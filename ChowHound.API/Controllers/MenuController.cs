using Microsoft.AspNetCore.Mvc;
using ChowHound.API.Models;
using ChowHound.API.Services;

namespace ChowHound.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class MenuController : ControllerBase
{
    private static readonly string[] MealItems = new[]
    {
        "Happy Meal", "Chicken Sanwich", "Burger", "Chicken Nuggets", "Tacos", "Salad", "1/4 Pounder", "Fish Tacos", "Lox Sandwich", "Meat loaf"
    };
    

    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMenu")]
    [ProducesResponseType(typeof(Menu[]), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetMenu(int limit)
    {
        return Ok(Enumerable.Range(1, limit > 0 ? limit : 1).Select(index => new Menu
            {
                MenuId = Guid.NewGuid(),
                LastUpdated = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Calories = Random.Shared.Next(900, 2400),
                Name = MealItems[Random.Shared.Next(MealItems.Length)]
            })
            .ToArray());
    }
}
