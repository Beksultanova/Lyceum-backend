namespace Lyceum.Domain.Entities;

public class Person : Entity
{
  
    public string? UserName { get; set; }
    public string? Img { get; set; }
    public string? Description { get; set; }
    public string? Age { get; set; }
    public string? FullInfo { get; set; } 
    public string? Features { get; set; }  
    public string? JobPosition { get; set; }
    public string? SocialNetwork { get; set; }
    protected override int GetClassId() => ClassNames.Person;
}