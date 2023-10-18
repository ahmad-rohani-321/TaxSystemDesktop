using System.Data.Entity;

namespace TaxSystem.Domain
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base(Defaults.ConnectionString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MainDbContext>());
        }
        public DbSet<Entities.Owners> Owners { get; set; }
        public DbSet<Entities.PropertyInfo> PropertyInfo { get; set; }
        public DbSet<Entities.CurrentOwners> CurrentOwners { get; set; }
        public DbSet<Entities.PropertyLevel> PropertyLevel { get; set; }
        public DbSet<Entities.PaymentPeriods> PaymentPeriods { get; set; }
    }
}
