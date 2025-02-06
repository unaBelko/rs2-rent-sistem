namespace rs2_rent_sistem.Services.Interfaces
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch> where TSearch : class
    {
        Task<bool> Delete(int id);
        Task<T> Insert(TInsert insert);
        Task<T> Update(int id, TUpdate update);
    }
}
