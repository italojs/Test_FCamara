using System.Data.Entity.ModelConfiguration;
using FCamaraProject.Domain.Entities;

namespace FCamaraProject.Infra.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasKey(x => x.Id);
            Property(x => x.Price);
            Property(x => x.Title).IsRequired().HasMaxLength(80);
        }
    }
}
