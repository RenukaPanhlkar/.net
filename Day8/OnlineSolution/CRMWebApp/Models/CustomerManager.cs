using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{
    public class CustomerManager
    {

        public static List<Customer> LoadData()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { ID = 19, Name = "IBM", ContactNumber = "8772374556", ContactPerson = "Peter Parker" });
            customers.Add(new Customer { ID = 20, Name = "Microsoft", ContactNumber = "8787374567", ContactPerson = "Alan Donald" });
            customers.Add(new Customer { ID = 21, Name = "Persistent", ContactNumber = "8779874569", ContactPerson = "Mahesh Patil" });
            customers.Add(new Customer { ID = 22, Name = "Tata Technologies", ContactNumber = "9832374567", ContactPerson = "Kiran Manik" });
            customers.Add(new Customer { ID = 23, Name = "KnowIT", ContactNumber = "8772374569", ContactPerson = "Bakul Joshi" });
            customers.Add(new Customer { ID = 24, Name = "IACSD", ContactNumber = "8732374567", ContactPerson = "Prashant Karhale" });
            customers.Add(new Customer { ID = 25, Name = "Sunbeam", ContactNumber = "8772374876", ContactPerson = "Nitin Kudale" });
            customers.Add(new Customer { ID = 25, Name = "IET", ContactNumber = "8772374898", ContactPerson = "Sangram Patil" });

            //Write Deserializtion data from file and return customers
            //Add ado.net code to fetch data from mysql

            return customers;
        }

        public static bool SaveData(List<Customer> customers)
        {
            bool status = false;
            //Implement serailization logic to store all list into file

            return status;
        }
    }
}