using CMSDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSDemo.Data
{
    public class BlogDbContext :DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        // Code First migration of setting our Post model to a Post table within this database
        public DbSet<Post> Posts { get; set; }
    }
}
