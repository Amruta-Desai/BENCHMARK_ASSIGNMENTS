using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicArguments
{
    abstract class Account
    {
        public abstract void Calculate_interest();

    }

    class Saving : Account
    {
        public override void Calculate_interest()
        {
            Console.WriteLine("Saving Account Interest:");
            Console.WriteLine("Calculating Saving Account Interest..");
        }
    }


    class Current : Account
    {
        public override void Calculate_interest()
        {
            Console.WriteLine("Current Account Interest:");
            Console.WriteLine("Calculating Current account Interest..");
        }
    }

    class FD_Account : Account
    {
        public override void Calculate_interest()
        {
            Console.WriteLine("FD_Account Interest:");
            Console.WriteLine("Calculating FD account Interest..");
        }
    }

    internal class Program
    {
        public void findInterest(Account acc)
        {
            if (acc.GetType() == typeof(Saving))
            {
                Saving save_obj = (Saving)acc;
            }
            if (acc.GetType() == typeof(Current))
            {
                Current current = (Current)acc;
            }
            if(acc.GetType() == typeof(FD_Account))
            {
                FD_Account fd_account = (FD_Account)acc;
            }
            acc.Calculate_interest();
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.findInterest(new Saving());
            p.findInterest(new Current());
            p.findInterest(new FD_Account());

        }
    }
}
