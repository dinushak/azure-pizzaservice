using Microsoft.AspNetCore.Mvc;

namespace PizzaService.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaServiceController : ControllerBase
{
    
    [HttpGet(Name = "GetPizzaOrders")]
    public IEnumerable<PizzaOrder> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new PizzaOrder
        {
            Id = Random.Shared.Next(1, 100),
            PizzaMake = "Veg",
            PizzaCount = Random.Shared.Next(1, 5)
        })
        .ToArray();
    }
}
