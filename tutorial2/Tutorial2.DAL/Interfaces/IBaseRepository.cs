using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tutorial2.Domain.Entity;

namespace Tutorial2.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<T> Get(int id);

        Task<List<T>> Select();

        Task<bool> Create(Car entity);

        Task<bool> Delete(Car entity);
    }
}
