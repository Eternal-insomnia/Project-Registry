using AutoMapper;
using ClosedXML.Excel;
using Backend.Models;
using Backend.Repository.Interfaces;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Reflection;

namespace Backend.Services.Implementations
{
    public class ImportService
    {
        private readonly ILogger<ImportService> _logger;

        private readonly IImportRepository<ProjectGeneralInfo> _importGeneralInfoRepository;
        private readonly IImportRepository<ProjectCondition>   _importConditionRepository;
        private readonly IImportRepository<ProjectTeam>        _importTeamRepository;
        private readonly IImportRepository<ProjectTimelines>   _importTimelinesRepository;
        private readonly IImportRepository<ProjectCost>        _importCostRepository;
        private readonly IImportRepository<ProjectDocuments>   _importDocumentsRepository;
        private readonly IImportRepository<ProjectGoals>       _importGoalsRepository;
        private readonly IImportRepository<ProjectMonitoring>  _importMonitoringRepository;

        private readonly PropertyInfo[] _generalInfoProperties;
        private readonly PropertyInfo[] _conditionProperties;
        private readonly PropertyInfo[] _teamProperties;
        private readonly PropertyInfo[] _timelinesProperties;
        private readonly PropertyInfo[] _costProperties;
        private readonly PropertyInfo[] _documentsProperties;
        private readonly PropertyInfo[] _goalsProperties;
        private readonly PropertyInfo[] _monitoringProperties;

        private static PropertyInfo[] GetProperties(Type type)
        {
            return type.GetProperties().Where(p => p.PropertyType == typeof(string)).ToArray();
        }

        public async Task Import(IFormFile file)
        {
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                stream.Position = 0;

                using var workbook = new XLWorkbook(stream);
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RowsUsed();

                foreach (var row in rows)
                {
                    if (row.RowNumber() < 5)
                        continue;

                    var id = Guid.NewGuid();
                    var column = 1;

                    var generalInfo = new ProjectGeneralInfo { Id = id };
                    ImportProjectData(generalInfo, _generalInfoProperties, row, ref column);

                    var condition = new ProjectCondition
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(condition, _conditionProperties, row, ref column);

                    var team = new ProjectTeam
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(team, _teamProperties, row, ref column);

                    var timelines = new ProjectTimelines
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(timelines, _timelinesProperties, row, ref column);

                    var cost = new ProjectCost
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(cost, _costProperties, row, ref column);

                    var documents = new ProjectDocuments
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(documents, _documentsProperties, row, ref column);

                    var goals = new ProjectGoals
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(goals, _goalsProperties, row, ref column);

                    var monitoring = new ProjectMonitoring
                    {
                        Id = id,
                        GeneralInfo = generalInfo
                    };
                    ImportProjectData(monitoring, _monitoringProperties, row, ref column);

                    await _importGeneralInfoRepository.AddAsync(generalInfo);
                    await _importConditionRepository.AddAsync(condition);
                    await _importTeamRepository.AddAsync(team);
                    await _importTimelinesRepository.AddAsync(timelines);
                    await _importCostRepository.AddAsync(cost);
                    await _importDocumentsRepository.AddAsync(documents);
                    await _importGoalsRepository.AddAsync(goals);
                    await _importMonitoringRepository.AddAsync(monitoring);
                }

                await _importGeneralInfoRepository.SaveChangesAsync();
                await _importConditionRepository.SaveChangesAsync();
                await _importTeamRepository.SaveChangesAsync();
                await _importTimelinesRepository.SaveChangesAsync();
                await _importCostRepository.SaveChangesAsync();
                await _importDocumentsRepository.SaveChangesAsync();
                await _importGoalsRepository.SaveChangesAsync();
                await _importMonitoringRepository.SaveChangesAsync();
            }
        }

        private static void ImportProjectData<T>(T model, PropertyInfo[] properties, IXLRow row, ref int column) where T : class
        {
            for (int i = 0; i < properties.Length; i++)
            {
                var cellValue = row.Cell(column++).Value.ToString();
                properties[i].SetValue(model, cellValue);
            }
        }

        public ImportService(ILogger<ImportService> logger,
            IImportRepository<ProjectGeneralInfo> importGeneralInfoRepository,
            IImportRepository<ProjectCondition> importConditionRepository,
            IImportRepository<ProjectTeam> importTeamRepository,
            IImportRepository<ProjectTimelines> importTimelinesRepository,
            IImportRepository<ProjectCost> importCostRepository,
            IImportRepository<ProjectDocuments> importDocumentsRepository,
            IImportRepository<ProjectGoals> importGoalsRepository,
            IImportRepository<ProjectMonitoring> importMonitoringRepository)
        {
            _logger = logger;
            _importGeneralInfoRepository = importGeneralInfoRepository;
            _importConditionRepository   = importConditionRepository;
            _importTeamRepository        = importTeamRepository;
            _importTimelinesRepository   = importTimelinesRepository;
            _importCostRepository        = importCostRepository;
            _importDocumentsRepository   = importDocumentsRepository;
            _importGoalsRepository       = importGoalsRepository;
            _importMonitoringRepository  = importMonitoringRepository;

            _generalInfoProperties = GetProperties(typeof(ProjectGeneralInfo));
            _conditionProperties   = GetProperties(typeof(ProjectCondition));
            _teamProperties        = GetProperties(typeof(ProjectTeam));
            _timelinesProperties   = GetProperties(typeof(ProjectTimelines));
            _costProperties        = GetProperties(typeof(ProjectCost));
            _documentsProperties   = GetProperties(typeof(ProjectDocuments));
            _goalsProperties       = GetProperties(typeof(ProjectGoals));
            _monitoringProperties  = GetProperties(typeof(ProjectMonitoring));
        }
    }
}
