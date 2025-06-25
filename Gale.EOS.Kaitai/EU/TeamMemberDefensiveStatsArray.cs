// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array team_member_defensive_stats defined within pmdsky.
    /// </summary>
    public partial class TeamMemberDefensiveStatsArray : KaitaiStruct
    {
        public static TeamMemberDefensiveStatsArray FromFile(string fileName)
        {
            return new TeamMemberDefensiveStatsArray(new KaitaiStream(fileName));
        }

        public TeamMemberDefensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberDefensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberDefensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberDefensiveStatsArrayDim0 : KaitaiStruct
        {
            public static TeamMemberDefensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberDefensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberDefensiveStatsArrayDim0(KaitaiStream p__io, TeamMemberDefensiveStatsArray p__parent = null, TeamMemberDefensiveStatsArray p__root = null) : base(p__io)
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
            private TeamMemberDefensiveStatsArray m_root;
            private TeamMemberDefensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public TeamMemberDefensiveStatsArray M_Root { get { return m_root; } }
            public TeamMemberDefensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberDefensiveStatsArrayDim0 _entries;
        private TeamMemberDefensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberDefensiveStatsArrayDim0 Entries { get { return _entries; } }
        public TeamMemberDefensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
