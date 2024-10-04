using Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository.Implementations
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext;

        public IQueryable<T> FindAll() => _repositoryContext.Set<T>();

        public DbSet<T> FindAllRaw() => _repositoryContext.Set<T>();

        public RepositoryBase(RepositoryContext repositoryContext)
            => _repositoryContext = repositoryContext;
    }
}
