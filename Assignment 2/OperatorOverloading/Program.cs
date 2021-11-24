using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Student
    {
        int marks;
        public Student(int m)
        {
            marks = m;
        }
        public static Student operator +(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks + b.marks;
            return res;
        }
        public static Student operator -(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks - b.marks;
            return res;
        }
        public static Student operator *(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks * b.marks;
            return res;
        }
        public static Student operator /(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks / b.marks;
            return res;
        }

        // For overloading the == operator the != is also required else it will throw a error
        public static bool operator ==(Student a, Student b)
        {
           if(a.marks == b.marks)
                return true;
           else
                return false;

            
        }
        public static bool operator !=(Student a, Student b)
        {
            if (a.marks != b.marks)
                return true;
            else
                return false;


        }
        public void PrintMarks()
        {
            Console.WriteLine(marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student(78);
            Student obj2 = new Student(44);

            Student addm = obj1 + obj2;
            addm.PrintMarks();

            Student subt = obj1 - obj2;
            subt.PrintMarks();

            Student mulres = obj1 * obj2;
            mulres.PrintMarks();

            Student div = obj1 / obj2;
            div.PrintMarks();

            if (obj1 == obj2)
            {
                Console.WriteLine("Marks are same");
            }
            else
            {
                Console.WriteLine("Marks are different");
            }

            Console.ReadKey();

        }

    }



}

