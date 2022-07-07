using Microsoft.AspNetCore.Mvc;
using Sample_Astronaut.Data;

namespace Sample_Astronaut.ViewComponents
{
    public class WorksViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Works = WorksStore.GetWorks();
            return View("_Works" , Works);
        }
    }
}
