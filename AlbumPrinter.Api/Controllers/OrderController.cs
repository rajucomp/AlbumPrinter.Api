using System;
using System.Net.Mime;
using System.Threading.Tasks;
using AlbumPrinter.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlbumPrinter.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost, Route("/Post")]
        public IActionResult Post(Order order)
        {
             _orderService.Post(order);
            return Ok();
        }

        [HttpGet("{id}")]
        public Order Get(int orderId)
        {
            return _orderService.Get(orderId);
        }
    }

    
}
