// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_stat_modifiers_hit_chance_stages defined within pmdsky.
    /// </summary>
    public partial class MonsterStatModifiersHitChanceStagesArray : KaitaiStruct
    {
        public static MonsterStatModifiersHitChanceStagesArray FromFile(string fileName)
        {
            return new MonsterStatModifiersHitChanceStagesArray(new KaitaiStream(fileName));
        }

        public MonsterStatModifiersHitChanceStagesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterStatModifiersHitChanceStagesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterStatModifiersHitChanceStagesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterStatModifiersHitChanceStagesArrayDim0 : KaitaiStruct
        {
            public static MonsterStatModifiersHitChanceStagesArrayDim0 FromFile(string fileName)
            {
                return new MonsterStatModifiersHitChanceStagesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterStatModifiersHitChanceStagesArrayDim0(KaitaiStream p__io, MonsterStatModifiersHitChanceStagesArray p__parent = null, MonsterStatModifiersHitChanceStagesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private MonsterStatModifiersHitChanceStagesArray m_root;
            private MonsterStatModifiersHitChanceStagesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public MonsterStatModifiersHitChanceStagesArray M_Root { get { return m_root; } }
            public MonsterStatModifiersHitChanceStagesArray M_Parent { get { return m_parent; } }
        }
        private MonsterStatModifiersHitChanceStagesArrayDim0 _entries;
        private MonsterStatModifiersHitChanceStagesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterStatModifiersHitChanceStagesArrayDim0 Entries { get { return _entries; } }
        public MonsterStatModifiersHitChanceStagesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
