// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STORAGE_ITEMS defined within pmdsky.
    /// </summary>
    public partial class StorageItemsArray : KaitaiStruct
    {
        public static StorageItemsArray FromFile(string fileName)
        {
            return new StorageItemsArray(new KaitaiStream(fileName));
        }

        public StorageItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StorageItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StorageItemsArrayDim0(m_io, this, m_root);
        }
        public partial class StorageItemsArrayDim0 : KaitaiStruct
        {
            public static StorageItemsArrayDim0 FromFile(string fileName)
            {
                return new StorageItemsArrayDim0(new KaitaiStream(fileName));
            }

            public StorageItemsArrayDim0(KaitaiStream p__io, StorageItemsArray p__parent = null, StorageItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ItemId16>();
                for (var i = 0; i < 1000; i++)
                {
                    _entries.Add(new ItemId16(m_io));
                }
            }
            private List<ItemId16> _entries;
            private StorageItemsArray m_root;
            private StorageItemsArray m_parent;
            public List<ItemId16> Entries { get { return _entries; } }
            public StorageItemsArray M_Root { get { return m_root; } }
            public StorageItemsArray M_Parent { get { return m_parent; } }
        }
        private StorageItemsArrayDim0 _entries;
        private StorageItemsArray m_root;
        private KaitaiStruct m_parent;
        public StorageItemsArrayDim0 Entries { get { return _entries; } }
        public StorageItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
