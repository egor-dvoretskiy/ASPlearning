using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial2.Domain.Entity;
using Tutorial2.Domain.Interfaces;
using Tutorial2.Domain.Response;
using Tutorial2.Domain.ViewModels.Car;

namespace Tutorial2.Service.Interfaces
{
    public interface ICarService
    {
        Task<IBaseResponse<IEnumerable<Car>>> GetCars();

        Task<IBaseResponse<Car>> GetCar(int id);

        Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);

        Task<IBaseResponse<bool>> DeleteCar(int id);

        Task<IBaseResponse<Car>> GetCarByName(string name);

        Task<IBaseResponse<Car>> Edit(int id, CarViewModel model);
    }
}
