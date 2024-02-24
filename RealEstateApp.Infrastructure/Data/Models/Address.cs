using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Infrastructure.Data.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        [MaxLength(4)]
        public string PostalCode { get; set; } = string.Empty;
        public ICollection<Property> Properties { get; set; } 
            = new List<Property>();
    }
}
