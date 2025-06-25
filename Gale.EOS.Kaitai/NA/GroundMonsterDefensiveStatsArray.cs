// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ground_monster_defensive_stats defined within pmdsky.
    /// </summary>
    public partial class GroundMonsterDefensiveStatsArray : KaitaiStruct
    {
        public static GroundMonsterDefensiveStatsArray FromFile(string fileName)
        {
            return new GroundMonsterDefensiveStatsArray(new KaitaiStream(fileName));
        }

        public GroundMonsterDefensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMonsterDefensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMonsterDefensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMonsterDefensiveStatsArrayDim0 : KaitaiStruct
        {
            public static GroundMonsterDefensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new GroundMonsterDefensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMonsterDefensiveStatsArrayDim0(KaitaiStream p__io, GroundMonsterDefensiveStatsArray p__parent = null, GroundMonsterDefensiveStatsArray p__root = null) : base(p__io)
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
            private GroundMonsterDefensiveStatsArray m_root;
            private GroundMonsterDefensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public GroundMonsterDefensiveStatsArray M_Root { get { return m_root; } }
            public GroundMonsterDefensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private GroundMonsterDefensiveStatsArrayDim0 _entries;
        private GroundMonsterDefensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public GroundMonsterDefensiveStatsArrayDim0 Entries { get { return _entries; } }
        public GroundMonsterDefensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
