// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array LINK_SHOP_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class LinkShopMainMenuItemsArray : KaitaiStruct
    {
        public static LinkShopMainMenuItemsArray FromFile(string fileName)
        {
            return new LinkShopMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public LinkShopMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, LinkShopMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LinkShopMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class LinkShopMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static LinkShopMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new LinkShopMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public LinkShopMainMenuItemsArrayDim0(KaitaiStream p__io, LinkShopMainMenuItemsArray p__parent = null, LinkShopMainMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private LinkShopMainMenuItemsArray m_root;
            private LinkShopMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public LinkShopMainMenuItemsArray M_Root { get { return m_root; } }
            public LinkShopMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private LinkShopMainMenuItemsArrayDim0 _entries;
        private LinkShopMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public LinkShopMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public LinkShopMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
