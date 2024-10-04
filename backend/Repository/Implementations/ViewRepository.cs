using AutoMapper;
using Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Backend.Repository.Implementations
{
    public class ViewRepository<Model, DTO>: RepositoryBase<Model>, IViewRepository<DTO>
        where Model : class
        where DTO : class
    {
        private readonly IMapper _mapper;

        public async Task<List<DTO>> GetAllView()
        {
            var dataView = await FindAll().ToListAsync();
            return _mapper.Map<List<DTO>>(dataView);
        }

        public async Task<List<DTO>> FullTextSearch(string searchTerm)
        {
            var properties = typeof(Model)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.PropertyType == typeof(string) && p.Name != "Id")
                .Select(p => $"COALESCE(\"{p.Name}\", '')")
                .ToList();

            if (!properties.Any())
            {
                throw new InvalidOperationException("no string properties found to search");
            }

            string concatenatedFields = string.Join(" || ' ' || ", properties);
            string sql = $@"
            SELECT * FROM ""{typeof(Model).Name}""
            WHERE to_tsvector('russian', {concatenatedFields})
            @@ phraseto_tsquery('russian', {{0}})";

            var searchResult = await FindAllRaw().FromSqlRaw(sql, searchTerm).ToListAsync();
            return _mapper.Map<List<DTO>>(searchResult);
        }

        public ViewRepository(RepositoryContext repositoryContext, IMapper mapper)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }
    }
}
