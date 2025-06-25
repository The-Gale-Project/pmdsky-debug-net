// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union wildcard_move_desc defined within pmdsky-debug.
    /// </summary>
    public partial class WildcardMoveDesc : KaitaiStruct
    {
        public static WildcardMoveDesc FromFile(string fileName)
        {
            return new WildcardMoveDesc(new KaitaiStream(fileName));
        }

        public WildcardMoveDesc(KaitaiStream p__io, KaitaiStruct p__parent = null, WildcardMoveDesc p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _moveId = new MoveId16(m_io);
            _padding = m_io.ReadU2le();
            _doMove = new Pointer(m_io);
        }
        private MoveId16 _moveId;
        private ushort _padding;
        private Pointer _doMove;
        private WildcardMoveDesc m_root;
        private KaitaiStruct m_parent;
        public MoveId16 MoveId { get { return _moveId; } }
        public ushort Padding { get { return _padding; } }
        public Pointer DoMove { get { return _doMove; } }
        public WildcardMoveDesc M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
