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

            if (zahl == "1")
            {
                Console.WriteLine("sehr gut)");
            }
            if (zahl == "2")
            {
                Console.WriteLine("gut)");
            }
        }
    }
}
