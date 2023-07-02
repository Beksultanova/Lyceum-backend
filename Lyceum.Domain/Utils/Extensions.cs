namespace Lyceum.Domain.Utils;

public static class Extensions
{
    public static string ToPascalCase(this string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length < 2)
            return value;
        return string.Concat(value[..1].ToUpper(), value.AsSpan(1));
    }
    
    public static object? GetDeepPropertyValue(this object? source, string path)
    {
        var pp = path.Split('.');
        if (source == null) return source;
        var t = source.GetType();
        foreach (var prop in pp)
        {
            var propInfo = t.GetProperty(prop);
            if (propInfo == null)
                throw new ArgumentException($"Properties path is not correct: {path}");
            
            source = propInfo.GetValue(source, null);
            t = propInfo.PropertyType;
        }

        return source;
    }
    
}