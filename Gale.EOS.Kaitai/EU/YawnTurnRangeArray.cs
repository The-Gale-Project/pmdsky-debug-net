// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array YAWN_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class YawnTurnRangeArray : KaitaiStruct
    {
        public static YawnTurnRangeArray FromFile(string fileName)
        {
            return new YawnTurnRangeArray(new KaitaiStream(fileName));
        }

        public YawnTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, YawnTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new YawnTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class YawnTurnRangeArrayDim0 : KaitaiStruct
        {
            public static YawnTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new YawnTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public YawnTurnRangeArrayDim0(KaitaiStream p__io, YawnTurnRangeArray p__parent = null, YawnTurnRangeArray p__root = null) : base(p__io)
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
            private YawnTurnRangeArray m_root;
            private YawnTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public YawnTurnRangeArray M_Root { get { return m_root; } }
            public YawnTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private YawnTurnRangeArrayDim0 _entries;
        private YawnTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public YawnTurnRangeArrayDim0 Entries { get { return _entries; } }
        public YawnTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
