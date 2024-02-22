using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern_and_Fluent_Builder
{
    public class ProductStockReportDirector
    {
        private IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }
        public void BuildStockReport()
        {
            _productStockReportBuilder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }
}
