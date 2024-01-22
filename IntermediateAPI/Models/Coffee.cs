using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntermediateAPI.Models;

[Table("Coffees")]
public class Coffee
{
    public Coffee()
    {
        Id = Guid.NewGuid();
    }

    public Coffee(string name, string characteristic, string strength, decimal cost, string imageUrl)
    {
        Id = Guid.NewGuid();
        Name = name;
        Characteristic = characteristic;
        Strength = strength;
        Cost = cost;
        ImageUrl = imageUrl;
    }

    [Key]
    public Guid Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public string? Characteristic { get; set; }
    public string? Strength { get; set; }
    public decimal? Cost { get; set; }
    public  string? ImageUrl { get; set; }
}

public class CoffeeList
{
    public Coffee ListOfCoffees { get; set; }
}
