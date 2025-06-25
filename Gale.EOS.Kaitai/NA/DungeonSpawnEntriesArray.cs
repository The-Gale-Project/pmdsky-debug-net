// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array dungeon_spawn_entries defined within pmdsky.
    /// </summary>
    public partial class DungeonSpawnEntriesArray : KaitaiStruct
    {
        public static DungeonSpawnEntriesArray FromFile(string fileName)
        {
            return new DungeonSpawnEntriesArray(new KaitaiStream(fileName));
        }

        public DungeonSpawnEntriesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonSpawnEntriesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonSpawnEntriesArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonSpawnEntriesArrayDim0 : KaitaiStruct
        {
            public static DungeonSpawnEntriesArrayDim0 FromFile(string fileName)
            {
                return new DungeonSpawnEntriesArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonSpawnEntriesArrayDim0(KaitaiStream p__io, DungeonSpawnEntriesArray p__parent = null, DungeonSpawnEntriesArray p__root = null) : base(p__io)
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
            private DungeonSpawnEntriesArray m_root;
            private DungeonSpawnEntriesArray m_parent;
            public List<MonsterSpawnEntry> Entries { get { return _entries; } }
            public DungeonSpawnEntriesArray M_Root { get { return m_root; } }
            public DungeonSpawnEntriesArray M_Parent { get { return m_parent; } }
        }
        private DungeonSpawnEntriesArrayDim0 _entries;
        private DungeonSpawnEntriesArray m_root;
        private KaitaiStruct m_parent;
        public DungeonSpawnEntriesArrayDim0 Entries { get { return _entries; } }
        public DungeonSpawnEntriesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
