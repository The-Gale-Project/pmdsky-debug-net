// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum type_matchup.
    /// </summary>
    public partial class TypeMatchup8 : KaitaiStruct
    {
        public static TypeMatchup8 FromFile(string fileName)
        {
            return new TypeMatchup8(new KaitaiStream(fileName));
        }


        public enum TypeMatchup8Enum
        {
            MatchupImmune = 0,
            MatchupNotVeryEffective = 1,
            MatchupNeutral = 2,
            MatchupSuperEffective = 3,
        }
        public TypeMatchup8(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchup8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _typeMatchup8Value = ((TypeMatchup8Enum) m_io.ReadBitsIntLe(8));
        }
        private TypeMatchup8Enum _typeMatchup8Value;
        private TypeMatchup8 m_root;
        private KaitaiStruct m_parent;
        public TypeMatchup8Enum TypeMatchup8Value { get { return _typeMatchup8Value; } }
        public TypeMatchup8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
