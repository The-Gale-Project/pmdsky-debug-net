// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FEMALE_EVASION_STAGE_MULTIPLIERS defined within pmdsky.
    /// </summary>
    public partial class FemaleEvasionStageMultipliersArray : KaitaiStruct
    {
        public static FemaleEvasionStageMultipliersArray FromFile(string fileName)
        {
            return new FemaleEvasionStageMultipliersArray(new KaitaiStream(fileName));
        }

        public FemaleEvasionStageMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FemaleEvasionStageMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FemaleEvasionStageMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class FemaleEvasionStageMultipliersArrayDim0 : KaitaiStruct
        {
            public static FemaleEvasionStageMultipliersArrayDim0 FromFile(string fileName)
            {
                return new FemaleEvasionStageMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public FemaleEvasionStageMultipliersArrayDim0(KaitaiStream p__io, FemaleEvasionStageMultipliersArray p__parent = null, FemaleEvasionStageMultipliersArray p__root = null) : base(p__io)
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
            private FemaleEvasionStageMultipliersArray m_root;
            private FemaleEvasionStageMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public FemaleEvasionStageMultipliersArray M_Root { get { return m_root; } }
            public FemaleEvasionStageMultipliersArray M_Parent { get { return m_parent; } }
        }
        private FemaleEvasionStageMultipliersArrayDim0 _entries;
        private FemaleEvasionStageMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public FemaleEvasionStageMultipliersArrayDim0 Entries { get { return _entries; } }
        public FemaleEvasionStageMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
