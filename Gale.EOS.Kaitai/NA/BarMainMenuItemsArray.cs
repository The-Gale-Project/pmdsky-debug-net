// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array BAR_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class BarMainMenuItemsArray : KaitaiStruct
    {
        public static BarMainMenuItemsArray FromFile(string fileName)
        {
            return new BarMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public BarMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BarMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class BarMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static BarMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new BarMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public BarMainMenuItemsArrayDim0(KaitaiStream p__io, BarMainMenuItemsArray p__parent = null, BarMainMenuItemsArray p__root = null) : base(p__io)
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
            private BarMainMenuItemsArray m_root;
            private BarMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public BarMainMenuItemsArray M_Root { get { return m_root; } }
            public BarMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private BarMainMenuItemsArrayDim0 _entries;
        private BarMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public BarMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public BarMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
