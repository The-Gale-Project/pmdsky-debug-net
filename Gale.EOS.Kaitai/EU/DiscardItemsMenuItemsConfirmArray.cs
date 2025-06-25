// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DISCARD_ITEMS_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class DiscardItemsMenuItemsConfirmArray : KaitaiStruct
    {
        public static DiscardItemsMenuItemsConfirmArray FromFile(string fileName)
        {
            return new DiscardItemsMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public DiscardItemsMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DiscardItemsMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DiscardItemsMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class DiscardItemsMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static DiscardItemsMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new DiscardItemsMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public DiscardItemsMenuItemsConfirmArrayDim0(KaitaiStream p__io, DiscardItemsMenuItemsConfirmArray p__parent = null, DiscardItemsMenuItemsConfirmArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private DiscardItemsMenuItemsConfirmArray m_root;
            private DiscardItemsMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DiscardItemsMenuItemsConfirmArray M_Root { get { return m_root; } }
            public DiscardItemsMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private DiscardItemsMenuItemsConfirmArrayDim0 _entries;
        private DiscardItemsMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public DiscardItemsMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public DiscardItemsMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
