using System;

namespace AlbumPrinter.Api.Models
{
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
}