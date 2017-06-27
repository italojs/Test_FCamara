using System.Data.Entity;
using TestFCamara.Domain.Entities;
using TestFCamara.Infra.Mappings;
using TestFCamara.Shared;

namespace TestFCamara.Infra.Contexts
{
    public class DB_FCAMARADataContext : DbContext
    {
        public DB_FCAMARADataContext() : base(Runtime.ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}