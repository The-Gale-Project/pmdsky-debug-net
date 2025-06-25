// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array team_member_offensive_stats defined within pmdsky.
    /// </summary>
    public partial class TeamMemberOffensiveStatsArray : KaitaiStruct
    {
        public static TeamMemberOffensiveStatsArray FromFile(string fileName)
        {
            return new TeamMemberOffensiveStatsArray(new KaitaiStream(fileName));
        }

        public TeamMemberOffensiveStatsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberOffensiveStatsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberOffensiveStatsArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberOffensiveStatsArrayDim0 : KaitaiStruct
        {
            public static TeamMemberOffensiveStatsArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberOffensiveStatsArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberOffensiveStatsArrayDim0(KaitaiStream p__io, TeamMemberOffensiveStatsArray p__parent = null, TeamMemberOffensiveStatsArray p__root = null) : base(p__io)
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
            private TeamMemberOffensiveStatsArray m_root;
            private TeamMemberOffensiveStatsArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public TeamMemberOffensiveStatsArray M_Root { get { return m_root; } }
            public TeamMemberOffensiveStatsArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberOffensiveStatsArrayDim0 _entries;
        private TeamMemberOffensiveStatsArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberOffensiveStatsArrayDim0 Entries { get { return _entries; } }
        public TeamMemberOffensiveStatsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
