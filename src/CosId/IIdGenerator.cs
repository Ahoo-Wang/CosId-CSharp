using CosId.Converter;

namespace CosId;

public interface IIdGenerator
{
    IIdConverter IdConverter()
    {
        return ToStringIdConverter.INSTANCE;
    }

    /// <summary>
    /// Generate distributed ID.
    /// </summary>
    /// <returns>generated distributed ID</returns>
   public long Generate();

    /// <summary>
    /// Generate distributed ID as String.
    /// </summary>
    /// <returns>generated distributed ID as String</returns>
    string GenerateAsString()
    {
        var id = Generate();
        return IdConverter().AsString(id);
    }
}