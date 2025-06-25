// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array SHOP_MAIN_MENU_ITEMS_2 defined within pmdsky.
    /// </summary>
    public partial class ShopMainMenuItems2Array : KaitaiStruct
    {
        public static ShopMainMenuItems2Array FromFile(string fileName)
        {
            return new ShopMainMenuItems2Array(new KaitaiStream(fileName));
        }

        public ShopMainMenuItems2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, ShopMainMenuItems2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ShopMainMenuItems2ArrayDim0(m_io, this, m_root);
        }
        public partial class ShopMainMenuItems2ArrayDim0 : KaitaiStruct
        {
            public static ShopMainMenuItems2ArrayDim0 FromFile(string fileName)
            {
                return new ShopMainMenuItems2ArrayDim0(new KaitaiStream(fileName));
            }

            public ShopMainMenuItems2ArrayDim0(KaitaiStream p__io, ShopMainMenuItems2Array p__parent = null, ShopMainMenuItems2Array p__root = null) : base(p__io)
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
            private ShopMainMenuItems2Array m_root;
            private ShopMainMenuItems2Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public ShopMainMenuItems2Array M_Root { get { return m_root; } }
            public ShopMainMenuItems2Array M_Parent { get { return m_parent; } }
        }
        private ShopMainMenuItems2ArrayDim0 _entries;
        private ShopMainMenuItems2Array m_root;
        private KaitaiStruct m_parent;
        public ShopMainMenuItems2ArrayDim0 Entries { get { return _entries; } }
        public ShopMainMenuItems2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
