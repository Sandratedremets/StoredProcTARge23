using Microsoft.EntityFrameworkCore;
using StoredProcedureTARge23.Models;

namespace StoredProcedureTARge23.Data
{
    public class StoredProcDbContext : DbContext
    {
        public StoredProcDbContext(DbContextOptions<StoredProcDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
