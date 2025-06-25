// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay10Data : KaitaiStruct
    {
        public static Overlay10Data FromFile(string fileName)
        {
            return new Overlay10Data(new KaitaiStream(fileName));
        }

        public Overlay10Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay10Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_iceFangCringeChance = false;
            f_waterSpoutDamageMultTable = false;
            f_octazookaLowerAccuracyChance = false;
            f_miracleChestExpBoost = false;
            f_yawnTurnRange = false;
            f_weatherMoveTurnCount = false;
            f_applesAndBerriesItemIds = false;
            f_synthesisHpRestorationTable = false;
            f_lusterPurgeLowerSpecialDefenseChance = false;
            f_unownStoneDropChance = false;
            f_expEliteExpBoost = false;
            f_blazeKickBurnChance = false;
            f_zincStatBoost = false;
            f_aiRegularAttackWeights = false;
            f_itemAnimationInfo = false;
            f_effectAnimationInfo = false;
            f_aiConfusedNoAttackChance = false;
            f_moveAnimationInfo = false;
            f_restTurnRange = false;
            f_shopItemChances = false;
            f_bounceDamageMultiplier = false;
            f_ironTailLowerDefenseChance = false;
            f_thunderParalyzeChance = false;
            f_matchupNotVeryEffectiveMultiplier = false;
            f_crushClawLowerDefenseChance = false;
            f_fixedRoomPropertiesTable = false;
            f_burnDamage = false;
            f_geoPebbleDamage = false;
            f_typeMatchupTable = false;
            f_spawnCooldownThiefAlert = false;
            f_calciumStatBoost = false;
            f_burnDamageCooldown = false;
            f_firstDungeonWithMonsterHouseTraps = false;
            f_diveDamageMultiplier = false;
            f_femaleEvasionStageMultipliers = false;
            f_powderSnowFreezeChance = false;
            f_lastResortDamageMultTable = false;
            f_digDamageMultiplier = false;
            f_flareBlitzBurnChance = false;
            f_bounceParalyzeChance = false;
            f_randomMusicIdTable = false;
            f_rainAbilityBonusRegen = false;
            f_silverSpikePower = false;
            f_thundershockParalyzeChance = false;
            f_tintedLensMultiplier = false;
            f_crunchLowerDefenseChance = false;
            f_wringOutDamageMultTable = false;
            f_matchupSuperEffectiveMultiplier = false;
            f_defensiveStatStageMultipliers = false;
            f_matchupNeutralMultiplierErraticPlayer = false;
            f_forewarnForcedMissChance = false;
            f_matchupImmuneMultiplier = false;
            f_matchupImmuneMultiplierErraticPlayer = false;
            f_lickParalyzeChance = false;
            f_kecleonShopBoostChanceMultiplier = false;
            f_razorWindDamageMultiplier = false;
            f_shadowForceDamageMultiplier = false;
            f_typeMatchupCombinatorTable = false;
            f_silverWindBoostChance = false;
            f_nightmareTurnRange = false;
            f_flameWheelBurnChance = false;
            f_cacneaSpikePower = false;
            f_smokescreenTurnRange = false;
            f_airBladeDamageMultiplier = false;
            f_powerPitcherDamageMultiplier = false;
            f_meteorMashBoostAttackChance = false;
            f_maleAccuracyStageMultipliers = false;
            f_spawnCapWithMonsterHouse = false;
            f_speedBoostTurns = false;
            f_naturePowerTable = false;
            f_fireFangCringeChance = false;
            f_snoreCringeChance = false;
            f_eruptionDamageMultTable = false;
            f_oranBerryHpRestoration = false;
            f_skyAttackCringeChance = false;
            f_steelWingBoostDefenseChance = false;
            f_naturalGiftItemTable = false;
            f_recruitmentLevelBoostTable = false;
            f_biteCringeChance = false;
            f_eatItemEffectIgnoreList = false;
            f_flamethrowerBurnChance = false;
            f_auroraBeamLowerAttackChance = false;
            f_wonderChestExpBoost = false;
            f_burnDamageMultiplier = false;
            f_sleepTurnRange = false;
            f_poisonDamage = false;
            f_sacredFireBurnChance = false;
            f_hiddenStairsSpawnChanceMultiplier = false;
            f_monsterHouseMaxMonsterSpawns = false;
            f_speedBoostTurnRange = false;
            f_smogPoisonChance = false;
            f_technicianMovePowerThreshold = false;
            f_tilesetProperties = false;
            f_ginsengChance3 = false;
            f_fixedRoomMonsterSpawnStatsTable = false;
            f_secretPowerEffectChance = false;
            f_matchupNeutralMultiplier = false;
            f_extrasensoryCringeChance = false;
            f_meFirstMultiplier = false;
            f_matchupNotVeryEffectiveMultiplierErraticPlayer = false;
            f_wishBonusRegen = false;
            f_ironThornPower = false;
            f_weatherBallDamageMultTable = false;
            f_rareFossilDamage = false;
            f_skullBashDamageMultiplier = false;
            f_flyDamageMultiplier = false;
            f_sonicboomFixedDamage = false;
            f_triAttackStatusChance = false;
            f_castformWeatherAttributeTable = false;
            f_sportConditionTurnRange = false;
            f_perishSongTurnRange = false;
            f_sitrusBerryFullHpBoost = false;
            f_moonlightHpRestorationTable = false;
            f_intimidatorActivationChance = false;
            f_waterfallCringeChance = false;
            f_thunderFangParalyzeChance = false;
            f_thrownItemHitChance = false;
            f_inventoryMenuDefaultWindowParams = false;
            f_metalClawBoostAttackChance = false;
            f_mistBallLowerSpecialAttackChance = false;
            f_goldThornPower = false;
            f_morningSunHpRestorationTable = false;
            f_stickPower = false;
            f_musicIdTable = false;
            f_oranBerryFullHpBoost = false;
            f_fakeOutCringeChance = false;
            f_exclusiveItemExpBoost = false;
            f_superLuckCritRateBoost = false;
            f_detectBandMoveAccuracyDrop = false;
            f_twineedlePoisonChance = false;
            f_poisonTailPoisonChance = false;
            f_spawnCapNoMonsterHouse = false;
            f_bubbleLowerSpeedChance = false;
            f_whirlpoolConstrictionChance = false;
            f_thunderboltParalyzeChance = false;
            f_constrictLowerSpeedChance = false;
            f_imprisonTurnRange = false;
            f_chargeBeamBoostSpecialAttackChance = false;
            f_ironStatBoost = false;
            f_corsolaTwigPower = false;
            f_gravelerockDamage = false;
            f_lifeSeedHpBoost = false;
            f_muddyWaterLowerAccuracyChance = false;
            f_quickDodgerMoveAccuracyDrop = false;
            f_matchupSuperEffectiveMultiplierErraticPlayer = false;
            f_orenBerryDamage = false;
            f_badPoisonDamageCooldown = false;
            f_trapAnimationInfo = false;
            f_sureShotTurnRange = false;
            f_poisonDamageCooldown = false;
            f_shadowBallLowerSpecialDefenseChance = false;
            f_proteinStatBoost = false;
            f_twisterCringeChance = false;
            f_goldFangPower = false;
            f_healOrderHpRestoration = false;
            f_poisonStingPoisonChance = false;
            f_healingWishHpRestoration = false;
            f_leechSeedDamageCooldown = false;
            f_specialMonsterMoveAnimationInfo = false;
            f_maleEvasionStageMultipliers = false;
            f_iceBodyBonusRegen = false;
            f_poisonFangPoisonChance = false;
            f_facadeDamageMultiplier = false;
            f_trapBusterActivationChance = false;
            f_roostHpRestorationTable = false;
            f_sitrusBerryHpRestoration = false;
            f_thunderFangCringeChance = false;
            f_setDamageStatusDamage = false;
            f_offensiveStatStageMultipliers = false;
            f_femaleAccuracyStageMultipliers = false;
            f_aftermathChance = false;
            f_rockSlideCringeChance = false;
            f_badPoisonDamageTable = false;
            f_skyAttackDamageMultiplier = false;
            f_weatherBallTypeTable = false;
            f_dragonRageFixedDamage = false;
            f_headbuttCringeChance = false;
            f_focusPunchDamageMultiplier = false;
            f_monsterHouseMaxNonMonsterSpawns = false;
            f_leechSeedHpDrain = false;
            f_psybeamConfuseChance = false;
            f_dizzyPunchConfuseChance = false;
            f_spawnCooldown = false;
            f_typeAdvantageMasterCritRate = false;
            f_reversalDamageMultTable = false;
            f_metronomeTable = false;
            f_scopeLensCritRateBoost = false;
            f_solarbeamDamageMultiplier = false;
            f_iceFangFreezeChance = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_iceFangCringeChance;
        private short _iceFangCringeChance;

        /// <summary>
        /// The chance of Ice Fang inflicting the cringe status, as a percentage (25%).
        /// </summary>
        public short IceFangCringeChance
        {
            get
            {
                if (f_iceFangCringeChance)
                    return _iceFangCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31444);
                _iceFangCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_iceFangCringeChance = true;
                return _iceFangCringeChance;
            }
        }
        private bool f_waterSpoutDamageMultTable;
        private WaterSpoutDamageMultTableArray _waterSpoutDamageMultTable;

        /// <summary>
        /// Table of damage multipliers for Water Spout at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// type: int[4]
        /// </summary>
        public WaterSpoutDamageMultTableArray WaterSpoutDamageMultTable
        {
            get
            {
                if (f_waterSpoutDamageMultTable)
                    return _waterSpoutDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(32572);
                _waterSpoutDamageMultTable = new WaterSpoutDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_waterSpoutDamageMultTable = true;
                return _waterSpoutDamageMultTable;
            }
        }
        private bool f_octazookaLowerAccuracyChance;
        private short _octazookaLowerAccuracyChance;

        /// <summary>
        /// The chance of Octazooka lowering accuracy, as a percentage (60%).
        /// </summary>
        public short OctazookaLowerAccuracyChance
        {
            get
            {
                if (f_octazookaLowerAccuracyChance)
                    return _octazookaLowerAccuracyChance;
                long _pos = m_io.Pos;
                m_io.Seek(31384);
                _octazookaLowerAccuracyChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_octazookaLowerAccuracyChance = true;
                return _octazookaLowerAccuracyChance;
            }
        }
        private bool f_miracleChestExpBoost;
        private short _miracleChestExpBoost;

        /// <summary>
        /// The percentage increase in experience from the Miracle Chest item
        /// </summary>
        public short MiracleChestExpBoost
        {
            get
            {
                if (f_miracleChestExpBoost)
                    return _miracleChestExpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31792);
                _miracleChestExpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_miracleChestExpBoost = true;
                return _miracleChestExpBoost;
            }
        }
        private bool f_yawnTurnRange;
        private YawnTurnRangeArray _yawnTurnRange;

        /// <summary>
        /// The turn range for the Yawning status inflicted by Yawn, [2, 2].
        /// 
        /// type: int16_t[2]
        /// </summary>
        public YawnTurnRangeArray YawnTurnRange
        {
            get
            {
                if (f_yawnTurnRange)
                    return _yawnTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(32248);
                _yawnTurnRange = new YawnTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_yawnTurnRange = true;
                return _yawnTurnRange;
            }
        }
        private bool f_weatherMoveTurnCount;
        private short _weatherMoveTurnCount;

        /// <summary>
        /// The number of turns the moves rain dance, hail, sandstorm, sunny day and defog change the weather for. (3000)
        /// </summary>
        public short WeatherMoveTurnCount
        {
            get
            {
                if (f_weatherMoveTurnCount)
                    return _weatherMoveTurnCount;
                long _pos = m_io.Pos;
                m_io.Seek(31724);
                _weatherMoveTurnCount = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_weatherMoveTurnCount = true;
                return _weatherMoveTurnCount;
            }
        }
        private bool f_applesAndBerriesItemIds;
        private ApplesAndBerriesItemIdsArray _applesAndBerriesItemIds;

        /// <summary>
        /// Table of item IDs for Apples and Berries, which trigger the exclusive item effect EXCLUSIVE_EFF_RECOVER_HP_FROM_APPLES_AND_BERRIES.
        /// 
        /// type: struct item_id_16[66]
        /// </summary>
        public ApplesAndBerriesItemIdsArray ApplesAndBerriesItemIds
        {
            get
            {
                if (f_applesAndBerriesItemIds)
                    return _applesAndBerriesItemIds;
                long _pos = m_io.Pos;
                m_io.Seek(33872);
                _applesAndBerriesItemIds = new ApplesAndBerriesItemIdsArray(m_io);
                m_io.Seek(_pos);
                f_applesAndBerriesItemIds = true;
                return _applesAndBerriesItemIds;
            }
        }
        private bool f_synthesisHpRestorationTable;
        private SynthesisHpRestorationTableArray _synthesisHpRestorationTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Synthesis.
        /// 
        /// type: int16_t[8]
        /// </summary>
        public SynthesisHpRestorationTableArray SynthesisHpRestorationTable
        {
            get
            {
                if (f_synthesisHpRestorationTable)
                    return _synthesisHpRestorationTable;
                long _pos = m_io.Pos;
                m_io.Seek(32492);
                _synthesisHpRestorationTable = new SynthesisHpRestorationTableArray(m_io);
                m_io.Seek(_pos);
                f_synthesisHpRestorationTable = true;
                return _synthesisHpRestorationTable;
            }
        }
        private bool f_lusterPurgeLowerSpecialDefenseChance;
        private short _lusterPurgeLowerSpecialDefenseChance;

        /// <summary>
        /// The chance of Luster Purge (and others, see DoMoveDamageLowerSpecialDefense50) lowering special defense, as a percentage (50%).
        /// </summary>
        public short LusterPurgeLowerSpecialDefenseChance
        {
            get
            {
                if (f_lusterPurgeLowerSpecialDefenseChance)
                    return _lusterPurgeLowerSpecialDefenseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31396);
                _lusterPurgeLowerSpecialDefenseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_lusterPurgeLowerSpecialDefenseChance = true;
                return _lusterPurgeLowerSpecialDefenseChance;
            }
        }
        private bool f_unownStoneDropChance;
        private short _unownStoneDropChance;

        /// <summary>
        /// The chance of an Unown dropping an Unown stone, as a percentage (33%).
        /// </summary>
        public short UnownStoneDropChance
        {
            get
            {
                if (f_unownStoneDropChance)
                    return _unownStoneDropChance;
                long _pos = m_io.Pos;
                m_io.Seek(31244);
                _unownStoneDropChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_unownStoneDropChance = true;
                return _unownStoneDropChance;
            }
        }
        private bool f_expEliteExpBoost;
        private short _expEliteExpBoost;

        /// <summary>
        /// The percentage increase in experience from the Exp. Elite IQ skill
        /// </summary>
        public short ExpEliteExpBoost
        {
            get
            {
                if (f_expEliteExpBoost)
                    return _expEliteExpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31296);
                _expEliteExpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_expEliteExpBoost = true;
                return _expEliteExpBoost;
            }
        }
        private bool f_blazeKickBurnChance;
        private short _blazeKickBurnChance;

        /// <summary>
        /// The chance of Blaze Kick burning, as a percentage (10%).
        /// </summary>
        public short BlazeKickBurnChance
        {
            get
            {
                if (f_blazeKickBurnChance)
                    return _blazeKickBurnChance;
                long _pos = m_io.Pos;
                m_io.Seek(31448);
                _blazeKickBurnChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_blazeKickBurnChance = true;
                return _blazeKickBurnChance;
            }
        }
        private bool f_zincStatBoost;
        private short _zincStatBoost;

        /// <summary>
        /// The permanent special defense boost from ingesting a Zinc.
        /// </summary>
        public short ZincStatBoost
        {
            get
            {
                if (f_zincStatBoost)
                    return _zincStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31836);
                _zincStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_zincStatBoost = true;
                return _zincStatBoost;
            }
        }
        private bool f_aiRegularAttackWeights;
        private AiRegularAttackWeightsArray _aiRegularAttackWeights;

        /// <summary>
        /// The weight of the regular attack in the weighted random when the AI is deciding which move to use, depending on how many other attacks the AI can currently use.
        /// Each index in the array corresponds to the number of attacks (0-4) the AI can use (i.e., is enabled and has PP remaining).
        /// 
        /// type: uint16_t[5]
        /// </summary>
        public AiRegularAttackWeightsArray AiRegularAttackWeights
        {
            get
            {
                if (f_aiRegularAttackWeights)
                    return _aiRegularAttackWeights;
                long _pos = m_io.Pos;
                m_io.Seek(32408);
                _aiRegularAttackWeights = new AiRegularAttackWeightsArray(m_io);
                m_io.Seek(_pos);
                f_aiRegularAttackWeights = true;
                return _aiRegularAttackWeights;
            }
        }
        private bool f_itemAnimationInfo;
        private ItemAnimationInfoArray _itemAnimationInfo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct item_animation[1400]
        /// </summary>
        public ItemAnimationInfoArray ItemAnimationInfo
        {
            get
            {
                if (f_itemAnimationInfo)
                    return _itemAnimationInfo;
                long _pos = m_io.Pos;
                m_io.Seek(45084);
                _itemAnimationInfo = new ItemAnimationInfoArray(m_io);
                m_io.Seek(_pos);
                f_itemAnimationInfo = true;
                return _itemAnimationInfo;
            }
        }
        private bool f_effectAnimationInfo;
        private EffectAnimationInfoArray _effectAnimationInfo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct effect_animation[700]
        /// </summary>
        public EffectAnimationInfoArray EffectAnimationInfo
        {
            get
            {
                if (f_effectAnimationInfo)
                    return _effectAnimationInfo;
                long _pos = m_io.Pos;
                m_io.Seek(64196);
                _effectAnimationInfo = new EffectAnimationInfoArray(m_io);
                m_io.Seek(_pos);
                f_effectAnimationInfo = true;
                return _effectAnimationInfo;
            }
        }
        private bool f_aiConfusedNoAttackChance;
        private short _aiConfusedNoAttackChance;

        /// <summary>
        /// The percentage chance of the AI not attacking when it is confused.
        /// </summary>
        public short AiConfusedNoAttackChance
        {
            get
            {
                if (f_aiConfusedNoAttackChance)
                    return _aiConfusedNoAttackChance;
                long _pos = m_io.Pos;
                m_io.Seek(31512);
                _aiConfusedNoAttackChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_aiConfusedNoAttackChance = true;
                return _aiConfusedNoAttackChance;
            }
        }
        private bool f_moveAnimationInfo;
        private MoveAnimationInfoArray _moveAnimationInfo;

        /// <summary>
        /// type: struct move_animation[563]
        /// </summary>
        public MoveAnimationInfoArray MoveAnimationInfo
        {
            get
            {
                if (f_moveAnimationInfo)
                    return _moveAnimationInfo;
                long _pos = m_io.Pos;
                m_io.Seek(50684);
                _moveAnimationInfo = new MoveAnimationInfoArray(m_io);
                m_io.Seek(_pos);
                f_moveAnimationInfo = true;
                return _moveAnimationInfo;
            }
        }
        private bool f_restTurnRange;
        private RestTurnRangeArray _restTurnRange;

        /// <summary>
        /// The turn range for the Napping status inflicted by Rest, [1, 4).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public RestTurnRangeArray RestTurnRange
        {
            get
            {
                if (f_restTurnRange)
                    return _restTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(31968);
                _restTurnRange = new RestTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_restTurnRange = true;
                return _restTurnRange;
            }
        }
        private bool f_shopItemChances;
        private ShopItemChancesArray _shopItemChances;

        /// <summary>
        /// 8 * 6 * 3 * 0x2
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public ShopItemChancesArray ShopItemChances
        {
            get
            {
                if (f_shopItemChances)
                    return _shopItemChances;
                long _pos = m_io.Pos;
                m_io.Seek(34948);
                _shopItemChances = new ShopItemChancesArray(m_io);
                m_io.Seek(_pos);
                f_shopItemChances = true;
                return _shopItemChances;
            }
        }
        private bool f_bounceDamageMultiplier;
        private int _bounceDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Bounce, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int BounceDamageMultiplier
        {
            get
            {
                if (f_bounceDamageMultiplier)
                    return _bounceDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32132);
                _bounceDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_bounceDamageMultiplier = true;
                return _bounceDamageMultiplier;
            }
        }
        private bool f_ironTailLowerDefenseChance;
        private short _ironTailLowerDefenseChance;

        /// <summary>
        /// The chance of Iron Tail lowering defense, as a percentage (30%).
        /// </summary>
        public short IronTailLowerDefenseChance
        {
            get
            {
                if (f_ironTailLowerDefenseChance)
                    return _ironTailLowerDefenseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31192);
                _ironTailLowerDefenseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_ironTailLowerDefenseChance = true;
                return _ironTailLowerDefenseChance;
            }
        }
        private bool f_thunderParalyzeChance;
        private short _thunderParalyzeChance;

        /// <summary>
        /// The chance of Thunder (and others, see DoMoveDamageParalyze20) paralyzing, as a percentage (20%)
        /// </summary>
        public short ThunderParalyzeChance
        {
            get
            {
                if (f_thunderParalyzeChance)
                    return _thunderParalyzeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31728);
                _thunderParalyzeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_thunderParalyzeChance = true;
                return _thunderParalyzeChance;
            }
        }
        private bool f_matchupNotVeryEffectiveMultiplier;
        private int _matchupNotVeryEffectiveMultiplier;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_NOT_VERY_EFFECTIVE, as a fixed-point number with 8 fraction bits (the raw value is 0x1B4, the closest possible representation of 1/√2).
        /// </summary>
        public int MatchupNotVeryEffectiveMultiplier
        {
            get
            {
                if (f_matchupNotVeryEffectiveMultiplier)
                    return _matchupNotVeryEffectiveMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32168);
                _matchupNotVeryEffectiveMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupNotVeryEffectiveMultiplier = true;
                return _matchupNotVeryEffectiveMultiplier;
            }
        }
        private bool f_crushClawLowerDefenseChance;
        private short _crushClawLowerDefenseChance;

        /// <summary>
        /// The chance of Crush Claw lowering defense, as a percentage (50%).
        /// </summary>
        public short CrushClawLowerDefenseChance
        {
            get
            {
                if (f_crushClawLowerDefenseChance)
                    return _crushClawLowerDefenseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31648);
                _crushClawLowerDefenseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_crushClawLowerDefenseChance = true;
                return _crushClawLowerDefenseChance;
            }
        }
        private bool f_fixedRoomPropertiesTable;
        private FixedRoomPropertiesTableArray _fixedRoomPropertiesTable;

        /// <summary>
        /// Table of properties for fixed rooms.
        /// 
        /// This is an array of 256 12-byte entries containing properties for a given fixed room ID.
        /// 
        /// See the struct definitions and Frostbyte's dungeon data document for more info.
        /// 
        /// type: struct fixed_room_properties_entry[256]
        /// </summary>
        public FixedRoomPropertiesTableArray FixedRoomPropertiesTable
        {
            get
            {
                if (f_fixedRoomPropertiesTable)
                    return _fixedRoomPropertiesTable;
                long _pos = m_io.Pos;
                m_io.Seek(41480);
                _fixedRoomPropertiesTable = new FixedRoomPropertiesTableArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomPropertiesTable = true;
                return _fixedRoomPropertiesTable;
            }
        }
        private bool f_burnDamage;
        private short _burnDamage;

        /// <summary>
        /// Damage dealt by the burn status condition.
        /// </summary>
        public short BurnDamage
        {
            get
            {
                if (f_burnDamage)
                    return _burnDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31340);
                _burnDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_burnDamage = true;
                return _burnDamage;
            }
        }
        private bool f_geoPebbleDamage;
        private short _geoPebbleDamage;

        /// <summary>
        /// Damage dealt by Geo Pebbles.
        /// </summary>
        public short GeoPebbleDamage
        {
            get
            {
                if (f_geoPebbleDamage)
                    return _geoPebbleDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31820);
                _geoPebbleDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_geoPebbleDamage = true;
                return _geoPebbleDamage;
            }
        }
        private bool f_typeMatchupTable;
        private TypeMatchupTable _typeMatchupTable;

        /// <summary>
        /// Table of type matchups.
        /// 
        /// Each row corresponds to the type matchups of a specific attack type, with each entry within the row specifying the type's effectiveness against a target type.
        /// 
        /// type: struct type_matchup_table
        /// </summary>
        public TypeMatchupTable TypeMatchupTable
        {
            get
            {
                if (f_typeMatchupTable)
                    return _typeMatchupTable;
                long _pos = m_io.Pos;
                m_io.Seek(35912);
                _typeMatchupTable = new TypeMatchupTable(m_io);
                m_io.Seek(_pos);
                f_typeMatchupTable = true;
                return _typeMatchupTable;
            }
        }
        private bool f_spawnCooldownThiefAlert;
        private short _spawnCooldownThiefAlert;

        /// <summary>
        /// The number of turns between enemy spawns when the Thief Alert condition is active.
        /// </summary>
        public short SpawnCooldownThiefAlert
        {
            get
            {
                if (f_spawnCooldownThiefAlert)
                    return _spawnCooldownThiefAlert;
                long _pos = m_io.Pos;
                m_io.Seek(31704);
                _spawnCooldownThiefAlert = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_spawnCooldownThiefAlert = true;
                return _spawnCooldownThiefAlert;
            }
        }
        private bool f_calciumStatBoost;
        private short _calciumStatBoost;

        /// <summary>
        /// The permanent special attack boost from ingesting a Calcium.
        /// </summary>
        public short CalciumStatBoost
        {
            get
            {
                if (f_calciumStatBoost)
                    return _calciumStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31844);
                _calciumStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_calciumStatBoost = true;
                return _calciumStatBoost;
            }
        }
        private bool f_burnDamageCooldown;
        private short _burnDamageCooldown;

        /// <summary>
        /// The number of turns between passive burn damage.
        /// </summary>
        public short BurnDamageCooldown
        {
            get
            {
                if (f_burnDamageCooldown)
                    return _burnDamageCooldown;
                long _pos = m_io.Pos;
                m_io.Seek(31656);
                _burnDamageCooldown = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_burnDamageCooldown = true;
                return _burnDamageCooldown;
            }
        }
        private bool f_firstDungeonWithMonsterHouseTraps;
        private DungeonId8 _firstDungeonWithMonsterHouseTraps;

        /// <summary>
        /// The first dungeon that can have extra traps spawn in Monster Houses, Dark Hill
        /// 
        /// type: struct dungeon_id_8
        /// </summary>
        public DungeonId8 FirstDungeonWithMonsterHouseTraps
        {
            get
            {
                if (f_firstDungeonWithMonsterHouseTraps)
                    return _firstDungeonWithMonsterHouseTraps;
                long _pos = m_io.Pos;
                m_io.Seek(31140);
                _firstDungeonWithMonsterHouseTraps = new DungeonId8(m_io);
                m_io.Seek(_pos);
                f_firstDungeonWithMonsterHouseTraps = true;
                return _firstDungeonWithMonsterHouseTraps;
            }
        }
        private bool f_diveDamageMultiplier;
        private int _diveDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Dive, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int DiveDamageMultiplier
        {
            get
            {
                if (f_diveDamageMultiplier)
                    return _diveDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32128);
                _diveDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_diveDamageMultiplier = true;
                return _diveDamageMultiplier;
            }
        }
        private bool f_femaleEvasionStageMultipliers;
        private FemaleEvasionStageMultipliersArray _femaleEvasionStageMultipliers;

        /// <summary>
        /// Table of multipliers for the evasion stat for females for each stage 0-20, as binary fixed-point numbers (8 fraction bits)
        /// </summary>
        public FemaleEvasionStageMultipliersArray FemaleEvasionStageMultipliers
        {
            get
            {
                if (f_femaleEvasionStageMultipliers)
                    return _femaleEvasionStageMultipliers;
                long _pos = m_io.Pos;
                m_io.Seek(35488);
                _femaleEvasionStageMultipliers = new FemaleEvasionStageMultipliersArray(m_io);
                m_io.Seek(_pos);
                f_femaleEvasionStageMultipliers = true;
                return _femaleEvasionStageMultipliers;
            }
        }
        private bool f_powderSnowFreezeChance;
        private short _powderSnowFreezeChance;

        /// <summary>
        /// The chance of Powder Snow (and others, see DoMoveDamageFreeze15) freezing, as a percentage (15%).
        /// </summary>
        public short PowderSnowFreezeChance
        {
            get
            {
                if (f_powderSnowFreezeChance)
                    return _powderSnowFreezeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31692);
                _powderSnowFreezeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_powderSnowFreezeChance = true;
                return _powderSnowFreezeChance;
            }
        }
        private bool f_lastResortDamageMultTable;
        private LastResortDamageMultTableArray _lastResortDamageMultTable;

        /// <summary>
        /// Table of damage multipliers for Last Resort for different numbers of moves out of PP, where each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// If n is the number of moves out of PP not counting Last Resort itself, the table is indexed by (n - 1).
        /// 
        /// type: int[4]
        /// </summary>
        public LastResortDamageMultTableArray LastResortDamageMultTable
        {
            get
            {
                if (f_lastResortDamageMultTable)
                    return _lastResortDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(32476);
                _lastResortDamageMultTable = new LastResortDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_lastResortDamageMultTable = true;
                return _lastResortDamageMultTable;
            }
        }
        private bool f_digDamageMultiplier;
        private int _digDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Dig, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int DigDamageMultiplier
        {
            get
            {
                if (f_digDamageMultiplier)
                    return _digDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32124);
                _digDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_digDamageMultiplier = true;
                return _digDamageMultiplier;
            }
        }
        private bool f_flareBlitzBurnChance;
        private short _flareBlitzBurnChance;

        /// <summary>
        /// The chance of Flare Blitz burning, as a percentage (25%). This value is also used for the Fire Fang burn chance.
        /// </summary>
        public short FlareBlitzBurnChance
        {
            get
            {
                if (f_flareBlitzBurnChance)
                    return _flareBlitzBurnChance;
                long _pos = m_io.Pos;
                m_io.Seek(31772);
                _flareBlitzBurnChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_flareBlitzBurnChance = true;
                return _flareBlitzBurnChance;
            }
        }
        private bool f_bounceParalyzeChance;
        private short _bounceParalyzeChance;

        /// <summary>
        /// The chance of Bounce paralyzing, as a percentage (30%)
        /// </summary>
        public short BounceParalyzeChance
        {
            get
            {
                if (f_bounceParalyzeChance)
                    return _bounceParalyzeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31276);
                _bounceParalyzeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_bounceParalyzeChance = true;
                return _bounceParalyzeChance;
            }
        }
        private bool f_randomMusicIdTable;
        private RandomMusicIdTableArray _randomMusicIdTable;

        /// <summary>
        /// Table of music IDs for dungeons with a random assortment of music tracks.
        /// 
        /// This is a table with 30 rows, each with 4 2-byte music IDs. Each row contains the possible music IDs for a given group, from which the music track will be selected randomly.
        /// 
        /// type: struct music_id_16[30][4]
        /// </summary>
        public RandomMusicIdTableArray RandomMusicIdTable
        {
            get
            {
                if (f_randomMusicIdTable)
                    return _randomMusicIdTable;
                long _pos = m_io.Pos;
                m_io.Seek(34708);
                _randomMusicIdTable = new RandomMusicIdTableArray(m_io);
                m_io.Seek(_pos);
                f_randomMusicIdTable = true;
                return _randomMusicIdTable;
            }
        }
        private bool f_rainAbilityBonusRegen;
        private short _rainAbilityBonusRegen;

        /// <summary>
        /// The passive bonus health regen given when the weather is rain for the abilities rain dish and dry skin.
        /// </summary>
        public short RainAbilityBonusRegen
        {
            get
            {
                if (f_rainAbilityBonusRegen)
                    return _rainAbilityBonusRegen;
                long _pos = m_io.Pos;
                m_io.Seek(31504);
                _rainAbilityBonusRegen = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_rainAbilityBonusRegen = true;
                return _rainAbilityBonusRegen;
            }
        }
        private bool f_silverSpikePower;
        private short _silverSpikePower;

        /// <summary>
        /// Attack power for Silver Spikes.
        /// </summary>
        public short SilverSpikePower
        {
            get
            {
                if (f_silverSpikePower)
                    return _silverSpikePower;
                long _pos = m_io.Pos;
                m_io.Seek(31868);
                _silverSpikePower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_silverSpikePower = true;
                return _silverSpikePower;
            }
        }
        private bool f_thundershockParalyzeChance;
        private short _thundershockParalyzeChance;

        /// <summary>
        /// The chance of Thundershock paralyzing, as a percentage (10%).
        /// </summary>
        public short ThundershockParalyzeChance
        {
            get
            {
                if (f_thundershockParalyzeChance)
                    return _thundershockParalyzeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31272);
                _thundershockParalyzeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_thundershockParalyzeChance = true;
                return _thundershockParalyzeChance;
            }
        }
        private bool f_tintedLensMultiplier;
        private int _tintedLensMultiplier;

        /// <summary>
        /// The extra damage multiplier for not-very-effective moves when Tinted Lens is active, as a fixed-point number with 8 fraction bits (the raw value is 0x133, the closest possible representation of 1.2).
        /// </summary>
        public int TintedLensMultiplier
        {
            get
            {
                if (f_tintedLensMultiplier)
                    return _tintedLensMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32088);
                _tintedLensMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_tintedLensMultiplier = true;
                return _tintedLensMultiplier;
            }
        }
        private bool f_crunchLowerDefenseChance;
        private short _crunchLowerDefenseChance;

        /// <summary>
        /// The chance of Crunch (and others, see DoMoveDamageLowerDef20) lowering defense, as a percentage (20%).
        /// </summary>
        public short CrunchLowerDefenseChance
        {
            get
            {
                if (f_crunchLowerDefenseChance)
                    return _crunchLowerDefenseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31208);
                _crunchLowerDefenseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_crunchLowerDefenseChance = true;
                return _crunchLowerDefenseChance;
            }
        }
        private bool f_wringOutDamageMultTable;
        private WringOutDamageMultTableArray _wringOutDamageMultTable;

        /// <summary>
        /// Table of damage multipliers for Wring Out/Crush Grip at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// type: int[4]
        /// </summary>
        public WringOutDamageMultTableArray WringOutDamageMultTable
        {
            get
            {
                if (f_wringOutDamageMultTable)
                    return _wringOutDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(32588);
                _wringOutDamageMultTable = new WringOutDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_wringOutDamageMultTable = true;
                return _wringOutDamageMultTable;
            }
        }
        private bool f_matchupSuperEffectiveMultiplier;
        private int _matchupSuperEffectiveMultiplier;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_SUPER_EFFECTIVE, as a fixed-point number with 8 fraction bits (the raw value is 0x166, the closest possible representation of 1.4).
        /// </summary>
        public int MatchupSuperEffectiveMultiplier
        {
            get
            {
                if (f_matchupSuperEffectiveMultiplier)
                    return _matchupSuperEffectiveMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32176);
                _matchupSuperEffectiveMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupSuperEffectiveMultiplier = true;
                return _matchupSuperEffectiveMultiplier;
            }
        }
        private bool f_defensiveStatStageMultipliers;
        private DefensiveStatStageMultipliersArray _defensiveStatStageMultipliers;

        /// <summary>
        /// Table of multipliers for defensive stats (defense/special defense) for each stage 0-20, as binary fixed-point numbers (8 fraction bits)
        /// </summary>
        public DefensiveStatStageMultipliersArray DefensiveStatStageMultipliers
        {
            get
            {
                if (f_defensiveStatStageMultipliers)
                    return _defensiveStatStageMultipliers;
                long _pos = m_io.Pos;
                m_io.Seek(33668);
                _defensiveStatStageMultipliers = new DefensiveStatStageMultipliersArray(m_io);
                m_io.Seek(_pos);
                f_defensiveStatStageMultipliers = true;
                return _defensiveStatStageMultipliers;
            }
        }
        private bool f_matchupNeutralMultiplierErraticPlayer;
        private int _matchupNeutralMultiplierErraticPlayer;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_NEUTRAL when Erratic Player is active, as a fixed-point number with 8 fraction bits (1).
        /// </summary>
        public int MatchupNeutralMultiplierErraticPlayer
        {
            get
            {
                if (f_matchupNeutralMultiplierErraticPlayer)
                    return _matchupNeutralMultiplierErraticPlayer;
                long _pos = m_io.Pos;
                m_io.Seek(32196);
                _matchupNeutralMultiplierErraticPlayer = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupNeutralMultiplierErraticPlayer = true;
                return _matchupNeutralMultiplierErraticPlayer;
            }
        }
        private bool f_forewarnForcedMissChance;
        private short _forewarnForcedMissChance;

        /// <summary>
        /// The chance of Forewarn forcing a move to miss, as a percentage (20%).
        /// </summary>
        public short ForewarnForcedMissChance
        {
            get
            {
                if (f_forewarnForcedMissChance)
                    return _forewarnForcedMissChance;
                long _pos = m_io.Pos;
                m_io.Seek(31232);
                _forewarnForcedMissChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_forewarnForcedMissChance = true;
                return _forewarnForcedMissChance;
            }
        }
        private bool f_matchupImmuneMultiplier;
        private int _matchupImmuneMultiplier;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_IMMUNE, as a fixed-point number with 8 fraction bits (0.5).
        /// </summary>
        public int MatchupImmuneMultiplier
        {
            get
            {
                if (f_matchupImmuneMultiplier)
                    return _matchupImmuneMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(31984);
                _matchupImmuneMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupImmuneMultiplier = true;
                return _matchupImmuneMultiplier;
            }
        }
        private bool f_matchupImmuneMultiplierErraticPlayer;
        private int _matchupImmuneMultiplierErraticPlayer;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_IMMUNE when Erratic Player is active, as a fixed-point number with 8 fraction bits (0.25).
        /// </summary>
        public int MatchupImmuneMultiplierErraticPlayer
        {
            get
            {
                if (f_matchupImmuneMultiplierErraticPlayer)
                    return _matchupImmuneMultiplierErraticPlayer;
                long _pos = m_io.Pos;
                m_io.Seek(32184);
                _matchupImmuneMultiplierErraticPlayer = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupImmuneMultiplierErraticPlayer = true;
                return _matchupImmuneMultiplierErraticPlayer;
            }
        }
        private bool f_lickParalyzeChance;
        private short _lickParalyzeChance;

        /// <summary>
        /// The chance of Lick (and others, see DoMoveDamageParalyze10) paralyzing, as a percentage (10%).
        /// </summary>
        public short LickParalyzeChance
        {
            get
            {
                if (f_lickParalyzeChance)
                    return _lickParalyzeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31424);
                _lickParalyzeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_lickParalyzeChance = true;
                return _lickParalyzeChance;
            }
        }
        private bool f_kecleonShopBoostChanceMultiplier;
        private int _kecleonShopBoostChanceMultiplier;

        /// <summary>
        /// The boosted kecleon shop spawn chance multiplier (~1.2) as a binary fixed-point number (8 fraction bits).
        /// </summary>
        public int KecleonShopBoostChanceMultiplier
        {
            get
            {
                if (f_kecleonShopBoostChanceMultiplier)
                    return _kecleonShopBoostChanceMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32228);
                _kecleonShopBoostChanceMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_kecleonShopBoostChanceMultiplier = true;
                return _kecleonShopBoostChanceMultiplier;
            }
        }
        private bool f_razorWindDamageMultiplier;
        private int _razorWindDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Razor Wind, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int RazorWindDamageMultiplier
        {
            get
            {
                if (f_razorWindDamageMultiplier)
                    return _razorWindDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32328);
                _razorWindDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_razorWindDamageMultiplier = true;
                return _razorWindDamageMultiplier;
            }
        }
        private bool f_shadowForceDamageMultiplier;
        private int _shadowForceDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Shadow Force, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int ShadowForceDamageMultiplier
        {
            get
            {
                if (f_shadowForceDamageMultiplier)
                    return _shadowForceDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32116);
                _shadowForceDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_shadowForceDamageMultiplier = true;
                return _shadowForceDamageMultiplier;
            }
        }
        private bool f_typeMatchupCombinatorTable;
        private TypeMatchupCombinatorTable _typeMatchupCombinatorTable;

        /// <summary>
        /// Table of type matchup combinations.
        /// 
        /// Each row corresponds to a single type matchup that results from combining two individual type matchups together. For example, combining MATCHUP_NOT_VERY_EFFECTIVE with MATCHUP_SUPER_EFFECTIVE results in MATCHUP_NEUTRAL.
        /// 
        /// type: struct type_matchup_combinator_table
        /// </summary>
        public TypeMatchupCombinatorTable TypeMatchupCombinatorTable
        {
            get
            {
                if (f_typeMatchupCombinatorTable)
                    return _typeMatchupCombinatorTable;
                long _pos = m_io.Pos;
                m_io.Seek(33452);
                _typeMatchupCombinatorTable = new TypeMatchupCombinatorTable(m_io);
                m_io.Seek(_pos);
                f_typeMatchupCombinatorTable = true;
                return _typeMatchupCombinatorTable;
            }
        }
        private bool f_silverWindBoostChance;
        private short _silverWindBoostChance;

        /// <summary>
        /// The chance of Silver Wind (and others, see DoMoveDamageBoostAllStats) boosting all stats, as a percentage (20%).
        /// </summary>
        public short SilverWindBoostChance
        {
            get
            {
                if (f_silverWindBoostChance)
                    return _silverWindBoostChance;
                long _pos = m_io.Pos;
                m_io.Seek(31264);
                _silverWindBoostChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_silverWindBoostChance = true;
                return _silverWindBoostChance;
            }
        }
        private bool f_nightmareTurnRange;
        private NightmareTurnRangeArray _nightmareTurnRange;

        /// <summary>
        /// The turn range for the Nightmare status inflicted by Nightmare, [4, 8).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public NightmareTurnRangeArray NightmareTurnRange
        {
            get
            {
                if (f_nightmareTurnRange)
                    return _nightmareTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(31932);
                _nightmareTurnRange = new NightmareTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_nightmareTurnRange = true;
                return _nightmareTurnRange;
            }
        }
        private bool f_flameWheelBurnChance;
        private short _flameWheelBurnChance;

        /// <summary>
        /// The chance of Flame Wheel (and others, see DoMoveDamageBurn10FlameWheel) burning, as a percentage (10%).
        /// </summary>
        public short FlameWheelBurnChance
        {
            get
            {
                if (f_flameWheelBurnChance)
                    return _flameWheelBurnChance;
                long _pos = m_io.Pos;
                m_io.Seek(31776);
                _flameWheelBurnChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_flameWheelBurnChance = true;
                return _flameWheelBurnChance;
            }
        }
        private bool f_cacneaSpikePower;
        private short _cacneaSpikePower;

        /// <summary>
        /// Attack power for Cacnea Spikes.
        /// </summary>
        public short CacneaSpikePower
        {
            get
            {
                if (f_cacneaSpikePower)
                    return _cacneaSpikePower;
                long _pos = m_io.Pos;
                m_io.Seek(31860);
                _cacneaSpikePower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_cacneaSpikePower = true;
                return _cacneaSpikePower;
            }
        }
        private bool f_smokescreenTurnRange;
        private SmokescreenTurnRangeArray _smokescreenTurnRange;

        /// <summary>
        /// The turn range for the Whiffer status inflicted by Smokescreen, [1, 4).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public SmokescreenTurnRangeArray SmokescreenTurnRange
        {
            get
            {
                if (f_smokescreenTurnRange)
                    return _smokescreenTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(32092);
                _smokescreenTurnRange = new SmokescreenTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_smokescreenTurnRange = true;
                return _smokescreenTurnRange;
            }
        }
        private bool f_airBladeDamageMultiplier;
        private int _airBladeDamageMultiplier;

        /// <summary>
        /// The multiplier for damage from the Air Blade (1.5), as a binary fixed-point number (8 fraction bits)
        /// </summary>
        public int AirBladeDamageMultiplier
        {
            get
            {
                if (f_airBladeDamageMultiplier)
                    return _airBladeDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32220);
                _airBladeDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_airBladeDamageMultiplier = true;
                return _airBladeDamageMultiplier;
            }
        }
        private bool f_powerPitcherDamageMultiplier;
        private int _powerPitcherDamageMultiplier;

        /// <summary>
        /// The multiplier for projectile damage from Power Pitcher (1.5), as a binary fixed-point number (8 fraction bits)
        /// </summary>
        public int PowerPitcherDamageMultiplier
        {
            get
            {
                if (f_powerPitcherDamageMultiplier)
                    return _powerPitcherDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32144);
                _powerPitcherDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_powerPitcherDamageMultiplier = true;
                return _powerPitcherDamageMultiplier;
            }
        }
        private bool f_meteorMashBoostAttackChance;
        private short _meteorMashBoostAttackChance;

        /// <summary>
        /// The chance of Meteor Mash boosting attack, as a percentage (20%).
        /// </summary>
        public short MeteorMashBoostAttackChance
        {
            get
            {
                if (f_meteorMashBoostAttackChance)
                    return _meteorMashBoostAttackChance;
                long _pos = m_io.Pos;
                m_io.Seek(31644);
                _meteorMashBoostAttackChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_meteorMashBoostAttackChance = true;
                return _meteorMashBoostAttackChance;
            }
        }
        private bool f_maleAccuracyStageMultipliers;
        private MaleAccuracyStageMultipliersArray _maleAccuracyStageMultipliers;

        /// <summary>
        /// Table of multipliers for the accuracy stat for males for each stage 0-20, as binary fixed-point numbers (8 fraction bits)
        /// </summary>
        public MaleAccuracyStageMultipliersArray MaleAccuracyStageMultipliers
        {
            get
            {
                if (f_maleAccuracyStageMultipliers)
                    return _maleAccuracyStageMultipliers;
                long _pos = m_io.Pos;
                m_io.Seek(35236);
                _maleAccuracyStageMultipliers = new MaleAccuracyStageMultipliersArray(m_io);
                m_io.Seek(_pos);
                f_maleAccuracyStageMultipliers = true;
                return _maleAccuracyStageMultipliers;
            }
        }
        private bool f_spawnCapWithMonsterHouse;
        private short _spawnCapWithMonsterHouse;

        /// <summary>
        /// The maximum number of enemies that can spawn on a floor with a monster house, not counting those in the monster house (4).
        /// </summary>
        public short SpawnCapWithMonsterHouse
        {
            get
            {
                if (f_spawnCapWithMonsterHouse)
                    return _spawnCapWithMonsterHouse;
                long _pos = m_io.Pos;
                m_io.Seek(31804);
                _spawnCapWithMonsterHouse = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_spawnCapWithMonsterHouse = true;
                return _spawnCapWithMonsterHouse;
            }
        }
        private bool f_speedBoostTurns;
        private short _speedBoostTurns;

        /// <summary>
        /// Number of turns (250) after which Speed Boost will trigger and increase speed by one stage.
        /// </summary>
        public short SpeedBoostTurns
        {
            get
            {
                if (f_speedBoostTurns)
                    return _speedBoostTurns;
                long _pos = m_io.Pos;
                m_io.Seek(31748);
                _speedBoostTurns = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_speedBoostTurns = true;
                return _speedBoostTurns;
            }
        }
        private bool f_naturePowerTable;
        private NaturePowerTableArray _naturePowerTable;

        /// <summary>
        /// Maps enum nature_power_variant to the associated move ID and effect handler.
        /// 
        /// type: struct wildcard_move_desc[15]
        /// </summary>
        public NaturePowerTableArray NaturePowerTable
        {
            get
            {
                if (f_naturePowerTable)
                    return _naturePowerTable;
                long _pos = m_io.Pos;
                m_io.Seek(33752);
                _naturePowerTable = new NaturePowerTableArray(m_io);
                m_io.Seek(_pos);
                f_naturePowerTable = true;
                return _naturePowerTable;
            }
        }
        private bool f_fireFangCringeChance;
        private short _fireFangCringeChance;

        /// <summary>
        /// The chance of Fire Fang inflicting the cringe status, as a percentage (25%).
        /// </summary>
        public short FireFangCringeChance
        {
            get
            {
                if (f_fireFangCringeChance)
                    return _fireFangCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31284);
                _fireFangCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_fireFangCringeChance = true;
                return _fireFangCringeChance;
            }
        }
        private bool f_snoreCringeChance;
        private short _snoreCringeChance;

        /// <summary>
        /// The chance of Snore inflicting the cringe status, as a percentage (30%).
        /// </summary>
        public short SnoreCringeChance
        {
            get
            {
                if (f_snoreCringeChance)
                    return _snoreCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31640);
                _snoreCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_snoreCringeChance = true;
                return _snoreCringeChance;
            }
        }
        private bool f_eruptionDamageMultTable;
        private EruptionDamageMultTableArray _eruptionDamageMultTable;

        /// <summary>
        /// Table of damage multipliers for Eruption at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// type: int[4]
        /// </summary>
        public EruptionDamageMultTableArray EruptionDamageMultTable
        {
            get
            {
                if (f_eruptionDamageMultTable)
                    return _eruptionDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(32604);
                _eruptionDamageMultTable = new EruptionDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_eruptionDamageMultTable = true;
                return _eruptionDamageMultTable;
            }
        }
        private bool f_oranBerryHpRestoration;
        private short _oranBerryHpRestoration;

        /// <summary>
        /// The amount of HP restored by eating a Oran Berry.
        /// </summary>
        public short OranBerryHpRestoration
        {
            get
            {
                if (f_oranBerryHpRestoration)
                    return _oranBerryHpRestoration;
                long _pos = m_io.Pos;
                m_io.Seek(31620);
                _oranBerryHpRestoration = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_oranBerryHpRestoration = true;
                return _oranBerryHpRestoration;
            }
        }
        private bool f_skyAttackCringeChance;
        private short _skyAttackCringeChance;

        /// <summary>
        /// The chance of Sky Attack inflicting the cringe status, as a percentage (25%).
        /// </summary>
        public short SkyAttackCringeChance
        {
            get
            {
                if (f_skyAttackCringeChance)
                    return _skyAttackCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31440);
                _skyAttackCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_skyAttackCringeChance = true;
                return _skyAttackCringeChance;
            }
        }
        private bool f_steelWingBoostDefenseChance;
        private short _steelWingBoostDefenseChance;

        /// <summary>
        /// The chance of Steel Wing boosting defense, as a percentage (20%).
        /// </summary>
        public short SteelWingBoostDefenseChance
        {
            get
            {
                if (f_steelWingBoostDefenseChance)
                    return _steelWingBoostDefenseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31324);
                _steelWingBoostDefenseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_steelWingBoostDefenseChance = true;
                return _steelWingBoostDefenseChance;
            }
        }
        private bool f_naturalGiftItemTable;
        private NaturalGiftItemTableArray _naturalGiftItemTable;

        /// <summary>
        /// Maps items to their type and base power if used with Natural Gift.
        /// 
        /// Any item not listed in this table explicitly will be Normal type with a base power of 1 when used with Natural Gift.
        /// 
        /// type: struct natural_gift_item_info[34]
        /// </summary>
        public NaturalGiftItemTableArray NaturalGiftItemTable
        {
            get
            {
                if (f_naturalGiftItemTable)
                    return _naturalGiftItemTable;
                long _pos = m_io.Pos;
                m_io.Seek(34504);
                _naturalGiftItemTable = new NaturalGiftItemTableArray(m_io);
                m_io.Seek(_pos);
                f_naturalGiftItemTable = true;
                return _naturalGiftItemTable;
            }
        }
        private bool f_recruitmentLevelBoostTable;
        private RecruitmentLevelBoostTableArray _recruitmentLevelBoostTable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: int16_t[102]
        /// </summary>
        public RecruitmentLevelBoostTableArray RecruitmentLevelBoostTable
        {
            get
            {
                if (f_recruitmentLevelBoostTable)
                    return _recruitmentLevelBoostTable;
                long _pos = m_io.Pos;
                m_io.Seek(34300);
                _recruitmentLevelBoostTable = new RecruitmentLevelBoostTableArray(m_io);
                m_io.Seek(_pos);
                f_recruitmentLevelBoostTable = true;
                return _recruitmentLevelBoostTable;
            }
        }
        private bool f_biteCringeChance;
        private short _biteCringeChance;

        /// <summary>
        /// The chance of Bite (and others, see DoMoveDamageCringe20) inflicting the cringe status, as a percentage (20%)
        /// </summary>
        public short BiteCringeChance
        {
            get
            {
                if (f_biteCringeChance)
                    return _biteCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31436);
                _biteCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_biteCringeChance = true;
                return _biteCringeChance;
            }
        }
        private bool f_eatItemEffectIgnoreList;
        private EatItemEffectIgnoreListArray _eatItemEffectIgnoreList;

        /// <summary>
        /// List of item IDs that should be ignored by the ShouldTryEatItem function. The last entry is null.
        /// </summary>
        public EatItemEffectIgnoreListArray EatItemEffectIgnoreList
        {
            get
            {
                if (f_eatItemEffectIgnoreList)
                    return _eatItemEffectIgnoreList;
                long _pos = m_io.Pos;
                m_io.Seek(33036);
                _eatItemEffectIgnoreList = new EatItemEffectIgnoreListArray(m_io);
                m_io.Seek(_pos);
                f_eatItemEffectIgnoreList = true;
                return _eatItemEffectIgnoreList;
            }
        }
        private bool f_flamethrowerBurnChance;
        private short _flamethrowerBurnChance;

        /// <summary>
        /// The chance of Flamethrower (and others, see DoMoveDamageBurn10) burning, as a percentage (10%).
        /// </summary>
        public short FlamethrowerBurnChance
        {
            get
            {
                if (f_flamethrowerBurnChance)
                    return _flamethrowerBurnChance;
                long _pos = m_io.Pos;
                m_io.Seek(31452);
                _flamethrowerBurnChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_flamethrowerBurnChance = true;
                return _flamethrowerBurnChance;
            }
        }
        private bool f_auroraBeamLowerAttackChance;
        private short _auroraBeamLowerAttackChance;

        /// <summary>
        /// The chance of Aurora Beam halving attack, as a percentage (60%).
        /// </summary>
        public short AuroraBeamLowerAttackChance
        {
            get
            {
                if (f_auroraBeamLowerAttackChance)
                    return _auroraBeamLowerAttackChance;
                long _pos = m_io.Pos;
                m_io.Seek(31168);
                _auroraBeamLowerAttackChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_auroraBeamLowerAttackChance = true;
                return _auroraBeamLowerAttackChance;
            }
        }
        private bool f_wonderChestExpBoost;
        private short _wonderChestExpBoost;

        /// <summary>
        /// The percentage increase in experience from the Wonder Chest item
        /// </summary>
        public short WonderChestExpBoost
        {
            get
            {
                if (f_wonderChestExpBoost)
                    return _wonderChestExpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31796);
                _wonderChestExpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_wonderChestExpBoost = true;
                return _wonderChestExpBoost;
            }
        }
        private bool f_burnDamageMultiplier;
        private int _burnDamageMultiplier;

        /// <summary>
        /// The extra damage multiplier for moves when the attacker is burned, as a fixed-point number with 8 fraction bits (the raw value is 0xCC, which is close to 0.8).
        /// 
        /// Unlike in the main series, this multiplier is applied regardless of whether the move being used is physical or special.
        /// </summary>
        public int BurnDamageMultiplier
        {
            get
            {
                if (f_burnDamageMultiplier)
                    return _burnDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(31964);
                _burnDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_burnDamageMultiplier = true;
                return _burnDamageMultiplier;
            }
        }
        private bool f_sleepTurnRange;
        private SleepTurnRangeArray _sleepTurnRange;

        /// <summary>
        /// Appears to control the range of turns for which the sleep condition can last.
        /// 
        /// The first two bytes are the low value of the range, and the later two bytes are the high value.
        /// </summary>
        public SleepTurnRangeArray SleepTurnRange
        {
            get
            {
                if (f_sleepTurnRange)
                    return _sleepTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(31928);
                _sleepTurnRange = new SleepTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_sleepTurnRange = true;
                return _sleepTurnRange;
            }
        }
        private bool f_poisonDamage;
        private short _poisonDamage;

        /// <summary>
        /// Damage dealt by the poison status condition.
        /// </summary>
        public short PoisonDamage
        {
            get
            {
                if (f_poisonDamage)
                    return _poisonDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31344);
                _poisonDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_poisonDamage = true;
                return _poisonDamage;
            }
        }
        private bool f_sacredFireBurnChance;
        private short _sacredFireBurnChance;

        /// <summary>
        /// The chance of Sacred Fire burning, as a percentage (50%).
        /// </summary>
        public short SacredFireBurnChance
        {
            get
            {
                if (f_sacredFireBurnChance)
                    return _sacredFireBurnChance;
                long _pos = m_io.Pos;
                m_io.Seek(31288);
                _sacredFireBurnChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_sacredFireBurnChance = true;
                return _sacredFireBurnChance;
            }
        }
        private bool f_hiddenStairsSpawnChanceMultiplier;
        private int _hiddenStairsSpawnChanceMultiplier;

        /// <summary>
        /// The hidden stairs spawn chance multiplier (~1.2) as a binary fixed-point number (8 fraction bits), if applicable. See ShouldBoostHiddenStairsSpawnChance in overlay 29.
        /// </summary>
        public int HiddenStairsSpawnChanceMultiplier
        {
            get
            {
                if (f_hiddenStairsSpawnChanceMultiplier)
                    return _hiddenStairsSpawnChanceMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32232);
                _hiddenStairsSpawnChanceMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_hiddenStairsSpawnChanceMultiplier = true;
                return _hiddenStairsSpawnChanceMultiplier;
            }
        }
        private bool f_monsterHouseMaxMonsterSpawns;
        private short _monsterHouseMaxMonsterSpawns;

        /// <summary>
        /// The maximum number of monster spawns in a Monster House, 30, but multiplied by 2/3 for some reason (so the actual maximum is 45)
        /// </summary>
        public short MonsterHouseMaxMonsterSpawns
        {
            get
            {
                if (f_monsterHouseMaxMonsterSpawns)
                    return _monsterHouseMaxMonsterSpawns;
                long _pos = m_io.Pos;
                m_io.Seek(31736);
                _monsterHouseMaxMonsterSpawns = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_monsterHouseMaxMonsterSpawns = true;
                return _monsterHouseMaxMonsterSpawns;
            }
        }
        private bool f_speedBoostTurnRange;
        private SpeedBoostTurnRangeArray _speedBoostTurnRange;

        /// <summary>
        /// Appears to control the range of turns for which a speed boost can last.
        /// 
        /// The first two bytes are the low value of the range, and the later two bytes are the high value.
        /// </summary>
        public SpeedBoostTurnRangeArray SpeedBoostTurnRange
        {
            get
            {
                if (f_speedBoostTurnRange)
                    return _speedBoostTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(32288);
                _speedBoostTurnRange = new SpeedBoostTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_speedBoostTurnRange = true;
                return _speedBoostTurnRange;
            }
        }
        private bool f_smogPoisonChance;
        private short _smogPoisonChance;

        /// <summary>
        /// The chance of Smog (and others, see DoMoveDamagePoison40) poisoning, as a percentage (40%).
        /// </summary>
        public short SmogPoisonChance
        {
            get
            {
                if (f_smogPoisonChance)
                    return _smogPoisonChance;
                long _pos = m_io.Pos;
                m_io.Seek(31412);
                _smogPoisonChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_smogPoisonChance = true;
                return _smogPoisonChance;
            }
        }
        private bool f_technicianMovePowerThreshold;
        private short _technicianMovePowerThreshold;

        /// <summary>
        /// The move power threshold for Technician (4). Moves whose base power doesn't exceed this value will receive a 50% damage boost.
        /// </summary>
        public short TechnicianMovePowerThreshold
        {
            get
            {
                if (f_technicianMovePowerThreshold)
                    return _technicianMovePowerThreshold;
                long _pos = m_io.Pos;
                m_io.Seek(31476);
                _technicianMovePowerThreshold = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_technicianMovePowerThreshold = true;
                return _technicianMovePowerThreshold;
            }
        }
        private bool f_tilesetProperties;
        private TilesetPropertiesArray _tilesetProperties;

        /// <summary>
        /// type: struct tileset_property[199]
        /// </summary>
        public TilesetPropertiesArray TilesetProperties
        {
            get
            {
                if (f_tilesetProperties)
                    return _tilesetProperties;
                long _pos = m_io.Pos;
                m_io.Seek(39092);
                _tilesetProperties = new TilesetPropertiesArray(m_io);
                m_io.Seek(_pos);
                f_tilesetProperties = true;
                return _tilesetProperties;
            }
        }
        private bool f_ginsengChance3;
        private short _ginsengChance3;

        /// <summary>
        /// The percentage chance for Ginseng to boost a move's power by 3 (12%).
        /// </summary>
        public short GinsengChance3
        {
            get
            {
                if (f_ginsengChance3)
                    return _ginsengChance3;
                long _pos = m_io.Pos;
                m_io.Seek(31832);
                _ginsengChance3 = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_ginsengChance3 = true;
                return _ginsengChance3;
            }
        }
        private bool f_fixedRoomMonsterSpawnStatsTable;
        private FixedRoomMonsterSpawnStatsTableArray _fixedRoomMonsterSpawnStatsTable;

        /// <summary>
        /// Table of stats for monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_MONSTER_SPAWN_TABLE.
        /// 
        /// This is an array of 99 12-byte entries containing stat spreads for one monster entry each.
        /// 
        /// type: struct fixed_room_monster_spawn_stats_entry[99]
        /// </summary>
        public FixedRoomMonsterSpawnStatsTableArray FixedRoomMonsterSpawnStatsTable
        {
            get
            {
                if (f_fixedRoomMonsterSpawnStatsTable)
                    return _fixedRoomMonsterSpawnStatsTable;
                long _pos = m_io.Pos;
                m_io.Seek(36560);
                _fixedRoomMonsterSpawnStatsTable = new FixedRoomMonsterSpawnStatsTableArray(m_io);
                m_io.Seek(_pos);
                f_fixedRoomMonsterSpawnStatsTable = true;
                return _fixedRoomMonsterSpawnStatsTable;
            }
        }
        private bool f_secretPowerEffectChance;
        private short _secretPowerEffectChance;

        /// <summary>
        /// The chance of Secret Power inflicting an effect, as a percentage (30%).
        /// </summary>
        public short SecretPowerEffectChance
        {
            get
            {
                if (f_secretPowerEffectChance)
                    return _secretPowerEffectChance;
                long _pos = m_io.Pos;
                m_io.Seek(31460);
                _secretPowerEffectChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_secretPowerEffectChance = true;
                return _secretPowerEffectChance;
            }
        }
        private bool f_matchupNeutralMultiplier;
        private int _matchupNeutralMultiplier;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_NEUTRAL, as a fixed-point number with 8 fraction bits (1).
        /// </summary>
        public int MatchupNeutralMultiplier
        {
            get
            {
                if (f_matchupNeutralMultiplier)
                    return _matchupNeutralMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32180);
                _matchupNeutralMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupNeutralMultiplier = true;
                return _matchupNeutralMultiplier;
            }
        }
        private bool f_extrasensoryCringeChance;
        private short _extrasensoryCringeChance;

        /// <summary>
        /// The chance of Extrasensory (and others, see DoMoveDamageCringe10) inflicting the cringe status, as a percentage (10%).
        /// </summary>
        public short ExtrasensoryCringeChance
        {
            get
            {
                if (f_extrasensoryCringeChance)
                    return _extrasensoryCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31200);
                _extrasensoryCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_extrasensoryCringeChance = true;
                return _extrasensoryCringeChance;
            }
        }
        private bool f_meFirstMultiplier;
        private int _meFirstMultiplier;

        /// <summary>
        /// The damage multiplier applied to attacks copied by Me First, as a fixed-point number with 8 fraction bits (1.5).
        /// </summary>
        public int MeFirstMultiplier
        {
            get
            {
                if (f_meFirstMultiplier)
                    return _meFirstMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(31912);
                _meFirstMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_meFirstMultiplier = true;
                return _meFirstMultiplier;
            }
        }
        private bool f_matchupNotVeryEffectiveMultiplierErraticPlayer;
        private int _matchupNotVeryEffectiveMultiplierErraticPlayer;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_NOT_VERY_EFFECTIVE when Erratic Player is active, as a fixed-point number with 8 fraction bits (0.5).
        /// </summary>
        public int MatchupNotVeryEffectiveMultiplierErraticPlayer
        {
            get
            {
                if (f_matchupNotVeryEffectiveMultiplierErraticPlayer)
                    return _matchupNotVeryEffectiveMultiplierErraticPlayer;
                long _pos = m_io.Pos;
                m_io.Seek(32188);
                _matchupNotVeryEffectiveMultiplierErraticPlayer = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupNotVeryEffectiveMultiplierErraticPlayer = true;
                return _matchupNotVeryEffectiveMultiplierErraticPlayer;
            }
        }
        private bool f_wishBonusRegen;
        private short _wishBonusRegen;

        /// <summary>
        /// The passive bonus regen given by the wish status condition.
        /// </summary>
        public short WishBonusRegen
        {
            get
            {
                if (f_wishBonusRegen)
                    return _wishBonusRegen;
                long _pos = m_io.Pos;
                m_io.Seek(31848);
                _wishBonusRegen = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_wishBonusRegen = true;
                return _wishBonusRegen;
            }
        }
        private bool f_ironThornPower;
        private short _ironThornPower;

        /// <summary>
        /// Attack power for Iron Thorns.
        /// </summary>
        public short IronThornPower
        {
            get
            {
                if (f_ironThornPower)
                    return _ironThornPower;
                long _pos = m_io.Pos;
                m_io.Seek(31872);
                _ironThornPower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_ironThornPower = true;
                return _ironThornPower;
            }
        }
        private bool f_weatherBallDamageMultTable;
        private WeatherBallDamageMultTableArray _weatherBallDamageMultTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding Weather Ball damage multiplier, where each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// type: int[8]
        /// </summary>
        public WeatherBallDamageMultTableArray WeatherBallDamageMultTable
        {
            get
            {
                if (f_weatherBallDamageMultTable)
                    return _weatherBallDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(33004);
                _weatherBallDamageMultTable = new WeatherBallDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_weatherBallDamageMultTable = true;
                return _weatherBallDamageMultTable;
            }
        }
        private bool f_rareFossilDamage;
        private short _rareFossilDamage;

        /// <summary>
        /// Damage dealt by Rare Fossils.
        /// </summary>
        public short RareFossilDamage
        {
            get
            {
                if (f_rareFossilDamage)
                    return _rareFossilDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31828);
                _rareFossilDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_rareFossilDamage = true;
                return _rareFossilDamage;
            }
        }
        private bool f_skullBashDamageMultiplier;
        private int _skullBashDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Skull Bash, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int SkullBashDamageMultiplier
        {
            get
            {
                if (f_skullBashDamageMultiplier)
                    return _skullBashDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32340);
                _skullBashDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_skullBashDamageMultiplier = true;
                return _skullBashDamageMultiplier;
            }
        }
        private bool f_flyDamageMultiplier;
        private int _flyDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Fly, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int FlyDamageMultiplier
        {
            get
            {
                if (f_flyDamageMultiplier)
                    return _flyDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32344);
                _flyDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_flyDamageMultiplier = true;
                return _flyDamageMultiplier;
            }
        }
        private bool f_sonicboomFixedDamage;
        private short _sonicboomFixedDamage;

        /// <summary>
        /// The amount of fixed damage dealt by SonicBoom (20).
        /// </summary>
        public short SonicboomFixedDamage
        {
            get
            {
                if (f_sonicboomFixedDamage)
                    return _sonicboomFixedDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31488);
                _sonicboomFixedDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_sonicboomFixedDamage = true;
                return _sonicboomFixedDamage;
            }
        }
        private bool f_triAttackStatusChance;
        private short _triAttackStatusChance;

        /// <summary>
        /// The chance of Tri Attack inflicting any status condition, as a percentage (20%).
        /// </summary>
        public short TriAttackStatusChance
        {
            get
            {
                if (f_triAttackStatusChance)
                    return _triAttackStatusChance;
                long _pos = m_io.Pos;
                m_io.Seek(31788);
                _triAttackStatusChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_triAttackStatusChance = true;
                return _triAttackStatusChance;
            }
        }
        private bool f_castformWeatherAttributeTable;
        private CastformWeatherAttributeTableArray _castformWeatherAttributeTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding Castform type and form.
        /// 
        /// type: struct castform_weather_attributes[8]
        /// </summary>
        public CastformWeatherAttributeTableArray CastformWeatherAttributeTable
        {
            get
            {
                if (f_castformWeatherAttributeTable)
                    return _castformWeatherAttributeTable;
                long _pos = m_io.Pos;
                m_io.Seek(33284);
                _castformWeatherAttributeTable = new CastformWeatherAttributeTableArray(m_io);
                m_io.Seek(_pos);
                f_castformWeatherAttributeTable = true;
                return _castformWeatherAttributeTable;
            }
        }
        private bool f_sportConditionTurnRange;
        private SportConditionTurnRangeArray _sportConditionTurnRange;

        /// <summary>
        /// The turn range for the sport conditions activated by Mud Sport and Water Sport, [10, 12).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public SportConditionTurnRangeArray SportConditionTurnRange
        {
            get
            {
                if (f_sportConditionTurnRange)
                    return _sportConditionTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(32036);
                _sportConditionTurnRange = new SportConditionTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_sportConditionTurnRange = true;
                return _sportConditionTurnRange;
            }
        }
        private bool f_perishSongTurnRange;
        private PerishSongTurnRangeArray _perishSongTurnRange;

        /// <summary>
        /// The turn range for the status inflicted by Perish Song, [3, 3).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public PerishSongTurnRangeArray PerishSongTurnRange
        {
            get
            {
                if (f_perishSongTurnRange)
                    return _perishSongTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(32104);
                _perishSongTurnRange = new PerishSongTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_perishSongTurnRange = true;
                return _perishSongTurnRange;
            }
        }
        private bool f_sitrusBerryFullHpBoost;
        private short _sitrusBerryFullHpBoost;

        /// <summary>
        /// The permanent HP boost from eating a Sitrus Berry at full HP.
        /// </summary>
        public short SitrusBerryFullHpBoost
        {
            get
            {
                if (f_sitrusBerryFullHpBoost)
                    return _sitrusBerryFullHpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31628);
                _sitrusBerryFullHpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_sitrusBerryFullHpBoost = true;
                return _sitrusBerryFullHpBoost;
            }
        }
        private bool f_moonlightHpRestorationTable;
        private MoonlightHpRestorationTableArray _moonlightHpRestorationTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Moonlight.
        /// 
        /// type: int16_t[8]
        /// </summary>
        public MoonlightHpRestorationTableArray MoonlightHpRestorationTable
        {
            get
            {
                if (f_moonlightHpRestorationTable)
                    return _moonlightHpRestorationTable;
                long _pos = m_io.Pos;
                m_io.Seek(32524);
                _moonlightHpRestorationTable = new MoonlightHpRestorationTableArray(m_io);
                m_io.Seek(_pos);
                f_moonlightHpRestorationTable = true;
                return _moonlightHpRestorationTable;
            }
        }
        private bool f_intimidatorActivationChance;
        private short _intimidatorActivationChance;

        /// <summary>
        /// The percentage chance that Intimidator will activate.
        /// </summary>
        public short IntimidatorActivationChance
        {
            get
            {
                if (f_intimidatorActivationChance)
                    return _intimidatorActivationChance;
                long _pos = m_io.Pos;
                m_io.Seek(31568);
                _intimidatorActivationChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_intimidatorActivationChance = true;
                return _intimidatorActivationChance;
            }
        }
        private bool f_waterfallCringeChance;
        private short _waterfallCringeChance;

        /// <summary>
        /// The chance of Waterfall inflicting the cringe status, as a percentage (30%).
        /// </summary>
        public short WaterfallCringeChance
        {
            get
            {
                if (f_waterfallCringeChance)
                    return _waterfallCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31164);
                _waterfallCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_waterfallCringeChance = true;
                return _waterfallCringeChance;
            }
        }
        private bool f_thunderFangParalyzeChance;
        private short _thunderFangParalyzeChance;

        /// <summary>
        /// The chance of Thunder Fang paralyzing, as a percentage (10%).
        /// </summary>
        public short ThunderFangParalyzeChance
        {
            get
            {
                if (f_thunderFangParalyzeChance)
                    return _thunderFangParalyzeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31428);
                _thunderFangParalyzeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_thunderFangParalyzeChance = true;
                return _thunderFangParalyzeChance;
            }
        }
        private bool f_thrownItemHitChance;
        private short _thrownItemHitChance;

        /// <summary>
        /// Chance of a hurled item hitting the target (90%).
        /// </summary>
        public short ThrownItemHitChance
        {
            get
            {
                if (f_thrownItemHitChance)
                    return _thrownItemHitChance;
                long _pos = m_io.Pos;
                m_io.Seek(31816);
                _thrownItemHitChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_thrownItemHitChance = true;
                return _thrownItemHitChance;
            }
        }
        private bool f_inventoryMenuDefaultWindowParams;
        private WindowParams _inventoryMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for an inventory_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateInventoryMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateInventoryMenu.
        /// </summary>
        public WindowParams InventoryMenuDefaultWindowParams
        {
            get
            {
                if (f_inventoryMenuDefaultWindowParams)
                    return _inventoryMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(31020);
                _inventoryMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_inventoryMenuDefaultWindowParams = true;
                return _inventoryMenuDefaultWindowParams;
            }
        }
        private bool f_metalClawBoostAttackChance;
        private short _metalClawBoostAttackChance;

        /// <summary>
        /// The chance of Metal Claw boosting attack, as a percentage (20%).
        /// </summary>
        public short MetalClawBoostAttackChance
        {
            get
            {
                if (f_metalClawBoostAttackChance)
                    return _metalClawBoostAttackChance;
                long _pos = m_io.Pos;
                m_io.Seek(31468);
                _metalClawBoostAttackChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_metalClawBoostAttackChance = true;
                return _metalClawBoostAttackChance;
            }
        }
        private bool f_mistBallLowerSpecialAttackChance;
        private short _mistBallLowerSpecialAttackChance;

        /// <summary>
        /// The chance of Mist Ball lowering special attack, as a percentage (50%).
        /// </summary>
        public short MistBallLowerSpecialAttackChance
        {
            get
            {
                if (f_mistBallLowerSpecialAttackChance)
                    return _mistBallLowerSpecialAttackChance;
                long _pos = m_io.Pos;
                m_io.Seek(31352);
                _mistBallLowerSpecialAttackChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_mistBallLowerSpecialAttackChance = true;
                return _mistBallLowerSpecialAttackChance;
            }
        }
        private bool f_goldThornPower;
        private short _goldThornPower;

        /// <summary>
        /// Attack power for Golden Thorns.
        /// </summary>
        public short GoldThornPower
        {
            get
            {
                if (f_goldThornPower)
                    return _goldThornPower;
                long _pos = m_io.Pos;
                m_io.Seek(31336);
                _goldThornPower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_goldThornPower = true;
                return _goldThornPower;
            }
        }
        private bool f_morningSunHpRestorationTable;
        private MorningSunHpRestorationTableArray _morningSunHpRestorationTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Morning Sun.
        /// 
        /// type: int16_t[8]
        /// </summary>
        public MorningSunHpRestorationTableArray MorningSunHpRestorationTable
        {
            get
            {
                if (f_morningSunHpRestorationTable)
                    return _morningSunHpRestorationTable;
                long _pos = m_io.Pos;
                m_io.Seek(32540);
                _morningSunHpRestorationTable = new MorningSunHpRestorationTableArray(m_io);
                m_io.Seek(_pos);
                f_morningSunHpRestorationTable = true;
                return _morningSunHpRestorationTable;
            }
        }
        private bool f_stickPower;
        private short _stickPower;

        /// <summary>
        /// Attack power for Sticks.
        /// </summary>
        public short StickPower
        {
            get
            {
                if (f_stickPower)
                    return _stickPower;
                long _pos = m_io.Pos;
                m_io.Seek(31676);
                _stickPower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_stickPower = true;
                return _stickPower;
            }
        }
        private bool f_musicIdTable;
        private MusicIdTableArray _musicIdTable;

        /// <summary>
        /// List of music IDs used in dungeons with a single music track.
        /// 
        /// This is an array of 170 2-byte music IDs, and is indexed into by the music value in the floor properties struct for a given floor. Music IDs with the highest bit set (0x8000) are indexes into the RANDOM_MUSIC_ID_TABLE.
        /// 
        /// type: struct music_id_16[170] (or not a music ID if the highest bit is set)
        /// </summary>
        public MusicIdTableArray MusicIdTable
        {
            get
            {
                if (f_musicIdTable)
                    return _musicIdTable;
                long _pos = m_io.Pos;
                m_io.Seek(35572);
                _musicIdTable = new MusicIdTableArray(m_io);
                m_io.Seek(_pos);
                f_musicIdTable = true;
                return _musicIdTable;
            }
        }
        private bool f_oranBerryFullHpBoost;
        private short _oranBerryFullHpBoost;

        /// <summary>
        /// The permanent HP boost from eating an Oran Berry at full HP (0).
        /// </summary>
        public short OranBerryFullHpBoost
        {
            get
            {
                if (f_oranBerryFullHpBoost)
                    return _oranBerryFullHpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31372);
                _oranBerryFullHpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_oranBerryFullHpBoost = true;
                return _oranBerryFullHpBoost;
            }
        }
        private bool f_fakeOutCringeChance;
        private short _fakeOutCringeChance;

        /// <summary>
        /// The chance of Fake Out inflicting the cringe status, as a percentage (35%).
        /// </summary>
        public short FakeOutCringeChance
        {
            get
            {
                if (f_fakeOutCringeChance)
                    return _fakeOutCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31752);
                _fakeOutCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_fakeOutCringeChance = true;
                return _fakeOutCringeChance;
            }
        }
        private bool f_exclusiveItemExpBoost;
        private short _exclusiveItemExpBoost;

        /// <summary>
        /// The percentage increase in experience from exp-boosting exclusive items.
        /// </summary>
        public short ExclusiveItemExpBoost
        {
            get
            {
                if (f_exclusiveItemExpBoost)
                    return _exclusiveItemExpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31524);
                _exclusiveItemExpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_exclusiveItemExpBoost = true;
                return _exclusiveItemExpBoost;
            }
        }
        private bool f_superLuckCritRateBoost;
        private short _superLuckCritRateBoost;

        /// <summary>
        /// The critical hit rate (additive) boost from Super Luck, 10%.
        /// </summary>
        public short SuperLuckCritRateBoost
        {
            get
            {
                if (f_superLuckCritRateBoost)
                    return _superLuckCritRateBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31400);
                _superLuckCritRateBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_superLuckCritRateBoost = true;
                return _superLuckCritRateBoost;
            }
        }
        private bool f_detectBandMoveAccuracyDrop;
        private int _detectBandMoveAccuracyDrop;

        /// <summary>
        /// The (subtractive) move accuracy drop induced on an attacker if the defender is wearing a Detect Band (30).
        /// </summary>
        public int DetectBandMoveAccuracyDrop
        {
            get
            {
                if (f_detectBandMoveAccuracyDrop)
                    return _detectBandMoveAccuracyDrop;
                long _pos = m_io.Pos;
                m_io.Seek(32064);
                _detectBandMoveAccuracyDrop = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_detectBandMoveAccuracyDrop = true;
                return _detectBandMoveAccuracyDrop;
            }
        }
        private bool f_twineedlePoisonChance;
        private short _twineedlePoisonChance;

        /// <summary>
        /// The chance of Twineedle poisoning, as a percentage (20%).
        /// </summary>
        public short TwineedlePoisonChance
        {
            get
            {
                if (f_twineedlePoisonChance)
                    return _twineedlePoisonChance;
                long _pos = m_io.Pos;
                m_io.Seek(31196);
                _twineedlePoisonChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_twineedlePoisonChance = true;
                return _twineedlePoisonChance;
            }
        }
        private bool f_poisonTailPoisonChance;
        private short _poisonTailPoisonChance;

        /// <summary>
        /// The chance of Poison Tail poisoning, as a percentage (10%).
        /// </summary>
        public short PoisonTailPoisonChance
        {
            get
            {
                if (f_poisonTailPoisonChance)
                    return _poisonTailPoisonChance;
                long _pos = m_io.Pos;
                m_io.Seek(31268);
                _poisonTailPoisonChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_poisonTailPoisonChance = true;
                return _poisonTailPoisonChance;
            }
        }
        private bool f_spawnCapNoMonsterHouse;
        private short _spawnCapNoMonsterHouse;

        /// <summary>
        /// The maximum number of enemies that can spawn on a floor without a monster house (15).
        /// </summary>
        public short SpawnCapNoMonsterHouse
        {
            get
            {
                if (f_spawnCapNoMonsterHouse)
                    return _spawnCapNoMonsterHouse;
                long _pos = m_io.Pos;
                m_io.Seek(31176);
                _spawnCapNoMonsterHouse = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_spawnCapNoMonsterHouse = true;
                return _spawnCapNoMonsterHouse;
            }
        }
        private bool f_bubbleLowerSpeedChance;
        private short _bubbleLowerSpeedChance;

        /// <summary>
        /// The chance of Bubble lowering speed, as a percentage (10%).
        /// </summary>
        public short BubbleLowerSpeedChance
        {
            get
            {
                if (f_bubbleLowerSpeedChance)
                    return _bubbleLowerSpeedChance;
                long _pos = m_io.Pos;
                m_io.Seek(31684);
                _bubbleLowerSpeedChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_bubbleLowerSpeedChance = true;
                return _bubbleLowerSpeedChance;
            }
        }
        private bool f_whirlpoolConstrictionChance;
        private short _whirlpoolConstrictionChance;

        /// <summary>
        /// The chance of Whirlpool inflicting the constriction status, as a percentage (10%).
        /// </summary>
        public short WhirlpoolConstrictionChance
        {
            get
            {
                if (f_whirlpoolConstrictionChance)
                    return _whirlpoolConstrictionChance;
                long _pos = m_io.Pos;
                m_io.Seek(31292);
                _whirlpoolConstrictionChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_whirlpoolConstrictionChance = true;
                return _whirlpoolConstrictionChance;
            }
        }
        private bool f_thunderboltParalyzeChance;
        private short _thunderboltParalyzeChance;

        /// <summary>
        /// The chance of Thunderbolt paralyzing, as a percentage (15%).
        /// </summary>
        public short ThunderboltParalyzeChance
        {
            get
            {
                if (f_thunderboltParalyzeChance)
                    return _thunderboltParalyzeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31732);
                _thunderboltParalyzeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_thunderboltParalyzeChance = true;
                return _thunderboltParalyzeChance;
            }
        }
        private bool f_constrictLowerSpeedChance;
        private short _constrictLowerSpeedChance;

        /// <summary>
        /// The chance of Constrict (and others, see DoMoveDamageLowerSpeed20) lowering speed, as a percentage (20%).
        /// </summary>
        public short ConstrictLowerSpeedChance
        {
            get
            {
                if (f_constrictLowerSpeedChance)
                    return _constrictLowerSpeedChance;
                long _pos = m_io.Pos;
                m_io.Seek(31404);
                _constrictLowerSpeedChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_constrictLowerSpeedChance = true;
                return _constrictLowerSpeedChance;
            }
        }
        private bool f_imprisonTurnRange;
        private ImprisonTurnRangeArray _imprisonTurnRange;

        /// <summary>
        /// The turn range for the Paused status inflicted by Imprison, [3, 6).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public ImprisonTurnRangeArray ImprisonTurnRange
        {
            get
            {
                if (f_imprisonTurnRange)
                    return _imprisonTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(31924);
                _imprisonTurnRange = new ImprisonTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_imprisonTurnRange = true;
                return _imprisonTurnRange;
            }
        }
        private bool f_chargeBeamBoostSpecialAttackChance;
        private short _chargeBeamBoostSpecialAttackChance;

        /// <summary>
        /// The chance of Charge Beam boosting special attack, as a percentage (40%).
        /// </summary>
        public short ChargeBeamBoostSpecialAttackChance
        {
            get
            {
                if (f_chargeBeamBoostSpecialAttackChance)
                    return _chargeBeamBoostSpecialAttackChance;
                long _pos = m_io.Pos;
                m_io.Seek(31368);
                _chargeBeamBoostSpecialAttackChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_chargeBeamBoostSpecialAttackChance = true;
                return _chargeBeamBoostSpecialAttackChance;
            }
        }
        private bool f_ironStatBoost;
        private short _ironStatBoost;

        /// <summary>
        /// The permanent defense boost from ingesting an Iron.
        /// </summary>
        public short IronStatBoost
        {
            get
            {
                if (f_ironStatBoost)
                    return _ironStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31840);
                _ironStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_ironStatBoost = true;
                return _ironStatBoost;
            }
        }
        private bool f_corsolaTwigPower;
        private short _corsolaTwigPower;

        /// <summary>
        /// Attack power for Corsola Twigs.
        /// </summary>
        public short CorsolaTwigPower
        {
            get
            {
                if (f_corsolaTwigPower)
                    return _corsolaTwigPower;
                long _pos = m_io.Pos;
                m_io.Seek(31856);
                _corsolaTwigPower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_corsolaTwigPower = true;
                return _corsolaTwigPower;
            }
        }
        private bool f_gravelerockDamage;
        private short _gravelerockDamage;

        /// <summary>
        /// Damage dealt by Gravelerocks.
        /// </summary>
        public short GravelerockDamage
        {
            get
            {
                if (f_gravelerockDamage)
                    return _gravelerockDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31824);
                _gravelerockDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_gravelerockDamage = true;
                return _gravelerockDamage;
            }
        }
        private bool f_lifeSeedHpBoost;
        private short _lifeSeedHpBoost;

        /// <summary>
        /// The permanent HP boost from eating a Life Seed.
        /// </summary>
        public short LifeSeedHpBoost
        {
            get
            {
                if (f_lifeSeedHpBoost)
                    return _lifeSeedHpBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31376);
                _lifeSeedHpBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_lifeSeedHpBoost = true;
                return _lifeSeedHpBoost;
            }
        }
        private bool f_muddyWaterLowerAccuracyChance;
        private short _muddyWaterLowerAccuracyChance;

        /// <summary>
        /// The chance of Muddy Water (and others, see DoMoveDamageLowerAccuracy40) lowering accuracy, as a percentage (40%).
        /// </summary>
        public short MuddyWaterLowerAccuracyChance
        {
            get
            {
                if (f_muddyWaterLowerAccuracyChance)
                    return _muddyWaterLowerAccuracyChance;
                long _pos = m_io.Pos;
                m_io.Seek(31260);
                _muddyWaterLowerAccuracyChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_muddyWaterLowerAccuracyChance = true;
                return _muddyWaterLowerAccuracyChance;
            }
        }
        private bool f_quickDodgerMoveAccuracyDrop;
        private int _quickDodgerMoveAccuracyDrop;

        /// <summary>
        /// The (subtractive) move accuracy drop induced on an attacker if the defender has the Quick Dodger IQ skill (10).
        /// </summary>
        public int QuickDodgerMoveAccuracyDrop
        {
            get
            {
                if (f_quickDodgerMoveAccuracyDrop)
                    return _quickDodgerMoveAccuracyDrop;
                long _pos = m_io.Pos;
                m_io.Seek(32160);
                _quickDodgerMoveAccuracyDrop = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_quickDodgerMoveAccuracyDrop = true;
                return _quickDodgerMoveAccuracyDrop;
            }
        }
        private bool f_matchupSuperEffectiveMultiplierErraticPlayer;
        private int _matchupSuperEffectiveMultiplierErraticPlayer;

        /// <summary>
        /// The damage multiplier corresponding to MATCHUP_SUPER_EFFECTIVE when Erratic Player is active, as a fixed-point number with 8 fraction bits (the raw value is 0x1B3, the closest possible representation of 1.7).
        /// </summary>
        public int MatchupSuperEffectiveMultiplierErraticPlayer
        {
            get
            {
                if (f_matchupSuperEffectiveMultiplierErraticPlayer)
                    return _matchupSuperEffectiveMultiplierErraticPlayer;
                long _pos = m_io.Pos;
                m_io.Seek(31972);
                _matchupSuperEffectiveMultiplierErraticPlayer = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_matchupSuperEffectiveMultiplierErraticPlayer = true;
                return _matchupSuperEffectiveMultiplierErraticPlayer;
            }
        }
        private bool f_orenBerryDamage;
        private short _orenBerryDamage;

        /// <summary>
        /// Damage dealt by eating an Oren Berry.
        /// </summary>
        public short OrenBerryDamage
        {
            get
            {
                if (f_orenBerryDamage)
                    return _orenBerryDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31184);
                _orenBerryDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_orenBerryDamage = true;
                return _orenBerryDamage;
            }
        }
        private bool f_badPoisonDamageCooldown;
        private short _badPoisonDamageCooldown;

        /// <summary>
        /// The number of turns between passive bad poison (toxic) damage.
        /// </summary>
        public short BadPoisonDamageCooldown
        {
            get
            {
                if (f_badPoisonDamageCooldown)
                    return _badPoisonDamageCooldown;
                long _pos = m_io.Pos;
                m_io.Seek(31148);
                _badPoisonDamageCooldown = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_badPoisonDamageCooldown = true;
                return _badPoisonDamageCooldown;
            }
        }
        private bool f_trapAnimationInfo;
        private TrapAnimationInfoArray _trapAnimationInfo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct trap_animation[26]
        /// </summary>
        public TrapAnimationInfoArray TrapAnimationInfo
        {
            get
            {
                if (f_trapAnimationInfo)
                    return _trapAnimationInfo;
                long _pos = m_io.Pos;
                m_io.Seek(45032);
                _trapAnimationInfo = new TrapAnimationInfoArray(m_io);
                m_io.Seek(_pos);
                f_trapAnimationInfo = true;
                return _trapAnimationInfo;
            }
        }
        private bool f_sureShotTurnRange;
        private SureShotTurnRangeArray _sureShotTurnRange;

        /// <summary>
        /// The turn range for the Sure Shot status inflicted by Mind Reader and Lock-On, [10, 12).
        /// 
        /// type: int16_t[2]
        /// </summary>
        public SureShotTurnRangeArray SureShotTurnRange
        {
            get
            {
                if (f_sureShotTurnRange)
                    return _sureShotTurnRange;
                long _pos = m_io.Pos;
                m_io.Seek(32048);
                _sureShotTurnRange = new SureShotTurnRangeArray(m_io);
                m_io.Seek(_pos);
                f_sureShotTurnRange = true;
                return _sureShotTurnRange;
            }
        }
        private bool f_poisonDamageCooldown;
        private short _poisonDamageCooldown;

        /// <summary>
        /// The number of turns between passive poison damage.
        /// </summary>
        public short PoisonDamageCooldown
        {
            get
            {
                if (f_poisonDamageCooldown)
                    return _poisonDamageCooldown;
                long _pos = m_io.Pos;
                m_io.Seek(31808);
                _poisonDamageCooldown = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_poisonDamageCooldown = true;
                return _poisonDamageCooldown;
            }
        }
        private bool f_shadowBallLowerSpecialDefenseChance;
        private short _shadowBallLowerSpecialDefenseChance;

        /// <summary>
        /// The chance of Shadow Ball lowering special defense, as a percentage (20%).
        /// </summary>
        public short ShadowBallLowerSpecialDefenseChance
        {
            get
            {
                if (f_shadowBallLowerSpecialDefenseChance)
                    return _shadowBallLowerSpecialDefenseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31668);
                _shadowBallLowerSpecialDefenseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_shadowBallLowerSpecialDefenseChance = true;
                return _shadowBallLowerSpecialDefenseChance;
            }
        }
        private bool f_proteinStatBoost;
        private short _proteinStatBoost;

        /// <summary>
        /// The permanent attack boost from ingesting a Protein.
        /// </summary>
        public short ProteinStatBoost
        {
            get
            {
                if (f_proteinStatBoost)
                    return _proteinStatBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31160);
                _proteinStatBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_proteinStatBoost = true;
                return _proteinStatBoost;
            }
        }
        private bool f_twisterCringeChance;
        private short _twisterCringeChance;

        /// <summary>
        /// The chance of Twister inflicting the cringe status, as a percentage (10%).
        /// </summary>
        public short TwisterCringeChance
        {
            get
            {
                if (f_twisterCringeChance)
                    return _twisterCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31744);
                _twisterCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_twisterCringeChance = true;
                return _twisterCringeChance;
            }
        }
        private bool f_goldFangPower;
        private short _goldFangPower;

        /// <summary>
        /// Attack power for Gold Fangs.
        /// </summary>
        public short GoldFangPower
        {
            get
            {
                if (f_goldFangPower)
                    return _goldFangPower;
                long _pos = m_io.Pos;
                m_io.Seek(31864);
                _goldFangPower = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_goldFangPower = true;
                return _goldFangPower;
            }
        }
        private bool f_healOrderHpRestoration;
        private short _healOrderHpRestoration;

        /// <summary>
        /// The amount of HP restored by Heal Order (40).
        /// </summary>
        public short HealOrderHpRestoration
        {
            get
            {
                if (f_healOrderHpRestoration)
                    return _healOrderHpRestoration;
                long _pos = m_io.Pos;
                m_io.Seek(31312);
                _healOrderHpRestoration = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_healOrderHpRestoration = true;
                return _healOrderHpRestoration;
            }
        }
        private bool f_poisonStingPoisonChance;
        private short _poisonStingPoisonChance;

        /// <summary>
        /// The chance of Poison Sting (and others, see DoMoveDamagePoison18) poisoning, as a percentage (18%).
        /// </summary>
        public short PoisonStingPoisonChance
        {
            get
            {
                if (f_poisonStingPoisonChance)
                    return _poisonStingPoisonChance;
                long _pos = m_io.Pos;
                m_io.Seek(31700);
                _poisonStingPoisonChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_poisonStingPoisonChance = true;
                return _poisonStingPoisonChance;
            }
        }
        private bool f_healingWishHpRestoration;
        private short _healingWishHpRestoration;

        /// <summary>
        /// The amount of HP restored by Healing Wish (999). This also applies to Lunar Dance.
        /// </summary>
        public short HealingWishHpRestoration
        {
            get
            {
                if (f_healingWishHpRestoration)
                    return _healingWishHpRestoration;
                long _pos = m_io.Pos;
                m_io.Seek(31884);
                _healingWishHpRestoration = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_healingWishHpRestoration = true;
                return _healingWishHpRestoration;
            }
        }
        private bool f_leechSeedDamageCooldown;
        private short _leechSeedDamageCooldown;

        /// <summary>
        /// The number of turns between leech seed health drain.
        /// </summary>
        public short LeechSeedDamageCooldown
        {
            get
            {
                if (f_leechSeedDamageCooldown)
                    return _leechSeedDamageCooldown;
                long _pos = m_io.Pos;
                m_io.Seek(31812);
                _leechSeedDamageCooldown = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_leechSeedDamageCooldown = true;
                return _leechSeedDamageCooldown;
            }
        }
        private bool f_specialMonsterMoveAnimationInfo;
        private SpecialMonsterMoveAnimationInfoArray _specialMonsterMoveAnimationInfo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// type: struct special_monster_move_animation[7422]
        /// </summary>
        public SpecialMonsterMoveAnimationInfoArray SpecialMonsterMoveAnimationInfo
        {
            get
            {
                if (f_specialMonsterMoveAnimationInfo)
                    return _specialMonsterMoveAnimationInfo;
                long _pos = m_io.Pos;
                m_io.Seek(83796);
                _specialMonsterMoveAnimationInfo = new SpecialMonsterMoveAnimationInfoArray(m_io);
                m_io.Seek(_pos);
                f_specialMonsterMoveAnimationInfo = true;
                return _specialMonsterMoveAnimationInfo;
            }
        }
        private bool f_maleEvasionStageMultipliers;
        private MaleEvasionStageMultipliersArray _maleEvasionStageMultipliers;

        /// <summary>
        /// Table of multipliers for the evasion stat for males for each stage 0-20, as binary fixed-point numbers (8 fraction bits)
        /// </summary>
        public MaleEvasionStageMultipliersArray MaleEvasionStageMultipliers
        {
            get
            {
                if (f_maleEvasionStageMultipliers)
                    return _maleEvasionStageMultipliers;
                long _pos = m_io.Pos;
                m_io.Seek(35320);
                _maleEvasionStageMultipliers = new MaleEvasionStageMultipliersArray(m_io);
                m_io.Seek(_pos);
                f_maleEvasionStageMultipliers = true;
                return _maleEvasionStageMultipliers;
            }
        }
        private bool f_iceBodyBonusRegen;
        private short _iceBodyBonusRegen;

        /// <summary>
        /// The passive bonus health regen given when the weather is hail for the ability ice body.
        /// </summary>
        public short IceBodyBonusRegen
        {
            get
            {
                if (f_iceBodyBonusRegen)
                    return _iceBodyBonusRegen;
                long _pos = m_io.Pos;
                m_io.Seek(31688);
                _iceBodyBonusRegen = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_iceBodyBonusRegen = true;
                return _iceBodyBonusRegen;
            }
        }
        private bool f_poisonFangPoisonChance;
        private short _poisonFangPoisonChance;

        /// <summary>
        /// The chance of Poison Fang poisoning, as a percentage (30%).
        /// </summary>
        public short PoisonFangPoisonChance
        {
            get
            {
                if (f_poisonFangPoisonChance)
                    return _poisonFangPoisonChance;
                long _pos = m_io.Pos;
                m_io.Seek(31708);
                _poisonFangPoisonChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_poisonFangPoisonChance = true;
                return _poisonFangPoisonChance;
            }
        }
        private bool f_facadeDamageMultiplier;
        private int _facadeDamageMultiplier;

        /// <summary>
        /// The Facade damage multiplier for users with a status condition, as a binary fixed-point number with 8 fraction bits (0x200 -&gt; 2x).
        /// </summary>
        public int FacadeDamageMultiplier
        {
            get
            {
                if (f_facadeDamageMultiplier)
                    return _facadeDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(31920);
                _facadeDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_facadeDamageMultiplier = true;
                return _facadeDamageMultiplier;
            }
        }
        private bool f_trapBusterActivationChance;
        private short _trapBusterActivationChance;

        /// <summary>
        /// The chance of Trap Buster activating (30%).
        /// </summary>
        public short TrapBusterActivationChance
        {
            get
            {
                if (f_trapBusterActivationChance)
                    return _trapBusterActivationChance;
                long _pos = m_io.Pos;
                m_io.Seek(31220);
                _trapBusterActivationChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_trapBusterActivationChance = true;
                return _trapBusterActivationChance;
            }
        }
        private bool f_roostHpRestorationTable;
        private RoostHpRestorationTableArray _roostHpRestorationTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding HP restoration value for Roost.
        /// 
        /// Every entry in this table is 40.
        /// 
        /// type: int16_t[8]
        /// </summary>
        public RoostHpRestorationTableArray RoostHpRestorationTable
        {
            get
            {
                if (f_roostHpRestorationTable)
                    return _roostHpRestorationTable;
                long _pos = m_io.Pos;
                m_io.Seek(32508);
                _roostHpRestorationTable = new RoostHpRestorationTableArray(m_io);
                m_io.Seek(_pos);
                f_roostHpRestorationTable = true;
                return _roostHpRestorationTable;
            }
        }
        private bool f_sitrusBerryHpRestoration;
        private short _sitrusBerryHpRestoration;

        /// <summary>
        /// The amount of HP restored by eating a Sitrus Berry.
        /// </summary>
        public short SitrusBerryHpRestoration
        {
            get
            {
                if (f_sitrusBerryHpRestoration)
                    return _sitrusBerryHpRestoration;
                long _pos = m_io.Pos;
                m_io.Seek(31248);
                _sitrusBerryHpRestoration = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_sitrusBerryHpRestoration = true;
                return _sitrusBerryHpRestoration;
            }
        }
        private bool f_thunderFangCringeChance;
        private short _thunderFangCringeChance;

        /// <summary>
        /// The chance of Thunder Fang inflicting the cringe status, as a percentage (25%).
        /// </summary>
        public short ThunderFangCringeChance
        {
            get
            {
                if (f_thunderFangCringeChance)
                    return _thunderFangCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31760);
                _thunderFangCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_thunderFangCringeChance = true;
                return _thunderFangCringeChance;
            }
        }
        private bool f_setDamageStatusDamage;
        private short _setDamageStatusDamage;

        /// <summary>
        /// The fixed amount of damage dealt when the Set Damage status condition is active (30).
        /// </summary>
        public short SetDamageStatusDamage
        {
            get
            {
                if (f_setDamageStatusDamage)
                    return _setDamageStatusDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31536);
                _setDamageStatusDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_setDamageStatusDamage = true;
                return _setDamageStatusDamage;
            }
        }
        private bool f_offensiveStatStageMultipliers;
        private OffensiveStatStageMultipliersArray _offensiveStatStageMultipliers;

        /// <summary>
        /// Table of multipliers for offensive stats (attack/special attack) for each stage 0-20, as binary fixed-point numbers (8 fraction bits)
        /// </summary>
        public OffensiveStatStageMultipliersArray OffensiveStatStageMultipliers
        {
            get
            {
                if (f_offensiveStatStageMultipliers)
                    return _offensiveStatStageMultipliers;
                long _pos = m_io.Pos;
                m_io.Seek(33584);
                _offensiveStatStageMultipliers = new OffensiveStatStageMultipliersArray(m_io);
                m_io.Seek(_pos);
                f_offensiveStatStageMultipliers = true;
                return _offensiveStatStageMultipliers;
            }
        }
        private bool f_femaleAccuracyStageMultipliers;
        private FemaleAccuracyStageMultipliersArray _femaleAccuracyStageMultipliers;

        /// <summary>
        /// Table of multipliers for the accuracy stat for females for each stage 0-20, as binary fixed-point numbers (8 fraction bits)
        /// </summary>
        public FemaleAccuracyStageMultipliersArray FemaleAccuracyStageMultipliers
        {
            get
            {
                if (f_femaleAccuracyStageMultipliers)
                    return _femaleAccuracyStageMultipliers;
                long _pos = m_io.Pos;
                m_io.Seek(35404);
                _femaleAccuracyStageMultipliers = new FemaleAccuracyStageMultipliersArray(m_io);
                m_io.Seek(_pos);
                f_femaleAccuracyStageMultipliers = true;
                return _femaleAccuracyStageMultipliers;
            }
        }
        private bool f_aftermathChance;
        private short _aftermathChance;

        /// <summary>
        /// The chance of the Aftermath ability activating, as a percentage (50%).
        /// </summary>
        public short AftermathChance
        {
            get
            {
                if (f_aftermathChance)
                    return _aftermathChance;
                long _pos = m_io.Pos;
                m_io.Seek(31532);
                _aftermathChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_aftermathChance = true;
                return _aftermathChance;
            }
        }
        private bool f_rockSlideCringeChance;
        private short _rockSlideCringeChance;

        /// <summary>
        /// The chance of Rock Slide (and others, see DoMoveDamageCringe30) inflicting the cringe status, as a percentage (30%).
        /// </summary>
        public short RockSlideCringeChance
        {
            get
            {
                if (f_rockSlideCringeChance)
                    return _rockSlideCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31204);
                _rockSlideCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_rockSlideCringeChance = true;
                return _rockSlideCringeChance;
            }
        }
        private bool f_badPoisonDamageTable;
        private BadPoisonDamageTableArray _badPoisonDamageTable;

        /// <summary>
        /// Table for how much damage each tick of badly poisoned should deal. The table is filled with 0x0006, but could use different values for each entry.
        /// </summary>
        public BadPoisonDamageTableArray BadPoisonDamageTable
        {
            get
            {
                if (f_badPoisonDamageTable)
                    return _badPoisonDamageTable;
                long _pos = m_io.Pos;
                m_io.Seek(33332);
                _badPoisonDamageTable = new BadPoisonDamageTableArray(m_io);
                m_io.Seek(_pos);
                f_badPoisonDamageTable = true;
                return _badPoisonDamageTable;
            }
        }
        private bool f_skyAttackDamageMultiplier;
        private int _skyAttackDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Sky Attack, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int SkyAttackDamageMultiplier
        {
            get
            {
                if (f_skyAttackDamageMultiplier)
                    return _skyAttackDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32320);
                _skyAttackDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_skyAttackDamageMultiplier = true;
                return _skyAttackDamageMultiplier;
            }
        }
        private bool f_weatherBallTypeTable;
        private WeatherBallTypeTableArray _weatherBallTypeTable;

        /// <summary>
        /// Maps each weather type (by index, see enum weather_id) to the corresponding Weather Ball type.
        /// 
        /// type: struct type_id_8[8]
        /// </summary>
        public WeatherBallTypeTableArray WeatherBallTypeTable
        {
            get
            {
                if (f_weatherBallTypeTable)
                    return _weatherBallTypeTable;
                long _pos = m_io.Pos;
                m_io.Seek(32372);
                _weatherBallTypeTable = new WeatherBallTypeTableArray(m_io);
                m_io.Seek(_pos);
                f_weatherBallTypeTable = true;
                return _weatherBallTypeTable;
            }
        }
        private bool f_dragonRageFixedDamage;
        private short _dragonRageFixedDamage;

        /// <summary>
        /// The amount of fixed damage dealt by Dragon Rage (30).
        /// </summary>
        public short DragonRageFixedDamage
        {
            get
            {
                if (f_dragonRageFixedDamage)
                    return _dragonRageFixedDamage;
                long _pos = m_io.Pos;
                m_io.Seek(31852);
                _dragonRageFixedDamage = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_dragonRageFixedDamage = true;
                return _dragonRageFixedDamage;
            }
        }
        private bool f_headbuttCringeChance;
        private short _headbuttCringeChance;

        /// <summary>
        /// The chance of Headbutt inflicting the cringe status, as a percentage (25%).
        /// </summary>
        public short HeadbuttCringeChance
        {
            get
            {
                if (f_headbuttCringeChance)
                    return _headbuttCringeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31280);
                _headbuttCringeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_headbuttCringeChance = true;
                return _headbuttCringeChance;
            }
        }
        private bool f_focusPunchDamageMultiplier;
        private int _focusPunchDamageMultiplier;

        /// <summary>
        /// The damage multiplier for Focus Punch, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int FocusPunchDamageMultiplier
        {
            get
            {
                if (f_focusPunchDamageMultiplier)
                    return _focusPunchDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32332);
                _focusPunchDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_focusPunchDamageMultiplier = true;
                return _focusPunchDamageMultiplier;
            }
        }
        private bool f_monsterHouseMaxNonMonsterSpawns;
        private short _monsterHouseMaxNonMonsterSpawns;

        /// <summary>
        /// The maximum number of extra non-monster spawns (items/traps) in a Monster House, 7
        /// </summary>
        public short MonsterHouseMaxNonMonsterSpawns
        {
            get
            {
                if (f_monsterHouseMaxNonMonsterSpawns)
                    return _monsterHouseMaxNonMonsterSpawns;
                long _pos = m_io.Pos;
                m_io.Seek(31300);
                _monsterHouseMaxNonMonsterSpawns = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_monsterHouseMaxNonMonsterSpawns = true;
                return _monsterHouseMaxNonMonsterSpawns;
            }
        }
        private bool f_leechSeedHpDrain;
        private short _leechSeedHpDrain;

        /// <summary>
        /// The amount of health drained by leech seed status.
        /// </summary>
        public short LeechSeedHpDrain
        {
            get
            {
                if (f_leechSeedHpDrain)
                    return _leechSeedHpDrain;
                long _pos = m_io.Pos;
                m_io.Seek(31520);
                _leechSeedHpDrain = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_leechSeedHpDrain = true;
                return _leechSeedHpDrain;
            }
        }
        private bool f_psybeamConfuseChance;
        private short _psybeamConfuseChance;

        /// <summary>
        /// The chance of Psybeam (and others, see DoMoveDamageConfuse10) confusing, as a percentage (10%).
        /// </summary>
        public short PsybeamConfuseChance
        {
            get
            {
                if (f_psybeamConfuseChance)
                    return _psybeamConfuseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31784);
                _psybeamConfuseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_psybeamConfuseChance = true;
                return _psybeamConfuseChance;
            }
        }
        private bool f_dizzyPunchConfuseChance;
        private short _dizzyPunchConfuseChance;

        /// <summary>
        /// The chance of Dizzy Punch (and others, see DoMoveDamageConfuse30) confusing, as a percentage (30%).
        /// </summary>
        public short DizzyPunchConfuseChance
        {
            get
            {
                if (f_dizzyPunchConfuseChance)
                    return _dizzyPunchConfuseChance;
                long _pos = m_io.Pos;
                m_io.Seek(31456);
                _dizzyPunchConfuseChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_dizzyPunchConfuseChance = true;
                return _dizzyPunchConfuseChance;
            }
        }
        private bool f_spawnCooldown;
        private short _spawnCooldown;

        /// <summary>
        /// The number of turns between enemy spawns under normal conditions.
        /// </summary>
        public short SpawnCooldown
        {
            get
            {
                if (f_spawnCooldown)
                    return _spawnCooldown;
                long _pos = m_io.Pos;
                m_io.Seek(31348);
                _spawnCooldown = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_spawnCooldown = true;
                return _spawnCooldown;
            }
        }
        private bool f_typeAdvantageMasterCritRate;
        private short _typeAdvantageMasterCritRate;

        /// <summary>
        /// The flat critical hit rate with Type-Advantage Master, 40%.
        /// </summary>
        public short TypeAdvantageMasterCritRate
        {
            get
            {
                if (f_typeAdvantageMasterCritRate)
                    return _typeAdvantageMasterCritRate;
                long _pos = m_io.Pos;
                m_io.Seek(31608);
                _typeAdvantageMasterCritRate = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_typeAdvantageMasterCritRate = true;
                return _typeAdvantageMasterCritRate;
            }
        }
        private bool f_reversalDamageMultTable;
        private ReversalDamageMultTableArray _reversalDamageMultTable;

        /// <summary>
        /// Table of damage multipliers for Reversal/Flail at different HP ranges, where each entry is a binary fixed-point number with 8 fraction bits.
        /// 
        /// type: int[4]
        /// </summary>
        public ReversalDamageMultTableArray ReversalDamageMultTable
        {
            get
            {
                if (f_reversalDamageMultTable)
                    return _reversalDamageMultTable;
                long _pos = m_io.Pos;
                m_io.Seek(32556);
                _reversalDamageMultTable = new ReversalDamageMultTableArray(m_io);
                m_io.Seek(_pos);
                f_reversalDamageMultTable = true;
                return _reversalDamageMultTable;
            }
        }
        private bool f_metronomeTable;
        private MetronomeTableArray _metronomeTable;

        /// <summary>
        /// Something to do with the moves that Metronome can turn into.
        /// 
        /// type: struct wildcard_move_desc[168]
        /// </summary>
        public MetronomeTableArray MetronomeTable
        {
            get
            {
                if (f_metronomeTable)
                    return _metronomeTable;
                long _pos = m_io.Pos;
                m_io.Seek(37748);
                _metronomeTable = new MetronomeTableArray(m_io);
                m_io.Seek(_pos);
                f_metronomeTable = true;
                return _metronomeTable;
            }
        }
        private bool f_scopeLensCritRateBoost;
        private short _scopeLensCritRateBoost;

        /// <summary>
        /// The critical hit rate (additive) boost from the Scope Lens/Patsy Band items and the Sharpshooter IQ skill, 15%.
        /// </summary>
        public short ScopeLensCritRateBoost
        {
            get
            {
                if (f_scopeLensCritRateBoost)
                    return _scopeLensCritRateBoost;
                long _pos = m_io.Pos;
                m_io.Seek(31880);
                _scopeLensCritRateBoost = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_scopeLensCritRateBoost = true;
                return _scopeLensCritRateBoost;
            }
        }
        private bool f_solarbeamDamageMultiplier;
        private int _solarbeamDamageMultiplier;

        /// <summary>
        /// The default damage multiplier for SolarBeam, as a fixed-point number with 8 fraction bits (2).
        /// </summary>
        public int SolarbeamDamageMultiplier
        {
            get
            {
                if (f_solarbeamDamageMultiplier)
                    return _solarbeamDamageMultiplier;
                long _pos = m_io.Pos;
                m_io.Seek(32316);
                _solarbeamDamageMultiplier = m_io.ReadS4le();
                m_io.Seek(_pos);
                f_solarbeamDamageMultiplier = true;
                return _solarbeamDamageMultiplier;
            }
        }
        private bool f_iceFangFreezeChance;
        private short _iceFangFreezeChance;

        /// <summary>
        /// The chance of Ice Fang freezing, as a percentage (15%).
        /// </summary>
        public short IceFangFreezeChance
        {
            get
            {
                if (f_iceFangFreezeChance)
                    return _iceFangFreezeChance;
                long _pos = m_io.Pos;
                m_io.Seek(31408);
                _iceFangFreezeChance = m_io.ReadS2le();
                m_io.Seek(_pos);
                f_iceFangFreezeChance = true;
                return _iceFangFreezeChance;
            }
        }
        private Overlay10Data m_root;
        private KaitaiStruct m_parent;
        public Overlay10Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
