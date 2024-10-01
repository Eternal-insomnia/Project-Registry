using Backend.DTOs.Views;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ProjectConditionService : IViewService<ProjectConditionViewDTO>
    {
        private readonly ILogger<ProjectConditionService> _logger;
        private readonly IViewRepository<ProjectConditionViewDTO> _projectConditionViewRepository;

        public async Task<List<ProjectConditionViewDTO>> GetAllView()
        {
            _logger.LogInformation("get all ProjectConditionView [service]");
            return await _projectConditionViewRepository.GetAllView();
        }

        public ProjectConditionService(ILogger<ProjectConditionService> logger, IViewRepository<ProjectConditionViewDTO> projectConditionViewRepository)
        {
            _logger = logger;
            _projectConditionViewRepository = projectConditionViewRepository;
        }
    }
}
