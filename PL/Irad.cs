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

namespace COFFEE_SHOP.PL
{
    public partial class Irad : DevExpress.XtraEditors.XtraForm
    {
        BL.ORDERS ord = new BL.ORDERS();

        public void JustNumber(KeyPressEventArgs r)
        {
            if (!char.IsDigit(r.KeyChar))
            {
                if (!char.IsControl(r.KeyChar))
                {
                    if (!char.IsPunctuation(r.KeyChar))
                    {
                        if (!char.IsWhiteSpace(r.KeyChar))
                        {
                            if (!char.IsSeparator(r.KeyChar))
                                r.Handled = true;
                        }
                    }
                }
            }
        }

        public Irad()
        {
            InitializeComponent();
        }

        private void Irad_Load(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_NAME.Text == string.Empty && TXT_PRICE.Text == string.Empty && DATE_PRD.Text == string.Empty)
            {
                MessageBox.Show("الرجاء التأكد من الحقول المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                ord.add_irad(TXT_NAME.Text, TXT_NOTE.Text, DATE_PRD.DateTime.Date, TXT_PRICE.Text);
                MessageBox.Show("تمت إضافة الإيراد", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TXT_NAME.Text = "";
            TXT_NOTE.Text = "";
            TXT_PRICE.Text = "";
            DATE_PRD.Text = "";
        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXT_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}