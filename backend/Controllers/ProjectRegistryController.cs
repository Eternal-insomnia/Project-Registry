using Backend.DTOs.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectRegistryController : ControllerBase
    {
        private readonly ILogger<ProjectRegistryController> _logger;

        private readonly ProjectGeneralInfoService _projectGeneralInfoService;
        private readonly ViewService<ProjectConditionViewDTO> _projectConditionViewService;
        private readonly ViewService<ProjectTeamViewDTO> _projectTeamViewService;
        private readonly ViewService<ProjectTimelinesViewDTO> _projectTimelinesViewService;
        private readonly ViewService<ProjectCostViewDTO> _projectCostViewService;
        private readonly ViewService<ProjectDocumentsViewDTO> _projectDocumentsViewService;
        private readonly ViewService<ProjectGoalsViewDTO> _projectGoalsViewService;

        [HttpGet("ProjectsGeneralInfo")]
        public async Task<IActionResult> GetProjectsGeneralInfo()
        {
            var projectsGeneralInfo = await _projectGeneralInfoService.GetAll();
            return Ok(projectsGeneralInfo);
        }

        [HttpGet("ProjectsConditionView")]
        public async Task<IActionResult> GetProjectsConditionView()
        {
            var projectsCondition = await _projectConditionViewService.GetAllView();
            return Ok(projectsCondition);
        }

        [HttpGet("ProjectsTeamView")]
        public async Task<IActionResult> GetProjectsTeamView()
        {
            var projectsTeam = await _projectTeamViewService.GetAllView();
            return Ok(projectsTeam);
        }

        [HttpGet("ProjectsTimelinesView")]
        public async Task<IActionResult> GetProjectsTimelinesView()
        {
            var projectsTimelines = await _projectTimelinesViewService.GetAllView();
            return Ok(projectsTimelines);
        }

        [HttpGet("ProjectsCostView")]
        public async Task<IActionResult> GetProjectsCostView()
        {
            var projectsCost = await _projectCostViewService.GetAllView();
            return Ok(projectsCost);
        }

        [HttpGet("ProjectsDocumentsView")]
        public async Task<IActionResult> GetProjectsDocumentsView()
        {
            var projectsDocuments = await _projectDocumentsViewService.GetAllView();
            return Ok(projectsDocuments);
        }

        [HttpGet("ProjectsGoalsView")]
        public async Task<IActionResult> GetProjectsGoalsView()
        {
            var projectsGoals = await _projectGoalsViewService.GetAllView();
            return Ok(projectsGoals);
        }

        public ProjectRegistryController(ILogger<ProjectRegistryController> logger,
            ProjectGeneralInfoService projectGeneralInfoService,
            ViewService<ProjectConditionViewDTO> projectConditionService,
            ViewService<ProjectTeamViewDTO> projectTeamService,
            ViewService<ProjectTimelinesViewDTO> projectTimelinesService,
            ViewService<ProjectCostViewDTO> projectCostService,
            ViewService<ProjectDocumentsViewDTO> projectDocumentsService,
            ViewService<ProjectGoalsViewDTO> projectGoalsService)
        {
            _logger = logger;
            _projectGeneralInfoService = projectGeneralInfoService;
            _projectConditionViewService = projectConditionService;
            _projectTeamViewService = projectTeamService;
            _projectTimelinesViewService = projectTimelinesService;
            _projectCostViewService = projectCostService;
            _projectDocumentsViewService = projectDocumentsService;
            _projectGoalsViewService = projectGoalsService;
        }
    }
}
