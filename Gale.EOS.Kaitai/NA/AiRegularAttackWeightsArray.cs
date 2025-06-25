// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array AI_REGULAR_ATTACK_WEIGHTS defined within pmdsky.
    /// </summary>
    public partial class AiRegularAttackWeightsArray : KaitaiStruct
    {
        public static AiRegularAttackWeightsArray FromFile(string fileName)
        {
            return new AiRegularAttackWeightsArray(new KaitaiStream(fileName));
        }

        public AiRegularAttackWeightsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiRegularAttackWeightsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiRegularAttackWeightsArrayDim0(m_io, this, m_root);
        }
        public partial class AiRegularAttackWeightsArrayDim0 : KaitaiStruct
        {
            public static AiRegularAttackWeightsArrayDim0 FromFile(string fileName)
            {
                return new AiRegularAttackWeightsArrayDim0(new KaitaiStream(fileName));
            }

            public AiRegularAttackWeightsArrayDim0(KaitaiStream p__io, AiRegularAttackWeightsArray p__parent = null, AiRegularAttackWeightsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 5; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private AiRegularAttackWeightsArray m_root;
            private AiRegularAttackWeightsArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public AiRegularAttackWeightsArray M_Root { get { return m_root; } }
            public AiRegularAttackWeightsArray M_Parent { get { return m_parent; } }
        }
        private AiRegularAttackWeightsArrayDim0 _entries;
        private AiRegularAttackWeightsArray m_root;
        private KaitaiStruct m_parent;
        public AiRegularAttackWeightsArrayDim0 Entries { get { return _entries; } }
        public AiRegularAttackWeightsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
