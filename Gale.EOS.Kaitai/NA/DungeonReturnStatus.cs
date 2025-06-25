// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union dungeon_return_status defined within pmdsky-debug.
    /// </summary>
    public partial class DungeonReturnStatus : KaitaiStruct
    {
        public static DungeonReturnStatus FromFile(string fileName)
        {
            return new DungeonReturnStatus(new KaitaiStream(fileName));
        }

        public DungeonReturnStatus(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonReturnStatus p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _flag = m_io.ReadU1();
            _padding = m_io.ReadU1();
            _stringId = m_io.ReadS2le();
        }
        private byte _flag;
        private byte _padding;
        private short _stringId;
        private DungeonReturnStatus m_root;
        private KaitaiStruct m_parent;
        public byte Flag { get { return _flag; } }
        public byte Padding { get { return _padding; } }
        public short StringId { get { return _stringId; } }
        public DungeonReturnStatus M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
