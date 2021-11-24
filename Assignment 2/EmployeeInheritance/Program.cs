using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAssignment
{
    class employee
    {
        int empno;
        string ename;

        public employee(int empno, string ename)
        {
            this.empno = empno;
            this.ename = ename;
        }
        public void empDetails()
        {
            Console.WriteLine(empno + " " + ename);
        }
    }
    class PEmp : employee
    {
         double basicSal, hra, da;


         public PEmp(int empno, string ename, double basicSal) : base(empno, ename)
         {
                this.basicSal = basicSal;
         }
          public void displayPEmp()
          {
                base.empDetails();
                Console.WriteLine(basicSal);
                hra = basicSal * 0.5;
                da = basicSal * 0.2;
                Console.WriteLine("HRA - " + hra + " " +"DA- " + da);
                double total = hra + da + basicSal;
                Console.WriteLine("total salary - " + total);
          }

    }
    class WEmp : employee
    {
          double hours, amt;

          public WEmp(int empno, string ename, double hours, double amt) : base(empno, ename)                          //Parent class obejct is also created automatically
          {
                this.hours = hours;
                this.amt = amt;
          }
          public void WEmpDetails()
          {
                base.empDetails();
                double total = hours * amt;
                Console.WriteLine("hours {0} * amt per hr. {1} = {2} rs", hours, amt, total);


          }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            PEmp p = new PEmp(101, "Amruta", 20000);
            p.displayPEmp();

            WEmp w = new WEmp(102, "Simran",2, 500);
            w.WEmpDetails();
            Console.ReadKey();

        }
        
    }
    
}
