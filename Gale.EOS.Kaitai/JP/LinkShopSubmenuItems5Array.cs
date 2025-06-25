// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array LINK_SHOP_SUBMENU_ITEMS_5 defined within pmdsky.
    /// </summary>
    public partial class LinkShopSubmenuItems5Array : KaitaiStruct
    {
        public static LinkShopSubmenuItems5Array FromFile(string fileName)
        {
            return new LinkShopSubmenuItems5Array(new KaitaiStream(fileName));
        }

        public LinkShopSubmenuItems5Array(KaitaiStream p__io, KaitaiStruct p__parent = null, LinkShopSubmenuItems5Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LinkShopSubmenuItems5ArrayDim0(m_io, this, m_root);
        }
        public partial class LinkShopSubmenuItems5ArrayDim0 : KaitaiStruct
        {
            public static LinkShopSubmenuItems5ArrayDim0 FromFile(string fileName)
            {
                return new LinkShopSubmenuItems5ArrayDim0(new KaitaiStream(fileName));
            }

            public LinkShopSubmenuItems5ArrayDim0(KaitaiStream p__io, LinkShopSubmenuItems5Array p__parent = null, LinkShopSubmenuItems5Array p__root = null) : base(p__io)
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
            private LinkShopSubmenuItems5Array m_root;
            private LinkShopSubmenuItems5Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public LinkShopSubmenuItems5Array M_Root { get { return m_root; } }
            public LinkShopSubmenuItems5Array M_Parent { get { return m_parent; } }
        }
        private LinkShopSubmenuItems5ArrayDim0 _entries;
        private LinkShopSubmenuItems5Array m_root;
        private KaitaiStruct m_parent;
        public LinkShopSubmenuItems5ArrayDim0 Entries { get { return _entries; } }
        public LinkShopSubmenuItems5Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
