// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DEFAULT_MEMORY_ARENA_BLOCKS defined within pmdsky.
    /// </summary>
    public partial class DefaultMemoryArenaBlocksArray : KaitaiStruct
    {
        public static DefaultMemoryArenaBlocksArray FromFile(string fileName)
        {
            return new DefaultMemoryArenaBlocksArray(new KaitaiStream(fileName));
        }

        public DefaultMemoryArenaBlocksArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DefaultMemoryArenaBlocksArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DefaultMemoryArenaBlocksArrayDim0(m_io, this, m_root);
        }
        public partial class DefaultMemoryArenaBlocksArrayDim0 : KaitaiStruct
        {
            public static DefaultMemoryArenaBlocksArrayDim0 FromFile(string fileName)
            {
                return new DefaultMemoryArenaBlocksArrayDim0(new KaitaiStream(fileName));
            }

            public DefaultMemoryArenaBlocksArrayDim0(KaitaiStream p__io, DefaultMemoryArenaBlocksArray p__parent = null, DefaultMemoryArenaBlocksArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MemBlock>();
                for (var i = 0; i < 256; i++)
                {
                    _entries.Add(new MemBlock(m_io));
                }
            }
            private List<MemBlock> _entries;
            private DefaultMemoryArenaBlocksArray m_root;
            private DefaultMemoryArenaBlocksArray m_parent;
            public List<MemBlock> Entries { get { return _entries; } }
            public DefaultMemoryArenaBlocksArray M_Root { get { return m_root; } }
            public DefaultMemoryArenaBlocksArray M_Parent { get { return m_parent; } }
        }
        private DefaultMemoryArenaBlocksArrayDim0 _entries;
        private DefaultMemoryArenaBlocksArray m_root;
        private KaitaiStruct m_parent;
        public DefaultMemoryArenaBlocksArrayDim0 Entries { get { return _entries; } }
        public DefaultMemoryArenaBlocksArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
