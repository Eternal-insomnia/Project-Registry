using Backend.Models.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.ProjectRegistry
{
    [ApiController]
    [Route("ProjectRegistry/Views")]
    public class SearchInViewsController : ControllerBase
    {
        private readonly ILogger<SearchInViewsController> _logger;

        private readonly ViewService<HomeView>                _homeViewService;
        private readonly ViewService<GeneralInfoView>  _generalInfoViewService;
        private readonly ViewService<ConditionView>    _conditionViewService;
        private readonly ViewService<TeamView>         _teamViewService;
        private readonly ViewService<TimelinesView>    _timelinesViewService;
        private readonly ViewService<CostView>         _costViewService;
        private readonly ViewService<DocumentsView>    _documentsViewService;
        private readonly ViewService<GoalsView>        _goalsViewService;
        private readonly ViewService<MonitoringView>   _monitoringViewService;
        private readonly NotDisplayedViewService       _notDisplayedViewService;

        [HttpGet("Home/Search")]
        public async Task<IActionResult> SearchInHomeView([FromQuery] string searchTerm)
        {
            var searchResult = await _homeViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("GeneralInfo/Search")]
        public async Task<IActionResult> SearchInGeneralInfoView([FromQuery] string searchTerm)
        {
            var searchResult = await _generalInfoViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Condition/Search")]
        public async Task<IActionResult> SearchInConditionView([FromQuery] string searchTerm)
        {
            var searchResult = await _conditionViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Team/Search")]
        public async Task<IActionResult> SearchInTeamView([FromQuery] string searchTerm)
        {
            var searchResult = await _teamViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Timelines/Search")]
        public async Task<IActionResult> SearchInTimelinesView([FromQuery] string searchTerm)
        {
            var searchResult = await _timelinesViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Cost/Search")]
        public async Task<IActionResult> SearchInCostView([FromQuery] string searchTerm)
        {
            var searchResult = await _costViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Documents/Search")]
        public async Task<IActionResult> SearchInDocumentsView([FromQuery] string searchTerm)
        {
            var searchResult = await _documentsViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Goals/Search")]
        public async Task<IActionResult> SearchInGoalsView([FromQuery] string searchTerm)
        {
            var searchResult = await _goalsViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("Monitoring/Search")]
        public async Task<IActionResult> SearchInMonitoringView([FromQuery] string searchTerm)
        {
            var searchResult = await _monitoringViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        [HttpGet("NotDisplayed/Search")]
        public async Task<IActionResult> SearchInNotDisplayedView([FromQuery] string searchTerm)
        {
            var searchResult = await _notDisplayedViewService.FullTextSearch(searchTerm);
            return Ok(searchResult);
        }

        public SearchInViewsController(ILogger<SearchInViewsController> logger,
            ViewService<HomeView>                homeViewService,
            ViewService<GeneralInfoView>  generalInfoViewService,
            ViewService<ConditionView>    conditionService,
            ViewService<TeamView>         teamService,
            ViewService<TimelinesView>    timelinesService,
            ViewService<CostView>         costService,
            ViewService<DocumentsView>    documentsService,
            ViewService<GoalsView>        goalsService,
            ViewService<MonitoringView>   monitoringViewService,
            NotDisplayedViewService       notDisplayedViewService)
        {
            _logger = logger;
            _homeViewService         = homeViewService;
            _generalInfoViewService  = generalInfoViewService;
            _conditionViewService    = conditionService;
            _teamViewService         = teamService;
            _timelinesViewService    = timelinesService;
            _costViewService         = costService;
            _documentsViewService    = documentsService;
            _goalsViewService        = goalsService;
            _monitoringViewService   = monitoringViewService;
            _notDisplayedViewService = notDisplayedViewService;
        }
    }
}
