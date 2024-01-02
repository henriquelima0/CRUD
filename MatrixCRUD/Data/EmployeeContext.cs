using MatrixCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace MatrixCRUD.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> opts)
            : base(opts)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
