using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note eingeben 1-6");
            string zahl = Console.ReadLine();

            switch (zahl)
            {
                case "1":
                    Console.WriteLine("sehr gut");
                    break;
                case "2":
                    Console.WriteLine("gut");
                    break;
                case "3":
                    Console.WriteLine("befriedigend");
                    break;
                case "4":
                    Console.WriteLine("ausreichend");
                    break;
                case "5":
                    Console.WriteLine("was soll der Mist");
                    break;
                case "6":
                    Console.WriteLine("du musst mehr lernen");
                    break;
            }
        }
    }
}
