using BlazorApp1.Components.Data;
using Microsoft.AspNetCore.Mvc;

[Route("api/orders")]
[ApiController]
public class OrdersController : ControllerBase
{
    [HttpPost]
    [ActionName("Order")]
    public IActionResult Order([FromForm] SelectListItem selectListItem)
    {
        System.Console.WriteLine($"Selected {selectListItem.id} with value of {selectListItem.value}!");
        var response = new
        {
            Success = true,
            Message = $"Selected {selectListItem.id} with value of {selectListItem.value}!",
            Code = StatusCodes.Status200OK
        };
        return Ok(response);
    }
    
}