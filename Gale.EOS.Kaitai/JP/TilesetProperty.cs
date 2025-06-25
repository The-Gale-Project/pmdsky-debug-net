// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union tileset_property defined within pmdsky-debug.
    /// </summary>
    public partial class TilesetProperty : KaitaiStruct
    {
        public static TilesetProperty FromFile(string fileName)
        {
            return new TilesetProperty(new KaitaiStream(fileName));
        }

        public TilesetProperty(KaitaiStream p__io, KaitaiStruct p__parent = null, TilesetProperty p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS4le();
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _padding = m_io.ReadU1();
            _naturePowerVariant = new NaturePowerVariant16(m_io);
            _field0xa = m_io.ReadU1();
            _isWaterTileset = m_io.ReadU1();
        }
        private int _field0x0;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private byte _padding;
        private NaturePowerVariant16 _naturePowerVariant;
        private byte _field0xa;
        private byte _isWaterTileset;
        private TilesetProperty m_root;
        private KaitaiStruct m_parent;
        public int Field0x0 { get { return _field0x0; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Padding { get { return _padding; } }
        public NaturePowerVariant16 NaturePowerVariant { get { return _naturePowerVariant; } }
        public byte Field0xa { get { return _field0xa; } }
        public byte IsWaterTileset { get { return _isWaterTileset; } }
        public TilesetProperty M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
