// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_summary_iq_skill_flags defined within pmdsky.
    /// </summary>
    public partial class MonsterSummaryIqSkillFlagsArray : KaitaiStruct
    {
        public static MonsterSummaryIqSkillFlagsArray FromFile(string fileName)
        {
            return new MonsterSummaryIqSkillFlagsArray(new KaitaiStream(fileName));
        }

        public MonsterSummaryIqSkillFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterSummaryIqSkillFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterSummaryIqSkillFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterSummaryIqSkillFlagsArrayDim0 : KaitaiStruct
        {
            public static MonsterSummaryIqSkillFlagsArrayDim0 FromFile(string fileName)
            {
                return new MonsterSummaryIqSkillFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterSummaryIqSkillFlagsArrayDim0(KaitaiStream p__io, MonsterSummaryIqSkillFlagsArray p__parent = null, MonsterSummaryIqSkillFlagsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private MonsterSummaryIqSkillFlagsArray m_root;
            private MonsterSummaryIqSkillFlagsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public MonsterSummaryIqSkillFlagsArray M_Root { get { return m_root; } }
            public MonsterSummaryIqSkillFlagsArray M_Parent { get { return m_parent; } }
        }
        private MonsterSummaryIqSkillFlagsArrayDim0 _entries;
        private MonsterSummaryIqSkillFlagsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterSummaryIqSkillFlagsArrayDim0 Entries { get { return _entries; } }
        public MonsterSummaryIqSkillFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
