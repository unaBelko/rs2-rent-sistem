using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
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
        private readonly IOrderService _OrderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IOrderService service) : base(logger, service)
        {
            _OrderService = service;
            _logger = logger;
        }

        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreationRequest request)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);


            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                var userIdInt = int.Parse(userId);
                request.UserId = userIdInt;
            }

            try
            {
                var order = await _OrderService.CreateOrder(request);
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
