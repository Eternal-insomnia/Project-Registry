using ConsentCode.DTOs;
using ConsentCode.Repository.Interfaces;
using ConsentCode.Services.Interfaces;

namespace ConsentCode.Services.Implementations
{
    public class ProjectConditionViewService : IProjectsConditionService
    {
        private readonly ILogger<ProjectConditionViewService> _logger;
        private readonly IProjectConditionViewRepository _projectConditionViewRepository;

        public async Task<List<ProjectConditionViewDTO>> GetAll()
        {
            _logger.LogInformation("Get All ProjectGeneralInfo Service");
            return await _projectConditionViewRepository.GetAll();
        }

        public ProjectConditionViewService(ILogger<ProjectConditionViewService> logger, IProjectConditionViewRepository projectConditionViewRepository)
        {
            _logger = logger;
            _projectConditionViewRepository = projectConditionViewRepository;
        }
    }
}
