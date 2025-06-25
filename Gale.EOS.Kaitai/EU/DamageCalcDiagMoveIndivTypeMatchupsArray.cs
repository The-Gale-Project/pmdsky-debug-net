// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array damage_calc_diag_move_indiv_type_matchups defined within pmdsky.
    /// </summary>
    public partial class DamageCalcDiagMoveIndivTypeMatchupsArray : KaitaiStruct
    {
        public static DamageCalcDiagMoveIndivTypeMatchupsArray FromFile(string fileName)
        {
            return new DamageCalcDiagMoveIndivTypeMatchupsArray(new KaitaiStream(fileName));
        }

        public DamageCalcDiagMoveIndivTypeMatchupsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DamageCalcDiagMoveIndivTypeMatchupsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DamageCalcDiagMoveIndivTypeMatchupsArrayDim0(m_io, this, m_root);
        }
        public partial class DamageCalcDiagMoveIndivTypeMatchupsArrayDim0 : KaitaiStruct
        {
            public static DamageCalcDiagMoveIndivTypeMatchupsArrayDim0 FromFile(string fileName)
            {
                return new DamageCalcDiagMoveIndivTypeMatchupsArrayDim0(new KaitaiStream(fileName));
            }

            public DamageCalcDiagMoveIndivTypeMatchupsArrayDim0(KaitaiStream p__io, DamageCalcDiagMoveIndivTypeMatchupsArray p__parent = null, DamageCalcDiagMoveIndivTypeMatchupsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TypeMatchup8>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new TypeMatchup8(m_io));
                }
            }
            private List<TypeMatchup8> _entries;
            private DamageCalcDiagMoveIndivTypeMatchupsArray m_root;
            private DamageCalcDiagMoveIndivTypeMatchupsArray m_parent;
            public List<TypeMatchup8> Entries { get { return _entries; } }
            public DamageCalcDiagMoveIndivTypeMatchupsArray M_Root { get { return m_root; } }
            public DamageCalcDiagMoveIndivTypeMatchupsArray M_Parent { get { return m_parent; } }
        }
        private DamageCalcDiagMoveIndivTypeMatchupsArrayDim0 _entries;
        private DamageCalcDiagMoveIndivTypeMatchupsArray m_root;
        private KaitaiStruct m_parent;
        public DamageCalcDiagMoveIndivTypeMatchupsArrayDim0 Entries { get { return _entries; } }
        public DamageCalcDiagMoveIndivTypeMatchupsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
