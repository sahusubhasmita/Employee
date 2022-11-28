using Employee_Table.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace Employee_Table.Data
{
    public class MVCDemoDBcontext : DbContext 
    {
        public MVCDemoDBcontext(DbContextOptions options) : base(options)
        {
        }

            public DbSet<Employee> Employees { get; set; }
    
    }
}
