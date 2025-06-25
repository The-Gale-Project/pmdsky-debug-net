// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
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
            f_aiThrownItemDirections = false;
            f_alertAnimationControl = false;
            f_pendingDungeonId = false;
            f_teamName = false;
            f_rolloutIceBallSuccessiveHits = false;
            f_loadedAttackSpriteData = false;
            f_moneyCarried = false;
            f_defaultMemoryArenaMemory = false;
            f_dispMode = false;
            f_cursor16AnimationControl = false;
            f_cursorAnimationControl = false;
            f_kaomadoStream = false;
            f_tripleKickSuccessiveHits = false;
            f_touchscreenStatus = false;
            f_scriptVarsValues = false;
            f_alertSpriteId = false;
            f_subBgExtPltt = false;
            f_aiCanAttackInDirection = false;
            f_lastNewMove = false;
            f_aiThrownItemDirectionIsUsed = false;
            f_groundMemoryArena1 = false;
            f_threadInfoStruct = false;
            f_mobilityTypeToDungeonMobilityType = false;
            f_teamMemberTable = false;
            f_levelUpDataMonsterId = false;
            f_aiPotentialAttackTargetWeights = false;
            f_multihitFatigueMoveUsed = false;
            f_cursor16SpriteId = false;
            f_bagItems = false;
            f_playTimeSeconds = false;
            f_aiPotentialAttackTargetDirections = false;
            f_enabledVramBanks = false;
            f_levelUpDataDecompressBuffer = false;
            f_clrImg = false;
            f_moneyStored = false;
            f_aiPotentialAttackTargets = false;
            f_audioCommandsBuffer = false;
            f_gxiVramLockId = false;
            f_windowList = false;
            f_metronomeNextIndex = false;
            f_multihitMoveSuccessiveHits = false;
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
                m_io.Seek(3661037);
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
                m_io.Seek(3661035);
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
                m_io.Seek(3662396);
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
                m_io.Seek(2804840);
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
                m_io.Seek(3661033);
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
                m_io.Seek(3660888);
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
                m_io.Seek(3302420);
                _lockNotifyArray = new LockNotifyArrayArray(m_io);
                m_io.Seek(_pos);
                f_lockNotifyArray = true;
                return _lockNotifyArray;
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
                m_io.Seek(3660920);
                _aiThrownItemDirections = new AiThrownItemDirectionsArray(m_io);
                m_io.Seek(_pos);
                f_aiThrownItemDirections = true;
                return _aiThrownItemDirections;
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
                m_io.Seek(2803080);
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
                m_io.Seek(2804920);
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
                m_io.Seek(2805972);
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
                m_io.Seek(3661040);
                _rolloutIceBallSuccessiveHits = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_rolloutIceBallSuccessiveHits = true;
                return _rolloutIceBallSuccessiveHits;
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
                m_io.Seek(3660844);
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
                m_io.Seek(2778136);
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
                m_io.Seek(746528);
                _defaultMemoryArenaMemory = new DefaultMemoryArenaMemoryArray(m_io);
                m_io.Seek(_pos);
                f_defaultMemoryArenaMemory = true;
                return _defaultMemoryArenaMemory;
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
                m_io.Seek(2862400);
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
                m_io.Seek(2802952);
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
                m_io.Seek(2802828);
                _cursorAnimationControl = new Pointer(m_io);
                m_io.Seek(_pos);
                f_cursorAnimationControl = true;
                return _cursorAnimationControl;
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
                m_io.Seek(2804844);
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
                m_io.Seek(3661052);
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
                m_io.Seek(2772540);
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
                m_io.Seek(2803816);
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
                m_io.Seek(2803076);
                _alertSpriteId = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_alertSpriteId = true;
                return _alertSpriteId;
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
                m_io.Seek(2862432);
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
                m_io.Seek(3660952);
                _aiCanAttackInDirection = new AiCanAttackInDirectionArray(m_io);
                m_io.Seek(_pos);
                f_aiCanAttackInDirection = true;
                return _aiCanAttackInDirection;
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
                m_io.Seek(2803288);
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
                m_io.Seek(3660880);
                _aiThrownItemDirectionIsUsed = new AiThrownItemDirectionIsUsedArray(m_io);
                m_io.Seek(_pos);
                f_aiThrownItemDirectionIsUsed = true;
                return _aiThrownItemDirectionIsUsed;
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
                m_io.Seek(3302688);
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
                m_io.Seek(2862592);
                _threadInfoStruct = new ThreadInfo(m_io);
                m_io.Seek(_pos);
                f_threadInfoStruct = true;
                return _threadInfoStruct;
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
                m_io.Seek(3660856);
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
                m_io.Seek(2807192);
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
                m_io.Seek(2805988);
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
                m_io.Seek(3660968);
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
                m_io.Seek(3661034);
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
                m_io.Seek(2802800);
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
                m_io.Seek(2773124);
                _bagItems = new BagItemsArray(m_io);
                m_io.Seek(_pos);
                f_bagItems = true;
                return _bagItems;
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
                m_io.Seek(2805328);
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
                m_io.Seek(3660960);
                _aiPotentialAttackTargetDirections = new AiPotentialAttackTargetDirectionsArray(m_io);
                m_io.Seek(_pos);
                f_aiPotentialAttackTargetDirections = true;
                return _aiPotentialAttackTargetDirections;
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
                m_io.Seek(2862404);
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
                m_io.Seek(2805992);
                _levelUpDataDecompressBuffer = new LevelUpDataDecompressBufferArray(m_io);
                m_io.Seek(_pos);
                f_levelUpDataDecompressBuffer = true;
                return _levelUpDataDecompressBuffer;
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
                m_io.Seek(2862460);
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
                m_io.Seek(2778148);
                _moneyStored = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_moneyStored = true;
                return _moneyStored;
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
                m_io.Seek(3661000);
                _aiPotentialAttackTargets = new AiPotentialAttackTargetsArray(m_io);
                m_io.Seek(_pos);
                f_aiPotentialAttackTargets = true;
                return _aiPotentialAttackTargets;
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
                m_io.Seek(2778288);
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
                m_io.Seek(2862402);
                _gxiVramLockId = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_gxiVramLockId = true;
                return _gxiVramLockId;
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
                m_io.Seek(2793704);
                _windowList = new WindowList(m_io);
                m_io.Seek(_pos);
                f_windowList = true;
                return _windowList;
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
                m_io.Seek(3661064);
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
                m_io.Seek(3661048);
                _multihitMoveSuccessiveHits = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_multihitMoveSuccessiveHits = true;
                return _multihitMoveSuccessiveHits;
            }
        }
        private RamData m_root;
        private KaitaiStruct m_parent;
        public RamData M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
