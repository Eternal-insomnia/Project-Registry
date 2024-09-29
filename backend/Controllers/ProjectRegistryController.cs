using ConsentCode.Models;
using ConsentCode.Services.Implementations;
using ConsentCode.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsentCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectRegistryController : ControllerBase
    {
        private readonly ILogger<ProjectRegistryController> _logger;
        private readonly ProjectGeneralInfoService _projectGeneralInfoService;

        [HttpGet("ProjectsGeneralInfo")]
        public async Task<IActionResult> GetAll()
        {
            var projectsGeneralInfo = await _projectGeneralInfoService.GetAll();
            return Ok(projectsGeneralInfo);
        }

        public ProjectRegistryController(ILogger<ProjectRegistryController> logger, ProjectGeneralInfoService projectGeneralInfoService)
        {
            _logger = logger;
            _projectGeneralInfoService = projectGeneralInfoService;
        }
    }
}
