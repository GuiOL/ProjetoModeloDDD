using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(k => k.ProductId);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);
            Property(p => p.Value)
                .IsRequired();

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(k => k.ClientId);
        }
    }
}
