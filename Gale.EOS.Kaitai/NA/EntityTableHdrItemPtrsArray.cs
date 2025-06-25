// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array entity_table_hdr_item_ptrs defined within pmdsky.
    /// </summary>
    public partial class EntityTableHdrItemPtrsArray : KaitaiStruct
    {
        public static EntityTableHdrItemPtrsArray FromFile(string fileName)
        {
            return new EntityTableHdrItemPtrsArray(new KaitaiStream(fileName));
        }

        public EntityTableHdrItemPtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTableHdrItemPtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EntityTableHdrItemPtrsArrayDim0(m_io, this, m_root);
        }
        public partial class EntityTableHdrItemPtrsArrayDim0 : KaitaiStruct
        {
            public static EntityTableHdrItemPtrsArrayDim0 FromFile(string fileName)
            {
                return new EntityTableHdrItemPtrsArrayDim0(new KaitaiStream(fileName));
            }

            public EntityTableHdrItemPtrsArrayDim0(KaitaiStream p__io, EntityTableHdrItemPtrsArray p__parent = null, EntityTableHdrItemPtrsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 64; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private EntityTableHdrItemPtrsArray m_root;
            private EntityTableHdrItemPtrsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public EntityTableHdrItemPtrsArray M_Root { get { return m_root; } }
            public EntityTableHdrItemPtrsArray M_Parent { get { return m_parent; } }
        }
        private EntityTableHdrItemPtrsArrayDim0 _entries;
        private EntityTableHdrItemPtrsArray m_root;
        private KaitaiStruct m_parent;
        public EntityTableHdrItemPtrsArrayDim0 Entries { get { return _entries; } }
        public EntityTableHdrItemPtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
