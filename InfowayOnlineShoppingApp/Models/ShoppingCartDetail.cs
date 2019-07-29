using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfowayOnlineShoppingApp.Models
{
    public class ShoppingCartDetail
    {
        public int ShoppingCartDetailId { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public int Discount { get; set; }
    }
}