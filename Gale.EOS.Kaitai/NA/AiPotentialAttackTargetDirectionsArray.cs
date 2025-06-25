// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS defined within pmdsky.
    /// </summary>
    public partial class AiPotentialAttackTargetDirectionsArray : KaitaiStruct
    {
        public static AiPotentialAttackTargetDirectionsArray FromFile(string fileName)
        {
            return new AiPotentialAttackTargetDirectionsArray(new KaitaiStream(fileName));
        }

        public AiPotentialAttackTargetDirectionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiPotentialAttackTargetDirectionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiPotentialAttackTargetDirectionsArrayDim0(m_io, this, m_root);
        }
        public partial class AiPotentialAttackTargetDirectionsArrayDim0 : KaitaiStruct
        {
            public static AiPotentialAttackTargetDirectionsArrayDim0 FromFile(string fileName)
            {
                return new AiPotentialAttackTargetDirectionsArrayDim0(new KaitaiStream(fileName));
            }

            public AiPotentialAttackTargetDirectionsArrayDim0(KaitaiStream p__io, AiPotentialAttackTargetDirectionsArray p__parent = null, AiPotentialAttackTargetDirectionsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DirectionId8>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new DirectionId8(m_io));
                }
            }
            private List<DirectionId8> _entries;
            private AiPotentialAttackTargetDirectionsArray m_root;
            private AiPotentialAttackTargetDirectionsArray m_parent;
            public List<DirectionId8> Entries { get { return _entries; } }
            public AiPotentialAttackTargetDirectionsArray M_Root { get { return m_root; } }
            public AiPotentialAttackTargetDirectionsArray M_Parent { get { return m_parent; } }
        }
        private AiPotentialAttackTargetDirectionsArrayDim0 _entries;
        private AiPotentialAttackTargetDirectionsArray m_root;
        private KaitaiStruct m_parent;
        public AiPotentialAttackTargetDirectionsArrayDim0 Entries { get { return _entries; } }
        public AiPotentialAttackTargetDirectionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
