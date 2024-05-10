using Arieotech_EMS_project.Models;
using Arieotech_EMS_project.Repo;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Arieotech_EMS_project.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IemployeeRepo _employeesrepo;

        public EmployeeService(IemployeeRepo employeerepo)
        {
            _employeesrepo = employeerepo;
        }

        
       

        public int AddEmployee(Employee obj)
        {
            return _employeesrepo.AddEmployee(obj);

        }

        public int Delete(int id)
        {
            return _employeesrepo.Delete(id);
        }

        public int EditEmployee(Employee emp)
        {
            return _employeesrepo.EditEmployee(emp);

        }

        public List<Employee> GetEmployee()
        {
            return _employeesrepo.GetEmployee().ToList();

        }
        public Employee GetEmployeeById(int id)
        {
            return _employeesrepo.GetEmployeeById(id);

        }

    }
}
