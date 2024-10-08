using Code_First_Relation.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Code_First_Relation.Contexts
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options)
        : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Post>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);
        }
    }
}
