using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
    }
}