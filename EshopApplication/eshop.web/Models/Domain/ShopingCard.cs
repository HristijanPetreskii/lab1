using eshop.web.Models.identify;
using System.ComponentModel.DataAnnotations;

namespace eshop.web.Models.Domain
{
    public class ShopingCard
    {
        //internal object id;

        public Guid Id { get; set; }
        public string ownerId { get; set; }
        public EshopAplicationUser owner { get;set; }
        public virtual ICollection<ProductInShopingcard> ProductInShopingcards { get; set; }
}

    }

