using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace EligibilityProformaSystem
{
    public partial class Menu : Form
    {
        AddPlayerInfo api = new AddPlayerInfo();
        AddStaffInformation asi = new AddStaffInformation();
        AddMatchInformation ami = new AddMatchInformation();
        ElgibilityForm ef = new ElgibilityForm();
        UpdatePlayerTable up = new UpdatePlayerTable();
        UpdateStaffData usd = new UpdateStaffData();
        UpdateMatchTable umt = new UpdateMatchTable();
        ContactUs cu = new ContactUs();
        ShowAllData sd = new ShowAllData();
        ProductDetails pd = new ProductDetails();
        Trash tr = new Trash();

        public Menu()
        {
            InitializeComponent();
        }

       
        private void DisplayPanel() {
            AddInfoPanel.Visible = true;    
        }

        private void HidePanel() {
            AddInfoPanel.Visible = false;
        }

        private void DisplayUpdatePanel() {
            UpdateInfoPanel.Visible = true;
        }

        private void HideUpdatePanel() {
            UpdateInfoPanel.Visible = false;
        }

        private void FormStatus(params Form[] fm)
        {
            foreach (Form f in fm)
            {
                f.Visible = false;
            }
        }

        private void HideAndShowForm(Form fm)
        {
            if (fm == api)
            {
                FormStatus(asi, ami, ef, up, usd, umt, cu, sd, pd,tr);

            }
            if (fm == asi)
            {
                FormStatus(api, ami, ef, up, usd, umt, cu, sd, pd,tr);

            }
            if (fm == ami)
            {
                FormStatus(api, asi, ef, up, usd, umt, cu, sd, pd,tr);

            }
            if (fm == ef)
            {
                FormStatus(api, asi, ami, up, usd, umt, cu, sd, pd,tr);

            }
            if (fm == up)
            {
                FormStatus(api, asi, ami, ef, usd, umt, cu, sd, pd,tr);

            }
            if (fm == usd)
            {
                FormStatus(api, asi, ami, ef, up, umt, cu, sd, pd,tr);

            }
            if (fm == umt)
            {
                FormStatus(api, asi, ami, ef, up, usd, cu,sd, pd,tr);

            }
            if (fm == cu)
            {
                FormStatus(api, asi, ami, ef, up, usd, umt,sd, pd,tr);
            }
            if (fm == sd)
            {
                FormStatus(api, asi, ami, ef, up, usd, umt,cu, pd,tr);
            }
            if (fm == pd)
            {
                FormStatus(api, asi, ami, ef, up, usd, umt, cu, sd,tr);
            }
            if (fm == tr)
            {
                FormStatus(api, asi, ami, ef, up, usd, umt, cu, sd, pd);
            }

            fm.TopLevel = false;
            LoadDataPanel.Controls.Add(fm);
            LoadDataPanel.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void btnAddInformation_Click(object sender, EventArgs e)
        {
            DisplayPanel();
            HideUpdatePanel();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            HidePanel();
            DisplayUpdatePanel();
        }

        /*private void btnConcession_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
        }

        private void btnTADA_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
        }

        private void btnKit_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
        }

        private void btnResponsibility_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
        }

        private void btnIDCard_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
        }*/

        private void Trash_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
            tr.ShowData("DeletePlayer");
            tr.ShowData("DeleteMatch");
            tr.ShowData("DeleteStaff");
            tr.ShowData("DeleteEligibility");
            HideAndShowForm(tr);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
            HideAndShowForm(cu);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btnPlayerInfo_Click(object sender, EventArgs e)
        {
            HideAndShowForm(api);
        }

        private void btnStaffInfo_Click(object sender, EventArgs e)
        {
            HideAndShowForm(asi);
        }

        private void btnMatchInfo_Click(object sender, EventArgs e)
        {
            
            HideAndShowForm(ami);
        }

        private void btnUpdateStaffInfo_Click_1(object sender, EventArgs e)
        {
            usd.ShowAllData();
            HideAndShowForm(usd);

        }

        private void btnUpdateMatchInfo_Click_1(object sender, EventArgs e)
        {
            umt.ShowAllData();
            HideAndShowForm(umt);
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            up.ShowAllData();
            HidePanel();
            HideAndShowForm(up);
        }

        private void btnEligibility_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
            ef.getPlayerName();
            ef.getStaffName();
            ef.getTournamentName();
            HideAndShowForm(ef);
        }

        private void btnshowAllData_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
            sd.ShowData("Player_Table");
            sd.ShowData("Match_Table");
            sd.ShowData("Staff_Table");
            sd.ShowData("Eligibility_Table");
            HideAndShowForm(sd);
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            HidePanel();
            HideUpdatePanel();
            pd.showAllProduct();
            HideAndShowForm(pd);
        }

        

    }
}
