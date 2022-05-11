using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlbumPrinter.Api.Models
{
    public class Order
    {
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int OrderId { get; set; }
        public IList<Product> Products { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public double RequiredBinWidth { get; set; }

        public Order(int Id, IList<Product> products)
        {
            this.OrderId = Id;
            this.Products = products;
        }

        public Order()
        {

        }

        public Order(int Id)
        {
            this.OrderId = Id;
            this.Products = new List<Product>();
        }
    }
}
