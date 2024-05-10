using Arieotech_EMS_project.Models;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;

namespace Arieotech_EMS_project.Repo
{
    public class EmployeeRepo : IemployeeRepo
    {
        private readonly AppDBContext _db;
        public EmployeeRepo(AppDBContext db)
        {
            _db = db;
        }
        public int Delete(int id)
        {
           var employee =   _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            return _db.SaveChanges();
        }


        public int AddEmployee(Employee empobj)
        {
            _db.Employees.Add(empobj);
            int res = _db.SaveChanges();
            return res;
        }

        public int EditEmployee(Employee emp)
        {
            
            _db.Employees.Update(emp);
            int result = _db.SaveChanges();
            return result;
        }
        public List<Employee> GetEmployee()
        {
            List<Employee> employees = _db.Employees.ToList();
            return employees;
        }
        public Employee GetEmployeeById(int id)
        {
            var employee = _db.Employees.Find(id);
            return employee;
        }



    }
}
