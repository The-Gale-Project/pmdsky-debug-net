// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union action_data defined within pmdsky-debug.
    /// </summary>
    public partial class ActionData : KaitaiStruct
    {
        public static ActionData FromFile(string fileName)
        {
            return new ActionData(new KaitaiStream(fileName));
        }

        public ActionData(KaitaiStream p__io, KaitaiStruct p__parent = null, ActionData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _actionId = new Action16(m_io);
            _direction = new DirectionId8(m_io);
            _field0x3 = m_io.ReadU1();
            _actionParameters = new ActionDataActionParametersArray(m_io);
            _arcItemTargetPos = new Position(m_io);
        }
        private Action16 _actionId;
        private DirectionId8 _direction;
        private byte _field0x3;
        private ActionDataActionParametersArray _actionParameters;
        private Position _arcItemTargetPos;
        private ActionData m_root;
        private KaitaiStruct m_parent;
        public Action16 ActionId { get { return _actionId; } }
        public DirectionId8 Direction { get { return _direction; } }
        public byte Field0x3 { get { return _field0x3; } }
        public ActionDataActionParametersArray ActionParameters { get { return _actionParameters; } }
        public Position ArcItemTargetPos { get { return _arcItemTargetPos; } }
        public ActionData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
