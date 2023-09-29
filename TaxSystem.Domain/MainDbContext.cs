using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.OleDb;

namespace TaxSystem.Domain
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base(Defaults.ConnectionString)
        {
            Database.SetInitializer<MainDbContext>(new CreateDatabaseIfNotExists<MainDbContext>());
        }
        public DbSet<Entities.Owners> Owners { get; set; }
    }
}
