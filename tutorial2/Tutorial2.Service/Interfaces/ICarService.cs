using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial2.Domain.Entity;
using Tutorial2.Domain.Interfaces;
using Tutorial2.Domain.Response;

namespace Tutorial2.Service.Interfaces
{
    public interface ICarService
    {
        Task<IBaseResponse<IEnumerable<Car>>> GetCars();
    }
}
