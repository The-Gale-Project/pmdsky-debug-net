// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array LINK_SHOP_SUBMENU_ITEMS_6 defined within pmdsky.
    /// </summary>
    public partial class LinkShopSubmenuItems6Array : KaitaiStruct
    {
        public static LinkShopSubmenuItems6Array FromFile(string fileName)
        {
            return new LinkShopSubmenuItems6Array(new KaitaiStream(fileName));
        }

        public LinkShopSubmenuItems6Array(KaitaiStream p__io, KaitaiStruct p__parent = null, LinkShopSubmenuItems6Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LinkShopSubmenuItems6ArrayDim0(m_io, this, m_root);
        }
        public partial class LinkShopSubmenuItems6ArrayDim0 : KaitaiStruct
        {
            public static LinkShopSubmenuItems6ArrayDim0 FromFile(string fileName)
            {
                return new LinkShopSubmenuItems6ArrayDim0(new KaitaiStream(fileName));
            }

            public LinkShopSubmenuItems6ArrayDim0(KaitaiStream p__io, LinkShopSubmenuItems6Array p__parent = null, LinkShopSubmenuItems6Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private LinkShopSubmenuItems6Array m_root;
            private LinkShopSubmenuItems6Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public LinkShopSubmenuItems6Array M_Root { get { return m_root; } }
            public LinkShopSubmenuItems6Array M_Parent { get { return m_parent; } }
        }
        private LinkShopSubmenuItems6ArrayDim0 _entries;
        private LinkShopSubmenuItems6Array m_root;
        private KaitaiStruct m_parent;
        public LinkShopSubmenuItems6ArrayDim0 Entries { get { return _entries; } }
        public LinkShopSubmenuItems6Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
