// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Arm9Data : KaitaiStruct
    {
        public static Arm9Data FromFile(string fileName)
        {
            return new Arm9Data(new KaitaiStream(fileName));
        }

        public Arm9Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Arm9Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_arm9UnknownDataNa209e6bc = false;
            f_defaultPartnerId = false;
            f_itemTablesPtrs1 = false;
            f_loadedOverlayGroup2 = false;
            f_clientLevelTable = false;
            f_missionDungeonListPtr = false;
            f_startModuleParams = false;
            f_actorList = false;
            f_optionsMenuDefaultWindowParams = false;
            f_kecleonShopItemTableLists1 = false;
            f_maxRecruitableTeamMembers1 = false;
            f_jobMenuItems1 = false;
            f_isDispOn = false;
            f_scriptVarsValuesPtr1 = false;
            f_damageFormulaAtPrefactor = false;
            f_missionMenuStringIds1 = false;
            f_bagCapacityTable = false;
            f_parentMenuDefaultWindowParams = false;
            f_smdEventsFunTable = false;
            f_maxMoneyStored = false;
            f_unownSpeciesAdditionalChars = false;
            f_numberOfItems1 = false;
            f_cafeMissionRewardTypeWeights = false;
            f_stringDebugLogNull = false;
            f_missionBannedStoryMonsters = false;
            f_exclusiveItemDefenseBoosts = false;
            f_arm9UnknownTableNa2097ff8 = false;
            f_scriptVarsValuesPtr2 = false;
            f_teamSelectionMenuDefaultWindowParams = false;
            f_texPlttStartAddrTable = false;
            f_missionDeliverCount = false;
            f_missionBannedMonsters = false;
            f_eggStatBonuses = false;
            f_powerBandStatBoost = false;
            f_auraBowStatBoost = false;
            f_defScarfStatBoost = false;
            f_rankUpTable = false;
            f_eggHpBonus = false;
            f_recoilMoveList = false;
            f_auraBowIdLast = false;
            f_stringDebugNewline = false;
            f_recycleShopItemList = false;
            f_alertBoxDefaultWindowParams = false;
            f_gameMode = false;
            f_remoteStringPtrTable = false;
            f_stringBalanceMLevelBin = false;
            f_exclusiveItemEffectData = false;
            f_scrollBoxDefaultWindowParams = false;
            f_exclusiveItemStatBoostData = false;
            f_numberOfItems0 = false;
            f_defaultMissionRewardTypeWeights = false;
            f_noSendItemTable = false;
            f_jobMenuItems11 = false;
            f_arm9UnknownTableNa20a68bc = false;
            f_stringDebugNoProgPos = false;
            f_outlawMinionLevelTable = false;
            f_texStartAddrTable = false;
            f_stringEffectEffectBin = false;
            f_jobWindowParams1 = false;
            f_dungeonSwapIdTable = false;
            f_portraitBoxDefaultWindowParams = false;
            f_arm9UnknownTableNa209e12c = false;
            f_evolutionPhysicalStatBonuses = false;
            f_damageFormulaConstantShift = false;
            f_exclusiveItemSpecialDefenseBoosts = false;
            f_sentryDutyMonsterIds = false;
            f_iqGummiGainTable = false;
            f_loadedOverlayGroup1 = false;
            f_exclusiveItemPpBoostAmount = false;
            f_iqSkills = false;
            f_guestMonsterData = false;
            f_arm9UnknownTableNa209e280 = false;
            f_missionFloorRanksAndItemLists2 = false;
            f_missionDeliverListPtr = false;
            f_adventureLogEncountersMonsterIds = false;
            f_forbiddenForgotMoveList = false;
            f_wonderGummiIqGain = false;
            f_damageFormulaNonTeamMemberModifier = false;
            f_levelList = false;
            f_stringFileDirectoryInit = false;
            f_exclusiveItemSpecialAttackBoosts = false;
            f_outlawLevelTable = false;
            f_jobMenuItems7 = false;
            f_areaNameBoxDefaultWindowParams = false;
            f_hiddenPowerBasePowerTable = false;
            f_jobMenuItems13 = false;
            f_minIqExclusiveMoveUser = false;
            f_wonderMailEncryptionTable = false;
            f_moneyQuantityTable = false;
            f_wonderMailBitsMap = false;
            f_defaultHeroId = false;
            f_jobMenuItems8 = false;
            f_stringDebugStringNewline = false;
            f_dungeonRestrictions = false;
            f_prngSequenceNum = false;
            f_statusesFullDescriptionStringIds = false;
            f_missionDungeonCount = false;
            f_outlawMissionRewardTypeWeights = false;
            f_notifyNote = false;
            f_maxRecruitableTeamMembers0 = false;
            f_secure = false;
            f_cartRemovedImgData = false;
            f_collectionMenuDefaultWindowParams = false;
            f_evolutionHpBonus = false;
            f_minIqItemMaster = false;
            f_stringDebugEmpty = false;
            f_availableItemsInGroupTable = false;
            f_arm9UnknownTableNa20ae924 = false;
            f_moveAccuracyStarsTable = false;
            f_maxMoneyCarried = false;
            f_trigTable = false;
            f_stringMonsterMAttackBin = false;
            f_unownSpeciesAdditionalCharPtrTable = false;
            f_debugIsInitialized = false;
            f_packFilesOpened = false;
            f_remoteStrings = false;
            f_scriptVarsLocals = false;
            f_stringDebugFatal = false;
            f_portraitLayouts = false;
            f_missionValidationFunctionList = false;
            f_gummiBellyRestoreTable = false;
            f_fxAtanIdxTable = false;
            f_scriptVars = false;
            f_missionMonsterListPtr = false;
            f_missionStringIds = false;
            f_jobMenuItems10 = false;
            f_specialBandStatBoost = false;
            f_versionExclusiveMonsters = false;
            f_damageFormulaLnArgPrefactor = false;
            f_dialogueBoxDefaultWindowParams = false;
            f_itemDeliveryTable = false;
            f_damageFormulaFlvShift = false;
            f_jobMenuItems9 = false;
            f_exclusiveItemStatBoostDataIndexes = false;
            f_wonderMailBitsSwap = false;
            f_maxPlayTime = false;
            f_damageFormulaLnPrefactor = false;
            f_teamMemberTablePtr = false;
            f_scriptVarsValuesPtr3 = false;
            f_tblTalkGroupStringIdStart = false;
            f_memoryAllocationArenaGetters = false;
            f_dsDownloadTeams = false;
            f_missionFloorsForbidden = false;
            f_kecleonShopItemTableLists2 = false;
            f_jobMenuItems6 = false;
            f_lfoOutputVoiceUpdateFlags = false;
            f_specialEpisodeMainCharacters = false;
            f_arm9UnknownPtrNa20a2c84 = false;
            f_iqSkillRestrictions = false;
            f_musicDurationLookupTable1 = false;
            f_simpleMenuDefaultWindowParams = false;
            f_jobMenuItems3 = false;
            f_arm9UnknownDataNa209eaac = false;
            f_movePowerStarsTable = false;
            f_moveDataTablePtr = false;
            f_stringMonsterMGroundBin = false;
            f_jobMenuItems4 = false;
            f_advancedTextBoxDefaultWindowParams = false;
            f_gummiStatBoost = false;
            f_kaomadoFilepath = false;
            f_rankStrings1 = false;
            f_demoTeams = false;
            f_render3d = false;
            f_missionFloorRanksAndItemLists1 = false;
            f_missionMenuStringIds2 = false;
            f_partnerTalkKindTable = false;
            f_rankStrings2 = false;
            f_wonderGummiStatBoost = false;
            f_iqGroupSkills = false;
            f_keyboardStringIds = false;
            f_missionFloorRanksPtrs = false;
            f_controlsChartDefaultWindowParams = false;
            f_arm9UnknownTableNa209e164 = false;
            f_jobMenuItems2 = false;
            f_missionMonsterCount = false;
            f_entities = false;
            f_bagCapacityTableSpecialEpisodes = false;
            f_missionListPtr = false;
            f_damageFormulaFlvDeficitDivisor = false;
            f_tacticNameStringIds = false;
            f_globalProgressPtr = false;
            f_monsterDataTablePtr = false;
            f_rankStrings3 = false;
            f_missionDungeonUnlockTable = false;
            f_monsterIdLimit = false;
            f_musicDurationLookupTable2 = false;
            f_packFilePathsTable = false;
            f_monsterSpriteData = false;
            f_arm9UnknownTableNa20a20b0 = false;
            f_secondaryTerrainTypes = false;
            f_munchBeltStatBoost = false;
            f_gxiDmaId = false;
            f_stringDungeonDungeonBin = false;
            f_unknownPpBoostAmount = false;
            f_bagItemsPtrMirror = false;
            f_lfoWaveformCallbacks = false;
            f_wanTable = false;
            f_stringDebugFormatLineFile = false;
            f_typeSpecificExclusiveItems = false;
            f_jobWindowParams2 = false;
            f_missionRankPoints = false;
            f_debugMenuDefaultWindowParams = false;
            f_render3dFunctions64 = false;
            f_naturalLogValueTable = false;
            f_evolutionSpecialStatBonuses = false;
            f_itemDataTablePtrs = false;
            f_punchMoveList = false;
            f_damageFormulaDefPrefactor = false;
            f_events = false;
            f_dungeonReturnStatusTable = false;
            f_zincBandStatBoost = false;
            f_mapMarkerPlacements = false;
            f_advancedMenuDefaultWindowParams = false;
            f_multitalentPpBoostAmount = false;
            f_rankStringPtrTable = false;
            f_stringMonsterMonsterBin = false;
            f_defaultMemoryArenaSize = false;
            f_jobMenuItems12 = false;
            f_dungeonDataList = false;
            f_stringDebugSpacedPrint = false;
            f_tacticsUnlockLevelTable = false;
            f_loadedOverlayGroup0 = false;
            f_adventureLogPtr = false;
            f_textBoxDefaultWindowParams = false;
            f_scriptVarsValuesPtr0 = false;
            f_statusNameStringIds = false;
            f_jobMenuItems5 = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_arm9UnknownDataNa209e6bc;
        private List<byte> _arm9UnknownDataNa209e6bc;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownDataNa209e6bc
        {
            get
            {
                if (f_arm9UnknownDataNa209e6bc)
                    return _arm9UnknownDataNa209e6bc;
                long _pos = m_io.Pos;
                m_io.Seek(650304);
                _arm9UnknownDataNa209e6bc = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _arm9UnknownDataNa209e6bc.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownDataNa209e6bc = true;
                return _arm9UnknownDataNa209e6bc;
            }
        }
        private bool f_defaultPartnerId;
        private MonsterId16 _defaultPartnerId;

        /// <summary>
        /// The default monster ID for the partner (0x1: Bulbasaur)
        /// 
        /// type: struct monster_id_16
        /// </summary>
        public MonsterId16 DefaultPartnerId
        {
            get
            {
                if (f_defaultPartnerId)
                    return _defaultPartnerId;
                long _pos = m_io.Pos;
                m_io.Seek(722970);
                _defaultPartnerId = new MonsterId16(m_io);
                m_io.Seek(_pos);
                f_defaultPartnerId = true;
                return _defaultPartnerId;
            }
        }
        private bool f_itemTablesPtrs1;
        private ItemTablesPtrs1Array _itemTablesPtrs1;

        /// <summary>
        /// Irdkwia's notes: 26*0x4, uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS
        /// </summary>
        public ItemTablesPtrs1Array ItemTablesPtrs1
        {
            get
            {
                if (f_itemTablesPtrs1)
                    return _itemTablesPtrs1;
                long _pos = m_io.Pos;
                m_io.Seek(725604);
                _itemTablesPtrs1 = new ItemTablesPtrs1Array(m_io);
                m_io.Seek(_pos);
                f_itemTablesPtrs1 = true;
                return _itemTablesPtrs1;
            }
        }
        private bool f_loadedOverlayGroup2;
        private OverlayGroupId _loadedOverlayGroup2;

        /// <summary>
        /// [Runtime] The overlay group ID of the overlay currently loaded in slot 2. A group ID of 0 denotes no overlay.
        /// 
        /// Overlay group IDs that can be loaded in slot 2:
        /// - 0x1 (overlay 0)
        /// - 0x2 (overlay 10)
        /// - 0x3 (overlay 35)
        /// 
        /// type: enum overlay_group_id
        /// </summary>
        public OverlayGroupId LoadedOverlayGroup2
        {
            get
            {
                if (f_loadedOverlayGroup2)
                    return _loadedOverlayGroup2;
                long _pos = m_io.Pos;
                m_io.Seek(719576);
                _loadedOverlayGroup2 = new OverlayGroupId(m_io);
                m_io.Seek(_pos);
                f_loadedOverlayGroup2 = true;
                return _loadedOverlayGroup2;
            }
        }
        private bool f_clientLevelTable;
        private ClientLevelTableArray _clientLevelTable;

        /// <summary>
        /// Still a guess
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[16]
        /// </summary>
        public ClientLevelTableArray ClientLevelTable
        {
            get
            {
                if (f_clientLevelTable)
                    return _clientLevelTable;
                long _pos = m_io.Pos;
                m_io.Seek(663292);
                _clientLevelTable = new ClientLevelTableArray(m_io);
                m_io.Seek(_pos);
                f_clientLevelTable = true;
                return _clientLevelTable;
            }
        }
        private bool f_missionDungeonListPtr;
        private Pointer _missionDungeonListPtr;

        /// <summary>
        /// A pointer to a heap-allocated list of dungeons usable for missions
        /// </summary>
        public Pointer MissionDungeonListPtr
        {
            get
            {
                if (f_missionDungeonListPtr)
                    return _missionDungeonListPtr;
                long _pos = m_io.Pos;
                m_io.Seek(725932);
                _missionDungeonListPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_missionDungeonListPtr = true;
                return _missionDungeonListPtr;
            }
        }
        private bool f_startModuleParams;
        private Pointer _startModuleParams;

        /// <summary>
        /// Parameters used by the NitroSDK to read the ROM.
        /// </summary>
        public Pointer StartModuleParams
        {
            get
            {
                if (f_startModuleParams)
                    return _startModuleParams;
                long _pos = m_io.Pos;
                m_io.Seek(2976);
                _startModuleParams = new Pointer(m_io);
                m_io.Seek(_pos);
                f_startModuleParams = true;
                return _startModuleParams;
            }
        }
        private bool f_actorList;
        private List<byte> _actorList;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> ActorList
        {
            get
            {
                if (f_actorList)
                    return _actorList;
                long _pos = m_io.Pos;
                m_io.Seek(684464);
                _actorList = new List<byte>();
                for (var i = 0; i < 10488; i++)
                {
                    _actorList.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_actorList = true;
                return _actorList;
            }
        }
        private bool f_optionsMenuDefaultWindowParams;
        private WindowParams _optionsMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for an options_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateOptionsMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateOptionsMenu.
        /// </summary>
        public WindowParams OptionsMenuDefaultWindowParams
        {
            get
            {
                if (f_optionsMenuDefaultWindowParams)
                    return _optionsMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635916);
                _optionsMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_optionsMenuDefaultWindowParams = true;
                return _optionsMenuDefaultWindowParams;
            }
        }
        private bool f_kecleonShopItemTableLists1;
        private KecleonShopItemTableLists1Array _kecleonShopItemTableLists1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: enum item_id[4]
        /// </summary>
        public KecleonShopItemTableLists1Array KecleonShopItemTableLists1
        {
            get
            {
                if (f_kecleonShopItemTableLists1)
                    return _kecleonShopItemTableLists1;
                long _pos = m_io.Pos;
                m_io.Seek(623876);
                _kecleonShopItemTableLists1 = new KecleonShopItemTableLists1Array(m_io);
                m_io.Seek(_pos);
                f_kecleonShopItemTableLists1 = true;
                return _kecleonShopItemTableLists1;
            }
        }
        private bool f_maxRecruitableTeamMembers1;
        private uint _maxRecruitableTeamMembers1;

        /// <summary>
        /// 555, appears to be the maximum number of members recruited to an exploration team, at least for the purposes of some checks that need to iterate over all team members.
        /// </summary>
        public uint MaxRecruitableTeamMembers1
        {
            get
            {
                if (f_maxRecruitableTeamMembers1)
                    return _maxRecruitableTeamMembers1;
                long _pos = m_io.Pos;
                m_io.Seek(350664);
                _maxRecruitableTeamMembers1 = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_maxRecruitableTeamMembers1 = true;
                return _maxRecruitableTeamMembers1;
            }
        }
        private bool f_jobMenuItems1;
        private JobMenuItems1Array _jobMenuItems1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems1Array JobMenuItems1
        {
            get
            {
                if (f_jobMenuItems1)
                    return _jobMenuItems1;
                long _pos = m_io.Pos;
                m_io.Seek(694984);
                _jobMenuItems1 = new JobMenuItems1Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems1 = true;
                return _jobMenuItems1;
            }
        }
        private bool f_isDispOn;
        private byte _isDispOn;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public byte IsDispOn
        {
            get
            {
                if (f_isDispOn)
                    return _isDispOn;
                long _pos = m_io.Pos;
                m_io.Seek(734424);
                _isDispOn = m_io.ReadU1();
                m_io.Seek(_pos);
                f_isDispOn = true;
                return _isDispOn;
            }
        }
        private bool f_scriptVarsValuesPtr1;
        private Pointer _scriptVarsValuesPtr1;

        /// <summary>
        /// Hard-coded pointer to SCRIPT_VARS_VALUES.
        /// </summary>
        public Pointer ScriptVarsValuesPtr1
        {
            get
            {
                if (f_scriptVarsValuesPtr1)
                    return _scriptVarsValuesPtr1;
                long _pos = m_io.Pos;
                m_io.Seek(309276);
                _scriptVarsValuesPtr1 = new Pointer(m_io);
                m_io.Seek(_pos);
                f_scriptVarsValuesPtr1 = true;
                return _scriptVarsValuesPtr1;
            }
        }
        private bool f_damageFormulaAtPrefactor;
        private int _damageFormulaAtPrefactor;

        /// <summary>
        /// The prefactor to the &quot;AT&quot; (attack) intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_at), as a binary fixed-point number with 8 fraction bits (153/256, which is close to 0.6).
        /// </summary>
        public int DamageFormulaAtPrefactor
        {
            get
            {
                if (f_damageFormulaAtPrefactor)
                    return _damageFormulaAtPrefactor;
                long _pos = m_io.Pos;
                m_io.Seek(663160);
                _damageFormulaAtPrefactor = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaAtPrefactor = true;
                return _damageFormulaAtPrefactor;
            }
        }
        private bool f_missionMenuStringIds1;
        private MissionMenuStringIds1Array _missionMenuStringIds1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[8]
        /// </summary>
        public MissionMenuStringIds1Array MissionMenuStringIds1
        {
            get
            {
                if (f_missionMenuStringIds1)
                    return _missionMenuStringIds1;
                long _pos = m_io.Pos;
                m_io.Seek(672156);
                _missionMenuStringIds1 = new MissionMenuStringIds1Array(m_io);
                m_io.Seek(_pos);
                f_missionMenuStringIds1 = true;
                return _missionMenuStringIds1;
            }
        }
        private bool f_bagCapacityTable;
        private BagCapacityTableArray _bagCapacityTable;

        /// <summary>
        /// Array of 4-byte integers containing the bag capacity for each bag level.
        /// 
        /// type: uint32_t[8]
        /// </summary>
        public BagCapacityTableArray BagCapacityTable
        {
            get
            {
                if (f_bagCapacityTable)
                    return _bagCapacityTable;
                long _pos = m_io.Pos;
                m_io.Seek(666968);
                _bagCapacityTable = new BagCapacityTableArray(m_io);
                m_io.Seek(_pos);
                f_bagCapacityTable = true;
                return _bagCapacityTable;
            }
        }
        private bool f_parentMenuDefaultWindowParams;
        private WindowParams _parentMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a simple_menu created with CreateParentMenuInternal.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateParentMenuInternal.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateParentMenuInternal.
        /// </summary>
        public WindowParams ParentMenuDefaultWindowParams
        {
            get
            {
                if (f_parentMenuDefaultWindowParams)
                    return _parentMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635852);
                _parentMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_parentMenuDefaultWindowParams = true;
                return _parentMenuDefaultWindowParams;
            }
        }
        private bool f_smdEventsFunTable;
        private SmdEventsFunTableArray _smdEventsFunTable;

        /// <summary>
        /// Table of all DSE events, see https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/
        /// 
        /// Irdkwia's notes: named DSEEventFunctionPtrTable with length 0x3C0 (note the disagreement), 240*0x4.
        /// </summary>
        public SmdEventsFunTableArray SmdEventsFunTable
        {
            get
            {
                if (f_smdEventsFunTable)
                    return _smdEventsFunTable;
                long _pos = m_io.Pos;
                m_io.Seek(726228);
                _smdEventsFunTable = new SmdEventsFunTableArray(m_io);
                m_io.Seek(_pos);
                f_smdEventsFunTable = true;
                return _smdEventsFunTable;
            }
        }
        private bool f_maxMoneyStored;
        private uint _maxMoneyStored;

        /// <summary>
        /// Maximum amount of money the player can store in the Duskull Bank, 9999999.
        /// </summary>
        public uint MaxMoneyStored
        {
            get
            {
                if (f_maxMoneyStored)
                    return _maxMoneyStored;
                long _pos = m_io.Pos;
                m_io.Seek(67576);
                _maxMoneyStored = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_maxMoneyStored = true;
                return _maxMoneyStored;
            }
        }
        private bool f_unownSpeciesAdditionalChars;
        private UnownSpeciesAdditionalCharsArray _unownSpeciesAdditionalChars;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: enum monster_id[28]
        /// </summary>
        public UnownSpeciesAdditionalCharsArray UnownSpeciesAdditionalChars
        {
            get
            {
                if (f_unownSpeciesAdditionalChars)
                    return _unownSpeciesAdditionalChars;
                long _pos = m_io.Pos;
                m_io.Seek(668172);
                _unownSpeciesAdditionalChars = new UnownSpeciesAdditionalCharsArray(m_io);
                m_io.Seek(_pos);
                f_unownSpeciesAdditionalChars = true;
                return _unownSpeciesAdditionalChars;
            }
        }
        private bool f_numberOfItems1;
        private uint _numberOfItems1;

        /// <summary>
        /// Number of items in the game.
        /// </summary>
        public uint NumberOfItems1
        {
            get
            {
                if (f_numberOfItems1)
                    return _numberOfItems1;
                long _pos = m_io.Pos;
                m_io.Seek(59696);
                _numberOfItems1 = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_numberOfItems1 = true;
                return _numberOfItems1;
            }
        }
        private bool f_cafeMissionRewardTypeWeights;
        private CafeMissionRewardTypeWeightsArray _cafeMissionRewardTypeWeights;

        /// <summary>
        /// Weights for each possible mission_reward_type, used only by cafe mission generation.
        /// Seems identical to DEFAULT_MISSION_REWARD_TYPE_WEIGHTS.
        /// </summary>
        public CafeMissionRewardTypeWeightsArray CafeMissionRewardTypeWeights
        {
            get
            {
                if (f_cafeMissionRewardTypeWeights)
                    return _cafeMissionRewardTypeWeights;
                long _pos = m_io.Pos;
                m_io.Seek(672456);
                _cafeMissionRewardTypeWeights = new CafeMissionRewardTypeWeightsArray(m_io);
                m_io.Seek(_pos);
                f_cafeMissionRewardTypeWeights = true;
                return _cafeMissionRewardTypeWeights;
            }
        }
        private bool f_stringDebugLogNull;
        private StringDebugLogNullArray _stringDebugLogNull;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugLogNullArray StringDebugLogNull
        {
            get
            {
                if (f_stringDebugLogNull)
                    return _stringDebugLogNull;
                long _pos = m_io.Pos;
                m_io.Seek(610132);
                _stringDebugLogNull = new StringDebugLogNullArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugLogNull = true;
                return _stringDebugLogNull;
            }
        }
        private bool f_missionBannedStoryMonsters;
        private MissionBannedStoryMonstersArray _missionBannedStoryMonsters;

        /// <summary>
        /// Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions before a certain point in the story.
        /// 
        /// To be precise, PERFOMANCE_PROGRESS_FLAG[9] must be enabled so these monsters can appear as mission clients.
        /// 
        /// type: struct monster_id_16[length / 2]
        /// </summary>
        public MissionBannedStoryMonstersArray MissionBannedStoryMonsters
        {
            get
            {
                if (f_missionBannedStoryMonsters)
                    return _missionBannedStoryMonsters;
                long _pos = m_io.Pos;
                m_io.Seek(672532);
                _missionBannedStoryMonsters = new MissionBannedStoryMonstersArray(m_io);
                m_io.Seek(_pos);
                f_missionBannedStoryMonsters = true;
                return _missionBannedStoryMonsters;
            }
        }
        private bool f_exclusiveItemDefenseBoosts;
        private List<byte> _exclusiveItemDefenseBoosts;

        /// <summary>
        /// EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 1
        /// </summary>
        public List<byte> ExclusiveItemDefenseBoosts
        {
            get
            {
                if (f_exclusiveItemDefenseBoosts)
                    return _exclusiveItemDefenseBoosts;
                long _pos = m_io.Pos;
                m_io.Seek(623917);
                _exclusiveItemDefenseBoosts = new List<byte>();
                for (var i = 0; i < 57; i++)
                {
                    _exclusiveItemDefenseBoosts.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_exclusiveItemDefenseBoosts = true;
                return _exclusiveItemDefenseBoosts;
            }
        }
        private bool f_arm9UnknownTableNa2097ff8;
        private List<byte> _arm9UnknownTableNa2097ff8;

        /// <summary>
        /// 16*0x4 (0x2+0x2)
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa2097ff8
        {
            get
            {
                if (f_arm9UnknownTableNa2097ff8)
                    return _arm9UnknownTableNa2097ff8;
                long _pos = m_io.Pos;
                m_io.Seek(623684);
                _arm9UnknownTableNa2097ff8 = new List<byte>();
                for (var i = 0; i < 64; i++)
                {
                    _arm9UnknownTableNa2097ff8.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa2097ff8 = true;
                return _arm9UnknownTableNa2097ff8;
            }
        }
        private bool f_scriptVarsValuesPtr2;
        private Pointer _scriptVarsValuesPtr2;

        /// <summary>
        /// Hard-coded pointer to SCRIPT_VARS_VALUES.
        /// </summary>
        public Pointer ScriptVarsValuesPtr2
        {
            get
            {
                if (f_scriptVarsValuesPtr2)
                    return _scriptVarsValuesPtr2;
                long _pos = m_io.Pos;
                m_io.Seek(313188);
                _scriptVarsValuesPtr2 = new Pointer(m_io);
                m_io.Seek(_pos);
                f_scriptVarsValuesPtr2 = true;
                return _scriptVarsValuesPtr2;
            }
        }
        private bool f_teamSelectionMenuDefaultWindowParams;
        private WindowParams _teamSelectionMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a team_selection_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateTeamSelectionMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateTeamSelectionMenu.
        /// </summary>
        public WindowParams TeamSelectionMenuDefaultWindowParams
        {
            get
            {
                if (f_teamSelectionMenuDefaultWindowParams)
                    return _teamSelectionMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636144);
                _teamSelectionMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_teamSelectionMenuDefaultWindowParams = true;
                return _teamSelectionMenuDefaultWindowParams;
            }
        }
        private bool f_texPlttStartAddrTable;
        private TexPlttStartAddrTableArray _texPlttStartAddrTable;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public TexPlttStartAddrTableArray TexPlttStartAddrTable
        {
            get
            {
                if (f_texPlttStartAddrTable)
                    return _texPlttStartAddrTable;
                long _pos = m_io.Pos;
                m_io.Seek(715092);
                _texPlttStartAddrTable = new TexPlttStartAddrTableArray(m_io);
                m_io.Seek(_pos);
                f_texPlttStartAddrTable = true;
                return _texPlttStartAddrTable;
            }
        }
        private bool f_missionDeliverCount;
        private int _missionDeliverCount;

        /// <summary>
        /// The total number of items usable for delivery missions
        /// </summary>
        public int MissionDeliverCount
        {
            get
            {
                if (f_missionDeliverCount)
                    return _missionDeliverCount;
                long _pos = m_io.Pos;
                m_io.Seek(725928);
                _missionDeliverCount = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_missionDeliverCount = true;
                return _missionDeliverCount;
            }
        }
        private bool f_missionBannedMonsters;
        private MissionBannedMonstersArray _missionBannedMonsters;

        /// <summary>
        /// Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions.
        /// 
        /// type: struct monster_id_16[124]
        /// </summary>
        public MissionBannedMonstersArray MissionBannedMonsters
        {
            get
            {
                if (f_missionBannedMonsters)
                    return _missionBannedMonsters;
                long _pos = m_io.Pos;
                m_io.Seek(672684);
                _missionBannedMonsters = new MissionBannedMonstersArray(m_io);
                m_io.Seek(_pos);
                f_missionBannedMonsters = true;
                return _missionBannedMonsters;
            }
        }
        private bool f_eggStatBonuses;
        private EggStatBonusesArray _eggStatBonuses;

        /// <summary>
        /// 0x2: Atk + 0x2: SpAtk + 0x2: Def + 0x2: SpDef
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public EggStatBonusesArray EggStatBonuses
        {
            get
            {
                if (f_eggStatBonuses)
                    return _eggStatBonuses;
                long _pos = m_io.Pos;
                m_io.Seek(663136);
                _eggStatBonuses = new EggStatBonusesArray(m_io);
                m_io.Seek(_pos);
                f_eggStatBonuses = true;
                return _eggStatBonuses;
            }
        }
        private bool f_powerBandStatBoost;
        private short _powerBandStatBoost;

        /// <summary>
        /// Stat boost value for the Power Band.
        /// </summary>
        public short PowerBandStatBoost
        {
            get
            {
                if (f_powerBandStatBoost)
                    return _powerBandStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663088);
                _powerBandStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_powerBandStatBoost = true;
                return _powerBandStatBoost;
            }
        }
        private bool f_auraBowStatBoost;
        private short _auraBowStatBoost;

        /// <summary>
        /// Stat boost value for the aura bows.
        /// </summary>
        public short AuraBowStatBoost
        {
            get
            {
                if (f_auraBowStatBoost)
                    return _auraBowStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663068);
                _auraBowStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_auraBowStatBoost = true;
                return _auraBowStatBoost;
            }
        }
        private bool f_defScarfStatBoost;
        private short _defScarfStatBoost;

        /// <summary>
        /// Stat boost value for the Defense Scarf.
        /// </summary>
        public short DefScarfStatBoost
        {
            get
            {
                if (f_defScarfStatBoost)
                    return _defScarfStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663084);
                _defScarfStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_defScarfStatBoost = true;
                return _defScarfStatBoost;
            }
        }
        private bool f_rankUpTable;
        private RankUpTableArray _rankUpTable;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public RankUpTableArray RankUpTable
        {
            get
            {
                if (f_rankUpTable)
                    return _rankUpTable;
                long _pos = m_io.Pos;
                m_io.Seek(667848);
                _rankUpTable = new RankUpTableArray(m_io);
                m_io.Seek(_pos);
                f_rankUpTable = true;
                return _rankUpTable;
            }
        }
        private bool f_eggHpBonus;
        private short _eggHpBonus;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public short EggHpBonus
        {
            get
            {
                if (f_eggHpBonus)
                    return _eggHpBonus;
                long _pos = m_io.Pos;
                m_io.Seek(663100);
                _eggHpBonus = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_eggHpBonus = true;
                return _eggHpBonus;
            }
        }
        private bool f_recoilMoveList;
        private RecoilMoveListArray _recoilMoveList;

        /// <summary>
        /// Null-terminated list of all the recoil moves, as 2-byte move IDs.
        /// 
        /// type: struct move_id_16[11]
        /// </summary>
        public RecoilMoveListArray RecoilMoveList
        {
            get
            {
                if (f_recoilMoveList)
                    return _recoilMoveList;
                long _pos = m_io.Pos;
                m_io.Seek(627128);
                _recoilMoveList = new RecoilMoveListArray(m_io);
                m_io.Seek(_pos);
                f_recoilMoveList = true;
                return _recoilMoveList;
            }
        }
        private bool f_auraBowIdLast;
        private ItemId _auraBowIdLast;

        /// <summary>
        /// Highest item ID of the aura bows.
        /// </summary>
        public ItemId AuraBowIdLast
        {
            get
            {
                if (f_auraBowIdLast)
                    return _auraBowIdLast;
                long _pos = m_io.Pos;
                m_io.Seek(52412);
                _auraBowIdLast = new ItemId(m_io);
                m_io.Seek(_pos);
                f_auraBowIdLast = true;
                return _auraBowIdLast;
            }
        }
        private bool f_stringDebugNewline;
        private StringDebugNewlineArray _stringDebugNewline;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugNewlineArray StringDebugNewline
        {
            get
            {
                if (f_stringDebugNewline)
                    return _stringDebugNewline;
                long _pos = m_io.Pos;
                m_io.Seek(610128);
                _stringDebugNewline = new StringDebugNewlineArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugNewline = true;
                return _stringDebugNewline;
            }
        }
        private bool f_recycleShopItemList;
        private List<byte> _recycleShopItemList;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> RecycleShopItemList
        {
            get
            {
                if (f_recycleShopItemList)
                    return _recycleShopItemList;
                long _pos = m_io.Pos;
                m_io.Seek(625936);
                _recycleShopItemList = new List<byte>();
                for (var i = 0; i < 864; i++)
                {
                    _recycleShopItemList.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_recycleShopItemList = true;
                return _recycleShopItemList;
            }
        }
        private bool f_alertBoxDefaultWindowParams;
        private WindowParams _alertBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for an alert_box.
        /// </summary>
        public WindowParams AlertBoxDefaultWindowParams
        {
            get
            {
                if (f_alertBoxDefaultWindowParams)
                    return _alertBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636112);
                _alertBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_alertBoxDefaultWindowParams = true;
                return _alertBoxDefaultWindowParams;
            }
        }
        private bool f_gameMode;
        private byte _gameMode;

        /// <summary>
        /// [Runtime] Game mode, see enum game_mode for possible values.
        /// 
        /// type: uint8_t
        /// </summary>
        public byte GameMode
        {
            get
            {
                if (f_gameMode)
                    return _gameMode;
                long _pos = m_io.Pos;
                m_io.Seek(723084);
                _gameMode = m_io.ReadU1();
                m_io.Seek(_pos);
                f_gameMode = true;
                return _gameMode;
            }
        }
        private bool f_remoteStringPtrTable;
        private RemoteStringPtrTableArray _remoteStringPtrTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: const char*[7]
        /// </summary>
        public RemoteStringPtrTableArray RemoteStringPtrTable
        {
            get
            {
                if (f_remoteStringPtrTable)
                    return _remoteStringPtrTable;
                long _pos = m_io.Pos;
                m_io.Seek(725952);
                _remoteStringPtrTable = new RemoteStringPtrTableArray(m_io);
                m_io.Seek(_pos);
                f_remoteStringPtrTable = true;
                return _remoteStringPtrTable;
            }
        }
        private bool f_stringBalanceMLevelBin;
        private StringBalanceMLevelBinArray _stringBalanceMLevelBin;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringBalanceMLevelBinArray StringBalanceMLevelBin
        {
            get
            {
                if (f_stringBalanceMLevelBin)
                    return _stringBalanceMLevelBin;
                long _pos = m_io.Pos;
                m_io.Seek(610184);
                _stringBalanceMLevelBin = new StringBalanceMLevelBinArray(m_io);
                m_io.Seek(_pos);
                f_stringBalanceMLevelBin = true;
                return _stringBalanceMLevelBin;
            }
        }
        private bool f_exclusiveItemEffectData;
        private ExclusiveItemEffectDataArray _exclusiveItemEffectData;

        /// <summary>
        /// Contains special effects for each exclusive item.
        /// 
        /// Each entry is 2 bytes, with the first entry corresponding to the first exclusive item (Prism Ruff). The first byte is the exclusive item effect ID, and the second byte is an index into other data tables (related to the more generic stat boosting effects for specific monsters).
        /// 
        /// type: struct exclusive_item_effect_entry[956]
        /// </summary>
        public ExclusiveItemEffectDataArray ExclusiveItemEffectData
        {
            get
            {
                if (f_exclusiveItemEffectData)
                    return _exclusiveItemEffectData;
                long _pos = m_io.Pos;
                m_io.Seek(623976);
                _exclusiveItemEffectData = new ExclusiveItemEffectDataArray(m_io);
                m_io.Seek(_pos);
                f_exclusiveItemEffectData = true;
                return _exclusiveItemEffectData;
            }
        }
        private bool f_scrollBoxDefaultWindowParams;
        private WindowParams _scrollBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for a scroll_box.
        /// </summary>
        public WindowParams ScrollBoxDefaultWindowParams
        {
            get
            {
                if (f_scrollBoxDefaultWindowParams)
                    return _scrollBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635992);
                _scrollBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_scrollBoxDefaultWindowParams = true;
                return _scrollBoxDefaultWindowParams;
            }
        }
        private bool f_exclusiveItemStatBoostData;
        private ExclusiveItemStatBoostDataArray _exclusiveItemStatBoostData;

        /// <summary>
        /// Contains stat boost effects for different exclusive item classes.
        /// 
        /// Each 4-byte entry contains the boost data for (attack, defense, special attack, special defense), 1 byte each, for a specific exclusive item class, indexed according to the stat boost data index list.
        /// 
        /// type: struct exclusive_item_stat_boost_entry[15]
        /// </summary>
        public ExclusiveItemStatBoostDataArray ExclusiveItemStatBoostData
        {
            get
            {
                if (f_exclusiveItemStatBoostData)
                    return _exclusiveItemStatBoostData;
                long _pos = m_io.Pos;
                m_io.Seek(623916);
                _exclusiveItemStatBoostData = new ExclusiveItemStatBoostDataArray(m_io);
                m_io.Seek(_pos);
                f_exclusiveItemStatBoostData = true;
                return _exclusiveItemStatBoostData;
            }
        }
        private bool f_numberOfItems0;
        private uint _numberOfItems0;

        /// <summary>
        /// Number of items in the game.
        /// </summary>
        public uint NumberOfItems0
        {
            get
            {
                if (f_numberOfItems0)
                    return _numberOfItems0;
                long _pos = m_io.Pos;
                m_io.Seek(59532);
                _numberOfItems0 = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_numberOfItems0 = true;
                return _numberOfItems0;
            }
        }
        private bool f_defaultMissionRewardTypeWeights;
        private DefaultMissionRewardTypeWeightsArray _defaultMissionRewardTypeWeights;

        /// <summary>
        /// Weights for each possible mission_reward_type, used for non-cafe missions.
        /// Seems identical to CAFE_MISSION_REWARD_TYPE_WEIGHTS.
        /// </summary>
        public DefaultMissionRewardTypeWeightsArray DefaultMissionRewardTypeWeights
        {
            get
            {
                if (f_defaultMissionRewardTypeWeights)
                    return _defaultMissionRewardTypeWeights;
                long _pos = m_io.Pos;
                m_io.Seek(672484);
                _defaultMissionRewardTypeWeights = new DefaultMissionRewardTypeWeightsArray(m_io);
                m_io.Seek(_pos);
                f_defaultMissionRewardTypeWeights = true;
                return _defaultMissionRewardTypeWeights;
            }
        }
        private bool f_noSendItemTable;
        private NoSendItemTableArray _noSendItemTable;

        /// <summary>
        /// A list of items that are forbidden from being used in a mission sent by Wonder Mail.
        /// 
        /// type: struct item_id_16[3]
        /// </summary>
        public NoSendItemTableArray NoSendItemTable
        {
            get
            {
                if (f_noSendItemTable)
                    return _noSendItemTable;
                long _pos = m_io.Pos;
                m_io.Seek(672434);
                _noSendItemTable = new NoSendItemTableArray(m_io);
                m_io.Seek(_pos);
                f_noSendItemTable = true;
                return _noSendItemTable;
            }
        }
        private bool f_jobMenuItems11;
        private JobMenuItems11Array _jobMenuItems11;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems11Array JobMenuItems11
        {
            get
            {
                if (f_jobMenuItems11)
                    return _jobMenuItems11;
                long _pos = m_io.Pos;
                m_io.Seek(695320);
                _jobMenuItems11 = new JobMenuItems11Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems11 = true;
                return _jobMenuItems11;
            }
        }
        private bool f_arm9UnknownTableNa20a68bc;
        private List<byte> _arm9UnknownTableNa20a68bc;

        /// <summary>
        /// 6*0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa20a68bc
        {
            get
            {
                if (f_arm9UnknownTableNa20a68bc)
                    return _arm9UnknownTableNa20a68bc;
                long _pos = m_io.Pos;
                m_io.Seek(684380);
                _arm9UnknownTableNa20a68bc = new List<byte>();
                for (var i = 0; i < 12; i++)
                {
                    _arm9UnknownTableNa20a68bc.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa20a68bc = true;
                return _arm9UnknownTableNa20a68bc;
            }
        }
        private bool f_stringDebugNoProgPos;
        private StringDebugNoProgPosArray _stringDebugNoProgPos;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugNoProgPosArray StringDebugNoProgPos
        {
            get
            {
                if (f_stringDebugNoProgPos)
                    return _stringDebugNoProgPos;
                long _pos = m_io.Pos;
                m_io.Seek(610072);
                _stringDebugNoProgPos = new StringDebugNoProgPosArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugNoProgPos = true;
                return _stringDebugNoProgPos;
            }
        }
        private bool f_outlawMinionLevelTable;
        private OutlawMinionLevelTableArray _outlawMinionLevelTable;

        /// <summary>
        /// Table of 2-byte outlaw minion levels for outlaw hideout missions, indexed by mission rank.
        /// 
        /// type: int16_t[16]
        /// </summary>
        public OutlawMinionLevelTableArray OutlawMinionLevelTable
        {
            get
            {
                if (f_outlawMinionLevelTable)
                    return _outlawMinionLevelTable;
                long _pos = m_io.Pos;
                m_io.Seek(663356);
                _outlawMinionLevelTable = new OutlawMinionLevelTableArray(m_io);
                m_io.Seek(_pos);
                f_outlawMinionLevelTable = true;
                return _outlawMinionLevelTable;
            }
        }
        private bool f_texStartAddrTable;
        private TexStartAddrTableArray _texStartAddrTable;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public TexStartAddrTableArray TexStartAddrTable
        {
            get
            {
                if (f_texStartAddrTable)
                    return _texStartAddrTable;
                long _pos = m_io.Pos;
                m_io.Seek(715108);
                _texStartAddrTable = new TexStartAddrTableArray(m_io);
                m_io.Seek(_pos);
                f_texStartAddrTable = true;
                return _texStartAddrTable;
            }
        }
        private bool f_stringEffectEffectBin;
        private StringEffectEffectBinArray _stringEffectEffectBin;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringEffectEffectBinArray StringEffectEffectBin
        {
            get
            {
                if (f_stringEffectEffectBin)
                    return _stringEffectEffectBin;
                long _pos = m_io.Pos;
                m_io.Seek(610144);
                _stringEffectEffectBin = new StringEffectEffectBinArray(m_io);
                m_io.Seek(_pos);
                f_stringEffectEffectBin = true;
                return _stringEffectEffectBin;
            }
        }
        private bool f_jobWindowParams1;
        private WindowParams _jobWindowParams1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams JobWindowParams1
        {
            get
            {
                if (f_jobWindowParams1)
                    return _jobWindowParams1;
                long _pos = m_io.Pos;
                m_io.Seek(694968);
                _jobWindowParams1 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_jobWindowParams1 = true;
                return _jobWindowParams1;
            }
        }
        private bool f_dungeonSwapIdTable;
        private DungeonSwapIdTableArray _dungeonSwapIdTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct dungeon_id_8[212]
        /// </summary>
        public DungeonSwapIdTableArray DungeonSwapIdTable
        {
            get
            {
                if (f_dungeonSwapIdTable)
                    return _dungeonSwapIdTable;
                long _pos = m_io.Pos;
                m_io.Seek(695424);
                _dungeonSwapIdTable = new DungeonSwapIdTableArray(m_io);
                m_io.Seek(_pos);
                f_dungeonSwapIdTable = true;
                return _dungeonSwapIdTable;
            }
        }
        private bool f_portraitBoxDefaultWindowParams;
        private WindowParams _portraitBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for a portrait_box.
        /// 
        /// Note that the screen and box type are unset, and are determined in CreatePortraitBox.
        /// </summary>
        public WindowParams PortraitBoxDefaultWindowParams
        {
            get
            {
                if (f_portraitBoxDefaultWindowParams)
                    return _portraitBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636024);
                _portraitBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_portraitBoxDefaultWindowParams = true;
                return _portraitBoxDefaultWindowParams;
            }
        }
        private bool f_arm9UnknownTableNa209e12c;
        private List<byte> _arm9UnknownTableNa209e12c;

        /// <summary>
        /// 52*0x2 + 2 bytes unused
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa209e12c
        {
            get
            {
                if (f_arm9UnknownTableNa209e12c)
                    return _arm9UnknownTableNa209e12c;
                long _pos = m_io.Pos;
                m_io.Seek(648880);
                _arm9UnknownTableNa209e12c = new List<byte>();
                for (var i = 0; i < 56; i++)
                {
                    _arm9UnknownTableNa209e12c.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa209e12c = true;
                return _arm9UnknownTableNa209e12c;
            }
        }
        private bool f_evolutionPhysicalStatBonuses;
        private EvolutionPhysicalStatBonusesArray _evolutionPhysicalStatBonuses;

        /// <summary>
        /// 0x2: Atk + 0x2: Def
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public EvolutionPhysicalStatBonusesArray EvolutionPhysicalStatBonuses
        {
            get
            {
                if (f_evolutionPhysicalStatBonuses)
                    return _evolutionPhysicalStatBonuses;
                long _pos = m_io.Pos;
                m_io.Seek(663124);
                _evolutionPhysicalStatBonuses = new EvolutionPhysicalStatBonusesArray(m_io);
                m_io.Seek(_pos);
                f_evolutionPhysicalStatBonuses = true;
                return _evolutionPhysicalStatBonuses;
            }
        }
        private bool f_damageFormulaConstantShift;
        private int _damageFormulaConstantShift;

        /// <summary>
        /// The constant shift applied to the overall output of the &quot;unshifted base&quot; damage formula (the sum of the scaled AT, DEF, and ClampedLn terms), as a binary fixed-point number with 8 fraction bits (-311).
        /// 
        /// The value of -311 is notably equal to -round[DAMAGE_FORMULA_LN_PREFACTOR * ln(DAMAGE_FORMULA_LN_ARG_PREFACTOR * DAMAGE_FORMULA_FLV_SHIFT)]. This is probably not a coincidence.
        /// </summary>
        public int DamageFormulaConstantShift
        {
            get
            {
                if (f_damageFormulaConstantShift)
                    return _damageFormulaConstantShift;
                long _pos = m_io.Pos;
                m_io.Seek(663128);
                _damageFormulaConstantShift = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaConstantShift = true;
                return _damageFormulaConstantShift;
            }
        }
        private bool f_exclusiveItemSpecialDefenseBoosts;
        private List<byte> _exclusiveItemSpecialDefenseBoosts;

        /// <summary>
        /// EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 3
        /// </summary>
        public List<byte> ExclusiveItemSpecialDefenseBoosts
        {
            get
            {
                if (f_exclusiveItemSpecialDefenseBoosts)
                    return _exclusiveItemSpecialDefenseBoosts;
                long _pos = m_io.Pos;
                m_io.Seek(623919);
                _exclusiveItemSpecialDefenseBoosts = new List<byte>();
                for (var i = 0; i < 57; i++)
                {
                    _exclusiveItemSpecialDefenseBoosts.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_exclusiveItemSpecialDefenseBoosts = true;
                return _exclusiveItemSpecialDefenseBoosts;
            }
        }
        private bool f_sentryDutyMonsterIds;
        private SentryDutyMonsterIdsArray _sentryDutyMonsterIds;

        /// <summary>
        /// Table of monster IDs usable in the sentry duty minigame.
        /// 
        /// type: struct monster_id_16[102]
        /// </summary>
        public SentryDutyMonsterIdsArray SentryDutyMonsterIds
        {
            get
            {
                if (f_sentryDutyMonsterIds)
                    return _sentryDutyMonsterIds;
                long _pos = m_io.Pos;
                m_io.Seek(663860);
                _sentryDutyMonsterIds = new SentryDutyMonsterIdsArray(m_io);
                m_io.Seek(_pos);
                f_sentryDutyMonsterIds = true;
                return _sentryDutyMonsterIds;
            }
        }
        private bool f_iqGummiGainTable;
        private IqGummiGainTableArray _iqGummiGainTable;

        /// <summary>
        /// type: int16_t[18][18]
        /// </summary>
        public IqGummiGainTableArray IqGummiGainTable
        {
            get
            {
                if (f_iqGummiGainTable)
                    return _iqGummiGainTable;
                long _pos = m_io.Pos;
                m_io.Seek(665652);
                _iqGummiGainTable = new IqGummiGainTableArray(m_io);
                m_io.Seek(_pos);
                f_iqGummiGainTable = true;
                return _iqGummiGainTable;
            }
        }
        private bool f_loadedOverlayGroup1;
        private OverlayGroupId _loadedOverlayGroup1;

        /// <summary>
        /// [Runtime] The overlay group ID of the overlay currently loaded in slot 1. A group ID of 0 denotes no overlay.
        /// 
        /// Overlay group IDs that can be loaded in slot 1:
        /// - 0x4 (overlay 1)
        /// - 0x5 (overlay 2)
        /// - 0xD (overlay 11)
        /// - 0xE (overlay 29)
        /// - 0xF (overlay 34)
        /// 
        /// type: enum overlay_group_id
        /// </summary>
        public OverlayGroupId LoadedOverlayGroup1
        {
            get
            {
                if (f_loadedOverlayGroup1)
                    return _loadedOverlayGroup1;
                long _pos = m_io.Pos;
                m_io.Seek(719572);
                _loadedOverlayGroup1 = new OverlayGroupId(m_io);
                m_io.Seek(_pos);
                f_loadedOverlayGroup1 = true;
                return _loadedOverlayGroup1;
            }
        }
        private bool f_exclusiveItemPpBoostAmount;
        private short _exclusiveItemPpBoostAmount;

        /// <summary>
        /// PP boost value for exclusive items that boost move PP.
        /// </summary>
        public short ExclusiveItemPpBoostAmount
        {
            get
            {
                if (f_exclusiveItemPpBoostAmount)
                    return _exclusiveItemPpBoostAmount;
                long _pos = m_io.Pos;
                m_io.Seek(663116);
                _exclusiveItemPpBoostAmount = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_exclusiveItemPpBoostAmount = true;
                return _exclusiveItemPpBoostAmount;
            }
        }
        private bool f_iqSkills;
        private IqSkillsArray _iqSkills;

        /// <summary>
        /// Table of 4-byte values for each IQ skill that represent the required IQ value to unlock a skill.
        /// 
        /// type: int[69]
        /// </summary>
        public IqSkillsArray IqSkills
        {
            get
            {
                if (f_iqSkills)
                    return _iqSkills;
                long _pos = m_io.Pos;
                m_io.Seek(664064);
                _iqSkills = new IqSkillsArray(m_io);
                m_io.Seek(_pos);
                f_iqSkills = true;
                return _iqSkills;
            }
        }
        private bool f_guestMonsterData;
        private GuestMonsterDataArray _guestMonsterData;

        /// <summary>
        /// Data for guest monsters that join you during certain story dungeons.
        /// 
        /// Array of 18 36-byte entries.
        /// 
        /// See the struct definitions and Frostbyte's dungeon data document for more info.
        /// 
        /// type: struct guest_monster[18]
        /// </summary>
        public GuestMonsterDataArray GuestMonsterData
        {
            get
            {
                if (f_guestMonsterData)
                    return _guestMonsterData;
                long _pos = m_io.Pos;
                m_io.Seek(667200);
                _guestMonsterData = new GuestMonsterDataArray(m_io);
                m_io.Seek(_pos);
                f_guestMonsterData = true;
                return _guestMonsterData;
            }
        }
        private bool f_arm9UnknownTableNa209e280;
        private List<byte> _arm9UnknownTableNa209e280;

        /// <summary>
        /// 32*0x1
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa209e280
        {
            get
            {
                if (f_arm9UnknownTableNa209e280)
                    return _arm9UnknownTableNa209e280;
                long _pos = m_io.Pos;
                m_io.Seek(649220);
                _arm9UnknownTableNa209e280 = new List<byte>();
                for (var i = 0; i < 32; i++)
                {
                    _arm9UnknownTableNa209e280.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa209e280 = true;
                return _arm9UnknownTableNa209e280;
            }
        }
        private bool f_missionFloorRanksAndItemLists2;
        private List<byte> _missionFloorRanksAndItemLists2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> MissionFloorRanksAndItemLists2
        {
            get
            {
                if (f_missionFloorRanksAndItemLists2)
                    return _missionFloorRanksAndItemLists2;
                long _pos = m_io.Pos;
                m_io.Seek(654688);
                _missionFloorRanksAndItemLists2 = new List<byte>();
                for (var i = 0; i < 4856; i++)
                {
                    _missionFloorRanksAndItemLists2.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_missionFloorRanksAndItemLists2 = true;
                return _missionFloorRanksAndItemLists2;
            }
        }
        private bool f_missionDeliverListPtr;
        private Pointer _missionDeliverListPtr;

        /// <summary>
        /// A pointer to a heap-allocated list of items usable for delivery missions
        /// </summary>
        public Pointer MissionDeliverListPtr
        {
            get
            {
                if (f_missionDeliverListPtr)
                    return _missionDeliverListPtr;
                long _pos = m_io.Pos;
                m_io.Seek(725924);
                _missionDeliverListPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_missionDeliverListPtr = true;
                return _missionDeliverListPtr;
            }
        }
        private bool f_adventureLogEncountersMonsterIds;
        private AdventureLogEncountersMonsterIdsArray _adventureLogEncountersMonsterIds;

        /// <summary>
        /// List of monster IDs with a corresponding milestone in the Adventure Log.
        /// 
        /// type: struct monster_id_16[38]
        /// </summary>
        public AdventureLogEncountersMonsterIdsArray AdventureLogEncountersMonsterIds
        {
            get
            {
                if (f_adventureLogEncountersMonsterIds)
                    return _adventureLogEncountersMonsterIds;
                long _pos = m_io.Pos;
                m_io.Seek(650228);
                _adventureLogEncountersMonsterIds = new AdventureLogEncountersMonsterIdsArray(m_io);
                m_io.Seek(_pos);
                f_adventureLogEncountersMonsterIds = true;
                return _adventureLogEncountersMonsterIds;
            }
        }
        private bool f_forbiddenForgotMoveList;
        private ForbiddenForgotMoveListArray _forbiddenForgotMoveList;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct forbidden_forgot_move_entry[3]
        /// </summary>
        public ForbiddenForgotMoveListArray ForbiddenForgotMoveList
        {
            get
            {
                if (f_forbiddenForgotMoveList)
                    return _forbiddenForgotMoveList;
                long _pos = m_io.Pos;
                m_io.Seek(663196);
                _forbiddenForgotMoveList = new ForbiddenForgotMoveListArray(m_io);
                m_io.Seek(_pos);
                f_forbiddenForgotMoveList = true;
                return _forbiddenForgotMoveList;
            }
        }
        private bool f_wonderGummiIqGain;
        private short _wonderGummiIqGain;

        /// <summary>
        /// IQ gain when ingesting wonder gummis.
        /// </summary>
        public short WonderGummiIqGain
        {
            get
            {
                if (f_wonderGummiIqGain)
                    return _wonderGummiIqGain;
                long _pos = m_io.Pos;
                m_io.Seek(663060);
                _wonderGummiIqGain = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_wonderGummiIqGain = true;
                return _wonderGummiIqGain;
            }
        }
        private bool f_damageFormulaNonTeamMemberModifier;
        private int _damageFormulaNonTeamMemberModifier;

        /// <summary>
        /// The divisor applied to the overall output of the &quot;shifted base&quot; damage formula (the sum of the scaled AT, Def, ClampedLn, and DAMAGE_FORMULA_CONSTANT_SHIFT terms) if the attacker is not a team member (and the current fixed room is not the substitute room...for some reason), as a binary fixed-point number with 8 fraction bits (85/64).
        /// </summary>
        public int DamageFormulaNonTeamMemberModifier
        {
            get
            {
                if (f_damageFormulaNonTeamMemberModifier)
                    return _damageFormulaNonTeamMemberModifier;
                long _pos = m_io.Pos;
                m_io.Seek(663148);
                _damageFormulaNonTeamMemberModifier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaNonTeamMemberModifier = true;
                return _damageFormulaNonTeamMemberModifier;
            }
        }
        private bool f_levelList;
        private List<byte> _levelList;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> LevelList
        {
            get
            {
                if (f_levelList)
                    return _levelList;
                long _pos = m_io.Pos;
                m_io.Seek(675052);
                _levelList = new List<byte>();
                for (var i = 0; i < 9328; i++)
                {
                    _levelList.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_levelList = true;
                return _levelList;
            }
        }
        private bool f_stringFileDirectoryInit;
        private StringFileDirectoryInitArray _stringFileDirectoryInit;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringFileDirectoryInitArray StringFileDirectoryInit
        {
            get
            {
                if (f_stringFileDirectoryInit)
                    return _stringFileDirectoryInit;
                long _pos = m_io.Pos;
                m_io.Seek(610272);
                _stringFileDirectoryInit = new StringFileDirectoryInitArray(m_io);
                m_io.Seek(_pos);
                f_stringFileDirectoryInit = true;
                return _stringFileDirectoryInit;
            }
        }
        private bool f_exclusiveItemSpecialAttackBoosts;
        private List<byte> _exclusiveItemSpecialAttackBoosts;

        /// <summary>
        /// EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 2
        /// </summary>
        public List<byte> ExclusiveItemSpecialAttackBoosts
        {
            get
            {
                if (f_exclusiveItemSpecialAttackBoosts)
                    return _exclusiveItemSpecialAttackBoosts;
                long _pos = m_io.Pos;
                m_io.Seek(623918);
                _exclusiveItemSpecialAttackBoosts = new List<byte>();
                for (var i = 0; i < 57; i++)
                {
                    _exclusiveItemSpecialAttackBoosts.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_exclusiveItemSpecialAttackBoosts = true;
                return _exclusiveItemSpecialAttackBoosts;
            }
        }
        private bool f_outlawLevelTable;
        private OutlawLevelTableArray _outlawLevelTable;

        /// <summary>
        /// Table of 2-byte outlaw levels for outlaw missions, indexed by mission rank.
        /// 
        /// type: int16_t[16]
        /// </summary>
        public OutlawLevelTableArray OutlawLevelTable
        {
            get
            {
                if (f_outlawLevelTable)
                    return _outlawLevelTable;
                long _pos = m_io.Pos;
                m_io.Seek(663324);
                _outlawLevelTable = new OutlawLevelTableArray(m_io);
                m_io.Seek(_pos);
                f_outlawLevelTable = true;
                return _outlawLevelTable;
            }
        }
        private bool f_jobMenuItems7;
        private JobMenuItems7Array _jobMenuItems7;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems7Array JobMenuItems7
        {
            get
            {
                if (f_jobMenuItems7)
                    return _jobMenuItems7;
                long _pos = m_io.Pos;
                m_io.Seek(695224);
                _jobMenuItems7 = new JobMenuItems7Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems7 = true;
                return _jobMenuItems7;
            }
        }
        private bool f_areaNameBoxDefaultWindowParams;
        private WindowParams _areaNameBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for an area_name_box.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAreaNameBox.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateAreaNameBox.
        /// </summary>
        public WindowParams AreaNameBoxDefaultWindowParams
        {
            get
            {
                if (f_areaNameBoxDefaultWindowParams)
                    return _areaNameBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636056);
                _areaNameBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_areaNameBoxDefaultWindowParams = true;
                return _areaNameBoxDefaultWindowParams;
            }
        }
        private bool f_hiddenPowerBasePowerTable;
        private HiddenPowerBasePowerTableArray _hiddenPowerBasePowerTable;

        /// <summary>
        /// Still a guess
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int[10]
        /// </summary>
        public HiddenPowerBasePowerTableArray HiddenPowerBasePowerTable
        {
            get
            {
                if (f_hiddenPowerBasePowerTable)
                    return _hiddenPowerBasePowerTable;
                long _pos = m_io.Pos;
                m_io.Seek(663388);
                _hiddenPowerBasePowerTable = new HiddenPowerBasePowerTableArray(m_io);
                m_io.Seek(_pos);
                f_hiddenPowerBasePowerTable = true;
                return _hiddenPowerBasePowerTable;
            }
        }
        private bool f_jobMenuItems13;
        private JobMenuItems13Array _jobMenuItems13;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems13Array JobMenuItems13
        {
            get
            {
                if (f_jobMenuItems13)
                    return _jobMenuItems13;
                long _pos = m_io.Pos;
                m_io.Seek(695376);
                _jobMenuItems13 = new JobMenuItems13Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems13 = true;
                return _jobMenuItems13;
            }
        }
        private bool f_minIqExclusiveMoveUser;
        private int _minIqExclusiveMoveUser;

        /// <summary>
        /// Minimum IQ required for enemies to use Exclusive-Move User
        /// </summary>
        public int MinIqExclusiveMoveUser
        {
            get
            {
                if (f_minIqExclusiveMoveUser)
                    return _minIqExclusiveMoveUser;
                long _pos = m_io.Pos;
                m_io.Seek(663056);
                _minIqExclusiveMoveUser = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_minIqExclusiveMoveUser = true;
                return _minIqExclusiveMoveUser;
            }
        }
        private bool f_wonderMailEncryptionTable;
        private WonderMailEncryptionTableArray _wonderMailEncryptionTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: uint8_t[256]
        /// </summary>
        public WonderMailEncryptionTableArray WonderMailEncryptionTable
        {
            get
            {
                if (f_wonderMailEncryptionTable)
                    return _wonderMailEncryptionTable;
                long _pos = m_io.Pos;
                m_io.Seek(649252);
                _wonderMailEncryptionTable = new WonderMailEncryptionTableArray(m_io);
                m_io.Seek(_pos);
                f_wonderMailEncryptionTable = true;
                return _wonderMailEncryptionTable;
            }
        }
        private bool f_moneyQuantityTable;
        private MoneyQuantityTableArray _moneyQuantityTable;

        /// <summary>
        /// Table that maps money quantity codes (as recorded in, e.g., struct item) to actual amounts.
        /// 
        /// type: int[100]
        /// </summary>
        public MoneyQuantityTableArray MoneyQuantityTable
        {
            get
            {
                if (f_moneyQuantityTable)
                    return _moneyQuantityTable;
                long _pos = m_io.Pos;
                m_io.Seek(664740);
                _moneyQuantityTable = new MoneyQuantityTableArray(m_io);
                m_io.Seek(_pos);
                f_moneyQuantityTable = true;
                return _moneyQuantityTable;
            }
        }
        private bool f_wonderMailBitsMap;
        private WonderMailBitsMapArray _wonderMailBitsMap;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: uint8_t[32]
        /// </summary>
        public WonderMailBitsMapArray WonderMailBitsMap
        {
            get
            {
                if (f_wonderMailBitsMap)
                    return _wonderMailBitsMap;
                long _pos = m_io.Pos;
                m_io.Seek(648812);
                _wonderMailBitsMap = new WonderMailBitsMapArray(m_io);
                m_io.Seek(_pos);
                f_wonderMailBitsMap = true;
                return _wonderMailBitsMap;
            }
        }
        private bool f_defaultHeroId;
        private MonsterId16 _defaultHeroId;

        /// <summary>
        /// The default monster ID for the hero (0x4: Charmander)
        /// 
        /// type: struct monster_id_16
        /// </summary>
        public MonsterId16 DefaultHeroId
        {
            get
            {
                if (f_defaultHeroId)
                    return _defaultHeroId;
                long _pos = m_io.Pos;
                m_io.Seek(722968);
                _defaultHeroId = new MonsterId16(m_io);
                m_io.Seek(_pos);
                f_defaultHeroId = true;
                return _defaultHeroId;
            }
        }
        private bool f_jobMenuItems8;
        private JobMenuItems8Array _jobMenuItems8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems8Array JobMenuItems8
        {
            get
            {
                if (f_jobMenuItems8)
                    return _jobMenuItems8;
                long _pos = m_io.Pos;
                m_io.Seek(695248);
                _jobMenuItems8 = new JobMenuItems8Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems8 = true;
                return _jobMenuItems8;
            }
        }
        private bool f_stringDebugStringNewline;
        private StringDebugStringNewlineArray _stringDebugStringNewline;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugStringNewlineArray StringDebugStringNewline
        {
            get
            {
                if (f_stringDebugStringNewline)
                    return _stringDebugStringNewline;
                long _pos = m_io.Pos;
                m_io.Seek(610140);
                _stringDebugStringNewline = new StringDebugStringNewlineArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugStringNewline = true;
                return _stringDebugStringNewline;
            }
        }
        private bool f_dungeonRestrictions;
        private DungeonRestrictionsArray _dungeonRestrictions;

        /// <summary>
        /// Data related to dungeon restrictions for every dungeon in the game.
        /// 
        /// This is an array of 256 dungeon restriction structs. Each entry is 12 bytes, and contains information about restrictions within the given dungeon.
        /// 
        /// See the struct definitions and Frostbyte's dungeon data document for more info.
        /// 
        /// type: struct dungeon_restriction[256]
        /// </summary>
        public DungeonRestrictionsArray DungeonRestrictions
        {
            get
            {
                if (f_dungeonRestrictions)
                    return _dungeonRestrictions;
                long _pos = m_io.Pos;
                m_io.Seek(659944);
                _dungeonRestrictions = new DungeonRestrictionsArray(m_io);
                m_io.Seek(_pos);
                f_dungeonRestrictions = true;
                return _dungeonRestrictions;
            }
        }
        private bool f_prngSequenceNum;
        private ushort _prngSequenceNum;

        /// <summary>
        /// [Runtime] The current PRNG sequence number for the general-purpose PRNG. See Rand16Bit for more information on how the general-purpose PRNG works.
        /// </summary>
        public ushort PrngSequenceNum
        {
            get
            {
                if (f_prngSequenceNum)
                    return _prngSequenceNum;
                long _pos = m_io.Pos;
                m_io.Seek(718796);
                _prngSequenceNum = m_io.ReadU2le();
                m_io.Seek(_pos);
                f_prngSequenceNum = true;
                return _prngSequenceNum;
            }
        }
        private bool f_statusesFullDescriptionStringIds;
        private StatusesFullDescriptionStringIdsArray _statusesFullDescriptionStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct status_description[103]
        /// </summary>
        public StatusesFullDescriptionStringIdsArray StatusesFullDescriptionStringIds
        {
            get
            {
                if (f_statusesFullDescriptionStringIds)
                    return _statusesFullDescriptionStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(650900);
                _statusesFullDescriptionStringIds = new StatusesFullDescriptionStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_statusesFullDescriptionStringIds = true;
                return _statusesFullDescriptionStringIds;
            }
        }
        private bool f_missionDungeonCount;
        private int _missionDungeonCount;

        /// <summary>
        /// The total number of dungeons usable for missions
        /// </summary>
        public int MissionDungeonCount
        {
            get
            {
                if (f_missionDungeonCount)
                    return _missionDungeonCount;
                long _pos = m_io.Pos;
                m_io.Seek(725936);
                _missionDungeonCount = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_missionDungeonCount = true;
                return _missionDungeonCount;
            }
        }
        private bool f_outlawMissionRewardTypeWeights;
        private OutlawMissionRewardTypeWeightsArray _outlawMissionRewardTypeWeights;

        /// <summary>
        /// Weights for each possible mission_reward_type, exclusively for the ARREST_OUTLAW mission type.
        /// Takes priority over CAFE_MISSION_REWARD_TYPE_WEIGHTS and CAFE_MISSION_REWARD_TYPE_WEIGHTS.
        /// </summary>
        public OutlawMissionRewardTypeWeightsArray OutlawMissionRewardTypeWeights
        {
            get
            {
                if (f_outlawMissionRewardTypeWeights)
                    return _outlawMissionRewardTypeWeights;
                long _pos = m_io.Pos;
                m_io.Seek(672470);
                _outlawMissionRewardTypeWeights = new OutlawMissionRewardTypeWeightsArray(m_io);
                m_io.Seek(_pos);
                f_outlawMissionRewardTypeWeights = true;
                return _outlawMissionRewardTypeWeights;
            }
        }
        private bool f_notifyNote;
        private byte _notifyNote;

        /// <summary>
        /// [Runtime] Flag related to saving and loading state?
        /// 
        /// type: bool
        /// </summary>
        public byte NotifyNote
        {
            get
            {
                if (f_notifyNote)
                    return _notifyNote;
                long _pos = m_io.Pos;
                m_io.Seek(722964);
                _notifyNote = m_io.ReadU1();
                m_io.Seek(_pos);
                f_notifyNote = true;
                return _notifyNote;
            }
        }
        private bool f_maxRecruitableTeamMembers0;
        private uint _maxRecruitableTeamMembers0;

        /// <summary>
        /// 555, appears to be the maximum number of members recruited to an exploration team, at least for the purposes of some checks that need to iterate over all team members.
        /// </summary>
        public uint MaxRecruitableTeamMembers0
        {
            get
            {
                if (f_maxRecruitableTeamMembers0)
                    return _maxRecruitableTeamMembers0;
                long _pos = m_io.Pos;
                m_io.Seek(349620);
                _maxRecruitableTeamMembers0 = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_maxRecruitableTeamMembers0 = true;
                return _maxRecruitableTeamMembers0;
            }
        }
        private bool f_secure;
        private List<byte> _secure;

        /// <summary>
        /// The header of the DS cartridge secure area. See https://problemkaputt.de/gbatek.htm#dscartridgesecurearea
        /// </summary>
        public List<byte> Secure
        {
            get
            {
                if (f_secure)
                    return _secure;
                long _pos = m_io.Pos;
                m_io.Seek(0);
                _secure = new List<byte>();
                for (var i = 0; i < 2048; i++)
                {
                    _secure.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_secure = true;
                return _secure;
            }
        }
        private bool f_cartRemovedImgData;
        private CartRemovedImgDataArray _cartRemovedImgData;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public CartRemovedImgDataArray CartRemovedImgData
        {
            get
            {
                if (f_cartRemovedImgData)
                    return _cartRemovedImgData;
                long _pos = m_io.Pos;
                m_io.Seek(601828);
                _cartRemovedImgData = new CartRemovedImgDataArray(m_io);
                m_io.Seek(_pos);
                f_cartRemovedImgData = true;
                return _cartRemovedImgData;
            }
        }
        private bool f_collectionMenuDefaultWindowParams;
        private WindowParams _collectionMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a collection_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateCollectionMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateCollectionMenu.
        /// </summary>
        public WindowParams CollectionMenuDefaultWindowParams
        {
            get
            {
                if (f_collectionMenuDefaultWindowParams)
                    return _collectionMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635900);
                _collectionMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_collectionMenuDefaultWindowParams = true;
                return _collectionMenuDefaultWindowParams;
            }
        }
        private bool f_evolutionHpBonus;
        private short _evolutionHpBonus;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public short EvolutionHpBonus
        {
            get
            {
                if (f_evolutionHpBonus)
                    return _evolutionHpBonus;
                long _pos = m_io.Pos;
                m_io.Seek(663112);
                _evolutionHpBonus = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_evolutionHpBonus = true;
                return _evolutionHpBonus;
            }
        }
        private bool f_minIqItemMaster;
        private int _minIqItemMaster;

        /// <summary>
        /// Minimum IQ required for enemies to use Item Master
        /// </summary>
        public int MinIqItemMaster
        {
            get
            {
                if (f_minIqItemMaster)
                    return _minIqItemMaster;
                long _pos = m_io.Pos;
                m_io.Seek(663080);
                _minIqItemMaster = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_minIqItemMaster = true;
                return _minIqItemMaster;
            }
        }
        private bool f_stringDebugEmpty;
        private StringDebugEmptyArray _stringDebugEmpty;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugEmptyArray StringDebugEmpty
        {
            get
            {
                if (f_stringDebugEmpty)
                    return _stringDebugEmpty;
                long _pos = m_io.Pos;
                m_io.Seek(610040);
                _stringDebugEmpty = new StringDebugEmptyArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugEmpty = true;
                return _stringDebugEmpty;
            }
        }
        private bool f_availableItemsInGroupTable;
        private List<byte> _availableItemsInGroupTable;

        /// <summary>
        /// 100*0x80
        /// Linked to the dungeon group id
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> AvailableItemsInGroupTable
        {
            get
            {
                if (f_availableItemsInGroupTable)
                    return _availableItemsInGroupTable;
                long _pos = m_io.Pos;
                m_io.Seek(610608);
                _availableItemsInGroupTable = new List<byte>();
                for (var i = 0; i < 12800; i++)
                {
                    _availableItemsInGroupTable.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_availableItemsInGroupTable = true;
                return _availableItemsInGroupTable;
            }
        }
        private bool f_arm9UnknownTableNa20ae924;
        private List<byte> _arm9UnknownTableNa20ae924;

        /// <summary>
        /// 724*0x1
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa20ae924
        {
            get
            {
                if (f_arm9UnknownTableNa20ae924)
                    return _arm9UnknownTableNa20ae924;
                long _pos = m_io.Pos;
                m_io.Seek(717252);
                _arm9UnknownTableNa20ae924 = new List<byte>();
                for (var i = 0; i < 724; i++)
                {
                    _arm9UnknownTableNa20ae924.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa20ae924 = true;
                return _arm9UnknownTableNa20ae924;
            }
        }
        private bool f_moveAccuracyStarsTable;
        private MoveAccuracyStarsTableArray _moveAccuracyStarsTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int[8]
        /// </summary>
        public MoveAccuracyStarsTableArray MoveAccuracyStarsTable
        {
            get
            {
                if (f_moveAccuracyStarsTable)
                    return _moveAccuracyStarsTable;
                long _pos = m_io.Pos;
                m_io.Seek(631144);
                _moveAccuracyStarsTable = new MoveAccuracyStarsTableArray(m_io);
                m_io.Seek(_pos);
                f_moveAccuracyStarsTable = true;
                return _moveAccuracyStarsTable;
            }
        }
        private bool f_maxMoneyCarried;
        private uint _maxMoneyCarried;

        /// <summary>
        /// Maximum amount of money the player can carry, 99999.
        /// </summary>
        public uint MaxMoneyCarried
        {
            get
            {
                if (f_maxMoneyCarried)
                    return _maxMoneyCarried;
                long _pos = m_io.Pos;
                m_io.Seek(60920);
                _maxMoneyCarried = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_maxMoneyCarried = true;
                return _maxMoneyCarried;
            }
        }
        private bool f_trigTable;
        private TrigTableArray _trigTable;

        /// <summary>
        /// Interleaved table of sine and cosine values at 4096 divisions over a full period (2π radians).
        /// 
        /// More precisely, the trig_values entry at index i corresponds to {sin(i * 2π/4096), cos(i * 2π/4096)} (each division is ~1/10 of a degree). Values are stored as signed fixed-point numbers with 12 fraction bits.
        /// 
        /// type: struct trig_values[4096]
        /// </summary>
        public TrigTableArray TrigTable
        {
            get
            {
                if (f_trigTable)
                    return _trigTable;
                long _pos = m_io.Pos;
                m_io.Seek(698448);
                _trigTable = new TrigTableArray(m_io);
                m_io.Seek(_pos);
                f_trigTable = true;
                return _trigTable;
            }
        }
        private bool f_stringMonsterMAttackBin;
        private StringMonsterMAttackBinArray _stringMonsterMAttackBin;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringMonsterMAttackBinArray StringMonsterMAttackBin
        {
            get
            {
                if (f_stringMonsterMAttackBin)
                    return _stringMonsterMAttackBin;
                long _pos = m_io.Pos;
                m_io.Seek(610224);
                _stringMonsterMAttackBin = new StringMonsterMAttackBinArray(m_io);
                m_io.Seek(_pos);
                f_stringMonsterMAttackBin = true;
                return _stringMonsterMAttackBin;
            }
        }
        private bool f_unownSpeciesAdditionalCharPtrTable;
        private UnownSpeciesAdditionalCharPtrTableArray _unownSpeciesAdditionalCharPtrTable;

        /// <summary>
        /// Uses UNOWN_SPECIES_ADDITIONAL_CHARS
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: enum monster_id*[28]
        /// </summary>
        public UnownSpeciesAdditionalCharPtrTableArray UnownSpeciesAdditionalCharPtrTable
        {
            get
            {
                if (f_unownSpeciesAdditionalCharPtrTable)
                    return _unownSpeciesAdditionalCharPtrTable;
                long _pos = m_io.Pos;
                m_io.Seek(725788);
                _unownSpeciesAdditionalCharPtrTable = new UnownSpeciesAdditionalCharPtrTableArray(m_io);
                m_io.Seek(_pos);
                f_unownSpeciesAdditionalCharPtrTable = true;
                return _unownSpeciesAdditionalCharPtrTable;
            }
        }
        private bool f_debugIsInitialized;
        private byte _debugIsInitialized;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public byte DebugIsInitialized
        {
            get
            {
                if (f_debugIsInitialized)
                    return _debugIsInitialized;
                long _pos = m_io.Pos;
                m_io.Seek(720720);
                _debugIsInitialized = m_io.ReadU1();
                m_io.Seek(_pos);
                f_debugIsInitialized = true;
                return _debugIsInitialized;
            }
        }
        private bool f_packFilesOpened;
        private Pointer _packFilesOpened;

        /// <summary>
        /// [Runtime] A pointer to the 6 opened Pack files (listed at PACK_FILE_PATHS_TABLE)
        /// 
        /// type: struct pack_file_opened*
        /// </summary>
        public Pointer PackFilesOpened
        {
            get
            {
                if (f_packFilesOpened)
                    return _packFilesOpened;
                long _pos = m_io.Pos;
                m_io.Seek(720724);
                _packFilesOpened = new Pointer(m_io);
                m_io.Seek(_pos);
                f_packFilesOpened = true;
                return _packFilesOpened;
            }
        }
        private bool f_remoteStrings;
        private List<byte> _remoteStrings;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> RemoteStrings
        {
            get
            {
                if (f_remoteStrings)
                    return _remoteStrings;
                long _pos = m_io.Pos;
                m_io.Seek(672064);
                _remoteStrings = new List<byte>();
                for (var i = 0; i < 44; i++)
                {
                    _remoteStrings.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_remoteStrings = true;
                return _remoteStrings;
            }
        }
        private bool f_scriptVarsLocals;
        private ScriptLocalVarTable _scriptVarsLocals;

        /// <summary>
        /// List of special &quot;local&quot; variables available to the script engine. There are 4 16-byte entries.
        /// 
        /// Each entry has the same structure as an entry in SCRIPT_VARS.
        /// 
        /// type: struct script_local_var_table
        /// </summary>
        public ScriptLocalVarTable ScriptVarsLocals
        {
            get
            {
                if (f_scriptVarsLocals)
                    return _scriptVarsLocals;
                long _pos = m_io.Pos;
                m_io.Seek(644176);
                _scriptVarsLocals = new ScriptLocalVarTable(m_io);
                m_io.Seek(_pos);
                f_scriptVarsLocals = true;
                return _scriptVarsLocals;
            }
        }
        private bool f_stringDebugFatal;
        private StringDebugFatalArray _stringDebugFatal;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugFatalArray StringDebugFatal
        {
            get
            {
                if (f_stringDebugFatal)
                    return _stringDebugFatal;
                long _pos = m_io.Pos;
                m_io.Seek(610108);
                _stringDebugFatal = new StringDebugFatalArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugFatal = true;
                return _stringDebugFatal;
            }
        }
        private bool f_portraitLayouts;
        private PortraitLayoutsArray _portraitLayouts;

        /// <summary>
        /// All the possible layouts a portrait can be placed in by default.
        /// 
        /// type: struct portrait_layout[32]
        /// </summary>
        public PortraitLayoutsArray PortraitLayouts
        {
            get
            {
                if (f_portraitLayouts)
                    return _portraitLayouts;
                long _pos = m_io.Pos;
                m_io.Seek(648600);
                _portraitLayouts = new PortraitLayoutsArray(m_io);
                m_io.Seek(_pos);
                f_portraitLayouts = true;
                return _portraitLayouts;
            }
        }
        private bool f_missionValidationFunctionList;
        private MissionValidationFunctionListArray _missionValidationFunctionList;

        /// <summary>
        /// A list of functions used to validate missions of different types at 02060CEC [EU].
        /// </summary>
        public MissionValidationFunctionListArray MissionValidationFunctionList
        {
            get
            {
                if (f_missionValidationFunctionList)
                    return _missionValidationFunctionList;
                long _pos = m_io.Pos;
                m_io.Seek(672500);
                _missionValidationFunctionList = new MissionValidationFunctionListArray(m_io);
                m_io.Seek(_pos);
                f_missionValidationFunctionList = true;
                return _missionValidationFunctionList;
            }
        }
        private bool f_gummiBellyRestoreTable;
        private GummiBellyRestoreTableArray _gummiBellyRestoreTable;

        /// <summary>
        /// type: int16_t[18][18]
        /// </summary>
        public GummiBellyRestoreTableArray GummiBellyRestoreTable
        {
            get
            {
                if (f_gummiBellyRestoreTable)
                    return _gummiBellyRestoreTable;
                long _pos = m_io.Pos;
                m_io.Seek(666300);
                _gummiBellyRestoreTable = new GummiBellyRestoreTableArray(m_io);
                m_io.Seek(_pos);
                f_gummiBellyRestoreTable = true;
                return _gummiBellyRestoreTable;
            }
        }
        private bool f_fxAtanIdxTable;
        private FxAtanIdxTableArray _fxAtanIdxTable;

        /// <summary>
        /// Table of arctangent values at 129 divisions over the domain [0, 1].
        /// 
        /// More precisely, entry at index i corresponds to (atan(i/128) / (π/2)). Values are stored as signed fixed-point numbers with 14 fraction bits.
        /// </summary>
        public FxAtanIdxTableArray FxAtanIdxTable
        {
            get
            {
                if (f_fxAtanIdxTable)
                    return _fxAtanIdxTable;
                long _pos = m_io.Pos;
                m_io.Seek(714832);
                _fxAtanIdxTable = new FxAtanIdxTableArray(m_io);
                m_io.Seek(_pos);
                f_fxAtanIdxTable = true;
                return _fxAtanIdxTable;
            }
        }
        private bool f_scriptVars;
        private ScriptVarTable _scriptVars;

        /// <summary>
        /// List of predefined global variables that track game state, which are available to the script engine. There are 115 16-byte entries.
        /// 
        /// These variables underpin the various ExplorerScript global variables you can use in the SkyTemple SSB debugger.
        /// 
        /// type: struct script_var_table
        /// </summary>
        public ScriptVarTable ScriptVars
        {
            get
            {
                if (f_scriptVars)
                    return _scriptVars;
                long _pos = m_io.Pos;
                m_io.Seek(646644);
                _scriptVars = new ScriptVarTable(m_io);
                m_io.Seek(_pos);
                f_scriptVars = true;
                return _scriptVars;
            }
        }
        private bool f_missionMonsterListPtr;
        private Pointer _missionMonsterListPtr;

        /// <summary>
        /// A pointer to a heap-allocated list of monsters usable for missions
        /// </summary>
        public Pointer MissionMonsterListPtr
        {
            get
            {
                if (f_missionMonsterListPtr)
                    return _missionMonsterListPtr;
                long _pos = m_io.Pos;
                m_io.Seek(725940);
                _missionMonsterListPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_missionMonsterListPtr = true;
                return _missionMonsterListPtr;
            }
        }
        private bool f_missionStringIds;
        private MissionStringIdsArray _missionStringIds;

        /// <summary>
        /// String IDs for mission title and summary flavor-text.
        /// Used by GenerateMissionTitle and GenerateMissionSummary.
        /// 
        /// type: int16_t[964]
        /// </summary>
        public MissionStringIdsArray MissionStringIds
        {
            get
            {
                if (f_missionStringIds)
                    return _missionStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(672932);
                _missionStringIds = new MissionStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_missionStringIds = true;
                return _missionStringIds;
            }
        }
        private bool f_jobMenuItems10;
        private JobMenuItems10Array _jobMenuItems10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems10Array JobMenuItems10
        {
            get
            {
                if (f_jobMenuItems10)
                    return _jobMenuItems10;
                long _pos = m_io.Pos;
                m_io.Seek(695296);
                _jobMenuItems10 = new JobMenuItems10Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems10 = true;
                return _jobMenuItems10;
            }
        }
        private bool f_specialBandStatBoost;
        private short _specialBandStatBoost;

        /// <summary>
        /// Stat boost value for the Special Band.
        /// </summary>
        public short SpecialBandStatBoost
        {
            get
            {
                if (f_specialBandStatBoost)
                    return _specialBandStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663024);
                _specialBandStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_specialBandStatBoost = true;
                return _specialBandStatBoost;
            }
        }
        private bool f_versionExclusiveMonsters;
        private VersionExclusiveMonstersArray _versionExclusiveMonsters;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct version_exclusive_monster[23]
        /// </summary>
        public VersionExclusiveMonstersArray VersionExclusiveMonsters
        {
            get
            {
                if (f_versionExclusiveMonsters)
                    return _versionExclusiveMonsters;
                long _pos = m_io.Pos;
                m_io.Seek(663428);
                _versionExclusiveMonsters = new VersionExclusiveMonstersArray(m_io);
                m_io.Seek(_pos);
                f_versionExclusiveMonsters = true;
                return _versionExclusiveMonsters;
            }
        }
        private bool f_damageFormulaLnArgPrefactor;
        private int _damageFormulaLnArgPrefactor;

        /// <summary>
        /// The prefactor to the argument of ClampedLn in the damage formula (FLV + DAMAGE_FORMULA_FLV_SHIFT), as a binary fixed-point number with 8 fraction bits (10).
        /// </summary>
        public int DamageFormulaLnArgPrefactor
        {
            get
            {
                if (f_damageFormulaLnArgPrefactor)
                    return _damageFormulaLnArgPrefactor;
                long _pos = m_io.Pos;
                m_io.Seek(663164);
                _damageFormulaLnArgPrefactor = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaLnArgPrefactor = true;
                return _damageFormulaLnArgPrefactor;
            }
        }
        private bool f_dialogueBoxDefaultWindowParams;
        private WindowParams _dialogueBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for a dialogue_box.
        /// </summary>
        public WindowParams DialogueBoxDefaultWindowParams
        {
            get
            {
                if (f_dialogueBoxDefaultWindowParams)
                    return _dialogueBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636008);
                _dialogueBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_dialogueBoxDefaultWindowParams = true;
                return _dialogueBoxDefaultWindowParams;
            }
        }
        private bool f_itemDeliveryTable;
        private ItemDeliveryTableArray _itemDeliveryTable;

        /// <summary>
        /// A list of valid items used for delivering an item for a mission client.
        /// 
        /// type: struct item_id_16[23]
        /// </summary>
        public ItemDeliveryTableArray ItemDeliveryTable
        {
            get
            {
                if (f_itemDeliveryTable)
                    return _itemDeliveryTable;
                long _pos = m_io.Pos;
                m_io.Seek(672574);
                _itemDeliveryTable = new ItemDeliveryTableArray(m_io);
                m_io.Seek(_pos);
                f_itemDeliveryTable = true;
                return _itemDeliveryTable;
            }
        }
        private bool f_damageFormulaFlvShift;
        private int _damageFormulaFlvShift;

        /// <summary>
        /// The constant shift added to the &quot;FLV&quot; intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_flv), as a binary fixed-point number with 8 fraction bits (50).
        /// </summary>
        public int DamageFormulaFlvShift
        {
            get
            {
                if (f_damageFormulaFlvShift)
                    return _damageFormulaFlvShift;
                long _pos = m_io.Pos;
                m_io.Seek(663120);
                _damageFormulaFlvShift = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaFlvShift = true;
                return _damageFormulaFlvShift;
            }
        }
        private bool f_jobMenuItems9;
        private JobMenuItems9Array _jobMenuItems9;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems9Array JobMenuItems9
        {
            get
            {
                if (f_jobMenuItems9)
                    return _jobMenuItems9;
                long _pos = m_io.Pos;
                m_io.Seek(695272);
                _jobMenuItems9 = new JobMenuItems9Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems9 = true;
                return _jobMenuItems9;
            }
        }
        private bool f_exclusiveItemStatBoostDataIndexes;
        private List<byte> _exclusiveItemStatBoostDataIndexes;

        /// <summary>
        /// EXCLUSIVE_ITEM_EFFECT_DATA, offset by 1
        /// </summary>
        public List<byte> ExclusiveItemStatBoostDataIndexes
        {
            get
            {
                if (f_exclusiveItemStatBoostDataIndexes)
                    return _exclusiveItemStatBoostDataIndexes;
                long _pos = m_io.Pos;
                m_io.Seek(623977);
                _exclusiveItemStatBoostDataIndexes = new List<byte>();
                for (var i = 0; i < 1911; i++)
                {
                    _exclusiveItemStatBoostDataIndexes.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_exclusiveItemStatBoostDataIndexes = true;
                return _exclusiveItemStatBoostDataIndexes;
            }
        }
        private bool f_wonderMailBitsSwap;
        private WonderMailBitsSwapArray _wonderMailBitsSwap;

        /// <summary>
        /// Last 2 bytes are unused
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: uint8_t[36]
        /// </summary>
        public WonderMailBitsSwapArray WonderMailBitsSwap
        {
            get
            {
                if (f_wonderMailBitsSwap)
                    return _wonderMailBitsSwap;
                long _pos = m_io.Pos;
                m_io.Seek(648844);
                _wonderMailBitsSwap = new WonderMailBitsSwapArray(m_io);
                m_io.Seek(_pos);
                f_wonderMailBitsSwap = true;
                return _wonderMailBitsSwap;
            }
        }
        private bool f_maxPlayTime;
        private uint _maxPlayTime;

        /// <summary>
        /// Maximum number of seconds that the file timer counts up to.
        /// 
        /// 35999999 seconds (one second under 10000 hours).
        /// </summary>
        public uint MaxPlayTime
        {
            get
            {
                if (f_maxPlayTime)
                    return _maxPlayTime;
                long _pos = m_io.Pos;
                m_io.Seek(332168);
                _maxPlayTime = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_maxPlayTime = true;
                return _maxPlayTime;
            }
        }
        private bool f_damageFormulaLnPrefactor;
        private int _damageFormulaLnPrefactor;

        /// <summary>
        /// The prefactor to the output of the ClampedLn in the damage formula, as a binary fixed-point number with 8 fraction bits (50).
        /// </summary>
        public int DamageFormulaLnPrefactor
        {
            get
            {
                if (f_damageFormulaLnPrefactor)
                    return _damageFormulaLnPrefactor;
                long _pos = m_io.Pos;
                m_io.Seek(663152);
                _damageFormulaLnPrefactor = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaLnPrefactor = true;
                return _damageFormulaLnPrefactor;
            }
        }
        private bool f_teamMemberTablePtr;
        private Pointer _teamMemberTablePtr;

        /// <summary>
        /// Pointer to TEAM_MEMBER_TABLE
        /// </summary>
        public Pointer TeamMemberTablePtr
        {
            get
            {
                if (f_teamMemberTablePtr)
                    return _teamMemberTablePtr;
                long _pos = m_io.Pos;
                m_io.Seek(725900);
                _teamMemberTablePtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_teamMemberTablePtr = true;
                return _teamMemberTablePtr;
            }
        }
        private bool f_scriptVarsValuesPtr3;
        private Pointer _scriptVarsValuesPtr3;

        /// <summary>
        /// Hard-coded pointer to SCRIPT_VARS_VALUES.
        /// </summary>
        public Pointer ScriptVarsValuesPtr3
        {
            get
            {
                if (f_scriptVarsValuesPtr3)
                    return _scriptVarsValuesPtr3;
                long _pos = m_io.Pos;
                m_io.Seek(313276);
                _scriptVarsValuesPtr3 = new Pointer(m_io);
                m_io.Seek(_pos);
                f_scriptVarsValuesPtr3 = true;
                return _scriptVarsValuesPtr3;
            }
        }
        private bool f_tblTalkGroupStringIdStart;
        private TblTalkGroupStringIdStartArray _tblTalkGroupStringIdStart;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[6]
        /// </summary>
        public TblTalkGroupStringIdStartArray TblTalkGroupStringIdStart
        {
            get
            {
                if (f_tblTalkGroupStringIdStart)
                    return _tblTalkGroupStringIdStart;
                long _pos = m_io.Pos;
                m_io.Seek(722452);
                _tblTalkGroupStringIdStart = new TblTalkGroupStringIdStartArray(m_io);
                m_io.Seek(_pos);
                f_tblTalkGroupStringIdStart = true;
                return _tblTalkGroupStringIdStart;
            }
        }
        private bool f_memoryAllocationArenaGetters;
        private MemArenaGetters _memoryAllocationArenaGetters;

        /// <summary>
        /// Functions to get the desired memory arena for allocating and freeing heap memory.
        /// 
        /// type: struct mem_arena_getters
        /// </summary>
        public MemArenaGetters MemoryAllocationArenaGetters
        {
            get
            {
                if (f_memoryAllocationArenaGetters)
                    return _memoryAllocationArenaGetters;
                long _pos = m_io.Pos;
                m_io.Seek(718752);
                _memoryAllocationArenaGetters = new MemArenaGetters(m_io);
                m_io.Seek(_pos);
                f_memoryAllocationArenaGetters = true;
                return _memoryAllocationArenaGetters;
            }
        }
        private bool f_dsDownloadTeams;
        private DsDownloadTeamsArray _dsDownloadTeams;

        /// <summary>
        /// Seems like this is just a collection of null-terminated lists concatenated together.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// struct monster_id_16[56]
        /// </summary>
        public DsDownloadTeamsArray DsDownloadTeams
        {
            get
            {
                if (f_dsDownloadTeams)
                    return _dsDownloadTeams;
                long _pos = m_io.Pos;
                m_io.Seek(668056);
                _dsDownloadTeams = new DsDownloadTeamsArray(m_io);
                m_io.Seek(_pos);
                f_dsDownloadTeams = true;
                return _dsDownloadTeams;
            }
        }
        private bool f_missionFloorsForbidden;
        private MissionFloorsForbiddenArray _missionFloorsForbidden;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct mission_floors_forbidden[100]
        /// </summary>
        public MissionFloorsForbiddenArray MissionFloorsForbidden
        {
            get
            {
                if (f_missionFloorsForbidden)
                    return _missionFloorsForbidden;
                long _pos = m_io.Pos;
                m_io.Seek(654488);
                _missionFloorsForbidden = new MissionFloorsForbiddenArray(m_io);
                m_io.Seek(_pos);
                f_missionFloorsForbidden = true;
                return _missionFloorsForbidden;
            }
        }
        private bool f_kecleonShopItemTableLists2;
        private KecleonShopItemTableLists2Array _kecleonShopItemTableLists2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: enum item_id[4]
        /// </summary>
        public KecleonShopItemTableLists2Array KecleonShopItemTableLists2
        {
            get
            {
                if (f_kecleonShopItemTableLists2)
                    return _kecleonShopItemTableLists2;
                long _pos = m_io.Pos;
                m_io.Seek(623892);
                _kecleonShopItemTableLists2 = new KecleonShopItemTableLists2Array(m_io);
                m_io.Seek(_pos);
                f_kecleonShopItemTableLists2 = true;
                return _kecleonShopItemTableLists2;
            }
        }
        private bool f_jobMenuItems6;
        private JobMenuItems6Array _jobMenuItems6;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems6Array JobMenuItems6
        {
            get
            {
                if (f_jobMenuItems6)
                    return _jobMenuItems6;
                long _pos = m_io.Pos;
                m_io.Seek(695200);
                _jobMenuItems6 = new JobMenuItems6Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems6 = true;
                return _jobMenuItems6;
            }
        }
        private bool f_lfoOutputVoiceUpdateFlags;
        private DseVoiceUpdateFlags _lfoOutputVoiceUpdateFlags;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public DseVoiceUpdateFlags LfoOutputVoiceUpdateFlags
        {
            get
            {
                if (f_lfoOutputVoiceUpdateFlags)
                    return _lfoOutputVoiceUpdateFlags;
                long _pos = m_io.Pos;
                m_io.Seek(698432);
                _lfoOutputVoiceUpdateFlags = new DseVoiceUpdateFlags(m_io);
                m_io.Seek(_pos);
                f_lfoOutputVoiceUpdateFlags = true;
                return _lfoOutputVoiceUpdateFlags;
            }
        }
        private bool f_specialEpisodeMainCharacters;
        private SpecialEpisodeMainCharactersArray _specialEpisodeMainCharacters;

        /// <summary>
        /// type: struct monster_id_16[100]
        /// </summary>
        public SpecialEpisodeMainCharactersArray SpecialEpisodeMainCharacters
        {
            get
            {
                if (f_specialEpisodeMainCharacters)
                    return _specialEpisodeMainCharacters;
                long _pos = m_io.Pos;
                m_io.Seek(667000);
                _specialEpisodeMainCharacters = new SpecialEpisodeMainCharactersArray(m_io);
                m_io.Seek(_pos);
                f_specialEpisodeMainCharacters = true;
                return _specialEpisodeMainCharacters;
            }
        }
        private bool f_arm9UnknownPtrNa20a2c84;
        private List<byte> _arm9UnknownPtrNa20a2c84;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownPtrNa20a2c84
        {
            get
            {
                if (f_arm9UnknownPtrNa20a2c84)
                    return _arm9UnknownPtrNa20a2c84;
                long _pos = m_io.Pos;
                m_io.Seek(668168);
                _arm9UnknownPtrNa20a2c84 = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _arm9UnknownPtrNa20a2c84.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownPtrNa20a2c84 = true;
                return _arm9UnknownPtrNa20a2c84;
            }
        }
        private bool f_iqSkillRestrictions;
        private IqSkillRestrictionsArray _iqSkillRestrictions;

        /// <summary>
        /// Table of 2-byte values for each IQ skill that represent a group. IQ skills in the same group can not be enabled at the same time.
        /// 
        /// type: int16_t[69]
        /// </summary>
        public IqSkillRestrictionsArray IqSkillRestrictions
        {
            get
            {
                if (f_iqSkillRestrictions)
                    return _iqSkillRestrictions;
                long _pos = m_io.Pos;
                m_io.Seek(663520);
                _iqSkillRestrictions = new IqSkillRestrictionsArray(m_io);
                m_io.Seek(_pos);
                f_iqSkillRestrictions = true;
                return _iqSkillRestrictions;
            }
        }
        private bool f_musicDurationLookupTable1;
        private MusicDurationLookupTable1Array _musicDurationLookupTable1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[128]
        /// </summary>
        public MusicDurationLookupTable1Array MusicDurationLookupTable1
        {
            get
            {
                if (f_musicDurationLookupTable1)
                    return _musicDurationLookupTable1;
                long _pos = m_io.Pos;
                m_io.Seek(727188);
                _musicDurationLookupTable1 = new MusicDurationLookupTable1Array(m_io);
                m_io.Seek(_pos);
                f_musicDurationLookupTable1 = true;
                return _musicDurationLookupTable1;
            }
        }
        private bool f_simpleMenuDefaultWindowParams;
        private WindowParams _simpleMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a simple_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateSimpleMenuInternal.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateSimpleMenuInternal.
        /// </summary>
        public WindowParams SimpleMenuDefaultWindowParams
        {
            get
            {
                if (f_simpleMenuDefaultWindowParams)
                    return _simpleMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635868);
                _simpleMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_simpleMenuDefaultWindowParams = true;
                return _simpleMenuDefaultWindowParams;
            }
        }
        private bool f_jobMenuItems3;
        private JobMenuItems3Array _jobMenuItems3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems3Array JobMenuItems3
        {
            get
            {
                if (f_jobMenuItems3)
                    return _jobMenuItems3;
                long _pos = m_io.Pos;
                m_io.Seek(695128);
                _jobMenuItems3 = new JobMenuItems3Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems3 = true;
                return _jobMenuItems3;
            }
        }
        private bool f_arm9UnknownDataNa209eaac;
        private List<byte> _arm9UnknownDataNa209eaac;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownDataNa209eaac
        {
            get
            {
                if (f_arm9UnknownDataNa209eaac)
                    return _arm9UnknownDataNa209eaac;
                long _pos = m_io.Pos;
                m_io.Seek(651312);
                _arm9UnknownDataNa209eaac = new List<byte>();
                for (var i = 0; i < 4; i++)
                {
                    _arm9UnknownDataNa209eaac.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownDataNa209eaac = true;
                return _arm9UnknownDataNa209eaac;
            }
        }
        private bool f_movePowerStarsTable;
        private MovePowerStarsTableArray _movePowerStarsTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int[6]
        /// </summary>
        public MovePowerStarsTableArray MovePowerStarsTable
        {
            get
            {
                if (f_movePowerStarsTable)
                    return _movePowerStarsTable;
                long _pos = m_io.Pos;
                m_io.Seek(631120);
                _movePowerStarsTable = new MovePowerStarsTableArray(m_io);
                m_io.Seek(_pos);
                f_movePowerStarsTable = true;
                return _movePowerStarsTable;
            }
        }
        private bool f_moveDataTablePtr;
        private Pointer _moveDataTablePtr;

        /// <summary>
        /// [Runtime] Points to the contents of the move data table loaded from waza_p.bin
        /// 
        /// type: struct move_data_table*
        /// </summary>
        public Pointer MoveDataTablePtr
        {
            get
            {
                if (f_moveDataTablePtr)
                    return _moveDataTablePtr;
                long _pos = m_io.Pos;
                m_io.Seek(720816);
                _moveDataTablePtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_moveDataTablePtr = true;
                return _moveDataTablePtr;
            }
        }
        private bool f_stringMonsterMGroundBin;
        private StringMonsterMGroundBinArray _stringMonsterMGroundBin;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringMonsterMGroundBinArray StringMonsterMGroundBin
        {
            get
            {
                if (f_stringMonsterMGroundBin)
                    return _stringMonsterMGroundBin;
                long _pos = m_io.Pos;
                m_io.Seek(610248);
                _stringMonsterMGroundBin = new StringMonsterMGroundBinArray(m_io);
                m_io.Seek(_pos);
                f_stringMonsterMGroundBin = true;
                return _stringMonsterMGroundBin;
            }
        }
        private bool f_jobMenuItems4;
        private JobMenuItems4Array _jobMenuItems4;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems4Array JobMenuItems4
        {
            get
            {
                if (f_jobMenuItems4)
                    return _jobMenuItems4;
                long _pos = m_io.Pos;
                m_io.Seek(695152);
                _jobMenuItems4 = new JobMenuItems4Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems4 = true;
                return _jobMenuItems4;
            }
        }
        private bool f_advancedTextBoxDefaultWindowParams;
        private WindowParams _advancedTextBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for an advanced_text_box.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAdvancedTextBoxInternal.
        /// </summary>
        public WindowParams AdvancedTextBoxDefaultWindowParams
        {
            get
            {
                if (f_advancedTextBoxDefaultWindowParams)
                    return _advancedTextBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636128);
                _advancedTextBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_advancedTextBoxDefaultWindowParams = true;
                return _advancedTextBoxDefaultWindowParams;
            }
        }
        private bool f_gummiStatBoost;
        private short _gummiStatBoost;

        /// <summary>
        /// Stat boost value if a stat boost occurs when eating normal Gummis.
        /// </summary>
        public short GummiStatBoost
        {
            get
            {
                if (f_gummiStatBoost)
                    return _gummiStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663052);
                _gummiStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_gummiStatBoost = true;
                return _gummiStatBoost;
            }
        }
        private bool f_kaomadoFilepath;
        private KaomadoFilepathArray _kaomadoFilepath;

        /// <summary>
        /// &quot;Path of the file where all the portraits are stored. \&quot;FONT/kaomado.kao\&quot;, padded with null to a multiple of 4&quot;
        /// 
        /// type: char[20]
        /// </summary>
        public KaomadoFilepathArray KaomadoFilepath
        {
            get
            {
                if (f_kaomadoFilepath)
                    return _kaomadoFilepath;
                long _pos = m_io.Pos;
                m_io.Seek(648792);
                _kaomadoFilepath = new KaomadoFilepathArray(m_io);
                m_io.Seek(_pos);
                f_kaomadoFilepath = true;
                return _kaomadoFilepath;
            }
        }
        private bool f_rankStrings1;
        private List<byte> _rankStrings1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> RankStrings1
        {
            get
            {
                if (f_rankStrings1)
                    return _rankStrings1;
                long _pos = m_io.Pos;
                m_io.Seek(672108);
                _rankStrings1 = new List<byte>();
                for (var i = 0; i < 48; i++)
                {
                    _rankStrings1.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_rankStrings1 = true;
                return _rankStrings1;
            }
        }
        private bool f_demoTeams;
        private DemoTeamsArray _demoTeams;

        /// <summary>
        /// 18*0x4 (Hero ID 0x2, Partner ID 0x2)
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public DemoTeamsArray DemoTeams
        {
            get
            {
                if (f_demoTeams)
                    return _demoTeams;
                long _pos = m_io.Pos;
                m_io.Seek(684392);
                _demoTeams = new DemoTeamsArray(m_io);
                m_io.Seek(_pos);
                f_demoTeams = true;
                return _demoTeams;
            }
        }
        private bool f_render3d;
        private Render3dGlobal _render3d;

        /// <summary>
        /// The (seemingly) unique instance render_3d_global in the game
        /// 
        /// type: struct render_3d_global
        /// </summary>
        public Render3dGlobal Render3d
        {
            get
            {
                if (f_render3d)
                    return _render3d;
                long _pos = m_io.Pos;
                m_io.Seek(722240);
                _render3d = new Render3dGlobal(m_io);
                m_io.Seek(_pos);
                f_render3d = true;
                return _render3d;
            }
        }
        private bool f_missionFloorRanksAndItemLists1;
        private List<byte> _missionFloorRanksAndItemLists1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> MissionFloorRanksAndItemLists1
        {
            get
            {
                if (f_missionFloorRanksAndItemLists1)
                    return _missionFloorRanksAndItemLists1;
                long _pos = m_io.Pos;
                m_io.Seek(651316);
                _missionFloorRanksAndItemLists1 = new List<byte>();
                for (var i = 0; i < 3172; i++)
                {
                    _missionFloorRanksAndItemLists1.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_missionFloorRanksAndItemLists1 = true;
                return _missionFloorRanksAndItemLists1;
            }
        }
        private bool f_missionMenuStringIds2;
        private MissionMenuStringIds2Array _missionMenuStringIds2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[8]
        /// </summary>
        public MissionMenuStringIds2Array MissionMenuStringIds2
        {
            get
            {
                if (f_missionMenuStringIds2)
                    return _missionMenuStringIds2;
                long _pos = m_io.Pos;
                m_io.Seek(672220);
                _missionMenuStringIds2 = new MissionMenuStringIds2Array(m_io);
                m_io.Seek(_pos);
                f_missionMenuStringIds2 = true;
                return _missionMenuStringIds2;
            }
        }
        private bool f_partnerTalkKindTable;
        private PartnerTalkKindTableArray _partnerTalkKindTable;

        /// <summary>
        /// Table of values for the PARTNER_TALK_KIND script variable.
        /// 
        /// type: struct partner_talk_kind_table_entry[11]
        /// </summary>
        public PartnerTalkKindTableArray PartnerTalkKindTable
        {
            get
            {
                if (f_partnerTalkKindTable)
                    return _partnerTalkKindTable;
                long _pos = m_io.Pos;
                m_io.Seek(643688);
                _partnerTalkKindTable = new PartnerTalkKindTableArray(m_io);
                m_io.Seek(_pos);
                f_partnerTalkKindTable = true;
                return _partnerTalkKindTable;
            }
        }
        private bool f_rankStrings2;
        private List<byte> _rankStrings2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> RankStrings2
        {
            get
            {
                if (f_rankStrings2)
                    return _rankStrings2;
                long _pos = m_io.Pos;
                m_io.Seek(672172);
                _rankStrings2 = new List<byte>();
                for (var i = 0; i < 48; i++)
                {
                    _rankStrings2.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_rankStrings2 = true;
                return _rankStrings2;
            }
        }
        private bool f_wonderGummiStatBoost;
        private short _wonderGummiStatBoost;

        /// <summary>
        /// Stat boost value if a stat boost occurs when eating Wonder Gummis.
        /// </summary>
        public short WonderGummiStatBoost
        {
            get
            {
                if (f_wonderGummiStatBoost)
                    return _wonderGummiStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663092);
                _wonderGummiStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_wonderGummiStatBoost = true;
                return _wonderGummiStatBoost;
            }
        }
        private bool f_iqGroupSkills;
        private IqGroupSkillsArray _iqGroupSkills;

        /// <summary>
        /// Irdkwia's notes: 25*16*0x1
        /// </summary>
        public IqGroupSkillsArray IqGroupSkills
        {
            get
            {
                if (f_iqGroupSkills)
                    return _iqGroupSkills;
                long _pos = m_io.Pos;
                m_io.Seek(664340);
                _iqGroupSkills = new IqGroupSkillsArray(m_io);
                m_io.Seek(_pos);
                f_iqGroupSkills = true;
                return _iqGroupSkills;
            }
        }
        private bool f_keyboardStringIds;
        private KeyboardStringIdsArray _keyboardStringIds;

        /// <summary>
        /// 30*0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[30]
        /// </summary>
        public KeyboardStringIdsArray KeyboardStringIds
        {
            get
            {
                if (f_keyboardStringIds)
                    return _keyboardStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(722712);
                _keyboardStringIds = new KeyboardStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_keyboardStringIds = true;
                return _keyboardStringIds;
            }
        }
        private bool f_missionFloorRanksPtrs;
        private MissionFloorRanksPtrsArray _missionFloorRanksPtrs;

        /// <summary>
        /// Uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public MissionFloorRanksPtrsArray MissionFloorRanksPtrs
        {
            get
            {
                if (f_missionFloorRanksPtrs)
                    return _missionFloorRanksPtrs;
                long _pos = m_io.Pos;
                m_io.Seek(659544);
                _missionFloorRanksPtrs = new MissionFloorRanksPtrsArray(m_io);
                m_io.Seek(_pos);
                f_missionFloorRanksPtrs = true;
                return _missionFloorRanksPtrs;
            }
        }
        private bool f_controlsChartDefaultWindowParams;
        private WindowParams _controlsChartDefaultWindowParams;

        /// <summary>
        /// Default window_params for a controls_chart.
        /// </summary>
        public WindowParams ControlsChartDefaultWindowParams
        {
            get
            {
                if (f_controlsChartDefaultWindowParams)
                    return _controlsChartDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636084);
                _controlsChartDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_controlsChartDefaultWindowParams = true;
                return _controlsChartDefaultWindowParams;
            }
        }
        private bool f_arm9UnknownTableNa209e164;
        private List<byte> _arm9UnknownTableNa209e164;

        /// <summary>
        /// 256*0x1
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa209e164
        {
            get
            {
                if (f_arm9UnknownTableNa209e164)
                    return _arm9UnknownTableNa209e164;
                long _pos = m_io.Pos;
                m_io.Seek(648936);
                _arm9UnknownTableNa209e164 = new List<byte>();
                for (var i = 0; i < 256; i++)
                {
                    _arm9UnknownTableNa209e164.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa209e164 = true;
                return _arm9UnknownTableNa209e164;
            }
        }
        private bool f_jobMenuItems2;
        private JobMenuItems2Array _jobMenuItems2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems2Array JobMenuItems2
        {
            get
            {
                if (f_jobMenuItems2)
                    return _jobMenuItems2;
                long _pos = m_io.Pos;
                m_io.Seek(695016);
                _jobMenuItems2 = new JobMenuItems2Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems2 = true;
                return _jobMenuItems2;
            }
        }
        private bool f_missionMonsterCount;
        private int _missionMonsterCount;

        /// <summary>
        /// The total number of monsters usable for missions
        /// </summary>
        public int MissionMonsterCount
        {
            get
            {
                if (f_missionMonsterCount)
                    return _missionMonsterCount;
                long _pos = m_io.Pos;
                m_io.Seek(725944);
                _missionMonsterCount = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_missionMonsterCount = true;
                return _missionMonsterCount;
            }
        }
        private bool f_entities;
        private EntitiesArray _entities;

        /// <summary>
        /// Table of entities for the script engine, which can move around and do things within a scene. There are 386 12-byte entries.
        /// 
        /// type: struct script_entity[386]
        /// </summary>
        public EntitiesArray Entities
        {
            get
            {
                if (f_entities)
                    return _entities;
                long _pos = m_io.Pos;
                m_io.Seek(690320);
                _entities = new EntitiesArray(m_io);
                m_io.Seek(_pos);
                f_entities = true;
                return _entities;
            }
        }
        private bool f_bagCapacityTableSpecialEpisodes;
        private BagCapacityTableSpecialEpisodesArray _bagCapacityTableSpecialEpisodes;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: uint32_t[5]
        /// </summary>
        public BagCapacityTableSpecialEpisodesArray BagCapacityTableSpecialEpisodes
        {
            get
            {
                if (f_bagCapacityTableSpecialEpisodes)
                    return _bagCapacityTableSpecialEpisodes;
                long _pos = m_io.Pos;
                m_io.Seek(666948);
                _bagCapacityTableSpecialEpisodes = new BagCapacityTableSpecialEpisodesArray(m_io);
                m_io.Seek(_pos);
                f_bagCapacityTableSpecialEpisodes = true;
                return _bagCapacityTableSpecialEpisodes;
            }
        }
        private bool f_missionListPtr;
        private Pointer _missionListPtr;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public Pointer MissionListPtr
        {
            get
            {
                if (f_missionListPtr)
                    return _missionListPtr;
                long _pos = m_io.Pos;
                m_io.Seek(725948);
                _missionListPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_missionListPtr = true;
                return _missionListPtr;
            }
        }
        private bool f_damageFormulaFlvDeficitDivisor;
        private int _damageFormulaFlvDeficitDivisor;

        /// <summary>
        /// The divisor of the (AT - DEF) term within the &quot;FLV&quot; intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_flv), as a binary fixed-point number with 8 fraction bits (8).
        /// </summary>
        public int DamageFormulaFlvDeficitDivisor
        {
            get
            {
                if (f_damageFormulaFlvDeficitDivisor)
                    return _damageFormulaFlvDeficitDivisor;
                long _pos = m_io.Pos;
                m_io.Seek(663132);
                _damageFormulaFlvDeficitDivisor = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaFlvDeficitDivisor = true;
                return _damageFormulaFlvDeficitDivisor;
            }
        }
        private bool f_tacticNameStringIds;
        private TacticNameStringIdsArray _tacticNameStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[12]
        /// </summary>
        public TacticNameStringIdsArray TacticNameStringIds
        {
            get
            {
                if (f_tacticNameStringIds)
                    return _tacticNameStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(650308);
                _tacticNameStringIds = new TacticNameStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_tacticNameStringIds = true;
                return _tacticNameStringIds;
            }
        }
        private bool f_globalProgressPtr;
        private Pointer _globalProgressPtr;

        /// <summary>
        /// [Runtime]
        /// 
        /// type: struct global_progress*
        /// </summary>
        public Pointer GlobalProgressPtr
        {
            get
            {
                if (f_globalProgressPtr)
                    return _globalProgressPtr;
                long _pos = m_io.Pos;
                m_io.Seek(723088);
                _globalProgressPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_globalProgressPtr = true;
                return _globalProgressPtr;
            }
        }
        private bool f_monsterDataTablePtr;
        private Pointer _monsterDataTablePtr;

        /// <summary>
        /// [Runtime] Points to data about monster species.
        /// </summary>
        public Pointer MonsterDataTablePtr
        {
            get
            {
                if (f_monsterDataTablePtr)
                    return _monsterDataTablePtr;
                long _pos = m_io.Pos;
                m_io.Seek(725712);
                _monsterDataTablePtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_monsterDataTablePtr = true;
                return _monsterDataTablePtr;
            }
        }
        private bool f_rankStrings3;
        private List<byte> _rankStrings3;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> RankStrings3
        {
            get
            {
                if (f_rankStrings3)
                    return _rankStrings3;
                long _pos = m_io.Pos;
                m_io.Seek(672236);
                _rankStrings3 = new List<byte>();
                for (var i = 0; i < 180; i++)
                {
                    _rankStrings3.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_rankStrings3 = true;
                return _rankStrings3;
            }
        }
        private bool f_missionDungeonUnlockTable;
        private MissionDungeonUnlockTableArray _missionDungeonUnlockTable;

        /// <summary>
        /// Irdkwia's notes: SpecialDungeonMissions
        /// 
        /// type: struct dungeon_unlock_entry[3]
        /// </summary>
        public MissionDungeonUnlockTableArray MissionDungeonUnlockTable
        {
            get
            {
                if (f_missionDungeonUnlockTable)
                    return _missionDungeonUnlockTable;
                long _pos = m_io.Pos;
                m_io.Seek(672428);
                _missionDungeonUnlockTable = new MissionDungeonUnlockTableArray(m_io);
                m_io.Seek(_pos);
                f_missionDungeonUnlockTable = true;
                return _missionDungeonUnlockTable;
            }
        }
        private bool f_monsterIdLimit;
        private uint _monsterIdLimit;

        /// <summary>
        /// One more than the maximum valid monster ID (0x483).
        /// </summary>
        public uint MonsterIdLimit
        {
            get
            {
                if (f_monsterIdLimit)
                    return _monsterIdLimit;
                long _pos = m_io.Pos;
                m_io.Seek(346136);
                _monsterIdLimit = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_monsterIdLimit = true;
                return _monsterIdLimit;
            }
        }
        private bool f_musicDurationLookupTable2;
        private MusicDurationLookupTable2Array _musicDurationLookupTable2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int32_t[128]
        /// </summary>
        public MusicDurationLookupTable2Array MusicDurationLookupTable2
        {
            get
            {
                if (f_musicDurationLookupTable2)
                    return _musicDurationLookupTable2;
                long _pos = m_io.Pos;
                m_io.Seek(727444);
                _musicDurationLookupTable2 = new MusicDurationLookupTable2Array(m_io);
                m_io.Seek(_pos);
                f_musicDurationLookupTable2 = true;
                return _musicDurationLookupTable2;
            }
        }
        private bool f_packFilePathsTable;
        private PackFilePathsTableArray _packFilePathsTable;

        /// <summary>
        /// List of pointers to path strings to all known pack files.
        /// The game uses this table to load its resources when launching dungeon mode.
        /// 
        /// type: char*[6]
        /// </summary>
        public PackFilePathsTableArray PackFilePathsTable
        {
            get
            {
                if (f_packFilePathsTable)
                    return _packFilePathsTable;
                long _pos = m_io.Pos;
                m_io.Seek(720728);
                _packFilePathsTable = new PackFilePathsTableArray(m_io);
                m_io.Seek(_pos);
                f_packFilePathsTable = true;
                return _packFilePathsTable;
            }
        }
        private bool f_monsterSpriteData;
        private MonsterSpriteDataArray _monsterSpriteData;

        /// <summary>
        /// Contains information about the sprite size and sprite file size of each monster
        /// </summary>
        public MonsterSpriteDataArray MonsterSpriteData
        {
            get
            {
                if (f_monsterSpriteData)
                    return _monsterSpriteData;
                long _pos = m_io.Pos;
                m_io.Seek(668460);
                _monsterSpriteData = new MonsterSpriteDataArray(m_io);
                m_io.Seek(_pos);
                f_monsterSpriteData = true;
                return _monsterSpriteData;
            }
        }
        private bool f_arm9UnknownTableNa20a20b0;
        private List<byte> _arm9UnknownTableNa20a20b0;

        /// <summary>
        /// 256*0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public List<byte> Arm9UnknownTableNa20a20b0
        {
            get
            {
                if (f_arm9UnknownTableNa20a20b0)
                    return _arm9UnknownTableNa20a20b0;
                long _pos = m_io.Pos;
                m_io.Seek(665140);
                _arm9UnknownTableNa20a20b0 = new List<byte>();
                for (var i = 0; i < 512; i++)
                {
                    _arm9UnknownTableNa20a20b0.Add(m_io.ReadU1());
                }
                m_io.Seek(_pos);
                f_arm9UnknownTableNa20a20b0 = true;
                return _arm9UnknownTableNa20a20b0;
            }
        }
        private bool f_secondaryTerrainTypes;
        private SecondaryTerrainTypesArray _secondaryTerrainTypes;

        /// <summary>
        /// The type of secondary terrain for each dungeon in the game.
        /// 
        /// This is an array of 200 bytes. Each byte is an enum corresponding to one dungeon.
        /// 
        /// type: struct secondary_terrain_type_8[200]
        /// </summary>
        public SecondaryTerrainTypesArray SecondaryTerrainTypes
        {
            get
            {
                if (f_secondaryTerrainTypes)
                    return _secondaryTerrainTypes;
                long _pos = m_io.Pos;
                m_io.Seek(663660);
                _secondaryTerrainTypes = new SecondaryTerrainTypesArray(m_io);
                m_io.Seek(_pos);
                f_secondaryTerrainTypes = true;
                return _secondaryTerrainTypes;
            }
        }
        private bool f_munchBeltStatBoost;
        private short _munchBeltStatBoost;

        /// <summary>
        /// Stat boost value for the Munch Belt.
        /// </summary>
        public short MunchBeltStatBoost
        {
            get
            {
                if (f_munchBeltStatBoost)
                    return _munchBeltStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663040);
                _munchBeltStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_munchBeltStatBoost = true;
                return _munchBeltStatBoost;
            }
        }
        private bool f_gxiDmaId;
        private uint _gxiDmaId;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public uint GxiDmaId
        {
            get
            {
                if (f_gxiDmaId)
                    return _gxiDmaId;
                long _pos = m_io.Pos;
                m_io.Seek(734428);
                _gxiDmaId = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_gxiDmaId = true;
                return _gxiDmaId;
            }
        }
        private bool f_stringDungeonDungeonBin;
        private StringDungeonDungeonBinArray _stringDungeonDungeonBin;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDungeonDungeonBinArray StringDungeonDungeonBin
        {
            get
            {
                if (f_stringDungeonDungeonBin)
                    return _stringDungeonDungeonBin;
                long _pos = m_io.Pos;
                m_io.Seek(610204);
                _stringDungeonDungeonBin = new StringDungeonDungeonBinArray(m_io);
                m_io.Seek(_pos);
                f_stringDungeonDungeonBin = true;
                return _stringDungeonDungeonBin;
            }
        }
        private bool f_unknownPpBoostAmount;
        private short _unknownPpBoostAmount;

        /// <summary>
        /// PP boost value for an unknown effect. Corresponds to the flag f_unknown_pp_boost in struct move.
        /// </summary>
        public short UnknownPpBoostAmount
        {
            get
            {
                if (f_unknownPpBoostAmount)
                    return _unknownPpBoostAmount;
                long _pos = m_io.Pos;
                m_io.Seek(663032);
                _unknownPpBoostAmount = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_unknownPpBoostAmount = true;
                return _unknownPpBoostAmount;
            }
        }
        private bool f_bagItemsPtrMirror;
        private Pointer _bagItemsPtrMirror;

        /// <summary>
        /// [Runtime] Probably a mirror of ram.yml::BAG_ITEMS_PTR?
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public Pointer BagItemsPtrMirror
        {
            get
            {
                if (f_bagItemsPtrMirror)
                    return _bagItemsPtrMirror;
                long _pos = m_io.Pos;
                m_io.Seek(720752);
                _bagItemsPtrMirror = new Pointer(m_io);
                m_io.Seek(_pos);
                f_bagItemsPtrMirror = true;
                return _bagItemsPtrMirror;
            }
        }
        private bool f_lfoWaveformCallbacks;
        private LfoWaveformCallbacksArray _lfoWaveformCallbacks;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public LfoWaveformCallbacksArray LfoWaveformCallbacks
        {
            get
            {
                if (f_lfoWaveformCallbacks)
                    return _lfoWaveformCallbacks;
                long _pos = m_io.Pos;
                m_io.Seek(727956);
                _lfoWaveformCallbacks = new LfoWaveformCallbacksArray(m_io);
                m_io.Seek(_pos);
                f_lfoWaveformCallbacks = true;
                return _lfoWaveformCallbacks;
            }
        }
        private bool f_wanTable;
        private Pointer _wanTable;

        /// <summary>
        /// pointer to the list of wan sprite loaded in RAM
        /// 
        /// struct wan_table*
        /// </summary>
        public Pointer WanTable
        {
            get
            {
                if (f_wanTable)
                    return _wanTable;
                long _pos = m_io.Pos;
                m_io.Seek(722212);
                _wanTable = new Pointer(m_io);
                m_io.Seek(_pos);
                f_wanTable = true;
                return _wanTable;
            }
        }
        private bool f_stringDebugFormatLineFile;
        private StringDebugFormatLineFileArray _stringDebugFormatLineFile;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugFormatLineFileArray StringDebugFormatLineFile
        {
            get
            {
                if (f_stringDebugFormatLineFile)
                    return _stringDebugFormatLineFile;
                long _pos = m_io.Pos;
                m_io.Seek(610044);
                _stringDebugFormatLineFile = new StringDebugFormatLineFileArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugFormatLineFile = true;
                return _stringDebugFormatLineFile;
            }
        }
        private bool f_typeSpecificExclusiveItems;
        private TypeSpecificExclusiveItemsArray _typeSpecificExclusiveItems;

        /// <summary>
        /// Lists of type-specific exclusive items (silk, dust, gem, globe) for each type.
        /// 
        /// type: struct item_id_16[17][4]
        /// </summary>
        public TypeSpecificExclusiveItemsArray TypeSpecificExclusiveItems
        {
            get
            {
                if (f_typeSpecificExclusiveItems)
                    return _typeSpecificExclusiveItems;
                long _pos = m_io.Pos;
                m_io.Seek(626800);
                _typeSpecificExclusiveItems = new TypeSpecificExclusiveItemsArray(m_io);
                m_io.Seek(_pos);
                f_typeSpecificExclusiveItems = true;
                return _typeSpecificExclusiveItems;
            }
        }
        private bool f_jobWindowParams2;
        private WindowParams _jobWindowParams2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public WindowParams JobWindowParams2
        {
            get
            {
                if (f_jobWindowParams2)
                    return _jobWindowParams2;
                long _pos = m_io.Pos;
                m_io.Seek(695408);
                _jobWindowParams2 = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_jobWindowParams2 = true;
                return _jobWindowParams2;
            }
        }
        private bool f_missionRankPoints;
        private MissionRankPointsArray _missionRankPoints;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int[16]
        /// </summary>
        public MissionRankPointsArray MissionRankPoints
        {
            get
            {
                if (f_missionRankPoints)
                    return _missionRankPoints;
                long _pos = m_io.Pos;
                m_io.Seek(672620);
                _missionRankPoints = new MissionRankPointsArray(m_io);
                m_io.Seek(_pos);
                f_missionRankPoints = true;
                return _missionRankPoints;
            }
        }
        private bool f_debugMenuDefaultWindowParams;
        private WindowParams _debugMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a debug_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateDebugMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateDebugMenu.
        /// </summary>
        public WindowParams DebugMenuDefaultWindowParams
        {
            get
            {
                if (f_debugMenuDefaultWindowParams)
                    return _debugMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635976);
                _debugMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_debugMenuDefaultWindowParams = true;
                return _debugMenuDefaultWindowParams;
            }
        }
        private bool f_render3dFunctions64;
        private Render3dFunctions64Array _render3dFunctions64;

        /// <summary>
        /// Pointers to the 8 functions available for rendering a render_3d_element_64
        /// 
        /// type: render_3d_element_64_fn_t[8]
        /// </summary>
        public Render3dFunctions64Array Render3dFunctions64
        {
            get
            {
                if (f_render3dFunctions64)
                    return _render3dFunctions64;
                long _pos = m_io.Pos;
                m_io.Seek(722308);
                _render3dFunctions64 = new Render3dFunctions64Array(m_io);
                m_io.Seek(_pos);
                f_render3dFunctions64 = true;
                return _render3dFunctions64;
            }
        }
        private bool f_naturalLogValueTable;
        private NaturalLogValueTableArray _naturalLogValueTable;

        /// <summary>
        /// A table of values for the natural log function corresponding to integer arguments in the range [0, 2047].
        /// 
        /// Each value is stored as a 16-bit fixed-point number with 12 fractional bits. I.e., to get the actual natural log value, take the table entry and divide it by 2^12.
        /// 
        /// The value at an input of 0 is just listed as 0; the Log function makes sure the input is always at least 1 before reading the table.
        /// 
        /// type: fx16_12[2048]
        /// </summary>
        public NaturalLogValueTableArray NaturalLogValueTable
        {
            get
            {
                if (f_naturalLogValueTable)
                    return _naturalLogValueTable;
                long _pos = m_io.Pos;
                m_io.Seek(595936);
                _naturalLogValueTable = new NaturalLogValueTableArray(m_io);
                m_io.Seek(_pos);
                f_naturalLogValueTable = true;
                return _naturalLogValueTable;
            }
        }
        private bool f_evolutionSpecialStatBonuses;
        private EvolutionSpecialStatBonusesArray _evolutionSpecialStatBonuses;

        /// <summary>
        /// 0x2: SpAtk + 0x2: SpDef
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public EvolutionSpecialStatBonusesArray EvolutionSpecialStatBonuses
        {
            get
            {
                if (f_evolutionSpecialStatBonuses)
                    return _evolutionSpecialStatBonuses;
                long _pos = m_io.Pos;
                m_io.Seek(663144);
                _evolutionSpecialStatBonuses = new EvolutionSpecialStatBonusesArray(m_io);
                m_io.Seek(_pos);
                f_evolutionSpecialStatBonuses = true;
                return _evolutionSpecialStatBonuses;
            }
        }
        private bool f_itemDataTablePtrs;
        private ItemDataTablePtrsArray _itemDataTablePtrs;

        /// <summary>
        /// [Runtime] List of pointers to various item data tables.
        /// 
        /// The first two pointers are definitely item-related (although the order appears to be flipped between EU/NA?). Not sure about the third pointer.
        /// </summary>
        public ItemDataTablePtrsArray ItemDataTablePtrs
        {
            get
            {
                if (f_itemDataTablePtrs)
                    return _itemDataTablePtrs;
                long _pos = m_io.Pos;
                m_io.Seek(720760);
                _itemDataTablePtrs = new ItemDataTablePtrsArray(m_io);
                m_io.Seek(_pos);
                f_itemDataTablePtrs = true;
                return _itemDataTablePtrs;
            }
        }
        private bool f_punchMoveList;
        private PunchMoveListArray _punchMoveList;

        /// <summary>
        /// Null-terminated list of all the punch moves, as 2-byte move IDs.
        /// 
        /// type: struct move_id_16[16]
        /// </summary>
        public PunchMoveListArray PunchMoveList
        {
            get
            {
                if (f_punchMoveList)
                    return _punchMoveList;
                long _pos = m_io.Pos;
                m_io.Seek(627150);
                _punchMoveList = new PunchMoveListArray(m_io);
                m_io.Seek(_pos);
                f_punchMoveList = true;
                return _punchMoveList;
            }
        }
        private bool f_damageFormulaDefPrefactor;
        private int _damageFormulaDefPrefactor;

        /// <summary>
        /// The prefactor to the &quot;DEF&quot; (defense) intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_def), as a binary fixed-point number with 8 fraction bits (-0.5).
        /// </summary>
        public int DamageFormulaDefPrefactor
        {
            get
            {
                if (f_damageFormulaDefPrefactor)
                    return _damageFormulaDefPrefactor;
                long _pos = m_io.Pos;
                m_io.Seek(663156);
                _damageFormulaDefPrefactor = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_damageFormulaDefPrefactor = true;
                return _damageFormulaDefPrefactor;
            }
        }
        private bool f_events;
        private EventsArray _events;

        /// <summary>
        /// Table of levels for the script engine, in which scenes can take place. There are a version-dependent number of 12-byte entries.
        /// 
        /// type: struct script_level[length / 12]
        /// </summary>
        public EventsArray Events
        {
            get
            {
                if (f_events)
                    return _events;
                long _pos = m_io.Pos;
                m_io.Seek(678872);
                _events = new EventsArray(m_io);
                m_io.Seek(_pos);
                f_events = true;
                return _events;
            }
        }
        private bool f_dungeonReturnStatusTable;
        private DungeonReturnStatusTableArray _dungeonReturnStatusTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct dungeon_return_status[91]
        /// </summary>
        public DungeonReturnStatusTableArray DungeonReturnStatusTable
        {
            get
            {
                if (f_dungeonReturnStatusTable)
                    return _dungeonReturnStatusTable;
                long _pos = m_io.Pos;
                m_io.Seek(650536);
                _dungeonReturnStatusTable = new DungeonReturnStatusTableArray(m_io);
                m_io.Seek(_pos);
                f_dungeonReturnStatusTable = true;
                return _dungeonReturnStatusTable;
            }
        }
        private bool f_zincBandStatBoost;
        private short _zincBandStatBoost;

        /// <summary>
        /// Stat boost value for the Zinc Band.
        /// </summary>
        public short ZincBandStatBoost
        {
            get
            {
                if (f_zincBandStatBoost)
                    return _zincBandStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(663096);
                _zincBandStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_zincBandStatBoost = true;
                return _zincBandStatBoost;
            }
        }
        private bool f_mapMarkerPlacements;
        private MapMarkerPlacementsArray _mapMarkerPlacements;

        /// <summary>
        /// The map marker position of each dungeon on the Wonder Map.
        /// 
        /// This is an array of 310 map marker structs. Each entry is 8 bytes, and contains positional information about a dungeon on the map.
        /// 
        /// See the struct definitions and Frostbyte's dungeon data document for more info.
        /// 
        /// type: struct map_marker[310]
        /// </summary>
        public MapMarkerPlacementsArray MapMarkerPlacements
        {
            get
            {
                if (f_mapMarkerPlacements)
                    return _mapMarkerPlacements;
                long _pos = m_io.Pos;
                m_io.Seek(695664);
                _mapMarkerPlacements = new MapMarkerPlacementsArray(m_io);
                m_io.Seek(_pos);
                f_mapMarkerPlacements = true;
                return _mapMarkerPlacements;
            }
        }
        private bool f_advancedMenuDefaultWindowParams;
        private WindowParams _advancedMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for an advanced_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAdvancedMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateAdvancedMenu.
        /// </summary>
        public WindowParams AdvancedMenuDefaultWindowParams
        {
            get
            {
                if (f_advancedMenuDefaultWindowParams)
                    return _advancedMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(635884);
                _advancedMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_advancedMenuDefaultWindowParams = true;
                return _advancedMenuDefaultWindowParams;
            }
        }
        private bool f_multitalentPpBoostAmount;
        private short _multitalentPpBoostAmount;

        /// <summary>
        /// PP boost value for the Multitalent IQ skill.
        /// </summary>
        public short MultitalentPpBoostAmount
        {
            get
            {
                if (f_multitalentPpBoostAmount)
                    return _multitalentPpBoostAmount;
                long _pos = m_io.Pos;
                m_io.Seek(663076);
                _multitalentPpBoostAmount = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_multitalentPpBoostAmount = true;
                return _multitalentPpBoostAmount;
            }
        }
        private bool f_rankStringPtrTable;
        private RankStringPtrTableArray _rankStringPtrTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: const char*[16]
        /// </summary>
        public RankStringPtrTableArray RankStringPtrTable
        {
            get
            {
                if (f_rankStringPtrTable)
                    return _rankStringPtrTable;
                long _pos = m_io.Pos;
                m_io.Seek(725980);
                _rankStringPtrTable = new RankStringPtrTableArray(m_io);
                m_io.Seek(_pos);
                f_rankStringPtrTable = true;
                return _rankStringPtrTable;
            }
        }
        private bool f_stringMonsterMonsterBin;
        private StringMonsterMonsterBinArray _stringMonsterMonsterBin;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringMonsterMonsterBinArray StringMonsterMonsterBin
        {
            get
            {
                if (f_stringMonsterMonsterBin)
                    return _stringMonsterMonsterBin;
                long _pos = m_io.Pos;
                m_io.Seek(610164);
                _stringMonsterMonsterBin = new StringMonsterMonsterBinArray(m_io);
                m_io.Seek(_pos);
                f_stringMonsterMonsterBin = true;
                return _stringMonsterMonsterBin;
            }
        }
        private bool f_defaultMemoryArenaSize;
        private uint _defaultMemoryArenaSize;

        /// <summary>
        /// Length in bytes of the default memory allocation arena, 1991680.
        /// </summary>
        public uint DefaultMemoryArenaSize
        {
            get
            {
                if (f_defaultMemoryArenaSize)
                    return _defaultMemoryArenaSize;
                long _pos = m_io.Pos;
                m_io.Seek(3672);
                _defaultMemoryArenaSize = m_io.ReadU4le();
                m_io.Seek(_pos);
                f_defaultMemoryArenaSize = true;
                return _defaultMemoryArenaSize;
            }
        }
        private bool f_jobMenuItems12;
        private JobMenuItems12Array _jobMenuItems12;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems12Array JobMenuItems12
        {
            get
            {
                if (f_jobMenuItems12)
                    return _jobMenuItems12;
                long _pos = m_io.Pos;
                m_io.Seek(695344);
                _jobMenuItems12 = new JobMenuItems12Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems12 = true;
                return _jobMenuItems12;
            }
        }
        private bool f_dungeonDataList;
        private DungeonDataListArray _dungeonDataList;

        /// <summary>
        /// Data about every dungeon in the game.
        /// 
        /// This is an array of 180 dungeon data list entry structs. Each entry is 4 bytes, and contains floor count information along with an index into the bulk of the dungeon's data in mappa_s.bin.
        /// 
        /// See the struct definitions and Frostbyte's dungeon data document for more info.
        /// 
        /// type: struct dungeon_data_list_entry[180]
        /// </summary>
        public DungeonDataListArray DungeonDataList
        {
            get
            {
                if (f_dungeonDataList)
                    return _dungeonDataList;
                long _pos = m_io.Pos;
                m_io.Seek(649508);
                _dungeonDataList = new DungeonDataListArray(m_io);
                m_io.Seek(_pos);
                f_dungeonDataList = true;
                return _dungeonDataList;
            }
        }
        private bool f_stringDebugSpacedPrint;
        private StringDebugSpacedPrintArray _stringDebugSpacedPrint;

        /// <summary>
        /// This symbol is missing documentation.
        /// </summary>
        public StringDebugSpacedPrintArray StringDebugSpacedPrint
        {
            get
            {
                if (f_stringDebugSpacedPrint)
                    return _stringDebugSpacedPrint;
                long _pos = m_io.Pos;
                m_io.Seek(610096);
                _stringDebugSpacedPrint = new StringDebugSpacedPrintArray(m_io);
                m_io.Seek(_pos);
                f_stringDebugSpacedPrint = true;
                return _stringDebugSpacedPrint;
            }
        }
        private bool f_tacticsUnlockLevelTable;
        private TacticsUnlockLevelTableArray _tacticsUnlockLevelTable;

        /// <summary>
        /// type: int16_t[12]
        /// </summary>
        public TacticsUnlockLevelTableArray TacticsUnlockLevelTable
        {
            get
            {
                if (f_tacticsUnlockLevelTable)
                    return _tacticsUnlockLevelTable;
                long _pos = m_io.Pos;
                m_io.Seek(663236);
                _tacticsUnlockLevelTable = new TacticsUnlockLevelTableArray(m_io);
                m_io.Seek(_pos);
                f_tacticsUnlockLevelTable = true;
                return _tacticsUnlockLevelTable;
            }
        }
        private bool f_loadedOverlayGroup0;
        private OverlayGroupId _loadedOverlayGroup0;

        /// <summary>
        /// [Runtime] The overlay group ID of the overlay currently loaded in slot 0. A group ID of 0 denotes no overlay.
        /// 
        /// Overlay group IDs that can be loaded in slot 0:
        /// - 0x06 (overlay 3)
        /// - 0x07 (overlay 6)
        /// - 0x08 (overlay 4)
        /// - 0x09 (overlay 5)
        /// - 0x0A (overlay 7)
        /// - 0x0B (overlay 8)
        /// - 0x0C (overlay 9)
        /// - 0x10 (overlay 12)
        /// - 0x11 (overlay 13)
        /// - 0x12 (overlay 14)
        /// - 0x13 (overlay 15)
        /// - 0x14 (overlay 16)
        /// - 0x15 (overlay 17)
        /// - 0x16 (overlay 18)
        /// - 0x17 (overlay 19)
        /// - 0x18 (overlay 20)
        /// - 0x19 (overlay 21)
        /// - 0x1A (overlay 22)
        /// - 0x1B (overlay 23)
        /// - 0x1C (overlay 24)
        /// - 0x1D (overlay 25)
        /// - 0x1E (overlay 26)
        /// - 0x1F (overlay 27)
        /// - 0x20 (overlay 28)
        /// - 0x21 (overlay 30)
        /// - 0x22 (overlay 31)
        /// - 0x23 (overlay 32)
        /// - 0x24 (overlay 33)
        /// 
        /// type: enum overlay_group_id
        /// </summary>
        public OverlayGroupId LoadedOverlayGroup0
        {
            get
            {
                if (f_loadedOverlayGroup0)
                    return _loadedOverlayGroup0;
                long _pos = m_io.Pos;
                m_io.Seek(719568);
                _loadedOverlayGroup0 = new OverlayGroupId(m_io);
                m_io.Seek(_pos);
                f_loadedOverlayGroup0 = true;
                return _loadedOverlayGroup0;
            }
        }
        private bool f_adventureLogPtr;
        private Pointer _adventureLogPtr;

        /// <summary>
        /// [Runtime]
        /// 
        /// type: struct adventure_log*
        /// </summary>
        public Pointer AdventureLogPtr
        {
            get
            {
                if (f_adventureLogPtr)
                    return _adventureLogPtr;
                long _pos = m_io.Pos;
                m_io.Seek(723092);
                _adventureLogPtr = new Pointer(m_io);
                m_io.Seek(_pos);
                f_adventureLogPtr = true;
                return _adventureLogPtr;
            }
        }
        private bool f_textBoxDefaultWindowParams;
        private WindowParams _textBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for a text_box.
        /// </summary>
        public WindowParams TextBoxDefaultWindowParams
        {
            get
            {
                if (f_textBoxDefaultWindowParams)
                    return _textBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(636040);
                _textBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_textBoxDefaultWindowParams = true;
                return _textBoxDefaultWindowParams;
            }
        }
        private bool f_scriptVarsValuesPtr0;
        private Pointer _scriptVarsValuesPtr0;

        /// <summary>
        /// Hard-coded pointer to SCRIPT_VARS_VALUES.
        /// </summary>
        public Pointer ScriptVarsValuesPtr0
        {
            get
            {
                if (f_scriptVarsValuesPtr0)
                    return _scriptVarsValuesPtr0;
                long _pos = m_io.Pos;
                m_io.Seek(308784);
                _scriptVarsValuesPtr0 = new Pointer(m_io);
                m_io.Seek(_pos);
                f_scriptVarsValuesPtr0 = true;
                return _scriptVarsValuesPtr0;
            }
        }
        private bool f_statusNameStringIds;
        private StatusNameStringIdsArray _statusNameStringIds;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[102]
        /// </summary>
        public StatusNameStringIdsArray StatusNameStringIds
        {
            get
            {
                if (f_statusNameStringIds)
                    return _statusNameStringIds;
                long _pos = m_io.Pos;
                m_io.Seek(650332);
                _statusNameStringIds = new StatusNameStringIdsArray(m_io);
                m_io.Seek(_pos);
                f_statusNameStringIds = true;
                return _statusNameStringIds;
            }
        }
        private bool f_jobMenuItems5;
        private JobMenuItems5Array _jobMenuItems5;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public JobMenuItems5Array JobMenuItems5
        {
            get
            {
                if (f_jobMenuItems5)
                    return _jobMenuItems5;
                long _pos = m_io.Pos;
                m_io.Seek(695176);
                _jobMenuItems5 = new JobMenuItems5Array(m_io);
                m_io.Seek(_pos);
                f_jobMenuItems5 = true;
                return _jobMenuItems5;
            }
        }
        private Arm9Data m_root;
        private KaitaiStruct m_parent;
        public Arm9Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
