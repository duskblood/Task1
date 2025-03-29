using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportFactory pdfFactory = new PdfReportFactory();
            IReport pdfReport = pdfFactory.CreateReport();
            pdfReport.Generate();

            ReportFactory excelFactory = new ExcelReportFactory();
            IReport excelReport = excelFactory.CreateReport();
            excelReport.Generate();

            ReportFactory wordFactory = new WordReportFactory();
            IReport wordReport = wordFactory.CreateReport();
            wordReport.Generate();
        }
    }
}
