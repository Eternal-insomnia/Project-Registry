using Backend.DTOs.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.ProjectRegistry
{
    [ApiController]
    [Route("ProjectRegistry/Views")]
    public class GetViewsController : ControllerBase
    {
        private readonly ILogger<GetViewsController> _logger;
        
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

        [HttpGet("ProjectGeneralInfo")]
        public async Task<IActionResult> GetProjectGeneralInfoView()
        {
            var projectsGeneralInfo = await _projectGeneralInfoViewService.GetAllView();
            return Ok(projectsGeneralInfo);
        }

        [HttpGet("ProjectCondition")]
        public async Task<IActionResult> GetProjectConditionView()
        {
            var projectsCondition = await _projectConditionViewService.GetAllView();
            return Ok(projectsCondition);
        }

        [HttpGet("ProjectTeam")]
        public async Task<IActionResult> GetProjectTeamView()
        {
            var projectsTeam = await _projectTeamViewService.GetAllView();
            return Ok(projectsTeam);
        }

        [HttpGet("ProjectTimelines")]
        public async Task<IActionResult> GetProjectTimelinesView()
        {
            var projectsTimelines = await _projectTimelinesViewService.GetAllView();
            return Ok(projectsTimelines);
        }

        [HttpGet("ProjectCost")]
        public async Task<IActionResult> GetProjectCostView()
        {
            var projectsCost = await _projectCostViewService.GetAllView();
            return Ok(projectsCost);
        }

        [HttpGet("ProjectDocuments")]
        public async Task<IActionResult> GetProjectDocumentsView()
        {
            var projectsDocuments = await _projectDocumentsViewService.GetAllView();
            return Ok(projectsDocuments);
        }

        [HttpGet("ProjectGoals")]
        public async Task<IActionResult> GetProjectGoalsView()
        {
            var projectsGoals = await _projectGoalsViewService.GetAllView();
            return Ok(projectsGoals);
        }

        [HttpGet("ProjectMonitoring")]
        public async Task<IActionResult> GetProjectMonitoringView()
        {
            var projectsMonitoring = await _projectMonitoringViewService.GetAllView();
            return Ok(projectsMonitoring);
        }

        public GetViewsController(ILogger<GetViewsController> logger,
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
