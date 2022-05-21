using System;

namespace CosId.Converter;

public class ToStringIdConverter : IIdConverter
{
    public static readonly ToStringIdConverter INSTANCE = new();

    public string AsString(long id)
    {
        return id.ToString();
    }

    public long AsLong(string idString)
    {
        return Convert.ToInt64(idString);
    }
}