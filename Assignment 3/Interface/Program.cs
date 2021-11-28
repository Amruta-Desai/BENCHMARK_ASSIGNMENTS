using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPrintable
    {
        void print();
    }
    class Account : IPrintable
    {
        string acc = "Saving";
        public void print()
        {
            Console.WriteLine("Print method- Account Class");
            
        }
    }
    class Employee : IPrintable
    {
        string Emp = "Permanent";
        public void print()
        {
            Console.WriteLine("Print method- Employee Class");
            
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            new Account().print();
            new Employee().print();
            Console.ReadKey();
        }
    }
}
