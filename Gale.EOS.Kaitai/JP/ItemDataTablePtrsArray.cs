// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array ITEM_DATA_TABLE_PTRS defined within pmdsky.
    /// </summary>
    public partial class ItemDataTablePtrsArray : KaitaiStruct
    {
        public static ItemDataTablePtrsArray FromFile(string fileName)
        {
            return new ItemDataTablePtrsArray(new KaitaiStream(fileName));
        }

        public ItemDataTablePtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ItemDataTablePtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ItemDataTablePtrsArrayDim0(m_io, this, m_root);
        }
        public partial class ItemDataTablePtrsArrayDim0 : KaitaiStruct
        {
            public static ItemDataTablePtrsArrayDim0 FromFile(string fileName)
            {
                return new ItemDataTablePtrsArrayDim0(new KaitaiStream(fileName));
            }

            public ItemDataTablePtrsArrayDim0(KaitaiStream p__io, ItemDataTablePtrsArray p__parent = null, ItemDataTablePtrsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private ItemDataTablePtrsArray m_root;
            private ItemDataTablePtrsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public ItemDataTablePtrsArray M_Root { get { return m_root; } }
            public ItemDataTablePtrsArray M_Parent { get { return m_parent; } }
        }
        private ItemDataTablePtrsArrayDim0 _entries;
        private ItemDataTablePtrsArray m_root;
        private KaitaiStruct m_parent;
        public ItemDataTablePtrsArrayDim0 Entries { get { return _entries; } }
        public ItemDataTablePtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
