using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OCRTool
{
    public class Bitmap2Monochrome
    {
        public Bitmap2Monochrome()
        {
        }

        public static Bitmap ConvertTo1Bit(Bitmap input)
        {
            byte[] masks = new byte[] { 128, 64, 32, 16, 8, 4, 2, 1 };
            Bitmap output = new Bitmap(input.Width, input.Height, PixelFormat.Format1bppIndexed);
            sbyte[,] data = new sbyte[input.Width, input.Height];
            BitmapData inputData = input.LockBits(new Rectangle(0, 0, input.Width, input.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try
            {
                IntPtr scanLine = inputData.Scan0;
                byte[] line = new byte[inputData.Stride];
                int y = 0;
                while (y < inputData.Height)
                {
                    Marshal.Copy(scanLine, line, 0, (int)line.Length);
                    for (int x = 0; x < input.Width; x++)
                    {
                        data[x, y] = (sbyte)(64 * (Bitmap2Monochrome.GetGreyLevel(line[x * 3 + 2], line[x * 3 + 1], line[x * 3]) - 0.5));
                    }
                    y++;
                    scanLine += inputData.Stride;
                }
            }
            finally
            {
                input.UnlockBits(inputData);
            }
            BitmapData outputData = output.LockBits(new Rectangle(0, 0, output.Width, output.Height), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
            try
            {
                IntPtr scanLine = outputData.Scan0;
                int y = 0;
                while (y < outputData.Height)
                {
                    byte[] line = new byte[outputData.Stride];
                    for (int x = 0; x < input.Width; x++)
                    {
                        bool j = data[x, y] > 0;
                        if (j)
                        {
                            ref byte numPointer = ref line[x / 8];
                            numPointer = (byte)(numPointer | masks[x % 8]);
                        }
                        sbyte error = (sbyte)(data[x, y] - (j ? 32 : -32));
                        if (x < input.Width - 1)
                        {
                            ref sbyte numPointer1 = ref data[x + 1, y];
                            numPointer1 = (sbyte)(numPointer1 + (sbyte)(7 * error / 16));
                        }
                        if (y < input.Height - 1)
                        {
                            if (x > 0)
                            {
                                ref sbyte numPointer2 = ref data[x - 1, y + 1];
                                numPointer2 = (sbyte)(numPointer2 + (sbyte)(3 * error / 16));
                            }
                            ref sbyte numPointer3 = ref data[x, y + 1];
                            numPointer3 = (sbyte)(numPointer3 + (sbyte)(5 * error / 16));
                            if (x < input.Width - 1)
                            {
                                ref sbyte numPointer4 = ref data[x + 1, y + 1];
                                numPointer4 = (sbyte)(numPointer4 + (sbyte)(error / 16));
                            }
                        }
                    }
                    Marshal.Copy(line, 0, scanLine, outputData.Stride);
                    y++;
                    scanLine += outputData.Stride;
                }
            }
            finally
            {
                output.UnlockBits(outputData);
            }
            return output;
        }

        public static double GetGreyLevel(byte r, byte g, byte b)
        {
            double num = ((double)r * 0.299 + (double)g * 0.587 + (double)b * 0.73) / 255;
            return num;
        }
    }
}
