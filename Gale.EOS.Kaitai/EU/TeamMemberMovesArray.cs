// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array team_member_moves defined within pmdsky.
    /// </summary>
    public partial class TeamMemberMovesArray : KaitaiStruct
    {
        public static TeamMemberMovesArray FromFile(string fileName)
        {
            return new TeamMemberMovesArray(new KaitaiStream(fileName));
        }

        public TeamMemberMovesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamMemberMovesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamMemberMovesArrayDim0(m_io, this, m_root);
        }
        public partial class TeamMemberMovesArrayDim0 : KaitaiStruct
        {
            public static TeamMemberMovesArrayDim0 FromFile(string fileName)
            {
                return new TeamMemberMovesArrayDim0(new KaitaiStream(fileName));
            }

            public TeamMemberMovesArrayDim0(KaitaiStream p__io, TeamMemberMovesArray p__parent = null, TeamMemberMovesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Move>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Move(m_io));
                }
            }
            private List<Move> _entries;
            private TeamMemberMovesArray m_root;
            private TeamMemberMovesArray m_parent;
            public List<Move> Entries { get { return _entries; } }
            public TeamMemberMovesArray M_Root { get { return m_root; } }
            public TeamMemberMovesArray M_Parent { get { return m_parent; } }
        }
        private TeamMemberMovesArrayDim0 _entries;
        private TeamMemberMovesArray m_root;
        private KaitaiStruct m_parent;
        public TeamMemberMovesArrayDim0 Entries { get { return _entries; } }
        public TeamMemberMovesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
