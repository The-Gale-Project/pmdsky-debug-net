// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union fixed_room_item_spawn_entry defined within pmdsky-debug.
    /// </summary>
    public partial class FixedRoomItemSpawnEntry : KaitaiStruct
    {
        public static FixedRoomItemSpawnEntry FromFile(string fileName)
        {
            return new FixedRoomItemSpawnEntry(new KaitaiStream(fileName));
        }

        public FixedRoomItemSpawnEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomItemSpawnEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _item = new BulkItem(m_io);
            _field0x4 = m_io.ReadU1();
            _field0x5 = m_io.ReadU1();
            _field0x6 = m_io.ReadU1();
            _field0x7 = m_io.ReadU1();
        }
        private BulkItem _item;
        private byte _field0x4;
        private byte _field0x5;
        private byte _field0x6;
        private byte _field0x7;
        private FixedRoomItemSpawnEntry m_root;
        private KaitaiStruct m_parent;
        public BulkItem Item { get { return _item; } }
        public byte Field0x4 { get { return _field0x4; } }
        public byte Field0x5 { get { return _field0x5; } }
        public byte Field0x6 { get { return _field0x6; } }
        public byte Field0x7 { get { return _field0x7; } }
        public FixedRoomItemSpawnEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
