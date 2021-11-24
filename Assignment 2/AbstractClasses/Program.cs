using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAnimal
{
    abstract class Animal
    {

        public abstract void foodHabit();

    }


    class Herbivorous : Animal
    {

        public override void foodHabit()
        {
            Console.WriteLine("Herbivorous animal Consume only plants");

        }
    }
    class Carnivorous : Animal
    {

        public override void foodHabit()
        {
            Console.WriteLine("Carnivorous animals Consume meat");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herbivorous animals ");
            new Herbivorous().foodHabit();
            
            Console.WriteLine("Carnivorous animals ");
            new Carnivorous().foodHabit();
            Console.ReadKey();
        }
    }
}
