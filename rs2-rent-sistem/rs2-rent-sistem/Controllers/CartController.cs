﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using System.Security.Claims;

namespace rs2_rent_sistem_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : BaseController<rs2_rent_sistem.Model.Models.Cart, CartSearchObject>
    {
        private readonly ICartService _cartService;
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger, ICartService service) : base(logger, service)
        {
            _cartService = service;
            _logger = logger;
        }

        [HttpGet("GetUsersCart")]
        public async Task<rs2_rent_sistem.Model.Models.Cart?> GetUsersCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (userId != null)
            {
                var cart = await _cartService.GetById(int.Parse(userId));
                return cart;
            }
            else
            {
                return null;
            }
        }

        [HttpPost("AddItem")]
        public async Task<IActionResult> AddItemToCart([FromBody] CartItemUpsertObject cartItem)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);


            if (userId == null)
            {
                return Unauthorized();
            }
            else
            {
                var userIdInt = int.Parse(userId);
                cartItem.UserID = userIdInt;
            }

            try
            {
                var updatedCart = await _cartService.AddToCart(cartItem);
                return Ok(updatedCart);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding item to cart");
                return StatusCode(500, "An error occurred while adding the item to the cart.");
            }
        }

        [HttpDelete("RemoveItem")]
        public async Task<IActionResult> RemoveItemFromCart(int cartItemId)
        {
            try
            {
                var updatedCart = await _cartService.RemoveFromCart(cartItemId);
                return Ok(updatedCart);
            }
            catch (Exception ex)
            {
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
