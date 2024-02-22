// See https://aka.ms/new-console-template for more information

using Builder_Design_Pattern_and_Fluent_Builder;

var products = new List<Product>
{
    new Product { Name = "Monitor", Price = 200.50 },
    new Product { Name = "Mouse", Price = 20.41 },
    new Product { Name = "Keyboard", Price = 30.15}
};

var builder = new ProductStockReportBuilder(products);
var director = new ProductStockReportDirector(builder);
director.BuildStockReport();

var report = builder.GerReport();
Console.WriteLine(report);
