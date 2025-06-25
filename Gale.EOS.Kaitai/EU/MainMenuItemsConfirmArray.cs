// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MAIN_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class MainMenuItemsConfirmArray : KaitaiStruct
    {
        public static MainMenuItemsConfirmArray FromFile(string fileName)
        {
            return new MainMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public MainMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MainMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MainMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class MainMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static MainMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new MainMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public MainMenuItemsConfirmArrayDim0(KaitaiStream p__io, MainMenuItemsConfirmArray p__parent = null, MainMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private MainMenuItemsConfirmArray m_root;
            private MainMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public MainMenuItemsConfirmArray M_Root { get { return m_root; } }
            public MainMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private MainMenuItemsConfirmArrayDim0 _entries;
        private MainMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public MainMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public MainMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
