// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array entity_table_hdr_active_monster_ptrs defined within pmdsky.
    /// </summary>
    public partial class EntityTableHdrActiveMonsterPtrsArray : KaitaiStruct
    {
        public static EntityTableHdrActiveMonsterPtrsArray FromFile(string fileName)
        {
            return new EntityTableHdrActiveMonsterPtrsArray(new KaitaiStream(fileName));
        }

        public EntityTableHdrActiveMonsterPtrsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTableHdrActiveMonsterPtrsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EntityTableHdrActiveMonsterPtrsArrayDim0(m_io, this, m_root);
        }
        public partial class EntityTableHdrActiveMonsterPtrsArrayDim0 : KaitaiStruct
        {
            public static EntityTableHdrActiveMonsterPtrsArrayDim0 FromFile(string fileName)
            {
                return new EntityTableHdrActiveMonsterPtrsArrayDim0(new KaitaiStream(fileName));
            }

            public EntityTableHdrActiveMonsterPtrsArrayDim0(KaitaiStream p__io, EntityTableHdrActiveMonsterPtrsArray p__parent = null, EntityTableHdrActiveMonsterPtrsArray p__root = null) : base(p__io)
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
            private EntityTableHdrActiveMonsterPtrsArray m_root;
            private EntityTableHdrActiveMonsterPtrsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public EntityTableHdrActiveMonsterPtrsArray M_Root { get { return m_root; } }
            public EntityTableHdrActiveMonsterPtrsArray M_Parent { get { return m_parent; } }
        }
        private EntityTableHdrActiveMonsterPtrsArrayDim0 _entries;
        private EntityTableHdrActiveMonsterPtrsArray m_root;
        private KaitaiStruct m_parent;
        public EntityTableHdrActiveMonsterPtrsArrayDim0 Entries { get { return _entries; } }
        public EntityTableHdrActiveMonsterPtrsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
