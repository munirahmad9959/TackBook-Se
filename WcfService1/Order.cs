using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Order
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ClientName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}