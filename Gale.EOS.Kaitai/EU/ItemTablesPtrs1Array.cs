// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ITEM_TABLES_PTRS_1 defined within pmdsky.
    /// </summary>
    public partial class ItemTablesPtrs1Array : KaitaiStruct
    {
        public static ItemTablesPtrs1Array FromFile(string fileName)
        {
            return new ItemTablesPtrs1Array(new KaitaiStream(fileName));
        }

        public ItemTablesPtrs1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, ItemTablesPtrs1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ItemTablesPtrs1ArrayDim0(m_io, this, m_root);
        }
        public partial class ItemTablesPtrs1ArrayDim0 : KaitaiStruct
        {
            public static ItemTablesPtrs1ArrayDim0 FromFile(string fileName)
            {
                return new ItemTablesPtrs1ArrayDim0(new KaitaiStream(fileName));
            }

            public ItemTablesPtrs1ArrayDim0(KaitaiStream p__io, ItemTablesPtrs1Array p__parent = null, ItemTablesPtrs1Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 26; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private ItemTablesPtrs1Array m_root;
            private ItemTablesPtrs1Array m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public ItemTablesPtrs1Array M_Root { get { return m_root; } }
            public ItemTablesPtrs1Array M_Parent { get { return m_parent; } }
        }
        private ItemTablesPtrs1ArrayDim0 _entries;
        private ItemTablesPtrs1Array m_root;
        private KaitaiStruct m_parent;
        public ItemTablesPtrs1ArrayDim0 Entries { get { return _entries; } }
        public ItemTablesPtrs1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
