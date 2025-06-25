// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array ITEM_CATEGORY_ACTIONS defined within pmdsky.
    /// </summary>
    public partial class ItemCategoryActionsArray : KaitaiStruct
    {
        public static ItemCategoryActionsArray FromFile(string fileName)
        {
            return new ItemCategoryActionsArray(new KaitaiStream(fileName));
        }

        public ItemCategoryActionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ItemCategoryActionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ItemCategoryActionsArrayDim0(m_io, this, m_root);
        }
        public partial class ItemCategoryActionsArrayDim0 : KaitaiStruct
        {
            public static ItemCategoryActionsArrayDim0 FromFile(string fileName)
            {
                return new ItemCategoryActionsArrayDim0(new KaitaiStream(fileName));
            }

            public ItemCategoryActionsArrayDim0(KaitaiStream p__io, ItemCategoryActionsArray p__parent = null, ItemCategoryActionsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Action16>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new Action16(m_io));
                }
            }
            private List<Action16> _entries;
            private ItemCategoryActionsArray m_root;
            private ItemCategoryActionsArray m_parent;
            public List<Action16> Entries { get { return _entries; } }
            public ItemCategoryActionsArray M_Root { get { return m_root; } }
            public ItemCategoryActionsArray M_Parent { get { return m_parent; } }
        }
        private ItemCategoryActionsArrayDim0 _entries;
        private ItemCategoryActionsArray m_root;
        private KaitaiStruct m_parent;
        public ItemCategoryActionsArrayDim0 Entries { get { return _entries; } }
        public ItemCategoryActionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
