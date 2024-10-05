namespace Backend.Repository.Interfaces
{
    public interface IImportRepository<T> where T : class
    {
        Task AddAsync(T obj);
        Task SaveChangesAsync();
    }
}
