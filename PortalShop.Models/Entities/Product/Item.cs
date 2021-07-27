namespace PortalShop.Models.Entities.Product
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal CurrentPrice { get; set; }

        [Required]
        public decimal BasePrice { get; set; }

        public IEnumerable<ItemCharacteristic> ItemCharacteristics { get; set; } =  new List<ItemCharacteristic>();

        public IEnumerable<Order> Orders { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }


    }
}
