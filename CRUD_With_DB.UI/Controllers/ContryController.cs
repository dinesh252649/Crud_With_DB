using CRUD_With_DB.Entity;
using CRUD_With_DB.Repository.Implimentations;
using CRUD_With_DB.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_With_DB.UI.Controllers
{
    public class ContryController : Controller
    {
        //private readonly ICity _cityReco;
        private readonly IContryRepo _contryRepo;
        public ContryController(IContryRepo contryRepo)
        {
            _contryRepo = contryRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var city = _contryRepo.GetAll();
            //var city = _contryRepo.GetAll();
            return View(city);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Countary city)
        {
            _contryRepo.Save(city);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _contryRepo.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Countary city) {

            _contryRepo.Save(city);            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var city= _contryRepo.GetById(id);
          //  _cityReco.Remove(city);
            return RedirectToAction("Index");
        }
    }
}
