using System.Diagnostics;
using CRUD_With_DB.Data;
using CRUD_With_DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_With_DB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _dbcontext;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext dbcontext)
        {
            _logger = logger;
            this._dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var result = _dbcontext.Peoples.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
