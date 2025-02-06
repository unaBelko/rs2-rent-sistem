using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IReviewService : IService<Review, ReviewSearchObject>
    {
        Task<Review> AddReview(ReviewUpsertObject review);
        Task HideReview(int reviewId, string userRole);
    }
}
