// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array LINK_SHOP_SUBMENU_ITEMS_7 defined within pmdsky.
    /// </summary>
    public partial class LinkShopSubmenuItems7Array : KaitaiStruct
    {
        public static LinkShopSubmenuItems7Array FromFile(string fileName)
        {
            return new LinkShopSubmenuItems7Array(new KaitaiStream(fileName));
        }

        public LinkShopSubmenuItems7Array(KaitaiStream p__io, KaitaiStruct p__parent = null, LinkShopSubmenuItems7Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new LinkShopSubmenuItems7ArrayDim0(m_io, this, m_root);
        }
        public partial class LinkShopSubmenuItems7ArrayDim0 : KaitaiStruct
        {
            public static LinkShopSubmenuItems7ArrayDim0 FromFile(string fileName)
            {
                return new LinkShopSubmenuItems7ArrayDim0(new KaitaiStream(fileName));
            }

            public LinkShopSubmenuItems7ArrayDim0(KaitaiStream p__io, LinkShopSubmenuItems7Array p__parent = null, LinkShopSubmenuItems7Array p__root = null) : base(p__io)
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
            private LinkShopSubmenuItems7Array m_root;
            private LinkShopSubmenuItems7Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public LinkShopSubmenuItems7Array M_Root { get { return m_root; } }
            public LinkShopSubmenuItems7Array M_Parent { get { return m_parent; } }
        }
        private LinkShopSubmenuItems7ArrayDim0 _entries;
        private LinkShopSubmenuItems7Array m_root;
        private KaitaiStruct m_parent;
        public LinkShopSubmenuItems7ArrayDim0 Entries { get { return _entries; } }
        public LinkShopSubmenuItems7Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
