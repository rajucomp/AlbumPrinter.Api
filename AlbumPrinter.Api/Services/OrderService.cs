using System;
using AlbumPrinter.Api.Models;
using System.Collections.Generic;

namespace AlbumPrinter.Api
{
    public class OrderService : IOrderService
    {
        IDictionary<ProductTypeEnum, IWidthCalculator> enumToCalculatorDictionary =
            new Dictionary<ProductTypeEnum, IWidthCalculator>
            {
                { ProductTypeEnum.PhotoBook, new PhotoBookWidthCalculator(19) },
                { ProductTypeEnum.Calendar, new CalendarWidthCalculator(10) },
                { ProductTypeEnum.Canvas, new CanvasWidthCalculator(16)},
                { ProductTypeEnum.Cards, new CardsWidthCalculator(4.7)},
                { ProductTypeEnum.Mug, new MugWidthCalculator(94)}
            };

        Dictionary<int, Order> orderDictionary;

        public OrderService()
        {
            orderDictionary = new Dictionary<int, Order>();
        }

        public void Post(Order order)
        {
            orderDictionary[order.OrderId] = order;
        }

        public Order Get(int orderId)
        {
            if(!orderDictionary.ContainsKey(orderId))
            {
                return null;
            }

            Order order = orderDictionary[orderId];
            order.RequiredBinWidth = CalculateWidth(order);
            return order;
        }

        public double CalculateWidth(Order order)
        {
            double count = 0;

            foreach(Product product in order.Products)
            {
                count += enumToCalculatorDictionary[product.ProductType].CalculateWidth(product.Quantity);
            }

            return count;
        }

        public double CalculateWidth(int productType, int quantity)
        {
            return enumToCalculatorDictionary[(ProductTypeEnum)productType].CalculateWidth(quantity);
        }
    }
}
