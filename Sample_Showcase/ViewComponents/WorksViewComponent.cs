using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample_Astronaut.Models;

namespace Sample_Astronaut.ViewComponents
{
    public class WorksViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           var Works = new List<WorksViewModel>
           {
               new WorksViewModel(1 , "Lorem Ipsum" , "Nulla facilisi. Vivamus vestibulum, elit in scelerisque ultricies." , "work01-hover.jpg"),
               new WorksViewModel(2 , "Lorem Ipsum" , "Nulla facilisi. Vivamus vestibulum, elit in scelerisque ultricies." , "work02-hover.jpg"),
               new WorksViewModel(3 , "Lorem Ipsum" , "Nulla facilisi. Vivamus vestibulum, elit in scelerisque ultricies." , "work03-hover.jpg"),
           };
            return View("_Works" , Works);
        }
    }
}
