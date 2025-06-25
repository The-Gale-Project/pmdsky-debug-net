// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GROUND_MEMORY_ARENA_2_BLOCKS defined within pmdsky.
    /// </summary>
    public partial class GroundMemoryArena2BlocksArray : KaitaiStruct
    {
        public static GroundMemoryArena2BlocksArray FromFile(string fileName)
        {
            return new GroundMemoryArena2BlocksArray(new KaitaiStream(fileName));
        }

        public GroundMemoryArena2BlocksArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMemoryArena2BlocksArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMemoryArena2BlocksArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMemoryArena2BlocksArrayDim0 : KaitaiStruct
        {
            public static GroundMemoryArena2BlocksArrayDim0 FromFile(string fileName)
            {
                return new GroundMemoryArena2BlocksArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMemoryArena2BlocksArrayDim0(KaitaiStream p__io, GroundMemoryArena2BlocksArray p__parent = null, GroundMemoryArena2BlocksArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MemBlock>();
                for (var i = 0; i < 32; i++)
                {
                    _entries.Add(new MemBlock(m_io));
                }
            }
            private List<MemBlock> _entries;
            private GroundMemoryArena2BlocksArray m_root;
            private GroundMemoryArena2BlocksArray m_parent;
            public List<MemBlock> Entries { get { return _entries; } }
            public GroundMemoryArena2BlocksArray M_Root { get { return m_root; } }
            public GroundMemoryArena2BlocksArray M_Parent { get { return m_parent; } }
        }
        private GroundMemoryArena2BlocksArrayDim0 _entries;
        private GroundMemoryArena2BlocksArray m_root;
        private KaitaiStruct m_parent;
        public GroundMemoryArena2BlocksArrayDim0 Entries { get { return _entries; } }
        public GroundMemoryArena2BlocksArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
