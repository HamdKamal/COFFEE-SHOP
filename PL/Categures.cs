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
using COFFEE_SHOP.FORMS;
using System.Data.SqlClient;

namespace COFFEE_SHOP
{
    public partial class Categures : DevExpress.XtraEditors.XtraForm
    {
        BL.BILLS B = new BL.BILLS();
        BL.TRANS TR = new BL.TRANS();

        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = TR.GET_CAT_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            CO_ID.Text = id.ToString();
        }
        public Categures()
        {
            InitializeComponent();
            
            sqlDataSource1.Fill();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            bt_name.Text = "";
            CO_ID.Text = "";
            GET_ID();

            bt_del.Enabled = false;
            bt_edite.Enabled = false ;
            bt_save.Enabled = true;

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            B.ADD_GATE(Convert.ToInt16(CO_ID.Text),bt_name.Text);
            MessageBox.Show("تمت إضافة الفئة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bt_name.Text = "";
            CO_ID.Text = "";
            sqlDataSource1.Fill();
            bt_save.Enabled = false;
        }

        private void bt_edite_Click(object sender, EventArgs e)
        {
            B.EDIT_GATE(bt_name.Text, Convert.ToInt16(CO_ID.Text));
            MessageBox.Show("تم تعديل الفئة ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bt_name.Text = "";
            CO_ID.Text = "";
            sqlDataSource1.Fill();
            bt_edite.Enabled = false;
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            B.DEL_GATE(Convert.ToInt16(CO_ID.Text));
            MessageBox.Show("تم حذف الفئة ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bt_name.Text = "";
            CO_ID.Text = "";
            sqlDataSource1.Fill();
            bt_del.Enabled = false;
        }

        private void GRID_CATE_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void GRID_CATE_Click(object sender, EventArgs e)
        {
            bt_del.Enabled = true;
            bt_edite.Enabled = true;
            bt_save.Enabled = false;

            bt_name.Text = "";
            CO_ID.Text = "";
            bt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("إسم الفئة"));
            CO_ID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("معرف الفئة"));
        }

        private void Categures_Load(object sender, EventArgs e)
        {
            bt_del.Enabled = false;
            bt_edite.Enabled = false;
            bt_save.Enabled = false;

        }
    }
}