using AutoMapper;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Database;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class ManufacturerService : CRUDService<Model.Models.Manufacturer, Manufacturer, ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>, IManufacturerService
    {
        public ManufacturerService(RentSistemDbContext context, IMapper mapper) : base(context, mapper) { }

        public override IQueryable<Manufacturer> AddFilter(IQueryable<Manufacturer> query, ManufacturerSearchObject? search = null)
        {
            query = query.Where(m => !m.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search?.ManufacturerName))
            {
                query = query.Where(m => m.Name.Contains(search.ManufacturerName));
            }

            return base.AddFilter(query, search);
        }
    }
}
