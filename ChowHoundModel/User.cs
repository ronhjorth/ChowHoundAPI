namespace ChowHoundModel;

public class User
{
    public int Id { get; set; }
    public Guid UserId { get; set; } 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? MobilePhone { get; set; }
    public string? Phone { get; set; }
    
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateActive { get; set; }
    public bool IsActive { get; set; }

}
