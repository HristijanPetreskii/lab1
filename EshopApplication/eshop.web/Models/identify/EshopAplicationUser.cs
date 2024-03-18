using eshop.web.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace eshop.web.Models.identify
{
    public class EshopAplicationUser:IdentityUser

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

        public virtual ShopingCard UserCard { get; set; }
    }
}
