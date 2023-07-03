namespace ChowHound.API.Models;

public class Menu
{
    public Guid MenuId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Calories { get; set; }
    public string Type { get; set; }
    public DateOnly LastUpdated {  get; set; }
    
}
//TODO 
// How am I going to define how this works:
// Dish, drinks, 
// Types: Breakfast, lunch, dinner 