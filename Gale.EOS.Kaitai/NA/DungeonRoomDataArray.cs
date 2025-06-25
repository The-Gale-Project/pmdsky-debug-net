// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_room_data defined within pmdsky.
    /// </summary>
    public partial class DungeonRoomDataArray : KaitaiStruct
    {
        public static DungeonRoomDataArray FromFile(string fileName)
        {
            return new DungeonRoomDataArray(new KaitaiStream(fileName));
        }

        public DungeonRoomDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonRoomDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonRoomDataArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonRoomDataArrayDim0 : KaitaiStruct
        {
            public static DungeonRoomDataArrayDim0 FromFile(string fileName)
            {
                return new DungeonRoomDataArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonRoomDataArrayDim0(KaitaiStream p__io, DungeonRoomDataArray p__parent = null, DungeonRoomDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<RoomData>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new RoomData(m_io));
                }
            }
            private List<RoomData> _entries;
            private DungeonRoomDataArray m_root;
            private DungeonRoomDataArray m_parent;
            public List<RoomData> Entries { get { return _entries; } }
            public DungeonRoomDataArray M_Root { get { return m_root; } }
            public DungeonRoomDataArray M_Parent { get { return m_parent; } }
        }
        private DungeonRoomDataArrayDim0 _entries;
        private DungeonRoomDataArray m_root;
        private KaitaiStruct m_parent;
        public DungeonRoomDataArrayDim0 Entries { get { return _entries; } }
        public DungeonRoomDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
