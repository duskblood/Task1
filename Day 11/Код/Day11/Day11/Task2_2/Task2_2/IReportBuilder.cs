using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public interface IReportBuilder
    {
        void BuildTitle(string title);
        void BuildContent(string content);
        void BuildFooter(string footer);
        Report GetReport();
    }
}
