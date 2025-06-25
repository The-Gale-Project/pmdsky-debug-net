// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union level_tilemap_list_entry defined within pmdsky-debug.
    /// </summary>
    public partial class LevelTilemapListEntry : KaitaiStruct
    {
        public static LevelTilemapListEntry FromFile(string fileName)
        {
            return new LevelTilemapListEntry(new KaitaiStream(fileName));
        }

        public LevelTilemapListEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, LevelTilemapListEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _field0x0 = m_io.ReadS2le();
            _field0x2 = m_io.ReadU1();
            _field0x3 = m_io.ReadU1();
            _field0x4 = m_io.ReadU4le();
        }
        private short _field0x0;
        private byte _field0x2;
        private byte _field0x3;
        private uint _field0x4;
        private LevelTilemapListEntry m_root;
        private KaitaiStruct m_parent;
        public short Field0x0 { get { return _field0x0; } }
        public byte Field0x2 { get { return _field0x2; } }
        public byte Field0x3 { get { return _field0x3; } }
        public uint Field0x4 { get { return _field0x4; } }
        public LevelTilemapListEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
