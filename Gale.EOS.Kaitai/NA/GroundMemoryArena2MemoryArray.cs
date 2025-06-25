// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GROUND_MEMORY_ARENA_2_MEMORY defined within pmdsky.
    /// </summary>
    public partial class GroundMemoryArena2MemoryArray : KaitaiStruct
    {
        public static GroundMemoryArena2MemoryArray FromFile(string fileName)
        {
            return new GroundMemoryArena2MemoryArray(new KaitaiStream(fileName));
        }

        public GroundMemoryArena2MemoryArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMemoryArena2MemoryArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMemoryArena2MemoryArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMemoryArena2MemoryArrayDim0 : KaitaiStruct
        {
            public static GroundMemoryArena2MemoryArrayDim0 FromFile(string fileName)
            {
                return new GroundMemoryArena2MemoryArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMemoryArena2MemoryArrayDim0(KaitaiStream p__io, GroundMemoryArena2MemoryArray p__parent = null, GroundMemoryArena2MemoryArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 720100; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private GroundMemoryArena2MemoryArray m_root;
            private GroundMemoryArena2MemoryArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public GroundMemoryArena2MemoryArray M_Root { get { return m_root; } }
            public GroundMemoryArena2MemoryArray M_Parent { get { return m_parent; } }
        }
        private GroundMemoryArena2MemoryArrayDim0 _entries;
        private GroundMemoryArena2MemoryArray m_root;
        private KaitaiStruct m_parent;
        public GroundMemoryArena2MemoryArrayDim0 Entries { get { return _entries; } }
        public GroundMemoryArena2MemoryArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
