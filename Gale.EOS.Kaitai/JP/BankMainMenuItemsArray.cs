// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array BANK_MAIN_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class BankMainMenuItemsArray : KaitaiStruct
    {
        public static BankMainMenuItemsArray FromFile(string fileName)
        {
            return new BankMainMenuItemsArray(new KaitaiStream(fileName));
        }

        public BankMainMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BankMainMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BankMainMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class BankMainMenuItemsArrayDim0 : KaitaiStruct
        {
            public static BankMainMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new BankMainMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public BankMainMenuItemsArrayDim0(KaitaiStream p__io, BankMainMenuItemsArray p__parent = null, BankMainMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private BankMainMenuItemsArray m_root;
            private BankMainMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public BankMainMenuItemsArray M_Root { get { return m_root; } }
            public BankMainMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private BankMainMenuItemsArrayDim0 _entries;
        private BankMainMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public BankMainMenuItemsArrayDim0 Entries { get { return _entries; } }
        public BankMainMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
