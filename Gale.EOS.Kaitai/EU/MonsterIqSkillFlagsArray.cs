// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array monster_iq_skill_flags defined within pmdsky.
    /// </summary>
    public partial class MonsterIqSkillFlagsArray : KaitaiStruct
    {
        public static MonsterIqSkillFlagsArray FromFile(string fileName)
        {
            return new MonsterIqSkillFlagsArray(new KaitaiStream(fileName));
        }

        public MonsterIqSkillFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterIqSkillFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterIqSkillFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterIqSkillFlagsArrayDim0 : KaitaiStruct
        {
            public static MonsterIqSkillFlagsArrayDim0 FromFile(string fileName)
            {
                return new MonsterIqSkillFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterIqSkillFlagsArrayDim0(KaitaiStream p__io, MonsterIqSkillFlagsArray p__parent = null, MonsterIqSkillFlagsArray p__root = null) : base(p__io)
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
            private MonsterIqSkillFlagsArray m_root;
            private MonsterIqSkillFlagsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public MonsterIqSkillFlagsArray M_Root { get { return m_root; } }
            public MonsterIqSkillFlagsArray M_Parent { get { return m_parent; } }
        }
        private MonsterIqSkillFlagsArrayDim0 _entries;
        private MonsterIqSkillFlagsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterIqSkillFlagsArrayDim0 Entries { get { return _entries; } }
        public MonsterIqSkillFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
