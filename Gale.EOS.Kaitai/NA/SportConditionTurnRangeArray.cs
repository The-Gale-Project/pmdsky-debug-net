// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SPORT_CONDITION_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class SportConditionTurnRangeArray : KaitaiStruct
    {
        public static SportConditionTurnRangeArray FromFile(string fileName)
        {
            return new SportConditionTurnRangeArray(new KaitaiStream(fileName));
        }

        public SportConditionTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SportConditionTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SportConditionTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class SportConditionTurnRangeArrayDim0 : KaitaiStruct
        {
            public static SportConditionTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new SportConditionTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public SportConditionTurnRangeArrayDim0(KaitaiStream p__io, SportConditionTurnRangeArray p__parent = null, SportConditionTurnRangeArray p__root = null) : base(p__io)
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
            private SportConditionTurnRangeArray m_root;
            private SportConditionTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public SportConditionTurnRangeArray M_Root { get { return m_root; } }
            public SportConditionTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private SportConditionTurnRangeArrayDim0 _entries;
        private SportConditionTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public SportConditionTurnRangeArrayDim0 Entries { get { return _entries; } }
        public SportConditionTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
