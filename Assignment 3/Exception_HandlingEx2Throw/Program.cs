using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Ex2Throw
{
    internal class Program
    {
        static int Divide_Func(int n1, int n2)
        {

            int ans;
            ans = n1 / n2;
            return ans;

        }


        static void CallMethod_1(int a, int b)
        {
            try
            {
                Divide_Func(a, b);
            }
            catch (DivideByZeroException Div)
            {
                throw Div;
            }
        }


        static void CallMethod_2(int a, int b)
        {
            try
            {
                CallMethod_1(a, b);
            }
            catch (DivideByZeroException Div)
            {
                throw Div;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2  numbers:");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                CallMethod_2(a, b);
            }
            catch (System.FormatException s)
            {
                Console.WriteLine("Catch block 1 sytsem Formate Exception");
                Console.WriteLine(s.Message);
            }
            catch (DivideByZeroException Div)
            {
                Console.WriteLine("Catch block 2 DivideByZeroException Exception");
                Console.WriteLine(Div.Message);
                // throw Div;

            }

            Console.ReadKey();
        }
    }
}
