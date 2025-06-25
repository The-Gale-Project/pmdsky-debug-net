// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array TEAM_NAME defined within pmdsky.
    /// </summary>
    public partial class TeamNameArray : KaitaiStruct
    {
        public static TeamNameArray FromFile(string fileName)
        {
            return new TeamNameArray(new KaitaiStream(fileName));
        }

        public TeamNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TeamNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TeamNameArrayDim0(m_io, this, m_root);
        }
        public partial class TeamNameArrayDim0 : KaitaiStruct
        {
            public static TeamNameArrayDim0 FromFile(string fileName)
            {
                return new TeamNameArrayDim0(new KaitaiStream(fileName));
            }

            public TeamNameArrayDim0(KaitaiStream p__io, TeamNameArray p__parent = null, TeamNameArray p__root = null) : base(p__io)
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
            private TeamNameArray m_root;
            private TeamNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public TeamNameArray M_Root { get { return m_root; } }
            public TeamNameArray M_Parent { get { return m_parent; } }
        }
        private TeamNameArrayDim0 _entries;
        private TeamNameArray m_root;
        private KaitaiStruct m_parent;
        public TeamNameArrayDim0 Entries { get { return _entries; } }
        public TeamNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
