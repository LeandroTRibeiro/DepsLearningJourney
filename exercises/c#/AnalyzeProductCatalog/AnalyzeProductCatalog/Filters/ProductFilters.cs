using AnalyzeProductCatalog.Models;

namespace AnalyzeProductCatalog.Services;

public class ProductFilters
{

    private static void ShowProduct(Product product)
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Nome: {product.Name}");
        Console.WriteLine($"Categoria: {product.Category}");
        Console.WriteLine($"Preço: {product.Price}");
        Console.WriteLine("-------------------------");
    }

    private static void NoAnyProduct()
    {
        Console.WriteLine("Nenhum produto encontrado");
    }
    
    public void FilterByCategory(List<Product> productsList, string category)
    {
        IEnumerable<Product> filteredProductsList = productsList.Where(p => p.Category.Equals(category));

        if (!filteredProductsList.Any())
        {
            NoAnyProduct();
        }
        
        foreach (Product product in filteredProductsList)
        {
            ShowProduct(product);
        }
    }

    public void OrderByCheaperPrices(List<Product> productsList)
    {
        IEnumerable<Product> orderedProducts = productsList.OrderBy(p => p.Price);
        
        if (!orderedProducts.Any())
        {
            NoAnyProduct();
        }
        
        foreach (Product product in orderedProducts)
        {
            ShowProduct(product);
        }
        
    }

    public void GroupByCategory(List<Product> productsList)
    {
        IEnumerable<IGrouping<string, Product>> groups = productsList.GroupBy(p => p.Category);
        
        if (!groups.Any())
        {
            NoAnyProduct();
        }

        foreach (var group in groups)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"{group.Key}: {group.Count()}");
            
            group.ToList().ForEach(product =>
            {
                ShowProduct(product);
            });
        }
    }

    public void SelectByPriceBelow(List<Product> productsList, decimal price)
    {
        IEnumerable<Product> filteredProductsList = productsList.Where(p => p.Price <= price);
        
        if (!filteredProductsList.Any())
        {
            NoAnyProduct();
        }

        foreach (var product in filteredProductsList)
        {
            ShowProduct(product);
        }
    }

    public void NamesOfProductsByCategory(List<Product> productsList, string category)
    {
        IEnumerable<string> filteredProductsList =
            productsList
                .Where(p => p.Category.Equals(category))
                .Select(p => p.Name)
                .Distinct();
        
        if (!filteredProductsList.Any())
        {
            NoAnyProduct();
        }

        Console.WriteLine($"----------------------------");
        Console.WriteLine($"Categoria: {category}");
        foreach (string product in filteredProductsList)
        {
            Console.WriteLine($"Nome: {product}");
        }
        Console.WriteLine($"----------------------------");
    }

    public void AllPrices(List<Product> productsList)
    {
        decimal totalPrice = productsList.Aggregate((decimal)0, (acc, item) => acc + item.Price);
        
        Console.WriteLine($"Total price: {totalPrice}");
    }
    
}