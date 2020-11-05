using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Title = "Kinh Tế" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Title = "Văn Hóa" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Title = "Lịch Sử" });

            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 1, Title = "CR7" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 2, Title = "Messi" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 3, Title = "Tin Hot" });

            modelBuilder.Entity<PostTag>().HasKey(posttag => new { posttag.PostId, posttag.TagId });
        }
    }
}
