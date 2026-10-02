using Microsoft.EntityFrameworkCore;
using studentManagement.Models;

namespace studentManagement.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, FirstName = "Maria", LastName = "Santos", Email = "maria.santos@school.edu" },
            new Student { Id = 2, FirstName = "Juan", LastName = "Dela Cruz", Email = "juan.delacruz@school.edu" },
            new Student { Id = 3, FirstName = "Ana", LastName = "Reyes", Email = "ana.reyes@school.edu" }
        );
    }
}