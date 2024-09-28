using ConsentCode.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsentCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
