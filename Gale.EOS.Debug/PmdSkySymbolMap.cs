using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace Gale.EOS.Debug;

public sealed class PmdSkySymbolMap
{
    private static readonly Regex RootSymbolYamlRegex = new(
        @".+\.symbols\.[^.]+\.yml", RegexOptions.Compiled
    );

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

        IDeserializer deserializer = new DeserializerBuilder()
            .WithNodeDeserializer(new YamlModelData.AddressNodeDeserializer()).Build();

        Assembly assembly = Assembly.GetExecutingAssembly();
        IEnumerable<string> rootSymbolYamls =
            assembly.GetManifestResourceNames().Where(x => RootSymbolYamlRegex.IsMatch(x));
        foreach (string yamlResource in rootSymbolYamls)
        {
            using Stream stream = assembly.GetManifestResourceStream(yamlResource);
            using StreamReader reader = new(stream);

            Dictionary<string, YamlModelData> symbolStore =
                deserializer.Deserialize<Dictionary<string, YamlModelData>>(reader);

            KeyValuePair<string, YamlModelData> symbol = symbolStore.First();

            Dictionary<string, PmdSkySymbol> subRegions = [];
            foreach (string subRegion in symbol.Value.SubRegions ?? [])
            {
                string subRegionYamlResource = assembly.GetManifestResourceNames().Single(x => x.EndsWith(subRegion));
                using Stream subRegionStream = assembly.GetManifestResourceStream(subRegionYamlResource);
                using StreamReader subRegionReader = new(subRegionStream);

                Dictionary<string, YamlModelData> subRegionSymbolStore =
                    deserializer.Deserialize<Dictionary<string, YamlModelData>>(subRegionReader);

                KeyValuePair<string, YamlModelData> subRegionSymbol = subRegionSymbolStore.First();

                subRegions[subRegionSymbol.Key] = new PmdSkySymbol(
                    symbol.Value.Versions,
                    symbol.Value.Address,
                    symbol.Value.Length,
                    symbol.Value.Description,
                    [], // Currently, this is not nested farther than a depth of 1.
                    [.. symbol.Value.Functions.Select(x => new PmdSkyFunction(
                        x.Name,
                        x.Aliases ?? [],
                        x.Address,
                        x.Description)
                    )],
                    [.. symbol.Value.Data.Select(x => new PmdSkyData(
                        x.Name,
                        x.Aliases ?? [],
                        x.Address,
                        x.Length,
                        x.Description
                    ))]
                );
            }

            this.Symbols[symbol.Key] = new PmdSkySymbol(
                symbol.Value.Versions,
                symbol.Value.Address,
                symbol.Value.Length,
                symbol.Value.Description,
                subRegions,
                [.. symbol.Value.Functions.Select(x => new PmdSkyFunction(
                    x.Name,
                    x.Aliases ?? [],
                    x.Address,
                    x.Description)
                )],
                [.. symbol.Value.Data.Select(x => new PmdSkyData(
                    x.Name,
                    x.Aliases ?? [],
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

        [YamlMember(Alias = "subregions")]
        public string[] SubRegions { get; set; }

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
            public Dictionary<string, long[]> Address { get; set; }

            [YamlMember(Alias = "description")]
            public string Description { get; set; }
        }

        public sealed class SkyDataModelData
        {
            [YamlMember(Alias = "name")]
            public string Name { get; set; }

            [YamlMember(Alias = "address")]
            public Dictionary<string, long[]> Address { get; set; }

            [YamlMember(Alias = "aliases")]
            public string[] Aliases { get; set; }

            [YamlMember(Alias = "length")]
            public Dictionary<string, long> Length { get; set; }

            [YamlMember(Alias = "description")]
            public string Description { get; set; }
        }

        // This is awful.
        public sealed class AddressNodeDeserializer : INodeDeserializer
        {
            bool INodeDeserializer.Deserialize(
                IParser reader,
                Type expectedType,
                Func<IParser, Type, object> nestedObjectDeserializer,
                out object value,
                ObjectDeserializer rootDeserializer
            )
            {
                if (expectedType != typeof(Dictionary<string, long[]>))
                {
                    value = null;
                    return false;
                }

                if (!reader.Accept<MappingStart>(out _))
                {
                    value = null;
                    return false;
                }

                reader.Consume<MappingStart>();
                Dictionary<string, long[]> result = [];
                while (!reader.TryConsume<MappingEnd>(out _))
                {
                    string versionKey = reader.Consume<Scalar>().Value;

                    try
                    {
                        long? singleAddress = nestedObjectDeserializer(reader, typeof(long)) as long?;
                        result[versionKey] = [singleAddress.Value];
                    }
                    catch
                    {
                        result[versionKey] = nestedObjectDeserializer(reader, typeof(long[])) as long[];
                    }
                }

                value = result;
                return true;
            }
        }
    }
}
