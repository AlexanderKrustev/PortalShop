namespace PortalShop.Models.Entities.User
{
    using System.Collections.Generic;
    using Product;

    public class Customer
    {
        public int Id { get; set; }

        public IEnumerable<Address> BillingAddresses { get; set; } = new List<Address>();

        public IEnumerable<Address> ShippingAddresses { get; set; } =new List<Address>();

        public int ShoppingCartId{ get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public IEnumerable<Order> Orders  { get; set; } = new List<Order>();

        public IEnumerable<Item> WishList { get; set; } = new List<Item>();
    }
}
