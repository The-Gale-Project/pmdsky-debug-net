// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FIXED_ROOM_ITEM_SPAWN_TABLE defined within pmdsky.
    /// </summary>
    public partial class FixedRoomItemSpawnTableArray : KaitaiStruct
    {
        public static FixedRoomItemSpawnTableArray FromFile(string fileName)
        {
            return new FixedRoomItemSpawnTableArray(new KaitaiStream(fileName));
        }

        public FixedRoomItemSpawnTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomItemSpawnTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomItemSpawnTableArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomItemSpawnTableArrayDim0 : KaitaiStruct
        {
            public static FixedRoomItemSpawnTableArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomItemSpawnTableArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomItemSpawnTableArrayDim0(KaitaiStream p__io, FixedRoomItemSpawnTableArray p__parent = null, FixedRoomItemSpawnTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomItemSpawnEntry>();
                for (var i = 0; i < 63; i++)
                {
                    _entries.Add(new FixedRoomItemSpawnEntry(m_io));
                }
            }
            private List<FixedRoomItemSpawnEntry> _entries;
            private FixedRoomItemSpawnTableArray m_root;
            private FixedRoomItemSpawnTableArray m_parent;
            public List<FixedRoomItemSpawnEntry> Entries { get { return _entries; } }
            public FixedRoomItemSpawnTableArray M_Root { get { return m_root; } }
            public FixedRoomItemSpawnTableArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomItemSpawnTableArrayDim0 _entries;
        private FixedRoomItemSpawnTableArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomItemSpawnTableArrayDim0 Entries { get { return _entries; } }
        public FixedRoomItemSpawnTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
