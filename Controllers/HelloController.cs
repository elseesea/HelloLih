using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLih.Controllers
{
    // The following Route attribute designates that all methods in this class will respond at /helloworld.
    // See Ch. 10.4.2.1
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        // GET: /<controller>/
        // Removed method Route attribute. See Ch. 10.4.2.1
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" +
               "<input type='text' name='name' />" +
               "<input type='submit' value='Greet Me!' />" +
               "</form>";

            return Content(html, "text/html");
        }

        // 1. Added ability to respond to Get requests. See Ch. 10.4.2.2
        // 2. Combined Request attribute and Route attribute for both Get & Post requests. See Ch. 10.4.2.2
        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
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
