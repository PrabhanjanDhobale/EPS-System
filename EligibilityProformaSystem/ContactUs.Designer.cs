namespace EligibilityProformaSystem
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            this.lblInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInformation.Location = new System.Drawing.Point(205, 246);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(1123, 288);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = resources.GetString("lblInformation.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(786, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 128);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Us :-\r\n\r\n1] Mail :- prabhanjandhobale99@gmail.com.\r\n2] Contact No :- 8766" +
    "553648.\r\n";
            // 
            // MyPhoto
            // 
            this.MyPhoto.Image = global::EligibilityProformaSystem.Properties.Resources.MyImage;
            this.MyPhoto.Location = new System.Drawing.Point(22, 23);
            this.MyPhoto.Name = "MyPhoto";
            this.MyPhoto.Size = new System.Drawing.Size(178, 194);
            this.MyPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPhoto.TabIndex = 0;
            this.MyPhoto.TabStop = false;
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1413, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.MyPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactUs";
            this.Text = "ContactUs";
            ((System.ComponentModel.ISupportInitialize)(this.MyPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MyPhoto;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label label1;
    }
}