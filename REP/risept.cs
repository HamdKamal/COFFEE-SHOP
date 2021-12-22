using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


namespace COFFEE_SHOP.REP
{
    public partial class risept : DevExpress.XtraReports.UI.XtraReport
    {
        BL.TRANS TR = new BL.TRANS();
      //  risept r = new risept();
        public risept()
        {
            InitializeComponent();
        }

        private void XrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {


            string sit_tax = DetailReport.GetCurrentColumnValue("SIT").ToString();
            string ball_tax = DetailReport.GetCurrentColumnValue("Ball").ToString();
            int ID = Convert .ToInt32 ( Parameters["RSP_ID"].Value);
            
           TR.edit_rspt(ID,sit_tax, ball_tax);
        }
    }
}
