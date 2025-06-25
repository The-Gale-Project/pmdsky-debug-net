// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array dungeon_fainted_monster_defensive_stats defined within pmdsky.
    /// </summary>
    public partial class DungeonFaintedMonsterDefensiveStatsArray : KaitaiStruct
    {
        public static DungeonFaintedMonsterDefensiveStatsArray FromFile(string fileName)
        {
            return new DungeonFaintedMonsterDefensiveStatsArray(new KaitaiStream(fileName));
        }

        public DungeonFaintedMonsterDefensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DungeonFaintedMonsterDefensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DungeonFaintedMonsterDefensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class DungeonFaintedMonsterDefensiveStatsArrayDim0 : KaitaiStruct
        {
            public static DungeonFaintedMonsterDefensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new DungeonFaintedMonsterDefensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public DungeonFaintedMonsterDefensiveStatsArrayDim0(KaitaiStream p__io, DungeonFaintedMonsterDefensiveStatsArray p__parent = null, DungeonFaintedMonsterDefensiveStatsArray p__root = null) : base(p__io)
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
            private DungeonFaintedMonsterDefensiveStatsArray m_root;
            private DungeonFaintedMonsterDefensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DungeonFaintedMonsterDefensiveStatsArray M_Root { get { return m_root; } }
            public DungeonFaintedMonsterDefensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private DungeonFaintedMonsterDefensiveStatsArrayDim0 _entries;
        private DungeonFaintedMonsterDefensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public DungeonFaintedMonsterDefensiveStatsArrayDim0 Entries { get { return _entries; } }
        public DungeonFaintedMonsterDefensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
