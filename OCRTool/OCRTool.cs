﻿using System;
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

            cbLag.Items.Clear();
            cbLag.DisplayMember = "Name";
            cbLag.ValueMember = "Key";

            cbLag.Items.Add(new { Name = "英文", Key = "eng" });
            cbLag.Items.Add(new { Name = "中文", Key = "chi_tra" });
            cbLag.Items.Add(new { Name = "日文", Key = "jpn" });
            cbLag.Items.Add(new { Name = "藏文", Key = "bod" });
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
                else
                    pbImage.Image = new Bitmap(labDataPath.Text);
            }
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            if (File.Exists(labDataPath.Text))
            {
                tbOCRStr.Text = string.Empty;

                //取得圖片bitmap檔
                //Bitmap resultBitmapt = Bitmap2Monochrome.ConvertTo1Bit(new Bitmap(labDataPath.Text));
                Bitmap resultBitmapt = new Bitmap(labDataPath.Text);

                ////存取成tif的路徑
                //string tifFile = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory + "test", ".tif");

                ////把圖片轉存成tif檔
                //resultBitmapt.Save(tifFile, System.Drawing.Imaging.ImageFormat.Tiff);

                //OCR元件路徑
                string octData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");

                if (cbLag.SelectedItem == null)
                {
                    MessageBox.Show("請選擇語系");
                    return;
                }

                var key = (cbLag.SelectedItem as dynamic).Key;

                //OCR辨識 jpn:日文 chi_tra:中文 eng:英文 bod:藏文
                using (TesseractEngine tesseractEngine = new TesseractEngine(octData, key, EngineMode.Default))
                {
                    //全彩掃描
                    using (Bitmap bitmap = new Bitmap(labDataPath.Text))
                    {
                        btnOCR.Enabled = false;
                        using (Page page = tesseractEngine.Process(bitmap, PageSegMode.Auto))
                        {
                            string text = page.GetText().Trim();
                            tbOCRStr.Text = text;
                        }
                        btnOCR.Enabled = true;
                    }
                }
            }
            else
                MessageBox.Show("請選擇正確的檔案。");
        }

    }
}
