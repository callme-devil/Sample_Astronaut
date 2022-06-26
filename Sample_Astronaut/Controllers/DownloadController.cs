using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Sample_Astronaut.Controllers
{
    public class DownloadController : Controller
    {
        public FileResult Index()
        {
            var fileByte = System.IO.File.ReadAllBytes("wwwroot/ClickMe.txt");
            const string fileName = "ClickMe.txt"; //?can change Final file name
            return File(fileByte, MediaTypeNames.Text.Plain, fileName); //! .Application.zip & .Application.Pdf 
        }

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert(test)"); //
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Works", "Home");
        //}
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //! can use like something done some javascript code goes run Note: (configure needed in _Layout)
    //}
}
