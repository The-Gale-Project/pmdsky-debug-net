// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array START_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class StartMenuItemsConfirmArray : KaitaiStruct
    {
        public static StartMenuItemsConfirmArray FromFile(string fileName)
        {
            return new StartMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public StartMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StartMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StartMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class StartMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static StartMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new StartMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public StartMenuItemsConfirmArrayDim0(KaitaiStream p__io, StartMenuItemsConfirmArray p__parent = null, StartMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private StartMenuItemsConfirmArray m_root;
            private StartMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public StartMenuItemsConfirmArray M_Root { get { return m_root; } }
            public StartMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private StartMenuItemsConfirmArrayDim0 _entries;
        private StartMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public StartMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public StartMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
