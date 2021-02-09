using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace EligibilityProformaSystem
{
    public partial class ReportPage : Form
    {
        ReportDocument rpt;
       
        public ReportPage()
        {
            InitializeComponent();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
           
        }

        DatabaseConnection dc = new DatabaseConnection();
        public void getEligibilityData(DataTable playerdatatable,DataTable staffdata,DataTable tournamentdata)
        {
            int i = 0;
            while (i <= playerdatatable.Rows.Count-1)
            {
                long prn =Convert.ToInt64(playerdatatable.Rows[i][0].ToString());
                if (dc.InsertIntoEligibilityTable(prn,playerdatatable.Rows[i][2].ToString(),staffdata.Rows[0][0].ToString(), tournamentdata.Rows[0][0].ToString(), tournamentdata.Rows[0][1].ToString(), tournamentdata.Rows[0][2].ToString()) == 0)
                {
                    if (i == playerdatatable.Rows.Count - 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                }
                else
                {
                    MessageBox.Show("Data Cannot be Inserted");
                }
                i++;
            }
             rpt = new ReportDocument();
             rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\EligibilityReport.rpt");
             rpt.Database.Tables["playerdata"].SetDataSource(playerdatatable);
             rpt.Database.Tables["staffdata"].SetDataSource(staffdata);
             rpt.Database.Tables["tournamentdata"].SetDataSource(tournamentdata);
             EligibilityReportViewer.ReportSource = rpt;
        }

        public void getSTData(int playercount, int staffcount, DataTable tournamentdata)
        {
            rpt = new ReportDocument();
            rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\STReport.rpt");
            rpt.Database.Tables["tournamentdata"].SetDataSource(tournamentdata);
            STReportViewier.ReportSource = rpt;
        }

        public void getTADAData(DataTable playerdata,DataTable staffdata,DataTable tournamentdata)
        {
            rpt = new ReportDocument();
            rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\TADAReport.rpt");
            rpt.Database.Tables["playerdata"].SetDataSource(playerdata);
            rpt.Database.Tables["staffdata"].SetDataSource(staffdata);
            rpt.Database.Tables["tournamentdata"].SetDataSource(tournamentdata);
            TADAReportViewer.ReportSource = rpt;
        }

        public void getResponsibilityData(DataTable playerdata, DataTable tournamentdata)
        {
            rpt = new ReportDocument();
            rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\ResponsibilityReport.rpt");
            rpt.Database.Tables["playerdata"].SetDataSource(playerdata);
            rpt.Database.Tables["tournamentdata"].SetDataSource(tournamentdata);
            ResponsibilityReportViewer.ReportSource = rpt;
        }

        public void getIDData(DataTable playerdata,DataTable staffdata,DataTable tournamentdata)
        {
            rpt = new ReportDocument();
            rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\IDCrystalReport.rpt");
            rpt.Database.Tables["playerdata"].SetDataSource(playerdata);
            rpt.Database.Tables["staffdata"].SetDataSource(staffdata);
            rpt.Database.Tables["tournamentdata"].SetDataSource(tournamentdata);
            IDReportViewer.ReportSource = rpt;
        }

        public void getKitDetails(DataTable playerdata, DataTable tournamentdata)
        {
            rpt = new ReportDocument();
            rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\KitReport.rpt");
            rpt.Database.Tables["playerdata"].SetDataSource(playerdata);
            rpt.Database.Tables["tournamentdata"].SetDataSource(tournamentdata);
            KitReportViewer.ReportSource = rpt;
        }
    }
}
