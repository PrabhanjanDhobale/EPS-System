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
    public partial class UpdateStaffData : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        public UpdateStaffData()
        {
            InitializeComponent();
        }

        public void ShowAllData()
        {
            SqlDataAdapter da = dc.GetAllData("Staff_Table");
            if (da != null)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUpdateStaffData.DataSource = dt;
            }
        }

        private void UpdateStaffData_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void dgvUpdateStaffData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvUpdateStaffData.CurrentRow;
            if (dgvr != null)
            {
                if (dc.UpdateData("Staff Data", "UpdateStaff", dgvr.Cells["ID"].Value == DBNull.Value ? "" : dgvr.Cells["Id"].Value.ToString(), dgvr.Cells["FullName"].Value == DBNull.Value ? "" : dgvr.Cells["FullName"].Value.ToString(), dgvr.Cells["StatusOfStaff"].Value == DBNull.Value ? "" : dgvr.Cells["StatusOfStaff"].Value.ToString(), dgvr.Cells["ContactNumber"].Value == DBNull.Value ? "" : dgvr.Cells["ContactNumber"].Value.ToString(), dgvr.Cells["Address"].Value == DBNull.Value ? "" : dgvr.Cells["Address"].Value.ToString()))
                    ShowAllData();
            }
        }
    }
}
