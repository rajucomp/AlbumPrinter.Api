using System;
using AlbumPrinter.Api.Models;
using System.Collections.Generic;

namespace AlbumPrinter.Api
{
    public interface IOrderService
    {
        void Post(Order order);

        Order Get(int orderId);

        double CalculateWidth(Order order);

        double CalculateWidth(int productType, int quantity);
    }
}