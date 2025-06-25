// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array team_member_table_active_team_roster_member_idxs defined within pmdsky.
    /// </summary>
    public partial class TeamMemberTableActiveTeamRosterMemberIdxsArray : KaitaiStruct
    {
        public static TeamMemberTableActiveTeamRosterMemberIdxsArray FromFile(string fileName)
        {
            return new TeamMemberTableActiveTeamRosterMemberIdxsArray(new KaitaiStream(fileName));
        }

        public TeamMemberTableActiveTeamRosterMemberIdxsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberTableActiveTeamRosterMemberIdxsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1(m_io, this, m_root);
        }
        public partial class TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0 : KaitaiStruct
        {
            public static TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0(KaitaiStream p__io, TeamMemberTableActiveTeamRosterMemberIdxsArray.TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 p__parent = null, TeamMemberTableActiveTeamRosterMemberIdxsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private TeamMemberTableActiveTeamRosterMemberIdxsArray m_root;
            private TeamMemberTableActiveTeamRosterMemberIdxsArray.TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 m_parent;
            public List<short> Entries { get { return _entries; } }
            public TeamMemberTableActiveTeamRosterMemberIdxsArray M_Root { get { return m_root; } }
            public TeamMemberTableActiveTeamRosterMemberIdxsArray.TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 : KaitaiStruct
        {
            public static TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 FromFile(string fileName)
            {
                return new TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1(new KaitaiStream(fileName));
            }

            public TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1(KaitaiStream p__io, TeamMemberTableActiveTeamRosterMemberIdxsArray p__parent = null, TeamMemberTableActiveTeamRosterMemberIdxsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0(m_io, this, m_root));
                }
            }
            private List<TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0> _entries;
            private TeamMemberTableActiveTeamRosterMemberIdxsArray m_root;
            private TeamMemberTableActiveTeamRosterMemberIdxsArray m_parent;
            public List<TeamMemberTableActiveTeamRosterMemberIdxsArrayDim0> Entries { get { return _entries; } }
            public TeamMemberTableActiveTeamRosterMemberIdxsArray M_Root { get { return m_root; } }
            public TeamMemberTableActiveTeamRosterMemberIdxsArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 _entries;
        private TeamMemberTableActiveTeamRosterMemberIdxsArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberTableActiveTeamRosterMemberIdxsArrayDim1 Entries { get { return _entries; } }
        public TeamMemberTableActiveTeamRosterMemberIdxsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
