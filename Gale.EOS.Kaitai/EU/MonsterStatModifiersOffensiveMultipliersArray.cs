// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_stat_modifiers_offensive_multipliers defined within pmdsky.
    /// </summary>
    public partial class MonsterStatModifiersOffensiveMultipliersArray : KaitaiStruct
    {
        public static MonsterStatModifiersOffensiveMultipliersArray FromFile(string fileName)
        {
            return new MonsterStatModifiersOffensiveMultipliersArray(new KaitaiStream(fileName));
        }

        public MonsterStatModifiersOffensiveMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterStatModifiersOffensiveMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterStatModifiersOffensiveMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterStatModifiersOffensiveMultipliersArrayDim0 : KaitaiStruct
        {
            public static MonsterStatModifiersOffensiveMultipliersArrayDim0 FromFile(string fileName)
            {
                return new MonsterStatModifiersOffensiveMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterStatModifiersOffensiveMultipliersArrayDim0(KaitaiStream p__io, MonsterStatModifiersOffensiveMultipliersArray p__parent = null, MonsterStatModifiersOffensiveMultipliersArray p__root = null) : base(p__io)
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
            private MonsterStatModifiersOffensiveMultipliersArray m_root;
            private MonsterStatModifiersOffensiveMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MonsterStatModifiersOffensiveMultipliersArray M_Root { get { return m_root; } }
            public MonsterStatModifiersOffensiveMultipliersArray M_Parent { get { return m_parent; } }
        }
        private MonsterStatModifiersOffensiveMultipliersArrayDim0 _entries;
        private MonsterStatModifiersOffensiveMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public MonsterStatModifiersOffensiveMultipliersArrayDim0 Entries { get { return _entries; } }
        public MonsterStatModifiersOffensiveMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
