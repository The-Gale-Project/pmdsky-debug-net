// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union minimap_display_tile defined within pmdsky-debug.
    /// </summary>
    public partial class MinimapDisplayTile : KaitaiStruct
    {
        public static MinimapDisplayTile FromFile(string fileName)
        {
            return new MinimapDisplayTile(new KaitaiStream(fileName));
        }

        public MinimapDisplayTile(KaitaiStream p__io, KaitaiStruct p__parent = null, MinimapDisplayTile p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadU4le();
            _field0x4 = m_io.ReadU4le();
            _field0x8 = m_io.ReadU4le();
            _field0x0c = m_io.ReadU4le();
            _field0x10 = m_io.ReadU4le();
            _field0x14 = m_io.ReadU4le();
            _field0x18 = m_io.ReadU4le();
            _field0x1c = m_io.ReadU4le();
            _field0x20 = m_io.ReadU4le();
            _field0x24 = m_io.ReadU4le();
            _field0x28 = m_io.ReadU4le();
            _field0x2c = m_io.ReadU4le();
            _field0x30 = m_io.ReadU4le();
            _field0x34 = m_io.ReadU4le();
            _field0x38 = m_io.ReadU4le();
            _field0x3c = m_io.ReadU4le();
        }
        private uint _field0x0;
        private uint _field0x4;
        private uint _field0x8;
        private uint _field0x0c;
        private uint _field0x10;
        private uint _field0x14;
        private uint _field0x18;
        private uint _field0x1c;
        private uint _field0x20;
        private uint _field0x24;
        private uint _field0x28;
        private uint _field0x2c;
        private uint _field0x30;
        private uint _field0x34;
        private uint _field0x38;
        private uint _field0x3c;
        private MinimapDisplayTile m_root;
        private KaitaiStruct m_parent;
        public uint Field0x0 { get { return _field0x0; } }
        public uint Field0x4 { get { return _field0x4; } }
        public uint Field0x8 { get { return _field0x8; } }
        public uint Field0x0c { get { return _field0x0c; } }
        public uint Field0x10 { get { return _field0x10; } }
        public uint Field0x14 { get { return _field0x14; } }
        public uint Field0x18 { get { return _field0x18; } }
        public uint Field0x1c { get { return _field0x1c; } }
        public uint Field0x20 { get { return _field0x20; } }
        public uint Field0x24 { get { return _field0x24; } }
        public uint Field0x28 { get { return _field0x28; } }
        public uint Field0x2c { get { return _field0x2c; } }
        public uint Field0x30 { get { return _field0x30; } }
        public uint Field0x34 { get { return _field0x34; } }
        public uint Field0x38 { get { return _field0x38; } }
        public uint Field0x3c { get { return _field0x3c; } }
        public MinimapDisplayTile M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
