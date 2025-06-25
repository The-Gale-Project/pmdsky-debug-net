// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds the data for the enum type_matchup.
    /// </summary>
    public partial class TypeMatchup : KaitaiStruct
    {
        public static TypeMatchup FromFile(string fileName)
        {
            return new TypeMatchup(new KaitaiStream(fileName));
        }


        public enum TypeMatchupEnum
        {
            MatchupImmune = 0,
            MatchupNotVeryEffective = 1,
            MatchupNeutral = 2,
            MatchupSuperEffective = 3,
        }
        public TypeMatchup(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchup p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _typeMatchupValue = ((TypeMatchupEnum) m_io.ReadBitsIntLe(32));
        }
        private TypeMatchupEnum _typeMatchupValue;
        private TypeMatchup m_root;
        private KaitaiStruct m_parent;
        public TypeMatchupEnum TypeMatchupValue { get { return _typeMatchupValue; } }
        public TypeMatchup M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
