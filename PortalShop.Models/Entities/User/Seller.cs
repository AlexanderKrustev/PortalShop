namespace PortalShop.Models.Entities.User
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string BusinessName { get; set; }

        [MaxLength(20)]
        public string  VAT { get; set; }


        public IEnumerable<Sale> Sales { get; set; }

    }
}
