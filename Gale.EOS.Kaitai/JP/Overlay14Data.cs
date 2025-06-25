// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay14Data : KaitaiStruct
    {
        public static Overlay14Data FromFile(string fileName)
        {
            return new Overlay14Data(new KaitaiStream(fileName));
        }

        public Overlay14Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay14Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_stringIdSentryThatsAll = false;
            f_sentryChatotMonsterId = false;
            f_sentryDutyPtr = false;
            f_sentryGrovyleMonsterId = false;
            f_stringIdSentryNoMoreVisitors = false;
            f_sentryDebugMenuItems = false;
            f_sentryDutyStateHandlerTable = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_stringIdSentryThatsAll;
        private int _stringIdSentryThatsAll;

        /// <summary>
        /// String ID 0x6F6:
        ///  OK, got that![C]
        ///  Hey, [partner] and
        /// [hero]![C]
        ///  That's all for today! Now get
        /// back here!
        /// </summary>
        public int StringIdSentryThatsAll
        {
            get
            {
                if (f_stringIdSentryThatsAll)
                    return _stringIdSentryThatsAll;
                long _pos = m_io.Pos;
                m_io.Seek(8296);
                _stringIdSentryThatsAll = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryThatsAll = true;
                return _stringIdSentryThatsAll;
            }
        }
        private bool f_sentryChatotMonsterId;
        private MonsterId _sentryChatotMonsterId;

        /// <summary>
        /// Monster ID for Chatot, used as the speaker ID for dialogue.
        /// </summary>
        public MonsterId SentryChatotMonsterId
        {
            get
            {
                if (f_sentryChatotMonsterId)
                    return _sentryChatotMonsterId;
                long _pos = m_io.Pos;
                m_io.Seek(8288);
                _sentryChatotMonsterId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_sentryChatotMonsterId = true;
                return _sentryChatotMonsterId;
            }
        }
        private bool f_sentryDutyPtr;
        private Pointer _sentryDutyPtr;

        /// <summary>
        /// Pointer to the SENTRY_DUTY_STRUCT.
        /// </summary>
        public Pointer SentryDutyPtr
        {
            get
            {
                if (f_sentryDutyPtr)
                    return _sentryDutyPtr;
                long _pos = m_io.Pos;
                m_io.Seek(14912);
                _sentryDutyPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_sentryDutyPtr = true;
                return _sentryDutyPtr;
            }
        }
        private bool f_sentryGrovyleMonsterId;
        private MonsterId _sentryGrovyleMonsterId;

        /// <summary>
        /// Monster ID for Grovyle, which appears to be explicitly excluded when generating species choices.
        /// </summary>
        public MonsterId SentryGrovyleMonsterId
        {
            get
            {
                if (f_sentryGrovyleMonsterId)
                    return _sentryGrovyleMonsterId;
                long _pos = m_io.Pos;
                m_io.Seek(10540);
                _sentryGrovyleMonsterId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_sentryGrovyleMonsterId = true;
                return _sentryGrovyleMonsterId;
            }
        }
        private bool f_stringIdSentryNoMoreVisitors;
        private int _stringIdSentryNoMoreVisitors;

        /// <summary>
        /// String ID 0x6F5:
        ///  [se_play:0]No more visitors! No more
        /// visitors! ♪
        /// </summary>
        public int StringIdSentryNoMoreVisitors
        {
            get
            {
                if (f_stringIdSentryNoMoreVisitors)
                    return _stringIdSentryNoMoreVisitors;
                long _pos = m_io.Pos;
                m_io.Seek(8292);
                _stringIdSentryNoMoreVisitors = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryNoMoreVisitors = true;
                return _stringIdSentryNoMoreVisitors;
            }
        }
        private bool f_sentryDebugMenuItems;
        private SentryDebugMenuItemsArray _sentryDebugMenuItems;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public SentryDebugMenuItemsArray SentryDebugMenuItems
        {
            get
            {
                if (f_sentryDebugMenuItems)
                    return _sentryDebugMenuItems;
                long _pos = m_io.Pos;
                m_io.Seek(14696);
                _sentryDebugMenuItems = new SentryDebugMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_sentryDebugMenuItems = true;
                return _sentryDebugMenuItems;
            }
        }
        private bool f_sentryDutyStateHandlerTable;
        private SentryDutyStateHandlerTableArray _sentryDutyStateHandlerTable;

        /// <summary>
        /// Null-terminated table of handler functions for the different states in the state machine. See SentryRunState.
        /// 
        /// type: state_handler_fn_t[35]
        /// </summary>
        public SentryDutyStateHandlerTableArray SentryDutyStateHandlerTable
        {
            get
            {
                if (f_sentryDutyStateHandlerTable)
                    return _sentryDutyStateHandlerTable;
                long _pos = m_io.Pos;
                m_io.Seek(14932);
                _sentryDutyStateHandlerTable = new SentryDutyStateHandlerTableArray(m_io);
                m_io.Seek(_pos);
                f_sentryDutyStateHandlerTable = true;
                return _sentryDutyStateHandlerTable;
            }
        }
        private Overlay14Data m_root;
        private KaitaiStruct m_parent;
        public Overlay14Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
