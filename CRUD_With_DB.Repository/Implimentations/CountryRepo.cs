using System.Diagnostics.Metrics;
using CRUD_With_DB.Entity;
using CRUD_With_DB.Repository.Interfaces;

namespace CRUD_With_DB.Repository.Implimentations
{
    public class CountryRepo : IContryRepo
    {
        private readonly ApplicationDBContext _dbContext;
        public CountryRepo(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void Edit(Countary countary)
        {
            _dbContext.Update(countary);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Countary> GetAll()
        {
            //Countarys
            //var result = _dbContext.Countaries.ToList();
            var result = _dbContext.Countarys.ToList();
           // var result = _dbContext.Citys.ToList();

            
            //entity.ToTable("tDataLoad", "log");
            return result;
        }

        public Countary GetById(int id)
        {
            //var result = _dbContext.Countaries.Find(id);
            var result = _dbContext.Countarys.Find(id);
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
