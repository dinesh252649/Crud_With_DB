using CRUD_With_DB.Entity;
using CRUD_With_DB.Repository.Interfaces;

namespace CRUD_With_DB.Repository.Implimentations
{
    public class StateRepo : IStateRepo
    {
        private readonly ApplicationDBContext _dbContext;
        public StateRepo(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Edit(State states)
        {
            _dbContext.State.Add(states);
            _dbContext.SaveChanges();
        }

        public IEnumerable<State> GetAll()
        {
            var resul = _dbContext.State.ToList();
            return resul;
        }

        public State GetById(int id)
        {
            var result = _dbContext.State.Find(id);
            return result;
        }

        public void Remove(State states)
        {
            _dbContext.Remove(states);
            _dbContext.SaveChanges();
        }

        public void Save(State states)
        {
            _dbContext.Update(states);
            _dbContext.SaveChanges();
        }
    }
}
