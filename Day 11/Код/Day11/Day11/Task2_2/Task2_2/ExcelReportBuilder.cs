using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class ExcelReportBuilder : IReportBuilder
    {

        private Report _report = new Report();

        public void BuildTitle(string title)
        {
            _report.AddSection($"Excel Заголовки: {title}");
        }

        public void BuildContent(string content)
        {
            _report.AddSection($"Excel контент: {content}");
        }

        public void BuildFooter(string footer)
        {
            _report.AddSection($"Excel подвал: {footer}");
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}
