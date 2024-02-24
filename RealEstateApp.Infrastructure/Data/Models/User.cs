namespace RealEstateApp.Infrastructure.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public ICollection<Review> Reviews { get; set; }
            = new List<Review>();
        public ICollection<Property> Properties { get; set; }
            = new List<Property>();
        public ICollection<Post> Posts { get; set; }
            = new List<Post>();
    }
}
