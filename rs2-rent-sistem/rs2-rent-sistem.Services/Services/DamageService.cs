using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;
using Damage = rs2_rent_sistem.Model.Models.Damage;

namespace rs2_rent_sistem.Services.Services
{
    public class DamageService : BaseService<Damage, Database.Damage, DamageSearchObject>, IDamageService
    {
        private readonly IOrderItemsService orderItemsService;
        public DamageService(RentSistemDbContext context, IMapper mapper, IOrderItemsService orderItemsService) : base(context, mapper)
        {
            this.orderItemsService = orderItemsService;
        }

        public override async Task<PageResult<Damage>> Get(DamageSearchObject? search = null)
        {
            var user = await _context.Users
                 .Include(u => u.UserRoles)
                 .ThenInclude(r => r.Role)
                 .FirstOrDefaultAsync(u => u.ID == search.UserID);
            if (user == null) {
                return new PageResult<Damage>();
            }

            var userIsEmployee = user.UserRoles.Any(ur => ur.Role.Name == "employee");
            IQueryable<Database.Damage> query = _context.Set<Database.Damage>().AsQueryable();

            if (userIsEmployee) {
                query = query.Include(d => d.OrderItem);
                if(search.EquipmentID != null)
                {
                    query = query.Where(d => d.OrderItem.EquipmentID == search.EquipmentID);
                }
            }

            PageResult<Damage> result = new();

            query = AddFilter(query, search);
            query = AddInclude(query, search);

            result.Count = await query.CountAsync();

            if (search.Page.HasValue && search.PageSize.HasValue)
            {
                query = query.Skip(search.Page.Value * search.PageSize.Value)
                             .Take(search.PageSize.Value);
            }

            var list = await query.ToListAsync();
            var tmp = _mapper.Map<List<Damage>>(list);
            result.Result = tmp;

            return result;
        }

        public async Task<Damage> ReportDamage(DamageInsertModel damage) {

            var orderItem = await _context.OrderItems
            .Include(oi => oi.Order)
                .FirstOrDefaultAsync(oi => oi.ID == damage.OrderItemID) ?? throw new ArgumentException("Order item not found.");
            if (orderItem.Order.Status.ToLower() != "returned" || orderItem.HasDamageReportedByUser)
            {
                throw new InvalidOperationException("Nije moguce prijaviti ostecenje!");
            }
            var newDamage = new Database.Damage()
            {
                DateAdded = DateTime.Now,
                Comment = damage.Comment,
                OrderItemID = orderItem.ID,
            };
            _context.Damages.Add(newDamage);
            await _context.SaveChangesAsync();

            await orderItemsService.MarkOrderItemAsDamaged(damage.OrderItemID);

            return _mapper.Map<Damage>(newDamage);
        }
    }
}
