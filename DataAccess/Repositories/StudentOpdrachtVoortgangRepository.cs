using DataAccess.Context;
using Domain;
using Domain.Models;
using DomainServices.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class StudentOpdrachtVoortgangRepository: IRepository<StudentOpdrachtVoortgang>
{
    private readonly AppDbContext _context;
    
    public StudentOpdrachtVoortgangRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<StudentOpdrachtVoortgang> GetAll()
    {
        return _context.StudentOpdrachtVoortgangen.ToList();
    }

    public StudentOpdrachtVoortgang Get(Guid id)
    {
        return _context.StudentOpdrachtVoortgangen.Include(s => s.Student).FirstOrDefault(sov => sov.Student.StudentId == id)!;
    }

    public void Update(StudentOpdrachtVoortgang model)
    {
        _context.StudentOpdrachtVoortgangen.Update(model);
        _context.SaveChanges();
    }

    public void Create(StudentOpdrachtVoortgang model)
    {
        _context.StudentOpdrachtVoortgangen.Add(model);
        _context.SaveChanges();
    }

    public void Delete(StudentOpdrachtVoortgang model)
    {
        _context.StudentOpdrachtVoortgangen.Remove(model);
        _context.SaveChanges();
    }
}