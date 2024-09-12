using AnalyzeProductCatalog.Models;
using AnalyzeProductCatalog.Services;

namespace AnalyzeProductCatalog;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new()
        {
            new Product { Name = "Smartphone", Category = "Eletrônicos", Price = 1000 },
            new Product { Name = "TV", Category = "Eletrônicos", Price = 1500 },
            new Product { Name = "Geladeira", Category = "Eletrodomésticos", Price = 2000 },
            new Product { Name = "Fogão", Category = "Eletrodomésticos", Price = 800 },
            new Product { Name = "Camiseta", Category = "Vestuário", Price = 50 },
        };

        ProductFilters filters = new();
        
        filters.FilterByCategory(products, "Eletrônicos");
        filters.OrderByCheaperPrices(products);
        filters.GroupByCategory(products);
        filters.SelectByPriceBelow(products, 1000);
        filters.NamesOfProductsByCategory(products, "Eletrodomésticos");
        filters.AllPrices(products);
    }
}