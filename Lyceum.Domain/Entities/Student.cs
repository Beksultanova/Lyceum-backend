using System.ComponentModel.DataAnnotations.Schema;

namespace Lyceum.Domain.Entities;

[Table("Student")]
public class Student : Person
{
    protected override int GetClassId() => ClassNames.Student;
}