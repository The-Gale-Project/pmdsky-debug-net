// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array TWO_TURN_MOVES_AND_STATUSES defined within pmdsky.
    /// </summary>
    public partial class TwoTurnMovesAndStatusesArray : KaitaiStruct
    {
        public static TwoTurnMovesAndStatusesArray FromFile(string fileName)
        {
            return new TwoTurnMovesAndStatusesArray(new KaitaiStream(fileName));
        }

        public TwoTurnMovesAndStatusesArray(KaitaiStream p__io, KaitaiStruct p__parent = null, TwoTurnMovesAndStatusesArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new TwoTurnMovesAndStatusesArrayDim0(m_io, this, m_root);
        }
        public partial class TwoTurnMovesAndStatusesArrayDim0 : KaitaiStruct
        {
            public static TwoTurnMovesAndStatusesArrayDim0 FromFile(string fileName)
            {
                return new TwoTurnMovesAndStatusesArrayDim0(new KaitaiStream(fileName));
            }

            public TwoTurnMovesAndStatusesArrayDim0(KaitaiStream p__io, TwoTurnMovesAndStatusesArray p__parent = null, TwoTurnMovesAndStatusesArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<TwoTurnMoveAndStatus>();
                for (var i = 0; i < 22; i++)
                {
                    _entries.Add(new TwoTurnMoveAndStatus(m_io));
                }
            }
            private List<TwoTurnMoveAndStatus> _entries;
            private TwoTurnMovesAndStatusesArray m_root;
            private TwoTurnMovesAndStatusesArray m_parent;
            public List<TwoTurnMoveAndStatus> Entries { get { return _entries; } }
            public TwoTurnMovesAndStatusesArray M_Root { get { return m_root; } }
            public TwoTurnMovesAndStatusesArray M_Parent { get { return m_parent; } }
        }
        private TwoTurnMovesAndStatusesArrayDim0 _entries;
        private TwoTurnMovesAndStatusesArray m_root;
        private KaitaiStruct m_parent;
        public TwoTurnMovesAndStatusesArrayDim0 Entries { get { return _entries; } }
        public TwoTurnMovesAndStatusesArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
