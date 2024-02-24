using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Infrastructure.Data.Models;

namespace RealEstateApp.Infrastructure.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        private Address[] initialAddresses = new Address[]
        {
            new Address
            {
                Id = 1,
                Street = "Nikola Genev",
                City = "Sofia",
                Country = "Bulgaria",
                PostalCode = "1335",
            },
            new Address
            {
                Id = 2,
                Street = "Moreto",
                City = "Varna",
                Country = "Bulgaria",
                PostalCode = "1234",
            },
            new Address
            {
                Id = 3,
                Street = "Hristo Smirnenski",
                City = "Sofia",
                Country = "Bulgaria",
                PostalCode = "2361",
            },
        };
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasMany(p => p.Properties)
                .WithOne(p => p.Address)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(initialAddresses);
        }
    }
}
