// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum type_id.
    /// </summary>
    public partial class TypeId : KaitaiStruct
    {
        public static TypeId FromFile(string fileName)
        {
            return new TypeId(new KaitaiStream(fileName));
        }


        public enum TypeIdEnum
        {
            TypeNone = 0,
            TypeNormal = 1,
            TypeFire = 2,
            TypeWater = 3,
            TypeGrass = 4,
            TypeElectric = 5,
            TypeIce = 6,
            TypeFighting = 7,
            TypePoison = 8,
            TypeGround = 9,
            TypeFlying = 10,
            TypePsychic = 11,
            TypeBug = 12,
            TypeRock = 13,
            TypeGhost = 14,
            TypeDragon = 15,
            TypeDark = 16,
            TypeSteel = 17,
            TypeNeutral = 18,
        }
        public TypeId(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeId p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _typeIdValue = ((TypeIdEnum) m_io.ReadBitsIntLe(32));
        }
        private TypeIdEnum _typeIdValue;
        private TypeId m_root;
        private KaitaiStruct m_parent;
        public TypeIdEnum TypeIdValue { get { return _typeIdValue; } }
        public TypeId M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
