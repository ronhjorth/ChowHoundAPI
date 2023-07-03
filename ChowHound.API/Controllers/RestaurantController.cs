using ChowHound.API.Services;
using ChowHoundModel;
using Microsoft.AspNetCore.Mvc;

namespace ChowHound.API.Controllers;
//namespace ChowHoundModel;

[ApiController]
[Route("[controller]/[action]")]
public class RestaurantController: ControllerBase
{
    private readonly ILogger<MenuController> _logger;
    public RestaurantController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetRestaurantsByZip")]
    [ProducesResponseType(typeof(Restaurant[]), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    //public async Task<IActionResult> Get()
    public IActionResult GetRestaurantsByZip(string zipCode, int limit)
    {
        //TODO need to get into the pipeline
        RequestRestaurants service = new RequestRestaurants();
        return Ok(service.GetRestaurants());
    }
}