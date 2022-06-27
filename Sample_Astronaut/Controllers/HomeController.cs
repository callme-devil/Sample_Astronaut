using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sample_Astronaut.Models;

namespace Sample_Astronaut.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var Model = new ContactViewModel();
            return View();
        }

        [HttpPost]
        public JsonResult Contact(ContactViewModel model)
        {
            return Json(Ok());
        }

        public IActionResult Works()
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
