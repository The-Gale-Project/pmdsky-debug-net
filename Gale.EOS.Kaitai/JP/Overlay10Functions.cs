// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// List of functions within OVERLAY10 with relative address locations as their values.
    /// </summary>
    public partial class Overlay10Functions : KaitaiStruct
    {
        public static Overlay10Functions FromFile(string fileName)
        {
            return new Overlay10Functions(new KaitaiStream(fileName));
        }

        public Overlay10Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay10Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_getMoveAnimation = false;
            f_isInventoryMenuState3 = false;
            f_processTeamStatsLvHp = false;
            f_closeInventoryMenu = false;
            f_isBackgroundTileset = false;
            f_setInventoryMenuState6 = false;
            f_createInventoryMenu = false;
            f_getTrapAnimation = false;
            f_freeTeamStats = false;
            f_getEffectAnimationField0x19 = false;
            f_setInventoryMenuState0 = false;
            f_mainGame = false;
            f_checkInventoryMenuField0x1A0 = false;
            f_initTilesetBuffer = false;
            f_getEffectAnimation = false;
            f_freeMapAndTeam = false;
            f_popInventoryMenuField0x1A3 = false;
            f_getSpecialMonsterMoveAnimation = false;
            f_getItemAnimation2 = false;
            f_processTeamStatsNameGender = false;
            f_updateInventoryMenu = false;
            f_getMoveAnimationSpeed = false;
            f_updateTeamStats = false;
            f_animationHasMoreFrames = false;
            f_drawTeamStats = false;
            f_getItemAnimation1 = false;
            f_isInventoryMenuActive = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_getMoveAnimation;
        private int _getMoveAnimation;

        /// <summary>
        /// Get the move animation corresponding to the given move ID.
        /// 
        /// r0: move_id
        /// return: move animation pointer
        /// </summary>
        public int GetMoveAnimation
        {
            get
            {
                if (f_getMoveAnimation)
                    return _getMoveAnimation;
                _getMoveAnimation = (int) (13368);
                f_getMoveAnimation = true;
                return _getMoveAnimation;
            }
        }
        private bool f_isInventoryMenuState3;
        private int _isInventoryMenuState3;

        /// <summary>
        /// Checks if an inventory menu has a state value of 3.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsInventoryMenuState3
        {
            get
            {
                if (f_isInventoryMenuState3)
                    return _isInventoryMenuState3;
                _isInventoryMenuState3 = (int) (2292);
                f_isInventoryMenuState3 = true;
                return _isInventoryMenuState3;
            }
        }
        private bool f_processTeamStatsLvHp;
        private int _processTeamStatsLvHp;

        /// <summary>
        /// Appears to populate the Lv./HP row in the &quot;Team stats&quot; top screen.
        /// 
        /// r0: index of some kind
        /// </summary>
        public int ProcessTeamStatsLvHp
        {
            get
            {
                if (f_processTeamStatsLvHp)
                    return _processTeamStatsLvHp;
                _processTeamStatsLvHp = (int) (19580);
                f_processTeamStatsLvHp = true;
                return _processTeamStatsLvHp;
            }
        }
        private bool f_closeInventoryMenu;
        private int _closeInventoryMenu;

        /// <summary>
        /// Closes a window created with CreateInventoryMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseInventoryMenu
        {
            get
            {
                if (f_closeInventoryMenu)
                    return _closeInventoryMenu;
                _closeInventoryMenu = (int) (628);
                f_closeInventoryMenu = true;
                return _closeInventoryMenu;
            }
        }
        private bool f_isBackgroundTileset;
        private int _isBackgroundTileset;

        /// <summary>
        /// Given a tileset ID, returns whether it's a background or a regular tileset
        /// 
        /// In particular, returns r0 &gt;= 0xAA
        /// 
        /// r0: Tileset ID
        /// return: True if the tileset ID corresponds to a background, false if it corresponds to a regular tileset
        /// </summary>
        public int IsBackgroundTileset
        {
            get
            {
                if (f_isBackgroundTileset)
                    return _isBackgroundTileset;
                _isBackgroundTileset = (int) (23100);
                f_isBackgroundTileset = true;
                return _isBackgroundTileset;
            }
        }
        private bool f_setInventoryMenuState6;
        private int _setInventoryMenuState6;

        /// <summary>
        /// Sets an inventory menu to state 6.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetInventoryMenuState6
        {
            get
            {
                if (f_setInventoryMenuState6)
                    return _setInventoryMenuState6;
                _setInventoryMenuState6 = (int) (608);
                f_setInventoryMenuState6 = true;
                return _setInventoryMenuState6;
            }
        }
        private bool f_createInventoryMenu;
        private sbyte _createInventoryMenu;

        /// <summary>
        /// Creates a window containing a menu for inventory management. Also see struct inventory_menu.
        /// 
        /// This is used for the Treasure Bag menu, the item information/price window in dungeon Kecleon shops, and possibly other things.
        /// 
        /// If window_params is NULL, INVENTORY_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: some function pointer?
        /// stack[0]: ?
        /// stack[1]: total number of items
        /// stack[2]: number of items per page
        /// stack[3]: ?
        /// return: window_id
        /// </summary>
        public sbyte CreateInventoryMenu
        {
            get
            {
                if (f_createInventoryMenu)
                    return _createInventoryMenu;
                _createInventoryMenu = (sbyte) (0);
                f_createInventoryMenu = true;
                return _createInventoryMenu;
            }
        }
        private bool f_getTrapAnimation;
        private int _getTrapAnimation;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: trap_id
        /// return: trap animation
        /// </summary>
        public int GetTrapAnimation
        {
            get
            {
                if (f_getTrapAnimation)
                    return _getTrapAnimation;
                _getTrapAnimation = (int) (13408);
                f_getTrapAnimation = true;
                return _getTrapAnimation;
            }
        }
        private bool f_freeTeamStats;
        private int _freeTeamStats;

        /// <summary>
        /// Handles the procedure to close the team stats top screen display.
        /// 
        /// First it deletes the sprites, then it closes the portrait boxes and then the text boxes containing the stats for all 4 team members.
        /// 
        /// return: always 1, seems unused
        /// </summary>
        public int FreeTeamStats
        {
            get
            {
                if (f_freeTeamStats)
                    return _freeTeamStats;
                _freeTeamStats = (int) (18664);
                f_freeTeamStats = true;
                return _freeTeamStats;
            }
        }
        private bool f_getEffectAnimationField0x19;
        private int _getEffectAnimationField0x19;

        /// <summary>
        /// Calls GetEffectAnimation and returns field 0x19.
        /// 
        /// r0: anim_id
        /// return: GetEffectAnimation(anim_id)-&gt;field_0x19.
        /// </summary>
        public int GetEffectAnimationField0x19
        {
            get
            {
                if (f_getEffectAnimationField0x19)
                    return _getEffectAnimationField0x19;
                _getEffectAnimationField0x19 = (int) (5176);
                f_getEffectAnimationField0x19 = true;
                return _getEffectAnimationField0x19;
            }
        }
        private bool f_setInventoryMenuState0;
        private int _setInventoryMenuState0;

        /// <summary>
        /// Sets an inventory menu to state 0.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetInventoryMenuState0
        {
            get
            {
                if (f_setInventoryMenuState0)
                    return _setInventoryMenuState0;
                _setInventoryMenuState0 = (int) (588);
                f_setInventoryMenuState0 = true;
                return _setInventoryMenuState0;
            }
        }
        private bool f_mainGame;
        private int _mainGame;

        /// <summary>
        /// Contains several functions that handle switching between ground and dungeon mode. It also handles other situations, like what happens right after exiting a dungeon.
        /// 
        /// The function doesn't get called until the player selects the option to resume a saved game and doesn't return until the player returns to the main menu.
        /// 
        /// r0: End condition code? Seems to control what tasks get run and what transition happens when the dungeon ends
        /// return: return code?
        /// </summary>
        public int MainGame
        {
            get
            {
                if (f_mainGame)
                    return _mainGame;
                _mainGame = (int) (23892);
                f_mainGame = true;
                return _mainGame;
            }
        }
        private bool f_checkInventoryMenuField0x1A0;
        private int _checkInventoryMenuField0x1A0;

        /// <summary>
        /// Checks if inventory_menu::field_0x1a0 is 0.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int CheckInventoryMenuField0x1A0
        {
            get
            {
                if (f_checkInventoryMenuField0x1A0)
                    return _checkInventoryMenuField0x1A0;
                _checkInventoryMenuField0x1A0 = (int) (776);
                f_checkInventoryMenuField0x1A0 = true;
                return _checkInventoryMenuField0x1A0;
            }
        }
        private bool f_initTilesetBuffer;
        private int _initTilesetBuffer;

        /// <summary>
        /// Initializes a buffer that contains data related to tilesets (such as dungeon::unknown_file_buffer_0x102A8).
        /// 
        /// Calls AllocAndLoadFileInPack and DecompressAtNormalVeneer.
        /// 
        /// r0: Pointer to the buffer to init
        /// r1: Tileset ID
        /// r2: Memory allocation flags
        /// </summary>
        public int InitTilesetBuffer
        {
            get
            {
                if (f_initTilesetBuffer)
                    return _initTilesetBuffer;
                _initTilesetBuffer = (int) (23428);
                f_initTilesetBuffer = true;
                return _initTilesetBuffer;
            }
        }
        private bool f_getEffectAnimation;
        private int _getEffectAnimation;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: anim_id
        /// return: effect animation pointer
        /// </summary>
        public int GetEffectAnimation
        {
            get
            {
                if (f_getEffectAnimation)
                    return _getEffectAnimation;
                _getEffectAnimation = (int) (13348);
                f_getEffectAnimation = true;
                return _getEffectAnimation;
            }
        }
        private bool f_freeMapAndTeam;
        private int _freeMapAndTeam;

        /// <summary>
        /// Handles the procedure to close the map and team top screen display.
        /// 
        /// return: always 1, seems unused
        /// </summary>
        public int FreeMapAndTeam
        {
            get
            {
                if (f_freeMapAndTeam)
                    return _freeMapAndTeam;
                _freeMapAndTeam = (int) (19468);
                f_freeMapAndTeam = true;
                return _freeMapAndTeam;
            }
        }
        private bool f_popInventoryMenuField0x1A3;
        private int _popInventoryMenuField0x1A3;

        /// <summary>
        /// Sets inventory_menu::field_0x1a3 to 0 and returns the old value.
        /// 
        /// r0: window_id
        /// return: old value
        /// </summary>
        public int PopInventoryMenuField0x1A3
        {
            get
            {
                if (f_popInventoryMenuField0x1A3)
                    return _popInventoryMenuField0x1A3;
                _popInventoryMenuField0x1A3 = (int) (984);
                f_popInventoryMenuField0x1A3 = true;
                return _popInventoryMenuField0x1A3;
            }
        }
        private bool f_getSpecialMonsterMoveAnimation;
        private int _getSpecialMonsterMoveAnimation;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ent_id
        /// return: special monster move animation pointer
        /// </summary>
        public int GetSpecialMonsterMoveAnimation
        {
            get
            {
                if (f_getSpecialMonsterMoveAnimation)
                    return _getSpecialMonsterMoveAnimation;
                _getSpecialMonsterMoveAnimation = (int) (13388);
                f_getSpecialMonsterMoveAnimation = true;
                return _getSpecialMonsterMoveAnimation;
            }
        }
        private bool f_getItemAnimation2;
        private int _getItemAnimation2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_id
        /// return: second field of the item animation info
        /// </summary>
        public int GetItemAnimation2
        {
            get
            {
                if (f_getItemAnimation2)
                    return _getItemAnimation2;
                _getItemAnimation2 = (int) (13448);
                f_getItemAnimation2 = true;
                return _getItemAnimation2;
            }
        }
        private bool f_processTeamStatsNameGender;
        private int _processTeamStatsNameGender;

        /// <summary>
        /// Appears to populate the name/gender row in the &quot;Team stats&quot; top screen.
        /// 
        /// r0: index of some kind
        /// </summary>
        public int ProcessTeamStatsNameGender
        {
            get
            {
                if (f_processTeamStatsNameGender)
                    return _processTeamStatsNameGender;
                _processTeamStatsNameGender = (int) (19888);
                f_processTeamStatsNameGender = true;
                return _processTeamStatsNameGender;
            }
        }
        private bool f_updateInventoryMenu;
        private int _updateInventoryMenu;

        /// <summary>
        /// Window update function for inventory menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateInventoryMenu
        {
            get
            {
                if (f_updateInventoryMenu)
                    return _updateInventoryMenu;
                _updateInventoryMenu = (int) (1012);
                f_updateInventoryMenu = true;
                return _updateInventoryMenu;
            }
        }
        private bool f_getMoveAnimationSpeed;
        private int _getMoveAnimationSpeed;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move_id
        /// return: anim_ent_ptr (This might be a mistake? It seems to be an integer, not a pointer)
        /// </summary>
        public int GetMoveAnimationSpeed
        {
            get
            {
                if (f_getMoveAnimationSpeed)
                    return _getMoveAnimationSpeed;
                _getMoveAnimationSpeed = (int) (13468);
                f_getMoveAnimationSpeed = true;
                return _getMoveAnimationSpeed;
            }
        }
        private bool f_updateTeamStats;
        private int _updateTeamStats;

        /// <summary>
        /// Handles updating the team stats top screen display.
        /// 
        /// No params.
        /// </summary>
        public int UpdateTeamStats
        {
            get
            {
                if (f_updateTeamStats)
                    return _updateTeamStats;
                _updateTeamStats = (int) (17000);
                f_updateTeamStats = true;
                return _updateTeamStats;
            }
        }
        private bool f_animationHasMoreFrames;
        private int _animationHasMoreFrames;

        /// <summary>
        /// Just a guess. This is called in a loop in PlayEffectAnimation, and the output controls whether or not AdvanceFrame continues to be called.
        /// If the current effect animation's is_non_blocking field is set, the function will return false the very first time it is called.
        /// 
        /// r0: ?
        /// return: whether or not the animation still has more frames left?
        /// </summary>
        public int AnimationHasMoreFrames
        {
            get
            {
                if (f_animationHasMoreFrames)
                    return _animationHasMoreFrames;
                _animationHasMoreFrames = (int) (11912);
                f_animationHasMoreFrames = true;
                return _animationHasMoreFrames;
            }
        }
        private bool f_drawTeamStats;
        private int _drawTeamStats;

        /// <summary>
        /// Handles creating the windows, sprites, etc. for the team stats top screen display.
        /// 
        /// r0: undefined4
        /// r1: int
        /// r2: undefined4
        /// r3: uint32_t
        /// return: undefined4
        /// </summary>
        public int DrawTeamStats
        {
            get
            {
                if (f_drawTeamStats)
                    return _drawTeamStats;
                _drawTeamStats = (int) (16236);
                f_drawTeamStats = true;
                return _drawTeamStats;
            }
        }
        private bool f_getItemAnimation1;
        private int _getItemAnimation1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_id
        /// return: first field of the item animation info
        /// </summary>
        public int GetItemAnimation1
        {
            get
            {
                if (f_getItemAnimation1)
                    return _getItemAnimation1;
                _getItemAnimation1 = (int) (13428);
                f_getItemAnimation1 = true;
                return _getItemAnimation1;
            }
        }
        private bool f_isInventoryMenuActive;
        private int _isInventoryMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of an inventory menu is something other than 7 or 8
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsInventoryMenuActive
        {
            get
            {
                if (f_isInventoryMenuActive)
                    return _isInventoryMenuActive;
                _isInventoryMenuActive = (int) (744);
                f_isInventoryMenuActive = true;
                return _isInventoryMenuActive;
            }
        }
        private Overlay10Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay10Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
