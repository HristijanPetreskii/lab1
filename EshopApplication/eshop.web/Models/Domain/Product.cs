using System.ComponentModel.DataAnnotations;

namespace eshop.web.Models.Domain
{
    public class Product
    {
        public Guid id { get; set; }
        [Required]
        public string productname { get; set; }
        [Required]
        public string productimage { get; set; }
        [Required]
        public string productdescription { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int Raiting { get; set; }
        [Required]
        public virtual ICollection<ProductInShopingcard> ProductInShopingcards { get; set; }

    }
}
