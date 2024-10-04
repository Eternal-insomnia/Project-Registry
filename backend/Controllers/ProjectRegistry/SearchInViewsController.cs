using Backend.DTOs.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.ProjectRegistry
{
    [ApiController]
    [Route("ProjectRegistry/Views")]
    public class SearchInViewsController : ControllerBase
    {
        private readonly ILogger<SearchInViewsController> _logger;

        private readonly ViewService<HomeViewDTO> _homeViewService;
        private readonly ViewService<ProjectGeneralInfoViewDTO> _projectGeneralInfoViewService;
        private readonly ViewService<ProjectConditionViewDTO> _projectConditionViewService;
        private readonly ViewService<ProjectTeamViewDTO> _projectTeamViewService;
        private readonly ViewService<ProjectTimelinesViewDTO> _projectTimelinesViewService;
        private readonly ViewService<ProjectCostViewDTO> _projectCostViewService;
        private readonly ViewService<ProjectDocumentsViewDTO> _projectDocumentsViewService;
        private readonly ViewService<ProjectGoalsViewDTO> _projectGoalsViewService;
        private readonly ViewService<ProjectMonitoringViewDTO> _projectMonitoringViewService;

        [HttpGet("Home/Search")]
        public async Task<IActionResult> SearchInHomeView([FromQuery] string searchTerm)
        {
            var searchResult = await _homeViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("ProjectGeneralInfo/Search")]
        public async Task<IActionResult> SearchInGeneralInfoView([FromQuery] string searchTerm)
        {
            var searchResult = await _projectGeneralInfoViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("ProjectsCondition/Search")]
        public async Task<IActionResult> SearchInProjectsConditionView([FromQuery] string searchTerm)
        {
            var searchResult = await _projectConditionViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("ProjectsTeam/Search")]
        public async Task<IActionResult> SearchInProjectsTeamView([FromQuery] string searchTerm)
        {
            var searchResult = await _projectTeamViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("ProjectsTimelines/Search")]
        public async Task<IActionResult> SearchInProjectsTimelinesView([FromQuery] string searchTerm)
        {
            var searchResult = await _projectTimelinesViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("ProjectsCost/Search")]
        public async Task<IActionResult> SearchInProjectsCostView([FromQuery] string searchTerm)
        {
            var homeView = await _projectCostViewService.FullTextSearch(searchTerm);
            return Ok(homeView);
        }

        [HttpGet("ProjectsDocuments/Search")]
        public async Task<IActionResult> SearchInProjectsDocumentsView([FromQuery] string searchTerm)
        {
            var homeView = await _projectDocumentsViewService.FullTextSearch(searchTerm);
            return Ok(homeView);
        }

        [HttpGet("ProjectsGoals/Search")]
        public async Task<IActionResult> SearchInProjectsGoalsView([FromQuery] string searchTerm)
        {
            var homeView = await _projectGoalsViewService.FullTextSearch(searchTerm);
            return Ok(homeView);
        }

        [HttpGet("ProjectsMonitoring/Search")]
        public async Task<IActionResult> SearchInProjectsMonitoringView([FromQuery] string searchTerm)
        {
            var homeView = await _projectMonitoringViewService.FullTextSearch(searchTerm);
            return Ok(homeView);
        }

        public SearchInViewsController(ILogger<SearchInViewsController> logger,
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
