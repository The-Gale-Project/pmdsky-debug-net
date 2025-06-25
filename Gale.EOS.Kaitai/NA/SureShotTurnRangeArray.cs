// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SURE_SHOT_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class SureShotTurnRangeArray : KaitaiStruct
    {
        public static SureShotTurnRangeArray FromFile(string fileName)
        {
            return new SureShotTurnRangeArray(new KaitaiStream(fileName));
        }

        public SureShotTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SureShotTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SureShotTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class SureShotTurnRangeArrayDim0 : KaitaiStruct
        {
            public static SureShotTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new SureShotTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public SureShotTurnRangeArrayDim0(KaitaiStream p__io, SureShotTurnRangeArray p__parent = null, SureShotTurnRangeArray p__root = null) : base(p__io)
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
            private SureShotTurnRangeArray m_root;
            private SureShotTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public SureShotTurnRangeArray M_Root { get { return m_root; } }
            public SureShotTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private SureShotTurnRangeArrayDim0 _entries;
        private SureShotTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public SureShotTurnRangeArrayDim0 Entries { get { return _entries; } }
        public SureShotTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
