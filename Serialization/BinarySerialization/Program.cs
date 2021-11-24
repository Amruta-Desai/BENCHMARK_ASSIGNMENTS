using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    [Serializable]   // attribute that specifies that employee class is serialized
    class Employee
    {
        int empno;
        string ename;
        public Employee(int eno,string enm)
        {
            empno = eno;
            ename = enm;
        }
        public override string ToString()
        {
            return "employee id :" + empno + "employee name: " + ename;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(10, "allen");
            FileStream fs = new FileStream("D:\\Benchmark\\Serialization\\Employee.data", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, e);
            Console.WriteLine("OBJECT SERIALIZED");
            Console.ReadKey();
        }
    }
}
