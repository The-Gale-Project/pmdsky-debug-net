// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union entity_table defined within pmdsky-debug.
    /// </summary>
    public partial class EntityTable : KaitaiStruct
    {
        public static EntityTable FromFile(string fileName)
        {
            return new EntityTable(new KaitaiStream(fileName));
        }

        public EntityTable(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _header = new EntityTableHdr(m_io);
            _entities = new EntityTableEntitiesArray(m_io);
        }
        private EntityTableHdr _header;
        private EntityTableEntitiesArray _entities;
        private EntityTable m_root;
        private KaitaiStruct m_parent;
        public EntityTableHdr Header { get { return _header; } }
        public EntityTableEntitiesArray Entities { get { return _entities; } }
        public EntityTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
