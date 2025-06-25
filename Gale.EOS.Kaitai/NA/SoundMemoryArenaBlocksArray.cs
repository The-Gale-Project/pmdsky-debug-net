// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SOUND_MEMORY_ARENA_BLOCKS defined within pmdsky.
    /// </summary>
    public partial class SoundMemoryArenaBlocksArray : KaitaiStruct
    {
        public static SoundMemoryArenaBlocksArray FromFile(string fileName)
        {
            return new SoundMemoryArenaBlocksArray(new KaitaiStream(fileName));
        }

        public SoundMemoryArenaBlocksArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SoundMemoryArenaBlocksArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SoundMemoryArenaBlocksArrayDim0(m_io, this, m_root);
        }
        public partial class SoundMemoryArenaBlocksArrayDim0 : KaitaiStruct
        {
            public static SoundMemoryArenaBlocksArrayDim0 FromFile(string fileName)
            {
                return new SoundMemoryArenaBlocksArrayDim0(new KaitaiStream(fileName));
            }

            public SoundMemoryArenaBlocksArrayDim0(KaitaiStream p__io, SoundMemoryArenaBlocksArray p__parent = null, SoundMemoryArenaBlocksArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MemBlock>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(new MemBlock(m_io));
                }
            }
            private List<MemBlock> _entries;
            private SoundMemoryArenaBlocksArray m_root;
            private SoundMemoryArenaBlocksArray m_parent;
            public List<MemBlock> Entries { get { return _entries; } }
            public SoundMemoryArenaBlocksArray M_Root { get { return m_root; } }
            public SoundMemoryArenaBlocksArray M_Parent { get { return m_parent; } }
        }
        private SoundMemoryArenaBlocksArrayDim0 _entries;
        private SoundMemoryArenaBlocksArray m_root;
        private KaitaiStruct m_parent;
        public SoundMemoryArenaBlocksArrayDim0 Entries { get { return _entries; } }
        public SoundMemoryArenaBlocksArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
