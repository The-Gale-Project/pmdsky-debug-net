// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array KECLEON_SHOP_ITEMS defined within pmdsky.
    /// </summary>
    public partial class KecleonShopItemsArray : KaitaiStruct
    {
        public static KecleonShopItemsArray FromFile(string fileName)
        {
            return new KecleonShopItemsArray(new KaitaiStream(fileName));
        }

        public KecleonShopItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, KecleonShopItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new KecleonShopItemsArrayDim0(m_io, this, m_root);
        }
        public partial class KecleonShopItemsArrayDim0 : KaitaiStruct
        {
            public static KecleonShopItemsArrayDim0 FromFile(string fileName)
            {
                return new KecleonShopItemsArrayDim0(new KaitaiStream(fileName));
            }

            public KecleonShopItemsArrayDim0(KaitaiStream p__io, KecleonShopItemsArray p__parent = null, KecleonShopItemsArray p__root = null) : base(p__io)
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
            private KecleonShopItemsArray m_root;
            private KecleonShopItemsArray m_parent;
            public List<BulkItem> Entries { get { return _entries; } }
            public KecleonShopItemsArray M_Root { get { return m_root; } }
            public KecleonShopItemsArray M_Parent { get { return m_parent; } }
        }
        private KecleonShopItemsArrayDim0 _entries;
        private KecleonShopItemsArray m_root;
        private KaitaiStruct m_parent;
        public KecleonShopItemsArrayDim0 Entries { get { return _entries; } }
        public KecleonShopItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
