using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ViewService<T> : IViewService<T> where T : class
    {
        private readonly ILogger<ViewService<T>> _logger;
        private readonly IViewRepository<T> _viewRepository;

        public async Task<List<T>> GetAllView()
        {
            _logger.LogInformation("[ViewService] get all {Type}", typeof(T));
            return await _viewRepository.GetAllView();
        }

        public async Task<List<T>> FullTextSearch(string searchTerm)
        {
            _logger.LogInformation("[ViewService] search for {Param} in {Type}", searchTerm, typeof(T));
            return await _viewRepository.FullTextSearch(searchTerm);
        }

        public ViewService(ILogger<ViewService<T>> logger, IViewRepository<T> viewRepository)
        {
            _logger = logger;
            _viewRepository = viewRepository;
        }
    }
}
