// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array GROUND_MEMORY_ARENA_1_MEMORY defined within pmdsky.
    /// </summary>
    public partial class GroundMemoryArena1MemoryArray : KaitaiStruct
    {
        public static GroundMemoryArena1MemoryArray FromFile(string fileName)
        {
            return new GroundMemoryArena1MemoryArray(new KaitaiStream(fileName));
        }

        public GroundMemoryArena1MemoryArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMemoryArena1MemoryArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMemoryArena1MemoryArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMemoryArena1MemoryArrayDim0 : KaitaiStruct
        {
            public static GroundMemoryArena1MemoryArrayDim0 FromFile(string fileName)
            {
                return new GroundMemoryArena1MemoryArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMemoryArena1MemoryArrayDim0(KaitaiStream p__io, GroundMemoryArena1MemoryArray p__parent = null, GroundMemoryArena1MemoryArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 408324; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private GroundMemoryArena1MemoryArray m_root;
            private GroundMemoryArena1MemoryArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public GroundMemoryArena1MemoryArray M_Root { get { return m_root; } }
            public GroundMemoryArena1MemoryArray M_Parent { get { return m_parent; } }
        }
        private GroundMemoryArena1MemoryArrayDim0 _entries;
        private GroundMemoryArena1MemoryArray m_root;
        private KaitaiStruct m_parent;
        public GroundMemoryArena1MemoryArrayDim0 Entries { get { return _entries; } }
        public GroundMemoryArena1MemoryArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
