using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IUsersService : ICRUDService<Model.Models.User, UserSearchObject, UserUpsertObject, UserUpsertObject>
    {
        public Task<String> Login(string email, string password);
    }
}
