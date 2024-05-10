using System.ComponentModel.DataAnnotations;

namespace Arieotech_EMS_project.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string JoiningDate { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }
    }
}
