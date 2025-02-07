using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using rs2_rent_sistem_api.Controllers;

namespace rs2_rent_sistem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : BaseController<Review, ReviewSearchObject>
    {
       public ReviewController(IReviewService service, ILogger<ReviewController> logger) : base(logger, service)
        {
        }

        public override async Task<PageResult<Review>> Get([FromQuery] ReviewSearchObject? search = null)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (userId != null)
            {
                search.userId = int.Parse(userId);
                var reviews = await _service.Get(search);
                return reviews;
            }
            else {
                return null;
            }
        }

        [Authorize(Roles = "employee")]
        [HttpDelete]
        public async Task RemoveReview(int id)
        {
            var userRole = User.FindFirstValue(ClaimTypes.Role);
            await ((IReviewService)_service).HideReview(id, userRole);
        }

        [HttpPost]
        public async Task AddReview(ReviewUpsertObject review)
        {
            await ((IReviewService)_service).AddReview(review);
        }

    }
}
