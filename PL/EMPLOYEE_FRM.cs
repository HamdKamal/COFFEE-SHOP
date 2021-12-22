using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using COFFEE_SHOP.PL;
using COFFEE_SHOP.FORMS;


namespace COFFEE_SHOP.FORMS
{
    public partial class EMPLOYEE_FRM : DevExpress.XtraEditors.XtraForm
    {
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
        BL.TRANS TR = new BL.TRANS();
        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = TR.GET_EMP_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_ID.Text = id.ToString();
        }
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);
            PIC_EMP.Image = null;
        }
        public EMPLOYEE_FRM()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }

        private void EMPLOYEE_FRM_Load(object sender, EventArgs e)
        {
            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = false;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] pictuer;
                if (PIC_EMP.Image == null)
                {
                    pictuer = new byte[0];
                    TR.add_EMPLOYEE(Convert.ToInt16(TXT_ID.Text),TXT_NAME.Text,TXT_SALARY.Text,TXT_STAY.Text,TXT_PHONE.Text,DATE_EMP.DateTime.Date,pictuer,TXT_NOTE.Text, "without_image");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    PIC_EMP.Image.Save(ms, PIC_EMP.Image.RawFormat);
                    pictuer = ms.ToArray();
                    TR.add_EMPLOYEE(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text, TXT_SALARY.Text, TXT_STAY.Text, TXT_PHONE.Text, DATE_EMP.DateTime.Date, pictuer, TXT_NOTE.Text, "with_image");
                   
                }

            }
            catch
            {
                return;
            }
            MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_SAVE.Enabled = false;

            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
           
        }

        private void PIC_EMP_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PIC_EMP.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void BT_DEL_Click(object sender, EventArgs e)
        {
            TR.DELETE_EMPLOYEE(Convert.ToInt16(TXT_ID.Text));
            MessageBox.Show("تم حذف بيانات الموظف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_DEL.Enabled = false;
         
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = false ;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] pictuer;
                if (PIC_EMP.Image == null)
                {
                    pictuer = new byte[0];
                    TR.EDITE_EMPLOYEE(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text, TXT_SALARY.Text, TXT_STAY.Text, TXT_PHONE.Text, DATE_EMP.DateTime.Date, pictuer, TXT_NOTE.Text, "without_image");
                     }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    PIC_EMP.Image.Save(ms, PIC_EMP.Image.RawFormat);
                    pictuer = ms.ToArray();
                    TR.EDITE_EMPLOYEE(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text, TXT_SALARY.Text, TXT_STAY.Text, TXT_PHONE.Text, DATE_EMP.DateTime.Date, pictuer, TXT_NOTE.Text, "with_image");
                      }

            }
            catch
            {
                return;
            }
            MessageBox.Show("تم تعديل بيانات الموظف ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_EDIT.Enabled = false;
            BT_DEL.Enabled = false;
          
            BT_SAVE.Enabled = false ;
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            GET_ID();
            sqlDataSource1.Fill();

            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = true ;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void GR_EMP_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void GR_EMP_Click(object sender, EventArgs e)
        {
            BT_DEL.Enabled = true ;
            BT_EDIT.Enabled = true ;
            BT_SAVE.Enabled = false;

            try
            {
                PIC_EMP.Image = null;
                TXT_ID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("معرف الموظف"));
                TXT_NAME.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("إسم الموظف"));
                TXT_SALARY.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("المرتب"));
                TXT_STAY.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم الإقامة"));
                TXT_PHONE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم الهاتف"));
                TXT_NOTE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ملاحظة"));
                DATE_EMP.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("التاريخ"));
                byte[] pic = (byte[])gridView1.GetFocusedRowCellValue("صورة الموظف");
                MemoryStream MS = new MemoryStream(pic);
                PIC_EMP.Image = Image.FromStream(MS);
            }
            catch
            {
                return;
            }
        }

        private void TXT_SALARY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_STAY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_PHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}