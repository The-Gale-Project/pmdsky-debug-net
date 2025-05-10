namespace Gale.EOS.Debug;

public sealed class PmdSkyData
{
    public string Name { get; }
    public Dictionary<string, long> Address { get; }
    public Dictionary<string, long> Length { get; }
    public string Description { get; }

    internal PmdSkyData(
        string name,
        Dictionary<string, long> address,
        Dictionary<string, long> length,
        string description
    )
    {
        this.Name = name;
        this.Address = address;
        this.Length = length;
        this.Description = description;
    }
}
