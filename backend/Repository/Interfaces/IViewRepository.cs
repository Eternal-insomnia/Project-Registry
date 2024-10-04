using Backend.DTOs.Views;

namespace Backend.Repository.Interfaces
{
    public interface IViewRepository<T> where T : class
    {
        Task<List<T>> GetAllView();
        Task<List<T>> FullTextSearch(string searchTerm);
    }
}
