// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union dungeon_group_and_group_floor defined within pmdsky-debug.
    /// </summary>
    public partial class DungeonGroupAndGroupFloor : KaitaiStruct
    {
        public static DungeonGroupAndGroupFloor FromFile(string fileName)
        {
            return new DungeonGroupAndGroupFloor(new KaitaiStream(fileName));
        }

        public DungeonGroupAndGroupFloor(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonGroupAndGroupFloor p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _groupId = new DungeonGroupId8(m_io);
            _groupFloor = m_io.ReadU1();
        }
        private DungeonGroupId8 _groupId;
        private byte _groupFloor;
        private DungeonGroupAndGroupFloor m_root;
        private KaitaiStruct m_parent;
        public DungeonGroupId8 GroupId { get { return _groupId; } }
        public byte GroupFloor { get { return _groupFloor; } }
        public DungeonGroupAndGroupFloor M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
