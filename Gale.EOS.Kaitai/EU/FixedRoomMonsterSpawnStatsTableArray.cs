// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array FIXED_ROOM_MONSTER_SPAWN_STATS_TABLE defined within pmdsky.
    /// </summary>
    public partial class FixedRoomMonsterSpawnStatsTableArray : KaitaiStruct
    {
        public static FixedRoomMonsterSpawnStatsTableArray FromFile(string fileName)
        {
            return new FixedRoomMonsterSpawnStatsTableArray(new KaitaiStream(fileName));
        }

        public FixedRoomMonsterSpawnStatsTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FixedRoomMonsterSpawnStatsTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FixedRoomMonsterSpawnStatsTableArrayDim0(m_io, this, m_root);
        }
        public partial class FixedRoomMonsterSpawnStatsTableArrayDim0 : KaitaiStruct
        {
            public static FixedRoomMonsterSpawnStatsTableArrayDim0 FromFile(string fileName)
            {
                return new FixedRoomMonsterSpawnStatsTableArrayDim0(new KaitaiStream(fileName));
            }

            public FixedRoomMonsterSpawnStatsTableArrayDim0(KaitaiStream p__io, FixedRoomMonsterSpawnStatsTableArray p__parent = null, FixedRoomMonsterSpawnStatsTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<FixedRoomMonsterSpawnStatsEntry>();
                for (var i = 0; i < 99; i++)
                {
                    _entries.Add(new FixedRoomMonsterSpawnStatsEntry(m_io));
                }
            }
            private List<FixedRoomMonsterSpawnStatsEntry> _entries;
            private FixedRoomMonsterSpawnStatsTableArray m_root;
            private FixedRoomMonsterSpawnStatsTableArray m_parent;
            public List<FixedRoomMonsterSpawnStatsEntry> Entries { get { return _entries; } }
            public FixedRoomMonsterSpawnStatsTableArray M_Root { get { return m_root; } }
            public FixedRoomMonsterSpawnStatsTableArray M_Parent { get { return m_parent; } }
        }
        private FixedRoomMonsterSpawnStatsTableArrayDim0 _entries;
        private FixedRoomMonsterSpawnStatsTableArray m_root;
        private KaitaiStruct m_parent;
        public FixedRoomMonsterSpawnStatsTableArrayDim0 Entries { get { return _entries; } }
        public FixedRoomMonsterSpawnStatsTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
