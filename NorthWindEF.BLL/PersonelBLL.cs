using NorthWindEF.DAL;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEF.BLL
{
    public static class PersonelBLL
    {

        static NorthwindEntities dataContext = new NorthwindEntities();

        public static List<Employee> GetEmployees()
        {

            return dataContext.Employees.ToList();

        }

        public static int AddEmployee(string name, string lastname, string title)
        {
            Employee employee = new Employee();
            employee.FirstName = name;
            employee.LastName = lastname;
            employee.ReportsTo = null;
            employee.Title = title;

            dataContext.Employees.Add(employee);
            dataContext.SaveChanges();

            return employee.EmployeeID;

        }

        public static object GetEmployeeTitles()
        {
            return dataContext.Employees.Select(x => new { x.Title }).Distinct().ToList();
        }

        public static void DeleteEmployee(int employeeId)
        {

            dataContext.Employees.Remove(dataContext.Employees.Single(e => e.EmployeeID == employeeId));
            dataContext.SaveChanges();

        }

        public static void UpdateEmployee(int id,string name, string lastname)
        {

           var emplpyee= dataContext.Employees.First(e =>e.EmployeeID==id);
            emplpyee.FirstName = name;
            emplpyee.LastName = lastname;
            dataContext.SaveChanges();



        }


    }
}
