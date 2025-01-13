using CRUD_With_DB.Entity;
using CRUD_With_DB.Repository.Interfaces;

namespace CRUD_With_DB.Repository.Implimentations
{
    public class CountryRepo : IContryRepo
    {
        private readonly ApplicationDBContext _dbContext;
        public CountryRepo(ApplicationDBContext dbContext)
        {
            this._dbContext = dbContext;

        }
        public void Edit(Countary countary)
        {
            _dbContext.Update(countary);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Countary> GetAll()
        {
            var result = _dbContext.Countaries.ToList();
            return result;
        }

        public Countary GetById(int id)
        {
            var result = _dbContext.Countaries.Find(id);
            return result;
        }

        public void Remove(Countary countary)
        {
            throw new NotImplementedException();
        }

        public void Save(Countary countary)
        {
            throw new NotImplementedException();
        }
    }


}
