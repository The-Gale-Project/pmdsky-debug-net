namespace Gale.EOS.Debug;

public sealed class PmdSkyFunction
{
    public string Name { get; }
    public string[] Aliases { get; }
    public Dictionary<string, long> Address { get; }
    public string Description { get; }

    internal PmdSkyFunction(
        string name,
        string[] aliases,
        Dictionary<string, long> address,
        string description
    )
    {
        this.Name = name;
        this.Aliases = aliases;
        this.Address = address;
        this.Description = description;
    }
}
