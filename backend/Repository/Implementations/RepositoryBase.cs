using ConsentCode.Repository.Interfaces;

namespace ConsentCode.Repository.Implementations
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext;

        public IQueryable<T> FindAll() => _repositoryContext.Set<T>();

        public RepositoryBase(RepositoryContext repositoryContext)
            => _repositoryContext = repositoryContext;
    }
}
