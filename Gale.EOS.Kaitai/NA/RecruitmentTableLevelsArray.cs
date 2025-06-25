// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array RECRUITMENT_TABLE_LEVELS defined within pmdsky.
    /// </summary>
    public partial class RecruitmentTableLevelsArray : KaitaiStruct
    {
        public static RecruitmentTableLevelsArray FromFile(string fileName)
        {
            return new RecruitmentTableLevelsArray(new KaitaiStream(fileName));
        }

        public RecruitmentTableLevelsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RecruitmentTableLevelsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecruitmentTableLevelsArrayDim0(m_io, this, m_root);
        }
        public partial class RecruitmentTableLevelsArrayDim0 : KaitaiStruct
        {
            public static RecruitmentTableLevelsArrayDim0 FromFile(string fileName)
            {
                return new RecruitmentTableLevelsArrayDim0(new KaitaiStream(fileName));
            }

            public RecruitmentTableLevelsArrayDim0(KaitaiStream p__io, RecruitmentTableLevelsArray p__parent = null, RecruitmentTableLevelsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 22; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private RecruitmentTableLevelsArray m_root;
            private RecruitmentTableLevelsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public RecruitmentTableLevelsArray M_Root { get { return m_root; } }
            public RecruitmentTableLevelsArray M_Parent { get { return m_parent; } }
        }
        private RecruitmentTableLevelsArrayDim0 _entries;
        private RecruitmentTableLevelsArray m_root;
        private KaitaiStruct m_parent;
        public RecruitmentTableLevelsArrayDim0 Entries { get { return _entries; } }
        public RecruitmentTableLevelsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
