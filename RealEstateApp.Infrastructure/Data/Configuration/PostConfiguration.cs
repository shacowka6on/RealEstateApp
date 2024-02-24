using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateApp.Infrastructure.Data.Models;

namespace RealEstateApp.Infrastructure.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private Post[] initialPosts = new Post[]
        {
            new Post
            {
                Id = 1,
                Title = "Spacious Family Home",
                Description = "Beautiful 4-bedroom house with a large backyard, perfect for families.",
                CreatedOn = DateTime.Now.AddDays(-7),
                PropertyId = 1, 
                UserId = 1
            },
            new Post
            {
                Id = 2,
                Title = "Luxury Apartment Downtown",
                Description = "Stunning 2-bedroom apartment in the heart of the city, with breathtaking views.",
                CreatedOn = DateTime.Now.AddDays(-5), 
                PropertyId = 2, 
                UserId = 2
            },
            new Post
            {
                Id = 3,
                Title = "Stunning Family Home",
                Description = "Beautiful 3-bedroom house with a small backyard, ideal for families.",
                CreatedOn = DateTime.Now.AddDays(-2),
                PropertyId = 3,
                UserId = 3
            },
            new Post
            {
                Id = 4,
                Title = "Apartment Downtown",
                Description = "Stunning 1-bedroom apartment in the heart of the city.",
                CreatedOn = DateTime.Now.AddDays(-12),
                PropertyId = 4,
                UserId = 4
            },
        };
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Property)
                   .WithOne(p => p.Post)
                   .HasForeignKey<Property>(p => p.PostId);

            builder.HasOne(p => p.User)
                   .WithMany(u => u.Posts)
                   .HasForeignKey(p => p.UserId);

            builder.HasData(initialPosts);
        }
    }
}
