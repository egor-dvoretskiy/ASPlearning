using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tutorial2.Models;
using Tutorial2.Domain.Entity;

namespace tutorial2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Car car = new Car()
            {
                Name = "Honda",
                Model = "Civic",
                Speed = 220,
                Price = 17500,
                Description = "Just a good car.",
                DateCreate = new DateTime(2017, 9, 24),
                TypeCar = Tutorial2.Domain.Enum.TypeCar.Hatchback
            };

            return View(car);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
