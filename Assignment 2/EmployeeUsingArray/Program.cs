using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDetailsLoops
{
    class Employee
    {
        int empno;
        string ename;
        string designation;
        int salary;

        public Employee()
        {
            Console.WriteLine("Enter emp no");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter emp name");
            ename = Console.ReadLine();

            Console.WriteLine("Enter emp desg");
            designation = Console.ReadLine();

            Console.WriteLine("Enter emp salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine("EmpNo:" + e.empno + " EmpName:" + e.ename + " Designation:" + e.designation + " Salary: Rs." + e.salary);
            }
            Console.ReadKey();
        }

    }
} 