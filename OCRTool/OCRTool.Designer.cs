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
            this.SuspendLayout();
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Location = new System.Drawing.Point(21, 16);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(69, 56);
            this.btnOpenImg.TabIndex = 0;
            this.btnOpenImg.Text = "開啟圖片";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // labDataPath
            // 
            this.labDataPath.AutoSize = true;
            this.labDataPath.Font = new System.Drawing.Font("新細明體", 15F);
            this.labDataPath.Location = new System.Drawing.Point(108, 52);
            this.labDataPath.Name = "labDataPath";
            this.labDataPath.Size = new System.Drawing.Size(76, 20);
            this.labDataPath.TabIndex = 1;
            this.labDataPath.Text = "DataAdd";
            // 
            // labPathShow
            // 
            this.labPathShow.AutoSize = true;
            this.labPathShow.Font = new System.Drawing.Font("新細明體", 15F);
            this.labPathShow.Location = new System.Drawing.Point(108, 16);
            this.labPathShow.Name = "labPathShow";
            this.labPathShow.Size = new System.Drawing.Size(89, 20);
            this.labPathShow.TabIndex = 2;
            this.labPathShow.Text = "檔案位置";
            // 
            // tbOCRStr
            // 
            this.tbOCRStr.Font = new System.Drawing.Font("新細明體", 24F);
            this.tbOCRStr.Location = new System.Drawing.Point(21, 78);
            this.tbOCRStr.Multiline = true;
            this.tbOCRStr.Name = "tbOCRStr";
            this.tbOCRStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOCRStr.Size = new System.Drawing.Size(755, 313);
            this.tbOCRStr.TabIndex = 3;
            // 
            // btnOCR
            // 
            this.btnOCR.Font = new System.Drawing.Font("新細明體", 9F);
            this.btnOCR.Location = new System.Drawing.Point(711, 397);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(65, 51);
            this.btnOCR.TabIndex = 4;
            this.btnOCR.Text = "OCR辨識";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // cbLag
            // 
            this.cbLag.FormattingEnabled = true;
            this.cbLag.Items.AddRange(new object[] {
            "eng",
            "chi",
            "jpn",
            "bod"});
            this.cbLag.Location = new System.Drawing.Point(528, 16);
            this.cbLag.Name = "cbLag";
            this.cbLag.Size = new System.Drawing.Size(121, 20);
            this.cbLag.TabIndex = 5;
            this.cbLag.Text = "eng";
            // 
            // labLag
            // 
            this.labLag.AutoSize = true;
            this.labLag.Font = new System.Drawing.Font("新細明體", 15F);
            this.labLag.Location = new System.Drawing.Point(473, 16);
            this.labLag.Name = "labLag";
            this.labLag.Size = new System.Drawing.Size(49, 20);
            this.labLag.TabIndex = 6;
            this.labLag.Text = "語系";
            // 
            // OCRTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labLag);
            this.Controls.Add(this.cbLag);
            this.Controls.Add(this.btnOCR);
            this.Controls.Add(this.tbOCRStr);
            this.Controls.Add(this.labPathShow);
            this.Controls.Add(this.labDataPath);
            this.Controls.Add(this.btnOpenImg);
            this.Name = "OCRTool";
            this.Text = "OCRTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.Label labDataPath;
        private System.Windows.Forms.Label labPathShow;
        private System.Windows.Forms.TextBox tbOCRStr;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.ComboBox cbLag;
        private System.Windows.Forms.Label labLag;
    }
}