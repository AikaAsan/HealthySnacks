using System;
using Microsoft.AspNetCore.Mvc;

namespace HealthySnacks.Controllers
{
    public class HealthySnacksController : Controller 
    {
        public IActionResult Index ()
        {
            return View();
        }


        public HealthySnacksController()
        {

        }
    }
}
