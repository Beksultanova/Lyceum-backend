using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;

[Table("ParentСommission")]
public class ParentСommission : Component
{
    protected override int GetClassId() => ClassNames.ParentСommission;
}