using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tutorial2.DAL.Interfaces;
using Tutorial2.Domain.Entity;

namespace Tutorial2.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            this._carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarsAsync()
        {
            var response = await _carRepository.Select();
            var response1 = await this._carRepository.GetByName("");

            Car car = new Car()
            {
                Name = "Honda",
                Model = "Civic",
                Description = "Amazing car",
                DateCreate = new System.DateTime(2017, 08, 22),
                Price = 17000,
                Speed = 220,
                TypeCar = Domain.Enum.TypeCar.Hatchback
            };
            await this._carRepository.Create(car);
            await this._carRepository.Delete(car);

            return View(response);
        }
    }
}
