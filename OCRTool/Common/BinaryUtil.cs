using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRTool
{
    public class BinaryUtil
    {
        public BinaryUtil()
        {
        }

        public static byte[] BinaryReadToEnd(Stream stream)
        {
            byte[] numArray;
            long position = (long)0;
            if (stream.CanSeek)
            {
                position = stream.Position;
                stream.Position = (long)0;
            }
            try
            {
                byte[] numArray1 = new byte[4096];
                int num = 0;
                while (true)
                {
                    int num1 = stream.Read(numArray1, num, (int)numArray1.Length - num);
                    int num2 = num1;
                    if (num1 <= 0)
                    {
                        break;
                    }
                    num += num2;
                    if (num == (int)numArray1.Length)
                    {
                        int num3 = stream.ReadByte();
                        if (num3 != -1)
                        {
                            byte[] numArray2 = new byte[(int)numArray1.Length * 2];
                            Buffer.BlockCopy(numArray1, 0, numArray2, 0, (int)numArray1.Length);
                            Buffer.SetByte(numArray2, num, (byte)num3);
                            numArray1 = numArray2;
                            num++;
                        }
                    }
                }
                byte[] numArray3 = numArray1;
                if ((int)numArray1.Length != num)
                {
                    numArray3 = new byte[num];
                    Buffer.BlockCopy(numArray1, 0, numArray3, 0, num);
                }
                numArray = numArray3;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = position;
                }
            }
            return numArray;
        }
    }
}
