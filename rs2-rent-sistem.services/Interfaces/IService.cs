using rs2_rent_sistem.Models;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IService<T, TSearch> where TSearch : class
    {
        Task<PageResult<T>> Get(TSearch search = null);
        Task<T> GetById(int id);
    }
}
