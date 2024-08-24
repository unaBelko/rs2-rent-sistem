using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace rs2_rent_sistem.Services.Services
{
    public class UserService : CRUDService<User, Database.User, UserSearchObject, UserUpsertObject, UserUpsertObject>, IUsersService
    {
        public UserService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<User> Insert(UserUpsertObject insert)
        {
            return await base.Insert(insert);
        }

        public override async Task BeforeInsert(Database.User entity, UserUpsertObject request)
        {
            entity.Salt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.Salt, request.Password);

            var endUserRole = await _context.Roles.FirstOrDefaultAsync(role => role.Name == "end-user");

            if (endUserRole != null)
            {
                entity.Roles.Add(endUserRole);
            }
            else
            {
                throw new Exception("End-user role not found.");
            }
        }


        public override async Task<User> Update(int id, UserUpsertObject update)
        {
            return await base.Update(id, update);
        }

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject? search = null)
        {
            query = query.Include(user => user.Roles);

            return base.AddInclude(query, search);
        }

        public async Task<User> Login(string email, string password)
        {
            var entity = await _context.Users
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(x => x.Email == email);

            if (entity == null)
                return null;

            var hash = GenerateHash(entity.Salt, password);

            if (hash != entity.PasswordHash)
            {
                return null;
            }

            return _mapper.Map<User>(entity);
        }


        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        private string GenerateHash(string salt, string password)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] combinedBytes = new byte[saltBytes.Length + passwordBytes.Length];
            Buffer.BlockCopy(saltBytes, 0, combinedBytes, 0, saltBytes.Length);
            Buffer.BlockCopy(passwordBytes, 0, combinedBytes, saltBytes.Length, passwordBytes.Length);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
