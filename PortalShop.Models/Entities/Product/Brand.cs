namespace PortalShop.Models.Entities.Product
{
    using System.ComponentModel.DataAnnotations;

    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string PicUrl { get; set; }
    }
}
