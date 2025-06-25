// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds the data for the enum sentry_completion_state.
    /// </summary>
    public partial class SentryCompletionState : KaitaiStruct
    {
        public static SentryCompletionState FromFile(string fileName)
        {
            return new SentryCompletionState(new KaitaiStream(fileName));
        }


        public enum SentryCompletionStateEnum
        {
            SentryCompletionInProgress = 0,
            SentryCompletionExiting = 1,
            SentryCompletionFinalizing = 2,
            SentryCompletionDone = 3,
        }
        public SentryCompletionState(KaitaiStream p__io, KaitaiStruct p__parent = null, SentryCompletionState p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _sentryCompletionStateValue = ((SentryCompletionStateEnum) m_io.ReadBitsIntLe(32));
        }
        private SentryCompletionStateEnum _sentryCompletionStateValue;
        private SentryCompletionState m_root;
        private KaitaiStruct m_parent;
        public SentryCompletionStateEnum SentryCompletionStateValue { get { return _sentryCompletionStateValue; } }
        public SentryCompletionState M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
