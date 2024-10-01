using Backend.DTOs.Views;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ProjectTeamService : IViewService<ProjectTeamViewDTO>
    {
        private readonly ILogger<ProjectTeamService> _logger;
        private readonly IViewRepository<ProjectTeamViewDTO> _projectTeamViewRepository;

        public async Task<List<ProjectTeamViewDTO>> GetAllView()
        {
            _logger.LogInformation("get all ProjectTeamView [service]");
            return await _projectTeamViewRepository.GetAllView();
        }

        public ProjectTeamService(ILogger<ProjectTeamService> logger, IViewRepository<ProjectTeamViewDTO> projectTeamViewRepository)
        {
            _logger = logger;
            _projectTeamViewRepository = projectTeamViewRepository;
        }
    }
}
