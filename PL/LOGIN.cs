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
using COFFEE_SHOP.FORMS;


namespace COFFEE_SHOP.PL
{
    public partial class LOGIN : DevExpress.XtraEditors.XtraForm
    {
        MAIN_FRM FM = new MAIN_FRM();
     
        BL.LOGIN LOG = new BL.LOGIN();
        string log_name;
        public void check()
        {
            string lo_name = TXTNAME.Text;
            string lo_pass = TXTPASS.Text;
          

            if (TXTNAME.Text == string.Empty | TXTPASS.Text == string.Empty)
            {
                MessageBox.Show("!يوجد خطأ في تسجيل الدخول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable DT = LOG.Login(TXTNAME.Text, TXTPASS.Text);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][2].ToString() == "ADMIN")
                {
                   log_name = DT.Rows[0]["USER_FULLNAME"].ToString();
                    FM.LBL_VIS.Text = "ADMIN";
                    FM.lbl_name_log.Text = log_name.ToString();
                    this.Hide();
                    FM.ShowDialog();
                 
                }
            }
            if (DT.Rows.Count > 0)
            {
              if  (DT.Rows[0][2].ToString() == "USER")
                {
                    log_name = DT.Rows[0]["USER_FULLNAME"].ToString();
                    FM.lbl_name_log.Text = log_name.ToString();
                    FM.LBL_VIS.Text = "USER";
                    this.Hide();
                    FM.ShowDialog();
                  
                }
            }
            else
                MessageBox.Show("!فشل تسجيل الدخول", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        public LOGIN()
        {
            InitializeComponent();
        }

              private void LOGIN_Load(object sender, EventArgs e)
        {
            try
                {
                    if (Properties.Settings.Default.Counter >= 1)
                        return;
                    else if (Properties.Settings.Default.Counter == 0)
                    {
                        SYS_Confiq SYS = new SYS_Confiq();
                        SYS.ShowDialog();
                        this.Hide();
                    }
                }
            catch (Exception)
            {
                    MessageBox.Show("فشل الإتصال بالسيرفر");
            }
                TXTNAME.Focus();
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            check();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    