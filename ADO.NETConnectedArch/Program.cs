using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ADOExample1
{
    internal class Program
    {
        class EmployeeInfo
        {
            public SqlDataReader GetEmployeeData()
            {

                SqlConnection conn = null;
                SqlCommand cmd = null;
                SqlDataReader reader = null;

                try
                {

                    conn = new SqlConnection();
                    conn.ConnectionString = "Server=.;Database = EmployeeDB; trusted_connection = true";
                    conn.Open();

                    cmd = new SqlCommand("GetEmployeeData", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString() + "\t" + reader[5].ToString() + "\t");
                    }
                    Console.ReadKey();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return reader;
            }

            public SqlDataReader GetEmpUsingEmpno(string empno)
            {
                SqlConnection conn = null;
                SqlCommand cmd = null;
                SqlDataReader reader = null;
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "Server=.;Database = EmployeeDB; trusted_connection = true";
                    conn.Open();

                    cmd = new SqlCommand("GetEmpUsingEmpno", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("empno", empno);
                    cmd.Parameters.Add(param);
                    reader = cmd.ExecuteReader();
                }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return reader;
            }
            public int InsertEmployee(int empno, string ename, string designation, double salary, int deptno,int mgrid)
            {
                SqlConnection conn = null;
                SqlCommand cmd = null;
                int res = 0;
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "Server=.;Database = EmployeeDB; trusted_connection = true";
                    conn.Open();

                    cmd = new SqlCommand("InsertEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("empno", empno);
                    SqlParameter param2 = new SqlParameter("ename", ename);
                    SqlParameter param3 = new SqlParameter("designation", designation);
                    SqlParameter param4 = new SqlParameter("salary", salary);
                    SqlParameter param5 = new SqlParameter("deptno", deptno);
                    SqlParameter param6 = new SqlParameter("mgrid", mgrid);
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);
                    cmd.Parameters.Add(param5);
                    cmd.Parameters.Add(param6);
                    res = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return res;
            }

            public int UpdateEmployee(int empno, string ename, string designation, double salary, int deptno,int mgrid)
            {
                SqlConnection conn = null;
                SqlCommand cmd = null;
                int res = 0;

                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "Server=.;Database = EmployeeDB; trusted_connection = true";
                    conn.Open();

                    cmd = new SqlCommand("UpdateEmployee", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("empo", empno);
                    SqlParameter param2 = new SqlParameter("ename", ename);
                    SqlParameter param3 = new SqlParameter("designation", designation);
                    SqlParameter param4 = new SqlParameter("salary", salary);
                    SqlParameter param5 = new SqlParameter("deptno", deptno);
                    SqlParameter param6 = new SqlParameter("mgrid", mgrid);
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);
                    cmd.Parameters.Add(param5);
                    cmd.Parameters.Add(param6);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return res;
            }
            public int DeleteEmpUsingEmpno(int empno)
            {
                SqlConnection conn = null;
                SqlCommand cmd = null;
                int res = 0;
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "Server=.;Database = EmployeeDB; trusted_connection = true";
                    conn.Open();

                    cmd = new SqlCommand("DeleteEmpUsingEmpno", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("empno", empno);
                    cmd.Parameters.Add(param1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return res;
            }
            public void PrintReader(SqlDataReader reader)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString() + "\t" + reader[5].ToString() + "\t");
                }
            }

        }

        static void Main(string[] args)
        {
            int choice;
            EmployeeInfo e = new EmployeeInfo();
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Print all Employee");
                Console.WriteLine("2.Print Employee details based on EmpNo");
                Console.WriteLine("3.Insert Employee Details");
                Console.WriteLine("4.Update Employee Details");
                Console.WriteLine("5.Delete Employee Details");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        e.PrintReader(e.GetEmployeeData());
                        break;
                    case 2:
                        Console.WriteLine("Enter EmpNo:");
                        int empno = Convert.ToInt32(Console.ReadLine());
                        e.PrintReader(e.GetEmpUsingEmpno(empno.ToString()));
                        break;
                    case 3:
                        Console.WriteLine("Enter the EmpNo:");
                        int empno1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Employee Name:");
                        string ename1 = Console.ReadLine();
                        Console.WriteLine("Enter the designation:");
                        string designation = Console.ReadLine();
                        Console.WriteLine("Enter the salary:");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the DeptNo:");
                        int deptno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Manager Id:");
                        int mgrid = Convert.ToInt32(Console.ReadLine());
                        e.InsertEmployee(empno1, ename1, designation, salary, deptno,mgrid);
                        Console.WriteLine("Data Inserted successfully");
                        break;
                    case 4:
                        Console.WriteLine("Enter the EmpNo:");
                        int empno2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Employee Name:");
                        string ename2 = Console.ReadLine();
                        Console.WriteLine("Enter the designation:");
                        string designation2 = Console.ReadLine();
                        Console.WriteLine("Enter the salary:");
                        double salary2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the DeptNo:");
                        int deptno2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Manager ID:");
                        int mgrid2 = Convert.ToInt32(Console.ReadLine());
                        e.UpdateEmployee(empno2, ename2, designation2, salary2, deptno2,mgrid2);
                        Console.WriteLine("Data Updated successfully");
                        break;
                    case 5:
                        Console.WriteLine("Enter the EmpNo:");
                        int empno3 = Convert.ToInt32(Console.ReadLine());
                        e.DeleteEmpUsingEmpno(empno3);
                        Console.WriteLine("Data deleted successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
                Console.WriteLine("Y or y to continue");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');
            Console.ReadKey();



        }


    }
   
}

