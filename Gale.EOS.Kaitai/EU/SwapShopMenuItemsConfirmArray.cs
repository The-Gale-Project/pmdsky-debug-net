// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SWAP_SHOP_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class SwapShopMenuItemsConfirmArray : KaitaiStruct
    {
        public static SwapShopMenuItemsConfirmArray FromFile(string fileName)
        {
            return new SwapShopMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public SwapShopMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SwapShopMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SwapShopMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class SwapShopMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static SwapShopMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new SwapShopMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public SwapShopMenuItemsConfirmArrayDim0(KaitaiStream p__io, SwapShopMenuItemsConfirmArray p__parent = null, SwapShopMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private SwapShopMenuItemsConfirmArray m_root;
            private SwapShopMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public SwapShopMenuItemsConfirmArray M_Root { get { return m_root; } }
            public SwapShopMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private SwapShopMenuItemsConfirmArrayDim0 _entries;
        private SwapShopMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public SwapShopMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public SwapShopMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
