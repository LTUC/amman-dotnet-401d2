using AuthMVCDemo.Models.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthMVCDemo.data
{
    public class AuthDBContext : IdentityDbContext<AuthUser>
    {
        public AuthDBContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "admin", Name = "Admin" },
                new IdentityRole { Id = "guest", Name = "Guest" }
                );
        }
    }
}
