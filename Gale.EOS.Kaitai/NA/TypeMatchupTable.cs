// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union type_matchup_table defined within pmdsky-debug.
    /// </summary>
    public partial class TypeMatchupTable : KaitaiStruct
    {
        public static TypeMatchupTable FromFile(string fileName)
        {
            return new TypeMatchupTable(new KaitaiStream(fileName));
        }

        public TypeMatchupTable(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchupTable p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _matchups = new TypeMatchupTableMatchupsArray(m_io);
        }
        private TypeMatchupTableMatchupsArray _matchups;
        private TypeMatchupTable m_root;
        private KaitaiStruct m_parent;
        public TypeMatchupTableMatchupsArray Matchups { get { return _matchups; } }
        public TypeMatchupTable M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
