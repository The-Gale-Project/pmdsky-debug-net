// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array enemy_spawn_stats_moves defined within pmdsky.
    /// </summary>
    public partial class EnemySpawnStatsMovesArray : KaitaiStruct
    {
        public static EnemySpawnStatsMovesArray FromFile(string fileName)
        {
            return new EnemySpawnStatsMovesArray(new KaitaiStream(fileName));
        }

        public EnemySpawnStatsMovesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EnemySpawnStatsMovesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EnemySpawnStatsMovesArrayDim0(m_io, this, m_root);
        }
        public partial class EnemySpawnStatsMovesArrayDim0 : KaitaiStruct
        {
            public static EnemySpawnStatsMovesArrayDim0 FromFile(string fileName)
            {
                return new EnemySpawnStatsMovesArrayDim0(new KaitaiStream(fileName));
            }

            public EnemySpawnStatsMovesArrayDim0(KaitaiStream p__io, EnemySpawnStatsMovesArray p__parent = null, EnemySpawnStatsMovesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MoveId16>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new MoveId16(m_io));
                }
            }
            private List<MoveId16> _entries;
            private EnemySpawnStatsMovesArray m_root;
            private EnemySpawnStatsMovesArray m_parent;
            public List<MoveId16> Entries { get { return _entries; } }
            public EnemySpawnStatsMovesArray M_Root { get { return m_root; } }
            public EnemySpawnStatsMovesArray M_Parent { get { return m_parent; } }
        }
        private EnemySpawnStatsMovesArrayDim0 _entries;
        private EnemySpawnStatsMovesArray m_root;
        private KaitaiStruct m_parent;
        public EnemySpawnStatsMovesArrayDim0 Entries { get { return _entries; } }
        public EnemySpawnStatsMovesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
