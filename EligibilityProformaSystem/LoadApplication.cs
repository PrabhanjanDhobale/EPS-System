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
    public partial class LoadApplication : Form
    {
        public LoadApplication()
        {
            InitializeComponent();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            ApplicationProgressBar.Increment(1);
            if (ApplicationProgressBar.Value == 100)
            {
                ProgressTimer.Stop();
                this.Hide();
                LogIn lg = new LogIn();
                lg.ShowDialog();
            }
        }
    }
}
