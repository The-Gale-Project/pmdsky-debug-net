// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents a struct or union action_parameter defined within pmdsky-debug.
    /// </summary>
    public partial class ActionParameter : KaitaiStruct
    {
        public static ActionParameter FromFile(string fileName)
        {
            return new ActionParameter(new KaitaiStream(fileName));
        }

        public ActionParameter(KaitaiStream p__io, KaitaiStruct p__parent = null, ActionParameter p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _actionUseIdx = m_io.ReadU1();
            _field0x1 = m_io.ReadU1();
            _itemPos = new Position(m_io);
        }
        private byte _actionUseIdx;
        private byte _field0x1;
        private Position _itemPos;
        private ActionParameter m_root;
        private KaitaiStruct m_parent;
        public byte ActionUseIdx { get { return _actionUseIdx; } }
        public byte Field0x1 { get { return _field0x1; } }
        public Position ItemPos { get { return _itemPos; } }
        public ActionParameter M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
