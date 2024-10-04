using AutoMapper;
using Backend.DTOs;
using Backend.Models;
using Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository.Implementations
{
    public class GeneralInfoRepository : RepositoryBase<ProjectGeneralInfo>, IGeneralInfoRepository
    {
        private readonly IMapper _mapper;

        public async Task<List<ProjectGeneralInfoDTO>> GetAll()
        {
            var generalInfo = await FindAll().ToListAsync();
            return _mapper.Map<List<ProjectGeneralInfoDTO>>(generalInfo);
        }

        public GeneralInfoRepository(RepositoryContext repositoryContext, IMapper mapper)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }
    }
}
