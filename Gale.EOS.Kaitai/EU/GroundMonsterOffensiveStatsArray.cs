// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ground_monster_offensive_stats defined within pmdsky.
    /// </summary>
    public partial class GroundMonsterOffensiveStatsArray : KaitaiStruct
    {
        public static GroundMonsterOffensiveStatsArray FromFile(string fileName)
        {
            return new GroundMonsterOffensiveStatsArray(new KaitaiStream(fileName));
        }

        public GroundMonsterOffensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMonsterOffensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMonsterOffensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMonsterOffensiveStatsArrayDim0 : KaitaiStruct
        {
            public static GroundMonsterOffensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new GroundMonsterOffensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMonsterOffensiveStatsArrayDim0(KaitaiStream p__io, GroundMonsterOffensiveStatsArray p__parent = null, GroundMonsterOffensiveStatsArray p__root = null) : base(p__io)
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
            private GroundMonsterOffensiveStatsArray m_root;
            private GroundMonsterOffensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public GroundMonsterOffensiveStatsArray M_Root { get { return m_root; } }
            public GroundMonsterOffensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private GroundMonsterOffensiveStatsArrayDim0 _entries;
        private GroundMonsterOffensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public GroundMonsterOffensiveStatsArrayDim0 Entries { get { return _entries; } }
        public GroundMonsterOffensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
