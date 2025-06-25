// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STORAGE_MAIN_MENU_ITEMS_1 defined within pmdsky.
    /// </summary>
    public partial class StorageMainMenuItems1Array : KaitaiStruct
    {
        public static StorageMainMenuItems1Array FromFile(string fileName)
        {
            return new StorageMainMenuItems1Array(new KaitaiStream(fileName));
        }

        public StorageMainMenuItems1Array(KaitaiStream p__io, KaitaiStruct p__parent = null, StorageMainMenuItems1Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StorageMainMenuItems1ArrayDim0(m_io, this, m_root);
        }
        public partial class StorageMainMenuItems1ArrayDim0 : KaitaiStruct
        {
            public static StorageMainMenuItems1ArrayDim0 FromFile(string fileName)
            {
                return new StorageMainMenuItems1ArrayDim0(new KaitaiStream(fileName));
            }

            public StorageMainMenuItems1ArrayDim0(KaitaiStream p__io, StorageMainMenuItems1Array p__parent = null, StorageMainMenuItems1Array p__root = null) : base(p__io)
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
            private StorageMainMenuItems1Array m_root;
            private StorageMainMenuItems1Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public StorageMainMenuItems1Array M_Root { get { return m_root; } }
            public StorageMainMenuItems1Array M_Parent { get { return m_parent; } }
        }
        private StorageMainMenuItems1ArrayDim0 _entries;
        private StorageMainMenuItems1Array m_root;
        private KaitaiStruct m_parent;
        public StorageMainMenuItems1ArrayDim0 Entries { get { return _entries; } }
        public StorageMainMenuItems1Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
