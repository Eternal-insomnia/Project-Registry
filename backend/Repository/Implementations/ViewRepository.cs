using AutoMapper;
using Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public ViewRepository(RepositoryContext repositoryContext, IMapper mapper)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }
    }
}
