using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CRMWebApp.Controllers
{

    // Controller Class
    public class HomeController : Controller
    {

        //List of Action Methods
        //Each Action method would return value of type ActionResult
        //ActionResult is a base class
        //ViewResult derived from ActionRsult
        //JSONResult derived from ActionResult

        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return this.View();
        }
    }
}