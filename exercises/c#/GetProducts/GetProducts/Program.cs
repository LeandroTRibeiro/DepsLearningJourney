using GetProducts.DB;
using GetProducts.Models;
using GetProducts.Services;

namespace GetProducts;

class Program
{
    static async Task Main(string[] args)
    {

        try
        {
            var context = new Context();
            var productsServices = new ProductsServices(context);

            #region AddProductsAsync
                // List<Product> products = new List<Product>
                // {
                //     new Product("Arroz", "Alimentos", 20),
                //     new Product("Feijão", "Alimentos", 7),
                //     new Product("Açúcar", "Alimentos", 5),
                //     new Product("Leite", "Bebidas", 4),
                //     new Product("Refrigerante", "Bebidas", 6),
                //     new Product("Café", "Bebidas", 8),
                //     new Product("Biscoito", "Alimentos", 3),
                //     new Product("Papel Higiênico", "Higiene", 12),
                //     new Product("Shampoo", "Higiene", 15),
                //     new Product("Sabonete", "Higiene", 2),
                //     new Product("Desodorante", "Higiene", 10),
                //     new Product("Fralda", "Higiene", 25),
                //     new Product("Queijo", "Alimentos", 30),
                //     new Product("Macarrão", "Alimentos", 4),
                //     new Product("Suco", "Bebidas", 5),
                //     new Product("Água Mineral", "Bebidas", 2),
                //     new Product("Vinho", "Bebidas", 40),
                //     new Product("Cerveja", "Bebidas", 5),
                //     new Product("Detergente", "Limpeza", 3),
                //     new Product("Sabão em Pó", "Limpeza", 18),
                //     new Product("Amaciante", "Limpeza", 10),
                //     new Product("Alvejante", "Limpeza", 9)
                // };
                
                // await productsServices.AddProductsAsync(products);
            #endregion

            #region AddProductAsync
                // Product newProduct = new Product("Esponja", "Limpeza", 2);
                // await productsServices.AddProductAsync(newProduct);
            #endregion
            
            #region GetProductsByCategoryIdAsync
                // var productList = await productsServices.GetProductsByCategoryIdAsync("Bebidas");
                // foreach (var product in productList)
                // {
                //     Console.WriteLine($"id: {product.Id}, name: {product.Name}, category: {product.Category}, price: {product.Price}, date: {product.Date}");
                // }
            #endregion
            

            #region GetProductsByName
                // var productList = await productsServices.GetProductsByName("a");
                // foreach (var product in productList)
                // {
                //     Console.WriteLine($"id: {product.Id}, name: {product.Name}, category: {product.Category}, price: {product.Price}, date: {product.Date}");
                // }
            #endregion

            #region GetProductByIdAsync
                // var product = await productsServices.GetProductByIdAsync(1);
                // Console.WriteLine($"id: {product.Id}, name: {product.Name}, category: {product.Category}, price: {product.Price}, date: {product.Date}");
            #endregion
            
            #region UploadProduct
                // var uploadproduct = await productsServices.GetProductByIdAsync(1);
                // uploadproduct.Price = 1000;
                // await productsServices.UploadProduct(uploadproduct);
            #endregion
            
            #region RemoveProductAsync
                // var product = await productsServices.GetProductByIdAsync(1);
                // await productsServices.RemoveProductAsync(product);
            #endregion
            
            #region RemoveProductsAsync
                // List<Product> removeList = await productsServices.GetProductsAsync();
                // await productsServices.RemoveProductsAsync(removeList);
            #endregion
            
            // List Products
            List<Product> productList = await productsServices.GetProductsAsync();
            
            foreach (var product in productList)
            {
                Console.WriteLine($"id: {product.Id}, name: {product.Name}, category: {product.Category}, price: {product.Price}, date: {product.Date}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}