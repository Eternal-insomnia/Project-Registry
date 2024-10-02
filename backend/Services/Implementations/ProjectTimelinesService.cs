using Backend.DTOs.Views;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ProjectTimelinesService : IViewService<ProjectTimelinesViewDTO>
    {
        private readonly ILogger<ProjectTimelinesService> _logger;
        private readonly IViewRepository<ProjectTimelinesViewDTO> _projectTimelinesViewRepository;

        public async Task<List<ProjectTimelinesViewDTO>> GetAllView()
        {
            _logger.LogInformation("get all ProjectTimelinesView [service]");
            return await _projectTimelinesViewRepository.GetAllView();
        }

        public ProjectTimelinesService(ILogger<ProjectTimelinesService> logger, IViewRepository<ProjectTimelinesViewDTO> projectTimelinesViewRepository)
        {
            _logger = logger;
            _projectTimelinesViewRepository = projectTimelinesViewRepository;
        }
    }
}
