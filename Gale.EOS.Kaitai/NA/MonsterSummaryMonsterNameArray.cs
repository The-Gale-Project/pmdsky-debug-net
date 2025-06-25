// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_summary_monster_name defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryMonsterNameArray : KaitaiStruct
    {
        public static MonsterSummaryMonsterNameArray FromFile(string fileName)
        {
            return new MonsterSummaryMonsterNameArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryMonsterNameArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryMonsterNameArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryMonsterNameArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryMonsterNameArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryMonsterNameArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryMonsterNameArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryMonsterNameArrayDim0(KaitaiStream p__io, MonsterSummaryMonsterNameArray p__parent = null, MonsterSummaryMonsterNameArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 10; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private MonsterSummaryMonsterNameArray m_root;
            private MonsterSummaryMonsterNameArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public MonsterSummaryMonsterNameArray M_Root { get { return m_root; } }
            public MonsterSummaryMonsterNameArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryMonsterNameArrayDim0 _entries;
        private MonsterSummaryMonsterNameArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryMonsterNameArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryMonsterNameArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
