using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace COFFEE_SHOP.PL
{
    public partial class SYS_Confiq : DevExpress.XtraEditors.XtraForm
    {
        
        public SYS_Confiq()
        {
            InitializeComponent();
        }

        private void BT_SAVE_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Server = TXT_SERVER.Text;
            Properties.Settings.Default.DataBase = TXT_BASE.Text;
            Properties.Settings.Default.Mode = RB_WIN.Checked == true ? "Windows" : "Windows";
            Properties.Settings.Default.Counter += 1;
            Properties.Settings.Default.Save();
                             
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["Aim-Connection"].ConnectionString = "XpoProvider=MSSqlServer;data source='" + TXT_SERVER.Text + "';integrated security=SSPI;initial catalog='" + TXT_BASE.Text + "'";
            config.Save(ConfigurationSaveMode.Modified,true);
            ConfigurationManager.RefreshSection("connectionStrings");

            config.ConnectionStrings.ConnectionStrings["localhost_Coffee_Shop_Connection"].ConnectionString = "XpoProvider=MSSqlServer;data source='" + TXT_SERVER.Text + "';integrated security=SSPI;initial catalog='" + TXT_BASE.Text + "'";
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            config.ConnectionStrings.ConnectionStrings["Coon-1"].ConnectionString = "XpoProvider=MSSqlServer;data source='" + TXT_SERVER.Text + "';integrated security=SSPI;initial catalog='" + TXT_BASE.Text + "'";
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("تم ربط الإتصال بنجاح", "الإتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SYS_Confiq_Load(object sender, System.EventArgs e)
        {
            TXT_SERVER.Text = Properties.Settings.Default.Server;
            TXT_BASE.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode == "Windows")
                RB_WIN.Checked = true;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}