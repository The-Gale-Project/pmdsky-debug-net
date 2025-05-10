namespace Gale.EOS.Debug;

/// <summary>
/// Stores symbol data for Explorers of Sky.
/// </summary>
/// <remarks>
/// A "symbol" is a name for a specific offset within a binary.
/// </remarks>
public sealed class PmdSkySymbol
{
    /// <summary>
    /// Array of all the address types.
    /// </summary>
    public string[] Versions { get; }

    /// <summary>
    /// Dictionary of all the addresses organized by versions defined by <see cref="Versions"/>
    /// </summary>
    public Dictionary<string, long> Address { get; }

    /// <summary>
    /// The length of this symbol, in bytes, organized by version defined by <see cref="Versions"/> .
    /// </summary>
    public Dictionary<string, long> Length { get; }

    /// <summary>
    /// An overview of this symbol.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Array of the functions within this symbol.
    /// </summary>
    public PmdSkyFunction[] Functions { get; }

    /// <summary>
    /// Array of the data within this symbol.
    /// </summary>
    public PmdSkyData[] Data { get; }

    internal PmdSkySymbol(
        string[] versions,
        Dictionary<string, long> address,
        Dictionary<string, long> length,
        string description,
        PmdSkyFunction[] functions,
        PmdSkyData[] data
    )
    {
        this.Versions = versions;
        this.Address = address;
        this.Length = length;
        this.Description = description;
        this.Functions = functions;
        this.Data = data;
    }
}
