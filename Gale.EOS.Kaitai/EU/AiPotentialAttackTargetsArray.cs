// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array AI_POTENTIAL_ATTACK_TARGETS defined within pmdsky.
    /// </summary>
    public partial class AiPotentialAttackTargetsArray : KaitaiStruct
    {
        public static AiPotentialAttackTargetsArray FromFile(string fileName)
        {
            return new AiPotentialAttackTargetsArray(new KaitaiStream(fileName));
        }

        public AiPotentialAttackTargetsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiPotentialAttackTargetsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiPotentialAttackTargetsArrayDim0(m_io, this, m_root);
        }
        public partial class AiPotentialAttackTargetsArrayDim0 : KaitaiStruct
        {
            public static AiPotentialAttackTargetsArrayDim0 FromFile(string fileName)
            {
                return new AiPotentialAttackTargetsArrayDim0(new KaitaiStream(fileName));
            }

            public AiPotentialAttackTargetsArrayDim0(KaitaiStream p__io, AiPotentialAttackTargetsArray p__parent = null, AiPotentialAttackTargetsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private AiPotentialAttackTargetsArray m_root;
            private AiPotentialAttackTargetsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public AiPotentialAttackTargetsArray M_Root { get { return m_root; } }
            public AiPotentialAttackTargetsArray M_Parent { get { return m_parent; } }
        }
        private AiPotentialAttackTargetsArrayDim0 _entries;
        private AiPotentialAttackTargetsArray m_root;
        private KaitaiStruct m_parent;
        public AiPotentialAttackTargetsArrayDim0 Entries { get { return _entries; } }
        public AiPotentialAttackTargetsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
