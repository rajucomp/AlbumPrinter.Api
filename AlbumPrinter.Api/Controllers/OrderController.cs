using System;
using System.Linq;
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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public ActionResult Post(Order order)
        {
            if (IsNotValid(order))
            {
                return BadRequest();
            }

            if(!IsValidProductType(order))
            {
                return NotFound();
            }
            try
            {
                _orderService.Post(order);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
             
        }

        bool IsNotValid(Order order)
        {
            return order.OrderId <= 0 || order.Products.Any(x => x.Quantity <= 0);
        }

        bool IsValidProductType(Order order)
        {
            return order.Products.All(x => (int)x.ProductType >= 1 && (int)x.ProductType <= 5);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> Get(int orderId)
        {
            try
            {
                Order order = _orderService.Get(orderId);

                if (order == null)
                {
                    return NotFound();
                }

                return Ok(order);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }
    }

    
}
