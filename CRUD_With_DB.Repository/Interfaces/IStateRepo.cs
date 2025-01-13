using CRUD_With_DB.Entity;

namespace CRUD_With_DB.Repository.Interfaces
{
    public interface IStateRepo
    {
        IEnumerable<State> GetAll();
        State GetById(int id);
        void Save(State states);
        void Edit(State states);
        void Remove(State states);
    }
}
