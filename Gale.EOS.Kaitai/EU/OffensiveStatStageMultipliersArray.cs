// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array OFFENSIVE_STAT_STAGE_MULTIPLIERS defined within pmdsky.
    /// </summary>
    public partial class OffensiveStatStageMultipliersArray : KaitaiStruct
    {
        public static OffensiveStatStageMultipliersArray FromFile(string fileName)
        {
            return new OffensiveStatStageMultipliersArray(new KaitaiStream(fileName));
        }

        public OffensiveStatStageMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, OffensiveStatStageMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new OffensiveStatStageMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class OffensiveStatStageMultipliersArrayDim0 : KaitaiStruct
        {
            public static OffensiveStatStageMultipliersArrayDim0 FromFile(string fileName)
            {
                return new OffensiveStatStageMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public OffensiveStatStageMultipliersArrayDim0(KaitaiStream p__io, OffensiveStatStageMultipliersArray p__parent = null, OffensiveStatStageMultipliersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 21; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private OffensiveStatStageMultipliersArray m_root;
            private OffensiveStatStageMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public OffensiveStatStageMultipliersArray M_Root { get { return m_root; } }
            public OffensiveStatStageMultipliersArray M_Parent { get { return m_parent; } }
        }
        private OffensiveStatStageMultipliersArrayDim0 _entries;
        private OffensiveStatStageMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public OffensiveStatStageMultipliersArrayDim0 Entries { get { return _entries; } }
        public OffensiveStatStageMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
