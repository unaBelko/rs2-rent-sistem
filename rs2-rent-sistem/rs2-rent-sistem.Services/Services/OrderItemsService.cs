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

            //todo: return only not completed reservations

            if (search?.UserId != null)
            {
                query = query.Where(oi => oi.Order.UserID == search.UserId).OrderByDescending(oi => oi.Order.DatePlaced);
            }
            return query;
        }
    }
}
