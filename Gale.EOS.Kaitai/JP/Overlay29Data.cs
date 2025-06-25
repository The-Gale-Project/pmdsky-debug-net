// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{
    public partial class Overlay29Data : KaitaiStruct
    {
        public static Overlay29Data FromFile(string fileName)
        {
            return new Overlay29Data(new KaitaiStream(fileName));
        }

        public Overlay29Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay29Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_damageFormulaMaxBase = false;
            f_typeDamageNegatingExclusiveItemEffects = false;
            f_directionalBitMasks5 = false;
            f_topScreenStatusPtr = false;
            f_loadedAttackSpriteFileIndex = false;
            f_cherrimSunshineFormFemaleId = false;
            f_rolloutDamageMultTable = false;
            f_damageMultiplier15 = false;
            f_twoTurnStatuses = false;
            f_exclItemEffectsWeatherNoStatus = false;
            f_directionalBitMasks2 = false;
            f_defaultTile = false;
            f_judgmentMoveId = false;
            f_aiThrownItemActionChoiceCount = false;
            f_kecleonFemaleId = false;
            f_statusIconArrayLeechSeed = false;
            f_statusIconArraySureShot = false;
            f_statusIconArraySleep = false;
            f_statusIconArrayLongToss = false;
            f_regularAttackMoveId = false;
            f_exclItemEffectsWeatherMoveSpeedBoost = false;
            f_leaderPtr = false;
            f_exclItemEffectsWeatherAtkSpeedBoost = false;
            f_positionDisplacementToDirection = false;
            f_displacementsWithin3 = false;
            f_hiddenStairsSpawnBlocked = false;
            f_statusIconArrayCringe = false;
            f_cloudyDamageMultiplier = false;
            f_fixedRoomItemSpawnTable = false;
            f_deoxysSpeedId = false;
            f_statusIconArrayReflect = false;
            f_itemCategoryActions = false;
            f_monsterTreatmentData = false;
            f_solidRockMultiplier = false;
            f_statusIconArrayFreeze = false;
            f_gummiLikeStringIds = false;
            f_cherrimSunshineFormMaleId = false;
            f_bellyDrainInWallsThousandths = false;
            f_gummiIqStringIds = false;
            f_fixedRoomTileSpawnTable = false;
            f_giratinaAlteredId = false;
            f_displacementsWithin2SmallestFirst = false;
            f_castformNormalFormMaleId = false;
            f_statusIconArrayBlinded = false;
            f_statusIconArrayMagnetRise = false;
            f_directionalBitMasks3 = false;
            f_castformNormalFormFemaleId = false;
            f_directionalBitMasks4 = false;
            f_statusIconArrayInvisible = false;
            f_cornerCardinalNeighborIsOpen = false;
            f_damageMultiplier2 = false;
            f_treasureBox1ItemIds = false;
            f_fixedRoomRevisitOverrides = false;
            f_fixedRoomMonsterSpawnTable = false;
            f_bellyLostPerTurn = false;
            f_directionsXy = false;
            f_displacementsWithin2LargestFirst = false;
            f_spatkStatIdx = false;
            f_punishmentMoveId = false;
            f_statusIconArrayMiracleEye = false;
            f_dungeonPtr = false;
            f_directionalBitMasks1 = false;
            f_dungeonPrngStateSecondaryValues = false;
            f_cherrimOvercastFormFemaleId = false;
            f_deoxysAttackId = false;
            f_mapColorTable = false;
            f_damageFormulaMinBase = false;
            f_directionalBitMasks0 = false;
            f_damageStringIds = false;
            f_fixedRoomDataPtr = false;
            f_kecleonMaleId = false;
            f_fractionalTurnSequence = false;
            f_statusIconArrayBide = false;
            f_dungeonFadesPtr = false;
            f_dungeonPrngState = false;
            f_bellyDrainInWallsInt = false;
            f_twoTurnMovesAndStatuses = false;
            f_exclItemEffectsEvasionBoost = false;
            f_statusIconArrayBurn = false;
            f_fixedRoomEntitySpawnTable = false;
            f_statusIconArrayCurse = false;
            f_atkStatIdx = false;
            f_attackSpriteBufferSize = false;
            f_statusIconArrayMuzzled = false;
            f_damageMultiplier05 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_damageFormulaMaxBase;
        private Fx6416 _damageFormulaMaxBase;

        /// <summary>
        /// The maximum value of the base damage formula (after DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER application, if relevant), as a 64-bit binary fixed-point number with 16 fraction bits (999).
        /// </summary>
        public Fx6416 DamageFormulaMaxBase
        {
            get
            {
                if (f_damageFormulaMaxBase)
                    return _damageFormulaMaxBase;
                long _pos = m_io.Pos;
                m_io.Seek(483852);
                _damageFormulaMaxBase = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_damageFormulaMaxBase = true;
                return _damageFormulaMaxBase;
            }
        }
        private bool f_typeDamageNegatingExclusiveItemEffects;
        private TypeDamageNegatingExclusiveItemEffectsArray _typeDamageNegatingExclusiveItemEffects;

        /// <summary>
        /// List of exclusive item effects that negate damage of a certain type, terminated by a TYPE_NEUTRAL entry.
        /// 
        /// type: struct damage_negating_exclusive_eff_entry[28]
        /// </summary>
        public TypeDamageNegatingExclusiveItemEffectsArray TypeDamageNegatingExclusiveItemEffects
        {
            get
            {
                if (f_typeDamageNegatingExclusiveItemEffects)
                    return _typeDamageNegatingExclusiveItemEffects;
                long _pos = m_io.Pos;
                m_io.Seek(483908);
                _typeDamageNegatingExclusiveItemEffects = new TypeDamageNegatingExclusiveItemEffectsArray(m_io);
                m_io.Seek(_pos);
                f_typeDamageNegatingExclusiveItemEffects = true;
                return _typeDamageNegatingExclusiveItemEffects;
            }
        }
        private bool f_directionalBitMasks5;
        private DirectionalBitMasksArray _directionalBitMasks5;

        /// <summary>
        /// An array of one-hot bit masks corresponding to each direction_id. Used alongside tile-&gt;walkable_neighbor_flags to determine whether it's possible to move to a tile.
        /// </summary>
        public DirectionalBitMasksArray DirectionalBitMasks5
        {
            get
            {
                if (f_directionalBitMasks5)
                    return _directionalBitMasks5;
                long _pos = m_io.Pos;
                m_io.Seek(483640);
                _directionalBitMasks5 = new DirectionalBitMasksArray(m_io);
                m_io.Seek(_pos);
                f_directionalBitMasks5 = true;
                return _directionalBitMasks5;
            }
        }
        private bool f_topScreenStatusPtr;
        private Pointer _topScreenStatusPtr;

        /// <summary>
        /// [Runtime] Pointer for struct for handling the status of the top screen in dungeon mode.
        /// 
        /// type: struct top_screen_status
        /// </summary>
        public Pointer TopScreenStatusPtr
        {
            get
            {
                if (f_topScreenStatusPtr)
                    return _topScreenStatusPtr;
                long _pos = m_io.Pos;
                m_io.Seek(487156);
                _topScreenStatusPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_topScreenStatusPtr = true;
                return _topScreenStatusPtr;
            }
        }
        private bool f_loadedAttackSpriteFileIndex;
        private ushort _loadedAttackSpriteFileIndex;

        /// <summary>
        /// [Runtime] The file index of the currently loaded attack sprite.
        /// 
        /// type: uint16_t
        /// </summary>
        public ushort LoadedAttackSpriteFileIndex
        {
            get
            {
                if (f_loadedAttackSpriteFileIndex)
                    return _loadedAttackSpriteFileIndex;
                long _pos = m_io.Pos;
                m_io.Seek(487244);
                _loadedAttackSpriteFileIndex = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_loadedAttackSpriteFileIndex = true;
                return _loadedAttackSpriteFileIndex;
            }
        }
        private bool f_cherrimSunshineFormFemaleId;
        private MonsterId _cherrimSunshineFormFemaleId;

        /// <summary>
        /// Cherrim's female sunshine form ID (0x425)
        /// </summary>
        public MonsterId CherrimSunshineFormFemaleId
        {
            get
            {
                if (f_cherrimSunshineFormFemaleId)
                    return _cherrimSunshineFormFemaleId;
                long _pos = m_io.Pos;
                m_io.Seek(364372);
                _cherrimSunshineFormFemaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_cherrimSunshineFormFemaleId = true;
                return _cherrimSunshineFormFemaleId;
            }
        }
        private bool f_rolloutDamageMultTable;
        private RolloutDamageMultTableArray _rolloutDamageMultTable;

        /// <summary>
        /// A table of damage multipliers for each successive hit of Rollout/Ice Ball. Each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// type: int32_t[10]
        /// </summary>
        public RolloutDamageMultTableArray RolloutDamageMultTable
        {
            get
            {
                if (f_rolloutDamageMultTable)
                    return _rolloutDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(484496);
                _rolloutDamageMultTable = new RolloutDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_rolloutDamageMultTable = true;
                return _rolloutDamageMultTable;
            }
        }
        private bool f_damageMultiplier15;
        private Fx6416 _damageMultiplier15;

        /// <summary>
        /// A generic damage multiplier of 1.5 used in various places, as a 64-bit fixed-point number with 16 fraction bits.
        /// </summary>
        public Fx6416 DamageMultiplier15
        {
            get
            {
                if (f_damageMultiplier15)
                    return _damageMultiplier15;
                long _pos = m_io.Pos;
                m_io.Seek(483812);
                _damageMultiplier15 = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_damageMultiplier15 = true;
                return _damageMultiplier15;
            }
        }
        private bool f_twoTurnStatuses;
        private TwoTurnStatusesArray _twoTurnStatuses;

        /// <summary>
        /// Lists all status IDs that are for two-turn moves. The last entry is null.
        /// </summary>
        public TwoTurnStatusesArray TwoTurnStatuses
        {
            get
            {
                if (f_twoTurnStatuses)
                    return _twoTurnStatuses;
                long _pos = m_io.Pos;
                m_io.Seek(484352);
                _twoTurnStatuses = new TwoTurnStatusesArray(m_io);
                m_io.Seek(_pos);
                f_twoTurnStatuses = true;
                return _twoTurnStatuses;
            }
        }
        private bool f_exclItemEffectsWeatherNoStatus;
        private ExclItemEffectsWeatherNoStatusArray _exclItemEffectsWeatherNoStatus;

        /// <summary>
        /// Array of IDs for exclusive item effects that grant status immunity with certain weather conditions.
        /// </summary>
        public ExclItemEffectsWeatherNoStatusArray ExclItemEffectsWeatherNoStatus
        {
            get
            {
                if (f_exclItemEffectsWeatherNoStatus)
                    return _exclItemEffectsWeatherNoStatus;
                long _pos = m_io.Pos;
                m_io.Seek(487264);
                _exclItemEffectsWeatherNoStatus = new ExclItemEffectsWeatherNoStatusArray(m_io);
                m_io.Seek(_pos);
                f_exclItemEffectsWeatherNoStatus = true;
                return _exclItemEffectsWeatherNoStatus;
            }
        }
        private bool f_directionalBitMasks2;
        private DirectionalBitMasksArray _directionalBitMasks2;

        /// <summary>
        /// An array of one-hot bit masks corresponding to each direction_id. Used alongside tile-&gt;walkable_neighbor_flags to determine whether it's possible to move to a tile.
        /// </summary>
        public DirectionalBitMasksArray DirectionalBitMasks2
        {
            get
            {
                if (f_directionalBitMasks2)
                    return _directionalBitMasks2;
                long _pos = m_io.Pos;
                m_io.Seek(483616);
                _directionalBitMasks2 = new DirectionalBitMasksArray(m_io);
                m_io.Seek(_pos);
                f_directionalBitMasks2 = true;
                return _directionalBitMasks2;
            }
        }
        private bool f_defaultTile;
        private Tile _defaultTile;

        /// <summary>
        /// The default tile struct.
        /// 
        /// This is just a struct full of zeroes, but is used as a fallback in various places where a &quot;default&quot; tile is needed, such as when a grid index is out of range.
        /// 
        /// type: struct tile
        /// </summary>
        public Tile DefaultTile
        {
            get
            {
                if (f_defaultTile)
                    return _defaultTile;
                long _pos = m_io.Pos;
                m_io.Seek(487612);
                _defaultTile = new Tile(m_io);
                m_io.Seek(_pos);
                f_defaultTile = true;
                return _defaultTile;
            }
        }
        private bool f_judgmentMoveId;
        private MoveId _judgmentMoveId;

        /// <summary>
        /// Move ID for Judgment (0x1D3)
        /// 
        /// type: enum move_id
        /// </summary>
        public MoveId JudgmentMoveId
        {
            get
            {
                if (f_judgmentMoveId)
                    return _judgmentMoveId;
                long _pos = m_io.Pos;
                m_io.Seek(196808);
                _judgmentMoveId = new MoveId(m_io);
                m_io.Seek(_pos);
                f_judgmentMoveId = true;
                return _judgmentMoveId;
            }
        }
        private bool f_aiThrownItemActionChoiceCount;
        private uint _aiThrownItemActionChoiceCount;

        /// <summary>
        /// [Runtime] Used to store the number of positions output by GetPossibleAiArcItemTargets and the number of directions/probabilities output by GetPossibleAiThrownItemDirections.
        /// </summary>
        public uint AiThrownItemActionChoiceCount
        {
            get
            {
                if (f_aiThrownItemActionChoiceCount)
                    return _aiThrownItemActionChoiceCount;
                long _pos = m_io.Pos;
                m_io.Seek(487580);
                _aiThrownItemActionChoiceCount = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_aiThrownItemActionChoiceCount = true;
                return _aiThrownItemActionChoiceCount;
            }
        }
        private bool f_kecleonFemaleId;
        private MonsterId _kecleonFemaleId;

        /// <summary>
        /// 0x3D7 (983). Used when spawning Kecleon on an even numbered floor.
        /// </summary>
        public MonsterId KecleonFemaleId
        {
            get
            {
                if (f_kecleonFemaleId)
                    return _kecleonFemaleId;
                long _pos = m_io.Pos;
                m_io.Seek(110828);
                _kecleonFemaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_kecleonFemaleId = true;
                return _kecleonFemaleId;
            }
        }
        private bool f_statusIconArrayLeechSeed;
        private StatusIconArrayLeechSeedArray _statusIconArrayLeechSeed;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::leech_seed * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayLeechSeedArray StatusIconArrayLeechSeed
        {
            get
            {
                if (f_statusIconArrayLeechSeed)
                    return _statusIconArrayLeechSeed;
                long _pos = m_io.Pos;
                m_io.Seek(478108);
                _statusIconArrayLeechSeed = new StatusIconArrayLeechSeedArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayLeechSeed = true;
                return _statusIconArrayLeechSeed;
            }
        }
        private bool f_statusIconArraySureShot;
        private StatusIconArraySureShotArray _statusIconArraySureShot;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::sure_shot * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArraySureShotArray StatusIconArraySureShot
        {
            get
            {
                if (f_statusIconArraySureShot)
                    return _statusIconArraySureShot;
                long _pos = m_io.Pos;
                m_io.Seek(478300);
                _statusIconArraySureShot = new StatusIconArraySureShotArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArraySureShot = true;
                return _statusIconArraySureShot;
            }
        }
        private bool f_statusIconArraySleep;
        private StatusIconArraySleepArray _statusIconArraySleep;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::sleep * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArraySleepArray StatusIconArraySleep
        {
            get
            {
                if (f_statusIconArraySleep)
                    return _statusIconArraySleep;
                long _pos = m_io.Pos;
                m_io.Seek(478380);
                _statusIconArraySleep = new StatusIconArraySleepArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArraySleep = true;
                return _statusIconArraySleep;
            }
        }
        private bool f_statusIconArrayLongToss;
        private StatusIconArrayLongTossArray _statusIconArrayLongToss;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::long_toss * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayLongTossArray StatusIconArrayLongToss
        {
            get
            {
                if (f_statusIconArrayLongToss)
                    return _statusIconArrayLongToss;
                long _pos = m_io.Pos;
                m_io.Seek(478132);
                _statusIconArrayLongToss = new StatusIconArrayLongTossArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayLongToss = true;
                return _statusIconArrayLongToss;
            }
        }
        private bool f_regularAttackMoveId;
        private MoveId _regularAttackMoveId;

        /// <summary>
        /// Move ID for the regular attack (0x163)
        /// 
        /// type: enum move_id
        /// </summary>
        public MoveId RegularAttackMoveId
        {
            get
            {
                if (f_regularAttackMoveId)
                    return _regularAttackMoveId;
                long _pos = m_io.Pos;
                m_io.Seek(196812);
                _regularAttackMoveId = new MoveId(m_io);
                m_io.Seek(_pos);
                f_regularAttackMoveId = true;
                return _regularAttackMoveId;
            }
        }
        private bool f_exclItemEffectsWeatherMoveSpeedBoost;
        private ExclItemEffectsWeatherMoveSpeedBoostArray _exclItemEffectsWeatherMoveSpeedBoost;

        /// <summary>
        /// Array of IDs for exclusive item effects that increase movement speed with certain weather conditions.
        /// </summary>
        public ExclItemEffectsWeatherMoveSpeedBoostArray ExclItemEffectsWeatherMoveSpeedBoost
        {
            get
            {
                if (f_exclItemEffectsWeatherMoveSpeedBoost)
                    return _exclItemEffectsWeatherMoveSpeedBoost;
                long _pos = m_io.Pos;
                m_io.Seek(487256);
                _exclItemEffectsWeatherMoveSpeedBoost = new ExclItemEffectsWeatherMoveSpeedBoostArray(m_io);
                m_io.Seek(_pos);
                f_exclItemEffectsWeatherMoveSpeedBoost = true;
                return _exclItemEffectsWeatherMoveSpeedBoost;
            }
        }
        private bool f_leaderPtr;
        private Pointer _leaderPtr;

        /// <summary>
        /// [Runtime] Pointer to the current leader of the team.
        /// 
        /// type: struct entity*
        /// </summary>
        public Pointer LeaderPtr
        {
            get
            {
                if (f_leaderPtr)
                    return _leaderPtr;
                long _pos = m_io.Pos;
                m_io.Seek(487164);
                _leaderPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_leaderPtr = true;
                return _leaderPtr;
            }
        }
        private bool f_exclItemEffectsWeatherAtkSpeedBoost;
        private ExclItemEffectsWeatherAtkSpeedBoostArray _exclItemEffectsWeatherAtkSpeedBoost;

        /// <summary>
        /// Array of IDs for exclusive item effects that increase attack speed with certain weather conditions.
        /// </summary>
        public ExclItemEffectsWeatherAtkSpeedBoostArray ExclItemEffectsWeatherAtkSpeedBoost
        {
            get
            {
                if (f_exclItemEffectsWeatherAtkSpeedBoost)
                    return _exclItemEffectsWeatherAtkSpeedBoost;
                long _pos = m_io.Pos;
                m_io.Seek(487248);
                _exclItemEffectsWeatherAtkSpeedBoost = new ExclItemEffectsWeatherAtkSpeedBoostArray(m_io);
                m_io.Seek(_pos);
                f_exclItemEffectsWeatherAtkSpeedBoost = true;
                return _exclItemEffectsWeatherAtkSpeedBoost;
            }
        }
        private bool f_positionDisplacementToDirection;
        private PositionDisplacementToDirectionArray _positionDisplacementToDirection;

        /// <summary>
        /// An array mapping position displacements (y, then x) to directions. Used by GetDirectionTowardsPosition.
        /// 
        /// Given two positions, displacements are either 0, 1, or 2 depending on whether the second position's x/y coordinate is less than, equal, or greater
        /// than the first position's corresponding coordinates. For example, POSITION_DISPLACEMENT_TO_DIRECTION[0][2] (DIR_UP_RIGHT)
        /// indicates that the second y coordinate is less than the first, and the second x coordinate is greater than the first.
        /// </summary>
        public PositionDisplacementToDirectionArray PositionDisplacementToDirection
        {
            get
            {
                if (f_positionDisplacementToDirection)
                    return _positionDisplacementToDirection;
                long _pos = m_io.Pos;
                m_io.Seek(479140);
                _positionDisplacementToDirection = new PositionDisplacementToDirectionArray(m_io);
                m_io.Seek(_pos);
                f_positionDisplacementToDirection = true;
                return _positionDisplacementToDirection;
            }
        }
        private bool f_displacementsWithin3;
        private DisplacementsWithin3Array _displacementsWithin3;

        /// <summary>
        /// An array of displacement vectors with max norm &lt;= 3. The elements are vaguely in ascending order by norm, but not exactly.
        /// 
        /// The last element, (99, 99), is invalid and used as an end marker.
        /// 
        /// type: position[50]
        /// </summary>
        public DisplacementsWithin3Array DisplacementsWithin3
        {
            get
            {
                if (f_displacementsWithin3)
                    return _displacementsWithin3;
                long _pos = m_io.Pos;
                m_io.Seek(479820);
                _displacementsWithin3 = new DisplacementsWithin3Array(m_io);
                m_io.Seek(_pos);
                f_displacementsWithin3 = true;
                return _displacementsWithin3;
            }
        }
        private bool f_hiddenStairsSpawnBlocked;
        private byte _hiddenStairsSpawnBlocked;

        /// <summary>
        /// [Runtime] A flag for when Hidden Stairs could normally have spawned on the floor but didn't.
        /// 
        /// This is set either when the Hidden Stairs just happen not to spawn by chance, or when the current floor is a rescue or mission destination floor.
        /// 
        /// This appears to be part of a larger (8-byte?) struct. It seems like this value is at least followed by 3 bytes of padding and a 4-byte integer field.
        /// </summary>
        public byte HiddenStairsSpawnBlocked
        {
            get
            {
                if (f_hiddenStairsSpawnBlocked)
                    return _hiddenStairsSpawnBlocked;
                long _pos = m_io.Pos;
                m_io.Seek(487716);
                _hiddenStairsSpawnBlocked = m_io.ReadU1();
                m_io.Seek(_pos);
                f_hiddenStairsSpawnBlocked = true;
                return _hiddenStairsSpawnBlocked;
            }
        }
        private bool f_statusIconArrayCringe;
        private StatusIconArrayCringeArray _statusIconArrayCringe;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::cringe * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayCringeArray StatusIconArrayCringe
        {
            get
            {
                if (f_statusIconArrayCringe)
                    return _statusIconArrayCringe;
                long _pos = m_io.Pos;
                m_io.Seek(478548);
                _statusIconArrayCringe = new StatusIconArrayCringeArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayCringe = true;
                return _statusIconArrayCringe;
            }
        }
        private bool f_cloudyDamageMultiplier;
        private Fx6416 _cloudyDamageMultiplier;

        /// <summary>
        /// The extra damage multiplier for non-Normal-type moves when the weather is Cloudy, as a 64-bit fixed-point number with 16 fraction bits (0.75).
        /// </summary>
        public Fx6416 CloudyDamageMultiplier
        {
            get
            {
                if (f_cloudyDamageMultiplier)
                    return _cloudyDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(483836);
                _cloudyDamageMultiplier = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_cloudyDamageMultiplier = true;
                return _cloudyDamageMultiplier;
            }
        }
        private bool f_fixedRoomItemSpawnTable;
        private FixedRoomItemSpawnTableArray _fixedRoomItemSpawnTable;

        /// <summary>
        /// Table of items that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.
        /// 
        /// This is an array of 63 8-byte entries containing one item ID each.
        /// 
        /// type: struct fixed_room_item_spawn_entry[63]
        /// </summary>
        public FixedRoomItemSpawnTableArray FixedRoomItemSpawnTable
        {
            get
            {
                if (f_fixedRoomItemSpawnTable)
                    return _fixedRoomItemSpawnTable;
                long _pos = m_io.Pos;
                m_io.Seek(473748);
                _fixedRoomItemSpawnTable = new FixedRoomItemSpawnTableArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomItemSpawnTable = true;
                return _fixedRoomItemSpawnTable;
            }
        }
        private bool f_deoxysSpeedId;
        private MonsterId _deoxysSpeedId;

        /// <summary>
        /// Monster ID for Deoxys in Speed Forme (0x1A5)
        /// 
        /// type: enum monster_id
        /// </summary>
        public MonsterId DeoxysSpeedId
        {
            get
            {
                if (f_deoxysSpeedId)
                    return _deoxysSpeedId;
                long _pos = m_io.Pos;
                m_io.Seek(196820);
                _deoxysSpeedId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_deoxysSpeedId = true;
                return _deoxysSpeedId;
            }
        }
        private bool f_statusIconArrayReflect;
        private StatusIconArrayReflectArray _statusIconArrayReflect;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::reflect * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayReflectArray StatusIconArrayReflect
        {
            get
            {
                if (f_statusIconArrayReflect)
                    return _statusIconArrayReflect;
                long _pos = m_io.Pos;
                m_io.Seek(478868);
                _statusIconArrayReflect = new StatusIconArrayReflectArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayReflect = true;
                return _statusIconArrayReflect;
            }
        }
        private bool f_itemCategoryActions;
        private ItemCategoryActionsArray _itemCategoryActions;

        /// <summary>
        /// Action ID associated with each item category. Used by GetItemAction.
        /// 
        /// Each entry is 2 bytes long.
        /// </summary>
        public ItemCategoryActionsArray ItemCategoryActions
        {
            get
            {
                if (f_itemCategoryActions)
                    return _itemCategoryActions;
                long _pos = m_io.Pos;
                m_io.Seek(481712);
                _itemCategoryActions = new ItemCategoryActionsArray(m_io);
                m_io.Seek(_pos);
                f_itemCategoryActions = true;
                return _itemCategoryActions;
            }
        }
        private bool f_monsterTreatmentData;
        private MonsterTreatmentDataArray _monsterTreatmentData;

        /// <summary>
        /// A 4D array of monster_treatment enum values. Used by GetTreatmentBetweenMonsters to determine treatment based on several parameters.
        /// The parameters are (in order of how the array is indexed):
        /// 1. Value from 0-3 based on entity1's decoy_ai_tracker value.
        ///   If decoy_ai_tracker is 0 and the entity is the leader, this value is 0. Otherwise it is decoy_ai_tracker + 1
        /// 2. Boolean value for whether entity1 is a wild Pokémon.
        /// 3. Boolean value for whether entity2 is a wild Pokémon.
        /// 4. Boolean value for whether entity2 is a decoy.
        /// </summary>
        public MonsterTreatmentDataArray MonsterTreatmentData
        {
            get
            {
                if (f_monsterTreatmentData)
                    return _monsterTreatmentData;
                long _pos = m_io.Pos;
                m_io.Seek(483648);
                _monsterTreatmentData = new MonsterTreatmentDataArray(m_io);
                m_io.Seek(_pos);
                f_monsterTreatmentData = true;
                return _monsterTreatmentData;
            }
        }
        private bool f_solidRockMultiplier;
        private Fx6416 _solidRockMultiplier;

        /// <summary>
        /// The extra damage multiplier for super-effective moves when Solid Rock or Filter is active, as a 64-bit fixed-point number with 16 fraction bits (0.75).
        /// </summary>
        public Fx6416 SolidRockMultiplier
        {
            get
            {
                if (f_solidRockMultiplier)
                    return _solidRockMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(483844);
                _solidRockMultiplier = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_solidRockMultiplier = true;
                return _solidRockMultiplier;
            }
        }
        private bool f_statusIconArrayFreeze;
        private StatusIconArrayFreezeArray _statusIconArrayFreeze;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::freeze * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayFreezeArray StatusIconArrayFreeze
        {
            get
            {
                if (f_statusIconArrayFreeze)
                    return _statusIconArrayFreeze;
                long _pos = m_io.Pos;
                m_io.Seek(478484);
                _statusIconArrayFreeze = new StatusIconArrayFreezeArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayFreeze = true;
                return _statusIconArrayFreeze;
            }
        }
        private bool f_gummiLikeStringIds;
        private GummiLikeStringIdsArray _gummiLikeStringIds;

        /// <summary>
        /// List that holds the string IDs for how much a monster liked a gummi in decreasing order.
        /// </summary>
        public GummiLikeStringIdsArray GummiLikeStringIds
        {
            get
            {
                if (f_gummiLikeStringIds)
                    return _gummiLikeStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(486512);
                _gummiLikeStringIds = new GummiLikeStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_gummiLikeStringIds = true;
                return _gummiLikeStringIds;
            }
        }
        private bool f_cherrimSunshineFormMaleId;
        private MonsterId _cherrimSunshineFormMaleId;

        /// <summary>
        /// Cherrim's male sunshine form ID (0x1CD)
        /// </summary>
        public MonsterId CherrimSunshineFormMaleId
        {
            get
            {
                if (f_cherrimSunshineFormMaleId)
                    return _cherrimSunshineFormMaleId;
                long _pos = m_io.Pos;
                m_io.Seek(364364);
                _cherrimSunshineFormMaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_cherrimSunshineFormMaleId = true;
                return _cherrimSunshineFormMaleId;
            }
        }
        private bool f_bellyDrainInWallsThousandths;
        private ushort _bellyDrainInWallsThousandths;

        /// <summary>
        /// The additional amount by which belly is decreased every turn when inside walls (fractional thousandths)
        /// </summary>
        public ushort BellyDrainInWallsThousandths
        {
            get
            {
                if (f_bellyDrainInWallsThousandths)
                    return _bellyDrainInWallsThousandths;
                long _pos = m_io.Pos;
                m_io.Seek(483594);
                _bellyDrainInWallsThousandths = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_bellyDrainInWallsThousandths = true;
                return _bellyDrainInWallsThousandths;
            }
        }
        private bool f_gummiIqStringIds;
        private GummiIqStringIdsArray _gummiIqStringIds;

        /// <summary>
        /// List that holds the string IDs for how much a monster's IQ was raised by in decreasing order.
        /// </summary>
        public GummiIqStringIdsArray GummiIqStringIds
        {
            get
            {
                if (f_gummiIqStringIds)
                    return _gummiIqStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(486596);
                _gummiIqStringIds = new GummiIqStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_gummiIqStringIds = true;
                return _gummiIqStringIds;
            }
        }
        private bool f_fixedRoomTileSpawnTable;
        private FixedRoomTileSpawnTableArray _fixedRoomTileSpawnTable;

        /// <summary>
        /// Table of tiles that can spawn in fixed rooms, pointed into by the FIXED_ROOM_TILE_SPAWN_TABLE.
        /// 
        /// This is an array of 11 4-byte entries containing info about one tile each. Info includes the trap ID if a trap, room ID, and flags.
        /// 
        /// type: struct fixed_room_tile_spawn_entry[11]
        /// </summary>
        public FixedRoomTileSpawnTableArray FixedRoomTileSpawnTable
        {
            get
            {
                if (f_fixedRoomTileSpawnTable)
                    return _fixedRoomTileSpawnTable;
                long _pos = m_io.Pos;
                m_io.Seek(472944);
                _fixedRoomTileSpawnTable = new FixedRoomTileSpawnTableArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomTileSpawnTable = true;
                return _fixedRoomTileSpawnTable;
            }
        }
        private bool f_giratinaAlteredId;
        private MonsterId _giratinaAlteredId;

        /// <summary>
        /// Monster ID for Giratina in Altered Forme (0x211)
        /// 
        /// type: enum monster_id
        /// </summary>
        public MonsterId GiratinaAlteredId
        {
            get
            {
                if (f_giratinaAlteredId)
                    return _giratinaAlteredId;
                long _pos = m_io.Pos;
                m_io.Seek(196824);
                _giratinaAlteredId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_giratinaAlteredId = true;
                return _giratinaAlteredId;
            }
        }
        private bool f_displacementsWithin2SmallestFirst;
        private DisplacementsWithin2SmallestFirstArray _displacementsWithin2SmallestFirst;

        /// <summary>
        /// An array of displacement vectors with max norm &lt;= 2, ordered in ascending order by norm.
        /// 
        /// The last element, (99, 99), is invalid and used as an end marker.
        /// 
        /// type: position[26]
        /// </summary>
        public DisplacementsWithin2SmallestFirstArray DisplacementsWithin2SmallestFirst
        {
            get
            {
                if (f_displacementsWithin2SmallestFirst)
                    return _displacementsWithin2SmallestFirst;
                long _pos = m_io.Pos;
                m_io.Seek(479716);
                _displacementsWithin2SmallestFirst = new DisplacementsWithin2SmallestFirstArray(m_io);
                m_io.Seek(_pos);
                f_displacementsWithin2SmallestFirst = true;
                return _displacementsWithin2SmallestFirst;
            }
        }
        private bool f_castformNormalFormMaleId;
        private MonsterId _castformNormalFormMaleId;

        /// <summary>
        /// Castform's male normal form ID (0x17B)
        /// </summary>
        public MonsterId CastformNormalFormMaleId
        {
            get
            {
                if (f_castformNormalFormMaleId)
                    return _castformNormalFormMaleId;
                long _pos = m_io.Pos;
                m_io.Seek(364356);
                _castformNormalFormMaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_castformNormalFormMaleId = true;
                return _castformNormalFormMaleId;
            }
        }
        private bool f_statusIconArrayBlinded;
        private StatusIconArrayBlindedArray _statusIconArrayBlinded;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::blinded * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayBlindedArray StatusIconArrayBlinded
        {
            get
            {
                if (f_statusIconArrayBlinded)
                    return _statusIconArrayBlinded;
                long _pos = m_io.Pos;
                m_io.Seek(478220);
                _statusIconArrayBlinded = new StatusIconArrayBlindedArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayBlinded = true;
                return _statusIconArrayBlinded;
            }
        }
        private bool f_statusIconArrayMagnetRise;
        private StatusIconArrayMagnetRiseArray _statusIconArrayMagnetRise;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::magnet_rise * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayMagnetRiseArray StatusIconArrayMagnetRise
        {
            get
            {
                if (f_statusIconArrayMagnetRise)
                    return _statusIconArrayMagnetRise;
                long _pos = m_io.Pos;
                m_io.Seek(478060);
                _statusIconArrayMagnetRise = new StatusIconArrayMagnetRiseArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayMagnetRise = true;
                return _statusIconArrayMagnetRise;
            }
        }
        private bool f_directionalBitMasks3;
        private DirectionalBitMasksArray _directionalBitMasks3;

        /// <summary>
        /// An array of one-hot bit masks corresponding to each direction_id. Used alongside tile-&gt;walkable_neighbor_flags to determine whether it's possible to move to a tile.
        /// </summary>
        public DirectionalBitMasksArray DirectionalBitMasks3
        {
            get
            {
                if (f_directionalBitMasks3)
                    return _directionalBitMasks3;
                long _pos = m_io.Pos;
                m_io.Seek(483624);
                _directionalBitMasks3 = new DirectionalBitMasksArray(m_io);
                m_io.Seek(_pos);
                f_directionalBitMasks3 = true;
                return _directionalBitMasks3;
            }
        }
        private bool f_castformNormalFormFemaleId;
        private MonsterId _castformNormalFormFemaleId;

        /// <summary>
        /// Castform's female normal form ID (0x3D3)
        /// </summary>
        public MonsterId CastformNormalFormFemaleId
        {
            get
            {
                if (f_castformNormalFormFemaleId)
                    return _castformNormalFormFemaleId;
                long _pos = m_io.Pos;
                m_io.Seek(364360);
                _castformNormalFormFemaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_castformNormalFormFemaleId = true;
                return _castformNormalFormFemaleId;
            }
        }
        private bool f_directionalBitMasks4;
        private DirectionalBitMasksArray _directionalBitMasks4;

        /// <summary>
        /// An array of one-hot bit masks corresponding to each direction_id. Used alongside tile-&gt;walkable_neighbor_flags to determine whether it's possible to move to a tile.
        /// </summary>
        public DirectionalBitMasksArray DirectionalBitMasks4
        {
            get
            {
                if (f_directionalBitMasks4)
                    return _directionalBitMasks4;
                long _pos = m_io.Pos;
                m_io.Seek(483632);
                _directionalBitMasks4 = new DirectionalBitMasksArray(m_io);
                m_io.Seek(_pos);
                f_directionalBitMasks4 = true;
                return _directionalBitMasks4;
            }
        }
        private bool f_statusIconArrayInvisible;
        private StatusIconArrayInvisibleArray _statusIconArrayInvisible;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::invisible * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayInvisibleArray StatusIconArrayInvisible
        {
            get
            {
                if (f_statusIconArrayInvisible)
                    return _statusIconArrayInvisible;
                long _pos = m_io.Pos;
                m_io.Seek(478340);
                _statusIconArrayInvisible = new StatusIconArrayInvisibleArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayInvisible = true;
                return _statusIconArrayInvisible;
            }
        }
        private bool f_cornerCardinalNeighborIsOpen;
        private CornerCardinalNeighborIsOpenArray _cornerCardinalNeighborIsOpen;

        /// <summary>
        /// An array mapping each (corner index, neighbor direction index) to whether or not that neighbor is expected to be open floor.
        /// 
        /// Corners start with 0=top-left and proceed clockwise. Directions are enumerated as with DIRECTIONS_XY. The array is indexed by i=(corner_index * N_DIRECTIONS + direction). An element of 1 (0) means that starting from the specified corner of a room, moving in the specified direction should lead to an open floor tile (non-open terrain like a wall).
        /// 
        /// Note that this array is only used for the cardinal directions. The elements at odd indexes are unused and unconditionally set to 0.
        /// 
        /// This array is used by the dungeon generation algorithm when generating room imperfections. See GenerateRoomImperfections.
        /// </summary>
        public CornerCardinalNeighborIsOpenArray CornerCardinalNeighborIsOpen
        {
            get
            {
                if (f_cornerCardinalNeighborIsOpen)
                    return _cornerCardinalNeighborIsOpen;
                long _pos = m_io.Pos;
                m_io.Seek(485808);
                _cornerCardinalNeighborIsOpen = new CornerCardinalNeighborIsOpenArray(m_io);
                m_io.Seek(_pos);
                f_cornerCardinalNeighborIsOpen = true;
                return _cornerCardinalNeighborIsOpen;
            }
        }
        private bool f_damageMultiplier2;
        private Fx6416 _damageMultiplier2;

        /// <summary>
        /// A generic damage multiplier of 2 used in various places, as a 64-bit fixed-point number with 16 fraction bits.
        /// </summary>
        public Fx6416 DamageMultiplier2
        {
            get
            {
                if (f_damageMultiplier2)
                    return _damageMultiplier2;
                long _pos = m_io.Pos;
                m_io.Seek(483820);
                _damageMultiplier2 = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_damageMultiplier2 = true;
                return _damageMultiplier2;
            }
        }
        private bool f_treasureBox1ItemIds;
        private TreasureBox1ItemIdsArray _treasureBox1ItemIds;

        /// <summary>
        /// Item IDs for variant 1 of each of the treasure box items (ITEM_*_BOX_1).
        /// 
        /// type: struct item_id_16[12]
        /// </summary>
        public TreasureBox1ItemIdsArray TreasureBox1ItemIds
        {
            get
            {
                if (f_treasureBox1ItemIds)
                    return _treasureBox1ItemIds;
                long _pos = m_io.Pos;
                m_io.Seek(472988);
                _treasureBox1ItemIds = new TreasureBox1ItemIdsArray(m_io);
                m_io.Seek(_pos);
                f_treasureBox1ItemIds = true;
                return _treasureBox1ItemIds;
            }
        }
        private bool f_fixedRoomRevisitOverrides;
        private FixedRoomRevisitOverridesArray _fixedRoomRevisitOverrides;

        /// <summary>
        /// Table of fixed room IDs, which if nonzero, overrides the normal fixed room ID for a floor (which is used to index the table) if the dungeon has already been cleared previously.
        /// 
        /// Overrides are used to substitute different fixed room data for things like revisits to story dungeons.
        /// 
        /// type: struct fixed_room_id_8[256]
        /// </summary>
        public FixedRoomRevisitOverridesArray FixedRoomRevisitOverrides
        {
            get
            {
                if (f_fixedRoomRevisitOverrides)
                    return _fixedRoomRevisitOverrides;
                long _pos = m_io.Pos;
                m_io.Seek(473012);
                _fixedRoomRevisitOverrides = new FixedRoomRevisitOverridesArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomRevisitOverrides = true;
                return _fixedRoomRevisitOverrides;
            }
        }
        private bool f_fixedRoomMonsterSpawnTable;
        private FixedRoomMonsterSpawnTableArray _fixedRoomMonsterSpawnTable;

        /// <summary>
        /// Table of monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.
        /// 
        /// This is an array of 120 4-byte entries containing info about one monster each. Info includes the monster ID, stats, and behavior type.
        /// 
        /// type: struct fixed_room_monster_spawn_entry[120]
        /// </summary>
        public FixedRoomMonsterSpawnTableArray FixedRoomMonsterSpawnTable
        {
            get
            {
                if (f_fixedRoomMonsterSpawnTable)
                    return _fixedRoomMonsterSpawnTable;
                long _pos = m_io.Pos;
                m_io.Seek(473268);
                _fixedRoomMonsterSpawnTable = new FixedRoomMonsterSpawnTableArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomMonsterSpawnTable = true;
                return _fixedRoomMonsterSpawnTable;
            }
        }
        private bool f_bellyLostPerTurn;
        private int _bellyLostPerTurn;

        /// <summary>
        /// The base value by which belly is decreased every turn.
        /// 
        /// Its raw value is 0x199A, which encodes a binary fixed-point number (16 fraction bits) with value (0x199A * 2^-16), and is the closest approximation to 0.1 representable in this number format.
        /// </summary>
        public int BellyLostPerTurn
        {
            get
            {
                if (f_bellyLostPerTurn)
                    return _bellyLostPerTurn;
                long _pos = m_io.Pos;
                m_io.Seek(214712);
                _bellyLostPerTurn = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_bellyLostPerTurn = true;
                return _bellyLostPerTurn;
            }
        }
        private bool f_directionsXy;
        private DirectionsXyArray _directionsXy;

        /// <summary>
        /// An array mapping each direction index to its x and y displacements.
        /// 
        /// Directions start with 0=down and proceed counterclockwise (see enum direction_id). Displacements for x and y are interleaved and encoded as 2-byte signed integers. For example, the first two integers are [0, 1], which correspond to the x and y displacements for the &quot;down&quot; direction (positive y means down).
        /// </summary>
        public DirectionsXyArray DirectionsXy
        {
            get
            {
                if (f_directionsXy)
                    return _directionsXy;
                long _pos = m_io.Pos;
                m_io.Seek(479420);
                _directionsXy = new DirectionsXyArray(m_io);
                m_io.Seek(_pos);
                f_directionsXy = true;
                return _directionsXy;
            }
        }
        private bool f_displacementsWithin2LargestFirst;
        private DisplacementsWithin2LargestFirstArray _displacementsWithin2LargestFirst;

        /// <summary>
        /// An array of displacement vectors with max norm &lt;= 2, ordered in descending order by norm.
        /// 
        /// The last element, (99, 99), is invalid and used as an end marker.
        /// 
        /// type: position[26]
        /// </summary>
        public DisplacementsWithin2LargestFirstArray DisplacementsWithin2LargestFirst
        {
            get
            {
                if (f_displacementsWithin2LargestFirst)
                    return _displacementsWithin2LargestFirst;
                long _pos = m_io.Pos;
                m_io.Seek(479612);
                _displacementsWithin2LargestFirst = new DisplacementsWithin2LargestFirstArray(m_io);
                m_io.Seek(_pos);
                f_displacementsWithin2LargestFirst = true;
                return _displacementsWithin2LargestFirst;
            }
        }
        private bool f_spatkStatIdx;
        private int _spatkStatIdx;

        /// <summary>
        /// The index (1) of the special attack entry in internal stat structs, such as the stat modifier array for a monster.
        /// </summary>
        public int SpatkStatIdx
        {
            get
            {
                if (f_spatkStatIdx)
                    return _spatkStatIdx;
                long _pos = m_io.Pos;
                m_io.Seek(484488);
                _spatkStatIdx = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_spatkStatIdx = true;
                return _spatkStatIdx;
            }
        }
        private bool f_punishmentMoveId;
        private MoveId _punishmentMoveId;

        /// <summary>
        /// Move ID for Punishment (0x1BD)
        /// 
        /// type: enum move_id
        /// </summary>
        public MoveId PunishmentMoveId
        {
            get
            {
                if (f_punishmentMoveId)
                    return _punishmentMoveId;
                long _pos = m_io.Pos;
                m_io.Seek(196828);
                _punishmentMoveId = new MoveId(m_io);
                m_io.Seek(_pos);
                f_punishmentMoveId = true;
                return _punishmentMoveId;
            }
        }
        private bool f_statusIconArrayMiracleEye;
        private StatusIconArrayMiracleEyeArray _statusIconArrayMiracleEye;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::miracle_eye * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayMiracleEyeArray StatusIconArrayMiracleEye
        {
            get
            {
                if (f_statusIconArrayMiracleEye)
                    return _statusIconArrayMiracleEye;
                long _pos = m_io.Pos;
                m_io.Seek(478092);
                _statusIconArrayMiracleEye = new StatusIconArrayMiracleEyeArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayMiracleEye = true;
                return _statusIconArrayMiracleEye;
            }
        }
        private bool f_dungeonPtr;
        private Pointer _dungeonPtr;

        /// <summary>
        /// [Runtime] Pointer to the dungeon struct in dungeon mode.
        /// 
        /// This is a &quot;working copy&quot; of DUNGEON_PTR_MASTER. The main dungeon engine uses this pointer (or rather pointers to this pointer) when actually running dungeon mode.
        /// 
        /// type: struct dungeon*
        /// </summary>
        public Pointer DungeonPtr
        {
            get
            {
                if (f_dungeonPtr)
                    return _dungeonPtr;
                long _pos = m_io.Pos;
                m_io.Seek(487128);
                _dungeonPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_dungeonPtr = true;
                return _dungeonPtr;
            }
        }
        private bool f_directionalBitMasks1;
        private DirectionalBitMasksArray _directionalBitMasks1;

        /// <summary>
        /// An array of one-hot bit masks corresponding to each direction_id. Used alongside tile-&gt;walkable_neighbor_flags to determine whether it's possible to move to a tile.
        /// </summary>
        public DirectionalBitMasksArray DirectionalBitMasks1
        {
            get
            {
                if (f_directionalBitMasks1)
                    return _directionalBitMasks1;
                long _pos = m_io.Pos;
                m_io.Seek(483608);
                _directionalBitMasks1 = new DirectionalBitMasksArray(m_io);
                m_io.Seek(_pos);
                f_directionalBitMasks1 = true;
                return _directionalBitMasks1;
            }
        }
        private bool f_dungeonPrngStateSecondaryValues;
        private DungeonPrngStateSecondaryValuesArray _dungeonPrngStateSecondaryValues;

        /// <summary>
        /// [Runtime] An array of 5 integers corresponding to the last value generated for each secondary LCG sequence.
        /// 
        /// Based on the assembly, this appears to be its own global array, separate from DUNGEON_PRNG_STATE.
        /// </summary>
        public DungeonPrngStateSecondaryValuesArray DungeonPrngStateSecondaryValues
        {
            get
            {
                if (f_dungeonPrngStateSecondaryValues)
                    return _dungeonPrngStateSecondaryValues;
                long _pos = m_io.Pos;
                m_io.Seek(487204);
                _dungeonPrngStateSecondaryValues = new DungeonPrngStateSecondaryValuesArray(m_io);
                m_io.Seek(_pos);
                f_dungeonPrngStateSecondaryValues = true;
                return _dungeonPrngStateSecondaryValues;
            }
        }
        private bool f_cherrimOvercastFormFemaleId;
        private MonsterId _cherrimOvercastFormFemaleId;

        /// <summary>
        /// Cherrim's female overcast form ID (0x424)
        /// </summary>
        public MonsterId CherrimOvercastFormFemaleId
        {
            get
            {
                if (f_cherrimOvercastFormFemaleId)
                    return _cherrimOvercastFormFemaleId;
                long _pos = m_io.Pos;
                m_io.Seek(364368);
                _cherrimOvercastFormFemaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_cherrimOvercastFormFemaleId = true;
                return _cherrimOvercastFormFemaleId;
            }
        }
        private bool f_deoxysAttackId;
        private MonsterId _deoxysAttackId;

        /// <summary>
        /// Monster ID for Deoxys in Attack Forme (0x1A3)
        /// 
        /// type: enum monster_id
        /// </summary>
        public MonsterId DeoxysAttackId
        {
            get
            {
                if (f_deoxysAttackId)
                    return _deoxysAttackId;
                long _pos = m_io.Pos;
                m_io.Seek(196816);
                _deoxysAttackId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_deoxysAttackId = true;
                return _deoxysAttackId;
            }
        }
        private bool f_mapColorTable;
        private MapColorTableArray _mapColorTable;

        /// <summary>
        /// In order: white, black, red, green, blue, magenta, dark pink, chartreuse, light orange
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct rgba[9]
        /// </summary>
        public MapColorTableArray MapColorTable
        {
            get
            {
                if (f_mapColorTable)
                    return _mapColorTable;
                long _pos = m_io.Pos;
                m_io.Seek(485744);
                _mapColorTable = new MapColorTableArray(m_io);
                m_io.Seek(_pos);
                f_mapColorTable = true;
                return _mapColorTable;
            }
        }
        private bool f_damageFormulaMinBase;
        private Fx6416 _damageFormulaMinBase;

        /// <summary>
        /// The minimum value of the base damage formula (after DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER application, if relevant), as a 64-bit binary fixed-point number with 16 fraction bits (1).
        /// </summary>
        public Fx6416 DamageFormulaMinBase
        {
            get
            {
                if (f_damageFormulaMinBase)
                    return _damageFormulaMinBase;
                long _pos = m_io.Pos;
                m_io.Seek(483868);
                _damageFormulaMinBase = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_damageFormulaMinBase = true;
                return _damageFormulaMinBase;
            }
        }
        private bool f_directionalBitMasks0;
        private DirectionalBitMasksArray _directionalBitMasks0;

        /// <summary>
        /// An array of one-hot bit masks corresponding to each direction_id. Used alongside tile-&gt;walkable_neighbor_flags to determine whether it's possible to move to a tile.
        /// </summary>
        public DirectionalBitMasksArray DirectionalBitMasks0
        {
            get
            {
                if (f_directionalBitMasks0)
                    return _directionalBitMasks0;
                long _pos = m_io.Pos;
                m_io.Seek(483600);
                _directionalBitMasks0 = new DirectionalBitMasksArray(m_io);
                m_io.Seek(_pos);
                f_directionalBitMasks0 = true;
                return _directionalBitMasks0;
            }
        }
        private bool f_damageStringIds;
        private DamageStringIdsArray _damageStringIds;

        /// <summary>
        /// List that matches the damage_message ID to their corresponding string ID. The null entry at 0xE in the middle is for hunger. The last entry is null.
        /// </summary>
        public DamageStringIdsArray DamageStringIds
        {
            get
            {
                if (f_damageStringIds)
                    return _damageStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(486608);
                _damageStringIds = new DamageStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_damageStringIds = true;
                return _damageStringIds;
            }
        }
        private bool f_fixedRoomDataPtr;
        private Pointer _fixedRoomDataPtr;

        /// <summary>
        /// [Runtime] Pointer to decoded fixed room data loaded from the BALANCE/fixed.bin file.
        /// </summary>
        public Pointer FixedRoomDataPtr
        {
            get
            {
                if (f_fixedRoomDataPtr)
                    return _fixedRoomDataPtr;
                long _pos = m_io.Pos;
                m_io.Seek(487724);
                _fixedRoomDataPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_fixedRoomDataPtr = true;
                return _fixedRoomDataPtr;
            }
        }
        private bool f_kecleonMaleId;
        private MonsterId _kecleonMaleId;

        /// <summary>
        /// 0x17F (383). Used when spawning Kecleon on an odd numbered floor.
        /// </summary>
        public MonsterId KecleonMaleId
        {
            get
            {
                if (f_kecleonMaleId)
                    return _kecleonMaleId;
                long _pos = m_io.Pos;
                m_io.Seek(110832);
                _kecleonMaleId = new MonsterId(m_io);
                m_io.Seek(_pos);
                f_kecleonMaleId = true;
                return _kecleonMaleId;
            }
        }
        private bool f_fractionalTurnSequence;
        private FractionalTurnSequenceArray _fractionalTurnSequence;

        /// <summary>
        /// Read by certain functions that are called by RunFractionalTurn to see if they should be executed.
        /// 
        /// Array is accessed via a pointer added to some multiple of fractional_turn, so that if the resulting memory location is zero, the function returns.
        /// </summary>
        public FractionalTurnSequenceArray FractionalTurnSequence
        {
            get
            {
                if (f_fractionalTurnSequence)
                    return _fractionalTurnSequence;
                long _pos = m_io.Pos;
                m_io.Seek(482340);
                _fractionalTurnSequence = new FractionalTurnSequenceArray(m_io);
                m_io.Seek(_pos);
                f_fractionalTurnSequence = true;
                return _fractionalTurnSequence;
            }
        }
        private bool f_statusIconArrayBide;
        private StatusIconArrayBideArray _statusIconArrayBide;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::bide * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayBideArray StatusIconArrayBide
        {
            get
            {
                if (f_statusIconArrayBide)
                    return _statusIconArrayBide;
                long _pos = m_io.Pos;
                m_io.Seek(478612);
                _statusIconArrayBide = new StatusIconArrayBideArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayBide = true;
                return _statusIconArrayBide;
            }
        }
        private bool f_dungeonFadesPtr;
        private Pointer _dungeonFadesPtr;

        /// <summary>
        /// [Runtime] Pointer to the dungeon fades struct that maintains the status of screen fades in dungeon mode.
        /// </summary>
        public Pointer DungeonFadesPtr
        {
            get
            {
                if (f_dungeonFadesPtr)
                    return _dungeonFadesPtr;
                long _pos = m_io.Pos;
                m_io.Seek(487800);
                _dungeonFadesPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_dungeonFadesPtr = true;
                return _dungeonFadesPtr;
            }
        }
        private bool f_dungeonPrngState;
        private PrngState _dungeonPrngState;

        /// <summary>
        /// [Runtime] The global PRNG state for dungeon mode, not including the current values in the secondary sequences.
        /// 
        /// This struct holds state for the primary LCG, as well as the current configuration controlling which LCG to use when generating random numbers. See DungeonRand16Bit for more information on how the dungeon PRNG works.
        /// 
        /// type: struct prng_state
        /// </summary>
        public PrngState DungeonPrngState
        {
            get
            {
                if (f_dungeonPrngState)
                    return _dungeonPrngState;
                long _pos = m_io.Pos;
                m_io.Seek(487184);
                _dungeonPrngState = new PrngState(m_io);
                m_io.Seek(_pos);
                f_dungeonPrngState = true;
                return _dungeonPrngState;
            }
        }
        private bool f_bellyDrainInWallsInt;
        private ushort _bellyDrainInWallsInt;

        /// <summary>
        /// The additional amount by which belly is decreased every turn when inside walls (integer part)
        /// </summary>
        public ushort BellyDrainInWallsInt
        {
            get
            {
                if (f_bellyDrainInWallsInt)
                    return _bellyDrainInWallsInt;
                long _pos = m_io.Pos;
                m_io.Seek(483592);
                _bellyDrainInWallsInt = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_bellyDrainInWallsInt = true;
                return _bellyDrainInWallsInt;
            }
        }
        private bool f_twoTurnMovesAndStatuses;
        private TwoTurnMovesAndStatusesArray _twoTurnMovesAndStatuses;

        /// <summary>
        /// List that matches two-turn move IDs to their corresponding status ID. The last entry is null.
        /// </summary>
        public TwoTurnMovesAndStatusesArray TwoTurnMovesAndStatuses
        {
            get
            {
                if (f_twoTurnMovesAndStatuses)
                    return _twoTurnMovesAndStatuses;
                long _pos = m_io.Pos;
                m_io.Seek(484428);
                _twoTurnMovesAndStatuses = new TwoTurnMovesAndStatusesArray(m_io);
                m_io.Seek(_pos);
                f_twoTurnMovesAndStatuses = true;
                return _twoTurnMovesAndStatuses;
            }
        }
        private bool f_exclItemEffectsEvasionBoost;
        private ExclItemEffectsEvasionBoostArray _exclItemEffectsEvasionBoost;

        /// <summary>
        /// Array of IDs for exclusive item effects that grant an evasion boost with certain weather conditions.
        /// </summary>
        public ExclItemEffectsEvasionBoostArray ExclItemEffectsEvasionBoost
        {
            get
            {
                if (f_exclItemEffectsEvasionBoost)
                    return _exclItemEffectsEvasionBoost;
                long _pos = m_io.Pos;
                m_io.Seek(487600);
                _exclItemEffectsEvasionBoost = new ExclItemEffectsEvasionBoostArray(m_io);
                m_io.Seek(_pos);
                f_exclItemEffectsEvasionBoost = true;
                return _exclItemEffectsEvasionBoost;
            }
        }
        private bool f_statusIconArrayBurn;
        private StatusIconArrayBurnArray _statusIconArrayBurn;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::burn * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayBurnArray StatusIconArrayBurn
        {
            get
            {
                if (f_statusIconArrayBurn)
                    return _statusIconArrayBurn;
                long _pos = m_io.Pos;
                m_io.Seek(478260);
                _statusIconArrayBurn = new StatusIconArrayBurnArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayBurn = true;
                return _statusIconArrayBurn;
            }
        }
        private bool f_fixedRoomEntitySpawnTable;
        private FixedRoomEntitySpawnTableArray _fixedRoomEntitySpawnTable;

        /// <summary>
        /// Table of entities (items, monsters, tiles) that can spawn in fixed rooms, which is indexed into by the main data structure for each fixed room.
        /// 
        /// This is an array of 269 entries. Each entry contains 3 pointers (one into FIXED_ROOM_ITEM_SPAWN_TABLE, one into FIXED_ROOM_MONSTER_SPAWN_TABLE, and one into FIXED_ROOM_TILE_SPAWN_TABLE), and represents the entities that can spawn on one specific tile in a fixed room.
        /// 
        /// type: struct fixed_room_entity_spawn_entry[269]
        /// </summary>
        public FixedRoomEntitySpawnTableArray FixedRoomEntitySpawnTable
        {
            get
            {
                if (f_fixedRoomEntitySpawnTable)
                    return _fixedRoomEntitySpawnTable;
                long _pos = m_io.Pos;
                m_io.Seek(474252);
                _fixedRoomEntitySpawnTable = new FixedRoomEntitySpawnTableArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomEntitySpawnTable = true;
                return _fixedRoomEntitySpawnTable;
            }
        }
        private bool f_statusIconArrayCurse;
        private StatusIconArrayCurseArray _statusIconArrayCurse;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::curse * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayCurseArray StatusIconArrayCurse
        {
            get
            {
                if (f_statusIconArrayCurse)
                    return _statusIconArrayCurse;
                long _pos = m_io.Pos;
                m_io.Seek(478428);
                _statusIconArrayCurse = new StatusIconArrayCurseArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayCurse = true;
                return _statusIconArrayCurse;
            }
        }
        private bool f_atkStatIdx;
        private int _atkStatIdx;

        /// <summary>
        /// The index (0) of the attack entry in internal stat structs, such as the stat modifier array for a monster.
        /// </summary>
        public int AtkStatIdx
        {
            get
            {
                if (f_atkStatIdx)
                    return _atkStatIdx;
                long _pos = m_io.Pos;
                m_io.Seek(484492);
                _atkStatIdx = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_atkStatIdx = true;
                return _atkStatIdx;
            }
        }
        private bool f_attackSpriteBufferSize;
        private int _attackSpriteBufferSize;

        /// <summary>
        /// Size of the buffer used to store the current attack sprite file.
        /// </summary>
        public int AttackSpriteBufferSize
        {
            get
            {
                if (f_attackSpriteBufferSize)
                    return _attackSpriteBufferSize;
                long _pos = m_io.Pos;
                m_io.Seek(109512);
                _attackSpriteBufferSize = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_attackSpriteBufferSize = true;
                return _attackSpriteBufferSize;
            }
        }
        private bool f_statusIconArrayMuzzled;
        private StatusIconArrayMuzzledArray _statusIconArrayMuzzled;

        /// <summary>
        /// Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::muzzled * 8. See UpdateStatusIconFlags for details.
        /// </summary>
        public StatusIconArrayMuzzledArray StatusIconArrayMuzzled
        {
            get
            {
                if (f_statusIconArrayMuzzled)
                    return _statusIconArrayMuzzled;
                long _pos = m_io.Pos;
                m_io.Seek(478044);
                _statusIconArrayMuzzled = new StatusIconArrayMuzzledArray(m_io);
                m_io.Seek(_pos);
                f_statusIconArrayMuzzled = true;
                return _statusIconArrayMuzzled;
            }
        }
        private bool f_damageMultiplier05;
        private Fx6416 _damageMultiplier05;

        /// <summary>
        /// A generic damage multiplier of 0.5 used in various places, as a 64-bit fixed-point number with 16 fraction bits.
        /// </summary>
        public Fx6416 DamageMultiplier05
        {
            get
            {
                if (f_damageMultiplier05)
                    return _damageMultiplier05;
                long _pos = m_io.Pos;
                m_io.Seek(483804);
                _damageMultiplier05 = new Fx6416(m_io);
                m_io.Seek(_pos);
                f_damageMultiplier05 = true;
                return _damageMultiplier05;
            }
        }
        private Overlay29Data m_root;
        private KaitaiStruct m_parent;
        public Overlay29Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
