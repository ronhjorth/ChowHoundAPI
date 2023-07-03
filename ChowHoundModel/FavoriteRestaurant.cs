namespace ChowHoundModel;

public class FavoriteRestaurants
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int RestaurantId { get; set; }
    public string? Remarks { get; set; }
}