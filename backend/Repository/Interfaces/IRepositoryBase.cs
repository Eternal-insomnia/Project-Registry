using Backend.DTOs;

namespace Backend.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
    }
}
