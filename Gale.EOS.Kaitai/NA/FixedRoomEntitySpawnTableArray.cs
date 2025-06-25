// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array FIXED_ROOM_ENTITY_SPAWN_TABLE defined within pmdsky.
    /// </summary>
    public partial class FixedRoomEntitySpawnTableArray : KaitaiStruct
    {
        public static FixedRoomEntitySpawnTableArray FromFile(string fileName)
        {
            return new FixedRoomEntitySpawnTableArray(new KaitaiStream(fileName));
        }

        public FixedRoomEntitySpawnTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomEntitySpawnTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomEntitySpawnTableArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomEntitySpawnTableArrayDim0 : KaitaiStruct
        {
            public static FixedRoomEntitySpawnTableArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomEntitySpawnTableArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomEntitySpawnTableArrayDim0(KaitaiStream p__io, FixedRoomEntitySpawnTableArray p__parent = null, FixedRoomEntitySpawnTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomEntitySpawnEntry>();
                for (var i = 0; i < 269; i++)
                {
                    _entries.Add(new FixedRoomEntitySpawnEntry(m_io));
                }
            }
            private List<FixedRoomEntitySpawnEntry> _entries;
            private FixedRoomEntitySpawnTableArray m_root;
            private FixedRoomEntitySpawnTableArray m_parent;
            public List<FixedRoomEntitySpawnEntry> Entries { get { return _entries; } }
            public FixedRoomEntitySpawnTableArray M_Root { get { return m_root; } }
            public FixedRoomEntitySpawnTableArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomEntitySpawnTableArrayDim0 _entries;
        private FixedRoomEntitySpawnTableArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomEntitySpawnTableArrayDim0 Entries { get { return _entries; } }
        public FixedRoomEntitySpawnTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
