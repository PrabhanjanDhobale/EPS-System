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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == " " || txtUsername.Text == "") {
                MessageBox.Show("Please enter username");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == " " || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();
            int chk = conn.ValidateAdmin(txtUsername.Text,txtPassword.Text);
            if (chk == 0)
            {
                this.Hide();
                Menu mn = new Menu();
                mn.ShowDialog();
            }
            else if (chk == 1)
            {
                MessageBox.Show("Please Check Username or password");
                return;
            }
            else
            {
                MessageBox.Show("Cannot Connect To Database");
                return;
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }

    }
}
