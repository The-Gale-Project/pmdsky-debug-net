// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array team_member_table_explorer_maze_monsters defined within pmdsky.
    /// </summary>
    public partial class TeamMemberTableExplorerMazeMonstersArray : KaitaiStruct
    {
        public static TeamMemberTableExplorerMazeMonstersArray FromFile(string fileName)
        {
            return new TeamMemberTableExplorerMazeMonstersArray(new KaitaiStream(fileName));
        }

        public TeamMemberTableExplorerMazeMonstersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberTableExplorerMazeMonstersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberTableExplorerMazeMonstersArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberTableExplorerMazeMonstersArrayDim0 : KaitaiStruct
        {
            public static TeamMemberTableExplorerMazeMonstersArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberTableExplorerMazeMonstersArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberTableExplorerMazeMonstersArrayDim0(KaitaiStream p__io, TeamMemberTableExplorerMazeMonstersArray p__parent = null, TeamMemberTableExplorerMazeMonstersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GroundMonster>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new GroundMonster(m_io));
                }
            }
            private List<GroundMonster> _entries;
            private TeamMemberTableExplorerMazeMonstersArray m_root;
            private TeamMemberTableExplorerMazeMonstersArray m_parent;
            public List<GroundMonster> Entries { get { return _entries; } }
            public TeamMemberTableExplorerMazeMonstersArray M_Root { get { return m_root; } }
            public TeamMemberTableExplorerMazeMonstersArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberTableExplorerMazeMonstersArrayDim0 _entries;
        private TeamMemberTableExplorerMazeMonstersArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberTableExplorerMazeMonstersArrayDim0 Entries { get { return _entries; } }
        public TeamMemberTableExplorerMazeMonstersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
