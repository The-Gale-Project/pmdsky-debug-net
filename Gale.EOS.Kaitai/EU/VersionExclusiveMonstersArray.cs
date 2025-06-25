// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array VERSION_EXCLUSIVE_MONSTERS defined within pmdsky.
    /// </summary>
    public partial class VersionExclusiveMonstersArray : KaitaiStruct
    {
        public static VersionExclusiveMonstersArray FromFile(string fileName)
        {
            return new VersionExclusiveMonstersArray(new KaitaiStream(fileName));
        }

        public VersionExclusiveMonstersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, VersionExclusiveMonstersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new VersionExclusiveMonstersArrayDim0(m_io, this, m_root);
        }
        public partial class VersionExclusiveMonstersArrayDim0 : KaitaiStruct
        {
            public static VersionExclusiveMonstersArrayDim0 FromFile(string fileName)
            {
                return new VersionExclusiveMonstersArrayDim0(new KaitaiStream(fileName));
            }

            public VersionExclusiveMonstersArrayDim0(KaitaiStream p__io, VersionExclusiveMonstersArray p__parent = null, VersionExclusiveMonstersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<VersionExclusiveMonster>();
                for (var i = 0; i < 23; i++)
                {
                    _entries.Add(new VersionExclusiveMonster(m_io));
                }
            }
            private List<VersionExclusiveMonster> _entries;
            private VersionExclusiveMonstersArray m_root;
            private VersionExclusiveMonstersArray m_parent;
            public List<VersionExclusiveMonster> Entries { get { return _entries; } }
            public VersionExclusiveMonstersArray M_Root { get { return m_root; } }
            public VersionExclusiveMonstersArray M_Parent { get { return m_parent; } }
        }
        private VersionExclusiveMonstersArrayDim0 _entries;
        private VersionExclusiveMonstersArray m_root;
        private KaitaiStruct m_parent;
        public VersionExclusiveMonstersArrayDim0 Entries { get { return _entries; } }
        public VersionExclusiveMonstersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
