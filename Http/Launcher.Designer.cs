namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartGameButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.downloadUpdates = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.dlp = new System.Windows.Forms.PictureBox();
            this.prozent = new System.Windows.Forms.Label();
            this.mbs = new System.Windows.Forms.Label();
            this.versionsnr = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.CheckBox();
            this.updateb = new System.Windows.Forms.PictureBox();
            this.version_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateb)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.Enabled = false;
            this.StartGameButton.Image = global::ExtremLauncher.Properties.Resources.extrem_nonstart;
            this.StartGameButton.InitialImage = global::ExtremLauncher.Properties.Resources.extrem_nonstart;
            this.StartGameButton.Location = new System.Drawing.Point(161, 105);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(340, 80);
            this.StartGameButton.TabIndex = 7;
            this.StartGameButton.TabStop = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGamebtn_Click);
            this.StartGameButton.MouseLeave += new System.EventHandler(this.StartGamebtn_MouseEnter);
            this.StartGameButton.MouseHover += new System.EventHandler(this.StartGamebtn_MouseHover);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = global::ExtremLauncher.Properties.Resources.exit_off;
            this.CloseButton.InitialImage = global::ExtremLauncher.Properties.Resources.exit_off;
            this.CloseButton.Location = new System.Drawing.Point(12, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(55, 42);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.Closebtn_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Closebtn_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.Closebtn_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.Closebtn_MouseLeave);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(32, 432);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(327, 23);
            this.downloadProgress.TabIndex = 10;
            this.downloadProgress.Visible = false;
            // 
            // downloadUpdates
            // 
            this.downloadUpdates.WorkerReportsProgress = true;
            this.downloadUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadUpdates_DoWork);
            this.downloadUpdates.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.downloadUpdates_ProgressChanged);
            this.downloadUpdates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.downloadUpdates_RunWorkerCompleted);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.status.Location = new System.Drawing.Point(71, 329);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 14);
            this.status.TabIndex = 11;
            // 
            // dlp
            // 
            this.dlp.BackColor = System.Drawing.Color.Transparent;
            this.dlp.Location = new System.Drawing.Point(27, 474);
            this.dlp.Name = "dlp";
            this.dlp.Size = new System.Drawing.Size(338, 35);
            this.dlp.TabIndex = 12;
            this.dlp.TabStop = false;
            // 
            // prozent
            // 
            this.prozent.AutoSize = true;
            this.prozent.BackColor = System.Drawing.Color.Transparent;
            this.prozent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prozent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prozent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.prozent.Location = new System.Drawing.Point(331, 463);
            this.prozent.Name = "prozent";
            this.prozent.Size = new System.Drawing.Size(30, 13);
            this.prozent.TabIndex = 1;
            this.prozent.Text = "0 %";
            this.prozent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mbs
            // 
            this.mbs.AutoSize = true;
            this.mbs.BackColor = System.Drawing.Color.Transparent;
            this.mbs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mbs.Location = new System.Drawing.Point(167, 463);
            this.mbs.Name = "mbs";
            this.mbs.Size = new System.Drawing.Size(82, 13);
            this.mbs.TabIndex = 14;
            this.mbs.Text = "0MB von 0MB";
            this.mbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionsnr
            // 
            this.versionsnr.AutoSize = true;
            this.versionsnr.BackColor = System.Drawing.Color.Transparent;
            this.versionsnr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionsnr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.versionsnr.Location = new System.Drawing.Point(863, 506);
            this.versionsnr.Name = "versionsnr";
            this.versionsnr.Size = new System.Drawing.Size(24, 13);
            this.versionsnr.TabIndex = 15;
            this.versionsnr.Text = "1.3";
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.BackColor = System.Drawing.Color.Transparent;
            this.sm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sm.Location = new System.Drawing.Point(557, 491);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(93, 18);
            this.sm.TabIndex = 16;
            this.sm.Text = "SoundMod";
            this.sm.UseVisualStyleBackColor = false;
            // 
            // updateb
            // 
            this.updateb.BackColor = System.Drawing.Color.Transparent;
            this.updateb.Enabled = false;
            this.updateb.Image = global::ExtremLauncher.Properties.Resources.update;
            this.updateb.InitialImage = global::ExtremLauncher.Properties.Resources.extrem_nonstart;
            this.updateb.Location = new System.Drawing.Point(407, 467);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(94, 42);
            this.updateb.TabIndex = 17;
            this.updateb.TabStop = false;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            this.updateb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateb_MouseDown);
            this.updateb.MouseEnter += new System.EventHandler(this.updateb_MouseEnter);
            this.updateb.MouseLeave += new System.EventHandler(this.updateb_MouseLeave);
            // 
            // version_txt
            // 
            this.version_txt.AutoSize = true;
            this.version_txt.BackColor = System.Drawing.Color.Transparent;
            this.version_txt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.version_txt.Location = new System.Drawing.Point(294, 283);
            this.version_txt.Name = "version_txt";
            this.version_txt.Size = new System.Drawing.Size(52, 13);
            this.version_txt.TabIndex = 18;
            this.version_txt.Text = "Version:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExtremLauncher.Properties.Resources.Launcherextrem_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 523);
            this.Controls.Add(this.version_txt);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.versionsnr);
            this.Controls.Add(this.mbs);
            this.Controls.Add(this.prozent);
            this.Controls.Add(this.dlp);
            this.Controls.Add(this.status);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartGameButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayZ Extrem Launcher";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titelLeiste_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titelLeiste_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.StartGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartGameButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.ComponentModel.BackgroundWorker downloadUpdates;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox dlp;
        private System.Windows.Forms.Label prozent;
        private System.Windows.Forms.Label mbs;
        private System.Windows.Forms.Label versionsnr;
        private System.Windows.Forms.CheckBox sm;
        private System.Windows.Forms.PictureBox updateb;
        private System.Windows.Forms.Label version_txt;
    }
}

