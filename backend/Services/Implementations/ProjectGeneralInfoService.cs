using ConsentCode.Models;
using ConsentCode.Repository;
using ConsentCode.Services.Interfaces;

namespace ConsentCode.Services.Implementations
{
    public class ProjectGeneralInfoService : IBaseService<ProjectGeneralInfo>
    {
        private readonly ILogger<ProjectGeneralInfoService> _logger;
        private readonly RepositoryContext _dbContext;

        public async Task<List<ProjectGeneralInfo>> GetAll()
        {
            _logger.LogInformation("Get All ProjectGeneralInfo Service");
            return await _dbContext.GetAllProjectsGeneralInfo();
        }

        public ProjectGeneralInfoService(ILogger<ProjectGeneralInfoService> logger, RepositoryContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
    }
}
