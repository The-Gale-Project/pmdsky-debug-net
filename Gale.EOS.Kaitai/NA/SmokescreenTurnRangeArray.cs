// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array SMOKESCREEN_TURN_RANGE defined within pmdsky.
    /// </summary>
    public partial class SmokescreenTurnRangeArray : KaitaiStruct
    {
        public static SmokescreenTurnRangeArray FromFile(string fileName)
        {
            return new SmokescreenTurnRangeArray(new KaitaiStream(fileName));
        }

        public SmokescreenTurnRangeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, SmokescreenTurnRangeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new SmokescreenTurnRangeArrayDim0(m_io, this, m_root);
        }
        public partial class SmokescreenTurnRangeArrayDim0 : KaitaiStruct
        {
            public static SmokescreenTurnRangeArrayDim0 FromFile(string fileName)
            {
                return new SmokescreenTurnRangeArrayDim0(new KaitaiStream(fileName));
            }

            public SmokescreenTurnRangeArrayDim0(KaitaiStream p__io, SmokescreenTurnRangeArray p__parent = null, SmokescreenTurnRangeArray p__root = null) : base(p__io)
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
            private SmokescreenTurnRangeArray m_root;
            private SmokescreenTurnRangeArray m_parent;
            public List<short> Entries { get { return _entries; } }
            public SmokescreenTurnRangeArray M_Root { get { return m_root; } }
            public SmokescreenTurnRangeArray M_Parent { get { return m_parent; } }
        }
        private SmokescreenTurnRangeArrayDim0 _entries;
        private SmokescreenTurnRangeArray m_root;
        private KaitaiStruct m_parent;
        public SmokescreenTurnRangeArrayDim0 Entries { get { return _entries; } }
        public SmokescreenTurnRangeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
