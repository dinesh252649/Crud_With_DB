using CRUD_With_DB.Data;
using CRUD_With_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_With_DB.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public PeopleController(ApplicationDBContext dbContext)
        {
                this._dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var result=_dbContext.Peoples.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(People people)
        {
            _dbContext.Peoples.Add(people);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var people=_dbContext.Peoples.Find(id);
            return View(people);
        }
        [HttpPost]
        public IActionResult Edit(People peoples) {
            _dbContext.Peoples.Update(peoples);
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(People peoples) {
            _dbContext.Peoples.Remove(peoples);
            _dbContext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
