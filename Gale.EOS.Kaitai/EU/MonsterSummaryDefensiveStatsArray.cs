// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_summary_defensive_stats defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryDefensiveStatsArray : KaitaiStruct
    {
        public static MonsterSummaryDefensiveStatsArray FromFile(string fileName)
        {
            return new MonsterSummaryDefensiveStatsArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryDefensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryDefensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryDefensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryDefensiveStatsArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryDefensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryDefensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryDefensiveStatsArrayDim0(KaitaiStream p__io, MonsterSummaryDefensiveStatsArray p__parent = null, MonsterSummaryDefensiveStatsArray p__root = null) : base(p__io)
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
            private MonsterSummaryDefensiveStatsArray m_root;
            private MonsterSummaryDefensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MonsterSummaryDefensiveStatsArray M_Root { get { return m_root; } }
            public MonsterSummaryDefensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryDefensiveStatsArrayDim0 _entries;
        private MonsterSummaryDefensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryDefensiveStatsArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryDefensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
