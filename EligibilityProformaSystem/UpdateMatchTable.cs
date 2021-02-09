using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EligibilityProformaSystem
{
    public partial class UpdateMatchTable : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        public UpdateMatchTable()
        {
            InitializeComponent();
        }

        public void ShowAllData() 
        {
            SqlDataAdapter da = dc.GetAllData("Match_Table");
            if (da != null)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUpdateMatchTable.DataSource = dt;

            }
        }

        private void UpdateMatchTable_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void dgvUpdateMatchTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvUpdateMatchTable.CurrentRow;
            if (dgvr != null)
            {
                if (dc.UpdateData("Match Data", "UpdateMatchTable", dgvr.Cells["ID"].Value == DBNull.Value ? "" : dgvr.Cells["ID"].Value.ToString(), dgvr.Cells["TournamentName"].Value == DBNull.Value ? "" : dgvr.Cells["TournamentName"].Value.ToString(), dgvr.Cells["TournamentStartDate"].Value == DBNull.Value ? "" : dgvr.Cells["TournamentStartDate"].Value.ToString(), dgvr.Cells["TournamentEndDate"].Value == DBNull.Value ? "" : dgvr.Cells["TournamentEndDate"].Value.ToString(), dgvr.Cells["ParticipatingCollege"].Value == DBNull.Value ? "" : dgvr.Cells["ParticipatingCollege"].Value.ToString(), dgvr.Cells["OrganizingCollege"].Value == DBNull.Value ? "" : dgvr.Cells["OrganizingCollege"].Value.ToString()))
                    ShowAllData();
            }
        }
    }
}
