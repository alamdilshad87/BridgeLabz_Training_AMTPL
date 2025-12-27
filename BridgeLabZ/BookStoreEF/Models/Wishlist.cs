using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreEF.Models
{
    public class Wishlist
    {
        public int WishlistId { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}
