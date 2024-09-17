using System.ComponentModel.DataAnnotations.Schema;

namespace GetProducts.Models;

[Table("products")]
public class Product
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("category")]
    public string Category { get; set; }
    
    [Column("price")]
    public int Price { get; set; }
    
    [Column("date")]
    public DateTime Date { get; set;  }

    public Product(string name, string category, int price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
}