using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class employeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }

        [HttpGet]
        [ActionName("byId")]
        public Employee GetEmployeeById(string Id)
        {
            var employee = EmployeeService.GetEmployeeById(Id);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }

        [HttpGet]
        [ActionName("byName")]
        public Employee GetEmployeeByName(string Name)
        {
            var employee = EmployeeService.GetEmployeeByName(Name);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }
    }
}
