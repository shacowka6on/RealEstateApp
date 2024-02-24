using RealEstateApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Infrastructure.Data.Models
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        public TypeEnum Type { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public StatusEnum Status { get; set; } 
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int SqMeters { get; set; }
        [Required]
        public double Price { get; set; }
        //[Required]
        public string ImageUrl { get; set; } = string.Empty;
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; } = null!;
        public int OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public User Owner { get; set; } = null!;
        public int AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;
    }
}
