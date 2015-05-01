using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {

        public IEmployeeDao EmployeeDao { get; set; }

        public void AddEmployee(Employee employee)
        {
            EmployeeDao.AddEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            EmployeeDao.UpdateEmployee(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            employee = EmployeeDao.GetEmployeeByName(employee.Name);

            if (employee != null)
            {
                EmployeeDao.DeleteEmployee(employee);
            }
        }

        public IList<Employee> GetAllEmployees()
        {
            return EmployeeDao.GetAllEmployees();
        }
        public Employee GetEmployeeById(string Id)
        {
            return EmployeeDao.GetEmployeeById(Id);
        }

        public Employee GetEmployeeByName(string Name)
        {
            return EmployeeDao.GetEmployeeByName(Name);
        }

    }

}
