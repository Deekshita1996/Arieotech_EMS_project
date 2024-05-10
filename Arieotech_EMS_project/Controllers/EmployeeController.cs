using Arieotech_EMS_project.Models;
using Arieotech_EMS_project.Repo;
using Arieotech_EMS_project.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Arieotech_EMS_project.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeService service, ILogger<EmployeeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [BindProperty]
        public List<Employee> employeeList { get; set; }

        [HttpGet]
        public IActionResult Index()
        {

            try
            {
                employeeList = _service.GetEmployee();
                          
            }
            catch (Exception ex)
            {

            }
            return View(employeeList);

        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult GetCreateData(int? id)
        {
            Employee employee = new Employee();
            try
            {
                // var id = CreateModel.Id;
               
                if (id != 0 && id != null)
                {
                    employee = _service.GetEmployee().Where(x => x.Id == id).FirstOrDefault();
                }

            }            
            catch (Exception ex)
            {

            }
            return View(employee);
        }
        [HttpPost]
        public ActionResult CreateEmployee(Employee emp)
        {
            try
            {

                if (emp.Id != 0 && emp.Id != null)
                {
                    _service.EditEmployee(emp);
                   // _service.AddEmployee(emp);
                    
                }
                else
                {

                    _service.AddEmployee(emp);
                }
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
               
            }
            catch(Exception ex)
            {

            }
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
