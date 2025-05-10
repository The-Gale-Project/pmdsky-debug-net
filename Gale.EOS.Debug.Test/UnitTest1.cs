namespace Gale.EOS.Debug.Test;

public class Tests
{
    private PmdSkySymbolMap pmdSkySymbolMap;

    [SetUp]
    public void Setup()
    {
        this.pmdSkySymbolMap = new PmdSkySymbolMap();
    }

    [Test]
    public void Test1()
    {
        Assert.That(this.pmdSkySymbolMap.Symbols.ContainsKey("arm9"));
    }
}
