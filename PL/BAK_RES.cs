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
using System.Data.SqlClient;


namespace COFFEE_SHOP.FORMS
{
    public partial class BAK_RES : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlconn = new SqlConnection(@"server= KIMO-1317\SQLEXPRESS; Database=Coffee_Shop; integrated Security=true");
        SqlCommand CMD;

        public BAK_RES()
        {
            InitializeComponent();
        }

        private void BAK_RES_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TXTFILE.BackColor = Color.White;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TXTFILE.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void BT_BAK_Click(object sender, EventArgs e)
        {
            if (TXTFILE.Text == "")
            {
                TXTFILE.BackColor = Color.Red;
                return;
            }
            string filename = TXTFILE.Text + "//COFFEE_SHOPE" + DateTime.Now.ToLongDateString().Replace('/', '-') + " ^ " + DateTime.Now.ToShortTimeString().Replace(':', '-');

            string strqry = "Backup Database Coffee_Shop to Disk ='" + filename + ".bak'";
            CMD = new SqlCommand(strqry,sqlconn);
            sqlconn.Open();
            CMD.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("تم عمل النسخة الإحتياطية بنجاح", "عمل نسخة  إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXTFILE.Text = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            TXTFILE1.BackColor = Color.White;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                TXTFILE1.Text = openFileDialog1.FileName;
            }
        }

        private void BT_RES_Click(object sender, EventArgs e)
        {
            if (TXTFILE1.Text == "")
            {
                TXTFILE1.BackColor = Color.Red;
                return;
            }
            string strqry = "ALTER Database Coffee_Shop SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Coffee_Shop From Disk ='" + TXTFILE1.Text + "'";
            CMD = new SqlCommand(strqry, sqlconn);
            sqlconn.Open();
            CMD.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح", "إستعادة نسخة  إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXTFILE1.Text = "";
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            TXTFILE.Text = "";
            TXTFILE1.Text = "";
        
            }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }
    }
    
}