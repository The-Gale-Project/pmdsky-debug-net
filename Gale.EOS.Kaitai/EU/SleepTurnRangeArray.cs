// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array SLEEP_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class SleepTurnRangeArray : KaitaiStruct
    {
        public static SleepTurnRangeArray FromFile(string fileName)
        {
            return new SleepTurnRangeArray(new KaitaiStream(fileName));
        }

        public SleepTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SleepTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SleepTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class SleepTurnRangeArrayDim0 : KaitaiStruct
        {
            public static SleepTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new SleepTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public SleepTurnRangeArrayDim0(KaitaiStream p__io, SleepTurnRangeArray p__parent = null, SleepTurnRangeArray p__root = null) : base(p__io)
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
            private SleepTurnRangeArray m_root;
            private SleepTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public SleepTurnRangeArray M_Root { get { return m_root; } }
            public SleepTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private SleepTurnRangeArrayDim0 _entries;
        private SleepTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public SleepTurnRangeArrayDim0 Entries { get { return _entries; } }
        public SleepTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
