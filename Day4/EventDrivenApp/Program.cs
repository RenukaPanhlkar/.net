using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountHooks;
using Banking;

namespace EventDrivenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Receiver theReceiver = new Receiver();
           
            account.UnderBalance += theReceiver.BlockAccount;
            account.OverBalance += theReceiver.PayIncomeTax;
            account.OverBalance += theReceiver.SendEmail;
            account.OverBalance += theReceiver.SendSMS;

            account.Balance = 45000;
            account.Deposit(319000);
            Console.WriteLine("Account operation successfull");
            Console.ReadLine();
        }
    }
}
