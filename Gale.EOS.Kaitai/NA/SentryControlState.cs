// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum sentry_control_state.
    /// </summary>
    public partial class SentryControlState : KaitaiStruct
    {
        public static SentryControlState FromFile(string fileName)
        {
            return new SentryControlState(new KaitaiStream(fileName));
        }


        public enum SentryControlStateEnum
        {
            SentryCtrlContinue = 0,
            SentryCtrlStateTransition = 1,
            SentryCtrlPostTransition = 2,
            SentryCtrlIntermediateTransition = 3,
        }
        public SentryControlState(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryControlState p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _sentryControlStateValue = ((SentryControlStateEnum) m_io.ReadBitsIntLe(32));
        }
        private SentryControlStateEnum _sentryControlStateValue;
        private SentryControlState m_root;
        private KaitaiStruct m_parent;
        public SentryControlStateEnum SentryControlStateValue { get { return _sentryControlStateValue; } }
        public SentryControlState M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
