using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Ex3AOR
{
    internal class Program
    {
        public static void ipArray(int[] a)
        {

            Console.Write("Enter 5 elements in the array :\n");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array - ");
            foreach (int it in a)
            {
                Console.WriteLine(it);
            }
            // for exception accessing element more than size of array
            a[6] = 1;

        }
        static void Main(string[] args)
        {
            int[] a = new int[5];


            try
            {
                ipArray(a);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index out of bound-" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
