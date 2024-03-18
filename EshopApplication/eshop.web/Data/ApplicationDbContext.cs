using eshop.web.Models.Domain;
using eshop.web.Models.identify;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eshop.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<EshopAplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShopingCard> ShopingCards { get; set; }
        public virtual DbSet<ProductInShopingcard> ProductInShopingcards { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .Property(z => z.id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShopingCard>()
               .Property(z => z.Id)
               .ValueGeneratedOnAdd();

            builder.Entity<ProductInShopingcard>()
                .HasKey(z => new { z.productId, z.ShopingcardId });

            builder.Entity<ProductInShopingcard>()
                .HasOne(z => z.Product)
                .WithMany(z => z.ProductInShopingcards)
                .HasForeignKey(z => z.ShopingcardId);

            builder.Entity<ProductInShopingcard>()
                .HasOne(z => z.ShopingCard)
                .WithMany(z => z.ProductInShopingcards)
                .HasForeignKey(z => z.productId);

            builder.Entity<ShopingCard>()
                .HasOne<EshopAplicationUser>(z => z.owner)
                .WithOne(z => z.UserCard)
                .HasForeignKey<ShopingCard>(z => z.ownerId);

        }
    }
}
