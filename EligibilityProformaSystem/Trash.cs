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
    public partial class Trash : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        public Trash()
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

            if (tabelname == "DeletePlayer")
            {
                PlayerDataGridView.DataSource = dt;
            }

            if (tabelname == "DeleteMatch")
            {
                TournamentDataGridView.DataSource = dt;
            }

            if (tabelname == "DeleteStaff")
            {
                StaffDataGridView.DataSource = dt;
            }

            if (tabelname == "DeleteEligibility")
            {
                EligibiltyDataGridView.DataSource = dt;
            }
        }

        private void Trash_Load(object sender, EventArgs e)
        {
            ShowData("DeletePlayer");
            ShowData("DeleteMatch");
            ShowData("DeleteStaff");
            ShowData("DeleteEligibility");
        }
    }
}
