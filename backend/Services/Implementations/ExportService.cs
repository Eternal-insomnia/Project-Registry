using ClosedXML.Excel;
using Backend.Models.Views;

namespace Backend.Services.Implementations
{
    public class ExportService
    {
        private readonly ILogger<ExportService> _logger;

        public static MemoryStream WorksheetToStream(XLWorkbook workbook, IXLWorksheet worksheet)
        {
            worksheet.Columns().AdjustToContents();

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;

            return stream;
        }

        public MemoryStream ExportHomeView(List<HomeView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Дом");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Приоритет";
            worksheet.Cell(1, 5).Value = "% реализации";
            worksheet.Cell(1, 6).Value = "Общий статус";
            worksheet.Cell(1, 7).Value = "Завершение по текущему плану";
            worksheet.Cell(1, 8).Value = "Менеджер проекта";
            worksheet.Cell(1, 9).Value = "Краткое описание";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Priority;
                worksheet.Cell(row, 5).Value = item.Progress;
                worksheet.Cell(row, 6).Value = item.GeneralStatus;
                worksheet.Cell(row, 7).Value = item.ActualEnd;
                worksheet.Cell(row, 8).Value = item.Manager;
                worksheet.Cell(row, 9).Value = item.Description;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportGeneralInfoView(List<GeneralInfoView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Общая информация");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Направление деятельности";
            worksheet.Cell(1, 5).Value = "Программа";
            worksheet.Cell(1, 6).Value = "R / G / T";
            worksheet.Cell(1, 7).Value = "Краткое описание";
            worksheet.Cell(1, 8).Value = "Бизнес-цели";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Activity;
                worksheet.Cell(row, 5).Value = item.Program;
                worksheet.Cell(row, 6).Value = item.RGT;
                worksheet.Cell(row, 7).Value = item.Description;
                worksheet.Cell(row, 8).Value = item.BusinessGoals;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportConditionView(List<ConditionView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Состояние");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "% реализации";
            worksheet.Cell(1, 5).Value = "Бизнес-цели";
            worksheet.Cell(1, 6).Value = "Сроки";
            worksheet.Cell(1, 7).Value = "Бюджет";
            worksheet.Cell(1, 8).Value = "Содержание";
            worksheet.Cell(1, 9).Value = "Ссылка на отчёт";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Progress;
                worksheet.Cell(row, 5).Value = item.Goals;
                worksheet.Cell(row, 6).Value = item.Timelines;
                worksheet.Cell(row, 7).Value = item.Budget;
                worksheet.Cell(row, 8).Value = item.Contents;
                worksheet.Cell(row, 9).Value = item.ReportLink;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportTeamView(List<TeamView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Оргструктура");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Заказчик";
            worksheet.Cell(1, 5).Value = "Руководитель проекта";
            worksheet.Cell(1, 6).Value = "Тимлид";
            worksheet.Cell(1, 7).Value = "Бизнес-аналитик";
            worksheet.Cell(1, 8).Value = "Состав УК";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Customer;
                worksheet.Cell(row, 5).Value = item.Manager;
                worksheet.Cell(row, 6).Value = item.TeamLead;
                worksheet.Cell(row, 7).Value = item.BusinessAnalyst;
                worksheet.Cell(row, 8).Value = item.MCPeople;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportTimelinesView(List<TimelinesView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Сроки");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Фактическое начало";
            worksheet.Cell(1, 5).Value = "Фактическое завершение";
            worksheet.Cell(1, 6).Value = "Фактическая длительность (мес)";
            worksheet.Cell(1, 7).Value = "Завершение по текущему плану";
            worksheet.Cell(1, 8).Value = "Отклонение (дней)";
            worksheet.Cell(1, 9).Value = "Год начала реализации";
            worksheet.Cell(1, 10).Value = "Год завершения";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.ActualStart;
                worksheet.Cell(row, 5).Value = item.ActualEnd;
                worksheet.Cell(row, 6).Value = item.ActualDuration;
                worksheet.Cell(row, 7).Value = item.BaseEnd;
                worksheet.Cell(row, 8).Value = item.BaseDeviation;
                worksheet.Cell(row, 9).Value = item.PassportStartYear;
                worksheet.Cell(row, 10).Value = item.PassportEndYear;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportCostView(List<CostView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Стоимость");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Доходность";
            worksheet.Cell(1, 5).Value = "Базовый CAPEX (внешний)";
            worksheet.Cell(1, 6).Value = "Базовый CAPEX ФОТ";
            worksheet.Cell(1, 7).Value = "Базовый OPEX";
            worksheet.Cell(1, 8).Value = "CAPEX (внешний) по паспорту";
            worksheet.Cell(1, 9).Value = "CAPEX ФОТ по паспорту";
            worksheet.Cell(1, 10).Value = "OPEX по паспорту";
            worksheet.Cell(1, 11).Value = "Фактический CAPEX (внешний)";
            worksheet.Cell(1, 12).Value = "Фактический CAPEX ФОТ";
            worksheet.Cell(1, 13).Value = "Фактический OPEX";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Profitability;
                worksheet.Cell(row, 5).Value = item.BaseCAPEXExt;
                worksheet.Cell(row, 6).Value = item.BaseCAPEXWF;
                worksheet.Cell(row, 7).Value = item.BaseOPEX;
                worksheet.Cell(row, 8).Value = item.PassportCAPEXExt;
                worksheet.Cell(row, 9).Value = item.PassportCAPEXWF;
                worksheet.Cell(row, 10).Value = item.PassportOPEX;
                worksheet.Cell(row, 11).Value = item.ActualCAPEXExt;
                worksheet.Cell(row, 12).Value = item.ActualCAPEXWF;
                worksheet.Cell(row, 13).Value = item.ActualOPEX;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportDocumentsView(List<DocumentsView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Документы");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Решение о начале реализации";
            worksheet.Cell(1, 5).Value = "Сроки";
            worksheet.Cell(1, 6).Value = "Бюджет";
            worksheet.Cell(1, 7).Value = "Содержание";
            worksheet.Cell(1, 8).Value = "Решение о приостановке/возобновлении";
            worksheet.Cell(1, 9).Value = "Решение о завершении/закрытии";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.ImplStartDecision;
                worksheet.Cell(row, 5).Value = item.Timelines;
                worksheet.Cell(row, 6).Value = item.Budget;
                worksheet.Cell(row, 7).Value = item.Contents;
                worksheet.Cell(row, 8).Value = item.StopResumeDecision;
                worksheet.Cell(row, 9).Value = item.CloseCompleteDecision;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportGoalsView(List<GoalsView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Цели");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Продукт проекта";
            worksheet.Cell(1, 5).Value = "Критерии реализации";
            worksheet.Cell(1, 6).Value = "Статус целей, %";
            worksheet.Cell(1, 7).Value = "Бизнес-цели";
            worksheet.Cell(1, 8).Value = "Критерии достижения";
            worksheet.Cell(1, 9).Value = "Статус бизнес-целей, %";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Product;
                worksheet.Cell(row, 5).Value = item.ImplCriteria;
                worksheet.Cell(row, 6).Value = item.GoalsStatus;
                worksheet.Cell(row, 7).Value = item.BusinessGoals;
                worksheet.Cell(row, 8).Value = item.AchieveCriteria;
                worksheet.Cell(row, 9).Value = item.BusinessGoalsStatus;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public MemoryStream ExportMonitoringView(List<MonitoringView> data)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Мониторинг");

            worksheet.Cell(1, 1).Value = "Код";
            worksheet.Cell(1, 2).Value = "Наименование";
            worksheet.Cell(1, 3).Value = "Этап";
            worksheet.Cell(1, 4).Value = "Признак мониторинга";
            worksheet.Cell(1, 5).Value = "Статус мониторинга";
            worksheet.Cell(1, 6).Value = "Год завершения мониторинга";
            worksheet.Cell(1, 7).Value = "Продукт";
            worksheet.Cell(1, 8).Value = "Менеджер продукта";
            worksheet.Cell(1, 9).Value = "Характеристика проекта";
            worksheet.Cell(1, 10).Value = "Краткое наименование";

            var row = 2;
            foreach (var item in data)
            {
                worksheet.Cell(row, 1).Value = item.Code;
                worksheet.Cell(row, 2).Value = item.Name;
                worksheet.Cell(row, 3).Value = item.Stage;
                worksheet.Cell(row, 4).Value = item.Sign;
                worksheet.Cell(row, 5).Value = item.MonitoringStatus;
                worksheet.Cell(row, 6).Value = item.EndYear;
                worksheet.Cell(row, 7).Value = item.Product;
                worksheet.Cell(row, 8).Value = item.Manager;
                worksheet.Cell(row, 9).Value = item.Characteristics;
                worksheet.Cell(row, 10).Value = item.ShortName;
                row++;
            }

            return WorksheetToStream(workbook, worksheet);
        }

        public ExportService(ILogger<ExportService> logger)
        {
            _logger = logger;
        }
    }
}
