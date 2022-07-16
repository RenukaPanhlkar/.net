using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CRMWebApp.Models;

namespace CRMWebApp.Controllers
{
    public class EmployeesController : Controller
    {

        //HTTP Request are of different Type
        //http Verbs HTTPAction
        //GET
        //POST
        //PUT
        //DELETE
        //PATCH


        //http://localhost:7898/employees/index  url
        //URL has been mapped to function
        // GET: Employees
       
        public ActionResult Index()
        {
            List<Employee> employees = HRManager.GetAll();
            return View(employees);
        }

        //http://localhost:7898/employees/details/id 
        public ActionResult Details(int id)
        {  
            Employee employee= HRManager.GetByID(id);
            return View(employee);
       }

        //http://localhost:7898/employees/delete/id
        //
        public ActionResult Delete(int id)
        {
            bool status = HRManager.Delete(id);
           return RedirectToAction("index");       
        }

        //http://localhost:7898/employees/insert
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(int id, string firstname, string lastname,
                                    string email, string department,
                                    string location, string contactnumber)
        {
            Employee emp = new Employee
            {
                ID = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Department = department,
                Location = location,
                ContactNumber = contactnumber
            };
            HRManager.Insert(emp);
            return RedirectToAction("index");

        }



        public ActionResult Update(int id)
        {
            Employee employee = HRManager.GetByID(id);
            return View(employee);
        }


        [HttpPost]
        public ActionResult Update(int id, string firstname, string lastname,
                                    string email, string department,
                                    string location, string contactnumber)
        {
            Employee emp = new Employee
            {
                ID = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Department = department,
                Location = location,
                ContactNumber = contactnumber
            };
            HRManager.Update(emp);
            return RedirectToAction("index");
        }
    }
}

    // NTier Architecture
    // Front End-------View
    // data Lyaer------------Model-----------Business Logic Layer (HR Manager)----Serilaization/Deserilaztion

    // RequestPRocessing---Controller


    // UI----------Model--------Controller------Request

        