using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashet
{
    internal class oper
    {
        HashSet<string> earth = new HashSet<string>();

        HashSet<string> venus = new HashSet<string>();

        HashSet<string> deimos = new HashSet<string>();




        public oper()
        {
            earth.Add("gara");
            earth.Add("revenant");
            earth.Add("KYOUMEI");
            earth.Add("yes");
            earth.Add("NIDUS");

            venus.Add("HILDRYN");
            venus.Add("baruuk");
            venus.Add("garuda");
            venus.Add("GAUSS");
            venus.Add("yes");

            deimos.Add("GRENdel");
            deimos.Add("NIDUS");
            deimos.Add("LAVOX");
            deimos.Add("XAKU");

        }

        private HashSet<string> GetServerSet(int serverChoice)
        {
            switch (serverChoice)
            {
                case 1: return earth;
                case 2: return venus;
                case 3: return deimos;
                default:
                    Console.WriteLine("INVALID INPUT");
                    return null;


            }
        }



        public void dev()
        {
            int command = 0;

            do
            {
                Console.Beep();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("SERVERS");
                Console.WriteLine("1 = EARTH");
                Console.WriteLine("2 = VENUS");
                Console.WriteLine("3 = DEIMOS");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("1 = UNION");
                Console.WriteLine("2 = INTERSEGGS");
                Console.WriteLine("3 = EXPECT WITH");
                Console.WriteLine("4 = EXIT");

                Console.WriteLine("---------------------------------------------------------------");

                Console.Write("ENTER COMMAND HERE: ");
                command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        Console.Beep();
                        Console.Write("Select first server (1=Earth, 2=Venus, 3=Deimos): ");
                        int firstSetChoice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Select second server (1=Earth, 2=Venus, 3=Deimos): ");
                        int secondSetChoice = Convert.ToInt32(Console.ReadLine());
                        
                        HashSet<string> firstSet = GetServerSet(firstSetChoice);
                        HashSet<string> secondSet = GetServerSet(secondSetChoice);
                       

                        HashSet<string> resultUnion = new HashSet<string>(firstSet);
                        resultUnion.UnionWith(secondSet);
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine("Union of the selected servers:");
                        foreach (var item in resultUnion)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 2:
                        Console.Beep();
                        Console.Write("Select first server (1=Earth, 2=Venus, 3=Deimos):");
                        int s1IN = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Select second server (1=Earth, 2=Venus, 3=Deimos):");
                        int s2IN = Convert.ToInt32(Console.ReadLine());

                        HashSet<string> firstin = GetServerSet(s1IN);
                        HashSet<string> secondin = GetServerSet(s2IN);

                        
                        HashSet<string> resultin = new HashSet<string>(firstin);
                        resultin.IntersectWith(secondin);
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine("Union of the selected servers:");
                        foreach (var item in resultin)
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    case 3:
                        Console.Beep();
                        Console.Write("Select first server (1=Earth, 2=Venus, 3=Deimos):");
                        int s1X = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Select second server (1=Earth, 2=Venus, 3=Deimos):");
                        int s2X = Convert.ToInt32(Console.ReadLine());
                       
                        HashSet<string> firstX = GetServerSet(s1X);
                        HashSet<string> secondX = GetServerSet(s2X);
                        

                        HashSet<string> resultX = new HashSet<string>(firstX);
                        resultX.ExceptWith(secondX);
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine("Union of the selected servers:");
                        foreach (var item in resultX)
                        {
                            Console.WriteLine(item);
                        }

                        break;


                }
            } while (command != 4);

        }
    }
}
