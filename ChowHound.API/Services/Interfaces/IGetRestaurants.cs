using ChowHound.API.Models;

namespace ChowHound.API.Services.Interfaces;

public interface IRequestRestaurants
{
    List<Restaurant> GetRestaurants();
}