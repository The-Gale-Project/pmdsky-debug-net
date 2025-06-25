// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within OVERLAY1 with relative address locations as their values.
    /// </summary>
    public partial class Overlay1Functions : KaitaiStruct
    {
        public static Overlay1Functions FromFile(string fileName)
        {
            return new Overlay1Functions(new KaitaiStream(fileName));
        }

        public Overlay1Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay1Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_createMainMenus = false;
            f_addMainMenuOption = false;
            f_addSubMenuOption = false;
            f_processContinueScreenContents = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_createMainMenus;
        private int _createMainMenus;

        /// <summary>
        /// Prepares the top menu and sub menu, adding the different options that compose them.
        /// 
        /// Contains multiple calls to AddMainMenuOption and AddSubMenuOption. Some of them are conditionally executed depending on which options should be unlocked.
        /// 
        /// No params.
        /// </summary>
        public int CreateMainMenus
        {
            get
            {
                if (f_createMainMenus)
                    return _createMainMenus;
                _createMainMenus = (int) (31684);
                f_createMainMenus = true;
                return _createMainMenus;
            }
        }
        private bool f_addMainMenuOption;
        private int _addMainMenuOption;

        /// <summary>
        /// Adds an option to the top menu.
        /// 
        /// This function is called for each one of the options in the top menu. It loops the MAIN_MENU data field, if the specified action ID does not exist there, the option won't be added.
        /// 
        /// r0: Action ID
        /// r1: True if the option should be enabled, false otherwise
        /// </summary>
        public int AddMainMenuOption
        {
            get
            {
                if (f_addMainMenuOption)
                    return _addMainMenuOption;
                _addMainMenuOption = (int) (32824);
                f_addMainMenuOption = true;
                return _addMainMenuOption;
            }
        }
        private bool f_addSubMenuOption;
        private int _addSubMenuOption;

        /// <summary>
        /// Adds an option to the &quot;Other&quot; submenu on the top menu.
        /// 
        /// This function is called for each one of the options in the submenu. It loops the SUBMENU data field, if the specified action ID does not exist there, the option won't be added.
        /// 
        /// r0: Action ID
        /// r1: True if the option should be enabled, false otherwise
        /// </summary>
        public int AddSubMenuOption
        {
            get
            {
                if (f_addSubMenuOption)
                    return _addSubMenuOption;
                _addSubMenuOption = (int) (33040);
                f_addSubMenuOption = true;
                return _addSubMenuOption;
            }
        }
        private bool f_processContinueScreenContents;
        private int _processContinueScreenContents;

        /// <summary>
        /// Fetches the required data and creates all the strings to display the contents shown in the window
        /// when choosing continue in the main menu.
        /// 
        /// r0: undefined4
        /// </summary>
        public int ProcessContinueScreenContents
        {
            get
            {
                if (f_processContinueScreenContents)
                    return _processContinueScreenContents;
                _processContinueScreenContents = (int) (39380);
                f_processContinueScreenContents = true;
                return _processContinueScreenContents;
            }
        }
        private Overlay1Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay1Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
