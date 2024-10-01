using Backend.DTOs.Views;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ProjectGoalsService : IViewService<ProjectGoalsViewDTO>
    {
        private readonly ILogger<ProjectGoalsService> _logger;
        private readonly IViewRepository<ProjectGoalsViewDTO> _projectGoalsViewRepository;

        public async Task<List<ProjectGoalsViewDTO>> GetAllView()
        {
            _logger.LogInformation("get all ProjectGoalsView [service]");
            return await _projectGoalsViewRepository.GetAllView();
        }

        public ProjectGoalsService(ILogger<ProjectGoalsService> logger, IViewRepository<ProjectGoalsViewDTO> projectGoalsViewRepository)
        {
            _logger = logger;
            _projectGoalsViewRepository = projectGoalsViewRepository;
        }
    }
}
