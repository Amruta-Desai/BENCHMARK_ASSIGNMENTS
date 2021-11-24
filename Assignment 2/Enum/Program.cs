using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        public enum Days { Sun,Mon,Tue,Wed,Thur,Fri,Sat}
        static void Main(string[] args)
        {
            Program p  =new Program();
            p.PrintData(Days.Mon);
            p.PrintData(Days.Wed);
            p.PrintData(Days.Fri);

            Console.ReadKey();

        }
        public void PrintData(Days d)
        {
            Console.WriteLine("The day is "+ d);
         
        }
        
    }
    
}
