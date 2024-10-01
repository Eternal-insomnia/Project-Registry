using Backend.DTOs;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ProjectGeneralInfoService : IProjectGeneralInfoService
    {
        private readonly ILogger<ProjectGeneralInfoService> _logger;
        private readonly IProjectGeneralInfoRepository _projectGeneralInfoRepository;

        public async Task<List<ProjectGeneralInfoDTO>> GetAll()
        {
            _logger.LogInformation("get all ProjectGeneralInfo [service]");
            return await _projectGeneralInfoRepository.GetAll();
        }

        public ProjectGeneralInfoService(ILogger<ProjectGeneralInfoService> logger, IProjectGeneralInfoRepository projectGeneralInfoRepository)
        {
            _logger = logger;
            _projectGeneralInfoRepository = projectGeneralInfoRepository;
        }
    }
}
