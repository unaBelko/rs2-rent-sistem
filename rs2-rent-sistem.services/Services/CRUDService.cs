using AutoMapper;
using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Services.Data;
using System.Security.Cryptography;
using System.Text;

namespace rs2_rent_sistem.Services.Services
{
    public class CRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseService<T, TDb, TSearch> where TDb : class where T : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {

        public CRUDService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public virtual async Task BeforeInsert(TDb db, TInsert insert)
        {

        }

        public virtual async Task BeforeUpdate(TDb db, TUpdate update)
        {

        }

        public virtual async Task<T> Insert(TInsert insert)
        {
            var set = _context.Set<TDb>();

            TDb entity = _mapper.Map<TDb>(insert);

            set.Add(entity);
            await BeforeInsert(entity, insert);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }

        public virtual async Task<T> Update(int id, TUpdate update)
        {
            var set = _context.Set<TDb>();

            var entity = await set.FindAsync(id);

            await BeforeUpdate(entity, update);

            _mapper.Map(update, entity);

            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }
        public static string GenerateSalt()
        {
            int saltSize = 16;

            byte[] saltBytes = new byte[saltSize];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            return Convert.ToBase64String(saltBytes);
        }

        public static string GenerateHash(string salt, string password)
        {
            string saltedPassword = salt + password;

            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                // Convert the hash byte array to a base64 string
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
