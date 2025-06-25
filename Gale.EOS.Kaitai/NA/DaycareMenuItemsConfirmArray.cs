// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array DAYCARE_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class DaycareMenuItemsConfirmArray : KaitaiStruct
    {
        public static DaycareMenuItemsConfirmArray FromFile(string fileName)
        {
            return new DaycareMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public DaycareMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DaycareMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DaycareMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class DaycareMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static DaycareMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new DaycareMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public DaycareMenuItemsConfirmArrayDim0(KaitaiStream p__io, DaycareMenuItemsConfirmArray p__parent = null, DaycareMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private DaycareMenuItemsConfirmArray m_root;
            private DaycareMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public DaycareMenuItemsConfirmArray M_Root { get { return m_root; } }
            public DaycareMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private DaycareMenuItemsConfirmArrayDim0 _entries;
        private DaycareMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public DaycareMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public DaycareMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
