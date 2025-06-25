// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// List of functions within ARM7 with relative address locations as their values.
    /// </summary>
    public partial class Arm7Functions : KaitaiStruct
    {
        public static Arm7Functions FromFile(string fileName)
        {
            return new Arm7Functions(new KaitaiStream(fileName));
        }

        public Arm7Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Arm7Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_u32DivNot0F = false;
            f_u32DivF = false;
            f_enableIrqFiqFlags = false;
            f_enableIrqFlag = false;
            f_hardwareInterrupt = false;
            f_startArm7 = false;
            f_nitroSpMain = false;
            f_getCurrentPlaybackTime = false;
            f_getProcessorMode = false;
            f_clearIeFlag = false;
            f_audioInterrupt = false;
            f_startAutoloadDoneCallbackArm7 = false;
            f_doAutoloadArm7 = false;
            f_returnFromInterrupt = false;
            f_clearIrqFlag = false;
            f_clearImeFlag = false;
            f_s32DivF = false;
            f_setIrqFlag = false;
            f_setIrqFiqFlags = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_u32DivNot0F;
        private int _u32DivNot0F;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
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
                _u32DivNot0F = (int) (61380);
                f_u32DivNot0F = true;
                return _u32DivNot0F;
            }
        }
        private bool f_u32DivF;
        private int _u32DivF;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
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
                _u32DivF = (int) (61372);
                f_u32DivF = true;
                return _u32DivF;
            }
        }
        private bool f_enableIrqFiqFlags;
        private int _enableIrqFiqFlags;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
        /// 
        /// return: Old value of cpsr &amp; 0xC0 (contains the previous values of the i and f flags)
        /// </summary>
        public int EnableIrqFiqFlags
        {
            get
            {
                if (f_enableIrqFiqFlags)
                    return _enableIrqFiqFlags;
                _enableIrqFiqFlags = (int) (24340);
                f_enableIrqFiqFlags = true;
                return _enableIrqFiqFlags;
            }
        }
        private bool f_enableIrqFlag;
        private int _enableIrqFlag;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
        /// 
        /// return: Old value of cpsr &amp; 0x80 (0x80 if interrupts were already disabled, 0x0 if they were enabled)
        /// </summary>
        public int EnableIrqFlag
        {
            get
            {
                if (f_enableIrqFlag)
                    return _enableIrqFlag;
                _enableIrqFlag = (int) (24296);
                f_enableIrqFlag = true;
                return _enableIrqFlag;
            }
        }
        private bool f_hardwareInterrupt;
        private int _hardwareInterrupt;

        /// <summary>
        /// Called whenever a hardware interrupt takes place.
        /// 
        /// Returns immediately if the IME flag is 0 or if none of the devices that requested an interrupt has the corresponding Interrupt Enable flag set.
        /// It searches for the first device that requested an interrupt, clears its Interrupt Request flag, then jumps to the start of the corresponding interrupt function. The return address is manually set to ReturnFromInterrupt.
        /// This function does not return.
        /// 
        /// No params.
        /// </summary>
        public int HardwareInterrupt
        {
            get
            {
                if (f_hardwareInterrupt)
                    return _hardwareInterrupt;
                _hardwareInterrupt = (int) (13936);
                f_hardwareInterrupt = true;
                return _hardwareInterrupt;
            }
        }
        private bool f_startArm7;
        private sbyte _startArm7;

        /// <summary>
        /// The entrypoint for the ARM7 CPU.
        /// 
        /// Handles mapping the ARM7 binary into the various memory areas that the program will be using.
        /// 
        /// Once the memory mapping has been completed, a constant containing the address to NitroSpMain is loaded into a register (r1), and a `bx` branch will jump to NitroSpMain.
        /// 
        /// No params.
        /// </summary>
        public sbyte StartArm7
        {
            get
            {
                if (f_startArm7)
                    return _startArm7;
                _startArm7 = (sbyte) (0);
                f_startArm7 = true;
                return _startArm7;
            }
        }
        private bool f_nitroSpMain;
        private int _nitroSpMain;

        /// <summary>
        /// This main function for the ARM7 subsystem. Contains the main event loop.
        /// 
        /// No params.
        /// </summary>
        public int NitroSpMain
        {
            get
            {
                if (f_nitroSpMain)
                    return _nitroSpMain;
                _nitroSpMain = (int) (488);
                f_nitroSpMain = true;
                return _nitroSpMain;
            }
        }
        private bool f_getCurrentPlaybackTime;
        private int _getCurrentPlaybackTime;

        /// <summary>
        /// Returns the time that the current song has been playing for. Might have a more generic purpose.
        /// 
        /// The time is obtained using a couple of RAM counters and the hardware timers for additional precision.
        /// The game uses this value to know when a given note should stop being played. It doesn't seem to be used to keep track of the
        /// current time instant within the song.
        /// 
        /// return: Playback time. Units unknown.
        /// </summary>
        public int GetCurrentPlaybackTime
        {
            get
            {
                if (f_getCurrentPlaybackTime)
                    return _getCurrentPlaybackTime;
                _getCurrentPlaybackTime = (int) (21508);
                f_getCurrentPlaybackTime = true;
                return _getCurrentPlaybackTime;
            }
        }
        private bool f_getProcessorMode;
        private int _getProcessorMode;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
        /// 
        /// return: cpsr &amp; 0x1f (the cpsr mode bits M4-M0)
        /// </summary>
        public int GetProcessorMode
        {
            get
            {
                if (f_getProcessorMode)
                    return _getProcessorMode;
                _getProcessorMode = (int) (24384);
                f_getProcessorMode = true;
                return _getProcessorMode;
            }
        }
        private bool f_clearIeFlag;
        private int _clearIeFlag;

        /// <summary>
        /// Clears the specified Interrupt Enable flag, which disables interrupts for the specified hardware component.
        /// 
        /// r0: Flag to clear
        /// return: Previous value of the Interrupt Enable flags
        /// </summary>
        public int ClearIeFlag
        {
            get
            {
                if (f_clearIeFlag)
                    return _clearIeFlag;
                _clearIeFlag = (int) (15120);
                f_clearIeFlag = true;
                return _clearIeFlag;
            }
        }
        private bool f_audioInterrupt;
        private int _audioInterrupt;

        /// <summary>
        /// Called when handling a hardware interrupt from the audio system.
        /// 
        /// Its parameter is used to index a list of function pointers. The game then jumps to the read pointer.
        /// 
        /// r0: Index of the function to jump to
        /// </summary>
        public int AudioInterrupt
        {
            get
            {
                if (f_audioInterrupt)
                    return _audioInterrupt;
                _audioInterrupt = (int) (14372);
                f_audioInterrupt = true;
                return _audioInterrupt;
            }
        }
        private bool f_startAutoloadDoneCallbackArm7;
        private int _startAutoloadDoneCallbackArm7;
        public int StartAutoloadDoneCallbackArm7
        {
            get
            {
                if (f_startAutoloadDoneCallbackArm7)
                    return _startAutoloadDoneCallbackArm7;
                _startAutoloadDoneCallbackArm7 = (int) (392);
                f_startAutoloadDoneCallbackArm7 = true;
                return _startAutoloadDoneCallbackArm7;
            }
        }
        private bool f_doAutoloadArm7;
        private int _doAutoloadArm7;
        public int DoAutoloadArm7
        {
            get
            {
                if (f_doAutoloadArm7)
                    return _doAutoloadArm7;
                _doAutoloadArm7 = (int) (280);
                f_doAutoloadArm7 = true;
                return _doAutoloadArm7;
            }
        }
        private bool f_returnFromInterrupt;
        private int _returnFromInterrupt;

        /// <summary>
        /// The execution returns to this function after a hardware interrupt function is run.
        /// 
        /// No params.
        /// </summary>
        public int ReturnFromInterrupt
        {
            get
            {
                if (f_returnFromInterrupt)
                    return _returnFromInterrupt;
                _returnFromInterrupt = (int) (14044);
                f_returnFromInterrupt = true;
                return _returnFromInterrupt;
            }
        }
        private bool f_clearIrqFlag;
        private int _clearIrqFlag;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
        /// 
        /// return: Old value of cpsr &amp; 0x80 (0x80 if interrupts were disabled, 0x0 if they were already enabled)
        /// </summary>
        public int ClearIrqFlag
        {
            get
            {
                if (f_clearIrqFlag)
                    return _clearIrqFlag;
                _clearIrqFlag = (int) (24276);
                f_clearIrqFlag = true;
                return _clearIrqFlag;
            }
        }
        private bool f_clearImeFlag;
        private int _clearImeFlag;

        /// <summary>
        /// Clears the Interrupt Master Enable flag, which disables all hardware interrupts.
        /// 
        /// return: Previous IME value
        /// </summary>
        public int ClearImeFlag
        {
            get
            {
                if (f_clearImeFlag)
                    return _clearImeFlag;
                _clearImeFlag = (int) (15040);
                f_clearImeFlag = true;
                return _clearImeFlag;
            }
        }
        private bool f_s32DivF;
        private int _s32DivF;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
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
                _s32DivF = (int) (60848);
                f_s32DivF = true;
                return _s32DivF;
            }
        }
        private bool f_setIrqFlag;
        private int _setIrqFlag;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
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
                _setIrqFlag = (int) (24316);
                f_setIrqFlag = true;
                return _setIrqFlag;
            }
        }
        private bool f_setIrqFiqFlags;
        private int _setIrqFiqFlags;

        /// <summary>
        /// Copy of the ARM9 function. See arm9.yml for more information.
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
                _setIrqFiqFlags = (int) (24360);
                f_setIrqFiqFlags = true;
                return _setIrqFiqFlags;
            }
        }
        private Arm7Functions m_root;
        private KaitaiStruct m_parent;
        public Arm7Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
