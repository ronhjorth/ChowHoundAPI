using ChowHound.API.Models;
using ChowHoundModel;

namespace ChowHound.API.Services.Interfaces;

public interface IRequestRestaurants
{
    List<Restaurant> GetRestaurants();
}