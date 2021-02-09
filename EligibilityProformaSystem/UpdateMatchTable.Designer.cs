namespace EligibilityProformaSystem
{
    partial class UpdateMatchTable
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
            this.dgvUpdateMatchTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipatingCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizingCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateMatchTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateMatchTable
            // 
            this.dgvUpdateMatchTable.AllowUserToAddRows = false;
            this.dgvUpdateMatchTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpdateMatchTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvUpdateMatchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateMatchTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TournamentName,
            this.TournamentStartDate,
            this.TournamentEndDate,
            this.ParticipatingCollege,
            this.OrganizingCollege});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpdateMatchTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUpdateMatchTable.Location = new System.Drawing.Point(12, 4);
            this.dgvUpdateMatchTable.Name = "dgvUpdateMatchTable";
            this.dgvUpdateMatchTable.RowTemplate.Height = 24;
            this.dgvUpdateMatchTable.Size = new System.Drawing.Size(1202, 811);
            this.dgvUpdateMatchTable.TabIndex = 0;
            this.dgvUpdateMatchTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateMatchTable_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // TournamentName
            // 
            this.TournamentName.DataPropertyName = "TournamentName";
            this.TournamentName.HeaderText = "Tournament Name";
            this.TournamentName.Name = "TournamentName";
            // 
            // TournamentStartDate
            // 
            this.TournamentStartDate.DataPropertyName = "TournamentStartDate";
            this.TournamentStartDate.HeaderText = "Tournament Start Date";
            this.TournamentStartDate.Name = "TournamentStartDate";
            // 
            // TournamentEndDate
            // 
            this.TournamentEndDate.DataPropertyName = "TournamentEndDate";
            this.TournamentEndDate.HeaderText = "Tournament End Date";
            this.TournamentEndDate.Name = "TournamentEndDate";
            // 
            // ParticipatingCollege
            // 
            this.ParticipatingCollege.DataPropertyName = "ParticipatingCollege";
            this.ParticipatingCollege.HeaderText = "Participating College";
            this.ParticipatingCollege.Name = "ParticipatingCollege";
            // 
            // OrganizingCollege
            // 
            this.OrganizingCollege.DataPropertyName = "OrganizingCollege";
            this.OrganizingCollege.HeaderText = "Organizing College";
            this.OrganizingCollege.Name = "OrganizingCollege";
            // 
            // UpdateMatchTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1226, 827);
            this.Controls.Add(this.dgvUpdateMatchTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateMatchTable";
            this.Text = "UpdateMatchTable";
            this.Load += new System.EventHandler(this.UpdateMatchTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateMatchTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateMatchTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipatingCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizingCollege;
    }
}