using AutoMapper;
using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Database;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class ManufacturerService : CRUDService<Models.Models.Manufacturer, Manufacturer, ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>, IManufacturerService
    {
        public ManufacturerService(RentSistemDbContext context, IMapper mapper) : base(context, mapper) { }
    }
}
