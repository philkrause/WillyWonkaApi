using System;
using System.Collections.Generic;

namespace willywonkaapi.Models
{
  public class LocationTableStructure
  {
    public int Id { get; set; }
    public DateTime Created_Time { get; set; } = DateTime.Now;
    public string ManagerName { get; set; }
    public string PhoneNumber { get; set; }
    public List<RecipeTableStructure> RecipeTableName { get; set; } = new List<RecipeTableStructure>();

  }
}