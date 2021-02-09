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
    public partial class ElgibilityForm : Form
    {
        string PlayerFullName,StaffFullName,Tournament_Name, Tournament_Start_Date, Tournament_End_Date;
        long PRN_Number;

        public ElgibilityForm()
        {
            InitializeComponent();
        }


        DataTable playerdata = null;
        DataTable staffdata = null;
        DataTable tournamentdata = null;
        private void ElgibilityForm_Load(object sender, EventArgs e)
        {
            //getPlayerName();
            //getStaffName();
            //getTournamentName();

            playerdata = new DataTable();
            playerdata.Columns.Add("PRNNumber");
            playerdata.Columns.Add("RollNumber");
            playerdata.Columns.Add("FullName");
            playerdata.Columns.Add("MotherName");
            playerdata.Columns.Add("DateOfBirth");
            playerdata.Columns.Add("HSCPassingYear");
            playerdata.Columns.Add("CourceYearAndClass");
            playerdata.Columns.Add("AdmissionToCollege");
            playerdata.Columns.Add("AdmissionToCource");
            playerdata.Columns.Add("AdmissionToClass");


            staffdata = new DataTable();
            staffdata.Columns.Add("FullName");
            staffdata.Columns.Add("StatusOfStaff");


            tournamentdata = new DataTable();
            tournamentdata.Columns.Add("TournamentName");
            tournamentdata.Columns.Add("TournamentStartDate");
            tournamentdata.Columns.Add("TournamentEndDate");
            tournamentdata.Columns.Add("ParticipatingCollege");
            tournamentdata.Columns.Add("OrganizingCollege");

        }

        DatabaseConnection dc = new DatabaseConnection();
        public void getPlayerName()
        {
            SqlDataReader dr = null; ;
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select FullName from Player_Table", dc.conn);
                dr = dc.query.ExecuteReader();
                AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycoll.Add(dr.GetString(0));
                }
                txtPlayerName.AutoCompleteCustomSource = mycoll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }
        }

        public void getStaffName()
        {
            SqlDataReader dr = null; ;
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select FullName from Staff_Table", dc.conn);
                dr = dc.query.ExecuteReader();
                AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycoll.Add(dr.GetString(0));
                }
                txtStaffName.AutoCompleteCustomSource = mycoll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }
        }

        public void getTournamentName()
        {
            SqlDataReader dr = null; ;
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select TournamentName from Match_Table", dc.conn);
                dr = dc.query.ExecuteReader();
                AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycoll.Add(dr.GetString(0));
                }
                txtTournamentName.AutoCompleteCustomSource = mycoll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "")
            {
                SqlDataReader dr = null; ;
                try
                {
                    dc.conn.Open();
                    dc.query = new SqlCommand("select * from Player_Table where FullName='" + txtPlayerName.Text + "'", dc.conn);
                    dr = dc.query.ExecuteReader();
                    if (dr.Read())
                    {
                        playerdata.Rows.Add(dr["PRNNumber"].ToString(), dr["RollNumber"].ToString(), dr["FullName"].ToString(), dr["MotherName"].ToString(), dr["DateOfBirth"].ToString(), dr["HSCPassingYear"].ToString(), dr["CourceYearAndClass"].ToString(), dr["AdmissionToCollege"].ToString(), dr["AdmissionToCource"].ToString(), dr["AdmissionToClass"].ToString());
                        PlayerDataGridView.Rows.Add(dr["PRNNumber"].ToString(), dr["FullName"].ToString());
                        PlayerFullName = dr["FullName"].ToString();
                        PRN_Number = Convert.ToInt64(dr["PRNNumber"].ToString());
                        txtPlayerName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Data not found");
                        txtPlayerName.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dc.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Player Name");
            }
        }

        private void btnSelectStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text != "")
            {
                SqlDataReader dr = null; ;
                try
                {
                    dc.conn.Open();
                    dc.query = new SqlCommand("select FullName,StatusOfStaff from Staff_Table where FullName='" + txtStaffName.Text + "'", dc.conn);
                    dr = dc.query.ExecuteReader();
                    if (dr.Read())
                    {
                        staffdata.Rows.Add(dr["FullName"].ToString(), dr["StatusOfStaff"].ToString());
                        StaffDataGridView.Rows.Add(dr["FullName"].ToString(), dr["StatusOfStaff"].ToString());
                        StaffFullName = dr["FullName"].ToString();
                        txtStaffName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Data not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    dc.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Staff Name");
            }
        }

        private void btnSelectTournamentName_Click(object sender, EventArgs e)
        {
            if (txtTournamentName.Text != "")
            {
                SqlDataReader dr = null; ;
                try
                {
                    dc.conn.Open();
                    dc.query = new SqlCommand("select * from Match_Table where TournamentName='" + txtTournamentName.Text + "'", dc.conn);
                    dr = dc.query.ExecuteReader();
                    if (dr.Read())
                    {
                        tournamentdata.Rows.Add(dr["TournamentName"].ToString(), dr["TournamentStartDate"].ToString(), dr["TournamentEndDate"].ToString(), dr["ParticipatingCollege"].ToString(), dr["OrganizingCollege"].ToString());
                        TournamentDataGridView.Rows.Add(dr["TournamentName"].ToString(), dr["TournamentStartDate"].ToString(), dr["TournamentEndDate"].ToString());
                        Tournament_Name = dr["TournamentName"].ToString();
                        Tournament_Start_Date = dr["TournamentStartDate"].ToString();
                        Tournament_End_Date = dr["TournamentEndDate"].ToString();
                        txtTournamentName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Data not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dc.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Tournament Name");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (playerdata.Rows.Count > 0)
            {
                if (staffdata.Rows.Count == 1)
                {
                    if (tournamentdata.Rows.Count == 1)
                    {
                            ReportPage rp = new ReportPage();
                            rp.getEligibilityData(playerdata, staffdata, tournamentdata);
                            rp.getSTData(playerdata.Rows.Count, staffdata.Rows.Count, tournamentdata);
                            rp.getTADAData(playerdata, staffdata, tournamentdata);
                            rp.getResponsibilityData(playerdata, tournamentdata);
                            rp.getIDData(playerdata, staffdata, tournamentdata);
                            rp.getKitDetails(playerdata, tournamentdata);
                            rp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You should select only one tournament at a time");
                    }
                }
                else
                {
                    MessageBox.Show("You should select only one staff member");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select Any Player Data");
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PlayerDataGridView.Rows.Clear();
            playerdata.Clear();
            staffdata.Clear();
            tournamentdata.Clear();
            StaffDataGridView.Rows.Clear();
            TournamentDataGridView.Rows.Clear();
            txtTournamentName.Text = txtPlayerName.Text = txtStaffName.Text = "";
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
