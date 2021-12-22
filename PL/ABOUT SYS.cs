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

namespace COFFEE_SHOP.FORMS
{
    public partial class ABOUT_SYS : DevExpress.XtraEditors.XtraForm
    {
        public ABOUT_SYS()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bttnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTE: This application was created by:Smart Vision Information Technology\n/Project Developer/System Analysit/Technician.\n\n[ APPLICATION TOOLS USED: ]\nProgramming Language: C#.Net 2015\nBack End Database: MS Sql Server 2012\nGraphics Designed: DEV Express 17.2.1\n\n[ SVIT - makers of high quality softwares. ]\n", "Short Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}