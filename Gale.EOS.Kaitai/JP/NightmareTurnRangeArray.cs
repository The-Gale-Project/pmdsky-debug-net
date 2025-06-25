// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array NIGHTMARE_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class NightmareTurnRangeArray : KaitaiStruct
    {
        public static NightmareTurnRangeArray FromFile(string fileName)
        {
            return new NightmareTurnRangeArray(new KaitaiStream(fileName));
        }

        public NightmareTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, NightmareTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new NightmareTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class NightmareTurnRangeArrayDim0 : KaitaiStruct
        {
            public static NightmareTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new NightmareTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public NightmareTurnRangeArrayDim0(KaitaiStream p__io, NightmareTurnRangeArray p__parent = null, NightmareTurnRangeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private NightmareTurnRangeArray m_root;
            private NightmareTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public NightmareTurnRangeArray M_Root { get { return m_root; } }
            public NightmareTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private NightmareTurnRangeArrayDim0 _entries;
        private NightmareTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public NightmareTurnRangeArrayDim0 Entries { get { return _entries; } }
        public NightmareTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
