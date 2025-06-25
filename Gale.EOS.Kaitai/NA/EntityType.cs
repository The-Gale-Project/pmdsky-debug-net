// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum entity_type.
    /// </summary>
    public partial class EntityType : KaitaiStruct
    {
        public static EntityType FromFile(string fileName)
        {
            return new EntityType(new KaitaiStream(fileName));
        }


        public enum EntityTypeEnum
        {
            EntityNothing = 0,
            EntityMonster = 1,
            EntityTrap = 2,
            EntityItem = 3,
            EntityHiddenStairs = 5,
            EntityTemporary = 6,
        }
        public EntityType(KaitaiStream p__io, KaitaiStruct p__parent = null, EntityType p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entityTypeValue = ((EntityTypeEnum) m_io.ReadBitsIntLe(32));
        }
        private EntityTypeEnum _entityTypeValue;
        private EntityType m_root;
        private KaitaiStruct m_parent;
        public EntityTypeEnum EntityTypeValue { get { return _entityTypeValue; } }
        public EntityType M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
