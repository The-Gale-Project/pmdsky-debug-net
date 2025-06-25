// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array KECLEON_SHOP_ITEM_TABLE_LISTS_2 defined within pmdsky.
    /// </summary>
    public partial class KecleonShopItemTableLists2Array : KaitaiStruct
    {
        public static KecleonShopItemTableLists2Array FromFile(string fileName)
        {
            return new KecleonShopItemTableLists2Array(new KaitaiStream(fileName));
        }

        public KecleonShopItemTableLists2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, KecleonShopItemTableLists2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new KecleonShopItemTableLists2ArrayDim0(m_io, this, m_root);
        }
        public partial class KecleonShopItemTableLists2ArrayDim0 : KaitaiStruct
        {
            public static KecleonShopItemTableLists2ArrayDim0 FromFile(string fileName)
            {
                return new KecleonShopItemTableLists2ArrayDim0(new KaitaiStream(fileName));
            }

            public KecleonShopItemTableLists2ArrayDim0(KaitaiStream p__io, KecleonShopItemTableLists2Array p__parent = null, KecleonShopItemTableLists2Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new ItemId(m_io));
                }
            }
            private List<ItemId> _entries;
            private KecleonShopItemTableLists2Array m_root;
            private KecleonShopItemTableLists2Array m_parent;
            public List<ItemId> Entries { get { return _entries; } }
            public KecleonShopItemTableLists2Array M_Root { get { return m_root; } }
            public KecleonShopItemTableLists2Array M_Parent { get { return m_parent; } }
        }
        private KecleonShopItemTableLists2ArrayDim0 _entries;
        private KecleonShopItemTableLists2Array m_root;
        private KaitaiStruct m_parent;
        public KecleonShopItemTableLists2ArrayDim0 Entries { get { return _entries; } }
        public KecleonShopItemTableLists2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
