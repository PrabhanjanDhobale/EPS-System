namespace EligibilityProformaSystem
{
    partial class ElgibilityForm
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
            this.lblTitleSecond = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.PRNNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnSelectStaff = new System.Windows.Forms.Button();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.btnSelectTournamentName = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(588, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Solapur University";
            // 
            // lblTitleSecond
            // 
            this.lblTitleSecond.AutoSize = true;
            this.lblTitleSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTitleSecond.Location = new System.Drawing.Point(540, 72);
            this.lblTitleSecond.Name = "lblTitleSecond";
            this.lblTitleSecond.Size = new System.Drawing.Size(360, 32);
            this.lblTitleSecond.TabIndex = 2;
            this.lblTitleSecond.Text = "ELIGIBILITY PROFORMA";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblPlayerName.Location = new System.Drawing.Point(96, 174);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(205, 25);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Enter Player Name :";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblStaffName.Location = new System.Drawing.Point(112, 300);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(189, 25);
            this.lblStaffName.TabIndex = 9;
            this.lblStaffName.Text = "Enter Staff Name :";
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSelect.Location = new System.Drawing.Point(750, 167);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 47);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRNNumber,
            this.FullName});
            this.PlayerDataGridView.Location = new System.Drawing.Point(12, 495);
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.RowTemplate.Height = 24;
            this.PlayerDataGridView.Size = new System.Drawing.Size(450, 289);
            this.PlayerDataGridView.TabIndex = 13;
            // 
            // PRNNumber
            // 
            this.PRNNumber.HeaderText = "PRNNumber";
            this.PRNNumber.Name = "PRNNumber";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // TournamentEndDate
            // 
            this.TournamentEndDate.HeaderText = "Tournament End Date";
            this.TournamentEndDate.Name = "TournamentEndDate";
            // 
            // TournamentStartDate
            // 
            this.TournamentStartDate.HeaderText = "Tournament Start Date";
            this.TournamentStartDate.Name = "TournamentStartDate";
            // 
            // TournamentName
            // 
            this.TournamentName.HeaderText = "Tournament Name";
            this.TournamentName.Name = "TournamentName";
            // 
            // TournamentDataGridView
            // 
            this.TournamentDataGridView.AllowUserToAddRows = false;
            this.TournamentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TournamentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TournamentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TournamentName,
            this.TournamentStartDate,
            this.TournamentEndDate});
            this.TournamentDataGridView.Location = new System.Drawing.Point(470, 495);
            this.TournamentDataGridView.Name = "TournamentDataGridView";
            this.TournamentDataGridView.RowTemplate.Height = 24;
            this.TournamentDataGridView.Size = new System.Drawing.Size(626, 289);
            this.TournamentDataGridView.TabIndex = 14;
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.AllowUserToAddRows = false;
            this.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffName,
            this.Status});
            this.StaffDataGridView.Location = new System.Drawing.Point(1102, 495);
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.RowTemplate.Height = 24;
            this.StaffDataGridView.Size = new System.Drawing.Size(414, 289);
            this.StaffDataGridView.TabIndex = 15;
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "Staff Name";
            this.StaffName.Name = "StaffName";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlayerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlayerName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(372, 172);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(332, 34);
            this.txtPlayerName.TabIndex = 16;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // txtStaffName
            // 
            this.txtStaffName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStaffName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStaffName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(371, 293);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(332, 34);
            this.txtStaffName.TabIndex = 17;
            // 
            // btnSelectStaff
            // 
            this.btnSelectStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSelectStaff.Location = new System.Drawing.Point(750, 288);
            this.btnSelectStaff.Name = "btnSelectStaff";
            this.btnSelectStaff.Size = new System.Drawing.Size(113, 47);
            this.btnSelectStaff.TabIndex = 18;
            this.btnSelectStaff.Text = "Select";
            this.btnSelectStaff.UseVisualStyleBackColor = true;
            this.btnSelectStaff.Click += new System.EventHandler(this.btnSelectStaff_Click);
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTournamentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTournamentName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTournamentName.Location = new System.Drawing.Point(371, 408);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(332, 34);
            this.txtTournamentName.TabIndex = 20;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTournamentName.Location = new System.Drawing.Point(41, 415);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(260, 25);
            this.lblTournamentName.TabIndex = 19;
            this.lblTournamentName.Text = "Enter Tournament Name :";
            // 
            // btnSelectTournamentName
            // 
            this.btnSelectTournamentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSelectTournamentName.Location = new System.Drawing.Point(750, 405);
            this.btnSelectTournamentName.Name = "btnSelectTournamentName";
            this.btnSelectTournamentName.Size = new System.Drawing.Size(113, 47);
            this.btnSelectTournamentName.TabIndex = 21;
            this.btnSelectTournamentName.Text = "Select";
            this.btnSelectTournamentName.UseVisualStyleBackColor = true;
            this.btnSelectTournamentName.Click += new System.EventHandler(this.btnSelectTournamentName_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnGenerateReport.Location = new System.Drawing.Point(1098, 802);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(263, 47);
            this.btnGenerateReport.TabIndex = 22;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReset.Location = new System.Drawing.Point(817, 802);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(263, 47);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ElgibilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1545, 940);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnSelectTournamentName);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.btnSelectStaff);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.StaffDataGridView);
            this.Controls.Add(this.TournamentDataGridView);
            this.Controls.Add(this.PlayerDataGridView);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblTitleSecond);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ElgibilityForm";
            this.Text = "ElgibilityForm";
            this.Load += new System.EventHandler(this.ElgibilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleSecond;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentName;
        private System.Windows.Forms.DataGridView TournamentDataGridView;
        private System.Windows.Forms.DataGridView StaffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRNNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnSelectStaff;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Button btnSelectTournamentName;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnReset;
    }
}