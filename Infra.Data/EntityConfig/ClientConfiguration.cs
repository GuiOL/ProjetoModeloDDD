using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(k => k.ClientId);

            Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.Email)
                .IsRequired();
        }
    }
}
