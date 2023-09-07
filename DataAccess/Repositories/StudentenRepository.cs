using DataAccess.Context;
using Domain;
using Domain.Models;
using DomainServices.Interfaces;

namespace DataAccess.Repositories;

public class StudentenRepository: IRepository<Student>
{
    private readonly AppDbContext _dbContext;
    public StudentenRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<Student> GetAll()
    {
        return _dbContext.Studenten.ToList();
    }

    public Student Get(Guid id)
    {
       return _dbContext.Studenten.Find(id)!;
    }

    public void Update(Student model)
    {
        _dbContext.Studenten.Update(model);
        _dbContext.SaveChanges();
    }

    public void Create(Student model)
    {
        _dbContext.Studenten.Add(model);
        _dbContext.SaveChanges();
    }

    public void Delete(Student model)
    {
        _dbContext.Studenten.Remove(model);
        _dbContext.SaveChanges();
    }
}