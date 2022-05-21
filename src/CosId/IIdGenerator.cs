namespace CosId;

public interface IIdGenerator
{
    /// <summary>
    /// Generate distributed ID.
    /// </summary>
    /// <returns>generated distributed ID</returns>
    long Generate();

    /// <summary>
    /// Generate distributed ID as String.
    /// </summary>
    /// <returns>generated distributed ID as String</returns>
    string GenerateAsString();
}