using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRTool
{
    public class BitmapCustom
    {
        private static string _currentDecFileName;

        private static MyImageFormat _currentImageType;

        public static string CurrentDecFileName
        {
            get
            {
                string str;
                str = (!string.IsNullOrEmpty(BitmapCustom._currentDecFileName) ? Path.Combine(Environment.GetEnvironmentVariable("TEMP"), string.Format("{0}.{1}", Path.GetFileName(BitmapCustom._currentDecFileName), BitmapCustom.getImageExtenssion(BitmapCustom._currentImageType))) : string.Empty);
                return str;
            }
        }

        static BitmapCustom()
        {
            BitmapCustom._currentDecFileName = string.Empty;
            BitmapCustom._currentImageType = MyImageFormat.Jpeg;
        }

        public BitmapCustom()
        {
        }

        public static string getImageExtenssion(MyImageFormat imgFormat)
        {
            string str;
            MyImageFormat myImageFormat = imgFormat;
            switch (myImageFormat)
            {
                case MyImageFormat.Jpeg:
                    {
                        str = "jpg";
                        break;
                    }
                case MyImageFormat.Png:
                    {
                        str = "png";
                        break;
                    }
                case MyImageFormat.Tiff:
                    {
                        str = "tif";
                        break;
                    }
                default:
                    {
                        if (myImageFormat == MyImageFormat.Gif)
                        {
                            str = "gif";
                            break;
                        }
                        else
                        {
                            str = "jpg";
                            break;
                        }
                    }
            }
            return str;
        }

        public static MyImageFormat getImageTypeByFileEx(string fileEx)
        {
            MyImageFormat myImageFormat;
            string upper = fileEx.ToUpper();
            if (upper == ".JPG")
            {
                myImageFormat = MyImageFormat.Jpeg;
            }
            else if (upper == ".GIF")
            {
                myImageFormat = MyImageFormat.Gif;
            }
            else if (upper == ".PNG")
            {
                myImageFormat = MyImageFormat.Png;
            }
            else
            {
                myImageFormat = (upper == ".TIF" ? MyImageFormat.Tiff : MyImageFormat.Jpeg);
            }
            return myImageFormat;
        }
    }
}
