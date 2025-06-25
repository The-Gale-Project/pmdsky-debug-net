// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array FRACTIONAL_TURN_SEQUENCE defined within pmdsky.
    /// </summary>
    public partial class FractionalTurnSequenceArray : KaitaiStruct
    {
        public static FractionalTurnSequenceArray FromFile(string fileName)
        {
            return new FractionalTurnSequenceArray(new KaitaiStream(fileName));
        }

        public FractionalTurnSequenceArray(KaitaiStream p__io, KaitaiStruct p__parent = null, FractionalTurnSequenceArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new FractionalTurnSequenceArrayDim0(m_io, this, m_root);
        }
        public partial class FractionalTurnSequenceArrayDim0 : KaitaiStruct
        {
            public static FractionalTurnSequenceArrayDim0 FromFile(string fileName)
            {
                return new FractionalTurnSequenceArrayDim0(new KaitaiStream(fileName));
            }

            public FractionalTurnSequenceArrayDim0(KaitaiStream p__io, FractionalTurnSequenceArray p__parent = null, FractionalTurnSequenceArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 125; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private FractionalTurnSequenceArray m_root;
            private FractionalTurnSequenceArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public FractionalTurnSequenceArray M_Root { get { return m_root; } }
            public FractionalTurnSequenceArray M_Parent { get { return m_parent; } }
        }
        private FractionalTurnSequenceArrayDim0 _entries;
        private FractionalTurnSequenceArray m_root;
        private KaitaiStruct m_parent;
        public FractionalTurnSequenceArrayDim0 Entries { get { return _entries; } }
        public FractionalTurnSequenceArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
