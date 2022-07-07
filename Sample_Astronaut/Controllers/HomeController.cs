using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_Astronaut.Data;
using Sample_Astronaut.Models;

namespace Sample_Astronaut.Controllers
{
    //? Attribute Based Route (Primary)
    //[Route("/Inventory/Packages/")]
    // localhost:4001/Inventory/Packages/Index
    public class HomeController : Controller
    {
        private readonly List<ContactorsViewModel> _contactors = new List<ContactorsViewModel>
        {
            new ContactorsViewModel(1 , "Ali"),
            new ContactorsViewModel(2 , "Milad"),
            new ContactorsViewModel(3 , "Reza")
        };

        //[Route("MyIndex")]
        //localhost:4001/Inventory/Packages/MyIndex
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(/*"ContactPage/{id:int}/{name:}"*/)]
        //localhost:4001/Inventory/Packages/ContactPage/2/milad
        public IActionResult Contact(int id , string name)
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

        public IActionResult WorksDetails(long id)
        {
            var work = WorksStore.GEtProjectBy(id);
            return View(work);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
