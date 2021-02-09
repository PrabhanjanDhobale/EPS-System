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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn lg = new LogIn();
            lg.ShowDialog();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();
            int chk = conn.ValidateFavPlayer(txtFavPlayer.Text);
            if (chk == 0)
            {
                this.Hide();
                SetPassword sp = new SetPassword();
                sp.ShowDialog();
            }
            else if (chk == 1)
            {
                MessageBox.Show("Player doesn't match");
                return;
            }
            else
            {
                MessageBox.Show("Cannot Connect To Database");
                return;
            }
        }

        private void txtFavPlayer_Leave(object sender, EventArgs e)
        {
            if (txtFavPlayer.Text == "" || txtFavPlayer.Text == " ")
            {
                MessageBox.Show("Please Enter Favourite Player Name");
                return;
            }
        }
    }
}
