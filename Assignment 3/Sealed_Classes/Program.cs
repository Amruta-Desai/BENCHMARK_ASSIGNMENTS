using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes
{
    class BaseClass
    {
        public virtual void method()
        {
            Console.WriteLine("Base Class Sealed Method");
        }

    }
    /*    class Child_Base : Base_Class  
          // if Base_Class is sealed then can not inherit it in child
          //  error --- >  'Child_Base': cannot derive from sealed type 'Base_Class'
    {
    }*/
    class ChildClass_1 : BaseClass
    {
        public sealed override void method()
        {
            base.method();
            Console.WriteLine("Base Method override in Child Class 1");
        }
    }
    /* class Child_class_2 : Child_class_1
    {
        public override void method_1()
        //  can't override inherited method  because it is sealed 
        {
            base.method_1();
            Console.WriteLine("Base Method override in Child Class 1");
        }
    }*/

    internal class Program
    {
        static void Main(string[] args)
        {
            new ChildClass_1().method();
            Console.ReadKey();
        }
    }
}
