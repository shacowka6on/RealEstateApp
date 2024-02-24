using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Infrastructure.Data.Enums;
using RealEstateApp.Infrastructure.Data.Models;

namespace RealEstateApp.Infrastructure.Data.Configuration
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        private Property[] initialProperties = new Property[]
        {
            new Property
            {
                Id = 1,
                Type = TypeEnum.Apartment,
                Description = "First Property Description",
                Status = StatusEnum.ForSale,
                Bathrooms = 2,
                Bedrooms = 3,
                SqMeters = 55,
                Price = 75_000,
                PostId = 1,
                OwnerId = 1,
                AddressId = 1,
            },
            new Property
            {
                Id = 2,
                Type = TypeEnum.Apartment,
                Description = "Second Property Description",
                Status = StatusEnum.ForSale,
                Bathrooms = 1,
                Bedrooms = 2,
                SqMeters = 45,
                Price = 60_000,
                PostId = 2,
                OwnerId = 2,
                AddressId = 2,
            },
            new Property
            {
                Id = 3,
                Type = TypeEnum.Apartment,
                Description = "Third Property Description",
                Status = StatusEnum.Rent,
                Bathrooms = 1,
                Bedrooms = 1,
                SqMeters = 40,
                Price = 55_000,
                PostId = 3,
                OwnerId = 3,
                AddressId = 3,
            },
        };
        public void Configure(EntityTypeBuilder<Property> builder)
        {

            builder.HasOne(p => p.Post)
               .WithOne(p => p.Property)
               .HasForeignKey<Property>(p => p.PostId);

            builder.HasOne(p => p.Owner)
                   .WithMany(u => u.Properties)
                   .HasForeignKey(p => p.OwnerId);

            builder.HasOne(p => p.Address)
                   .WithOne()
                   .HasForeignKey<Property>(p => p.AddressId);

            builder.HasData(initialProperties);
        }
    }
}
