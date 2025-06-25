// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_enemy_spawn_stats defined within pmdsky.
    /// </summary>
    public partial class DungeonEnemySpawnStatsArray : KaitaiStruct
    {
        public static DungeonEnemySpawnStatsArray FromFile(string fileName)
        {
            return new DungeonEnemySpawnStatsArray(new KaitaiStream(fileName));
        }

        public DungeonEnemySpawnStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonEnemySpawnStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonEnemySpawnStatsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonEnemySpawnStatsArrayDim0 : KaitaiStruct
        {
            public static DungeonEnemySpawnStatsArrayDim0 FromFile(string fileName)
            {
                return new DungeonEnemySpawnStatsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonEnemySpawnStatsArrayDim0(KaitaiStream p__io, DungeonEnemySpawnStatsArray p__parent = null, DungeonEnemySpawnStatsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<EnemySpawnStats>();
                for (var i = 0; i < 64; i++)
                {
                    _entries.Add(new EnemySpawnStats(m_io));
                }
            }
            private List<EnemySpawnStats> _entries;
            private DungeonEnemySpawnStatsArray m_root;
            private DungeonEnemySpawnStatsArray m_parent;
            public List<EnemySpawnStats> Entries { get { return _entries; } }
            public DungeonEnemySpawnStatsArray M_Root { get { return m_root; } }
            public DungeonEnemySpawnStatsArray M_Parent { get { return m_parent; } }
        }
        private DungeonEnemySpawnStatsArrayDim0 _entries;
        private DungeonEnemySpawnStatsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonEnemySpawnStatsArrayDim0 Entries { get { return _entries; } }
        public DungeonEnemySpawnStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
