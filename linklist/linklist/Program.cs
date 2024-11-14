using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operations op = new operations();

            int input = 0;



            do
            {
                Console.Beep();
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("THIS IS A PRIORITY LIST");
                Console.WriteLine("1 = ADD");
                Console.WriteLine("2 = REMOVE");
                Console.WriteLine("3 = VIEW");
                Console.WriteLine("4 = FIND");
                Console.WriteLine("5 = COUNT");
                Console.WriteLine("6 = CLEAR");
                Console.WriteLine("7 = EXIT");
                Console.Write("ENTER ACTION: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (input)
                {
                    case 1://add
                        Console.Beep();
                        op.add();
                        break;
                    //--------------------------------------------
                    case 2://remove
                        Console.Beep();
                        op.remove();
                        break;
                    //--------------------------------------------
                    case 3://view
                        Console.Beep();
                        op.view();
                        break;
                    //--------------------------------------------
                    case 4://find
                        Console.Beep();
                        op.find();
                        break;
                    //--------------------------------------------
                    case 5://count
                        Console.Beep();
                        op.count();
                        break;
                    //--------------------------------------------
                    case 6://clear
                        Console.Beep();
                        op.clear();
                        break;
                }


            } while (input != 7);

            Console.WriteLine("PROGRAM TERMINATED");

            Console.ReadLine();

        }
    }
}
