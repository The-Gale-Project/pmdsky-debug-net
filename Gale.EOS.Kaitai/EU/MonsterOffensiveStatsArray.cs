// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_offensive_stats defined within pmdsky.
    /// </summary>
    public partial class MonsterOffensiveStatsArray : KaitaiStruct
    {
        public static MonsterOffensiveStatsArray FromFile(string fileName)
        {
            return new MonsterOffensiveStatsArray(new KaitaiStream(fileName));
        }

        public MonsterOffensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterOffensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterOffensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterOffensiveStatsArrayDim0 : KaitaiStruct
        {
            public static MonsterOffensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new MonsterOffensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterOffensiveStatsArrayDim0(KaitaiStream p__io, MonsterOffensiveStatsArray p__parent = null, MonsterOffensiveStatsArray p__root = null) : base(p__io)
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
            private MonsterOffensiveStatsArray m_root;
            private MonsterOffensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MonsterOffensiveStatsArray M_Root { get { return m_root; } }
            public MonsterOffensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private MonsterOffensiveStatsArrayDim0 _entries;
        private MonsterOffensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterOffensiveStatsArrayDim0 Entries { get { return _entries; } }
        public MonsterOffensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
