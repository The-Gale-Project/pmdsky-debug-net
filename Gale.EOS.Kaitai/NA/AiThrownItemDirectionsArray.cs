// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array AI_THROWN_ITEM_DIRECTIONS defined within pmdsky.
    /// </summary>
    public partial class AiThrownItemDirectionsArray : KaitaiStruct
    {
        public static AiThrownItemDirectionsArray FromFile(string fileName)
        {
            return new AiThrownItemDirectionsArray(new KaitaiStream(fileName));
        }

        public AiThrownItemDirectionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiThrownItemDirectionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiThrownItemDirectionsArrayDim0(m_io, this, m_root);
        }
        public partial class AiThrownItemDirectionsArrayDim0 : KaitaiStruct
        {
            public static AiThrownItemDirectionsArrayDim0 FromFile(string fileName)
            {
                return new AiThrownItemDirectionsArrayDim0(new KaitaiStream(fileName));
            }

            public AiThrownItemDirectionsArrayDim0(KaitaiStream p__io, AiThrownItemDirectionsArray p__parent = null, AiThrownItemDirectionsArray p__root = null) : base(p__io)
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
            private AiThrownItemDirectionsArray m_root;
            private AiThrownItemDirectionsArray m_parent;
            public List<uint> Entries { get { return _entries; } }
            public AiThrownItemDirectionsArray M_Root { get { return m_root; } }
            public AiThrownItemDirectionsArray M_Parent { get { return m_parent; } }
        }
        private AiThrownItemDirectionsArrayDim0 _entries;
        private AiThrownItemDirectionsArray m_root;
        private KaitaiStruct m_parent;
        public AiThrownItemDirectionsArrayDim0 Entries { get { return _entries; } }
        public AiThrownItemDirectionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
