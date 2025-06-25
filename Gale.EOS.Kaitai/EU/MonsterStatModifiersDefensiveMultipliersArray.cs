// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_stat_modifiers_defensive_multipliers defined within pmdsky.
    /// </summary>
    public partial class MonsterStatModifiersDefensiveMultipliersArray : KaitaiStruct
    {
        public static MonsterStatModifiersDefensiveMultipliersArray FromFile(string fileName)
        {
            return new MonsterStatModifiersDefensiveMultipliersArray(new KaitaiStream(fileName));
        }

        public MonsterStatModifiersDefensiveMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterStatModifiersDefensiveMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterStatModifiersDefensiveMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterStatModifiersDefensiveMultipliersArrayDim0 : KaitaiStruct
        {
            public static MonsterStatModifiersDefensiveMultipliersArrayDim0 FromFile(string fileName)
            {
                return new MonsterStatModifiersDefensiveMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterStatModifiersDefensiveMultipliersArrayDim0(KaitaiStream p__io, MonsterStatModifiersDefensiveMultipliersArray p__parent = null, MonsterStatModifiersDefensiveMultipliersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private MonsterStatModifiersDefensiveMultipliersArray m_root;
            private MonsterStatModifiersDefensiveMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MonsterStatModifiersDefensiveMultipliersArray M_Root { get { return m_root; } }
            public MonsterStatModifiersDefensiveMultipliersArray M_Parent { get { return m_parent; } }
        }
        private MonsterStatModifiersDefensiveMultipliersArrayDim0 _entries;
        private MonsterStatModifiersDefensiveMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public MonsterStatModifiersDefensiveMultipliersArrayDim0 Entries { get { return _entries; } }
        public MonsterStatModifiersDefensiveMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
