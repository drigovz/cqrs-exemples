using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CustomersCqrs.Domain.Entities;

namespace CustomersCqrs.Infra.Data.Mappings.Customers
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                   .IsRequired();

            builder.Property(x => x.FirstName)
                   .IsRequired();

            builder.Property(x => x.LastName)
                   .IsRequired();

            builder.Property(x => x.Email)
                   .IsRequired();
        }
    }
}
