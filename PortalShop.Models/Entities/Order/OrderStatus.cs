namespace PortalShop.Models.Entities.Order
{
    using System.ComponentModel.DataAnnotations;

    public class OrderStatus
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Status { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

    }
}
