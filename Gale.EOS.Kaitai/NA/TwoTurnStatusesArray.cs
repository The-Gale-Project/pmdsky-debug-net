// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array TWO_TURN_STATUSES defined within pmdsky.
    /// </summary>
    public partial class TwoTurnStatusesArray : KaitaiStruct
    {
        public static TwoTurnStatusesArray FromFile(string fileName)
        {
            return new TwoTurnStatusesArray(new KaitaiStream(fileName));
        }

        public TwoTurnStatusesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TwoTurnStatusesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TwoTurnStatusesArrayDim0(m_io, this, m_root);
        }
        public partial class TwoTurnStatusesArrayDim0 : KaitaiStruct
        {
            public static TwoTurnStatusesArrayDim0 FromFile(string fileName)
            {
                return new TwoTurnStatusesArrayDim0(new KaitaiStream(fileName));
            }

            public TwoTurnStatusesArrayDim0(KaitaiStream p__io, TwoTurnStatusesArray p__parent = null, TwoTurnStatusesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusTwoTurnId8>();
                for (var i = 0; i < 11; i++)
                {
                    _entries.Add(new StatusTwoTurnId8(m_io));
                }
            }
            private List<StatusTwoTurnId8> _entries;
            private TwoTurnStatusesArray m_root;
            private TwoTurnStatusesArray m_parent;
            public List<StatusTwoTurnId8> Entries { get { return _entries; } }
            public TwoTurnStatusesArray M_Root { get { return m_root; } }
            public TwoTurnStatusesArray M_Parent { get { return m_parent; } }
        }
        private TwoTurnStatusesArrayDim0 _entries;
        private TwoTurnStatusesArray m_root;
        private KaitaiStruct m_parent;
        public TwoTurnStatusesArrayDim0 Entries { get { return _entries; } }
        public TwoTurnStatusesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
