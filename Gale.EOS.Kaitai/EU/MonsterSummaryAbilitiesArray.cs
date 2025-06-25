// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_summary_abilities defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryAbilitiesArray : KaitaiStruct
    {
        public static MonsterSummaryAbilitiesArray FromFile(string fileName)
        {
            return new MonsterSummaryAbilitiesArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryAbilitiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryAbilitiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryAbilitiesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryAbilitiesArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryAbilitiesArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryAbilitiesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryAbilitiesArrayDim0(KaitaiStream p__io, MonsterSummaryAbilitiesArray p__parent = null, MonsterSummaryAbilitiesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<AbilityId8>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new AbilityId8(m_io));
                }
            }
            private List<AbilityId8> _entries;
            private MonsterSummaryAbilitiesArray m_root;
            private MonsterSummaryAbilitiesArray m_parent;
            public List<AbilityId8> Entries { get { return _entries; } }
            public MonsterSummaryAbilitiesArray M_Root { get { return m_root; } }
            public MonsterSummaryAbilitiesArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryAbilitiesArrayDim0 _entries;
        private MonsterSummaryAbilitiesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryAbilitiesArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryAbilitiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
