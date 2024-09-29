using AutoMapper;
using ConsentCode.DTOs;
using ConsentCode.Models;
using ConsentCode.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsentCode.Repository.Implementations
{
    public class ProjectGeneralInfoRepository : RepositoryBase<ProjectGeneralInfo>, IProjectGeneralInfoRepository
    {
        private readonly IMapper _mapper;

        public async Task<List<ProjectGeneralInfoDTO>> GetAll()
        {
            var projectsGeneralInfo = await FindAll().ToListAsync();
            return _mapper.Map<List<ProjectGeneralInfoDTO>>(projectsGeneralInfo);
        }

        public ProjectGeneralInfoRepository(RepositoryContext repositoryContext, IMapper mapper)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }
    }
}
