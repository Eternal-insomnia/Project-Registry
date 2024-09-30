namespace Backend.Services.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        public Task<List<T>> GetAll();
    }
}
