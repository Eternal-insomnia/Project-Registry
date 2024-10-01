using Backend.DTOs.Views;

namespace Backend.Services.Interfaces
{
    public interface IViewService<T> where T : class
    {
        Task<List<T>> GetAllView();
    }
}
