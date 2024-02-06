using Microsoft.EntityFrameworkCore;
using MVCCORECodebaseapproach.Models;

namespace MVCCORECodebaseapproach.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options) 
        {
        
        } 
        public DbSet<Employee> Employees { get; set; }
    }
}
