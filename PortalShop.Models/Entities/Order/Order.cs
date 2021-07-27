namespace PortalShop.Models.Entities.Order
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Product;
    using User;

    public class Order
    {
        public int Id { get; set; }

        public IEnumerable<Item> Items { get; set; } = new List<Item>();

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public PaymentType  PaymentType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        [Required]
        public PaymentType PaymentStatus { get; set; }


    }

    
}
