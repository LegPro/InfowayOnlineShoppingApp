using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfowayOnlineShoppingApp.Models
{
    public class CustomerProductDetail
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Qty { get; set; }
        public int Discount { get; set; }
        public static int Total { get; set; }
    }
}