using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;

[Table("Stakeholder")]
public class Stakeholder : Component
{
    protected override int GetClassId() => ClassNames.Stakeholder;
}