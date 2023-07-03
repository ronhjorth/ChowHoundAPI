namespace ChowHoundModel;

public class Cuisines
{
    public int Id { get; set; }
    public int RestaurantId { get; set; } //could be many to one
    public string? CuisineName { get; set; }   
}