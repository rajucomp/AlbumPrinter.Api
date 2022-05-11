using System;
using System.ComponentModel.DataAnnotations;

namespace AlbumPrinter.Api.Models
{
    public class Product
    {
        public ProductTypeEnum ProductType { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public double Width { get; set; }

        public Product(ProductTypeEnum productType, int quantity)
        {
            this.ProductType = productType;
            this.Quantity = quantity;
        }

        public Product()
        {

        }
    }
}