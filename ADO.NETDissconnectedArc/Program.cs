using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ADOExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                char ch;
                SqlConnection conn = new SqlConnection("Server=.; Database=EmployeeDB; trusted_connection=true");
                SqlCommand cmd = new SqlCommand("select * from Course", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Course");
                DataTable tab = ds.Tables["Course"];
                
              
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1.Print all Course");
                    Console.WriteLine("2.Print Course based on CourseID");
                    Console.WriteLine("3.Insert Course Details");
                    Console.WriteLine("4.Update Course Details");
                    Console.WriteLine("5.Delete Course Details");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            foreach (DataRow rp in tab.Rows)
                            {
                                Console.WriteLine(rp[0].ToString() + "\t" + rp[1].ToString() + '\t' + rp[2].ToString() + '\t' + rp[3].ToString());
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Enter the CourseID");
                            int cid = Convert.ToInt32(Console.ReadLine());
                            DataRow[] row = tab.Select("CourseID= " + cid);
                            Console.WriteLine("Course details are:");
                            foreach (DataRow rp in row)
                            {
                                Console.WriteLine(rp[0].ToString() + "\t" + rp[1].ToString() + '\t' + rp[2].ToString() + '\t' + rp[3].ToString());
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the CourseID:");
                            int cid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Course Name:");
                            string cname = Console.ReadLine();
                            Console.WriteLine("Enter the Instructor Name:");
                            string ins = Console.ReadLine();
                            Console.WriteLine("Enter the Fees:");
                            double fees = Convert.ToDouble(Console.ReadLine());
                            DataRow NewRow = tab.NewRow();
                            NewRow["CourseId"] = cid1;
                            NewRow["CourseName"] = cname;
                            NewRow["instructor"] = ins;
                            NewRow["fees"] = fees;
                            tab.Rows.Add(NewRow);
                            adapter.Update(tab);
                            Console.WriteLine("Record are inserted into the table");
                            break;
                        case 4:
                            Console.WriteLine("Enter CourseID:");
                            int cid2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Course Name:");
                            string cname2 = Console.ReadLine();
                            Console.WriteLine("Enter Instructor Name:");
                            string ins2 = Console.ReadLine();
                            Console.WriteLine("Enter Fees:");
                            double fees2 = Convert.ToDouble(Console.ReadLine());
                            DataRow[] ro = tab.Select("CourseID= " + cid2);
                            DataRow rowup = ro[0];
                            rowup["CourseId"] = cid2;
                            rowup["CourseName"] = cname2;
                            rowup["instructor"] = ins2;
                            rowup["fees"] = fees2;
                            adapter.Update(tab);
                            Console.WriteLine("Record Updated into the table");
                            break;


                        case 5:
                            Console.WriteLine("Enter the CourseID");
                            int cid3 = Convert.ToInt32(Console.ReadLine());
                            DataRow[] rod = tab.Select("CourseID= " + cid3);
                            DataRow rodelete = rod[0];
                            rodelete.Delete();
                            adapter.Update(ds, "Course");
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;

                    }
                    Console.WriteLine("Y/y to continue");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch == 'Y' || ch == 'y');
                Console.ReadLine();
                           
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
