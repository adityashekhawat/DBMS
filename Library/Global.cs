using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public static class Global
    {
        public static string Username = "";
        public static string Password = "";
        public static bool isSystemUser = false;

        public static string ConnectionString = @"Data Source=ADITYA;Initial Catalog=LibraryDB;Integrated Security=True";


        public static bool ValidateId(string UserName, string Password)
        {
            try
            {
                DataSet ds = new DataSet();
                string SQLCommand = "select * from lib_users where user_name='" + UserName + "' and user_password ='" + Password + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);
                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public static bool ChangePassword(string Password)
        {

            try
            {
                DataSet ds = new DataSet();
                //string SQLCommand = "select * from lib_users where user_name='" + Global.Username + "' and user_password ='" + Password + "'";
                string SQLCommand = "update lib_users set user_password ='" + Password + "' where user_name='" + Global.Username + "';";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);

                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                return true;
                /*if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }*/
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public static bool RegisterUser(string Username,string Password)
        {

            try
            {
                DataSet ds = new DataSet();

                string SQLCommand = "insert into lib_users (user_name,user_password) values ('" + Username + "','" + Password + "');";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);

                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public static bool CheckUsername(string Username)
        {
            try
            {
                DataSet ds = new DataSet();
                string SQLCommand = "select * from lib_users where user_name='" + Username + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);
                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
