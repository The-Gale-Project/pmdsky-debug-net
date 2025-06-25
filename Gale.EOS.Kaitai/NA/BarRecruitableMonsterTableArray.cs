// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array BAR_RECRUITABLE_MONSTER_TABLE defined within pmdsky.
    /// </summary>
    public partial class BarRecruitableMonsterTableArray : KaitaiStruct
    {
        public static BarRecruitableMonsterTableArray FromFile(string fileName)
        {
            return new BarRecruitableMonsterTableArray(new KaitaiStream(fileName));
        }

        public BarRecruitableMonsterTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, BarRecruitableMonsterTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new BarRecruitableMonsterTableArrayDim0(m_io, this, m_root);
        }
        public partial class BarRecruitableMonsterTableArrayDim0 : KaitaiStruct
        {
            public static BarRecruitableMonsterTableArrayDim0 FromFile(string fileName)
            {
                return new BarRecruitableMonsterTableArrayDim0(new KaitaiStream(fileName));
            }

            public BarRecruitableMonsterTableArrayDim0(KaitaiStream p__io, BarRecruitableMonsterTableArray p__parent = null, BarRecruitableMonsterTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 108; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private BarRecruitableMonsterTableArray m_root;
            private BarRecruitableMonsterTableArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public BarRecruitableMonsterTableArray M_Root { get { return m_root; } }
            public BarRecruitableMonsterTableArray M_Parent { get { return m_parent; } }
        }
        private BarRecruitableMonsterTableArrayDim0 _entries;
        private BarRecruitableMonsterTableArray m_root;
        private KaitaiStruct m_parent;
        public BarRecruitableMonsterTableArrayDim0 Entries { get { return _entries; } }
        public BarRecruitableMonsterTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
