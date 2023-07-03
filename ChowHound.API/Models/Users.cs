namespace ChowHound.API.Models;

public class Users
{
    public Guid UserId { get; set; } 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MobilePhone { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateActive { get; set; }
    public bool IsActive { get; set; }
    
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    
}