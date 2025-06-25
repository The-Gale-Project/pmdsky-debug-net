// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array LINK_SHOP_SUBMENU_ITEMS_4 defined within pmdsky.
    /// </summary>
    public partial class LinkShopSubmenuItems4Array : KaitaiStruct
    {
        public static LinkShopSubmenuItems4Array FromFile(string fileName)
        {
            return new LinkShopSubmenuItems4Array(new KaitaiStream(fileName));
        }

        public LinkShopSubmenuItems4Array(KaitaiStream p__io, KaitaiStruct p__parent = null, LinkShopSubmenuItems4Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LinkShopSubmenuItems4ArrayDim0(m_io, this, m_root);
        }
        public partial class LinkShopSubmenuItems4ArrayDim0 : KaitaiStruct
        {
            public static LinkShopSubmenuItems4ArrayDim0 FromFile(string fileName)
            {
                return new LinkShopSubmenuItems4ArrayDim0(new KaitaiStream(fileName));
            }

            public LinkShopSubmenuItems4ArrayDim0(KaitaiStream p__io, LinkShopSubmenuItems4Array p__parent = null, LinkShopSubmenuItems4Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 6; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private LinkShopSubmenuItems4Array m_root;
            private LinkShopSubmenuItems4Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public LinkShopSubmenuItems4Array M_Root { get { return m_root; } }
            public LinkShopSubmenuItems4Array M_Parent { get { return m_parent; } }
        }
        private LinkShopSubmenuItems4ArrayDim0 _entries;
        private LinkShopSubmenuItems4Array m_root;
        private KaitaiStruct m_parent;
        public LinkShopSubmenuItems4ArrayDim0 Entries { get { return _entries; } }
        public LinkShopSubmenuItems4Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
