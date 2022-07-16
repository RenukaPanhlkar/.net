using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        //Auto property
        public  int Id { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public Account()
        {
            Balance = 0;
        }
        public Account(double balance)
        {
            Random random = new Random(); 
            this.Id = random.Next();
            this.Balance = balance;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            if (this.Balance <= 5000)
            {
                throw new Exception("Insufficient Balance");
            }
        }
        public void Deposit(double amount)
        {
            this.Balance += amount;
            if (this.Balance >= 250000)
            {
                throw new Exception("Balance Overflow");
            }
        }

    }
}
