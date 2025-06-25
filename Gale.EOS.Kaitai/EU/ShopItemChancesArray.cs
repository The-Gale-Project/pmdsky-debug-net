// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SHOP_ITEM_CHANCES defined within pmdsky.
    /// </summary>
    public partial class ShopItemChancesArray : KaitaiStruct
    {
        public static ShopItemChancesArray FromFile(string fileName)
        {
            return new ShopItemChancesArray(new KaitaiStream(fileName));
        }

        public ShopItemChancesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ShopItemChancesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ShopItemChancesArrayDim0(m_io, this, m_root);
        }
        public partial class ShopItemChancesArrayDim0 : KaitaiStruct
        {
            public static ShopItemChancesArrayDim0 FromFile(string fileName)
            {
                return new ShopItemChancesArrayDim0(new KaitaiStream(fileName));
            }

            public ShopItemChancesArrayDim0(KaitaiStream p__io, ShopItemChancesArray p__parent = null, ShopItemChancesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 144; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private ShopItemChancesArray m_root;
            private ShopItemChancesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public ShopItemChancesArray M_Root { get { return m_root; } }
            public ShopItemChancesArray M_Parent { get { return m_parent; } }
        }
        private ShopItemChancesArrayDim0 _entries;
        private ShopItemChancesArray m_root;
        private KaitaiStruct m_parent;
        public ShopItemChancesArrayDim0 Entries { get { return _entries; } }
        public ShopItemChancesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
