using Microsoft.AspNetCore.Mvc;

namespace Aromata1.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Home()
        {
            string name = "Omar Abdelkader Mohamed";
            int age = 28;
            double salary = 10000.5;

            var person = new { name, age, salary };

            return View(model: person);
        }
    }
}
