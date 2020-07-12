using System;
using HealthySnacks.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthySnacks.Controllers
{
    public class HealthySnacksController : Controller 
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHealthySnacksRepository _healthySnacksRepository;


        public HealthySnacksController(ICategoryRepository categoryRepository, IHealthySnacksRepository healthySnacksRepository)
        {
            _categoryRepository = categoryRepository;
            _healthySnacksRepository = healthySnacksRepository;

        }

        public IActionResult Index() //same name of action Index, same name as a View Index in view folder
        {
            var healthySnacks = _healthySnacksRepository.healthySnacks;

            return View(healthySnacks);
        }
    }
}
