// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array RECRUITMENT_LEVEL_BOOST_TABLE defined within pmdsky.
    /// </summary>
    public partial class RecruitmentLevelBoostTableArray : KaitaiStruct
    {
        public static RecruitmentLevelBoostTableArray FromFile(string fileName)
        {
            return new RecruitmentLevelBoostTableArray(new KaitaiStream(fileName));
        }

        public RecruitmentLevelBoostTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RecruitmentLevelBoostTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecruitmentLevelBoostTableArrayDim0(m_io, this, m_root);
        }
        public partial class RecruitmentLevelBoostTableArrayDim0 : KaitaiStruct
        {
            public static RecruitmentLevelBoostTableArrayDim0 FromFile(string fileName)
            {
                return new RecruitmentLevelBoostTableArrayDim0(new KaitaiStream(fileName));
            }

            public RecruitmentLevelBoostTableArrayDim0(KaitaiStream p__io, RecruitmentLevelBoostTableArray p__parent = null, RecruitmentLevelBoostTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 102; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private RecruitmentLevelBoostTableArray m_root;
            private RecruitmentLevelBoostTableArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public RecruitmentLevelBoostTableArray M_Root { get { return m_root; } }
            public RecruitmentLevelBoostTableArray M_Parent { get { return m_parent; } }
        }
        private RecruitmentLevelBoostTableArrayDim0 _entries;
        private RecruitmentLevelBoostTableArray m_root;
        private KaitaiStruct m_parent;
        public RecruitmentLevelBoostTableArrayDim0 Entries { get { return _entries; } }
        public RecruitmentLevelBoostTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
