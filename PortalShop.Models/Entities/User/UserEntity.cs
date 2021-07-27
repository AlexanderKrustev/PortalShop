namespace PortalShop.Models.Entities.User
{
    using Microsoft.AspNetCore.Identity;

    public class UserEntity : IdentityUser
    {
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int SellerId { get; set; }

        public Seller Seller { get; set; }

    }
}
