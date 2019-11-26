using Microsoft.AspNetCore.Mvc;

namespace Lecture.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hey how are ya?";
        }
        [HttpGet]
        [Route("hey")]
        public string Check()
        {
            return "Im am good ";
        }
        [HttpGet("user/{name}/{location}/{fav_stack}")]
        public string somethingcool(string name, string location, string fav_stack)
        {
            return $"{name}'s favorite stack is {fav_stack} and is studying in {location}";
        }

        [HttpGet("Count")] // not case sensitive
        public ViewResult Show()
        {
            return View("Show");
        }
        [HttpGet("Nothere")]
        public RedirectToActionResult cake()
        {
            return RedirectToAction("Check");
        }

    }
}