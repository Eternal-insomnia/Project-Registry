namespace Backend.Services.Interfaces
{
    public interface IViewService<T> where T : class
    {
        Task<List<T>> GetAllView();
        Task<List<T>> FullTextSearch(string searchTerm);
    }
}
