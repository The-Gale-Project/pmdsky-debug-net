// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_summary_types defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryTypesArray : KaitaiStruct
    {
        public static MonsterSummaryTypesArray FromFile(string fileName)
        {
            return new MonsterSummaryTypesArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryTypesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryTypesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryTypesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryTypesArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryTypesArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryTypesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryTypesArrayDim0(KaitaiStream p__io, MonsterSummaryTypesArray p__parent = null, MonsterSummaryTypesArray p__root = null) : base(p__io)
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
            private MonsterSummaryTypesArray m_root;
            private MonsterSummaryTypesArray m_parent;
            public List<TypeId8> Entries { get { return _entries; } }
            public MonsterSummaryTypesArray M_Root { get { return m_root; } }
            public MonsterSummaryTypesArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryTypesArrayDim0 _entries;
        private MonsterSummaryTypesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryTypesArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryTypesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
