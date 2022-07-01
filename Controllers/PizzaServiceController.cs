using Microsoft.AspNetCore.Mvc;

namespace PizzaService.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaServiceController : ControllerBase
{
    
    [HttpGet(Name = "GetPizzaOrders")]
    public IEnumerable<PizzaOrder> Get()
    {
        string[] pizzaType = {"Fruit","Veg","Seafood","Chicken"};
        return Enumerable.Range(1, 5).Select(index => new PizzaOrder
        {
            Id = Random.Shared.Next(1, 100),
            PizzaMake = pizzaType[Random.Shared.Next(0, pizzaType.Length-1)],
            PizzaCount = Random.Shared.Next(1, 5)
        })
        .ToArray();
    }
}
