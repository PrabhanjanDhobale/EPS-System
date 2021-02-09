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
    public partial class AddPlayerInfo : Form
    {
        public AddPlayerInfo()
        {
            InitializeComponent();
        }

        private void ClearAll()
        { 
           txtAdmissionToClass.Text = txtAdmissionToCource.Text = txtAdmissionToCollege.Text = txtClass.Text = txtCourceYear.Text = txtMiddleName.Text = txtFirstName.Text = txtLastName.Text = txtHSCPassingYear.Text = txtPRNNumber.Text = txtRollNumber.Text = txtMotherName.Text = txtCourceYear.Text = txtClass.Text = txtAdmissionToCollege.Text = txtAdmissionToCource.Text = txtAdmissionToClass.Text = txtContactNumber.Text = txtEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtAdmissionToClass.Text == "" || txtAdmissionToCource.Text == "" || txtAdmissionToCollege.Text == "" || txtClass.Text == "" || txtCourceYear.Text == "" || txtMiddleName.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtHSCPassingYear.Text == "" || txtPRNNumber.Text == "" || txtRollNumber.Text == "" || txtMotherName.Text == "" || txtCourceYear.Text == "" || txtClass.Text == "" || txtAdmissionToCollege.Text == "" || txtAdmissionToCource.Text == "" || txtAdmissionToClass.Text == "" || txtContactNumber.Text == "" || txtEmail.Text == ""))
            {
                DatabaseConnection dt = new DatabaseConnection();
                int chk = dt.InsertPlayerData(txtPRNNumber.Text, txtRollNumber.Text, txtLastName.Text + " " + txtFirstName.Text + " " + txtMiddleName.Text, txtMotherName.Text, dateTime.Value.ToString("yyyy-MM-dd"), txtHSCPassingYear.Text, txtCourceYear.Text + " " + txtClass.Text, txtAdmissionToCollege.Text, txtAdmissionToCource.Text, txtAdmissionToClass.Text, txtContactNumber.Text, txtEmail.Text);
                if (chk == 0)
                {
                    PlayerInformationGridView.Rows.Add(txtPRNNumber.Text, txtRollNumber.Text, txtLastName.Text + " " + txtFirstName.Text + " " + txtMiddleName.Text, txtMotherName.Text, dateTime.Value.ToString("yyyy-MM-dd"), txtHSCPassingYear.Text, txtCourceYear.Text + " " + txtClass.Text, txtAdmissionToCollege.Text, txtAdmissionToCource.Text, txtAdmissionToClass.Text, txtContactNumber.Text, txtEmail.Text);
                    ClearAll();
                }
                else if (chk == 1)
                {
                    MessageBox.Show("Cannot insert data");
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

        private void txtPRNNumber_Leave(object sender, EventArgs e)
        {
            if (txtPRNNumber.Text == "" || txtPRNNumber.Text == " ")
            {
                MessageBox.Show("Please Enter PRN Number");
                txtPRNNumber.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtPRNNumber.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid PRN Number");
                txtPRNNumber.Text = "";
                return;
            }
            if (txtPRNNumber.Text.Length < 16)
            {
                MessageBox.Show("PRN Number should not be smaller than 16");
                txtPRNNumber.Text = "";
                return;
            }
            
        }

        private void txtRollNumber_Leave(object sender, EventArgs e)
        {
            if (txtRollNumber.Text == "" || txtRollNumber.Text == " ")
            {
                MessageBox.Show("Please Enter Roll Number");
                txtRollNumber.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtRollNumber.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Roll Number");
                txtRollNumber.Text = "";
                return;
            }
            if (txtPRNNumber.Text.Length < 5)
            {
                MessageBox.Show("PRN Number should not be smaller than 5");
                txtRollNumber.Text = "";
                return;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtLastName.Text == " ")
            {
                MessageBox.Show("Please Enter Last Name");
                txtLastName.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Valid Last Name");
                txtLastName.Text = "";
                return;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == " " || txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter First Name");
                txtFirstName.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Valid First Name");
                txtFirstName.Text = "";
                return;
            }
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == " " || txtMiddleName.Text == "")
            {
                MessageBox.Show("Please Enter Middle Name");
                txtMiddleName.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtMiddleName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Valid Middle Name");
                txtMiddleName.Text = "";
                return;
            }
        }

        private void txtMotherName_Leave(object sender, EventArgs e)
        {
            if (txtMotherName.Text == "" || txtMotherName.Text == " ")
            {
                MessageBox.Show("Please Enter Mother Name");
                txtMotherName.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtMotherName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Valid Mother Name");
                txtMotherName.Text = "";
                return;
            }
        }

        private void txtHSCPassingYear_Leave(object sender, EventArgs e)
        {
            if (txtHSCPassingYear.Text == "" || txtHSCPassingYear.Text == " ")
            {
                MessageBox.Show("Please Enter HSC Passing Year");
                txtHSCPassingYear.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtHSCPassingYear.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid HSC Passing Year in numbers");
                txtHSCPassingYear.Text = "";
                return;
            }
            if (txtHSCPassingYear.Text.Length < 4)
            {
                MessageBox.Show("Year should not be should not be smaller than 4");
                txtHSCPassingYear.Text = "";
                return;
            }
        }

        private void txtCourceYear_Leave(object sender, EventArgs e)
        {
            if (txtCourceYear.Text == "" || txtCourceYear.Text == " ")
            {
                MessageBox.Show("Please Enter Cource ");
                txtCourceYear.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtCourceYear.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Valid Course Name");
                txtCourceYear.Text = "";
                return;
            }
            
        }

        private void txtAdmissionToCollege_Leave(object sender, EventArgs e)
        {
            if (txtAdmissionToCollege.Text == "" || txtAdmissionToCollege.Text == " ")
            {
                MessageBox.Show("Please Enter Year Of Admission to College");
                txtAdmissionToCollege.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtAdmissionToCollege.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid College year");
                txtAdmissionToCollege.Text = "";
                return;
            }
            if (txtAdmissionToCollege.Text.Length < 4)
            {
                MessageBox.Show("year should not be smaller than 4");
                txtAdmissionToCollege.Text = "";
                return;
            }
        }

        private void txtAdmissionToCource_Leave(object sender, EventArgs e)
        {
            if (txtAdmissionToCource.Text == "" || txtAdmissionToCource.Text == " ")
            {
                MessageBox.Show("Please Enter Year Of Admission to Cource");
                txtAdmissionToCource.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtAdmissionToCource.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Course year");
                txtAdmissionToCource.Text = "";
                return;
            }
            if (txtAdmissionToCource.Text.Length < 4)
            {
                MessageBox.Show("year should not be smaller than 16");
                txtAdmissionToCource.Text = "";
                return;
            }
        }

        private void txtAdmissionToClass_Leave(object sender, EventArgs e)
        {
            if (txtAdmissionToClass.Text == "" || txtAdmissionToClass.Text == " ")
            {
                MessageBox.Show("Please Enter Year Of Admission to Class");
                txtAdmissionToClass.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtAdmissionToClass.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid class year");
                txtAdmissionToClass.Text = "";
                return;
            }
            if (txtAdmissionToClass.Text.Length < 4)
            {
                MessageBox.Show("year should not be smaller than 4");
                txtAdmissionToClass.Text = "";
                return;
            }
        }

        private void txtClass_Leave(object sender, EventArgs e)
        {
            if (txtClass.Text == "" || txtClass.Text == " ")
            {
                MessageBox.Show("Please Enter Class year");
                txtClass.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtClass.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid class year");
                txtClass.Text = "";
                return;
            }
            if (txtClass.Text.Length < 1)
            {
                MessageBox.Show("Year should not be should not be smaller than 4");
                txtCourceYear.Text = "";
                return;
            }
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "" || txtContactNumber.Text == " ")
            {
                MessageBox.Show("Please Enter Contact Number");
                txtContactNumber.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtContactNumber.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Contact Number");
                txtContactNumber.Text = "";
                return;
            }
            if (txtContactNumber.Text.Length < 10)
            {
                MessageBox.Show("Contact Number Number should not be smaller than 10");
                txtContactNumber.Text = "";
                return;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == " ")
            {
                MessageBox.Show("Please Enter Email Address");
                txtEmail.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            { 
                MessageBox.Show("Please Enter Valid Email Address");
                txtEmail.Text = "";
                return;
            }
        }
    }
}
