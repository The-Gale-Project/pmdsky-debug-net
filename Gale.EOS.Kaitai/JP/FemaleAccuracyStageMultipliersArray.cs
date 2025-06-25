// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FEMALE_ACCURACY_STAGE_MULTIPLIERS defined within pmdsky.
    /// </summary>
    public partial class FemaleAccuracyStageMultipliersArray : KaitaiStruct
    {
        public static FemaleAccuracyStageMultipliersArray FromFile(string fileName)
        {
            return new FemaleAccuracyStageMultipliersArray(new KaitaiStream(fileName));
        }

        public FemaleAccuracyStageMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FemaleAccuracyStageMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FemaleAccuracyStageMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class FemaleAccuracyStageMultipliersArrayDim0 : KaitaiStruct
        {
            public static FemaleAccuracyStageMultipliersArrayDim0 FromFile(string fileName)
            {
                return new FemaleAccuracyStageMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public FemaleAccuracyStageMultipliersArrayDim0(KaitaiStream p__io, FemaleAccuracyStageMultipliersArray p__parent = null, FemaleAccuracyStageMultipliersArray p__root = null) : base(p__io)
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
            private FemaleAccuracyStageMultipliersArray m_root;
            private FemaleAccuracyStageMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public FemaleAccuracyStageMultipliersArray M_Root { get { return m_root; } }
            public FemaleAccuracyStageMultipliersArray M_Parent { get { return m_parent; } }
        }
        private FemaleAccuracyStageMultipliersArrayDim0 _entries;
        private FemaleAccuracyStageMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public FemaleAccuracyStageMultipliersArrayDim0 Entries { get { return _entries; } }
        public FemaleAccuracyStageMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
