using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoApp
{

    //Declration of delegate in namespace

    public delegate void Operation();
    public delegate void Handler(string name);
    public delegate int ArithmaticOperation(int op1, int op2);

    public class MathEngine
    {

        public MathEngine() { }

        //Arithmatic operations as indivisual function.
        public   int Addition(int op1, int op2)
        {
            return op1 + op2;
        }
        public   int Subtraction(int op1, int op2)
        {
            return op1 - op2;
        }
        public   int Multiplication(int op1, int op2)
        {
            return op1 * op2;
        }
        public   int Division(int op1, int op2)
        {
            return op1 / op2;
        }
    }

    internal class Program
    {
        //Normal functions
        public static void Show()
        {
            Console.WriteLine("Showing information");
        }
        public static void Display()
        {
            Console.WriteLine("Displaying Data");

        }

        //Request handliner mulitple functions
        //Callback function

        public static void GetRequestHandler(string request)
        {
            Console.WriteLine("GET Repsonse is generated.......");
        }
        public static void PostRequestHandler(string request)
        {
            Console.WriteLine("POST Repsonse is generated.......");
        }
        public static void DeleteRequestHandler(string request)
        {
            Console.WriteLine("DELETE Repsonse is generated.......");

            Console.WriteLine("{0} data is removed from storage", request);

        }

        
        static void Main(string[] args)
        { 
            //ealry Binding (static linking)
            //Show(); 
            //Display();u
            //late Binding
            //Register funtion name  at the time construction of Operation instance
            Operation opn1 = new Operation(Show);
            opn1.Invoke();

            Handler requestHandler1 = new Handler(GetRequestHandler);
            Handler requestHandler2 = new Handler(PostRequestHandler);
            Handler requestHandler3 = new Handler(DeleteRequestHandler);

            //requestHandler1("Customer Data"); // instance is behaving like a function
            //requestHandler2("User details Data");
            //requestHandler3("User id 56");
            Handler master = requestHandler1;

            //Chaining Delegates
            //attaching multiple delegates
            master += requestHandler2;
            master += requestHandler3;

            // master.Invoke("Ravi Tambade");
            master("Sameer");

            Console.WriteLine(" after detachment of Delete delegate....");
            //Dechaining Delegate
            //Detaching a delegate from master delegate
            master -= requestHandler3;
            master("Sameer");

            MathEngine engine = new MathEngine();

            ArithmaticOperation subtractOperation = new ArithmaticOperation(engine.Subtraction);
            ArithmaticOperation addOperation = new ArithmaticOperation(engine.Addition);
            ArithmaticOperation multiplicationOperation = new ArithmaticOperation(engine.Multiplication);

            ArithmaticOperation calculator = null;
            calculator = subtractOperation;
            calculator += multiplicationOperation;
            calculator+=addOperation;

            int number1 = 45;
            int number2 = 12;

            int result = calculator(number1, number2);
            Console.WriteLine("Result= " + result);

         


            Console.ReadLine();
        }
    }
}
