using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
// PizzaController handles requests to https://localhost:{PORT}/pizza
public class PizzaController : ControllerBase
{
  public PizzaController()
  {
  }

  // GET all action
  // Responds only to the HTTP GET verb, as denoted by the [HttpGet] attribute.
  // Returns an ActionResult instance of type List<Pizza>.
  // The ActionResult type is the base class for all action results in ASP.NET Core.
  // Queries the service for all pizza and automatically returns data with a Content-Type value of application/json.
  [HttpGet]
  public ActionResult<List<Pizza>> GetAll() =>
  PizzaService.GetAll();

  // GET by Id action
  // Responds only to the HTTP GET verb, as denoted by the [HttpGet] attribute.
  // Requires that the id parameter's value is included in the URL segment after pizza/.
  // See the controller-level [Route] attribute defined the /pizza pattern.
  // Queries the database for a pizza that matches the provided id parameter. (200)
  // Or if not found, returns 404
  [HttpGet("{id}")]
  public ActionResult<Pizza> Get(int id)
  {
    var pizza = PizzaService.Get(id);

    if (pizza == null)
      return NotFound();

    return pizza;
  }

  // POST action

  // PUT action

  // DELETE action
}