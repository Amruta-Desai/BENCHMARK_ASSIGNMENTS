using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List
            List<String> listv = new List<String>();
            listv.Add("one");
            listv.Add("two");
            listv.Add("three");
            listv.Add("four");
            Console.WriteLine("List : ");
            foreach (string a in listv)
            {
                Console.Write(a + " ");
                
            }
            Console.Write("\n");

            //Linked List
            string[] words = { "Hello", "this is", "my", "first", "program" };
            LinkedList<string> linkv = new LinkedList<string>(words);
            Console.WriteLine("Linked List: ");
            foreach (string s in linkv)
            {
                Console.Write(s + " ");
                
            }
            Console.Write("\n");

            //sorted list
            SortedList<int, string> sortv = new SortedList<int, string>();

            sortv.Add(1, "r");
            sortv.Add(101, "ee");
            sortv.Add(14, "taet");
            sortv.Add(51, "bt");
            sortv.Add(156, "bgh");
            sortv.Add(10, "dfs");


            Console.WriteLine(" Sorted List: ");
            foreach (KeyValuePair<int, string> kvp in sortv)
            {
                Console.Write(kvp.Key + " " + kvp.Value + "\n");
            }
            Console.ReadKey();


        }
    }
}
