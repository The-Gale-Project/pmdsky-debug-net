// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array monster_iq_skill_menu_flags defined within pmdsky.
    /// </summary>
    public partial class MonsterIqSkillMenuFlagsArray : KaitaiStruct
    {
        public static MonsterIqSkillMenuFlagsArray FromFile(string fileName)
        {
            return new MonsterIqSkillMenuFlagsArray(new KaitaiStream(fileName));
        }

        public MonsterIqSkillMenuFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterIqSkillMenuFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterIqSkillMenuFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class MonsterIqSkillMenuFlagsArrayDim0 : KaitaiStruct
        {
            public static MonsterIqSkillMenuFlagsArrayDim0 FromFile(string fileName)
            {
                return new MonsterIqSkillMenuFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterIqSkillMenuFlagsArrayDim0(KaitaiStream p__io, MonsterIqSkillMenuFlagsArray p__parent = null, MonsterIqSkillMenuFlagsArray p__root = null) : base(p__io)
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
            private MonsterIqSkillMenuFlagsArray m_root;
            private MonsterIqSkillMenuFlagsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public MonsterIqSkillMenuFlagsArray M_Root { get { return m_root; } }
            public MonsterIqSkillMenuFlagsArray M_Parent { get { return m_parent; } }
        }
        private MonsterIqSkillMenuFlagsArrayDim0 _entries;
        private MonsterIqSkillMenuFlagsArray m_root;
        private KaitaiStruct m_parent;
        public MonsterIqSkillMenuFlagsArrayDim0 Entries { get { return _entries; } }
        public MonsterIqSkillMenuFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
