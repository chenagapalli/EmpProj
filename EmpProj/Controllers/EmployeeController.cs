using EmpProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeProj.Controllers
{
    public class EmployeeController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> GetEmployees()
        {
            using(MyDBEntities entites = new MyDBEntities())
            {
                return entites.Employees.ToList();
            }
        }
    }
}