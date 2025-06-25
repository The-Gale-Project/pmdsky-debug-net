// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array BAG_ITEMS defined within pmdsky.
    /// </summary>
    public partial class BagItemsArray : KaitaiStruct
    {
        public static BagItemsArray FromFile(string fileName)
        {
            return new BagItemsArray(new KaitaiStream(fileName));
        }

        public BagItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BagItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BagItemsArrayDim0(m_io, this, m_root);
        }
        public partial class BagItemsArrayDim0 : KaitaiStruct
        {
            public static BagItemsArrayDim0 FromFile(string fileName)
            {
                return new BagItemsArrayDim0(new KaitaiStream(fileName));
            }

            public BagItemsArrayDim0(KaitaiStream p__io, BagItemsArray p__parent = null, BagItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Item>();
                for (var i = 0; i < 50; i++)
                {
                    _entries.Add(new Item(m_io));
                }
            }
            private List<Item> _entries;
            private BagItemsArray m_root;
            private BagItemsArray m_parent;
            public List<Item> Entries { get { return _entries; } }
            public BagItemsArray M_Root { get { return m_root; } }
            public BagItemsArray M_Parent { get { return m_parent; } }
        }
        private BagItemsArrayDim0 _entries;
        private BagItemsArray m_root;
        private KaitaiStruct m_parent;
        public BagItemsArrayDim0 Entries { get { return _entries; } }
        public BagItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
