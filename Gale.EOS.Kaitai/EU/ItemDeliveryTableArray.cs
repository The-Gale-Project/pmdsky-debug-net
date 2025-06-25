// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array ITEM_DELIVERY_TABLE defined within pmdsky.
    /// </summary>
    public partial class ItemDeliveryTableArray : KaitaiStruct
    {
        public static ItemDeliveryTableArray FromFile(string fileName)
        {
            return new ItemDeliveryTableArray(new KaitaiStream(fileName));
        }

        public ItemDeliveryTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ItemDeliveryTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ItemDeliveryTableArrayDim0(m_io, this, m_root);
        }
        public partial class ItemDeliveryTableArrayDim0 : KaitaiStruct
        {
            public static ItemDeliveryTableArrayDim0 FromFile(string fileName)
            {
                return new ItemDeliveryTableArrayDim0(new KaitaiStream(fileName));
            }

            public ItemDeliveryTableArrayDim0(KaitaiStream p__io, ItemDeliveryTableArray p__parent = null, ItemDeliveryTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 23; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private ItemDeliveryTableArray m_root;
            private ItemDeliveryTableArray m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public ItemDeliveryTableArray M_Root { get { return m_root; } }
            public ItemDeliveryTableArray M_Parent { get { return m_parent; } }
        }
        private ItemDeliveryTableArrayDim0 _entries;
        private ItemDeliveryTableArray m_root;
        private KaitaiStruct m_parent;
        public ItemDeliveryTableArrayDim0 Entries { get { return _entries; } }
        public ItemDeliveryTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
