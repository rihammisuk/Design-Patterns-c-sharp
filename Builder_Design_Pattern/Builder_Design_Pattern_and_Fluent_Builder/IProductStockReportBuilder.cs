using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern_and_Fluent_Builder
{
    public interface IProductStockReportBuilder
    {
        IProductStockReportBuilder BuildHeader();
        IProductStockReportBuilder BuildBody();
        IProductStockReportBuilder BuildFooter();
        ProductStockReport GetReport();
    }
}
