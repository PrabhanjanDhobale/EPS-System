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
using System.Text.RegularExpressions;

namespace EligibilityProformaSystem
{
    public partial class UpdatePlayerTable : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        AutoCompleteStringCollection actc = new AutoCompleteStringCollection();
        public UpdatePlayerTable()
        {
            InitializeComponent();
        }

        public void ShowAllData()
        {
            SqlDataAdapter da = dc.GetAllData("Player_Table");
            if (da != null)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUpdatePlayer.DataSource = dt;
            }

            /*try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select FullName from Player_Table", dc.conn);
                SqlDataReader dr = dc.query.ExecuteReader();

                while (dr.Read())
                {
                    actc.Add(dr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                //return da;
            }
            finally
            {
                dc.conn.Close();
            }*/
        }

        private void UpdatePlayerTable_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void dgvUpdatePlayer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvUpdatePlayer.CurrentRow;

            if (dgvr != null)
            {
                if (dc.UpdateData("Player Data","AddPlayerData", dgvr.Cells["PRNNumber"].Value == DBNull.Value ? "" : dgvr.Cells["PRNNumber"].Value.ToString(), dgvr.Cells["RollNumber"].Value == DBNull.Value ? "" : dgvr.Cells["RollNumber"].Value.ToString(), dgvr.Cells["FullName"].Value == DBNull.Value ? "" : dgvr.Cells["FullName"].Value.ToString(), dgvr.Cells["MotherName"].Value == DBNull.Value ? "" : dgvr.Cells["MotherName"].Value.ToString(), dgvr.Cells["DOB"].Value == DBNull.Value ? "" : dgvr.Cells["DOB"].Value.ToString(), dgvr.Cells["HSCPassingYear"].Value == DBNull.Value ? "" : dgvr.Cells["HSCPassingYear"].Value.ToString(), dgvr.Cells["CourceYearAndClass"].Value == DBNull.Value ? "" : dgvr.Cells["CourceYearAndClass"].Value.ToString(), dgvr.Cells["AdmissionToCollege"].Value == DBNull.Value ? "" : dgvr.Cells["AdmissionToCollege"].Value.ToString(), dgvr.Cells["AdmissionToCource"].Value.ToString(), dgvr.Cells["AdmissionToClass"].Value == DBNull.Value ? "" : dgvr.Cells["AdmissionToClass"].Value.ToString(), dgvr.Cells["ContactNumber"].Value == DBNull.Value ? "" : dgvr.Cells["ContactNumber"].Value.ToString(), dgvr.Cells["Email"].Value == DBNull.Value ? "" : dgvr.Cells["Email"].Value.ToString()))
                    ShowAllData();
            }

        }
    }
}
