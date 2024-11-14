using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
{
    internal class operations
    {
        LinkedList<String> list = new LinkedList<String>();
        //add   (addlast, addfirst)
        //
        //clear
        //remove (removelast, add first, specific node)
        //count
        public void add()
        {
            Console.Beep();
            Console.Write("ADD ITEM HERE: ");
            string add = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("HOW TOP IS THIS IN YOUR LIST");
            Console.WriteLine("1 = FIRST");
            Console.WriteLine("2 = LAST");
            int adder = 0;
            Console.Write("ENTER HERE: ");
            adder =Convert.ToInt32(Console.ReadLine());


            if (adder == 1 )
            {
                list.AddFirst(add);
            }
            else if (adder == 2)
            {
                list.AddLast(add);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

            Console.WriteLine();
            Console.WriteLine("ITEM ADDED");

           
        }

        public void remove()
        {
            Console.Beep();
            Console.Write("ENTER ITEM TO REMOVE: ");
            string remove = Console.ReadLine().ToUpper();
            list.Remove(remove);
            Console.WriteLine();
            Console.WriteLine("CURRENT LIST");

            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
           
        }
        
        public void view()
        {
            Console.Beep();
            foreach (string l in list) { Console.WriteLine(l); }
        }

        public void find()
        {
            Console.Write("ENTER ITEM TO FIND: ");
            string find = Console.ReadLine().ToUpper();


            if (list.Contains(find) == true)
            {
                Console.WriteLine("ITEM HAS BEEN THE FOUNDED");
            }
            else
            {
                Console.WriteLine("TARGET NOT FOUNDSY");

            }


        }

        public void count()
        {
            Console.WriteLine("CURRENT NUMBER OF ITEMS ON THE LIST IS {0}", list.Count());
            Console.WriteLine("----------------------------------------");
        }

        public void clear()
        {
            list.Clear();
            Console.WriteLine("----------------------------------------");
        }

    }
}
