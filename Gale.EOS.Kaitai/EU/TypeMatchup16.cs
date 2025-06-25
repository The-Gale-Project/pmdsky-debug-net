// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum type_matchup.
    /// </summary>
    public partial class TypeMatchup16 : KaitaiStruct
    {
        public static TypeMatchup16 FromFile(string fileName)
        {
            return new TypeMatchup16(new KaitaiStream(fileName));
        }


        public enum TypeMatchup16Enum
        {
            MatchupImmune = 0,
            MatchupNotVeryEffective = 1,
            MatchupNeutral = 2,
            MatchupSuperEffective = 3,
        }
        public TypeMatchup16(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchup16 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _typeMatchup16Value = ((TypeMatchup16Enum) m_io.ReadBitsIntLe(16));
        }
        private TypeMatchup16Enum _typeMatchup16Value;
        private TypeMatchup16 m_root;
        private KaitaiStruct m_parent;
        public TypeMatchup16Enum TypeMatchup16Value { get { return _typeMatchup16Value; } }
        public TypeMatchup16 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
