// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array team_member_name defined within pmdsky.
    /// </summary>
    public partial class TeamMemberNameArray : KaitaiStruct
    {
        public static TeamMemberNameArray FromFile(string fileName)
        {
            return new TeamMemberNameArray(new KaitaiStream(fileName));
        }

        public TeamMemberNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberNameArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberNameArrayDim0 : KaitaiStruct
        {
            public static TeamMemberNameArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberNameArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberNameArrayDim0(KaitaiStream p__io, TeamMemberNameArray p__parent = null, TeamMemberNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private TeamMemberNameArray m_root;
            private TeamMemberNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public TeamMemberNameArray M_Root { get { return m_root; } }
            public TeamMemberNameArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberNameArrayDim0 _entries;
        private TeamMemberNameArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberNameArrayDim0 Entries { get { return _entries; } }
        public TeamMemberNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
