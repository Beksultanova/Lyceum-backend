using System.ComponentModel.DataAnnotations.Schema;
namespace Lyceum.Domain.Entities;
[Table("History")]
public class History : Component
{
    public string? Date { get; set; }
    protected override int GetClassId() => ClassNames.History;

}