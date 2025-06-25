// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
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
            f_sentryDebugMenuItems = false;
            f_sentryDutyPtr = false;
            f_sentryDutyStateHandlerTable = false;
            _read();
        }
        private void _read()
        {
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
                m_io.Seek(14784);
                _sentryDebugMenuItems = new SentryDebugMenuItemsArray(m_io);
                m_io.Seek(_pos);
                f_sentryDebugMenuItems = true;
                return _sentryDebugMenuItems;
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
                m_io.Seek(15008);
                _sentryDutyPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_sentryDutyPtr = true;
                return _sentryDutyPtr;
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
                m_io.Seek(15028);
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
