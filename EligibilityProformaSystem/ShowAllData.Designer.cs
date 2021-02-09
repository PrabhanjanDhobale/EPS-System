namespace EligibilityProformaSystem
{
    partial class ShowAllData
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
            this.ShowAllDataTab = new System.Windows.Forms.TabControl();
            this.PlayerDataTab = new System.Windows.Forms.TabPage();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.TournamentDataTab = new System.Windows.Forms.TabPage();
            this.btnDeleteTournament = new System.Windows.Forms.Button();
            this.TournamentDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffDataTab = new System.Windows.Forms.TabPage();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.StaffDataGridView = new System.Windows.Forms.DataGridView();
            this.EligigbiltyDataTab = new System.Windows.Forms.TabPage();
            this.btnDeleteEligibility = new System.Windows.Forms.Button();
            this.EligibiltyDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowAllDataTab.SuspendLayout();
            this.PlayerDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            this.TournamentDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).BeginInit();
            this.StaffDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            this.EligigbiltyDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EligibiltyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAllDataTab
            // 
            this.ShowAllDataTab.Controls.Add(this.PlayerDataTab);
            this.ShowAllDataTab.Controls.Add(this.TournamentDataTab);
            this.ShowAllDataTab.Controls.Add(this.StaffDataTab);
            this.ShowAllDataTab.Controls.Add(this.EligigbiltyDataTab);
            this.ShowAllDataTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowAllDataTab.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllDataTab.Location = new System.Drawing.Point(0, 0);
            this.ShowAllDataTab.Name = "ShowAllDataTab";
            this.ShowAllDataTab.SelectedIndex = 0;
            this.ShowAllDataTab.Size = new System.Drawing.Size(1566, 749);
            this.ShowAllDataTab.TabIndex = 0;
            // 
            // PlayerDataTab
            // 
            this.PlayerDataTab.Controls.Add(this.btnDeletePlayer);
            this.PlayerDataTab.Controls.Add(this.PlayerDataGridView);
            this.PlayerDataTab.Location = new System.Drawing.Point(4, 29);
            this.PlayerDataTab.Name = "PlayerDataTab";
            this.PlayerDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerDataTab.Size = new System.Drawing.Size(1558, 716);
            this.PlayerDataTab.TabIndex = 0;
            this.PlayerDataTab.Text = "Player Data";
            this.PlayerDataTab.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Location = new System.Drawing.Point(1335, 651);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(142, 55);
            this.btnDeletePlayer.TabIndex = 1;
            this.btnDeletePlayer.Text = "Delete";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AllowUserToDeleteRows = false;
            this.PlayerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.ReadOnly = true;
            this.PlayerDataGridView.RowTemplate.Height = 24;
            this.PlayerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerDataGridView.Size = new System.Drawing.Size(1552, 633);
            this.PlayerDataGridView.TabIndex = 0;
            // 
            // TournamentDataTab
            // 
            this.TournamentDataTab.Controls.Add(this.btnDeleteTournament);
            this.TournamentDataTab.Controls.Add(this.TournamentDataGridView);
            this.TournamentDataTab.Location = new System.Drawing.Point(4, 29);
            this.TournamentDataTab.Name = "TournamentDataTab";
            this.TournamentDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.TournamentDataTab.Size = new System.Drawing.Size(1558, 716);
            this.TournamentDataTab.TabIndex = 1;
            this.TournamentDataTab.Text = "Tournament Data";
            this.TournamentDataTab.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTournament
            // 
            this.btnDeleteTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTournament.Location = new System.Drawing.Point(1358, 646);
            this.btnDeleteTournament.Name = "btnDeleteTournament";
            this.btnDeleteTournament.Size = new System.Drawing.Size(142, 55);
            this.btnDeleteTournament.TabIndex = 2;
            this.btnDeleteTournament.Text = "Delete";
            this.btnDeleteTournament.UseVisualStyleBackColor = true;
            this.btnDeleteTournament.Click += new System.EventHandler(this.btnDeleteTournament_Click);
            // 
            // TournamentDataGridView
            // 
            this.TournamentDataGridView.AllowUserToAddRows = false;
            this.TournamentDataGridView.AllowUserToDeleteRows = false;
            this.TournamentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TournamentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TournamentDataGridView.Name = "TournamentDataGridView";
            this.TournamentDataGridView.ReadOnly = true;
            this.TournamentDataGridView.RowTemplate.Height = 24;
            this.TournamentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TournamentDataGridView.Size = new System.Drawing.Size(1552, 630);
            this.TournamentDataGridView.TabIndex = 0;
            // 
            // StaffDataTab
            // 
            this.StaffDataTab.Controls.Add(this.btnDeleteStaff);
            this.StaffDataTab.Controls.Add(this.StaffDataGridView);
            this.StaffDataTab.Location = new System.Drawing.Point(4, 29);
            this.StaffDataTab.Name = "StaffDataTab";
            this.StaffDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffDataTab.Size = new System.Drawing.Size(1558, 716);
            this.StaffDataTab.TabIndex = 2;
            this.StaffDataTab.Text = "Satff Data";
            this.StaffDataTab.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Location = new System.Drawing.Point(1354, 637);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(142, 55);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.AllowUserToAddRows = false;
            this.StaffDataGridView.AllowUserToDeleteRows = false;
            this.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.ReadOnly = true;
            this.StaffDataGridView.RowTemplate.Height = 24;
            this.StaffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffDataGridView.Size = new System.Drawing.Size(1552, 617);
            this.StaffDataGridView.TabIndex = 0;
            // 
            // EligigbiltyDataTab
            // 
            this.EligigbiltyDataTab.Controls.Add(this.btnDeleteEligibility);
            this.EligigbiltyDataTab.Controls.Add(this.EligibiltyDataGridView);
            this.EligigbiltyDataTab.Location = new System.Drawing.Point(4, 29);
            this.EligigbiltyDataTab.Name = "EligigbiltyDataTab";
            this.EligigbiltyDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.EligigbiltyDataTab.Size = new System.Drawing.Size(1558, 716);
            this.EligigbiltyDataTab.TabIndex = 3;
            this.EligigbiltyDataTab.Text = "Eligibility Data";
            this.EligigbiltyDataTab.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEligibility
            // 
            this.btnDeleteEligibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEligibility.Location = new System.Drawing.Point(1385, 646);
            this.btnDeleteEligibility.Name = "btnDeleteEligibility";
            this.btnDeleteEligibility.Size = new System.Drawing.Size(142, 55);
            this.btnDeleteEligibility.TabIndex = 2;
            this.btnDeleteEligibility.Text = "Delete";
            this.btnDeleteEligibility.UseVisualStyleBackColor = true;
            this.btnDeleteEligibility.Click += new System.EventHandler(this.btnDeleteEligibility_Click);
            // 
            // EligibiltyDataGridView
            // 
            this.EligibiltyDataGridView.AllowUserToAddRows = false;
            this.EligibiltyDataGridView.AllowUserToDeleteRows = false;
            this.EligibiltyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EligibiltyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EligibiltyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.EligibiltyDataGridView.Name = "EligibiltyDataGridView";
            this.EligibiltyDataGridView.ReadOnly = true;
            this.EligibiltyDataGridView.RowTemplate.Height = 24;
            this.EligibiltyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EligibiltyDataGridView.Size = new System.Drawing.Size(1552, 628);
            this.EligibiltyDataGridView.TabIndex = 0;
            // 
            // ShowAllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1566, 749);
            this.Controls.Add(this.ShowAllDataTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAllData";
            this.Text = "ShowAllData";
            this.Load += new System.EventHandler(this.ShowAllData_Load);
            this.ShowAllDataTab.ResumeLayout(false);
            this.PlayerDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            this.TournamentDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).EndInit();
            this.StaffDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            this.EligigbiltyDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EligibiltyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ShowAllDataTab;
        private System.Windows.Forms.TabPage PlayerDataTab;
        private System.Windows.Forms.TabPage TournamentDataTab;
        private System.Windows.Forms.TabPage StaffDataTab;
        private System.Windows.Forms.TabPage EligigbiltyDataTab;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private System.Windows.Forms.DataGridView TournamentDataGridView;
        private System.Windows.Forms.DataGridView StaffDataGridView;
        private System.Windows.Forms.DataGridView EligibiltyDataGridView;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnDeleteTournament;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnDeleteEligibility;
    }
}