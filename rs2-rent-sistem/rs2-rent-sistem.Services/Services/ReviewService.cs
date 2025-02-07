using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class ReviewService : BaseService<Review, Database.Review, ReviewSearchObject>, IReviewService
    {
        private readonly IOrderItemsService orderItemsService;
        private readonly IEquipmentService equipmentService;
        public ReviewService(RentSistemDbContext context, IMapper mapper, IOrderItemsService orderItemsService, IEquipmentService equipmentService) : base(context, mapper)
        {
            this.orderItemsService = orderItemsService;
            this.equipmentService = equipmentService;   
        }

        public override async Task<PageResult<Review>> Get(ReviewSearchObject? search = null)
        {
            if (search == null) { 
                return new PageResult<Review>();
            }

            var user = await _context.Users
                .Include(u => u.UserRoles)
                .ThenInclude(r => r.Role)
                .FirstOrDefaultAsync(u => u.ID == search.userId);

            if (user == null)
            {
                return new PageResult<Review>();
            }

            var userIsEmployee = user.UserRoles.Any(ur => ur.Role.Name == "employee");
            IQueryable<Database.Review> query = _context.Set<Database.Review>().AsQueryable();

            if (userIsEmployee) {
                if(search.searchForUserId.HasValue )
                {
                    query = query.Where(r => r.OrderItem.Order.UserID == search.searchForUserId.Value);
                }
                if(search.searchForEquipmentId.HasValue )
                {
                    query = query.Where(r => r.OrderItem.EquipmentID == search.searchForEquipmentId.Value);
                }
            }
            else
            {
                query = query.Where(r => r.OrderItem.Order.UserID == search.userId);
            }

            PageResult<Review> result = new();

            query = AddFilter(query, search);
            query = AddInclude(query, search);

            result.Count = await query.CountAsync();

            if (search.Page.HasValue && search.PageSize.HasValue)
            {
                query = query.Skip(search.Page.Value * search.PageSize.Value)
                             .Take(search.PageSize.Value);
            }

            var list = await query.ToListAsync();
            var tmp = _mapper.Map<List<Review>>(list);
            result.Result = tmp;

            return result;
        }

        public async Task<Review> AddReview(ReviewUpsertObject review)
        {
            var orderItem = await _context.OrderItems
                .Include(oi => oi.Order)
                .FirstOrDefaultAsync(oi => oi.ID == review.OrderItemID) ?? throw new ArgumentException("Order item not found.");
            if (orderItem.Order.Status.ToLower() != "returned")
            {
                throw new InvalidOperationException("Cannot add a review. The order has not been returned.");
            }

            var newReview = new Database.Review()
            {
                DateAdded = DateTime.Now,
                Description = review.Description,
                NumberOfStars = (decimal?)review.NumberOfStars,
                OrderItemID = review.OrderItemID,
            };

            _context.Reviews.Add(newReview);
            await _context.SaveChangesAsync();

            await orderItemsService.MarkOrderItemAsReviewed(review.OrderItemID);
            await equipmentService.RecalculateAverageRating(orderItem.EquipmentID);

            return _mapper.Map<Review>(newReview);
        }
        public async Task HideReview(int reviewId, string userRole)
        {
            if (userRole.ToLower() != "employee")
            {
                throw new UnauthorizedAccessException("Only employees can hide reviews.");
            }

            var review = await _context.Reviews.FirstOrDefaultAsync(r => r.ID == reviewId);

            if (review == null)
            {
                throw new KeyNotFoundException("Review not found.");
            }

            review.IsDeleted = true;

            await _context.SaveChangesAsync();
        }
        public override IQueryable<Database.Review> AddInclude(IQueryable<Database.Review> query, ReviewSearchObject? search = null)
        {
            query = query.Include(r => r.OrderItem)
                         .ThenInclude(oi => oi.Equipment)
                         .Include(r => r.OrderItem)
                         .ThenInclude(oi => oi.Order)
                         .ThenInclude(o => o.User);
            return query;
        }

        public override IQueryable<Database.Review> AddFilter(IQueryable<Database.Review> query, ReviewSearchObject? search = null)
        {
            return query.Where(r => r.IsDeleted == false);
        }
    }
}
