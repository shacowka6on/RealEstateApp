namespace RealEstateApp.Infrastructure
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Property> Favorites { get; set; }
            = new List<Property>();
    }
}
