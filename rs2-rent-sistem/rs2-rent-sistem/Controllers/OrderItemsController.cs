using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using rs2_rent_sistem_api.Controllers;

namespace rs2_rent_sistem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemsController : BaseController<OrderItem, OrderItemSearchObject>
    {
        private readonly IOrderItemsService _orderItemsService;
        private readonly ILogger<OrderItemsController> _logger;

        public OrderItemsController(ILogger<OrderItemsController> logger, IOrderItemsService service) : base(logger, service)
        {
            _orderItemsService = service;
            _logger = logger;
        }

        public override Task<PageResult<OrderItem>> Get([FromQuery] OrderItemSearchObject? search = null)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);

            if (userId != null) {
                search.UserId = int.Parse(userId);
            }

            return base.Get(search);
        }
    }
}
