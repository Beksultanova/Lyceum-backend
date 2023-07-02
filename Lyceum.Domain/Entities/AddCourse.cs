using System.ComponentModel.DataAnnotations.Schema;
namespace Lyceum.Domain.Entities;
[Table("AddCourse")]
public class AddCourse : Component
{
    public string? CourseDuration { get; set; }
    protected override int GetClassId() => ClassNames.AddCourse;

}


