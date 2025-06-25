// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// List of functions within OVERLAY9 with relative address locations as their values.
    /// </summary>
    public partial class Overlay9Functions : KaitaiStruct
    {
        public static Overlay9Functions FromFile(string fileName)
        {
            return new Overlay9Functions(new KaitaiStream(fileName));
        }

        public Overlay9Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay9Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_isInputLockBoxActive = false;
            f_closePlaybackControlsMenu = false;
            f_updateJukeboxTrackMenu = false;
            f_isJukeboxTrackMenuActive = false;
            f_closeInputLockBox = false;
            f_updateInputLockBox = false;
            f_createJukeboxTrackMenu = false;
            f_isPlaybackControlsMenuActive = false;
            f_createInputLockBox = false;
            f_createPlaybackControlsMenu = false;
            f_closeJukeboxTrackMenu = false;
            f_updatePlaybackControlsMenu = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_isInputLockBoxActive;
        private int _isInputLockBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of an input lock box is not 4.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsInputLockBoxActive
        {
            get
            {
                if (f_isInputLockBoxActive)
                    return _isInputLockBoxActive;
                _isInputLockBoxActive = (int) (10588);
                f_isInputLockBoxActive = true;
                return _isInputLockBoxActive;
            }
        }
        private bool f_closePlaybackControlsMenu;
        private int _closePlaybackControlsMenu;

        /// <summary>
        /// Closes a window created with CreatePlaybackControlsMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int ClosePlaybackControlsMenu
        {
            get
            {
                if (f_closePlaybackControlsMenu)
                    return _closePlaybackControlsMenu;
                _closePlaybackControlsMenu = (int) (8664);
                f_closePlaybackControlsMenu = true;
                return _closePlaybackControlsMenu;
            }
        }
        private bool f_updateJukeboxTrackMenu;
        private int _updateJukeboxTrackMenu;

        /// <summary>
        /// Window update function for jukebox track menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateJukeboxTrackMenu
        {
            get
            {
                if (f_updateJukeboxTrackMenu)
                    return _updateJukeboxTrackMenu;
                _updateJukeboxTrackMenu = (int) (6492);
                f_updateJukeboxTrackMenu = true;
                return _updateJukeboxTrackMenu;
            }
        }
        private bool f_isJukeboxTrackMenuActive;
        private int _isJukeboxTrackMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a jukebox track menu is something other than 7 or 8.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsJukeboxTrackMenuActive
        {
            get
            {
                if (f_isJukeboxTrackMenuActive)
                    return _isJukeboxTrackMenuActive;
                _isJukeboxTrackMenuActive = (int) (6404);
                f_isJukeboxTrackMenuActive = true;
                return _isJukeboxTrackMenuActive;
            }
        }
        private bool f_closeInputLockBox;
        private int _closeInputLockBox;

        /// <summary>
        /// Closes a window created with InputLockBox.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseInputLockBox
        {
            get
            {
                if (f_closeInputLockBox)
                    return _closeInputLockBox;
                _closeInputLockBox = (int) (10560);
                f_closeInputLockBox = true;
                return _closeInputLockBox;
            }
        }
        private bool f_updateInputLockBox;
        private int _updateInputLockBox;

        /// <summary>
        /// Window update function for input lock boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateInputLockBox
        {
            get
            {
                if (f_updateInputLockBox)
                    return _updateInputLockBox;
                _updateInputLockBox = (int) (10620);
                f_updateInputLockBox = true;
                return _updateInputLockBox;
            }
        }
        private bool f_createJukeboxTrackMenu;
        private int _createJukeboxTrackMenu;

        /// <summary>
        /// Creates a window containing the track selection menu for the Sky Jukebox. Also see struct jukebox_track_menu.
        /// 
        /// If window_params is NULL, JUKEBOX_TRACK_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: simple_menu_id_item struct array, terminated with an item with string_id 0
        /// stack[0]: number of menu items
        /// return: window_id
        /// </summary>
        public int CreateJukeboxTrackMenu
        {
            get
            {
                if (f_createJukeboxTrackMenu)
                    return _createJukeboxTrackMenu;
                _createJukeboxTrackMenu = (int) (5552);
                f_createJukeboxTrackMenu = true;
                return _createJukeboxTrackMenu;
            }
        }
        private bool f_isPlaybackControlsMenuActive;
        private int _isPlaybackControlsMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a playback controls menu is something other than 7 or 8.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsPlaybackControlsMenuActive
        {
            get
            {
                if (f_isPlaybackControlsMenuActive)
                    return _isPlaybackControlsMenuActive;
                _isPlaybackControlsMenuActive = (int) (8828);
                f_isPlaybackControlsMenuActive = true;
                return _isPlaybackControlsMenuActive;
            }
        }
        private bool f_createInputLockBox;
        private int _createInputLockBox;

        /// <summary>
        /// Creates a window containing the &quot;Locked&quot; text when inputs are locked while a song is playing. Also see struct input_lock_box.
        /// 
        /// If window_params is NULL, INPUT_LOCK_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::height is 0, it will default to 2.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: ?
        /// stack[0]: string ID
        /// return: window_id
        /// </summary>
        public int CreateInputLockBox
        {
            get
            {
                if (f_createInputLockBox)
                    return _createInputLockBox;
                _createInputLockBox = (int) (10128);
                f_createInputLockBox = true;
                return _createInputLockBox;
            }
        }
        private bool f_createPlaybackControlsMenu;
        private int _createPlaybackControlsMenu;

        /// <summary>
        /// Creates a window containing the playback controls menu for a selected song. Also see struct playback_controls_menu.
        /// 
        /// If window_params is NULL, PLAYBACK_CONTROLS_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: ?
        /// stack[0]: simple_menu_id_item struct array 1, terminated with an item with string_id 0
        /// stack[1]: simple_menu_id_item struct array 2, terminated with an item with string_id 0
        /// return: window_id
        /// </summary>
        public int CreatePlaybackControlsMenu
        {
            get
            {
                if (f_createPlaybackControlsMenu)
                    return _createPlaybackControlsMenu;
                _createPlaybackControlsMenu = (int) (7832);
                f_createPlaybackControlsMenu = true;
                return _createPlaybackControlsMenu;
            }
        }
        private bool f_closeJukeboxTrackMenu;
        private int _closeJukeboxTrackMenu;

        /// <summary>
        /// Closes a window created with CreateJukeboxTrackMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseJukeboxTrackMenu
        {
            get
            {
                if (f_closeJukeboxTrackMenu)
                    return _closeJukeboxTrackMenu;
                _closeJukeboxTrackMenu = (int) (6348);
                f_closeJukeboxTrackMenu = true;
                return _closeJukeboxTrackMenu;
            }
        }
        private bool f_updatePlaybackControlsMenu;
        private int _updatePlaybackControlsMenu;

        /// <summary>
        /// Window update function for playback controls menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdatePlaybackControlsMenu
        {
            get
            {
                if (f_updatePlaybackControlsMenu)
                    return _updatePlaybackControlsMenu;
                _updatePlaybackControlsMenu = (int) (8964);
                f_updatePlaybackControlsMenu = true;
                return _updatePlaybackControlsMenu;
            }
        }
        private Overlay9Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay9Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
