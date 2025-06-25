// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array RECRUITMENT_TABLE_LOCATIONS defined within pmdsky.
    /// </summary>
    public partial class RecruitmentTableLocationsArray : KaitaiStruct
    {
        public static RecruitmentTableLocationsArray FromFile(string fileName)
        {
            return new RecruitmentTableLocationsArray(new KaitaiStream(fileName));
        }

        public RecruitmentTableLocationsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RecruitmentTableLocationsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecruitmentTableLocationsArrayDim0(m_io, this, m_root);
        }
        public partial class RecruitmentTableLocationsArrayDim0 : KaitaiStruct
        {
            public static RecruitmentTableLocationsArrayDim0 FromFile(string fileName)
            {
                return new RecruitmentTableLocationsArrayDim0(new KaitaiStream(fileName));
            }

            public RecruitmentTableLocationsArrayDim0(KaitaiStream p__io, RecruitmentTableLocationsArray p__parent = null, RecruitmentTableLocationsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DungeonId16>();
                for (var i = 0; i < 22; i++)
                {
                    _entries.Add(new DungeonId16(m_io));
                }
            }
            private List<DungeonId16> _entries;
            private RecruitmentTableLocationsArray m_root;
            private RecruitmentTableLocationsArray m_parent;
            public List<DungeonId16> Entries { get { return _entries; } }
            public RecruitmentTableLocationsArray M_Root { get { return m_root; } }
            public RecruitmentTableLocationsArray M_Parent { get { return m_parent; } }
        }
        private RecruitmentTableLocationsArrayDim0 _entries;
        private RecruitmentTableLocationsArray m_root;
        private KaitaiStruct m_parent;
        public RecruitmentTableLocationsArrayDim0 Entries { get { return _entries; } }
        public RecruitmentTableLocationsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
