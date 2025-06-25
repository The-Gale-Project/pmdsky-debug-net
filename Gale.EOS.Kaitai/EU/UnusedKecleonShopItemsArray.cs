// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array UNUSED_KECLEON_SHOP_ITEMS defined within pmdsky.
    /// </summary>
    public partial class UnusedKecleonShopItemsArray : KaitaiStruct
    {
        public static UnusedKecleonShopItemsArray FromFile(string fileName)
        {
            return new UnusedKecleonShopItemsArray(new KaitaiStream(fileName));
        }

        public UnusedKecleonShopItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, UnusedKecleonShopItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new UnusedKecleonShopItemsArrayDim0(m_io, this, m_root);
        }
        public partial class UnusedKecleonShopItemsArrayDim0 : KaitaiStruct
        {
            public static UnusedKecleonShopItemsArrayDim0 FromFile(string fileName)
            {
                return new UnusedKecleonShopItemsArrayDim0(new KaitaiStream(fileName));
            }

            public UnusedKecleonShopItemsArrayDim0(KaitaiStream p__io, UnusedKecleonShopItemsArray p__parent = null, UnusedKecleonShopItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<BulkItem>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new BulkItem(m_io));
                }
            }
            private List<BulkItem> _entries;
            private UnusedKecleonShopItemsArray m_root;
            private UnusedKecleonShopItemsArray m_parent;
            public List<BulkItem> Entries { get { return _entries; } }
            public UnusedKecleonShopItemsArray M_Root { get { return m_root; } }
            public UnusedKecleonShopItemsArray M_Parent { get { return m_parent; } }
        }
        private UnusedKecleonShopItemsArrayDim0 _entries;
        private UnusedKecleonShopItemsArray m_root;
        private KaitaiStruct m_parent;
        public UnusedKecleonShopItemsArrayDim0 Entries { get { return _entries; } }
        public UnusedKecleonShopItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
