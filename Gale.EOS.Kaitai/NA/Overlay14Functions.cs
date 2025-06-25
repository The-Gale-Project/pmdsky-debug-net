// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within OVERLAY14 with relative address locations as their values.
    /// </summary>
    public partial class Overlay14Functions : KaitaiStruct
    {
        public static Overlay14Functions FromFile(string fileName)
        {
            return new Overlay14Functions(new KaitaiStream(fileName));
        }

        public Overlay14Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay14Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_sentryState4 = false;
            f_sentryState1D = false;
            f_sentryState1F = false;
            f_sentryState9 = false;
            f_sentryState1C = false;
            f_sentryState10 = false;
            f_sentryState7 = false;
            f_sentryState1 = false;
            f_sentryStateExit = false;
            f_sentryState12 = false;
            f_sentrySetExitingState = false;
            f_sentryUpdateDisplay = false;
            f_sentryState21 = false;
            f_sentryRunState = false;
            f_sentryState0 = false;
            f_sentryState1E = false;
            f_sentryState3 = false;
            f_sentryState16 = false;
            f_sentryState20 = false;
            f_sentryState13 = false;
            f_sentryState2 = false;
            f_sentryState19 = false;
            f_sentryStateGenerateChoices = false;
            f_sentryState6 = false;
            f_sentryState8 = false;
            f_sentryStateGetUserChoice = false;
            f_sentryStateA = false;
            f_sentryState18 = false;
            f_sentryState14 = false;
            f_sentryState15 = false;
            f_sentryState11 = false;
            f_sentryStateB = false;
            f_sentryStateFinalizePoints = false;
            f_sentrySetupState = false;
            f_sentryStateFinalizeRound = false;
            f_sentryState17 = false;
            f_sentryState1A = false;
            f_sentrySetStateIntermediate = false;
            f_sentryStateF = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_sentryState4;
        private int _sentryState4;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState4
        {
            get
            {
                if (f_sentryState4)
                    return _sentryState4;
                _sentryState4 = (int) (8816);
                f_sentryState4 = true;
                return _sentryState4;
            }
        }
        private bool f_sentryState1D;
        private int _sentryState1D;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState1D
        {
            get
            {
                if (f_sentryState1D)
                    return _sentryState1D;
                _sentryState1D = (int) (13660);
                f_sentryState1D = true;
                return _sentryState1D;
            }
        }
        private bool f_sentryState1F;
        private int _sentryState1F;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState1F
        {
            get
            {
                if (f_sentryState1F)
                    return _sentryState1F;
                _sentryState1F = (int) (13784);
                f_sentryState1F = true;
                return _sentryState1F;
            }
        }
        private bool f_sentryState9;
        private int _sentryState9;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState9
        {
            get
            {
                if (f_sentryState9)
                    return _sentryState9;
                _sentryState9 = (int) (8960);
                f_sentryState9 = true;
                return _sentryState9;
            }
        }
        private bool f_sentryState1C;
        private int _sentryState1C;

        /// <summary>
        /// This state corresponds to when Loudred tells the player that they chose the correct answer (&quot;Yep! Looks like you're right!&quot;).
        /// 
        /// No params.
        /// </summary>
        public int SentryState1C
        {
            get
            {
                if (f_sentryState1C)
                    return _sentryState1C;
                _sentryState1C = (int) (13592);
                f_sentryState1C = true;
                return _sentryState1C;
            }
        }
        private bool f_sentryState10;
        private int _sentryState10;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState10
        {
            get
            {
                if (f_sentryState10)
                    return _sentryState10;
                _sentryState10 = (int) (12768);
                f_sentryState10 = true;
                return _sentryState10;
            }
        }
        private bool f_sentryState7;
        private int _sentryState7;

        /// <summary>
        /// This state corresponds to when Loudred tells you the instructions for the minigame (STRING_ID_SENTRY_INSTRUCTIONS).
        /// 
        /// No params.
        /// </summary>
        public int SentryState7
        {
            get
            {
                if (f_sentryState7)
                    return _sentryState7;
                _sentryState7 = (int) (8900);
                f_sentryState7 = true;
                return _sentryState7;
            }
        }
        private bool f_sentryState1;
        private int _sentryState1;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState1
        {
            get
            {
                if (f_sentryState1)
                    return _sentryState1;
                _sentryState1 = (int) (8396);
                f_sentryState1 = true;
                return _sentryState1;
            }
        }
        private bool f_sentryStateExit;
        private int _sentryStateExit;

        /// <summary>
        /// State 0x5: Exit (wraps SentrySetExitingState).
        /// 
        /// No params.
        /// </summary>
        public int SentryStateExit
        {
            get
            {
                if (f_sentryStateExit)
                    return _sentryStateExit;
                _sentryStateExit = (int) (8852);
                f_sentryStateExit = true;
                return _sentryStateExit;
            }
        }
        private bool f_sentryState12;
        private int _sentryState12;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState12
        {
            get
            {
                if (f_sentryState12)
                    return _sentryState12;
                _sentryState12 = (int) (12912);
                f_sentryState12 = true;
                return _sentryState12;
            }
        }
        private bool f_sentrySetExitingState;
        private int _sentrySetExitingState;

        /// <summary>
        /// Sets the completion state to exiting, triggering the minigame to run its exit sequence.
        /// 
        /// No params.
        /// </summary>
        public int SentrySetExitingState
        {
            get
            {
                if (f_sentrySetExitingState)
                    return _sentrySetExitingState;
                _sentrySetExitingState = (int) (5528);
                f_sentrySetExitingState = true;
                return _sentrySetExitingState;
            }
        }
        private bool f_sentryUpdateDisplay;
        private int _sentryUpdateDisplay;

        /// <summary>
        /// Seems to update various parts of the display, such as the round number.
        /// 
        /// No params.
        /// </summary>
        public int SentryUpdateDisplay
        {
            get
            {
                if (f_sentryUpdateDisplay)
                    return _sentryUpdateDisplay;
                _sentryUpdateDisplay = (int) (3260);
                f_sentryUpdateDisplay = true;
                return _sentryUpdateDisplay;
            }
        }
        private bool f_sentryState21;
        private int _sentryState21;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState21
        {
            get
            {
                if (f_sentryState21)
                    return _sentryState21;
                _sentryState21 = (int) (13932);
                f_sentryState21 = true;
                return _sentryState21;
            }
        }
        private bool f_sentryRunState;
        private int _sentryRunState;

        /// <summary>
        /// Run the minigame according to the current game state, or handle the transition to a new state if one has been set.
        /// 
        /// The game is implemented using the state machine programming pattern. This function appears to contain the top-level code for running a single &quot;turn&quot; of the state machine, although presumably there's a higher level game engine that's calling this function in a loop somewhere.
        /// 
        /// return: return code for the engine driving the minigame? Seems like 1 to keep going and 4 to stop
        /// </summary>
        public int SentryRunState
        {
            get
            {
                if (f_sentryRunState)
                    return _sentryRunState;
                _sentryRunState = (int) (5820);
                f_sentryRunState = true;
                return _sentryRunState;
            }
        }
        private bool f_sentryState0;
        private int _sentryState0;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState0
        {
            get
            {
                if (f_sentryState0)
                    return _sentryState0;
                _sentryState0 = (int) (8360);
                f_sentryState0 = true;
                return _sentryState0;
            }
        }
        private bool f_sentryState1E;
        private int _sentryState1E;

        /// <summary>
        /// This state corresponds to one of the possible dialogue options when you've finished all the rounds (STRING_ID_SENTRY_KEEP_YOU_WAITING, STRING_ID_SENTRY_THATLL_DO_IT).
        /// 
        /// No params.
        /// </summary>
        public int SentryState1E
        {
            get
            {
                if (f_sentryState1E)
                    return _sentryState1E;
                _sentryState1E = (int) (13760);
                f_sentryState1E = true;
                return _sentryState1E;
            }
        }
        private bool f_sentryState3;
        private int _sentryState3;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState3
        {
            get
            {
                if (f_sentryState3)
                    return _sentryState3;
                _sentryState3 = (int) (8520);
                f_sentryState3 = true;
                return _sentryState3;
            }
        }
        private bool f_sentryState16;
        private int _sentryState16;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState16
        {
            get
            {
                if (f_sentryState16)
                    return _sentryState16;
                _sentryState16 = (int) (13096);
                f_sentryState16 = true;
                return _sentryState16;
            }
        }
        private bool f_sentryState20;
        private int _sentryState20;

        /// <summary>
        /// This state corresponds to one of the possible dialogue options when you've finished all the rounds (STRING_ID_SENTRY_NO_MORE_VISITORS, STRING_ID_SENTRY_THATS_ALL).
        /// 
        /// No params.
        /// </summary>
        public int SentryState20
        {
            get
            {
                if (f_sentryState20)
                    return _sentryState20;
                _sentryState20 = (int) (13908);
                f_sentryState20 = true;
                return _sentryState20;
            }
        }
        private bool f_sentryState13;
        private int _sentryState13;

        /// <summary>
        /// This state corresponds to when Loudred tells you that you're out of time (STRING_ID_SENTRY_OUT_OF_TIME).
        /// 
        /// No params.
        /// </summary>
        public int SentryState13
        {
            get
            {
                if (f_sentryState13)
                    return _sentryState13;
                _sentryState13 = (int) (12968);
                f_sentryState13 = true;
                return _sentryState13;
            }
        }
        private bool f_sentryState2;
        private int _sentryState2;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState2
        {
            get
            {
                if (f_sentryState2)
                    return _sentryState2;
                _sentryState2 = (int) (8484);
                f_sentryState2 = true;
                return _sentryState2;
            }
        }
        private bool f_sentryState19;
        private int _sentryState19;

        /// <summary>
        /// This state seems to be similar to state 0x14, when the player is shouting their guess (STRING_ID_SENTRY_FOOTPRINT_IS_6EC), and when Loudred tells the visitor to come in (STRING_ID_SENTRY_COME_IN_6ED), but used in a different context (different state transitions to and from this state).
        /// 
        /// No params.
        /// </summary>
        public int SentryState19
        {
            get
            {
                if (f_sentryState19)
                    return _sentryState19;
                _sentryState19 = (int) (13360);
                f_sentryState19 = true;
                return _sentryState19;
            }
        }
        private bool f_sentryStateGenerateChoices;
        private int _sentryStateGenerateChoices;

        /// <summary>
        /// State 0xC: Generate the four choices for a round.
        /// 
        /// No params.
        /// </summary>
        public int SentryStateGenerateChoices
        {
            get
            {
                if (f_sentryStateGenerateChoices)
                    return _sentryStateGenerateChoices;
                _sentryStateGenerateChoices = (int) (9044);
                f_sentryStateGenerateChoices = true;
                return _sentryStateGenerateChoices;
            }
        }
        private bool f_sentryState6;
        private int _sentryState6;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState6
        {
            get
            {
                if (f_sentryState6)
                    return _sentryState6;
                _sentryState6 = (int) (8864);
                f_sentryState6 = true;
                return _sentryState6;
            }
        }
        private bool f_sentryState8;
        private int _sentryState8;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState8
        {
            get
            {
                if (f_sentryState8)
                    return _sentryState8;
                _sentryState8 = (int) (8924);
                f_sentryState8 = true;
                return _sentryState8;
            }
        }
        private bool f_sentryStateGetUserChoice;
        private int _sentryStateGetUserChoice;

        /// <summary>
        /// State 0xD: Wait for the player to select an answer.
        /// 
        /// No params.
        /// </summary>
        public int SentryStateGetUserChoice
        {
            get
            {
                if (f_sentryStateGetUserChoice)
                    return _sentryStateGetUserChoice;
                _sentryStateGetUserChoice = (int) (10580);
                f_sentryStateGetUserChoice = true;
                return _sentryStateGetUserChoice;
            }
        }
        private bool f_sentryStateA;
        private int _sentryStateA;

        /// <summary>
        /// This state corresponds to when Loudred alerts you that someone is coming (STRING_ID_SENTRY_HERE_COMES).
        /// 
        /// No params.
        /// </summary>
        public int SentryStateA
        {
            get
            {
                if (f_sentryStateA)
                    return _sentryStateA;
                _sentryStateA = (int) (8996);
                f_sentryStateA = true;
                return _sentryStateA;
            }
        }
        private bool f_sentryState18;
        private int _sentryState18;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState18
        {
            get
            {
                if (f_sentryState18)
                    return _sentryState18;
                _sentryState18 = (int) (13304);
                f_sentryState18 = true;
                return _sentryState18;
            }
        }
        private bool f_sentryState14;
        private int _sentryState14;

        /// <summary>
        /// This state corresponds to when the player is shouting their guess (STRING_ID_SENTRY_FOOTPRINT_IS_6EE), and when Loudred tells the visitor to come in (STRING_ID_SENTRY_COME_IN_6EF).
        /// 
        /// No params.
        /// </summary>
        public int SentryState14
        {
            get
            {
                if (f_sentryState14)
                    return _sentryState14;
                _sentryState14 = (int) (13008);
                f_sentryState14 = true;
                return _sentryState14;
            }
        }
        private bool f_sentryState15;
        private int _sentryState15;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState15
        {
            get
            {
                if (f_sentryState15)
                    return _sentryState15;
                _sentryState15 = (int) (13032);
                f_sentryState15 = true;
                return _sentryState15;
            }
        }
        private bool f_sentryState11;
        private int _sentryState11;

        /// <summary>
        /// This state corresponds to when the partner tells you to try again after the player makes a wrong selection for the first time (STRING_ID_SENTRY_TRY_AGAIN).
        /// 
        /// No params.
        /// </summary>
        public int SentryState11
        {
            get
            {
                if (f_sentryState11)
                    return _sentryState11;
                _sentryState11 = (int) (12888);
                f_sentryState11 = true;
                return _sentryState11;
            }
        }
        private bool f_sentryStateB;
        private int _sentryStateB;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryStateB
        {
            get
            {
                if (f_sentryStateB)
                    return _sentryStateB;
                _sentryStateB = (int) (9020);
                f_sentryStateB = true;
                return _sentryStateB;
            }
        }
        private bool f_sentryStateFinalizePoints;
        private int _sentryStateFinalizePoints;

        /// <summary>
        /// State 0x1B: Apply any modifiers to the player's point total, such as granting 2000 bonus points for 100% correctness.
        /// 
        /// No params.
        /// </summary>
        public int SentryStateFinalizePoints
        {
            get
            {
                if (f_sentryStateFinalizePoints)
                    return _sentryStateFinalizePoints;
                _sentryStateFinalizePoints = (int) (13448);
                f_sentryStateFinalizePoints = true;
                return _sentryStateFinalizePoints;
            }
        }
        private bool f_sentrySetupState;
        private sbyte _sentrySetupState;

        /// <summary>
        /// Allocates and initializes the sentry duty struct.
        /// 
        /// Possibly the entrypoint of this overlay?
        /// 
        /// r0: controls initial game state? If 2, the minigame starts in state 4 rather than state 6.
        /// return: always 1
        /// </summary>
        public sbyte SentrySetupState
        {
            get
            {
                if (f_sentrySetupState)
                    return _sentrySetupState;
                _sentrySetupState = (sbyte) (0);
                f_sentrySetupState = true;
                return _sentrySetupState;
            }
        }
        private bool f_sentryStateFinalizeRound;
        private int _sentryStateFinalizeRound;

        /// <summary>
        /// State 0xE: Deal with the bookkeeping after the player has made a final choice for the round.
        /// 
        /// This includes things like incrementing the round counter. It also appears to check the final point count on the last round to determine the player's overall performance.
        /// 
        /// No params.
        /// </summary>
        public int SentryStateFinalizeRound
        {
            get
            {
                if (f_sentryStateFinalizeRound)
                    return _sentryStateFinalizeRound;
                _sentryStateFinalizeRound = (int) (11908);
                f_sentryStateFinalizeRound = true;
                return _sentryStateFinalizeRound;
            }
        }
        private bool f_sentryState17;
        private int _sentryState17;

        /// <summary>
        /// This state corresponds to when Loudred tells the player that they chose the wrong answer (STRING_ID_SENTRY_WRONG, STRING_ID_SENTRY_BUCK_UP).
        /// 
        /// No params.
        /// </summary>
        public int SentryState17
        {
            get
            {
                if (f_sentryState17)
                    return _sentryState17;
                _sentryState17 = (int) (13184);
                f_sentryState17 = true;
                return _sentryState17;
            }
        }
        private bool f_sentryState1A;
        private int _sentryState1A;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryState1A
        {
            get
            {
                if (f_sentryState1A)
                    return _sentryState1A;
                _sentryState1A = (int) (13384);
                f_sentryState1A = true;
                return _sentryState1A;
            }
        }
        private bool f_sentrySetStateIntermediate;
        private int _sentrySetStateIntermediate;

        /// <summary>
        /// Queues up a new intermediate game state to transition to, where the transition handler will be called immediately by SentryRunState after the current state handler has returned.
        /// 
        /// r0: new state
        /// </summary>
        public int SentrySetStateIntermediate
        {
            get
            {
                if (f_sentrySetStateIntermediate)
                    return _sentrySetStateIntermediate;
                _sentrySetStateIntermediate = (int) (8328);
                f_sentrySetStateIntermediate = true;
                return _sentrySetStateIntermediate;
            }
        }
        private bool f_sentryStateF;
        private int _sentryStateF;

        /// <summary>
        /// No params.
        /// </summary>
        public int SentryStateF
        {
            get
            {
                if (f_sentryStateF)
                    return _sentryStateF;
                _sentryStateF = (int) (12744);
                f_sentryStateF = true;
                return _sentryStateF;
            }
        }
        private Overlay14Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay14Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
