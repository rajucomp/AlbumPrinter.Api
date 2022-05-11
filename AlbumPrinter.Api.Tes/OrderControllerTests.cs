using System;
using Xunit;
using AlbumPrinter.Api.Models;
using AlbumPrinter.Api.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AlbumPrinter.Api.Tes
{

    public class OrderControllerTests
    {
        readonly OrderController orderController;
        readonly OrderService orderService;

        public OrderControllerTests()
        {
            orderService = new OrderService();
            orderController = new OrderController(this.orderService);
        }

        [Fact]
        public void ShouldReturnNullWhenOrderDoesNotExists()
        {
            List<Product> products = new List<Product>()
            {
                new Product(ProductTypeEnum.PhotoBook, 1),
                new Product(ProductTypeEnum.Calendar, 2),
                new Product(ProductTypeEnum.Mug, 1)
            };

            Order order = new Order(1, products);

            Order result = orderController.Get(order.OrderId);

            Assert.Null(result);

        }

        [Fact]
        public void TestForOneMug()
        {
            var products = new List<Product>()
            {
                new Product(ProductTypeEnum.PhotoBook, 1),
                new Product(ProductTypeEnum.Calendar, 2),
                new Product(ProductTypeEnum.Mug, 1)
            };

            var order = new Order(1, products);

            orderController.Post(order);

            var result = orderController.Get(order.OrderId);

            var expectedValue = 133;

            Assert.Equal(expectedValue, result.RequiredBinWidth, 2);
        }

        [Fact]
        public void TestForFourMugs()
        {
            var products = new List<Product>()
            {
                new Product(ProductTypeEnum.PhotoBook, 1),
                new Product(ProductTypeEnum.Calendar, 2),
                new Product(ProductTypeEnum.Mug, 4)
            };

            var order = new Order(1, products);

            orderController.Post(order);

            var result = orderController.Get(order.OrderId);

            var expectedValue = 133;

            Assert.Equal(expectedValue, result.RequiredBinWidth, 2);
        }

        [Fact]
        public void TestForFiveMugs()
        {
            var products = new List<Product>()
            {
                new Product(ProductTypeEnum.PhotoBook, 1),
                new Product(ProductTypeEnum.Calendar, 2),
                new Product(ProductTypeEnum.Mug, 5)
            };

            var order = new Order(1, products);

            orderController.Post(order);

            var result = orderController.Get(order.OrderId);

            var expectedValue = 227;

            Assert.Equal(expectedValue, result.RequiredBinWidth, 2);
        }

        [Fact]
        public void TestForNineMugs()
        {
            var products = new List<Product>()
            {
                new Product(ProductTypeEnum.PhotoBook, 1),
                new Product(ProductTypeEnum.Calendar, 2),
                new Product(ProductTypeEnum.Mug, 9)
            };

            var order = new Order(1, products);

            orderController.Post(order);

            var result = orderController.Get(order.OrderId);

            var expectedValue = 321;

            Assert.Equal(expectedValue, result.RequiredBinWidth, 2);
        }
    }
}
