using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Books
    {
        private string[] titles = new string[100];

        //Indexer : Smart Array

        // YOu can write only one indexer for a class
        public string this[int index]
        {
            get
            {
                return titles[index];
            }
            set
            {
                this.titles[index] = value;
            }
        }

    }
}
