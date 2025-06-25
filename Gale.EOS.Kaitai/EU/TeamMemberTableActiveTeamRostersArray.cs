// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array team_member_table_active_team_rosters defined within pmdsky.
    /// </summary>
    public partial class TeamMemberTableActiveTeamRostersArray : KaitaiStruct
    {
        public static TeamMemberTableActiveTeamRostersArray FromFile(string fileName)
        {
            return new TeamMemberTableActiveTeamRostersArray(new KaitaiStream(fileName));
        }

        public TeamMemberTableActiveTeamRostersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberTableActiveTeamRostersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberTableActiveTeamRostersArrayDim1(m_io, this, m_root);
        }
        public partial class TeamMemberTableActiveTeamRostersArrayDim0 : KaitaiStruct
        {
            public static TeamMemberTableActiveTeamRostersArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberTableActiveTeamRostersArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberTableActiveTeamRostersArrayDim0(KaitaiStream p__io, TeamMemberTableActiveTeamRostersArray.TeamMemberTableActiveTeamRostersArrayDim1 p__parent = null, TeamMemberTableActiveTeamRostersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TeamMember>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new TeamMember(m_io));
                }
            }
            private List<TeamMember> _entries;
            private TeamMemberTableActiveTeamRostersArray m_root;
            private TeamMemberTableActiveTeamRostersArray.TeamMemberTableActiveTeamRostersArrayDim1 m_parent;
            public List<TeamMember> Entries { get { return _entries; } }
            public TeamMemberTableActiveTeamRostersArray M_Root { get { return m_root; } }
            public TeamMemberTableActiveTeamRostersArray.TeamMemberTableActiveTeamRostersArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class TeamMemberTableActiveTeamRostersArrayDim1 : KaitaiStruct
        {
            public static TeamMemberTableActiveTeamRostersArrayDim1 FromFile(string fileName)
            {
                return new TeamMemberTableActiveTeamRostersArrayDim1(new KaitaiStream(fileName));
            }

            public TeamMemberTableActiveTeamRostersArrayDim1(KaitaiStream p__io, TeamMemberTableActiveTeamRostersArray p__parent = null, TeamMemberTableActiveTeamRostersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TeamMemberTableActiveTeamRostersArrayDim0>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new TeamMemberTableActiveTeamRostersArrayDim0(m_io, this, m_root));
                }
            }
            private List<TeamMemberTableActiveTeamRostersArrayDim0> _entries;
            private TeamMemberTableActiveTeamRostersArray m_root;
            private TeamMemberTableActiveTeamRostersArray m_parent;
            public List<TeamMemberTableActiveTeamRostersArrayDim0> Entries { get { return _entries; } }
            public TeamMemberTableActiveTeamRostersArray M_Root { get { return m_root; } }
            public TeamMemberTableActiveTeamRostersArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberTableActiveTeamRostersArrayDim1 _entries;
        private TeamMemberTableActiveTeamRostersArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberTableActiveTeamRostersArrayDim1 Entries { get { return _entries; } }
        public TeamMemberTableActiveTeamRostersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
