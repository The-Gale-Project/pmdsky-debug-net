// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DEFAULT_MEMORY_ARENA_MEMORY defined within pmdsky.
    /// </summary>
    public partial class DefaultMemoryArenaMemoryArray : KaitaiStruct
    {
        public static DefaultMemoryArenaMemoryArray FromFile(string fileName)
        {
            return new DefaultMemoryArenaMemoryArray(new KaitaiStream(fileName));
        }

        public DefaultMemoryArenaMemoryArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DefaultMemoryArenaMemoryArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DefaultMemoryArenaMemoryArrayDim0(m_io, this, m_root);
        }
        public partial class DefaultMemoryArenaMemoryArrayDim0 : KaitaiStruct
        {
            public static DefaultMemoryArenaMemoryArrayDim0 FromFile(string fileName)
            {
                return new DefaultMemoryArenaMemoryArrayDim0(new KaitaiStream(fileName));
            }

            public DefaultMemoryArenaMemoryArrayDim0(KaitaiStream p__io, DefaultMemoryArenaMemoryArray p__parent = null, DefaultMemoryArenaMemoryArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 1991680; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private DefaultMemoryArenaMemoryArray m_root;
            private DefaultMemoryArenaMemoryArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public DefaultMemoryArenaMemoryArray M_Root { get { return m_root; } }
            public DefaultMemoryArenaMemoryArray M_Parent { get { return m_parent; } }
        }
        private DefaultMemoryArenaMemoryArrayDim0 _entries;
        private DefaultMemoryArenaMemoryArray m_root;
        private KaitaiStruct m_parent;
        public DefaultMemoryArenaMemoryArrayDim0 Entries { get { return _entries; } }
        public DefaultMemoryArenaMemoryArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
