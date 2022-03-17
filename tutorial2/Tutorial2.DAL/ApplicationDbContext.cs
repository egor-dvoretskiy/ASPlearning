using Microsoft.EntityFrameworkCore;
using System;
using Tutorial2.Domain.Entity;

namespace Tutorial2.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }
    }
}
