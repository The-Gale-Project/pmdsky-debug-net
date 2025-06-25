// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array mem_alloc_table_arenas defined within pmdsky.
    /// </summary>
    public partial class MemAllocTableArenasArray : KaitaiStruct
    {
        public static MemAllocTableArenasArray FromFile(string fileName)
        {
            return new MemAllocTableArenasArray(new KaitaiStream(fileName));
        }

        public MemAllocTableArenasArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MemAllocTableArenasArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MemAllocTableArenasArrayDim0(m_io, this, m_root);
        }
        public partial class MemAllocTableArenasArrayDim0 : KaitaiStruct
        {
            public static MemAllocTableArenasArrayDim0 FromFile(string fileName)
            {
                return new MemAllocTableArenasArrayDim0(new KaitaiStream(fileName));
            }

            public MemAllocTableArenasArrayDim0(KaitaiStream p__io, MemAllocTableArenasArray p__parent = null, MemAllocTableArenasArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private MemAllocTableArenasArray m_root;
            private MemAllocTableArenasArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public MemAllocTableArenasArray M_Root { get { return m_root; } }
            public MemAllocTableArenasArray M_Parent { get { return m_parent; } }
        }
        private MemAllocTableArenasArrayDim0 _entries;
        private MemAllocTableArenasArray m_root;
        private KaitaiStruct m_parent;
        public MemAllocTableArenasArrayDim0 Entries { get { return _entries; } }
        public MemAllocTableArenasArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
