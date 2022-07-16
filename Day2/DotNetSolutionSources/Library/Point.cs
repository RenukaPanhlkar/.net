using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // in .net variable are declared using their type
    // int .net types have been categoried in to two types
    // 1. Value Type
    //      primitive Type
    //      struct
    // 2. Reference Type
    //      class
    //      delegate
    //      event
   public struct Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.y = y;
            this.x = x;
        }

        //Property
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public override string ToString()
        {
            string result=string.Format("X={0}, Y={1}", this.x, this.y);
            return result;
        }
    }
}
