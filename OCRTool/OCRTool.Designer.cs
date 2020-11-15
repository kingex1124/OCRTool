namespace OCRTool
{
    partial class OCRTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.labDataPath = new System.Windows.Forms.Label();
            this.labPathShow = new System.Windows.Forms.Label();
            this.tbOCRStr = new System.Windows.Forms.TextBox();
            this.btnOCR = new System.Windows.Forms.Button();
            this.cbLag = new System.Windows.Forms.ComboBox();
            this.labLag = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Location = new System.Drawing.Point(28, 33);
            this.btnOpenImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(104, 84);
            this.btnOpenImg.TabIndex = 0;
            this.btnOpenImg.Text = "開啟圖片";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // labDataPath
            // 
            this.labDataPath.AutoSize = true;
            this.labDataPath.Font = new System.Drawing.Font("新細明體", 15F);
            this.labDataPath.Location = new System.Drawing.Point(158, 87);
            this.labDataPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDataPath.Name = "labDataPath";
            this.labDataPath.Size = new System.Drawing.Size(115, 30);
            this.labDataPath.TabIndex = 1;
            this.labDataPath.Text = "DataAdd";
            // 
            // labPathShow
            // 
            this.labPathShow.AutoSize = true;
            this.labPathShow.Font = new System.Drawing.Font("新細明體", 15F);
            this.labPathShow.Location = new System.Drawing.Point(158, 33);
            this.labPathShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPathShow.Name = "labPathShow";
            this.labPathShow.Size = new System.Drawing.Size(133, 30);
            this.labPathShow.TabIndex = 2;
            this.labPathShow.Text = "檔案位置";
            // 
            // tbOCRStr
            // 
            this.tbOCRStr.Font = new System.Drawing.Font("新細明體", 24F);
            this.tbOCRStr.Location = new System.Drawing.Point(28, 558);
            this.tbOCRStr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOCRStr.Multiline = true;
            this.tbOCRStr.Name = "tbOCRStr";
            this.tbOCRStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOCRStr.Size = new System.Drawing.Size(1130, 468);
            this.tbOCRStr.TabIndex = 3;
            // 
            // btnOCR
            // 
            this.btnOCR.Font = new System.Drawing.Font("新細明體", 9F);
            this.btnOCR.Location = new System.Drawing.Point(1183, 558);
            this.btnOCR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(98, 76);
            this.btnOCR.TabIndex = 4;
            this.btnOCR.Text = "OCR辨識";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // cbLag
            // 
            this.cbLag.FormattingEnabled = true;
            this.cbLag.Location = new System.Drawing.Point(902, 33);
            this.cbLag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLag.Name = "cbLag";
            this.cbLag.Size = new System.Drawing.Size(180, 26);
            this.cbLag.TabIndex = 5;
            this.cbLag.Text = "請選擇";
            // 
            // labLag
            // 
            this.labLag.AutoSize = true;
            this.labLag.Font = new System.Drawing.Font("新細明體", 15F);
            this.labLag.Location = new System.Drawing.Point(820, 33);
            this.labLag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLag.Name = "labLag";
            this.labLag.Size = new System.Drawing.Size(73, 30);
            this.labLag.TabIndex = 6;
            this.labLag.Text = "語系";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(755, 267);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Location = new System.Drawing.Point(28, 136);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 400);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnOpenImg);
            this.panel2.Controls.Add(this.tbOCRStr);
            this.panel2.Controls.Add(this.btnOCR);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.labDataPath);
            this.panel2.Controls.Add(this.labLag);
            this.panel2.Controls.Add(this.labPathShow);
            this.panel2.Controls.Add(this.cbLag);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 1049);
            this.panel2.TabIndex = 9;
            // 
            // OCRTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 1049);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OCRTool";
            this.Text = "OCRTool";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.Label labDataPath;
        private System.Windows.Forms.Label labPathShow;
        private System.Windows.Forms.TextBox tbOCRStr;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.ComboBox cbLag;
        private System.Windows.Forms.Label labLag;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}