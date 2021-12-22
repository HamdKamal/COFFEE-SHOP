using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using COFFEE_SHOP.PL;
using COFFEE_SHOP.FORMS;
using System.Data.SqlClient;

namespace COFFEE_SHOP.BL
{
    class ORDERS
    {
        public void add_orders(int ord_id, string ord_name, int cat_id,string  ord_price , int ord_vat, string ord_tax,DateTime ord_date, byte[] ord_pic, string note,string check,String ord_name_EN,string vat_cash)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];

            parm[0] = new SqlParameter("@ord_id", SqlDbType.Int);
            parm[0].Value = ord_id;

            parm[1] = new SqlParameter("@ord_name", SqlDbType.NVarChar, 50);
            parm[1].Value = ord_name;

            parm[2] = new SqlParameter("@cat_id", SqlDbType.Int);
            parm[2].Value = cat_id;

            parm[3] = new SqlParameter("@ord_price", SqlDbType.NVarChar,25);
            parm[3].Value = ord_price;

            parm[4] = new SqlParameter("@ord_vat", SqlDbType.Int);
            parm[4].Value = ord_vat;

            parm[5] = new SqlParameter("@ord_tax", SqlDbType.NVarChar,25);
            parm[5].Value = ord_tax;

            parm[6] = new SqlParameter("@ord_date", SqlDbType.Date);
            parm[6].Value = ord_date;

            parm[7] = new SqlParameter("@ord_pic", SqlDbType.Image);
            parm[7].Value = ord_pic;

            parm[8] = new SqlParameter("@note", SqlDbType.NVarChar ,50);
            parm[8].Value = note;

            parm[9] = new SqlParameter("@check", SqlDbType.NVarChar, 50);
            parm[9].Value = check;

            parm[10] = new SqlParameter("@ord_name_EN", SqlDbType.NVarChar, 50);
            parm[10].Value = ord_name_EN;

            parm[11] = new SqlParameter("@vat_cash", SqlDbType.NVarChar, 25);
            parm[11].Value = vat_cash;

            DAL.ExecuteCommand("add_orders", parm);
            DAL.close();
        }

        public void EDITE_orders(int ord_id, string ord_name, int cat_id, string ord_price, int ord_vat, string ord_tax, DateTime ord_date, byte[] ord_pic, string note, string check, String ord_name_EN,string vat_cash)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];

            parm[0] = new SqlParameter("@ord_id", SqlDbType.Int);
            parm[0].Value = ord_id;

            parm[1] = new SqlParameter("@ord_name", SqlDbType.NVarChar, 50);
            parm[1].Value = ord_name;

            parm[2] = new SqlParameter("@cat_id", SqlDbType.Int);
            parm[2].Value = cat_id;

            parm[3] = new SqlParameter("@ord_price", SqlDbType.NVarChar, 25);
            parm[3].Value = ord_price;

            parm[4] = new SqlParameter("@ord_vat", SqlDbType.Int);
            parm[4].Value = ord_vat;

            parm[5] = new SqlParameter("@ord_tax", SqlDbType.NVarChar, 25);
            parm[5].Value = ord_tax;

            parm[6] = new SqlParameter("@ord_date", SqlDbType.Date);
            parm[6].Value = ord_date;

            parm[7] = new SqlParameter("@ord_pic", SqlDbType.Image);
            parm[7].Value = ord_pic;

            parm[8] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            parm[8].Value = note;

            parm[9] = new SqlParameter("@check", SqlDbType.NVarChar, 50);
            parm[9].Value = check;

            parm[10] = new SqlParameter("@ord_name_EN", SqlDbType.NVarChar, 50);
            parm[10].Value = ord_name_EN;

            parm[11] = new SqlParameter("@vat_cash", SqlDbType.NVarChar, 25);
            parm[11].Value = vat_cash;

            DAL.ExecuteCommand("EDITE_orders", parm);
            DAL.close();
        }

        public void DELETE_orders(int ord_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ord_id", SqlDbType.Int);
            parm[0].Value = ord_id;

            DAL.ExecuteCommand("DELETE_orders", parm);
            DAL.close();
        }
        public void add_irad(String name, string not, DateTime date_ird, string price)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@not", SqlDbType.NVarChar, 50);
            parm[1].Value = not;

            parm[2] = new SqlParameter("@date_ird", SqlDbType.Date);
            parm[2].Value = date_ird;

            parm[3] = new SqlParameter("@price", SqlDbType.NVarChar, 25);
            parm[3].Value = price;

           
            DAL.ExecuteCommand("add_irad", parm);
            DAL.close();
        }

    }
}
