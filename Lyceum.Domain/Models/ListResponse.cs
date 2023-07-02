 namespace Lyceum.Domain.Models;

public class ListResponse<TType>
{
    
    public IEnumerable<TType> Items { get; set; } = new List<TType>();
    public long? Total { get; set; }
    
    public ListResponse(IEnumerable<TType> items, long? total)
    {
        Items = items;
        Total = total;
    }

}