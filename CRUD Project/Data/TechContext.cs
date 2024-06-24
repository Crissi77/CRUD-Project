using CRUD_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Project.Data
{
    public class TechContext:DbContext
    {
        public TechContext(DbContextOptions<TechContext> options) : base (options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
                     