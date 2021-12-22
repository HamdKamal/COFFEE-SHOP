using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COFFEE_SHOP.PL;
using COFFEE_SHOP.BL;
using DevExpress.XtraReports.UI;
using COFFEE_SHOP.FORMS;


namespace COFFEE_SHOP.PL
{
    public partial class MAIN_FRM : DevExpress.XtraEditors.XtraForm
    {
        OPPREATION OPP = new OPPREATION();

        public Color COL = new Color();
        int id;

        public int Bo1, Bo2, bo3, bo4, bo5, bo6, bo7, bo8, bo9, bo10, bo11;

        static int ID_1 = 1;
        static int ID_2 = 2;
        static int ID_3 = 3;
        static int ID_4 = 4;
        static int ID_5 = 5;
        static int ID_6 = 6;
        static int ID_7 = 7;
        static int ID_8 = 8;
        static int ID_9 = 9;
        static int ID_10 = 10;
        static int ID_11 = 11;
        static int ID_12 = 12;
        static int ID_13 = 13;

        public int ID1, ID2, ID3, ID4, ID5, ID6, ID7, ID8, ID9, ID10,ID12,ID13;

        private void BT_3_Click(object sender, EventArgs e)
        {
            if (labelControl5.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID2 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID2.ToString();


                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID2, ID_3, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK2.BackColor = Color.Red;

                labelControl5.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_3.ToString();
                a.LBL_BILLS_ID.Text = ID2.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK2.BackColor == Color.Red)
            {


                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_3.ToString();
                a.LBL_BILLS_ID.Text = ID2.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void BT_4_Click(object sender, EventArgs e)
        {
            if (labelControl4.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID3 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = id.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID3, ID_4, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK4.BackColor = Color.Red;

                labelControl4.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_4.ToString();
                a.LBL_BILLS_ID.Text = ID3.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }

            else if (BT_CHECK4.BackColor == Color.Red)
            {
                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_4.ToString();
                a.LBL_BILLS_ID.Text = ID3.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            if (labelControl3.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID4 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID4.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID4, ID_5, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK5.BackColor = Color.Red;

                labelControl3.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_5.ToString();
                a.LBL_BILLS_ID.Text = ID4.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK5.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_5.ToString();
                a.LBL_BILLS_ID.Text = ID4.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            if (labelControl6.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID5 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID5.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID5, ID_6, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK6.BackColor = Color.Red;

                labelControl6.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_6.ToString();
                a.LBL_BILLS_ID.Text = ID5.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK6.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_6.ToString();
                a.LBL_BILLS_ID.Text = ID5.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            if (labelControl7.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID6 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID6.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID6, ID_7, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK7.BackColor = Color.Red;

                labelControl7.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_7.ToString();
                a.LBL_BILLS_ID.Text = ID6.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK7.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_7.ToString();
                a.LBL_BILLS_ID.Text = ID6.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            if (labelControl8.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID7 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID7.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID7, ID_8, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK8.BackColor = Color.Red;

                labelControl8.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_8.ToString();
                a.LBL_BILLS_ID.Text = ID7.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK8.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_8.ToString();
                a.LBL_BILLS_ID.Text = ID7.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            if (labelControl9.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID8 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID8.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID8, ID_9, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK9.BackColor = Color.Red;

                labelControl9.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_9.ToString();
                a.LBL_BILLS_ID.Text = ID8.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK9.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_9.ToString();
                a.LBL_BILLS_ID.Text = ID8.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            if (labelControl10.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID9 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID9.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID9, ID_10, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK10.BackColor = Color.Red;

                labelControl10.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_10.ToString();
                a.LBL_BILLS_ID.Text = ID9.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK10.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_10.ToString();
                a.LBL_BILLS_ID.Text = ID9.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void BT_IRAD_Click(object sender, EventArgs e)
        {
            Irad ird = new Irad();
            ird.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            REP.products RT = new REP.products();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            REP.workers RT = new REP.workers();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            REP.XtraReport1 RT = new REP.XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            if (labelControl11.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID10 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID10.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID10, ID_11, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK11.BackColor = Color.Red;

                labelControl11.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_11.ToString();
                a.LBL_BILLS_ID.Text = ID10.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK11.BackColor == Color.Red)
            {

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_11.ToString();
                a.LBL_BILLS_ID.Text = ID10.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            if (labelControl1.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = id.ToString();


                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(id, ID_1, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK.BackColor = Color.Red;
              
                labelControl1.Text = "محجوز";
               
                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_1.ToString();
                a.LBL_BILLS_ID.Text = id.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();

               // splashScreenManager1.ShowWaitForm();
                
                a.ShowDialog();
            }
            else if (BT_CHECK.BackColor == Color.Red)
            {
                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_1.ToString();
                a.LBL_BILLS_ID.Text = id.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID12 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = ID12.ToString();


                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID12, ID_12, Convert.ToDateTime(LBL_TIME_IN.Text));
                
              

                ORDERS_FRM a = new ORDERS_FRM(this);

                a.LBL_ROM_ID.Text = ID_12.ToString();
                a.LBL_BILLS_ID.Text = ID12.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
                                   
        }

        private void BT_2_Click(object sender, EventArgs e)
        {
            if (labelControl2.Text == "غير محجوز")
            {

                DataTable DT = new DataTable();
                DT = OPP.GET_ID_RSP();
                ID1 = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                LBL_RST_ID.Text = id.ToString();

                LBL_TIME_IN.Text = DateTime.Now.ToString();
                OPP.CREATE_RSPT(ID1, ID_2, Convert.ToDateTime(LBL_TIME_IN.Text));
                BT_CHECK1.BackColor = Color.Red;

                labelControl2.Text = "محجوز";

                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_2.ToString();
                a.LBL_BILLS_ID.Text = ID1.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
            else if (BT_CHECK1.BackColor == Color.Red)
            {
                ORDERS_FRM a = new ORDERS_FRM(this);
                a.LBL_ROM_ID.Text = ID_2.ToString();
                a.LBL_BILLS_ID.Text = ID1.ToString();
                a.LBL_TIME.Text = DateTime.Now.ToShortTimeString();
                a.ShowDialog();
            }
        }

     



        public MAIN_FRM()
        {
            InitializeComponent();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ADD_ORDERS FRM = new ADD_ORDERS();
            FRM.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            product FRM = new product();
            FRM.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Categures FRM = new Categures();
            FRM.ShowDialog();
        }

        private void MAIN_FRM1_Load(object sender, EventArgs e)
        {
           
            TIMEEDITE1.Text = DateTime.Now.ToShortTimeString();
            
            if (LBL_VIS.Text == "USER")
            {
                barButtonItem2.Enabled = false;
                barButtonItem12.Enabled = false;
                barButtonItem10.Enabled = false;
                barButtonItem13.Enabled = false;
                barButtonItem5.Enabled = false;
                barButtonItem6.Enabled = false;
                barButtonItem7.Enabled = false;
                barButtonItem9.Enabled = false;
                barButtonItem18.Enabled = false;
                barButtonItem3.Enabled = false;
                barButtonItem1.Enabled = false;
                barButtonItem8.Enabled = false;
                barButtonItem4.Enabled = false;

            }
        }

        private void MAIN_FRM1_Paint(object sender, PaintEventArgs e)
        {
        //  BT_CHECK.BackColor = COL;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sub_categore FRM = new sub_categore();
            FRM.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BILLS_FRM FRM = new BILLS_FRM();
            FRM.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EMPLOYEE_FRM FRM = new EMPLOYEE_FRM();
            FRM.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ADD_USER FRM = new ADD_USER();
            FRM.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BAK_RES FRM = new BAK_RES();
            FRM.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ABOUT_SYS FRM = new ABOUT_SYS();
            FRM.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ABOUT_US FRM = new ABOUT_US();
            FRM.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("  هل تريد تسجيل الخروج  ", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            REP.daily RT = new REP.daily();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            REP.XtraReport2 RT = new REP.XtraReport2();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }
    }
}