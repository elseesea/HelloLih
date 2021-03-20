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

        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1> Welcome to my app, " + name + "! </ h1 > ", "text / html");
        }

        [HttpGet]
        [Route("/anyroute/goaway/{name?}")]
        public IActionResult GoAway(string name = "World")
        {
            return Content("<h1> Please go away, " + name + "! </ h1 > ", "text / html");
        }

    }
}
