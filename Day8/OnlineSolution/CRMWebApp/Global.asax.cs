using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CRMWebApp.Models;

namespace CRMWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           /* List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { ID = 23, FirstName = "Shiv", LastName = "Kumar", Department = "IT", Location = "Pune", ContactNumber = "9881734687", Email = "shiv.kumar@gmail.com" });
            employees.Add(new Employee { ID = 13, FirstName = "Manoj", LastName = "Varma", Department = "IT", Location = "Pune", ContactNumber = "9881734765", Email = "manoj.varama@gmail.com" });
            employees.Add(new Employee { ID = 63, FirstName = "Radhika", LastName = "Sharma", Department = "IT", Location = "Pune", ContactNumber = "9881734687", Email = "radhika.sharma@gmail.com" });

            string path = @"D:\try\employees.dat";
            bool status = HRManager.SaveData(path, employees);
           */


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
