using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonnaciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, sum=1, n;
            Console.Write("Enter the number upto which fibonnaci series is to be found? : ");
            n = Convert.ToInt32(Console.ReadLine());
            while(sum <= n)
            {
                Console.WriteLine(sum + " ");
                n1 = n2;
                n2 = sum;
                sum = n1 + n2;
            }
            Console.ReadKey();

        }
    }
}
