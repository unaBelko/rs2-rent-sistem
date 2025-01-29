using AutoMapper;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;

namespace rs2_rent_sistem.Services.Services
{
    public class CRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseService<T, TDb, TSearch>
        where TDb : class
        where T : class
        where TSearch : BaseSearchObject
        where TInsert : class
        where TUpdate : class
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
            if (entity == null)
                throw new KeyNotFoundException($"Entity with ID {id} not found.");

            await BeforeUpdate(entity, update);

            _mapper.Map(update, entity);

            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }

        public virtual async Task<bool> Delete(int id)
        {
            var set = _context.Set<TDb>();

            var entity = await set.FindAsync(id);
            if (entity == null)
                throw new KeyNotFoundException($"Entity with ID {id} not found.");

            var isDeletedProperty = typeof(TDb).GetProperty("IsDeleted");
            if (isDeletedProperty == null)
                throw new InvalidOperationException("Entity does not have an IsDeleted property.");

            isDeletedProperty.SetValue(entity, true);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
