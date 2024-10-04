using AutoMapper;
using Backend.DTOs;
using Backend.Models.Views;
using Backend.Repository.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class NotDisplayedViewService : IViewService<GeneralInfoMiniDTO>
    {
        private readonly ILogger<NotDisplayedViewService> _logger;
        private readonly IMapper _mapper;
        private readonly IViewRepository<NotDisplayedView> _viewRepository;

        public async Task<List<GeneralInfoMiniDTO>> GetAllView()
        {
            _logger.LogInformation("[ViewService] get all {Type}", typeof(NotDisplayedView));
            return _mapper.Map<List<GeneralInfoMiniDTO>>(await _viewRepository.GetAllView());
        }

        public async Task<List<GeneralInfoMiniDTO>> FullTextSearch(string searchTerm)
        {
            _logger.LogInformation("[ViewService] search for {Param} in {Type}", searchTerm, typeof(NotDisplayedView));
            return _mapper.Map<List<GeneralInfoMiniDTO>>(await _viewRepository.FullTextSearch(searchTerm));
        }

        public NotDisplayedViewService(ILogger<NotDisplayedViewService> logger, IMapper mapper, IViewRepository<NotDisplayedView> viewRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _viewRepository = viewRepository;
        }
    }
}
