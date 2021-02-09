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
    public partial class AddStaffInformation : Form
    {
        public AddStaffInformation()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            txtAddress.Text = txtContactNumber.Text = txtFirstName.Text = txtLastName.Text = txtMiddleName.Text = txtStatus.Text = "";
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtLastName.Text == "Last Name")
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
            if (txtFirstName.Text == "" || txtFirstName.Text == "First Name")
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
            if (txtMiddleName.Text == "" || txtMiddleName.Text == "Middle Name")
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

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            if (txtStatus.Text == "" || txtStatus.Text == " ")
            {
                MessageBox.Show("Please Enter Working Status");
                return;
            }
            if (!Regex.IsMatch(txtStatus.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Valid Status");
                txtStatus.Text = "";
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

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtAddress.Text == " ")
            {
                MessageBox.Show("Please Enter Your Address");
                txtAddress.Text = "";
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtAddress.Text == "" || txtContactNumber.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == "" || txtStatus.Text == ""))
            {
                DatabaseConnection dc = new DatabaseConnection();
                int chk = dc.InsertIntoStaffTable(txtLastName.Text + " " + txtFirstName.Text + " " + txtMiddleName.Text, txtStatus.Text, txtContactNumber.Text, txtAddress.Text);
                if (chk == 0)
                {
                    StaffInfoDataGridView.Rows.Add(txtLastName.Text + " " + txtFirstName.Text + " " + txtMiddleName.Text, txtStatus.Text, txtContactNumber.Text, txtAddress.Text);
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
