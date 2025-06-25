// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STORAGE_ITEM_QUANTITIES defined within pmdsky.
    /// </summary>
    public partial class StorageItemQuantitiesArray : KaitaiStruct
    {
        public static StorageItemQuantitiesArray FromFile(string fileName)
        {
            return new StorageItemQuantitiesArray(new KaitaiStream(fileName));
        }

        public StorageItemQuantitiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StorageItemQuantitiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StorageItemQuantitiesArrayDim0(m_io, this, m_root);
        }
        public partial class StorageItemQuantitiesArrayDim0 : KaitaiStruct
        {
            public static StorageItemQuantitiesArrayDim0 FromFile(string fileName)
            {
                return new StorageItemQuantitiesArrayDim0(new KaitaiStream(fileName));
            }

            public StorageItemQuantitiesArrayDim0(KaitaiStream p__io, StorageItemQuantitiesArray p__parent = null, StorageItemQuantitiesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ushort>();
                for (var i = 0; i < 1000; i++)
                {
                    _entries.Add(m_io.ReadU2le());
                }
            }
            private List<ushort> _entries;
            private StorageItemQuantitiesArray m_root;
            private StorageItemQuantitiesArray m_parent;
            public List<ushort> Entries { get { return _entries; } }
            public StorageItemQuantitiesArray M_Root { get { return m_root; } }
            public StorageItemQuantitiesArray M_Parent { get { return m_parent; } }
        }
        private StorageItemQuantitiesArrayDim0 _entries;
        private StorageItemQuantitiesArray m_root;
        private KaitaiStruct m_parent;
        public StorageItemQuantitiesArrayDim0 Entries { get { return _entries; } }
        public StorageItemQuantitiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
