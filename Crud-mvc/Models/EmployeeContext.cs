using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Crud_mvc.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
         
        public DbSet<Employee> Employees{ get; set; }
    }
}
