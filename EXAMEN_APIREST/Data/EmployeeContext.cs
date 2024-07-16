using EXAMEN_APIREST.Models;
using Microsoft.EntityFrameworkCore;
namespace EXAMEN_APIREST.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
