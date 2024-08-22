using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Models.Models;
using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : BaseController<Cart, CartSearchObject>
    {
        private readonly ICartService _cartService;
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger, ICartService service) : base(logger, service)
        {
            _cartService = service;
            _logger = logger;
        }

        // POST: api/Cart/AddItem
        [HttpPost("AddItem")]
        public async Task<IActionResult> AddItemToCart([FromBody] CartItemUpsertObject cartItem)
        {
            if (cartItem == null)
            {
                return BadRequest("Invalid cart item.");
            }

            try
            {
                var updatedCart = await _cartService.AddToCart(cartItem);
                return Ok(updatedCart);
            }
            catch (Exception ex)
            {
                // Log the error if needed
                _logger.LogError(ex, "Error adding item to cart");
                return StatusCode(500, "An error occurred while adding the item to the cart.");
            }
        }

        // POST: api/Cart/RemoveItem
        [HttpPost("RemoveItem")]
        public async Task<IActionResult> RemoveItemFromCart([FromBody] CartItem cartItem)
        {
            if (cartItem == null)
            {
                return BadRequest("Invalid cart item.");
            }

            try
            {
                var updatedCart = await _cartService.RemoveFromCart(cartItem);
                return Ok(updatedCart);
            }
            catch (Exception ex)
            {
                // Log the error if needed
                _logger.LogError(ex, "Error removing item from cart");
                return StatusCode(500, "An error occurred while removing the item from the cart.");
            }
        }

        [HttpPost("Empty/{id}")]
        public async Task<IActionResult> EmptyCart(int id)
        {
            try
            {
                await _cartService.EmptyCart(id);
                return Ok("Cart has been emptied successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error emptying cart");
                return StatusCode(500, "An error occurred while emptying the cart.");
            }
        }
    }

}
