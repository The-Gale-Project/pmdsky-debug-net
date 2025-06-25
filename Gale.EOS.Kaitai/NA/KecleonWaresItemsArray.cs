// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array KECLEON_WARES_ITEMS defined within pmdsky.
    /// </summary>
    public partial class KecleonWaresItemsArray : KaitaiStruct
    {
        public static KecleonWaresItemsArray FromFile(string fileName)
        {
            return new KecleonWaresItemsArray(new KaitaiStream(fileName));
        }

        public KecleonWaresItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, KecleonWaresItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new KecleonWaresItemsArrayDim0(m_io, this, m_root);
        }
        public partial class KecleonWaresItemsArrayDim0 : KaitaiStruct
        {
            public static KecleonWaresItemsArrayDim0 FromFile(string fileName)
            {
                return new KecleonWaresItemsArrayDim0(new KaitaiStream(fileName));
            }

            public KecleonWaresItemsArrayDim0(KaitaiStream p__io, KecleonWaresItemsArray p__parent = null, KecleonWaresItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<BulkItem>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new BulkItem(m_io));
                }
            }
            private List<BulkItem> _entries;
            private KecleonWaresItemsArray m_root;
            private KecleonWaresItemsArray m_parent;
            public List<BulkItem> Entries { get { return _entries; } }
            public KecleonWaresItemsArray M_Root { get { return m_root; } }
            public KecleonWaresItemsArray M_Parent { get { return m_parent; } }
        }
        private KecleonWaresItemsArrayDim0 _entries;
        private KecleonWaresItemsArray m_root;
        private KaitaiStruct m_parent;
        public KecleonWaresItemsArrayDim0 Entries { get { return _entries; } }
        public KecleonWaresItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
