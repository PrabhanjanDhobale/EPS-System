using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EligibilityProformaSystem
{
    public partial class SetPassword : Form
    {
        public SetPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == "" || txtPassword.Text == "" && txtConfirmPassword.Text == "" && txtConfirmPassword.Text == " "))
            {
                DatabaseConnection dc = new DatabaseConnection();
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    int chk = dc.SavePassword(txtPassword.Text);
                    if (chk == 0)
                    {
                        OpenLogin();
                    }
                    else if (chk == 1)
                    {
                        MessageBox.Show("Cannot Update Password");
                    }
                    else
                    {
                        MessageBox.Show("Cannot Connect To Database");
                    }
                }
                else
                {
                    MessageBox.Show("Password not matched");
                    return;
                }
            }
        }

        private void OpenLogin()
        {
            this.Hide();
            LogIn lg = new LogIn();
            lg.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OpenLogin();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text == " ")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "" || txtConfirmPassword.Text == " ")
            {
                MessageBox.Show("Please Enter Confirm Password");
                return;
            }
        }
    }
}
