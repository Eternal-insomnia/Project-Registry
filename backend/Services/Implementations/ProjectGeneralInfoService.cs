using ConsentCode.DTOs;
using ConsentCode.Repository.Interfaces;
using ConsentCode.Services.Interfaces;

namespace ConsentCode.Services.Implementations
{
    public class ProjectGeneralInfoService : IProjectGeneralInfoService
    {
        private readonly ILogger<ProjectGeneralInfoService> _logger;
        private readonly IProjectGeneralInfoRepository _projectGeneralInfoRepository;

        public async Task<List<ProjectGeneralInfoDTO>> GetAll()
        {
            _logger.LogInformation("Get All ProjectGeneralInfo Service");
            return await _projectGeneralInfoRepository.GetAll();
        }

        public ProjectGeneralInfoService(ILogger<ProjectGeneralInfoService> logger, IProjectGeneralInfoRepository projectGeneralInfoRepository)
        {
            _logger = logger;
            _projectGeneralInfoRepository = projectGeneralInfoRepository;
        }
    }
}
