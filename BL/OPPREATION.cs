using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace COFFEE_SHOP.BL
{
    class OPPREATION
    {
        public void CREATE_RSPT(int R_ID,int ROM_ID,DateTime TIMER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@R_ID", SqlDbType.Int);
            parm[0].Value = R_ID;

            parm[1] = new SqlParameter("@ROM_ID", SqlDbType.Int);
            parm[1].Value = ROM_ID;

            parm[2] = new SqlParameter("@TIMER", SqlDbType.DateTime);
            parm[2].Value = TIMER;

            DAL.ExecuteCommand("CREATE_RSPT", parm);
            DAL.close();
        }
        public DataTable GET_ID_RSP()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_RSP", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ID_RP(String TIMER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TIMER", SqlDbType.VarChar, 50);
            param[0].Value = TIMER;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_RP", param);
            DAL.close();
            return Dt;
        }

        public void ADD_ORD_DIT(int BILLS_ID, int ORD_ID, int QUN,string tot)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@BILLS_ID", SqlDbType.Int);
            parm[0].Value = BILLS_ID;

            parm[1] = new SqlParameter("@ORD_ID", SqlDbType.Int);
            parm[1].Value = ORD_ID;

            parm[2] = new SqlParameter("@QUN", SqlDbType.Int);
            parm[2].Value = QUN;

            parm[3] = new SqlParameter("@tot", SqlDbType.Money);
            parm[3].Value = tot;

            DAL.ExecuteCommand("ADD_ORD_DIT", parm);
            DAL.close();
        }

        public DataTable GET_BILL_ID_DIT(int BILLS_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            DataTable Dt = new DataTable();

            param[0] = new SqlParameter("@BILLS_ID", SqlDbType.Int);
            param[0].Value = BILLS_ID;

            Dt = DAL.selectData("GET_BILL_ID_DIT", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ID_IN_TRUE_CACE(String TM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TM", SqlDbType.DateTime);
            param[0].Value = TM;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_IN_TRUE_CACE", param);
            DAL.close();
            return Dt;
        }
        public void DELETE_orders_id(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            DAL.ExecuteCommand("DELETE_orders_id", parm);
            DAL.close();
        }

        public void dele_ricpt(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;

            DAL.ExecuteCommand("dele_ricpt", parm);
            DAL.close();
        }
        public DataTable GET_ID_order_no(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_order_no", param);
            DAL.close();
            return Dt;
        }

    }
}
