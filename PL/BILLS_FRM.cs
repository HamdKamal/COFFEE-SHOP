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
using System.Data.SqlClient;

namespace COFFEE_SHOP.FORMS
{
    public partial class BILLS_FRM : DevExpress.XtraEditors.XtraForm
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


        BL.BILLS B = new BL.BILLS();
        BL.TRANS TR = new BL.TRANS();
        void GET_ID()
        {
         if(RD_WORKER.Checked == true)
            {
                DataTable DT = new DataTable();
                DT = TR.GET_ID_BILLS();
                int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                TXT_ID.Text = id.ToString();
            }
         else if(RD_PLACE.Checked == true)
            {
                DataTable DT = new DataTable();
                DT = TR.GET_ID_BILLS_PLACE();
                int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
                TXT_ID.Text = id.ToString();
             }
           
        }
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);
          
        }

        void COMBO_place()
        {
            combo_place.DataSource = TR.get_place();
            combo_place.DisplayMember = "SUP_NAME";
            combo_place.ValueMember = "SUP_NAME";
        }

        void COMBO_workers()
        {
            combo_worker.DataSource =TR.get_workers();
            combo_worker.DisplayMember = "SUP_NAME";
            combo_worker.ValueMember = "SUP_NAME";
        }

        void COMBO_EMP()
        {
            combo_EMP.DataSource = B.GET_EMPLOYEE();
            combo_EMP.DisplayMember = "EMP_NAME";
            combo_EMP.ValueMember = "EMP_ID";
                               }
        void CHECK()
        {
            if (RD_PLACE.Checked == true)
            {
                combo_worker.Visible = false;
                combo_EMP.Visible = false;
                LBL_EMP.Visible = false;
                combo_place.Visible = true;
            }

            if (RD_WORKER.Checked == true)
            {
                combo_place.Visible = false;
                combo_worker.Visible = true;
                combo_EMP.Visible = true;
                LBL_EMP.Visible = true;
               
            }

            COMBO_EMP();
        }
        public BILLS_FRM()
        {
            InitializeComponent();
            
            GET_ID();
            sqlDataSource1.Fill();
            sqlDataSource2.Fill();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BILLS_FRM_Load(object sender, EventArgs e)
        {
            RD_PLACE.Checked = false;
            RD_WORKER.Checked = false;
            COMBO_place();
            COMBO_workers();
            BT_DEL.Enabled = false;
            BT_EDITE.Enabled = false;
            BT_SAVE.Enabled = false;


        }

        private void RD_PLACE_CheckedChanged(object sender, EventArgs e)
        {
            CHECK();
        }

        private void RD_WORKER_CheckedChanged(object sender, EventArgs e)
        {
            CHECK();
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if (RD_PLACE.Checked == true)
            {
                B.ADD_BILLS_PLACE(Convert.ToInt16(TXT_ID.Text), combo_place.Text, TXT_NOTE.Text, TXT_MONEY.Text, DATE_PAY.Text);
            }
            else
            {
                B.ADD_BILLS_EMP(Convert.ToInt16(TXT_ID.Text), combo_worker.Text, TXT_NOTE.Text, TXT_MONEY.Text, DATE_PAY.Text, Convert.ToInt32(combo_EMP.SelectedValue));
            }

            MessageBox.Show("تمت إضافة فاتورة الصرف", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            sqlDataSource2.Fill();
            BT_SAVE.Enabled = false;
        }

        private void BT_EDITE_Click(object sender, EventArgs e)
        { 
            if (RD_PLACE.Checked == true)
                    {
                B.EDITE_BILLS_PLACE(Convert.ToInt16(TXT_ID.Text), combo_place.Text, TXT_NOTE.Text, TXT_MONEY.Text, DATE_PAY.Text);
                            }
            else
            {
            B.EDITE_BILLS_EMP(Convert.ToInt16(TXT_ID.Text), combo_worker.Text, TXT_NOTE.Text, TXT_MONEY.Text, DATE_PAY.Text, Convert.ToInt32(combo_EMP.SelectedValue));
           }
            MessageBox.Show("تم تعديل فاتورة الصرف", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            sqlDataSource2.Fill();
            BT_EDITE.Enabled = false;
        }

        private void BT_DEL_Click(object sender, EventArgs e)
        {
            if (RD_PLACE.Checked == true)
            {
                B.del_bills_place(TXT_ID.Text);
            }
            else
            {
                B.del_bills_emp(TXT_ID.Text);
            }
               
            MessageBox.Show("تم حذف الفاتورة ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            sqlDataSource2.Fill();
            BT_DEL.Enabled = false;


        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            GET_ID();
            BT_DEL.Enabled = false;
            BT_EDITE.Enabled = false;
            BT_SAVE.Enabled = true;
        }
               
        private void GRID_PLACE_Click(object sender, EventArgs e)
        {
            
        }

        private void GRID_EMP_CLICK(object sender, EventArgs e)
        {
           
        }

        private void GRID_PLACE_Click_1(object sender, EventArgs e)
        {
            BT_DEL.Enabled = true;
            BT_EDITE.Enabled = true;
            BT_SAVE.Enabled = false;

            try
            {

                RD_PLACE.Checked = true;
                RD_WORKER.Checked = false;

                combo_worker.Visible = false;
                combo_EMP.Visible = false;
                LBL_EMP.Visible = false;
                combo_place.Visible = true;

                TXT_ID.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("معرف الصرف"));
                TXT_MONEY.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("المبلغ"));
                TXT_NOTE.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("ملاحظة"));
                combo_place.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("نوع الصرف"));
                DATE_PAY.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("التاريخ"));

            }
            catch
            {
                return;
            }
        }

        private void GRID_EMP_Click_1(object sender, EventArgs e)
        {
            BT_DEL.Enabled = true;
            BT_EDITE.Enabled = true;
            BT_SAVE.Enabled = false;

            try
            {
                RD_PLACE.Checked = false;
                RD_WORKER.Checked = true;

                combo_worker.Visible = true;
                combo_EMP.Visible = true;
                LBL_EMP.Visible = true;
                combo_place.Visible = false;

                TXT_ID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("معرف الصرف"));
                TXT_MONEY.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("المبلغ"));
                TXT_NOTE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ملاحظة"));
                combo_EMP.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("إسم الموظف"));
                combo_worker.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("نوع الصرف"));
                DATE_PAY.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("التاريخ"));

            }
            catch
            {
                return;
            }
        }

        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void S(object sender, EventArgs e)
        {

        }
    }
}