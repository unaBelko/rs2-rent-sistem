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
    }
}
