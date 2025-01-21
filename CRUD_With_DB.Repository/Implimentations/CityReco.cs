using CRUD_With_DB.Entity;
using CRUD_With_DB.Repository.Interfaces;

namespace CRUD_With_DB.Repository.Implimentations
{
    public class CityReco:ICity
    {
        private readonly ApplicationDBContext _dbContext;
        public CityReco(ApplicationDBContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void Edit(City city)
        {
            _dbContext.Citys.Add(city);
            _dbContext.SaveChanges();
        }

        public void Edit(Countary countary)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            //var resul = _dbContext.Citys.ToList();
            var resul=_dbContext.Citys.ToList();
            return resul;
        }

        public City GetById(int id)
        {
            var result = _dbContext.Citys.Find(id);
            return result;
        }

        public void Remove(City city)
        {
            _dbContext.Citys.Remove(city);
            _dbContext.SaveChanges();
        }

        public void Remove(Countary countary)
        {
            throw new NotImplementedException();
        }

        public void Save(City city)
        {
            _dbContext.Citys.Update(city);
            _dbContext.SaveChanges();
        }
    }
}
