using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern_and_Fluent_Builder
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _productStockReport = new ProductStockReport();
            _products = products;
        }

        public IProductStockReportBuilder BuilderBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => $"Product name: {p.Name}, product price: {p.Price}"));
            return this;
        }

        public IProductStockReportBuilder BuilderFooter()
        {
            _productStockReport.FooterPart = "\nReport provided by the IT_PRODUCTS company.";
            return this;
        }

        public IProductStockReportBuilder BuilderHeader()
        {
            _productStockReport.HeaderPart = $"STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
            return this;
        }

        public ProductStockReport GerReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;
        }

        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
