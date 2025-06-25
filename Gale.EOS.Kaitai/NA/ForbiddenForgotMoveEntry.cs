// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union forbidden_forgot_move_entry defined within pmdsky-debug.
    /// </summary>
    public partial class ForbiddenForgotMoveEntry : KaitaiStruct
    {
        public static ForbiddenForgotMoveEntry FromFile(string fileName)
        {
            return new ForbiddenForgotMoveEntry(new KaitaiStream(fileName));
        }

        public ForbiddenForgotMoveEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, ForbiddenForgotMoveEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _monsterId = new MonsterId16(m_io);
            _originId = new DungeonId16(m_io);
            _moveId = new MoveId16(m_io);
        }
        private MonsterId16 _monsterId;
        private DungeonId16 _originId;
        private MoveId16 _moveId;
        private ForbiddenForgotMoveEntry m_root;
        private KaitaiStruct m_parent;
        public MonsterId16 MonsterId { get { return _monsterId; } }
        public DungeonId16 OriginId { get { return _originId; } }
        public MoveId16 MoveId { get { return _moveId; } }
        public ForbiddenForgotMoveEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
