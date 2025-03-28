using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pdfBuilder = new PDFReportBuilder();
            var pdfDirector = new ReportDirector(pdfBuilder);
            pdfDirector.ConstructReport("Ежемесячный отчет", "Это содержимое ежемесячного отчета.", "Страница 1");
            var pdfReport = pdfBuilder.GetReport();
            pdfReport.ShowReport();

            var wordBuilder = new WordReportBuilder();
            var wordDirector = new ReportDirector(wordBuilder);
            wordDirector.ConstructReport("Годовой отчет", "Это содержимое годового отчета.", "Конец отчета");
            var wordReport = wordBuilder.GetReport();
            wordReport.ShowReport();

            var excelBuilder = new ExcelReportBuilder();
            var excelDirector = new ReportDirector(excelBuilder);
            excelDirector.ConstructReport("Отчет по продажам", "Это содержимое отчета по продажам.", "Резюме");
            var excelReport = excelBuilder.GetReport();
            excelReport.ShowReport();
        }
    }
}
