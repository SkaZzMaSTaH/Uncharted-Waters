namespace Text_Packer
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.CaptionDataFile = new System.Windows.Forms.Label();
            this.TBoxDataFile = new System.Windows.Forms.TextBox();
            this.BtnOpenDataFile = new System.Windows.Forms.Button();
            this.BtnOpenTextFile = new System.Windows.Forms.Button();
            this.TBoxTextFile = new System.Windows.Forms.TextBox();
            this.CaptionTextFile = new System.Windows.Forms.Label();
            this.GBoxFiles = new System.Windows.Forms.GroupBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.RBtn32Bits = new System.Windows.Forms.RadioButton();
            this.BtnExtract = new System.Windows.Forms.Button();
            this.RBtn16Bits = new System.Windows.Forms.RadioButton();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.TitleInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.GBoxFiles.SuspendLayout();
            this.MainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptionDataFile
            // 
            this.CaptionDataFile.AutoSize = true;
            this.CaptionDataFile.Location = new System.Drawing.Point(7, 22);
            this.CaptionDataFile.Name = "CaptionDataFile";
            this.CaptionDataFile.Size = new System.Drawing.Size(49, 13);
            this.CaptionDataFile.TabIndex = 0;
            this.CaptionDataFile.Text = "Data file:";
            // 
            // TBoxDataFile
            // 
            this.TBoxDataFile.Location = new System.Drawing.Point(62, 19);
            this.TBoxDataFile.Name = "TBoxDataFile";
            this.TBoxDataFile.Size = new System.Drawing.Size(315, 20);
            this.TBoxDataFile.TabIndex = 1;
            // 
            // BtnOpenDataFile
            // 
            this.BtnOpenDataFile.Image = global::Text_Packer.Properties.Resources._049_folder_open;
            this.BtnOpenDataFile.Location = new System.Drawing.Point(383, 18);
            this.BtnOpenDataFile.Name = "BtnOpenDataFile";
            this.BtnOpenDataFile.Size = new System.Drawing.Size(22, 22);
            this.BtnOpenDataFile.TabIndex = 2;
            this.BtnOpenDataFile.UseVisualStyleBackColor = true;
            this.BtnOpenDataFile.Click += new System.EventHandler(this.BtnOpenDataFile_Click);
            // 
            // BtnOpenTextFile
            // 
            this.BtnOpenTextFile.Image = global::Text_Packer.Properties.Resources._049_folder_open;
            this.BtnOpenTextFile.Location = new System.Drawing.Point(383, 46);
            this.BtnOpenTextFile.Name = "BtnOpenTextFile";
            this.BtnOpenTextFile.Size = new System.Drawing.Size(22, 22);
            this.BtnOpenTextFile.TabIndex = 5;
            this.BtnOpenTextFile.UseVisualStyleBackColor = true;
            this.BtnOpenTextFile.Click += new System.EventHandler(this.BtnOpenTextFile_Click);
            // 
            // TBoxTextFile
            // 
            this.TBoxTextFile.Location = new System.Drawing.Point(62, 47);
            this.TBoxTextFile.Name = "TBoxTextFile";
            this.TBoxTextFile.Size = new System.Drawing.Size(315, 20);
            this.TBoxTextFile.TabIndex = 4;
            // 
            // CaptionTextFile
            // 
            this.CaptionTextFile.AutoSize = true;
            this.CaptionTextFile.Location = new System.Drawing.Point(9, 50);
            this.CaptionTextFile.Name = "CaptionTextFile";
            this.CaptionTextFile.Size = new System.Drawing.Size(47, 13);
            this.CaptionTextFile.TabIndex = 3;
            this.CaptionTextFile.Text = "Text file:";
            // 
            // GBoxFiles
            // 
            this.GBoxFiles.Controls.Add(this.BtnInsert);
            this.GBoxFiles.Controls.Add(this.RBtn32Bits);
            this.GBoxFiles.Controls.Add(this.BtnExtract);
            this.GBoxFiles.Controls.Add(this.RBtn16Bits);
            this.GBoxFiles.Controls.Add(this.CaptionTextFile);
            this.GBoxFiles.Controls.Add(this.BtnOpenTextFile);
            this.GBoxFiles.Controls.Add(this.CaptionDataFile);
            this.GBoxFiles.Controls.Add(this.TBoxTextFile);
            this.GBoxFiles.Controls.Add(this.TBoxDataFile);
            this.GBoxFiles.Controls.Add(this.BtnOpenDataFile);
            this.GBoxFiles.Location = new System.Drawing.Point(12, 12);
            this.GBoxFiles.Name = "GBoxFiles";
            this.GBoxFiles.Size = new System.Drawing.Size(417, 162);
            this.GBoxFiles.TabIndex = 6;
            this.GBoxFiles.TabStop = false;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(212, 118);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(198, 31);
            this.BtnInsert.TabIndex = 9;
            this.BtnInsert.Text = "Insert texts";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // RBtn32Bits
            // 
            this.RBtn32Bits.AutoSize = true;
            this.RBtn32Bits.Location = new System.Drawing.Point(281, 82);
            this.RBtn32Bits.Name = "RBtn32Bits";
            this.RBtn32Bits.Size = new System.Drawing.Size(57, 17);
            this.RBtn32Bits.TabIndex = 11;
            this.RBtn32Bits.Text = "32 Bits";
            this.RBtn32Bits.UseVisualStyleBackColor = true;
            // 
            // BtnExtract
            // 
            this.BtnExtract.Location = new System.Drawing.Point(8, 118);
            this.BtnExtract.Name = "BtnExtract";
            this.BtnExtract.Size = new System.Drawing.Size(198, 31);
            this.BtnExtract.TabIndex = 8;
            this.BtnExtract.Text = "Extract texts";
            this.BtnExtract.UseVisualStyleBackColor = true;
            this.BtnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // RBtn16Bits
            // 
            this.RBtn16Bits.AutoSize = true;
            this.RBtn16Bits.Checked = true;
            this.RBtn16Bits.Location = new System.Drawing.Point(78, 82);
            this.RBtn16Bits.Name = "RBtn16Bits";
            this.RBtn16Bits.Size = new System.Drawing.Size(57, 17);
            this.RBtn16Bits.TabIndex = 10;
            this.RBtn16Bits.TabStop = true;
            this.RBtn16Bits.Text = "16 Bits";
            this.RBtn16Bits.UseVisualStyleBackColor = true;
            // 
            // MainStatus
            // 
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitleInfo});
            this.MainStatus.Location = new System.Drawing.Point(0, 177);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Size = new System.Drawing.Size(441, 22);
            this.MainStatus.SizingGrip = false;
            this.MainStatus.TabIndex = 7;
            // 
            // TitleInfo
            // 
            this.TitleInfo.Name = "TitleInfo";
            this.TitleInfo.Size = new System.Drawing.Size(60, 17);
            this.TitleInfo.Text = "Welcome!";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 199);
            this.Controls.Add(this.MainStatus);
            this.Controls.Add(this.GBoxFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Packer";
            this.GBoxFiles.ResumeLayout(false);
            this.GBoxFiles.PerformLayout();
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaptionDataFile;
        private System.Windows.Forms.TextBox TBoxDataFile;
        private System.Windows.Forms.Button BtnOpenDataFile;
        private System.Windows.Forms.Button BtnOpenTextFile;
        private System.Windows.Forms.TextBox TBoxTextFile;
        private System.Windows.Forms.Label CaptionTextFile;
        private System.Windows.Forms.GroupBox GBoxFiles;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnExtract;
        private System.Windows.Forms.RadioButton RBtn32Bits;
        private System.Windows.Forms.RadioButton RBtn16Bits;
        private System.Windows.Forms.StatusStrip MainStatus;
        private System.Windows.Forms.ToolStripStatusLabel TitleInfo;
    }
}

