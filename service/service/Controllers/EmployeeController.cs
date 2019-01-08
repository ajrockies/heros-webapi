using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using service.Models;

namespace service.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            var dbContext = new DbBaseContext();
            return dbContext.Employee.ToList();
            //List<Employee> list = new List<Employee>();
            //return list;
        }

        // GET api/values
        [HttpPost]
        public ActionResult<Employee> SaveChanges()
        {
            Employee employee = new Employee();
            var dbContext = new DbBaseContext();
            dbContext.Employee.Add(employee);
            dbContext.SaveChanges();

            return employee;
        }
    }
}
