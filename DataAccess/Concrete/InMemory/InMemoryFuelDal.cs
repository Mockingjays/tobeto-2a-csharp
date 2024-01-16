using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryFuelDal : InMemoryEntityRepositoryBase<Fuel, int>, IFuelDal
{
    protected override int generateId()
    {
        int nextId = _entities.Count == 0 
            ? 1 
            : _entities.Max(e => e.Id) + 1;
        return nextId;
    }

    // InMemoryEntityRepositoryBase<Fuel, int> kalıtımın örnek uygulaması:
    //private readonly HashSet<Fuel> _entities = new();
    //public void Add(Fuel entity)
    //{
    //    entity.CreatedAt = DateTime.UtcNow;
    //    _entities.Add(entity);
    //}
    //public void Delete(Fuel entity)
    //{
    //    entity.DeletedAt = DateTime.UtcNow;
    //}
    //public Fuel? GetById(int id)
    //{
    //    Fuel? entity = _entities.FirstOrDefault(
    //        e => e.Id.Equals(id) && e.DeletedAt.HasValue == false
    //    );
    //    return entity;
    //}
    //public IList<Fuel> GetList()
    //{
    //    IList<Fuel> entities = _entities.Where(e => e.DeletedAt.HasValue == false).ToList();
    //    return entities;
    //}
    //public void Update(Fuel entity)
    //{
    //    entity.UpdateAt = DateTime.UtcNow;
    //}

    //public IList<Fuel> GetFuelsByNameSearch(string nameSearch)
    //{
    //    throw new NotImplementedException();
    //}
}
