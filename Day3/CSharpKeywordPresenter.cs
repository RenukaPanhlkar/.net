using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    public class MathEngine
    {
       private  const double PI = 3.14;
       private readonly string author;

        public MathEngine()
        {
            this.author = "Ravi Tambade";
        }

        public double Addition(double op1, double op2)
        {
            //this.author = "Mazz Mustafa";
            return op1 + op2;
        }
    }


    public class Complex
    {
        private int real;
        private int imag;

        public Complex()
        {
            real = 0;
            imag = 0;   
        }
        public Complex(int num1, int num2)
        {
            this.real = num1;
            this.imag = num2;
        }
        public static Complex  operator+ (Complex c1, Complex c2){
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.imag = c1.imag + c2.imag;
            return temp;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real =  c1.real- c2.real;
            temp.imag = c1.imag - c2.imag;
            return temp;
        }


        public override string ToString()
        {
            return  this.real+ "+i"+ this.imag;
        }
    }
    internal class CSharpKeywordPresenter
    {


        static void Main(string [] args)
        {
            Complex complex1 = new Complex(23, 54);
            Complex complex2 = new Complex(77, 100);
            Complex complex3 = complex1 + complex2;
            Console.WriteLine(complex3);
            Console.ReadLine();
        }
    }
}
