using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Enter the month number to find the number of days ");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month contains 31 days");
                    break;
                case 2:
                    Console.WriteLine("This month contains 28 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month contains 30 days");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();

        }
    }
}
