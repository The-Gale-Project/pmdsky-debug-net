// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array type_matchup_combinator_table_combination defined within pmdsky.
    /// </summary>
    public partial class TypeMatchupCombinatorTableCombinationArray : KaitaiStruct
    {
        public static TypeMatchupCombinatorTableCombinationArray FromFile(string fileName)
        {
            return new TypeMatchupCombinatorTableCombinationArray(new KaitaiStream(fileName));
        }

        public TypeMatchupCombinatorTableCombinationArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchupCombinatorTableCombinationArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TypeMatchupCombinatorTableCombinationArrayDim1(m_io, this, m_root);
        }
        public partial class TypeMatchupCombinatorTableCombinationArrayDim0 : KaitaiStruct
        {
            public static TypeMatchupCombinatorTableCombinationArrayDim0 FromFile(string fileName)
            {
                return new TypeMatchupCombinatorTableCombinationArrayDim0(new KaitaiStream(fileName));
            }

            public TypeMatchupCombinatorTableCombinationArrayDim0(KaitaiStream p__io, TypeMatchupCombinatorTableCombinationArray.TypeMatchupCombinatorTableCombinationArrayDim1 p__parent = null, TypeMatchupCombinatorTableCombinationArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeMatchup>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new TypeMatchup(m_io));
                }
            }
            private List<TypeMatchup> _entries;
            private TypeMatchupCombinatorTableCombinationArray m_root;
            private TypeMatchupCombinatorTableCombinationArray.TypeMatchupCombinatorTableCombinationArrayDim1 m_parent;
            public List<TypeMatchup> Entries { get { return _entries; } }
            public TypeMatchupCombinatorTableCombinationArray M_Root { get { return m_root; } }
            public TypeMatchupCombinatorTableCombinationArray.TypeMatchupCombinatorTableCombinationArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class TypeMatchupCombinatorTableCombinationArrayDim1 : KaitaiStruct
        {
            public static TypeMatchupCombinatorTableCombinationArrayDim1 FromFile(string fileName)
            {
                return new TypeMatchupCombinatorTableCombinationArrayDim1(new KaitaiStream(fileName));
            }

            public TypeMatchupCombinatorTableCombinationArrayDim1(KaitaiStream p__io, TypeMatchupCombinatorTableCombinationArray p__parent = null, TypeMatchupCombinatorTableCombinationArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeMatchupCombinatorTableCombinationArrayDim0>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new TypeMatchupCombinatorTableCombinationArrayDim0(m_io, this, m_root));
                }
            }
            private List<TypeMatchupCombinatorTableCombinationArrayDim0> _entries;
            private TypeMatchupCombinatorTableCombinationArray m_root;
            private TypeMatchupCombinatorTableCombinationArray m_parent;
            public List<TypeMatchupCombinatorTableCombinationArrayDim0> Entries { get { return _entries; } }
            public TypeMatchupCombinatorTableCombinationArray M_Root { get { return m_root; } }
            public TypeMatchupCombinatorTableCombinationArray M_Parent { get { return m_parent; } }
        }
        private TypeMatchupCombinatorTableCombinationArrayDim1 _entries;
        private TypeMatchupCombinatorTableCombinationArray m_root;
        private KaitaiStruct m_parent;
        public TypeMatchupCombinatorTableCombinationArrayDim1 Entries { get { return _entries; } }
        public TypeMatchupCombinatorTableCombinationArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
