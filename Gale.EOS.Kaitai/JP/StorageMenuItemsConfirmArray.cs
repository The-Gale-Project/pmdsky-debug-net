// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STORAGE_MENU_ITEMS_CONFIRM defined within pmdsky.
    /// </summary>
    public partial class StorageMenuItemsConfirmArray : KaitaiStruct
    {
        public static StorageMenuItemsConfirmArray FromFile(string fileName)
        {
            return new StorageMenuItemsConfirmArray(new KaitaiStream(fileName));
        }

        public StorageMenuItemsConfirmArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StorageMenuItemsConfirmArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StorageMenuItemsConfirmArrayDim0(m_io, this, m_root);
        }
        public partial class StorageMenuItemsConfirmArrayDim0 : KaitaiStruct
        {
            public static StorageMenuItemsConfirmArrayDim0 FromFile(string fileName)
            {
                return new StorageMenuItemsConfirmArrayDim0(new KaitaiStream(fileName));
            }

            public StorageMenuItemsConfirmArrayDim0(KaitaiStream p__io, StorageMenuItemsConfirmArray p__parent = null, StorageMenuItemsConfirmArray p__root = null) : base(p__io)
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
            private StorageMenuItemsConfirmArray m_root;
            private StorageMenuItemsConfirmArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public StorageMenuItemsConfirmArray M_Root { get { return m_root; } }
            public StorageMenuItemsConfirmArray M_Parent { get { return m_parent; } }
        }
        private StorageMenuItemsConfirmArrayDim0 _entries;
        private StorageMenuItemsConfirmArray m_root;
        private KaitaiStruct m_parent;
        public StorageMenuItemsConfirmArrayDim0 Entries { get { return _entries; } }
        public StorageMenuItemsConfirmArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
