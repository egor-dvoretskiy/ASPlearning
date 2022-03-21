using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial2.DAL.Interfaces;
using Tutorial2.Domain.Entity;
using Tutorial2.Domain.Interfaces;
using Tutorial2.Domain.Response;
using Tutorial2.Domain.ViewModels.Car;
using Tutorial2.Service.Interfaces;

namespace Tutorial2.Service.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;

        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public async Task<IBaseResponse<Car>> GetCar(int id)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                var car = await this.carRepository.Get(id);

                if (car == null)
                {
                    baseResponse.Description = "User not found";
                    baseResponse.StatusCode = Domain.Enum.StatusCode.UserNotFound;
                    return baseResponse;
                }

                baseResponse.Data = car;
                baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
                return baseResponse;
            }
            catch (Exception exception)
            {
                return new BaseResponse<Car>()
                {
                    Description = $"[GetCar] : {exception.Message}",
                    StatusCode = Domain.Enum.StatusCode.InternalServerError,
                };
            }
        }

        public async Task<IBaseResponse<Car>> GetCarByName(string name)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                var car = await this.carRepository.GetByName(name);

                if (car == null)
                {
                    baseResponse.Description = "User not found";
                    baseResponse.StatusCode = Domain.Enum.StatusCode.UserNotFound;
                    return baseResponse;
                }

                baseResponse.Data = car;
                baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
                return baseResponse;
            }
            catch (Exception exception)
            {
                return new BaseResponse<Car>()
                {
                    Description = $"[GetCarByName] : {exception.Message}",
                    StatusCode = Domain.Enum.StatusCode.InternalServerError,
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Car>>> GetCars()
        {
            var baseResponse = new BaseResponse<IEnumerable<Car>>();

            try
            {
                var cars = await this.carRepository.Select();

                if (cars.Count == 0)
                {
                    baseResponse.Description = "Found 0 elements.";
                    baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
                    return baseResponse;
                }

                baseResponse.Data = cars;
                baseResponse.StatusCode = Domain.Enum.StatusCode.OK;

                return baseResponse;
            }
            catch (Exception exception)
            {
                return new BaseResponse<IEnumerable<Car>>()
                {
                    Description = $"[GetCars] : {exception.Message}",
                    StatusCode = Domain.Enum.StatusCode.InternalServerError,
                };
            }
        }

        public async Task<IBaseResponse<bool>> CreateCar(CarViewModel carViewModel)
        {
            var baseResponse = new BaseResponse<bool>();

            try
            {
                var car = new Car()
                { 
                    Description = carViewModel.Description,
                    DateCreate = carViewModel.DateCreate,
                    Speed = carViewModel.Speed,
                    Model = carViewModel.Model,
                    Price = carViewModel.Price,
                    Name = carViewModel.Name,
                    TypeCar = carViewModel.TypeCar
                };


                await this.carRepository.Create(car);
                baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
                return baseResponse;
            }
            catch (Exception exception)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[CreateCar] : {exception.Message}",
                    StatusCode = Domain.Enum.StatusCode.InternalServerError,
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteCar(int id)
        {
            var baseResponse = new BaseResponse<bool>();

            try
            {
                var car = await this.carRepository.Get(id);

                if (car is null)
                {
                    baseResponse.Description = "User not found";
                    baseResponse.StatusCode = Domain.Enum.StatusCode.UserNotFound;
                    return baseResponse;
                }

                await this.carRepository.Delete(car);
                baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
                return baseResponse;
            }
            catch (Exception exception)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteCar] : {exception.Message}",
                    StatusCode = Domain.Enum.StatusCode.InternalServerError,
                };
            }
        }
    }
}
