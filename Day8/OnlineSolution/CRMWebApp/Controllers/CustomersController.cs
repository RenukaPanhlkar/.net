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
            //return Json(customers, JsonRequestBehavior.AllowGet);
            List<Customer> customers = CustomerManager.LoadData();
            return View(customers);
        }
    }
}