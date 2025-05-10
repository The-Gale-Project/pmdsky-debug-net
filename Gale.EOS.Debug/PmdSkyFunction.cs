namespace Gale.EOS.Debug;

/// <summary>
/// Function data stored within a symbol.
/// </summary>
public sealed class PmdSkyFunction
{
    /// <summary>
    /// Name of this function.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Array of alias names for this function.
    /// </summary>
    public string[] Aliases { get; }

    /// <summary>
    /// Dictionary of addresses for this function organized by versions defined by <see cref="PmdSkySymbol.Versions"/>.
    /// </summary>
    public Dictionary<string, long[]> Address { get; }

    /// <summary>
    /// An overview of this function.
    /// </summary>
    public string Description { get; }

    internal PmdSkyFunction(
        string name,
        string[] aliases,
        Dictionary<string, long[]> address,
        string description
    )
    {
        this.Name = name;
        this.Aliases = aliases;
        this.Address = address;
        this.Description = description;
    }
}
