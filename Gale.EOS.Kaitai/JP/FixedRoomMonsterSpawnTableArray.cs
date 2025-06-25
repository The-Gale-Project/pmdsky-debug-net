// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FIXED_ROOM_MONSTER_SPAWN_TABLE defined within pmdsky.
    /// </summary>
    public partial class FixedRoomMonsterSpawnTableArray : KaitaiStruct
    {
        public static FixedRoomMonsterSpawnTableArray FromFile(string fileName)
        {
            return new FixedRoomMonsterSpawnTableArray(new KaitaiStream(fileName));
        }

        public FixedRoomMonsterSpawnTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomMonsterSpawnTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomMonsterSpawnTableArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomMonsterSpawnTableArrayDim0 : KaitaiStruct
        {
            public static FixedRoomMonsterSpawnTableArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomMonsterSpawnTableArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomMonsterSpawnTableArrayDim0(KaitaiStream p__io, FixedRoomMonsterSpawnTableArray p__parent = null, FixedRoomMonsterSpawnTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomMonsterSpawnEntry>();
                for (var i = 0; i < 120; i++)
                {
                    _entries.Add(new FixedRoomMonsterSpawnEntry(m_io));
                }
            }
            private List<FixedRoomMonsterSpawnEntry> _entries;
            private FixedRoomMonsterSpawnTableArray m_root;
            private FixedRoomMonsterSpawnTableArray m_parent;
            public List<FixedRoomMonsterSpawnEntry> Entries { get { return _entries; } }
            public FixedRoomMonsterSpawnTableArray M_Root { get { return m_root; } }
            public FixedRoomMonsterSpawnTableArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomMonsterSpawnTableArrayDim0 _entries;
        private FixedRoomMonsterSpawnTableArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomMonsterSpawnTableArrayDim0 Entries { get { return _entries; } }
        public FixedRoomMonsterSpawnTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
