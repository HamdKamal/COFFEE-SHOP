using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COFFEE_SHOP.PL;
using System.Windows.Forms;

namespace COFFEE_SHOP.BL
{
    class LOGIN
    {
        public DataTable Login(string U_NAME, string U_PASS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@U_NAME", SqlDbType.NVarChar, 50);
            param[0].Value = U_NAME;

            param[1] = new SqlParameter("@U_PASS", SqlDbType.NVarChar, 50);
            param[1].Value = U_PASS;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("LOG", param);
            DAL.close();
            return Dt;
        }

        public void ADD_USER(int ID, string U_NAME, string U_FULL, string U_TYPE,string U_PASS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@U_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = U_NAME;

            parm[2] = new SqlParameter("@U_FULL", SqlDbType.NVarChar, 50);
            parm[2].Value = U_FULL;

            parm[3] = new SqlParameter("@U_TYPE", SqlDbType.NVarChar, 50);
            parm[3].Value = U_TYPE;

            parm[4] = new SqlParameter("@U_PASS", SqlDbType.NVarChar, 50);
            parm[4].Value = U_PASS;

            DAL.ExecuteCommand("ADD_USER", parm);
            DAL.close();
        }

        public void EDITE_USER(int ID, string U_NAME, string U_FULL, string U_TYPE, string U_PASS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@U_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = U_NAME;

            parm[2] = new SqlParameter("@U_FULL", SqlDbType.NVarChar, 50);
            parm[2].Value = U_FULL;

            parm[3] = new SqlParameter("@U_TYPE", SqlDbType.NVarChar, 50);
            parm[3].Value = U_TYPE;

            parm[4] = new SqlParameter("@U_PASS", SqlDbType.NVarChar, 50);
            parm[4].Value = U_PASS;

            DAL.ExecuteCommand("EDITE_USER", parm);
            DAL.close();
        }
        public void DEL_USER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;

            DAL.ExecuteCommand("DEL_USER", parm);
            DAL.close();
        }

        public DataTable GET_ID_USER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_USER", param);
            DAL.close();
            return Dt;
        }
       
    }


}
