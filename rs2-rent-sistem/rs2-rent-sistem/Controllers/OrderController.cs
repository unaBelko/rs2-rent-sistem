using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using rs2_rent_sistem_api.Controllers;
using System.Security.Claims;

namespace rs2_rent_sistem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : BaseController<Order, OrderSearchObject>
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IOrderService service) : base(logger, service)
        {
            _orderService = service;
            _logger = logger;
        }

        [HttpGet]
        public override async Task<PageResult<Order>> Get(OrderSearchObject? search)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (userId != null)
            {
                var orders = await _orderService.Get(new OrderSearchObject()
                {
                    UserId = int.Parse(userId),
                });
                return orders;
            }
            else
            {
                return null;
            }
        }

        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);


            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                try
                {
                    var order = await _orderService.CreateOrder(int.Parse(userId));
                    return Ok(order);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error creating order");
                    return StatusCode(500, "An error occurred while creating the order.");
                }
            }
        }

    }
}
