// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GROUND_MEMORY_ARENA_1_BLOCKS defined within pmdsky.
    /// </summary>
    public partial class GroundMemoryArena1BlocksArray : KaitaiStruct
    {
        public static GroundMemoryArena1BlocksArray FromFile(string fileName)
        {
            return new GroundMemoryArena1BlocksArray(new KaitaiStream(fileName));
        }

        public GroundMemoryArena1BlocksArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMemoryArena1BlocksArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMemoryArena1BlocksArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMemoryArena1BlocksArrayDim0 : KaitaiStruct
        {
            public static GroundMemoryArena1BlocksArrayDim0 FromFile(string fileName)
            {
                return new GroundMemoryArena1BlocksArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMemoryArena1BlocksArrayDim0(KaitaiStream p__io, GroundMemoryArena1BlocksArray p__parent = null, GroundMemoryArena1BlocksArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MemBlock>();
                for (var i = 0; i < 52; i++)
                {
                    _entries.Add(new MemBlock(m_io));
                }
            }
            private List<MemBlock> _entries;
            private GroundMemoryArena1BlocksArray m_root;
            private GroundMemoryArena1BlocksArray m_parent;
            public List<MemBlock> Entries { get { return _entries; } }
            public GroundMemoryArena1BlocksArray M_Root { get { return m_root; } }
            public GroundMemoryArena1BlocksArray M_Parent { get { return m_parent; } }
        }
        private GroundMemoryArena1BlocksArrayDim0 _entries;
        private GroundMemoryArena1BlocksArray m_root;
        private KaitaiStruct m_parent;
        public GroundMemoryArena1BlocksArrayDim0 Entries { get { return _entries; } }
        public GroundMemoryArena1BlocksArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
