// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RECRUITMENT_TABLE_SPECIES defined within pmdsky.
    /// </summary>
    public partial class RecruitmentTableSpeciesArray : KaitaiStruct
    {
        public static RecruitmentTableSpeciesArray FromFile(string fileName)
        {
            return new RecruitmentTableSpeciesArray(new KaitaiStream(fileName));
        }

        public RecruitmentTableSpeciesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RecruitmentTableSpeciesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RecruitmentTableSpeciesArrayDim0(m_io, this, m_root);
        }
        public partial class RecruitmentTableSpeciesArrayDim0 : KaitaiStruct
        {
            public static RecruitmentTableSpeciesArrayDim0 FromFile(string fileName)
            {
                return new RecruitmentTableSpeciesArrayDim0(new KaitaiStream(fileName));
            }

            public RecruitmentTableSpeciesArrayDim0(KaitaiStream p__io, RecruitmentTableSpeciesArray p__parent = null, RecruitmentTableSpeciesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 22; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private RecruitmentTableSpeciesArray m_root;
            private RecruitmentTableSpeciesArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public RecruitmentTableSpeciesArray M_Root { get { return m_root; } }
            public RecruitmentTableSpeciesArray M_Parent { get { return m_parent; } }
        }
        private RecruitmentTableSpeciesArrayDim0 _entries;
        private RecruitmentTableSpeciesArray m_root;
        private KaitaiStruct m_parent;
        public RecruitmentTableSpeciesArrayDim0 Entries { get { return _entries; } }
        public RecruitmentTableSpeciesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
