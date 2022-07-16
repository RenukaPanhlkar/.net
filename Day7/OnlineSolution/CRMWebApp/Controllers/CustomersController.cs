using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CRMWebApp.Models;

namespace CRMWebApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
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
             return Json(customers, JsonRequestBehavior.AllowGet);


            //return View(customers);
        }
    }
}