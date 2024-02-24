using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Infrastructure.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;
        public int PropertyId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; } = null!;
    }
}
