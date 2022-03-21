using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tutorial2.DAL.Interfaces;
using Tutorial2.Domain.Entity;
using Tutorial2.Service.Interfaces;

namespace Tutorial2.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarsAsync()
        {
            var response = await this._carService.GetCars();

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error");
        }
    }
}
