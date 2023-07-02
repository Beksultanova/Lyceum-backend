using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;

[Table("News")]
public class News : Component
{
    protected override int GetClassId() => ClassNames.News;
}