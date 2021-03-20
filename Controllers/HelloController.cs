using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLih.Controllers
{
    public class HelloController : Controller
    {

        // GET: /<controller>/
        // Example from Ch. 10.3.2
        [HttpGet]
        [Route("/helloworld")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
               "<input type='text' name='name' />" +
               "<input type='submit' value='Greet Me!' />" +
               "</form>";

            return Content(html, "text/html");
        }
        
        // Example from Ch. 10.3.2
        [HttpPost]
        [Route("/helloworld")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1> Welcome to my app, " + name + "! </ h1 > ", "text / html");
        }

        // Personal variation of example from Ch. 10.2
        [HttpGet]
        [Route("/anyroute/goaway/{name?}")]
        public IActionResult GoAway(string name = "World")
        {
            return Content("<h1> Please go away, " + name + "! </ h1 > ", "text / html");
        }

    } // class
} // namespace
