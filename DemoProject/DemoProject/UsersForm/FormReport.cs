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
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using CrystalDecisions.Windows.Forms;
using DemoProject.DAL;
using DemoProject.SO;

namespace DemoProject.UsersForm
{
    public partial class FormReport : Form
    {
        public FormReport(string _FileName)
        {
            InitializeComponent();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(System.IO.Directory.GetCurrentDirectory() + "\\CrystalReport\\" + _FileName);
            crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.SetDatabaseLogon(MyApp.gUserDB, MyApp.gPwdDB);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }
    }
}
