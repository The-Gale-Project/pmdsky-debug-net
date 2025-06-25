// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array entity_table_hdr_monster_slot_ptrs defined within pmdsky.
    /// </summary>
    public partial class EntityTableHdrMonsterSlotPtrsArray : KaitaiStruct
    {
        public static EntityTableHdrMonsterSlotPtrsArray FromFile(string fileName)
        {
            return new EntityTableHdrMonsterSlotPtrsArray(new KaitaiStream(fileName));
        }

        public EntityTableHdrMonsterSlotPtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTableHdrMonsterSlotPtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EntityTableHdrMonsterSlotPtrsArrayDim0(m_io, this, m_root);
        }
        public partial class EntityTableHdrMonsterSlotPtrsArrayDim0 : KaitaiStruct
        {
            public static EntityTableHdrMonsterSlotPtrsArrayDim0 FromFile(string fileName)
            {
                return new EntityTableHdrMonsterSlotPtrsArrayDim0(new KaitaiStream(fileName));
            }

            public EntityTableHdrMonsterSlotPtrsArrayDim0(KaitaiStream p__io, EntityTableHdrMonsterSlotPtrsArray p__parent = null, EntityTableHdrMonsterSlotPtrsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private EntityTableHdrMonsterSlotPtrsArray m_root;
            private EntityTableHdrMonsterSlotPtrsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public EntityTableHdrMonsterSlotPtrsArray M_Root { get { return m_root; } }
            public EntityTableHdrMonsterSlotPtrsArray M_Parent { get { return m_parent; } }
        }
        private EntityTableHdrMonsterSlotPtrsArrayDim0 _entries;
        private EntityTableHdrMonsterSlotPtrsArray m_root;
        private KaitaiStruct m_parent;
        public EntityTableHdrMonsterSlotPtrsArrayDim0 Entries { get { return _entries; } }
        public EntityTableHdrMonsterSlotPtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
