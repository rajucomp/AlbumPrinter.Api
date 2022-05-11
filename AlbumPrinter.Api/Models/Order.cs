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


    public class Product
    {
        public ProductTypeEnum ProductType { get; set; }
        public int Quantity { get; set; }
        public double Width { get; set; }

        public Product(ProductTypeEnum productType, int quantity)
        {
            this.ProductType = productType;
            this.Quantity = quantity;
        }
    }

    public enum ProductTypeEnum
    {
        PhotoBook = 1,
        Calendar = 2,
        Canvas = 3,
        Cards = 4,
        Mug = 5
    }
}
