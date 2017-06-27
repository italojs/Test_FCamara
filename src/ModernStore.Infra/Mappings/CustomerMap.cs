using System.Data.Entity.ModelConfiguration;
using TestFCamara.Domain.Entities;

namespace TestFCamara.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(x => x.Id);
            Property(x => x.Name.FirstName).IsRequired().HasMaxLength(60);
            Property(x => x.Name.LastName).IsRequired().HasMaxLength(60);
            HasRequired(x => x.User);
        }
    }
}