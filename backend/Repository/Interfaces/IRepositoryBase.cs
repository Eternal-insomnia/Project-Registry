using ConsentCode.DTOs;

namespace ConsentCode.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
    }
}
