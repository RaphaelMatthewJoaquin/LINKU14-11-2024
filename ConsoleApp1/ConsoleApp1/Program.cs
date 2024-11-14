using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            HashSet<string> numbers = new HashSet<string>();
            numbers.Add("1");
            numbers.Add("2");
            numbers.Add("3");
            numbers.Add("1");

            //foreach (string n in numbers)
            //{
            //    Console.WriteLine(n);
            //}


            HashSet<string> name2 = new HashSet<string>
            {
                "1",
                "2",
                "3",
                "4",
            };


            //numbers.UnionWith(name2);
            //Console.WriteLine("USING UNIONWITH");
            //foreach (string n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //numbers.IntersectWith(name2);
            //Console.WriteLine("WITH INTERSEGGS");
            //foreach (string n in numbers)
            //{ Console.WriteLine(n); }

            name2.ExceptWith(numbers); 
            foreach (string n in numbers) 
            {
                Console.WriteLine(n); 
            }

            Console.ReadKey();
        }
    }
}
