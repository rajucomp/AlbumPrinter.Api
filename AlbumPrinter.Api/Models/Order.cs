using System;
using System.Collections.Generic;

namespace AlbumPrinter.Api.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public IList<Product> Products { get; set; }
        public double RequiredBinWidth { get; set; }

        public Order(int Id, IList<Product> products)
        {
            this.OrderId = Id;
            this.Products = products;
        }

        public Order(int Id)
        {
            this.OrderId = Id;
            this.Products = new List<Product>();
        }
    }
}
