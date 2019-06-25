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

  public class LocationsController : ControllerBase
  {


    [HttpGet("all")]
    public ActionResult<List<LocationTableStructure>> GetAllLocations()
    {
      var db = new DatabaseContext();
      var data = db.LocationTableName;
      return data.ToList();
    }

    [HttpPost("addlocation")]
    public ActionResult<LocationTableStructure> Post([FromBody]LocationTableStructure myLocation)
    {
      var db = new DatabaseContext();
      db.LocationTableName.Add(myLocation);
      db.SaveChanges();
      return myLocation;
    }

    [HttpGet("location/{locationId}")]
    public ActionResult<List<RecipeTableStructure>> GetAllLocation([FromRoute]int locationId)
    {
      var db = new DatabaseContext();
      var data = db.RecipeTableName.Where(u => u.LocationTableNameId == locationId);
      return data.ToList();
    }
  }

}