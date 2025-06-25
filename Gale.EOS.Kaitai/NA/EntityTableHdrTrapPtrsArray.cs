// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array entity_table_hdr_trap_ptrs defined within pmdsky.
    /// </summary>
    public partial class EntityTableHdrTrapPtrsArray : KaitaiStruct
    {
        public static EntityTableHdrTrapPtrsArray FromFile(string fileName)
        {
            return new EntityTableHdrTrapPtrsArray(new KaitaiStream(fileName));
        }

        public EntityTableHdrTrapPtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTableHdrTrapPtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EntityTableHdrTrapPtrsArrayDim0(m_io, this, m_root);
        }
        public partial class EntityTableHdrTrapPtrsArrayDim0 : KaitaiStruct
        {
            public static EntityTableHdrTrapPtrsArrayDim0 FromFile(string fileName)
            {
                return new EntityTableHdrTrapPtrsArrayDim0(new KaitaiStream(fileName));
            }

            public EntityTableHdrTrapPtrsArrayDim0(KaitaiStream p__io, EntityTableHdrTrapPtrsArray p__parent = null, EntityTableHdrTrapPtrsArray p__root = null) : base(p__io)
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
            private EntityTableHdrTrapPtrsArray m_root;
            private EntityTableHdrTrapPtrsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public EntityTableHdrTrapPtrsArray M_Root { get { return m_root; } }
            public EntityTableHdrTrapPtrsArray M_Parent { get { return m_parent; } }
        }
        private EntityTableHdrTrapPtrsArrayDim0 _entries;
        private EntityTableHdrTrapPtrsArray m_root;
        private KaitaiStruct m_parent;
        public EntityTableHdrTrapPtrsArrayDim0 Entries { get { return _entries; } }
        public EntityTableHdrTrapPtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
