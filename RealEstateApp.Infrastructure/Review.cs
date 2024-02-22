using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Infrastructure
{
    public class Review
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
