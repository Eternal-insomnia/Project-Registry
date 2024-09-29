using AutoMapper;
using ConsentCode.DTOs;
using ConsentCode.Models;
using ConsentCode.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsentCode.Repository.Implementations
{
    public class ProjectConditionViewRepository : RepositoryBase<ProjectConditionView>, IProjectConditionViewRepository
    {
        private readonly IMapper _mapper;

        public async Task<List<ProjectConditionViewDTO>> GetAll()
        {
            var projectConditionView = await FindAll().ToListAsync();
            return _mapper.Map<List<ProjectConditionViewDTO>>(projectConditionView);
        }

        public ProjectConditionViewRepository(RepositoryContext repositoryContext, IMapper mapper)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }
    }
}
