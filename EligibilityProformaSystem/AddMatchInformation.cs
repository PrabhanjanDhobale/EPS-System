using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EligibilityProformaSystem
{
    public partial class AddMatchInformation : Form
    {
        public AddMatchInformation()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            txtNameOfOrganisingCollege.Text = txtParticipatingCollege.Text = txtTournamentName.Text = "";
        }

        private void txtTournamentName_Leave(object sender, EventArgs e)
        {
            if (txtTournamentName.Text == "" || txtTournamentName.Text == " ")
            {
                MessageBox.Show("Please Enter Tournament Name");
                txtTournamentName.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtTournamentName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Please Enter Valid Turnament Name");
                txtTournamentName.Text = "";
                return;
            }
        }

        private void txtParticipatingCollege_Leave(object sender, EventArgs e)
        {
            if (txtParticipatingCollege.Text == "" || txtParticipatingCollege.Text == " ")
            {
                MessageBox.Show("Please Enter Participating College Name");
                txtParticipatingCollege.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtParticipatingCollege.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Please Enter Valid Participating College Name");
                txtParticipatingCollege.Text = "";
                return;
            }
        }

        private void txtNameOfOrganisingCollege_Leave(object sender, EventArgs e)
        {
            if (txtNameOfOrganisingCollege.Text == "" || txtNameOfOrganisingCollege.Text == " ")
            {
                MessageBox.Show("Please Enter Name Of Organizing College");
                txtNameOfOrganisingCollege.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtNameOfOrganisingCollege.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Please Enter Valid Tournamenet Organizing College Name");
                txtNameOfOrganisingCollege.Text = "";
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtNameOfOrganisingCollege.Text == "" || txtParticipatingCollege.Text == "" || txtTournamentName.Text == ""))
            {
                DatabaseConnection dc = new DatabaseConnection();
                int chk = dc.InsertIntoMatchTable(txtTournamentName.Text, TournamentStartDate.Value.ToString("yyyy-MM-dd"), TornamentEndDate.Value.ToString("yyyy-MM-dd"), txtParticipatingCollege.Text, txtNameOfOrganisingCollege.Text);
                if (chk == 0)
                {
                    TournamentDataGridView.Rows.Add(txtTournamentName.Text, txtParticipatingCollege.Text, txtNameOfOrganisingCollege.Text, TournamentStartDate.Value.ToString("yyyy-MM-dd"), TornamentEndDate.Value.ToString("yyyy-MM-dd"));
                    ClearAll();
                }
                else if (chk == 1)
                {
                    MessageBox.Show("Cannot Insert Data");
                }
                else
                {
                    MessageBox.Show("Cannot Connect To Database");
                }
            }
            else
            {
                MessageBox.Show("Please Fill The Blank Feilds");
            }
        }

        
    }
}
