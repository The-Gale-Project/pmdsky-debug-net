// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array REST_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class RestTurnRangeArray : KaitaiStruct
    {
        public static RestTurnRangeArray FromFile(string fileName)
        {
            return new RestTurnRangeArray(new KaitaiStream(fileName));
        }

        public RestTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, RestTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new RestTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class RestTurnRangeArrayDim0 : KaitaiStruct
        {
            public static RestTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new RestTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public RestTurnRangeArrayDim0(KaitaiStream p__io, RestTurnRangeArray p__parent = null, RestTurnRangeArray p__root = null) : base(p__io)
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
            private RestTurnRangeArray m_root;
            private RestTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public RestTurnRangeArray M_Root { get { return m_root; } }
            public RestTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private RestTurnRangeArrayDim0 _entries;
        private RestTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public RestTurnRangeArrayDim0 Entries { get { return _entries; } }
        public RestTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
