using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class AppDbContext: DbContext
{
    public DbSet<Student> Studenten { get; set; }
    public DbSet<StudentOpdrachtVoortgang> StudentOpdrachtVoortgangen { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentOpdrachtVoortgang>().HasKey(l => new { l.StudentId, l.OpdrachtId });
        modelBuilder.Entity<StudentOpdrachtVoortgang>().ToTable("StudentOpdrachtVoortgang");
        modelBuilder.Entity<Student>().ToTable("Studenten");
        base.OnModelCreating(modelBuilder);
    }
}