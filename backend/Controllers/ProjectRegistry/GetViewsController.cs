using Backend.Models.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.ProjectRegistry
{
    [ApiController]
    [Route("ProjectRegistry/Views")]
    public class GetViewsController : ControllerBase
    {
        private readonly ILogger<GetViewsController> _logger;
        
        private readonly ViewService<HomeView>               _homeViewService;
        private readonly ViewService<GeneralInfoView> _generalInfoViewService;
        private readonly ViewService<ConditionView>   _conditionViewService;
        private readonly ViewService<TeamView>        _teamViewService;
        private readonly ViewService<ProjectTimelinesView>   _timelinesViewService;
        private readonly ViewService<CostView>        _costViewService;
        private readonly ViewService<DocumentsView>   _documentsViewService;
        private readonly ViewService<GoalsView>       _goalsViewService;
        private readonly ViewService<MonitoringView>  _monitoringViewService;

        [HttpGet("Home")]
        public async Task<IActionResult> GetHomeView()
        {
            var home = await _homeViewService.GetAllView();
            return Ok(home);
        }

        [HttpGet("GeneralInfo")]
        public async Task<IActionResult> GetGeneralInfoView()
        {
            var generalInfo = await _generalInfoViewService.GetAllView();
            return Ok(generalInfo);
        }

        [HttpGet("Condition")]
        public async Task<IActionResult> GetConditionView()
        {
            var condition = await _conditionViewService.GetAllView();
            return Ok(condition);
        }

        [HttpGet("Team")]
        public async Task<IActionResult> GetTeamView()
        {
            var team = await _teamViewService.GetAllView();
            return Ok(team);
        }

        [HttpGet("Timelines")]
        public async Task<IActionResult> GetTimelinesView()
        {
            var timelines = await _timelinesViewService.GetAllView();
            return Ok(timelines);
        }

        [HttpGet("Cost")]
        public async Task<IActionResult> GetCostView()
        {
            var cost = await _costViewService.GetAllView();
            return Ok(cost);
        }

        [HttpGet("Documents")]
        public async Task<IActionResult> GetDocumentsView()
        {
            var documents = await _documentsViewService.GetAllView();
            return Ok(documents);
        }

        [HttpGet("Goals")]
        public async Task<IActionResult> GetGoalsView()
        {
            var goals = await _goalsViewService.GetAllView();
            return Ok(goals);
        }

        [HttpGet("Monitoring")]
        public async Task<IActionResult> GetMonitoringView()
        {
            var monitoring = await _monitoringViewService.GetAllView();
            return Ok(monitoring);
        }

        public GetViewsController(ILogger<GetViewsController> logger,
            ViewService<HomeView>               homeViewService,
            ViewService<GeneralInfoView> generalInfoViewService,
            ViewService<ConditionView>   conditionService,
            ViewService<TeamView>        teamService,
            ViewService<ProjectTimelinesView>   timelinesService,
            ViewService<CostView>        costService,
            ViewService<DocumentsView>   documentsService,
            ViewService<GoalsView>       goalsService,
            ViewService<MonitoringView>  monitoringViewService)
        {
            _logger = logger;
            _homeViewService        = homeViewService;
            _generalInfoViewService = generalInfoViewService;
            _conditionViewService   = conditionService;
            _teamViewService        = teamService;
            _timelinesViewService   = timelinesService;
            _costViewService        = costService;
            _documentsViewService   = documentsService;
            _goalsViewService       = goalsService;
            _monitoringViewService  = monitoringViewService;
        }
    }
}
