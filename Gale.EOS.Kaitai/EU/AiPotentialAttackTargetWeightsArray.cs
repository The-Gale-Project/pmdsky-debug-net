// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array AI_POTENTIAL_ATTACK_TARGET_WEIGHTS defined within pmdsky.
    /// </summary>
    public partial class AiPotentialAttackTargetWeightsArray : KaitaiStruct
    {
        public static AiPotentialAttackTargetWeightsArray FromFile(string fileName)
        {
            return new AiPotentialAttackTargetWeightsArray(new KaitaiStream(fileName));
        }

        public AiPotentialAttackTargetWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiPotentialAttackTargetWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiPotentialAttackTargetWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class AiPotentialAttackTargetWeightsArrayDim0 : KaitaiStruct
        {
            public static AiPotentialAttackTargetWeightsArrayDim0 FromFile(string fileName)
            {
                return new AiPotentialAttackTargetWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public AiPotentialAttackTargetWeightsArrayDim0(KaitaiStream p__io, AiPotentialAttackTargetWeightsArray p__parent = null, AiPotentialAttackTargetWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<uint>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU4le());
                }
            }
            private List<uint> _entries;
            private AiPotentialAttackTargetWeightsArray m_root;
            private AiPotentialAttackTargetWeightsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public AiPotentialAttackTargetWeightsArray M_Root { get { return m_root; } }
            public AiPotentialAttackTargetWeightsArray M_Parent { get { return m_parent; } }
        }
        private AiPotentialAttackTargetWeightsArrayDim0 _entries;
        private AiPotentialAttackTargetWeightsArray m_root;
        private KaitaiStruct m_parent;
        public AiPotentialAttackTargetWeightsArrayDim0 Entries { get { return _entries; } }
        public AiPotentialAttackTargetWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
