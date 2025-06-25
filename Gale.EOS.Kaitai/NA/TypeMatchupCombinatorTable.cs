// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union type_matchup_combinator_table defined within pmdsky-debug.
    /// </summary>
    public partial class TypeMatchupCombinatorTable : KaitaiStruct
    {
        public static TypeMatchupCombinatorTable FromFile(string fileName)
        {
            return new TypeMatchupCombinatorTable(new KaitaiStream(fileName));
        }

        public TypeMatchupCombinatorTable(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchupCombinatorTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _combination = new TypeMatchupCombinatorTableCombinationArray(m_io);
        }
        private TypeMatchupCombinatorTableCombinationArray _combination;
        private TypeMatchupCombinatorTable m_root;
        private KaitaiStruct m_parent;
        public TypeMatchupCombinatorTableCombinationArray Combination { get { return _combination; } }
        public TypeMatchupCombinatorTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
