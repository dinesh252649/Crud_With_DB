using Microsoft.AspNetCore.Mvc;

namespace CRUD_With_DB.UI.Controllers
{
    public class ContryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
