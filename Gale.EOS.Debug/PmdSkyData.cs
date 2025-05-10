namespace Gale.EOS.Debug;

/// <summary>
/// Any non-function type stored within a symbol.
/// </summary>
public sealed class PmdSkyData
{
    /// <summary>
    /// The name of this data.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Array of alias names for this data.
    /// </summary>
    public string[] Aliases { get; }

    /// <summary>
    /// Dictionary of addresses for this data organized by versions defined by <see cref="PmdSkySymbol.Versions"/>.
    /// </summary>
    public Dictionary<string, long[]> Address { get; }

    /// <summary>
    /// Dictionary of byte-lengths of this data organized by versions defined by <see cref="PmdSkySymbol.Versions"/>.
    /// </summary>
    public Dictionary<string, long> Length { get; }

    /// <summary>
    /// An overview of this data.
    /// </summary>
    public string Description { get; }

    internal PmdSkyData(
        string name,
        string[] aliases,
        Dictionary<string, long[]> address,
        Dictionary<string, long> length,
        string description
    )
    {
        this.Name = name;
        this.Aliases = aliases;
        this.Address = address;
        this.Length = length;
        this.Description = description;
    }
}
