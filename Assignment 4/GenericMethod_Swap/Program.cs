using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod_Swap
{
    class Program
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            char ch1 = 'a', ch2 = 'b';

            Console.WriteLine("Before Swap");
            Console.WriteLine("a= " + a + " b=" + b);
            
            swap(ref a, ref b);
            swap(ref ch1, ref ch2);

            Console.WriteLine("/n------");
            Console.WriteLine("after Swap");
            Console.WriteLine("a= " + a + " b=" + b);
            
            Console.ReadKey();

        }
    }
}
