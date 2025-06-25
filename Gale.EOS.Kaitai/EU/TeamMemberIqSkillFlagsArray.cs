// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array team_member_iq_skill_flags defined within pmdsky.
    /// </summary>
    public partial class TeamMemberIqSkillFlagsArray : KaitaiStruct
    {
        public static TeamMemberIqSkillFlagsArray FromFile(string fileName)
        {
            return new TeamMemberIqSkillFlagsArray(new KaitaiStream(fileName));
        }

        public TeamMemberIqSkillFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberIqSkillFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberIqSkillFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberIqSkillFlagsArrayDim0 : KaitaiStruct
        {
            public static TeamMemberIqSkillFlagsArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberIqSkillFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberIqSkillFlagsArrayDim0(KaitaiStream p__io, TeamMemberIqSkillFlagsArray p__parent = null, TeamMemberIqSkillFlagsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private TeamMemberIqSkillFlagsArray m_root;
            private TeamMemberIqSkillFlagsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public TeamMemberIqSkillFlagsArray M_Root { get { return m_root; } }
            public TeamMemberIqSkillFlagsArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberIqSkillFlagsArrayDim0 _entries;
        private TeamMemberIqSkillFlagsArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberIqSkillFlagsArrayDim0 Entries { get { return _entries; } }
        public TeamMemberIqSkillFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
