using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using COFFEE_SHOP.FORMS;
using COFFEE_SHOP.PL;
using System.Data;

namespace COFFEE_SHOP.BL
{
    class TRANS
    {
        public void add_EMPLOYEE(int EMP_id, string EMP_name,string EMP_SALARY,string EMP_ST,string EMP_TEL, DateTime EMP_date, byte[] EMP_pic, string note, string check)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@EMP_id", SqlDbType.Int);
            parm[0].Value = EMP_id;

            parm[1] = new SqlParameter("@EMP_name", SqlDbType.NVarChar, 50);
            parm[1].Value = EMP_name;

            parm[2] = new SqlParameter("@EMP_ST", SqlDbType.NVarChar , 50 );
            parm[2].Value = EMP_ST;

            parm[3] = new SqlParameter("@EMP_SALARY", SqlDbType.Money);
            parm[3].Value = EMP_SALARY;

            parm[4] = new SqlParameter("@EMP_date", SqlDbType.Date);
            parm[4].Value = EMP_date;

            parm[5] = new SqlParameter("@EMP_pic", SqlDbType.Image);
            parm[5].Value = EMP_pic;

            parm[6] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            parm[6].Value = note;

            parm[7] = new SqlParameter("@EMP_TEL", SqlDbType.VarChar, 50);
            parm[7].Value = EMP_TEL;

            parm[8] = new SqlParameter("@check", SqlDbType.NVarChar, 50);
            parm[8].Value = check;

            DAL.ExecuteCommand("add_EMPLOYEE", parm);
            DAL.close();
        }

        public void EDITE_EMPLOYEE(int EMP_id, string EMP_name, string EMP_SALARY, string EMP_ST, string EMP_TEL, DateTime EMP_date, byte[] EMP_pic, string note, string check)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@EMP_id", SqlDbType.Int);
            parm[0].Value = EMP_id;

            parm[1] = new SqlParameter("@EMP_name", SqlDbType.NVarChar, 50);
            parm[1].Value = EMP_name;

            parm[2] = new SqlParameter("@EMP_ST", SqlDbType.NVarChar, 50);
            parm[2].Value = EMP_ST;

            parm[3] = new SqlParameter("@EMP_SALARY", SqlDbType.Money);
            parm[3].Value = EMP_SALARY;

            parm[4] = new SqlParameter("@EMP_date", SqlDbType.Date);
            parm[4].Value = EMP_date;

            parm[5] = new SqlParameter("@EMP_pic", SqlDbType.Image);
            parm[5].Value = EMP_pic;

            parm[6] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            parm[6].Value = note;

            parm[7] = new SqlParameter("@EMP_TEL", SqlDbType.VarChar, 50);
            parm[7].Value = EMP_TEL;

            parm[8] = new SqlParameter("@check", SqlDbType.NVarChar, 50);
            parm[8].Value = check;

            DAL.ExecuteCommand("EDITE_EMPLOYEE", parm);
            DAL.close();
        }

        public void DELETE_EMPLOYEE(int EMP_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@EMP_id", SqlDbType.Int);
            parm[0].Value = EMP_id;

            DAL.ExecuteCommand("DELETE_EMPLOYEE", parm);
            DAL.close();
        }
        public void ADD_PRODUCT(int PRD_ID, string PRD_NAME, string PRD_PRIC, string PRD_NOTE,DateTime PRD_DATE,DateTime exd,int qun,int ID_CAT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[8];

            parm[0] = new SqlParameter("@PRD_ID", SqlDbType.Int);
            parm[0].Value = PRD_ID;

            parm[1] = new SqlParameter("@PRD_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = PRD_NAME;

            parm[2] = new SqlParameter("@PRD_PRIC", SqlDbType.Money);
            parm[2].Value = PRD_PRIC;

            parm[3] = new SqlParameter("@PRD_NOTE", SqlDbType.NVarChar , 50);
            parm[3].Value = PRD_NOTE;

            parm[4] = new SqlParameter("@PRD_DATE", SqlDbType.Date);
            parm[4].Value = PRD_DATE;

            parm[5] = new SqlParameter("@exd", SqlDbType.Date);
            parm[5].Value = exd;

            parm[6] = new SqlParameter("@qun", SqlDbType.Int);
            parm[6].Value = qun;

            parm[7] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            parm[7].Value = ID_CAT;


            DAL.ExecuteCommand("ADD_PRODUCT", parm);
            DAL.close();
        }

        public void EDITE_PRODUCT(int PRD_ID, string PRD_NAME, string PRD_PRIC, string PRD_NOTE, DateTime PRD_DATE, DateTime exd, int qun, int ID_CAT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[8];

            parm[0] = new SqlParameter("@PRD_ID", SqlDbType.Int);
            parm[0].Value = PRD_ID;

            parm[1] = new SqlParameter("@PRD_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = PRD_NAME;

            parm[2] = new SqlParameter("@PRD_PRIC", SqlDbType.Money);
            parm[2].Value = PRD_PRIC;

            parm[3] = new SqlParameter("@PRD_NOTE", SqlDbType.NVarChar, 50);
            parm[3].Value = PRD_NOTE;

            parm[4] = new SqlParameter("@PRD_DATE", SqlDbType.Date);
            parm[4].Value = PRD_DATE;

            parm[5] = new SqlParameter("@exd", SqlDbType.Date);
            parm[5].Value = exd;


            parm[6] = new SqlParameter("@qun", SqlDbType.Int);
            parm[6].Value = qun;

            parm[7] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            parm[7].Value = ID_CAT;


            DAL.ExecuteCommand("EDITE_PRODUCT", parm);
            DAL.close();
        }
        public void DELETE_PRODUCT(int PRD_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@PRD_ID", SqlDbType.Int);
            parm[0].Value = PRD_ID;

            DAL.ExecuteCommand("DELETE_PRODUCT", parm);
            DAL.close();
        }


        public void edit_rspt(int id,string sit,string ball)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@sit", SqlDbType.VarChar ,50);
            parm[1].Value = sit;

            parm[2] = new SqlParameter("@ball", SqlDbType.VarChar, 50);
            parm[2].Value = ball;

            DAL.ExecuteCommand("edit_rspt", parm);
            DAL.close();
        }

        public DataTable GET_ID_ORD()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_ORD", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ID_BILLS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_BILLS", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_ID_BILLS_PLACE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ID_BILLS_PLACE", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_EMP_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_EMP_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_CAT_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_CAT_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_PRD_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_PRD_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_SUP_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_SUP_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable GET_USER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_USER_ID", param);
            DAL.close();
            return Dt;
        }

        public DataTable get_workers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_workers", param);
            DAL.close();
            return Dt;
        }

        public DataTable get_place()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_place", param);
            DAL.close();
            return Dt;
        }
    }
}
