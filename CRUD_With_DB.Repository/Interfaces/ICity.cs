using CRUD_With_DB.Entity;

namespace CRUD_With_DB.Repository.Interfaces
{
    public interface ICity
    {
        IEnumerable<City> GetAll();
        City GetById(int id);
        void Save(City citys);
        void Edit(Countary countary);
        void Remove(Countary countary);
    }
}
