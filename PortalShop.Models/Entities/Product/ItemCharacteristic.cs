namespace PortalShop.Models.Entities.Product
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ItemCharacteristic
    {
        [Key] public int Id { get; set; }

        [Required]
        [MaxLength(30)] 
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [MaxLength(20)] 
        public string Value { get; set; }

        public IEnumerable<Item> Items { get; set; } = new List<Item>();


    }
}
