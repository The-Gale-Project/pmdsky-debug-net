// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array team_member_table_explorer_maze_team_name defined within pmdsky.
    /// </summary>
    public partial class TeamMemberTableExplorerMazeTeamNameArray : KaitaiStruct
    {
        public static TeamMemberTableExplorerMazeTeamNameArray FromFile(string fileName)
        {
            return new TeamMemberTableExplorerMazeTeamNameArray(new KaitaiStream(fileName));
        }

        public TeamMemberTableExplorerMazeTeamNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberTableExplorerMazeTeamNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberTableExplorerMazeTeamNameArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberTableExplorerMazeTeamNameArrayDim0 : KaitaiStruct
        {
            public static TeamMemberTableExplorerMazeTeamNameArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberTableExplorerMazeTeamNameArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberTableExplorerMazeTeamNameArrayDim0(KaitaiStream p__io, TeamMemberTableExplorerMazeTeamNameArray p__parent = null, TeamMemberTableExplorerMazeTeamNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private TeamMemberTableExplorerMazeTeamNameArray m_root;
            private TeamMemberTableExplorerMazeTeamNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public TeamMemberTableExplorerMazeTeamNameArray M_Root { get { return m_root; } }
            public TeamMemberTableExplorerMazeTeamNameArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberTableExplorerMazeTeamNameArrayDim0 _entries;
        private TeamMemberTableExplorerMazeTeamNameArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberTableExplorerMazeTeamNameArrayDim0 Entries { get { return _entries; } }
        public TeamMemberTableExplorerMazeTeamNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
