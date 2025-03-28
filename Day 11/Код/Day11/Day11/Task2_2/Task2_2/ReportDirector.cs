using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class ReportDirector
    {
        private readonly IReportBuilder _reportBuilder;

        public ReportDirector(IReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }

        public void ConstructReport(string title, string content, string footer)
        {
            _reportBuilder.BuildTitle(title);
            _reportBuilder.BuildContent(content);
            _reportBuilder.BuildFooter(footer);
        }
    }
}
