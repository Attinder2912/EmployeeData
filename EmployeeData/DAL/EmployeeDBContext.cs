using EmployeeData.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeData.DAL
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee>Employees { get; set; }
    }
}
