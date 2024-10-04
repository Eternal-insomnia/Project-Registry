namespace Backend.Services.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
