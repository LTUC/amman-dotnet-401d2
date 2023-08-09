using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class SchoolAPIDbContext : IdentityDbContext<ApplicationUser>
    {
        public SchoolAPIDbContext(DbContextOptions options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Technology>().HasData(
              new Technology { Id = 1, Name = "Javascript" },
              new Technology { Id = 2, Name = "Python" },
              new Technology { Id = 3, Name = "C#" },
              new Technology { Id = 4, Name = "Java" }
            );


            SeedRole(modelBuilder, "Admin" , "create", "update", "delete");
            SeedRole(modelBuilder, "User" ,"create", "update");

            modelBuilder.Entity<Enrollment>().HasKey(
                enrollment => new { enrollment.StudentId, 
                    enrollment.CourseId }
                );

        }
        int nextId = 1;
        private void SeedRole(ModelBuilder modelBuilder, string roleName, params string[] permissions)
        {
            var role = new IdentityRole
            {
                Id = roleName.ToLower(),
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()
            };

            modelBuilder.Entity<IdentityRole>().HasData(role);

            // Go through the permissions list (the params) and seed a new entry for each
            var roleClaims = permissions.Select(permission =>
              new IdentityRoleClaim<string>
              {
                  Id = nextId++,
                  RoleId = role.Id,
                  ClaimType = "permissions", // This matches what we did in Program.cs
                  ClaimValue = permission
              }).ToArray();

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(roleClaims);
        }

       public DbSet<Student> Students { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Transcript> Transcripts { get; set; }
    }
}
