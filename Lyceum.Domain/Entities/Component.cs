using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;


[Table("Component")]
public class Component : Entity
{
    public string? Caption { get; set; }
    public string? FullInfo { get; set; }
    public DateTimeOffset? CreateDate  { get; set; } = DateTimeOffset.Now;
    public string? UpdateDate { get; set; }
    public string? DefaultImgId { get; set; }
    public List<string> Images { get; set; } = new();
    public string? Features { get; set; }
    public string? Views { get; set; }
    public int? Likes { get; set; }
    public int? Dislikes { get; set; }
    protected override int GetClassId() => ClassNames.Component;
}














