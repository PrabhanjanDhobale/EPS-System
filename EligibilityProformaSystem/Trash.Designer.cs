namespace EligibilityProformaSystem
{
    partial class Trash
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
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowAllDataTab = new System.Windows.Forms.TabControl();
            this.PlayerDataTab = new System.Windows.Forms.TabPage();
            this.TournamentDataTab = new System.Windows.Forms.TabPage();
            this.TournamentDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffDataTab = new System.Windows.Forms.TabPage();
            this.StaffDataGridView = new System.Windows.Forms.DataGridView();
            this.EligigbiltyDataTab = new System.Windows.Forms.TabPage();
            this.EligibiltyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            this.ShowAllDataTab.SuspendLayout();
            this.PlayerDataTab.SuspendLayout();
            this.TournamentDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).BeginInit();
            this.StaffDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            this.EligigbiltyDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EligibiltyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AllowUserToDeleteRows = false;
            this.PlayerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.ReadOnly = true;
            this.PlayerDataGridView.RowTemplate.Height = 24;
            this.PlayerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerDataGridView.Size = new System.Drawing.Size(1547, 712);
            this.PlayerDataGridView.TabIndex = 0;
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
            this.ShowAllDataTab.Size = new System.Drawing.Size(1561, 751);
            this.ShowAllDataTab.TabIndex = 1;
            // 
            // PlayerDataTab
            // 
            this.PlayerDataTab.Controls.Add(this.PlayerDataGridView);
            this.PlayerDataTab.Location = new System.Drawing.Point(4, 29);
            this.PlayerDataTab.Name = "PlayerDataTab";
            this.PlayerDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerDataTab.Size = new System.Drawing.Size(1553, 718);
            this.PlayerDataTab.TabIndex = 0;
            this.PlayerDataTab.Text = "Player Data";
            this.PlayerDataTab.UseVisualStyleBackColor = true;
            // 
            // TournamentDataTab
            // 
            this.TournamentDataTab.Controls.Add(this.TournamentDataGridView);
            this.TournamentDataTab.Location = new System.Drawing.Point(4, 29);
            this.TournamentDataTab.Name = "TournamentDataTab";
            this.TournamentDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.TournamentDataTab.Size = new System.Drawing.Size(1553, 718);
            this.TournamentDataTab.TabIndex = 1;
            this.TournamentDataTab.Text = "Tournament Data";
            this.TournamentDataTab.UseVisualStyleBackColor = true;
            // 
            // TournamentDataGridView
            // 
            this.TournamentDataGridView.AllowUserToAddRows = false;
            this.TournamentDataGridView.AllowUserToDeleteRows = false;
            this.TournamentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TournamentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TournamentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TournamentDataGridView.Name = "TournamentDataGridView";
            this.TournamentDataGridView.ReadOnly = true;
            this.TournamentDataGridView.RowTemplate.Height = 24;
            this.TournamentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TournamentDataGridView.Size = new System.Drawing.Size(1547, 712);
            this.TournamentDataGridView.TabIndex = 0;
            // 
            // StaffDataTab
            // 
            this.StaffDataTab.Controls.Add(this.StaffDataGridView);
            this.StaffDataTab.Location = new System.Drawing.Point(4, 29);
            this.StaffDataTab.Name = "StaffDataTab";
            this.StaffDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffDataTab.Size = new System.Drawing.Size(1553, 718);
            this.StaffDataTab.TabIndex = 2;
            this.StaffDataTab.Text = "Satff Data";
            this.StaffDataTab.UseVisualStyleBackColor = true;
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.AllowUserToAddRows = false;
            this.StaffDataGridView.AllowUserToDeleteRows = false;
            this.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.ReadOnly = true;
            this.StaffDataGridView.RowTemplate.Height = 24;
            this.StaffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffDataGridView.Size = new System.Drawing.Size(1547, 712);
            this.StaffDataGridView.TabIndex = 0;
            // 
            // EligigbiltyDataTab
            // 
            this.EligigbiltyDataTab.Controls.Add(this.EligibiltyDataGridView);
            this.EligigbiltyDataTab.Location = new System.Drawing.Point(4, 29);
            this.EligigbiltyDataTab.Name = "EligigbiltyDataTab";
            this.EligigbiltyDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.EligigbiltyDataTab.Size = new System.Drawing.Size(1553, 718);
            this.EligigbiltyDataTab.TabIndex = 3;
            this.EligigbiltyDataTab.Text = "Eligibility Data";
            this.EligigbiltyDataTab.UseVisualStyleBackColor = true;
            // 
            // EligibiltyDataGridView
            // 
            this.EligibiltyDataGridView.AllowUserToAddRows = false;
            this.EligibiltyDataGridView.AllowUserToDeleteRows = false;
            this.EligibiltyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EligibiltyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EligibiltyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EligibiltyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.EligibiltyDataGridView.Name = "EligibiltyDataGridView";
            this.EligibiltyDataGridView.ReadOnly = true;
            this.EligibiltyDataGridView.RowTemplate.Height = 24;
            this.EligibiltyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EligibiltyDataGridView.Size = new System.Drawing.Size(1547, 712);
            this.EligibiltyDataGridView.TabIndex = 0;
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 751);
            this.Controls.Add(this.ShowAllDataTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trash";
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.Trash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            this.ShowAllDataTab.ResumeLayout(false);
            this.PlayerDataTab.ResumeLayout(false);
            this.TournamentDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TournamentDataGridView)).EndInit();
            this.StaffDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            this.EligigbiltyDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EligibiltyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private System.Windows.Forms.TabControl ShowAllDataTab;
        private System.Windows.Forms.TabPage PlayerDataTab;
        private System.Windows.Forms.TabPage TournamentDataTab;
        private System.Windows.Forms.DataGridView TournamentDataGridView;
        private System.Windows.Forms.TabPage StaffDataTab;
        private System.Windows.Forms.DataGridView StaffDataGridView;
        private System.Windows.Forms.TabPage EligigbiltyDataTab;
        private System.Windows.Forms.DataGridView EligibiltyDataGridView;
    }
}