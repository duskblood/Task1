using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class WordReportFactory : ReportFactory
    {
        public override IReport CreateReport()
        {
            return new WordReport();
        }
    }
}
