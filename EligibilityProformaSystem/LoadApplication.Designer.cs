namespace EligibilityProformaSystem
{
    partial class LoadApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadApplication));
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.ApplicationProgressBar = new System.Windows.Forms.ProgressBar();
            this.ApplicationImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Enabled = true;
            this.ProgressTimer.Interval = 32;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // ApplicationProgressBar
            // 
            this.ApplicationProgressBar.Location = new System.Drawing.Point(25, 220);
            this.ApplicationProgressBar.Name = "ApplicationProgressBar";
            this.ApplicationProgressBar.Size = new System.Drawing.Size(539, 23);
            this.ApplicationProgressBar.TabIndex = 0;
            // 
            // ApplicationImage
            // 
            this.ApplicationImage.Image = ((System.Drawing.Image)(resources.GetObject("ApplicationImage.Image")));
            this.ApplicationImage.Location = new System.Drawing.Point(97, 40);
            this.ApplicationImage.Name = "ApplicationImage";
            this.ApplicationImage.Size = new System.Drawing.Size(140, 128);
            this.ApplicationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApplicationImage.TabIndex = 1;
            this.ApplicationImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(255, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 68);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Eligibility Proforma  \r\n          System\r\n";
            // 
            // LoadApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(598, 264);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ApplicationImage);
            this.Controls.Add(this.ApplicationProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadApplication";
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.ProgressBar ApplicationProgressBar;
        private System.Windows.Forms.PictureBox ApplicationImage;
        private System.Windows.Forms.Label lblTitle;

    }
}