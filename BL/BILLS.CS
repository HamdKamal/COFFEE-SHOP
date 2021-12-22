using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COFFEE_SHOP.PL;
using COFFEE_SHOP.BL;


namespace COFFEE_SHOP.BL
{
    class BILLS
    {
        public void ADD_BILLS_EMP(int B_ID, string B_TYPE, string B_NOTE, string B_MONEY, string B_DATE, int EMP_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@B_TYPE", SqlDbType.NVarChar, 50);
            parm[1].Value = B_TYPE;

            parm[2] = new SqlParameter("@B_NOTE", SqlDbType.NVarChar, 50);
            parm[2].Value = B_NOTE;

            parm[3] = new SqlParameter("@B_MONEY", SqlDbType.Money);
            parm[3].Value = B_MONEY;

            parm[4] = new SqlParameter("@B_DATE", SqlDbType.Date);
            parm[4].Value = B_DATE;

            parm[5] = new SqlParameter("@EMP_ID", SqlDbType.Int);
            parm[5].Value = EMP_ID;


            DAL.ExecuteCommand("ADD_BILLS_EMP", parm);
            DAL.close();
        }

        public void EDITE_BILLS_EMP(int B_ID, string B_TYPE, string B_NOTE, string B_MONEY, string B_DATE, int EMP_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@B_TYPE", SqlDbType.NVarChar, 50);
            parm[1].Value = B_TYPE;

            parm[2] = new SqlParameter("@B_NOTE", SqlDbType.NVarChar, 50);
            parm[2].Value = B_NOTE;

            parm[3] = new SqlParameter("@B_MONEY", SqlDbType.Money);
            parm[3].Value = B_MONEY;

            parm[4] = new SqlParameter("@B_DATE", SqlDbType.Date);
            parm[4].Value = B_DATE;

            parm[5] = new SqlParameter("@EMP_ID", SqlDbType.Int);
            parm[5].Value = EMP_ID;


            DAL.ExecuteCommand("EDITE_BILLS_EMP", parm);
            DAL.close();
        }

        public void del_bills_emp(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parm[0].Value = ID;

            DAL.ExecuteCommand("del_bills_emp", parm);
            DAL.close();
        }

        public DataTable GET_EMPLOYEE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_EMPLOYEE", param);
            DAL.close();
            return Dt;
        }

        /// this secition for bills place .....

        public void ADD_BILLS_PLACE(int B_ID, string B_TYPE, string B_NOTE, string B_MONEY, string B_DATE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@B_TYPE", SqlDbType.NVarChar, 50);
            parm[1].Value = B_TYPE;

            parm[2] = new SqlParameter("@B_NOTE", SqlDbType.NVarChar, 50);
            parm[2].Value = B_NOTE;

            parm[3] = new SqlParameter("@B_MONEY", SqlDbType.Money);
            parm[3].Value = B_MONEY;

            parm[4] = new SqlParameter("@B_DATE", SqlDbType.Date);
            parm[4].Value = B_DATE;


            DAL.ExecuteCommand("ADD_BILLS_PLACE", parm);
            DAL.close();
        }

        public void EDITE_BILLS_PLACE(int B_ID, string B_TYPE, string B_NOTE, string B_MONEY, string B_DATE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@B_TYPE", SqlDbType.NVarChar, 50);
            parm[1].Value = B_TYPE;

            parm[2] = new SqlParameter("@B_NOTE", SqlDbType.NVarChar, 50);
            parm[2].Value = B_NOTE;

            parm[3] = new SqlParameter("@B_MONEY", SqlDbType.Money);
            parm[3].Value = B_MONEY;

            parm[4] = new SqlParameter("@B_DATE", SqlDbType.Date);
            parm[4].Value = B_DATE;

            DAL.ExecuteCommand("EDITE_BILLS_PLACE", parm);
            DAL.close();
        }

        public void del_bills_place(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parm[0].Value = ID;

            DAL.ExecuteCommand("del_bills_place", parm);
            DAL.close();
        }
        public void ADD_GATE(int ID,string G_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;
            parm[1] = new SqlParameter("@G_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = G_NAME;

            DAL.ExecuteCommand("ADD_GATE", parm);
            DAL.close();
        }

        public void EDIT_GATE(string G_NAME, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@G_NAME", SqlDbType.NVarChar, 50);
            parm[0].Value = G_NAME;

            parm[1] = new SqlParameter("@ID", SqlDbType.Int);
            parm[1].Value = ID;

            DAL.ExecuteCommand("EDIT_GATE", parm);
            DAL.close();
        }
        public void DEL_GATE(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;

            DAL.ExecuteCommand("DEL_GATE", parm);
            DAL.close();
        }
        public DataTable GET_GATE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_GATE", param);
            DAL.close();
            return Dt;
        }
        public void ADD_S_GATE(string G_NAME, int S_ID,int CAT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@G_NAME", SqlDbType.NVarChar, 50);
            parm[0].Value = G_NAME;

            parm[1] = new SqlParameter("@S_ID", SqlDbType.Int);
            parm[1].Value = S_ID;

            parm[2] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            parm[2].Value = CAT_ID;

            DAL.ExecuteCommand("ADD_S_GATE", parm);
            DAL.close();
        }
        public void EDITE_S_GATE(string G_NAME, int S_ID, int CAT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@G_NAME", SqlDbType.NVarChar, 50);
            parm[0].Value = G_NAME;

            parm[1] = new SqlParameter("@S_ID", SqlDbType.Int);
            parm[1].Value = S_ID;

            parm[2] = new SqlParameter("@CAT_ID", SqlDbType.Int);
            parm[2].Value = CAT_ID;

            DAL.ExecuteCommand("EDITE_S_GATE", parm);
            DAL.close();
        }
    }

    }
