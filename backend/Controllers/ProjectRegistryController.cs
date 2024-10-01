using Backend.DTOs;
using Backend.Models;
using Backend.Services.Implementations;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectRegistryController : ControllerBase
    {
        private readonly ILogger<ProjectRegistryController> _logger;

        private readonly ProjectGeneralInfoService _projectGeneralInfoService;
        private readonly ProjectConditionService _projectConditionService;
        private readonly ProjectTeamService _projectTeamService;
        private readonly ProjectGoalsService _projectGoalsService;

        [HttpGet("ProjectsGeneralInfo")]
        public async Task<IActionResult> GetProjectsGeneralInfo()
        {
            var projectsGeneralInfo = await _projectGeneralInfoService.GetAll();
            return Ok(projectsGeneralInfo);
        }

        [HttpGet("ProjectsConditionView")]
        public async Task<IActionResult> GetProjectsConditionView()
        {
            var projectsCondition = await _projectConditionService.GetAllView();
            return Ok(projectsCondition);
        }

        [HttpGet("ProjectsTeamView")]
        public async Task<IActionResult> GetProjectsTeamView()
        {
            var projectsTeam = await _projectTeamService.GetAllView();
            return Ok(projectsTeam);
        }

        [HttpGet("ProjectsGoalsView")]
        public async Task<IActionResult> GetProjectsGoalsView()
        {
            var projectsGoals = await _projectGoalsService.GetAllView();
            return Ok(projectsGoals);
        }

        public ProjectRegistryController(ILogger<ProjectRegistryController> logger,
            ProjectGeneralInfoService projectGeneralInfoService,
            ProjectConditionService projectConditionService,
            ProjectTeamService projectTeamService,
            ProjectGoalsService projectGoalsService)
        {
            _logger = logger;
            _projectGeneralInfoService = projectGeneralInfoService;
            _projectConditionService = projectConditionService;
            _projectTeamService = projectTeamService;
            _projectGoalsService = projectGoalsService;
        }
    }
}
