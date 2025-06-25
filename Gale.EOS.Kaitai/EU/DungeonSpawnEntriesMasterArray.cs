// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_spawn_entries_master defined within pmdsky.
    /// </summary>
    public partial class DungeonSpawnEntriesMasterArray : KaitaiStruct
    {
        public static DungeonSpawnEntriesMasterArray FromFile(string fileName)
        {
            return new DungeonSpawnEntriesMasterArray(new KaitaiStream(fileName));
        }

        public DungeonSpawnEntriesMasterArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSpawnEntriesMasterArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSpawnEntriesMasterArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSpawnEntriesMasterArrayDim0 : KaitaiStruct
        {
            public static DungeonSpawnEntriesMasterArrayDim0 FromFile(string fileName)
            {
                return new DungeonSpawnEntriesMasterArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSpawnEntriesMasterArrayDim0(KaitaiStream p__io, DungeonSpawnEntriesMasterArray p__parent = null, DungeonSpawnEntriesMasterArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterSpawnEntry>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new MonsterSpawnEntry(m_io));
                }
            }
            private List<MonsterSpawnEntry> _entries;
            private DungeonSpawnEntriesMasterArray m_root;
            private DungeonSpawnEntriesMasterArray m_parent;
            public List<MonsterSpawnEntry> Entries { get { return _entries; } }
            public DungeonSpawnEntriesMasterArray M_Root { get { return m_root; } }
            public DungeonSpawnEntriesMasterArray M_Parent { get { return m_parent; } }
        }
        private DungeonSpawnEntriesMasterArrayDim0 _entries;
        private DungeonSpawnEntriesMasterArray m_root;
        private KaitaiStruct m_parent;
        public DungeonSpawnEntriesMasterArrayDim0 Entries { get { return _entries; } }
        public DungeonSpawnEntriesMasterArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
