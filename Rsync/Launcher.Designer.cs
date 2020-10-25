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
            this.downloadUpdates = new System.ComponentModel.BackgroundWorker();
            this.versionsnr = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.Label();
            this.version_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
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
            // versionsnr
            // 
            this.versionsnr.AutoSize = true;
            this.versionsnr.BackColor = System.Drawing.Color.Transparent;
            this.versionsnr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionsnr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.versionsnr.Location = new System.Drawing.Point(863, 506);
            this.versionsnr.Name = "versionsnr";
            this.versionsnr.Size = new System.Drawing.Size(31, 13);
            this.versionsnr.TabIndex = 15;
            this.versionsnr.Text = "1.5T";
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.BackColor = System.Drawing.Color.Transparent;
            this.sm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sm.Location = new System.Drawing.Point(48, 491);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(93, 18);
            this.sm.TabIndex = 16;
            this.sm.Text = "SoundMod";
            this.sm.UseVisualStyleBackColor = false;
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
            // version_txt
            // 
            this.version_txt.AutoSize = true;
            this.version_txt.BackColor = System.Drawing.Color.Transparent;
            this.version_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.version_txt.Location = new System.Drawing.Point(270, 492);
            this.version_txt.Name = "version_txt";
            this.version_txt.Size = new System.Drawing.Size(56, 14);
            this.version_txt.TabIndex = 18;
            this.version_txt.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(71, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExtremLauncher.Properties.Resources.Launcherextrem_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.version_txt);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.versionsnr);
            this.Controls.Add(this.status);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartGameButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.ComponentModel.BackgroundWorker downloadUpdates;
        private System.Windows.Forms.Label versionsnr;
        private System.Windows.Forms.CheckBox sm;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label version_txt;
        private System.Windows.Forms.Label label1;
    }
}

