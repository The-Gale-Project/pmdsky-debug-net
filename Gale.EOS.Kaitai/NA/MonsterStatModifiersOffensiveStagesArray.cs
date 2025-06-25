// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_stat_modifiers_offensive_stages defined within pmdsky.
    /// </summary>
    public partial class MonsterStatModifiersOffensiveStagesArray : KaitaiStruct
    {
        public static MonsterStatModifiersOffensiveStagesArray FromFile(string fileName)
        {
            return new MonsterStatModifiersOffensiveStagesArray(new KaitaiStream(fileName));
        }

        public MonsterStatModifiersOffensiveStagesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterStatModifiersOffensiveStagesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterStatModifiersOffensiveStagesArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterStatModifiersOffensiveStagesArrayDim0 : KaitaiStruct
        {
            public static MonsterStatModifiersOffensiveStagesArrayDim0 FromFile(string fileName)
            {
                return new MonsterStatModifiersOffensiveStagesArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterStatModifiersOffensiveStagesArrayDim0(KaitaiStream p__io, MonsterStatModifiersOffensiveStagesArray p__parent = null, MonsterStatModifiersOffensiveStagesArray p__root = null) : base(p__io)
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
            private MonsterStatModifiersOffensiveStagesArray m_root;
            private MonsterStatModifiersOffensiveStagesArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public MonsterStatModifiersOffensiveStagesArray M_Root { get { return m_root; } }
            public MonsterStatModifiersOffensiveStagesArray M_Parent { get { return m_parent; } }
        }
        private MonsterStatModifiersOffensiveStagesArrayDim0 _entries;
        private MonsterStatModifiersOffensiveStagesArray m_root;
        private KaitaiStruct m_parent;
        public MonsterStatModifiersOffensiveStagesArrayDim0 Entries { get { return _entries; } }
        public MonsterStatModifiersOffensiveStagesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
