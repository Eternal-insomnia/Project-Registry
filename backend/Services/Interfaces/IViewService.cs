using Backend.DTOs.Views;

namespace Backend.Services.Interfaces
{
    public interface IViewService<DTO> where DTO : class
    {
        Task<List<DTO>> GetAllView();
        Task<List<DTO>> FullTextSearch(string searchTerm);
    }
}
