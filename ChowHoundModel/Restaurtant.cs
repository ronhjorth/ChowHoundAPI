namespace ChowHoundModel;

public class Restaurant
{
    public int Id { get; set; }
    public int AddressId { get; set; }
    public int GeoCodeId { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? WebSite { get; set; }
    public string? Hours { get; set; }
    public string? PriceRange { get; set; }
    public string? AddressFormatted { get; set; }
}