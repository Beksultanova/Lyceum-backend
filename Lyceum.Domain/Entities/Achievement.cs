using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;

[Table("Achievement")]
public class Achievement : Component
{
    protected override int GetClassId() => ClassNames.Achievement;
}