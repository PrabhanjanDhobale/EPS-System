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
    public partial class ShowAllData : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        public ShowAllData()
        {
            InitializeComponent();
        }

        public void ShowData(string tabelname)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = dc.GetAllData(tabelname);
            if (da != null)
            {
                da.Fill(dt);
            }

            if (tabelname == "Player_Table")
            {
                PlayerDataGridView.DataSource = dt;
            }

            if (tabelname == "Match_Table")
            {
                TournamentDataGridView.DataSource = dt;
            }

            if (tabelname == "Staff_Table")
            {
                StaffDataGridView.DataSource = dt;
            }

            if (tabelname == "Eligibility_Table")
            {
                EligibiltyDataGridView.DataSource = dt;
            }
        }

        private void ShowAllData_Load(object sender, EventArgs e)
        {
            //ShowData("Player_Table");
            //ShowData("Match_Table");
            //ShowData("Staff_Table");
            //ShowData("Eligibility_Table");
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in PlayerDataGridView.SelectedRows)
            {
                dc.DeleteData("Player_Table", dr.Cells[0].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[7].Value.ToString(), dr.Cells[10].Value.ToString());
            }
            PlayerDataGridView.DataSource = null;
            ShowData("Player_Table");
        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in TournamentDataGridView.SelectedRows)
            {
                dc.DeleteData("Match_Table", dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[5].Value.ToString());
            }
            TournamentDataGridView.DataSource = null;
            ShowData("Match_Table");
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in StaffDataGridView.SelectedRows)
            {
                dc.DeleteData("Staff_Table", dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(),dr.Cells[3].Value.ToString());
            }
            StaffDataGridView.DataSource = null;
            ShowData("Staff_Table");
        }

        private void btnDeleteEligibility_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in EligibiltyDataGridView.SelectedRows)
            {
                dc.DeleteData("Eligibility_Table", dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), dr.Cells[4].Value.ToString(), dr.Cells[5].Value.ToString());
            }
            EligibiltyDataGridView.DataSource = null;
            ShowData("Eligibility_Table");
        }
       
    }
}
