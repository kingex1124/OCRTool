using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace OCRTool
{
    public partial class OCRTool : Form
    {
        public OCRTool()
        {
            InitializeComponent();
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.RestoreDirectory = true;
            dlg.Title = "請選取圖片";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != null)
            {
                labDataPath.Text = dlg.FileName;

                if (!File.Exists(labDataPath.Text))
                    MessageBox.Show("檔案不存在");
            }
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            if (File.Exists(labDataPath.Text))
            {
                tbOCRStr.Text = string.Empty;

                //取得圖片bitmap檔
                Bitmap resultBitmapt = Bitmap2Monochrome.ConvertTo1Bit(new Bitmap(labDataPath.Text));

                //OCR元件路徑
                string octData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");

                //OCR辨識 jpn:日文 chi_tra:中文 eng:英文 bod:藏文
                using (TesseractEngine tesseractEngine = new TesseractEngine(octData, cbLag.Text, EngineMode.Default))
                {
                    //全彩掃描
                    using (Bitmap bitmap = new Bitmap(labDataPath.Text))
                    {
                        using (Page page = tesseractEngine.Process(bitmap, null))
                        {
                            string text = page.GetText().Trim();
                            tbOCRStr.Text = text;
                        }
                    }
                }
            }
        }

    }
}
