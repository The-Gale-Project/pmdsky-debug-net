// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_stat_modifiers_defensive_stages defined within pmdsky.
    /// </summary>
    public partial class MonsterStatModifiersDefensiveStagesArray : KaitaiStruct
    {
        public static MonsterStatModifiersDefensiveStagesArray FromFile(string fileName)
        {
            return new MonsterStatModifiersDefensiveStagesArray(new KaitaiStream(fileName));
        }

        public MonsterStatModifiersDefensiveStagesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterStatModifiersDefensiveStagesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterStatModifiersDefensiveStagesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterStatModifiersDefensiveStagesArrayDim0 : KaitaiStruct
        {
            public static MonsterStatModifiersDefensiveStagesArrayDim0 FromFile(string fileName)
            {
                return new MonsterStatModifiersDefensiveStagesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterStatModifiersDefensiveStagesArrayDim0(KaitaiStream p__io, MonsterStatModifiersDefensiveStagesArray p__parent = null, MonsterStatModifiersDefensiveStagesArray p__root = null) : base(p__io)
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
            private MonsterStatModifiersDefensiveStagesArray m_root;
            private MonsterStatModifiersDefensiveStagesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public MonsterStatModifiersDefensiveStagesArray M_Root { get { return m_root; } }
            public MonsterStatModifiersDefensiveStagesArray M_Parent { get { return m_parent; } }
        }
        private MonsterStatModifiersDefensiveStagesArrayDim0 _entries;
        private MonsterStatModifiersDefensiveStagesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterStatModifiersDefensiveStagesArrayDim0 Entries { get { return _entries; } }
        public MonsterStatModifiersDefensiveStagesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
