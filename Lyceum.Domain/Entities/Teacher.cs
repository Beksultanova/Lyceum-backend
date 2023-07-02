using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;

[Table("Teacher")]
public class Teacher : Person
{
    public string? Rank { get; set; }
    public string? AcademicDegree { get; set; }
    protected override int GetClassId() => ClassNames.Teacher;
}