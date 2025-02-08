using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IDamageService : IService<Damage, DamageSearchObject>
    {
        Task<Damage> ReportDamage(DamageInsertModel damage);
    }
}
