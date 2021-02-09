namespace EligibilityProformaSystem
{
    partial class AddMatchInformation
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblNameOfParticipatingCollege = new System.Windows.Forms.Label();
            this.txtParticipatingCollege = new System.Windows.Forms.TextBox();
            this.lblNameOfOrganisingCollege = new System.Windows.Forms.Label();
            this.txtNameOfOrganisingCollege = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.TournamentDataGridView = new System.Windows.Forms.DataGridView();
            this.NameOfTournament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfParticipatingCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfOrganisigCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTournamentEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.TournamentStartDate = new System.Windows.Forms.DateTimePicker();
            this.TornamentEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(455, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 32);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Tournament Information";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTournamentName.Location = new System.Drawing.Point(99, 113);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(232, 25);
            this.lblTournamentName.TabIndex = 4;
            this.lblTournamentName.Text = "Name Of Tournament :";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtTournamentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTournamentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTournamentName.Location = new System.Drawing.Point(371, 108);
            this.txtTournamentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(821, 34);
            this.txtTournamentName.TabIndex = 0;
            this.txtTournamentName.Leave += new System.EventHandler(this.txtTournamentName_Leave);
            // 
            // lblNameOfParticipatingCollege
            // 
            this.lblNameOfParticipatingCollege.AutoSize = true;
            this.lblNameOfParticipatingCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfParticipatingCollege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblNameOfParticipatingCollege.Location = new System.Drawing.Point(16, 300);
            this.lblNameOfParticipatingCollege.Name = "lblNameOfParticipatingCollege";
            this.lblNameOfParticipatingCollege.Size = new System.Drawing.Size(315, 25);
            this.lblNameOfParticipatingCollege.TabIndex = 16;
            this.lblNameOfParticipatingCollege.Text = "Name Of Participating College :";
            // 
            // txtParticipatingCollege
            // 
            this.txtParticipatingCollege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtParticipatingCollege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParticipatingCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipatingCollege.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtParticipatingCollege.Location = new System.Drawing.Point(371, 295);
            this.txtParticipatingCollege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParticipatingCollege.Name = "txtParticipatingCollege";
            this.txtParticipatingCollege.Size = new System.Drawing.Size(821, 34);
            this.txtParticipatingCollege.TabIndex = 3;
            this.txtParticipatingCollege.Leave += new System.EventHandler(this.txtParticipatingCollege_Leave);
            // 
            // lblNameOfOrganisingCollege
            // 
            this.lblNameOfOrganisingCollege.AutoSize = true;
            this.lblNameOfOrganisingCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfOrganisingCollege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblNameOfOrganisingCollege.Location = new System.Drawing.Point(30, 402);
            this.lblNameOfOrganisingCollege.Name = "lblNameOfOrganisingCollege";
            this.lblNameOfOrganisingCollege.Size = new System.Drawing.Size(301, 25);
            this.lblNameOfOrganisingCollege.TabIndex = 18;
            this.lblNameOfOrganisingCollege.Text = "Name Of Organising College :";
            // 
            // txtNameOfOrganisingCollege
            // 
            this.txtNameOfOrganisingCollege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNameOfOrganisingCollege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameOfOrganisingCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfOrganisingCollege.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNameOfOrganisingCollege.Location = new System.Drawing.Point(371, 399);
            this.txtNameOfOrganisingCollege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameOfOrganisingCollege.Name = "txtNameOfOrganisingCollege";
            this.txtNameOfOrganisingCollege.Size = new System.Drawing.Size(821, 34);
            this.txtNameOfOrganisingCollege.TabIndex = 4;
            this.txtNameOfOrganisingCollege.Leave += new System.EventHandler(this.txtNameOfOrganisingCollege_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(576, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TournamentDataGridView
            // 
            this.TournamentDataGridView.AllowUserToAddRows = false;
            this.TournamentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TournamentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfTournament,
            this.NameOfParticipatingCollege,
            this.NameOfOrganisigCollege,
            this.StartDate,
            this.EndDate});
            this.TournamentDataGridView.Location = new System.Drawing.Point(43, 574);
            this.TournamentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TournamentDataGridView.Name = "TournamentDataGridView";
            this.TournamentDataGridView.RowTemplate.Height = 24;
            this.TournamentDataGridView.Size = new System.Drawing.Size(1204, 181);
            this.TournamentDataGridView.TabIndex = 6;
            // 
            // NameOfTournament
            // 
            this.NameOfTournament.HeaderText = "Name Of Tournament";
            this.NameOfTournament.Name = "NameOfTournament";
            // 
            // NameOfParticipatingCollege
            // 
            this.NameOfParticipatingCollege.HeaderText = "Name Of Participating College";
            this.NameOfParticipatingCollege.Name = "NameOfParticipatingCollege";
            // 
            // NameOfOrganisigCollege
            // 
            this.NameOfOrganisigCollege.HeaderText = "Name Of Organising College";
            this.NameOfOrganisigCollege.Name = "NameOfOrganisigCollege";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            // 
            // lblTournamentEndDate
            // 
            this.lblTournamentEndDate.AutoSize = true;
            this.lblTournamentEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTournamentEndDate.Location = new System.Drawing.Point(692, 208);
            this.lblTournamentEndDate.Name = "lblTournamentEndDate";
            this.lblTournamentEndDate.Size = new System.Drawing.Size(212, 25);
            this.lblTournamentEndDate.TabIndex = 30;
            this.lblTournamentEndDate.Text = "Tournament End At :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblStartDate.Location = new System.Drawing.Point(111, 209);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(220, 25);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Tournament Start At :";
            // 
            // TournamentStartDate
            // 
            this.TournamentStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TournamentStartDate.Location = new System.Drawing.Point(371, 204);
            this.TournamentStartDate.Name = "TournamentStartDate";
            this.TournamentStartDate.Size = new System.Drawing.Size(282, 30);
            this.TournamentStartDate.TabIndex = 1;
            // 
            // TornamentEndDate
            // 
            this.TornamentEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TornamentEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TornamentEndDate.Location = new System.Drawing.Point(910, 204);
            this.TornamentEndDate.Name = "TornamentEndDate";
            this.TornamentEndDate.Size = new System.Drawing.Size(282, 30);
            this.TornamentEndDate.TabIndex = 2;
            // 
            // AddMatchInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1287, 768);
            this.Controls.Add(this.TornamentEndDate);
            this.Controls.Add(this.TournamentStartDate);
            this.Controls.Add(this.lblTournamentEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.TournamentDataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNameOfOrganisingCollege);
            this.Controls.Add(this.lblNameOfOrganisingCollege);
            this.Controls.Add(this.txtParticipatingCollege);
            this.Controls.Add(this.lblNameOfParticipatingCollege);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMatchInformation";
            this.Text = "AddMatchInformation";
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblNameOfParticipatingCollege;
        private System.Windows.Forms.TextBox txtParticipatingCollege;
        private System.Windows.Forms.Label lblNameOfOrganisingCollege;
        private System.Windows.Forms.TextBox txtNameOfOrganisingCollege;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView TournamentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfTournament;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfParticipatingCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfOrganisigCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.Label lblTournamentEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker TournamentStartDate;
        private System.Windows.Forms.DateTimePicker TornamentEndDate;
    }
}