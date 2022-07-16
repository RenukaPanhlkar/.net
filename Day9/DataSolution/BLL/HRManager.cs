using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;
using DAL;

namespace BLL
{
	public class HRManager
    { 
		public static List<Employee> GetAll()
		{
			//YOu can put your business Logic code here before sending data to outer layer
			return EmployeeDAL.GetAll();
		}
		public static bool Insert(Employee emp)
		{
			//YOu can put your business Logic code here before sending data to outer layer
			return EmployeeDAL.Insert(emp);
		}

		public static bool Update(Employee empToUpdate)
		{
			//YOu can put your business Logic code here before sending data to outer layer
			return EmployeeDAL.Update(empToUpdate);
		}
		public static bool Delete(int id)
		{
			//YOu can put your business Logic code here before sending data to outer layer
			return EmployeeDAL.Delete(id);
		}
		public static Employee GetByID(int id)
		{ 
			//YOu can put your business Logic code here before sending data to outer layer
			return EmployeeDAL.GetByID(id);
		}
	}
}
