// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_summary_offensive_stats defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryOffensiveStatsArray : KaitaiStruct
    {
        public static MonsterSummaryOffensiveStatsArray FromFile(string fileName)
        {
            return new MonsterSummaryOffensiveStatsArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryOffensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryOffensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryOffensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryOffensiveStatsArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryOffensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryOffensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryOffensiveStatsArrayDim0(KaitaiStream p__io, MonsterSummaryOffensiveStatsArray p__parent = null, MonsterSummaryOffensiveStatsArray p__root = null) : base(p__io)
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
            private MonsterSummaryOffensiveStatsArray m_root;
            private MonsterSummaryOffensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MonsterSummaryOffensiveStatsArray M_Root { get { return m_root; } }
            public MonsterSummaryOffensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryOffensiveStatsArrayDim0 _entries;
        private MonsterSummaryOffensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryOffensiveStatsArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryOffensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
