// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
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
            f_stringIdSentryComeIn6ed = false;
            f_stringIdSentryWrong = false;
            f_stringIdSentryTryAgain = false;
            f_stringIdSentryThatsAll = false;
            f_stringIdSentryInstructions = false;
            f_sentryChatotMonsterId = false;
            f_stringIdSentryKeepYouWaiting = false;
            f_sentryDutyPtr = false;
            f_stringIdSentryTopSessions = false;
            f_stringIdSentryFootprintIs6ec = false;
            f_sentryGrovyleMonsterId = false;
            f_stringIdSentryNoMoreVisitors = false;
            f_stringIdSentryFootprintIs6ee = false;
            f_stringIdSentryThatllDoIt = false;
            f_sentryDutyStructSize = false;
            f_sentryLoudredMonsterId = false;
            f_stringIdSentryHereComes = false;
            f_sentryDebugMenuItems = false;
            f_sentryDutyStateHandlerTable = false;
            f_stringIdSentryOutOfTime = false;
            f_stringIdSentryWhoseFootprint = false;
            f_stringIdSentryBuckUp = false;
            f_stringIdSentryComeIn6ef = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_stringIdSentryComeIn6ed;
        private int _stringIdSentryComeIn6ed;

        /// <summary>
        /// String ID 0x6ED:
        ///  Heard ya! Come in, visitor![W:30]
        /// </summary>
        public int StringIdSentryComeIn6ed
        {
            get
            {
                if (f_stringIdSentryComeIn6ed)
                    return _stringIdSentryComeIn6ed;
                long _pos = m_io.Pos;
                m_io.Seek(8264);
                _stringIdSentryComeIn6ed = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryComeIn6ed = true;
                return _stringIdSentryComeIn6ed;
            }
        }
        private bool f_stringIdSentryWrong;
        private int _stringIdSentryWrong;

        /// <summary>
        /// String ID 0x6F1:
        ///  ......[se_play:0][W:30]Huh?! Looks wrong to me![W:50]
        /// </summary>
        public int StringIdSentryWrong
        {
            get
            {
                if (f_stringIdSentryWrong)
                    return _stringIdSentryWrong;
                long _pos = m_io.Pos;
                m_io.Seek(8248);
                _stringIdSentryWrong = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryWrong = true;
                return _stringIdSentryWrong;
            }
        }
        private bool f_stringIdSentryTryAgain;
        private int _stringIdSentryTryAgain;

        /// <summary>
        /// String ID 0x6EB:
        ///  Huh? I don't think so. Try again!
        /// </summary>
        public int StringIdSentryTryAgain
        {
            get
            {
                if (f_stringIdSentryTryAgain)
                    return _stringIdSentryTryAgain;
                long _pos = m_io.Pos;
                m_io.Seek(8228);
                _stringIdSentryTryAgain = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryTryAgain = true;
                return _stringIdSentryTryAgain;
            }
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
                m_io.Seek(8288);
                _stringIdSentryThatsAll = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryThatsAll = true;
                return _stringIdSentryThatsAll;
            }
        }
        private bool f_stringIdSentryInstructions;
        private int _stringIdSentryInstructions;

        /// <summary>
        /// String ID 0x6D8:
        ///  Look at the footprint on the top
        /// screen, OK? Then identify the Pokémon![C]
        ///  You can get only [CS:V]two wrong[CR], OK?
        /// [partner] will keep an eye on things!
        /// </summary>
        public int StringIdSentryInstructions
        {
            get
            {
                if (f_stringIdSentryInstructions)
                    return _stringIdSentryInstructions;
                long _pos = m_io.Pos;
                m_io.Seek(8212);
                _stringIdSentryInstructions = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryInstructions = true;
                return _stringIdSentryInstructions;
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
                m_io.Seek(8280);
                _sentryChatotMonsterId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_sentryChatotMonsterId = true;
                return _sentryChatotMonsterId;
            }
        }
        private bool f_stringIdSentryKeepYouWaiting;
        private int _stringIdSentryKeepYouWaiting;

        /// <summary>
        /// String ID 0x6F3:
        ///  [se_play:0]Sorry to keep you waiting.
        /// </summary>
        public int StringIdSentryKeepYouWaiting
        {
            get
            {
                if (f_stringIdSentryKeepYouWaiting)
                    return _stringIdSentryKeepYouWaiting;
                long _pos = m_io.Pos;
                m_io.Seek(8272);
                _stringIdSentryKeepYouWaiting = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryKeepYouWaiting = true;
                return _stringIdSentryKeepYouWaiting;
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
        private bool f_stringIdSentryTopSessions;
        private int _stringIdSentryTopSessions;

        /// <summary>
        /// String ID 0x6D9:
        ///  Here are the rankings for the
        /// top sentry sessions.
        /// </summary>
        public int StringIdSentryTopSessions
        {
            get
            {
                if (f_stringIdSentryTopSessions)
                    return _stringIdSentryTopSessions;
                long _pos = m_io.Pos;
                m_io.Seek(8208);
                _stringIdSentryTopSessions = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryTopSessions = true;
                return _stringIdSentryTopSessions;
            }
        }
        private bool f_stringIdSentryFootprintIs6ec;
        private int _stringIdSentryFootprintIs6ec;

        /// <summary>
        /// String ID 0x6EC:
        ///  The footprint is [kind:]'s!
        /// The footprint is [kind:]'s![W:60]
        /// </summary>
        public int StringIdSentryFootprintIs6ec
        {
            get
            {
                if (f_stringIdSentryFootprintIs6ec)
                    return _stringIdSentryFootprintIs6ec;
                long _pos = m_io.Pos;
                m_io.Seek(8260);
                _stringIdSentryFootprintIs6ec = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryFootprintIs6ec = true;
                return _stringIdSentryFootprintIs6ec;
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
                m_io.Seek(10532);
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
                m_io.Seek(8284);
                _stringIdSentryNoMoreVisitors = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryNoMoreVisitors = true;
                return _stringIdSentryNoMoreVisitors;
            }
        }
        private bool f_stringIdSentryFootprintIs6ee;
        private int _stringIdSentryFootprintIs6ee;

        /// <summary>
        /// String ID 0x6EE:
        ///  The footprint is [kind:]'s!
        /// The footprint is [kind:]'s![W:60]
        /// </summary>
        public int StringIdSentryFootprintIs6ee
        {
            get
            {
                if (f_stringIdSentryFootprintIs6ee)
                    return _stringIdSentryFootprintIs6ee;
                long _pos = m_io.Pos;
                m_io.Seek(8236);
                _stringIdSentryFootprintIs6ee = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryFootprintIs6ee = true;
                return _stringIdSentryFootprintIs6ee;
            }
        }
        private bool f_stringIdSentryThatllDoIt;
        private int _stringIdSentryThatllDoIt;

        /// <summary>
        /// String ID 0x6F4:
        ///  [partner] and [hero]![C]
        ///  That'll do it! Now get back here!
        /// </summary>
        public int StringIdSentryThatllDoIt
        {
            get
            {
                if (f_stringIdSentryThatllDoIt)
                    return _stringIdSentryThatllDoIt;
                long _pos = m_io.Pos;
                m_io.Seek(8276);
                _stringIdSentryThatllDoIt = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryThatllDoIt = true;
                return _stringIdSentryThatllDoIt;
            }
        }
        private bool f_sentryDutyStructSize;
        private uint _sentryDutyStructSize;

        /// <summary>
        /// Number of bytes in the sentry duty struct (14548).
        /// </summary>
        public uint SentryDutyStructSize
        {
            get
            {
                if (f_sentryDutyStructSize)
                    return _sentryDutyStructSize;
                long _pos = m_io.Pos;
                m_io.Seek(964);
                _sentryDutyStructSize = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_sentryDutyStructSize = true;
                return _sentryDutyStructSize;
            }
        }
        private bool f_sentryLoudredMonsterId;
        private MonsterId _sentryLoudredMonsterId;

        /// <summary>
        /// Monster ID for Loudred, used as the speaker ID for dialogue.
        /// </summary>
        public MonsterId SentryLoudredMonsterId
        {
            get
            {
                if (f_sentryLoudredMonsterId)
                    return _sentryLoudredMonsterId;
                long _pos = m_io.Pos;
                m_io.Seek(8204);
                _sentryLoudredMonsterId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_sentryLoudredMonsterId = true;
                return _sentryLoudredMonsterId;
            }
        }
        private bool f_stringIdSentryHereComes;
        private int _stringIdSentryHereComes;

        /// <summary>
        /// String ID 0x6DA:
        ///  Here comes a Pokémon! Check
        /// its footprint and tell me what it is!
        /// </summary>
        public int StringIdSentryHereComes
        {
            get
            {
                if (f_stringIdSentryHereComes)
                    return _stringIdSentryHereComes;
                long _pos = m_io.Pos;
                m_io.Seek(8216);
                _stringIdSentryHereComes = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryHereComes = true;
                return _stringIdSentryHereComes;
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
                m_io.Seek(14688);
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
        private bool f_stringIdSentryOutOfTime;
        private int _stringIdSentryOutOfTime;

        /// <summary>
        /// String ID 0x6DC:
        ///  [se_play:0][W:30]Out of time! Pick up the pace![W:75]
        /// </summary>
        public int StringIdSentryOutOfTime
        {
            get
            {
                if (f_stringIdSentryOutOfTime)
                    return _stringIdSentryOutOfTime;
                long _pos = m_io.Pos;
                m_io.Seek(8232);
                _stringIdSentryOutOfTime = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryOutOfTime = true;
                return _stringIdSentryOutOfTime;
            }
        }
        private bool f_stringIdSentryWhoseFootprint;
        private int _stringIdSentryWhoseFootprint;

        /// <summary>
        /// String ID 0x6DB:
        ///  Whose footprint is this?[W:60]
        /// </summary>
        public int StringIdSentryWhoseFootprint
        {
            get
            {
                if (f_stringIdSentryWhoseFootprint)
                    return _stringIdSentryWhoseFootprint;
                long _pos = m_io.Pos;
                m_io.Seek(8220);
                _stringIdSentryWhoseFootprint = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryWhoseFootprint = true;
                return _stringIdSentryWhoseFootprint;
            }
        }
        private bool f_stringIdSentryBuckUp;
        private int _stringIdSentryBuckUp;

        /// <summary>
        /// String ID 0x6F2 (and also used as Loudred's speaker ID after subtracting 0x5B0):
        ///  The correct answer is
        /// [kind:]! Buck up! And snap to it![se_play:0][W:120]
        /// </summary>
        public int StringIdSentryBuckUp
        {
            get
            {
                if (f_stringIdSentryBuckUp)
                    return _stringIdSentryBuckUp;
                long _pos = m_io.Pos;
                m_io.Seek(8252);
                _stringIdSentryBuckUp = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryBuckUp = true;
                return _stringIdSentryBuckUp;
            }
        }
        private bool f_stringIdSentryComeIn6ef;
        private int _stringIdSentryComeIn6ef;

        /// <summary>
        /// String ID 0x6EF:
        ///  Heard ya! Come in, visitor![W:30]
        /// </summary>
        public int StringIdSentryComeIn6ef
        {
            get
            {
                if (f_stringIdSentryComeIn6ef)
                    return _stringIdSentryComeIn6ef;
                long _pos = m_io.Pos;
                m_io.Seek(8240);
                _stringIdSentryComeIn6ef = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_stringIdSentryComeIn6ef = true;
                return _stringIdSentryComeIn6ef;
            }
        }
        private Overlay14Data m_root;
        private KaitaiStruct m_parent;
        public Overlay14Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
