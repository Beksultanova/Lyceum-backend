namespace Lyceum.Domain.Entities;

public abstract class Entity
{
    public long Id { get; set; }
    public int ClassId { get=>GetClassId();set{} }
    protected abstract int GetClassId();
    public string ClassName => GetType().Name;
}