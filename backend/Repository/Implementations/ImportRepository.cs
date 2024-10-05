using Backend.Repository.Interfaces;

namespace Backend.Repository.Implementations
{
    public class ImportRepository<T> : RepositoryBase<T>, IImportRepository<T> where T : class
    {
        public async Task AddAsync(T obj)
        {
            await FindAllRaw().AddAsync(obj);
        }

        public async Task SaveChangesAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }

        public ImportRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
