// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array SPEED_BOOST_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class SpeedBoostTurnRangeArray : KaitaiStruct
    {
        public static SpeedBoostTurnRangeArray FromFile(string fileName)
        {
            return new SpeedBoostTurnRangeArray(new KaitaiStream(fileName));
        }

        public SpeedBoostTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SpeedBoostTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SpeedBoostTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class SpeedBoostTurnRangeArrayDim0 : KaitaiStruct
        {
            public static SpeedBoostTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new SpeedBoostTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public SpeedBoostTurnRangeArrayDim0(KaitaiStream p__io, SpeedBoostTurnRangeArray p__parent = null, SpeedBoostTurnRangeArray p__root = null) : base(p__io)
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
            private SpeedBoostTurnRangeArray m_root;
            private SpeedBoostTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public SpeedBoostTurnRangeArray M_Root { get { return m_root; } }
            public SpeedBoostTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private SpeedBoostTurnRangeArrayDim0 _entries;
        private SpeedBoostTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public SpeedBoostTurnRangeArrayDim0 Entries { get { return _entries; } }
        public SpeedBoostTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
