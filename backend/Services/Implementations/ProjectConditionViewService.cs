using Backend.DTOs;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
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
