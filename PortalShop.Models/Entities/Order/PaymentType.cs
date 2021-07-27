namespace PortalShop.Models.Entities.Order
{
    using System.ComponentModel.DataAnnotations;

    public class PaymentType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        public string Value { get; set; } //Temporary to, to be implemented with real payment type
    }
}
