// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum type_id.
    /// </summary>
    public partial class TypeId8 : KaitaiStruct
    {
        public static TypeId8 FromFile(string fileName)
        {
            return new TypeId8(new KaitaiStream(fileName));
        }


        public enum TypeId8Enum
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
        public TypeId8(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _typeId8Value = ((TypeId8Enum) m_io.ReadBitsIntLe(8));
        }
        private TypeId8Enum _typeId8Value;
        private TypeId8 m_root;
        private KaitaiStruct m_parent;
        public TypeId8Enum TypeId8Value { get { return _typeId8Value; } }
        public TypeId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
