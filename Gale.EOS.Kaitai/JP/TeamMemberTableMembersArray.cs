// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array team_member_table_members defined within pmdsky.
    /// </summary>
    public partial class TeamMemberTableMembersArray : KaitaiStruct
    {
        public static TeamMemberTableMembersArray FromFile(string fileName)
        {
            return new TeamMemberTableMembersArray(new KaitaiStream(fileName));
        }

        public TeamMemberTableMembersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberTableMembersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberTableMembersArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberTableMembersArrayDim0 : KaitaiStruct
        {
            public static TeamMemberTableMembersArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberTableMembersArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberTableMembersArrayDim0(KaitaiStream p__io, TeamMemberTableMembersArray p__parent = null, TeamMemberTableMembersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<GroundMonster>();
                for (var i = 0; i < 555; i++)
                {
                    _entries.Add(new GroundMonster(m_io));
                }
            }
            private List<GroundMonster> _entries;
            private TeamMemberTableMembersArray m_root;
            private TeamMemberTableMembersArray m_parent;
            public List<GroundMonster> Entries { get { return _entries; } }
            public TeamMemberTableMembersArray M_Root { get { return m_root; } }
            public TeamMemberTableMembersArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberTableMembersArrayDim0 _entries;
        private TeamMemberTableMembersArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberTableMembersArrayDim0 Entries { get { return _entries; } }
        public TeamMemberTableMembersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
