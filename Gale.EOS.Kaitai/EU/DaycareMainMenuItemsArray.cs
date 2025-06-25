// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array DAYCARE_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class DaycareMainMenuItemsArray : KaitaiStruct
    {
        public static DaycareMainMenuItemsArray FromFile(string fileName)
        {
            return new DaycareMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public DaycareMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DaycareMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DaycareMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class DaycareMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static DaycareMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new DaycareMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public DaycareMainMenuItemsArrayDim0(KaitaiStream p__io, DaycareMainMenuItemsArray p__parent = null, DaycareMainMenuItemsArray p__root = null) : base(p__io)
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
            private DaycareMainMenuItemsArray m_root;
            private DaycareMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DaycareMainMenuItemsArray M_Root { get { return m_root; } }
            public DaycareMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private DaycareMainMenuItemsArrayDim0 _entries;
        private DaycareMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public DaycareMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public DaycareMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
