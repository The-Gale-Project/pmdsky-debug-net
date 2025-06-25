// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_defensive_stats defined within pmdsky.
    /// </summary>
    public partial class MonsterDefensiveStatsArray : KaitaiStruct
    {
        public static MonsterDefensiveStatsArray FromFile(string fileName)
        {
            return new MonsterDefensiveStatsArray(new KaitaiStream(fileName));
        }

        public MonsterDefensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterDefensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterDefensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterDefensiveStatsArrayDim0 : KaitaiStruct
        {
            public static MonsterDefensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new MonsterDefensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterDefensiveStatsArrayDim0(KaitaiStream p__io, MonsterDefensiveStatsArray p__parent = null, MonsterDefensiveStatsArray p__root = null) : base(p__io)
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
            private MonsterDefensiveStatsArray m_root;
            private MonsterDefensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public MonsterDefensiveStatsArray M_Root { get { return m_root; } }
            public MonsterDefensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private MonsterDefensiveStatsArrayDim0 _entries;
        private MonsterDefensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterDefensiveStatsArrayDim0 Entries { get { return _entries; } }
        public MonsterDefensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
