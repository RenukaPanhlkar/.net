using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoApp
{

    //Multiple Interface inheritance is possible in C#
    //CSharp allows inteface methods should be accessed using interface name

   public interface IOrderDetails {
         void ShowDetails();
    }
   public interface ICustomerDetails {
        void ShowDetails();
   }

    class Transaction : IOrderDetails, ICustomerDetails
    {
        void IOrderDetails.ShowDetails()
        { // implementation for interface IOrderDetails ;
        }
        void ICustomerDetails.ShowDetails()
        { // implementation for interface IOrderDetails ;}

        }
    }

          
    internal class Program
    {
        static void Main(string[] args)
        {

            Transaction obj = new Transaction();
           
            IOrderDetails od = obj;
            od.ShowDetails();

            ICustomerDetails cd = obj;
            cd.ShowDetails();

        }
    }
}
