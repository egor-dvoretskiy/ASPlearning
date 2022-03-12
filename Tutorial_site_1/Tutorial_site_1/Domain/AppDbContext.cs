using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tutorial_site_1.Domain.Entities;

namespace Tutorial_site_1.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "dea27ec6-06d5-40a7-92a5-9f24c1ecf084",
                Name = "admin",
                NormalizedName = "ADMIN",
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "58ed892f-172c-4fcd-9c51-2ced5409528b",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@ec.com",
                NormalizedEmail = "MY@EC.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "dea27ec6-06d5-40a7-92a5-9f24c1ecf084",
                UserId = "58ed892f-172c-4fcd-9c51-2ced5409528b"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("8b37312e-1083-4104-a581-4160a94dfebe"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("e041631b-6f4b-425a-8f5d-05bff12909a6"),
                CodeWord = "PageServices",
                Title = "Our services"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("f6d016e6-b593-483c-a7c2-d2499c36a695"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
        }
    }
}
