// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array PUNCH_MOVE_LIST defined within pmdsky.
    /// </summary>
    public partial class PunchMoveListArray : KaitaiStruct
    {
        public static PunchMoveListArray FromFile(string fileName)
        {
            return new PunchMoveListArray(new KaitaiStream(fileName));
        }

        public PunchMoveListArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PunchMoveListArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PunchMoveListArrayDim0(m_io, this, m_root);
        }
        public partial class PunchMoveListArrayDim0 : KaitaiStruct
        {
            public static PunchMoveListArrayDim0 FromFile(string fileName)
            {
                return new PunchMoveListArrayDim0(new KaitaiStream(fileName));
            }

            public PunchMoveListArrayDim0(KaitaiStream p__io, PunchMoveListArray p__parent = null, PunchMoveListArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MoveId16>();
                for (var i = 0; i < 16; i++)
                {
                    _entries.Add(new MoveId16(m_io));
                }
            }
            private List<MoveId16> _entries;
            private PunchMoveListArray m_root;
            private PunchMoveListArray m_parent;
            public List<MoveId16> Entries { get { return _entries; } }
            public PunchMoveListArray M_Root { get { return m_root; } }
            public PunchMoveListArray M_Parent { get { return m_parent; } }
        }
        private PunchMoveListArrayDim0 _entries;
        private PunchMoveListArray m_root;
        private KaitaiStruct m_parent;
        public PunchMoveListArrayDim0 Entries { get { return _entries; } }
        public PunchMoveListArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
