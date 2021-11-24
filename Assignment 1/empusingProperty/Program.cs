using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProperty
{
    class EmpProperty
    {
        private int empNo;
        private String eName, designation;
        private float salary;

        public int EmpNo
        {
            get
            {
                return empNo;
            }

            set
            {
                empNo = value;
            }
        }

        public string EName
        {
            get
            {
                return eName;
            }

            set
            {
                eName = value;
            }
        }

        public string Designation 
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }




        public float Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

    }
  
    internal class Program
    {
        
    static void Main(string[] args)
        {
            EmpProperty e = new EmpProperty();
            e.EmpNo = 101;
            e.EName = "Amruta Desai";
            e.Designation = "Software Engineer";
            Console.WriteLine("Emp-No = {0} Name - {1}  Designation - {2}", e.EmpNo, e.EName, e.Designation);
            Console.ReadKey();


        }
    }
}

