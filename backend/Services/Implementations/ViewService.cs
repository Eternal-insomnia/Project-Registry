using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ViewService<DTO> : IViewService<DTO> where DTO : class
    {
        private readonly ILogger<ViewService<DTO>> _logger;
        private readonly IViewRepository<DTO> _viewRepository;

        public async Task<List<DTO>> GetAllView()
        {
            _logger.LogInformation("[ViewService] get all {Type}", typeof(DTO));
            return await _viewRepository.GetAllView();
        }

        public async Task<List<DTO>> FullTextSearch(string searchTerm)
        {
            _logger.LogInformation("[ViewService] search for {Param} in {Type}", searchTerm, typeof(DTO));
            return await _viewRepository.FullTextSearch(searchTerm);
        }

        public ViewService(ILogger<ViewService<DTO>> logger, IViewRepository<DTO> viewRepository)
        {
            _logger = logger;
            _viewRepository = viewRepository;
        }
    }
}
