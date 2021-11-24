using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [Serializable]   // attribute that specifies that employee class is serialized
    public class Employee
    {
        public int empno;
        public string ename,designation;
        [NonSerialized]
        public double salary;
        public Employee()
        {

        }
        public Employee(int eno, string enm,string desg, double sal)
        {
            empno = eno;
            ename = enm;
            designation = desg;
            salary = sal;
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
            FileStream fs = new FileStream("D:\\Benchmark\\XMLSerialization\\employee.xml" , FileMode.Create, FileAccess.Write);
            Employee e = new Employee(1001, "Smith","Manager",10000.50);
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            serializer.Serialize(fs, e);
            Console.WriteLine("OBJECT SERIALIZED");
            Console.ReadKey();


         }
    }
}
