using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();

            list.Add(new Customer { Id = 12, Name = "IBM", ContactNumber = "9881745792", Email = "santosh.p@ibm.com" });
            list.Add(new Customer { Id = 13, Name = "Microsoft", ContactNumber = "9888645792", Email = "seema.p@microsoft.com" });
            list.Add(new Customer { Id = 14, Name = "Facebook", ContactNumber = "9881745792", Email = "chirag.h@facebbok.com" });
            list.Add(new Customer { Id = 15, Name = "Tesla", ContactNumber = "9887645792", Email = "sohail@tesla.com" });

            Console.WriteLine("Customers have been perssisted using Serialization process");
            FileStream fs=new FileStream("customers.dat",FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();

            Console.WriteLine("File has been stored with all list of person data");


            Console.WriteLine("\n-----------------------------------------------");

            Console.WriteLine("Customers retrived from File using DeSerialization process");


            //List<Customer> retrivedCustomers= (List<Customer>)bf.Deserialize(fs);
            FileStream fsToRead = new FileStream("customers.dat", FileMode.Open);
            List<Customer> retrivedCustomers =  bf.Deserialize(fsToRead) as  List<Customer>;
            fsToRead.Close();
            foreach( Customer theCustomer in retrivedCustomers)
            {
                Console.WriteLine(theCustomer.Name + " " + theCustomer.ContactNumber + " "+ theCustomer.Email);
            }
            Console.ReadLine();
        }
    }
}
