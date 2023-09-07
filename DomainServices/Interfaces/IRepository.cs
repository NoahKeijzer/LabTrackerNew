namespace DomainServices.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Get(Guid id);
        void Update(T model);
        void Create(T model);
        void Delete(T model);
    }
}