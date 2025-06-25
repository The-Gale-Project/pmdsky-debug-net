// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array STORAGE_MAIN_MENU_ITEMS_2 defined within pmdsky.
    /// </summary>
    public partial class StorageMainMenuItems2Array : KaitaiStruct
    {
        public static StorageMainMenuItems2Array FromFile(string fileName)
        {
            return new StorageMainMenuItems2Array(new KaitaiStream(fileName));
        }

        public StorageMainMenuItems2Array(KaitaiStream p__io, KaitaiStruct p__parent = null, StorageMainMenuItems2Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StorageMainMenuItems2ArrayDim0(m_io, this, m_root);
        }
        public partial class StorageMainMenuItems2ArrayDim0 : KaitaiStruct
        {
            public static StorageMainMenuItems2ArrayDim0 FromFile(string fileName)
            {
                return new StorageMainMenuItems2ArrayDim0(new KaitaiStream(fileName));
            }

            public StorageMainMenuItems2ArrayDim0(KaitaiStream p__io, StorageMainMenuItems2Array p__parent = null, StorageMainMenuItems2Array p__root = null) : base(p__io)
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
            private StorageMainMenuItems2Array m_root;
            private StorageMainMenuItems2Array m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public StorageMainMenuItems2Array M_Root { get { return m_root; } }
            public StorageMainMenuItems2Array M_Parent { get { return m_parent; } }
        }
        private StorageMainMenuItems2ArrayDim0 _entries;
        private StorageMainMenuItems2Array m_root;
        private KaitaiStruct m_parent;
        public StorageMainMenuItems2ArrayDim0 Entries { get { return _entries; } }
        public StorageMainMenuItems2Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
