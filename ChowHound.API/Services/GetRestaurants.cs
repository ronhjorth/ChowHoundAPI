using ChowHound.API.Models;
using ChowHound.API.Services.Interfaces;

namespace ChowHound.API.Services;

public class RequestRestaurants: IRequestRestaurants
{
    List<string> Restaurants = new List<string>
    {
        "Noma (Copenhagen, Denmark)",
        "Osteria Francescana (Modena, Italy)",
        "El Celler de Can Roca (Girona, Spain)",
        "Mirazur (Menton, France)",
        "Central (Lima, Peru)",
        "Gaggan (Bangkok, Thailand)",
        "Mugaritz (San Sebastian, Spain)",
        "Eleven Madison Park (New York City, USA)",
        "Quintonil (Mexico City, Mexico)",
        "Maido (Lima, Peru)",
        "The Ledbury (London, UK)",
        "Alinea (Chicago, USA)",
        "Azurmendi (Larrabetzu, Spain)",
        "Piazza Duomo (Alba, Italy)",
        "White Rabbit (Moscow, Russia)",
        "Arpège (Paris, France)",
        "Amber (Hong Kong, China)",
        "Mikla (Istanbul, Turkey)",
        "Robuchon au Dôme (Macau)",
        "Narisawa (Tokyo, Japan)",
        "L'Arpège (Paris, France)",
        "Le Bernardin (New York City, USA)",
        "Alléno Paris au Pavillon Ledoyen (Paris, France)",
        "Attica (Melbourne, Australia)",
        "Geranium (Copenhagen, Denmark)",
        "Género (Caracas, Venezuela)"
    };
    
    public List<Restaurant> GetRestaurants()
    {
        int limit = 3;
        return Enumerable.Range(1, limit > 0 ? limit : 1).Select(index => new Restaurant()
            {
                // D = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                // TemperatureC = Random.Shared.Next(-20, 55),
                Name = Restaurants[Random.Shared.Next(Restaurants.Count)]
            })
            .ToList();
            //.ToArray();
        //return new Restaurant();
    }
}