using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Infrastructure
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Area { get; set; }
        public double Price { get; set; }
        public string Location { get; set; } = string.Empty;
        public int Beds { get; set; }
        public int Bathrooms { get; set; }
        public DateTime CreatedOn { get; set; }
        public int OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public Owner Owner { get; set; } = null!;
    }
}
