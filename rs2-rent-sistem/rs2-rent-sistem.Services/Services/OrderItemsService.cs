using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class OrderItemsService : BaseService<OrderItem, Database.OrderItem, OrderItemSearchObject>, IOrderItemsService
    {
        public OrderItemsService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override IQueryable<Database.OrderItem> AddFilter(IQueryable<Database.OrderItem> query, OrderItemSearchObject? search = null)
        {
            query = base.AddFilter(query, search);

            query = query.Include(oi => oi.Order)
                .Include(oi => oi.Equipment);

            if (search.ReturnOnlyActiveReservations)
            {
                query = query.Where(oi => oi.Order.Status != "returned");
            }

            if (search.OrderId != null && search.UserId != null)
            {
                query = query.Where(oi => oi.OrderID == search.OrderId && oi.Order.UserID == search.UserId);
            }
            else if (search.OrderId != null)
            {
                query = query.Where(oi => oi.OrderID == search.OrderId);
            }
            else if (search.UserId != null)
            {
                query = query.Where(oi => oi.Order.UserID == search.UserId);
            }

            query = query.OrderByDescending(oi => oi.Order.DatePlaced);
            return query;
        }

        public async Task MarkOrderItemAsReviewed(int orderItemId)
        {
            var orderItem = _context.OrderItems.Where(oi => oi.ID == orderItemId).FirstOrDefault();
            if (orderItem != null) {
                orderItem.IsReviewedByUser = true;
            }
            await _context.SaveChangesAsync();
        }
    }
}
