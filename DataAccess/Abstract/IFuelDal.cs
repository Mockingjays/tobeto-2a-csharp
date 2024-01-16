using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IFuelDal : IEntityRepository<Fuel, int>
{
    // CRUD - Create, Read, Update, Delete

    // IEntityRepository<Fuel, int> kalıtımının örnek canlandırması:
    //public void Add(Fuel entity);
    //public void Delete(Fuel entity);
    //public Fuel? GetById(int id);
    //public IList<Fuel> GetList();
    //public void Update(Fuel entity);
    //

    //public IList<Fuel> GetFuelsByNameSearch(string nameSearch);
}
