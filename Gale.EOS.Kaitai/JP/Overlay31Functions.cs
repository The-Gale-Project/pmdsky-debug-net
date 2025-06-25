// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// List of functions within OVERLAY31 with relative address locations as their values.
    /// </summary>
    public partial class Overlay31Functions : KaitaiStruct
    {
        public static Overlay31Functions FromFile(string fileName)
        {
            return new Overlay31Functions(new KaitaiStream(fileName));
        }

        public Overlay31Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay31Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_entryOverlay31 = false;
            f_movesMenu = false;
            f_helpMenuLoop = false;
            f_handleMovesMenuWrapper1 = false;
            f_handleMovesMenu = false;
            f_handleStairsMenu = false;
            f_drawDungeonMenuStatusWindow = false;
            f_stairsSubheadingCallback = false;
            f_teamMenu = false;
            f_createStairsMenuState = false;
            f_restMenu = false;
            f_handleMovesMenuWrapper0 = false;
            f_recruitmentSearchMenuLoop = false;
            f_dungeonMenuSwitch = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_entryOverlay31;
        private sbyte _entryOverlay31;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public sbyte EntryOverlay31
        {
            get
            {
                if (f_entryOverlay31)
                    return _entryOverlay31;
                _entryOverlay31 = (sbyte) (0);
                f_entryOverlay31 = true;
                return _entryOverlay31;
            }
        }
        private bool f_movesMenu;
        private int _movesMenu;

        /// <summary>
        /// Displays a menu showing the moves of a monster. Does not return until the menu is closed.
        /// 
        /// This function does not get called when opening the leader's move menu.
        /// 
        /// r0: Pointer to an action struct containing the index of the monster whose moves will be checked in the action_use_idx field.
        /// </summary>
        public int MovesMenu
        {
            get
            {
                if (f_movesMenu)
                    return _movesMenu;
                _movesMenu = (int) (10640);
                f_movesMenu = true;
                return _movesMenu;
            }
        }
        private bool f_helpMenuLoop;
        private int _helpMenuLoop;

        /// <summary>
        /// Called on each frame while the in-dungeon &quot;help&quot; menu is open.
        /// 
        /// The menu is still considered open while one of the help pages is being viewed, so this function keeps being called even after choosing an option.
        /// 
        /// return: int (Actually, this is probably some sort of enum shared by all the MenuLoop functions)
        /// </summary>
        public int HelpMenuLoop
        {
            get
            {
                if (f_helpMenuLoop)
                    return _helpMenuLoop;
                _helpMenuLoop = (int) (27168);
                f_helpMenuLoop = true;
                return _helpMenuLoop;
            }
        }
        private bool f_handleMovesMenuWrapper1;
        private int _handleMovesMenuWrapper1;

        /// <summary>
        /// Sets some field on a struct to 1 and calls HandleMovesMenu.
        /// 
        /// r0: struct pointer, see HandleMovesMenu
        /// r1: See HandleMovesMenu
        /// r2: See HandleMovesMenu
        /// r3: monster index, see HandleMovesMenu
        /// return: bool, see HandleMovesMenu
        /// </summary>
        public int HandleMovesMenuWrapper1
        {
            get
            {
                if (f_handleMovesMenuWrapper1)
                    return _handleMovesMenuWrapper1;
                _handleMovesMenuWrapper1 = (int) (11184);
                f_handleMovesMenuWrapper1 = true;
                return _handleMovesMenuWrapper1;
            }
        }
        private bool f_handleMovesMenu;
        private int _handleMovesMenu;

        /// <summary>
        /// Handles the different options on the moves menu. Does not return until the menu is closed.
        /// 
        /// This function also takes care of updating the fields in the action_data struct it receives when a menu option is chosen.
        /// 
        /// r0: Pointer to some struct that was created by a previous function. Contains a pointer to the monster whose moves are being displayed at offset 0x0.
        /// r1: ?
        /// r2: ?
        /// r3: Index of the monster whose moves are going to be displayed on the menu. Unused.
        /// return: True if the menu was closed without selecting anything, false if an option was chosen.
        /// </summary>
        public int HandleMovesMenu
        {
            get
            {
                if (f_handleMovesMenu)
                    return _handleMovesMenu;
                _handleMovesMenu = (int) (11220);
                f_handleMovesMenu = true;
                return _handleMovesMenu;
            }
        }
        private bool f_handleStairsMenu;
        private int _handleStairsMenu;

        /// <summary>
        /// Handles displaying the stairs menu and is called on each frame while it is open, also updating the leader's action fields.
        /// 
        /// Uses a switch statement based on the state field in stairs_menu to determine what actions to take.
        /// 
        /// return: int
        /// </summary>
        public int HandleStairsMenu
        {
            get
            {
                if (f_handleStairsMenu)
                    return _handleStairsMenu;
                _handleStairsMenu = (int) (1948);
                f_handleStairsMenu = true;
                return _handleStairsMenu;
            }
        }
        private bool f_drawDungeonMenuStatusWindow;
        private sbyte _drawDungeonMenuStatusWindow;

        /// <summary>
        /// Draws the contents shown in the main dungeon menu status window showing the player's belly, money, play time, etc.
        /// 
        /// r0: int
        /// </summary>
        public sbyte DrawDungeonMenuStatusWindow
        {
            get
            {
                if (f_drawDungeonMenuStatusWindow)
                    return _drawDungeonMenuStatusWindow;
                _drawDungeonMenuStatusWindow = (sbyte) (68);
                f_drawDungeonMenuStatusWindow = true;
                return _drawDungeonMenuStatusWindow;
            }
        }
        private bool f_stairsSubheadingCallback;
        private int _stairsSubheadingCallback;

        /// <summary>
        /// Callback function passed to CreateAdvancedTextBox for creating the subheading for the stairs menu.
        /// 
        /// r0: window_id
        /// </summary>
        public int StairsSubheadingCallback
        {
            get
            {
                if (f_stairsSubheadingCallback)
                    return _stairsSubheadingCallback;
                _stairsSubheadingCallback = (int) (1864);
                f_stairsSubheadingCallback = true;
                return _stairsSubheadingCallback;
            }
        }
        private bool f_teamMenu;
        private int _teamMenu;

        /// <summary>
        /// Called when the in-dungeon &quot;team&quot; menu is open. Does not return until the menu is closed.
        /// 
        /// Note that selecting certain options in this menu (such as viewing the details or the moves of a pokémon) counts as switching to a different menu, which causes the function to return.
        /// 
        /// r0: Pointer to the leader's entity struct
        /// return: ?
        /// </summary>
        public int TeamMenu
        {
            get
            {
                if (f_teamMenu)
                    return _teamMenu;
                _teamMenu = (int) (18472);
                f_teamMenu = true;
                return _teamMenu;
            }
        }
        private bool f_createStairsMenuState;
        private int _createStairsMenuState;

        /// <summary>
        /// Called when the leader steps on any stairs tile (regular, warp zone, rescue point, hidden stairs).
        /// 
        /// Allocates a stairs_menu struct on the heap with information for HandleStairsMenu, which will be pointed to by STAIRS_MENU_PTR.
        /// 
        /// r0: Entity pointer (in practice, always the leader)
        /// </summary>
        public int CreateStairsMenuState
        {
            get
            {
                if (f_createStairsMenuState)
                    return _createStairsMenuState;
                _createStairsMenuState = (int) (1716);
                f_createStairsMenuState = true;
                return _createStairsMenuState;
            }
        }
        private bool f_restMenu;
        private int _restMenu;

        /// <summary>
        /// Called when the in-dungeon &quot;rest&quot; menu is open. Does not return until the menu is closed.
        /// 
        /// No params.
        /// </summary>
        public int RestMenu
        {
            get
            {
                if (f_restMenu)
                    return _restMenu;
                _restMenu = (int) (24396);
                f_restMenu = true;
                return _restMenu;
            }
        }
        private bool f_handleMovesMenuWrapper0;
        private int _handleMovesMenuWrapper0;

        /// <summary>
        /// Sets some field on a struct to 0 and calls HandleMovesMenu.
        /// 
        /// r0: struct pointer, see HandleMovesMenu
        /// r1: See HandleMovesMenu
        /// r2: See HandleMovesMenu
        /// r3: monster index, see HandleMovesMenu
        /// return: bool, see HandleMovesMenu
        /// </summary>
        public int HandleMovesMenuWrapper0
        {
            get
            {
                if (f_handleMovesMenuWrapper0)
                    return _handleMovesMenuWrapper0;
                _handleMovesMenuWrapper0 = (int) (11148);
                f_handleMovesMenuWrapper0 = true;
                return _handleMovesMenuWrapper0;
            }
        }
        private bool f_recruitmentSearchMenuLoop;
        private int _recruitmentSearchMenuLoop;

        /// <summary>
        /// Called on each frame while the in-dungeon &quot;recruitment search&quot; menu is open.
        /// 
        /// return: int (Actually, this is probably some sort of enum shared by all the MenuLoop functions)
        /// </summary>
        public int RecruitmentSearchMenuLoop
        {
            get
            {
                if (f_recruitmentSearchMenuLoop)
                    return _recruitmentSearchMenuLoop;
                _recruitmentSearchMenuLoop = (int) (25564);
                f_recruitmentSearchMenuLoop = true;
                return _recruitmentSearchMenuLoop;
            }
        }
        private bool f_dungeonMenuSwitch;
        private int _dungeonMenuSwitch;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: appears to be an index of some sort, probably the menu index based on the function name?
        /// </summary>
        public int DungeonMenuSwitch
        {
            get
            {
                if (f_dungeonMenuSwitch)
                    return _dungeonMenuSwitch;
                _dungeonMenuSwitch = (int) (672);
                f_dungeonMenuSwitch = true;
                return _dungeonMenuSwitch;
            }
        }
        private Overlay31Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay31Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
