using CRUD_With_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_With_DB.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { 
        
        }
        public DbSet<People> Peoples { get; set; }
        
    }
}
