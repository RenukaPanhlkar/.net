using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHooks
{
    //Helper function /Accont handler functions /Event Receivers /Callback function 
    public class Receiver
    {
        public void SendSMS()
        {
            Console.WriteLine("Information  has been sent to your registered Mobile Number");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email has been sent to your registered email address");
        }

        public   void BlockAccount()
        {
            Console.WriteLine("Your account has been blocked due to less Balance");
        }

        public   void PayIncomeTax()
        {
            Console.WriteLine("Your account has been charged with 10% income tax. ");
            Console.WriteLine("10% Income tax has been deducted from your account...");
        }
    }
}
