using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    //singleton design Pattern

    // 23 Design Patterns 
    // Three Categories:
    // Creational  patterns
    //      Singleton
    //      factory
    // Structural  patterns
    // Behavioural patterns

    public class OfficeBoy
    {
        //step 1:
        private static OfficeBoy _ref = null;
        public string Name { get; set; }
        public double Salary { get; set; }

        //step 2:
        private OfficeBoy()
        {
            Name = "Ravi Tambade";
            Salary = 10000;
        }

        //Step 3
        public static OfficeBoy GetInstance()
        {
            if(_ref == null)
            {
                _ref=new OfficeBoy();
            }
            return _ref;
        }
        public override string ToString()
        {
            return  this.Name +  "  Salary="+ this.Salary;
        }
    }


    public class SingletonTester
    {
        static void Main(string [] args)
        {
            OfficeBoy boy1 = OfficeBoy.GetInstance();
            OfficeBoy boy2 = OfficeBoy.GetInstance();

            Console.WriteLine(boy1);
            Console.WriteLine(boy2);

            boy2.Name = "Bharat Varma";
            Console.WriteLine(boy1);
            Console.WriteLine(boy2);

            //Console.ReadLine();


            string[] names = { "Mangesh", "Bharati", "Shiv", "Rajan" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Array.Sort(names);

            Console.WriteLine("After sorting....");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Rectangular Array
            int[,] mtrx = new int[2, 3]
            {
                {12,34,54 },
                {120,4,64},
            };

            int result = mtrx[0, 2];
            Console.WriteLine("showing result");
            Console.WriteLine(result);

            //Jagged Arrays
            //Array of Array
            int[][] dacBatch = new int[2][];
            dacBatch[0] = new int[5] { 23, 54, 65, 12, 34 };
            dacBatch[1] = new int[10] { 34, 65, 76, 12, 76, 34, 98, 45, 76, 12 };
            int rollNumber = dacBatch[1][2];

            //Nullable type

         //   Boolean? status = null;

            int? total=null;
            total = null;

            //Console.WriteLine(total);
           // Nullable<int> scoreEarned =null;


            if (total == null)
            {
                Console.WriteLine("Null value can not be displayed");
            }
            else
            {
                Console.WriteLine(total);
            }

        }
    }
}
