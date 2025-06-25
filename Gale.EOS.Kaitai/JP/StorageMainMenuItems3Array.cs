// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STORAGE_MAIN_MENU_ITEMS_3 defined within pmdsky.
    /// </summary>
    public partial class StorageMainMenuItems3Array : KaitaiStruct
    {
        public static StorageMainMenuItems3Array FromFile(string fileName)
        {
            return new StorageMainMenuItems3Array(new KaitaiStream(fileName));
        }

        public StorageMainMenuItems3Array(KaitaiStream p__io, KaitaiStruct p__parent = null, StorageMainMenuItems3Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StorageMainMenuItems3ArrayDim0(m_io, this, m_root);
        }
        public partial class StorageMainMenuItems3ArrayDim0 : KaitaiStruct
        {
            public static StorageMainMenuItems3ArrayDim0 FromFile(string fileName)
            {
                return new StorageMainMenuItems3ArrayDim0(new KaitaiStream(fileName));
            }

            public StorageMainMenuItems3ArrayDim0(KaitaiStream p__io, StorageMainMenuItems3Array p__parent = null, StorageMainMenuItems3Array p__root = null) : base(p__io)
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
            private StorageMainMenuItems3Array m_root;
            private StorageMainMenuItems3Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public StorageMainMenuItems3Array M_Root { get { return m_root; } }
            public StorageMainMenuItems3Array M_Parent { get { return m_parent; } }
        }
        private StorageMainMenuItems3ArrayDim0 _entries;
        private StorageMainMenuItems3Array m_root;
        private KaitaiStruct m_parent;
        public StorageMainMenuItems3ArrayDim0 Entries { get { return _entries; } }
        public StorageMainMenuItems3Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
