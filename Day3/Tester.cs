using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureDemoApp
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            foreach( string arg in args)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine("Tester class Main function as entry Point...");
            Console.ReadLine();
        }
    }
}
