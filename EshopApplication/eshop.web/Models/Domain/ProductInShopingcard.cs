namespace eshop.web.Models.Domain
{
    public class ProductInShopingcard
    {
        public Guid productId { get; set; }

        public Product Product { get; set; }
        public Guid ShopingcardId { get; set; }

        public ShopingCard ShopingCard { get; set; }

        public int Quantity { get; set; }
    }
}
