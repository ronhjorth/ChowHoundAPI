namespace ChowHoundModel;

public class Menu
{
    public int Id { get; set; }
    public int CuisineId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool GlutenFree { get; set; }
    public DateOnly LastUpdated {  get; set; }
    public string? Price { get; set; }
    public string? Image { get; set; }
    public string? Type { get; set; }
}

//TODO 
// How am I going to define how this works:
// Dish, drinks, 
// Types: Breakfast, lunch, dinner 