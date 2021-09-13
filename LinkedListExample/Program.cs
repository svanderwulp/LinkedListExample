using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            Console.WriteLine("Inhoud van de list: {0}", list1.ToString());
            Console.WriteLine("Aantal items in list: {0}", list1.Length);
            list1.Insert(12);
            list1.Insert(14);
            list1.Insert(45);
            Console.WriteLine("Inhoud van de list: {0}", list1.ToString());
            Console.WriteLine("Aantal items in list: {0}\n", list1.Length);
            for(int i = 0; i < 4; i++)
            {
                var popped = list1.Delete();
                Console.WriteLine("Verwijderd item: {0}", popped);
                Console.WriteLine("Inhoud van de list: {0}", list1.ToString());
                Console.WriteLine("Aantal items in list: {0}\n", list1.Length);
            }
            
            Console.WriteLine("Druk Enter om door te gaan");
            string input = Console.ReadLine();
        }
    }
}
