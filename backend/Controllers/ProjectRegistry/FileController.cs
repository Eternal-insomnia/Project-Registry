using Backend.Models.Views;
using Backend.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.ProjectRegistry
{
    [ApiController]
    [Route("ProjectRegistry")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        private readonly ImportService _importService;
        private readonly ExportService _exportService;

        private readonly ViewService<HomeView>             _homeViewService;
        private readonly ViewService<GeneralInfoView>      _generalInfoViewService;
        private readonly ViewService<ConditionView>        _conditionViewService;
        private readonly ViewService<TeamView>             _teamViewService;
        private readonly ViewService<TimelinesView> _timelinesViewService;
        private readonly ViewService<CostView>             _costViewService;
        private readonly ViewService<DocumentsView>        _documentsViewService;
        private readonly ViewService<GoalsView>            _goalsViewService;
        private readonly ViewService<MonitoringView>       _monitoringViewService;

        private readonly string _exportContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        [HttpPost("Import")]
        public async Task<IActionResult> ImportExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                _logger.LogWarning("empty import file");
                return BadRequest("empty import file");
            }

            var extension = Path.GetExtension(file.FileName).ToLower();
            if (extension != ".xlsx")
            {
                _logger.LogWarning("invalid import file format");
                return BadRequest("invalid import file format");
            }

            await _importService.Import(file);

            return Ok();
        }

        [HttpGet("Views/Home/Export")]
        public async Task<IActionResult> ExportHomeViewExcel()
        {
            var homeView = await _homeViewService.GetAllView();
            var excelStream = _exportService.ExportHomeView(homeView);

            return File(excelStream, _exportContentType, "Home.xlsx");
        }

        [HttpGet("Views/GeneralInfo/Export")]
        public async Task<IActionResult> ExportGeneralInfoViewExcel()
        {
            var generalInfoView = await _generalInfoViewService.GetAllView();
            var excelStream = _exportService.ExportGeneralInfoView(generalInfoView);

            return File(excelStream, _exportContentType, "GeneralInfo.xlsx");
        }

        [HttpGet("Views/Condition/Export")]
        public async Task<IActionResult> ExportConditionViewExcel()
        {
            var conditionView = await _conditionViewService.GetAllView();
            var excelStream = _exportService.ExportConditionView(conditionView);

            return File(excelStream, _exportContentType, "Condition.xlsx");
        }

        [HttpGet("Views/Team/Export")]
        public async Task<IActionResult> ExportTeamViewExcel()
        {
            var teamView = await _teamViewService.GetAllView();
            var excelStream = _exportService.ExportTeamView(teamView);

            return File(excelStream, _exportContentType, "Team.xlsx");
        }

        [HttpGet("Views/Timelines/Export")]
        public async Task<IActionResult> ExportTimelinesViewExcel()
        {
            var timelinesView = await _timelinesViewService.GetAllView();
            var excelStream = _exportService.ExportTimelinesView(timelinesView);

            return File(excelStream, _exportContentType, "Timelines.xlsx");
        }

        [HttpGet("Views/Cost/Export")]
        public async Task<IActionResult> ExportCostViewExcel()
        {
            var costView = await _costViewService.GetAllView();
            var excelStream = _exportService.ExportCostView(costView);

            return File(excelStream, _exportContentType, "Cost.xlsx");
        }

        [HttpGet("Views/Documents/Export")]
        public async Task<IActionResult> ExportDocumentsViewExcel()
        {
            var documentsView = await _documentsViewService.GetAllView();
            var excelStream = _exportService.ExportDocumentsView(documentsView);

            return File(excelStream, _exportContentType, "Documents.xlsx");
        }

        [HttpGet("Views/Goals/Export")]
        public async Task<IActionResult> ExportGoalsViewExcel()
        {
            var goalsView = await _goalsViewService.GetAllView();
            var excelStream = _exportService.ExportGoalsView(goalsView);

            return File(excelStream, _exportContentType, "Goals.xlsx");
        }

        [HttpGet("Views/Monitoring/Export")]
        public async Task<IActionResult> ExportMonitoringViewExcel()
        {
            var monitoringView = await _monitoringViewService.GetAllView();
            var excelStream = _exportService.ExportMonitoringView(monitoringView);

            return File(excelStream, _exportContentType, "Monitoring.xlsx");
        }

        public FileController(ILogger<FileController> logger,
            ImportService importService,
            ExportService exportService,
            ViewService<HomeView> homeViewService,
            ViewService<GeneralInfoView> generalInfoViewService,
            ViewService<ConditionView> conditionService,
            ViewService<TeamView> teamService,
            ViewService<TimelinesView> timelinesService,
            ViewService<CostView> costService,
            ViewService<DocumentsView> documentsService,
            ViewService<GoalsView> goalsService,
            ViewService<MonitoringView> monitoringViewService)
        {
            _logger = logger;

            _importService = importService;
            _exportService = exportService;

            _homeViewService = homeViewService;
            _generalInfoViewService = generalInfoViewService;
            _conditionViewService = conditionService;
            _teamViewService = teamService;
            _timelinesViewService = timelinesService;
            _costViewService = costService;
            _documentsViewService = documentsService;
            _goalsViewService = goalsService;
            _monitoringViewService = monitoringViewService;
        }
    }
}
