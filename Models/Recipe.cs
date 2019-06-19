using System;

namespace willywonkaapi.Models
{
  public class RecipeTableStructure
  {
    public int Id { get; set; }
    public DateTime Created_Time { get; set; } = DateTime.Now;
    public string Name { get; set; }
    public string SKU { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }

  }
}