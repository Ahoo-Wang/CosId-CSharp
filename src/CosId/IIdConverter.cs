namespace CosId;

public interface IIdConverter
{
    /// <summary>
    /// convert long type ID to string.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    string AsString(long id);

    /// <summary>
    /// convert string type ID to long.
    /// </summary>
    /// <param name="idString"></param>
    /// <returns></returns>
    long AsLong(string idString);
}