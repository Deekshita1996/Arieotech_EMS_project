using Arieotech_EMS_project.Models;
using Microsoft.EntityFrameworkCore;

namespace Arieotech_EMS_project
{
    public class AppDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=EmployeeDataBase;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
