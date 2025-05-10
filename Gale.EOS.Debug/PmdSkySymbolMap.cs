using System.Reflection;
using YamlDotNet.Serialization;

namespace Gale.EOS.Debug;

public sealed class PmdSkySymbolMap
{
    /// <summary>
    /// Mapping of all the symbols within Explorers of Sky.
    /// </summary>
    /// <remarks>
    /// Each file is stored as a key using its symbol name (e.g. "arm9" for the arm9 symbol).
    /// </remarks>
    public Dictionary<string, PmdSkySymbol> Symbols { get; }

    // cSpell:words pmdsky
    /// <summary>
    /// Loads all the symbol data from pmdsky_debug.
    /// </summary>
    /// <remarks>
    /// This can be resource intensive, so keep that in mind when calling this constructor.
    /// </remarks>
    public PmdSkySymbolMap()
    {
        this.Symbols = [];

        IDeserializer deserializer = new DeserializerBuilder().Build();

        Assembly assembly = Assembly.GetExecutingAssembly();
        foreach (string yamlResource in assembly.GetManifestResourceNames().Where(x => x.EndsWith(".yml")))
        {
            using Stream stream = assembly.GetManifestResourceStream(yamlResource);
            using StreamReader reader = new(stream);
            string yamlData = reader.ReadToEnd();

            Dictionary<string, YamlModelData> symbolStore =
                deserializer.Deserialize<Dictionary<string, YamlModelData>>(yamlData);

            KeyValuePair<string, YamlModelData> symbol = symbolStore.First();

            this.Symbols[symbol.Key] = new PmdSkySymbol(
                symbol.Value.Versions,
                symbol.Value.Address,
                symbol.Value.Length,
                symbol.Value.Description,
                [.. symbol.Value.Functions.Select(x => new PmdSkyFunction(
                    x.Name,
                    x.Aliases ?? [],
                    x.Address,
                    x.Description)
                )],
                [.. symbol.Value.Data.Select(x => new PmdSkyData(
                    x.Name,
                    x.Address,
                    x.Length,
                    x.Description
                ))]
            );
        }
    }

    private sealed class YamlModelData
    {
        [YamlMember(Alias = "versions")]
        public string[] Versions { get; set; }

        [YamlMember(Alias = "address")]
        public Dictionary<string, long> Address { get; set; }

        [YamlMember(Alias = "length")]
        public Dictionary<string, long> Length { get; set; }

        [YamlMember(Alias = "description")]
        public string Description { get; set; }

        [YamlMember(Alias = "functions")]
        public FunctionModelData[] Functions { get; set; }

        [YamlMember(Alias = "data")]
        public SkyDataModelData[] Data { get; set; }

        public sealed class FunctionModelData
        {
            [YamlMember(Alias = "name")]
            public string Name { get; set; }

            [YamlMember(Alias = "aliases")]
            public string[] Aliases { get; set; }

            [YamlMember(Alias = "address")]
            public Dictionary<string, long> Address { get; set; }

            [YamlMember(Alias = "description")]
            public string Description { get; set; }
        }

        public sealed class SkyDataModelData
        {
            [YamlMember(Alias = "name")]
            public string Name { get; set; }

            [YamlMember(Alias = "address")]
            public Dictionary<string, long> Address { get; set; }

            [YamlMember(Alias = "length")]
            public Dictionary<string, long> Length { get; set; }

            [YamlMember(Alias = "description")]
            public string Description { get; set; }
        }
    }
}
