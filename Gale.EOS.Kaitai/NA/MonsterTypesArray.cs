// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_types defined within pmdsky.
    /// </summary>
    public partial class MonsterTypesArray : KaitaiStruct
    {
        public static MonsterTypesArray FromFile(string fileName)
        {
            return new MonsterTypesArray(new KaitaiStream(fileName));
        }

        public MonsterTypesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterTypesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterTypesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterTypesArrayDim0 : KaitaiStruct
        {
            public static MonsterTypesArrayDim0 FromFile(string fileName)
            {
                return new MonsterTypesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterTypesArrayDim0(KaitaiStream p__io, MonsterTypesArray p__parent = null, MonsterTypesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeId8>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new TypeId8(m_io));
                }
            }
            private List<TypeId8> _entries;
            private MonsterTypesArray m_root;
            private MonsterTypesArray m_parent;
            public List<TypeId8> Entries { get { return _entries; } }
            public MonsterTypesArray M_Root { get { return m_root; } }
            public MonsterTypesArray M_Parent { get { return m_parent; } }
        }
        private MonsterTypesArrayDim0 _entries;
        private MonsterTypesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterTypesArrayDim0 Entries { get { return _entries; } }
        public MonsterTypesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
