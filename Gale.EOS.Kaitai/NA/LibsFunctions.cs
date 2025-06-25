// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within LIBS with relative address locations as their values.
    /// </summary>
    public partial class LibsFunctions : KaitaiStruct
    {
        public static LibsFunctions FromFile(string fileName)
        {
            return new LibsFunctions(new KaitaiStream(fileName));
        }

        public LibsFunctions(KaitaiStream p__io, KaitaiStruct p__parent = null, LibsFunctions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_dseSynthSetBend = false;
            f_strcpy = false;
            f_gxSetBankForSubBg = false;
            f_dseSynthResetAndSetBankAndSequence = false;
            f_dseSwdIsBankLoading = false;
            f_gxLoadBg1Scr = false;
            f_startThread = false;
            f_gxLoadObj = false;
            f_gxLoadBg1Char = false;
            f_dseBgmIsPlaying = false;
            f_strncpy = false;
            f_gxDispOff = false;
            f_llUdiv = false;
            f_dseSetError2 = false;
            f_g2SGetBg0ScrPtr = false;
            f_mtxOrthoW = false;
            f_gxResetBankForSubBgExtPltt = false;
            f_dfltu = false;
            f_dseSynthUnload = false;
            f_dseBgmStopAll = false;
            f_strcmp = false;
            f_dseVoiceUpdateParameters = false;
            f_u32DivNot0F = false;
            f_dseSequenceGetParameter = false;
            f_dseTrackEventSetEnvelopeDecayTimeAndSustainLevel = false;
            f_dseSeSysReset = false;
            f_gxSetBankForBg = false;
            f_gxSetBankForObjExtPltt = false;
            f_dseTrackEventSetTuning = false;
            f_abs = false;
            f_dseDriverIsSettingsValid = false;
            f_ullMod = false;
            f_insertThreadIntoList = false;
            f_g3XInitTable = false;
            f_gxBeginLoadTexPltt = false;
            f_dseDriverStartMainThread = false;
            f_soundLfoWaveHalfNoiseFunc = false;
            f_gxsLoadOam = false;
            f_dseChannelSetInstrument = false;
            f_dseSynthReset = false;
            f_ddiv = false;
            f_dseVoiceUpdateHardware = false;
            f_g2GetBg1ScrPtr = false;
            f_dsqrt = false;
            f_g2GetBg3ScrPtr = false;
            f_gxHBlankIntr = false;
            f_dseBgmLoad = false;
            f_dseTrackEventSetPan = false;
            f_gxDisableBankForObj = false;
            f_dseSwdCloseMainBankFileReader = false;
            f_dseTrackEventPanDelta = false;
            f_gxVBlankIntr = false;
            f_strlen = false;
            f_dseSequenceGetSmallestNumLoops = false;
            f_dseSequenceAllocateNew = false;
            f_dseSeStopAll = false;
            f_dseTrackEventSetupPanLfo = false;
            f_dseSequenceSetFades = false;
            f_gxDisableBankForSubObjExtPltt = false;
            f_dseTrackEventSetupLfoEnvelope = false;
            f_tryAssignByteWrapper = false;
            f_dseDriverMain = false;
            f_gxResetBankForObjExtPltt = false;
            f_dsub = false;
            f_soundLfoBankSetConstEnvelopes = false;
            f_u32DivF = false;
            f_cryptoRc4Init = false;
            f_gxLoadTex = false;
            f_loadOverlayInternal = false;
            f_gxEndLoadBgExtPltt = false;
            f_gxSetBankForSubBgExtPltt = false;
            f_dseTrackEventSetBankLsb = false;
            f_gxSetBankForObj = false;
            f_dseVoiceFlagForActivation = false;
            f_dseUtilByteSwap32 = false;
            f_getIrqFlag = false;
            f_strcat = false;
            f_dseSwdLoadWavesInternal = false;
            f_dseTrackEventUseKeyBendLfo = false;
            f_dseSeGetEffectSong = false;
            f_fxAtan2Idx = false;
            f_gxsLoadObjPltt = false;
            f_dseTrackEventSetExpression = false;
            f_dseSePlay = false;
            f_memsetFast = false;
            f_dseSwdGetMainBankById = false;
            f_enableVramBanksInSet = false;
            f_dseVoiceRelease = false;
            f_dseVoiceResetAll = false;
            f_dseTrackEventForceLfoEnvelopeLevel = false;
            f_countLeadingZeros = false;
            f_dseSwdSampleLoaderMain = false;
            f_dseTrackEventOctaveDelta = false;
            f_dseSeUnload = false;
            f_fxInvAsync = false;
            f_dseTrackEventVolumeFade = false;
            f_gxDisableBankForBgExtPltt = false;
            f_dseTrackEventTuningDeltaFine = false;
            f_strncat = false;
            f_dseMemAllocateUser = false;
            f_vecDistance = false;
            f_gxSetBankForSubObjExtPltt = false;
            f_gxSetBankForTex = false;
            f_dseTrackEventSetOctave = false;
            f_dseTrackEventSetEnvelopeSustainTime = false;
            f_dseTrackEventSetEnvelopeHoldTime = false;
            f_dflt = false;
            f_enableIrqFiqFlags = false;
            f_g3XInit = false;
            f_gxDispOn = false;
            f_snprintf = false;
            f_g2GetBg0ScrPtr = false;
            f_soundEnvelopeStop = false;
            f_g3XSetClearColor = false;
            f_dseSynthRestoreHeldNotes = false;
            f_g2xChangeBlendBrightness = false;
            f_dmul = false;
            f_soundLfoWaveFullTriangleFunc = false;
            f_dseTrackEventSetLfoParameter = false;
            f_gxLoadBgPltt = false;
            f_gXxSetMasterBrightness = false;
            f_dseSeCheckTooManyInstancesInGroup = false;
            f_dseMemAllocateThreadStack = false;
            f_deq = false;
            f_ffltu = false;
            f_gxDisableBankForSubBgExtPltt = false;
            f_gxDisableBankForTexPltt = false;
            f_dseSynthSetGlobalVolumeIndex = false;
            f_dseTrackEventSetBpm = false;
            f_soundEnvelopeTick = false;
            f_llUfromD = false;
            f_dseSynthSetPan = false;
            f_dseTrackEventSetVolume = false;
            f_gxDisableBankForTex = false;
            f_dseTrackEventSetupKeyBendLfoEnvelope = false;
            f_soundLfoBankReset = false;
            f_g3XGetMtxStackLevelPj = false;
            f_dgeq = false;
            f_gxSetGraphicsMode = false;
            f_dseSeHasPlayingInstances = false;
            f_enableIrqFlag = false;
            f_dseSequencePauseList = false;
            f_strncmp = false;
            f_gxDisableBankForObjExtPltt = false;
            f_soundEnvelopeReset = false;
            f_soundLfoWaveInvalidFunc = false;
            f_dseSwdLoadMainBank = false;
            f_wcstombs = false;
            f_dseSeGetUsedBankIDs = false;
            f_dseDriverLoadDefaultSettings = false;
            f_updateChannels = false;
            f_fxGetDivResultFx64c = false;
            f_soundEnvelopeStop2 = false;
            f_gxLoadObjPltt = false;
            f_findSmdlSongChunk = false;
            f_getTimer0Control = false;
            f_dseSequenceLoadSong = false;
            f_disableBankForX = false;
            f_vsprintf = false;
            f_memsetInternal = false;
            f_soundEnvelopeParametersReset = false;
            f_dseSwdGetNextSplitInRange = false;
            f_fmul = false;
            f_resumeBgm = false;
            f_dseSwdGetBankById = false;
            f_g2GetBg0CharPtr = false;
            f_dleq = false;
            f_dseTrackEventSignal = false;
            f_g2GetBg1CharPtr = false;
            f_updateTrackVolumeEnvelopes = false;
            f_gXiNopClearFifo128 = false;
            f_gxLoadBg3Char = false;
            f_dseSequenceUnload = false;
            f_dseVoiceDeallocate = false;
            f_soundLfoWaveSawFunc = false;
            f_g3XGetMtxStackLevelPv = false;
            f_soundEnvelopeSetParameters = false;
            f_dseTrackEventUsePanLfo = false;
            f_dseTrackEventSetUnknown2 = false;
            f_dseSeGetBestSeqAllocation = false;
            f_updateSequencerTracks = false;
            f_g2xSetBlendAlpha = false;
            f_soundLfoBankTick = false;
            f_dseSequenceTickFades = false;
            f_dseTrackEventUseLfo = false;
            f_dseChannelAllocateNote = false;
            f_fpInit = false;
            f_gxDisableBankForBg = false;
            f_gxsSetGraphicsMode = false;
            f_dseTrackEventWaitSame = false;
            f_dseSequenceTickNotes = false;
            f_vsprintfInternalSlice = false;
            f_dseChannelSetKeyBend = false;
            f_dseMemQuit = false;
            f_dls = false;
            f_g2SGetBg1ScrPtr = false;
            f_vecCrossProduct = false;
            f_fflt = false;
            f_soundLfoWaveFullSquareFunc = false;
            f_gxSetBankForBgExtPltt = false;
            f_dseTrackEventDummy2Bytes = false;
            f_g2GetBg2ScrPtr = false;
            f_fxDiv = false;
            f_soundLfoWaveHalfTriangleFunc = false;
            f_g2GetBg2CharPtr = false;
            f_gxSetBankForArm7 = false;
            f_gxLoadBg2Char = false;
            f_dseTrackEventSetOptionalVolume = false;
            f_getProcessorMode = false;
            f_dseSynthSetVolume = false;
            f_d2f = false;
            f_dseSynthStopChannels = false;
            f_dseSwdSysQuit = false;
            f_gxInit = false;
            f_dseVoiceReleaseHeld = false;
            f_dseVoiceAllocate = false;
            f_gxsLoadBg0Char = false;
            f_dseVoiceCleanup = false;
            f_soundUtilGetRandomNumber = false;
            f_g2GetBg3CharPtr = false;
            f_gxSetBankForLcdc = false;
            f_dseSeGetById = false;
            f_dseSynthAllocateNew = false;
            f_dseTrackEventSetKeyBend = false;
            f_dseBgmSetSignalCallback = false;
            f_soundEnvelopeForceVolume = false;
            f_waitForInterrupt = false;
            f_dseTrackEventMainLoopBegin = false;
            f_dseBgmSysSetupNoteList = false;
            f_dseChannelSetLfoConstEnvelopeLevel = false;
            f_wcslen = false;
            f_dseSeLoad = false;
            f_dseChannelReleaseNoteInternal = false;
            f_g3LoadMtx44 = false;
            f_dseBgmStop = false;
            f_g3MultMtx43 = false;
            f_gxLoadTexPltt = false;
            f_gxSetBankForClearImage = false;
            f_dseSwdReadMainBank = false;
            f_arrayFill32 = false;
            f_dseTrackEventDummy2Bytes2 = false;
            f_dseSetError = false;
            f_g3iOrthoW = false;
            f_memchr = false;
            f_gxsLoadBgPltt = false;
            f_fls = false;
            f_gxsLoadBg1Char = false;
            f_fxDivAsync = false;
            f_dseTrackEventSetupVolumeLfo = false;
            f_dseDriverInit = false;
            f_mbtowc = false;
            f_gxsBeginLoadObjExtPltt = false;
            f_soundEnvelopeParametersCheckValidity = false;
            f_dseTrackEventSetNoteRandomRegion = false;
            f_g2xSetBlendBrightness = false;
            f_dseTrackEventSetupVolumeLfoEnvelope = false;
            f_dseVoiceResetHw = false;
            f_dseSequenceStart = false;
            f_strchr = false;
            f_dseTrackEventTuningDeltaFull = false;
            f_gxDisableBankForLcdc = false;
            f_gxsLoadObj = false;
            f_dseTrackEventVolumeDelta = false;
            f_fsub = false;
            f_gxLoadBg3Scr = false;
            f_dseTrackEventSetHoldNotes = false;
            f_enableVramBanksInSetDontSave = false;
            f_dseTrackEventSetupKeyBendLfo = false;
            f_vecDotProduct = false;
            f_gxBeginLoadTex = false;
            f_gxLoadOam = false;
            f_dseTrackEventSetBankMsb = false;
            f_gxsEndLoadBgExtPltt = false;
            f_dseChannelInit = false;
            f_dseSeStopSeq = false;
            f_dseMemClear = false;
            f_tryAssignByte = false;
            f_dseBgmDefaultSignalCallback = false;
            f_dseSwdSysInit = false;
            f_dseSwdGetInstrument = false;
            f_gxInitGxState = false;
            f_dseVoiceStart = false;
            f_dseDriverStartTickTimer = false;
            f_gxsLoadBg1Scr = false;
            f_gxSetBankForTexPltt = false;
            f_dseTrackEventSetFlagBit1Unknown = false;
            f_sprintf = false;
            f_gxBeginLoadObjExtPltt = false;
            f_gxSendFifo64B = false;
            f_gxDisableBankForClearImage = false;
            f_gxEndLoadTexPltt = false;
            f_gxEndLoadTex = false;
            f_soundLfoBankSet = false;
            f_dseChannelDeallocateVoices = false;
            f_g2SGetBg1CharPtr = false;
            f_dseTrackEventSetupPanLfoEnvelope = false;
            f_memmove = false;
            f_dseMemInit = false;
            f_gxResetBankForBgExtPltt = false;
            f_dseDriverConfigureHeap = false;
            f_vecNormalize = false;
            f_getOverlayInfo = false;
            f_dseChannelResetTimerAndVolumeForVoices = false;
            f_initOverlay = false;
            f_dseTrackEventTuningFade = false;
            f_dseTrackEventSongVolumeFade = false;
            f_gxDisableBankForSubBg = false;
            f_dseTrackEventSetTuningJitterAmplitude = false;
            f_gxResetBankForTex = false;
            f_soundLfoWaveFullNoiseFunc = false;
            f_arrayFill16 = false;
            f_gxBeginLoadBgExtPltt = false;
            f_g3XClearFifo = false;
            f_gxSetBankForSubObj = false;
            f_geomGxFifoSendMtx4x3 = false;
            f_dseVoiceFlagForDeactivation = false;
            f_dseTrackEventSubLoopEnd = false;
            f_dseSynthSetBankAndSequence = false;
            f_setThreadField0xB4 = false;
            f_dseTrackEventWait24 = false;
            f_dseSwdLoadWaves = false;
            f_dneq = false;
            f_incrementThreadCount = false;
            f_dseVoiceReleaseNote = false;
            f_dseSwdUnload = false;
            f_fdiv = false;
            f_dseTrackEventWaitDelta = false;
            f_g3XReset = false;
            f_threadExit = false;
            f_dadd = false;
            f_dseTrackEventUseVolumeLfo = false;
            f_dseTrackEventEndTrack = false;
            f_osGetLockId = false;
            f_arrayCopy32Fast = false;
            f_dseTrackEventRestoreEnvelopeDefaults = false;
            f_dseTrackEventSetupLfo = false;
            f_dseTrackEventWait8 = false;
            f_dseTrackEventWaitUntilFadeout = false;
            f_dseTrackEventSubLoopBegin = false;
            f_dseTrackEventInvalid = false;
            f_dseSequenceInitTracks = false;
            f_g3XInitMtxStack = false;
            f_dseMemFree = false;
            f_dseFileCheckHeader = false;
            f_fxDivS32 = false;
            f_fxGetDivResult = false;
            f_dseSequenceStop = false;
            f_gxsBeginLoadBgExtPltt = false;
            f_gxResetBankForTexPltt = false;
            f_readWaviEntry = false;
            f_strstr = false;
            f_clearIrqFlag = false;
            f_dseTrackEventSetKeyBendRange = false;
            f_dseChannelChangeNote = false;
            f_dseSwdLoadBank = false;
            f_atomicExchange = false;
            f_g2SGetBg0CharPtr = false;
            f_strcspn = false;
            f_gxResetBankForSubObjExtPltt = false;
            f_gxDisableBankForSubObj = false;
            f_vsprintfInternal = false;
            f_dseSeCheckTooManyInstances = false;
            f_dseSeStop = false;
            f_gxDisableBankForArm7 = false;
            f_dseBgmSetFades = false;
            f_memcpyFast = false;
            f_dseSynthClearHeldNotes = false;
            f_dseTrackEventWait16 = false;
            f_dseTrackEventSetBank = false;
            f_llMul = false;
            f_gxLoadBg0Char = false;
            f_gxEndLoadObjExtPltt = false;
            f_dseSequenceReset = false;
            f_dseVoicePlayNote = false;
            f_gxsEndLoadObjExtPltt = false;
            f_dseTrackEventSetEnvelopeReleaseTime = false;
            f_mtxLookAt = false;
            f_dseDriverNotifyTick = false;
            f_drdiv = false;
            f_llSdiv = false;
            f_llMod = false;
            f_g3XResetMtxStack = false;
            f_arrayCopy16 = false;
            f_fileInit = false;
            f_sqrtf = false;
            f_dseChannelSetBank = false;
            f_dseTrackEventSetInstrument = false;
            f_dseTrackEventSetEnvelopeAttackTime = false;
            f_dseSynthResetAllVoiceTimersAndVolumes = false;
            f_tryAppendToSlice = false;
            f_getDsFirmwareUserSettings = false;
            f_initThread = false;
            f_dseSequenceGetById = false;
            f_f2d = false;
            f_parseDseEvent = false;
            f_soundLfoWaveHalfSquareFunc = false;
            f_dseTrackEventDummy1Byte = false;
            f_dseTrackEventSubLoopBreakOnLastIteration = false;
            f_arrayCopy32 = false;
            f_soundEnvelopeRelease = false;
            f_g3iLookAt = false;
            f_ffix = false;
            f_dseMemAllocate = false;
            f_memcmp = false;
            f_s32DivF = false;
            f_fadd = false;
            f_dseTrackEventSetNoteDurationMultiplier = false;
            f_dseSwdInitMainBankFileReader = false;
            f_dseSwdMainBankDummyCallback = false;
            f_dseVoiceCountNumActiveInChannel = false;
            f_memset = false;
            f_setIrqFlag = false;
            f_fxModS32 = false;
            f_waitForever2 = false;
            f_flushChannels = false;
            f_dseBgmUnload = false;
            f_dseTrackEventSetBpm2 = false;
            f_gxLoadBg2Scr = false;
            f_gxLoadBg0Scr = false;
            f_dseChannelReleaseNote = false;
            f_dseTrackEventPanFade = false;
            f_dseSwdOpenMainBankFileReader = false;
            f_soundEnvelopeSetSlide = false;
            f_g3LoadMtx43 = false;
            f_setIrqFiqFlags = false;
            f_dseTrackEventSetEnvelopeAttackBegin = false;
            f_arrayFill32Fast = false;
            f_memcpy = false;
            f_dseTrackEventTuningDeltaCoarse = false;
            f_soundLfoWaveReverseSawFunc = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_dseSynthSetBend;
        private int _dseSynthSetBend;
        public int DseSynthSetBend
        {
            get
            {
                if (f_dseSynthSetBend)
                    return _dseSynthSetBend;
                _dseSynthSetBend = (int) (30076);
                f_dseSynthSetBend = true;
                return _dseSynthSetBend;
            }
        }
        private bool f_strcpy;
        private int _strcpy;

        /// <summary>
        /// The strcpy(3) C library function.
        /// 
        /// This function is optimized to copy characters in aligned 4-byte chunks if possible, correctly handling any unaligned bytes at the front/back.
        /// 
        /// r0: dest
        /// r1: src
        /// return: dest
        /// </summary>
        public int Strcpy
        {
            get
            {
                if (f_strcpy)
                    return _strcpy;
                _strcpy = (int) (120252);
                f_strcpy = true;
                return _strcpy;
            }
        }
        private bool f_gxSetBankForSubBg;
        private int _gxSetBankForSubBg;
        public int GxSetBankForSubBg
        {
            get
            {
                if (f_gxSetBankForSubBg)
                    return _gxSetBankForSubBg;
                _gxSetBankForSubBg = (int) (44504);
                f_gxSetBankForSubBg = true;
                return _gxSetBankForSubBg;
            }
        }
        private bool f_dseSynthResetAndSetBankAndSequence;
        private int _dseSynthResetAndSetBankAndSequence;
        public int DseSynthResetAndSetBankAndSequence
        {
            get
            {
                if (f_dseSynthResetAndSetBankAndSequence)
                    return _dseSynthResetAndSetBankAndSequence;
                _dseSynthResetAndSetBankAndSequence = (int) (29568);
                f_dseSynthResetAndSetBankAndSequence = true;
                return _dseSynthResetAndSetBankAndSequence;
            }
        }
        private bool f_dseSwdIsBankLoading;
        private int _dseSwdIsBankLoading;
        public int DseSwdIsBankLoading
        {
            get
            {
                if (f_dseSwdIsBankLoading)
                    return _dseSwdIsBankLoading;
                _dseSwdIsBankLoading = (int) (4660);
                f_dseSwdIsBankLoading = true;
                return _dseSwdIsBankLoading;
            }
        }
        private bool f_gxLoadBg1Scr;
        private int _gxLoadBg1Scr;
        public int GxLoadBg1Scr
        {
            get
            {
                if (f_gxLoadBg1Scr)
                    return _gxLoadBg1Scr;
                _gxLoadBg1Scr = (int) (48952);
                f_gxLoadBg1Scr = true;
                return _gxLoadBg1Scr;
            }
        }
        private bool f_startThread;
        private int _startThread;

        /// <summary>
        /// Called to start a new thread.
        /// 
        /// Initializes the specified thread struct and some values on its stack area.
        /// 
        /// r0: Struct of the thread to init
        /// r1: Pointer to the function to run on this thread
        /// r2: Pointer to a thread struct. Sometimes equal to r0. Sometimes null.
        /// r3: Pointer to the stack area for this thread. Not all the space is usable. See thread::usable_stack_pointer for more info.
        /// stack[0]: Stack size
        /// stack[1]: (?) Used to sort threads on a list
        /// </summary>
        public int StartThread
        {
            get
            {
                if (f_startThread)
                    return _startThread;
                _startThread = (int) (54408);
                f_startThread = true;
                return _startThread;
            }
        }
        private bool f_gxLoadObj;
        private int _gxLoadObj;
        public int GxLoadObj
        {
            get
            {
                if (f_gxLoadObj)
                    return _gxLoadObj;
                _gxLoadObj = (int) (48680);
                f_gxLoadObj = true;
                return _gxLoadObj;
            }
        }
        private bool f_gxLoadBg1Char;
        private int _gxLoadBg1Char;
        public int GxLoadBg1Char
        {
            get
            {
                if (f_gxLoadBg1Char)
                    return _gxLoadBg1Char;
                _gxLoadBg1Char = (int) (49528);
                f_gxLoadBg1Char = true;
                return _gxLoadBg1Char;
            }
        }
        private bool f_dseBgmIsPlaying;
        private int _dseBgmIsPlaying;
        public int DseBgmIsPlaying
        {
            get
            {
                if (f_dseBgmIsPlaying)
                    return _dseBgmIsPlaying;
                _dseBgmIsPlaying = (int) (6348);
                f_dseBgmIsPlaying = true;
                return _dseBgmIsPlaying;
            }
        }
        private bool f_strncpy;
        private int _strncpy;

        /// <summary>
        /// The strncpy(3) C library function.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// return: dest
        /// </summary>
        public int Strncpy
        {
            get
            {
                if (f_strncpy)
                    return _strncpy;
                _strncpy = (int) (120452);
                f_strncpy = true;
                return _strncpy;
            }
        }
        private bool f_gxDispOff;
        private int _gxDispOff;
        public int GxDispOff
        {
            get
            {
                if (f_gxDispOff)
                    return _gxDispOff;
                _gxDispOff = (int) (41284);
                f_gxDispOff = true;
                return _gxDispOff;
            }
        }
        private bool f_llUdiv;
        private int _llUdiv;

        /// <summary>
        /// Implements the division operator for unsigned long longs.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __udivti3 in libgcc.
        /// 
        /// r0: dividend (low bits)
        /// r1: dividend (high bits)
        /// r2: divisor (low bits)
        /// r3: divisor (high bits)
        /// return: dividend / divisor
        /// </summary>
        public int LlUdiv
        {
            get
            {
                if (f_llUdiv)
                    return _llUdiv;
                _llUdiv = (int) (146788);
                f_llUdiv = true;
                return _llUdiv;
            }
        }
        private bool f_dseSetError2;
        private int _dseSetError2;
        public int DseSetError2
        {
            get
            {
                if (f_dseSetError2)
                    return _dseSetError2;
                _dseSetError2 = (int) (1968);
                f_dseSetError2 = true;
                return _dseSetError2;
            }
        }
        private bool f_g2SGetBg0ScrPtr;
        private int _g2SGetBg0ScrPtr;
        public int G2SGetBg0ScrPtr
        {
            get
            {
                if (f_g2SGetBg0ScrPtr)
                    return _g2SGetBg0ScrPtr;
                _g2SGetBg0ScrPtr = (int) (45892);
                f_g2SGetBg0ScrPtr = true;
                return _g2SGetBg0ScrPtr;
            }
        }
        private bool f_mtxOrthoW;
        private int _mtxOrthoW;
        public int MtxOrthoW
        {
            get
            {
                if (f_mtxOrthoW)
                    return _mtxOrthoW;
                _mtxOrthoW = (int) (39000);
                f_mtxOrthoW = true;
                return _mtxOrthoW;
            }
        }
        private bool f_gxResetBankForSubBgExtPltt;
        private int _gxResetBankForSubBgExtPltt;
        public int GxResetBankForSubBgExtPltt
        {
            get
            {
                if (f_gxResetBankForSubBgExtPltt)
                    return _gxResetBankForSubBgExtPltt;
                _gxResetBankForSubBgExtPltt = (int) (45204);
                f_gxResetBankForSubBgExtPltt = true;
                return _gxResetBankForSubBgExtPltt;
            }
        }
        private bool f_dfltu;
        private int _dfltu;

        /// <summary>
        /// Implements the unsigned int to double cast operation for IEEE 754 floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __floatunsidf in libgcc.
        /// 
        /// r0: uint
        /// return: (double)uint
        /// </summary>
        public int Dfltu
        {
            get
            {
                if (f_dfltu)
                    return _dfltu;
                _dfltu = (int) (139992);
                f_dfltu = true;
                return _dfltu;
            }
        }
        private bool f_dseSynthUnload;
        private int _dseSynthUnload;
        public int DseSynthUnload
        {
            get
            {
                if (f_dseSynthUnload)
                    return _dseSynthUnload;
                _dseSynthUnload = (int) (29304);
                f_dseSynthUnload = true;
                return _dseSynthUnload;
            }
        }
        private bool f_dseBgmStopAll;
        private int _dseBgmStopAll;
        public int DseBgmStopAll
        {
            get
            {
                if (f_dseBgmStopAll)
                    return _dseBgmStopAll;
                _dseBgmStopAll = (int) (6660);
                f_dseBgmStopAll = true;
                return _dseBgmStopAll;
            }
        }
        private bool f_strcmp;
        private int _strcmp;

        /// <summary>
        /// The strcmp(3) C library function.
        /// 
        /// Similarly to strcpy, this function is optimized to compare characters in aligned 4-byte chunks if possible.
        /// 
        /// r0: s1
        /// r1: s2
        /// return: comparison value
        /// </summary>
        public int Strcmp
        {
            get
            {
                if (f_strcmp)
                    return _strcmp;
                _strcmp = (int) (120660);
                f_strcmp = true;
                return _strcmp;
            }
        }
        private bool f_dseVoiceUpdateParameters;
        private int _dseVoiceUpdateParameters;
        public int DseVoiceUpdateParameters
        {
            get
            {
                if (f_dseVoiceUpdateParameters)
                    return _dseVoiceUpdateParameters;
                _dseVoiceUpdateParameters = (int) (32956);
                f_dseVoiceUpdateParameters = true;
                return _dseVoiceUpdateParameters;
            }
        }
        private bool f_u32DivNot0F;
        private int _u32DivNot0F;

        /// <summary>
        /// Subsidiary function to _u32_div_f. Skips the initial check for divisor == 0.
        /// 
        /// The return value is a 64-bit integer, with the quotient (dividend / divisor) in the lower 32 bits and the remainder (dividend % divisor) in the upper 32 bits. In accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return), this means that the quotient is returned in r0 and the remainder is returned in r1.
        /// This function appears to only be called internally.
        /// 
        /// r0: dividend
        /// r1: divisor
        /// return: (quotient) | (remainder &lt;&lt; 32)
        /// </summary>
        public int U32DivNot0F
        {
            get
            {
                if (f_u32DivNot0F)
                    return _u32DivNot0F;
                _u32DivNot0F = (int) (147424);
                f_u32DivNot0F = true;
                return _u32DivNot0F;
            }
        }
        private bool f_dseSequenceGetParameter;
        private int _dseSequenceGetParameter;
        public int DseSequenceGetParameter
        {
            get
            {
                if (f_dseSequenceGetParameter)
                    return _dseSequenceGetParameter;
                _dseSequenceGetParameter = (int) (8076);
                f_dseSequenceGetParameter = true;
                return _dseSequenceGetParameter;
            }
        }
        private bool f_dseTrackEventSetEnvelopeDecayTimeAndSustainLevel;
        private int _dseTrackEventSetEnvelopeDecayTimeAndSustainLevel;
        public int DseTrackEventSetEnvelopeDecayTimeAndSustainLevel
        {
            get
            {
                if (f_dseTrackEventSetEnvelopeDecayTimeAndSustainLevel)
                    return _dseTrackEventSetEnvelopeDecayTimeAndSustainLevel;
                _dseTrackEventSetEnvelopeDecayTimeAndSustainLevel = (int) (23656);
                f_dseTrackEventSetEnvelopeDecayTimeAndSustainLevel = true;
                return _dseTrackEventSetEnvelopeDecayTimeAndSustainLevel;
            }
        }
        private bool f_dseSeSysReset;
        private int _dseSeSysReset;
        public int DseSeSysReset
        {
            get
            {
                if (f_dseSeSysReset)
                    return _dseSeSysReset;
                _dseSeSysReset = (int) (10312);
                f_dseSeSysReset = true;
                return _dseSeSysReset;
            }
        }
        private bool f_gxSetBankForBg;
        private int _gxSetBankForBg;
        public int GxSetBankForBg
        {
            get
            {
                if (f_gxSetBankForBg)
                    return _gxSetBankForBg;
                _gxSetBankForBg = (int) (41868);
                f_gxSetBankForBg = true;
                return _gxSetBankForBg;
            }
        }
        private bool f_gxSetBankForObjExtPltt;
        private int _gxSetBankForObjExtPltt;
        public int GxSetBankForObjExtPltt
        {
            get
            {
                if (f_gxSetBankForObjExtPltt)
                    return _gxSetBankForObjExtPltt;
                _gxSetBankForObjExtPltt = (int) (43116);
                f_gxSetBankForObjExtPltt = true;
                return _gxSetBankForObjExtPltt;
            }
        }
        private bool f_dseTrackEventSetTuning;
        private int _dseTrackEventSetTuning;
        public int DseTrackEventSetTuning
        {
            get
            {
                if (f_dseTrackEventSetTuning)
                    return _dseTrackEventSetTuning;
                _dseTrackEventSetTuning = (int) (23900);
                f_dseTrackEventSetTuning = true;
                return _dseTrackEventSetTuning;
            }
        }
        private bool f_abs;
        private int _abs;

        /// <summary>
        /// Takes the absolute value of an integer.
        /// 
        /// r0: x
        /// return: abs(x)
        /// </summary>
        public int Abs
        {
            get
            {
                if (f_abs)
                    return _abs;
                _abs = (int) (107652);
                f_abs = true;
                return _abs;
            }
        }
        private bool f_dseDriverIsSettingsValid;
        private int _dseDriverIsSettingsValid;

        /// <summary>
        /// r0: DSE driver settings
        /// return: Flags specifying what settings are invalid.
        /// </summary>
        public int DseDriverIsSettingsValid
        {
            get
            {
                if (f_dseDriverIsSettingsValid)
                    return _dseDriverIsSettingsValid;
                _dseDriverIsSettingsValid = (int) (384);
                f_dseDriverIsSettingsValid = true;
                return _dseDriverIsSettingsValid;
            }
        }
        private bool f_ullMod;
        private int _ullMod;

        /// <summary>
        /// Implements the modulus operator for unsigned long longs.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __umodti3 in libgcc.
        /// 
        /// r0: dividend (low bits)
        /// r1: dividend (high bits)
        /// r2: divisor (low bits)
        /// r3: divisor (high bits)
        /// return: dividend % divisor
        /// </summary>
        public int UllMod
        {
            get
            {
                if (f_ullMod)
                    return _ullMod;
                _ullMod = (int) (146800);
                f_ullMod = true;
                return _ullMod;
            }
        }
        private bool f_insertThreadIntoList;
        private int _insertThreadIntoList;

        /// <summary>
        /// Inserts a new thread into the linked thread list (see thread_info::thread_list_head).
        /// 
        /// The thread is inserted in sorted order.
        /// 
        /// r0: Thread to insert
        /// </summary>
        public int InsertThreadIntoList
        {
            get
            {
                if (f_insertThreadIntoList)
                    return _insertThreadIntoList;
                _insertThreadIntoList = (int) (53696);
                f_insertThreadIntoList = true;
                return _insertThreadIntoList;
            }
        }
        private bool f_g3XInitTable;
        private int _g3XInitTable;
        public int G3XInitTable
        {
            get
            {
                if (f_g3XInitTable)
                    return _g3XInitTable;
                _g3XInitTable = (int) (47580);
                f_g3XInitTable = true;
                return _g3XInitTable;
            }
        }
        private bool f_gxBeginLoadTexPltt;
        private int _gxBeginLoadTexPltt;
        public int GxBeginLoadTexPltt
        {
            get
            {
                if (f_gxBeginLoadTexPltt)
                    return _gxBeginLoadTexPltt;
                _gxBeginLoadTexPltt = (int) (50948);
                f_gxBeginLoadTexPltt = true;
                return _gxBeginLoadTexPltt;
            }
        }
        private bool f_dseDriverStartMainThread;
        private int _dseDriverStartMainThread;
        public int DseDriverStartMainThread
        {
            get
            {
                if (f_dseDriverStartMainThread)
                    return _dseDriverStartMainThread;
                _dseDriverStartMainThread = (int) (19764);
                f_dseDriverStartMainThread = true;
                return _dseDriverStartMainThread;
            }
        }
        private bool f_soundLfoWaveHalfNoiseFunc;
        private int _soundLfoWaveHalfNoiseFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveHalfNoiseFunc
        {
            get
            {
                if (f_soundLfoWaveHalfNoiseFunc)
                    return _soundLfoWaveHalfNoiseFunc;
                _soundLfoWaveHalfNoiseFunc = (int) (38044);
                f_soundLfoWaveHalfNoiseFunc = true;
                return _soundLfoWaveHalfNoiseFunc;
            }
        }
        private bool f_gxsLoadOam;
        private int _gxsLoadOam;
        public int GxsLoadOam
        {
            get
            {
                if (f_gxsLoadOam)
                    return _gxsLoadOam;
                _gxsLoadOam = (int) (48592);
                f_gxsLoadOam = true;
                return _gxsLoadOam;
            }
        }
        private bool f_dseChannelSetInstrument;
        private int _dseChannelSetInstrument;
        public int DseChannelSetInstrument
        {
            get
            {
                if (f_dseChannelSetInstrument)
                    return _dseChannelSetInstrument;
                _dseChannelSetInstrument = (int) (31472);
                f_dseChannelSetInstrument = true;
                return _dseChannelSetInstrument;
            }
        }
        private bool f_dseSynthReset;
        private int _dseSynthReset;
        public int DseSynthReset
        {
            get
            {
                if (f_dseSynthReset)
                    return _dseSynthReset;
                _dseSynthReset = (int) (28976);
                f_dseSynthReset = true;
                return _dseSynthReset;
            }
        }
        private bool f_ddiv;
        private int _ddiv;

        /// <summary>
        /// Implements the division operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __divdf3 in libgcc.
        /// 
        /// r0: dividend (low bits)
        /// r1: dividend (high bits)
        /// r2: divisor (low bits)
        /// r3: divisor (high bits)
        /// return: dividend / divisor
        /// </summary>
        public int Ddiv
        {
            get
            {
                if (f_ddiv)
                    return _ddiv;
                _ddiv = (int) (147924);
                f_ddiv = true;
                return _ddiv;
            }
        }
        private bool f_dseVoiceUpdateHardware;
        private int _dseVoiceUpdateHardware;
        public int DseVoiceUpdateHardware
        {
            get
            {
                if (f_dseVoiceUpdateHardware)
                    return _dseVoiceUpdateHardware;
                _dseVoiceUpdateHardware = (int) (35200);
                f_dseVoiceUpdateHardware = true;
                return _dseVoiceUpdateHardware;
            }
        }
        private bool f_g2GetBg1ScrPtr;
        private int _g2GetBg1ScrPtr;
        public int G2GetBg1ScrPtr
        {
            get
            {
                if (f_g2GetBg1ScrPtr)
                    return _g2GetBg1ScrPtr;
                _g2GetBg1ScrPtr = (int) (45924);
                f_g2GetBg1ScrPtr = true;
                return _g2GetBg1ScrPtr;
            }
        }
        private bool f_dsqrt;
        private int _dsqrt;

        /// <summary>
        /// Analogous to the sqrt(3) C library function.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// r0: x (low bits)
        /// r1: x (high bits)
        /// return: sqrt(x)
        /// </summary>
        public int Dsqrt
        {
            get
            {
                if (f_dsqrt)
                    return _dsqrt;
                _dsqrt = (int) (140920);
                f_dsqrt = true;
                return _dsqrt;
            }
        }
        private bool f_g2GetBg3ScrPtr;
        private int _g2GetBg3ScrPtr;
        public int G2GetBg3ScrPtr
        {
            get
            {
                if (f_g2GetBg3ScrPtr)
                    return _g2GetBg3ScrPtr;
                _g2GetBg3ScrPtr = (int) (46140);
                f_g2GetBg3ScrPtr = true;
                return _g2GetBg3ScrPtr;
            }
        }
        private bool f_gxHBlankIntr;
        private int _gxHBlankIntr;
        public int GxHBlankIntr
        {
            get
            {
                if (f_gxHBlankIntr)
                    return _gxHBlankIntr;
                _gxHBlankIntr = (int) (41192);
                f_gxHBlankIntr = true;
                return _gxHBlankIntr;
            }
        }
        private bool f_dseBgmLoad;
        private int _dseBgmLoad;
        public int DseBgmLoad
        {
            get
            {
                if (f_dseBgmLoad)
                    return _dseBgmLoad;
                _dseBgmLoad = (int) (5936);
                f_dseBgmLoad = true;
                return _dseBgmLoad;
            }
        }
        private bool f_dseTrackEventSetPan;
        private int _dseTrackEventSetPan;
        public int DseTrackEventSetPan
        {
            get
            {
                if (f_dseTrackEventSetPan)
                    return _dseTrackEventSetPan;
                _dseTrackEventSetPan = (int) (25724);
                f_dseTrackEventSetPan = true;
                return _dseTrackEventSetPan;
            }
        }
        private bool f_gxDisableBankForObj;
        private int _gxDisableBankForObj;
        public int GxDisableBankForObj
        {
            get
            {
                if (f_gxDisableBankForObj)
                    return _gxDisableBankForObj;
                _gxDisableBankForObj = (int) (45528);
                f_gxDisableBankForObj = true;
                return _gxDisableBankForObj;
            }
        }
        private bool f_dseSwdCloseMainBankFileReader;
        private int _dseSwdCloseMainBankFileReader;
        public int DseSwdCloseMainBankFileReader
        {
            get
            {
                if (f_dseSwdCloseMainBankFileReader)
                    return _dseSwdCloseMainBankFileReader;
                _dseSwdCloseMainBankFileReader = (int) (5716);
                f_dseSwdCloseMainBankFileReader = true;
                return _dseSwdCloseMainBankFileReader;
            }
        }
        private bool f_dseTrackEventPanDelta;
        private int _dseTrackEventPanDelta;
        public int DseTrackEventPanDelta
        {
            get
            {
                if (f_dseTrackEventPanDelta)
                    return _dseTrackEventPanDelta;
                _dseTrackEventPanDelta = (int) (25852);
                f_dseTrackEventPanDelta = true;
                return _dseTrackEventPanDelta;
            }
        }
        private bool f_gxVBlankIntr;
        private int _gxVBlankIntr;
        public int GxVBlankIntr
        {
            get
            {
                if (f_gxVBlankIntr)
                    return _gxVBlankIntr;
                _gxVBlankIntr = (int) (41232);
                f_gxVBlankIntr = true;
                return _gxVBlankIntr;
            }
        }
        private bool f_strlen;
        private int _strlen;

        /// <summary>
        /// The strlen(3) C library function.
        /// 
        /// r0: s
        /// return: length of s
        /// </summary>
        public int Strlen
        {
            get
            {
                if (f_strlen)
                    return _strlen;
                _strlen = (int) (120224);
                f_strlen = true;
                return _strlen;
            }
        }
        private bool f_dseSequenceGetSmallestNumLoops;
        private int _dseSequenceGetSmallestNumLoops;
        public int DseSequenceGetSmallestNumLoops
        {
            get
            {
                if (f_dseSequenceGetSmallestNumLoops)
                    return _dseSequenceGetSmallestNumLoops;
                _dseSequenceGetSmallestNumLoops = (int) (8512);
                f_dseSequenceGetSmallestNumLoops = true;
                return _dseSequenceGetSmallestNumLoops;
            }
        }
        private bool f_dseSequenceAllocateNew;
        private int _dseSequenceAllocateNew;
        public int DseSequenceAllocateNew
        {
            get
            {
                if (f_dseSequenceAllocateNew)
                    return _dseSequenceAllocateNew;
                _dseSequenceAllocateNew = (int) (9672);
                f_dseSequenceAllocateNew = true;
                return _dseSequenceAllocateNew;
            }
        }
        private bool f_dseSeStopAll;
        private int _dseSeStopAll;
        public int DseSeStopAll
        {
            get
            {
                if (f_dseSeStopAll)
                    return _dseSeStopAll;
                _dseSeStopAll = (int) (13320);
                f_dseSeStopAll = true;
                return _dseSeStopAll;
            }
        }
        private bool f_dseTrackEventSetupPanLfo;
        private int _dseTrackEventSetupPanLfo;
        public int DseTrackEventSetupPanLfo
        {
            get
            {
                if (f_dseTrackEventSetupPanLfo)
                    return _dseTrackEventSetupPanLfo;
                _dseTrackEventSetupPanLfo = (int) (26092);
                f_dseTrackEventSetupPanLfo = true;
                return _dseTrackEventSetupPanLfo;
            }
        }
        private bool f_dseSequenceSetFades;
        private int _dseSequenceSetFades;
        public int DseSequenceSetFades
        {
            get
            {
                if (f_dseSequenceSetFades)
                    return _dseSequenceSetFades;
                _dseSequenceSetFades = (int) (7320);
                f_dseSequenceSetFades = true;
                return _dseSequenceSetFades;
            }
        }
        private bool f_gxDisableBankForSubObjExtPltt;
        private int _gxDisableBankForSubObjExtPltt;
        public int GxDisableBankForSubObjExtPltt
        {
            get
            {
                if (f_gxDisableBankForSubObjExtPltt)
                    return _gxDisableBankForSubObjExtPltt;
                _gxDisableBankForSubObjExtPltt = (int) (45800);
                f_gxDisableBankForSubObjExtPltt = true;
                return _gxDisableBankForSubObjExtPltt;
            }
        }
        private bool f_dseTrackEventSetupLfoEnvelope;
        private int _dseTrackEventSetupLfoEnvelope;
        public int DseTrackEventSetupLfoEnvelope
        {
            get
            {
                if (f_dseTrackEventSetupLfoEnvelope)
                    return _dseTrackEventSetupLfoEnvelope;
                _dseTrackEventSetupLfoEnvelope = (int) (26352);
                f_dseTrackEventSetupLfoEnvelope = true;
                return _dseTrackEventSetupLfoEnvelope;
            }
        }
        private bool f_tryAssignByteWrapper;
        private int _tryAssignByteWrapper;

        /// <summary>
        /// Wrapper around TryAssignByte.
        /// 
        /// Accesses the TryAssignByte function with a weird chain of pointer dereferences.
        /// 
        /// r0: pointer
        /// r1: value
        /// return: true on success, false on failure
        /// </summary>
        public int TryAssignByteWrapper
        {
            get
            {
                if (f_tryAssignByteWrapper)
                    return _tryAssignByteWrapper;
                _tryAssignByteWrapper = (int) (110896);
                f_tryAssignByteWrapper = true;
                return _tryAssignByteWrapper;
            }
        }
        private bool f_dseDriverMain;
        private int _dseDriverMain;
        public int DseDriverMain
        {
            get
            {
                if (f_dseDriverMain)
                    return _dseDriverMain;
                _dseDriverMain = (int) (20284);
                f_dseDriverMain = true;
                return _dseDriverMain;
            }
        }
        private bool f_gxResetBankForObjExtPltt;
        private int _gxResetBankForObjExtPltt;
        public int GxResetBankForObjExtPltt
        {
            get
            {
                if (f_gxResetBankForObjExtPltt)
                    return _gxResetBankForObjExtPltt;
                _gxResetBankForObjExtPltt = (int) (45128);
                f_gxResetBankForObjExtPltt = true;
                return _gxResetBankForObjExtPltt;
            }
        }
        private bool f_dsub;
        private int _dsub;

        /// <summary>
        /// Implements the subtraction operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __subdf3 in libgcc.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a - b
        /// </summary>
        public int Dsub
        {
            get
            {
                if (f_dsub)
                    return _dsub;
                _dsub = (int) (141356);
                f_dsub = true;
                return _dsub;
            }
        }
        private bool f_soundLfoBankSetConstEnvelopes;
        private int _soundLfoBankSetConstEnvelopes;

        /// <summary>
        /// r0: LFO bank pointer
        /// r1: Level
        /// </summary>
        public int SoundLfoBankSetConstEnvelopes
        {
            get
            {
                if (f_soundLfoBankSetConstEnvelopes)
                    return _soundLfoBankSetConstEnvelopes;
                _soundLfoBankSetConstEnvelopes = (int) (37332);
                f_soundLfoBankSetConstEnvelopes = true;
                return _soundLfoBankSetConstEnvelopes;
            }
        }
        private bool f_u32DivF;
        private int _u32DivF;

        /// <summary>
        /// Implements the division operator for unsigned ints.
        /// 
        /// Analogous to __udivsi3 in libgcc.
        /// 
        /// The return value is a 64-bit integer, with the quotient (dividend / divisor) in the lower 32 bits and the remainder (dividend % divisor) in the upper 32 bits. In accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return), this means that the quotient is returned in r0 and the remainder is returned in r1.
        /// Note: This function falls through to _u32_div_not_0_f.
        /// 
        /// r0: dividend
        /// r1: divisor
        /// return: (quotient) | (remainder &lt;&lt; 32)
        /// </summary>
        public int U32DivF
        {
            get
            {
                if (f_u32DivF)
                    return _u32DivF;
                _u32DivF = (int) (147416);
                f_u32DivF = true;
                return _u32DivF;
            }
        }
        private bool f_cryptoRc4Init;
        private int _cryptoRc4Init;
        public int CryptoRc4Init
        {
            get
            {
                if (f_cryptoRc4Init)
                    return _cryptoRc4Init;
                _cryptoRc4Init = (int) (38472);
                f_cryptoRc4Init = true;
                return _cryptoRc4Init;
            }
        }
        private bool f_gxLoadTex;
        private int _gxLoadTex;
        public int GxLoadTex
        {
            get
            {
                if (f_gxLoadTex)
                    return _gxLoadTex;
                _gxLoadTex = (int) (50552);
                f_gxLoadTex = true;
                return _gxLoadTex;
            }
        }
        private bool f_loadOverlayInternal;
        private int _loadOverlayInternal;

        /// <summary>
        /// Called by LoadOverlay to load an overlay into RAM given its info struct
        /// 
        /// r0: Overlay info struct
        /// Return: True if the overlay was loaded successfully?
        /// </summary>
        public int LoadOverlayInternal
        {
            get
            {
                if (f_loadOverlayInternal)
                    return _loadOverlayInternal;
                _loadOverlayInternal = (int) (81088);
                f_loadOverlayInternal = true;
                return _loadOverlayInternal;
            }
        }
        private bool f_gxEndLoadBgExtPltt;
        private int _gxEndLoadBgExtPltt;
        public int GxEndLoadBgExtPltt
        {
            get
            {
                if (f_gxEndLoadBgExtPltt)
                    return _gxEndLoadBgExtPltt;
                _gxEndLoadBgExtPltt = (int) (50072);
                f_gxEndLoadBgExtPltt = true;
                return _gxEndLoadBgExtPltt;
            }
        }
        private bool f_gxSetBankForSubBgExtPltt;
        private int _gxSetBankForSubBgExtPltt;
        public int GxSetBankForSubBgExtPltt
        {
            get
            {
                if (f_gxSetBankForSubBgExtPltt)
                    return _gxSetBankForSubBgExtPltt;
                _gxSetBankForSubBgExtPltt = (int) (44784);
                f_gxSetBankForSubBgExtPltt = true;
                return _gxSetBankForSubBgExtPltt;
            }
        }
        private bool f_dseTrackEventSetBankLsb;
        private int _dseTrackEventSetBankLsb;
        public int DseTrackEventSetBankLsb
        {
            get
            {
                if (f_dseTrackEventSetBankLsb)
                    return _dseTrackEventSetBankLsb;
                _dseTrackEventSetBankLsb = (int) (23268);
                f_dseTrackEventSetBankLsb = true;
                return _dseTrackEventSetBankLsb;
            }
        }
        private bool f_gxSetBankForObj;
        private int _gxSetBankForObj;
        public int GxSetBankForObj
        {
            get
            {
                if (f_gxSetBankForObj)
                    return _gxSetBankForObj;
                _gxSetBankForObj = (int) (42524);
                f_gxSetBankForObj = true;
                return _gxSetBankForObj;
            }
        }
        private bool f_dseVoiceFlagForActivation;
        private int _dseVoiceFlagForActivation;
        public int DseVoiceFlagForActivation
        {
            get
            {
                if (f_dseVoiceFlagForActivation)
                    return _dseVoiceFlagForActivation;
                _dseVoiceFlagForActivation = (int) (35020);
                f_dseVoiceFlagForActivation = true;
                return _dseVoiceFlagForActivation;
            }
        }
        private bool f_dseUtilByteSwap32;
        private int _dseUtilByteSwap32;
        public int DseUtilByteSwap32
        {
            get
            {
                if (f_dseUtilByteSwap32)
                    return _dseUtilByteSwap32;
                _dseUtilByteSwap32 = (int) (2028);
                f_dseUtilByteSwap32 = true;
                return _dseUtilByteSwap32;
            }
        }
        private bool f_getIrqFlag;
        private int _getIrqFlag;

        /// <summary>
        /// Gets the current value of the processor's interrupt request (i) flag
        /// 
        /// return: cpsr &amp; 0x80 (0x80 if interrupts are disabled, 0x0 if they are enabled)
        /// </summary>
        public int GetIrqFlag
        {
            get
            {
                if (f_getIrqFlag)
                    return _getIrqFlag;
                _getIrqFlag = (int) (63332);
                f_getIrqFlag = true;
                return _getIrqFlag;
            }
        }
        private bool f_strcat;
        private int _strcat;

        /// <summary>
        /// The strcat(3) C library function.
        /// 
        /// r0: dest
        /// r1: src
        /// return: dest
        /// </summary>
        public int Strcat
        {
            get
            {
                if (f_strcat)
                    return _strcat;
                _strcat = (int) (120532);
                f_strcat = true;
                return _strcat;
            }
        }
        private bool f_dseSwdLoadWavesInternal;
        private int _dseSwdLoadWavesInternal;
        public int DseSwdLoadWavesInternal
        {
            get
            {
                if (f_dseSwdLoadWavesInternal)
                    return _dseSwdLoadWavesInternal;
                _dseSwdLoadWavesInternal = (int) (4864);
                f_dseSwdLoadWavesInternal = true;
                return _dseSwdLoadWavesInternal;
            }
        }
        private bool f_dseTrackEventUseKeyBendLfo;
        private int _dseTrackEventUseKeyBendLfo;
        public int DseTrackEventUseKeyBendLfo
        {
            get
            {
                if (f_dseTrackEventUseKeyBendLfo)
                    return _dseTrackEventUseKeyBendLfo;
                _dseTrackEventUseKeyBendLfo = (int) (24956);
                f_dseTrackEventUseKeyBendLfo = true;
                return _dseTrackEventUseKeyBendLfo;
            }
        }
        private bool f_dseSeGetEffectSong;
        private int _dseSeGetEffectSong;
        public int DseSeGetEffectSong
        {
            get
            {
                if (f_dseSeGetEffectSong)
                    return _dseSeGetEffectSong;
                _dseSeGetEffectSong = (int) (11992);
                f_dseSeGetEffectSong = true;
                return _dseSeGetEffectSong;
            }
        }
        private bool f_fxAtan2Idx;
        private int _fxAtan2Idx;
        public int FxAtan2Idx
        {
            get
            {
                if (f_fxAtan2Idx)
                    return _fxAtan2Idx;
                _fxAtan2Idx = (int) (40432);
                f_fxAtan2Idx = true;
                return _fxAtan2Idx;
            }
        }
        private bool f_gxsLoadObjPltt;
        private int _gxsLoadObjPltt;
        public int GxsLoadObjPltt
        {
            get
            {
                if (f_gxsLoadObjPltt)
                    return _gxsLoadObjPltt;
                _gxsLoadObjPltt = (int) (48420);
                f_gxsLoadObjPltt = true;
                return _gxsLoadObjPltt;
            }
        }
        private bool f_dseTrackEventSetExpression;
        private int _dseTrackEventSetExpression;
        public int DseTrackEventSetExpression
        {
            get
            {
                if (f_dseTrackEventSetExpression)
                    return _dseTrackEventSetExpression;
                _dseTrackEventSetExpression = (int) (25412);
                f_dseTrackEventSetExpression = true;
                return _dseTrackEventSetExpression;
            }
        }
        private bool f_dseSePlay;
        private int _dseSePlay;
        public int DseSePlay
        {
            get
            {
                if (f_dseSePlay)
                    return _dseSePlay;
                _dseSePlay = (int) (11556);
                f_dseSePlay = true;
                return _dseSePlay;
            }
        }
        private bool f_memsetFast;
        private int _memsetFast;

        /// <summary>
        /// A semi-optimized implementation of the memset(3) C library function.
        /// 
        /// This function was probably manually implemented by the developers, or was included as part of a library other than libc (the Nitro SDK probably?). See memset for what's probably the real libc function.
        /// 
        /// This function is optimized to set values in 4-byte chunks, properly dealing with pointer alignment. However, unlike the libc memset, there are no loop unrolling optimizations.
        /// 
        /// r0: ptr
        /// r1: value
        /// r2: len (# bytes)
        /// </summary>
        public int MemsetFast
        {
            get
            {
                if (f_memsetFast)
                    return _memsetFast;
                _memsetFast = (int) (66356);
                f_memsetFast = true;
                return _memsetFast;
            }
        }
        private bool f_dseSwdGetMainBankById;
        private int _dseSwdGetMainBankById;
        public int DseSwdGetMainBankById
        {
            get
            {
                if (f_dseSwdGetMainBankById)
                    return _dseSwdGetMainBankById;
                _dseSwdGetMainBankById = (int) (5496);
                f_dseSwdGetMainBankById = true;
                return _dseSwdGetMainBankById;
            }
        }
        private bool f_enableVramBanksInSet;
        private int _enableVramBanksInSet;

        /// <summary>
        /// Enable the VRAM banks in the input set. Will reset the pointed set to 0, and update ENABLED_VRAM_BANKS
        /// 
        /// r0: vram_banks_set *
        /// </summary>
        public int EnableVramBanksInSet
        {
            get
            {
                if (f_enableVramBanksInSet)
                    return _enableVramBanksInSet;
                _enableVramBanksInSet = (int) (45040);
                f_enableVramBanksInSet = true;
                return _enableVramBanksInSet;
            }
        }
        private bool f_dseVoiceRelease;
        private int _dseVoiceRelease;
        public int DseVoiceRelease
        {
            get
            {
                if (f_dseVoiceRelease)
                    return _dseVoiceRelease;
                _dseVoiceRelease = (int) (34692);
                f_dseVoiceRelease = true;
                return _dseVoiceRelease;
            }
        }
        private bool f_dseVoiceResetAll;
        private int _dseVoiceResetAll;
        public int DseVoiceResetAll
        {
            get
            {
                if (f_dseVoiceResetAll)
                    return _dseVoiceResetAll;
                _dseVoiceResetAll = (int) (33376);
                f_dseVoiceResetAll = true;
                return _dseVoiceResetAll;
            }
        }
        private bool f_dseTrackEventForceLfoEnvelopeLevel;
        private int _dseTrackEventForceLfoEnvelopeLevel;
        public int DseTrackEventForceLfoEnvelopeLevel
        {
            get
            {
                if (f_dseTrackEventForceLfoEnvelopeLevel)
                    return _dseTrackEventForceLfoEnvelopeLevel;
                _dseTrackEventForceLfoEnvelopeLevel = (int) (23780);
                f_dseTrackEventForceLfoEnvelopeLevel = true;
                return _dseTrackEventForceLfoEnvelopeLevel;
            }
        }
        private bool f_countLeadingZeros;
        private int _countLeadingZeros;

        /// <summary>
        /// Counts the number of leading zeros in a 32-bit integer.
        /// 
        /// r0: x
        /// return: clz(x)
        /// </summary>
        public int CountLeadingZeros
        {
            get
            {
                if (f_countLeadingZeros)
                    return _countLeadingZeros;
                _countLeadingZeros = (int) (63924);
                f_countLeadingZeros = true;
                return _countLeadingZeros;
            }
        }
        private bool f_dseSwdSampleLoaderMain;
        private int _dseSwdSampleLoaderMain;
        public int DseSwdSampleLoaderMain
        {
            get
            {
                if (f_dseSwdSampleLoaderMain)
                    return _dseSwdSampleLoaderMain;
                _dseSwdSampleLoaderMain = (int) (3472);
                f_dseSwdSampleLoaderMain = true;
                return _dseSwdSampleLoaderMain;
            }
        }
        private bool f_dseTrackEventOctaveDelta;
        private int _dseTrackEventOctaveDelta;
        public int DseTrackEventOctaveDelta
        {
            get
            {
                if (f_dseTrackEventOctaveDelta)
                    return _dseTrackEventOctaveDelta;
                _dseTrackEventOctaveDelta = (int) (23028);
                f_dseTrackEventOctaveDelta = true;
                return _dseTrackEventOctaveDelta;
            }
        }
        private bool f_dseSeUnload;
        private int _dseSeUnload;
        public int DseSeUnload
        {
            get
            {
                if (f_dseSeUnload)
                    return _dseSeUnload;
                _dseSeUnload = (int) (10996);
                f_dseSeUnload = true;
                return _dseSeUnload;
            }
        }
        private bool f_fxInvAsync;
        private int _fxInvAsync;
        public int FxInvAsync
        {
            get
            {
                if (f_fxInvAsync)
                    return _fxInvAsync;
                _fxInvAsync = (int) (39628);
                f_fxInvAsync = true;
                return _fxInvAsync;
            }
        }
        private bool f_dseTrackEventVolumeFade;
        private int _dseTrackEventVolumeFade;
        public int DseTrackEventVolumeFade
        {
            get
            {
                if (f_dseTrackEventVolumeFade)
                    return _dseTrackEventVolumeFade;
                _dseTrackEventVolumeFade = (int) (25320);
                f_dseTrackEventVolumeFade = true;
                return _dseTrackEventVolumeFade;
            }
        }
        private bool f_gxDisableBankForBgExtPltt;
        private int _gxDisableBankForBgExtPltt;
        public int GxDisableBankForBgExtPltt
        {
            get
            {
                if (f_gxDisableBankForBgExtPltt)
                    return _gxDisableBankForBgExtPltt;
                _gxDisableBankForBgExtPltt = (int) (45548);
                f_gxDisableBankForBgExtPltt = true;
                return _gxDisableBankForBgExtPltt;
            }
        }
        private bool f_dseTrackEventTuningDeltaFine;
        private int _dseTrackEventTuningDeltaFine;
        public int DseTrackEventTuningDeltaFine
        {
            get
            {
                if (f_dseTrackEventTuningDeltaFine)
                    return _dseTrackEventTuningDeltaFine;
                _dseTrackEventTuningDeltaFine = (int) (24164);
                f_dseTrackEventTuningDeltaFine = true;
                return _dseTrackEventTuningDeltaFine;
            }
        }
        private bool f_strncat;
        private int _strncat;

        /// <summary>
        /// The strncat(3) C library function.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// return: dest
        /// </summary>
        public int Strncat
        {
            get
            {
                if (f_strncat)
                    return _strncat;
                _strncat = (int) (120580);
                f_strncat = true;
                return _strncat;
            }
        }
        private bool f_dseMemAllocateUser;
        private int _dseMemAllocateUser;
        public int DseMemAllocateUser
        {
            get
            {
                if (f_dseMemAllocateUser)
                    return _dseMemAllocateUser;
                _dseMemAllocateUser = (int) (2256);
                f_dseMemAllocateUser = true;
                return _dseMemAllocateUser;
            }
        }
        private bool f_vecDistance;
        private int _vecDistance;
        public int VecDistance
        {
            get
            {
                if (f_vecDistance)
                    return _vecDistance;
                _vecDistance = (int) (40308);
                f_vecDistance = true;
                return _vecDistance;
            }
        }
        private bool f_gxSetBankForSubObjExtPltt;
        private int _gxSetBankForSubObjExtPltt;
        public int GxSetBankForSubObjExtPltt
        {
            get
            {
                if (f_gxSetBankForSubObjExtPltt)
                    return _gxSetBankForSubObjExtPltt;
                _gxSetBankForSubObjExtPltt = (int) (44912);
                f_gxSetBankForSubObjExtPltt = true;
                return _gxSetBankForSubObjExtPltt;
            }
        }
        private bool f_gxSetBankForTex;
        private int _gxSetBankForTex;
        public int GxSetBankForTex
        {
            get
            {
                if (f_gxSetBankForTex)
                    return _gxSetBankForTex;
                _gxSetBankForTex = (int) (43288);
                f_gxSetBankForTex = true;
                return _gxSetBankForTex;
            }
        }
        private bool f_dseTrackEventSetOctave;
        private int _dseTrackEventSetOctave;
        public int DseTrackEventSetOctave
        {
            get
            {
                if (f_dseTrackEventSetOctave)
                    return _dseTrackEventSetOctave;
                _dseTrackEventSetOctave = (int) (23016);
                f_dseTrackEventSetOctave = true;
                return _dseTrackEventSetOctave;
            }
        }
        private bool f_dseTrackEventSetEnvelopeSustainTime;
        private int _dseTrackEventSetEnvelopeSustainTime;
        public int DseTrackEventSetEnvelopeSustainTime
        {
            get
            {
                if (f_dseTrackEventSetEnvelopeSustainTime)
                    return _dseTrackEventSetEnvelopeSustainTime;
                _dseTrackEventSetEnvelopeSustainTime = (int) (23704);
                f_dseTrackEventSetEnvelopeSustainTime = true;
                return _dseTrackEventSetEnvelopeSustainTime;
            }
        }
        private bool f_dseTrackEventSetEnvelopeHoldTime;
        private int _dseTrackEventSetEnvelopeHoldTime;
        public int DseTrackEventSetEnvelopeHoldTime
        {
            get
            {
                if (f_dseTrackEventSetEnvelopeHoldTime)
                    return _dseTrackEventSetEnvelopeHoldTime;
                _dseTrackEventSetEnvelopeHoldTime = (int) (23624);
                f_dseTrackEventSetEnvelopeHoldTime = true;
                return _dseTrackEventSetEnvelopeHoldTime;
            }
        }
        private bool f_dflt;
        private int _dflt;

        /// <summary>
        /// Implements the int to double cast operation for IEEE 754 floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __floatsidf in libgcc.
        /// 
        /// r0: int
        /// return: (double)int
        /// </summary>
        public int Dflt
        {
            get
            {
                if (f_dflt)
                    return _dflt;
                _dflt = (int) (139928);
                f_dflt = true;
                return _dflt;
            }
        }
        private bool f_enableIrqFiqFlags;
        private int _enableIrqFiqFlags;

        /// <summary>
        /// Disables processor all interrupts (both standard and fast) by setting the i and f flags in the program status register (cpsr).
        /// 
        /// return: Old value of cpsr &amp; 0xC0 (contains the previous values of the i and f flags)
        /// </summary>
        public int EnableIrqFiqFlags
        {
            get
            {
                if (f_enableIrqFiqFlags)
                    return _enableIrqFiqFlags;
                _enableIrqFiqFlags = (int) (63288);
                f_enableIrqFiqFlags = true;
                return _enableIrqFiqFlags;
            }
        }
        private bool f_g3XInit;
        private int _g3XInit;
        public int G3XInit
        {
            get
            {
                if (f_g3XInit)
                    return _g3XInit;
                _g3XInit = (int) (46828);
                f_g3XInit = true;
                return _g3XInit;
            }
        }
        private bool f_gxDispOn;
        private int _gxDispOn;
        public int GxDispOn
        {
            get
            {
                if (f_gxDispOn)
                    return _gxDispOn;
                _gxDispOn = (int) (41344);
                f_gxDispOn = true;
                return _gxDispOn;
            }
        }
        private bool f_snprintf;
        private int _snprintf;

        /// <summary>
        /// The snprintf(3) C library function.
        /// 
        /// This calls __vsprintf_internal directly, so it's presumably the real snprintf.
        /// 
        /// r0: str
        /// r1: n
        /// r2: format
        /// ...: variadic
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int Snprintf
        {
            get
            {
                if (f_snprintf)
                    return _snprintf;
                _snprintf = (int) (119940);
                f_snprintf = true;
                return _snprintf;
            }
        }
        private bool f_g2GetBg0ScrPtr;
        private int _g2GetBg0ScrPtr;
        public int G2GetBg0ScrPtr
        {
            get
            {
                if (f_g2GetBg0ScrPtr)
                    return _g2GetBg0ScrPtr;
                _g2GetBg0ScrPtr = (int) (45840);
                f_g2GetBg0ScrPtr = true;
                return _g2GetBg0ScrPtr;
            }
        }
        private bool f_soundEnvelopeStop;
        private int _soundEnvelopeStop;

        /// <summary>
        /// r0: Sound envelope pointer
        /// </summary>
        public int SoundEnvelopeStop
        {
            get
            {
                if (f_soundEnvelopeStop)
                    return _soundEnvelopeStop;
                _soundEnvelopeStop = (int) (36396);
                f_soundEnvelopeStop = true;
                return _soundEnvelopeStop;
            }
        }
        private bool f_g3XSetClearColor;
        private int _g3XSetClearColor;
        public int G3XSetClearColor
        {
            get
            {
                if (f_g3XSetClearColor)
                    return _g3XSetClearColor;
                _g3XSetClearColor = (int) (47540);
                f_g3XSetClearColor = true;
                return _g3XSetClearColor;
            }
        }
        private bool f_dseSynthRestoreHeldNotes;
        private int _dseSynthRestoreHeldNotes;
        public int DseSynthRestoreHeldNotes
        {
            get
            {
                if (f_dseSynthRestoreHeldNotes)
                    return _dseSynthRestoreHeldNotes;
                _dseSynthRestoreHeldNotes = (int) (29740);
                f_dseSynthRestoreHeldNotes = true;
                return _dseSynthRestoreHeldNotes;
            }
        }
        private bool f_g2xChangeBlendBrightness;
        private int _g2xChangeBlendBrightness;
        public int G2xChangeBlendBrightness
        {
            get
            {
                if (f_g2xChangeBlendBrightness)
                    return _g2xChangeBlendBrightness;
                _g2xChangeBlendBrightness = (int) (46676);
                f_g2xChangeBlendBrightness = true;
                return _g2xChangeBlendBrightness;
            }
        }
        private bool f_dmul;
        private int _dmul;

        /// <summary>
        /// Implements the multiplication operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __muldf3 in libgcc.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a * b
        /// </summary>
        public int Dmul
        {
            get
            {
                if (f_dmul)
                    return _dmul;
                _dmul = (int) (140052);
                f_dmul = true;
                return _dmul;
            }
        }
        private bool f_soundLfoWaveFullTriangleFunc;
        private int _soundLfoWaveFullTriangleFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveFullTriangleFunc
        {
            get
            {
                if (f_soundLfoWaveFullTriangleFunc)
                    return _soundLfoWaveFullTriangleFunc;
                _soundLfoWaveFullTriangleFunc = (int) (37824);
                f_soundLfoWaveFullTriangleFunc = true;
                return _soundLfoWaveFullTriangleFunc;
            }
        }
        private bool f_dseTrackEventSetLfoParameter;
        private int _dseTrackEventSetLfoParameter;
        public int DseTrackEventSetLfoParameter
        {
            get
            {
                if (f_dseTrackEventSetLfoParameter)
                    return _dseTrackEventSetLfoParameter;
                _dseTrackEventSetLfoParameter = (int) (26404);
                f_dseTrackEventSetLfoParameter = true;
                return _dseTrackEventSetLfoParameter;
            }
        }
        private bool f_gxLoadBgPltt;
        private int _gxLoadBgPltt;
        public int GxLoadBgPltt
        {
            get
            {
                if (f_gxLoadBgPltt)
                    return _gxLoadBgPltt;
                _gxLoadBgPltt = (int) (48160);
                f_gxLoadBgPltt = true;
                return _gxLoadBgPltt;
            }
        }
        private bool f_gXxSetMasterBrightness;
        private int _gXxSetMasterBrightness;
        public int GXxSetMasterBrightness
        {
            get
            {
                if (f_gXxSetMasterBrightness)
                    return _gXxSetMasterBrightness;
                _gXxSetMasterBrightness = (int) (41548);
                f_gXxSetMasterBrightness = true;
                return _gXxSetMasterBrightness;
            }
        }
        private bool f_dseSeCheckTooManyInstancesInGroup;
        private int _dseSeCheckTooManyInstancesInGroup;
        public int DseSeCheckTooManyInstancesInGroup
        {
            get
            {
                if (f_dseSeCheckTooManyInstancesInGroup)
                    return _dseSeCheckTooManyInstancesInGroup;
                _dseSeCheckTooManyInstancesInGroup = (int) (12328);
                f_dseSeCheckTooManyInstancesInGroup = true;
                return _dseSeCheckTooManyInstancesInGroup;
            }
        }
        private bool f_dseMemAllocateThreadStack;
        private int _dseMemAllocateThreadStack;
        public int DseMemAllocateThreadStack
        {
            get
            {
                if (f_dseMemAllocateThreadStack)
                    return _dseMemAllocateThreadStack;
                _dseMemAllocateThreadStack = (int) (2548);
                f_dseMemAllocateThreadStack = true;
                return _dseMemAllocateThreadStack;
            }
        }
        private bool f_deq;
        private int _deq;

        /// <summary>
        /// Implements the == operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a == b
        /// </summary>
        public int Deq
        {
            get
            {
                if (f_deq)
                    return _deq;
                _deq = (int) (143324);
                f_deq = true;
                return _deq;
            }
        }
        private bool f_ffltu;
        private int _ffltu;

        /// <summary>
        /// Implements the unsigned int to float cast operation for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __floatunsisf in libgcc.
        /// 
        /// r0: uint
        /// return: (float)uint
        /// </summary>
        public int Ffltu
        {
            get
            {
                if (f_ffltu)
                    return _ffltu;
                _ffltu = (int) (144916);
                f_ffltu = true;
                return _ffltu;
            }
        }
        private bool f_gxDisableBankForSubBgExtPltt;
        private int _gxDisableBankForSubBgExtPltt;
        public int GxDisableBankForSubBgExtPltt
        {
            get
            {
                if (f_gxDisableBankForSubBgExtPltt)
                    return _gxDisableBankForSubBgExtPltt;
                _gxDisableBankForSubBgExtPltt = (int) (45760);
                f_gxDisableBankForSubBgExtPltt = true;
                return _gxDisableBankForSubBgExtPltt;
            }
        }
        private bool f_gxDisableBankForTexPltt;
        private int _gxDisableBankForTexPltt;
        public int GxDisableBankForTexPltt
        {
            get
            {
                if (f_gxDisableBankForTexPltt)
                    return _gxDisableBankForTexPltt;
                _gxDisableBankForTexPltt = (int) (45640);
                f_gxDisableBankForTexPltt = true;
                return _gxDisableBankForTexPltt;
            }
        }
        private bool f_dseSynthSetGlobalVolumeIndex;
        private int _dseSynthSetGlobalVolumeIndex;
        public int DseSynthSetGlobalVolumeIndex
        {
            get
            {
                if (f_dseSynthSetGlobalVolumeIndex)
                    return _dseSynthSetGlobalVolumeIndex;
                _dseSynthSetGlobalVolumeIndex = (int) (29844);
                f_dseSynthSetGlobalVolumeIndex = true;
                return _dseSynthSetGlobalVolumeIndex;
            }
        }
        private bool f_dseTrackEventSetBpm;
        private int _dseTrackEventSetBpm;
        public int DseTrackEventSetBpm
        {
            get
            {
                if (f_dseTrackEventSetBpm)
                    return _dseTrackEventSetBpm;
                _dseTrackEventSetBpm = (int) (23048);
                f_dseTrackEventSetBpm = true;
                return _dseTrackEventSetBpm;
            }
        }
        private bool f_soundEnvelopeTick;
        private int _soundEnvelopeTick;

        /// <summary>
        /// r0: Sound envelope pointer
        /// return: Current volume
        /// </summary>
        public int SoundEnvelopeTick
        {
            get
            {
                if (f_soundEnvelopeTick)
                    return _soundEnvelopeTick;
                _soundEnvelopeTick = (int) (36476);
                f_soundEnvelopeTick = true;
                return _soundEnvelopeTick;
            }
        }
        private bool f_llUfromD;
        private int _llUfromD;

        /// <summary>
        /// Implements the double to unsigned long long cast operation for IEEE 754 floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __fixunsdfti in libgcc.
        /// 
        /// r0: double (low bits)
        /// r1: double (high bits)
        /// return: (unsigned long long)double
        /// </summary>
        public int LlUfromD
        {
            get
            {
                if (f_llUfromD)
                    return _llUfromD;
                _llUfromD = (int) (139788);
                f_llUfromD = true;
                return _llUfromD;
            }
        }
        private bool f_dseSynthSetPan;
        private int _dseSynthSetPan;
        public int DseSynthSetPan
        {
            get
            {
                if (f_dseSynthSetPan)
                    return _dseSynthSetPan;
                _dseSynthSetPan = (int) (30432);
                f_dseSynthSetPan = true;
                return _dseSynthSetPan;
            }
        }
        private bool f_dseTrackEventSetVolume;
        private int _dseTrackEventSetVolume;
        public int DseTrackEventSetVolume
        {
            get
            {
                if (f_dseTrackEventSetVolume)
                    return _dseTrackEventSetVolume;
                _dseTrackEventSetVolume = (int) (24996);
                f_dseTrackEventSetVolume = true;
                return _dseTrackEventSetVolume;
            }
        }
        private bool f_gxDisableBankForTex;
        private int _gxDisableBankForTex;
        public int GxDisableBankForTex
        {
            get
            {
                if (f_gxDisableBankForTex)
                    return _gxDisableBankForTex;
                _gxDisableBankForTex = (int) (45620);
                f_gxDisableBankForTex = true;
                return _gxDisableBankForTex;
            }
        }
        private bool f_dseTrackEventSetupKeyBendLfoEnvelope;
        private int _dseTrackEventSetupKeyBendLfoEnvelope;
        public int DseTrackEventSetupKeyBendLfoEnvelope
        {
            get
            {
                if (f_dseTrackEventSetupKeyBendLfoEnvelope)
                    return _dseTrackEventSetupKeyBendLfoEnvelope;
                _dseTrackEventSetupKeyBendLfoEnvelope = (int) (24916);
                f_dseTrackEventSetupKeyBendLfoEnvelope = true;
                return _dseTrackEventSetupKeyBendLfoEnvelope;
            }
        }
        private bool f_soundLfoBankReset;
        private int _soundLfoBankReset;

        /// <summary>
        /// r0: LFO bank pointer
        /// </summary>
        public int SoundLfoBankReset
        {
            get
            {
                if (f_soundLfoBankReset)
                    return _soundLfoBankReset;
                _soundLfoBankReset = (int) (36804);
                f_soundLfoBankReset = true;
                return _soundLfoBankReset;
            }
        }
        private bool f_g3XGetMtxStackLevelPj;
        private int _g3XGetMtxStackLevelPj;
        public int G3XGetMtxStackLevelPj
        {
            get
            {
                if (f_g3XGetMtxStackLevelPj)
                    return _g3XGetMtxStackLevelPj;
                _g3XGetMtxStackLevelPj = (int) (47788);
                f_g3XGetMtxStackLevelPj = true;
                return _g3XGetMtxStackLevelPj;
            }
        }
        private bool f_dgeq;
        private int _dgeq;

        /// <summary>
        /// Implements the &gt;= operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a &gt;= b
        /// </summary>
        public int Dgeq
        {
            get
            {
                if (f_dgeq)
                    return _dgeq;
                _dgeq = (int) (142852);
                f_dgeq = true;
                return _dgeq;
            }
        }
        private bool f_gxSetGraphicsMode;
        private int _gxSetGraphicsMode;
        public int GxSetGraphicsMode
        {
            get
            {
                if (f_gxSetGraphicsMode)
                    return _gxSetGraphicsMode;
                _gxSetGraphicsMode = (int) (41416);
                f_gxSetGraphicsMode = true;
                return _gxSetGraphicsMode;
            }
        }
        private bool f_dseSeHasPlayingInstances;
        private int _dseSeHasPlayingInstances;
        public int DseSeHasPlayingInstances
        {
            get
            {
                if (f_dseSeHasPlayingInstances)
                    return _dseSeHasPlayingInstances;
                _dseSeHasPlayingInstances = (int) (11352);
                f_dseSeHasPlayingInstances = true;
                return _dseSeHasPlayingInstances;
            }
        }
        private bool f_enableIrqFlag;
        private int _enableIrqFlag;

        /// <summary>
        /// Disables processor interrupts by setting the i flag in the program status register (cpsr).
        /// 
        /// return: Old value of cpsr &amp; 0x80 (0x80 if interrupts were already disabled, 0x0 if they were enabled)
        /// </summary>
        public int EnableIrqFlag
        {
            get
            {
                if (f_enableIrqFlag)
                    return _enableIrqFlag;
                _enableIrqFlag = (int) (63244);
                f_enableIrqFlag = true;
                return _enableIrqFlag;
            }
        }
        private bool f_dseSequencePauseList;
        private int _dseSequencePauseList;
        public int DseSequencePauseList
        {
            get
            {
                if (f_dseSequencePauseList)
                    return _dseSequencePauseList;
                _dseSequencePauseList = (int) (6964);
                f_dseSequencePauseList = true;
                return _dseSequencePauseList;
            }
        }
        private bool f_strncmp;
        private int _strncmp;

        /// <summary>
        /// The strncmp(3) C library function.
        /// 
        /// r0: s1
        /// r1: s2
        /// r2: n
        /// return: comparison value
        /// </summary>
        public int Strncmp
        {
            get
            {
                if (f_strncmp)
                    return _strncmp;
                _strncmp = (int) (120936);
                f_strncmp = true;
                return _strncmp;
            }
        }
        private bool f_gxDisableBankForObjExtPltt;
        private int _gxDisableBankForObjExtPltt;
        public int GxDisableBankForObjExtPltt
        {
            get
            {
                if (f_gxDisableBankForObjExtPltt)
                    return _gxDisableBankForObjExtPltt;
                _gxDisableBankForObjExtPltt = (int) (45584);
                f_gxDisableBankForObjExtPltt = true;
                return _gxDisableBankForObjExtPltt;
            }
        }
        private bool f_soundEnvelopeReset;
        private int _soundEnvelopeReset;

        /// <summary>
        /// r0: Sound envelope pointer
        /// </summary>
        public int SoundEnvelopeReset
        {
            get
            {
                if (f_soundEnvelopeReset)
                    return _soundEnvelopeReset;
                _soundEnvelopeReset = (int) (35736);
                f_soundEnvelopeReset = true;
                return _soundEnvelopeReset;
            }
        }
        private bool f_soundLfoWaveInvalidFunc;
        private int _soundLfoWaveInvalidFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: 0
        /// </summary>
        public int SoundLfoWaveInvalidFunc
        {
            get
            {
                if (f_soundLfoWaveInvalidFunc)
                    return _soundLfoWaveInvalidFunc;
                _soundLfoWaveInvalidFunc = (int) (37588);
                f_soundLfoWaveInvalidFunc = true;
                return _soundLfoWaveInvalidFunc;
            }
        }
        private bool f_dseSwdLoadMainBank;
        private int _dseSwdLoadMainBank;
        public int DseSwdLoadMainBank
        {
            get
            {
                if (f_dseSwdLoadMainBank)
                    return _dseSwdLoadMainBank;
                _dseSwdLoadMainBank = (int) (3576);
                f_dseSwdLoadMainBank = true;
                return _dseSwdLoadMainBank;
            }
        }
        private bool f_wcstombs;
        private int _wcstombs;

        /// <summary>
        /// The wcstombs(3) C library function.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// return: characters converted
        /// </summary>
        public int Wcstombs
        {
            get
            {
                if (f_wcstombs)
                    return _wcstombs;
                _wcstombs = (int) (110924);
                f_wcstombs = true;
                return _wcstombs;
            }
        }
        private bool f_dseSeGetUsedBankIDs;
        private int _dseSeGetUsedBankIDs;
        public int DseSeGetUsedBankIDs
        {
            get
            {
                if (f_dseSeGetUsedBankIDs)
                    return _dseSeGetUsedBankIDs;
                _dseSeGetUsedBankIDs = (int) (11140);
                f_dseSeGetUsedBankIDs = true;
                return _dseSeGetUsedBankIDs;
            }
        }
        private bool f_dseDriverLoadDefaultSettings;
        private byte _dseDriverLoadDefaultSettings;
        public byte DseDriverLoadDefaultSettings
        {
            get
            {
                if (f_dseDriverLoadDefaultSettings)
                    return _dseDriverLoadDefaultSettings;
                _dseDriverLoadDefaultSettings = (byte) (232);
                f_dseDriverLoadDefaultSettings = true;
                return _dseDriverLoadDefaultSettings;
            }
        }
        private bool f_updateChannels;
        private int _updateChannels;

        /// <summary>
        /// From https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/ and Irdkwia's notes.
        /// 
        /// No params.
        /// </summary>
        public int UpdateChannels
        {
            get
            {
                if (f_updateChannels)
                    return _updateChannels;
                _updateChannels = (int) (33716);
                f_updateChannels = true;
                return _updateChannels;
            }
        }
        private bool f_fxGetDivResultFx64c;
        private int _fxGetDivResultFx64c;
        public int FxGetDivResultFx64c
        {
            get
            {
                if (f_fxGetDivResultFx64c)
                    return _fxGetDivResultFx64c;
                _fxGetDivResultFx64c = (int) (39536);
                f_fxGetDivResultFx64c = true;
                return _fxGetDivResultFx64c;
            }
        }
        private bool f_soundEnvelopeStop2;
        private int _soundEnvelopeStop2;

        /// <summary>
        /// r0: Sound envelope pointer
        /// </summary>
        public int SoundEnvelopeStop2
        {
            get
            {
                if (f_soundEnvelopeStop2)
                    return _soundEnvelopeStop2;
                _soundEnvelopeStop2 = (int) (36452);
                f_soundEnvelopeStop2 = true;
                return _soundEnvelopeStop2;
            }
        }
        private bool f_gxLoadObjPltt;
        private int _gxLoadObjPltt;
        public int GxLoadObjPltt
        {
            get
            {
                if (f_gxLoadObjPltt)
                    return _gxLoadObjPltt;
                _gxLoadObjPltt = (int) (48332);
                f_gxLoadObjPltt = true;
                return _gxLoadObjPltt;
            }
        }
        private bool f_findSmdlSongChunk;
        private int _findSmdlSongChunk;

        /// <summary>
        /// Finds the first song chunk within an SMDL file that has the specified value on its 0x10 field.
        /// 
        /// See https://projectpokemon.org/home/docs/mystery-dungeon-nds/dse-smdl-format-r13/.
        /// 
        /// r0: Pointer to the start of the SMDL file
        /// r1: Value to search for
        /// return: Pointer to the first chunk that has the specified value + 0x10, or null if no chunk was found.
        /// </summary>
        public int FindSmdlSongChunk
        {
            get
            {
                if (f_findSmdlSongChunk)
                    return _findSmdlSongChunk;
                _findSmdlSongChunk = (int) (9232);
                f_findSmdlSongChunk = true;
                return _findSmdlSongChunk;
            }
        }
        private bool f_getTimer0Control;
        private int _getTimer0Control;

        /// <summary>
        /// Returns the value of the control register for hardware timer 0
        /// 
        /// return: Value of the control register
        /// </summary>
        public int GetTimer0Control
        {
            get
            {
                if (f_getTimer0Control)
                    return _getTimer0Control;
                _getTimer0Control = (int) (60940);
                f_getTimer0Control = true;
                return _getTimer0Control;
            }
        }
        private bool f_dseSequenceLoadSong;
        private int _dseSequenceLoadSong;
        public int DseSequenceLoadSong
        {
            get
            {
                if (f_dseSequenceLoadSong)
                    return _dseSequenceLoadSong;
                _dseSequenceLoadSong = (int) (9340);
                f_dseSequenceLoadSong = true;
                return _dseSequenceLoadSong;
            }
        }
        private bool f_disableBankForX;
        private int _disableBankForX;
        public int DisableBankForX
        {
            get
            {
                if (f_disableBankForX)
                    return _disableBankForX;
                _disableBankForX = (int) (45284);
                f_disableBankForX = true;
                return _disableBankForX;
            }
        }
        private bool f_vsprintf;
        private int _vsprintf;

        /// <summary>
        /// The vsprintf(3) C library function.
        /// 
        /// r0: str
        /// r1: format
        /// r2: ap
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int Vsprintf
        {
            get
            {
                if (f_vsprintf)
                    return _vsprintf;
                _vsprintf = (int) (119916);
                f_vsprintf = true;
                return _vsprintf;
            }
        }
        private bool f_memsetInternal;
        private int _memsetInternal;

        /// <summary>
        /// The actual memory-setting implementation for the memset(3) C library function.
        /// 
        /// This function is optimized to set bytes in 4-byte chunks for n &gt;= 32, correctly handling any unaligned bytes at the front/back. In this case, it also further optimizes by unrolling a for loop to set 8 4-byte values at once (effectively a 32-byte chunk).
        /// 
        /// r0: s
        /// r1: c (int, but must be a single-byte value)
        /// r2: n
        /// </summary>
        public int MemsetInternal
        {
            get
            {
                if (f_memsetInternal)
                    return _memsetInternal;
                _memsetInternal = (int) (111280);
                f_memsetInternal = true;
                return _memsetInternal;
            }
        }
        private bool f_soundEnvelopeParametersReset;
        private int _soundEnvelopeParametersReset;

        /// <summary>
        /// r0: Sound envelope parameters pointer
        /// </summary>
        public int SoundEnvelopeParametersReset
        {
            get
            {
                if (f_soundEnvelopeParametersReset)
                    return _soundEnvelopeParametersReset;
                _soundEnvelopeParametersReset = (int) (35756);
                f_soundEnvelopeParametersReset = true;
                return _soundEnvelopeParametersReset;
            }
        }
        private bool f_dseSwdGetNextSplitInRange;
        private int _dseSwdGetNextSplitInRange;
        public int DseSwdGetNextSplitInRange
        {
            get
            {
                if (f_dseSwdGetNextSplitInRange)
                    return _dseSwdGetNextSplitInRange;
                _dseSwdGetNextSplitInRange = (int) (5360);
                f_dseSwdGetNextSplitInRange = true;
                return _dseSwdGetNextSplitInRange;
            }
        }
        private bool f_fmul;
        private int _fmul;

        /// <summary>
        /// Implements the multiplication operator for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __mulsf3 in libgcc.
        /// 
        /// r0: a
        /// r1: b
        /// return: a * b
        /// </summary>
        public int Fmul
        {
            get
            {
                if (f_fmul)
                    return _fmul;
                _fmul = (int) (144988);
                f_fmul = true;
                return _fmul;
            }
        }
        private bool f_resumeBgm;
        private int _resumeBgm;

        /// <summary>
        /// Uncertain.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ResumeBgm
        {
            get
            {
                if (f_resumeBgm)
                    return _resumeBgm;
                _resumeBgm = (int) (6372);
                f_resumeBgm = true;
                return _resumeBgm;
            }
        }
        private bool f_dseSwdGetBankById;
        private int _dseSwdGetBankById;
        public int DseSwdGetBankById
        {
            get
            {
                if (f_dseSwdGetBankById)
                    return _dseSwdGetBankById;
                _dseSwdGetBankById = (int) (5576);
                f_dseSwdGetBankById = true;
                return _dseSwdGetBankById;
            }
        }
        private bool f_g2GetBg0CharPtr;
        private int _g2GetBg0CharPtr;
        public int G2GetBg0CharPtr
        {
            get
            {
                if (f_g2GetBg0CharPtr)
                    return _g2GetBg0CharPtr;
                _g2GetBg0CharPtr = (int) (46272);
                f_g2GetBg0CharPtr = true;
                return _g2GetBg0CharPtr;
            }
        }
        private bool f_dleq;
        private int _dleq;

        /// <summary>
        /// Implements the &lt;= operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a &lt;= b
        /// </summary>
        public int Dleq
        {
            get
            {
                if (f_dleq)
                    return _dleq;
                _dleq = (int) (143004);
                f_dleq = true;
                return _dleq;
            }
        }
        private bool f_dseTrackEventSignal;
        private int _dseTrackEventSignal;
        public int DseTrackEventSignal
        {
            get
            {
                if (f_dseTrackEventSignal)
                    return _dseTrackEventSignal;
                _dseTrackEventSignal = (int) (26772);
                f_dseTrackEventSignal = true;
                return _dseTrackEventSignal;
            }
        }
        private bool f_g2GetBg1CharPtr;
        private int _g2GetBg1CharPtr;
        public int G2GetBg1CharPtr
        {
            get
            {
                if (f_g2GetBg1CharPtr)
                    return _g2GetBg1CharPtr;
                _g2GetBg1CharPtr = (int) (46356);
                f_g2GetBg1CharPtr = true;
                return _g2GetBg1CharPtr;
            }
        }
        private bool f_updateTrackVolumeEnvelopes;
        private int _updateTrackVolumeEnvelopes;

        /// <summary>
        /// From https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/
        /// 
        /// r0: Sound envelope pointer
        /// </summary>
        public int UpdateTrackVolumeEnvelopes
        {
            get
            {
                if (f_updateTrackVolumeEnvelopes)
                    return _updateTrackVolumeEnvelopes;
                _updateTrackVolumeEnvelopes = (int) (36148);
                f_updateTrackVolumeEnvelopes = true;
                return _updateTrackVolumeEnvelopes;
            }
        }
        private bool f_gXiNopClearFifo128;
        private int _gXiNopClearFifo128;
        public int GXiNopClearFifo128
        {
            get
            {
                if (f_gXiNopClearFifo128)
                    return _gXiNopClearFifo128;
                _gXiNopClearFifo128 = (int) (47836);
                f_gXiNopClearFifo128 = true;
                return _gXiNopClearFifo128;
            }
        }
        private bool f_gxLoadBg3Char;
        private int _gxLoadBg3Char;
        public int GxLoadBg3Char
        {
            get
            {
                if (f_gxLoadBg3Char)
                    return _gxLoadBg3Char;
                _gxLoadBg3Char = (int) (49816);
                f_gxLoadBg3Char = true;
                return _gxLoadBg3Char;
            }
        }
        private bool f_dseSequenceUnload;
        private int _dseSequenceUnload;
        public int DseSequenceUnload
        {
            get
            {
                if (f_dseSequenceUnload)
                    return _dseSequenceUnload;
                _dseSequenceUnload = (int) (9984);
                f_dseSequenceUnload = true;
                return _dseSequenceUnload;
            }
        }
        private bool f_dseVoiceDeallocate;
        private int _dseVoiceDeallocate;
        public int DseVoiceDeallocate
        {
            get
            {
                if (f_dseVoiceDeallocate)
                    return _dseVoiceDeallocate;
                _dseVoiceDeallocate = (int) (34760);
                f_dseVoiceDeallocate = true;
                return _dseVoiceDeallocate;
            }
        }
        private bool f_soundLfoWaveSawFunc;
        private int _soundLfoWaveSawFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveSawFunc
        {
            get
            {
                if (f_soundLfoWaveSawFunc)
                    return _soundLfoWaveSawFunc;
                _soundLfoWaveSawFunc = (int) (37924);
                f_soundLfoWaveSawFunc = true;
                return _soundLfoWaveSawFunc;
            }
        }
        private bool f_g3XGetMtxStackLevelPv;
        private int _g3XGetMtxStackLevelPv;
        public int G3XGetMtxStackLevelPv
        {
            get
            {
                if (f_g3XGetMtxStackLevelPv)
                    return _g3XGetMtxStackLevelPv;
                _g3XGetMtxStackLevelPv = (int) (47740);
                f_g3XGetMtxStackLevelPv = true;
                return _g3XGetMtxStackLevelPv;
            }
        }
        private bool f_soundEnvelopeSetParameters;
        private int _soundEnvelopeSetParameters;

        /// <summary>
        /// r0: Sound envelope pointer
        /// r1: Sound envelope parameters pointer
        /// </summary>
        public int SoundEnvelopeSetParameters
        {
            get
            {
                if (f_soundEnvelopeSetParameters)
                    return _soundEnvelopeSetParameters;
                _soundEnvelopeSetParameters = (int) (35868);
                f_soundEnvelopeSetParameters = true;
                return _soundEnvelopeSetParameters;
            }
        }
        private bool f_dseTrackEventUsePanLfo;
        private int _dseTrackEventUsePanLfo;
        public int DseTrackEventUsePanLfo
        {
            get
            {
                if (f_dseTrackEventUsePanLfo)
                    return _dseTrackEventUsePanLfo;
                _dseTrackEventUsePanLfo = (int) (26224);
                f_dseTrackEventUsePanLfo = true;
                return _dseTrackEventUsePanLfo;
            }
        }
        private bool f_dseTrackEventSetUnknown2;
        private int _dseTrackEventSetUnknown2;
        public int DseTrackEventSetUnknown2
        {
            get
            {
                if (f_dseTrackEventSetUnknown2)
                    return _dseTrackEventSetUnknown2;
                _dseTrackEventSetUnknown2 = (int) (24792);
                f_dseTrackEventSetUnknown2 = true;
                return _dseTrackEventSetUnknown2;
            }
        }
        private bool f_dseSeGetBestSeqAllocation;
        private int _dseSeGetBestSeqAllocation;
        public int DseSeGetBestSeqAllocation
        {
            get
            {
                if (f_dseSeGetBestSeqAllocation)
                    return _dseSeGetBestSeqAllocation;
                _dseSeGetBestSeqAllocation = (int) (12780);
                f_dseSeGetBestSeqAllocation = true;
                return _dseSeGetBestSeqAllocation;
            }
        }
        private bool f_updateSequencerTracks;
        private int _updateSequencerTracks;

        /// <summary>
        /// From https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/
        /// </summary>
        public int UpdateSequencerTracks
        {
            get
            {
                if (f_updateSequencerTracks)
                    return _updateSequencerTracks;
                _updateSequencerTracks = (int) (21264);
                f_updateSequencerTracks = true;
                return _updateSequencerTracks;
            }
        }
        private bool f_g2xSetBlendAlpha;
        private int _g2xSetBlendAlpha;
        public int G2xSetBlendAlpha
        {
            get
            {
                if (f_g2xSetBlendAlpha)
                    return _g2xSetBlendAlpha;
                _g2xSetBlendAlpha = (int) (46608);
                f_g2xSetBlendAlpha = true;
                return _g2xSetBlendAlpha;
            }
        }
        private bool f_soundLfoBankTick;
        private int _soundLfoBankTick;

        /// <summary>
        /// r0: LFO bank pointer
        /// return: New voice update flags
        /// </summary>
        public int SoundLfoBankTick
        {
            get
            {
                if (f_soundLfoBankTick)
                    return _soundLfoBankTick;
                _soundLfoBankTick = (int) (37408);
                f_soundLfoBankTick = true;
                return _soundLfoBankTick;
            }
        }
        private bool f_dseSequenceTickFades;
        private int _dseSequenceTickFades;
        public int DseSequenceTickFades
        {
            get
            {
                if (f_dseSequenceTickFades)
                    return _dseSequenceTickFades;
                _dseSequenceTickFades = (int) (22188);
                f_dseSequenceTickFades = true;
                return _dseSequenceTickFades;
            }
        }
        private bool f_dseTrackEventUseLfo;
        private int _dseTrackEventUseLfo;
        public int DseTrackEventUseLfo
        {
            get
            {
                if (f_dseTrackEventUseLfo)
                    return _dseTrackEventUseLfo;
                _dseTrackEventUseLfo = (int) (26720);
                f_dseTrackEventUseLfo = true;
                return _dseTrackEventUseLfo;
            }
        }
        private bool f_dseChannelAllocateNote;
        private int _dseChannelAllocateNote;
        public int DseChannelAllocateNote
        {
            get
            {
                if (f_dseChannelAllocateNote)
                    return _dseChannelAllocateNote;
                _dseChannelAllocateNote = (int) (31744);
                f_dseChannelAllocateNote = true;
                return _dseChannelAllocateNote;
            }
        }
        private bool f_fpInit;
        private int _fpInit;

        /// <summary>
        /// Meant to do set up for floating point calculations? Does nothing.
        /// 
        /// No params.
        /// </summary>
        public int FpInit
        {
            get
            {
                if (f_fpInit)
                    return _fpInit;
                _fpInit = (int) (149272);
                f_fpInit = true;
                return _fpInit;
            }
        }
        private bool f_gxDisableBankForBg;
        private int _gxDisableBankForBg;
        public int GxDisableBankForBg
        {
            get
            {
                if (f_gxDisableBankForBg)
                    return _gxDisableBankForBg;
                _gxDisableBankForBg = (int) (45508);
                f_gxDisableBankForBg = true;
                return _gxDisableBankForBg;
            }
        }
        private bool f_gxsSetGraphicsMode;
        private int _gxsSetGraphicsMode;
        public int GxsSetGraphicsMode
        {
            get
            {
                if (f_gxsSetGraphicsMode)
                    return _gxsSetGraphicsMode;
                _gxsSetGraphicsMode = (int) (41520);
                f_gxsSetGraphicsMode = true;
                return _gxsSetGraphicsMode;
            }
        }
        private bool f_dseTrackEventWaitSame;
        private int _dseTrackEventWaitSame;
        public int DseTrackEventWaitSame
        {
            get
            {
                if (f_dseTrackEventWaitSame)
                    return _dseTrackEventWaitSame;
                _dseTrackEventWaitSame = (int) (22608);
                f_dseTrackEventWaitSame = true;
                return _dseTrackEventWaitSame;
            }
        }
        private bool f_dseSequenceTickNotes;
        private int _dseSequenceTickNotes;
        public int DseSequenceTickNotes
        {
            get
            {
                if (f_dseSequenceTickNotes)
                    return _dseSequenceTickNotes;
                _dseSequenceTickNotes = (int) (20616);
                f_dseSequenceTickNotes = true;
                return _dseSequenceTickNotes;
            }
        }
        private bool f_vsprintfInternalSlice;
        private int _vsprintfInternalSlice;

        /// <summary>
        /// This is what implements the bulk of __vsprintf_internal.
        /// 
        /// The __vsprintf_internal in the modern-day version of glibc relies on __vfprintf_internal; this function has a slightly different interface, but it serves a similar role.
        /// 
        /// r0: function pointer to append to the string being built (__vsprintf_internal uses TryAppendToSlice)
        /// r1: string buffer slice
        /// r2: format
        /// r3: ap
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int VsprintfInternalSlice
        {
            get
            {
                if (f_vsprintfInternalSlice)
                    return _vsprintfInternalSlice;
                _vsprintfInternalSlice = (int) (117660);
                f_vsprintfInternalSlice = true;
                return _vsprintfInternalSlice;
            }
        }
        private bool f_dseChannelSetKeyBend;
        private int _dseChannelSetKeyBend;
        public int DseChannelSetKeyBend
        {
            get
            {
                if (f_dseChannelSetKeyBend)
                    return _dseChannelSetKeyBend;
                _dseChannelSetKeyBend = (int) (31672);
                f_dseChannelSetKeyBend = true;
                return _dseChannelSetKeyBend;
            }
        }
        private bool f_dseMemQuit;
        private int _dseMemQuit;
        public int DseMemQuit
        {
            get
            {
                if (f_dseMemQuit)
                    return _dseMemQuit;
                _dseMemQuit = (int) (2228);
                f_dseMemQuit = true;
                return _dseMemQuit;
            }
        }
        private bool f_dls;
        private int _dls;

        /// <summary>
        /// Implements the &lt; operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a &lt; b
        /// </summary>
        public int Dls
        {
            get
            {
                if (f_dls)
                    return _dls;
                _dls = (int) (143168);
                f_dls = true;
                return _dls;
            }
        }
        private bool f_g2SGetBg1ScrPtr;
        private int _g2SGetBg1ScrPtr;
        public int G2SGetBg1ScrPtr
        {
            get
            {
                if (f_g2SGetBg1ScrPtr)
                    return _g2SGetBg1ScrPtr;
                _g2SGetBg1ScrPtr = (int) (45976);
                f_g2SGetBg1ScrPtr = true;
                return _g2SGetBg1ScrPtr;
            }
        }
        private bool f_vecCrossProduct;
        private int _vecCrossProduct;
        public int VecCrossProduct
        {
            get
            {
                if (f_vecCrossProduct)
                    return _vecCrossProduct;
                _vecCrossProduct = (int) (39896);
                f_vecCrossProduct = true;
                return _vecCrossProduct;
            }
        }
        private bool f_fflt;
        private int _fflt;

        /// <summary>
        /// Implements the int to float cast operation for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __floatsisf in libgcc.
        /// 
        /// r0: int
        /// return: (float)int
        /// </summary>
        public int Fflt
        {
            get
            {
                if (f_fflt)
                    return _fflt;
                _fflt = (int) (144844);
                f_fflt = true;
                return _fflt;
            }
        }
        private bool f_soundLfoWaveFullSquareFunc;
        private int _soundLfoWaveFullSquareFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveFullSquareFunc
        {
            get
            {
                if (f_soundLfoWaveFullSquareFunc)
                    return _soundLfoWaveFullSquareFunc;
                _soundLfoWaveFullSquareFunc = (int) (37668);
                f_soundLfoWaveFullSquareFunc = true;
                return _soundLfoWaveFullSquareFunc;
            }
        }
        private bool f_gxSetBankForBgExtPltt;
        private int _gxSetBankForBgExtPltt;
        public int GxSetBankForBgExtPltt
        {
            get
            {
                if (f_gxSetBankForBgExtPltt)
                    return _gxSetBankForBgExtPltt;
                _gxSetBankForBgExtPltt = (int) (42860);
                f_gxSetBankForBgExtPltt = true;
                return _gxSetBankForBgExtPltt;
            }
        }
        private bool f_dseTrackEventDummy2Bytes;
        private int _dseTrackEventDummy2Bytes;
        public int DseTrackEventDummy2Bytes
        {
            get
            {
                if (f_dseTrackEventDummy2Bytes)
                    return _dseTrackEventDummy2Bytes;
                _dseTrackEventDummy2Bytes = (int) (23892);
                f_dseTrackEventDummy2Bytes = true;
                return _dseTrackEventDummy2Bytes;
            }
        }
        private bool f_g2GetBg2ScrPtr;
        private int _g2GetBg2ScrPtr;
        public int G2GetBg2ScrPtr
        {
            get
            {
                if (f_g2GetBg2ScrPtr)
                    return _g2GetBg2ScrPtr;
                _g2GetBg2ScrPtr = (int) (46008);
                f_g2GetBg2ScrPtr = true;
                return _g2GetBg2ScrPtr;
            }
        }
        private bool f_fxDiv;
        private int _fxDiv;
        public int FxDiv
        {
            get
            {
                if (f_fxDiv)
                    return _fxDiv;
                _fxDiv = (int) (39520);
                f_fxDiv = true;
                return _fxDiv;
            }
        }
        private bool f_soundLfoWaveHalfTriangleFunc;
        private int _soundLfoWaveHalfTriangleFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveHalfTriangleFunc
        {
            get
            {
                if (f_soundLfoWaveHalfTriangleFunc)
                    return _soundLfoWaveHalfTriangleFunc;
                _soundLfoWaveHalfTriangleFunc = (int) (37740);
                f_soundLfoWaveHalfTriangleFunc = true;
                return _soundLfoWaveHalfTriangleFunc;
            }
        }
        private bool f_g2GetBg2CharPtr;
        private int _g2GetBg2CharPtr;
        public int G2GetBg2CharPtr
        {
            get
            {
                if (f_g2GetBg2CharPtr)
                    return _g2GetBg2CharPtr;
                _g2GetBg2CharPtr = (int) (46440);
                f_g2GetBg2CharPtr = true;
                return _g2GetBg2CharPtr;
            }
        }
        private bool f_gxSetBankForArm7;
        private int _gxSetBankForArm7;
        public int GxSetBankForArm7
        {
            get
            {
                if (f_gxSetBankForArm7)
                    return _gxSetBankForArm7;
                _gxSetBankForArm7 = (int) (44300);
                f_gxSetBankForArm7 = true;
                return _gxSetBankForArm7;
            }
        }
        private bool f_gxLoadBg2Char;
        private int _gxLoadBg2Char;
        public int GxLoadBg2Char
        {
            get
            {
                if (f_gxLoadBg2Char)
                    return _gxLoadBg2Char;
                _gxLoadBg2Char = (int) (49720);
                f_gxLoadBg2Char = true;
                return _gxLoadBg2Char;
            }
        }
        private bool f_dseTrackEventSetOptionalVolume;
        private int _dseTrackEventSetOptionalVolume;
        public int DseTrackEventSetOptionalVolume
        {
            get
            {
                if (f_dseTrackEventSetOptionalVolume)
                    return _dseTrackEventSetOptionalVolume;
                _dseTrackEventSetOptionalVolume = (int) (23880);
                f_dseTrackEventSetOptionalVolume = true;
                return _dseTrackEventSetOptionalVolume;
            }
        }
        private bool f_getProcessorMode;
        private int _getProcessorMode;

        /// <summary>
        /// Gets the processor's current operating mode.
        /// 
        /// See https://problemkaputt.de/gbatek.htm#armcpuflagsconditionfieldcond
        /// 
        /// return: cpsr &amp; 0x1f (the cpsr mode bits M4-M0)
        /// </summary>
        public int GetProcessorMode
        {
            get
            {
                if (f_getProcessorMode)
                    return _getProcessorMode;
                _getProcessorMode = (int) (63344);
                f_getProcessorMode = true;
                return _getProcessorMode;
            }
        }
        private bool f_dseSynthSetVolume;
        private int _dseSynthSetVolume;
        public int DseSynthSetVolume
        {
            get
            {
                if (f_dseSynthSetVolume)
                    return _dseSynthSetVolume;
                _dseSynthSetVolume = (int) (30224);
                f_dseSynthSetVolume = true;
                return _dseSynthSetVolume;
            }
        }
        private bool f_d2f;
        private int _d2f;

        /// <summary>
        /// Implements the double to float cast operator for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __truncdfsf2 in libgcc.
        /// 
        /// r0: double (low bits)
        /// r1: double (high bits)
        /// return: (float)double
        /// </summary>
        public int D2f
        {
            get
            {
                if (f_d2f)
                    return _d2f;
                _d2f = (int) (139528);
                f_d2f = true;
                return _d2f;
            }
        }
        private bool f_dseSynthStopChannels;
        private int _dseSynthStopChannels;
        public int DseSynthStopChannels
        {
            get
            {
                if (f_dseSynthStopChannels)
                    return _dseSynthStopChannels;
                _dseSynthStopChannels = (int) (29608);
                f_dseSynthStopChannels = true;
                return _dseSynthStopChannels;
            }
        }
        private bool f_dseSwdSysQuit;
        private int _dseSwdSysQuit;
        public int DseSwdSysQuit
        {
            get
            {
                if (f_dseSwdSysQuit)
                    return _dseSwdSysQuit;
                _dseSwdSysQuit = (int) (3408);
                f_dseSwdSysQuit = true;
                return _dseSwdSysQuit;
            }
        }
        private bool f_gxInit;
        private int _gxInit;
        public int GxInit
        {
            get
            {
                if (f_gxInit)
                    return _gxInit;
                _gxInit = (int) (40860);
                f_gxInit = true;
                return _gxInit;
            }
        }
        private bool f_dseVoiceReleaseHeld;
        private int _dseVoiceReleaseHeld;
        public int DseVoiceReleaseHeld
        {
            get
            {
                if (f_dseVoiceReleaseHeld)
                    return _dseVoiceReleaseHeld;
                _dseVoiceReleaseHeld = (int) (34564);
                f_dseVoiceReleaseHeld = true;
                return _dseVoiceReleaseHeld;
            }
        }
        private bool f_dseVoiceAllocate;
        private int _dseVoiceAllocate;
        public int DseVoiceAllocate
        {
            get
            {
                if (f_dseVoiceAllocate)
                    return _dseVoiceAllocate;
                _dseVoiceAllocate = (int) (34112);
                f_dseVoiceAllocate = true;
                return _dseVoiceAllocate;
            }
        }
        private bool f_gxsLoadBg0Char;
        private int _gxsLoadBg0Char;
        public int GxsLoadBg0Char
        {
            get
            {
                if (f_gxsLoadBg0Char)
                    return _gxsLoadBg0Char;
                _gxsLoadBg0Char = (int) (49432);
                f_gxsLoadBg0Char = true;
                return _gxsLoadBg0Char;
            }
        }
        private bool f_dseVoiceCleanup;
        private int _dseVoiceCleanup;
        public int DseVoiceCleanup
        {
            get
            {
                if (f_dseVoiceCleanup)
                    return _dseVoiceCleanup;
                _dseVoiceCleanup = (int) (33956);
                f_dseVoiceCleanup = true;
                return _dseVoiceCleanup;
            }
        }
        private bool f_soundUtilGetRandomNumber;
        private int _soundUtilGetRandomNumber;

        /// <summary>
        /// return: random number in the range [0, 32767]
        /// </summary>
        public int SoundUtilGetRandomNumber
        {
            get
            {
                if (f_soundUtilGetRandomNumber)
                    return _soundUtilGetRandomNumber;
                _soundUtilGetRandomNumber = (int) (2076);
                f_soundUtilGetRandomNumber = true;
                return _soundUtilGetRandomNumber;
            }
        }
        private bool f_g2GetBg3CharPtr;
        private int _g2GetBg3CharPtr;
        public int G2GetBg3CharPtr
        {
            get
            {
                if (f_g2GetBg3CharPtr)
                    return _g2GetBg3CharPtr;
                _g2GetBg3CharPtr = (int) (46520);
                f_g2GetBg3CharPtr = true;
                return _g2GetBg3CharPtr;
            }
        }
        private bool f_gxSetBankForLcdc;
        private int _gxSetBankForLcdc;
        public int GxSetBankForLcdc
        {
            get
            {
                if (f_gxSetBankForLcdc)
                    return _gxSetBankForLcdc;
                _gxSetBankForLcdc = (int) (44472);
                f_gxSetBankForLcdc = true;
                return _gxSetBankForLcdc;
            }
        }
        private bool f_dseSeGetById;
        private int _dseSeGetById;
        public int DseSeGetById
        {
            get
            {
                if (f_dseSeGetById)
                    return _dseSeGetById;
                _dseSeGetById = (int) (12904);
                f_dseSeGetById = true;
                return _dseSeGetById;
            }
        }
        private bool f_dseSynthAllocateNew;
        private int _dseSynthAllocateNew;
        public int DseSynthAllocateNew
        {
            get
            {
                if (f_dseSynthAllocateNew)
                    return _dseSynthAllocateNew;
                _dseSynthAllocateNew = (int) (29096);
                f_dseSynthAllocateNew = true;
                return _dseSynthAllocateNew;
            }
        }
        private bool f_dseTrackEventSetKeyBend;
        private int _dseTrackEventSetKeyBend;
        public int DseTrackEventSetKeyBend
        {
            get
            {
                if (f_dseTrackEventSetKeyBend)
                    return _dseTrackEventSetKeyBend;
                _dseTrackEventSetKeyBend = (int) (24748);
                f_dseTrackEventSetKeyBend = true;
                return _dseTrackEventSetKeyBend;
            }
        }
        private bool f_dseBgmSetSignalCallback;
        private int _dseBgmSetSignalCallback;
        public int DseBgmSetSignalCallback
        {
            get
            {
                if (f_dseBgmSetSignalCallback)
                    return _dseBgmSetSignalCallback;
                _dseBgmSetSignalCallback = (int) (6252);
                f_dseBgmSetSignalCallback = true;
                return _dseBgmSetSignalCallback;
            }
        }
        private bool f_soundEnvelopeForceVolume;
        private int _soundEnvelopeForceVolume;

        /// <summary>
        /// r0: Sound envelope pointer
        /// r1: Volume
        /// </summary>
        public int SoundEnvelopeForceVolume
        {
            get
            {
                if (f_soundEnvelopeForceVolume)
                    return _soundEnvelopeForceVolume;
                _soundEnvelopeForceVolume = (int) (36420);
                f_soundEnvelopeForceVolume = true;
                return _soundEnvelopeForceVolume;
            }
        }
        private bool f_waitForInterrupt;
        private int _waitForInterrupt;

        /// <summary>
        /// Presumably blocks until the program receives an interrupt.
        /// 
        /// This just calls (in Ghidra terminology) coproc_moveto_Wait_for_interrupt(0). See https://en.wikipedia.org/wiki/ARM_architecture_family#Coprocessors.
        /// 
        /// No params.
        /// </summary>
        public int WaitForInterrupt
        {
            get
            {
                if (f_waitForInterrupt)
                    return _waitForInterrupt;
                _waitForInterrupt = (int) (64344);
                f_waitForInterrupt = true;
                return _waitForInterrupt;
            }
        }
        private bool f_dseTrackEventMainLoopBegin;
        private int _dseTrackEventMainLoopBegin;
        public int DseTrackEventMainLoopBegin
        {
            get
            {
                if (f_dseTrackEventMainLoopBegin)
                    return _dseTrackEventMainLoopBegin;
                _dseTrackEventMainLoopBegin = (int) (22844);
                f_dseTrackEventMainLoopBegin = true;
                return _dseTrackEventMainLoopBegin;
            }
        }
        private bool f_dseBgmSysSetupNoteList;
        private int _dseBgmSysSetupNoteList;
        public int DseBgmSysSetupNoteList
        {
            get
            {
                if (f_dseBgmSysSetupNoteList)
                    return _dseBgmSysSetupNoteList;
                _dseBgmSysSetupNoteList = (int) (10196);
                f_dseBgmSysSetupNoteList = true;
                return _dseBgmSysSetupNoteList;
            }
        }
        private bool f_dseChannelSetLfoConstEnvelopeLevel;
        private int _dseChannelSetLfoConstEnvelopeLevel;
        public int DseChannelSetLfoConstEnvelopeLevel
        {
            get
            {
                if (f_dseChannelSetLfoConstEnvelopeLevel)
                    return _dseChannelSetLfoConstEnvelopeLevel;
                _dseChannelSetLfoConstEnvelopeLevel = (int) (31620);
                f_dseChannelSetLfoConstEnvelopeLevel = true;
                return _dseChannelSetLfoConstEnvelopeLevel;
            }
        }
        private bool f_wcslen;
        private int _wcslen;

        /// <summary>
        /// The wcslen(3) C library function.
        /// 
        /// r0: ws
        /// return: length of ws
        /// </summary>
        public int Wcslen
        {
            get
            {
                if (f_wcslen)
                    return _wcslen;
                _wcslen = (int) (127760);
                f_wcslen = true;
                return _wcslen;
            }
        }
        private bool f_dseSeLoad;
        private int _dseSeLoad;
        public int DseSeLoad
        {
            get
            {
                if (f_dseSeLoad)
                    return _dseSeLoad;
                _dseSeLoad = (int) (10560);
                f_dseSeLoad = true;
                return _dseSeLoad;
            }
        }
        private bool f_dseChannelReleaseNoteInternal;
        private int _dseChannelReleaseNoteInternal;
        public int DseChannelReleaseNoteInternal
        {
            get
            {
                if (f_dseChannelReleaseNoteInternal)
                    return _dseChannelReleaseNoteInternal;
                _dseChannelReleaseNoteInternal = (int) (31888);
                f_dseChannelReleaseNoteInternal = true;
                return _dseChannelReleaseNoteInternal;
            }
        }
        private bool f_g3LoadMtx44;
        private int _g3LoadMtx44;
        public int G3LoadMtx44
        {
            get
            {
                if (f_g3LoadMtx44)
                    return _g3LoadMtx44;
                _g3LoadMtx44 = (int) (46744);
                f_g3LoadMtx44 = true;
                return _g3LoadMtx44;
            }
        }
        private bool f_dseBgmStop;
        private int _dseBgmStop;
        public int DseBgmStop
        {
            get
            {
                if (f_dseBgmStop)
                    return _dseBgmStop;
                _dseBgmStop = (int) (6596);
                f_dseBgmStop = true;
                return _dseBgmStop;
            }
        }
        private bool f_g3MultMtx43;
        private int _g3MultMtx43;

        /// <summary>
        /// Send the MTX_MULT_4x3 geometry engine command, through a GXFIFO command. See https://problemkaputt.de/gbatek.htm#ds3dgeometrycommands and https://problemkaputt.de/gbatek.htm#ds3dmatrixloadmultiply for more information.
        /// 
        /// This pops the top of the current matrix stack (https://problemkaputt.de/gbatek.htm#ds3dmatrixstack) and left-multiplies the engine's &quot;current&quot; matrix by the new matrix. It's commonly preceded by a MTX_PUSH command to populate the matrix stack with a matrix.
        /// 
        /// r0: matrix_4x3 pointer
        /// </summary>
        public int G3MultMtx43
        {
            get
            {
                if (f_g3MultMtx43)
                    return _g3MultMtx43;
                _g3MultMtx43 = (int) (46800);
                f_g3MultMtx43 = true;
                return _g3MultMtx43;
            }
        }
        private bool f_gxLoadTexPltt;
        private int _gxLoadTexPltt;
        public int GxLoadTexPltt
        {
            get
            {
                if (f_gxLoadTexPltt)
                    return _gxLoadTexPltt;
                _gxLoadTexPltt = (int) (51000);
                f_gxLoadTexPltt = true;
                return _gxLoadTexPltt;
            }
        }
        private bool f_gxSetBankForClearImage;
        private int _gxSetBankForClearImage;
        public int GxSetBankForClearImage
        {
            get
            {
                if (f_gxSetBankForClearImage)
                    return _gxSetBankForClearImage;
                _gxSetBankForClearImage = (int) (43992);
                f_gxSetBankForClearImage = true;
                return _gxSetBankForClearImage;
            }
        }
        private bool f_dseSwdReadMainBank;
        private int _dseSwdReadMainBank;
        public int DseSwdReadMainBank
        {
            get
            {
                if (f_dseSwdReadMainBank)
                    return _dseSwdReadMainBank;
                _dseSwdReadMainBank = (int) (5732);
                f_dseSwdReadMainBank = true;
                return _dseSwdReadMainBank;
            }
        }
        private bool f_arrayFill32;
        private int _arrayFill32;

        /// <summary>
        /// Fills an array of 32-bit values with a given value.
        /// 
        /// This is essentially an alternate implementation of Memset32, but with a different parameter order.
        /// 
        /// r0: value
        /// r1: ptr
        /// r2: len (# bytes)
        /// </summary>
        public int ArrayFill32
        {
            get
            {
                if (f_arrayFill32)
                    return _arrayFill32;
                _arrayFill32 = (int) (66108);
                f_arrayFill32 = true;
                return _arrayFill32;
            }
        }
        private bool f_dseTrackEventDummy2Bytes2;
        private int _dseTrackEventDummy2Bytes2;
        public int DseTrackEventDummy2Bytes2
        {
            get
            {
                if (f_dseTrackEventDummy2Bytes2)
                    return _dseTrackEventDummy2Bytes2;
                _dseTrackEventDummy2Bytes2 = (int) (26820);
                f_dseTrackEventDummy2Bytes2 = true;
                return _dseTrackEventDummy2Bytes2;
            }
        }
        private bool f_dseSetError;
        private int _dseSetError;
        public int DseSetError
        {
            get
            {
                if (f_dseSetError)
                    return _dseSetError;
                _dseSetError = (int) (1916);
                f_dseSetError = true;
                return _dseSetError;
            }
        }
        private bool f_g3iOrthoW;
        private int _g3iOrthoW;
        public int G3iOrthoW
        {
            get
            {
                if (f_g3iOrthoW)
                    return _g3iOrthoW;
                _g3iOrthoW = (int) (47984);
                f_g3iOrthoW = true;
                return _g3iOrthoW;
            }
        }
        private bool f_memchr;
        private int _memchr;

        /// <summary>
        /// The memchr(3) C library function.
        /// 
        /// r0: s
        /// r1: c
        /// r2: n
        /// return: pointer to first occurrence of c in s, or a null pointer if no match
        /// </summary>
        public int Memchr
        {
            get
            {
                if (f_memchr)
                    return _memchr;
                _memchr = (int) (111172);
                f_memchr = true;
                return _memchr;
            }
        }
        private bool f_gxsLoadBgPltt;
        private int _gxsLoadBgPltt;
        public int GxsLoadBgPltt
        {
            get
            {
                if (f_gxsLoadBgPltt)
                    return _gxsLoadBgPltt;
                _gxsLoadBgPltt = (int) (48244);
                f_gxsLoadBgPltt = true;
                return _gxsLoadBgPltt;
            }
        }
        private bool f_fls;
        private int _fls;

        /// <summary>
        /// Implements the &lt; operator for IEEE 754 floating-point numbers.
        /// 
        /// r0: a
        /// r1: b
        /// return: a &lt; b
        /// </summary>
        public int Fls
        {
            get
            {
                if (f_fls)
                    return _fls;
                _fls = (int) (143604);
                f_fls = true;
                return _fls;
            }
        }
        private bool f_gxsLoadBg1Char;
        private int _gxsLoadBg1Char;
        public int GxsLoadBg1Char
        {
            get
            {
                if (f_gxsLoadBg1Char)
                    return _gxsLoadBg1Char;
                _gxsLoadBg1Char = (int) (49624);
                f_gxsLoadBg1Char = true;
                return _gxsLoadBg1Char;
            }
        }
        private bool f_fxDivAsync;
        private int _fxDivAsync;
        public int FxDivAsync
        {
            get
            {
                if (f_fxDivAsync)
                    return _fxDivAsync;
                _fxDivAsync = (int) (39676);
                f_fxDivAsync = true;
                return _fxDivAsync;
            }
        }
        private bool f_dseTrackEventSetupVolumeLfo;
        private int _dseTrackEventSetupVolumeLfo;
        public int DseTrackEventSetupVolumeLfo
        {
            get
            {
                if (f_dseTrackEventSetupVolumeLfo)
                    return _dseTrackEventSetupVolumeLfo;
                _dseTrackEventSetupVolumeLfo = (int) (25552);
                f_dseTrackEventSetupVolumeLfo = true;
                return _dseTrackEventSetupVolumeLfo;
            }
        }
        private bool f_dseDriverInit;
        private int _dseDriverInit;
        public int DseDriverInit
        {
            get
            {
                if (f_dseDriverInit)
                    return _dseDriverInit;
                _dseDriverInit = (int) (776);
                f_dseDriverInit = true;
                return _dseDriverInit;
            }
        }
        private bool f_mbtowc;
        private int _mbtowc;

        /// <summary>
        /// The mbtowc(3) C library function.
        /// 
        /// r0: pwc
        /// r1: s
        /// r2: n
        /// return: number of consumed bytes, or -1 on failure
        /// </summary>
        public int Mbtowc
        {
            get
            {
                if (f_mbtowc)
                    return _mbtowc;
                _mbtowc = (int) (110820);
                f_mbtowc = true;
                return _mbtowc;
            }
        }
        private bool f_gxsBeginLoadObjExtPltt;
        private int _gxsBeginLoadObjExtPltt;
        public int GxsBeginLoadObjExtPltt
        {
            get
            {
                if (f_gxsBeginLoadObjExtPltt)
                    return _gxsBeginLoadObjExtPltt;
                _gxsBeginLoadObjExtPltt = (int) (50372);
                f_gxsBeginLoadObjExtPltt = true;
                return _gxsBeginLoadObjExtPltt;
            }
        }
        private bool f_soundEnvelopeParametersCheckValidity;
        private int _soundEnvelopeParametersCheckValidity;

        /// <summary>
        /// r0: Sound envelope parameters pointer
        /// </summary>
        public int SoundEnvelopeParametersCheckValidity
        {
            get
            {
                if (f_soundEnvelopeParametersCheckValidity)
                    return _soundEnvelopeParametersCheckValidity;
                _soundEnvelopeParametersCheckValidity = (int) (35784);
                f_soundEnvelopeParametersCheckValidity = true;
                return _soundEnvelopeParametersCheckValidity;
            }
        }
        private bool f_dseTrackEventSetNoteRandomRegion;
        private int _dseTrackEventSetNoteRandomRegion;
        public int DseTrackEventSetNoteRandomRegion
        {
            get
            {
                if (f_dseTrackEventSetNoteRandomRegion)
                    return _dseTrackEventSetNoteRandomRegion;
                _dseTrackEventSetNoteRandomRegion = (int) (24684);
                f_dseTrackEventSetNoteRandomRegion = true;
                return _dseTrackEventSetNoteRandomRegion;
            }
        }
        private bool f_g2xSetBlendBrightness;
        private int _g2xSetBlendBrightness;
        public int G2xSetBlendBrightness
        {
            get
            {
                if (f_g2xSetBlendBrightness)
                    return _g2xSetBlendBrightness;
                _g2xSetBlendBrightness = (int) (46636);
                f_g2xSetBlendBrightness = true;
                return _g2xSetBlendBrightness;
            }
        }
        private bool f_dseTrackEventSetupVolumeLfoEnvelope;
        private int _dseTrackEventSetupVolumeLfoEnvelope;
        public int DseTrackEventSetupVolumeLfoEnvelope
        {
            get
            {
                if (f_dseTrackEventSetupVolumeLfoEnvelope)
                    return _dseTrackEventSetupVolumeLfoEnvelope;
                _dseTrackEventSetupVolumeLfoEnvelope = (int) (25644);
                f_dseTrackEventSetupVolumeLfoEnvelope = true;
                return _dseTrackEventSetupVolumeLfoEnvelope;
            }
        }
        private bool f_dseVoiceResetHw;
        private int _dseVoiceResetHw;
        public int DseVoiceResetHw
        {
            get
            {
                if (f_dseVoiceResetHw)
                    return _dseVoiceResetHw;
                _dseVoiceResetHw = (int) (33540);
                f_dseVoiceResetHw = true;
                return _dseVoiceResetHw;
            }
        }
        private bool f_dseSequenceStart;
        private int _dseSequenceStart;
        public int DseSequenceStart
        {
            get
            {
                if (f_dseSequenceStart)
                    return _dseSequenceStart;
                _dseSequenceStart = (int) (6820);
                f_dseSequenceStart = true;
                return _dseSequenceStart;
            }
        }
        private bool f_strchr;
        private int _strchr;

        /// <summary>
        /// The strchr(3) C library function.
        /// 
        /// r0: string
        /// r1: c
        /// return: pointer to the located byte c, or null pointer if no match
        /// </summary>
        public int Strchr
        {
            get
            {
                if (f_strchr)
                    return _strchr;
                _strchr = (int) (120988);
                f_strchr = true;
                return _strchr;
            }
        }
        private bool f_dseTrackEventTuningDeltaFull;
        private int _dseTrackEventTuningDeltaFull;
        public int DseTrackEventTuningDeltaFull
        {
            get
            {
                if (f_dseTrackEventTuningDeltaFull)
                    return _dseTrackEventTuningDeltaFull;
                _dseTrackEventTuningDeltaFull = (int) (24300);
                f_dseTrackEventTuningDeltaFull = true;
                return _dseTrackEventTuningDeltaFull;
            }
        }
        private bool f_gxDisableBankForLcdc;
        private int _gxDisableBankForLcdc;
        public int GxDisableBankForLcdc
        {
            get
            {
                if (f_gxDisableBankForLcdc)
                    return _gxDisableBankForLcdc;
                _gxDisableBankForLcdc = (int) (45700);
                f_gxDisableBankForLcdc = true;
                return _gxDisableBankForLcdc;
            }
        }
        private bool f_gxsLoadObj;
        private int _gxsLoadObj;
        public int GxsLoadObj
        {
            get
            {
                if (f_gxsLoadObj)
                    return _gxsLoadObj;
                _gxsLoadObj = (int) (48768);
                f_gxsLoadObj = true;
                return _gxsLoadObj;
            }
        }
        private bool f_dseTrackEventVolumeDelta;
        private int _dseTrackEventVolumeDelta;
        public int DseTrackEventVolumeDelta
        {
            get
            {
                if (f_dseTrackEventVolumeDelta)
                    return _dseTrackEventVolumeDelta;
                _dseTrackEventVolumeDelta = (int) (25144);
                f_dseTrackEventVolumeDelta = true;
                return _dseTrackEventVolumeDelta;
            }
        }
        private bool f_fsub;
        private int _fsub;

        /// <summary>
        /// Implements the subtraction operator for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __subsf3 in libgcc.
        /// 
        /// r0: a
        /// r1: b
        /// return: a - b
        /// </summary>
        public int Fsub
        {
            get
            {
                if (f_fsub)
                    return _fsub;
                _fsub = (int) (145708);
                f_fsub = true;
                return _fsub;
            }
        }
        private bool f_gxLoadBg3Scr;
        private int _gxLoadBg3Scr;
        public int GxLoadBg3Scr
        {
            get
            {
                if (f_gxLoadBg3Scr)
                    return _gxLoadBg3Scr;
                _gxLoadBg3Scr = (int) (49240);
                f_gxLoadBg3Scr = true;
                return _gxLoadBg3Scr;
            }
        }
        private bool f_dseTrackEventSetHoldNotes;
        private int _dseTrackEventSetHoldNotes;
        public int DseTrackEventSetHoldNotes
        {
            get
            {
                if (f_dseTrackEventSetHoldNotes)
                    return _dseTrackEventSetHoldNotes;
                _dseTrackEventSetHoldNotes = (int) (23808);
                f_dseTrackEventSetHoldNotes = true;
                return _dseTrackEventSetHoldNotes;
            }
        }
        private bool f_enableVramBanksInSetDontSave;
        private int _enableVramBanksInSetDontSave;

        /// <summary>
        /// Enable the VRAM bank marked in the input set, but don’t mark them as enabled in ENABLED_VRAM_BANKS
        /// 
        /// r0: vram_banks_set
        /// </summary>
        public int EnableVramBanksInSetDontSave
        {
            get
            {
                if (f_enableVramBanksInSetDontSave)
                    return _enableVramBanksInSetDontSave;
                _enableVramBanksInSetDontSave = (int) (41684);
                f_enableVramBanksInSetDontSave = true;
                return _enableVramBanksInSetDontSave;
            }
        }
        private bool f_dseTrackEventSetupKeyBendLfo;
        private int _dseTrackEventSetupKeyBendLfo;
        public int DseTrackEventSetupKeyBendLfo
        {
            get
            {
                if (f_dseTrackEventSetupKeyBendLfo)
                    return _dseTrackEventSetupKeyBendLfo;
                _dseTrackEventSetupKeyBendLfo = (int) (24828);
                f_dseTrackEventSetupKeyBendLfo = true;
                return _dseTrackEventSetupKeyBendLfo;
            }
        }
        private bool f_vecDotProduct;
        private int _vecDotProduct;
        public int VecDotProduct
        {
            get
            {
                if (f_vecDotProduct)
                    return _vecDotProduct;
                _vecDotProduct = (int) (39836);
                f_vecDotProduct = true;
                return _vecDotProduct;
            }
        }
        private bool f_gxBeginLoadTex;
        private int _gxBeginLoadTex;
        public int GxBeginLoadTex
        {
            get
            {
                if (f_gxBeginLoadTex)
                    return _gxBeginLoadTex;
                _gxBeginLoadTex = (int) (50460);
                f_gxBeginLoadTex = true;
                return _gxBeginLoadTex;
            }
        }
        private bool f_gxLoadOam;
        private int _gxLoadOam;
        public int GxLoadOam
        {
            get
            {
                if (f_gxLoadOam)
                    return _gxLoadOam;
                _gxLoadOam = (int) (48508);
                f_gxLoadOam = true;
                return _gxLoadOam;
            }
        }
        private bool f_dseTrackEventSetBankMsb;
        private int _dseTrackEventSetBankMsb;
        public int DseTrackEventSetBankMsb
        {
            get
            {
                if (f_dseTrackEventSetBankMsb)
                    return _dseTrackEventSetBankMsb;
                _dseTrackEventSetBankMsb = (int) (23220);
                f_dseTrackEventSetBankMsb = true;
                return _dseTrackEventSetBankMsb;
            }
        }
        private bool f_gxsEndLoadBgExtPltt;
        private int _gxsEndLoadBgExtPltt;
        public int GxsEndLoadBgExtPltt
        {
            get
            {
                if (f_gxsEndLoadBgExtPltt)
                    return _gxsEndLoadBgExtPltt;
                _gxsEndLoadBgExtPltt = (int) (50308);
                f_gxsEndLoadBgExtPltt = true;
                return _gxsEndLoadBgExtPltt;
            }
        }
        private bool f_dseChannelInit;
        private int _dseChannelInit;
        public int DseChannelInit
        {
            get
            {
                if (f_dseChannelInit)
                    return _dseChannelInit;
                _dseChannelInit = (int) (30724);
                f_dseChannelInit = true;
                return _dseChannelInit;
            }
        }
        private bool f_dseSeStopSeq;
        private int _dseSeStopSeq;
        public int DseSeStopSeq
        {
            get
            {
                if (f_dseSeStopSeq)
                    return _dseSeStopSeq;
                _dseSeStopSeq = (int) (13428);
                f_dseSeStopSeq = true;
                return _dseSeStopSeq;
            }
        }
        private bool f_dseMemClear;
        private int _dseMemClear;
        public int DseMemClear
        {
            get
            {
                if (f_dseMemClear)
                    return _dseMemClear;
                _dseMemClear = (int) (3044);
                f_dseMemClear = true;
                return _dseMemClear;
            }
        }
        private bool f_tryAssignByte;
        private int _tryAssignByte;

        /// <summary>
        /// Assign a byte to the target of a pointer if the pointer is non-null.
        /// 
        /// r0: pointer
        /// r1: value
        /// return: true on success, false on failure
        /// </summary>
        public int TryAssignByte
        {
            get
            {
                if (f_tryAssignByte)
                    return _tryAssignByte;
                _tryAssignByte = (int) (110876);
                f_tryAssignByte = true;
                return _tryAssignByte;
            }
        }
        private bool f_dseBgmDefaultSignalCallback;
        private int _dseBgmDefaultSignalCallback;
        public int DseBgmDefaultSignalCallback
        {
            get
            {
                if (f_dseBgmDefaultSignalCallback)
                    return _dseBgmDefaultSignalCallback;
                _dseBgmDefaultSignalCallback = (int) (5928);
                f_dseBgmDefaultSignalCallback = true;
                return _dseBgmDefaultSignalCallback;
            }
        }
        private bool f_dseSwdSysInit;
        private int _dseSwdSysInit;
        public int DseSwdSysInit
        {
            get
            {
                if (f_dseSwdSysInit)
                    return _dseSwdSysInit;
                _dseSwdSysInit = (int) (3268);
                f_dseSwdSysInit = true;
                return _dseSwdSysInit;
            }
        }
        private bool f_dseSwdGetInstrument;
        private int _dseSwdGetInstrument;
        public int DseSwdGetInstrument
        {
            get
            {
                if (f_dseSwdGetInstrument)
                    return _dseSwdGetInstrument;
                _dseSwdGetInstrument = (int) (5304);
                f_dseSwdGetInstrument = true;
                return _dseSwdGetInstrument;
            }
        }
        private bool f_gxInitGxState;
        private int _gxInitGxState;
        public int GxInitGxState
        {
            get
            {
                if (f_gxInitGxState)
                    return _gxInitGxState;
                _gxInitGxState = (int) (41588);
                f_gxInitGxState = true;
                return _gxInitGxState;
            }
        }
        private bool f_dseVoiceStart;
        private int _dseVoiceStart;
        public int DseVoiceStart
        {
            get
            {
                if (f_dseVoiceStart)
                    return _dseVoiceStart;
                _dseVoiceStart = (int) (34472);
                f_dseVoiceStart = true;
                return _dseVoiceStart;
            }
        }
        private bool f_dseDriverStartTickTimer;
        private int _dseDriverStartTickTimer;
        public int DseDriverStartTickTimer
        {
            get
            {
                if (f_dseDriverStartTickTimer)
                    return _dseDriverStartTickTimer;
                _dseDriverStartTickTimer = (int) (19972);
                f_dseDriverStartTickTimer = true;
                return _dseDriverStartTickTimer;
            }
        }
        private bool f_gxsLoadBg1Scr;
        private int _gxsLoadBg1Scr;
        public int GxsLoadBg1Scr
        {
            get
            {
                if (f_gxsLoadBg1Scr)
                    return _gxsLoadBg1Scr;
                _gxsLoadBg1Scr = (int) (49048);
                f_gxsLoadBg1Scr = true;
                return _gxsLoadBg1Scr;
            }
        }
        private bool f_gxSetBankForTexPltt;
        private int _gxSetBankForTexPltt;
        public int GxSetBankForTexPltt
        {
            get
            {
                if (f_gxSetBankForTexPltt)
                    return _gxSetBankForTexPltt;
                _gxSetBankForTexPltt = (int) (43760);
                f_gxSetBankForTexPltt = true;
                return _gxSetBankForTexPltt;
            }
        }
        private bool f_dseTrackEventSetFlagBit1Unknown;
        private int _dseTrackEventSetFlagBit1Unknown;
        public int DseTrackEventSetFlagBit1Unknown
        {
            get
            {
                if (f_dseTrackEventSetFlagBit1Unknown)
                    return _dseTrackEventSetFlagBit1Unknown;
                _dseTrackEventSetFlagBit1Unknown = (int) (23864);
                f_dseTrackEventSetFlagBit1Unknown = true;
                return _dseTrackEventSetFlagBit1Unknown;
            }
        }
        private bool f_sprintf;
        private int _sprintf;

        /// <summary>
        /// The sprintf(3) C library function.
        /// 
        /// This calls __vsprintf_internal directly, so it's presumably the real sprintf.
        /// 
        /// r0: str
        /// r1: format
        /// ...: variadic
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int Sprintf
        {
            get
            {
                if (f_sprintf)
                    return _sprintf;
                _sprintf = (int) (119980);
                f_sprintf = true;
                return _sprintf;
            }
        }
        private bool f_gxBeginLoadObjExtPltt;
        private int _gxBeginLoadObjExtPltt;
        public int GxBeginLoadObjExtPltt
        {
            get
            {
                if (f_gxBeginLoadObjExtPltt)
                    return _gxBeginLoadObjExtPltt;
                _gxBeginLoadObjExtPltt = (int) (50144);
                f_gxBeginLoadObjExtPltt = true;
                return _gxBeginLoadObjExtPltt;
            }
        }
        private bool f_gxSendFifo64B;
        private int _gxSendFifo64B;
        public int GxSendFifo64B
        {
            get
            {
                if (f_gxSendFifo64B)
                    return _gxSendFifo64B;
                _gxSendFifo64B = (int) (51212);
                f_gxSendFifo64B = true;
                return _gxSendFifo64B;
            }
        }
        private bool f_gxDisableBankForClearImage;
        private int _gxDisableBankForClearImage;
        public int GxDisableBankForClearImage
        {
            get
            {
                if (f_gxDisableBankForClearImage)
                    return _gxDisableBankForClearImage;
                _gxDisableBankForClearImage = (int) (45660);
                f_gxDisableBankForClearImage = true;
                return _gxDisableBankForClearImage;
            }
        }
        private bool f_gxEndLoadTexPltt;
        private int _gxEndLoadTexPltt;
        public int GxEndLoadTexPltt
        {
            get
            {
                if (f_gxEndLoadTexPltt)
                    return _gxEndLoadTexPltt;
                _gxEndLoadTexPltt = (int) (51108);
                f_gxEndLoadTexPltt = true;
                return _gxEndLoadTexPltt;
            }
        }
        private bool f_gxEndLoadTex;
        private int _gxEndLoadTex;
        public int GxEndLoadTex
        {
            get
            {
                if (f_gxEndLoadTex)
                    return _gxEndLoadTex;
                _gxEndLoadTex = (int) (50872);
                f_gxEndLoadTex = true;
                return _gxEndLoadTex;
            }
        }
        private bool f_soundLfoBankSet;
        private int _soundLfoBankSet;

        /// <summary>
        /// r0: LFO bank pointer
        /// r1: LFO settings pointer
        /// r2: Envelope level
        /// </summary>
        public int SoundLfoBankSet
        {
            get
            {
                if (f_soundLfoBankSet)
                    return _soundLfoBankSet;
                _soundLfoBankSet = (int) (36828);
                f_soundLfoBankSet = true;
                return _soundLfoBankSet;
            }
        }
        private bool f_dseChannelDeallocateVoices;
        private int _dseChannelDeallocateVoices;
        public int DseChannelDeallocateVoices
        {
            get
            {
                if (f_dseChannelDeallocateVoices)
                    return _dseChannelDeallocateVoices;
                _dseChannelDeallocateVoices = (int) (31160);
                f_dseChannelDeallocateVoices = true;
                return _dseChannelDeallocateVoices;
            }
        }
        private bool f_g2SGetBg1CharPtr;
        private int _g2SGetBg1CharPtr;
        public int G2SGetBg1CharPtr
        {
            get
            {
                if (f_g2SGetBg1CharPtr)
                    return _g2SGetBg1CharPtr;
                _g2SGetBg1CharPtr = (int) (46408);
                f_g2SGetBg1CharPtr = true;
                return _g2SGetBg1CharPtr;
            }
        }
        private bool f_dseTrackEventSetupPanLfoEnvelope;
        private int _dseTrackEventSetupPanLfoEnvelope;
        public int DseTrackEventSetupPanLfoEnvelope
        {
            get
            {
                if (f_dseTrackEventSetupPanLfoEnvelope)
                    return _dseTrackEventSetupPanLfoEnvelope;
                _dseTrackEventSetupPanLfoEnvelope = (int) (26184);
                f_dseTrackEventSetupPanLfoEnvelope = true;
                return _dseTrackEventSetupPanLfoEnvelope;
            }
        }
        private bool f_memmove;
        private int _memmove;

        /// <summary>
        /// The memmove(3) C library function.
        /// 
        /// The implementation is nearly the same as memcpy, but it copies bytes from back to front if src &lt; dst.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// return: dest
        /// </summary>
        public int Memmove
        {
            get
            {
                if (f_memmove)
                    return _memmove;
                _memmove = (int) (111076);
                f_memmove = true;
                return _memmove;
            }
        }
        private bool f_dseMemInit;
        private int _dseMemInit;
        public int DseMemInit
        {
            get
            {
                if (f_dseMemInit)
                    return _dseMemInit;
                _dseMemInit = (int) (2116);
                f_dseMemInit = true;
                return _dseMemInit;
            }
        }
        private bool f_gxResetBankForBgExtPltt;
        private int _gxResetBankForBgExtPltt;
        public int GxResetBankForBgExtPltt
        {
            get
            {
                if (f_gxResetBankForBgExtPltt)
                    return _gxResetBankForBgExtPltt;
                _gxResetBankForBgExtPltt = (int) (45092);
                f_gxResetBankForBgExtPltt = true;
                return _gxResetBankForBgExtPltt;
            }
        }
        private bool f_dseDriverConfigureHeap;
        private int _dseDriverConfigureHeap;
        public int DseDriverConfigureHeap
        {
            get
            {
                if (f_dseDriverConfigureHeap)
                    return _dseDriverConfigureHeap;
                _dseDriverConfigureHeap = (int) (612);
                f_dseDriverConfigureHeap = true;
                return _dseDriverConfigureHeap;
            }
        }
        private bool f_vecNormalize;
        private int _vecNormalize;
        public int VecNormalize
        {
            get
            {
                if (f_vecNormalize)
                    return _vecNormalize;
                _vecNormalize = (int) (40028);
                f_vecNormalize = true;
                return _vecNormalize;
            }
        }
        private bool f_getOverlayInfo;
        private int _getOverlayInfo;

        /// <summary>
        /// Returns the y9.bin entry for the specified overlay
        /// 
        /// r0: [output] Overlay info struct
        /// r1: ?
        /// r2: Overlay ID
        /// return: True if the entry could be loaded successfully?
        /// </summary>
        public int GetOverlayInfo
        {
            get
            {
                if (f_getOverlayInfo)
                    return _getOverlayInfo;
                _getOverlayInfo = (int) (80836);
                f_getOverlayInfo = true;
                return _getOverlayInfo;
            }
        }
        private bool f_dseChannelResetTimerAndVolumeForVoices;
        private int _dseChannelResetTimerAndVolumeForVoices;
        public int DseChannelResetTimerAndVolumeForVoices
        {
            get
            {
                if (f_dseChannelResetTimerAndVolumeForVoices)
                    return _dseChannelResetTimerAndVolumeForVoices;
                _dseChannelResetTimerAndVolumeForVoices = (int) (31292);
                f_dseChannelResetTimerAndVolumeForVoices = true;
                return _dseChannelResetTimerAndVolumeForVoices;
            }
        }
        private bool f_initOverlay;
        private int _initOverlay;

        /// <summary>
        /// Performs overlay initialization right after loading an overlay with LoadOverlayInternal.
        /// 
        /// This function is responsible for jumping to all the pointers located in the overlay's static init array, among other things.
        /// 
        /// r0: Overlay info struct
        /// </summary>
        public int InitOverlay
        {
            get
            {
                if (f_initOverlay)
                    return _initOverlay;
                _initOverlay = (int) (81380);
                f_initOverlay = true;
                return _initOverlay;
            }
        }
        private bool f_dseTrackEventTuningFade;
        private int _dseTrackEventTuningFade;
        public int DseTrackEventTuningFade
        {
            get
            {
                if (f_dseTrackEventTuningFade)
                    return _dseTrackEventTuningFade;
                _dseTrackEventTuningFade = (int) (24444);
                f_dseTrackEventTuningFade = true;
                return _dseTrackEventTuningFade;
            }
        }
        private bool f_dseTrackEventSongVolumeFade;
        private int _dseTrackEventSongVolumeFade;
        public int DseTrackEventSongVolumeFade
        {
            get
            {
                if (f_dseTrackEventSongVolumeFade)
                    return _dseTrackEventSongVolumeFade;
                _dseTrackEventSongVolumeFade = (int) (23396);
                f_dseTrackEventSongVolumeFade = true;
                return _dseTrackEventSongVolumeFade;
            }
        }
        private bool f_gxDisableBankForSubBg;
        private int _gxDisableBankForSubBg;
        public int GxDisableBankForSubBg
        {
            get
            {
                if (f_gxDisableBankForSubBg)
                    return _gxDisableBankForSubBg;
                _gxDisableBankForSubBg = (int) (45720);
                f_gxDisableBankForSubBg = true;
                return _gxDisableBankForSubBg;
            }
        }
        private bool f_dseTrackEventSetTuningJitterAmplitude;
        private int _dseTrackEventSetTuningJitterAmplitude;
        public int DseTrackEventSetTuningJitterAmplitude
        {
            get
            {
                if (f_dseTrackEventSetTuningJitterAmplitude)
                    return _dseTrackEventSetTuningJitterAmplitude;
                _dseTrackEventSetTuningJitterAmplitude = (int) (24724);
                f_dseTrackEventSetTuningJitterAmplitude = true;
                return _dseTrackEventSetTuningJitterAmplitude;
            }
        }
        private bool f_gxResetBankForTex;
        private int _gxResetBankForTex;
        public int GxResetBankForTex
        {
            get
            {
                if (f_gxResetBankForTex)
                    return _gxResetBankForTex;
                _gxResetBankForTex = (int) (45164);
                f_gxResetBankForTex = true;
                return _gxResetBankForTex;
            }
        }
        private bool f_soundLfoWaveFullNoiseFunc;
        private int _soundLfoWaveFullNoiseFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveFullNoiseFunc
        {
            get
            {
                if (f_soundLfoWaveFullNoiseFunc)
                    return _soundLfoWaveFullNoiseFunc;
                _soundLfoWaveFullNoiseFunc = (int) (38112);
                f_soundLfoWaveFullNoiseFunc = true;
                return _soundLfoWaveFullNoiseFunc;
            }
        }
        private bool f_arrayFill16;
        private int _arrayFill16;

        /// <summary>
        /// Fills an array of 16-bit values with a given value.
        /// 
        /// r0: value
        /// r1: ptr
        /// r2: len (# bytes)
        /// </summary>
        public int ArrayFill16
        {
            get
            {
                if (f_arrayFill16)
                    return _arrayFill16;
                _arrayFill16 = (int) (66016);
                f_arrayFill16 = true;
                return _arrayFill16;
            }
        }
        private bool f_gxBeginLoadBgExtPltt;
        private int _gxBeginLoadBgExtPltt;
        public int GxBeginLoadBgExtPltt
        {
            get
            {
                if (f_gxBeginLoadBgExtPltt)
                    return _gxBeginLoadBgExtPltt;
                _gxBeginLoadBgExtPltt = (int) (49912);
                f_gxBeginLoadBgExtPltt = true;
                return _gxBeginLoadBgExtPltt;
            }
        }
        private bool f_g3XClearFifo;
        private int _g3XClearFifo;
        public int G3XClearFifo
        {
            get
            {
                if (f_g3XClearFifo)
                    return _g3XClearFifo;
                _g3XClearFifo = (int) (47204);
                f_g3XClearFifo = true;
                return _g3XClearFifo;
            }
        }
        private bool f_gxSetBankForSubObj;
        private int _gxSetBankForSubObj;
        public int GxSetBankForSubObj
        {
            get
            {
                if (f_gxSetBankForSubObj)
                    return _gxSetBankForSubObj;
                _gxSetBankForSubObj = (int) (44672);
                f_gxSetBankForSubObj = true;
                return _gxSetBankForSubObj;
            }
        }
        private bool f_geomGxFifoSendMtx4x3;
        private int _geomGxFifoSendMtx4x3;

        /// <summary>
        /// Send a 4x3 matrix argument for a GXFIFO geometry engine command.
        /// 
        /// This function is used by GeomMtxLoad4x3 and GeomMtxMult4x3 to pass the matrix argument for a GXFIFO command after already having written the command code. See https://problemkaputt.de/gbatek.htm#ds3dgeometrycommands for more information.
        /// 
        /// Note that the GXFIFO address is 0x4000400, but is (maybe) mirrored up to 0x400043F. This function is optimized to take advantage of this by writing 3 matrix entries at a time using ldmia and stmia instructions.
        /// 
        /// r0: matrix_4x3 pointer
        /// r1: GXFIFO pointer
        /// </summary>
        public int GeomGxFifoSendMtx4x3
        {
            get
            {
                if (f_geomGxFifoSendMtx4x3)
                    return _geomGxFifoSendMtx4x3;
                _geomGxFifoSendMtx4x3 = (int) (51176);
                f_geomGxFifoSendMtx4x3 = true;
                return _geomGxFifoSendMtx4x3;
            }
        }
        private bool f_dseVoiceFlagForDeactivation;
        private int _dseVoiceFlagForDeactivation;
        public int DseVoiceFlagForDeactivation
        {
            get
            {
                if (f_dseVoiceFlagForDeactivation)
                    return _dseVoiceFlagForDeactivation;
                _dseVoiceFlagForDeactivation = (int) (35100);
                f_dseVoiceFlagForDeactivation = true;
                return _dseVoiceFlagForDeactivation;
            }
        }
        private bool f_dseTrackEventSubLoopEnd;
        private int _dseTrackEventSubLoopEnd;
        public int DseTrackEventSubLoopEnd
        {
            get
            {
                if (f_dseTrackEventSubLoopEnd)
                    return _dseTrackEventSubLoopEnd;
                _dseTrackEventSubLoopEnd = (int) (22916);
                f_dseTrackEventSubLoopEnd = true;
                return _dseTrackEventSubLoopEnd;
            }
        }
        private bool f_dseSynthSetBankAndSequence;
        private int _dseSynthSetBankAndSequence;
        public int DseSynthSetBankAndSequence
        {
            get
            {
                if (f_dseSynthSetBankAndSequence)
                    return _dseSynthSetBankAndSequence;
                _dseSynthSetBankAndSequence = (int) (30580);
                f_dseSynthSetBankAndSequence = true;
                return _dseSynthSetBankAndSequence;
            }
        }
        private bool f_setThreadField0xB4;
        private int _setThreadField0xB4;

        /// <summary>
        /// Sets the given thread's field_0xB4 to the specified value.
        /// 
        /// r0: Thread
        /// r1: Value to set
        /// </summary>
        public int SetThreadField0xB4
        {
            get
            {
                if (f_setThreadField0xB4)
                    return _setThreadField0xB4;
                _setThreadField0xB4 = (int) (56228);
                f_setThreadField0xB4 = true;
                return _setThreadField0xB4;
            }
        }
        private bool f_dseTrackEventWait24;
        private int _dseTrackEventWait24;
        public int DseTrackEventWait24
        {
            get
            {
                if (f_dseTrackEventWait24)
                    return _dseTrackEventWait24;
                _dseTrackEventWait24 = (int) (22688);
                f_dseTrackEventWait24 = true;
                return _dseTrackEventWait24;
            }
        }
        private bool f_dseSwdLoadWaves;
        private int _dseSwdLoadWaves;
        public int DseSwdLoadWaves
        {
            get
            {
                if (f_dseSwdLoadWaves)
                    return _dseSwdLoadWaves;
                _dseSwdLoadWaves = (int) (4688);
                f_dseSwdLoadWaves = true;
                return _dseSwdLoadWaves;
            }
        }
        private bool f_dneq;
        private int _dneq;

        /// <summary>
        /// Implements the != operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a != b
        /// </summary>
        public int Dneq
        {
            get
            {
                if (f_dneq)
                    return _dneq;
                _dneq = (int) (143464);
                f_dneq = true;
                return _dneq;
            }
        }
        private bool f_incrementThreadCount;
        private int _incrementThreadCount;

        /// <summary>
        /// Increments thread_info::thread_count by 1 and returns the new value.
        /// 
        /// return: New thread count
        /// </summary>
        public int IncrementThreadCount
        {
            get
            {
                if (f_incrementThreadCount)
                    return _incrementThreadCount;
                _incrementThreadCount = (int) (53368);
                f_incrementThreadCount = true;
                return _incrementThreadCount;
            }
        }
        private bool f_dseVoiceReleaseNote;
        private int _dseVoiceReleaseNote;
        public int DseVoiceReleaseNote
        {
            get
            {
                if (f_dseVoiceReleaseNote)
                    return _dseVoiceReleaseNote;
                _dseVoiceReleaseNote = (int) (32888);
                f_dseVoiceReleaseNote = true;
                return _dseVoiceReleaseNote;
            }
        }
        private bool f_dseSwdUnload;
        private int _dseSwdUnload;
        public int DseSwdUnload
        {
            get
            {
                if (f_dseSwdUnload)
                    return _dseSwdUnload;
                _dseSwdUnload = (int) (5132);
                f_dseSwdUnload = true;
                return _dseSwdUnload;
            }
        }
        private bool f_fdiv;
        private int _fdiv;

        /// <summary>
        /// Implements the division operator for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __divsf3 in libgcc.
        /// 
        /// r0: dividend
        /// r1: divisor
        /// return: dividend / divisor
        /// </summary>
        public int Fdiv
        {
            get
            {
                if (f_fdiv)
                    return _fdiv;
                _fdiv = (int) (143708);
                f_fdiv = true;
                return _fdiv;
            }
        }
        private bool f_dseTrackEventWaitDelta;
        private int _dseTrackEventWaitDelta;
        public int DseTrackEventWaitDelta
        {
            get
            {
                if (f_dseTrackEventWaitDelta)
                    return _dseTrackEventWaitDelta;
                _dseTrackEventWaitDelta = (int) (22620);
                f_dseTrackEventWaitDelta = true;
                return _dseTrackEventWaitDelta;
            }
        }
        private bool f_g3XReset;
        private int _g3XReset;
        public int G3XReset
        {
            get
            {
                if (f_g3XReset)
                    return _g3XReset;
                _g3XReset = (int) (47096);
                f_g3XReset = true;
                return _g3XReset;
            }
        }
        private bool f_threadExit;
        private int _threadExit;

        /// <summary>
        /// Function called by threads on exit.
        /// 
        /// Base functions that contain an infinite loop that is not supposed to return and that have their stacks in main RAM have this function as their return address.
        /// 
        /// No params.
        /// </summary>
        public int ThreadExit
        {
            get
            {
                if (f_threadExit)
                    return _threadExit;
                _threadExit = (int) (54660);
                f_threadExit = true;
                return _threadExit;
            }
        }
        private bool f_dadd;
        private int _dadd;

        /// <summary>
        /// Implements the addition operator for IEEE 754 double-precision floating-point numbers.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __adddf3 in libgcc.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a + b
        /// </summary>
        public int Dadd
        {
            get
            {
                if (f_dadd)
                    return _dadd;
                _dadd = (int) (138736);
                f_dadd = true;
                return _dadd;
            }
        }
        private bool f_dseTrackEventUseVolumeLfo;
        private int _dseTrackEventUseVolumeLfo;
        public int DseTrackEventUseVolumeLfo
        {
            get
            {
                if (f_dseTrackEventUseVolumeLfo)
                    return _dseTrackEventUseVolumeLfo;
                _dseTrackEventUseVolumeLfo = (int) (25684);
                f_dseTrackEventUseVolumeLfo = true;
                return _dseTrackEventUseVolumeLfo;
            }
        }
        private bool f_dseTrackEventEndTrack;
        private int _dseTrackEventEndTrack;
        public int DseTrackEventEndTrack
        {
            get
            {
                if (f_dseTrackEventEndTrack)
                    return _dseTrackEventEndTrack;
                _dseTrackEventEndTrack = (int) (22768);
                f_dseTrackEventEndTrack = true;
                return _dseTrackEventEndTrack;
            }
        }
        private bool f_osGetLockId;
        private int _osGetLockId;
        public int OsGetLockId
        {
            get
            {
                if (f_osGetLockId)
                    return _osGetLockId;
                _osGetLockId = (int) (53076);
                f_osGetLockId = true;
                return _osGetLockId;
            }
        }
        private bool f_arrayCopy32Fast;
        private int _arrayCopy32Fast;

        /// <summary>
        /// Does the same thing as ArrayCopy32, except the implementation uses an unrolled loop that copies 8 values per iteration, taking advantage of the ldmia/stmia instructions.
        /// 
        /// r0: src
        /// r1: dest
        /// r2: len (# bytes)
        /// </summary>
        public int ArrayCopy32Fast
        {
            get
            {
                if (f_arrayCopy32Fast)
                    return _arrayCopy32Fast;
                _arrayCopy32Fast = (int) (66268);
                f_arrayCopy32Fast = true;
                return _arrayCopy32Fast;
            }
        }
        private bool f_dseTrackEventRestoreEnvelopeDefaults;
        private int _dseTrackEventRestoreEnvelopeDefaults;
        public int DseTrackEventRestoreEnvelopeDefaults
        {
            get
            {
                if (f_dseTrackEventRestoreEnvelopeDefaults)
                    return _dseTrackEventRestoreEnvelopeDefaults;
                _dseTrackEventRestoreEnvelopeDefaults = (int) (23536);
                f_dseTrackEventRestoreEnvelopeDefaults = true;
                return _dseTrackEventRestoreEnvelopeDefaults;
            }
        }
        private bool f_dseTrackEventSetupLfo;
        private int _dseTrackEventSetupLfo;
        public int DseTrackEventSetupLfo
        {
            get
            {
                if (f_dseTrackEventSetupLfo)
                    return _dseTrackEventSetupLfo;
                _dseTrackEventSetupLfo = (int) (26264);
                f_dseTrackEventSetupLfo = true;
                return _dseTrackEventSetupLfo;
            }
        }
        private bool f_dseTrackEventWait8;
        private int _dseTrackEventWait8;
        public int DseTrackEventWait8
        {
            get
            {
                if (f_dseTrackEventWait8)
                    return _dseTrackEventWait8;
                _dseTrackEventWait8 = (int) (22644);
                f_dseTrackEventWait8 = true;
                return _dseTrackEventWait8;
            }
        }
        private bool f_dseTrackEventWaitUntilFadeout;
        private int _dseTrackEventWaitUntilFadeout;
        public int DseTrackEventWaitUntilFadeout
        {
            get
            {
                if (f_dseTrackEventWaitUntilFadeout)
                    return _dseTrackEventWaitUntilFadeout;
                _dseTrackEventWaitUntilFadeout = (int) (22724);
                f_dseTrackEventWaitUntilFadeout = true;
                return _dseTrackEventWaitUntilFadeout;
            }
        }
        private bool f_dseTrackEventSubLoopBegin;
        private int _dseTrackEventSubLoopBegin;
        public int DseTrackEventSubLoopBegin
        {
            get
            {
                if (f_dseTrackEventSubLoopBegin)
                    return _dseTrackEventSubLoopBegin;
                _dseTrackEventSubLoopBegin = (int) (22852);
                f_dseTrackEventSubLoopBegin = true;
                return _dseTrackEventSubLoopBegin;
            }
        }
        private bool f_dseTrackEventInvalid;
        private int _dseTrackEventInvalid;
        public int DseTrackEventInvalid
        {
            get
            {
                if (f_dseTrackEventInvalid)
                    return _dseTrackEventInvalid;
                _dseTrackEventInvalid = (int) (22596);
                f_dseTrackEventInvalid = true;
                return _dseTrackEventInvalid;
            }
        }
        private bool f_dseSequenceInitTracks;
        private int _dseSequenceInitTracks;
        public int DseSequenceInitTracks
        {
            get
            {
                if (f_dseSequenceInitTracks)
                    return _dseSequenceInitTracks;
                _dseSequenceInitTracks = (int) (10116);
                f_dseSequenceInitTracks = true;
                return _dseSequenceInitTracks;
            }
        }
        private bool f_g3XInitMtxStack;
        private int _g3XInitMtxStack;
        public int G3XInitMtxStack
        {
            get
            {
                if (f_g3XInitMtxStack)
                    return _g3XInitMtxStack;
                _g3XInitMtxStack = (int) (47244);
                f_g3XInitMtxStack = true;
                return _g3XInitMtxStack;
            }
        }
        private bool f_dseMemFree;
        private int _dseMemFree;
        public int DseMemFree
        {
            get
            {
                if (f_dseMemFree)
                    return _dseMemFree;
                _dseMemFree = (int) (2876);
                f_dseMemFree = true;
                return _dseMemFree;
            }
        }
        private bool f_dseFileCheckHeader;
        private int _dseFileCheckHeader;
        public int DseFileCheckHeader
        {
            get
            {
                if (f_dseFileCheckHeader)
                    return _dseFileCheckHeader;
                _dseFileCheckHeader = (int) (3140);
                f_dseFileCheckHeader = true;
                return _dseFileCheckHeader;
            }
        }
        private bool f_fxDivS32;
        private int _fxDivS32;
        public int FxDivS32
        {
            get
            {
                if (f_fxDivS32)
                    return _fxDivS32;
                _fxDivS32 = (int) (39716);
                f_fxDivS32 = true;
                return _fxDivS32;
            }
        }
        private bool f_fxGetDivResult;
        private int _fxGetDivResult;
        public int FxGetDivResult
        {
            get
            {
                if (f_fxGetDivResult)
                    return _fxGetDivResult;
                _fxGetDivResult = (int) (39572);
                f_fxGetDivResult = true;
                return _fxGetDivResult;
            }
        }
        private bool f_dseSequenceStop;
        private int _dseSequenceStop;
        public int DseSequenceStop
        {
            get
            {
                if (f_dseSequenceStop)
                    return _dseSequenceStop;
                _dseSequenceStop = (int) (8940);
                f_dseSequenceStop = true;
                return _dseSequenceStop;
            }
        }
        private bool f_gxsBeginLoadBgExtPltt;
        private int _gxsBeginLoadBgExtPltt;
        public int GxsBeginLoadBgExtPltt
        {
            get
            {
                if (f_gxsBeginLoadBgExtPltt)
                    return _gxsBeginLoadBgExtPltt;
                _gxsBeginLoadBgExtPltt = (int) (50284);
                f_gxsBeginLoadBgExtPltt = true;
                return _gxsBeginLoadBgExtPltt;
            }
        }
        private bool f_gxResetBankForTexPltt;
        private int _gxResetBankForTexPltt;
        public int GxResetBankForTexPltt
        {
            get
            {
                if (f_gxResetBankForTexPltt)
                    return _gxResetBankForTexPltt;
                _gxResetBankForTexPltt = (int) (45184);
                f_gxResetBankForTexPltt = true;
                return _gxResetBankForTexPltt;
            }
        }
        private bool f_readWaviEntry;
        private int _readWaviEntry;

        /// <summary>
        /// Reads an entry from the pointer table of a wavi container and returns a pointer to the data of said entry, which contains information about a particular sample.
        /// 
        /// r0: Wavi data struct
        /// r1: Entry index
        /// return: Pointer to the entry's data
        /// </summary>
        public int ReadWaviEntry
        {
            get
            {
                if (f_readWaviEntry)
                    return _readWaviEntry;
                _readWaviEntry = (int) (5248);
                f_readWaviEntry = true;
                return _readWaviEntry;
            }
        }
        private bool f_strstr;
        private int _strstr;

        /// <summary>
        /// The strstr(3) C library function.
        /// 
        /// r0: haystack
        /// r1: needle
        /// return: pointer into haystack where needle starts, or null pointer if no match
        /// </summary>
        public int Strstr
        {
            get
            {
                if (f_strstr)
                    return _strstr;
                _strstr = (int) (121240);
                f_strstr = true;
                return _strstr;
            }
        }
        private bool f_clearIrqFlag;
        private int _clearIrqFlag;

        /// <summary>
        /// Enables processor interrupts by clearing the i flag in the program status register (cpsr).
        /// 
        /// return: Old value of cpsr &amp; 0x80 (0x80 if interrupts were disabled, 0x0 if they were already enabled)
        /// </summary>
        public int ClearIrqFlag
        {
            get
            {
                if (f_clearIrqFlag)
                    return _clearIrqFlag;
                _clearIrqFlag = (int) (63224);
                f_clearIrqFlag = true;
                return _clearIrqFlag;
            }
        }
        private bool f_dseTrackEventSetKeyBendRange;
        private int _dseTrackEventSetKeyBendRange;
        public int DseTrackEventSetKeyBendRange
        {
            get
            {
                if (f_dseTrackEventSetKeyBendRange)
                    return _dseTrackEventSetKeyBendRange;
                _dseTrackEventSetKeyBendRange = (int) (24816);
                f_dseTrackEventSetKeyBendRange = true;
                return _dseTrackEventSetKeyBendRange;
            }
        }
        private bool f_dseChannelChangeNote;
        private int _dseChannelChangeNote;
        public int DseChannelChangeNote
        {
            get
            {
                if (f_dseChannelChangeNote)
                    return _dseChannelChangeNote;
                _dseChannelChangeNote = (int) (32056);
                f_dseChannelChangeNote = true;
                return _dseChannelChangeNote;
            }
        }
        private bool f_dseSwdLoadBank;
        private int _dseSwdLoadBank;
        public int DseSwdLoadBank
        {
            get
            {
                if (f_dseSwdLoadBank)
                    return _dseSwdLoadBank;
                _dseSwdLoadBank = (int) (4144);
                f_dseSwdLoadBank = true;
                return _dseSwdLoadBank;
            }
        }
        private bool f_atomicExchange;
        private int _atomicExchange;

        /// <summary>
        /// Atomically replaces a pointer's pointee with a desired value, and returns the previous value.
        /// 
        /// This function is just a single swp instruction.
        /// 
        /// r0: desired value
        /// r1: ptr
        /// return: previous value
        /// </summary>
        public int AtomicExchange
        {
            get
            {
                if (f_atomicExchange)
                    return _atomicExchange;
                _atomicExchange = (int) (66928);
                f_atomicExchange = true;
                return _atomicExchange;
            }
        }
        private bool f_g2SGetBg0CharPtr;
        private int _g2SGetBg0CharPtr;
        public int G2SGetBg0CharPtr
        {
            get
            {
                if (f_g2SGetBg0CharPtr)
                    return _g2SGetBg0CharPtr;
                _g2SGetBg0CharPtr = (int) (46324);
                f_g2SGetBg0CharPtr = true;
                return _g2SGetBg0CharPtr;
            }
        }
        private bool f_strcspn;
        private int _strcspn;

        /// <summary>
        /// The strcspn(3) C library function.
        /// 
        /// r0: string
        /// r1: stopset
        /// return: offset of the first character in string within stopset
        /// </summary>
        public int Strcspn
        {
            get
            {
                if (f_strcspn)
                    return _strcspn;
                _strcspn = (int) (121048);
                f_strcspn = true;
                return _strcspn;
            }
        }
        private bool f_gxResetBankForSubObjExtPltt;
        private int _gxResetBankForSubObjExtPltt;
        public int GxResetBankForSubObjExtPltt
        {
            get
            {
                if (f_gxResetBankForSubObjExtPltt)
                    return _gxResetBankForSubObjExtPltt;
                _gxResetBankForSubObjExtPltt = (int) (45244);
                f_gxResetBankForSubObjExtPltt = true;
                return _gxResetBankForSubObjExtPltt;
            }
        }
        private bool f_gxDisableBankForSubObj;
        private int _gxDisableBankForSubObj;
        public int GxDisableBankForSubObj
        {
            get
            {
                if (f_gxDisableBankForSubObj)
                    return _gxDisableBankForSubObj;
                _gxDisableBankForSubObj = (int) (45740);
                f_gxDisableBankForSubObj = true;
                return _gxDisableBankForSubObj;
            }
        }
        private bool f_vsprintfInternal;
        private int _vsprintfInternal;

        /// <summary>
        /// This is what implements vsprintf. It's akin to __vsprintf_internal in the modern-day version of glibc (in fact, it's probably an older version of this).
        /// 
        /// r0: str
        /// r1: maxlen (vsprintf passes UINT32_MAX for this)
        /// r2: format
        /// r3: ap
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int VsprintfInternal
        {
            get
            {
                if (f_vsprintfInternal)
                    return _vsprintfInternal;
                _vsprintfInternal = (int) (119812);
                f_vsprintfInternal = true;
                return _vsprintfInternal;
            }
        }
        private bool f_dseSeCheckTooManyInstances;
        private int _dseSeCheckTooManyInstances;
        public int DseSeCheckTooManyInstances
        {
            get
            {
                if (f_dseSeCheckTooManyInstances)
                    return _dseSeCheckTooManyInstances;
                _dseSeCheckTooManyInstances = (int) (12064);
                f_dseSeCheckTooManyInstances = true;
                return _dseSeCheckTooManyInstances;
            }
        }
        private bool f_dseSeStop;
        private int _dseSeStop;
        public int DseSeStop
        {
            get
            {
                if (f_dseSeStop)
                    return _dseSeStop;
                _dseSeStop = (int) (12980);
                f_dseSeStop = true;
                return _dseSeStop;
            }
        }
        private bool f_gxDisableBankForArm7;
        private int _gxDisableBankForArm7;
        public int GxDisableBankForArm7
        {
            get
            {
                if (f_gxDisableBankForArm7)
                    return _gxDisableBankForArm7;
                _gxDisableBankForArm7 = (int) (45680);
                f_gxDisableBankForArm7 = true;
                return _gxDisableBankForArm7;
            }
        }
        private bool f_dseBgmSetFades;
        private int _dseBgmSetFades;
        public int DseBgmSetFades
        {
            get
            {
                if (f_dseBgmSetFades)
                    return _dseBgmSetFades;
                _dseBgmSetFades = (int) (6756);
                f_dseBgmSetFades = true;
                return _dseBgmSetFades;
            }
        }
        private bool f_memcpyFast;
        private int _memcpyFast;

        /// <summary>
        /// Copies bytes from one buffer to another, similar to memcpy(3). Note that the source/destination buffer parameters swapped relative to the standard memcpy.
        /// 
        /// This function was probably manually implemented by the developers, or was included as part of a library other than libc (the Nitro SDK probably?). See memcpy for what's probably the real libc function.
        /// 
        /// This function is optimized to copy values in 4-byte chunks, properly dealing with pointer alignment.
        /// 
        /// r0: src
        /// r1: dest
        /// r2: n (# bytes)
        /// </summary>
        public int MemcpyFast
        {
            get
            {
                if (f_memcpyFast)
                    return _memcpyFast;
                _memcpyFast = (int) (66544);
                f_memcpyFast = true;
                return _memcpyFast;
            }
        }
        private bool f_dseSynthClearHeldNotes;
        private int _dseSynthClearHeldNotes;
        public int DseSynthClearHeldNotes
        {
            get
            {
                if (f_dseSynthClearHeldNotes)
                    return _dseSynthClearHeldNotes;
                _dseSynthClearHeldNotes = (int) (29412);
                f_dseSynthClearHeldNotes = true;
                return _dseSynthClearHeldNotes;
            }
        }
        private bool f_dseTrackEventWait16;
        private int _dseTrackEventWait16;
        public int DseTrackEventWait16
        {
            get
            {
                if (f_dseTrackEventWait16)
                    return _dseTrackEventWait16;
                _dseTrackEventWait16 = (int) (22660);
                f_dseTrackEventWait16 = true;
                return _dseTrackEventWait16;
            }
        }
        private bool f_dseTrackEventSetBank;
        private int _dseTrackEventSetBank;
        public int DseTrackEventSetBank
        {
            get
            {
                if (f_dseTrackEventSetBank)
                    return _dseTrackEventSetBank;
                _dseTrackEventSetBank = (int) (23176);
                f_dseTrackEventSetBank = true;
                return _dseTrackEventSetBank;
            }
        }
        private bool f_llMul;
        private int _llMul;

        /// <summary>
        /// Implements the multiplication operator for signed long longs.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __multi3 in libgcc.
        /// 
        /// r0: a (low bits)
        /// r1: a (high bits)
        /// r2: b (low bits)
        /// r3: b (high bits)
        /// return: a * b
        /// </summary>
        public int LlMul
        {
            get
            {
                if (f_llMul)
                    return _llMul;
                _llMul = (int) (146860);
                f_llMul = true;
                return _llMul;
            }
        }
        private bool f_gxLoadBg0Char;
        private int _gxLoadBg0Char;
        public int GxLoadBg0Char
        {
            get
            {
                if (f_gxLoadBg0Char)
                    return _gxLoadBg0Char;
                _gxLoadBg0Char = (int) (49336);
                f_gxLoadBg0Char = true;
                return _gxLoadBg0Char;
            }
        }
        private bool f_gxEndLoadObjExtPltt;
        private int _gxEndLoadObjExtPltt;
        public int GxEndLoadObjExtPltt
        {
            get
            {
                if (f_gxEndLoadObjExtPltt)
                    return _gxEndLoadObjExtPltt;
                _gxEndLoadObjExtPltt = (int) (50216);
                f_gxEndLoadObjExtPltt = true;
                return _gxEndLoadObjExtPltt;
            }
        }
        private bool f_dseSequenceReset;
        private int _dseSequenceReset;
        public int DseSequenceReset
        {
            get
            {
                if (f_dseSequenceReset)
                    return _dseSequenceReset;
                _dseSequenceReset = (int) (8596);
                f_dseSequenceReset = true;
                return _dseSequenceReset;
            }
        }
        private bool f_dseVoicePlayNote;
        private int _dseVoicePlayNote;
        public int DseVoicePlayNote
        {
            get
            {
                if (f_dseVoicePlayNote)
                    return _dseVoicePlayNote;
                _dseVoicePlayNote = (int) (32260);
                f_dseVoicePlayNote = true;
                return _dseVoicePlayNote;
            }
        }
        private bool f_gxsEndLoadObjExtPltt;
        private int _gxsEndLoadObjExtPltt;
        public int GxsEndLoadObjExtPltt
        {
            get
            {
                if (f_gxsEndLoadObjExtPltt)
                    return _gxsEndLoadObjExtPltt;
                _gxsEndLoadObjExtPltt = (int) (50396);
                f_gxsEndLoadObjExtPltt = true;
                return _gxsEndLoadObjExtPltt;
            }
        }
        private bool f_dseTrackEventSetEnvelopeReleaseTime;
        private int _dseTrackEventSetEnvelopeReleaseTime;
        public int DseTrackEventSetEnvelopeReleaseTime
        {
            get
            {
                if (f_dseTrackEventSetEnvelopeReleaseTime)
                    return _dseTrackEventSetEnvelopeReleaseTime;
                _dseTrackEventSetEnvelopeReleaseTime = (int) (23736);
                f_dseTrackEventSetEnvelopeReleaseTime = true;
                return _dseTrackEventSetEnvelopeReleaseTime;
            }
        }
        private bool f_mtxLookAt;
        private int _mtxLookAt;
        public int MtxLookAt
        {
            get
            {
                if (f_mtxLookAt)
                    return _mtxLookAt;
                _mtxLookAt = (int) (38736);
                f_mtxLookAt = true;
                return _mtxLookAt;
            }
        }
        private bool f_dseDriverNotifyTick;
        private int _dseDriverNotifyTick;
        public int DseDriverNotifyTick
        {
            get
            {
                if (f_dseDriverNotifyTick)
                    return _dseDriverNotifyTick;
                _dseDriverNotifyTick = (int) (20220);
                f_dseDriverNotifyTick = true;
                return _dseDriverNotifyTick;
            }
        }
        private bool f_drdiv;
        private int _drdiv;

        /// <summary>
        /// The same as _ddiv, but with the parameters reversed.
        /// 
        /// This simply swaps the first and second parameters, then falls through to _ddiv.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// r0: divisor (low bits)
        /// r1: divisor (high bits)
        /// r2: dividend (low bits)
        /// r3: dividend (high bits)
        /// return: dividend / divisor
        /// </summary>
        public int Drdiv
        {
            get
            {
                if (f_drdiv)
                    return _drdiv;
                _drdiv = (int) (147900);
                f_drdiv = true;
                return _drdiv;
            }
        }
        private bool f_llSdiv;
        private int _llSdiv;

        /// <summary>
        /// Implements the division operator for signed long longs.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __divti3 in libgcc.
        /// 
        /// r0: dividend (low bits)
        /// r1: dividend (high bits)
        /// r2: divisor (low bits)
        /// r3: divisor (high bits)
        /// return: dividend / divisor
        /// </summary>
        public int LlSdiv
        {
            get
            {
                if (f_llSdiv)
                    return _llSdiv;
                _llSdiv = (int) (146356);
                f_llSdiv = true;
                return _llSdiv;
            }
        }
        private bool f_llMod;
        private int _llMod;

        /// <summary>
        /// Implements the modulus operator for signed long longs.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// Analogous to __modti3 in libgcc.
        /// 
        /// r0: dividend (low bits)
        /// r1: dividend (high bits)
        /// r2: divisor (low bits)
        /// r3: divisor (high bits)
        /// return: dividend % divisor
        /// </summary>
        public int LlMod
        {
            get
            {
                if (f_llMod)
                    return _llMod;
                _llMod = (int) (146340);
                f_llMod = true;
                return _llMod;
            }
        }
        private bool f_g3XResetMtxStack;
        private int _g3XResetMtxStack;
        public int G3XResetMtxStack
        {
            get
            {
                if (f_g3XResetMtxStack)
                    return _g3XResetMtxStack;
                _g3XResetMtxStack = (int) (47396);
                f_g3XResetMtxStack = true;
                return _g3XResetMtxStack;
            }
        }
        private bool f_arrayCopy16;
        private int _arrayCopy16;

        /// <summary>
        /// Copies an array of 16-bit values to another array of 16-bit values.
        /// 
        /// This is essentially an alternate implementation of Memcpy16, but with a different parameter order.
        /// 
        /// r0: src
        /// r1: dest
        /// r2: len (# bytes)
        /// </summary>
        public int ArrayCopy16
        {
            get
            {
                if (f_arrayCopy16)
                    return _arrayCopy16;
                _arrayCopy16 = (int) (66056);
                f_arrayCopy16 = true;
                return _arrayCopy16;
            }
        }
        private bool f_fileInit;
        private int _fileInit;

        /// <summary>
        /// Initializes a file_stream structure for file I/O.
        /// 
        /// This function must always be called before opening a file.
        /// 
        /// r0: file_stream pointer
        /// </summary>
        public int FileInit
        {
            get
            {
                if (f_fileInit)
                    return _fileInit;
                _fileInit = (int) (78604);
                f_fileInit = true;
                return _fileInit;
            }
        }
        private bool f_sqrtf;
        private int _sqrtf;

        /// <summary>
        /// The sqrtf(3) C library function.
        /// 
        /// r0: x
        /// return: sqrt(x)
        /// </summary>
        public int Sqrtf
        {
            get
            {
                if (f_sqrtf)
                    return _sqrtf;
                _sqrtf = (int) (145468);
                f_sqrtf = true;
                return _sqrtf;
            }
        }
        private bool f_dseChannelSetBank;
        private int _dseChannelSetBank;
        public int DseChannelSetBank
        {
            get
            {
                if (f_dseChannelSetBank)
                    return _dseChannelSetBank;
                _dseChannelSetBank = (int) (31416);
                f_dseChannelSetBank = true;
                return _dseChannelSetBank;
            }
        }
        private bool f_dseTrackEventSetInstrument;
        private int _dseTrackEventSetInstrument;
        public int DseTrackEventSetInstrument
        {
            get
            {
                if (f_dseTrackEventSetInstrument)
                    return _dseTrackEventSetInstrument;
                _dseTrackEventSetInstrument = (int) (23324);
                f_dseTrackEventSetInstrument = true;
                return _dseTrackEventSetInstrument;
            }
        }
        private bool f_dseTrackEventSetEnvelopeAttackTime;
        private int _dseTrackEventSetEnvelopeAttackTime;
        public int DseTrackEventSetEnvelopeAttackTime
        {
            get
            {
                if (f_dseTrackEventSetEnvelopeAttackTime)
                    return _dseTrackEventSetEnvelopeAttackTime;
                _dseTrackEventSetEnvelopeAttackTime = (int) (23592);
                f_dseTrackEventSetEnvelopeAttackTime = true;
                return _dseTrackEventSetEnvelopeAttackTime;
            }
        }
        private bool f_dseSynthResetAllVoiceTimersAndVolumes;
        private int _dseSynthResetAllVoiceTimersAndVolumes;
        public int DseSynthResetAllVoiceTimersAndVolumes
        {
            get
            {
                if (f_dseSynthResetAllVoiceTimersAndVolumes)
                    return _dseSynthResetAllVoiceTimersAndVolumes;
                _dseSynthResetAllVoiceTimersAndVolumes = (int) (29652);
                f_dseSynthResetAllVoiceTimersAndVolumes = true;
                return _dseSynthResetAllVoiceTimersAndVolumes;
            }
        }
        private bool f_tryAppendToSlice;
        private int _tryAppendToSlice;

        /// <summary>
        /// Best-effort append the given data to a slice. If the slice's capacity is reached, any remaining data will be truncated.
        /// 
        /// r0: slice pointer
        /// r1: buffer of data to append
        /// r2: number of bytes in the data buffer
        /// return: true
        /// </summary>
        public int TryAppendToSlice
        {
            get
            {
                if (f_tryAppendToSlice)
                    return _tryAppendToSlice;
                _tryAppendToSlice = (int) (119744);
                f_tryAppendToSlice = true;
                return _tryAppendToSlice;
            }
        }
        private bool f_getDsFirmwareUserSettings;
        private int _getDsFirmwareUserSettings;

        /// <summary>
        /// Gets the user settings of the DS firmware.
        /// 
        /// See https://problemkaputt.de/gbatek.htm#dsfirmwareusersettings
        /// 
        /// r0: user_settings pointer
        /// </summary>
        public int GetDsFirmwareUserSettings
        {
            get
            {
                if (f_getDsFirmwareUserSettings)
                    return _getDsFirmwareUserSettings;
                _getDsFirmwareUserSettings = (int) (63792);
                f_getDsFirmwareUserSettings = true;
                return _getDsFirmwareUserSettings;
            }
        }
        private bool f_initThread;
        private int _initThread;

        /// <summary>
        /// Initializes some fields of the given thread struct.
        /// 
        /// Most notably, thread::flags, thread::function_address_plus_4, thread::stack_pointer_minus_4 and thread::usable_stack_pointer. Also initializes a few more fields with a value of 0.
        /// thread::flags is initialized to 0x1F, unless the address of the function is odd (???), in which case it's initialized to 0x3F.
        /// 
        /// r0: Pointer to the thread to initialize
        /// r1: Pointer to the function the thread will run
        /// r2: Pointer to the start of the thread's stack area - 4
        /// </summary>
        public int InitThread
        {
            get
            {
                if (f_initThread)
                    return _initThread;
                _initThread = (int) (56236);
                f_initThread = true;
                return _initThread;
            }
        }
        private bool f_dseSequenceGetById;
        private int _dseSequenceGetById;
        public int DseSequenceGetById
        {
            get
            {
                if (f_dseSequenceGetById)
                    return _dseSequenceGetById;
                _dseSequenceGetById = (int) (9596);
                f_dseSequenceGetById = true;
                return _dseSequenceGetById;
            }
        }
        private bool f_f2d;
        private int _f2d;

        /// <summary>
        /// Implements the float to double cast operation for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __extendsfdf2 in libgcc.
        /// 
        /// The result is returned in r0 and r1, in accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return).
        /// 
        /// r0: float
        /// return: (double)float
        /// </summary>
        public int F2d
        {
            get
            {
                if (f_f2d)
                    return _f2d;
                _f2d = (int) (144660);
                f_f2d = true;
                return _f2d;
            }
        }
        private bool f_parseDseEvent;
        private int _parseDseEvent;

        /// <summary>
        /// Parses and executes a DSE event for the specified track, if necessary.
        /// 
        /// The function checks the time left before the next event (track_data::event_delay), and parses it if said time is 0.
        /// 
        /// See also https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/
        /// 
        /// r0: Pointer to some struct that seems to hold the state of the audio engine
        /// r1: Pointer to track data
        /// </summary>
        public int ParseDseEvent
        {
            get
            {
                if (f_parseDseEvent)
                    return _parseDseEvent;
                _parseDseEvent = (int) (20812);
                f_parseDseEvent = true;
                return _parseDseEvent;
            }
        }
        private bool f_soundLfoWaveHalfSquareFunc;
        private int _soundLfoWaveHalfSquareFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveHalfSquareFunc
        {
            get
            {
                if (f_soundLfoWaveHalfSquareFunc)
                    return _soundLfoWaveHalfSquareFunc;
                _soundLfoWaveHalfSquareFunc = (int) (37608);
                f_soundLfoWaveHalfSquareFunc = true;
                return _soundLfoWaveHalfSquareFunc;
            }
        }
        private bool f_dseTrackEventDummy1Byte;
        private int _dseTrackEventDummy1Byte;
        public int DseTrackEventDummy1Byte
        {
            get
            {
                if (f_dseTrackEventDummy1Byte)
                    return _dseTrackEventDummy1Byte;
                _dseTrackEventDummy1Byte = (int) (23316);
                f_dseTrackEventDummy1Byte = true;
                return _dseTrackEventDummy1Byte;
            }
        }
        private bool f_dseTrackEventSubLoopBreakOnLastIteration;
        private int _dseTrackEventSubLoopBreakOnLastIteration;
        public int DseTrackEventSubLoopBreakOnLastIteration
        {
            get
            {
                if (f_dseTrackEventSubLoopBreakOnLastIteration)
                    return _dseTrackEventSubLoopBreakOnLastIteration;
                _dseTrackEventSubLoopBreakOnLastIteration = (int) (22976);
                f_dseTrackEventSubLoopBreakOnLastIteration = true;
                return _dseTrackEventSubLoopBreakOnLastIteration;
            }
        }
        private bool f_arrayCopy32;
        private int _arrayCopy32;

        /// <summary>
        /// Copies an array of 32-bit values to another array of 32-bit values.
        /// 
        /// This is essentially an alternate implementation of Memcpy32, but with a different parameter order.
        /// 
        /// r0: src
        /// r1: dest
        /// r2: len (# bytes)
        /// </summary>
        public int ArrayCopy32
        {
            get
            {
                if (f_arrayCopy32)
                    return _arrayCopy32;
                _arrayCopy32 = (int) (66136);
                f_arrayCopy32 = true;
                return _arrayCopy32;
            }
        }
        private bool f_soundEnvelopeRelease;
        private int _soundEnvelopeRelease;

        /// <summary>
        /// r0: Sound envelope pointer
        /// </summary>
        public int SoundEnvelopeRelease
        {
            get
            {
                if (f_soundEnvelopeRelease)
                    return _soundEnvelopeRelease;
                _soundEnvelopeRelease = (int) (36352);
                f_soundEnvelopeRelease = true;
                return _soundEnvelopeRelease;
            }
        }
        private bool f_g3iLookAt;
        private int _g3iLookAt;
        public int G3iLookAt
        {
            get
            {
                if (f_g3iLookAt)
                    return _g3iLookAt;
                _g3iLookAt = (int) (48084);
                f_g3iLookAt = true;
                return _g3iLookAt;
            }
        }
        private bool f_ffix;
        private int _ffix;

        /// <summary>
        /// Implements the float to int cast operation for IEEE 754 floating-point numbers. The output saturates if the input is out of the representable range for the int type.
        /// 
        /// Analogous to __fixsfsi in libgcc.
        /// 
        /// r0: float
        /// return: (int)float
        /// </summary>
        public int Ffix
        {
            get
            {
                if (f_ffix)
                    return _ffix;
                _ffix = (int) (144792);
                f_ffix = true;
                return _ffix;
            }
        }
        private bool f_dseMemAllocate;
        private int _dseMemAllocate;
        public int DseMemAllocate
        {
            get
            {
                if (f_dseMemAllocate)
                    return _dseMemAllocate;
                _dseMemAllocate = (int) (2276);
                f_dseMemAllocate = true;
                return _dseMemAllocate;
            }
        }
        private bool f_memcmp;
        private int _memcmp;

        /// <summary>
        /// The memcmp(3) C library function.
        /// 
        /// r0: s1
        /// r1: s2
        /// r2: n
        /// return: comparison value
        /// </summary>
        public int Memcmp
        {
            get
            {
                if (f_memcmp)
                    return _memcmp;
                _memcmp = (int) (111216);
                f_memcmp = true;
                return _memcmp;
            }
        }
        private bool f_s32DivF;
        private int _s32DivF;

        /// <summary>
        /// Implements the division operator for signed ints.
        /// 
        /// Analogous to __divsi3 in libgcc.
        /// 
        /// The return value is a 64-bit integer, with the quotient (dividend / divisor) in the lower 32 bits and the remainder (dividend % divisor) in the upper 32 bits. In accordance with the Procedure Call Standard for the Arm Architecture (see https://github.com/ARM-software/abi-aa/blob/60a8eb8c55e999d74dac5e368fc9d7e36e38dda4/aapcs32/aapcs32.rst#result-return), this means that the quotient is returned in r0 and the remainder is returned in r1.
        /// 
        /// r0: dividend
        /// r1: divisor
        /// return: (quotient) | (remainder &lt;&lt; 32)
        /// </summary>
        public int S32DivF
        {
            get
            {
                if (f_s32DivF)
                    return _s32DivF;
                _s32DivF = (int) (146892);
                f_s32DivF = true;
                return _s32DivF;
            }
        }
        private bool f_fadd;
        private int _fadd;

        /// <summary>
        /// Implements the addition operator for IEEE 754 floating-point numbers.
        /// 
        /// Analogous to __addsf3 in libgcc.
        /// 
        /// r0: a
        /// r1: b
        /// return: a + b
        /// </summary>
        public int Fadd
        {
            get
            {
                if (f_fadd)
                    return _fadd;
                _fadd = (int) (142304);
                f_fadd = true;
                return _fadd;
            }
        }
        private bool f_dseTrackEventSetNoteDurationMultiplier;
        private int _dseTrackEventSetNoteDurationMultiplier;
        public int DseTrackEventSetNoteDurationMultiplier
        {
            get
            {
                if (f_dseTrackEventSetNoteDurationMultiplier)
                    return _dseTrackEventSetNoteDurationMultiplier;
                _dseTrackEventSetNoteDurationMultiplier = (int) (23768);
                f_dseTrackEventSetNoteDurationMultiplier = true;
                return _dseTrackEventSetNoteDurationMultiplier;
            }
        }
        private bool f_dseSwdInitMainBankFileReader;
        private int _dseSwdInitMainBankFileReader;
        public int DseSwdInitMainBankFileReader
        {
            get
            {
                if (f_dseSwdInitMainBankFileReader)
                    return _dseSwdInitMainBankFileReader;
                _dseSwdInitMainBankFileReader = (int) (5656);
                f_dseSwdInitMainBankFileReader = true;
                return _dseSwdInitMainBankFileReader;
            }
        }
        private bool f_dseSwdMainBankDummyCallback;
        private int _dseSwdMainBankDummyCallback;
        public int DseSwdMainBankDummyCallback
        {
            get
            {
                if (f_dseSwdMainBankDummyCallback)
                    return _dseSwdMainBankDummyCallback;
                _dseSwdMainBankDummyCallback = (int) (3568);
                f_dseSwdMainBankDummyCallback = true;
                return _dseSwdMainBankDummyCallback;
            }
        }
        private bool f_dseVoiceCountNumActiveInChannel;
        private int _dseVoiceCountNumActiveInChannel;
        public int DseVoiceCountNumActiveInChannel
        {
            get
            {
                if (f_dseVoiceCountNumActiveInChannel)
                    return _dseVoiceCountNumActiveInChannel;
                _dseVoiceCountNumActiveInChannel = (int) (35156);
                f_dseVoiceCountNumActiveInChannel = true;
                return _dseVoiceCountNumActiveInChannel;
            }
        }
        private bool f_memset;
        private int _memset;

        /// <summary>
        /// The memset(3) C library function.
        /// 
        /// This is just a wrapper around memset_internal that returns the pointer at the end.
        /// 
        /// r0: s
        /// r1: c (int, but must be a single-byte value)
        /// r2: n
        /// return: s
        /// </summary>
        public int Memset
        {
            get
            {
                if (f_memset)
                    return _memset;
                _memset = (int) (111152);
                f_memset = true;
                return _memset;
            }
        }
        private bool f_setIrqFlag;
        private int _setIrqFlag;

        /// <summary>
        /// Sets the value of the processor's interrupt flag according to the specified parameter.
        /// 
        /// r0: Value to set the flag to (0x80 to set it, which disables interrupts; 0x0 to unset it, which enables interrupts)
        /// return: Old value of cpsr &amp; 0x80 (0x80 if interrupts were disabled, 0x0 if they were enabled)
        /// </summary>
        public int SetIrqFlag
        {
            get
            {
                if (f_setIrqFlag)
                    return _setIrqFlag;
                _setIrqFlag = (int) (63264);
                f_setIrqFlag = true;
                return _setIrqFlag;
            }
        }
        private bool f_fxModS32;
        private int _fxModS32;
        public int FxModS32
        {
            get
            {
                if (f_fxModS32)
                    return _fxModS32;
                _fxModS32 = (int) (39776);
                f_fxModS32 = true;
                return _fxModS32;
            }
        }
        private bool f_waitForever2;
        private int _waitForever2;

        /// <summary>
        /// Calls EnableIrqFlag and WaitForInterrupt in an infinite loop.
        /// 
        /// This is called on fatal errors to hang the program indefinitely.
        /// 
        /// No params.
        /// </summary>
        public int WaitForever2
        {
            get
            {
                if (f_waitForever2)
                    return _waitForever2;
                _waitForever2 = (int) (64328);
                f_waitForever2 = true;
                return _waitForever2;
            }
        }
        private bool f_flushChannels;
        private int _flushChannels;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int FlushChannels
        {
            get
            {
                if (f_flushChannels)
                    return _flushChannels;
                _flushChannels = (int) (17820);
                f_flushChannels = true;
                return _flushChannels;
            }
        }
        private bool f_dseBgmUnload;
        private int _dseBgmUnload;
        public int DseBgmUnload
        {
            get
            {
                if (f_dseBgmUnload)
                    return _dseBgmUnload;
                _dseBgmUnload = (int) (6196);
                f_dseBgmUnload = true;
                return _dseBgmUnload;
            }
        }
        private bool f_dseTrackEventSetBpm2;
        private int _dseTrackEventSetBpm2;
        public int DseTrackEventSetBpm2
        {
            get
            {
                if (f_dseTrackEventSetBpm2)
                    return _dseTrackEventSetBpm2;
                _dseTrackEventSetBpm2 = (int) (23112);
                f_dseTrackEventSetBpm2 = true;
                return _dseTrackEventSetBpm2;
            }
        }
        private bool f_gxLoadBg2Scr;
        private int _gxLoadBg2Scr;
        public int GxLoadBg2Scr
        {
            get
            {
                if (f_gxLoadBg2Scr)
                    return _gxLoadBg2Scr;
                _gxLoadBg2Scr = (int) (49144);
                f_gxLoadBg2Scr = true;
                return _gxLoadBg2Scr;
            }
        }
        private bool f_gxLoadBg0Scr;
        private int _gxLoadBg0Scr;
        public int GxLoadBg0Scr
        {
            get
            {
                if (f_gxLoadBg0Scr)
                    return _gxLoadBg0Scr;
                _gxLoadBg0Scr = (int) (48856);
                f_gxLoadBg0Scr = true;
                return _gxLoadBg0Scr;
            }
        }
        private bool f_dseChannelReleaseNote;
        private int _dseChannelReleaseNote;
        public int DseChannelReleaseNote
        {
            get
            {
                if (f_dseChannelReleaseNote)
                    return _dseChannelReleaseNote;
                _dseChannelReleaseNote = (int) (32200);
                f_dseChannelReleaseNote = true;
                return _dseChannelReleaseNote;
            }
        }
        private bool f_dseTrackEventPanFade;
        private int _dseTrackEventPanFade;
        public int DseTrackEventPanFade
        {
            get
            {
                if (f_dseTrackEventPanFade)
                    return _dseTrackEventPanFade;
                _dseTrackEventPanFade = (int) (26000);
                f_dseTrackEventPanFade = true;
                return _dseTrackEventPanFade;
            }
        }
        private bool f_dseSwdOpenMainBankFileReader;
        private int _dseSwdOpenMainBankFileReader;
        public int DseSwdOpenMainBankFileReader
        {
            get
            {
                if (f_dseSwdOpenMainBankFileReader)
                    return _dseSwdOpenMainBankFileReader;
                _dseSwdOpenMainBankFileReader = (int) (5672);
                f_dseSwdOpenMainBankFileReader = true;
                return _dseSwdOpenMainBankFileReader;
            }
        }
        private bool f_soundEnvelopeSetSlide;
        private int _soundEnvelopeSetSlide;

        /// <summary>
        /// r0: Sound envelope pointer
        /// r1: Target volume
        /// r2: Music duration lookup table index
        /// </summary>
        public int SoundEnvelopeSetSlide
        {
            get
            {
                if (f_soundEnvelopeSetSlide)
                    return _soundEnvelopeSetSlide;
                _soundEnvelopeSetSlide = (int) (35968);
                f_soundEnvelopeSetSlide = true;
                return _soundEnvelopeSetSlide;
            }
        }
        private bool f_g3LoadMtx43;
        private int _g3LoadMtx43;

        /// <summary>
        /// Send the MTX_LOAD_4x3 geometry engine command, through a GXFIFO command. See https://problemkaputt.de/gbatek.htm#ds3dgeometrycommands and https://problemkaputt.de/gbatek.htm#ds3dmatrixloadmultiply for more information.
        /// 
        /// This pops the top of the current matrix stack (https://problemkaputt.de/gbatek.htm#ds3dmatrixstack) and sets it as the engine's &quot;current&quot; matrix. It's commonly preceded by a MTX_PUSH command to populate the matrix stack with a matrix.
        /// 
        /// r0: matrix_4x3 pointer
        /// </summary>
        public int G3LoadMtx43
        {
            get
            {
                if (f_g3LoadMtx43)
                    return _g3LoadMtx43;
                _g3LoadMtx43 = (int) (46772);
                f_g3LoadMtx43 = true;
                return _g3LoadMtx43;
            }
        }
        private bool f_setIrqFiqFlags;
        private int _setIrqFiqFlags;

        /// <summary>
        /// Sets the value of the processor's interrupt flags (i and f) according to the specified parameter.
        /// 
        /// r0: Value to set the flags to (0xC0 to set both flags, 0x80 to set the i flag and clear the f flag, 0x40 to set the f flag and clear the i flag and 0x0 to clear both flags)
        /// return: Old value of cpsr &amp; 0xC0 (contains the previous values of the i and f flags)
        /// </summary>
        public int SetIrqFiqFlags
        {
            get
            {
                if (f_setIrqFiqFlags)
                    return _setIrqFiqFlags;
                _setIrqFiqFlags = (int) (63308);
                f_setIrqFiqFlags = true;
                return _setIrqFiqFlags;
            }
        }
        private bool f_dseTrackEventSetEnvelopeAttackBegin;
        private int _dseTrackEventSetEnvelopeAttackBegin;
        public int DseTrackEventSetEnvelopeAttackBegin
        {
            get
            {
                if (f_dseTrackEventSetEnvelopeAttackBegin)
                    return _dseTrackEventSetEnvelopeAttackBegin;
                _dseTrackEventSetEnvelopeAttackBegin = (int) (23560);
                f_dseTrackEventSetEnvelopeAttackBegin = true;
                return _dseTrackEventSetEnvelopeAttackBegin;
            }
        }
        private bool f_arrayFill32Fast;
        private int _arrayFill32Fast;

        /// <summary>
        /// Does the same thing as ArrayFill32, except the implementation uses an unrolled loop that sets 8 values per iteration, taking advantage of the stmia instruction.
        /// 
        /// r0: value
        /// r1: ptr
        /// r2: len (# bytes)
        /// </summary>
        public int ArrayFill32Fast
        {
            get
            {
                if (f_arrayFill32Fast)
                    return _arrayFill32Fast;
                _arrayFill32Fast = (int) (66176);
                f_arrayFill32Fast = true;
                return _arrayFill32Fast;
            }
        }
        private bool f_memcpy;
        private int _memcpy;

        /// <summary>
        /// The memcpy(3) C library function.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// return: dest
        /// </summary>
        public int Memcpy
        {
            get
            {
                if (f_memcpy)
                    return _memcpy;
                _memcpy = (int) (111044);
                f_memcpy = true;
                return _memcpy;
            }
        }
        private bool f_dseTrackEventTuningDeltaCoarse;
        private int _dseTrackEventTuningDeltaCoarse;
        public int DseTrackEventTuningDeltaCoarse
        {
            get
            {
                if (f_dseTrackEventTuningDeltaCoarse)
                    return _dseTrackEventTuningDeltaCoarse;
                _dseTrackEventTuningDeltaCoarse = (int) (24028);
                f_dseTrackEventTuningDeltaCoarse = true;
                return _dseTrackEventTuningDeltaCoarse;
            }
        }
        private bool f_soundLfoWaveReverseSawFunc;
        private int _soundLfoWaveReverseSawFunc;

        /// <summary>
        /// r0: LFO pointer
        /// return: LFO current output
        /// </summary>
        public int SoundLfoWaveReverseSawFunc
        {
            get
            {
                if (f_soundLfoWaveReverseSawFunc)
                    return _soundLfoWaveReverseSawFunc;
                _soundLfoWaveReverseSawFunc = (int) (37984);
                f_soundLfoWaveReverseSawFunc = true;
                return _soundLfoWaveReverseSawFunc;
            }
        }
        private LibsFunctions m_root;
        private KaitaiStruct m_parent;
        public LibsFunctions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
