namespace PortalShop.Models.Entities
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class PortalShopDbContext : IdentityDbContext
        {
            public PortalShopDbContext(DbContextOptions<PortalShopDbContext> options)
                : base(options)
            {
            }
        }
    

}
