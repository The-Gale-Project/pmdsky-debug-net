// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array AI_CAN_ATTACK_IN_DIRECTION defined within pmdsky.
    /// </summary>
    public partial class AiCanAttackInDirectionArray : KaitaiStruct
    {
        public static AiCanAttackInDirectionArray FromFile(string fileName)
        {
            return new AiCanAttackInDirectionArray(new KaitaiStream(fileName));
        }

        public AiCanAttackInDirectionArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiCanAttackInDirectionArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiCanAttackInDirectionArrayDim0(m_io, this, m_root);
        }
        public partial class AiCanAttackInDirectionArrayDim0 : KaitaiStruct
        {
            public static AiCanAttackInDirectionArrayDim0 FromFile(string fileName)
            {
                return new AiCanAttackInDirectionArrayDim0(new KaitaiStream(fileName));
            }

            public AiCanAttackInDirectionArrayDim0(KaitaiStream p__io, AiCanAttackInDirectionArray p__parent = null, AiCanAttackInDirectionArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private AiCanAttackInDirectionArray m_root;
            private AiCanAttackInDirectionArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public AiCanAttackInDirectionArray M_Root { get { return m_root; } }
            public AiCanAttackInDirectionArray M_Parent { get { return m_parent; } }
        }
        private AiCanAttackInDirectionArrayDim0 _entries;
        private AiCanAttackInDirectionArray m_root;
        private KaitaiStruct m_parent;
        public AiCanAttackInDirectionArrayDim0 Entries { get { return _entries; } }
        public AiCanAttackInDirectionArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
