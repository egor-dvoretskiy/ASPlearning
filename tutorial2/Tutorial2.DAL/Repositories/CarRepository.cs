using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial2.DAL.Interfaces;
using Tutorial2.Domain.Entity;

namespace Tutorial2.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<bool> Create(Car entity)
        {
            await this._context.Car.AddAsync(entity);
            await this._context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(Car entity)
        {
            this._context.Car.Remove(entity);
            await this._context.SaveChangesAsync();

            return true;
        }

        public async Task<Car> Get(int id)
        {
            return await this._context.Car.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Car> GetByName(string name)
        {
            return await this._context.Car.FirstOrDefaultAsync(x => x.Name == name);
        }

        public Task<List<Car>> Select()
        {
            return this._context.Car.ToListAsync();
        }

        public async Task<Car> Update(Car entity)
        {
            this._context.Car.Update(entity);
            await this._context.SaveChangesAsync();

            return entity;
        }
    }
}
