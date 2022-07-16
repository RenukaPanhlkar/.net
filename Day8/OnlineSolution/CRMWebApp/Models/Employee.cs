﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMWebApp.Models
{


	//POCO Class    in C#

	//POJO Class    in Java
	//Plain Old CRL Object

	[Serializable]
    public class Employee
    {
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Department { get; set; }
		public string ContactNumber { get; set; }
		public string Email { get; set; }
		public string Location { get; set; }
	}
}