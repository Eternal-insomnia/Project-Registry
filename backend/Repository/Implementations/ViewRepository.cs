using AutoMapper;
using Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Backend.Repository.Implementations
{
    public class ViewRepository<T>: RepositoryBase<T>, IViewRepository<T>
        where T : class
    {
        public async Task<List<T>> GetAllView() => await FindAll().ToListAsync();

        public async Task<List<T>> FullTextSearch(string searchTerm)
        {
            var properties = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.PropertyType == typeof(string) && p.Name != "Id")
                .Select(p => $"COALESCE(\"{p.Name}\", '')")
                .ToList();

            if (properties.Count == 0)
            {
                throw new InvalidOperationException("no string properties found to search");
            }

            string concatenatedFields = string.Join(" || ' ' || ", properties);
            string sql = $@"
            SELECT * FROM ""{typeof(T).Name}""
            WHERE to_tsvector('russian', {concatenatedFields})
            @@ phraseto_tsquery('russian', {{0}})";

            return await FindAllRaw().FromSqlRaw(sql, searchTerm).ToListAsync();
        }

        public ViewRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
