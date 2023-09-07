using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class AppDbContext: DbContext
{
    public DbSet<Student> Studenten { get; set; }
    public DbSet<StudentOpdrachtVoortgang> StudentOpdrachtVoortgangen { get; set; }
    public DbSet<Opdracht> Opdrachten { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentOpdrachtVoortgang>()
            .HasKey(l => new { l.StudentId, l.OpdrachtId });
        
        modelBuilder.Entity<StudentOpdrachtVoortgang>()
            .HasOne(s => s.Opdracht)
            .WithMany(o => o.StudentOpdrachtVoortgangen)
            .HasForeignKey(k => k.OpdrachtId);
        
        modelBuilder.Entity<StudentOpdrachtVoortgang>()
            .HasOne(s => s.Student)
            .WithMany(s => s.StudentOpdrachtVoortgangen)
            .HasForeignKey(k => k.StudentId);
            
        base.OnModelCreating(modelBuilder);
    }
}