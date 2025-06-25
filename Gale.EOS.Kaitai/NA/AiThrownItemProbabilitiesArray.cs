// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array AI_THROWN_ITEM_PROBABILITIES defined within pmdsky.
    /// </summary>
    public partial class AiThrownItemProbabilitiesArray : KaitaiStruct
    {
        public static AiThrownItemProbabilitiesArray FromFile(string fileName)
        {
            return new AiThrownItemProbabilitiesArray(new KaitaiStream(fileName));
        }

        public AiThrownItemProbabilitiesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiThrownItemProbabilitiesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiThrownItemProbabilitiesArrayDim0(m_io, this, m_root);
        }
        public partial class AiThrownItemProbabilitiesArrayDim0 : KaitaiStruct
        {
            public static AiThrownItemProbabilitiesArrayDim0 FromFile(string fileName)
            {
                return new AiThrownItemProbabilitiesArrayDim0(new KaitaiStream(fileName));
            }

            public AiThrownItemProbabilitiesArrayDim0(KaitaiStream p__io, AiThrownItemProbabilitiesArray p__parent = null, AiThrownItemProbabilitiesArray p__root = null) : base(p__io)
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
            private AiThrownItemProbabilitiesArray m_root;
            private AiThrownItemProbabilitiesArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public AiThrownItemProbabilitiesArray M_Root { get { return m_root; } }
            public AiThrownItemProbabilitiesArray M_Parent { get { return m_parent; } }
        }
        private AiThrownItemProbabilitiesArrayDim0 _entries;
        private AiThrownItemProbabilitiesArray m_root;
        private KaitaiStruct m_parent;
        public AiThrownItemProbabilitiesArrayDim0 Entries { get { return _entries; } }
        public AiThrownItemProbabilitiesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
