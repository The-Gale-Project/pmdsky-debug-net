// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array BAR_AVAILABLE_ITEMS defined within pmdsky.
    /// </summary>
    public partial class BarAvailableItemsArray : KaitaiStruct
    {
        public static BarAvailableItemsArray FromFile(string fileName)
        {
            return new BarAvailableItemsArray(new KaitaiStream(fileName));
        }

        public BarAvailableItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BarAvailableItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarAvailableItemsArrayDim0(m_io, this, m_root);
        }
        public partial class BarAvailableItemsArrayDim0 : KaitaiStruct
        {
            public static BarAvailableItemsArrayDim0 FromFile(string fileName)
            {
                return new BarAvailableItemsArrayDim0(new KaitaiStream(fileName));
            }

            public BarAvailableItemsArrayDim0(KaitaiStream p__io, BarAvailableItemsArray p__parent = null, BarAvailableItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<BarItem>();
                for (var i = 0; i < 66; i++)
                {
                    _entries.Add(new BarItem(m_io));
                }
            }
            private List<BarItem> _entries;
            private BarAvailableItemsArray m_root;
            private BarAvailableItemsArray m_parent;
            public List<BarItem> Entries { get { return _entries; } }
            public BarAvailableItemsArray M_Root { get { return m_root; } }
            public BarAvailableItemsArray M_Parent { get { return m_parent; } }
        }
        private BarAvailableItemsArrayDim0 _entries;
        private BarAvailableItemsArray m_root;
        private KaitaiStruct m_parent;
        public BarAvailableItemsArrayDim0 Entries { get { return _entries; } }
        public BarAvailableItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
