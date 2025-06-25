// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class RamData : KaitaiStruct
    {
        public static RamData FromFile(string fileName)
        {
            return new RamData(new KaitaiStream(fileName));
        }

        public RamData(KaitaiStream p__io, KaitaiStruct p__parent = null, RamData p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_rapidSpinBindingRemoval = false;
            f_twineedleHitTracker = false;
            f_floorGenerationStatus = false;
            f_debugSpecialEpisodeNumber = false;
            f_rolloutIceBallMissed = false;
            f_aiThrownItemProbabilities = false;
            f_lockNotifyArray = false;
            f_framesSinceLaunchTimesThree = false;
            f_aiThrownItemDirections = false;
            f_bagItemsPtr = false;
            f_alertAnimationControl = false;
            f_pendingDungeonId = false;
            f_teamName = false;
            f_rolloutIceBallSuccessiveHits = false;
            f_playTimeFrameCounter = false;
            f_pendingStartingFloor = false;
            f_loadedAttackSpriteData = false;
            f_moneyCarried = false;
            f_defaultMemoryArenaMemory = false;
            f_kecleonShopItemsPtr = false;
            f_dispMode = false;
            f_cursor16AnimationControl = false;
            f_cursorAnimationControl = false;
            f_unusedKecleonWaresItems = false;
            f_kaomadoStream = false;
            f_tripleKickSuccessiveHits = false;
            f_touchscreenStatus = false;
            f_scriptVarsValues = false;
            f_alertSpriteId = false;
            f_storageItemQuantities = false;
            f_subBgExtPltt = false;
            f_aiCanAttackInDirection = false;
            f_unusedKecleonShopItems = false;
            f_lastNewMove = false;
            f_aiThrownItemDirectionIsUsed = false;
            f_bagLevel = false;
            f_framesSinceLaunch1 = false;
            f_groundMemoryArena1 = false;
            f_threadInfoStruct = false;
            f_kecleonWaresItems = false;
            f_moveDataTable = false;
            f_mobilityTypeToDungeonMobilityType = false;
            f_teamMemberTable = false;
            f_levelUpDataMonsterId = false;
            f_aiPotentialAttackTargetWeights = false;
            f_multihitFatigueMoveUsed = false;
            f_cursor16SpriteId = false;
            f_bagItems = false;
            f_kecleonWaresItemsPtr = false;
            f_playTimeSeconds = false;
            f_aiPotentialAttackTargetDirections = false;
            f_turningOnTheSpotFlag = false;
            f_enabledVramBanks = false;
            f_levelUpDataDecompressBuffer = false;
            f_storageItems = false;
            f_clrImg = false;
            f_moneyStored = false;
            f_stairsMenuPtr = false;
            f_aiPotentialAttackTargets = false;
            f_cursorSpriteId = false;
            f_audioCommandsBuffer = false;
            f_gxiVramLockId = false;
            f_dungeonColormapPtr = false;
            f_framesSinceLaunch0 = false;
            f_windowList = false;
            f_kecleonShopItems = false;
            f_metronomeNextIndex = false;
            f_multihitMoveSuccessiveHits = false;
            f_dungeonStruct = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_rapidSpinBindingRemoval;
        private byte _rapidSpinBindingRemoval;

        /// <summary>
        /// [Runtime] Appears to be set to true when using Rapid Spin to later remove any binding effects and Leech Seed.
        /// </summary>
        public byte RapidSpinBindingRemoval
        {
            get
            {
                if (f_rapidSpinBindingRemoval)
                    return _rapidSpinBindingRemoval;
                long _pos = m_io.Pos;
                m_io.Seek(3659373);
                _rapidSpinBindingRemoval = m_io.ReadU1();
                m_io.Seek(_pos);
                f_rapidSpinBindingRemoval = true;
                return _rapidSpinBindingRemoval;
            }
        }
        private bool f_twineedleHitTracker;
        private byte _twineedleHitTracker;

        /// <summary>
        /// [Runtime] Appears to be set to true whenever Twineedle hits and deals damage. So that even if the second attack misses, it will still try to poison the target.
        /// </summary>
        public byte TwineedleHitTracker
        {
            get
            {
                if (f_twineedleHitTracker)
                    return _twineedleHitTracker;
                long _pos = m_io.Pos;
                m_io.Seek(3659371);
                _twineedleHitTracker = m_io.ReadU1();
                m_io.Seek(_pos);
                f_twineedleHitTracker = true;
                return _twineedleHitTracker;
            }
        }
        private bool f_floorGenerationStatus;
        private FloorGenerationStatus _floorGenerationStatus;

        /// <summary>
        /// [Runtime] Status data related to generation of the current floor in a dungeon.
        /// 
        /// This data is populated as the dungeon floor is generated.
        /// 
        /// type: struct floor_generation_status
        /// </summary>
        public FloorGenerationStatus FloorGenerationStatus
        {
            get
            {
                if (f_floorGenerationStatus)
                    return _floorGenerationStatus;
                long _pos = m_io.Pos;
                m_io.Seek(3660732);
                _floorGenerationStatus = new FloorGenerationStatus(m_io);
                m_io.Seek(_pos);
                f_floorGenerationStatus = true;
                return _floorGenerationStatus;
            }
        }
        private bool f_debugSpecialEpisodeNumber;
        private SpecialEpisodeType8 _debugSpecialEpisodeNumber;

        /// <summary>
        /// The number of the special episode currently being played.
        /// 
        /// This backs the EXECUTE_SPECIAL_EPISODE_TYPE script variable.
        /// 
        /// type: struct special_episode_type_8
        /// </summary>
        public SpecialEpisodeType8 DebugSpecialEpisodeNumber
        {
            get
            {
                if (f_debugSpecialEpisodeNumber)
                    return _debugSpecialEpisodeNumber;
                long _pos = m_io.Pos;
                m_io.Seek(2801132);
                _debugSpecialEpisodeNumber = new SpecialEpisodeType8(m_io);
                m_io.Seek(_pos);
                f_debugSpecialEpisodeNumber = true;
                return _debugSpecialEpisodeNumber;
            }
        }
        private bool f_rolloutIceBallMissed;
        private byte _rolloutIceBallMissed;

        /// <summary>
        /// [Runtime] Appears to be set to true whenever a hit from Rollout or Ice Ball fails to deal damage.
        /// </summary>
        public byte RolloutIceBallMissed
        {
            get
            {
                if (f_rolloutIceBallMissed)
                    return _rolloutIceBallMissed;
                long _pos = m_io.Pos;
                m_io.Seek(3659369);
                _rolloutIceBallMissed = m_io.ReadU1();
                m_io.Seek(_pos);
                f_rolloutIceBallMissed = true;
                return _rolloutIceBallMissed;
            }
        }
        private bool f_aiThrownItemProbabilities;
        private AiThrownItemProbabilitiesArray _aiThrownItemProbabilities;

        /// <summary>
        /// [Runtime] Used to store the probabilities matching the directions in THROWN_ITEM_DIRECTIONS.
        /// </summary>
        public AiThrownItemProbabilitiesArray AiThrownItemProbabilities
        {
            get
            {
                if (f_aiThrownItemProbabilities)
                    return _aiThrownItemProbabilities;
                long _pos = m_io.Pos;
                m_io.Seek(3659224);
                _aiThrownItemProbabilities = new AiThrownItemProbabilitiesArray(m_io);
                m_io.Seek(_pos);
                f_aiThrownItemProbabilities = true;
                return _aiThrownItemProbabilities;
            }
        }
        private bool f_lockNotifyArray;
        private LockNotifyArrayArray _lockNotifyArray;

        /// <summary>
        /// Used to notify scripts waiting for a certain lock to unlock so they can resume their execution.
        /// 
        /// 1 byte per lock.
        /// </summary>
        public LockNotifyArrayArray LockNotifyArray
        {
            get
            {
                if (f_lockNotifyArray)
                    return _lockNotifyArray;
                long _pos = m_io.Pos;
                m_io.Seek(3299828);
                _lockNotifyArray = new LockNotifyArrayArray(m_io);
                m_io.Seek(_pos);
                f_lockNotifyArray = true;
                return _lockNotifyArray;
            }
        }
        private bool f_framesSinceLaunchTimesThree;
        private uint _framesSinceLaunchTimesThree;

        /// <summary>
        /// Starts at 0 when the game is first launched, and ticks up by 3 per frame while the game is running.
        /// </summary>
        public uint FramesSinceLaunchTimesThree
        {
            get
            {
                if (f_framesSinceLaunchTimesThree)
                    return _framesSinceLaunchTimesThree;
                long _pos = m_io.Pos;
                m_io.Seek(2859780);
                _framesSinceLaunchTimesThree = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_framesSinceLaunchTimesThree = true;
                return _framesSinceLaunchTimesThree;
            }
        }
        private bool f_aiThrownItemDirections;
        private AiThrownItemDirectionsArray _aiThrownItemDirections;

        /// <summary>
        /// [Runtime] Used to store the directions output by GetPossibleAiThrownItemDirections.
        /// </summary>
        public AiThrownItemDirectionsArray AiThrownItemDirections
        {
            get
            {
                if (f_aiThrownItemDirections)
                    return _aiThrownItemDirections;
                long _pos = m_io.Pos;
                m_io.Seek(3659256);
                _aiThrownItemDirections = new AiThrownItemDirectionsArray(m_io);
                m_io.Seek(_pos);
                f_aiThrownItemDirections = true;
                return _aiThrownItemDirections;
            }
        }
        private bool f_bagItemsPtr;
        private Pointer _bagItemsPtr;

        /// <summary>
        /// Pointer to BAG_ITEMS.
        /// </summary>
        public Pointer BagItemsPtr
        {
            get
            {
                if (f_bagItemsPtr)
                    return _bagItemsPtr;
                long _pos = m_io.Pos;
                m_io.Seek(2770152);
                _bagItemsPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_bagItemsPtr = true;
                return _bagItemsPtr;
            }
        }
        private bool f_alertAnimationControl;
        private Pointer _alertAnimationControl;

        /// <summary>
        /// animation_control of &quot;FONT/alter.wan&quot;
        /// </summary>
        public Pointer AlertAnimationControl
        {
            get
            {
                if (f_alertAnimationControl)
                    return _alertAnimationControl;
                long _pos = m_io.Pos;
                m_io.Seek(2799292);
                _alertAnimationControl = new Pointer(m_io);
                m_io.Seek(_pos);
                f_alertAnimationControl = true;
                return _alertAnimationControl;
            }
        }
        private bool f_pendingDungeonId;
        private DungeonId8 _pendingDungeonId;

        /// <summary>
        /// The ID of the selected dungeon when setting off from the overworld.
        /// 
        /// Controls the text and map location during the &quot;map cutscene&quot; just before entering a dungeon, as well as the actual dungeon loaded afterwards.
        /// 
        /// This field is actually part of a larger struct that also contains PENDING_STARTING_FLOOR.
        /// 
        /// type: struct dungeon_id_8
        /// </summary>
        public DungeonId8 PendingDungeonId
        {
            get
            {
                if (f_pendingDungeonId)
                    return _pendingDungeonId;
                long _pos = m_io.Pos;
                m_io.Seek(2801212);
                _pendingDungeonId = new DungeonId8(m_io);
                m_io.Seek(_pos);
                f_pendingDungeonId = true;
                return _pendingDungeonId;
            }
        }
        private bool f_teamName;
        private TeamNameArray _teamName;

        /// <summary>
        /// The team name.
        /// 
        /// A null-terminated string, with a maximum length of 10 (or 5 in JP). Presumably encoded with the ANSI/Shift JIS encoding the game typically uses.
        /// 
        /// This is presumably part of a larger struct, together with other nearby data.
        /// </summary>
        public TeamNameArray TeamName
        {
            get
            {
                if (f_teamName)
                    return _teamName;
                long _pos = m_io.Pos;
                m_io.Seek(2802264);
                _teamName = new TeamNameArray(m_io);
                m_io.Seek(_pos);
                f_teamName = true;
                return _teamName;
            }
        }
        private bool f_rolloutIceBallSuccessiveHits;
        private int _rolloutIceBallSuccessiveHits;

        /// <summary>
        /// [Runtime] Seems to count the number of successive hits by Rollout or Ice Ball.
        /// </summary>
        public int RolloutIceBallSuccessiveHits
        {
            get
            {
                if (f_rolloutIceBallSuccessiveHits)
                    return _rolloutIceBallSuccessiveHits;
                long _pos = m_io.Pos;
                m_io.Seek(3659376);
                _rolloutIceBallSuccessiveHits = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_rolloutIceBallSuccessiveHits = true;
                return _rolloutIceBallSuccessiveHits;
            }
        }
        private bool f_playTimeFrameCounter;
        private byte _playTimeFrameCounter;

        /// <summary>
        /// Counts from 0-59 in a loop, with the play time being incremented by 1 second with each rollover.
        /// </summary>
        public byte PlayTimeFrameCounter
        {
            get
            {
                if (f_playTimeFrameCounter)
                    return _playTimeFrameCounter;
                long _pos = m_io.Pos;
                m_io.Seek(2801624);
                _playTimeFrameCounter = m_io.ReadU1();
                m_io.Seek(_pos);
                f_playTimeFrameCounter = true;
                return _playTimeFrameCounter;
            }
        }
        private bool f_pendingStartingFloor;
        private byte _pendingStartingFloor;

        /// <summary>
        /// The floor number to start from in the dungeon specified by PENDING_DUNGEON_ID.
        /// </summary>
        public byte PendingStartingFloor
        {
            get
            {
                if (f_pendingStartingFloor)
                    return _pendingStartingFloor;
                long _pos = m_io.Pos;
                m_io.Seek(2801213);
                _pendingStartingFloor = m_io.ReadU1();
                m_io.Seek(_pos);
                f_pendingStartingFloor = true;
                return _pendingStartingFloor;
            }
        }
        private bool f_loadedAttackSpriteData;
        private Pointer _loadedAttackSpriteData;

        /// <summary>
        /// [Runtime] Pointer to the dynamically allocated structure relating to the currently loaded attack sprite, in dungeon mode.
        /// 
        /// type: struct loaded_attack_sprite_data*
        /// </summary>
        public Pointer LoadedAttackSpriteData
        {
            get
            {
                if (f_loadedAttackSpriteData)
                    return _loadedAttackSpriteData;
                long _pos = m_io.Pos;
                m_io.Seek(3659180);
                _loadedAttackSpriteData = new Pointer(m_io);
                m_io.Seek(_pos);
                f_loadedAttackSpriteData = true;
                return _loadedAttackSpriteData;
            }
        }
        private bool f_moneyCarried;
        private int _moneyCarried;

        /// <summary>
        /// The amount of money the player is currently carrying.
        /// </summary>
        public int MoneyCarried
        {
            get
            {
                if (f_moneyCarried)
                    return _moneyCarried;
                long _pos = m_io.Pos;
                m_io.Seek(2774264);
                _moneyCarried = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_moneyCarried = true;
                return _moneyCarried;
            }
        }
        private bool f_defaultMemoryArenaMemory;
        private DefaultMemoryArenaMemoryArray _defaultMemoryArenaMemory;

        /// <summary>
        /// The memory region for the default memory arena.
        /// 
        /// The length is defined by DEFAULT_MEMORY_ARENA_SIZE.
        /// 
        /// One mode that uses this region for heap allocations is dungeon mode.
        /// </summary>
        public DefaultMemoryArenaMemoryArray DefaultMemoryArenaMemory
        {
            get
            {
                if (f_defaultMemoryArenaMemory)
                    return _defaultMemoryArenaMemory;
                long _pos = m_io.Pos;
                m_io.Seek(742656);
                _defaultMemoryArenaMemory = new DefaultMemoryArenaMemoryArray(m_io);
                m_io.Seek(_pos);
                f_defaultMemoryArenaMemory = true;
                return _defaultMemoryArenaMemory;
            }
        }
        private bool f_kecleonShopItemsPtr;
        private Pointer _kecleonShopItemsPtr;

        /// <summary>
        /// Pointer to KECLEON_SHOP_ITEMS.
        /// </summary>
        public Pointer KecleonShopItemsPtr
        {
            get
            {
                if (f_kecleonShopItemsPtr)
                    return _kecleonShopItemsPtr;
                long _pos = m_io.Pos;
                m_io.Seek(2774160);
                _kecleonShopItemsPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_kecleonShopItemsPtr = true;
                return _kecleonShopItemsPtr;
            }
        }
        private bool f_dispMode;
        private ushort _dispMode;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public ushort DispMode
        {
            get
            {
                if (f_dispMode)
                    return _dispMode;
                long _pos = m_io.Pos;
                m_io.Seek(2858696);
                _dispMode = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_dispMode = true;
                return _dispMode;
            }
        }
        private bool f_cursor16AnimationControl;
        private Pointer _cursor16AnimationControl;

        /// <summary>
        /// animation_control of &quot;FONT/cursor_16.wan&quot;
        /// </summary>
        public Pointer Cursor16AnimationControl
        {
            get
            {
                if (f_cursor16AnimationControl)
                    return _cursor16AnimationControl;
                long _pos = m_io.Pos;
                m_io.Seek(2799164);
                _cursor16AnimationControl = new Pointer(m_io);
                m_io.Seek(_pos);
                f_cursor16AnimationControl = true;
                return _cursor16AnimationControl;
            }
        }
        private bool f_cursorAnimationControl;
        private Pointer _cursorAnimationControl;

        /// <summary>
        /// animation_control of &quot;FONT/cursor.wan&quot;
        /// </summary>
        public Pointer CursorAnimationControl
        {
            get
            {
                if (f_cursorAnimationControl)
                    return _cursorAnimationControl;
                long _pos = m_io.Pos;
                m_io.Seek(2799040);
                _cursorAnimationControl = new Pointer(m_io);
                m_io.Seek(_pos);
                f_cursorAnimationControl = true;
                return _cursorAnimationControl;
            }
        }
        private bool f_unusedKecleonWaresItems;
        private UnusedKecleonWaresItemsArray _unusedKecleonWaresItems;

        /// <summary>
        /// Seems to be another array like KECLEON_WARES_ITEMS, but don't actually appear to be used by Kecleon Wares.
        /// </summary>
        public UnusedKecleonWaresItemsArray UnusedKecleonWaresItems
        {
            get
            {
                if (f_unusedKecleonWaresItems)
                    return _unusedKecleonWaresItems;
                long _pos = m_io.Pos;
                m_io.Seek(2774248);
                _unusedKecleonWaresItems = new UnusedKecleonWaresItemsArray(m_io);
                m_io.Seek(_pos);
                f_unusedKecleonWaresItems = true;
                return _unusedKecleonWaresItems;
            }
        }
        private bool f_kaomadoStream;
        private FileStream _kaomadoStream;

        /// <summary>
        /// The file stream utilized for all Kaomado portrait loads.
        /// 
        /// type: struct file_stream
        /// </summary>
        public FileStream KaomadoStream
        {
            get
            {
                if (f_kaomadoStream)
                    return _kaomadoStream;
                long _pos = m_io.Pos;
                m_io.Seek(2801136);
                _kaomadoStream = new FileStream(m_io);
                m_io.Seek(_pos);
                f_kaomadoStream = true;
                return _kaomadoStream;
            }
        }
        private bool f_tripleKickSuccessiveHits;
        private int _tripleKickSuccessiveHits;

        /// <summary>
        /// [Runtime] Seems to count the number of successive hits by Triple Kick.
        /// </summary>
        public int TripleKickSuccessiveHits
        {
            get
            {
                if (f_tripleKickSuccessiveHits)
                    return _tripleKickSuccessiveHits;
                long _pos = m_io.Pos;
                m_io.Seek(3659388);
                _tripleKickSuccessiveHits = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_tripleKickSuccessiveHits = true;
                return _tripleKickSuccessiveHits;
            }
        }
        private bool f_touchscreenStatus;
        private TouchscreenStatus _touchscreenStatus;

        /// <summary>
        /// Status of the touchscreen, including the coordinates of the currently pressed position in pixels.
        /// </summary>
        public TouchscreenStatus TouchscreenStatus
        {
            get
            {
                if (f_touchscreenStatus)
                    return _touchscreenStatus;
                long _pos = m_io.Pos;
                m_io.Seek(2768668);
                _touchscreenStatus = new TouchscreenStatus(m_io);
                m_io.Seek(_pos);
                f_touchscreenStatus = true;
                return _touchscreenStatus;
            }
        }
        private bool f_scriptVarsValues;
        private ScriptVarValueTable _scriptVarsValues;

        /// <summary>
        /// The table of game variable values. Its structure is determined by SCRIPT_VARS.
        /// 
        /// Note that with the script variable list defined in SCRIPT_VARS, the used length of this table is actually only 0x2B4. However, the real length of this table is 0x400 based on the game code.
        /// 
        /// type: struct script_var_value_table
        /// </summary>
        public ScriptVarValueTable ScriptVarsValues
        {
            get
            {
                if (f_scriptVarsValues)
                    return _scriptVarsValues;
                long _pos = m_io.Pos;
                m_io.Seek(2800108);
                _scriptVarsValues = new ScriptVarValueTable(m_io);
                m_io.Seek(_pos);
                f_scriptVarsValues = true;
                return _scriptVarsValues;
            }
        }
        private bool f_alertSpriteId;
        private ushort _alertSpriteId;

        /// <summary>
        /// Id of the &quot;FONT/alert.wan&quot; sprite loaded in WAN_TABLE
        /// </summary>
        public ushort AlertSpriteId
        {
            get
            {
                if (f_alertSpriteId)
                    return _alertSpriteId;
                long _pos = m_io.Pos;
                m_io.Seek(2799288);
                _alertSpriteId = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_alertSpriteId = true;
                return _alertSpriteId;
            }
        }
        private bool f_storageItemQuantities;
        private StorageItemQuantitiesArray _storageItemQuantities;

        /// <summary>
        /// Array of 1000 2-byte (unsigned) quantities corresponding to the item IDs in STORAGE_ITEMS.
        /// 
        /// If the corresponding item ID is not a stackable item, the entry in this array is unused, and will be 0.
        /// </summary>
        public StorageItemQuantitiesArray StorageItemQuantities
        {
            get
            {
                if (f_storageItemQuantities)
                    return _storageItemQuantities;
                long _pos = m_io.Pos;
                m_io.Seek(2772158);
                _storageItemQuantities = new StorageItemQuantitiesArray(m_io);
                m_io.Seek(_pos);
                f_storageItemQuantities = true;
                return _storageItemQuantities;
            }
        }
        private bool f_subBgExtPltt;
        private uint _subBgExtPltt;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public uint SubBgExtPltt
        {
            get
            {
                if (f_subBgExtPltt)
                    return _subBgExtPltt;
                long _pos = m_io.Pos;
                m_io.Seek(2858728);
                _subBgExtPltt = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_subBgExtPltt = true;
                return _subBgExtPltt;
            }
        }
        private bool f_aiCanAttackInDirection;
        private AiCanAttackInDirectionArray _aiCanAttackInDirection;

        /// <summary>
        /// [Runtime] Stores whether the AI can use an attack in each direction.
        /// </summary>
        public AiCanAttackInDirectionArray AiCanAttackInDirection
        {
            get
            {
                if (f_aiCanAttackInDirection)
                    return _aiCanAttackInDirection;
                long _pos = m_io.Pos;
                m_io.Seek(3659288);
                _aiCanAttackInDirection = new AiCanAttackInDirectionArray(m_io);
                m_io.Seek(_pos);
                f_aiCanAttackInDirection = true;
                return _aiCanAttackInDirection;
            }
        }
        private bool f_unusedKecleonShopItems;
        private UnusedKecleonShopItemsArray _unusedKecleonShopItems;

        /// <summary>
        /// Seems to be another array like KECLEON_SHOP_ITEMS, but don't actually appear to be used by the Kecleon Shop.
        /// </summary>
        public UnusedKecleonShopItemsArray UnusedKecleonShopItems
        {
            get
            {
                if (f_unusedKecleonShopItems)
                    return _unusedKecleonShopItems;
                long _pos = m_io.Pos;
                m_io.Seek(2774196);
                _unusedKecleonShopItems = new UnusedKecleonShopItemsArray(m_io);
                m_io.Seek(_pos);
                f_unusedKecleonShopItems = true;
                return _unusedKecleonShopItems;
            }
        }
        private bool f_lastNewMove;
        private Move _lastNewMove;

        /// <summary>
        /// Move struct of the last new move introduced when learning a new move. Persists even after the move selection is made in the menu.
        /// 
        /// type: struct move
        /// </summary>
        public Move LastNewMove
        {
            get
            {
                if (f_lastNewMove)
                    return _lastNewMove;
                long _pos = m_io.Pos;
                m_io.Seek(2799500);
                _lastNewMove = new Move(m_io);
                m_io.Seek(_pos);
                f_lastNewMove = true;
                return _lastNewMove;
            }
        }
        private bool f_aiThrownItemDirectionIsUsed;
        private AiThrownItemDirectionIsUsedArray _aiThrownItemDirectionIsUsed;

        /// <summary>
        /// [Runtime] Used in GetPossibleAiThrownItemDirections to indicate whether a certain direction enum value is already being used or not.
        /// </summary>
        public AiThrownItemDirectionIsUsedArray AiThrownItemDirectionIsUsed
        {
            get
            {
                if (f_aiThrownItemDirectionIsUsed)
                    return _aiThrownItemDirectionIsUsed;
                long _pos = m_io.Pos;
                m_io.Seek(3659216);
                _aiThrownItemDirectionIsUsed = new AiThrownItemDirectionIsUsedArray(m_io);
                m_io.Seek(_pos);
                f_aiThrownItemDirectionIsUsed = true;
                return _aiThrownItemDirectionIsUsed;
            }
        }
        private bool f_bagLevel;
        private byte _bagLevel;

        /// <summary>
        /// The player's bag level, which determines the bag capacity. This indexes directly into the BAG_CAPACITY_TABLE in the ARM9 binary.
        /// </summary>
        public byte BagLevel
        {
            get
            {
                if (f_bagLevel)
                    return _bagLevel;
                long _pos = m_io.Pos;
                m_io.Seek(2800284);
                _bagLevel = m_io.ReadU1();
                m_io.Seek(_pos);
                f_bagLevel = true;
                return _bagLevel;
            }
        }
        private bool f_framesSinceLaunch1;
        private uint _framesSinceLaunch1;

        /// <summary>
        /// Starts at 0 when the game is first launched, and continuously ticks up once per frame while the game is running.
        /// </summary>
        public uint FramesSinceLaunch1
        {
            get
            {
                if (f_framesSinceLaunch1)
                    return _framesSinceLaunch1;
                long _pos = m_io.Pos;
                m_io.Seek(2768604);
                _framesSinceLaunch1 = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_framesSinceLaunch1 = true;
                return _framesSinceLaunch1;
            }
        }
        private bool f_groundMemoryArena1;
        private MemArena _groundMemoryArena1;

        /// <summary>
        /// This is a top-level memory arena used for some things in ground mode.
        /// 
        /// It's used for user_flags 8, 15, and 16.
        /// 
        /// Including the allocator metadata, this arena occupies 0x64000 bytes of space.
        /// 
        /// type: struct mem_arena
        /// </summary>
        public MemArena GroundMemoryArena1
        {
            get
            {
                if (f_groundMemoryArena1)
                    return _groundMemoryArena1;
                long _pos = m_io.Pos;
                m_io.Seek(3300096);
                _groundMemoryArena1 = new MemArena(m_io);
                m_io.Seek(_pos);
                f_groundMemoryArena1 = true;
                return _groundMemoryArena1;
            }
        }
        private bool f_threadInfoStruct;
        private ThreadInfo _threadInfoStruct;

        /// <summary>
        /// thread_info struct that contains global state about threads
        /// </summary>
        public ThreadInfo ThreadInfoStruct
        {
            get
            {
                if (f_threadInfoStruct)
                    return _threadInfoStruct;
                long _pos = m_io.Pos;
                m_io.Seek(2858888);
                _threadInfoStruct = new ThreadInfo(m_io);
                m_io.Seek(_pos);
                f_threadInfoStruct = true;
                return _threadInfoStruct;
            }
        }
        private bool f_kecleonWaresItems;
        private KecleonWaresItemsArray _kecleonWaresItems;

        /// <summary>
        /// Array of up to 4 items in Kecleon Wares.
        /// 
        /// If there are fewer than 4 items, the array is expected to be null-terminated.
        /// 
        /// type: struct bulk_item[4]
        /// </summary>
        public KecleonWaresItemsArray KecleonWaresItems
        {
            get
            {
                if (f_kecleonWaresItems)
                    return _kecleonWaresItems;
                long _pos = m_io.Pos;
                m_io.Seek(2774232);
                _kecleonWaresItems = new KecleonWaresItemsArray(m_io);
                m_io.Seek(_pos);
                f_kecleonWaresItems = true;
                return _kecleonWaresItems;
            }
        }
        private bool f_moveDataTable;
        private MoveDataTable _moveDataTable;

        /// <summary>
        /// The move data table loaded directly from /BALANCE/waza_p.bin. See struct move_data_table in the C headers.
        /// 
        /// Pointed to by MOVE_DATA_TABLE_PTR in the ARM 9 binary.
        /// 
        /// type: struct move_data_table
        /// </summary>
        public MoveDataTable MoveDataTable
        {
            get
            {
                if (f_moveDataTable)
                    return _moveDataTable;
                long _pos = m_io.Pos;
                m_io.Seek(2170124);
                _moveDataTable = new MoveDataTable(m_io);
                m_io.Seek(_pos);
                f_moveDataTable = true;
                return _moveDataTable;
            }
        }
        private bool f_mobilityTypeToDungeonMobilityType;
        private MobilityTypeToDungeonMobilityTypeArray _mobilityTypeToDungeonMobilityType;

        /// <summary>
        /// [Runtime] Used by GetMobilityTypeCheckSlip to determine if a monster with a mobility type of MOBILITY_WATER or MOBILITY_LAVA can cross the current dungeon's liquid (lava or water). Only the values at indexes 4 (MOBILITY_LAVA) and 5 (MOBILITY_WATER) are used. If the mobility type can cross the liquid in the current dungeon, the array value at the mobility type's index is MOBILITY_WATER. If not, the array value is MOBILITY_NORMAL.
        /// </summary>
        public MobilityTypeToDungeonMobilityTypeArray MobilityTypeToDungeonMobilityType
        {
            get
            {
                if (f_mobilityTypeToDungeonMobilityType)
                    return _mobilityTypeToDungeonMobilityType;
                long _pos = m_io.Pos;
                m_io.Seek(3659192);
                _mobilityTypeToDungeonMobilityType = new MobilityTypeToDungeonMobilityTypeArray(m_io);
                m_io.Seek(_pos);
                f_mobilityTypeToDungeonMobilityType = true;
                return _mobilityTypeToDungeonMobilityType;
            }
        }
        private bool f_teamMemberTable;
        private TeamMemberTable _teamMemberTable;

        /// <summary>
        /// Table with all team members, persistent information about them, and information about which ones are currently active.
        /// 
        /// See the comments on struct team_member_table for more information.
        /// 
        /// type: struct team_member_table
        /// </summary>
        public TeamMemberTable TeamMemberTable
        {
            get
            {
                if (f_teamMemberTable)
                    return _teamMemberTable;
                long _pos = m_io.Pos;
                m_io.Seek(2803488);
                _teamMemberTable = new TeamMemberTable(m_io);
                m_io.Seek(_pos);
                f_teamMemberTable = true;
                return _teamMemberTable;
            }
        }
        private bool f_levelUpDataMonsterId;
        private MonsterId16 _levelUpDataMonsterId;

        /// <summary>
        /// ID of the monster whose level-up data is currently stored in LEVEL_UP_DATA_DECOMPRESS_BUFFER.
        /// </summary>
        public MonsterId16 LevelUpDataMonsterId
        {
            get
            {
                if (f_levelUpDataMonsterId)
                    return _levelUpDataMonsterId;
                long _pos = m_io.Pos;
                m_io.Seek(2802284);
                _levelUpDataMonsterId = new MonsterId16(m_io);
                m_io.Seek(_pos);
                f_levelUpDataMonsterId = true;
                return _levelUpDataMonsterId;
            }
        }
        private bool f_aiPotentialAttackTargetWeights;
        private AiPotentialAttackTargetWeightsArray _aiPotentialAttackTargetWeights;

        /// <summary>
        /// [Runtime] Stores the targeting weights for each direction the AI can use an attack in. Parallel to AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS and AI_POTENTIAL_ATTACK_TARGETS.
        /// </summary>
        public AiPotentialAttackTargetWeightsArray AiPotentialAttackTargetWeights
        {
            get
            {
                if (f_aiPotentialAttackTargetWeights)
                    return _aiPotentialAttackTargetWeights;
                long _pos = m_io.Pos;
                m_io.Seek(3659304);
                _aiPotentialAttackTargetWeights = new AiPotentialAttackTargetWeightsArray(m_io);
                m_io.Seek(_pos);
                f_aiPotentialAttackTargetWeights = true;
                return _aiPotentialAttackTargetWeights;
            }
        }
        private bool f_multihitFatigueMoveUsed;
        private byte _multihitFatigueMoveUsed;

        /// <summary>
        /// [Runtime] Appears to be set to true whenever a multihit fatigue move deals damage.
        /// </summary>
        public byte MultihitFatigueMoveUsed
        {
            get
            {
                if (f_multihitFatigueMoveUsed)
                    return _multihitFatigueMoveUsed;
                long _pos = m_io.Pos;
                m_io.Seek(3659370);
                _multihitFatigueMoveUsed = m_io.ReadU1();
                m_io.Seek(_pos);
                f_multihitFatigueMoveUsed = true;
                return _multihitFatigueMoveUsed;
            }
        }
        private bool f_cursor16SpriteId;
        private ushort _cursor16SpriteId;

        /// <summary>
        /// Id of the &quot;FONT/cursor_16.wan&quot; sprite loaded in WAN_TABLE
        /// </summary>
        public ushort Cursor16SpriteId
        {
            get
            {
                if (f_cursor16SpriteId)
                    return _cursor16SpriteId;
                long _pos = m_io.Pos;
                m_io.Seek(2799012);
                _cursor16SpriteId = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_cursor16SpriteId = true;
                return _cursor16SpriteId;
            }
        }
        private bool f_bagItems;
        private BagItemsArray _bagItems;

        /// <summary>
        /// Array of item structs within the player's bag.
        /// 
        /// While the game only allows a maximum of 48 items during normal play, it seems to read up to 50 item slots if filled.
        /// 
        /// type: struct item[50]
        /// </summary>
        public BagItemsArray BagItems
        {
            get
            {
                if (f_bagItems)
                    return _bagItems;
                long _pos = m_io.Pos;
                m_io.Seek(2769252);
                _bagItems = new BagItemsArray(m_io);
                m_io.Seek(_pos);
                f_bagItems = true;
                return _bagItems;
            }
        }
        private bool f_kecleonWaresItemsPtr;
        private Pointer _kecleonWaresItemsPtr;

        /// <summary>
        /// Pointer to KECLEON_WARES_ITEMS.
        /// </summary>
        public Pointer KecleonWaresItemsPtr
        {
            get
            {
                if (f_kecleonWaresItemsPtr)
                    return _kecleonWaresItemsPtr;
                long _pos = m_io.Pos;
                m_io.Seek(2774228);
                _kecleonWaresItemsPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_kecleonWaresItemsPtr = true;
                return _kecleonWaresItemsPtr;
            }
        }
        private bool f_playTimeSeconds;
        private uint _playTimeSeconds;

        /// <summary>
        /// The player's total play time in seconds.
        /// </summary>
        public uint PlayTimeSeconds
        {
            get
            {
                if (f_playTimeSeconds)
                    return _playTimeSeconds;
                long _pos = m_io.Pos;
                m_io.Seek(2801620);
                _playTimeSeconds = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_playTimeSeconds = true;
                return _playTimeSeconds;
            }
        }
        private bool f_aiPotentialAttackTargetDirections;
        private AiPotentialAttackTargetDirectionsArray _aiPotentialAttackTargetDirections;

        /// <summary>
        /// [Runtime] Stores the directions that the AI can use an attack in. Parallel to AI_POTENTIAL_ATTACK_TARGET_WEIGHTS and AI_POTENTIAL_ATTACK_TARGETS.
        /// </summary>
        public AiPotentialAttackTargetDirectionsArray AiPotentialAttackTargetDirections
        {
            get
            {
                if (f_aiPotentialAttackTargetDirections)
                    return _aiPotentialAttackTargetDirections;
                long _pos = m_io.Pos;
                m_io.Seek(3659296);
                _aiPotentialAttackTargetDirections = new AiPotentialAttackTargetDirectionsArray(m_io);
                m_io.Seek(_pos);
                f_aiPotentialAttackTargetDirections = true;
                return _aiPotentialAttackTargetDirections;
            }
        }
        private bool f_turningOnTheSpotFlag;
        private byte _turningOnTheSpotFlag;

        /// <summary>
        /// [Runtime] Flag for whether the player is turning on the spot (pressing Y).
        /// </summary>
        public byte TurningOnTheSpotFlag
        {
            get
            {
                if (f_turningOnTheSpotFlag)
                    return _turningOnTheSpotFlag;
                long _pos = m_io.Pos;
                m_io.Seek(3659174);
                _turningOnTheSpotFlag = m_io.ReadU1();
                m_io.Seek(_pos);
                f_turningOnTheSpotFlag = true;
                return _turningOnTheSpotFlag;
            }
        }
        private bool f_enabledVramBanks;
        private VramBanksSet _enabledVramBanks;

        /// <summary>
        /// Bitset of enabled VRAM banks
        /// 
        /// type: vram_banks_set
        /// </summary>
        public VramBanksSet EnabledVramBanks
        {
            get
            {
                if (f_enabledVramBanks)
                    return _enabledVramBanks;
                long _pos = m_io.Pos;
                m_io.Seek(2858700);
                _enabledVramBanks = new VramBanksSet(m_io);
                m_io.Seek(_pos);
                f_enabledVramBanks = true;
                return _enabledVramBanks;
            }
        }
        private bool f_levelUpDataDecompressBuffer;
        private LevelUpDataDecompressBufferArray _levelUpDataDecompressBuffer;

        /// <summary>
        /// Buffer used to stored a monster's decompressed level up data. Used by GetLvlUpEntry.
        /// 
        /// Exact size is a guess (100 levels * 12 bytes per entry = 1200 = 0x4B0).
        /// </summary>
        public LevelUpDataDecompressBufferArray LevelUpDataDecompressBuffer
        {
            get
            {
                if (f_levelUpDataDecompressBuffer)
                    return _levelUpDataDecompressBuffer;
                long _pos = m_io.Pos;
                m_io.Seek(2802288);
                _levelUpDataDecompressBuffer = new LevelUpDataDecompressBufferArray(m_io);
                m_io.Seek(_pos);
                f_levelUpDataDecompressBuffer = true;
                return _levelUpDataDecompressBuffer;
            }
        }
        private bool f_storageItems;
        private StorageItemsArray _storageItems;

        /// <summary>
        /// Array of item IDs in the player's item storage.
        /// 
        /// For stackable items, the quantities are stored elsewhere, in STORAGE_ITEM_QUANTITIES.
        /// 
        /// type: struct item_id_16[1000]
        /// </summary>
        public StorageItemsArray StorageItems
        {
            get
            {
                if (f_storageItems)
                    return _storageItems;
                long _pos = m_io.Pos;
                m_io.Seek(2770158);
                _storageItems = new StorageItemsArray(m_io);
                m_io.Seek(_pos);
                f_storageItems = true;
                return _storageItems;
            }
        }
        private bool f_clrImg;
        private uint _clrImg;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public uint ClrImg
        {
            get
            {
                if (f_clrImg)
                    return _clrImg;
                long _pos = m_io.Pos;
                m_io.Seek(2858756);
                _clrImg = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_clrImg = true;
                return _clrImg;
            }
        }
        private bool f_moneyStored;
        private int _moneyStored;

        /// <summary>
        /// The amount of money the player currently has stored in the Duskull Bank.
        /// </summary>
        public int MoneyStored
        {
            get
            {
                if (f_moneyStored)
                    return _moneyStored;
                long _pos = m_io.Pos;
                m_io.Seek(2774276);
                _moneyStored = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_moneyStored = true;
                return _moneyStored;
            }
        }
        private bool f_stairsMenuPtr;
        private Pointer _stairsMenuPtr;

        /// <summary>
        /// Pointer to the stairs_menu struct during dungeon mode.
        /// </summary>
        public Pointer StairsMenuPtr
        {
            get
            {
                if (f_stairsMenuPtr)
                    return _stairsMenuPtr;
                long _pos = m_io.Pos;
                m_io.Seek(3714756);
                _stairsMenuPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_stairsMenuPtr = true;
                return _stairsMenuPtr;
            }
        }
        private bool f_aiPotentialAttackTargets;
        private AiPotentialAttackTargetsArray _aiPotentialAttackTargets;

        /// <summary>
        /// [Runtime] Stores the target entity for each direction the AI can use an attack in. Parallel to AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS and AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS.
        /// </summary>
        public AiPotentialAttackTargetsArray AiPotentialAttackTargets
        {
            get
            {
                if (f_aiPotentialAttackTargets)
                    return _aiPotentialAttackTargets;
                long _pos = m_io.Pos;
                m_io.Seek(3659336);
                _aiPotentialAttackTargets = new AiPotentialAttackTargetsArray(m_io);
                m_io.Seek(_pos);
                f_aiPotentialAttackTargets = true;
                return _aiPotentialAttackTargets;
            }
        }
        private bool f_cursorSpriteId;
        private ushort _cursorSpriteId;

        /// <summary>
        /// Id of the &quot;FONT/cursor.wan&quot; sprite loaded in WAN_TABLE
        /// </summary>
        public ushort CursorSpriteId
        {
            get
            {
                if (f_cursorSpriteId)
                    return _cursorSpriteId;
                long _pos = m_io.Pos;
                m_io.Seek(2799014);
                _cursorSpriteId = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_cursorSpriteId = true;
                return _cursorSpriteId;
            }
        }
        private bool f_audioCommandsBuffer;
        private AudioCommandsBufferArray _audioCommandsBuffer;

        /// <summary>
        /// Buffer used to store audio commands. 16 entries in total. Seems like entries are removed at some point (maybe after the commands are read or after they finish executing).
        /// </summary>
        public AudioCommandsBufferArray AudioCommandsBuffer
        {
            get
            {
                if (f_audioCommandsBuffer)
                    return _audioCommandsBuffer;
                long _pos = m_io.Pos;
                m_io.Seek(2774416);
                _audioCommandsBuffer = new AudioCommandsBufferArray(m_io);
                m_io.Seek(_pos);
                f_audioCommandsBuffer = true;
                return _audioCommandsBuffer;
            }
        }
        private bool f_gxiVramLockId;
        private ushort _gxiVramLockId;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public ushort GxiVramLockId
        {
            get
            {
                if (f_gxiVramLockId)
                    return _gxiVramLockId;
                long _pos = m_io.Pos;
                m_io.Seek(2858698);
                _gxiVramLockId = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_gxiVramLockId = true;
                return _gxiVramLockId;
            }
        }
        private bool f_dungeonColormapPtr;
        private Pointer _dungeonColormapPtr;

        /// <summary>
        /// Pointer to a colormap used to render colors in a dungeon.
        /// 
        /// The colormap is a list of 4-byte RGB colors of the form {R, G, B, padding}, which the game indexes into when rendering colors. Some weather conditions modify the colormap, which is how the color scheme changes when it's, e.g., raining.
        /// </summary>
        public Pointer DungeonColormapPtr
        {
            get
            {
                if (f_dungeonColormapPtr)
                    return _dungeonColormapPtr;
                long _pos = m_io.Pos;
                m_io.Seek(1812020);
                _dungeonColormapPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_dungeonColormapPtr = true;
                return _dungeonColormapPtr;
            }
        }
        private bool f_framesSinceLaunch0;
        private uint _framesSinceLaunch0;

        /// <summary>
        /// Starts at 0 when the game is first launched, and continuously ticks up once per frame while the game is running.
        /// </summary>
        public uint FramesSinceLaunch0
        {
            get
            {
                if (f_framesSinceLaunch0)
                    return _framesSinceLaunch0;
                long _pos = m_io.Pos;
                m_io.Seek(2768524);
                _framesSinceLaunch0 = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_framesSinceLaunch0 = true;
                return _framesSinceLaunch0;
            }
        }
        private bool f_windowList;
        private WindowList _windowList;

        /// <summary>
        /// Array of all window structs. Newly created window structs are taken from slots in this array.
        /// 
        /// Note that this array isn't strictly ordered in any way. A newly created window will occupy the first available slot. If a window in an early slot is destroyed, windows that are still active in later slots won't be shifted back unless destroyed and recreated.
        /// 
        /// type: struct window_list
        /// </summary>
        public WindowList WindowList
        {
            get
            {
                if (f_windowList)
                    return _windowList;
                long _pos = m_io.Pos;
                m_io.Seek(2789916);
                _windowList = new WindowList(m_io);
                m_io.Seek(_pos);
                f_windowList = true;
                return _windowList;
            }
        }
        private bool f_kecleonShopItems;
        private KecleonShopItemsArray _kecleonShopItems;

        /// <summary>
        /// Array of up to 8 items in the Kecleon Shop.
        /// 
        /// If there are fewer than 8 items, the array is expected to be null-terminated.
        /// 
        /// type: struct bulk_item[8]
        /// </summary>
        public KecleonShopItemsArray KecleonShopItems
        {
            get
            {
                if (f_kecleonShopItems)
                    return _kecleonShopItems;
                long _pos = m_io.Pos;
                m_io.Seek(2774164);
                _kecleonShopItems = new KecleonShopItemsArray(m_io);
                m_io.Seek(_pos);
                f_kecleonShopItems = true;
                return _kecleonShopItems;
            }
        }
        private bool f_metronomeNextIndex;
        private int _metronomeNextIndex;

        /// <summary>
        /// [Runtime] The index into METRONOME_TABLE for the next usage of Metronome.
        /// </summary>
        public int MetronomeNextIndex
        {
            get
            {
                if (f_metronomeNextIndex)
                    return _metronomeNextIndex;
                long _pos = m_io.Pos;
                m_io.Seek(3659400);
                _metronomeNextIndex = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_metronomeNextIndex = true;
                return _metronomeNextIndex;
            }
        }
        private bool f_multihitMoveSuccessiveHits;
        private int _multihitMoveSuccessiveHits;

        /// <summary>
        /// [Runtime] Seems to count the number of successive hits for multihit moves. This is used by Twineedle to check to attempt to apply Poison after the second attack.
        /// </summary>
        public int MultihitMoveSuccessiveHits
        {
            get
            {
                if (f_multihitMoveSuccessiveHits)
                    return _multihitMoveSuccessiveHits;
                long _pos = m_io.Pos;
                m_io.Seek(3659384);
                _multihitMoveSuccessiveHits = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_multihitMoveSuccessiveHits = true;
                return _multihitMoveSuccessiveHits;
            }
        }
        private bool f_dungeonStruct;
        private Dungeon _dungeonStruct;

        /// <summary>
        /// The dungeon context struct used for tons of stuff in dungeon mode. See struct dungeon in the C headers.
        /// 
        /// This struct never seems to be referenced directly, and is instead usually accessed via DUNGEON_PTR in overlay 29.
        /// 
        /// type: struct dungeon
        /// </summary>
        public Dungeon DungeonStruct
        {
            get
            {
                if (f_dungeonStruct)
                    return _dungeonStruct;
                long _pos = m_io.Pos;
                m_io.Seek(1812084);
                _dungeonStruct = new Dungeon(m_io);
                m_io.Seek(_pos);
                f_dungeonStruct = true;
                return _dungeonStruct;
            }
        }
        private RamData m_root;
        private KaitaiStruct m_parent;
        public RamData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
