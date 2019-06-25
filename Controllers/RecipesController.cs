using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using willywonkaapi;
using willywonkaapi.Models;
using Microsoft.EntityFrameworkCore;


namespace willywonkaapi.Controllers
{

  [ApiController]
  [Route("api/[controller]")]

  public class RecipesController : ControllerBase
  {

    [HttpPost]
    public ActionResult<RecipeTableStructure> Post([FromBody]RecipeTableStructure myRecipe)
    {
      var db = new DatabaseContext();
      db.RecipeTableName.Add(myRecipe);
      db.SaveChanges();
      return myRecipe;
    }
    [HttpGet("all")]
    public ActionResult<List<RecipeTableStructure>> GetAll()
    {
      var db = new DatabaseContext();
      var allRecipes = db.RecipeTableName.Include(i => i.LocationTableName);
      return allRecipes.ToList();
    }

    // [HttpGet()]
    // public ActionResult<List<RecipeTableStructure>> GetAll([FromQuery]int locationid)
    // {
    //   var db = new DatabaseContext();
    //   var local = db.LocationTableName.Include(f => f.Id == locationid);
    //   var returnValue = db.RecipeTableName.Where(w => w.LocationTableNameId == local.Id);
    //   return returnValue.ToList();
    // }

    [HttpGet("{id}")]
    public ActionResult<RecipeTableStructure> ListGetOneRecipe(int id)
    {
      var db = new DatabaseContext();
      var oneRecipe = db.RecipeTableName.FirstOrDefault(w => w.Id == id);
      return oneRecipe;
    }

    [HttpPut("update/{id}")]
    public ActionResult<RecipeTableStructure> UpdateRecipe(int id, [FromBody]RecipeTableStructure recipe)
    {
      var db = new DatabaseContext();
      var oneRecipe = db.RecipeTableName.FirstOrDefault(w => w.Id == id);
      oneRecipe.Name = recipe.Name;
      oneRecipe.SKU = recipe.SKU;
      oneRecipe.Description = recipe.Description;
      oneRecipe.Amount = recipe.Amount;
      oneRecipe.Price = recipe.Price;
      oneRecipe.LocationTableNameId = recipe.LocationTableNameId;
      db.SaveChanges();
      return oneRecipe;
    }

    [HttpDelete("delete/{id}")]
    public ActionResult<RecipeTableStructure> DeleteRecipe(int id)
    {
      var db = new DatabaseContext();
      var deleteOne = db.RecipeTableName.FirstOrDefault(w => w.Id == id);
      db.RecipeTableName.Remove(deleteOne);
      db.SaveChanges();
      return deleteOne;
    }
    [HttpGet("outofstock")]
    public ActionResult<List<RecipeTableStructure>> GetOutofStock(int id)
    {
      var db = new DatabaseContext();
      var outofStock = db.RecipeTableName.Where(w => w.Amount == 0);
      return outofStock.ToList();
    }
    [HttpGet("sku/{sku}")]
    public ActionResult<RecipeTableStructure> GetSku(string sku)
    {
      var db = new DatabaseContext();
      var skuRecipe = db.RecipeTableName.FirstOrDefault(f => f.SKU == sku);
      return skuRecipe;
    }
  }

}