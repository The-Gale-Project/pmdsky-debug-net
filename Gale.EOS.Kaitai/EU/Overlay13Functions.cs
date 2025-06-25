// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// List of functions within OVERLAY13 with relative address locations as their values.
    /// </summary>
    public partial class Overlay13Functions : KaitaiStruct
    {
        public static Overlay13Functions FromFile(string fileName)
        {
            return new Overlay13Functions(new KaitaiStream(fileName));
        }

        public Overlay13Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay13Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_exitOverlay13 = false;
            f_entryOverlay13 = false;
            f_overlay13SwitchFunctionNa238A1C8 = false;
            f_getPersonality = false;
            f_overlay13SwitchFunctionNa238A574 = false;
            f_waitForNextStep = false;
            f_getOptionStringFromId = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_exitOverlay13;
        private sbyte _exitOverlay13;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public sbyte ExitOverlay13
        {
            get
            {
                if (f_exitOverlay13)
                    return _exitOverlay13;
                _exitOverlay13 = (sbyte) (80);
                f_exitOverlay13 = true;
                return _exitOverlay13;
            }
        }
        private bool f_entryOverlay13;
        private sbyte _entryOverlay13;

        /// <summary>
        /// Main function of this overlay.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public sbyte EntryOverlay13
        {
            get
            {
                if (f_entryOverlay13)
                    return _entryOverlay13;
                _entryOverlay13 = (sbyte) (0);
                f_entryOverlay13 = true;
                return _entryOverlay13;
            }
        }
        private bool f_overlay13SwitchFunctionNa238A1C8;
        private byte _overlay13SwitchFunctionNa238A1C8;

        /// <summary>
        /// Handles the 'return' value from MENU_PERSONALITY_TEST called by scripts. 
        /// 
        /// return: int?
        /// </summary>
        public byte Overlay13SwitchFunctionNa238A1C8
        {
            get
            {
                if (f_overlay13SwitchFunctionNa238A1C8)
                    return _overlay13SwitchFunctionNa238A1C8;
                _overlay13SwitchFunctionNa238A1C8 = (byte) (136);
                f_overlay13SwitchFunctionNa238A1C8 = true;
                return _overlay13SwitchFunctionNa238A1C8;
            }
        }
        private bool f_getPersonality;
        private int _getPersonality;

        /// <summary>
        /// Returns the personality obtained after answering all the questions.
        /// 
        /// The value to return is determined by checking the points obtained for each the personalities and returning the one with the highest amount of points.
        /// 
        /// return: Personality (0-15)
        /// </summary>
        public int GetPersonality
        {
            get
            {
                if (f_getPersonality)
                    return _getPersonality;
                _getPersonality = (int) (7272);
                f_getPersonality = true;
                return _getPersonality;
            }
        }
        private bool f_overlay13SwitchFunctionNa238A574;
        private int _overlay13SwitchFunctionNa238A574;

        /// <summary>
        /// Handles the menus and dialogue boxes associated with the personality quiz.
        /// 
        /// No params.
        /// </summary>
        public int Overlay13SwitchFunctionNa238A574
        {
            get
            {
                if (f_overlay13SwitchFunctionNa238A574)
                    return _overlay13SwitchFunctionNa238A574;
                _overlay13SwitchFunctionNa238A574 = (int) (1076);
                f_overlay13SwitchFunctionNa238A574 = true;
                return _overlay13SwitchFunctionNa238A574;
            }
        }
        private bool f_waitForNextStep;
        private int _waitForNextStep;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: switch_case
        /// </summary>
        public int WaitForNextStep
        {
            get
            {
                if (f_waitForNextStep)
                    return _waitForNextStep;
                _waitForNextStep = (int) (7436);
                f_waitForNextStep = true;
                return _waitForNextStep;
            }
        }
        private bool f_getOptionStringFromId;
        private int _getOptionStringFromId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes. The first parameter and the return value point to the same string (which is passed directly into PreprocessString as the first argument), so I'm not sure why they're named differently... Seems like a mistake?
        /// 
        /// r0: menu_id
        /// r1: option_id
        /// return: process
        /// </summary>
        public int GetOptionStringFromId
        {
            get
            {
                if (f_getOptionStringFromId)
                    return _getOptionStringFromId;
                _getOptionStringFromId = (int) (7344);
                f_getOptionStringFromId = true;
                return _getOptionStringFromId;
            }
        }
        private Overlay13Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay13Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
