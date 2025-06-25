// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array type_matchup_table_matchups defined within pmdsky.
    /// </summary>
    public partial class TypeMatchupTableMatchupsArray : KaitaiStruct
    {
        public static TypeMatchupTableMatchupsArray FromFile(string fileName)
        {
            return new TypeMatchupTableMatchupsArray(new KaitaiStream(fileName));
        }

        public TypeMatchupTableMatchupsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TypeMatchupTableMatchupsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TypeMatchupTableMatchupsArrayDim1(m_io, this, m_root);
        }
        public partial class TypeMatchupTableMatchupsArrayDim0 : KaitaiStruct
        {
            public static TypeMatchupTableMatchupsArrayDim0 FromFile(string fileName)
            {
                return new TypeMatchupTableMatchupsArrayDim0(new KaitaiStream(fileName));
            }

            public TypeMatchupTableMatchupsArrayDim0(KaitaiStream p__io, TypeMatchupTableMatchupsArray.TypeMatchupTableMatchupsArrayDim1 p__parent = null, TypeMatchupTableMatchupsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeMatchup16>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new TypeMatchup16(m_io));
                }
            }
            private List<TypeMatchup16> _entries;
            private TypeMatchupTableMatchupsArray m_root;
            private TypeMatchupTableMatchupsArray.TypeMatchupTableMatchupsArrayDim1 m_parent;
            public List<TypeMatchup16> Entries { get { return _entries; } }
            public TypeMatchupTableMatchupsArray M_Root { get { return m_root; } }
            public TypeMatchupTableMatchupsArray.TypeMatchupTableMatchupsArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class TypeMatchupTableMatchupsArrayDim1 : KaitaiStruct
        {
            public static TypeMatchupTableMatchupsArrayDim1 FromFile(string fileName)
            {
                return new TypeMatchupTableMatchupsArrayDim1(new KaitaiStream(fileName));
            }

            public TypeMatchupTableMatchupsArrayDim1(KaitaiStream p__io, TypeMatchupTableMatchupsArray p__parent = null, TypeMatchupTableMatchupsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeMatchupTableMatchupsArrayDim0>();
                for (var i = 0; i < 18; i++)
                {
                    _entries.Add(new TypeMatchupTableMatchupsArrayDim0(m_io, this, m_root));
                }
            }
            private List<TypeMatchupTableMatchupsArrayDim0> _entries;
            private TypeMatchupTableMatchupsArray m_root;
            private TypeMatchupTableMatchupsArray m_parent;
            public List<TypeMatchupTableMatchupsArrayDim0> Entries { get { return _entries; } }
            public TypeMatchupTableMatchupsArray M_Root { get { return m_root; } }
            public TypeMatchupTableMatchupsArray M_Parent { get { return m_parent; } }
        }
        private TypeMatchupTableMatchupsArrayDim1 _entries;
        private TypeMatchupTableMatchupsArray m_root;
        private KaitaiStruct m_parent;
        public TypeMatchupTableMatchupsArrayDim1 Entries { get { return _entries; } }
        public TypeMatchupTableMatchupsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
