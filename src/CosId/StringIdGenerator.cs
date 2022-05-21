using System;

namespace CosId;

public class StringIdGenerator : IIdGenerator
{
    protected readonly IIdGenerator actual;
    protected readonly IIdConverter idConverter;


    public StringIdGenerator(IIdGenerator actual, IIdConverter idConverter)
    {
        this.actual = actual ?? throw new ArgumentNullException(nameof(actual));
        this.idConverter = idConverter ?? throw new ArgumentNullException(nameof(idConverter));
    }

    public long Generate()
    {
        return actual.Generate();
    }

    public string GenerateAsString()
    {
        var id = Generate();
        return idConverter.AsString(id);
    }
}