using Arieotech_EMS_project.Models;

namespace Arieotech_EMS_project.Repo
{
    public interface IemployeeRepo
    {
        public int AddEmployee(Employee obj);

        public int EditEmployee(Employee emp);
        public List<Employee> GetEmployee();
        public Employee GetEmployeeById(int id);
        public int Delete(int id);
    }
}
