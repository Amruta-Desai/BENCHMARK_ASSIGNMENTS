using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEx1
{
    internal class Program
    {
        static int Divide_func(int n1, int n2)
        {
            int ans;
            ans = n1 / n2;
            return ans;
        }
        static void CallMethod_1(int a, int b)
        {
            try
            {
                Divide_func(a, b);
            }

            catch (Exception e)
            {
                Console.WriteLine("Catch Block: ");
                Console.WriteLine("Exception Message - " + e.Message);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2  numbers -");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                CallMethod_1(a, b);
            }
            catch (System.FormatException s)
            {
                Console.WriteLine("Catch block 3 sytsem Formate Exception");
                Console.WriteLine(s.Message);
            }


            Console.ReadKey();
        }


    }
}
