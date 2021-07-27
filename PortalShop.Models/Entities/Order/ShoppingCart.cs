namespace PortalShop.Models.Entities.Order
{
    using System;
    using System.Collections.Generic;
    using Product;
    using User;

    public class ShoppingCart
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public IEnumerable<Item> Items { get; set; } = new List<Item>();

        public DateTime CreationDate { get; set; }

        public bool IsAlive { get; set; }

    }
}