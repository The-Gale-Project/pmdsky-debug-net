// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_fainted_monster_offensive_stats defined within pmdsky.
    /// </summary>
    public partial class DungeonFaintedMonsterOffensiveStatsArray : KaitaiStruct
    {
        public static DungeonFaintedMonsterOffensiveStatsArray FromFile(string fileName)
        {
            return new DungeonFaintedMonsterOffensiveStatsArray(new KaitaiStream(fileName));
        }

        public DungeonFaintedMonsterOffensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFaintedMonsterOffensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFaintedMonsterOffensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonFaintedMonsterOffensiveStatsArrayDim0 : KaitaiStruct
        {
            public static DungeonFaintedMonsterOffensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new DungeonFaintedMonsterOffensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFaintedMonsterOffensiveStatsArrayDim0(KaitaiStream p__io, DungeonFaintedMonsterOffensiveStatsArray p__parent = null, DungeonFaintedMonsterOffensiveStatsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private DungeonFaintedMonsterOffensiveStatsArray m_root;
            private DungeonFaintedMonsterOffensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DungeonFaintedMonsterOffensiveStatsArray M_Root { get { return m_root; } }
            public DungeonFaintedMonsterOffensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private DungeonFaintedMonsterOffensiveStatsArrayDim0 _entries;
        private DungeonFaintedMonsterOffensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFaintedMonsterOffensiveStatsArrayDim0 Entries { get { return _entries; } }
        public DungeonFaintedMonsterOffensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
