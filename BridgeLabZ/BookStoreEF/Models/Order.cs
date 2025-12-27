using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreEF.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public virtual User User { get; set; }
    }
}