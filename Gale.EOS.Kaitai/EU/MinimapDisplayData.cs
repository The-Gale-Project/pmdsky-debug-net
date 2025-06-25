// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union minimap_display_data defined within pmdsky-debug.
    /// </summary>
    public partial class MinimapDisplayData : KaitaiStruct
    {
        public static MinimapDisplayData FromFile(string fileName)
        {
            return new MinimapDisplayData(new KaitaiStream(fileName));
        }

        public MinimapDisplayData(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _tileMatrix1 = new MinimapDisplayDataTileMatrix1Array(m_io);
            _tileMatrix2 = new MinimapDisplayDataTileMatrix2Array(m_io);
            _field0xe000 = new MinimapDisplayDataField0xe000Array(m_io);
            _overwrittenExtraBytes = new MinimapDisplayDataOverwrittenExtraBytesArray(m_io);
            _field0xe39c = new MinimapDisplayDataField0xe39cArray(m_io);
            _field0xe440 = m_io.ReadU4le();
            _field0xe444 = m_io.ReadU1();
            _field0xe445 = m_io.ReadU1();
            _field0xe446 = m_io.ReadU1();
            _field0xe447 = m_io.ReadU1();
            _field0xe448 = m_io.ReadU1();
            _field0xe449 = m_io.ReadU1();
            _field0xe44a = m_io.ReadU1();
            _field0xe44b = m_io.ReadU1();
        }
        private MinimapDisplayDataTileMatrix1Array _tileMatrix1;
        private MinimapDisplayDataTileMatrix2Array _tileMatrix2;
        private MinimapDisplayDataField0xe000Array _field0xe000;
        private MinimapDisplayDataOverwrittenExtraBytesArray _overwrittenExtraBytes;
        private MinimapDisplayDataField0xe39cArray _field0xe39c;
        private uint _field0xe440;
        private byte _field0xe444;
        private byte _field0xe445;
        private byte _field0xe446;
        private byte _field0xe447;
        private byte _field0xe448;
        private byte _field0xe449;
        private byte _field0xe44a;
        private byte _field0xe44b;
        private MinimapDisplayData m_root;
        private KaitaiStruct m_parent;
        public MinimapDisplayDataTileMatrix1Array TileMatrix1 { get { return _tileMatrix1; } }
        public MinimapDisplayDataTileMatrix2Array TileMatrix2 { get { return _tileMatrix2; } }
        public MinimapDisplayDataField0xe000Array Field0xe000 { get { return _field0xe000; } }
        public MinimapDisplayDataOverwrittenExtraBytesArray OverwrittenExtraBytes { get { return _overwrittenExtraBytes; } }
        public MinimapDisplayDataField0xe39cArray Field0xe39c { get { return _field0xe39c; } }
        public uint Field0xe440 { get { return _field0xe440; } }
        public byte Field0xe444 { get { return _field0xe444; } }
        public byte Field0xe445 { get { return _field0xe445; } }
        public byte Field0xe446 { get { return _field0xe446; } }
        public byte Field0xe447 { get { return _field0xe447; } }
        public byte Field0xe448 { get { return _field0xe448; } }
        public byte Field0xe449 { get { return _field0xe449; } }
        public byte Field0xe44a { get { return _field0xe44a; } }
        public byte Field0xe44b { get { return _field0xe44b; } }
        public MinimapDisplayData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
