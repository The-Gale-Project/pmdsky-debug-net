// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union two_turn_move_and_status defined within pmdsky-debug.
    /// </summary>
    public partial class TwoTurnMoveAndStatus : KaitaiStruct
    {
        public static TwoTurnMoveAndStatus FromFile(string fileName)
        {
            return new TwoTurnMoveAndStatus(new KaitaiStream(fileName));
        }

        public TwoTurnMoveAndStatus(KaitaiStream p__io, KaitaiStruct p__parent = null, TwoTurnMoveAndStatus p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _move = new MoveId16(m_io);
            _status = new StatusTwoTurnId16(m_io);
        }
        private MoveId16 _move;
        private StatusTwoTurnId16 _status;
        private TwoTurnMoveAndStatus m_root;
        private KaitaiStruct m_parent;
        public MoveId16 Move { get { return _move; } }
        public StatusTwoTurnId16 Status { get { return _status; } }
        public TwoTurnMoveAndStatus M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
