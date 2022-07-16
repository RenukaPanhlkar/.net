using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaprisionDemoApp
{
    public class Player : IComparable
    {
        public string Name { get; set; }
        public int Runs { get; set; }
        public int Age { get; set; }
        public int Rank { get; set; }
        int IComparable.CompareTo(object obj)
        {
            Player temp = (Player)obj;
            if (this.Age > temp.Age)
                return 1;
            if (this.Age < temp.Age)
                return -1;
            else
                return 0;
        }
    }
}
