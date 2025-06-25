// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array ground_monster_iq_skill_flags defined within pmdsky.
    /// </summary>
    public partial class GroundMonsterIqSkillFlagsArray : KaitaiStruct
    {
        public static GroundMonsterIqSkillFlagsArray FromFile(string fileName)
        {
            return new GroundMonsterIqSkillFlagsArray(new KaitaiStream(fileName));
        }

        public GroundMonsterIqSkillFlagsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, GroundMonsterIqSkillFlagsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new GroundMonsterIqSkillFlagsArrayDim0(m_io, this, m_root);
        }
        public partial class GroundMonsterIqSkillFlagsArrayDim0 : KaitaiStruct
        {
            public static GroundMonsterIqSkillFlagsArrayDim0 FromFile(string fileName)
            {
                return new GroundMonsterIqSkillFlagsArrayDim0(new KaitaiStream(fileName));
            }

            public GroundMonsterIqSkillFlagsArrayDim0(KaitaiStream p__io, GroundMonsterIqSkillFlagsArray p__parent = null, GroundMonsterIqSkillFlagsArray p__root = null) : base(p__io)
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
            private GroundMonsterIqSkillFlagsArray m_root;
            private GroundMonsterIqSkillFlagsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public GroundMonsterIqSkillFlagsArray M_Root { get { return m_root; } }
            public GroundMonsterIqSkillFlagsArray M_Parent { get { return m_parent; } }
        }
        private GroundMonsterIqSkillFlagsArrayDim0 _entries;
        private GroundMonsterIqSkillFlagsArray m_root;
        private KaitaiStruct m_parent;
        public GroundMonsterIqSkillFlagsArrayDim0 Entries { get { return _entries; } }
        public GroundMonsterIqSkillFlagsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
