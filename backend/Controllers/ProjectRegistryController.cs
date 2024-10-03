using Backend.DTOs.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("ProjectRegistry/Views")]
    public class ProjectRegistryViewsController : ControllerBase
    {
        private readonly ILogger<ProjectRegistryViewsController> _logger;

        private readonly ViewService<HomeViewDTO> _homeViewService;
        private readonly ViewService<ProjectGeneralInfoViewDTO> _projectGeneralInfoViewService;
        private readonly ViewService<ProjectConditionViewDTO> _projectConditionViewService;
        private readonly ViewService<ProjectTeamViewDTO> _projectTeamViewService;
        private readonly ViewService<ProjectTimelinesViewDTO> _projectTimelinesViewService;
        private readonly ViewService<ProjectCostViewDTO> _projectCostViewService;
        private readonly ViewService<ProjectDocumentsViewDTO> _projectDocumentsViewService;
        private readonly ViewService<ProjectGoalsViewDTO> _projectGoalsViewService;
        private readonly ViewService<ProjectMonitoringViewDTO> _projectMonitoringViewService;

        [HttpGet("Home")]
        public async Task<IActionResult> GetHomeView()
        {
            var homeView = await _homeViewService.GetAllView();
            return Ok(homeView);
        }

        [HttpGet("ProjectsGeneralInfo")]
        public async Task<IActionResult> GetProjectsGeneralInfoView()
        {
            var projectsGeneralInfo = await _projectGeneralInfoViewService.GetAllView();
            return Ok(projectsGeneralInfo);
        }

        [HttpGet("ProjectsCondition")]
        public async Task<IActionResult> GetProjectsConditionView()
        {
            var projectsCondition = await _projectConditionViewService.GetAllView();
            return Ok(projectsCondition);
        }

        [HttpGet("ProjectsTeam")]
        public async Task<IActionResult> GetProjectsTeamView()
        {
            var projectsTeam = await _projectTeamViewService.GetAllView();
            return Ok(projectsTeam);
        }

        [HttpGet("ProjectsTimelines")]
        public async Task<IActionResult> GetProjectsTimelinesView()
        {
            var projectsTimelines = await _projectTimelinesViewService.GetAllView();
            return Ok(projectsTimelines);
        }

        [HttpGet("ProjectsCost")]
        public async Task<IActionResult> GetProjectsCostView()
        {
            var projectsCost = await _projectCostViewService.GetAllView();
            return Ok(projectsCost);
        }

        [HttpGet("ProjectsDocuments")]
        public async Task<IActionResult> GetProjectsDocumentsView()
        {
            var projectsDocuments = await _projectDocumentsViewService.GetAllView();
            return Ok(projectsDocuments);
        }

        [HttpGet("ProjectsGoals")]
        public async Task<IActionResult> GetProjectsGoalsView()
        {
            var projectsGoals = await _projectGoalsViewService.GetAllView();
            return Ok(projectsGoals);
        }

        [HttpGet("ProjectsMonitoring")]
        public async Task<IActionResult> GetProjectsMonitoringView()
        {
            var projectsMonitoring = await _projectMonitoringViewService.GetAllView();
            return Ok(projectsMonitoring);
        }

        public ProjectRegistryViewsController(ILogger<ProjectRegistryViewsController> logger,
            ViewService<HomeViewDTO> homeViewService,
            ViewService<ProjectGeneralInfoViewDTO> projectGeneralInfoViewService,
            ViewService<ProjectConditionViewDTO> projectConditionService,
            ViewService<ProjectTeamViewDTO> projectTeamService,
            ViewService<ProjectTimelinesViewDTO> projectTimelinesService,
            ViewService<ProjectCostViewDTO> projectCostService,
            ViewService<ProjectDocumentsViewDTO> projectDocumentsService,
            ViewService<ProjectGoalsViewDTO> projectGoalsService,
            ViewService<ProjectMonitoringViewDTO> projectMonitoringViewService)
        {
            _logger = logger;
            _homeViewService = homeViewService;
            _projectGeneralInfoViewService = projectGeneralInfoViewService;
            _projectConditionViewService = projectConditionService;
            _projectTeamViewService = projectTeamService;
            _projectTimelinesViewService = projectTimelinesService;
            _projectCostViewService = projectCostService;
            _projectDocumentsViewService = projectDocumentsService;
            _projectGoalsViewService = projectGoalsService;
            _projectMonitoringViewService = projectMonitoringViewService;
        }
    }
}
