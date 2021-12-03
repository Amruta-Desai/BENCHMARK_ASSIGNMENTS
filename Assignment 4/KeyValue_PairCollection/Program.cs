using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace KeyValue_PairCollection
{
    class student
    {
        public int rollno;
        public string name;

        public student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(2, "Riya");
            student s2 = new student(1, "Mamta");

            // generic
            SortedList<int, string> sortList = new SortedList<int, string>();

            sortList.Add(s1.rollno, s1.name);
            sortList.Add(s2.rollno, s2.name);

            Console.WriteLine(" sorted List --> ");
            foreach (KeyValuePair<int, string> kvp in sortList)
            {
                Console.Write(kvp.Key + "--" + kvp.Value + "\n");
            }



            Console.WriteLine("\n------------");
            // non generic 

            Hashtable ht = new Hashtable();
            ht.Add(s1.rollno, s1.name);
            ht.Add(s2.rollno, s2.name);

            foreach (DictionaryEntry di in ht)
            {
                Console.WriteLine("{0} - {1}", di.Key, di.Value);
            }

            Console.ReadKey();
        }
    }
}

