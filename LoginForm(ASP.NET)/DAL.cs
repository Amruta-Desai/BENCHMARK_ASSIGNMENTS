using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{

    public class DAL
    {
        SqlConnection conn = null;
        public DAL()
            {
            conn = new SqlConnection("server=.;database=EmployeeDB;trusted_connection=true");
            conn.Open();
            }
        public bool Login(string loginname, string password)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("LoginProcedure", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("loginname" ,loginname);
                SqlParameter p2 = new SqlParameter("password", password);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException s)
            {
                Console.WriteLine(s.Message);
                return false;
            }
        }
        ~DAL()
        {
            conn.Close();
        }

    }
}