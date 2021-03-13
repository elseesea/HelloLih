using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLih.Controllers
{
    public class HelloController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<h1>" + "Hello Lih!" + "<h1>";
            return Content(html, "text/html");
        }
    }
}
