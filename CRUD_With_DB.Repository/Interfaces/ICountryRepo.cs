using CRUD_With_DB.Entity;

namespace CRUD_With_DB.Repository.Interfaces
{
    public interface IContryRepo
    {
        IEnumerable<Countary> GetAll();
        Countary GetById(int id);
        void Save(Countary countary);
        void Edit(Countary countary);
        void Remove(Countary countary);

    }
}
