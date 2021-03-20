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
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" + 
                "<input type='text' name='name' id='name'" +
                "<label for='language'></label>" +
                "<select name = 'language' id = 'language'>" +
                "<option value = 'English'>English</option>" +
                "<option value = 'German'>German</option>" +
                "<option value = 'Italian'>Italian</option>" +
                "<option value = 'Spanish'>Spanish</option>" +
                "<option value = 'French'>French</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World", string language = "English")
        {
            string selectedLanguage = language;
            string greeting = CreateMessage(name, language);
            return Content("<h1>" + greeting + "</h1>", "text / html");
        }

        public static string CreateMessage(string name, string language)
        {
            string languageGreeting = "Hello";

            if (language.Equals("French"))
            {
                languageGreeting = "Bonjour";
            }
            else if (language.Equals("Spanish"))
            {
                languageGreeting = "Hola";
            }
            else if (language.Equals("Italian"))
            {
                languageGreeting = "Ciao";
            }
            else if (language.Equals("German"))
            {
                languageGreeting = "Hallo";
            }
            else
            {
                languageGreeting = "Hello";
            }

            return languageGreeting + " " + name;
        }

    } // class
} // namespace
