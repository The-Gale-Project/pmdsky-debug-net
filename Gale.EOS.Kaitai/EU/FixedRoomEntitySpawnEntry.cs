// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union fixed_room_entity_spawn_entry defined within pmdsky-debug.
    /// </summary>
    public partial class FixedRoomEntitySpawnEntry : KaitaiStruct
    {
        public static FixedRoomEntitySpawnEntry FromFile(string fileName)
        {
            return new FixedRoomEntitySpawnEntry(new KaitaiStream(fileName));
        }

        public FixedRoomEntitySpawnEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomEntitySpawnEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _item = new Pointer(m_io);
            _monster = new Pointer(m_io);
            _tile = new Pointer(m_io);
        }
        private Pointer _item;
        private Pointer _monster;
        private Pointer _tile;
        private FixedRoomEntitySpawnEntry m_root;
        private KaitaiStruct m_parent;
        public Pointer Item { get { return _item; } }
        public Pointer Monster { get { return _monster; } }
        public Pointer Tile { get { return _tile; } }
        public FixedRoomEntitySpawnEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
