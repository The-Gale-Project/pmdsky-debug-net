// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array entity_table_entities defined within pmdsky.
    /// </summary>
    public partial class EntityTableEntitiesArray : KaitaiStruct
    {
        public static EntityTableEntitiesArray FromFile(string fileName)
        {
            return new EntityTableEntitiesArray(new KaitaiStream(fileName));
        }

        public EntityTableEntitiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTableEntitiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new EntityTableEntitiesArrayDim0(m_io, this, m_root);
        }
        public partial class EntityTableEntitiesArrayDim0 : KaitaiStruct
        {
            public static EntityTableEntitiesArrayDim0 FromFile(string fileName)
            {
                return new EntityTableEntitiesArrayDim0(new KaitaiStream(fileName));
            }

            public EntityTableEntitiesArrayDim0(KaitaiStream p__io, EntityTableEntitiesArray p__parent = null, EntityTableEntitiesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Entity>();
                for (var i = 0; i < 149; i++)
                {
                    _entries.Add(new Entity(m_io));
                }
            }
            private List<Entity> _entries;
            private EntityTableEntitiesArray m_root;
            private EntityTableEntitiesArray m_parent;
            public List<Entity> Entries { get { return _entries; } }
            public EntityTableEntitiesArray M_Root { get { return m_root; } }
            public EntityTableEntitiesArray M_Parent { get { return m_parent; } }
        }
        private EntityTableEntitiesArrayDim0 _entries;
        private EntityTableEntitiesArray m_root;
        private KaitaiStruct m_parent;
        public EntityTableEntitiesArrayDim0 Entries { get { return _entries; } }
        public EntityTableEntitiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
