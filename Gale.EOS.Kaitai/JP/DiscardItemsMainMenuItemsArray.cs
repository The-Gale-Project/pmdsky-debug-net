// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array DISCARD_ITEMS_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class DiscardItemsMainMenuItemsArray : KaitaiStruct
    {
        public static DiscardItemsMainMenuItemsArray FromFile(string fileName)
        {
            return new DiscardItemsMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public DiscardItemsMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DiscardItemsMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DiscardItemsMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class DiscardItemsMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static DiscardItemsMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new DiscardItemsMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public DiscardItemsMainMenuItemsArrayDim0(KaitaiStream p__io, DiscardItemsMainMenuItemsArray p__parent = null, DiscardItemsMainMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private DiscardItemsMainMenuItemsArray m_root;
            private DiscardItemsMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DiscardItemsMainMenuItemsArray M_Root { get { return m_root; } }
            public DiscardItemsMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private DiscardItemsMainMenuItemsArrayDim0 _entries;
        private DiscardItemsMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public DiscardItemsMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public DiscardItemsMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
