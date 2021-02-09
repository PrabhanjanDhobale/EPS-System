namespace EligibilityProformaSystem
{
    partial class UpdatePlayerTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUpdatePlayer = new System.Windows.Forms.DataGridView();
            this.PRNNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSCPassingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourceYearAndClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionToCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionToCource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionToClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdatePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdatePlayer
            // 
            this.dgvUpdatePlayer.AllowUserToAddRows = false;
            this.dgvUpdatePlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpdatePlayer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvUpdatePlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdatePlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRNNumber,
            this.RollNumber,
            this.FullName,
            this.MotherName,
            this.DOB,
            this.HSCPassingYear,
            this.CourceYearAndClass,
            this.AdmissionToCollege,
            this.AdmissionToCource,
            this.AdmissionToClass,
            this.ContactNumber,
            this.Email});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpdatePlayer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUpdatePlayer.Location = new System.Drawing.Point(3, 3);
            this.dgvUpdatePlayer.Margin = new System.Windows.Forms.Padding(10);
            this.dgvUpdatePlayer.Name = "dgvUpdatePlayer";
            this.dgvUpdatePlayer.RowTemplate.Height = 24;
            this.dgvUpdatePlayer.Size = new System.Drawing.Size(1537, 746);
            this.dgvUpdatePlayer.TabIndex = 0;
            this.dgvUpdatePlayer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdatePlayer_CellValueChanged);
            // 
            // PRNNumber
            // 
            this.PRNNumber.DataPropertyName = "PRNNumber";
            this.PRNNumber.HeaderText = "PRN Number";
            this.PRNNumber.Name = "PRNNumber";
            // 
            // RollNumber
            // 
            this.RollNumber.DataPropertyName = "RollNumber";
            this.RollNumber.HeaderText = "Roll Number";
            this.RollNumber.Name = "RollNumber";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // MotherName
            // 
            this.MotherName.DataPropertyName = "MotherName";
            this.MotherName.HeaderText = "Mother Name";
            this.MotherName.Name = "MotherName";
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DateOfBirth";
            this.DOB.HeaderText = "Date Of Birth";
            this.DOB.Name = "DOB";
            // 
            // HSCPassingYear
            // 
            this.HSCPassingYear.DataPropertyName = "HSCPassingYear";
            this.HSCPassingYear.HeaderText = "HSC Passing Year";
            this.HSCPassingYear.Name = "HSCPassingYear";
            // 
            // CourceYearAndClass
            // 
            this.CourceYearAndClass.DataPropertyName = "CourceYearAndClass";
            this.CourceYearAndClass.HeaderText = "Cource Year And Class";
            this.CourceYearAndClass.Name = "CourceYearAndClass";
            // 
            // AdmissionToCollege
            // 
            this.AdmissionToCollege.DataPropertyName = "AdmissionToCollege";
            this.AdmissionToCollege.HeaderText = "Admission To College";
            this.AdmissionToCollege.Name = "AdmissionToCollege";
            // 
            // AdmissionToCource
            // 
            this.AdmissionToCource.DataPropertyName = "AdmissionToCource";
            this.AdmissionToCource.HeaderText = "Admission To Cource";
            this.AdmissionToCource.Name = "AdmissionToCource";
            // 
            // AdmissionToClass
            // 
            this.AdmissionToClass.DataPropertyName = "AdmissionToClass";
            this.AdmissionToClass.HeaderText = "Admission To Class";
            this.AdmissionToClass.Name = "AdmissionToClass";
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // UpdatePlayerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1548, 815);
            this.Controls.Add(this.dgvUpdatePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePlayerTable";
            this.Text = "UpdatePlayerTable";
            this.Load += new System.EventHandler(this.UpdatePlayerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdatePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdatePlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRNNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSCPassingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourceYearAndClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionToCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionToCource;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionToClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}