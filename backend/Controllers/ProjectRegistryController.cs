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
        private readonly ProjectConditionViewService _projectConditionViewService;

        [HttpGet("ProjectsGeneralInfo")]
        public async Task<IActionResult> GetProjectsGeneralInfo()
        {
            var projectsGeneralInfo = await _projectGeneralInfoService.GetAll();
            return Ok(projectsGeneralInfo);
        }

        [HttpGet("ProjectsCondition")]
        public async Task<IActionResult> GetProjectsCondition()
        {
            var projectsCondition = await _projectConditionViewService.GetAll();
            return Ok(projectsCondition);
        }

        public ProjectRegistryController(ILogger<ProjectRegistryController> logger,
            ProjectGeneralInfoService projectGeneralInfoService,
            ProjectConditionViewService projectConditionViewService)
        {
            _logger = logger;
            _projectGeneralInfoService = projectGeneralInfoService;
            _projectConditionViewService = projectConditionViewService;
        }
    }
}
