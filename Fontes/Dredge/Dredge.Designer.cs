namespace Dredge
{
    partial class Dredge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dredge));
            this.txtOPath = new System.Windows.Forms.TextBox();
            this.btnREAD = new System.Windows.Forms.Button();
            this.lstAllFiles = new System.Windows.Forms.ListBox();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.txtDPath = new System.Windows.Forms.TextBox();
            this.btnCOPY = new System.Windows.Forms.Button();
            this.pgbCOPY = new System.Windows.Forms.ProgressBar();
            this.fbdRead = new System.Windows.Forms.FolderBrowserDialog();
            this.filesType = new System.Windows.Forms.GroupBox();
            this.chkGIF = new System.Windows.Forms.CheckBox();
            this.txtYOURTYPE = new System.Windows.Forms.TextBox();
            this.chkYOURTYPE = new System.Windows.Forms.CheckBox();
            this.chkBMP = new System.Windows.Forms.CheckBox();
            this.chkPNG = new System.Windows.Forms.CheckBox();
            this.chkJPEG = new System.Windows.Forms.CheckBox();
            this.chkJPG = new System.Windows.Forms.CheckBox();
            this.chkALL = new System.Windows.Forms.CheckBox();
            this.fbdCopy = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFilesLeft = new System.Windows.Forms.Label();
            this.chkRemove = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.bgwCopy = new System.ComponentModel.BackgroundWorker();
            this.bgwRead = new System.ComponentModel.BackgroundWorker();
            this.pgbREAD = new System.Windows.Forms.ProgressBar();
            this.filesType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOPath
            // 
            this.txtOPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOPath.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPath.Location = new System.Drawing.Point(15, 12);
            this.txtOPath.Name = "txtOPath";
            this.txtOPath.Size = new System.Drawing.Size(352, 24);
            this.txtOPath.TabIndex = 0;
            this.txtOPath.Click += new System.EventHandler(this.txtOPath_TextClick);
            // 
            // btnREAD
            // 
            this.btnREAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnREAD.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREAD.Location = new System.Drawing.Point(381, 9);
            this.btnREAD.MaximumSize = new System.Drawing.Size(87, 27);
            this.btnREAD.MinimumSize = new System.Drawing.Size(87, 27);
            this.btnREAD.Name = "btnREAD";
            this.btnREAD.Size = new System.Drawing.Size(87, 27);
            this.btnREAD.TabIndex = 1;
            this.btnREAD.Text = "READ";
            this.btnREAD.UseVisualStyleBackColor = true;
            this.btnREAD.Click += new System.EventHandler(this.btnREAD_Click);
            // 
            // lstAllFiles
            // 
            this.lstAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAllFiles.FormattingEnabled = true;
            this.lstAllFiles.ItemHeight = 15;
            this.lstAllFiles.Location = new System.Drawing.Point(14, 80);
            this.lstAllFiles.Name = "lstAllFiles";
            this.lstAllFiles.Size = new System.Drawing.Size(353, 184);
            this.lstAllFiles.TabIndex = 2;
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(12, 283);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(112, 17);
            this.lblTotalFiles.TabIndex = 3;
            this.lblTotalFiles.Text = "Total Files: 000000";
            this.lblTotalFiles.Visible = false;
            // 
            // txtDPath
            // 
            this.txtDPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDPath.Enabled = false;
            this.txtDPath.Location = new System.Drawing.Point(15, 313);
            this.txtDPath.Name = "txtDPath";
            this.txtDPath.Size = new System.Drawing.Size(352, 24);
            this.txtDPath.TabIndex = 4;
            this.txtDPath.Click += new System.EventHandler(this.txtDPath_TextClick);
            // 
            // btnCOPY
            // 
            this.btnCOPY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOPY.Enabled = false;
            this.btnCOPY.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOPY.Location = new System.Drawing.Point(381, 314);
            this.btnCOPY.MaximumSize = new System.Drawing.Size(87, 27);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(87, 23);
            this.btnCOPY.TabIndex = 5;
            this.btnCOPY.Text = "COPY";
            this.btnCOPY.UseVisualStyleBackColor = true;
            this.btnCOPY.Click += new System.EventHandler(this.btnCOPY_Click);
            // 
            // pgbCOPY
            // 
            this.pgbCOPY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbCOPY.Enabled = false;
            this.pgbCOPY.Location = new System.Drawing.Point(15, 343);
            this.pgbCOPY.Name = "pgbCOPY";
            this.pgbCOPY.Size = new System.Drawing.Size(453, 23);
            this.pgbCOPY.Step = 1;
            this.pgbCOPY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbCOPY.TabIndex = 6;
            // 
            // fbdRead
            // 
            this.fbdRead.SelectedPath = "C:\\";
            // 
            // filesType
            // 
            this.filesType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesType.BackColor = System.Drawing.SystemColors.Control;
            this.filesType.Controls.Add(this.chkGIF);
            this.filesType.Controls.Add(this.txtYOURTYPE);
            this.filesType.Controls.Add(this.chkYOURTYPE);
            this.filesType.Controls.Add(this.chkBMP);
            this.filesType.Controls.Add(this.chkPNG);
            this.filesType.Controls.Add(this.chkJPEG);
            this.filesType.Controls.Add(this.chkJPG);
            this.filesType.Controls.Add(this.chkALL);
            this.filesType.Font = new System.Drawing.Font("Calibri", 8F);
            this.filesType.ForeColor = System.Drawing.Color.Black;
            this.filesType.Location = new System.Drawing.Point(381, 80);
            this.filesType.Name = "filesType";
            this.filesType.Size = new System.Drawing.Size(87, 184);
            this.filesType.TabIndex = 7;
            this.filesType.TabStop = false;
            this.filesType.Text = "Files";
            // 
            // chkGIF
            // 
            this.chkGIF.AutoSize = true;
            this.chkGIF.Location = new System.Drawing.Point(6, 134);
            this.chkGIF.Name = "chkGIF";
            this.chkGIF.Size = new System.Drawing.Size(41, 17);
            this.chkGIF.TabIndex = 7;
            this.chkGIF.Text = "GIF";
            this.chkGIF.UseVisualStyleBackColor = true;
            this.chkGIF.CheckedChanged += new System.EventHandler(this.chkALL_UnCheck);
            // 
            // txtYOURTYPE
            // 
            this.txtYOURTYPE.Location = new System.Drawing.Point(24, 157);
            this.txtYOURTYPE.Name = "txtYOURTYPE";
            this.txtYOURTYPE.Size = new System.Drawing.Size(58, 21);
            this.txtYOURTYPE.TabIndex = 6;
            // 
            // chkYOURTYPE
            // 
            this.chkYOURTYPE.AutoSize = true;
            this.chkYOURTYPE.Location = new System.Drawing.Point(6, 160);
            this.chkYOURTYPE.Name = "chkYOURTYPE";
            this.chkYOURTYPE.Size = new System.Drawing.Size(15, 14);
            this.chkYOURTYPE.TabIndex = 5;
            this.chkYOURTYPE.UseVisualStyleBackColor = true;
            this.chkYOURTYPE.CheckedChanged += new System.EventHandler(this.chkALL_UnCheck);
            // 
            // chkBMP
            // 
            this.chkBMP.AutoSize = true;
            this.chkBMP.Location = new System.Drawing.Point(6, 113);
            this.chkBMP.Name = "chkBMP";
            this.chkBMP.Size = new System.Drawing.Size(47, 17);
            this.chkBMP.TabIndex = 4;
            this.chkBMP.Text = "BMP";
            this.chkBMP.UseVisualStyleBackColor = true;
            this.chkBMP.CheckedChanged += new System.EventHandler(this.chkALL_UnCheck);
            // 
            // chkPNG
            // 
            this.chkPNG.AutoSize = true;
            this.chkPNG.Location = new System.Drawing.Point(6, 90);
            this.chkPNG.Name = "chkPNG";
            this.chkPNG.Size = new System.Drawing.Size(46, 17);
            this.chkPNG.TabIndex = 3;
            this.chkPNG.Text = "PNG";
            this.chkPNG.UseVisualStyleBackColor = true;
            this.chkPNG.CheckedChanged += new System.EventHandler(this.chkALL_UnCheck);
            // 
            // chkJPEG
            // 
            this.chkJPEG.AutoSize = true;
            this.chkJPEG.Location = new System.Drawing.Point(6, 67);
            this.chkJPEG.Name = "chkJPEG";
            this.chkJPEG.Size = new System.Drawing.Size(48, 17);
            this.chkJPEG.TabIndex = 2;
            this.chkJPEG.Text = "JPEG";
            this.chkJPEG.UseVisualStyleBackColor = true;
            this.chkJPEG.CheckedChanged += new System.EventHandler(this.chkALL_UnCheck);
            // 
            // chkJPG
            // 
            this.chkJPG.AutoSize = true;
            this.chkJPG.Location = new System.Drawing.Point(6, 44);
            this.chkJPG.Name = "chkJPG";
            this.chkJPG.Size = new System.Drawing.Size(43, 17);
            this.chkJPG.TabIndex = 1;
            this.chkJPG.Text = "JPG";
            this.chkJPG.UseVisualStyleBackColor = true;
            this.chkJPG.CheckedChanged += new System.EventHandler(this.chkALL_UnCheck);
            // 
            // chkALL
            // 
            this.chkALL.AutoSize = true;
            this.chkALL.Checked = true;
            this.chkALL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkALL.Location = new System.Drawing.Point(6, 21);
            this.chkALL.Name = "chkALL";
            this.chkALL.Size = new System.Drawing.Size(42, 17);
            this.chkALL.TabIndex = 0;
            this.chkALL.Text = "ALL";
            this.chkALL.UseVisualStyleBackColor = true;
            this.chkALL.CheckedChanged += new System.EventHandler(this.chkALL_CheckedChanged);
            // 
            // fbdCopy
            // 
            this.fbdCopy.SelectedPath = "C:\\";
            // 
            // lblFilesLeft
            // 
            this.lblFilesLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilesLeft.AutoSize = true;
            this.lblFilesLeft.Location = new System.Drawing.Point(137, 283);
            this.lblFilesLeft.Name = "lblFilesLeft";
            this.lblFilesLeft.Size = new System.Drawing.Size(106, 17);
            this.lblFilesLeft.TabIndex = 8;
            this.lblFilesLeft.Text = "Files Left: 000000";
            this.lblFilesLeft.Visible = false;
            // 
            // chkRemove
            // 
            this.chkRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRemove.AutoSize = true;
            this.chkRemove.Enabled = false;
            this.chkRemove.Location = new System.Drawing.Point(249, 281);
            this.chkRemove.Name = "chkRemove";
            this.chkRemove.Size = new System.Drawing.Size(72, 21);
            this.chkRemove.TabIndex = 9;
            this.chkRemove.Text = "Replace";
            this.chkRemove.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(327, 280);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(141, 24);
            this.txtFileName.TabIndex = 10;
            // 
            // bgwCopy
            // 
            this.bgwCopy.WorkerReportsProgress = true;
            this.bgwCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCopy_DoWork);
            this.bgwCopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCopy_ProgressChanged);
            this.bgwCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCopy_RunWorkerCompleted);
            // 
            // bgwRead
            // 
            this.bgwRead.WorkerReportsProgress = true;
            this.bgwRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRead_DoWork);
            this.bgwRead.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRead_ProgressChanged);
            this.bgwRead.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRead_RunWorkerCompleted);
            // 
            // pgbREAD
            // 
            this.pgbREAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbREAD.Location = new System.Drawing.Point(14, 45);
            this.pgbREAD.MarqueeAnimationSpeed = 1;
            this.pgbREAD.Name = "pgbREAD";
            this.pgbREAD.Size = new System.Drawing.Size(454, 23);
            this.pgbREAD.Step = 1;
            this.pgbREAD.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbREAD.TabIndex = 11;
            // 
            // Dredge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 379);
            this.Controls.Add(this.pgbREAD);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.chkRemove);
            this.Controls.Add(this.lblFilesLeft);
            this.Controls.Add(this.filesType);
            this.Controls.Add(this.pgbCOPY);
            this.Controls.Add(this.btnCOPY);
            this.Controls.Add(this.txtDPath);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.lstAllFiles);
            this.Controls.Add(this.btnREAD);
            this.Controls.Add(this.txtOPath);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(499, 381);
            this.Name = "Dredge";
            this.Text = "Dredge 0.1";
            this.filesType.ResumeLayout(false);
            this.filesType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOPath;
        private System.Windows.Forms.Button btnREAD;
        private System.Windows.Forms.ListBox lstAllFiles;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.TextBox txtDPath;
        private System.Windows.Forms.Button btnCOPY;
        private System.Windows.Forms.ProgressBar pgbCOPY;
        private System.Windows.Forms.FolderBrowserDialog fbdRead;
        private System.Windows.Forms.GroupBox filesType;
        private System.Windows.Forms.CheckBox chkGIF;
        private System.Windows.Forms.TextBox txtYOURTYPE;
        private System.Windows.Forms.CheckBox chkYOURTYPE;
        private System.Windows.Forms.CheckBox chkBMP;
        private System.Windows.Forms.CheckBox chkPNG;
        private System.Windows.Forms.CheckBox chkJPG;
        private System.Windows.Forms.CheckBox chkALL;
        private System.Windows.Forms.CheckBox chkJPEG;
        private System.Windows.Forms.FolderBrowserDialog fbdCopy;
        private System.Windows.Forms.Label lblFilesLeft;
        private System.Windows.Forms.CheckBox chkRemove;
        private System.Windows.Forms.TextBox txtFileName;
        private System.ComponentModel.BackgroundWorker bgwCopy;
        private System.ComponentModel.BackgroundWorker bgwRead;
        private System.Windows.Forms.ProgressBar pgbREAD;
    }
}

