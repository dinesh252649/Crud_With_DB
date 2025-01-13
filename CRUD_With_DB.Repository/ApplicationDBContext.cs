//using CRUD_With_DB.Models;
using CRUD_With_DB.Entity;
using Microsoft.EntityFrameworkCore;

namespace CRUD_With_DB.Repository
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        // public DbSet<People> Peoples { get; set; }
        public DbSet<Countary> Countaries { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> Citys { get; set; }

    }
}
