using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaprisionDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player[] players ={
                                new Player { Name="Ravi", Age=23, Rank=4, Runs=540 },
                                new Player { Name="Seeta",Age=23, Rank=5, Runs=600 },
                                new Player { Name="Raghav",Age=32, Rank=8, Runs=987 },
                                new Player { Name= "Zuber",Age=25, Rank=2, Runs=50 },
                                new Player {Name="Salim", Age=28, Rank=8, Runs=300 },
                                new Player {Name="Smith", Age=21, Rank=9, Runs=120 }
            };

            Console.WriteLine("Before Sorting");

            foreach (Player p in players)
            {
                Console.WriteLine(p.Name + " " + p.Age + " " + p.Runs);
            }

            // add five players with Runs
            Array.Sort(players );

            Console.WriteLine("After Sorting");
            foreach ( Player p in players )
            {
                Console.WriteLine( p.Name  + " "+ p.Age + " "+ p.Runs);
            }

            // display sorted Array
            Console.ReadLine();
        }
    }
}
