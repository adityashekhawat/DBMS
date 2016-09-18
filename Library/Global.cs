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

        public static bool CheckNewEntry(string BookTitle)
        {
            try
            {
                DataSet ds = new DataSet();
                string SQLCommand = "select book_title from lib_book where book_title='" + BookTitle + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);
                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IncrementQuantity(int numValue,string title)
        {
            try
            {
                DataSet ds = new DataSet();
                string SQLCommand = "update lib_book set book_count = book_count + " + numValue + "where book_title = '" + title + "';";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);
                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool AddBook(string BookTitle, string AuthorName, int Quantity, string Category)
        {
            try
            {
                DataSet ds = new DataSet();
                string SQLCommand = "INSERT INTO lib_book (book_title,book_category,book_author,book_count) values ('" + BookTitle + "','" + Category + "','" + AuthorName + "'," + Quantity + ")";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);
                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                return true;
               
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool CheckCategory(string Category)
        {
            try
            {
                DataSet ds = new DataSet();
                string SQLCommand = "select * from lib_category where book_category='" + Category + "';"; // try and remove the ; if it fucks with the code
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
        }


        public static bool AddCategory(string CategoryName)
        {
            /*if (CategoryList.ContainsValue(CategoryName))
            {
                return IsSuccess;
            }
            */
            try
            {
                DataSet ds = new DataSet();
                /*SqlConnection conn = new SqlConnection(Global.ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("", conn);*/
                string SQLCommand = "INSERT INTO lib_category (book_category) values ('" + CategoryName + "');";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, Global.ConnectionString);
                Adapter.Fill(ds);
                Adapter.SelectCommand.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
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
            
        }
    }
}
