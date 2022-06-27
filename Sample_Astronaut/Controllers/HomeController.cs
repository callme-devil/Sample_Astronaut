using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_Astronaut.Models;

namespace Sample_Astronaut.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<ContactorsViewModel> _contactors = new List<ContactorsViewModel>
        {
            new ContactorsViewModel(1 , "Ali"),
            new ContactorsViewModel(2 , "Milad"),
            new ContactorsViewModel(3 , "Reza")
    };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactViewModel()
            {
                Contactors = new SelectList(_contactors, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            model.Contactors = new SelectList(_contactors, "Id", "Name");

            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمیباشد , لطفا دوباره تلاش کنید";
                return View(model);
            }

            ModelState.Clear();
            model = new ContactViewModel
            {
                Contactors = new SelectList(_contactors, "Id", "Name")
            };
            ViewBag.Success = "پیغام شما با موفقیت ارسال شد باتشکر";
            return View(model);
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
