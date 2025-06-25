// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array LINK_SHOP_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class LinkShopMenuItemsConfirmArray : KaitaiStruct
    {
        public static LinkShopMenuItemsConfirmArray FromFile(string fileName)
        {
            return new LinkShopMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public LinkShopMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LinkShopMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LinkShopMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class LinkShopMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static LinkShopMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new LinkShopMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public LinkShopMenuItemsConfirmArrayDim0(KaitaiStream p__io, LinkShopMenuItemsConfirmArray p__parent = null, LinkShopMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private LinkShopMenuItemsConfirmArray m_root;
            private LinkShopMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public LinkShopMenuItemsConfirmArray M_Root { get { return m_root; } }
            public LinkShopMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private LinkShopMenuItemsConfirmArrayDim0 _entries;
        private LinkShopMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public LinkShopMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public LinkShopMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
