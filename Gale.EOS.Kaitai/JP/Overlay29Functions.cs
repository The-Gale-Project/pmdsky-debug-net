// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// List of functions within OVERLAY29 with relative address locations as their values.
    /// </summary>
    public partial class Overlay29Functions : KaitaiStruct
    {
        public static Overlay29Functions FromFile(string fileName)
        {
            return new Overlay29Functions(new KaitaiStream(fileName));
        }

        public Overlay29Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay29Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_shuffleSpawnPositions = false;
            f_resetInnerBoundaryTileRows = false;
            f_disableDungeonSubMenuOption = false;
            f_freeLoadedAttackSpriteAndMore = false;
            f_monsterHasImmobilizingStatus = false;
            f_tryRecruit = false;
            f_dealDamageProjectile = false;
            f_tryInflictPerishSongStatus = false;
            f_getAiUseItemProbability = false;
            f_determineMonsterShadow = false;
            f_canSeeTarget = false;
            f_monsterHasWhifferStatus = false;
            f_tryInflictMirrorMoveStatus = false;
            f_endMuzzledStatus = false;
            f_dungeonRandInt = false;
            f_applyPokemonTrapEffect = false;
            f_tryInflictPausedStatus = false;
            f_setMinimapDataE448 = false;
            f_displayDungeonTip = false;
            f_initWeirdMinimapMatrix = false;
            f_getDoughSeedFlag = false;
            f_isDungeonEndReasonFailure = false;
            f_applyDefensiveStatMultiplier = false;
            f_addDungeonSubMenuOption = false;
            f_tryInflictVitalThrowStatus = false;
            f_useSingleUseItemWrapper = false;
            f_incrementEntityPixelPosXy = false;
            f_initializeTile = false;
            f_endNegativeStatusConditionWrapper = false;
            f_yesNoMenu = false;
            f_populateActiveMonsterPtrs = false;
            f_tryInflictWrappedStatus = false;
            f_loadMonsterSpriteInner = false;
            f_getPersonalityIndex = false;
            f_shouldDisplayEntity = false;
            f_nearbyAllyIqSkillIsEnabled = false;
            f_loadFixedRoomData = false;
            f_applyRawstBerryEffect = false;
            f_createEnemyEntity = false;
            f_checkSpawnThreshold = false;
            f_isBlinded = false;
            f_setActionUseMovePlayer = false;
            f_useSingleUseItem = false;
            f_tryActivateConversion2 = false;
            f_boostSpeed = false;
            f_loadWeather3DFiles = false;
            f_applyViolentSeedEffect = false;
            f_getPossibleAiThrownItemDirections = false;
            f_applyProteinEffect = false;
            f_isRoomIlluminated = false;
            f_isMonsterSleeping = false;
            f_logMessageByIdQuiet = false;
            f_playMoveAnimation = false;
            f_applySummonTrapEffect = false;
            f_determineAllMonsterShadow = false;
            f_exclusiveItemOffenseBoost = false;
            f_executeMonsterAction = false;
            f_teamMemberHasEnabledIqSkill = false;
            f_activateMotorDrive = false;
            f_endFrozenStatus = false;
            f_playEffectAnimationEntity = false;
            f_applyGrudgeTrapEffect = false;
            f_aiDecideUseItem = false;
            f_setEntityPixelPosXy = false;
            f_resetFloor = false;
            f_spawnShopkeepers = false;
            f_stairsAlwaysReachable = false;
            f_placeFixedRoomTile = false;
            f_tryInflictDropeyeStatus = false;
            f_isSecretBazaarVeneer = false;
            f_setShouldBoostKecleonShopSpawnChance = false;
            f_ghostImmunityIsActive = false;
            f_tryTriggerMonsterHouse = false;
            f_tryInflictLongTossStatus = false;
            f_tryInflictCringeStatus = false;
            f_getDamageSourceWrapper = false;
            f_isOutlawOrChallengeRequestFloor = false;
            f_tryInflictSleeplessStatus = false;
            f_assignRooms = false;
            f_isLegendaryChallengeFloor = false;
            f_revealEnemies = false;
            f_trySealMove = false;
            f_addHeldItemToBag = false;
            f_setActionPassTurnOrWalk = false;
            f_endNegativeStatusCondition = false;
            f_shouldTryEatItem = false;
            f_isHyperBeamVariant = false;
            f_applyBlastSeedEffect = false;
            f_isMonsterIdInNormalRangeVeneer = false;
            f_isAiTargetEligible = false;
            f_tryTransform = false;
            f_flagHallwayJunctions = false;
            f_othersMenuLoop = false;
            f_tryActivateArtificialWeatherAbilities = false;
            f_endCringeClassStatus = false;
            f_changeMonsterAnimation = false;
            f_weightMoveWithIqSkills = false;
            f_levelUp = false;
            f_subInitMonster = false;
            f_decrementWindCounter = false;
            f_dealDamageWithType = false;
            f_getRandomExplorerMazeMonster = false;
            f_areLateGameTrapsEnabled = false;
            f_getLoadedAttackSpriteId = false;
            f_handleFloorCard = false;
            f_tryInflictInvisibleStatus = false;
            f_tryInflictWhifferStatus = false;
            f_tryInflictHealBlockStatus = false;
            f_applyGinsengEffect = false;
            f_freeTeamStatsWrapper = false;
            f_freeTopScreenStatus = false;
            f_teamMemberHasExclusiveItemEffectActive = false;
            f_shouldDisplayEntityWrapper = false;
            f_runDungeon = false;
            f_logMessageWithPopupCheckUser = false;
            f_safeguardIsActive = false;
            f_tryActivateSteadfast = false;
            f_resetDamageData = false;
            f_updateShouldBoostHiddenStairsSpawnChance = false;
            f_getEntityNaturalGiftInfo = false;
            f_endFrozenClassStatus = false;
            f_tryInflictSafeguardStatus = false;
            f_tryNonLeaderItemPickUp = false;
            f_logItemBlockedByEmbargo = false;
            f_tryBlowAway = false;
            f_createMonsterSummaryFromMonster = false;
            f_isChargingAnyTwoTurnMove = false;
            f_clearMonsterActionFields = false;
            f_getMonsterLevelToSpawn = false;
            f_displayItemTip = false;
            f_setShouldBoostHiddenStairsSpawnChance = false;
            f_deleteAllMonsterSpriteFiles = false;
            f_displayActions = false;
            f_displayMessage = false;
            f_tryGenerateUnownStoneDrop = false;
            f_runDungeonMode = false;
            f_isTargetInRange = false;
            f_buildMoveTargetList = false;
            f_canMonsterMoveInDirection = false;
            f_getItemToRetrieve = false;
            f_setHiddenStairsField = false;
            f_isMonsterMuzzled = false;
            f_tryInflictDecoyStatus = false;
            f_tryInflictTauntStatus = false;
            f_isFloating = false;
            f_endBurnClassStatus = false;
            f_getIdleAnimationId = false;
            f_runLeaderTurn = false;
            f_playEffectAnimation0x18E = false;
            f_tryActivateNondamagingDefenderAbility = false;
            f_generateRoomImperfections = false;
            f_swapMonsterWanFileIndex = false;
            f_resetHiddenStairsSpawn = false;
            f_updateShouldBoostKecleonShopSpawnChance = false;
            f_tryInflictBurnStatus = false;
            f_isFloorOver = false;
            f_canTargetEntity = false;
            f_spawnDroppedItem = false;
            f_checkActiveChallengeRequest = false;
            f_getMoveAnimationId = false;
            f_isHiddenStairsFloor = false;
            f_applyTripTrapEffect = false;
            f_isProtectedFromNegativeStatus = false;
            f_calcDamageFixedNoCategory = false;
            f_tryInflictWishStatus = false;
            f_applyHungerSeedEffect = false;
            f_tryIncreaseBelly = false;
            f_ensureConnectedGrid = false;
            f_getChebyshevDistance = false;
            f_dungeonGetSpriteIndex = false;
            f_trySwitchPlace = false;
            f_hiddenStairsPresent = false;
            f_pointCameraToMonster = false;
            f_getMonsterName = false;
            f_animationDelayOrSomething = false;
            f_shouldMinimapDisplayEntity = false;
            f_iqSkillIsEnabled = false;
            f_canAiUseMove = false;
            f_tryIncreaseHp = false;
            f_closeFixedBin = false;
            f_areTrawlOrbsAllowed = false;
            f_getItemToUse = false;
            f_displayFloorCard = false;
            f_spawnStairs = false;
            f_debugRecruitingEnabled = false;
            f_tryRestoreHp = false;
            f_isOnMonsterSpawnList = false;
            f_findUnoccupiedTileWithin3 = false;
            f_tryDecreaseLevel = false;
            f_dealDamageWithTypeAndPowerBoost = false;
            f_revealWholeFloor = false;
            f_setMissionTargetEnemyDefeated = false;
            f_trySpawnMonsterAndActivatePlusMinus = false;
            f_loadFixedRoom = false;
            f_shouldMonsterHeadToStairs = false;
            f_tryPounce = false;
            f_showPpRestoreEffect = false;
            f_positionHasItem = false;
            f_updateAiTargetPos = false;
            f_getMissionTargetEnemy = false;
            f_aiConsiderMove = false;
            f_getLeaderMonster = false;
            f_canMonsterUseItem = false;
            f_createRoomsAndAnchors = false;
            f_loadMissionMonsterSprites = false;
            f_recruitCheck = false;
            f_areLateGameTrapsEnabledWrapper = false;
            f_logMessageWithPopup = false;
            f_generateDungeonRngSeed = false;
            f_digitCount = false;
            f_applyCalciumEffect = false;
            f_setActionRegularAttack = false;
            f_twoTurnMoveForcedMiss = false;
            f_playEffectAnimationPos = false;
            f_tryInflictCrossEyedStatus = false;
            f_initDungeonGrid = false;
            f_unloadFixedRoomData = false;
            f_getFloorType = false;
            f_shouldDisplayEntityAdvanced = false;
            f_playEffectAnimation0x171 = false;
            f_applyIronEffect = false;
            f_isSecretBazaarNpcBehavior = false;
            f_isFullFloorFixedRoom = false;
            f_getItemToUseByIndex = false;
            f_tryInflictLeechSeedStatus = false;
            f_setDungeonRngPreseed = false;
            f_getOffensiveStatAtLevel = false;
            f_getLeader = false;
            f_isDestinationFloorWithMonster = false;
            f_lowerDefensiveStat = false;
            f_isProtectedFromStatDrops = false;
            f_generateFloor = false;
            f_getTileSafe = false;
            f_hideTileGrid = false;
            f_canSeeInvisibleMonsters = false;
            f_getApparentWeather = false;
            f_activateStench = false;
            f_getMatchingMonsterId = false;
            f_trySmashWall = false;
            f_resetDamageCalcDiagnostics = false;
            f_moveMonsterToPos = false;
            f_fixedRoomActionParamToDirection = false;
            f_applyGummiBoostsDungeonMode = false;
            f_countItemsOnFloorForAcuteSniffer = false;
            f_displayAnimatedNumbers = false;
            f_getEntityTouchscreenArea = false;
            f_shouldBoostHiddenStairsSpawnChance = false;
            f_evolveMonster = false;
            f_teamMemberHasItemActive = false;
            f_isDestinationFloor = false;
            f_advanceFrame = false;
            f_canAiMonsterMoveInDirection = false;
            f_logMessageByIdQuietCheckUserTarget = false;
            f_generateMonsterHouse = false;
            f_hasLowHealth = false;
            f_hasHeldItem = false;
            f_displayMessageInternal = false;
            f_endLeechSeedClassStatus = false;
            f_generateCrossroadsFloor = false;
            f_tryInflictMiracleEyeStatus = false;
            f_isProtectedFromSleepClassStatus = false;
            f_applyDamageAndEffects = false;
            f_playEffectAnimation0x29 = false;
            f_tryInflictMagnetRiseStatus = false;
            f_displayMessage2 = false;
            f_openFixedBin = false;
            f_clearHiddenStairs = false;
            f_dealDamage = false;
            f_shouldMonsterRunAwayAndShowEffect = false;
            f_applyMixElixirEffect = false;
            f_dungeonGetTotalSpriteFileSize = false;
            f_canHitWithRegularAttack = false;
            f_setBothScreensWindowColorToDefault = false;
            f_tryActivateIdentifyCondition = false;
            f_logMessageWithPopupCheckUserTarget = false;
            f_endInvisibleClassStatus = false;
            f_doMoveDamageInlined = false;
            f_tryInflictConfusedStatus = false;
            f_initPortraitDungeon = false;
            f_getHiddenStairsField = false;
            f_tryLeaderItemPickUp = false;
            f_sprintfStatic = false;
            f_convertWallsToChasms = false;
            f_areEntitiesAdjacent = false;
            f_getTreatmentBetweenMonsters = false;
            f_isCurrentFixedRoomBossFight = false;
            f_initMonster = false;
            f_boostOrLowerSpeed = false;
            f_playEffectAnimationPixelPos = false;
            f_endBlinkerClassStatus = false;
            f_isPositionInSight = false;
            f_revealStairs = false;
            f_specificRecruitCheck = false;
            f_endMagnetRiseStatus = false;
            f_drawTileGrid = false;
            f_activateSportCondition = false;
            f_clearLoadedAttackSprite = false;
            f_applyGravelyrockEffect = false;
            f_displayFloorTip = false;
            f_monsterHasNonvolatileNonsleepStatus = false;
            f_posIsOutOfBounds = false;
            f_loadMonsterSprite = false;
            f_trySpawnDoughSeedPoke = false;
            f_isChargingTwoTurnMove = false;
            f_initEnemySpawnStats = false;
            f_tryInflictNightmareStatus = false;
            f_scrappyShouldActivate = false;
            f_getWeatherColorTable = false;
            f_runMonsterAi = false;
            f_tryTriggerTrap = false;
            f_isDestinationFloorWithFixedRoom = false;
            f_drawMinimapTile = false;
            f_checkTeamItemsFlags = false;
            f_calcStatusDuration = false;
            f_othersMenu = false;
            f_storyRestrictionsEnabled = false;
            f_logMessageById = false;
            f_resetHitChanceStat = false;
            f_getGridPositions = false;
            f_isTacticSet = false;
            f_tryInflictSnatchStatus = false;
            f_tryInflictStockpileStatus = false;
            f_getKecleonIdToSpawnByFloor = false;
            f_getMaxPpWrapper = false;
            f_getRandomTile = false;
            f_applyGrimyFoodEffect = false;
            f_tryActivateIqBooster = false;
            f_spawnTeam = false;
            f_tryInflictCoweringStatus = false;
            f_dungeonRandOutcomeUserTargetInteraction = false;
            f_trySpawnTrap = false;
            f_tryPointCameraToMonster = false;
            f_hasTypeAffectedByGravity = false;
            f_tryActivateWeather = false;
            f_teamLeaderIqSkillIsEnabled = false;
            f_tryInflictSetDamageStatus = false;
            f_monsterHasEmbargoStatus = false;
            f_getTargetMonsterNotFoundFlag = false;
            f_createGridCellConnections = false;
            f_tryActivateQuickFeet = false;
            f_getDungeonRngPreseed = false;
            f_areTileJumpsAllowed = false;
            f_mergeRoomsVertically = false;
            f_doesProjectileHitTarget = false;
            f_checkVariousStatuses = false;
            f_spawnItem = false;
            f_generateCleanItem = false;
            f_tryDrought = false;
            f_removeEmptyItemsInBagWrapper = false;
            f_statusCheckerCheck = false;
            f_boostHitChanceStat = false;
            f_setDungeonRngPreseed23Bit = false;
            f_canAttackInDirection = false;
            f_handleFadesDungeon = false;
            f_tryActivateTraceAndColorChange = false;
            f_hasDropeyeStatus = false;
            f_isDestinationFloorWithHiddenOutlaw = false;
            f_cannotStandOnTile = false;
            f_shouldMonsterFollowLeader = false;
            f_tryInflictEmbargoStatus = false;
            f_tryInflictEyedropStatus = false;
            f_spawnEnemyTrapAtPos = false;
            f_generateExtraHallways = false;
            f_flashLeaderIcon = false;
            f_mistIsActive = false;
            f_getDefaultTileTextureId = false;
            f_tryInflictSlipStatus = false;
            f_canMonsterMoveOrSwapWithAllyInDirection = false;
            f_renderWeather3D = false;
            f_getNumberOfAttacks = false;
            f_getItemToDeliver = false;
            f_dungeonFree = false;
            f_generateLineFloor = false;
            f_generateOuterRoomsFloor = false;
            f_positionIsOnHiddenStairs = false;
            f_calcDamageFixedWrapper = false;
            f_getPlayerGender = false;
            f_missionTargetEnemyIsDefeated = false;
            f_isNormalFloor = false;
            f_tryInflictMistStatus = false;
            f_getMonsterApparentId = false;
            f_applyTrapEffect = false;
            f_findClosestUnoccupiedTileWithin2 = false;
            f_leafGuardIsActive = false;
            f_getScenarioBalanceVeneer = false;
            f_exclusiveItemDefenseBoost = false;
            f_moveHitCheck = false;
            f_updateStatusIconFlags = false;
            f_getRandomSpawnMonsterId = false;
            f_monsterHasLeechSeedStatus = false;
            f_boostSpeedOneStage = false;
            f_isOutlawMonsterHouseFloor = false;
            f_bindTrapToTile = false;
            f_substitutePlaceholderStringTags = false;
            f_updateTrapsVisibility = false;
            f_floorNumberIsEven = false;
            f_generateCrossFloor = false;
            f_tryInflictLightScreenStatus = false;
            f_generateItemExplicit = false;
            f_tryInflictAquaRingStatus = false;
            f_getStairsRoom = false;
            f_tryInflictFrozenStatus = false;
            f_revealItems = false;
            f_shouldBoostKecleonShopSpawnChance = false;
            f_fillMissionDestinationInfo = false;
            f_isJirachiChallengeFloor = false;
            f_applyKeyEffect = false;
            f_generateTwoRoomsWithMonsterHouseFloor = false;
            f_setHiddenFloorField = false;
            f_setAndLoadCurrentAttackAnimation = false;
            f_tryInflictCurseStatus = false;
            f_openMenu = false;
            f_getItemIdToSpawn = false;
            f_activateFlashFire = false;
            f_trySpawnEnemyItemDrop = false;
            f_updateStateFlags = false;
            f_setMonsterTypeAndAbility = false;
            f_getDirectionTowardsPosition = false;
            f_setMinimapDataE447 = false;
            f_applyGonePebbleEffect = false;
            f_hasSuperEffectiveMoveAgainstUser = false;
            f_getTileAtEntity = false;
            f_markEnemySpawns = false;
            f_addExpSpecial = false;
            f_tryInflictEncoreStatus = false;
            f_applyAquaRingHealing = false;
            f_setActionStruggle = false;
            f_lowerHitChanceStat = false;
            f_exclusiveItemEffectIsActiveWithLogging = false;
            f_applyOffensiveStatMultiplier = false;
            f_isCurrentMissionTypeExact = false;
            f_isGoldenChamber = false;
            f_tickNoSlipCap = false;
            f_tryInflictExposedStatus = false;
            f_resetImportantSpawnPositions = false;
            f_handleFadesDungeonBothScreens = false;
            f_getDungeonPtrMaster = false;
            f_initTeamMember = false;
            f_lowerSshort = false;
            f_areMovesEnabled = false;
            f_tryInflictDestinyBondStatus = false;
            f_fixedRoomIsSubstituteRoom = false;
            f_isInSpawnList = false;
            f_monsterHasAttackInterferingStatus = false;
            f_getVisibilityRange = false;
            f_applyViaSeedEffect = false;
            f_checkVariousStatuses2 = false;
            f_getMobilityTypeCheckSlip = false;
            f_applyPpZeroTrapEffect = false;
            f_changeDungeonMusic = false;
            f_updateIqSkills = false;
            f_hiddenStairsTrigger = false;
            f_isInvalidSpawnTile = false;
            f_applyGracideaEffect = false;
            f_tryActivateSlowStart = false;
            f_tickStatusTurnCounter = false;
            f_applyDamage = false;
            f_determineAllTilesWalkableNeighbors = false;
            f_otherMonsterAbilityIsActive = false;
            f_getMobilityTypeCheckSlipAndFloating = false;
            f_dungeonAlloc = false;
            f_findFarthestUnoccupiedTileWithin2 = false;
            f_tryInflictYawningStatus = false;
            f_updateEntityPixelPos = false;
            f_markNonEnemySpawns = false;
            f_updateShopkeeperModeAfterAttack = false;
            f_playQuestionMarkEffect = false;
            f_markShopkeeperSpawn = false;
            f_tryInflictMuzzledStatus = false;
            f_tryInflictInfatuatedStatus = false;
            f_initializeTeamStats = false;
            f_tryInflictReflectStatus = false;
            f_updateShopkeeperModeAfterTrap = false;
            f_calcRecoilDamageFixed = false;
            f_isBossFight = false;
            f_endSureShotClassStatus = false;
            f_removeUsedItem = false;
            f_trySpawnTrapperTrap = false;
            f_runFractionalTurn = false;
            f_abilityIsActive = false;
            f_getEntityWeatherBallType = false;
            f_applyGrimyTrapEffect = false;
            f_shouldMonsterRunAway = false;
            f_tryInflictPetrifiedStatus = false;
            f_getHiddenFloorField = false;
            f_lowerSpeed = false;
            f_generateAndSpawnItem = false;
            f_tryInflictSleepStatus = false;
            f_isMonsterVisuallyImpaired = false;
            f_getSpecialTargetItem = false;
            f_getForcedLossReason = false;
            f_freeOtherWrappedMonsters = false;
            f_setTargetMonsterNotFoundFlag = false;
            f_freeTopScreen = false;
            f_getPossibleAiArcItemTargets = false;
            f_loadFixedRoomDataVeneer = false;
            f_calcTypeBasedDamageEffects = false;
            f_monsterCanThrowItems = false;
            f_isMarowakTrainingMaze = false;
            f_getFinalKecleonShopSpawnChance = false;
            f_checkTeamMemberIdxVeneer = false;
            f_generateMaze = false;
            f_isSecretFloor = false;
            f_applyMudTrapEffect = false;
            f_getNextFixedRoomAction = false;
            f_generateMazeLine = false;
            f_tryInflictPierceStatus = false;
            f_generateMissionEggMonster = false;
            f_ensureImpassableTilesAreWalls = false;
            f_flashFireShouldActivate = false;
            f_spawnItemEntity = false;
            f_musicTableIdxToMusicId = false;
            f_tryInflictBlinkerStatus = false;
            f_displayUi = false;
            f_setActionUseMoveAi = false;
            f_endCurseClassStatus = false;
            f_tryDecreaseBelly = false;
            f_spawnInitialMonsters = false;
            f_tickStatusAndHealthRegen = false;
            f_boostIq = false;
            f_tryInflictFocusEnergyStatus = false;
            f_joinedAtRangeCheck2Veneer = false;
            f_dungeonRand100 = false;
            f_getMoveTypeForMonster = false;
            f_dungeonModeSetupAndShowNameKeyboard = false;
            f_tryInflictMirrorCoatStatus = false;
            f_getMaxHpAtLevel = false;
            f_endSleepClassStatus = false;
            f_boostOffensiveStat = false;
            f_isMonsterCornered = false;
            f_removeGroundItem = false;
            f_tryInflictGrudgeStatus = false;
            f_isSpecialStoryAlly = false;
            f_displayRunAwayIfTriggered = false;
            f_tryInflictTerrifiedStatus = false;
            f_logMessageByIdWithPopupCheckUser = false;
            f_tryActivateGravity = false;
            f_isExperienceLocked = false;
            f_applyDamageAndEffectsWrapper = false;
            f_resolveInvalidSpawns = false;
            f_tryWarp = false;
            f_isTypeIneffectiveAgainstGhost = false;
            f_setDoughSeedFlag = false;
            f_shouldLeaderKeepRunning = false;
            f_getMovePower = false;
            f_mirrorMoveIsActive = false;
            f_spawnDroppedItemWrapper = false;
            f_getStairsSpawnPosition = false;
            f_openMessageLog = false;
            f_areOrbsAllowed = false;
            f_deleteMonsterSpriteFile = false;
            f_enemyEvolution = false;
            f_monsterIsType = false;
            f_countMovesOutOfPp = false;
            f_tryInflictMobileStatus = false;
            f_spawnTrap = false;
            f_generateMoneyQuantity = false;
            f_handleFaint = false;
            f_initDungeonRng = false;
            f_applyPechaBerryEffect = false;
            f_prepareTrapperTrap = false;
            f_setSpawnFlag5 = false;
            f_tryExplosion = false;
            f_conversion2IsActive = false;
            f_fadeToBlack = false;
            f_applyStickyTrapEffect = false;
            f_applyDoughSeedEffect = false;
            f_levitateIsActive = false;
            f_determineTileWalkableNeighbors = false;
            f_isMonsterDrowsy = false;
            f_dungeonRandOutcomeUserAction = false;
            f_getExclusiveItemWithEffectFromBag = false;
            f_executeMoveEffect = false;
            f_playEffectAnimation0x171Full = false;
            f_getLeaderAction = false;
            f_tryInflictShadowHoldStatus = false;
            f_getEntityMoveTargetAndRange = false;
            f_generateMazeRoom = false;
            f_performDamageSequence = false;
            f_levelUpItemEffect = false;
            f_tryInflictBadlyPoisonedStatus = false;
            f_isDestinationFloorWithFleeingOutlaw = false;
            f_applyVileSeedEffect = false;
            f_loadTextureUi = false;
            f_checkNonLeaderTile = false;
            f_positionHasMonster = false;
            f_inflictSleepStatusSingle = false;
            f_restoreOneMovePp = false;
            f_shouldRunMonsterAi = false;
            f_mewSpawnCheck = false;
            f_trySpawnMonsterAndTickSpawnCounter = false;
            f_getTeamMemberIndex = false;
            f_generateOneRoomMonsterHouseFloor = false;
            f_isAdjacentToEnemy = false;
            f_lowerOffensiveStat = false;
            f_shouldUsePp = false;
            f_tryActivateFlashFireOnAllMonsters = false;
            f_getItemInfo = false;
            f_initOtherMonsterData = false;
            f_dungeonRngSetPrimary = false;
            f_applyRandomTrapEffect = false;
            f_tryAddTargetToAiTargetList = false;
            f_tryRemoveTrap = false;
            f_tryInflictSureShotStatus = false;
            f_tryInflictProtectStatus = false;
            f_getTypeMatchupBothTypes = false;
            f_getOutlawSpawnData = false;
            f_isNotFullFloorFixedRoom = false;
            f_categoryIsNotPhysical = false;
            f_getTile = false;
            f_getTrapInfo = false;
            f_applyZincEffect = false;
            f_logMessageQuiet = false;
            f_tryEatItem = false;
            f_getItemAction = false;
            f_tryInflictMagicCoatStatus = false;
            f_dungeonRandRange = false;
            f_generateBeetleFloor = false;
            f_boostDefensiveStat = false;
            f_updateMovePp = false;
            f_endReflectClassStatus = false;
            f_dungeonRngUnsetSecondary = false;
            f_tryInflictLuckyChantStatus = false;
            f_calcSpeedStage = false;
            f_initEnemyStatsAndMoves = false;
            f_discoverMinimap = false;
            f_isWaterTileset = false;
            f_getDefensiveStatAtLevel = false;
            f_tryForcedLoss = false;
            f_setMonsterActionFields = false;
            f_tryInflictConstrictionStatus = false;
            f_changeLeader = false;
            f_targetRegularAttack = false;
            f_logMessageByIdWithPopupCheckParticipants = false;
            f_getMonsterIdToSpawn = false;
            f_setAquaRingHealingCountdownTo4 = false;
            f_spawnMonster = false;
            f_tryInflictIngrainStatus = false;
            f_allocTopScreenStatus = false;
            f_createHallway = false;
            f_tryEndStatusWithAbility = false;
            f_generateStandardItem = false;
            f_tryInflictEndureStatus = false;
            f_calcDamage = false;
            f_generateStandardFloor = false;
            f_setLeaderAction = false;
            f_startFadeDungeonWrapper = false;
            f_calcSpeedStageWrapper = false;
            f_reevaluateSnatchMonster = false;
            f_getMoveRangeDistance = false;
            f_trySpawnGoldenChamber = false;
            f_setTerrainObstacleChecked = false;
            f_getMissionDestination = false;
            f_useThrowableItem = false;
            f_setForcedLossReason = false;
            f_endMiracleEyeStatus = false;
            f_convertSecondaryTerrainToChasms = false;
            f_isCurrentMissionType = false;
            f_generateKecleonShop = false;
            f_assignTopScreenHandlers = false;
            f_endProtectStatus = false;
            f_updateCamera = false;
            f_tryActivateFrisk = false;
            f_gravityIsActive = false;
            f_tryInflictPoisonedStatus = false;
            f_findNearbyUnoccupiedTile = false;
            f_ensureCanStandCurrentTile = false;
            f_restoreRandomMovePp = false;
            f_tryActivateBadDreams = false;
            f_restorePpAllMovesSetFlags = false;
            f_playEffectAnimationEntityStandard = false;
            f_canTargetPosition = false;
            f_loadMappaFileAttributes = false;
            f_resetAiCanAttackInDirection = false;
            f_isTypeAffectedByGravity = false;
            f_aftermathCheck = false;
            f_finalizeJunctions = false;
            f_getMonsterMoves = false;
            f_transferNegativeStatusCondition = false;
            f_logMessage = false;
            f_assignGridCellConnections = false;
            f_dungeonRngSetSecondary = false;
            f_setLeaderActionFields = false;
            f_generateFixedRoom = false;
            f_setSecondaryTerrainOnWall = false;
            f_moveIsNotPhysical = false;
            f_isSecretBazaar = false;
            f_updateMinimap = false;
            f_restoreAllMovePp = false;
            f_areOrbsAllowedVeneer = false;
            f_checkTouchscreenArea = false;
            f_monsterHasMiracleEyeStatus = false;
            f_checkVariousConditions = false;
            f_tryAftermathExplosion = false;
            f_abilityIsActiveVeneer = false;
            f_getMissionEnemyMinionGroup = false;
            f_tryInflictConversion2Status = false;
            f_updateTeamStatsWrapper = false;
            f_revealTrapsNearby = false;
            f_logMessageByIdWithPopup = false;
            f_isSecretRoom = false;
            f_tryWeatherFormChange = false;
            f_startFadeDungeon = false;
            f_copySpawnEntriesMaster = false;
            f_logMessageByIdWithPopupCheckUserUnknown = false;
            f_handleTopScreenFades = false;
            f_displayNumberTextureUi = false;
            f_checkLeaderTile = false;
            f_monsterHasNegativeStatus = false;
            f_tryRestoreRoostTyping = false;
            f_changeShayminForme = false;
            f_isNextToHallway = false;
            f_resetGravity = false;
            f_monsterHasSkillInterferingStatus = false;
            f_getMinimapData = false;
            f_dungeonRand16Bit = false;
            f_applyStealthRockTrapEffect = false;
            f_tryActivateNondamagingDefenderExclusiveItem = false;
            f_hasStatusThatPreventsActing = false;
            f_tryRemoveSnatchedMonsterFromDungeonStruct = false;
            f_tryInflictNappingStatus = false;
            f_floorHasMissionMonster = false;
            f_tryInflictGastroAcidStatus = false;
            f_getTypeMatchup = false;
            f_auraBowIsActive = false;
            f_storeSpriteFileIndexBothGenders = false;
            f_generateSecondaryTerrainFormations = false;
            f_tryResetStatChanges = false;
            f_positionIsOnStairs = false;
            f_getTileTerrain = false;
            f_isDestinationFloorWithItem = false;
            f_tryInflictParalysisStatus = false;
            f_isCurrentTilesetBackground = false;
            f_isPositionActuallyInSight = false;
            f_displayCharTextureUi = false;
            f_tryActivateTruant = false;
            f_getTeamMemberWithIqSkill = false;
            f_applyCheriBerryEffect = false;
            f_generateSecondaryStructures = false;
            f_hasMaxGinsengBoost99 = false;
            f_applyPitfallTrapEffect = false;
            f_getHiddenStairsType = false;
            f_noGastroAcidStatus = false;
            f_monsterSpawnListPartialCopy = false;
            f_transferNegativeBlinkerClassStatus = false;
            f_tryInflictBurnStatusWholeTeam = false;
            f_getCurrentHiddenStairsType = false;
            f_calcDamageFixed = false;
            f_canMonsterUseMove = false;
            f_monsterCannotAttack = false;
            f_applyItemEffect = false;
            f_logMessageByIdWithPopupCheckUserTarget = false;
            f_generateOuterRingFloor = false;
            f_initMinimapDisplayTile = false;
            f_dungeonZInit = false;
            f_generateItem = false;
            f_shouldMovePlayAlternativeAnimation = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_shuffleSpawnPositions;
        private int _shuffleSpawnPositions;

        /// <summary>
        /// Randomly shuffle an array of spawn positions.
        /// 
        /// r0: spawn position array containing bytes {x1, y1, x2, y2, ...}
        /// r1: number of (x, y) pairs in the spawn position array
        /// </summary>
        public int ShuffleSpawnPositions
        {
            get
            {
                if (f_shuffleSpawnPositions)
                    return _shuffleSpawnPositions;
                _shuffleSpawnPositions = (int) (411588);
                f_shuffleSpawnPositions = true;
                return _shuffleSpawnPositions;
            }
        }
        private bool f_resetInnerBoundaryTileRows;
        private int _resetInnerBoundaryTileRows;

        /// <summary>
        /// Reset the inner boundary tile rows (y == 1 and y == 30) to their initial state of all wall tiles, with impassable walls at the edges (x == 0 and x == 55).
        /// 
        /// No params.
        /// </summary>
        public int ResetInnerBoundaryTileRows
        {
            get
            {
                if (f_resetInnerBoundaryTileRows)
                    return _resetInnerBoundaryTileRows;
                _resetInnerBoundaryTileRows = (int) (419420);
                f_resetInnerBoundaryTileRows = true;
                return _resetInnerBoundaryTileRows;
            }
        }
        private bool f_disableDungeonSubMenuOption;
        private int _disableDungeonSubMenuOption;

        /// <summary>
        /// Disables an option that was addeed to a dungeon sub-menu.
        /// 
        /// r0: Action ID of the option that should be disabled
        /// </summary>
        public int DisableDungeonSubMenuOption
        {
            get
            {
                if (f_disableDungeonSubMenuOption)
                    return _disableDungeonSubMenuOption;
                _disableDungeonSubMenuOption = (int) (63100);
                f_disableDungeonSubMenuOption = true;
                return _disableDungeonSubMenuOption;
            }
        }
        private bool f_freeLoadedAttackSpriteAndMore;
        private int _freeLoadedAttackSpriteAndMore;

        /// <summary>
        /// Among other things, free another data structure in the attack sprite storage area/data
        /// 
        /// No params.
        /// </summary>
        public int FreeLoadedAttackSpriteAndMore
        {
            get
            {
                if (f_freeLoadedAttackSpriteAndMore)
                    return _freeLoadedAttackSpriteAndMore;
                _freeLoadedAttackSpriteAndMore = (int) (109564);
                f_freeLoadedAttackSpriteAndMore = true;
                return _freeLoadedAttackSpriteAndMore;
            }
        }
        private bool f_monsterHasImmobilizingStatus;
        private int _monsterHasImmobilizingStatus;

        /// <summary>
        /// Checks if a monster has one of the non-self-inflicted statuses in the &quot;freeze&quot; group, which includes status conditions that immobilize the monster: STATUS_FROZEN, STATUS_SHADOW_HOLD, STATUS_WRAPPED, STATUS_PETRIFIED, STATUS_CONSTRICTION, and STATUS_FAMISHED.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasImmobilizingStatus
        {
            get
            {
                if (f_monsterHasImmobilizingStatus)
                    return _monsterHasImmobilizingStatus;
                _monsterHasImmobilizingStatus = (int) (147460);
                f_monsterHasImmobilizingStatus = true;
                return _monsterHasImmobilizingStatus;
            }
        }
        private bool f_tryRecruit;
        private int _tryRecruit;

        /// <summary>
        /// Asks the player if they would like to recruit the enemy that was just defeated and handles the recruitment if they accept.
        /// 
        /// r0: user entity pointer
        /// r1: monster to recruit entity pointer
        /// return: True if the monster was recruited, false if it wasn't
        /// </summary>
        public int TryRecruit
        {
            get
            {
                if (f_tryRecruit)
                    return _tryRecruit;
                _tryRecruit = (int) (203972);
                f_tryRecruit = true;
                return _tryRecruit;
            }
        }
        private bool f_dealDamageProjectile;
        private int _dealDamageProjectile;

        /// <summary>
        /// Deals damage from a variable-damage projectile.
        /// 
        /// r0: entity pointer 1?
        /// r1: entity pointer 2?
        /// r2: move pointer
        /// r3: move power
        /// stack[0]: damage multiplier (as a binary fixed-point number with 8 fraction bits)
        /// stack[1]: item ID of the projectile
        /// return: Calculated damage
        /// </summary>
        public int DealDamageProjectile
        {
            get
            {
                if (f_dealDamageProjectile)
                    return _dealDamageProjectile;
                _dealDamageProjectile = (int) (354140);
                f_dealDamageProjectile = true;
                return _dealDamageProjectile;
            }
        }
        private bool f_tryInflictPerishSongStatus;
        private int _tryInflictPerishSongStatus;

        /// <summary>
        /// Inflicts the Perish Song status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictPerishSongStatus
        {
            get
            {
                if (f_tryInflictPerishSongStatus)
                    return _tryInflictPerishSongStatus;
                _tryInflictPerishSongStatus = (int) (238112);
                f_tryInflictPerishSongStatus = true;
                return _tryInflictPerishSongStatus;
            }
        }
        private bool f_getAiUseItemProbability;
        private int _getAiUseItemProbability;

        /// <summary>
        /// Called to get the probability of an item being used or thrown by an AI on the current turn.
        /// 
        /// r0: Pointer to either the user if it is an item used by the AI or the target if it is an item thrown by the AI
        /// r1: Pointer to item
        /// r2: Size-2 bitvector: if bit 0 is set, the AI is throwing the item. If bit 1 is set, it is targeting an ally with the item.
        /// return: Integer in range [0, 100]
        /// </summary>
        public int GetAiUseItemProbability
        {
            get
            {
                if (f_getAiUseItemProbability)
                    return _getAiUseItemProbability;
                _getAiUseItemProbability = (int) (269352);
                f_getAiUseItemProbability = true;
                return _getAiUseItemProbability;
            }
        }
        private bool f_determineMonsterShadow;
        private int _determineMonsterShadow;

        /// <summary>
        /// Changes the monster's shadow to be appropriate for its size and the tile it's standing on.
        /// If the tile is a floor and it's a water tileset, it changes the monster to use the water
        /// shadows. If the tile is secondary terrain and secondary terrain is water, it also uses the
        /// water shadows. If the tile is a chasm, it changes nothing and returns 6. Otherwise, use
        /// the default land shadow.
        /// 
        /// r0: monster entity pointer
        /// return: the type of shadow used?
        /// </summary>
        public int DetermineMonsterShadow
        {
            get
            {
                if (f_determineMonsterShadow)
                    return _determineMonsterShadow;
                _determineMonsterShadow = (int) (165916);
                f_determineMonsterShadow = true;
                return _determineMonsterShadow;
            }
        }
        private bool f_canSeeTarget;
        private int _canSeeTarget;

        /// <summary>
        /// Checks if a given monster can see another monster.
        /// 
        /// Calls IsPositionActuallyInSight. Also checks if the user is blinded, if the target is invisible, etc.
        /// This function is almost the same as CanTargetEntity, the only difference is that the latter calls IsPositionInSight instead.
        /// 
        /// r0: User entity pointer
        /// r1: Target entity pointer
        /// return: True if the user can see the target, false otherwise
        /// </summary>
        public int CanSeeTarget
        {
            get
            {
                if (f_canSeeTarget)
                    return _canSeeTarget;
                _canSeeTarget = (int) (25856);
                f_canSeeTarget = true;
                return _canSeeTarget;
            }
        }
        private bool f_monsterHasWhifferStatus;
        private int _monsterHasWhifferStatus;

        /// <summary>
        /// Checks if a monster has the whiffer status.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasWhifferStatus
        {
            get
            {
                if (f_monsterHasWhifferStatus)
                    return _monsterHasWhifferStatus;
                _monsterHasWhifferStatus = (int) (147624);
                f_monsterHasWhifferStatus = true;
                return _monsterHasWhifferStatus;
            }
        }
        private bool f_tryInflictMirrorMoveStatus;
        private int _tryInflictMirrorMoveStatus;

        /// <summary>
        /// Inflicts the Mirror Move status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictMirrorMoveStatus
        {
            get
            {
                if (f_tryInflictMirrorMoveStatus)
                    return _tryInflictMirrorMoveStatus;
                _tryInflictMirrorMoveStatus = (int) (249864);
                f_tryInflictMirrorMoveStatus = true;
                return _tryInflictMirrorMoveStatus;
            }
        }
        private bool f_endMuzzledStatus;
        private int _endMuzzledStatus;

        /// <summary>
        /// Removes the target's muzzled status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndMuzzledStatus
        {
            get
            {
                if (f_endMuzzledStatus)
                    return _endMuzzledStatus;
                _endMuzzledStatus = (int) (174152);
                f_endMuzzledStatus = true;
                return _endMuzzledStatus;
            }
        }
        private bool f_dungeonRandInt;
        private int _dungeonRandInt;

        /// <summary>
        /// Compute a pseudorandom integer under a given maximum value using the dungeon PRNG.
        /// 
        /// r0: high
        /// return: pseudorandom integer on the interval [0, high - 1]
        /// </summary>
        public int DungeonRandInt
        {
            get
            {
                if (f_dungeonRandInt)
                    return _dungeonRandInt;
                _dungeonRandInt = (int) (59424);
                f_dungeonRandInt = true;
                return _dungeonRandInt;
            }
        }
        private bool f_applyPokemonTrapEffect;
        private int _applyPokemonTrapEffect;

        /// <summary>
        /// Turns item in the same room as the tile at the position (usually just the entities's
        /// position) into monsters. If the position is in a hallway, convert items in a 3x3 area
        /// centered on the position into monsters.
        /// 
        /// r0: entity pointer
        /// r1: position
        /// </summary>
        public int ApplyPokemonTrapEffect
        {
            get
            {
                if (f_applyPokemonTrapEffect)
                    return _applyPokemonTrapEffect;
                _applyPokemonTrapEffect = (int) (75916);
                f_applyPokemonTrapEffect = true;
                return _applyPokemonTrapEffect;
            }
        }
        private bool f_tryInflictPausedStatus;
        private int _tryInflictPausedStatus;

        /// <summary>
        /// Inflicts the Paused status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: ?
        /// r3: number of turns
        /// stack[0]: flag to log a message on failure
        /// stack[1]: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictPausedStatus
        {
            get
            {
                if (f_tryInflictPausedStatus)
                    return _tryInflictPausedStatus;
                _tryInflictPausedStatus = (int) (220304);
                f_tryInflictPausedStatus = true;
                return _tryInflictPausedStatus;
            }
        }
        private bool f_setMinimapDataE448;
        private int _setMinimapDataE448;

        /// <summary>
        /// Sets minimap_display_data::field_0xE448 to the specified value
        /// 
        /// r0: Value to set the field to
        /// </summary>
        public int SetMinimapDataE448
        {
            get
            {
                if (f_setMinimapDataE448)
                    return _setMinimapDataE448;
                _setMinimapDataE448 = (int) (384276);
                f_setMinimapDataE448 = true;
                return _setMinimapDataE448;
            }
        }
        private bool f_displayDungeonTip;
        private int _displayDungeonTip;

        /// <summary>
        /// Checks if a given dungeon tip should be displayed at the start of a floor and if so, displays it. Called up to 4 times at the start of each new floor, with a different r0 parameter each time.
        /// 
        /// r0: Pointer to the message_tip struct of the message that should be displayed
        /// r1: True to log the message in the message log
        /// 
        /// return: 1 if the message has been displayed, 0 if it wasn’t
        /// </summary>
        public int DisplayDungeonTip
        {
            get
            {
                if (f_displayDungeonTip)
                    return _displayDungeonTip;
                _displayDungeonTip = (int) (460916);
                f_displayDungeonTip = true;
                return _displayDungeonTip;
            }
        }
        private bool f_initWeirdMinimapMatrix;
        private int _initWeirdMinimapMatrix;

        /// <summary>
        /// Initializes the matrix at minimap_display_data+0xE000. Seems to overflow said matrix when doing so.
        /// 
        /// No params.
        /// </summary>
        public int InitWeirdMinimapMatrix
        {
            get
            {
                if (f_initWeirdMinimapMatrix)
                    return _initWeirdMinimapMatrix;
                _initWeirdMinimapMatrix = (int) (384372);
                f_initWeirdMinimapMatrix = true;
                return _initWeirdMinimapMatrix;
            }
        }
        private bool f_getDoughSeedFlag;
        private int _getDoughSeedFlag;

        /// <summary>
        /// Gets the dough_seed_extra_money_flag field on the dungeon struct.
        /// 
        /// return: bool
        /// </summary>
        public int GetDoughSeedFlag
        {
            get
            {
                if (f_getDoughSeedFlag)
                    return _getDoughSeedFlag;
                _getDoughSeedFlag = (int) (376852);
                f_getDoughSeedFlag = true;
                return _getDoughSeedFlag;
            }
        }
        private bool f_isDungeonEndReasonFailure;
        private int _isDungeonEndReasonFailure;

        /// <summary>
        /// Checks if the damage_source of the dungeon ending is because of a failure to complete the dungeon.
        /// Specifically checks fainted_monster_dungeon_end_reason to be less than DAMAGE_SOURCE_ESCAPE.
        /// 
        /// return: bool
        /// </summary>
        public int IsDungeonEndReasonFailure
        {
            get
            {
                if (f_isDungeonEndReasonFailure)
                    return _isDungeonEndReasonFailure;
                _isDungeonEndReasonFailure = (int) (68808);
                f_isDungeonEndReasonFailure = true;
                return _isDungeonEndReasonFailure;
            }
        }
        private bool f_applyDefensiveStatMultiplier;
        private int _applyDefensiveStatMultiplier;

        /// <summary>
        /// Applies a multiplier to the specified defensive stat on the target monster.
        /// 
        /// This affects struct monster_stat_modifiers::defensive_multipliers, for moves like Screech.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: multiplier
        /// stack[0]: ?
        /// </summary>
        public int ApplyDefensiveStatMultiplier
        {
            get
            {
                if (f_applyDefensiveStatMultiplier)
                    return _applyDefensiveStatMultiplier;
                _applyDefensiveStatMultiplier = (int) (228196);
                f_applyDefensiveStatMultiplier = true;
                return _applyDefensiveStatMultiplier;
            }
        }
        private bool f_addDungeonSubMenuOption;
        private int _addDungeonSubMenuOption;

        /// <summary>
        /// Adds an option to the list of actions that can be taken on a pokémon, item or move to the currently active sub-menu on dungeon mode (team, moves, items, etc.).
        /// 
        /// r0: Action ID
        /// r1: True if the option should be enabled, false otherwise
        /// </summary>
        public int AddDungeonSubMenuOption
        {
            get
            {
                if (f_addDungeonSubMenuOption)
                    return _addDungeonSubMenuOption;
                _addDungeonSubMenuOption = (int) (62884);
                f_addDungeonSubMenuOption = true;
                return _addDungeonSubMenuOption;
            }
        }
        private bool f_tryInflictVitalThrowStatus;
        private int _tryInflictVitalThrowStatus;

        /// <summary>
        /// Inflicts the Vital Throw status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictVitalThrowStatus
        {
            get
            {
                if (f_tryInflictVitalThrowStatus)
                    return _tryInflictVitalThrowStatus;
                _tryInflictVitalThrowStatus = (int) (250228);
                f_tryInflictVitalThrowStatus = true;
                return _tryInflictVitalThrowStatus;
            }
        }
        private bool f_useSingleUseItemWrapper;
        private int _useSingleUseItemWrapper;

        /// <summary>
        /// Same as UseSingleUseItem, but the second parameter is determined automatically from monster::action_data::action_parameter[1]::action_use_idx.
        /// 
        /// r0: User
        /// </summary>
        public int UseSingleUseItemWrapper
        {
            get
            {
                if (f_useSingleUseItemWrapper)
                    return _useSingleUseItemWrapper;
                _useSingleUseItemWrapper = (int) (102372);
                f_useSingleUseItemWrapper = true;
                return _useSingleUseItemWrapper;
            }
        }
        private bool f_incrementEntityPixelPosXy;
        private int _incrementEntityPixelPosXy;

        /// <summary>
        /// r0: Entity pointer
        /// r1: x
        /// r2: y
        /// </summary>
        public int IncrementEntityPixelPosXy
        {
            get
            {
                if (f_incrementEntityPixelPosXy)
                    return _incrementEntityPixelPosXy;
                _incrementEntityPixelPosXy = (int) (22592);
                f_incrementEntityPixelPosXy = true;
                return _incrementEntityPixelPosXy;
            }
        }
        private bool f_initializeTile;
        private int _initializeTile;

        /// <summary>
        /// Initialize a tile struct.
        /// 
        /// r0: tile pointer
        /// </summary>
        public int InitializeTile
        {
            get
            {
                if (f_initializeTile)
                    return _initializeTile;
                _initializeTile = (int) (411060);
                f_initializeTile = true;
                return _initializeTile;
            }
        }
        private bool f_endNegativeStatusConditionWrapper;
        private int _endNegativeStatusConditionWrapper;

        /// <summary>
        /// Calls EndNegativeStatusCondition with remove wrapping status false.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// r2: bool play animation
        /// r3: bool log failure message
        /// return: bool succesfully removed negative status
        /// </summary>
        public int EndNegativeStatusConditionWrapper
        {
            get
            {
                if (f_endNegativeStatusConditionWrapper)
                    return _endNegativeStatusConditionWrapper;
                _endNegativeStatusConditionWrapper = (int) (170136);
                f_endNegativeStatusConditionWrapper = true;
                return _endNegativeStatusConditionWrapper;
            }
        }
        private bool f_yesNoMenu;
        private int _yesNoMenu;

        /// <summary>
        /// Opens a menu where the user can choose &quot;Yes&quot; or &quot;No&quot; and waits for input before returning.
        /// 
        /// r0: ?
        /// r1: ID of the string to display in the textbox
        /// r2: Option that the cursor will be on by default. 0 for &quot;Yes&quot;, 1 for &quot;No&quot;
        /// r3: ?
        /// return: True if the user chooses &quot;Yes&quot;, false if the user chooses &quot;No&quot;
        /// </summary>
        public int YesNoMenu
        {
            get
            {
                if (f_yesNoMenu)
                    return _yesNoMenu;
                _yesNoMenu = (int) (462532);
                f_yesNoMenu = true;
                return _yesNoMenu;
            }
        }
        private bool f_populateActiveMonsterPtrs;
        private int _populateActiveMonsterPtrs;

        /// <summary>
        /// Populates active_monster_ptrs with all valid monsters in the monster_slot_headers array.
        /// 
        /// No params.
        /// </summary>
        public int PopulateActiveMonsterPtrs
        {
            get
            {
                if (f_populateActiveMonsterPtrs)
                    return _populateActiveMonsterPtrs;
                _populateActiveMonsterPtrs = (int) (26412);
                f_populateActiveMonsterPtrs = true;
                return _populateActiveMonsterPtrs;
            }
        }
        private bool f_tryInflictWrappedStatus;
        private int _tryInflictWrappedStatus;

        /// <summary>
        /// Inflicts the Wrapped status condition on a target monster if possible.
        /// 
        /// This also gives the user the Wrap status (Wrapped around foe).
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictWrappedStatus
        {
            get
            {
                if (f_tryInflictWrappedStatus)
                    return _tryInflictWrappedStatus;
                _tryInflictWrappedStatus = (int) (224768);
                f_tryInflictWrappedStatus = true;
                return _tryInflictWrappedStatus;
            }
        }
        private bool f_loadMonsterSpriteInner;
        private int _loadMonsterSpriteInner;

        /// <summary>
        /// This is called by LoadMonsterSprite a bunch of times.
        /// 
        /// r0: monster ID
        /// </summary>
        public int LoadMonsterSpriteInner
        {
            get
            {
                if (f_loadMonsterSpriteInner)
                    return _loadMonsterSpriteInner;
                _loadMonsterSpriteInner = (int) (111036);
                f_loadMonsterSpriteInner = true;
                return _loadMonsterSpriteInner;
            }
        }
        private bool f_getPersonalityIndex;
        private int _getPersonalityIndex;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster pointer
        /// return: ?
        /// </summary>
        public int GetPersonalityIndex
        {
            get
            {
                if (f_getPersonalityIndex)
                    return _getPersonalityIndex;
                _getPersonalityIndex = (int) (461168);
                f_getPersonalityIndex = true;
                return _getPersonalityIndex;
            }
        }
        private bool f_shouldDisplayEntity;
        private int _shouldDisplayEntity;

        /// <summary>
        /// Checks if an entity should be displayed or not.
        /// 
        /// For example, it returns false if the entity is an invisible enemy.
        /// Also used to determine if messages that involve a certain entity should be displayed or suppressed.
        /// 
        /// r0: Entity pointer
        /// r1: (?) Seems to be 1 for monsters and 0 for items.
        /// return: True if the entity and its associated messages should be displayed, false if they shouldn't.
        /// </summary>
        public int ShouldDisplayEntity
        {
            get
            {
                if (f_shouldDisplayEntity)
                    return _shouldDisplayEntity;
                _shouldDisplayEntity = (int) (25384);
                f_shouldDisplayEntity = true;
                return _shouldDisplayEntity;
            }
        }
        private bool f_nearbyAllyIqSkillIsEnabled;
        private int _nearbyAllyIqSkillIsEnabled;

        /// <summary>
        /// Appears to check whether or not the given monster has any allies nearby (within 1 tile) that have the given IQ skill active.
        /// 
        /// r0: entity pointer
        /// r1: IQ skill ID
        /// return: bool
        /// </summary>
        public int NearbyAllyIqSkillIsEnabled
        {
            get
            {
                if (f_nearbyAllyIqSkillIsEnabled)
                    return _nearbyAllyIqSkillIsEnabled;
                _nearbyAllyIqSkillIsEnabled = (int) (376172);
                f_nearbyAllyIqSkillIsEnabled = true;
                return _nearbyAllyIqSkillIsEnabled;
            }
        }
        private bool f_loadFixedRoomData;
        private int _loadFixedRoomData;

        /// <summary>
        /// Loads fixed room data from BALANCE/fixed.bin into the buffer pointed to by FIXED_ROOM_DATA_PTR.
        /// 
        /// No params.
        /// </summary>
        public int LoadFixedRoomData
        {
            get
            {
                if (f_loadFixedRoomData)
                    return _loadFixedRoomData;
                _loadFixedRoomData = (int) (424052);
                f_loadFixedRoomData = true;
                return _loadFixedRoomData;
            }
        }
        private bool f_applyRawstBerryEffect;
        private int _applyRawstBerryEffect;

        /// <summary>
        /// Tries to heal the burn status condition. Prints a message on failure.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyRawstBerryEffect
        {
            get
            {
                if (f_applyRawstBerryEffect)
                    return _applyRawstBerryEffect;
                _applyRawstBerryEffect = (int) (264248);
                f_applyRawstBerryEffect = true;
                return _applyRawstBerryEffect;
            }
        }
        private bool f_createEnemyEntity;
        private int _createEnemyEntity;

        /// <summary>
        /// Creates and initializes the entity struct of a newly spawned enemy monster. Fails if there's 16 enemies on the floor already.
        /// 
        /// It could also be used to spawn fixed room allies, since those share their slots on the entity list.
        /// 
        /// r0: Monster ID
        /// return: Pointer to the newly initialized entity, or null if the entity couldn't be initialized
        /// </summary>
        public int CreateEnemyEntity
        {
            get
            {
                if (f_createEnemyEntity)
                    return _createEnemyEntity;
                _createEnemyEntity = (int) (24176);
                f_createEnemyEntity = true;
                return _createEnemyEntity;
            }
        }
        private bool f_checkSpawnThreshold;
        private int _checkSpawnThreshold;

        /// <summary>
        /// Checks if a given monster ID can spawn in dungeons.
        /// 
        /// The function returns true if the monster's spawn threshold value is &lt;= SCENARIO_BALANCE_FLAG
        /// 
        /// r0: monster ID
        /// return: True if the monster can spawn, false otherwise
        /// </summary>
        public int CheckSpawnThreshold
        {
            get
            {
                if (f_checkSpawnThreshold)
                    return _checkSpawnThreshold;
                _checkSpawnThreshold = (int) (127456);
                f_checkSpawnThreshold = true;
                return _checkSpawnThreshold;
            }
        }
        private bool f_isBlinded;
        private int _isBlinded;

        /// <summary>
        /// Returns true if the monster has the blinded status (see statuses::blinded), or if it is not the leader and is holding Y-Ray Specs.
        /// 
        /// r0: pointer to entity
        /// r1: flag for whether to check for the held item
        /// return: bool
        /// </summary>
        public int IsBlinded
        {
            get
            {
                if (f_isBlinded)
                    return _isBlinded;
                _isBlinded = (int) (242644);
                f_isBlinded = true;
                return _isBlinded;
            }
        }
        private bool f_setActionUseMovePlayer;
        private int _setActionUseMovePlayer;

        /// <summary>
        /// Sets a monster's action to action::ACTION_USE_MOVE_PLAYER, with a specified monster and move index.
        /// 
        /// r0: Pointer to the monster's action field
        /// r1: Index of the monster that is using the move on the entity list. Gets stored in monster::action::action_use_idx.
        /// r2: Index of the move to use (0-3). Gets stored in monster::action::field_0xA.
        /// </summary>
        public int SetActionUseMovePlayer
        {
            get
            {
                if (f_setActionUseMovePlayer)
                    return _setActionUseMovePlayer;
                _setActionUseMovePlayer = (int) (64032);
                f_setActionUseMovePlayer = true;
                return _setActionUseMovePlayer;
            }
        }
        private bool f_useSingleUseItem;
        private int _useSingleUseItem;

        /// <summary>
        /// Makes a monster use a single-use item. The item is deleted afterwards.
        /// 
        /// The item to use is determined by the user's monster::action_data::action_parameter[0].
        /// 
        /// r0: User (monster who used the item)
        /// r1: Target (monster that consumes the item)
        /// </summary>
        public int UseSingleUseItem
        {
            get
            {
                if (f_useSingleUseItem)
                    return _useSingleUseItem;
                _useSingleUseItem = (int) (102416);
                f_useSingleUseItem = true;
                return _useSingleUseItem;
            }
        }
        private bool f_tryActivateConversion2;
        private int _tryActivateConversion2;

        /// <summary>
        /// Checks for the conversion2 status and applies the type change if applicable. Called
        /// after using a move.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// r2: move pointer
        /// </summary>
        public int TryActivateConversion2
        {
            get
            {
                if (f_tryActivateConversion2)
                    return _tryActivateConversion2;
                _tryActivateConversion2 = (int) (119836);
                f_tryActivateConversion2 = true;
                return _tryActivateConversion2;
            }
        }
        private bool f_boostSpeed;
        private int _boostSpeed;

        /// <summary>
        /// Boosts the speed of the target monster.
        /// 
        /// If the number of turns specified is 0, a random turn count will be selected using the default SPEED_BOOST_TURN_RANGE.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of stages
        /// r3: number of turns
        /// stack[0]: flag to log a message on failure
        /// </summary>
        public int BoostSpeed
        {
            get
            {
                if (f_boostSpeed)
                    return _boostSpeed;
                _boostSpeed = (int) (230404);
                f_boostSpeed = true;
                return _boostSpeed;
            }
        }
        private bool f_loadWeather3DFiles;
        private int _loadWeather3DFiles;

        /// <summary>
        /// Loads the 1001.wte, 1005.wte, and 1031.wte files in dungeon.bin, which are used for the 3D effects for the tileset weather as well as the Sandstorm/Fog weather conditions.
        /// 
        /// No params.
        /// </summary>
        public int LoadWeather3DFiles
        {
            get
            {
                if (f_loadWeather3DFiles)
                    return _loadWeather3DFiles;
                _loadWeather3DFiles = (int) (377748);
                f_loadWeather3DFiles = true;
                return _loadWeather3DFiles;
            }
        }
        private bool f_applyViolentSeedEffect;
        private int _applyViolentSeedEffect;

        /// <summary>
        /// Boosts the target's offensive stats stages to the max.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyViolentSeedEffect
        {
            get
            {
                if (f_applyViolentSeedEffect)
                    return _applyViolentSeedEffect;
                _applyViolentSeedEffect = (int) (264712);
                f_applyViolentSeedEffect = true;
                return _applyViolentSeedEffect;
            }
        }
        private bool f_getPossibleAiThrownItemDirections;
        private int _getPossibleAiThrownItemDirections;

        /// <summary>
        /// If the entity can throw an item at a target in a certain direction,
        /// adds that direction to AI_THROWN_ITEM_DIRECTIONS and the probability of throwing it to AI_THROWN_ITEM_PROBABILITIES (if it is not already present).
        /// The size of the arrays will be stored in AI_THROWN_ITEM_ACTION_CHOICE_COUNT.
        /// The caller function will select the direction to throw the item by iterating through the array(s), rolling the probability, and then throwing in that direction if the roll succeeds.
        /// Nothing will be thrown if all rolls fail.
        /// 
        /// r0: Entity pointer
        /// r1: Integer in {1, 2}. If 1, target allies; if 2, target enemies.
        /// r2: Item struct pointer
        /// r3: If false, will call GetAiUseItemProbability to get the probability of throwing in a certain direction.
        /// If true, the added probability will always be 100.
        /// </summary>
        public int GetPossibleAiThrownItemDirections
        {
            get
            {
                if (f_getPossibleAiThrownItemDirections)
                    return _getPossibleAiThrownItemDirections;
                _getPossibleAiThrownItemDirections = (int) (207372);
                f_getPossibleAiThrownItemDirections = true;
                return _getPossibleAiThrownItemDirections;
            }
        }
        private bool f_applyProteinEffect;
        private int _applyProteinEffect;

        /// <summary>
        /// Tries to boost the target's attack stat.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: attack boost
        /// </summary>
        public int ApplyProteinEffect
        {
            get
            {
                if (f_applyProteinEffect)
                    return _applyProteinEffect;
                _applyProteinEffect = (int) (244544);
                f_applyProteinEffect = true;
                return _applyProteinEffect;
            }
        }
        private bool f_isRoomIlluminated;
        private int _isRoomIlluminated;

        /// <summary>
        /// Checks if the given fixed room is fully illuminated.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int IsRoomIlluminated
        {
            get
            {
                if (f_isRoomIlluminated)
                    return _isRoomIlluminated;
                _isRoomIlluminated = (int) (425052);
                f_isRoomIlluminated = true;
                return _isRoomIlluminated;
            }
        }
        private bool f_isMonsterSleeping;
        private int _isMonsterSleeping;

        /// <summary>
        /// Checks if a monster has the sleep, nightmare, or napping status.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int IsMonsterSleeping
        {
            get
            {
                if (f_isMonsterSleeping)
                    return _isMonsterSleeping;
                _isMonsterSleeping = (int) (148140);
                f_isMonsterSleeping = true;
                return _isMonsterSleeping;
            }
        }
        private bool f_logMessageByIdQuiet;
        private int _logMessageByIdQuiet;

        /// <summary>
        /// Logs a message in the message log (but without a message popup).
        /// 
        /// r0: user entity pointer
        /// r1: message ID
        /// </summary>
        public int LogMessageByIdQuiet
        {
            get
            {
                if (f_logMessageByIdQuiet)
                    return _logMessageByIdQuiet;
                _logMessageByIdQuiet = (int) (453804);
                f_logMessageByIdQuiet = true;
                return _logMessageByIdQuiet;
            }
        }
        private bool f_playMoveAnimation;
        private int _playMoveAnimation;

        /// <summary>
        /// Handles the process of getting and playing all the animations for a move. Waits
        /// until the animation has no more frames before returning.
        /// 
        /// r0: Pointer to the entity that used the move
        /// r1: Pointer to the entity that is the target
        /// r2: Move pointer
        /// r3: position
        /// </summary>
        public int PlayMoveAnimation
        {
            get
            {
                if (f_playMoveAnimation)
                    return _playMoveAnimation;
                _playMoveAnimation = (int) (299616);
                f_playMoveAnimation = true;
                return _playMoveAnimation;
            }
        }
        private bool f_applySummonTrapEffect;
        private int _applySummonTrapEffect;

        /// <summary>
        /// Randomly spawns 2-4 enemy monsters around the position. The entity is only used for
        /// logging messages.
        /// 
        /// r0: entity pointer
        /// r1: position
        /// </summary>
        public int ApplySummonTrapEffect
        {
            get
            {
                if (f_applySummonTrapEffect)
                    return _applySummonTrapEffect;
                _applySummonTrapEffect = (int) (75528);
                f_applySummonTrapEffect = true;
                return _applySummonTrapEffect;
            }
        }
        private bool f_determineAllMonsterShadow;
        private int _determineAllMonsterShadow;

        /// <summary>
        /// Change all monsters' shadows to be appropriate for their sizes and the tile they're
        /// standing on. It simply calls DetermineMontersShadow for all monsters in the dungeon.
        /// 
        /// No params.
        /// </summary>
        public int DetermineAllMonsterShadow
        {
            get
            {
                if (f_determineAllMonsterShadow)
                    return _determineAllMonsterShadow;
                _determineAllMonsterShadow = (int) (165844);
                f_determineAllMonsterShadow = true;
                return _determineAllMonsterShadow;
            }
        }
        private bool f_exclusiveItemOffenseBoost;
        private int _exclusiveItemOffenseBoost;

        /// <summary>
        /// Gets the exclusive item boost for attack/special attack for a monster
        /// 
        /// r0: entity pointer
        /// r1: move category index (0 for physical, 1 for special)
        /// return: boost
        /// </summary>
        public int ExclusiveItemOffenseBoost
        {
            get
            {
                if (f_exclusiveItemOffenseBoost)
                    return _exclusiveItemOffenseBoost;
                _exclusiveItemOffenseBoost = (int) (209876);
                f_exclusiveItemOffenseBoost = true;
                return _exclusiveItemOffenseBoost;
            }
        }
        private bool f_executeMonsterAction;
        private int _executeMonsterAction;

        /// <summary>
        /// Executes the set action for the specified monster. Used for both AI actions and player-inputted actions. If the action is not ACTION_NOTHING, ACTION_PASS_TURN, ACTION_WALK or ACTION_UNK_4, the monster's already_acted field is set to true. Includes a switch based on the action ID that performs the action, although some of them aren't handled by said swtich.
        /// 
        /// r0: Pointer to monster entity
        /// return: If the result is true, the AI is run again for the current ally, and it performs another action. This can happen up to three times.
        /// </summary>
        public int ExecuteMonsterAction
        {
            get
            {
                if (f_executeMonsterAction)
                    return _executeMonsterAction;
                _executeMonsterAction = (int) (139204);
                f_executeMonsterAction = true;
                return _executeMonsterAction;
            }
        }
        private bool f_teamMemberHasEnabledIqSkill;
        private int _teamMemberHasEnabledIqSkill;

        /// <summary>
        /// Returns true if any team member has the specified iq skill.
        /// 
        /// r0: iq skill id
        /// return: bool
        /// </summary>
        public int TeamMemberHasEnabledIqSkill
        {
            get
            {
                if (f_teamMemberHasEnabledIqSkill)
                    return _teamMemberHasEnabledIqSkill;
                _teamMemberHasEnabledIqSkill = (int) (126220);
                f_teamMemberHasEnabledIqSkill = true;
                return _teamMemberHasEnabledIqSkill;
            }
        }
        private bool f_activateMotorDrive;
        private int _activateMotorDrive;

        /// <summary>
        /// Displays the message and applies the speed boost for the ability Motor Drive.
        /// 
        /// r0: monster pointer
        /// </summary>
        public int ActivateMotorDrive
        {
            get
            {
                if (f_activateMotorDrive)
                    return _activateMotorDrive;
                _activateMotorDrive = (int) (257104);
                f_activateMotorDrive = true;
                return _activateMotorDrive;
            }
        }
        private bool f_endFrozenStatus;
        private int _endFrozenStatus;

        /// <summary>
        /// Cures the target's freeze status due to the action of the user.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int EndFrozenStatus
        {
            get
            {
                if (f_endFrozenStatus)
                    return _endFrozenStatus;
                _endFrozenStatus = (int) (178376);
                f_endFrozenStatus = true;
                return _endFrozenStatus;
            }
        }
        private bool f_playEffectAnimationEntity;
        private int _playEffectAnimationEntity;

        /// <summary>
        /// Just a guess. This appears to be paired often with GetEffectAnimationField0x19, and also has calls AnimationHasMoreFrames in a loop alongside AdvanceFrame(66) calls.
        /// 
        /// The third parameter skips the loop entirely. It seems like in this case the function might just preload some animation frames for later use??
        /// 
        /// r0: entity pointer
        /// r1: Effect ID
        /// r2: appears to be a flag for actually running the animation now? If this is 0, the AdvanceFrame loop is skipped entirely.
        /// others: ?
        /// return: status code, or maybe the number of frames or something? Either way, -1 seems to indicate the animation being finished or something?
        /// </summary>
        public int PlayEffectAnimationEntity
        {
            get
            {
                if (f_playEffectAnimationEntity)
                    return _playEffectAnimationEntity;
                _playEffectAnimationEntity = (int) (29556);
                f_playEffectAnimationEntity = true;
                return _playEffectAnimationEntity;
            }
        }
        private bool f_applyGrudgeTrapEffect;
        private int _applyGrudgeTrapEffect;

        /// <summary>
        /// Spawns several monsters around the position and gives all monsters on the floor the
        /// grudge status condition.
        /// 
        /// r0: entity pointer
        /// r1: position
        /// </summary>
        public int ApplyGrudgeTrapEffect
        {
            get
            {
                if (f_applyGrudgeTrapEffect)
                    return _applyGrudgeTrapEffect;
                _applyGrudgeTrapEffect = (int) (77196);
                f_applyGrudgeTrapEffect = true;
                return _applyGrudgeTrapEffect;
            }
        }
        private bool f_aiDecideUseItem;
        private int _aiDecideUseItem;

        /// <summary>
        /// Decides whether or not an AI should use its held item and updates its action_data fields accordingly.
        /// 
        /// r0: Entity pointer
        /// </summary>
        public int AiDecideUseItem
        {
            get
            {
                if (f_aiDecideUseItem)
                    return _aiDecideUseItem;
                _aiDecideUseItem = (int) (206192);
                f_aiDecideUseItem = true;
                return _aiDecideUseItem;
            }
        }
        private bool f_setEntityPixelPosXy;
        private int _setEntityPixelPosXy;

        /// <summary>
        /// r0: Entity pointer
        /// r1: x
        /// r2: y
        /// </summary>
        public int SetEntityPixelPosXy
        {
            get
            {
                if (f_setEntityPixelPosXy)
                    return _setEntityPixelPosXy;
                _setEntityPixelPosXy = (int) (22580);
                f_setEntityPixelPosXy = true;
                return _setEntityPixelPosXy;
            }
        }
        private bool f_resetFloor;
        private int _resetFloor;

        /// <summary>
        /// Resets the floor in preparation for a floor generation attempt.
        /// 
        /// Resets all tiles, resets the border to be impassable, and clears entity spawns.
        /// 
        /// No params.
        /// </summary>
        public int ResetFloor
        {
            get
            {
                if (f_resetFloor)
                    return _resetFloor;
                _resetFloor = (int) (411116);
                f_resetFloor = true;
                return _resetFloor;
            }
        }
        private bool f_spawnShopkeepers;
        private int _spawnShopkeepers;

        /// <summary>
        /// Spawns all the shopkeepers in the dungeon struct's shopkeeper_spawns array.
        /// 
        /// No params.
        /// </summary>
        public int SpawnShopkeepers
        {
            get
            {
                if (f_spawnShopkeepers)
                    return _spawnShopkeepers;
                _spawnShopkeepers = (int) (138580);
                f_spawnShopkeepers = true;
                return _spawnShopkeepers;
            }
        }
        private bool f_stairsAlwaysReachable;
        private int _stairsAlwaysReachable;

        /// <summary>
        /// Checks that the stairs are reachable from every walkable tile on the floor.
        /// 
        /// This runs a graph traversal algorithm that is very similar to breadth-first search (the order in which nodes are visited is slightly different), starting from the stairs. If any tile is walkable but wasn't reached by the traversal algorithm, then the stairs must not be reachable from that tile.
        /// 
        /// r0: x coordinate of the stairs
        /// r1: y coordinate of the stairs
        /// r2: flag to always return true, but set a special bit on all walkable tiles that aren't reachable from the stairs
        /// return: bool
        /// </summary>
        public int StairsAlwaysReachable
        {
            get
            {
                if (f_stairsAlwaysReachable)
                    return _stairsAlwaysReachable;
                _stairsAlwaysReachable = (int) (416076);
                f_stairsAlwaysReachable = true;
                return _stairsAlwaysReachable;
            }
        }
        private bool f_placeFixedRoomTile;
        private int _placeFixedRoomTile;

        /// <summary>
        /// Used to spawn a single tile when generating a fixed room. The tile might contain an item or a monster.
        /// 
        /// r0: Pointer to the tile to spawn
        /// r1: Fixed room action to perform. Controls what exactly will be spawned. The action is actually 12 bits long, the highest 4 bits are used as a parameter that represents a direction (for example, when spawning a monster).
        /// r2: Tile X position
        /// r3: Tile Y position
        /// </summary>
        public int PlaceFixedRoomTile
        {
            get
            {
                if (f_placeFixedRoomTile)
                    return _placeFixedRoomTile;
                _placeFixedRoomTile = (int) (420372);
                f_placeFixedRoomTile = true;
                return _placeFixedRoomTile;
            }
        }
        private bool f_tryInflictDropeyeStatus;
        private int _tryInflictDropeyeStatus;

        /// <summary>
        /// Inflicts the Dropeye status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictDropeyeStatus
        {
            get
            {
                if (f_tryInflictDropeyeStatus)
                    return _tryInflictDropeyeStatus;
                _tryInflictDropeyeStatus = (int) (243428);
                f_tryInflictDropeyeStatus = true;
                return _tryInflictDropeyeStatus;
            }
        }
        private bool f_isSecretBazaarVeneer;
        private int _isSecretBazaarVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for IsSecretBazaar.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// return: bool
        /// </summary>
        public int IsSecretBazaarVeneer
        {
            get
            {
                if (f_isSecretBazaarVeneer)
                    return _isSecretBazaarVeneer;
                _isSecretBazaarVeneer = (int) (426012);
                f_isSecretBazaarVeneer = true;
                return _isSecretBazaarVeneer;
            }
        }
        private bool f_setShouldBoostKecleonShopSpawnChance;
        private int _setShouldBoostKecleonShopSpawnChance;

        /// <summary>
        /// Sets the boost_kecleon_shop_spawn_chance field on the dungeon struct to the given value.
        /// 
        /// r0: bool to set the flag to
        /// </summary>
        public int SetShouldBoostKecleonShopSpawnChance
        {
            get
            {
                if (f_setShouldBoostKecleonShopSpawnChance)
                    return _setShouldBoostKecleonShopSpawnChance;
                _setShouldBoostKecleonShopSpawnChance = (int) (376764);
                f_setShouldBoostKecleonShopSpawnChance = true;
                return _setShouldBoostKecleonShopSpawnChance;
            }
        }
        private bool f_ghostImmunityIsActive;
        private int _ghostImmunityIsActive;

        /// <summary>
        /// Checks whether the defender's typing would give it Ghost immunities.
        /// 
        /// This only checks one of the defender's types at a time. It checks whether the defender has the exposed status and whether the attacker has the Scrappy-like exclusive item effect, but does NOT check whether the attacker has the Scrappy ability.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: defender type index (0 the defender's first type, 1 for the defender's second type)
        /// return: bool
        /// </summary>
        public int GhostImmunityIsActive
        {
            get
            {
                if (f_ghostImmunityIsActive)
                    return _ghostImmunityIsActive;
                _ghostImmunityIsActive = (int) (190620);
                f_ghostImmunityIsActive = true;
                return _ghostImmunityIsActive;
            }
        }
        private bool f_tryTriggerMonsterHouse;
        private int _tryTriggerMonsterHouse;

        /// <summary>
        /// Triggers a Monster House for an entity, if the right conditions are met.
        /// 
        /// Conditions: entity is valid and on the team, the tile is a Monster House tile, and the Monster House hasn't already been triggered.
        /// 
        /// This function sets the monster_house_triggered flag on the dungeon struct, spawns a bunch of enemies around the triggering entity (within a 4 tile radius), and handles the &quot;dropping down&quot; animation for these enemies. If the allow outside enemies flag is set, the enemy spawns can be on any free tile (no monster) with open terrain, including in hallways. Otherwise, spawns are confined within the room boundaries.
        /// 
        /// r0: entity for which the Monster House should be triggered
        /// r1: allow outside enemies flag (in practice this is always set to dungeon_generation_info::force_create_monster_house)
        /// </summary>
        public int TryTriggerMonsterHouse
        {
            get
            {
                if (f_tryTriggerMonsterHouse)
                    return _tryTriggerMonsterHouse;
                _tryTriggerMonsterHouse = (int) (179104);
                f_tryTriggerMonsterHouse = true;
                return _tryTriggerMonsterHouse;
            }
        }
        private bool f_tryInflictLongTossStatus;
        private int _tryInflictLongTossStatus;

        /// <summary>
        /// Inflicts the Long Toss status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictLongTossStatus
        {
            get
            {
                if (f_tryInflictLongTossStatus)
                    return _tryInflictLongTossStatus;
                _tryInflictLongTossStatus = (int) (245136);
                f_tryInflictLongTossStatus = true;
                return _tryInflictLongTossStatus;
            }
        }
        private bool f_tryInflictCringeStatus;
        private int _tryInflictCringeStatus;

        /// <summary>
        /// Inflicts the Cringe status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictCringeStatus
        {
            get
            {
                if (f_tryInflictCringeStatus)
                    return _tryInflictCringeStatus;
                _tryInflictCringeStatus = (int) (229348);
                f_tryInflictCringeStatus = true;
                return _tryInflictCringeStatus;
            }
        }
        private bool f_getDamageSourceWrapper;
        private int _getDamageSourceWrapper;

        /// <summary>
        /// Wraps GetDamageSource (in arm9) for a move info struct rather than a move ID.
        /// 
        /// r0: move info pointer
        /// r1: item ID
        /// return: damage source
        /// </summary>
        public int GetDamageSourceWrapper
        {
            get
            {
                if (f_getDamageSourceWrapper)
                    return _getDamageSourceWrapper;
                _getDamageSourceWrapper = (int) (297456);
                f_getDamageSourceWrapper = true;
                return _getDamageSourceWrapper;
            }
        }
        private bool f_isOutlawOrChallengeRequestFloor;
        private int _isOutlawOrChallengeRequestFloor;

        /// <summary>
        /// Checks if the current floor is an active mission destination of type MISSION_TAKE_ITEM_FROM_OUTLAW, MISSION_ARREST_OUTLAW or MISSION_CHALLENGE_REQUEST.
        /// 
        /// return: bool
        /// </summary>
        public int IsOutlawOrChallengeRequestFloor
        {
            get
            {
                if (f_isOutlawOrChallengeRequestFloor)
                    return _isOutlawOrChallengeRequestFloor;
                _isOutlawOrChallengeRequestFloor = (int) (445452);
                f_isOutlawOrChallengeRequestFloor = true;
                return _isOutlawOrChallengeRequestFloor;
            }
        }
        private bool f_tryInflictSleeplessStatus;
        private int _tryInflictSleeplessStatus;

        /// <summary>
        /// Inflicts the Sleepless status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictSleeplessStatus
        {
            get
            {
                if (f_tryInflictSleeplessStatus)
                    return _tryInflictSleeplessStatus;
                _tryInflictSleeplessStatus = (int) (220068);
                f_tryInflictSleeplessStatus = true;
                return _tryInflictSleeplessStatus;
            }
        }
        private bool f_assignRooms;
        private int _assignRooms;

        /// <summary>
        /// Randomly selects a subset of grid cells to become rooms.
        /// 
        /// The given number of grid cells will become rooms. If any of the selected grid cells are invalid, fewer rooms will be generated. The number of rooms assigned will always be at least 2 and never exceed 36.
        /// 
        /// Cells not marked as rooms will become hallway anchors. A hallway anchor is a single tile in a non-room grid cell to which hallways will be connected later, thus &quot;anchoring&quot; hallway generation.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: number of rooms; if positive, a random value between [n_rooms, n_rooms+2] will be used. If negative, |n_rooms| will be used exactly.
        /// </summary>
        public int AssignRooms
        {
            get
            {
                if (f_assignRooms)
                    return _assignRooms;
                _assignRooms = (int) (396260);
                f_assignRooms = true;
                return _assignRooms;
            }
        }
        private bool f_isLegendaryChallengeFloor;
        private int _isLegendaryChallengeFloor;

        /// <summary>
        /// Checks if the current floor is a boss floor for a Legendary Challenge Letter mission.
        /// 
        /// return: bool
        /// </summary>
        public int IsLegendaryChallengeFloor
        {
            get
            {
                if (f_isLegendaryChallengeFloor)
                    return _isLegendaryChallengeFloor;
                _isLegendaryChallengeFloor = (int) (445724);
                f_isLegendaryChallengeFloor = true;
                return _isLegendaryChallengeFloor;
            }
        }
        private bool f_revealEnemies;
        private int _revealEnemies;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int RevealEnemies
        {
            get
            {
                if (f_revealEnemies)
                    return _revealEnemies;
                _revealEnemies = (int) (234324);
                f_revealEnemies = true;
                return _revealEnemies;
            }
        }
        private bool f_trySealMove;
        private int _trySealMove;

        /// <summary>
        /// Seals one of the target monster's moves. The move to be sealed is randomly selected.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// return: Whether or not a move was sealed
        /// </summary>
        public int TrySealMove
        {
            get
            {
                if (f_trySealMove)
                    return _trySealMove;
                _trySealMove = (int) (231088);
                f_trySealMove = true;
                return _trySealMove;
            }
        }
        private bool f_addHeldItemToBag;
        private int _addHeldItemToBag;

        /// <summary>
        /// Adds the monster's held item to the bag. This is only called on monsters on the exploration team.
        /// monster::is_not_team_member should be checked to be false before calling.
        /// 
        /// r0: monster pointer
        /// </summary>
        public int AddHeldItemToBag
        {
            get
            {
                if (f_addHeldItemToBag)
                    return _addHeldItemToBag;
                _addHeldItemToBag = (int) (436724);
                f_addHeldItemToBag = true;
                return _addHeldItemToBag;
            }
        }
        private bool f_setActionPassTurnOrWalk;
        private int _setActionPassTurnOrWalk;

        /// <summary>
        /// Sets a monster's action to action::ACTION_PASS_TURN or action::ACTION_WALK, depending on the result of GetCanMoveFlag for the monster's ID.
        /// 
        /// r0: Pointer to the monster's action field
        /// r1: Monster ID
        /// </summary>
        public int SetActionPassTurnOrWalk
        {
            get
            {
                if (f_setActionPassTurnOrWalk)
                    return _setActionPassTurnOrWalk;
                _setActionPassTurnOrWalk = (int) (61860);
                f_setActionPassTurnOrWalk = true;
                return _setActionPassTurnOrWalk;
            }
        }
        private bool f_endNegativeStatusCondition;
        private int _endNegativeStatusCondition;

        /// <summary>
        /// Cures the target's negative status conditions. The game rarely (if not never) calls
        /// this function with the bool to remove the wrapping status false.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// r2: bool play animation
        /// r3: bool log failure message
        /// stack[0]: bool remove wrapping status
        /// return: bool succesfully removed negative status
        /// </summary>
        public int EndNegativeStatusCondition
        {
            get
            {
                if (f_endNegativeStatusCondition)
                    return _endNegativeStatusCondition;
                _endNegativeStatusCondition = (int) (169268);
                f_endNegativeStatusCondition = true;
                return _endNegativeStatusCondition;
            }
        }
        private bool f_shouldTryEatItem;
        private int _shouldTryEatItem;

        /// <summary>
        /// Checks if a given item should be eaten by the TryEatItem effect.
        /// 
        /// Returns false if the ID is lower than 0x45, greater than 0x8A or if it's listed in the EAT_ITEM_EFFECT_IGNORE_LIST array.
        /// 
        /// r0: Item ID
        /// return: True if the item should be eaten by TryEatItem.
        /// </summary>
        public int ShouldTryEatItem
        {
            get
            {
                if (f_shouldTryEatItem)
                    return _shouldTryEatItem;
                _shouldTryEatItem = (int) (271708);
                f_shouldTryEatItem = true;
                return _shouldTryEatItem;
            }
        }
        private bool f_isHyperBeamVariant;
        private int _isHyperBeamVariant;

        /// <summary>
        /// Checks if a move is a Hyper Beam variant that requires a a turn to recharge.
        /// 
        /// Include moves: Frenzy Plant, Hydro Cannon, Hyper Beam, Blast Burn, Rock Wrecker, Giga Impact, Roar of Time
        /// 
        /// r0: move
        /// return: bool
        /// </summary>
        public int IsHyperBeamVariant
        {
            get
            {
                if (f_isHyperBeamVariant)
                    return _isHyperBeamVariant;
                _isHyperBeamVariant = (int) (295140);
                f_isHyperBeamVariant = true;
                return _isHyperBeamVariant;
            }
        }
        private bool f_applyBlastSeedEffect;
        private int _applyBlastSeedEffect;

        /// <summary>
        /// If thrown, unfreeze and deal fixed damage to the defender. If not thrown, try to find 
        /// a monster in front of the attacker. If a monster is found unfreeze and dedal fixed 
        /// damage to the defender. Appears to have a leftover check for if the current fixed room is a boss fight and loads a different pointer for the damage when used in a boss room.
        /// However, this isn't noticeable because both the normal and boss damage is the same.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: bool thrown
        /// </summary>
        public int ApplyBlastSeedEffect
        {
            get
            {
                if (f_applyBlastSeedEffect)
                    return _applyBlastSeedEffect;
                _applyBlastSeedEffect = (int) (265068);
                f_applyBlastSeedEffect = true;
                return _applyBlastSeedEffect;
            }
        }
        private bool f_isMonsterIdInNormalRangeVeneer;
        private int _isMonsterIdInNormalRangeVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for IsMonsterIdInNormalRange.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsMonsterIdInNormalRangeVeneer
        {
            get
            {
                if (f_isMonsterIdInNormalRangeVeneer)
                    return _isMonsterIdInNormalRangeVeneer;
                _isMonsterIdInNormalRangeVeneer = (int) (121152);
                f_isMonsterIdInNormalRangeVeneer = true;
                return _isMonsterIdInNormalRangeVeneer;
            }
        }
        private bool f_isAiTargetEligible;
        private int _isAiTargetEligible;

        /// <summary>
        /// Checks if a given target is eligible to be targeted by the AI with a certain move
        /// 
        /// r0: Move's AI range field
        /// r1: User entity pointer
        /// r2: Target entity pointer
        /// r3: Move pointer
        /// stack[0]: True to check all the possible move_ai_condition values, false to only check for move_ai_condition::AI_CONDITION_RANDOM (if the move has a different ai condition, the result will be false).
        /// return: True if the target is eligible, false otherwise
        /// </summary>
        public int IsAiTargetEligible
        {
            get
            {
                if (f_isAiTargetEligible)
                    return _isAiTargetEligible;
                _isAiTargetEligible = (int) (253076);
                f_isAiTargetEligible = true;
                return _isAiTargetEligible;
            }
        }
        private bool f_tryTransform;
        private int _tryTransform;

        /// <summary>
        /// Attempts to transform the target into the species of a random monster contained in the list returned by MonsterSpawnListPartialCopy.
        /// 
        /// The user pointer is only used when calling LogMessage functions.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryTransform
        {
            get
            {
                if (f_tryTransform)
                    return _tryTransform;
                _tryTransform = (int) (241164);
                f_tryTransform = true;
                return _tryTransform;
            }
        }
        private bool f_flagHallwayJunctions;
        private int _flagHallwayJunctions;

        /// <summary>
        /// Sets the junction flag (bit 3 of the terrain flags) on any hallway junction tiles in some range [x0, x1), [y0, y1). This leaves tiles within rooms untouched.
        /// 
        /// A hallway tile is considered a junction if it has at least 3 cardinal neighbors with open terrain.
        /// 
        /// r0: x0
        /// r1: y0
        /// r2: x1
        /// r3: y1
        /// </summary>
        public int FlagHallwayJunctions
        {
            get
            {
                if (f_flagHallwayJunctions)
                    return _flagHallwayJunctions;
                _flagHallwayJunctions = (int) (387568);
                f_flagHallwayJunctions = true;
                return _flagHallwayJunctions;
            }
        }
        private bool f_othersMenuLoop;
        private int _othersMenuLoop;

        /// <summary>
        /// Called on each frame while the in-dungeon &quot;others&quot; menu is open.
        /// 
        /// It contains a switch to determine whether an option has been chosen or not and a second switch that determines what to do depending on which option was chosen.
        /// 
        /// return: int (Actually, this is probably some sort of enum shared by all the MenuLoop functions)
        /// </summary>
        public int OthersMenuLoop
        {
            get
            {
                if (f_othersMenuLoop)
                    return _othersMenuLoop;
                _othersMenuLoop = (int) (471392);
                f_othersMenuLoop = true;
                return _othersMenuLoop;
            }
        }
        private bool f_tryActivateArtificialWeatherAbilities;
        private int _tryActivateArtificialWeatherAbilities;

        /// <summary>
        /// Runs a check over all monsters on the field for abilities that affect the weather and changes the floor's weather accordingly.
        /// 
        /// No params
        /// </summary>
        public int TryActivateArtificialWeatherAbilities
        {
            get
            {
                if (f_tryActivateArtificialWeatherAbilities)
                    return _tryActivateArtificialWeatherAbilities;
                _tryActivateArtificialWeatherAbilities = (int) (118716);
                f_tryActivateArtificialWeatherAbilities = true;
                return _tryActivateArtificialWeatherAbilities;
            }
        }
        private bool f_endCringeClassStatus;
        private int _endCringeClassStatus;

        /// <summary>
        /// Cures the target's cringe, confusion, cowering, pause, taunt, encore or infatuated status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndCringeClassStatus
        {
            get
            {
                if (f_endCringeClassStatus)
                    return _endCringeClassStatus;
                _endCringeClassStatus = (int) (172068);
                f_endCringeClassStatus = true;
                return _endCringeClassStatus;
            }
        }
        private bool f_changeMonsterAnimation;
        private int _changeMonsterAnimation;

        /// <summary>
        /// Changes the animation a monster is currently playing. Optionally changes their direction as well.
        /// 
        /// Does nothing if the provided entity is not a monster.
        /// 
        /// r0: Entity pointer
        /// r1: ID of the animation to set
        /// r2: Direction to turn the monster in, or DIR_NONE to keep the current direction
        /// </summary>
        public int ChangeMonsterAnimation
        {
            get
            {
                if (f_changeMonsterAnimation)
                    return _changeMonsterAnimation;
                _changeMonsterAnimation = (int) (165400);
                f_changeMonsterAnimation = true;
                return _changeMonsterAnimation;
            }
        }
        private bool f_weightMoveWithIqSkills;
        private int _weightMoveWithIqSkills;

        /// <summary>
        /// Calculates a move weight used for deciding which target the move should be used on. If the user is an ally, the target is an enemy Pokémon, and the user has Exp. Go-Getter, Efficiency Expert, or Weak-Type Picker enabled, this function calculates a move weight based on that IQ skill's functionality. Otherwise, this function returns a weight of 1.
        /// 
        /// r0: User entity pointer
        /// r1: Move's AI range field
        /// r2: Target entity pointer
        /// r3: Move type
        /// return: Move weight for deciding move targeting.
        /// </summary>
        public int WeightMoveWithIqSkills
        {
            get
            {
                if (f_weightMoveWithIqSkills)
                    return _weightMoveWithIqSkills;
                _weightMoveWithIqSkills = (int) (253780);
                f_weightMoveWithIqSkills = true;
                return _weightMoveWithIqSkills;
            }
        }
        private bool f_levelUp;
        private int _levelUp;

        /// <summary>
        /// Attempts to level up the target. Fails if the target's level can't be raised. The show level up dialogue bool does nothing for monsters not on the team.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: bool message flag?
        /// r3: bool show level up dialogue (for example &quot;Hey, I leveled up!&quot; with a portrait)?
        /// return: success flag
        /// </summary>
        public int LevelUp
        {
            get
            {
                if (f_levelUp)
                    return _levelUp;
                _levelUp = (int) (158888);
                f_levelUp = true;
                return _levelUp;
            }
        }
        private bool f_subInitMonster;
        private int _subInitMonster;

        /// <summary>
        /// Called by InitMonster. Initializes some fields on the monster struct.
        /// 
        /// r0: pointer to monster to initialize
        /// r1: some flag
        /// </summary>
        public int SubInitMonster
        {
            get
            {
                if (f_subInitMonster)
                    return _subInitMonster;
                _subInitMonster = (int) (137424);
                f_subInitMonster = true;
                return _subInitMonster;
            }
        }
        private bool f_decrementWindCounter;
        private int _decrementWindCounter;

        /// <summary>
        /// Decrements dungeon::wind_turns and displays a wind warning message if required.
        /// 
        /// No params.
        /// </summary>
        public int DecrementWindCounter
        {
            get
            {
                if (f_decrementWindCounter)
                    return _decrementWindCounter;
                _decrementWindCounter = (int) (67788);
                f_decrementWindCounter = true;
                return _decrementWindCounter;
            }
        }
        private bool f_dealDamageWithType;
        private int _dealDamageWithType;

        /// <summary>
        /// Same as DealDamage, except with an explicit move type.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move type
        /// r3: move
        /// stack[0]: damage multiplier (as a binary fixed-point number with 8 fraction bits)
        /// stack[1]: item ID
        /// return: amount of damage dealt
        /// </summary>
        public int DealDamageWithType
        {
            get
            {
                if (f_dealDamageWithType)
                    return _dealDamageWithType;
                _dealDamageWithType = (int) (354284);
                f_dealDamageWithType = true;
                return _dealDamageWithType;
            }
        }
        private bool f_getRandomExplorerMazeMonster;
        private int _getRandomExplorerMazeMonster;

        /// <summary>
        /// Checks if any enemy monsters on the floor have the behavior BEHAVIOR_EXPLORER_MAZE_1, 
        /// BEHAVIOR_EXPLORER_MAZE_2, BEHAVIOR_EXPLORER_MAZE_3 or BEHAVIOR_EXPLORER_MAZE_4 and returns
        /// one at random. If none can be found, it returns NULL.
        /// 
        /// return: monster entity pointer
        /// </summary>
        public int GetRandomExplorerMazeMonster
        {
            get
            {
                if (f_getRandomExplorerMazeMonster)
                    return _getRandomExplorerMazeMonster;
                _getRandomExplorerMazeMonster = (int) (120516);
                f_getRandomExplorerMazeMonster = true;
                return _getRandomExplorerMazeMonster;
            }
        }
        private bool f_areLateGameTrapsEnabled;
        private int _areLateGameTrapsEnabled;

        /// <summary>
        /// Check if late-game traps (Summon, Pitfall, and Pokémon traps) work in the given fixed room.
        /// 
        /// Or disabled? This function, which Irdkwia's notes label as a disable check, check the struct field labeled in End's notes as an enable flag.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int AreLateGameTrapsEnabled
        {
            get
            {
                if (f_areLateGameTrapsEnabled)
                    return _areLateGameTrapsEnabled;
                _areLateGameTrapsEnabled = (int) (425004);
                f_areLateGameTrapsEnabled = true;
                return _areLateGameTrapsEnabled;
            }
        }
        private bool f_getLoadedAttackSpriteId;
        private int _getLoadedAttackSpriteId;

        /// <summary>
        /// Get the sprite ID (in the loaded WAN list) of the currently loaded attack sprite, or 0 if none.
        /// 
        /// return: sprite ID
        /// </summary>
        public int GetLoadedAttackSpriteId
        {
            get
            {
                if (f_getLoadedAttackSpriteId)
                    return _getLoadedAttackSpriteId;
                _getLoadedAttackSpriteId = (int) (109884);
                f_getLoadedAttackSpriteId = true;
                return _getLoadedAttackSpriteId;
            }
        }
        private bool f_handleFloorCard;
        private int _handleFloorCard;

        /// <summary>
        /// Handles the display of the splash screen between floors showing the dungeon name and the current floor.
        /// 
        /// Seems to enter a loop where it calls AdvanceFrame until the desired number of frames is waited or A is pressed.
        /// 
        /// r0: dungeon_id
        /// r1: floor
        /// r2: duration
        /// r3: enum hidden_stairs_type
        /// </summary>
        public int HandleFloorCard
        {
            get
            {
                if (f_handleFloorCard)
                    return _handleFloorCard;
                _handleFloorCard = (int) (441780);
                f_handleFloorCard = true;
                return _handleFloorCard;
            }
        }
        private bool f_tryInflictInvisibleStatus;
        private int _tryInflictInvisibleStatus;

        /// <summary>
        /// Attempts to turn the target invisible.
        /// 
        /// The user pointer is only used when calling LogMessage functions.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictInvisibleStatus
        {
            get
            {
                if (f_tryInflictInvisibleStatus)
                    return _tryInflictInvisibleStatus;
                _tryInflictInvisibleStatus = (int) (237936);
                f_tryInflictInvisibleStatus = true;
                return _tryInflictInvisibleStatus;
            }
        }
        private bool f_tryInflictWhifferStatus;
        private int _tryInflictWhifferStatus;

        /// <summary>
        /// Inflicts the Whiffer status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictWhifferStatus
        {
            get
            {
                if (f_tryInflictWhifferStatus)
                    return _tryInflictWhifferStatus;
                _tryInflictWhifferStatus = (int) (235512);
                f_tryInflictWhifferStatus = true;
                return _tryInflictWhifferStatus;
            }
        }
        private bool f_tryInflictHealBlockStatus;
        private int _tryInflictHealBlockStatus;

        /// <summary>
        /// Inflicts the Heal Block status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log message
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictHealBlockStatus
        {
            get
            {
                if (f_tryInflictHealBlockStatus)
                    return _tryInflictHealBlockStatus;
                _tryInflictHealBlockStatus = (int) (246168);
                f_tryInflictHealBlockStatus = true;
                return _tryInflictHealBlockStatus;
            }
        }
        private bool f_applyGinsengEffect;
        private int _applyGinsengEffect;

        /// <summary>
        /// Boosts the power of the move at the top of the target's Move List. Appears to have a
        /// leftover check to boost the power of a move by 3 instead of 1 that always fails because
        /// the chance is 0.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyGinsengEffect
        {
            get
            {
                if (f_applyGinsengEffect)
                    return _applyGinsengEffect;
                _applyGinsengEffect = (int) (264780);
                f_applyGinsengEffect = true;
                return _applyGinsengEffect;
            }
        }
        private bool f_freeTeamStatsWrapper;
        private int _freeTeamStatsWrapper;

        /// <summary>
        /// Calls a function that calls FreeTeamStats in overlay10.
        /// 
        /// return: always 1, seems unused
        /// </summary>
        public int FreeTeamStatsWrapper
        {
            get
            {
                if (f_freeTeamStatsWrapper)
                    return _freeTeamStatsWrapper;
                _freeTeamStatsWrapper = (int) (49008);
                f_freeTeamStatsWrapper = true;
                return _freeTeamStatsWrapper;
            }
        }
        private bool f_freeTopScreenStatus;
        private int _freeTopScreenStatus;

        /// <summary>
        /// Gets called when leaving dungeon mode, calls FreeTopScreen and then also frees the allocated memory to the top_screen_status struct.
        /// 
        /// No params.
        /// </summary>
        public int FreeTopScreenStatus
        {
            get
            {
                if (f_freeTopScreenStatus)
                    return _freeTopScreenStatus;
                _freeTopScreenStatus = (int) (48332);
                f_freeTopScreenStatus = true;
                return _freeTopScreenStatus;
            }
        }
        private bool f_teamMemberHasExclusiveItemEffectActive;
        private int _teamMemberHasExclusiveItemEffectActive;

        /// <summary>
        /// Checks if any team member is under the effects of a certain exclusive item effect.
        /// 
        /// r0: exclusive item effect ID
        /// return: bool
        /// </summary>
        public int TeamMemberHasExclusiveItemEffectActive
        {
            get
            {
                if (f_teamMemberHasExclusiveItemEffectActive)
                    return _teamMemberHasExclusiveItemEffectActive;
                _teamMemberHasExclusiveItemEffectActive = (int) (210076);
                f_teamMemberHasExclusiveItemEffectActive = true;
                return _teamMemberHasExclusiveItemEffectActive;
            }
        }
        private bool f_shouldDisplayEntityWrapper;
        private int _shouldDisplayEntityWrapper;

        /// <summary>
        /// Calls ShouldDisplayEntity with r1 = 0
        /// 
        /// r0: Entity pointer
        /// return: True if the entity and its associated messages should be displayed, false if they shouldn't.
        /// </summary>
        public int ShouldDisplayEntityWrapper
        {
            get
            {
                if (f_shouldDisplayEntityWrapper)
                    return _shouldDisplayEntityWrapper;
                _shouldDisplayEntityWrapper = (int) (25824);
                f_shouldDisplayEntityWrapper = true;
                return _shouldDisplayEntityWrapper;
            }
        }
        private bool f_runDungeon;
        private int _runDungeon;

        /// <summary>
        /// Called at the start of a dungeon. Initializes the dungeon struct from specified dungeon data. Includes a loop that does not break until the dungeon is cleared, and another one inside it that runs until the current floor ends.
        /// 
        /// r0: Pointer to the struct containing info used to initialize the dungeon. See type dungeon_init for details.
        /// r1: Pointer to the dungeon data struct that will be used during the dungeon.
        /// </summary>
        public int RunDungeon
        {
            get
            {
                if (f_runDungeon)
                    return _runDungeon;
                _runDungeon = (int) (11512);
                f_runDungeon = true;
                return _runDungeon;
            }
        }
        private bool f_logMessageWithPopupCheckUser;
        private int _logMessageWithPopupCheckUser;

        /// <summary>
        /// Logs a message in the message log alongside a message popup, if the user hasn't fainted.
        /// 
        /// r0: user entity pointer
        /// r1: message string
        /// </summary>
        public int LogMessageWithPopupCheckUser
        {
            get
            {
                if (f_logMessageWithPopupCheckUser)
                    return _logMessageWithPopupCheckUser;
                _logMessageWithPopupCheckUser = (int) (453748);
                f_logMessageWithPopupCheckUser = true;
                return _logMessageWithPopupCheckUser;
            }
        }
        private bool f_safeguardIsActive;
        private int _safeguardIsActive;

        /// <summary>
        /// Checks if the monster is under the effect of Safeguard.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message
        /// return: bool
        /// </summary>
        public int SafeguardIsActive
        {
            get
            {
                if (f_safeguardIsActive)
                    return _safeguardIsActive;
                _safeguardIsActive = (int) (153036);
                f_safeguardIsActive = true;
                return _safeguardIsActive;
            }
        }
        private bool f_tryActivateSteadfast;
        private int _tryActivateSteadfast;

        /// <summary>
        /// Activate the Steadfast ability on the defender, if the monster has it and it's active.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// </summary>
        public int TryActivateSteadfast
        {
            get
            {
                if (f_tryActivateSteadfast)
                    return _tryActivateSteadfast;
                _tryActivateSteadfast = (int) (257872);
                f_tryActivateSteadfast = true;
                return _tryActivateSteadfast;
            }
        }
        private bool f_resetDamageData;
        private int _resetDamageData;

        /// <summary>
        /// Zeroes the damage data struct, which is output by the damage calculation function.
        /// 
        /// r0: damage data pointer
        /// </summary>
        public int ResetDamageData
        {
            get
            {
                if (f_resetDamageData)
                    return _resetDamageData;
                _resetDamageData = (int) (109340);
                f_resetDamageData = true;
                return _resetDamageData;
            }
        }
        private bool f_updateShouldBoostHiddenStairsSpawnChance;
        private int _updateShouldBoostHiddenStairsSpawnChance;

        /// <summary>
        /// Sets the boost_hidden_stairs_spawn_chance field on the dungeon struct depending on if a team member has the exclusive item effect for more hidden stairs.
        /// 
        /// No params.
        /// </summary>
        public int UpdateShouldBoostHiddenStairsSpawnChance
        {
            get
            {
                if (f_updateShouldBoostHiddenStairsSpawnChance)
                    return _updateShouldBoostHiddenStairsSpawnChance;
                _updateShouldBoostHiddenStairsSpawnChance = (int) (377088);
                f_updateShouldBoostHiddenStairsSpawnChance = true;
                return _updateShouldBoostHiddenStairsSpawnChance;
            }
        }
        private bool f_getEntityNaturalGiftInfo;
        private int _getEntityNaturalGiftInfo;

        /// <summary>
        /// Gets the relevant entry in NATURAL_GIFT_ITEM_TABLE based on the entity's held item, if possible.
        /// 
        /// r0: entity pointer
        /// return: pointer to a struct natural_gift_item_info, or null if none was found
        /// </summary>
        public int GetEntityNaturalGiftInfo
        {
            get
            {
                if (f_getEntityNaturalGiftInfo)
                    return _getEntityNaturalGiftInfo;
                _getEntityNaturalGiftInfo = (int) (256640);
                f_getEntityNaturalGiftInfo = true;
                return _getEntityNaturalGiftInfo;
            }
        }
        private bool f_endFrozenClassStatus;
        private int _endFrozenClassStatus;

        /// <summary>
        /// Cures the target's freeze, shadow hold, ingrain, petrified, constriction or wrap (both as user and as target) status due to the action of the user.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// r2: if true, the event will be printed to the log
        /// </summary>
        public int EndFrozenClassStatus
        {
            get
            {
                if (f_endFrozenClassStatus)
                    return _endFrozenClassStatus;
                _endFrozenClassStatus = (int) (171720);
                f_endFrozenClassStatus = true;
                return _endFrozenClassStatus;
            }
        }
        private bool f_tryInflictSafeguardStatus;
        private int _tryInflictSafeguardStatus;

        /// <summary>
        /// Inflicts the Safeguard status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictSafeguardStatus
        {
            get
            {
                if (f_tryInflictSafeguardStatus)
                    return _tryInflictSafeguardStatus;
                _tryInflictSafeguardStatus = (int) (248416);
                f_tryInflictSafeguardStatus = true;
                return _tryInflictSafeguardStatus;
            }
        }
        private bool f_tryNonLeaderItemPickUp;
        private int _tryNonLeaderItemPickUp;

        /// <summary>
        /// Similar to TryLeaderItemPickUp, but for other monsters.
        /// 
        /// Used both for enemies and team members.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int TryNonLeaderItemPickUp
        {
            get
            {
                if (f_tryNonLeaderItemPickUp)
                    return _tryNonLeaderItemPickUp;
                _tryNonLeaderItemPickUp = (int) (208320);
                f_tryNonLeaderItemPickUp = true;
                return _tryNonLeaderItemPickUp;
            }
        }
        private bool f_logItemBlockedByEmbargo;
        private int _logItemBlockedByEmbargo;

        /// <summary>
        /// Logs the error message when the usage of an item is blocked by Embargo.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int LogItemBlockedByEmbargo
        {
            get
            {
                if (f_logItemBlockedByEmbargo)
                    return _logItemBlockedByEmbargo;
                _logItemBlockedByEmbargo = (int) (246512);
                f_logItemBlockedByEmbargo = true;
                return _logItemBlockedByEmbargo;
            }
        }
        private bool f_tryBlowAway;
        private int _tryBlowAway;

        /// <summary>
        /// Blows away the target monster in a given direction if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: direction ID
        /// </summary>
        public int TryBlowAway
        {
            get
            {
                if (f_tryBlowAway)
                    return _tryBlowAway;
                _tryBlowAway = (int) (276908);
                f_tryBlowAway = true;
                return _tryBlowAway;
            }
        }
        private bool f_createMonsterSummaryFromMonster;
        private int _createMonsterSummaryFromMonster;

        /// <summary>
        /// Creates a snapshot of the condition of a monster struct in a monster_summary struct.
        /// 
        /// r0: [output] monster_summary
        /// r1: monster
        /// </summary>
        public int CreateMonsterSummaryFromMonster
        {
            get
            {
                if (f_createMonsterSummaryFromMonster)
                    return _createMonsterSummaryFromMonster;
                _createMonsterSummaryFromMonster = (int) (116400);
                f_createMonsterSummaryFromMonster = true;
                return _createMonsterSummaryFromMonster;
            }
        }
        private bool f_isChargingAnyTwoTurnMove;
        private int _isChargingAnyTwoTurnMove;

        /// <summary>
        /// Returns a boolean indicating whether or not the given entity is charging any two-turn move.
        /// 
        /// r0: Entity pointer
        /// r1: Unused boolean which was supposed to make function return true if the entity is under the effect of Charge (the Electric-type move).
        ///     However, the conditional which uses this boolean will never be activated, as the loop will always terminate before getting to it.
        /// return: bool
        /// </summary>
        public int IsChargingAnyTwoTurnMove
        {
            get
            {
                if (f_isChargingAnyTwoTurnMove)
                    return _isChargingAnyTwoTurnMove;
                _isChargingAnyTwoTurnMove = (int) (295372);
                f_isChargingAnyTwoTurnMove = true;
                return _isChargingAnyTwoTurnMove;
            }
        }
        private bool f_clearMonsterActionFields;
        private int _clearMonsterActionFields;

        /// <summary>
        /// Clears the fields related to AI in the monster's data struct, setting them all to 0.
        /// Specifically, monster::action::action_id, monster::action::action_use_idx and monster::action::field_0xA are cleared.
        /// 
        /// r0: Pointer to the monster's action field
        /// </summary>
        public int ClearMonsterActionFields
        {
            get
            {
                if (f_clearMonsterActionFields)
                    return _clearMonsterActionFields;
                _clearMonsterActionFields = (int) (61820);
                f_clearMonsterActionFields = true;
                return _clearMonsterActionFields;
            }
        }
        private bool f_getMonsterLevelToSpawn;
        private int _getMonsterLevelToSpawn;

        /// <summary>
        /// Get the level of the monster to be spawned, given its id.
        /// 
        /// r0: monster ID
        /// return: Level of the monster to be spawned, or 1 if the specified ID can't be found on the floor's spawn table.
        /// </summary>
        public int GetMonsterLevelToSpawn
        {
            get
            {
                if (f_getMonsterLevelToSpawn)
                    return _getMonsterLevelToSpawn;
                _getMonsterLevelToSpawn = (int) (48096);
                f_getMonsterLevelToSpawn = true;
                return _getMonsterLevelToSpawn;
            }
        }
        private bool f_displayItemTip;
        private int _displayItemTip;

        /// <summary>
        /// Display the dungeon tip if not already displayed matching the (presumably newly acquired) item
        /// 
        /// r0: item id
        /// return: 1 if a tip has been displayed, 0 otherwise
        /// </summary>
        public int DisplayItemTip
        {
            get
            {
                if (f_displayItemTip)
                    return _displayItemTip;
                _displayItemTip = (int) (460344);
                f_displayItemTip = true;
                return _displayItemTip;
            }
        }
        private bool f_setShouldBoostHiddenStairsSpawnChance;
        private int _setShouldBoostHiddenStairsSpawnChance;

        /// <summary>
        /// Sets the boost_hidden_stairs_spawn_chance field on the dungeon struct to the given value.
        /// 
        /// r0: bool to set the flag to
        /// </summary>
        public int SetShouldBoostHiddenStairsSpawnChance
        {
            get
            {
                if (f_setShouldBoostHiddenStairsSpawnChance)
                    return _setShouldBoostHiddenStairsSpawnChance;
                _setShouldBoostHiddenStairsSpawnChance = (int) (377064);
                f_setShouldBoostHiddenStairsSpawnChance = true;
                return _setShouldBoostHiddenStairsSpawnChance;
            }
        }
        private bool f_deleteAllMonsterSpriteFiles;
        private int _deleteAllMonsterSpriteFiles;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int DeleteAllMonsterSpriteFiles
        {
            get
            {
                if (f_deleteAllMonsterSpriteFiles)
                    return _deleteAllMonsterSpriteFiles;
                _deleteAllMonsterSpriteFiles = (int) (111844);
                f_deleteAllMonsterSpriteFiles = true;
                return _deleteAllMonsterSpriteFiles;
            }
        }
        private bool f_displayActions;
        private int _displayActions;

        /// <summary>
        /// Graphically displays any pending actions that have happened but haven't been shown on screen yet. All actions are displayed at the same time. For example, this delayed display system is used to display multiple monsters moving at once even though they take turns sequentially.
        /// 
        /// r0: Pointer to an entity. Can be null.
        /// return: Seems to be true if there were any pending actions to display.
        /// </summary>
        public int DisplayActions
        {
            get
            {
                if (f_displayActions)
                    return _displayActions;
                _displayActions = (int) (166992);
                f_displayActions = true;
                return _displayActions;
            }
        }
        private bool f_displayMessage;
        private int _displayMessage;

        /// <summary>
        /// Displays a message in a dialogue box that optionally waits for player input before closing.
        /// 
        /// r0: pointer to the structure representing the desired state of the portrait
        /// r1: ID of the string to display
        /// r2: True to wait for player input before closing the dialogue box, false to close it automatically once all the characters get printed.
        /// </summary>
        public int DisplayMessage
        {
            get
            {
                if (f_displayMessage)
                    return _displayMessage;
                _displayMessage = (int) (461828);
                f_displayMessage = true;
                return _displayMessage;
            }
        }
        private bool f_tryGenerateUnownStoneDrop;
        private int _tryGenerateUnownStoneDrop;

        /// <summary>
        /// Determine if a defeated monster should drop a Unown Stone, and generate the item if so.
        /// 
        /// Checks that the current dungeon isn't a Marowak Dojo training maze, and that the monster is an Unown. If so, there's a 21% chance that an Unown Stone will be generated.
        /// 
        /// r0: [output] item
        /// r1: monster ID
        /// return: whether or not an Unown Stone was generated
        /// </summary>
        public int TryGenerateUnownStoneDrop
        {
            get
            {
                if (f_tryGenerateUnownStoneDrop)
                    return _tryGenerateUnownStoneDrop;
                _tryGenerateUnownStoneDrop = (int) (432964);
                f_tryGenerateUnownStoneDrop = true;
                return _tryGenerateUnownStoneDrop;
            }
        }
        private bool f_runDungeonMode;
        private int _runDungeonMode;

        /// <summary>
        /// This appears to be the top-level function for running dungeon mode.
        /// 
        /// It gets called by MainGame right after doing the dungeon fade transition, and once it exits, the dungeon results are processed.
        /// 
        /// This function is presumably in charge of allocating the dungeon struct, setting it up, launching the dungeon engine, etc.
        /// </summary>
        public int RunDungeonMode
        {
            get
            {
                if (f_runDungeonMode)
                    return _runDungeonMode;
                _runDungeonMode = (int) (456876);
                f_runDungeonMode = true;
                return _runDungeonMode;
            }
        }
        private bool f_isTargetInRange;
        private int _isTargetInRange;

        /// <summary>
        /// Returns true if the target is within range of the user's move, false otherwise.
        /// 
        /// If the user does not have Course Checker, it simply checks if the distance between user and target is less or equal than the move range.
        /// Otherwise, it will iterate through all tiles in the direction specified, checking for walls or other monsters in the way, and return false if they are found.
        /// 
        /// r0: user pointer
        /// r1: target pointer
        /// r2: direction ID
        /// r3: move range (in number of tiles)
        /// </summary>
        public int IsTargetInRange
        {
            get
            {
                if (f_isTargetInRange)
                    return _isTargetInRange;
                _isTargetInRange = (int) (254596);
                f_isTargetInRange = true;
                return _isTargetInRange;
            }
        }
        private bool f_buildMoveTargetList;
        private int _buildMoveTargetList;

        /// <summary>
        /// Builds the list of targets of a given move for a given user
        /// 
        /// r0: [output] Buffer where the resulting list should be stored
        /// r1: Pointer to entity using the move
        /// r2: Pointer to move data
        /// </summary>
        public int BuildMoveTargetList
        {
            get
            {
                if (f_buildMoveTargetList)
                    return _buildMoveTargetList;
                _buildMoveTargetList = (int) (293856);
                f_buildMoveTargetList = true;
                return _buildMoveTargetList;
            }
        }
        private bool f_canMonsterMoveInDirection;
        private int _canMonsterMoveInDirection;

        /// <summary>
        /// Checks if the given monster can move in the specified direction
        /// 
        /// Returns false if any monster is standing on the target tile
        /// 
        /// r0: Monster entity pointer
        /// r1: Direction to check
        /// return: bool
        /// </summary>
        public int CanMonsterMoveInDirection
        {
            get
            {
                if (f_canMonsterMoveInDirection)
                    return _canMonsterMoveInDirection;
                _canMonsterMoveInDirection = (int) (149884);
                f_canMonsterMoveInDirection = true;
                return _canMonsterMoveInDirection;
            }
        }
        private bool f_getItemToRetrieve;
        private int _getItemToRetrieve;

        /// <summary>
        /// Get the ID of the item that needs to be retrieve on the current floor for a mission, if one exists.
        /// 
        /// return: item ID
        /// </summary>
        public int GetItemToRetrieve
        {
            get
            {
                if (f_getItemToRetrieve)
                    return _getItemToRetrieve;
                _getItemToRetrieve = (int) (446228);
                f_getItemToRetrieve = true;
                return _getItemToRetrieve;
            }
        }
        private bool f_setHiddenStairsField;
        private int _setHiddenStairsField;

        /// <summary>
        /// Sets the hidden_stairs_type variable from dungeon::dungeon_generation_info to a certain value.
        /// 
        /// r0: New value
        /// </summary>
        public int SetHiddenStairsField
        {
            get
            {
                if (f_setHiddenStairsField)
                    return _setHiddenStairsField;
                _setHiddenStairsField = (int) (377676);
                f_setHiddenStairsField = true;
                return _setHiddenStairsField;
            }
        }
        private bool f_isMonsterMuzzled;
        private int _isMonsterMuzzled;

        /// <summary>
        /// Checks if a monster has the muzzled status.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int IsMonsterMuzzled
        {
            get
            {
                if (f_isMonsterMuzzled)
                    return _isMonsterMuzzled;
                _isMonsterMuzzled = (int) (147712);
                f_isMonsterMuzzled = true;
                return _isMonsterMuzzled;
            }
        }
        private bool f_tryInflictDecoyStatus;
        private int _tryInflictDecoyStatus;

        /// <summary>
        /// Inflicts the Decoy status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictDecoyStatus
        {
            get
            {
                if (f_tryInflictDecoyStatus)
                    return _tryInflictDecoyStatus;
                _tryInflictDecoyStatus = (int) (236060);
                f_tryInflictDecoyStatus = true;
                return _tryInflictDecoyStatus;
            }
        }
        private bool f_tryInflictTauntStatus;
        private int _tryInflictTauntStatus;

        /// <summary>
        /// Inflicts the Taunt status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictTauntStatus
        {
            get
            {
                if (f_tryInflictTauntStatus)
                    return _tryInflictTauntStatus;
                _tryInflictTauntStatus = (int) (237472);
                f_tryInflictTauntStatus = true;
                return _tryInflictTauntStatus;
            }
        }
        private bool f_isFloating;
        private int _isFloating;

        /// <summary>
        /// Checks if a monster is currently floating for reasons other than its typing or ability.
        /// 
        /// In particular, this checks for Gravity and Magnet Rise.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int IsFloating
        {
            get
            {
                if (f_isFloating)
                    return _isFloating;
                _isFloating = (int) (247356);
                f_isFloating = true;
                return _isFloating;
            }
        }
        private bool f_endBurnClassStatus;
        private int _endBurnClassStatus;

        /// <summary>
        /// Cures the target's burned, poisoned, badly poisoned or paralysis status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndBurnClassStatus
        {
            get
            {
                if (f_endBurnClassStatus)
                    return _endBurnClassStatus;
                _endBurnClassStatus = (int) (171544);
                f_endBurnClassStatus = true;
                return _endBurnClassStatus;
            }
        }
        private bool f_getIdleAnimationId;
        private int _getIdleAnimationId;

        /// <summary>
        /// Returns the animation id to be applied to a monster that is currently idling.
        /// 
        /// Returns a different animation for monsters with the sleep, napping, nightmare or bide status, as well as for sudowoodo and for monsters with infinite sleep turns (0x7F).
        /// 
        /// r0: pointer to entity
        /// return: animation ID
        /// </summary>
        public int GetIdleAnimationId
        {
            get
            {
                if (f_getIdleAnimationId)
                    return _getIdleAnimationId;
                _getIdleAnimationId = (int) (165668);
                f_getIdleAnimationId = true;
                return _getIdleAnimationId;
            }
        }
        private bool f_runLeaderTurn;
        private int _runLeaderTurn;

        /// <summary>
        /// Handles the leader's turn. Includes a movement speed check that might cause it to return early if the leader isn't fast enough to act in this fractional turn. If that check (and some others) pass, the function does not return until the leader performs an action.
        /// 
        /// r0: ?
        /// return: true if the leader has performed an action
        /// </summary>
        public int RunLeaderTurn
        {
            get
            {
                if (f_runLeaderTurn)
                    return _runLeaderTurn;
                _runLeaderTurn = (int) (65680);
                f_runLeaderTurn = true;
                return _runLeaderTurn;
            }
        }
        private bool f_playEffectAnimation0x18E;
        private int _playEffectAnimation0x18E;

        /// <summary>
        /// Just a guess. Calls PlayEffectAnimation with data from animation ID 0x18E.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int PlayEffectAnimation0x18E
        {
            get
            {
                if (f_playEffectAnimation0x18E)
                    return _playEffectAnimation0x18E;
                _playEffectAnimation0x18E = (int) (41320);
                f_playEffectAnimation0x18E = true;
                return _playEffectAnimation0x18E;
            }
        }
        private bool f_tryActivateNondamagingDefenderAbility;
        private int _tryActivateNondamagingDefenderAbility;

        /// <summary>
        /// Applies the effects of a defender's ability on an attacker. After a move is used,
        /// this function is called to see if any of the bitflags for an ability were set and
        /// applies the corresponding effect. (The way leech seed removes certain statuses is
        /// also handled here.)
        /// 
        /// r0: entity pointer
        /// </summary>
        public int TryActivateNondamagingDefenderAbility
        {
            get
            {
                if (f_tryActivateNondamagingDefenderAbility)
                    return _tryActivateNondamagingDefenderAbility;
                _tryActivateNondamagingDefenderAbility = (int) (284228);
                f_tryActivateNondamagingDefenderAbility = true;
                return _tryActivateNondamagingDefenderAbility;
            }
        }
        private bool f_generateRoomImperfections;
        private int _generateRoomImperfections;

        /// <summary>
        /// Attempt to generate room imperfections for each room in the floor layout, if enabled.
        /// 
        /// Each room has a 40% chance of having imperfections if its grid cell is flagged to allow room imperfections. Imperfections are generated by randomly growing the walls of the room inwards for a certain number of iterations, starting from the corners.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// </summary>
        public int GenerateRoomImperfections
        {
            get
            {
                if (f_generateRoomImperfections)
                    return _generateRoomImperfections;
                _generateRoomImperfections = (int) (403476);
                f_generateRoomImperfections = true;
                return _generateRoomImperfections;
            }
        }
        private bool f_swapMonsterWanFileIndex;
        private int _swapMonsterWanFileIndex;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: src_id
        /// r1: dst_id
        /// </summary>
        public int SwapMonsterWanFileIndex
        {
            get
            {
                if (f_swapMonsterWanFileIndex)
                    return _swapMonsterWanFileIndex;
                _swapMonsterWanFileIndex = (int) (111288);
                f_swapMonsterWanFileIndex = true;
                return _swapMonsterWanFileIndex;
            }
        }
        private bool f_resetHiddenStairsSpawn;
        private int _resetHiddenStairsSpawn;

        /// <summary>
        /// Resets hidden stairs spawn information for the floor. This includes the position on the floor generation status as well as the flag indicating whether the spawn was blocked.
        /// 
        /// No params.
        /// </summary>
        public int ResetHiddenStairsSpawn
        {
            get
            {
                if (f_resetHiddenStairsSpawn)
                    return _resetHiddenStairsSpawn;
                _resetHiddenStairsSpawn = (int) (420332);
                f_resetHiddenStairsSpawn = true;
                return _resetHiddenStairsSpawn;
            }
        }
        private bool f_updateShouldBoostKecleonShopSpawnChance;
        private int _updateShouldBoostKecleonShopSpawnChance;

        /// <summary>
        /// Sets the boost_kecleon_shop_spawn_chance field on the dungeon struct depending on if a team member has the exclusive item effect for more kecleon shops.
        /// 
        /// No params.
        /// </summary>
        public int UpdateShouldBoostKecleonShopSpawnChance
        {
            get
            {
                if (f_updateShouldBoostKecleonShopSpawnChance)
                    return _updateShouldBoostKecleonShopSpawnChance;
                _updateShouldBoostKecleonShopSpawnChance = (int) (376788);
                f_updateShouldBoostKecleonShopSpawnChance = true;
                return _updateShouldBoostKecleonShopSpawnChance;
            }
        }
        private bool f_tryInflictBurnStatus;
        private int _tryInflictBurnStatus;

        /// <summary>
        /// Inflicts the Burn status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to apply some special effect alongside the burn?
        /// r3: flag to log a message on failure
        /// stack[0]: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictBurnStatus
        {
            get
            {
                if (f_tryInflictBurnStatus)
                    return _tryInflictBurnStatus;
                _tryInflictBurnStatus = (int) (221016);
                f_tryInflictBurnStatus = true;
                return _tryInflictBurnStatus;
            }
        }
        private bool f_isFloorOver;
        private int _isFloorOver;

        /// <summary>
        /// Checks if the current floor should end, and updates dungeon::floor_loop_status if required.
        /// If the player has been defeated, sets dungeon::floor_loop_status to floor_loop_status::FLOOR_LOOP_LEADER_FAINTED.
        /// If dungeon::end_floor_flag is 1 or 2, sets dungeon::floor_loop_status to floor_loop_status::FLOOR_LOOP_NEXT_FLOOR.
        /// 
        /// return: true if the current floor should end
        /// </summary>
        public int IsFloorOver
        {
            get
            {
                if (f_isFloorOver)
                    return _isFloorOver;
                _isFloorOver = (int) (66928);
                f_isFloorOver = true;
                return _isFloorOver;
            }
        }
        private bool f_canTargetEntity;
        private int _canTargetEntity;

        /// <summary>
        /// Checks if a monster can target another entity when controlled by the AI.
        /// More specifically, it checks if the target is invisible, if the user can see invisible monsters, if the user is blinded and if the target position is in sight from the position of the user (this last check is done by calling IsPositionInSight with the user's and the target's position).
        /// This function is almost the same as CanSeeTarget, the only difference is that the latter calls IsPositionActuallyInSight instead.
        /// 
        /// r0: User entity pointer
        /// r1: Target entity pointer
        /// return: True if the user can target the target, false otherwise
        /// </summary>
        public int CanTargetEntity
        {
            get
            {
                if (f_canTargetEntity)
                    return _canTargetEntity;
                _canTargetEntity = (int) (26052);
                f_canTargetEntity = true;
                return _canTargetEntity;
            }
        }
        private bool f_spawnDroppedItem;
        private int _spawnDroppedItem;

        /// <summary>
        /// Used to spawn an item that was thrown or dropped, with a log message.
        /// 
        /// Determines where exactly the item will land, if it bounces on a trap, etc.
        /// Used for thrown items that hit a wall, for certain enemy drops (such as Unown stones or Treasure Boxes), for certain moves (like Pay Day and Knock Off), and possibly other things.
        /// 
        /// r0: entity that dropped or threw the item
        /// r1: item entity. Contains the coordinates where the item should try to land first.
        /// r2: item info
        /// r3: ?
        /// stack[0]: pointer to int16_t[2] for x/y direction (corresponding to DIRECTIONS_XY)
        /// stack[1]: ?
        /// </summary>
        public int SpawnDroppedItem
        {
            get
            {
                if (f_spawnDroppedItem)
                    return _spawnDroppedItem;
                _spawnDroppedItem = (int) (431548);
                f_spawnDroppedItem = true;
                return _spawnDroppedItem;
            }
        }
        private bool f_checkActiveChallengeRequest;
        private int _checkActiveChallengeRequest;

        /// <summary>
        /// Checks if there's an active challenge request on the current dungeon.
        /// 
        /// return: True if there's an active challenge request on the current dungeon in the list of missions.
        /// </summary>
        public int CheckActiveChallengeRequest
        {
            get
            {
                if (f_checkActiveChallengeRequest)
                    return _checkActiveChallengeRequest;
                _checkActiveChallengeRequest = (int) (445332);
                f_checkActiveChallengeRequest = true;
                return _checkActiveChallengeRequest;
            }
        }
        private bool f_getMoveAnimationId;
        private int _getMoveAnimationId;

        /// <summary>
        /// Returns the move animation ID that should be played for a move.
        /// It contains a check for weather ball. After that, if the parameter should_play_alternative_animation is false, the move ID is returned. If it's true, there's a bunch of manual ID checks that result on a certain hardcoded return value.
        /// 
        /// r0: Move ID
        /// r1: Apparent weather for the monster who used the move
        /// r2: Result of ShouldMovePlayADifferentAnimation
        /// return: Move animation ID
        /// </summary>
        public int GetMoveAnimationId
        {
            get
            {
                if (f_getMoveAnimationId)
                    return _getMoveAnimationId;
                _getMoveAnimationId = (int) (300732);
                f_getMoveAnimationId = true;
                return _getMoveAnimationId;
            }
        }
        private bool f_isHiddenStairsFloor;
        private int _isHiddenStairsFloor;

        /// <summary>
        /// Checks if the current floor is either the Secret Bazaar or a Secret Room.
        /// 
        /// return: bool
        /// </summary>
        public int IsHiddenStairsFloor
        {
            get
            {
                if (f_isHiddenStairsFloor)
                    return _isHiddenStairsFloor;
                _isHiddenStairsFloor = (int) (425968);
                f_isHiddenStairsFloor = true;
                return _isHiddenStairsFloor;
            }
        }
        private bool f_applyTripTrapEffect;
        private int _applyTripTrapEffect;

        /// <summary>
        /// Tries to drop the defender's item and places it on the floor.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int ApplyTripTrapEffect
        {
            get
            {
                if (f_applyTripTrapEffect)
                    return _applyTripTrapEffect;
                _applyTripTrapEffect = (int) (76448);
                f_applyTripTrapEffect = true;
                return _applyTripTrapEffect;
            }
        }
        private bool f_isProtectedFromNegativeStatus;
        private int _isProtectedFromNegativeStatus;

        /// <summary>
        /// Checks if the target monster is protected from getting a negative status condition.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message
        /// return: bool
        /// </summary>
        public int IsProtectedFromNegativeStatus
        {
            get
            {
                if (f_isProtectedFromNegativeStatus)
                    return _isProtectedFromNegativeStatus;
                _isProtectedFromNegativeStatus = (int) (155808);
                f_isProtectedFromNegativeStatus = true;
                return _isProtectedFromNegativeStatus;
            }
        }
        private bool f_calcDamageFixedNoCategory;
        private int _calcDamageFixedNoCategory;

        /// <summary>
        /// A wrapper around CalcDamageFixed with the move category set to none.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: fixed damage
        /// r3: experience flag (see ApplyDamage)
        /// stack[0]: [output] struct containing info about the damage calculation
        /// stack[1]: attack type
        /// stack[2]: damage source
        /// stack[3]: damage message
        /// others: ?
        /// </summary>
        public int CalcDamageFixedNoCategory
        {
            get
            {
                if (f_calcDamageFixedNoCategory)
                    return _calcDamageFixedNoCategory;
                _calcDamageFixedNoCategory = (int) (200708);
                f_calcDamageFixedNoCategory = true;
                return _calcDamageFixedNoCategory;
            }
        }
        private bool f_tryInflictWishStatus;
        private int _tryInflictWishStatus;

        /// <summary>
        /// Inflicts the Wish status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictWishStatus
        {
            get
            {
                if (f_tryInflictWishStatus)
                    return _tryInflictWishStatus;
                _tryInflictWishStatus = (int) (248732);
                f_tryInflictWishStatus = true;
                return _tryInflictWishStatus;
            }
        }
        private bool f_applyHungerSeedEffect;
        private int _applyHungerSeedEffect;

        /// <summary>
        /// Empties the targets belly to cause Hungry Pal status in non-leader monsters and
        /// Famished in the leader monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyHungerSeedEffect
        {
            get
            {
                if (f_applyHungerSeedEffect)
                    return _applyHungerSeedEffect;
                _applyHungerSeedEffect = (int) (264320);
                f_applyHungerSeedEffect = true;
                return _applyHungerSeedEffect;
            }
        }
        private bool f_tryIncreaseBelly;
        private int _tryIncreaseBelly;

        /// <summary>
        /// Restore belly and possibly boost max belly of the target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: belly to restore
        /// r3: max belly boost (if belly is full)
        /// stack[0]: flag to log a message
        /// </summary>
        public int TryIncreaseBelly
        {
            get
            {
                if (f_tryIncreaseBelly)
                    return _tryIncreaseBelly;
                _tryIncreaseBelly = (int) (239520);
                f_tryIncreaseBelly = true;
                return _tryIncreaseBelly;
            }
        }
        private bool f_ensureConnectedGrid;
        private int _ensureConnectedGrid;

        /// <summary>
        /// Ensure the grid forms a connected graph (all valid cells are reachable) by adding hallways to unreachable grid cells.
        /// 
        /// If a grid cell cannot be connected for some reason, remove it entirely.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: array of the starting x coordinates of each grid column
        /// stack[0]: array of the starting y coordinates of each grid row
        /// </summary>
        public int EnsureConnectedGrid
        {
            get
            {
                if (f_ensureConnectedGrid)
                    return _ensureConnectedGrid;
                _ensureConnectedGrid = (int) (405252);
                f_ensureConnectedGrid = true;
                return _ensureConnectedGrid;
            }
        }
        private bool f_getChebyshevDistance;
        private int _getChebyshevDistance;

        /// <summary>
        /// Returns the Chebyshev distance between two positions. Calculated as max(abs(x0-x1), abs(y0-y1)).
        /// 
        /// r0: Position A
        /// r1: Position B
        /// return: Chebyshev Distance between position A and position B
        /// </summary>
        public int GetChebyshevDistance
        {
            get
            {
                if (f_getChebyshevDistance)
                    return _getChebyshevDistance;
                _getChebyshevDistance = (int) (52756);
                f_getChebyshevDistance = true;
                return _getChebyshevDistance;
            }
        }
        private bool f_dungeonGetSpriteIndex;
        private int _dungeonGetSpriteIndex;

        /// <summary>
        /// Gets the sprite index of the specified monster on this floor
        /// 
        /// r0: Monster ID
        /// return: Sprite index of the specified monster ID
        /// </summary>
        public int DungeonGetSpriteIndex
        {
            get
            {
                if (f_dungeonGetSpriteIndex)
                    return _dungeonGetSpriteIndex;
                _dungeonGetSpriteIndex = (int) (110708);
                f_dungeonGetSpriteIndex = true;
                return _dungeonGetSpriteIndex;
            }
        }
        private bool f_trySwitchPlace;
        private int _trySwitchPlace;

        /// <summary>
        /// The user entity attempts to switch places with the target entity (i.e. by the effect of the Switcher Orb). 
        /// 
        /// The function checks for the Suction Cups ability for both the user and the target, and for the Mold Breaker ability on the user.
        /// 
        /// r0: pointer to user entity
        /// r1: pointer to target entity
        /// </summary>
        public int TrySwitchPlace
        {
            get
            {
                if (f_trySwitchPlace)
                    return _trySwitchPlace;
                _trySwitchPlace = (int) (61184);
                f_trySwitchPlace = true;
                return _trySwitchPlace;
            }
        }
        private bool f_hiddenStairsPresent;
        private int _hiddenStairsPresent;

        /// <summary>
        /// Checks if the hidden stairs are present on this floor.
        /// 
        /// The function checks that dungeon_generation_info::hidden_stairs_pos isn't (-1, -1)
        /// 
        /// return: True if the hidden stairs are present on this floor, false otherwise.
        /// </summary>
        public int HiddenStairsPresent
        {
            get
            {
                if (f_hiddenStairsPresent)
                    return _hiddenStairsPresent;
                _hiddenStairsPresent = (int) (377276);
                f_hiddenStairsPresent = true;
                return _hiddenStairsPresent;
            }
        }
        private bool f_pointCameraToMonster;
        private int _pointCameraToMonster;

        /// <summary>
        /// Points the camera to the specified monster.
        /// 
        /// r0: Entity pointer
        /// r1: ?
        /// </summary>
        public int PointCameraToMonster
        {
            get
            {
                if (f_pointCameraToMonster)
                    return _pointCameraToMonster;
                _pointCameraToMonster = (int) (27620);
                f_pointCameraToMonster = true;
                return _pointCameraToMonster;
            }
        }
        private bool f_getMonsterName;
        private int _getMonsterName;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// r1: TargetInfo
        /// </summary>
        public int GetMonsterName
        {
            get
            {
                if (f_getMonsterName)
                    return _getMonsterName;
                _getMonsterName = (int) (146520);
                f_getMonsterName = true;
                return _getMonsterName;
            }
        }
        private bool f_animationDelayOrSomething;
        private int _animationDelayOrSomething;

        /// <summary>
        /// Called whenever most (all?) animations are played. Does not return until the animation is over.
        /// 
        /// Might wait until the animation is done? Contains several loops that call AdvanceFrame.
        /// 
        /// r0: ?
        /// </summary>
        public int AnimationDelayOrSomething
        {
            get
            {
                if (f_animationDelayOrSomething)
                    return _animationDelayOrSomething;
                _animationDelayOrSomething = (int) (30320);
                f_animationDelayOrSomething = true;
                return _animationDelayOrSomething;
            }
        }
        private bool f_shouldMinimapDisplayEntity;
        private int _shouldMinimapDisplayEntity;

        /// <summary>
        /// Checks if a given entity should be displayed on the minimap
        /// 
        /// r0: Entity pointer
        /// return: True if the entity should be displayed on the minimap
        /// </summary>
        public int ShouldMinimapDisplayEntity
        {
            get
            {
                if (f_shouldMinimapDisplayEntity)
                    return _shouldMinimapDisplayEntity;
                _shouldMinimapDisplayEntity = (int) (25164);
                f_shouldMinimapDisplayEntity = true;
                return _shouldMinimapDisplayEntity;
            }
        }
        private bool f_iqSkillIsEnabled;
        private int _iqSkillIsEnabled;

        /// <summary>
        /// Checks if a monster has a certain IQ skill enabled.
        /// 
        /// r0: entity pointer
        /// r1: IQ skill ID
        /// return: bool
        /// </summary>
        public int IqSkillIsEnabled
        {
            get
            {
                if (f_iqSkillIsEnabled)
                    return _iqSkillIsEnabled;
                _iqSkillIsEnabled = (int) (154608);
                f_iqSkillIsEnabled = true;
                return _iqSkillIsEnabled;
            }
        }
        private bool f_canAiUseMove;
        private int _canAiUseMove;

        /// <summary>
        /// Checks if an AI-controlled monster can use a move.
        /// Will return false if the any of the flags move::f_exists, move::f_subsequent_in_link_chain or move::f_disabled is true. The function does not check if the flag move::f_enabled_for_ai is set. This function also returns true if the call to CanMonsterUseMove is true.
        /// The function contains a loop that is supposed to check other moves after the specified one, but the loop breaks after it finds a move that isn't linked, which is always true given the checks in place at the start of the function.
        /// 
        /// r0: Entity pointer
        /// r1: Move index
        /// r2: extra_checks parameter when calling CanMonsterUseMove
        /// return: True if the AI can use the move (not accounting for move::f_enabled_for_ai)
        /// </summary>
        public int CanAiUseMove
        {
            get
            {
                if (f_canAiUseMove)
                    return _canAiUseMove;
                _canAiUseMove = (int) (296480);
                f_canAiUseMove = true;
                return _canAiUseMove;
            }
        }
        private bool f_tryIncreaseHp;
        private int _tryIncreaseHp;

        /// <summary>
        /// Restore HP and possibly boost max HP of the target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: HP to restore
        /// r3: max HP boost
        /// stack[0]: flag to log a message on failure
        /// return: Success flag
        /// </summary>
        public int TryIncreaseHp
        {
            get
            {
                if (f_tryIncreaseHp)
                    return _tryIncreaseHp;
                _tryIncreaseHp = (int) (233180);
                f_tryIncreaseHp = true;
                return _tryIncreaseHp;
            }
        }
        private bool f_closeFixedBin;
        private int _closeFixedBin;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int CloseFixedBin
        {
            get
            {
                if (f_closeFixedBin)
                    return _closeFixedBin;
                _closeFixedBin = (int) (424812);
                f_closeFixedBin = true;
                return _closeFixedBin;
            }
        }
        private bool f_areTrawlOrbsAllowed;
        private int _areTrawlOrbsAllowed;

        /// <summary>
        /// Checks if Trawl Orbs work in the given fixed room.
        /// 
        /// Always true if not a full-floor fixed room.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int AreTrawlOrbsAllowed
        {
            get
            {
                if (f_areTrawlOrbsAllowed)
                    return _areTrawlOrbsAllowed;
                _areTrawlOrbsAllowed = (int) (424944);
                f_areTrawlOrbsAllowed = true;
                return _areTrawlOrbsAllowed;
            }
        }
        private bool f_getItemToUse;
        private int _getItemToUse;

        /// <summary>
        /// Returns a pointer to the item that is about to be used by a monster.
        /// 
        /// r0: Entity pointer
        /// r1: Parameter index in monster::action_data::action_parameters. Will be used to use to determine the index of the used item.
        /// r2: Unused
        /// return: Pointer to the item
        /// </summary>
        public int GetItemToUse
        {
            get
            {
                if (f_getItemToUse)
                    return _getItemToUse;
                _getItemToUse = (int) (62164);
                f_getItemToUse = true;
                return _getItemToUse;
            }
        }
        private bool f_displayFloorCard;
        private int _displayFloorCard;

        /// <summary>
        /// Dispatches the splash screen between floors showing the dungeon name and the current floor.
        /// 
        /// First it checks whether the current floor is a secret bazaar or secret room, then it calls HandleFloorCard.
        /// 
        /// r0: Duration in frames
        /// </summary>
        public int DisplayFloorCard
        {
            get
            {
                if (f_displayFloorCard)
                    return _displayFloorCard;
                _displayFloorCard = (int) (441724);
                f_displayFloorCard = true;
                return _displayFloorCard;
            }
        }
        private bool f_spawnStairs;
        private int _spawnStairs;

        /// <summary>
        /// Spawn stairs at the given location.
        /// 
        /// If the hidden stairs type is something other than HIDDEN_STAIRS_NONE, hidden stairs of the specified type will be spawned instead of normal stairs.
        /// 
        /// If spawning normal stairs and the current floor is a rescue floor, the room containing the stairs will be converted into a Monster House.
        /// 
        /// If attempting to spawn hidden stairs but the spawn is blocked, the floor generation status's hidden stairs spawn position will be updated, but it won't be transferred to the dungeon generation info struct.
        /// 
        /// r0: position (two-byte array for {x, y})
        /// r1: dungeon generation info pointer (a field on the dungeon struct)
        /// r2: hidden stairs type
        /// </summary>
        public int SpawnStairs
        {
            get
            {
                if (f_spawnStairs)
                    return _spawnStairs;
                _spawnStairs = (int) (419692);
                f_spawnStairs = true;
                return _spawnStairs;
            }
        }
        private bool f_debugRecruitingEnabled;
        private int _debugRecruitingEnabled;

        /// <summary>
        /// Always returns true. Called by SpecificRecruitCheck.
        /// 
        /// Seems to be a function used during development to disable recruiting. If it returns false, SpecificRecruitCheck will also return false.
        /// 
        /// return: true
        /// </summary>
        public int DebugRecruitingEnabled
        {
            get
            {
                if (f_debugRecruitingEnabled)
                    return _debugRecruitingEnabled;
                _debugRecruitingEnabled = (int) (79760);
                f_debugRecruitingEnabled = true;
                return _debugRecruitingEnabled;
            }
        }
        private bool f_tryRestoreHp;
        private int _tryRestoreHp;

        /// <summary>
        /// Restore HP of the target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: HP to restore
        /// return: success flag
        /// </summary>
        public int TryRestoreHp
        {
            get
            {
                if (f_tryRestoreHp)
                    return _tryRestoreHp;
                _tryRestoreHp = (int) (233060);
                f_tryRestoreHp = true;
                return _tryRestoreHp;
            }
        }
        private bool f_isOnMonsterSpawnList;
        private int _isOnMonsterSpawnList;

        /// <summary>
        /// Returns true if the specified monster is included in the floor's monster spawn list (the modified list after a maximum of 14 different species were chosen, not the raw list read from the mappa file).
        /// 
        /// r0: Monster ID
        /// return: bool
        /// </summary>
        public int IsOnMonsterSpawnList
        {
            get
            {
                if (f_isOnMonsterSpawnList)
                    return _isOnMonsterSpawnList;
                _isOnMonsterSpawnList = (int) (47828);
                f_isOnMonsterSpawnList = true;
                return _isOnMonsterSpawnList;
            }
        }
        private bool f_findUnoccupiedTileWithin3;
        private int _findUnoccupiedTileWithin3;

        /// <summary>
        /// Searches for an unoccupied tile within 3 steps of the given origin.
        /// 
        /// Calls FindNearbyUnoccupiedTile with DISPLACEMENTS_WITHIN_3.
        /// 
        /// r0: [output] position
        /// r1: origin position
        /// r2: random room mode flag
        /// return: whether a tile was successfully found
        /// </summary>
        public int FindUnoccupiedTileWithin3
        {
            get
            {
                if (f_findUnoccupiedTileWithin3)
                    return _findUnoccupiedTileWithin3;
                _findUnoccupiedTileWithin3 = (int) (55216);
                f_findUnoccupiedTileWithin3 = true;
                return _findUnoccupiedTileWithin3;
            }
        }
        private bool f_tryDecreaseLevel;
        private int _tryDecreaseLevel;

        /// <summary>
        /// Decrease the target monster's level if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of levels to decrease
        /// return: success flag
        /// </summary>
        public int TryDecreaseLevel
        {
            get
            {
                if (f_tryDecreaseLevel)
                    return _tryDecreaseLevel;
                _tryDecreaseLevel = (int) (158708);
                f_tryDecreaseLevel = true;
                return _tryDecreaseLevel;
            }
        }
        private bool f_dealDamageWithTypeAndPowerBoost;
        private int _dealDamageWithTypeAndPowerBoost;

        /// <summary>
        /// Same as DealDamage, except with an explicit move type and a base power boost.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: damage multiplier (as a binary fixed-point number with 8 fraction bits)
        /// stack[0]: item ID
        /// stack[1]: move type
        /// stack[2]: base power boost
        /// return: amount of damage dealt
        /// </summary>
        public int DealDamageWithTypeAndPowerBoost
        {
            get
            {
                if (f_dealDamageWithTypeAndPowerBoost)
                    return _dealDamageWithTypeAndPowerBoost;
                _dealDamageWithTypeAndPowerBoost = (int) (353992);
                f_dealDamageWithTypeAndPowerBoost = true;
                return _dealDamageWithTypeAndPowerBoost;
            }
        }
        private bool f_revealWholeFloor;
        private int _revealWholeFloor;

        /// <summary>
        /// Sets the luminous state for the floor and marks all the tiles on the floor as revealed.
        /// 
        /// More specifically, sets dungeon::display_data::luminous to 1, sets visibility_flags::f_revealed for all tiles on the floor, calls UpdateCamera, UpdateTrapsVisibility, UpdateMinimap and logs the message &quot;It became brighter on the floor!&quot;.
        /// 
        /// r0: Pointer to the entity who revealed the floor
        /// </summary>
        public int RevealWholeFloor
        {
            get
            {
                if (f_revealWholeFloor)
                    return _revealWholeFloor;
                _revealWholeFloor = (int) (29120);
                f_revealWholeFloor = true;
                return _revealWholeFloor;
            }
        }
        private bool f_setMissionTargetEnemyDefeated;
        private int _setMissionTargetEnemyDefeated;

        /// <summary>
        /// Set the flag for whether or not the target enemy of the current mission has been defeated.
        /// 
        /// r0: new flag value
        /// </summary>
        public int SetMissionTargetEnemyDefeated
        {
            get
            {
                if (f_setMissionTargetEnemyDefeated)
                    return _setMissionTargetEnemyDefeated;
                _setMissionTargetEnemyDefeated = (int) (446168);
                f_setMissionTargetEnemyDefeated = true;
                return _setMissionTargetEnemyDefeated;
            }
        }
        private bool f_trySpawnMonsterAndActivatePlusMinus;
        private int _trySpawnMonsterAndActivatePlusMinus;

        /// <summary>
        /// Called at the beginning of RunFractionalTurn. Executed only if FRACTIONAL_TURN_SEQUENCE[fractional_turn * 2] is not 0.
        /// 
        /// First it calls TrySpawnMonsterAndTickSpawnCounter, then tries to activate the Plus and Minus abilities for both allies and enemies, and finally calls TryForcedLoss.
        /// 
        /// No params.
        /// </summary>
        public int TrySpawnMonsterAndActivatePlusMinus
        {
            get
            {
                if (f_trySpawnMonsterAndActivatePlusMinus)
                    return _trySpawnMonsterAndActivatePlusMinus;
                _trySpawnMonsterAndActivatePlusMinus = (int) (66660);
                f_trySpawnMonsterAndActivatePlusMinus = true;
                return _trySpawnMonsterAndActivatePlusMinus;
            }
        }
        private bool f_loadFixedRoom;
        private int _loadFixedRoom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int LoadFixedRoom
        {
            get
            {
                if (f_loadFixedRoom)
                    return _loadFixedRoom;
                _loadFixedRoom = (int) (424196);
                f_loadFixedRoom = true;
                return _loadFixedRoom;
            }
        }
        private bool f_shouldMonsterHeadToStairs;
        private int _shouldMonsterHeadToStairs;

        /// <summary>
        /// Checks if a given monster should try to reach the stairs when controlled by the AI
        /// 
        /// r0: Entity pointer
        /// return: True if the monster should try to reach the stairs, false otherwise
        /// </summary>
        public int ShouldMonsterHeadToStairs
        {
            get
            {
                if (f_shouldMonsterHeadToStairs)
                    return _shouldMonsterHeadToStairs;
                _shouldMonsterHeadToStairs = (int) (123128);
                f_shouldMonsterHeadToStairs = true;
                return _shouldMonsterHeadToStairs;
            }
        }
        private bool f_tryPounce;
        private int _tryPounce;

        /// <summary>
        /// Makes the target monster execute the Pounce action in a given direction if possible.
        /// 
        /// If the direction ID is 8, the target will pounce in the direction it's currently facing.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: direction ID
        /// </summary>
        public int TryPounce
        {
            get
            {
                if (f_tryPounce)
                    return _tryPounce;
                _tryPounce = (int) (276460);
                f_tryPounce = true;
                return _tryPounce;
            }
        }
        private bool f_showPpRestoreEffect;
        private int _showPpRestoreEffect;

        /// <summary>
        /// Displays the graphical effect on a monster that just recovered PP.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int ShowPpRestoreEffect
        {
            get
            {
                if (f_showPpRestoreEffect)
                    return _showPpRestoreEffect;
                _showPpRestoreEffect = (int) (34548);
                f_showPpRestoreEffect = true;
                return _showPpRestoreEffect;
            }
        }
        private bool f_positionHasItem;
        private int _positionHasItem;

        /// <summary>
        /// Checks if the tile at the position has an item on it.
        /// 
        /// r0: Position to check
        /// return: bool
        /// </summary>
        public int PositionHasItem
        {
            get
            {
                if (f_positionHasItem)
                    return _positionHasItem;
                _positionHasItem = (int) (374288);
                f_positionHasItem = true;
                return _positionHasItem;
            }
        }
        private bool f_updateAiTargetPos;
        private int _updateAiTargetPos;

        /// <summary>
        /// Given a monster, updates its target_pos field based on its current position and the direction in which it plans to attack.
        /// 
        /// r0: Entity pointer
        /// </summary>
        public int UpdateAiTargetPos
        {
            get
            {
                if (f_updateAiTargetPos)
                    return _updateAiTargetPos;
                _updateAiTargetPos = (int) (118312);
                f_updateAiTargetPos = true;
                return _updateAiTargetPos;
            }
        }
        private bool f_getMissionTargetEnemy;
        private int _getMissionTargetEnemy;

        /// <summary>
        /// Get the monster ID of the target enemy to be defeated on the current floor for a mission, if one exists.
        /// 
        /// return: monster ID
        /// </summary>
        public int GetMissionTargetEnemy
        {
            get
            {
                if (f_getMissionTargetEnemy)
                    return _getMissionTargetEnemy;
                _getMissionTargetEnemy = (int) (446568);
                f_getMissionTargetEnemy = true;
                return _getMissionTargetEnemy;
            }
        }
        private bool f_aiConsiderMove;
        private int _aiConsiderMove;

        /// <summary>
        /// The AI uses this function to check if a move has any potential targets, to calculate the list of potential targets and to calculate the move's special weight. The weight is calculated using WeightMoveWithIqSkills.
        /// This function also sets the flag can_be_used on the ai_possible_move struct if it makes sense to use it.
        /// 
        /// The weight returned by this function is not the same as GetMoveAiWeight. If the AI does not have Weak-Type Picker, AiConsiderMove is called after the AI has selected which move it will use (using GetMoveAiWeight). It determines whether it makes sense for the AI to actually use the chosen move (i.e., whether targets are in range), and which direction the AI will use the move in if so. The return value of this function is not used anywhere in this case.
        /// 
        /// If the AI has Weak-Type Picker, the AI calls this function earlier in the AI logic to determine which move to use, using the returned special weight to find which move has the most advantageous type matchups.
        /// 
        /// r0: ai_possible_move struct for this move
        /// r1: Entity pointer
        /// r2: Move pointer
        /// return: Move's calculated special weight
        /// </summary>
        public int AiConsiderMove
        {
            get
            {
                if (f_aiConsiderMove)
                    return _aiConsiderMove;
                _aiConsiderMove = (int) (250992);
                f_aiConsiderMove = true;
                return _aiConsiderMove;
            }
        }
        private bool f_getLeaderMonster;
        private int _getLeaderMonster;

        /// <summary>
        /// Returns a pointer to the monster data of the current leader.
        /// 
        /// No params.
        /// </summary>
        public int GetLeaderMonster
        {
            get
            {
                if (f_getLeaderMonster)
                    return _getLeaderMonster;
                _getLeaderMonster = (int) (54176);
                f_getLeaderMonster = true;
                return _getLeaderMonster;
            }
        }
        private bool f_canMonsterUseItem;
        private int _canMonsterUseItem;

        /// <summary>
        /// Checks whether a monster can use a certain item.
        /// 
        /// Returns false if the item is sticky, or if the monster is under the STATUS_MUZZLED status and the item is edible.
        /// Also prints failure messages if required.
        /// 
        /// r0: Monster entity pointer
        /// r1: Item pointer
        /// return: True if the monster can use the item, false otherwise
        /// </summary>
        public int CanMonsterUseItem
        {
            get
            {
                if (f_canMonsterUseItem)
                    return _canMonsterUseItem;
                _canMonsterUseItem = (int) (266380);
                f_canMonsterUseItem = true;
                return _canMonsterUseItem;
            }
        }
        private bool f_createRoomsAndAnchors;
        private int _createRoomsAndAnchors;

        /// <summary>
        /// Creates rooms and hallway anchors in each grid cell as designated by AssignRooms.
        /// 
        /// This function creates a rectangle of open terrain for each room (with some margin relative to the grid cell border). A single open tile is created in hallway anchor cells, and a hallway anchor indicator is set for later reference.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: array of the starting x coordinates of each grid column
        /// stack[0]: array of the starting y coordinates of each grid row
        /// stack[1]: room bitflags; only uses bit 2 (mask: 0b100), which enables room imperfections
        /// </summary>
        public int CreateRoomsAndAnchors
        {
            get
            {
                if (f_createRoomsAndAnchors)
                    return _createRoomsAndAnchors;
                _createRoomsAndAnchors = (int) (396792);
                f_createRoomsAndAnchors = true;
                return _createRoomsAndAnchors;
            }
        }
        private bool f_loadMissionMonsterSprites;
        private int _loadMissionMonsterSprites;

        /// <summary>
        /// Loads the sprites of monsters that appear on the current floor because of a mission, if applicable.
        /// 
        /// This includes monsters to be rescued, outlaws and its minions.
        /// 
        /// No params.
        /// </summary>
        public int LoadMissionMonsterSprites
        {
            get
            {
                if (f_loadMissionMonsterSprites)
                    return _loadMissionMonsterSprites;
                _loadMissionMonsterSprites = (int) (446016);
                f_loadMissionMonsterSprites = true;
                return _loadMissionMonsterSprites;
            }
        }
        private bool f_recruitCheck;
        private int _recruitCheck;

        /// <summary>
        /// Determines if a defeated enemy will attempt to join the team
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: True if the target will attempt to join the team
        /// </summary>
        public int RecruitCheck
        {
            get
            {
                if (f_recruitCheck)
                    return _recruitCheck;
                _recruitCheck = (int) (202800);
                f_recruitCheck = true;
                return _recruitCheck;
            }
        }
        private bool f_areLateGameTrapsEnabledWrapper;
        private int _areLateGameTrapsEnabledWrapper;

        /// <summary>
        /// A wrapper around AreLateGameTrapsEnabled that passes the fixed room for the floor.
        /// 
        /// return: bool
        /// </summary>
        public int AreLateGameTrapsEnabledWrapper
        {
            get
            {
                if (f_areLateGameTrapsEnabledWrapper)
                    return _areLateGameTrapsEnabledWrapper;
                _areLateGameTrapsEnabledWrapper = (int) (71148);
                f_areLateGameTrapsEnabledWrapper = true;
                return _areLateGameTrapsEnabledWrapper;
            }
        }
        private bool f_logMessageWithPopup;
        private int _logMessageWithPopup;

        /// <summary>
        /// Logs a message in the message log alongside a message popup.
        /// 
        /// r0: user entity pointer
        /// r1: message string
        /// </summary>
        public int LogMessageWithPopup
        {
            get
            {
                if (f_logMessageWithPopup)
                    return _logMessageWithPopup;
                _logMessageWithPopup = (int) (454220);
                f_logMessageWithPopup = true;
                return _logMessageWithPopup;
            }
        }
        private bool f_generateDungeonRngSeed;
        private int _generateDungeonRngSeed;

        /// <summary>
        /// Generates a seed with which to initialize the dungeon PRNG.
        /// 
        /// The seed is calculated by starting with a different seed, the &quot;preseed&quot; x0 (defaults to 1, but can be set by other functions). The preseed is iterated twice with the same recurrence relation used in the primary LCG to generate two pseudorandom 32-bit numbers x1 and x2. The output seed is then computed as
        ///   seed = (x1 &amp; 0xFF0000) | (x2 &gt;&gt; 0x10) | 1
        /// The value x1 is then saved as the new preseed.
        /// 
        /// This method of seeding the dungeon PRNG appears to be used only sometimes, depending on certain flags in the data for a given dungeon.
        /// 
        /// return: RNG seed
        /// </summary>
        public int GenerateDungeonRngSeed
        {
            get
            {
                if (f_generateDungeonRngSeed)
                    return _generateDungeonRngSeed;
                _generateDungeonRngSeed = (int) (59144);
                f_generateDungeonRngSeed = true;
                return _generateDungeonRngSeed;
            }
        }
        private bool f_digitCount;
        private int _digitCount;

        /// <summary>
        /// Counts the number of digits in a nonnegative integer.
        /// 
        /// If the number is negative, it is cast to a uint16_t before counting digits.
        /// 
        /// r0: int
        /// return: number of digits in int
        /// </summary>
        public int DigitCount
        {
            get
            {
                if (f_digitCount)
                    return _digitCount;
                _digitCount = (int) (364924);
                f_digitCount = true;
                return _digitCount;
            }
        }
        private bool f_applyCalciumEffect;
        private int _applyCalciumEffect;

        /// <summary>
        /// Tries to boost the target's special attack stat.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: special attack boost
        /// </summary>
        public int ApplyCalciumEffect
        {
            get
            {
                if (f_applyCalciumEffect)
                    return _applyCalciumEffect;
                _applyCalciumEffect = (int) (244692);
                f_applyCalciumEffect = true;
                return _applyCalciumEffect;
            }
        }
        private bool f_setActionRegularAttack;
        private int _setActionRegularAttack;

        /// <summary>
        /// Sets a monster's action to action::ACTION_REGULAR_ATTACK, with a specified direction.
        /// 
        /// r0: Pointer to the monster's action field
        /// r1: Direction in which to use the move. Gets stored in monster::action::direction.
        /// </summary>
        public int SetActionRegularAttack
        {
            get
            {
                if (f_setActionRegularAttack)
                    return _setActionRegularAttack;
                _setActionRegularAttack = (int) (63960);
                f_setActionRegularAttack = true;
                return _setActionRegularAttack;
            }
        }
        private bool f_twoTurnMoveForcedMiss;
        private int _twoTurnMoveForcedMiss;

        /// <summary>
        /// Checks if a move should miss a monster due to the monster being in the middle of Fly, Bounce, Dive, Dig, Shadow Force, or some other two-turn move that grants pseudo-invincibility.
        /// 
        /// r0: entity pointer
        /// r1: move
        /// return: true if the move should miss
        /// </summary>
        public int TwoTurnMoveForcedMiss
        {
            get
            {
                if (f_twoTurnMoveForcedMiss)
                    return _twoTurnMoveForcedMiss;
                _twoTurnMoveForcedMiss = (int) (295940);
                f_twoTurnMoveForcedMiss = true;
                return _twoTurnMoveForcedMiss;
            }
        }
        private bool f_playEffectAnimationPos;
        private int _playEffectAnimationPos;

        /// <summary>
        /// Takes a position struct in r0 and converts it to a pixel position struct before calling PlayEffectAnimationPixelPos
        /// 
        /// r0: Position where the effect should be played
        /// r1: Effect ID
        /// r2: Unknown flag (same as the one in PlayEffectAnimationEntity)
        /// return: Result of call to PlayEffectAnimationPixelPos
        /// </summary>
        public int PlayEffectAnimationPos
        {
            get
            {
                if (f_playEffectAnimationPos)
                    return _playEffectAnimationPos;
                _playEffectAnimationPos = (int) (30060);
                f_playEffectAnimationPos = true;
                return _playEffectAnimationPos;
            }
        }
        private bool f_tryInflictCrossEyedStatus;
        private int _tryInflictCrossEyedStatus;

        /// <summary>
        /// Inflicts the Cross-Eyed status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictCrossEyedStatus
        {
            get
            {
                if (f_tryInflictCrossEyedStatus)
                    return _tryInflictCrossEyedStatus;
                _tryInflictCrossEyedStatus = (int) (242740);
                f_tryInflictCrossEyedStatus = true;
                return _tryInflictCrossEyedStatus;
            }
        }
        private bool f_initDungeonGrid;
        private int _initDungeonGrid;

        /// <summary>
        /// Initialize a dungeon grid with defaults.
        /// 
        /// The grid is an array of grid cells stored in column-major order (such that grid cells with the same x value are stored contiguously), with a fixed column size of 15. If the grid size in the y direction is less than this, the last (15 - grid_size_y) entries of each column will be uninitialized.
        /// 
        /// Note that the grid size arguments define the maximum size of the grid from a programmatic standpoint. However, grid cells can be invalidated if they exceed the configured floor size in the dungeon generation status struct. Thus, the dimensions of the ACTIVE grid can be smaller.
        /// 
        /// r0: [output] grid (expected to have space for at least (15*(grid_size_x-1) + grid_size_y) dungeon grid cells)
        /// r1: grid size x
        /// r2: grid size y
        /// </summary>
        public int InitDungeonGrid
        {
            get
            {
                if (f_initDungeonGrid)
                    return _initDungeonGrid;
                _initDungeonGrid = (int) (396004);
                f_initDungeonGrid = true;
                return _initDungeonGrid;
            }
        }
        private bool f_unloadFixedRoomData;
        private int _unloadFixedRoomData;

        /// <summary>
        /// Unloads fixed room data from the buffer pointed to by FIXED_ROOM_DATA_PTR, then clears the pointer.
        /// 
        /// Also clears dungeon::unk_fixed_room_pointer.
        /// 
        /// No params.
        /// </summary>
        public int UnloadFixedRoomData
        {
            get
            {
                if (f_unloadFixedRoomData)
                    return _unloadFixedRoomData;
                _unloadFixedRoomData = (int) (385300);
                f_unloadFixedRoomData = true;
                return _unloadFixedRoomData;
            }
        }
        private bool f_getFloorType;
        private int _getFloorType;

        /// <summary>
        /// Get the current floor type.
        /// 
        /// Floor types:
        ///   0 appears to mean the current floor is &quot;normal&quot;
        ///   1 means the current floor is a fixed floor with warp zones enabled
        ///   2 means the current floor has a rescue point
        /// 
        /// return: floor type
        /// </summary>
        public int GetFloorType
        {
            get
            {
                if (f_getFloorType)
                    return _getFloorType;
                _getFloorType = (int) (16744);
                f_getFloorType = true;
                return _getFloorType;
            }
        }
        private bool f_shouldDisplayEntityAdvanced;
        private int _shouldDisplayEntityAdvanced;

        /// <summary>
        /// Returns whether or not the entity should be displayed, using the same checks as ShouldDisplayEntity except also checking whether it is visible and whether the camera entity is blinded.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int ShouldDisplayEntityAdvanced
        {
            get
            {
                if (f_shouldDisplayEntityAdvanced)
                    return _shouldDisplayEntityAdvanced;
                _shouldDisplayEntityAdvanced = (int) (40032);
                f_shouldDisplayEntityAdvanced = true;
                return _shouldDisplayEntityAdvanced;
            }
        }
        private bool f_playEffectAnimation0x171;
        private int _playEffectAnimation0x171;

        /// <summary>
        /// Just a guess. Calls PlayEffectAnimation with data from animation ID 0x171.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int PlayEffectAnimation0x171
        {
            get
            {
                if (f_playEffectAnimation0x171)
                    return _playEffectAnimation0x171;
                _playEffectAnimation0x171 = (int) (32252);
                f_playEffectAnimation0x171 = true;
                return _playEffectAnimation0x171;
            }
        }
        private bool f_applyIronEffect;
        private int _applyIronEffect;

        /// <summary>
        /// Tries to boost the target's defense stat.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: defense boost
        /// </summary>
        public int ApplyIronEffect
        {
            get
            {
                if (f_applyIronEffect)
                    return _applyIronEffect;
                _applyIronEffect = (int) (244840);
                f_applyIronEffect = true;
                return _applyIronEffect;
            }
        }
        private bool f_isSecretBazaarNpcBehavior;
        private int _isSecretBazaarNpcBehavior;

        /// <summary>
        /// Checks if a behavior ID corresponds to one of the Secret Bazaar NPCs.
        /// 
        /// r0: monster behavior ID
        /// return: bool
        /// </summary>
        public int IsSecretBazaarNpcBehavior
        {
            get
            {
                if (f_isSecretBazaarNpcBehavior)
                    return _isSecretBazaarNpcBehavior;
                _isSecretBazaarNpcBehavior = (int) (79912);
                f_isSecretBazaarNpcBehavior = true;
                return _isSecretBazaarNpcBehavior;
            }
        }
        private bool f_isFullFloorFixedRoom;
        private int _isFullFloorFixedRoom;

        /// <summary>
        /// Checks if the current fixed room on the dungeon generation info corresponds to a fixed, full-floor layout.
        /// 
        /// The first non-full-floor fixed room is 0xA5, which is for Sealed Chambers.
        /// 
        /// return: bool
        /// </summary>
        public int IsFullFloorFixedRoom
        {
            get
            {
                if (f_isFullFloorFixedRoom)
                    return _isFullFloorFixedRoom;
                _isFullFloorFixedRoom = (int) (367812);
                f_isFullFloorFixedRoom = true;
                return _isFullFloorFixedRoom;
            }
        }
        private bool f_getItemToUseByIndex;
        private int _getItemToUseByIndex;

        /// <summary>
        /// Returns a pointer to the item that is about to be used by a monster given its index.
        /// 
        /// r0: Entity pointer
        /// r1: Item index
        /// return: Pointer to the item
        /// </summary>
        public int GetItemToUseByIndex
        {
            get
            {
                if (f_getItemToUseByIndex)
                    return _getItemToUseByIndex;
                _getItemToUseByIndex = (int) (61908);
                f_getItemToUseByIndex = true;
                return _getItemToUseByIndex;
            }
        }
        private bool f_tryInflictLeechSeedStatus;
        private int _tryInflictLeechSeedStatus;

        /// <summary>
        /// Inflicts the Leech Seed status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictLeechSeedStatus
        {
            get
            {
                if (f_tryInflictLeechSeedStatus)
                    return _tryInflictLeechSeedStatus;
                _tryInflictLeechSeedStatus = (int) (234468);
                f_tryInflictLeechSeedStatus = true;
                return _tryInflictLeechSeedStatus;
            }
        }
        private bool f_setDungeonRngPreseed;
        private int _setDungeonRngPreseed;

        /// <summary>
        /// Sets the preseed in the global dungeon PRNG state. See GenerateDungeonRngSeed for more information.
        /// 
        /// r0: preseed
        /// </summary>
        public int SetDungeonRngPreseed
        {
            get
            {
                if (f_setDungeonRngPreseed)
                    return _setDungeonRngPreseed;
                _setDungeonRngPreseed = (int) (59236);
                f_setDungeonRngPreseed = true;
                return _setDungeonRngPreseed;
            }
        }
        private bool f_getOffensiveStatAtLevel;
        private int _getOffensiveStatAtLevel;

        /// <summary>
        /// Returns the Atk / Sp. Atk of a monster given its level, capped to 255.
        /// 
        /// r0: Monster ID
        /// r1: Monster level
        /// r2: Stat index (0: Atk, 1: Sp. Atk)
        /// return: Atk / Sp. Atk at the given level
        /// </summary>
        public int GetOffensiveStatAtLevel
        {
            get
            {
                if (f_getOffensiveStatAtLevel)
                    return _getOffensiveStatAtLevel;
                _getOffensiveStatAtLevel = (int) (138840);
                f_getOffensiveStatAtLevel = true;
                return _getOffensiveStatAtLevel;
            }
        }
        private bool f_getLeader;
        private int _getLeader;

        /// <summary>
        /// Gets the pointer to the entity that is currently leading the team, or null if none of the first 4 entities is a valid monster with its is_team_leader flag set. It also sets LEADER_PTR to the result before returning it.
        /// 
        /// return: Pointer to the current leader of the team or null if there's no valid leader.
        /// </summary>
        public int GetLeader
        {
            get
            {
                if (f_getLeader)
                    return _getLeader;
                _getLeader = (int) (54024);
                f_getLeader = true;
                return _getLeader;
            }
        }
        private bool f_isDestinationFloorWithMonster;
        private int _isDestinationFloorWithMonster;

        /// <summary>
        /// Checks if the current floor is a mission destination floor with a special monster.
        /// 
        /// See FloorHasMissionMonster for details.
        /// 
        /// return: bool
        /// </summary>
        public int IsDestinationFloorWithMonster
        {
            get
            {
                if (f_isDestinationFloorWithMonster)
                    return _isDestinationFloorWithMonster;
                _isDestinationFloorWithMonster = (int) (445844);
                f_isDestinationFloorWithMonster = true;
                return _isDestinationFloorWithMonster;
            }
        }
        private bool f_lowerDefensiveStat;
        private int _lowerDefensiveStat;

        /// <summary>
        /// Lowers the specified defensive stat on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: number of stages
        /// stack[0]: flag to check for being protected from stat drops
        /// stack[1]: flag to log a message on failure for IsProtectedFromStatDrops
        /// </summary>
        public int LowerDefensiveStat
        {
            get
            {
                if (f_lowerDefensiveStat)
                    return _lowerDefensiveStat;
                _lowerDefensiveStat = (int) (226332);
                f_lowerDefensiveStat = true;
                return _lowerDefensiveStat;
            }
        }
        private bool f_isProtectedFromStatDrops;
        private int _isProtectedFromStatDrops;

        /// <summary>
        /// Checks if the target monster is protected from getting their stats dropped by the user.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message
        /// return: bool
        /// </summary>
        public int IsProtectedFromStatDrops
        {
            get
            {
                if (f_isProtectedFromStatDrops)
                    return _isProtectedFromStatDrops;
                _isProtectedFromStatDrops = (int) (153516);
                f_isProtectedFromStatDrops = true;
                return _isProtectedFromStatDrops;
            }
        }
        private bool f_generateFloor;
        private int _generateFloor;

        /// <summary>
        /// This is the master function that generates the dungeon floor.
        /// 
        /// Very loosely speaking, this function first tries to generate a valid floor layout. Then it tries to spawn entities in a valid configuration. Finally, it performs cleanup and post-processing depending on the dungeon.
        /// 
        /// If a spawn configuration is invalid, the entire floor layout is scrapped and regenerated. If the generated floor layout is invalid 10 times in a row, or a valid spawn configuration isn't generated within 10 attempts, the generation algorithm aborts and the default one-room Monster House floor is generated as a fallback.
        /// 
        /// No params.
        /// </summary>
        public int GenerateFloor
        {
            get
            {
                if (f_generateFloor)
                    return _generateFloor;
                _generateFloor = (int) (385468);
                f_generateFloor = true;
                return _generateFloor;
            }
        }
        private bool f_getTileSafe;
        private int _getTileSafe;

        /// <summary>
        /// Get the tile at some position. If the coordinates are out of bounds, returns a pointer to a copy of the default tile.
        /// 
        /// r0: x position
        /// r1: y position
        /// return: tile pointer
        /// </summary>
        public int GetTileSafe
        {
            get
            {
                if (f_getTileSafe)
                    return _getTileSafe;
                _getTileSafe = (int) (367700);
                f_getTileSafe = true;
                return _getTileSafe;
            }
        }
        private bool f_hideTileGrid;
        private int _hideTileGrid;

        /// <summary>
        /// Hides the grid on the nearby walkable tiles. Triggered by releasing Y.
        /// 
        /// No params.
        /// </summary>
        public int HideTileGrid
        {
            get
            {
                if (f_hideTileGrid)
                    return _hideTileGrid;
                _hideTileGrid = (int) (373376);
                f_hideTileGrid = true;
                return _hideTileGrid;
            }
        }
        private bool f_canSeeInvisibleMonsters;
        private int _canSeeInvisibleMonsters;

        /// <summary>
        /// Returns whether a certain monster can see other invisible monsters.
        /// To be precise, this function returns true if the monster is holding Goggle Specs or if it has the status status::STATUS_EYEDROPS.
        /// 
        /// r0: Entity pointer
        /// return: True if the monster can see invisible monsters.
        /// </summary>
        public int CanSeeInvisibleMonsters
        {
            get
            {
                if (f_canSeeInvisibleMonsters)
                    return _canSeeInvisibleMonsters;
                _canSeeInvisibleMonsters = (int) (154460);
                f_canSeeInvisibleMonsters = true;
                return _canSeeInvisibleMonsters;
            }
        }
        private bool f_getApparentWeather;
        private int _getApparentWeather;

        /// <summary>
        /// Get the weather, as experienced by a specific entity.
        /// 
        /// r0: entity pointer
        /// return: weather ID
        /// </summary>
        public int GetApparentWeather
        {
            get
            {
                if (f_getApparentWeather)
                    return _getApparentWeather;
                _getApparentWeather = (int) (362516);
                f_getApparentWeather = true;
                return _getApparentWeather;
            }
        }
        private bool f_activateStench;
        private int _activateStench;

        /// <summary>
        /// Activate the Stench ability on the monster.
        /// 
        /// r0: monster pointer
        /// </summary>
        public int ActivateStench
        {
            get
            {
                if (f_activateStench)
                    return _activateStench;
                _activateStench = (int) (257832);
                f_activateStench = true;
                return _activateStench;
            }
        }
        private bool f_getMatchingMonsterId;
        private int _getMatchingMonsterId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// r1: ?
        /// r2: ?
        /// return: monster ID
        /// </summary>
        public int GetMatchingMonsterId
        {
            get
            {
                if (f_getMatchingMonsterId)
                    return _getMatchingMonsterId;
                _getMatchingMonsterId = (int) (425076);
                f_getMatchingMonsterId = true;
                return _getMatchingMonsterId;
            }
        }
        private bool f_trySmashWall;
        private int _trySmashWall;

        /// <summary>
        /// Checks if the tile at the position is a wall. If so, smash it (turn it into a floor tile), play an animation
        /// 
        /// r0: Wall position to smash
        /// return: bool
        /// </summary>
        public int TrySmashWall
        {
            get
            {
                if (f_trySmashWall)
                    return _trySmashWall;
                _trySmashWall = (int) (374400);
                f_trySmashWall = true;
                return _trySmashWall;
            }
        }
        private bool f_resetDamageCalcDiagnostics;
        private int _resetDamageCalcDiagnostics;

        /// <summary>
        /// Resets the damage calculation diagnostic info stored on the dungeon struct. Called unconditionally at the start of CalcDamage.
        /// 
        /// No params.
        /// </summary>
        public int ResetDamageCalcDiagnostics
        {
            get
            {
                if (f_resetDamageCalcDiagnostics)
                    return _resetDamageCalcDiagnostics;
                _resetDamageCalcDiagnostics = (int) (201092);
                f_resetDamageCalcDiagnostics = true;
                return _resetDamageCalcDiagnostics;
            }
        }
        private bool f_moveMonsterToPos;
        private int _moveMonsterToPos;

        /// <summary>
        /// Moves a monster to the target position. Used both for regular movement and special movement (like teleportation).
        /// 
        /// r0: Entity pointer
        /// r1: X target position
        /// r2: Y target position
        /// r3: ?
        /// </summary>
        public int MoveMonsterToPos
        {
            get
            {
                if (f_moveMonsterToPos)
                    return _moveMonsterToPos;
                _moveMonsterToPos = (int) (115412);
                f_moveMonsterToPos = true;
                return _moveMonsterToPos;
            }
        }
        private bool f_fixedRoomActionParamToDirection;
        private int _fixedRoomActionParamToDirection;

        /// <summary>
        /// Converts the parameter stored in a fixed room action value to a direction ID.
        /// 
        /// The conversion is performed by subtracting 1 to the value. If the parameter had a value of 0, DIR_NONE is returned.
        /// 
        /// r0: Parameter value
        /// return: Direction
        /// </summary>
        public int FixedRoomActionParamToDirection
        {
            get
            {
                if (f_fixedRoomActionParamToDirection)
                    return _fixedRoomActionParamToDirection;
                _fixedRoomActionParamToDirection = (int) (422992);
                f_fixedRoomActionParamToDirection = true;
                return _fixedRoomActionParamToDirection;
            }
        }
        private bool f_applyGummiBoostsDungeonMode;
        private int _applyGummiBoostsDungeonMode;

        /// <summary>
        /// Applies the IQ and possible stat boosts from eating a Gummi to the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: Gummi type ID
        /// r3: Stat boost amount, if a random stat boost occurs
        /// </summary>
        public int ApplyGummiBoostsDungeonMode
        {
            get
            {
                if (f_applyGummiBoostsDungeonMode)
                    return _applyGummiBoostsDungeonMode;
                _applyGummiBoostsDungeonMode = (int) (265384);
                f_applyGummiBoostsDungeonMode = true;
                return _applyGummiBoostsDungeonMode;
            }
        }
        private bool f_countItemsOnFloorForAcuteSniffer;
        private int _countItemsOnFloorForAcuteSniffer;

        /// <summary>
        /// Counts the number of items on the floor by checking every tile for an item and stores it into
        /// dungeon::item_sniffer_item_count
        /// 
        /// No params.
        /// </summary>
        public int CountItemsOnFloorForAcuteSniffer
        {
            get
            {
                if (f_countItemsOnFloorForAcuteSniffer)
                    return _countItemsOnFloorForAcuteSniffer;
                _countItemsOnFloorForAcuteSniffer = (int) (367952);
                f_countItemsOnFloorForAcuteSniffer = true;
                return _countItemsOnFloorForAcuteSniffer;
            }
        }
        private bool f_displayAnimatedNumbers;
        private int _displayAnimatedNumbers;

        /// <summary>
        /// Displays numbers or the &quot;MISS&quot; text above a monster. Normally used to display damage amounts, although it also has other uses (such as showing the stockpile count).
        /// 
        /// r0: Amount to display. Can be negative. 9999 displays &quot;MISS&quot; instead.
        /// r1: Entity above which the numbers will be displayed
        /// r2: True to display a plus or minus sign before the numbers, false to hide it
        /// r3: Color of the numbers. NUMBER_COLOR_AUTO to determine it automatically.
        /// </summary>
        public int DisplayAnimatedNumbers
        {
            get
            {
                if (f_displayAnimatedNumbers)
                    return _displayAnimatedNumbers;
                _displayAnimatedNumbers = (int) (58528);
                f_displayAnimatedNumbers = true;
                return _displayAnimatedNumbers;
            }
        }
        private bool f_getEntityTouchscreenArea;
        private int _getEntityTouchscreenArea;

        /// <summary>
        /// Returns the area on the touchscreen that contains the sprite of the specified entity
        /// 
        /// r0: Entity pointer
        /// r1: [output] struct where the result should be written
        /// </summary>
        public int GetEntityTouchscreenArea
        {
            get
            {
                if (f_getEntityTouchscreenArea)
                    return _getEntityTouchscreenArea;
                _getEntityTouchscreenArea = (int) (84172);
                f_getEntityTouchscreenArea = true;
                return _getEntityTouchscreenArea;
            }
        }
        private bool f_shouldBoostHiddenStairsSpawnChance;
        private int _shouldBoostHiddenStairsSpawnChance;

        /// <summary>
        /// Gets the boost_hidden_stairs_spawn_chance field on the dungeon struct.
        /// 
        /// return: bool
        /// </summary>
        public int ShouldBoostHiddenStairsSpawnChance
        {
            get
            {
                if (f_shouldBoostHiddenStairsSpawnChance)
                    return _shouldBoostHiddenStairsSpawnChance;
                _shouldBoostHiddenStairsSpawnChance = (int) (377040);
                f_shouldBoostHiddenStairsSpawnChance = true;
                return _shouldBoostHiddenStairsSpawnChance;
            }
        }
        private bool f_evolveMonster;
        private int _evolveMonster;

        /// <summary>
        /// Makes the specified monster evolve into the specified species. Has a special case when
        /// a monster evolves into Ninjask and tries to spawn a Shedinja as well.
        /// 
        /// r0: user entity pointer?
        /// r1: target pointer to the entity to evolve
        /// r2: Species to evolve into
        /// </summary>
        public int EvolveMonster
        {
            get
            {
                if (f_evolveMonster)
                    return _evolveMonster;
                _evolveMonster = (int) (162028);
                f_evolveMonster = true;
                return _evolveMonster;
            }
        }
        private bool f_teamMemberHasItemActive;
        private int _teamMemberHasItemActive;

        /// <summary>
        /// Checks if any team member is holding a certain item and puts them into the array given.
        /// 
        /// r0: [output] pointer to array of monsters (expected to have space for at least 4 pointers)
        /// r1: item ID
        /// return: number of team members with the item active
        /// </summary>
        public int TeamMemberHasItemActive
        {
            get
            {
                if (f_teamMemberHasItemActive)
                    return _teamMemberHasItemActive;
                _teamMemberHasItemActive = (int) (209908);
                f_teamMemberHasItemActive = true;
                return _teamMemberHasItemActive;
            }
        }
        private bool f_isDestinationFloor;
        private int _isDestinationFloor;

        /// <summary>
        /// Checks if the current floor is a mission destination floor.
        /// 
        /// return: bool
        /// </summary>
        public int IsDestinationFloor
        {
            get
            {
                if (f_isDestinationFloor)
                    return _isDestinationFloor;
                _isDestinationFloor = (int) (445520);
                f_isDestinationFloor = true;
                return _isDestinationFloor;
            }
        }
        private bool f_advanceFrame;
        private int _advanceFrame;

        /// <summary>
        /// Advances one frame. Does not return until the next frame starts.
        /// 
        /// r0: ? - Unused by the function
        /// </summary>
        public int AdvanceFrame
        {
            get
            {
                if (f_advanceFrame)
                    return _advanceFrame;
                _advanceFrame = (int) (56680);
                f_advanceFrame = true;
                return _advanceFrame;
            }
        }
        private bool f_canAiMonsterMoveInDirection;
        private int _canAiMonsterMoveInDirection;

        /// <summary>
        /// Checks whether an AI-controlled monster can move in the specified direction.
        /// Accounts for walls, other monsters on the target position and IQ skills that might prevent a monster from moving into a specific location, such as House Avoider, Trap Avoider or Lava Evader.
        /// 
        /// r0: Entity pointer
        /// r1: Direction
        /// r2: [output] True if movement was not possible because there was another monster on the target tile, false otherwise.
        /// return: True if the monster can move in the specified direction, false otherwise.
        /// </summary>
        public int CanAiMonsterMoveInDirection
        {
            get
            {
                if (f_canAiMonsterMoveInDirection)
                    return _canAiMonsterMoveInDirection;
                _canAiMonsterMoveInDirection = (int) (151256);
                f_canAiMonsterMoveInDirection = true;
                return _canAiMonsterMoveInDirection;
            }
        }
        private bool f_logMessageByIdQuietCheckUserTarget;
        private int _logMessageByIdQuietCheckUserTarget;

        /// <summary>
        /// Logs a message in the message log (but without a message popup), if some user check passes and the target hasn't fainted.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: message ID
        /// </summary>
        public int LogMessageByIdQuietCheckUserTarget
        {
            get
            {
                if (f_logMessageByIdQuietCheckUserTarget)
                    return _logMessageByIdQuietCheckUserTarget;
                _logMessageByIdQuietCheckUserTarget = (int) (454016);
                f_logMessageByIdQuietCheckUserTarget = true;
                return _logMessageByIdQuietCheckUserTarget;
            }
        }
        private bool f_generateMonsterHouse;
        private int _generateMonsterHouse;

        /// <summary>
        /// Possibly generate a Monster House on the floor.
        /// 
        /// A Monster House will be generated with a probability determined by the Monster House spawn chance parameter, and only if the current floor can support one (no non-Monster-House outlaw missions or special floor types). A Monster House will be generated in a random room that is valid, connected, and is not a merged or maze room.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: Monster House spawn chance (percentage from 0-100)
        /// </summary>
        public int GenerateMonsterHouse
        {
            get
            {
                if (f_generateMonsterHouse)
                    return _generateMonsterHouse;
                _generateMonsterHouse = (int) (408188);
                f_generateMonsterHouse = true;
                return _generateMonsterHouse;
            }
        }
        private bool f_hasLowHealth;
        private int _hasLowHealth;

        /// <summary>
        /// Checks if the entity passed is a valid monster, and if it's at low health (below 25% rounded down)
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int HasLowHealth
        {
            get
            {
                if (f_hasLowHealth)
                    return _hasLowHealth;
                _hasLowHealth = (int) (127492);
                f_hasLowHealth = true;
                return _hasLowHealth;
            }
        }
        private bool f_hasHeldItem;
        private int _hasHeldItem;

        /// <summary>
        /// Checks if a monster has a certain held item.
        /// 
        /// r0: entity pointer
        /// r1: item ID
        /// return: bool
        /// </summary>
        public int HasHeldItem
        {
            get
            {
                if (f_hasHeldItem)
                    return _hasHeldItem;
                _hasHeldItem = (int) (434868);
                f_hasHeldItem = true;
                return _hasHeldItem;
            }
        }
        private bool f_displayMessageInternal;
        private int _displayMessageInternal;

        /// <summary>
        /// Called by DisplayMessage. Seems to be the function that handles the display of the dialogue box. It won't return until all the characters have been written and after the player manually closes the dialogue box (if the corresponding parameter was set).
        /// 
        /// r0: ID of the string to display
        /// r1: True to wait for player input before closing the dialogue box, false to close it automatically once all the characters get printed.
        /// r2: pointer to the structure representing the desired state of the portrait
        /// r3: ?
        /// stack[0]: ?
        /// stack[1]: ?
        /// </summary>
        public int DisplayMessageInternal
        {
            get
            {
                if (f_displayMessageInternal)
                    return _displayMessageInternal;
                _displayMessageInternal = (int) (462652);
                f_displayMessageInternal = true;
                return _displayMessageInternal;
            }
        }
        private bool f_endLeechSeedClassStatus;
        private int _endLeechSeedClassStatus;

        /// <summary>
        /// Cures the target's leech seed or destiny bond status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndLeechSeedClassStatus
        {
            get
            {
                if (f_endLeechSeedClassStatus)
                    return _endLeechSeedClassStatus;
                _endLeechSeedClassStatus = (int) (173332);
                f_endLeechSeedClassStatus = true;
                return _endLeechSeedClassStatus;
            }
        }
        private bool f_generateCrossroadsFloor;
        private int _generateCrossroadsFloor;

        /// <summary>
        /// Generates a floor layout with a mesh of hallways on the interior 3x2 grid, surrounded by a boundary of rooms protruding from the interior like spikes, excluding the corner cells.
        /// 
        /// r0: floor properties
        /// </summary>
        public int GenerateCrossroadsFloor
        {
            get
            {
                if (f_generateCrossroadsFloor)
                    return _generateCrossroadsFloor;
                _generateCrossroadsFloor = (int) (389376);
                f_generateCrossroadsFloor = true;
                return _generateCrossroadsFloor;
            }
        }
        private bool f_tryInflictMiracleEyeStatus;
        private int _tryInflictMiracleEyeStatus;

        /// <summary>
        /// Inflicts the Miracle Eye status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// </summary>
        public int TryInflictMiracleEyeStatus
        {
            get
            {
                if (f_tryInflictMiracleEyeStatus)
                    return _tryInflictMiracleEyeStatus;
                _tryInflictMiracleEyeStatus = (int) (246848);
                f_tryInflictMiracleEyeStatus = true;
                return _tryInflictMiracleEyeStatus;
            }
        }
        private bool f_isProtectedFromSleepClassStatus;
        private int _isProtectedFromSleepClassStatus;

        /// <summary>
        /// Checks if the monster is immune to sleep class status conditions.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: ignore safeguard
        /// r3: ignore other protections (exclusive items + leaf guard)
        /// stack[0]: flag to log a message on failure
        /// return: bool
        /// </summary>
        public int IsProtectedFromSleepClassStatus
        {
            get
            {
                if (f_isProtectedFromSleepClassStatus)
                    return _isProtectedFromSleepClassStatus;
                _isProtectedFromSleepClassStatus = (int) (218652);
                f_isProtectedFromSleepClassStatus = true;
                return _isProtectedFromSleepClassStatus;
            }
        }
        private bool f_applyDamageAndEffects;
        private int _applyDamageAndEffects;

        /// <summary>
        /// Calls ApplyDamage, then performs various &quot;post-damage&quot; effects such as counter damage, statuses from abilities that activate on contact, and probably some other stuff.
        /// 
        /// Note that this doesn't include the effect of Illuminate, which is specifically handled elsewhere.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: damage_data pointer
        /// r3: False Swipe flag (see ApplyDamage)
        /// stack[0]: experience flag (see ApplyDamage)
        /// stack[1]: Damage source (see HandleFaint)
        /// stack[2]: defender response flag. If true, the defender can respond to the attack with various effects. If false, the only post-damage effect that can happen is the Rage attack boost.
        /// </summary>
        public int ApplyDamageAndEffects
        {
            get
            {
                if (f_applyDamageAndEffects)
                    return _applyDamageAndEffects;
                _applyDamageAndEffects = (int) (181052);
                f_applyDamageAndEffects = true;
                return _applyDamageAndEffects;
            }
        }
        private bool f_playEffectAnimation0x29;
        private int _playEffectAnimation0x29;

        /// <summary>
        /// Calls PlayEffectAnimation with data from animation ID 0x29.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int PlayEffectAnimation0x29
        {
            get
            {
                if (f_playEffectAnimation0x29)
                    return _playEffectAnimation0x29;
                _playEffectAnimation0x29 = (int) (41016);
                f_playEffectAnimation0x29 = true;
                return _playEffectAnimation0x29;
            }
        }
        private bool f_tryInflictMagnetRiseStatus;
        private int _tryInflictMagnetRiseStatus;

        /// <summary>
        /// Inflicts the Magnet Rise status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictMagnetRiseStatus
        {
            get
            {
                if (f_tryInflictMagnetRiseStatus)
                    return _tryInflictMagnetRiseStatus;
                _tryInflictMagnetRiseStatus = (int) (247156);
                f_tryInflictMagnetRiseStatus = true;
                return _tryInflictMagnetRiseStatus;
            }
        }
        private bool f_displayMessage2;
        private int _displayMessage2;

        /// <summary>
        /// Very similar to DisplayMessage
        /// </summary>
        public int DisplayMessage2
        {
            get
            {
                if (f_displayMessage2)
                    return _displayMessage2;
                _displayMessage2 = (int) (461912);
                f_displayMessage2 = true;
                return _displayMessage2;
            }
        }
        private bool f_openFixedBin;
        private int _openFixedBin;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int OpenFixedBin
        {
            get
            {
                if (f_openFixedBin)
                    return _openFixedBin;
                _openFixedBin = (int) (424760);
                f_openFixedBin = true;
                return _openFixedBin;
            }
        }
        private bool f_clearHiddenStairs;
        private int _clearHiddenStairs;

        /// <summary>
        /// Clears the tile (terrain and spawns) on which Hidden Stairs are spawned, if applicable.
        /// 
        /// No params.
        /// </summary>
        public int ClearHiddenStairs
        {
            get
            {
                if (f_clearHiddenStairs)
                    return _clearHiddenStairs;
                _clearHiddenStairs = (int) (387448);
                f_clearHiddenStairs = true;
                return _clearHiddenStairs;
            }
        }
        private bool f_dealDamage;
        private int _dealDamage;

        /// <summary>
        /// Deals damage from a move or item used by an attacking monster on a defending monster.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: damage multiplier (as a binary fixed-point number with 8 fraction bits)
        /// stack[0]: item ID
        /// return: amount of damage dealt
        /// </summary>
        public int DealDamage
        {
            get
            {
                if (f_dealDamage)
                    return _dealDamage;
                _dealDamage = (int) (353840);
                f_dealDamage = true;
                return _dealDamage;
            }
        }
        private bool f_shouldMonsterRunAwayAndShowEffect;
        private int _shouldMonsterRunAwayAndShowEffect;

        /// <summary>
        /// Calls ShouldMonsterRunAway and returns its result. It also calls DisplayRunAwayIfTriggered if the result was true.
        /// 
        /// r0: Entity pointer
        /// r1: Boolean value. If true, display a visual &quot;poof&quot; effect if the Run Away ability caused the monster to run away.
        /// return: Result of the call to ShouldMonsterRunAway
        /// </summary>
        public int ShouldMonsterRunAwayAndShowEffect
        {
            get
            {
                if (f_shouldMonsterRunAwayAndShowEffect)
                    return _shouldMonsterRunAwayAndShowEffect;
                _shouldMonsterRunAwayAndShowEffect = (int) (152376);
                f_shouldMonsterRunAwayAndShowEffect = true;
                return _shouldMonsterRunAwayAndShowEffect;
            }
        }
        private bool f_applyMixElixirEffect;
        private int _applyMixElixirEffect;

        /// <summary>
        /// If the target monster is a Linoone, restores all the PP of all the target's moves.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyMixElixirEffect
        {
            get
            {
                if (f_applyMixElixirEffect)
                    return _applyMixElixirEffect;
                _applyMixElixirEffect = (int) (266856);
                f_applyMixElixirEffect = true;
                return _applyMixElixirEffect;
            }
        }
        private bool f_dungeonGetTotalSpriteFileSize;
        private int _dungeonGetTotalSpriteFileSize;

        /// <summary>
        /// Checks Castform and Cherrim
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: sprite file size
        /// </summary>
        public int DungeonGetTotalSpriteFileSize
        {
            get
            {
                if (f_dungeonGetTotalSpriteFileSize)
                    return _dungeonGetTotalSpriteFileSize;
                _dungeonGetTotalSpriteFileSize = (int) (109908);
                f_dungeonGetTotalSpriteFileSize = true;
                return _dungeonGetTotalSpriteFileSize;
            }
        }
        private bool f_canHitWithRegularAttack;
        private int _canHitWithRegularAttack;

        /// <summary>
        /// Returns true if the defender is adjacent to the attacker and can hit them with a regular attack.
        /// Notably, this check is what prevents ranged moves, moves that cut corners, etc. from being reflected by Magic Coat and Mirror Move.
        /// 
        /// r0: Entity pointer (attacker)
        /// r1: Entity pointer (defender)
        /// return: bool
        /// </summary>
        public int CanHitWithRegularAttack
        {
            get
            {
                if (f_canHitWithRegularAttack)
                    return _canHitWithRegularAttack;
                _canHitWithRegularAttack = (int) (355028);
                f_canHitWithRegularAttack = true;
                return _canHitWithRegularAttack;
            }
        }
        private bool f_setBothScreensWindowColorToDefault;
        private int _setBothScreensWindowColorToDefault;

        /// <summary>
        /// This changes the palettes of windows in both screens to an appropiate value depending on the playthrough
        /// If you're in a special episode, they turn green , otherwise, they turn blue or pink depending on your character's sex
        /// 
        /// No params
        /// </summary>
        public int SetBothScreensWindowColorToDefault
        {
            get
            {
                if (f_setBothScreensWindowColorToDefault)
                    return _setBothScreensWindowColorToDefault;
                _setBothScreensWindowColorToDefault = (int) (461028);
                f_setBothScreensWindowColorToDefault = true;
                return _setBothScreensWindowColorToDefault;
            }
        }
        private bool f_tryActivateIdentifyCondition;
        private int _tryActivateIdentifyCondition;

        /// <summary>
        /// Sets the flag for the identify orb which causes monsters holding items to be shown with
        /// a blue exclamation mark status icon.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryActivateIdentifyCondition
        {
            get
            {
                if (f_tryActivateIdentifyCondition)
                    return _tryActivateIdentifyCondition;
                _tryActivateIdentifyCondition = (int) (242232);
                f_tryActivateIdentifyCondition = true;
                return _tryActivateIdentifyCondition;
            }
        }
        private bool f_logMessageWithPopupCheckUserTarget;
        private int _logMessageWithPopupCheckUserTarget;

        /// <summary>
        /// Logs a message in the message log alongside a message popup, if some user check passes and the target hasn't fainted.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: message string
        /// </summary>
        public int LogMessageWithPopupCheckUserTarget
        {
            get
            {
                if (f_logMessageWithPopupCheckUserTarget)
                    return _logMessageWithPopupCheckUserTarget;
                _logMessageWithPopupCheckUserTarget = (int) (453940);
                f_logMessageWithPopupCheckUserTarget = true;
                return _logMessageWithPopupCheckUserTarget;
            }
        }
        private bool f_endInvisibleClassStatus;
        private int _endInvisibleClassStatus;

        /// <summary>
        /// Removes the target's invisible, transformed, mobile, or slip status due to the action of the user, and prints
        /// the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// r2: flag to not log a message when removing slip status
        /// </summary>
        public int EndInvisibleClassStatus
        {
            get
            {
                if (f_endInvisibleClassStatus)
                    return _endInvisibleClassStatus;
                _endInvisibleClassStatus = (int) (173648);
                f_endInvisibleClassStatus = true;
                return _endInvisibleClassStatus;
            }
        }
        private bool f_doMoveDamageInlined;
        private int _doMoveDamageInlined;

        /// <summary>
        /// Exactly the same as DoMoveDamage, except it appears DealDamage was inlined.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageInlined
        {
            get
            {
                if (f_doMoveDamageInlined)
                    return _doMoveDamageInlined;
                _doMoveDamageInlined = (int) (353664);
                f_doMoveDamageInlined = true;
                return _doMoveDamageInlined;
            }
        }
        private bool f_tryInflictConfusedStatus;
        private int _tryInflictConfusedStatus;

        /// <summary>
        /// Inflicts the Confused status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictConfusedStatus
        {
            get
            {
                if (f_tryInflictConfusedStatus)
                    return _tryInflictConfusedStatus;
                _tryInflictConfusedStatus = (int) (232240);
                f_tryInflictConfusedStatus = true;
                return _tryInflictConfusedStatus;
            }
        }
        private bool f_initPortraitDungeon;
        private int _initPortraitDungeon;

        /// <summary>
        /// Initialize the portrait params structure for the given monster and expression
        /// 
        /// r0: pointer the portrait params data structure to initialize
        /// r1: monster id
        /// r2: emotion id
        /// </summary>
        public int InitPortraitDungeon
        {
            get
            {
                if (f_initPortraitDungeon)
                    return _initPortraitDungeon;
                _initPortraitDungeon = (int) (455748);
                f_initPortraitDungeon = true;
                return _initPortraitDungeon;
            }
        }
        private bool f_getHiddenStairsField;
        private int _getHiddenStairsField;

        /// <summary>
        /// Gets the hidden_stairs_type variable from dungeon::dungeon_generation_info.
        /// 
        /// return: enum hidden_stairs_type
        /// </summary>
        public int GetHiddenStairsField
        {
            get
            {
                if (f_getHiddenStairsField)
                    return _getHiddenStairsField;
                _getHiddenStairsField = (int) (377652);
                f_getHiddenStairsField = true;
                return _getHiddenStairsField;
            }
        }
        private bool f_tryLeaderItemPickUp;
        private int _tryLeaderItemPickUp;

        /// <summary>
        /// Checks the tile at the specified position and determines if the leader should pick up an item.
        /// 
        /// r0: position
        /// r1: flag for whether or not a message should be logged upon the leader failing to obtain the item
        /// </summary>
        public int TryLeaderItemPickUp
        {
            get
            {
                if (f_tryLeaderItemPickUp)
                    return _tryLeaderItemPickUp;
                _tryLeaderItemPickUp = (int) (428860);
                f_tryLeaderItemPickUp = true;
                return _tryLeaderItemPickUp;
            }
        }
        private bool f_sprintfStatic;
        private int _sprintfStatic;

        /// <summary>
        /// Statically defined copy of sprintf(3) in overlay 29. See arm9.yml for more information.
        /// 
        /// r0: str
        /// r1: format
        /// ...: variadic
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int SprintfStatic
        {
            get
            {
                if (f_sprintfStatic)
                    return _sprintfStatic;
                _sprintfStatic = (int) (146928);
                f_sprintfStatic = true;
                return _sprintfStatic;
            }
        }
        private bool f_convertWallsToChasms;
        private int _convertWallsToChasms;

        /// <summary>
        /// Converts all wall tiles to chasms.
        /// 
        /// No params.
        /// </summary>
        public int ConvertWallsToChasms
        {
            get
            {
                if (f_convertWallsToChasms)
                    return _convertWallsToChasms;
                _convertWallsToChasms = (int) (417832);
                f_convertWallsToChasms = true;
                return _convertWallsToChasms;
            }
        }
        private bool f_areEntitiesAdjacent;
        private int _areEntitiesAdjacent;

        /// <summary>
        /// Checks whether two entities are adjacent or not.
        /// 
        /// The function checks all 8 possible directions.
        /// 
        /// r0: First entity
        /// r1: Second entity
        /// return: True if both entities are adjacent, false otherwise.
        /// </summary>
        public int AreEntitiesAdjacent
        {
            get
            {
                if (f_areEntitiesAdjacent)
                    return _areEntitiesAdjacent;
                _areEntitiesAdjacent = (int) (127596);
                f_areEntitiesAdjacent = true;
                return _areEntitiesAdjacent;
            }
        }
        private bool f_getTreatmentBetweenMonsters;
        private int _getTreatmentBetweenMonsters;

        /// <summary>
        /// Called to check if a monster should treat another as an ally, enemy, or ignore it.
        /// (Examples of the &quot;ignore&quot; case: target is a shopkeeper, there is a decoy on the floor, etc.)
        /// 
        /// r0: Pointer to entity 1
        /// r1: Pointer to entity 2
        /// r2: If false, return TREATMENT_IGNORE if entity 2 is invisible and entity 1 cannot see invisible monsters
        /// r3: If true, return TREATMENT_IGNORE if entity 1 is a team member and entity 2 has the STATUS_PETRIFIED status
        /// return: Treatment that monster 1 should apply to monster 2
        /// </summary>
        public int GetTreatmentBetweenMonsters
        {
            get
            {
                if (f_getTreatmentBetweenMonsters)
                    return _getTreatmentBetweenMonsters;
                _getTreatmentBetweenMonsters = (int) (152556);
                f_getTreatmentBetweenMonsters = true;
                return _getTreatmentBetweenMonsters;
            }
        }
        private bool f_isCurrentFixedRoomBossFight;
        private int _isCurrentFixedRoomBossFight;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: bool
        /// </summary>
        public int IsCurrentFixedRoomBossFight
        {
            get
            {
                if (f_isCurrentFixedRoomBossFight)
                    return _isCurrentFixedRoomBossFight;
                _isCurrentFixedRoomBossFight = (int) (17968);
                f_isCurrentFixedRoomBossFight = true;
                return _isCurrentFixedRoomBossFight;
            }
        }
        private bool f_initMonster;
        private int _initMonster;

        /// <summary>
        /// Initializes the monster struct within the provided entity struct.
        /// 
        /// r0: ?
        /// r1: Pointer to the entity whose monster struct should be initialized
        /// r2: pointer to the entity's spawned_monster_data struct
        /// r3: (?) Pointer to something
        /// </summary>
        public int InitMonster
        {
            get
            {
                if (f_initMonster)
                    return _initMonster;
                _initMonster = (int) (136420);
                f_initMonster = true;
                return _initMonster;
            }
        }
        private bool f_boostOrLowerSpeed;
        private int _boostOrLowerSpeed;

        /// <summary>
        /// Randomly boosts or lowers the speed of the target monster by one stage with equal probability.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int BoostOrLowerSpeed
        {
            get
            {
                if (f_boostOrLowerSpeed)
                    return _boostOrLowerSpeed;
                _boostOrLowerSpeed = (int) (231456);
                f_boostOrLowerSpeed = true;
                return _boostOrLowerSpeed;
            }
        }
        private bool f_playEffectAnimationPixelPos;
        private int _playEffectAnimationPixelPos;

        /// <summary>
        /// Seems like a variant of PlayEffectAnimationEntity that uses pixel coordinates as its first parameter instead of an entity pointer.
        /// 
        /// r0: Pixel position where the effect should be played
        /// r1: Effect ID
        /// r2: Unknown flag (same as the one in PlayEffectAnimationEntity)
        /// return: Same as PlayEffectAnimationEntity
        /// </summary>
        public int PlayEffectAnimationPixelPos
        {
            get
            {
                if (f_playEffectAnimationPixelPos)
                    return _playEffectAnimationPixelPos;
                _playEffectAnimationPixelPos = (int) (30128);
                f_playEffectAnimationPixelPos = true;
                return _playEffectAnimationPixelPos;
            }
        }
        private bool f_endBlinkerClassStatus;
        private int _endBlinkerClassStatus;

        /// <summary>
        /// Removes the target's blinker, cross-eyed, eyedrops, or dropeye status due to the action of the user, and
        /// prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndBlinkerClassStatus
        {
            get
            {
                if (f_endBlinkerClassStatus)
                    return _endBlinkerClassStatus;
                _endBlinkerClassStatus = (int) (173944);
                f_endBlinkerClassStatus = true;
                return _endBlinkerClassStatus;
            }
        }
        private bool f_isPositionInSight;
        private int _isPositionInSight;

        /// <summary>
        /// Checks if a given target position is in sight from a given origin position.
        /// There's multiple factors that affect this check, but generally, it's true if both positions are in the same room (by checking if the target position is within the boundaries of the room where the origin position is) or within 2 tiles of each other.
        /// 
        /// r0: Origin position
        /// r1: Target position
        /// r2: True to assume the entity standing on the origin position has the dropeye status
        /// return: True if the target position is in sight from the origin position
        /// </summary>
        public int IsPositionInSight
        {
            get
            {
                if (f_isPositionInSight)
                    return _isPositionInSight;
                _isPositionInSight = (int) (53036);
                f_isPositionInSight = true;
                return _isPositionInSight;
            }
        }
        private bool f_revealStairs;
        private int _revealStairs;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int RevealStairs
        {
            get
            {
                if (f_revealStairs)
                    return _revealStairs;
                _revealStairs = (int) (234136);
                f_revealStairs = true;
                return _revealStairs;
            }
        }
        private bool f_specificRecruitCheck;
        private int _specificRecruitCheck;

        /// <summary>
        /// Checks if a specific monster can be recruited. Called by RecruitCheck.
        /// 
        /// Will return false if dungeon::recruiting_enabled is false, if the monster is Mew and dungeon::dungeon_objective is OBJECTIVE_RESCUE or if the monster is any of the special Deoxys forms or any of the 3 regis.
        /// If this function returns false, RecruitCheck will return false as well.
        /// 
        /// r0: Monster ID
        /// return: True if the monster can be recruited
        /// </summary>
        public int SpecificRecruitCheck
        {
            get
            {
                if (f_specificRecruitCheck)
                    return _specificRecruitCheck;
                _specificRecruitCheck = (int) (202612);
                f_specificRecruitCheck = true;
                return _specificRecruitCheck;
            }
        }
        private bool f_endMagnetRiseStatus;
        private int _endMagnetRiseStatus;

        /// <summary>
        /// Removes the target's magnet rise status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndMagnetRiseStatus
        {
            get
            {
                if (f_endMagnetRiseStatus)
                    return _endMagnetRiseStatus;
                _endMagnetRiseStatus = (int) (174368);
                f_endMagnetRiseStatus = true;
                return _endMagnetRiseStatus;
            }
        }
        private bool f_drawTileGrid;
        private int _drawTileGrid;

        /// <summary>
        /// Draws a grid on the nearby walkable tiles. Triggered by pressing Y.
        /// 
        /// r0: Coordinates of the entity around which the grid will be drawn
        /// r1: ?
        /// r2: ?
        /// r3: ?
        /// </summary>
        public int DrawTileGrid
        {
            get
            {
                if (f_drawTileGrid)
                    return _drawTileGrid;
                _drawTileGrid = (int) (372496);
                f_drawTileGrid = true;
                return _drawTileGrid;
            }
        }
        private bool f_activateSportCondition;
        private int _activateSportCondition;

        /// <summary>
        /// Activates the Mud Sport or Water Sport condition on the dungeon floor for some number of turns.
        /// 
        /// r0: water sport flag (false for Mud Sport, true for Water Sport)
        /// </summary>
        public int ActivateSportCondition
        {
            get
            {
                if (f_activateSportCondition)
                    return _activateSportCondition;
                _activateSportCondition = (int) (364376);
                f_activateSportCondition = true;
                return _activateSportCondition;
            }
        }
        private bool f_clearLoadedAttackSprite;
        private int _clearLoadedAttackSprite;

        /// <summary>
        /// Delete the data of the currently loaded attack sprite, if any.
        /// Doesn’t free the structure, which can continue to be used.
        /// 
        /// No params.
        /// </summary>
        public int ClearLoadedAttackSprite
        {
            get
            {
                if (f_clearLoadedAttackSprite)
                    return _clearLoadedAttackSprite;
                _clearLoadedAttackSprite = (int) (109812);
                f_clearLoadedAttackSprite = true;
                return _clearLoadedAttackSprite;
            }
        }
        private bool f_applyGravelyrockEffect;
        private int _applyGravelyrockEffect;

        /// <summary>
        /// Restores 10 hunger to the target and will raise the target's IQ if they are a bonsly
        /// or sudowoodo.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyGravelyrockEffect
        {
            get
            {
                if (f_applyGravelyrockEffect)
                    return _applyGravelyrockEffect;
                _applyGravelyrockEffect = (int) (267176);
                f_applyGravelyrockEffect = true;
                return _applyGravelyrockEffect;
            }
        }
        private bool f_displayFloorTip;
        private int _displayFloorTip;

        /// <summary>
        /// Display the dungeon tip that displays on floor change, based on which tips have already been displayed.
        /// 
        /// No params.
        /// 
        /// return: 1 if a tip has been displayed, 0 otherwise
        /// </summary>
        public int DisplayFloorTip
        {
            get
            {
                if (f_displayFloorTip)
                    return _displayFloorTip;
                _displayFloorTip = (int) (460044);
                f_displayFloorTip = true;
                return _displayFloorTip;
            }
        }
        private bool f_monsterHasNonvolatileNonsleepStatus;
        private int _monsterHasNonvolatileNonsleepStatus;

        /// <summary>
        /// Checks if a monster has one of the statuses in the &quot;burn&quot; group, which includes the traditionally non-volatile status conditions (except sleep) in the main series: STATUS_BURN, STATUS_POISONED, STATUS_BADLY_POISONED, STATUS_PARALYSIS, and STATUS_IDENTIFYING.
        /// 
        /// STATUS_IDENTIFYING is probably included based on enum status_id? Unless it's handled differently somehow.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasNonvolatileNonsleepStatus
        {
            get
            {
                if (f_monsterHasNonvolatileNonsleepStatus)
                    return _monsterHasNonvolatileNonsleepStatus;
                _monsterHasNonvolatileNonsleepStatus = (int) (147432);
                f_monsterHasNonvolatileNonsleepStatus = true;
                return _monsterHasNonvolatileNonsleepStatus;
            }
        }
        private bool f_posIsOutOfBounds;
        private int _posIsOutOfBounds;

        /// <summary>
        /// Checks if a position (x, y) is out of bounds on the map: !((0 &lt;= x &lt;= 55) &amp;&amp; (0 &lt;= y &lt;= 31)).
        /// 
        /// r0: x
        /// r1: y
        /// return: bool
        /// </summary>
        public int PosIsOutOfBounds
        {
            get
            {
                if (f_posIsOutOfBounds)
                    return _posIsOutOfBounds;
                _posIsOutOfBounds = (int) (411532);
                f_posIsOutOfBounds = true;
                return _posIsOutOfBounds;
            }
        }
        private bool f_loadMonsterSprite;
        private int _loadMonsterSprite;

        /// <summary>
        /// Loads the sprite of the specified monster to use it in a dungeon.
        /// 
        /// Irdkwia's notes: Handles Castform/Cherrim/Deoxys
        /// 
        /// r0: monster ID
        /// r1: ?
        /// </summary>
        public int LoadMonsterSprite
        {
            get
            {
                if (f_loadMonsterSprite)
                    return _loadMonsterSprite;
                _loadMonsterSprite = (int) (111416);
                f_loadMonsterSprite = true;
                return _loadMonsterSprite;
            }
        }
        private bool f_trySpawnDoughSeedPoke;
        private int _trySpawnDoughSeedPoke;

        /// <summary>
        /// Checks the dough_seed_extra_money_flag field on the dungeon struct and tries to spawn
        /// extra poke if it is set.
        /// 
        /// No params.
        /// </summary>
        public int TrySpawnDoughSeedPoke
        {
            get
            {
                if (f_trySpawnDoughSeedPoke)
                    return _trySpawnDoughSeedPoke;
                _trySpawnDoughSeedPoke = (int) (376900);
                f_trySpawnDoughSeedPoke = true;
                return _trySpawnDoughSeedPoke;
            }
        }
        private bool f_isChargingTwoTurnMove;
        private int _isChargingTwoTurnMove;

        /// <summary>
        /// Checks if a monster is currently charging the specified two-turn move.
        /// 
        /// r0: User entity pointer
        /// r1: Move pointer
        /// return: True if the user is charging the specified two-turn move, false otherwise.
        /// </summary>
        public int IsChargingTwoTurnMove
        {
            get
            {
                if (f_isChargingTwoTurnMove)
                    return _isChargingTwoTurnMove;
                _isChargingTwoTurnMove = (int) (295252);
                f_isChargingTwoTurnMove = true;
                return _isChargingTwoTurnMove;
            }
        }
        private bool f_initEnemySpawnStats;
        private int _initEnemySpawnStats;

        /// <summary>
        /// Initializes dungeon::enemy_spawn_stats. Might do something else too.
        /// 
        /// No params.
        /// </summary>
        public int InitEnemySpawnStats
        {
            get
            {
                if (f_initEnemySpawnStats)
                    return _initEnemySpawnStats;
                _initEnemySpawnStats = (int) (129640);
                f_initEnemySpawnStats = true;
                return _initEnemySpawnStats;
            }
        }
        private bool f_tryInflictNightmareStatus;
        private int _tryInflictNightmareStatus;

        /// <summary>
        /// Inflicts the Nightmare status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of turns
        /// </summary>
        public int TryInflictNightmareStatus
        {
            get
            {
                if (f_tryInflictNightmareStatus)
                    return _tryInflictNightmareStatus;
                _tryInflictNightmareStatus = (int) (219256);
                f_tryInflictNightmareStatus = true;
                return _tryInflictNightmareStatus;
            }
        }
        private bool f_scrappyShouldActivate;
        private int _scrappyShouldActivate;

        /// <summary>
        /// Checks whether Scrappy should activate.
        /// 
        /// Scrappy activates when the ability is active on the attacker, the move type is Normal or Fighting, and the defender is a Ghost type.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move type ID
        /// return: bool
        /// </summary>
        public int ScrappyShouldActivate
        {
            get
            {
                if (f_scrappyShouldActivate)
                    return _scrappyShouldActivate;
                _scrappyShouldActivate = (int) (190448);
                f_scrappyShouldActivate = true;
                return _scrappyShouldActivate;
            }
        }
        private bool f_getWeatherColorTable;
        private int _getWeatherColorTable;

        /// <summary>
        /// Gets a pointer to the floor's color table given the current weather.
        /// 
        /// The returned table contains 1024 color entries.
        /// 
        /// r0: Weather ID
        /// return: color table pointer
        /// </summary>
        public int GetWeatherColorTable
        {
            get
            {
                if (f_getWeatherColorTable)
                    return _getWeatherColorTable;
                _getWeatherColorTable = (int) (9184);
                f_getWeatherColorTable = true;
                return _getWeatherColorTable;
            }
        }
        private bool f_runMonsterAi;
        private int _runMonsterAi;

        /// <summary>
        /// Runs the AI for a single monster to determine whether the monster can act and which action it should perform if so
        /// 
        /// r0: Pointer to monster
        /// r1: Unused
        /// </summary>
        public int RunMonsterAi
        {
            get
            {
                if (f_runMonsterAi)
                    return _runMonsterAi;
                _runMonsterAi = (int) (180116);
                f_runMonsterAi = true;
                return _runMonsterAi;
            }
        }
        private bool f_tryTriggerTrap;
        private int _tryTriggerTrap;

        /// <summary>
        /// Called whenever a monster steps on a trap.
        /// 
        /// The function will try to trigger it. Nothing will happen if the pokémon has the same team as the trap. The attempt to trigger the trap can also fail due to IQ skills, due to the trap failing to work (random chance), etc.
        /// 
        /// r0: Entity who stepped on the trap
        /// r1: Trap position
        /// r2: ?
        /// r3: ?
        /// </summary>
        public int TryTriggerTrap
        {
            get
            {
                if (f_tryTriggerTrap)
                    return _tryTriggerTrap;
                _tryTriggerTrap = (int) (72996);
                f_tryTriggerTrap = true;
                return _tryTriggerTrap;
            }
        }
        private bool f_isDestinationFloorWithFixedRoom;
        private int _isDestinationFloorWithFixedRoom;

        /// <summary>
        /// Checks if the current floor is a mission destination floor with a fixed room.
        /// 
        /// The entire floor can be a fixed room layout, or it can just contain a Sealed Chamber.
        /// 
        /// return: bool
        /// </summary>
        public int IsDestinationFloorWithFixedRoom
        {
            get
            {
                if (f_isDestinationFloorWithFixedRoom)
                    return _isDestinationFloorWithFixedRoom;
                _isDestinationFloorWithFixedRoom = (int) (446188);
                f_isDestinationFloorWithFixedRoom = true;
                return _isDestinationFloorWithFixedRoom;
            }
        }
        private bool f_drawMinimapTile;
        private int _drawMinimapTile;

        /// <summary>
        /// Draws a single tile on the minimap.
        /// 
        /// r0: X position
        /// r1: Y position
        /// </summary>
        public int DrawMinimapTile
        {
            get
            {
                if (f_drawMinimapTile)
                    return _drawMinimapTile;
                _drawMinimapTile = (int) (380112);
                f_drawMinimapTile = true;
                return _drawMinimapTile;
            }
        }
        private bool f_checkTeamItemsFlags;
        private int _checkTeamItemsFlags;

        /// <summary>
        /// Checks whether any of the items in the bag or any of the items carried by team members has any of the specified flags set in its flags field.
        /// 
        /// r0: Flag(s) to check (0 = f_exists, 1 = f_in_shop, 2 = f_unpaid, etc.)
        /// return: True if any of the items of the team has the specified flags set, false otherwise.
        /// </summary>
        public int CheckTeamItemsFlags
        {
            get
            {
                if (f_checkTeamItemsFlags)
                    return _checkTeamItemsFlags;
                _checkTeamItemsFlags = (int) (435884);
                f_checkTeamItemsFlags = true;
                return _checkTeamItemsFlags;
            }
        }
        private bool f_calcStatusDuration;
        private int _calcStatusDuration;

        /// <summary>
        /// Seems to calculate the duration of a volatile status on a monster.
        /// 
        /// r0: entity pointer
        /// r1: pointer to a turn range (an array of two shorts {lower, higher})
        /// r2: flag for whether or not to factor in the Self Curer IQ skill and the Natural Cure ability
        /// return: number of turns for the status condition
        /// </summary>
        public int CalcStatusDuration
        {
            get
            {
                if (f_calcStatusDuration)
                    return _calcStatusDuration;
                _calcStatusDuration = (int) (59656);
                f_calcStatusDuration = true;
                return _calcStatusDuration;
            }
        }
        private bool f_othersMenu;
        private int _othersMenu;

        /// <summary>
        /// Called when the in-dungeon &quot;others&quot; menu is open. Does not return until the menu is closed.
        /// 
        /// return: Always 0
        /// </summary>
        public int OthersMenu
        {
            get
            {
                if (f_othersMenu)
                    return _othersMenu;
                _othersMenu = (int) (472004);
                f_othersMenu = true;
                return _othersMenu;
            }
        }
        private bool f_storyRestrictionsEnabled;
        private int _storyRestrictionsEnabled;

        /// <summary>
        /// Returns true if certain special restrictions are enabled.
        /// 
        /// If true, you will get kicked out of the dungeon if a team member that passes the arm9::JoinedAtRangeCheck2 check faints.
        /// 
        /// return: !dungeon::nonstory_flag || dungeon::hidden_land_flag
        /// </summary>
        public int StoryRestrictionsEnabled
        {
            get
            {
                if (f_storyRestrictionsEnabled)
                    return _storyRestrictionsEnabled;
                _storyRestrictionsEnabled = (int) (18136);
                f_storyRestrictionsEnabled = true;
                return _storyRestrictionsEnabled;
            }
        }
        private bool f_logMessageById;
        private int _logMessageById;

        /// <summary>
        /// Logs a message in the message log.
        /// 
        /// r0: user entity pointer
        /// r1: message ID
        /// r2: bool, whether or not to present a message popup
        /// </summary>
        public int LogMessageById
        {
            get
            {
                if (f_logMessageById)
                    return _logMessageById;
                _logMessageById = (int) (454820);
                f_logMessageById = true;
                return _logMessageById;
            }
        }
        private bool f_resetHitChanceStat;
        private int _resetHitChanceStat;

        /// <summary>
        /// Resets the specified hit chance stat (accuracy or evasion) back to normal on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: ?
        /// </summary>
        public int ResetHitChanceStat
        {
            get
            {
                if (f_resetHitChanceStat)
                    return _resetHitChanceStat;
                _resetHitChanceStat = (int) (231552);
                f_resetHitChanceStat = true;
                return _resetHitChanceStat;
            }
        }
        private bool f_getGridPositions;
        private int _getGridPositions;

        /// <summary>
        /// Get the grid cell positions for a given set of floor grid dimensions.
        /// 
        /// r0: [output] pointer to array of the starting x coordinates of each grid column
        /// r1: [output] pointer to array of the starting y coordinates of each grid row
        /// r2: grid size x
        /// r3: grid size y
        /// </summary>
        public int GetGridPositions
        {
            get
            {
                if (f_getGridPositions)
                    return _getGridPositions;
                _getGridPositions = (int) (395876);
                f_getGridPositions = true;
                return _getGridPositions;
            }
        }
        private bool f_isTacticSet;
        private int _isTacticSet;

        /// <summary>
        /// Returns whether a monster is set to use a specific tactic.
        /// 
        /// r0: Entity pointer
        /// r1: Enum tactic_id
        /// return: True if the monster is set to the given tactic.
        /// </summary>
        public int IsTacticSet
        {
            get
            {
                if (f_isTacticSet)
                    return _isTacticSet;
                _isTacticSet = (int) (154512);
                f_isTacticSet = true;
                return _isTacticSet;
            }
        }
        private bool f_tryInflictSnatchStatus;
        private int _tryInflictSnatchStatus;

        /// <summary>
        /// Inflicts the Snatch status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictSnatchStatus
        {
            get
            {
                if (f_tryInflictSnatchStatus)
                    return _tryInflictSnatchStatus;
                _tryInflictSnatchStatus = (int) (237176);
                f_tryInflictSnatchStatus = true;
                return _tryInflictSnatchStatus;
            }
        }
        private bool f_tryInflictStockpileStatus;
        private int _tryInflictStockpileStatus;

        /// <summary>
        /// Inflicts the Stockpile condition on a target monster if possible. Won't boost the level
        /// of stockpiling above 3.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: Whether or not the status could be inflicted or boosted
        /// </summary>
        public int TryInflictStockpileStatus
        {
            get
            {
                if (f_tryInflictStockpileStatus)
                    return _tryInflictStockpileStatus;
                _tryInflictStockpileStatus = (int) (237772);
                f_tryInflictStockpileStatus = true;
                return _tryInflictStockpileStatus;
            }
        }
        private bool f_getKecleonIdToSpawnByFloor;
        private int _getKecleonIdToSpawnByFloor;

        /// <summary>
        /// If the current floor number is even, returns female Kecleon's id (0x3D7), otherwise returns male Kecleon's id (0x17F).
        /// 
        /// return: monster ID
        /// </summary>
        public int GetKecleonIdToSpawnByFloor
        {
            get
            {
                if (f_getKecleonIdToSpawnByFloor)
                    return _getKecleonIdToSpawnByFloor;
                _getKecleonIdToSpawnByFloor = (int) (110804);
                f_getKecleonIdToSpawnByFloor = true;
                return _getKecleonIdToSpawnByFloor;
            }
        }
        private bool f_getMaxPpWrapper;
        private int _getMaxPpWrapper;

        /// <summary>
        /// Gets the maximum PP for a given move. A wrapper around the function in the ARM 9 binary.
        /// 
        /// r0: move pointer
        /// return: max PP for the given move, capped at 99
        /// </summary>
        public int GetMaxPpWrapper
        {
            get
            {
                if (f_getMaxPpWrapper)
                    return _getMaxPpWrapper;
                _getMaxPpWrapper = (int) (271804);
                f_getMaxPpWrapper = true;
                return _getMaxPpWrapper;
            }
        }
        private bool f_getRandomTile;
        private int _getRandomTile;

        /// <summary>
        /// Gets a random valid tile. Used for warping as well as several other things.
        /// 
        /// The selection algorithm is as follows:
        /// First, try to randomly select a valid tile that is not a hallway and is at least 6 tiles away from the leader in either direction.
        /// If none are found, try to randomly select a valid tile that is not a hallway.
        /// If none are found, try to randomly select a valid tile.
        /// If none are found, return 0.
        /// 
        /// A valid tile is defined as a floor tile that has no object or monster on it and also does not have a key door (if r1 is true).
        /// 
        /// r0: [output] position
        /// r1: boolean indicating whether or not to exclude key doors
        /// return: whether a tile was successfully found
        /// </summary>
        public int GetRandomTile
        {
            get
            {
                if (f_getRandomTile)
                    return _getRandomTile;
                _getRandomTile = (int) (54192);
                f_getRandomTile = true;
                return _getRandomTile;
            }
        }
        private bool f_applyGrimyFoodEffect;
        private int _applyGrimyFoodEffect;

        /// <summary>
        /// Randomly inflicts poison, shadow hold, burn, paralysis, or an offensive stat debuff
        /// to the target. If the survivalist iq skill or gluttony ability is active, the target
        /// has a 50% chance not to be affected.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyGrimyFoodEffect
        {
            get
            {
                if (f_applyGrimyFoodEffect)
                    return _applyGrimyFoodEffect;
                _applyGrimyFoodEffect = (int) (266524);
                f_applyGrimyFoodEffect = true;
                return _applyGrimyFoodEffect;
            }
        }
        private bool f_tryActivateIqBooster;
        private int _tryActivateIqBooster;

        /// <summary>
        /// Increases the IQ of all team members holding the IQ Booster by floor_properties::iq_booster_value amount unless the
        /// value is 0.
        /// 
        /// No params.
        /// </summary>
        public int TryActivateIqBooster
        {
            get
            {
                if (f_tryActivateIqBooster)
                    return _tryActivateIqBooster;
                _tryActivateIqBooster = (int) (79768);
                f_tryActivateIqBooster = true;
                return _tryActivateIqBooster;
            }
        }
        private bool f_spawnTeam;
        private int _spawnTeam;

        /// <summary>
        /// Seems to initialize and spawn the team when entering a dungeon.
        /// 
        /// r0: ?
        /// </summary>
        public int SpawnTeam
        {
            get
            {
                if (f_spawnTeam)
                    return _spawnTeam;
                _spawnTeam = (int) (131100);
                f_spawnTeam = true;
                return _spawnTeam;
            }
        }
        private bool f_tryInflictCoweringStatus;
        private int _tryInflictCoweringStatus;

        /// <summary>
        /// Inflicts the Cowering status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictCoweringStatus
        {
            get
            {
                if (f_tryInflictCoweringStatus)
                    return _tryInflictCoweringStatus;
                _tryInflictCoweringStatus = (int) (232804);
                f_tryInflictCoweringStatus = true;
                return _tryInflictCoweringStatus;
            }
        }
        private bool f_dungeonRandOutcomeUserTargetInteraction;
        private int _dungeonRandOutcomeUserTargetInteraction;

        /// <summary>
        /// Like DungeonRandOutcome, but specifically for user-target interactions.
        /// 
        /// This modifies the underlying random process depending on factors like Serene Grace, and whether or not either entity has fainted.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: base success percentage (100*p). 0 is treated specially and guarantees success.
        /// return: True if the random check passed, false otherwise.
        /// </summary>
        public int DungeonRandOutcomeUserTargetInteraction
        {
            get
            {
                if (f_dungeonRandOutcomeUserTargetInteraction)
                    return _dungeonRandOutcomeUserTargetInteraction;
                _dungeonRandOutcomeUserTargetInteraction = (int) (296164);
                f_dungeonRandOutcomeUserTargetInteraction = true;
                return _dungeonRandOutcomeUserTargetInteraction;
            }
        }
        private bool f_trySpawnTrap;
        private int _trySpawnTrap;

        /// <summary>
        /// Checks if the a trap can be placed on the tile. If the trap ID is &gt;= TRAP_NONE (the
        /// last value for a trap), randomly select another trap (except for wonder tile). After
        /// 30 failed attempts to select a non-wonder tile trap ID, default to chestnut trap.
        /// If the checks pass, spawn the trap.
        /// 
        /// r0: position
        /// r1: trap ID
        /// r2: team (see struct trap::team)
        /// r3: visibility flag
        /// return: true if a trap was spawned succesfully
        /// </summary>
        public int TrySpawnTrap
        {
            get
            {
                if (f_trySpawnTrap)
                    return _trySpawnTrap;
                _trySpawnTrap = (int) (72256);
                f_trySpawnTrap = true;
                return _trySpawnTrap;
            }
        }
        private bool f_tryPointCameraToMonster;
        private int _tryPointCameraToMonster;

        /// <summary>
        /// Attempts to place the camera on top of the specified monster.
        /// 
        /// If the camera is already on top of the specified entity, the function does nothing.
        /// 
        /// r0: Entity pointer. Must be a monster, otherwise the function does nothing.
        /// r1: ?
        /// r2: ?
        /// </summary>
        public int TryPointCameraToMonster
        {
            get
            {
                if (f_tryPointCameraToMonster)
                    return _tryPointCameraToMonster;
                _tryPointCameraToMonster = (int) (120204);
                f_tryPointCameraToMonster = true;
                return _tryPointCameraToMonster;
            }
        }
        private bool f_hasTypeAffectedByGravity;
        private int _hasTypeAffectedByGravity;

        /// <summary>
        /// Checks if Gravity is active and that the given monster is of an affected type (i.e., Flying type).
        /// 
        /// r0: target entity pointer
        /// r1: type ID
        /// return: bool
        /// </summary>
        public int HasTypeAffectedByGravity
        {
            get
            {
                if (f_hasTypeAffectedByGravity)
                    return _hasTypeAffectedByGravity;
                _hasTypeAffectedByGravity = (int) (154396);
                f_hasTypeAffectedByGravity = true;
                return _hasTypeAffectedByGravity;
            }
        }
        private bool f_tryActivateWeather;
        private int _tryActivateWeather;

        /// <summary>
        /// Tries to change the weather based upon the information for each weather type in the
        /// dungeon struct. Returns whether the weather was succesfully changed or not.
        /// 
        /// r0: bool to log message and play animation?
        /// r1: bool to force weather change and animation?
        /// return: True if the weather changed
        /// </summary>
        public int TryActivateWeather
        {
            get
            {
                if (f_tryActivateWeather)
                    return _tryActivateWeather;
                _tryActivateWeather = (int) (364496);
                f_tryActivateWeather = true;
                return _tryActivateWeather;
            }
        }
        private bool f_teamLeaderIqSkillIsEnabled;
        private int _teamLeaderIqSkillIsEnabled;

        /// <summary>
        /// Returns true the leader has the specified iq skill.
        /// 
        /// r0: iq skill id
        /// return: bool
        /// </summary>
        public int TeamLeaderIqSkillIsEnabled
        {
            get
            {
                if (f_teamLeaderIqSkillIsEnabled)
                    return _teamLeaderIqSkillIsEnabled;
                _teamLeaderIqSkillIsEnabled = (int) (126248);
                f_teamLeaderIqSkillIsEnabled = true;
                return _teamLeaderIqSkillIsEnabled;
            }
        }
        private bool f_tryInflictSetDamageStatus;
        private int _tryInflictSetDamageStatus;

        /// <summary>
        /// Inflicts the Set Damage status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictSetDamageStatus
        {
            get
            {
                if (f_tryInflictSetDamageStatus)
                    return _tryInflictSetDamageStatus;
                _tryInflictSetDamageStatus = (int) (235744);
                f_tryInflictSetDamageStatus = true;
                return _tryInflictSetDamageStatus;
            }
        }
        private bool f_monsterHasEmbargoStatus;
        private int _monsterHasEmbargoStatus;

        /// <summary>
        /// Returns true if the monster has the Embargo status condition.
        /// 
        /// r0: pointer to entity
        /// return: bool
        /// </summary>
        public int MonsterHasEmbargoStatus
        {
            get
            {
                if (f_monsterHasEmbargoStatus)
                    return _monsterHasEmbargoStatus;
                _monsterHasEmbargoStatus = (int) (246460);
                f_monsterHasEmbargoStatus = true;
                return _monsterHasEmbargoStatus;
            }
        }
        private bool f_getTargetMonsterNotFoundFlag;
        private int _getTargetMonsterNotFoundFlag;

        /// <summary>
        /// Gets the value of dungeon::target_monster_not_found_flag.
        /// 
        /// return: dungeon::target_monster_not_found_flag
        /// </summary>
        public int GetTargetMonsterNotFoundFlag
        {
            get
            {
                if (f_getTargetMonsterNotFoundFlag)
                    return _getTargetMonsterNotFoundFlag;
                _getTargetMonsterNotFoundFlag = (int) (446752);
                f_getTargetMonsterNotFoundFlag = true;
                return _getTargetMonsterNotFoundFlag;
            }
        }
        private bool f_createGridCellConnections;
        private int _createGridCellConnections;

        /// <summary>
        /// Create grid cell connections either by creating hallways or merging rooms.
        /// 
        /// When creating a hallway connecting a hallway anchor, the exact anchor coordinates are used as the endpoint. When creating a hallway connecting a room, a random point on the room edge facing the hallway is used as the endpoint. The grid cell boundaries are used as the middle coordinates for kinks (see CreateHallway).
        /// 
        /// If room merging is enabled, there is a 9.75% chance that two connected rooms will be merged into a single larger room (9.75% comes from two 5% rolls, one for each of the two rooms being merged). A room can only participate in a merge once.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: array of the starting x coordinates of each grid column
        /// stack[0]: array of the starting y coordinates of each grid row
        /// stack[1]: disable room merging flag
        /// </summary>
        public int CreateGridCellConnections
        {
            get
            {
                if (f_createGridCellConnections)
                    return _createGridCellConnections;
                _createGridCellConnections = (int) (401180);
                f_createGridCellConnections = true;
                return _createGridCellConnections;
            }
        }
        private bool f_tryActivateQuickFeet;
        private int _tryActivateQuickFeet;

        /// <summary>
        /// Activate the Quick Feet ability on the defender, if the monster has it and it's active.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// return: bool, whether or not the ability was activated
        /// </summary>
        public int TryActivateQuickFeet
        {
            get
            {
                if (f_tryActivateQuickFeet)
                    return _tryActivateQuickFeet;
                _tryActivateQuickFeet = (int) (231952);
                f_tryActivateQuickFeet = true;
                return _tryActivateQuickFeet;
            }
        }
        private bool f_getDungeonRngPreseed;
        private int _getDungeonRngPreseed;

        /// <summary>
        /// Gets the current preseed stored in the global dungeon PRNG state. See GenerateDungeonRngSeed for more information.
        /// 
        /// return: current dungeon RNG preseed
        /// </summary>
        public int GetDungeonRngPreseed
        {
            get
            {
                if (f_getDungeonRngPreseed)
                    return _getDungeonRngPreseed;
                _getDungeonRngPreseed = (int) (59220);
                f_getDungeonRngPreseed = true;
                return _getDungeonRngPreseed;
            }
        }
        private bool f_areTileJumpsAllowed;
        private int _areTileJumpsAllowed;

        /// <summary>
        /// Checks if tile jumps (warping, being blown away, and leaping) are allowed in the given fixed room.
        /// 
        /// Always true if not a full-floor fixed room.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int AreTileJumpsAllowed
        {
            get
            {
                if (f_areTileJumpsAllowed)
                    return _areTileJumpsAllowed;
                _areTileJumpsAllowed = (int) (424896);
                f_areTileJumpsAllowed = true;
                return _areTileJumpsAllowed;
            }
        }
        private bool f_mergeRoomsVertically;
        private int _mergeRoomsVertically;

        /// <summary>
        /// Merges two vertically stacked rooms into one larger room.
        /// 
        /// r0: x grid coordinate of the rooms to merge
        /// r1: y grid coordinate of the upper room
        /// r2: dy, where the lower room has a y grid coordinate of y+dy
        /// r3: grid to update
        /// </summary>
        public int MergeRoomsVertically
        {
            get
            {
                if (f_mergeRoomsVertically)
                    return _mergeRoomsVertically;
                _mergeRoomsVertically = (int) (391700);
                f_mergeRoomsVertically = true;
                return _mergeRoomsVertically;
            }
        }
        private bool f_doesProjectileHitTarget;
        private int _doesProjectileHitTarget;

        /// <summary>
        /// Determines if a hurled projectile will impact on a target or if the target will dodge it instead.
        /// 
        /// Contains a random chance using THROWN_ITEM_HIT_CHANCE, as well as some additional checks involving certain items (Whiff Specs, Lockon Specs and Dodge Scarf), exclusive item effects (EXCLUSIVE_EFF_THROWN_ITEM_PROTECTION) or pokémon (Kecleon, clients, secret bazaar NPCs).
        /// 
        /// r0: Monster that throws the item
        /// r1: Target monster
        /// return: True if the item impacts on the target, false if the target dodges the item.
        /// </summary>
        public int DoesProjectileHitTarget
        {
            get
            {
                if (f_doesProjectileHitTarget)
                    return _doesProjectileHitTarget;
                _doesProjectileHitTarget = (int) (441032);
                f_doesProjectileHitTarget = true;
                return _doesProjectileHitTarget;
            }
        }
        private bool f_checkVariousStatuses;
        private int _checkVariousStatuses;

        /// <summary>
        /// Returns 0 if none of these conditions holds for the given entity: asleep, frozen, petrified, biding.
        /// 
        /// r0: Entity pointer
        /// return: bool
        /// </summary>
        public int CheckVariousStatuses
        {
            get
            {
                if (f_checkVariousStatuses)
                    return _checkVariousStatuses;
                _checkVariousStatuses = (int) (149428);
                f_checkVariousStatuses = true;
                return _checkVariousStatuses;
            }
        }
        private bool f_spawnItem;
        private int _spawnItem;

        /// <summary>
        /// Spawns an item on the floor. Fails if there are more than 64 items already on the floor.
        /// 
        /// This calls SpawnItemEntity, fills in the item info struct, sets the entity to be visible, binds the entity to the tile it occupies, updates the n_items counter on the dungeon struct, and various other bits of bookkeeping.
        /// 
        /// r0: position
        /// r1: item pointer
        /// r2: some flag?
        /// return: success flag
        /// </summary>
        public int SpawnItem
        {
            get
            {
                if (f_spawnItem)
                    return _spawnItem;
                _spawnItem = (int) (430108);
                f_spawnItem = true;
                return _spawnItem;
            }
        }
        private bool f_generateCleanItem;
        private int _generateCleanItem;

        /// <summary>
        /// Wrapper around GenerateItem with quantity set to 0 and stickiness type set to SPAWN_STICKY_NEVER.
        /// 
        /// r0: pointer to item to initialize
        /// r1: item ID
        /// </summary>
        public int GenerateCleanItem
        {
            get
            {
                if (f_generateCleanItem)
                    return _generateCleanItem;
                _generateCleanItem = (int) (427720);
                f_generateCleanItem = true;
                return _generateCleanItem;
            }
        }
        private bool f_tryDrought;
        private int _tryDrought;

        /// <summary>
        /// Attempts to drain all water from the current floor.
        /// 
        /// Fails if orbs are disabled on the floor or if the current tileset has the is_water_tileset flag set.
        /// 
        /// r0: user pointer
        /// </summary>
        public int TryDrought
        {
            get
            {
                if (f_tryDrought)
                    return _tryDrought;
                _tryDrought = (int) (274784);
                f_tryDrought = true;
                return _tryDrought;
            }
        }
        private bool f_removeEmptyItemsInBagWrapper;
        private int _removeEmptyItemsInBagWrapper;

        /// <summary>
        /// Calls RemoveEmptyItemsInBag, then some other function that seems to update the minimap, the map surveyor flag, and other stuff.
        /// 
        /// No params.
        /// </summary>
        public int RemoveEmptyItemsInBagWrapper
        {
            get
            {
                if (f_removeEmptyItemsInBagWrapper)
                    return _removeEmptyItemsInBagWrapper;
                _removeEmptyItemsInBagWrapper = (int) (437008);
                f_removeEmptyItemsInBagWrapper = true;
                return _removeEmptyItemsInBagWrapper;
            }
        }
        private bool f_statusCheckerCheck;
        private int _statusCheckerCheck;

        /// <summary>
        /// Determines if using a given move against its intended targets would be redundant because all of them already have the effect caused by said move.
        /// 
        /// r0: Pointer to the entity that is considering using the move
        /// r1: Move pointer
        /// return: True if it makes sense to use the move, false if it would be redundant given the effects it causes and the effects that all the targets already have.
        /// </summary>
        public int StatusCheckerCheck
        {
            get
            {
                if (f_statusCheckerCheck)
                    return _statusCheckerCheck;
                _statusCheckerCheck = (int) (355200);
                f_statusCheckerCheck = true;
                return _statusCheckerCheck;
            }
        }
        private bool f_boostHitChanceStat;
        private int _boostHitChanceStat;

        /// <summary>
        /// Boosts the specified hit chance stat (accuracy or evasion) on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// </summary>
        public int BoostHitChanceStat
        {
            get
            {
                if (f_boostHitChanceStat)
                    return _boostHitChanceStat;
                _boostHitChanceStat = (int) (228580);
                f_boostHitChanceStat = true;
                return _boostHitChanceStat;
            }
        }
        private bool f_setDungeonRngPreseed23Bit;
        private int _setDungeonRngPreseed23Bit;

        /// <summary>
        /// Sets the preseed in the global dungeon PRNG state, using 23 bits from the input. See GenerateDungeonRngSeed for more information.
        /// 
        /// Given the input preseed23, the actual global preseed is set to (preseed23 &amp; 0xFFFFFF | 1), so only bits 1-23 of the input are used.
        /// 
        /// r0: preseed23
        /// </summary>
        public int SetDungeonRngPreseed23Bit
        {
            get
            {
                if (f_setDungeonRngPreseed23Bit)
                    return _setDungeonRngPreseed23Bit;
                _setDungeonRngPreseed23Bit = (int) (59120);
                f_setDungeonRngPreseed23Bit = true;
                return _setDungeonRngPreseed23Bit;
            }
        }
        private bool f_canAttackInDirection;
        private int _canAttackInDirection;

        /// <summary>
        /// Returns whether a monster can attack in a given direction.
        /// The check fails if the destination tile is impassable, contains a monster that isn't of type entity_type::ENTITY_MONSTER or if the monster can't directly move from the current tile into the destination tile.
        /// 
        /// r0: Entity pointer
        /// r1: Direction
        /// return: True if the monster can attack into the tile adjacent to them in the specified direction, false otherwise.
        /// </summary>
        public int CanAttackInDirection
        {
            get
            {
                if (f_canAttackInDirection)
                    return _canAttackInDirection;
                _canAttackInDirection = (int) (150964);
                f_canAttackInDirection = true;
                return _canAttackInDirection;
            }
        }
        private bool f_handleFadesDungeon;
        private int _handleFadesDungeon;

        /// <summary>
        /// Gets called every frame for both screens in dungeon mode. Handles the status of the screen fades.
        /// 
        /// r0: enum screen
        /// </summary>
        public int HandleFadesDungeon
        {
            get
            {
                if (f_handleFadesDungeon)
                    return _handleFadesDungeon;
                _handleFadesDungeon = (int) (459096);
                f_handleFadesDungeon = true;
                return _handleFadesDungeon;
            }
        }
        private bool f_tryActivateTraceAndColorChange;
        private int _tryActivateTraceAndColorChange;

        /// <summary>
        /// Tries to activate the abilities trace and color change if possible. Called after using
        /// a move.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// r2: move pointer
        /// </summary>
        public int TryActivateTraceAndColorChange
        {
            get
            {
                if (f_tryActivateTraceAndColorChange)
                    return _tryActivateTraceAndColorChange;
                _tryActivateTraceAndColorChange = (int) (119252);
                f_tryActivateTraceAndColorChange = true;
                return _tryActivateTraceAndColorChange;
            }
        }
        private bool f_hasDropeyeStatus;
        private int _hasDropeyeStatus;

        /// <summary>
        /// Returns whether a certain monster is under the effect of status::STATUS_DROPEYE.
        /// 
        /// r0: Entity pointer
        /// return: True if the monster has dropeye status.
        /// </summary>
        public int HasDropeyeStatus
        {
            get
            {
                if (f_hasDropeyeStatus)
                    return _hasDropeyeStatus;
                _hasDropeyeStatus = (int) (154560);
                f_hasDropeyeStatus = true;
                return _hasDropeyeStatus;
            }
        }
        private bool f_isDestinationFloorWithHiddenOutlaw;
        private int _isDestinationFloorWithHiddenOutlaw;

        /// <summary>
        /// Checks if the current floor is a mission destination floor with a &quot;hidden outlaw&quot; that behaves like a normal enemy.
        /// 
        /// return: bool
        /// </summary>
        public int IsDestinationFloorWithHiddenOutlaw
        {
            get
            {
                if (f_isDestinationFloorWithHiddenOutlaw)
                    return _isDestinationFloorWithHiddenOutlaw;
                _isDestinationFloorWithHiddenOutlaw = (int) (446476);
                f_isDestinationFloorWithHiddenOutlaw = true;
                return _isDestinationFloorWithHiddenOutlaw;
            }
        }
        private bool f_cannotStandOnTile;
        private int _cannotStandOnTile;

        /// <summary>
        /// Checks if a given monster cannot stand on a given tile.
        /// 
        /// Reasons include:
        /// - The coordinates of the tile are out of bounds
        /// - There's another monster on the tile
        /// - The monster does not have the required mobility to stand on the tile
        /// 
        /// r0: Entity pointer
        /// r1: Tile pointer
        /// return: True if the monster cannot stand on the specified tile, false if it can
        /// </summary>
        public int CannotStandOnTile
        {
            get
            {
                if (f_cannotStandOnTile)
                    return _cannotStandOnTile;
                _cannotStandOnTile = (int) (145356);
                f_cannotStandOnTile = true;
                return _cannotStandOnTile;
            }
        }
        private bool f_shouldMonsterFollowLeader;
        private int _shouldMonsterFollowLeader;

        /// <summary>
        /// Checks if the monster should follow the leader. Always returns false for enemy monsters.
        /// This function may actually be should monster target leader position.
        /// 
        /// r0: Pointer to monster
        /// return: bool
        /// </summary>
        public int ShouldMonsterFollowLeader
        {
            get
            {
                if (f_shouldMonsterFollowLeader)
                    return _shouldMonsterFollowLeader;
                _shouldMonsterFollowLeader = (int) (179956);
                f_shouldMonsterFollowLeader = true;
                return _shouldMonsterFollowLeader;
            }
        }
        private bool f_tryInflictEmbargoStatus;
        private int _tryInflictEmbargoStatus;

        /// <summary>
        /// Inflicts the Embargo status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log message
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictEmbargoStatus
        {
            get
            {
                if (f_tryInflictEmbargoStatus)
                    return _tryInflictEmbargoStatus;
                _tryInflictEmbargoStatus = (int) (246556);
                f_tryInflictEmbargoStatus = true;
                return _tryInflictEmbargoStatus;
            }
        }
        private bool f_tryInflictEyedropStatus;
        private int _tryInflictEyedropStatus;

        /// <summary>
        /// Inflicts the Eyedrop status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictEyedropStatus
        {
            get
            {
                if (f_tryInflictEyedropStatus)
                    return _tryInflictEyedropStatus;
                _tryInflictEyedropStatus = (int) (243020);
                f_tryInflictEyedropStatus = true;
                return _tryInflictEyedropStatus;
            }
        }
        private bool f_spawnEnemyTrapAtPos;
        private int _spawnEnemyTrapAtPos;

        /// <summary>
        /// A convenience wrapper around SpawnTrap and BindTrapToTile. Always passes 0 for the team parameter (making it an enemy trap).
        /// 
        /// r0: trap ID
        /// r1: x position
        /// r2: y position
        /// r3: flags
        /// stack[0]: visibility flag
        /// </summary>
        public int SpawnEnemyTrapAtPos
        {
            get
            {
                if (f_spawnEnemyTrapAtPos)
                    return _spawnEnemyTrapAtPos;
                _spawnEnemyTrapAtPos = (int) (71412);
                f_spawnEnemyTrapAtPos = true;
                return _spawnEnemyTrapAtPos;
            }
        }
        private bool f_generateExtraHallways;
        private int _generateExtraHallways;

        /// <summary>
        /// Generate extra hallways on the floor via a series of random walks.
        /// 
        /// Each random walk starts from a random tile in a random room, leaves the room in a random cardinal direction, and from there tunnels through obstacles through a series of random turns, leaving open terrain in its wake. The random walk stops when it reaches open terrain, goes out of bounds, or reaches an impassable obstruction.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: number of extra hallways to generate
        /// </summary>
        public int GenerateExtraHallways
        {
            get
            {
                if (f_generateExtraHallways)
                    return _generateExtraHallways;
                _generateExtraHallways = (int) (394440);
                f_generateExtraHallways = true;
                return _generateExtraHallways;
            }
        }
        private bool f_flashLeaderIcon;
        private int _flashLeaderIcon;

        /// <summary>
        /// Seems to control flashing the leader's icon on the minimap when r0 = 0? Doesn't seem to ever be called when r0 = 1.
        /// 
        /// r0: ?
        /// </summary>
        public int FlashLeaderIcon
        {
            get
            {
                if (f_flashLeaderIcon)
                    return _flashLeaderIcon;
                _flashLeaderIcon = (int) (382216);
                f_flashLeaderIcon = true;
                return _flashLeaderIcon;
            }
        }
        private bool f_mistIsActive;
        private int _mistIsActive;

        /// <summary>
        /// Checks if the monster is under the effect of Mist.
        /// 
        /// Returns 1 if the effects is a status, 2 if it comes from an exclusive item, 0 otherwise.
        /// 
        /// r0: pointer to entity
        /// return: int
        /// </summary>
        public int MistIsActive
        {
            get
            {
                if (f_mistIsActive)
                    return _mistIsActive;
                _mistIsActive = (int) (250812);
                f_mistIsActive = true;
                return _mistIsActive;
            }
        }
        private bool f_getDefaultTileTextureId;
        private int _getDefaultTileTextureId;

        /// <summary>
        /// Returns the texture_id of the default tile?
        /// 
        /// return: texture_id
        /// </summary>
        public int GetDefaultTileTextureId
        {
            get
            {
                if (f_getDefaultTileTextureId)
                    return _getDefaultTileTextureId;
                _getDefaultTileTextureId = (int) (368448);
                f_getDefaultTileTextureId = true;
                return _getDefaultTileTextureId;
            }
        }
        private bool f_tryInflictSlipStatus;
        private int _tryInflictSlipStatus;

        /// <summary>
        /// Inflicts the Slip status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictSlipStatus
        {
            get
            {
                if (f_tryInflictSlipStatus)
                    return _tryInflictSlipStatus;
                _tryInflictSlipStatus = (int) (243196);
                f_tryInflictSlipStatus = true;
                return _tryInflictSlipStatus;
            }
        }
        private bool f_canMonsterMoveOrSwapWithAllyInDirection;
        private int _canMonsterMoveOrSwapWithAllyInDirection;

        /// <summary>
        /// Checks if the given monster can move in the specified direction. Includes if an allied or neutral monster is standing on an adjacent tile, as the monsters can swap places.
        /// 
        /// Returns false if an enemy monster is standing on the target tile
        /// 
        /// r0: Monster entity pointer
        /// r1: Direction to check
        /// return: bool
        /// </summary>
        public int CanMonsterMoveOrSwapWithAllyInDirection
        {
            get
            {
                if (f_canMonsterMoveOrSwapWithAllyInDirection)
                    return _canMonsterMoveOrSwapWithAllyInDirection;
                _canMonsterMoveOrSwapWithAllyInDirection = (int) (150652);
                f_canMonsterMoveOrSwapWithAllyInDirection = true;
                return _canMonsterMoveOrSwapWithAllyInDirection;
            }
        }
        private bool f_renderWeather3D;
        private int _renderWeather3D;

        /// <summary>
        /// Renders the 3D effects for the tileset weather as well as the Sandstorm/Fog weather conditions.
        /// 
        /// No params.
        /// </summary>
        public int RenderWeather3D
        {
            get
            {
                if (f_renderWeather3D)
                    return _renderWeather3D;
                _renderWeather3D = (int) (378280);
                f_renderWeather3D = true;
                return _renderWeather3D;
            }
        }
        private bool f_getNumberOfAttacks;
        private int _getNumberOfAttacks;

        /// <summary>
        /// Returns the number of attacks that a monster can do in one turn (1 or 2).
        /// 
        /// Checks for the abilities Swift Swim, Chlorophyll, Unburden, and for exclusive items.
        /// 
        /// r0: pointer to entity
        /// return: int
        /// </summary>
        public int GetNumberOfAttacks
        {
            get
            {
                if (f_getNumberOfAttacks)
                    return _getNumberOfAttacks;
                _getNumberOfAttacks = (int) (146092);
                f_getNumberOfAttacks = true;
                return _getNumberOfAttacks;
            }
        }
        private bool f_getItemToDeliver;
        private int _getItemToDeliver;

        /// <summary>
        /// Get the ID of the item that needs to be delivered to a mission client on the current floor, if one exists.
        /// 
        /// return: item ID
        /// </summary>
        public int GetItemToDeliver
        {
            get
            {
                if (f_getItemToDeliver)
                    return _getItemToDeliver;
                _getItemToDeliver = (int) (446264);
                f_getItemToDeliver = true;
                return _getItemToDeliver;
            }
        }
        private bool f_dungeonFree;
        private int _dungeonFree;

        /// <summary>
        /// Frees the dungeons struct pointer to by the master dungeon pointer, and nullifies the pointer.
        /// 
        /// No params.
        /// </summary>
        public int DungeonFree
        {
            get
            {
                if (f_dungeonFree)
                    return _dungeonFree;
                _dungeonFree = (int) (10352);
                f_dungeonFree = true;
                return _dungeonFree;
            }
        }
        private bool f_generateLineFloor;
        private int _generateLineFloor;

        /// <summary>
        /// Generates a floor layout with 5 grid cells in a horizontal line.
        /// 
        /// r0: floor properties
        /// </summary>
        public int GenerateLineFloor
        {
            get
            {
                if (f_generateLineFloor)
                    return _generateLineFloor;
                _generateLineFloor = (int) (390496);
                f_generateLineFloor = true;
                return _generateLineFloor;
            }
        }
        private bool f_generateOuterRoomsFloor;
        private int _generateOuterRoomsFloor;

        /// <summary>
        /// Generates a floor layout with a ring of rooms on the grid boundary and nothing in the interior.
        /// 
        /// Note that this function is bugged, and won't properly connect all the rooms together for grid_size_x &lt; 4.
        /// 
        /// r0: grid size x
        /// r1: grid size y
        /// r2: floor properties
        /// </summary>
        public int GenerateOuterRoomsFloor
        {
            get
            {
                if (f_generateOuterRoomsFloor)
                    return _generateOuterRoomsFloor;
                _generateOuterRoomsFloor = (int) (392032);
                f_generateOuterRoomsFloor = true;
                return _generateOuterRoomsFloor;
            }
        }
        private bool f_positionIsOnHiddenStairs;
        private int _positionIsOnHiddenStairs;

        /// <summary>
        /// Checks if this location is on top of the hidden stairs.
        /// 
        /// r0: position pointer
        /// return: bool
        /// </summary>
        public int PositionIsOnHiddenStairs
        {
            get
            {
                if (f_positionIsOnHiddenStairs)
                    return _positionIsOnHiddenStairs;
                _positionIsOnHiddenStairs = (int) (377324);
                f_positionIsOnHiddenStairs = true;
                return _positionIsOnHiddenStairs;
            }
        }
        private bool f_calcDamageFixedWrapper;
        private int _calcDamageFixedWrapper;

        /// <summary>
        /// A wrapper around CalcDamageFixed.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: fixed damage
        /// r3: experience flag (see ApplyDamage)
        /// stack[0]: [output] struct containing info about the damage calculation
        /// stack[1]: attack type
        /// stack[2]: move category
        /// stack[3]: damage source
        /// stack[4]: damage message
        /// others: ?
        /// </summary>
        public int CalcDamageFixedWrapper
        {
            get
            {
                if (f_calcDamageFixedWrapper)
                    return _calcDamageFixedWrapper;
                _calcDamageFixedWrapper = (int) (200784);
                f_calcDamageFixedWrapper = true;
                return _calcDamageFixedWrapper;
            }
        }
        private bool f_getPlayerGender;
        private int _getPlayerGender;

        /// <summary>
        /// Gets the gender of the player.
        /// 
        /// return: monster_gender
        /// </summary>
        public int GetPlayerGender
        {
            get
            {
                if (f_getPlayerGender)
                    return _getPlayerGender;
                _getPlayerGender = (int) (98288);
                f_getPlayerGender = true;
                return _getPlayerGender;
            }
        }
        private bool f_missionTargetEnemyIsDefeated;
        private int _missionTargetEnemyIsDefeated;

        /// <summary>
        /// Checks if the target enemy of the mission on the current floor has been defeated.
        /// 
        /// return: bool
        /// </summary>
        public int MissionTargetEnemyIsDefeated
        {
            get
            {
                if (f_missionTargetEnemyIsDefeated)
                    return _missionTargetEnemyIsDefeated;
                _missionTargetEnemyIsDefeated = (int) (446136);
                f_missionTargetEnemyIsDefeated = true;
                return _missionTargetEnemyIsDefeated;
            }
        }
        private bool f_isNormalFloor;
        private int _isNormalFloor;

        /// <summary>
        /// Checks if the current floor is a normal layout.
        /// 
        /// &quot;Normal&quot; means any layout that is NOT one of the following:
        /// - Hidden stairs floors
        /// - Golden Chamber
        /// - Challenge Request floor
        /// - Outlaw hideout
        /// - Treasure Memo floor
        /// - Full-room fixed floors (ID &lt; 0xA5) [0xA5 == Sealed Chamber]
        /// 
        /// return: bool
        /// </summary>
        public int IsNormalFloor
        {
            get
            {
                if (f_isNormalFloor)
                    return _isNormalFloor;
                _isNormalFloor = (int) (385336);
                f_isNormalFloor = true;
                return _isNormalFloor;
            }
        }
        private bool f_tryInflictMistStatus;
        private int _tryInflictMistStatus;

        /// <summary>
        /// Inflicts the Mist status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictMistStatus
        {
            get
            {
                if (f_tryInflictMistStatus)
                    return _tryInflictMistStatus;
                _tryInflictMistStatus = (int) (248576);
                f_tryInflictMistStatus = true;
                return _tryInflictMistStatus;
            }
        }
        private bool f_getMonsterApparentId;
        private int _getMonsterApparentId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: target entity pointer
        /// r1: current_id
        /// return: ?
        /// </summary>
        public int GetMonsterApparentId
        {
            get
            {
                if (f_getMonsterApparentId)
                    return _getMonsterApparentId;
                _getMonsterApparentId = (int) (119020);
                f_getMonsterApparentId = true;
                return _getMonsterApparentId;
            }
        }
        private bool f_applyTrapEffect;
        private int _applyTrapEffect;

        /// <summary>
        /// Performs the effect of a triggered trap.
        /// 
        /// The trap's animation happens before this function is called.
        /// 
        /// r0: Triggered trap
        /// r1: User
        /// r2: Target, normally same as user
        /// r3: Tile that contains the trap
        /// stack[0]: position
        /// stack[1]: trap ID
        /// stack[2]: bool caused by random trap
        /// return: True if the trap should be destroyed after the effect is applied
        /// </summary>
        public int ApplyTrapEffect
        {
            get
            {
                if (f_applyTrapEffect)
                    return _applyTrapEffect;
                _applyTrapEffect = (int) (77392);
                f_applyTrapEffect = true;
                return _applyTrapEffect;
            }
        }
        private bool f_findClosestUnoccupiedTileWithin2;
        private int _findClosestUnoccupiedTileWithin2;

        /// <summary>
        /// Searches for the closest unoccupied tile within 2 steps of the given origin.
        /// 
        /// Calls FindNearbyUnoccupiedTile with DISPLACEMENTS_WITHIN_2_SMALLEST_FIRST.
        /// 
        /// r0: [output] position
        /// r1: origin position
        /// r2: random room mode flag
        /// return: whether a tile was successfully found
        /// </summary>
        public int FindClosestUnoccupiedTileWithin2
        {
            get
            {
                if (f_findClosestUnoccupiedTileWithin2)
                    return _findClosestUnoccupiedTileWithin2;
                _findClosestUnoccupiedTileWithin2 = (int) (55160);
                f_findClosestUnoccupiedTileWithin2 = true;
                return _findClosestUnoccupiedTileWithin2;
            }
        }
        private bool f_leafGuardIsActive;
        private int _leafGuardIsActive;

        /// <summary>
        /// Checks if the monster is protected by the ability Leaf Guard.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message
        /// return: bool
        /// </summary>
        public int LeafGuardIsActive
        {
            get
            {
                if (f_leafGuardIsActive)
                    return _leafGuardIsActive;
                _leafGuardIsActive = (int) (153120);
                f_leafGuardIsActive = true;
                return _leafGuardIsActive;
            }
        }
        private bool f_getScenarioBalanceVeneer;
        private int _getScenarioBalanceVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for GetScenarioBalance.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// </summary>
        public int GetScenarioBalanceVeneer
        {
            get
            {
                if (f_getScenarioBalanceVeneer)
                    return _getScenarioBalanceVeneer;
                _getScenarioBalanceVeneer = (int) (18188);
                f_getScenarioBalanceVeneer = true;
                return _getScenarioBalanceVeneer;
            }
        }
        private bool f_exclusiveItemDefenseBoost;
        private int _exclusiveItemDefenseBoost;

        /// <summary>
        /// Gets the exclusive item boost for defense/special defense for a monster
        /// 
        /// r0: entity pointer
        /// r1: move category index (0 for physical, 1 for special)
        /// return: boost
        /// </summary>
        public int ExclusiveItemDefenseBoost
        {
            get
            {
                if (f_exclusiveItemDefenseBoost)
                    return _exclusiveItemDefenseBoost;
                _exclusiveItemDefenseBoost = (int) (209892);
                f_exclusiveItemDefenseBoost = true;
                return _exclusiveItemDefenseBoost;
            }
        }
        private bool f_moveHitCheck;
        private int _moveHitCheck;

        /// <summary>
        /// Determines if a move used hits or misses the target. It gets called twice per target, once with r3 = false and a second time with r3 = true.
        /// 
        /// r0: Attacker
        /// r1: Defender
        /// r2: Pointer to move data
        /// r3: False if the move's first accuracy (accuracy1) should be used, true if its second accuracy (accuracy2) should be used instead.
        /// stack[0]: If true, always hit if the attacker and defender are the same. Otherwise, moves can miss no matter what the attacker and defender are.
        /// return: True if the move hits, false if it misses.
        /// </summary>
        public int MoveHitCheck
        {
            get
            {
                if (f_moveHitCheck)
                    return _moveHitCheck;
                _moveHitCheck = (int) (292872);
                f_moveHitCheck = true;
                return _moveHitCheck;
            }
        }
        private bool f_updateStatusIconFlags;
        private int _updateStatusIconFlags;

        /// <summary>
        /// Sets a monster's status_icon_flags bitfield according to its current status effects. Does not affect a Sudowoodo in the &quot;permanent sleep&quot; state (statuses::sleep == 0x7F).
        /// 
        /// Some of the status effect in monster::statuses are used as an index to access an array, where every group of 8 bytes represents a bitmask. All masks are added in a bitwise OR and then stored in monster::status_icon.
        /// 
        /// Also sets icon flags for statuses::exposed, statuses::grudge, critical HP and lowered stats with explicit checks, and applies the effect of the Identifier Orb (see dungeon::identify_orb_flag).
        /// 
        /// r0: entity pointer
        /// </summary>
        public int UpdateStatusIconFlags
        {
            get
            {
                if (f_updateStatusIconFlags)
                    return _updateStatusIconFlags;
                _updateStatusIconFlags = (int) (30788);
                f_updateStatusIconFlags = true;
                return _updateStatusIconFlags;
            }
        }
        private bool f_getRandomSpawnMonsterId;
        private int _getRandomSpawnMonsterId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: monster ID?
        /// </summary>
        public int GetRandomSpawnMonsterId
        {
            get
            {
                if (f_getRandomSpawnMonsterId)
                    return _getRandomSpawnMonsterId;
                _getRandomSpawnMonsterId = (int) (375420);
                f_getRandomSpawnMonsterId = true;
                return _getRandomSpawnMonsterId;
            }
        }
        private bool f_monsterHasLeechSeedStatus;
        private int _monsterHasLeechSeedStatus;

        /// <summary>
        /// Checks if a monster is afflicted with Leech Seed.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasLeechSeedStatus
        {
            get
            {
                if (f_monsterHasLeechSeedStatus)
                    return _monsterHasLeechSeedStatus;
                _monsterHasLeechSeedStatus = (int) (147596);
                f_monsterHasLeechSeedStatus = true;
                return _monsterHasLeechSeedStatus;
            }
        }
        private bool f_boostSpeedOneStage;
        private int _boostSpeedOneStage;

        /// <summary>
        /// A wrapper around BoostSpeed with the number of stages set to 1.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of turns
        /// r3: flag to log a message on failure
        /// </summary>
        public int BoostSpeedOneStage
        {
            get
            {
                if (f_boostSpeedOneStage)
                    return _boostSpeedOneStage;
                _boostSpeedOneStage = (int) (230704);
                f_boostSpeedOneStage = true;
                return _boostSpeedOneStage;
            }
        }
        private bool f_isOutlawMonsterHouseFloor;
        private int _isOutlawMonsterHouseFloor;

        /// <summary>
        /// Checks if the current floor is a mission destination for a Monster House outlaw mission.
        /// 
        /// return: bool
        /// </summary>
        public int IsOutlawMonsterHouseFloor
        {
            get
            {
                if (f_isOutlawMonsterHouseFloor)
                    return _isOutlawMonsterHouseFloor;
                _isOutlawMonsterHouseFloor = (int) (445652);
                f_isOutlawMonsterHouseFloor = true;
                return _isOutlawMonsterHouseFloor;
            }
        }
        private bool f_bindTrapToTile;
        private int _bindTrapToTile;

        /// <summary>
        /// Sets the given tile's associated object to be the given trap, and sets the visibility of the trap.
        /// 
        /// r0: tile pointer
        /// r1: entity pointer
        /// r2: visibility flag
        /// </summary>
        public int BindTrapToTile
        {
            get
            {
                if (f_bindTrapToTile)
                    return _bindTrapToTile;
                _bindTrapToTile = (int) (71132);
                f_bindTrapToTile = true;
                return _bindTrapToTile;
            }
        }
        private bool f_substitutePlaceholderStringTags;
        private int _substitutePlaceholderStringTags;

        /// <summary>
        /// Replaces instances of a given placeholder tag by the string representation of the given entity.
        /// 
        /// From the eos-move-effects docs (which are somewhat nebulous): &quot;Replaces the string at StringID [r0] by the string representation of the target [r1] (aka its name). Any message with the string manipulator '[string:StringID]' will use that string&quot;.
        /// 
        /// The game uses various placeholder tags in its strings, which you can read about here: https://textbox.skytemple.org/.
        /// 
        /// r0: string ID (unclear what this means)
        /// r1: entity pointer
        /// r2: ?
        /// </summary>
        public int SubstitutePlaceholderStringTags
        {
            get
            {
                if (f_substitutePlaceholderStringTags)
                    return _substitutePlaceholderStringTags;
                _substitutePlaceholderStringTags = (int) (26764);
                f_substitutePlaceholderStringTags = true;
                return _substitutePlaceholderStringTags;
            }
        }
        private bool f_updateTrapsVisibility;
        private int _updateTrapsVisibility;

        /// <summary>
        /// Exact purpose unknown. Gets called whenever a trap tile is shown or hidden.
        /// 
        /// No params.
        /// </summary>
        public int UpdateTrapsVisibility
        {
            get
            {
                if (f_updateTrapsVisibility)
                    return _updateTrapsVisibility;
                _updateTrapsVisibility = (int) (371252);
                f_updateTrapsVisibility = true;
                return _updateTrapsVisibility;
            }
        }
        private bool f_floorNumberIsEven;
        private int _floorNumberIsEven;

        /// <summary>
        /// Checks if the current dungeon floor number is even (probably to determine whether an enemy spawn should be female).
        /// 
        /// Has a special check to return false for Labyrinth Cave B10F (the Gabite boss fight).
        /// 
        /// return: bool
        /// </summary>
        public int FloorNumberIsEven
        {
            get
            {
                if (f_floorNumberIsEven)
                    return _floorNumberIsEven;
                _floorNumberIsEven = (int) (110748);
                f_floorNumberIsEven = true;
                return _floorNumberIsEven;
            }
        }
        private bool f_generateCrossFloor;
        private int _generateCrossFloor;

        /// <summary>
        /// Generates a floor layout with 5 rooms arranged in a cross (&quot;plus sign&quot;) formation.
        /// 
        /// r0: floor properties
        /// </summary>
        public int GenerateCrossFloor
        {
            get
            {
                if (f_generateCrossFloor)
                    return _generateCrossFloor;
                _generateCrossFloor = (int) (390848);
                f_generateCrossFloor = true;
                return _generateCrossFloor;
            }
        }
        private bool f_tryInflictLightScreenStatus;
        private int _tryInflictLightScreenStatus;

        /// <summary>
        /// Inflicts the Light Screen status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictLightScreenStatus
        {
            get
            {
                if (f_tryInflictLightScreenStatus)
                    return _tryInflictLightScreenStatus;
                _tryInflictLightScreenStatus = (int) (249052);
                f_tryInflictLightScreenStatus = true;
                return _tryInflictLightScreenStatus;
            }
        }
        private bool f_generateItemExplicit;
        private int _generateItemExplicit;

        /// <summary>
        /// Initializes an item struct with the given information.
        /// 
        /// This calls InitStandardItem, then explicitly sets the quantity and stickiness. If quantity == 0 for Poké, GenerateCleanItem is used instead.
        /// 
        /// r0: pointer to item to initialize
        /// r1: item ID
        /// r2: quantity
        /// r3: sticky flag
        /// </summary>
        public int GenerateItemExplicit
        {
            get
            {
                if (f_generateItemExplicit)
                    return _generateItemExplicit;
                _generateItemExplicit = (int) (425624);
                f_generateItemExplicit = true;
                return _generateItemExplicit;
            }
        }
        private bool f_tryInflictAquaRingStatus;
        private int _tryInflictAquaRingStatus;

        /// <summary>
        /// Inflicts the Aqua Ring status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictAquaRingStatus
        {
            get
            {
                if (f_tryInflictAquaRingStatus)
                    return _tryInflictAquaRingStatus;
                _tryInflictAquaRingStatus = (int) (245836);
                f_tryInflictAquaRingStatus = true;
                return _tryInflictAquaRingStatus;
            }
        }
        private bool f_getStairsRoom;
        private int _getStairsRoom;

        /// <summary>
        /// Returns the index of the room that contains the stairs
        /// 
        /// return: Room index
        /// </summary>
        public int GetStairsRoom
        {
            get
            {
                if (f_getStairsRoom)
                    return _getStairsRoom;
                _getStairsRoom = (int) (368408);
                f_getStairsRoom = true;
                return _getStairsRoom;
            }
        }
        private bool f_tryInflictFrozenStatus;
        private int _tryInflictFrozenStatus;

        /// <summary>
        /// Inflicts the Frozen status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// </summary>
        public int TryInflictFrozenStatus
        {
            get
            {
                if (f_tryInflictFrozenStatus)
                    return _tryInflictFrozenStatus;
                _tryInflictFrozenStatus = (int) (223244);
                f_tryInflictFrozenStatus = true;
                return _tryInflictFrozenStatus;
            }
        }
        private bool f_revealItems;
        private int _revealItems;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int RevealItems
        {
            get
            {
                if (f_revealItems)
                    return _revealItems;
                _revealItems = (int) (233992);
                f_revealItems = true;
                return _revealItems;
            }
        }
        private bool f_shouldBoostKecleonShopSpawnChance;
        private int _shouldBoostKecleonShopSpawnChance;

        /// <summary>
        /// Gets the boost_kecleon_shop_spawn_chance field on the dungeon struct.
        /// 
        /// return: bool
        /// </summary>
        public int ShouldBoostKecleonShopSpawnChance
        {
            get
            {
                if (f_shouldBoostKecleonShopSpawnChance)
                    return _shouldBoostKecleonShopSpawnChance;
                _shouldBoostKecleonShopSpawnChance = (int) (376740);
                f_shouldBoostKecleonShopSpawnChance = true;
                return _shouldBoostKecleonShopSpawnChance;
            }
        }
        private bool f_fillMissionDestinationInfo;
        private int _fillMissionDestinationInfo;

        /// <summary>
        /// Fills the dungeon::mission_destination_info field with information from the currently active mission on the floor, if one is present.
        /// 
        /// No params.
        /// </summary>
        public int FillMissionDestinationInfo
        {
            get
            {
                if (f_fillMissionDestinationInfo)
                    return _fillMissionDestinationInfo;
                _fillMissionDestinationInfo = (int) (442184);
                f_fillMissionDestinationInfo = true;
                return _fillMissionDestinationInfo;
            }
        }
        private bool f_isJirachiChallengeFloor;
        private int _isJirachiChallengeFloor;

        /// <summary>
        /// Checks if the current floor is the boss floor in Star Cave Pit for Jirachi's Challenge Letter mission.
        /// 
        /// return: bool
        /// </summary>
        public int IsJirachiChallengeFloor
        {
            get
            {
                if (f_isJirachiChallengeFloor)
                    return _isJirachiChallengeFloor;
                _isJirachiChallengeFloor = (int) (445788);
                f_isJirachiChallengeFloor = true;
                return _isJirachiChallengeFloor;
            }
        }
        private bool f_applyKeyEffect;
        private int _applyKeyEffect;

        /// <summary>
        /// Attempts to open a locked door in front of the target if a locked door has not already
        /// been open on the floor.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyKeyEffect
        {
            get
            {
                if (f_applyKeyEffect)
                    return _applyKeyEffect;
                _applyKeyEffect = (int) (423868);
                f_applyKeyEffect = true;
                return _applyKeyEffect;
            }
        }
        private bool f_generateTwoRoomsWithMonsterHouseFloor;
        private int _generateTwoRoomsWithMonsterHouseFloor;

        /// <summary>
        /// Generate a floor layout with two rooms (left and right), one of which is a Monster House.
        /// 
        /// No params.
        /// </summary>
        public int GenerateTwoRoomsWithMonsterHouseFloor
        {
            get
            {
                if (f_generateTwoRoomsWithMonsterHouseFloor)
                    return _generateTwoRoomsWithMonsterHouseFloor;
                _generateTwoRoomsWithMonsterHouseFloor = (int) (394020);
                f_generateTwoRoomsWithMonsterHouseFloor = true;
                return _generateTwoRoomsWithMonsterHouseFloor;
            }
        }
        private bool f_setHiddenFloorField;
        private int _setHiddenFloorField;

        /// <summary>
        /// Sets the hidden_floor_type variable from dungeon::dungeon_generation_info to a certain value.
        /// 
        /// r0: New value
        /// </summary>
        public int SetHiddenFloorField
        {
            get
            {
                if (f_setHiddenFloorField)
                    return _setHiddenFloorField;
                _setHiddenFloorField = (int) (377724);
                f_setHiddenFloorField = true;
                return _setHiddenFloorField;
            }
        }
        private bool f_setAndLoadCurrentAttackAnimation;
        private int _setAndLoadCurrentAttackAnimation;

        /// <summary>
        /// Load given sprite into the currently loaded attack sprite structure, replacing the previous one if already loaded.
        /// 
        /// r0: pack id
        /// r1: file index
        /// return: sprite id in the loaded wan list
        /// </summary>
        public int SetAndLoadCurrentAttackAnimation
        {
            get
            {
                if (f_setAndLoadCurrentAttackAnimation)
                    return _setAndLoadCurrentAttackAnimation;
                _setAndLoadCurrentAttackAnimation = (int) (109652);
                f_setAndLoadCurrentAttackAnimation = true;
                return _setAndLoadCurrentAttackAnimation;
            }
        }
        private bool f_tryInflictCurseStatus;
        private int _tryInflictCurseStatus;

        /// <summary>
        /// Inflicts the Curse status condition on a target monster if possible and if the user is
        /// a ghost type. Otherwise, just boost the user's defense and attack then lower the user's
        /// speed.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictCurseStatus
        {
            get
            {
                if (f_tryInflictCurseStatus)
                    return _tryInflictCurseStatus;
                _tryInflictCurseStatus = (int) (236756);
                f_tryInflictCurseStatus = true;
                return _tryInflictCurseStatus;
            }
        }
        private bool f_openMenu;
        private int _openMenu;

        /// <summary>
        /// Opens a menu. The menu to open depends on the specified parameter.
        /// 
        /// It looks like the function takes a parameter in r0, but doesn't use it. r1 doesn't even get set when this function is called.
        /// 
        /// r0: (?) Unused by the function. Seems to be 1 byte long.
        /// r1: (?) Unused by the function. Seems to be 1 byte long.
        /// r2: True to open the bag menu, false to open the main dungeon menu
        /// </summary>
        public int OpenMenu
        {
            get
            {
                if (f_openMenu)
                    return _openMenu;
                _openMenu = (int) (464800);
                f_openMenu = true;
                return _openMenu;
            }
        }
        private bool f_getItemIdToSpawn;
        private int _getItemIdToSpawn;

        /// <summary>
        /// Randomly picks an item to spawn using one of the floor's item spawn lists and returns its ID.
        /// 
        /// If the function fails to properly choose an item (due to, for example, a corrupted item list), ITEM_POKE is returned.
        /// 
        /// r0: Which item list to use
        /// return: Item ID
        /// </summary>
        public int GetItemIdToSpawn
        {
            get
            {
                if (f_getItemIdToSpawn)
                    return _getItemIdToSpawn;
                _getItemIdToSpawn = (int) (47184);
                f_getItemIdToSpawn = true;
                return _getItemIdToSpawn;
            }
        }
        private bool f_activateFlashFire;
        private int _activateFlashFire;

        /// <summary>
        /// Actually applies the Flash Fire boost with a message log and animation. Passes the same monster for attacker and
        /// defender, but the attacker goes unused.
        /// 
        /// r0: attacker pointer?
        /// r1: defender pointer
        /// </summary>
        public int ActivateFlashFire
        {
            get
            {
                if (f_activateFlashFire)
                    return _activateFlashFire;
                _activateFlashFire = (int) (227560);
                f_activateFlashFire = true;
                return _activateFlashFire;
            }
        }
        private bool f_trySpawnEnemyItemDrop;
        private int _trySpawnEnemyItemDrop;

        /// <summary>
        /// Determine what item a defeated enemy should drop, if any, then (probably?) spawn that item underneath them.
        /// 
        /// This function is called at the time when an enemy is defeated from ApplyDamage.
        /// 
        /// r0: attacker entity (who defeated the enemy)
        /// r1: defender entity (who was defeated)
        /// </summary>
        public int TrySpawnEnemyItemDrop
        {
            get
            {
                if (f_trySpawnEnemyItemDrop)
                    return _trySpawnEnemyItemDrop;
                _trySpawnEnemyItemDrop = (int) (210484);
                f_trySpawnEnemyItemDrop = true;
                return _trySpawnEnemyItemDrop;
            }
        }
        private bool f_updateStateFlags;
        private int _updateStateFlags;

        /// <summary>
        /// Updates monster::state_flags and monster::prev_state_flags with new values.
        /// 
        /// r0: monster pointer
        /// r1: bitmask for bits to update
        /// r2: whether to set the bits indicated by the mask to 1 or 0
        /// return: whether or not any of the masked bits changed from the previous state
        /// </summary>
        public int UpdateStateFlags
        {
            get
            {
                if (f_updateStateFlags)
                    return _updateStateFlags;
                _updateStateFlags = (int) (155696);
                f_updateStateFlags = true;
                return _updateStateFlags;
            }
        }
        private bool f_setMonsterTypeAndAbility;
        private int _setMonsterTypeAndAbility;

        /// <summary>
        /// Checks Forecast ability
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: target entity pointer
        /// </summary>
        public int SetMonsterTypeAndAbility
        {
            get
            {
                if (f_setMonsterTypeAndAbility)
                    return _setMonsterTypeAndAbility;
                _setMonsterTypeAndAbility = (int) (118392);
                f_setMonsterTypeAndAbility = true;
                return _setMonsterTypeAndAbility;
            }
        }
        private bool f_getDirectionTowardsPosition;
        private int _getDirectionTowardsPosition;

        /// <summary>
        /// Gets the direction in which a monster should move to go from the origin position to the target position
        /// 
        /// r0: Origin position
        /// r1: Target position
        /// return: Direction in which to move to reach the target position from the origin position
        /// </summary>
        public int GetDirectionTowardsPosition
        {
            get
            {
                if (f_getDirectionTowardsPosition)
                    return _getDirectionTowardsPosition;
                _getDirectionTowardsPosition = (int) (52648);
                f_getDirectionTowardsPosition = true;
                return _getDirectionTowardsPosition;
            }
        }
        private bool f_setMinimapDataE447;
        private int _setMinimapDataE447;

        /// <summary>
        /// Sets minimap_display_data::field_0xE447 to the specified value
        /// 
        /// r0: Value to set the field to
        /// </summary>
        public int SetMinimapDataE447
        {
            get
            {
                if (f_setMinimapDataE447)
                    return _setMinimapDataE447;
                _setMinimapDataE447 = (int) (384252);
                f_setMinimapDataE447 = true;
                return _setMinimapDataE447;
            }
        }
        private bool f_applyGonePebbleEffect;
        private int _applyGonePebbleEffect;

        /// <summary>
        /// Causes a few visual effects, temporarily changes the dungeon music to the Goodnight
        /// track, and gives the target the enduring status.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyGonePebbleEffect
        {
            get
            {
                if (f_applyGonePebbleEffect)
                    return _applyGonePebbleEffect;
                _applyGonePebbleEffect = (int) (267296);
                f_applyGonePebbleEffect = true;
                return _applyGonePebbleEffect;
            }
        }
        private bool f_hasSuperEffectiveMoveAgainstUser;
        private int _hasSuperEffectiveMoveAgainstUser;

        /// <summary>
        /// Checks if the target has at least one super effective move against the user.
        /// 
        /// r0: User
        /// r1: Target
        /// r2: If true, moves with a max Ginseng boost != 99 will be ignored
        /// return: True if the target has at least one super effective move against the user, false otherwise.
        /// </summary>
        public int HasSuperEffectiveMoveAgainstUser
        {
            get
            {
                if (f_hasSuperEffectiveMoveAgainstUser)
                    return _hasSuperEffectiveMoveAgainstUser;
                _hasSuperEffectiveMoveAgainstUser = (int) (126388);
                f_hasSuperEffectiveMoveAgainstUser = true;
                return _hasSuperEffectiveMoveAgainstUser;
            }
        }
        private bool f_getTileAtEntity;
        private int _getTileAtEntity;

        /// <summary>
        /// Returns a pointer to the tile where an entity is located.
        /// 
        /// r0: pointer to entity
        /// return: pointer to tile
        /// </summary>
        public int GetTileAtEntity
        {
            get
            {
                if (f_getTileAtEntity)
                    return _getTileAtEntity;
                _getTileAtEntity = (int) (21464);
                f_getTileAtEntity = true;
                return _getTileAtEntity;
            }
        }
        private bool f_markEnemySpawns;
        private int _markEnemySpawns;

        /// <summary>
        /// Mark tiles for all enemies, which includes normal enemies and those in Monster Houses. Note that this only marks tiles; actual spawning is handled later in SpawnInitialMonsters.
        /// 
        /// Normal enemies can spawn on any tile that has open terrain, isn't in a Kecleon shop, doesn't already have another entity spawn, and isn't a special tile like a Key door.
        /// 
        /// Monster House enemies can spawn on any Monster House tile that isn't in a Kecleon shop, isn't where the player spawns, and isn't a special tile like a Key door.
        /// 
        /// r0: floor properties
        /// r1: empty Monster House flag. An empty Monster House is one with no items or traps, and only a small number of enemies.
        /// </summary>
        public int MarkEnemySpawns
        {
            get
            {
                if (f_markEnemySpawns)
                    return _markEnemySpawns;
                _markEnemySpawns = (int) (413520);
                f_markEnemySpawns = true;
                return _markEnemySpawns;
            }
        }
        private bool f_addExpSpecial;
        private int _addExpSpecial;

        /// <summary>
        /// Adds to a monster's experience points, subject to experience boosting effects.
        /// 
        /// This function appears to be called only under special circumstances. Possibly when granting experience from damage (e.g., Joy Ribbon)?
        /// 
        /// Interestingly, the parameter in r0 isn't actually used. This might be a compiler optimization to avoid shuffling registers, since this function might be called alongside lots of other functions that have both the attacker and defender as the first two arguments.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: base experience gain, before boosts
        /// </summary>
        public int AddExpSpecial
        {
            get
            {
                if (f_addExpSpecial)
                    return _addExpSpecial;
                _addExpSpecial = (int) (156076);
                f_addExpSpecial = true;
                return _addExpSpecial;
            }
        }
        private bool f_tryInflictEncoreStatus;
        private int _tryInflictEncoreStatus;

        /// <summary>
        /// Inflicts the Encore status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictEncoreStatus
        {
            get
            {
                if (f_tryInflictEncoreStatus)
                    return _tryInflictEncoreStatus;
                _tryInflictEncoreStatus = (int) (238356);
                f_tryInflictEncoreStatus = true;
                return _tryInflictEncoreStatus;
            }
        }
        private bool f_applyAquaRingHealing;
        private int _applyAquaRingHealing;

        /// <summary>
        /// Applies the passive healing gained from the Aqua Ring status.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int ApplyAquaRingHealing
        {
            get
            {
                if (f_applyAquaRingHealing)
                    return _applyAquaRingHealing;
                _applyAquaRingHealing = (int) (245720);
                f_applyAquaRingHealing = true;
                return _applyAquaRingHealing;
            }
        }
        private bool f_setActionStruggle;
        private int _setActionStruggle;

        /// <summary>
        /// Sets a monster's action to action::ACTION_STRUGGLE, with a specified direction.
        /// 
        /// r0: Pointer to the monster's action field
        /// r1: Direction in which to use the move. Gets stored in monster::action::direction.
        /// </summary>
        public int SetActionStruggle
        {
            get
            {
                if (f_setActionStruggle)
                    return _setActionStruggle;
                _setActionStruggle = (int) (63996);
                f_setActionStruggle = true;
                return _setActionStruggle;
            }
        }
        private bool f_lowerHitChanceStat;
        private int _lowerHitChanceStat;

        /// <summary>
        /// Lowers the specified hit chance stat (accuracy or evasion) on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: flag to log a message on failure
        /// </summary>
        public int LowerHitChanceStat
        {
            get
            {
                if (f_lowerHitChanceStat)
                    return _lowerHitChanceStat;
                _lowerHitChanceStat = (int) (228908);
                f_lowerHitChanceStat = true;
                return _lowerHitChanceStat;
            }
        }
        private bool f_exclusiveItemEffectIsActiveWithLogging;
        private int _exclusiveItemEffectIsActiveWithLogging;

        /// <summary>
        /// Calls ExclusiveItemEffectIsActive, then logs the specified message if indicated.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: whether a message should be logged if the effect is active
        /// r3: message ID to be logged if the effect is active
        /// stack[0]: exclusive item effect ID
        /// return: bool, same as ExclusiveItemEffectIsActive
        /// </summary>
        public int ExclusiveItemEffectIsActiveWithLogging
        {
            get
            {
                if (f_exclusiveItemEffectIsActiveWithLogging)
                    return _exclusiveItemEffectIsActiveWithLogging;
                _exclusiveItemEffectIsActiveWithLogging = (int) (231732);
                f_exclusiveItemEffectIsActiveWithLogging = true;
                return _exclusiveItemEffectIsActiveWithLogging;
            }
        }
        private bool f_applyOffensiveStatMultiplier;
        private int _applyOffensiveStatMultiplier;

        /// <summary>
        /// Applies a multiplier to the specified offensive stat on the target monster.
        /// 
        /// This affects struct monster_stat_modifiers::offensive_multipliers, for moves like Charm and Memento.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: multiplier
        /// stack[0]: ?
        /// </summary>
        public int ApplyOffensiveStatMultiplier
        {
            get
            {
                if (f_applyOffensiveStatMultiplier)
                    return _applyOffensiveStatMultiplier;
                _applyOffensiveStatMultiplier = (int) (227652);
                f_applyOffensiveStatMultiplier = true;
                return _applyOffensiveStatMultiplier;
            }
        }
        private bool f_isCurrentMissionTypeExact;
        private int _isCurrentMissionTypeExact;

        /// <summary>
        /// Checks if the current floor is an active mission destination of a given type and subtype.
        /// 
        /// r0: mission type
        /// r1: mission subtype
        /// return: bool
        /// </summary>
        public int IsCurrentMissionTypeExact
        {
            get
            {
                if (f_isCurrentMissionTypeExact)
                    return _isCurrentMissionTypeExact;
                _isCurrentMissionTypeExact = (int) (445592);
                f_isCurrentMissionTypeExact = true;
                return _isCurrentMissionTypeExact;
            }
        }
        private bool f_isGoldenChamber;
        private int _isGoldenChamber;

        /// <summary>
        /// Checks if the current floor is a Golden Chamber floor.
        /// 
        /// return: bool
        /// </summary>
        public int IsGoldenChamber
        {
            get
            {
                if (f_isGoldenChamber)
                    return _isGoldenChamber;
                _isGoldenChamber = (int) (445688);
                f_isGoldenChamber = true;
                return _isGoldenChamber;
            }
        }
        private bool f_tickNoSlipCap;
        private int _tickNoSlipCap;

        /// <summary>
        /// Checks if the entity is a team member and holds the No-Slip Cap, and if so attempts to make one item in the bag sticky.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int TickNoSlipCap
        {
            get
            {
                if (f_tickNoSlipCap)
                    return _tickNoSlipCap;
                _tickNoSlipCap = (int) (210924);
                f_tickNoSlipCap = true;
                return _tickNoSlipCap;
            }
        }
        private bool f_tryInflictExposedStatus;
        private int _tryInflictExposedStatus;

        /// <summary>
        /// Inflicts the Exposed status condition on a target monster if possible. Only applies to
        /// Ghost types and monsters with raised evasion. If the animation effect ID is 0,
        /// defaults to animation ID 0xE (this fallback animation likely can't be seen in normal
        /// play).
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: animation effect ID
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictExposedStatus
        {
            get
            {
                if (f_tryInflictExposedStatus)
                    return _tryInflictExposedStatus;
                _tryInflictExposedStatus = (int) (241848);
                f_tryInflictExposedStatus = true;
                return _tryInflictExposedStatus;
            }
        }
        private bool f_resetImportantSpawnPositions;
        private int _resetImportantSpawnPositions;

        /// <summary>
        /// Resets important spawn positions (the player, stairs, and hidden stairs) back to their default values.
        /// 
        /// r0: dungeon generation info pointer (a field on the dungeon struct)
        /// </summary>
        public int ResetImportantSpawnPositions
        {
            get
            {
                if (f_resetImportantSpawnPositions)
                    return _resetImportantSpawnPositions;
                _resetImportantSpawnPositions = (int) (419656);
                f_resetImportantSpawnPositions = true;
                return _resetImportantSpawnPositions;
            }
        }
        private bool f_handleFadesDungeonBothScreens;
        private int _handleFadesDungeonBothScreens;

        /// <summary>
        /// Calls HandleFadesDungeon for both screens.
        /// 
        /// No params.
        /// </summary>
        public int HandleFadesDungeonBothScreens
        {
            get
            {
                if (f_handleFadesDungeonBothScreens)
                    return _handleFadesDungeonBothScreens;
                _handleFadesDungeonBothScreens = (int) (459624);
                f_handleFadesDungeonBothScreens = true;
                return _handleFadesDungeonBothScreens;
            }
        }
        private bool f_getDungeonPtrMaster;
        private int _getDungeonPtrMaster;

        /// <summary>
        /// Returns the master dungeon pointer (a global, see DUNGEON_PTR_MASTER).
        /// 
        /// return: pointer to a newly allocated dungeon struct
        /// </summary>
        public int GetDungeonPtrMaster
        {
            get
            {
                if (f_getDungeonPtrMaster)
                    return _getDungeonPtrMaster;
                _getDungeonPtrMaster = (int) (10304);
                f_getDungeonPtrMaster = true;
                return _getDungeonPtrMaster;
            }
        }
        private bool f_initTeamMember;
        private int _initTeamMember;

        /// <summary>
        /// Initializes a team member. Run at the start of each floor in a dungeon.
        /// 
        /// r0: Monster ID
        /// r1: X position
        /// r2: Y position
        /// r3: Pointer to the struct containing the data of the team member to initialize
        /// stack[0]: ?
        /// stack[1]: ?
        /// stack[2]: ?
        /// stack[3]: ?
        /// stack[4]: ?
        /// </summary>
        public int InitTeamMember
        {
            get
            {
                if (f_initTeamMember)
                    return _initTeamMember;
                _initTeamMember = (int) (134856);
                f_initTeamMember = true;
                return _initTeamMember;
            }
        }
        private bool f_lowerSshort;
        private int _lowerSshort;

        /// <summary>
        /// Gets the lower 2 bytes of a 4-byte number and interprets it as a signed short.
        /// 
        /// r0: 4-byte number x
        /// return: (short) x
        /// </summary>
        public int LowerSshort
        {
            get
            {
                if (f_lowerSshort)
                    return _lowerSshort;
                _lowerSshort = (int) (297488);
                f_lowerSshort = true;
                return _lowerSshort;
            }
        }
        private bool f_areMovesEnabled;
        private int _areMovesEnabled;

        /// <summary>
        /// Checks if moves (excluding the regular attack) are usable in the given fixed room.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int AreMovesEnabled
        {
            get
            {
                if (f_areMovesEnabled)
                    return _areMovesEnabled;
                _areMovesEnabled = (int) (425028);
                f_areMovesEnabled = true;
                return _areMovesEnabled;
            }
        }
        private bool f_tryInflictDestinyBondStatus;
        private int _tryInflictDestinyBondStatus;

        /// <summary>
        /// Inflicts the Destiny Bond status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictDestinyBondStatus
        {
            get
            {
                if (f_tryInflictDestinyBondStatus)
                    return _tryInflictDestinyBondStatus;
                _tryInflictDestinyBondStatus = (int) (235080);
                f_tryInflictDestinyBondStatus = true;
                return _tryInflictDestinyBondStatus;
            }
        }
        private bool f_fixedRoomIsSubstituteRoom;
        private int _fixedRoomIsSubstituteRoom;

        /// <summary>
        /// Checks if the current fixed room is the &quot;substitute room&quot; (ID 0x6E).
        /// 
        /// return: bool
        /// </summary>
        public int FixedRoomIsSubstituteRoom
        {
            get
            {
                if (f_fixedRoomIsSubstituteRoom)
                    return _fixedRoomIsSubstituteRoom;
                _fixedRoomIsSubstituteRoom = (int) (18044);
                f_fixedRoomIsSubstituteRoom = true;
                return _fixedRoomIsSubstituteRoom;
            }
        }
        private bool f_isInSpawnList;
        private int _isInSpawnList;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: spawn_list_ptr
        /// r1: monster ID
        /// return: bool
        /// </summary>
        public int IsInSpawnList
        {
            get
            {
                if (f_isInSpawnList)
                    return _isInSpawnList;
                _isInSpawnList = (int) (258024);
                f_isInSpawnList = true;
                return _isInSpawnList;
            }
        }
        private bool f_monsterHasAttackInterferingStatus;
        private int _monsterHasAttackInterferingStatus;

        /// <summary>
        /// Checks if a monster has one of the statuses in the &quot;cringe&quot; group, which includes status conditions that interfere with the monster's ability to attack: STATUS_CRINGE, STATUS_CONFUSED, STATUS_PAUSED, STATUS_COWERING, STATUS_TAUNTED, STATUS_ENCORE, STATUS_INFATUATED, and STATUS_DOUBLE_SPEED.
        /// 
        /// STATUS_DOUBLE_SPEED is probably included based on enum status_id? Unless it's handled differently somehow.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasAttackInterferingStatus
        {
            get
            {
                if (f_monsterHasAttackInterferingStatus)
                    return _monsterHasAttackInterferingStatus;
                _monsterHasAttackInterferingStatus = (int) (147492);
                f_monsterHasAttackInterferingStatus = true;
                return _monsterHasAttackInterferingStatus;
            }
        }
        private bool f_getVisibilityRange;
        private int _getVisibilityRange;

        /// <summary>
        /// Returns dungeon::display_data::visibility_range. If the visibility range is 0, returns 2 instead.
        /// 
        /// return: Visibility range of the current floor, or 2 if the visibility is 0.
        /// </summary>
        public int GetVisibilityRange
        {
            get
            {
                if (f_getVisibilityRange)
                    return _getVisibilityRange;
                _getVisibilityRange = (int) (28876);
                f_getVisibilityRange = true;
                return _getVisibilityRange;
            }
        }
        private bool f_applyViaSeedEffect;
        private int _applyViaSeedEffect;

        /// <summary>
        /// Tries to randomly teleport the target with a message for eating the seed.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyViaSeedEffect
        {
            get
            {
                if (f_applyViaSeedEffect)
                    return _applyViaSeedEffect;
                _applyViaSeedEffect = (int) (267060);
                f_applyViaSeedEffect = true;
                return _applyViaSeedEffect;
            }
        }
        private bool f_checkVariousStatuses2;
        private int _checkVariousStatuses2;

        /// <summary>
        /// Returns 0 if none of these conditions holds for the given entity:
        /// blinded (checked only if blind_check == 1),
        /// asleep, frozen, paused, infatuated, wrapping, wrapped, biding, petrified, or terrified.
        /// 
        /// r0: Entity pointer
        /// r1: If true, return 1 if entity is blinded
        /// return: bool
        /// </summary>
        public int CheckVariousStatuses2
        {
            get
            {
                if (f_checkVariousStatuses2)
                    return _checkVariousStatuses2;
                _checkVariousStatuses2 = (int) (148252);
                f_checkVariousStatuses2 = true;
                return _checkVariousStatuses2;
            }
        }
        private bool f_getMobilityTypeCheckSlip;
        private int _getMobilityTypeCheckSlip;

        /// <summary>
        /// Returns the mobility type of a monster species, accounting for STATUS_SLIP.
        /// 
        /// The function also converts MOBILITY_LAVA and MOBILITY_WATER to other values if required.
        /// 
        /// r0: Monster species
        /// r1: True if the monster can walk on water
        /// return: Mobility type
        /// </summary>
        public int GetMobilityTypeCheckSlip
        {
            get
            {
                if (f_getMobilityTypeCheckSlip)
                    return _getMobilityTypeCheckSlip;
                _getMobilityTypeCheckSlip = (int) (143676);
                f_getMobilityTypeCheckSlip = true;
                return _getMobilityTypeCheckSlip;
            }
        }
        private bool f_applyPpZeroTrapEffect;
        private int _applyPpZeroTrapEffect;

        /// <summary>
        /// Tries to reduce the PP of one of the defender's moves to 0.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int ApplyPpZeroTrapEffect
        {
            get
            {
                if (f_applyPpZeroTrapEffect)
                    return _applyPpZeroTrapEffect;
                _applyPpZeroTrapEffect = (int) (75684);
                f_applyPpZeroTrapEffect = true;
                return _applyPpZeroTrapEffect;
            }
        }
        private bool f_changeDungeonMusic;
        private int _changeDungeonMusic;

        /// <summary>
        /// Replace the currently playing music with the provided music
        /// 
        /// r0: music ID
        /// </summary>
        public int ChangeDungeonMusic
        {
            get
            {
                if (f_changeDungeonMusic)
                    return _changeDungeonMusic;
                _changeDungeonMusic = (int) (60316);
                f_changeDungeonMusic = true;
                return _changeDungeonMusic;
            }
        }
        private bool f_updateIqSkills;
        private int _updateIqSkills;

        /// <summary>
        /// Updates the IQ skill flags of a monster.
        /// 
        /// If the monster is a team member, copies monster::iq_skill_menu_flags to monster::iq_skill_flags. If the monster is an enemy, enables all the IQ skills it can learn (except a few that are only enabled in enemies that have a certain amount of IQ).
        /// If the monster is an enemy, it also sets its tactic to TACTIC_GO_AFTER_FOES.
        /// Called after exiting the IQ skills menu or after an enemy spawns.
        /// 
        /// r0: monster pointer
        /// </summary>
        public int UpdateIqSkills
        {
            get
            {
                if (f_updateIqSkills)
                    return _updateIqSkills;
                _updateIqSkills = (int) (154668);
                f_updateIqSkills = true;
                return _updateIqSkills;
            }
        }
        private bool f_hiddenStairsTrigger;
        private int _hiddenStairsTrigger;

        /// <summary>
        /// Called whenever the leader steps on the hidden stairs.
        /// 
        /// If the stairs hadn't been revealed yet, plays the corresponding animation.
        /// 
        /// r0: True to display a message if the stairs are revealed, false to omit it.
        /// </summary>
        public int HiddenStairsTrigger
        {
            get
            {
                if (f_hiddenStairsTrigger)
                    return _hiddenStairsTrigger;
                _hiddenStairsTrigger = (int) (377464);
                f_hiddenStairsTrigger = true;
                return _hiddenStairsTrigger;
            }
        }
        private bool f_isInvalidSpawnTile;
        private int _isInvalidSpawnTile;

        /// <summary>
        /// Checks if a monster cannot spawn on the given tile for some reason.
        /// 
        /// Reasons include:
        /// - There's another monster on the tile
        /// - The tile is an impassable wall
        /// - The monster does not have the required mobility to stand on the tile
        /// 
        /// r0: monster ID
        /// r1: tile pointer
        /// return: true means the monster CANNOT spawn on this tile
        /// </summary>
        public int IsInvalidSpawnTile
        {
            get
            {
                if (f_isInvalidSpawnTile)
                    return _isInvalidSpawnTile;
                _isInvalidSpawnTile = (int) (143828);
                f_isInvalidSpawnTile = true;
                return _isInvalidSpawnTile;
            }
        }
        private bool f_applyGracideaEffect;
        private int _applyGracideaEffect;

        /// <summary>
        /// If the target is Shaymin, attempt to change the target's form to Shaymin Sky Forme. Otherwise, do nothing.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyGracideaEffect
        {
            get
            {
                if (f_applyGracideaEffect)
                    return _applyGracideaEffect;
                _applyGracideaEffect = (int) (267676);
                f_applyGracideaEffect = true;
                return _applyGracideaEffect;
            }
        }
        private bool f_tryActivateSlowStart;
        private int _tryActivateSlowStart;

        /// <summary>
        /// Runs a check over all monsters on the field for the ability Slow Start, and lowers the speed of those who have it.
        /// 
        /// No params
        /// </summary>
        public int TryActivateSlowStart
        {
            get
            {
                if (f_tryActivateSlowStart)
                    return _tryActivateSlowStart;
                _tryActivateSlowStart = (int) (118560);
                f_tryActivateSlowStart = true;
                return _tryActivateSlowStart;
            }
        }
        private bool f_tickStatusTurnCounter;
        private int _tickStatusTurnCounter;

        /// <summary>
        /// Ticks down a turn counter for a status condition. If the counter equals 0x7F, it will not be decreased.
        /// 
        /// r0: pointer to the status turn counter
        /// return: new counter value
        /// </summary>
        public int TickStatusTurnCounter
        {
            get
            {
                if (f_tickStatusTurnCounter)
                    return _tickStatusTurnCounter;
                _tickStatusTurnCounter = (int) (55244);
                f_tickStatusTurnCounter = true;
                return _tickStatusTurnCounter;
            }
        }
        private bool f_applyDamage;
        private int _applyDamage;

        /// <summary>
        /// Applies damage to a monster. Displays the damage animation, lowers its health and handles reviving if applicable.
        /// The EU version has some additional checks related to printing fainting messages under specific circumstances.
        /// 
        /// r0: Attacker pointer
        /// r1: Defender pointer
        /// r2: Pointer to the damage_data struct that contains info about the damage to deal
        /// r3: False Swipe flag, causes the defender's HP to be set to 1 if it would otherwise have been 0
        /// stack[0]: experience flag, controls whether or not experience will be granted upon a monster fainting, and whether enemy evolution might be triggered
        /// stack[1]: Damage source (see HandleFaint)
        /// return: True if the target fainted (reviving does not count as fainting)
        /// </summary>
        public int ApplyDamage
        {
            get
            {
                if (f_applyDamage)
                    return _applyDamage;
                _applyDamage = (int) (183480);
                f_applyDamage = true;
                return _applyDamage;
            }
        }
        private bool f_determineAllTilesWalkableNeighbors;
        private int _determineAllTilesWalkableNeighbors;

        /// <summary>
        /// Evaluates the walkable_neighbor_flags for all tiles.
        /// 
        /// No params.
        /// </summary>
        public int DetermineAllTilesWalkableNeighbors
        {
            get
            {
                if (f_determineAllTilesWalkableNeighbors)
                    return _determineAllTilesWalkableNeighbors;
                _determineAllTilesWalkableNeighbors = (int) (369972);
                f_determineAllTilesWalkableNeighbors = true;
                return _determineAllTilesWalkableNeighbors;
            }
        }
        private bool f_otherMonsterAbilityIsActive;
        private int _otherMonsterAbilityIsActive;

        /// <summary>
        /// Checks if there are any other monsters on the floor besides the user that have the specified ability active, subject to the user being on the floor.
        /// 
        /// It also seems like there might be some other range or validity check, so this might not actually check ALL other monsters?
        /// 
        /// r0: user entity pointer
        /// r1: ability ID
        /// return: bool
        /// </summary>
        public int OtherMonsterAbilityIsActive
        {
            get
            {
                if (f_otherMonsterAbilityIsActive)
                    return _otherMonsterAbilityIsActive;
                _otherMonsterAbilityIsActive = (int) (154108);
                f_otherMonsterAbilityIsActive = true;
                return _otherMonsterAbilityIsActive;
            }
        }
        private bool f_getMobilityTypeCheckSlipAndFloating;
        private int _getMobilityTypeCheckSlipAndFloating;

        /// <summary>
        /// Returns the mobility type of a monster, accounting for STATUS_SLIP and the result of a call to IsFloating.
        /// 
        /// r0: Entity pointer
        /// r1: Monster species
        /// return: Mobility type
        /// </summary>
        public int GetMobilityTypeCheckSlipAndFloating
        {
            get
            {
                if (f_getMobilityTypeCheckSlipAndFloating)
                    return _getMobilityTypeCheckSlipAndFloating;
                _getMobilityTypeCheckSlipAndFloating = (int) (143748);
                f_getMobilityTypeCheckSlipAndFloating = true;
                return _getMobilityTypeCheckSlipAndFloating;
            }
        }
        private bool f_dungeonAlloc;
        private int _dungeonAlloc;

        /// <summary>
        /// Allocates a new dungeon struct.
        /// 
        /// This updates the master dungeon pointer and returns a copy of that pointer.
        /// 
        /// return: pointer to a newly allocated dungeon struct
        /// </summary>
        public int DungeonAlloc
        {
            get
            {
                if (f_dungeonAlloc)
                    return _dungeonAlloc;
                _dungeonAlloc = (int) (10268);
                f_dungeonAlloc = true;
                return _dungeonAlloc;
            }
        }
        private bool f_findFarthestUnoccupiedTileWithin2;
        private int _findFarthestUnoccupiedTileWithin2;

        /// <summary>
        /// Searches for the farthest unoccupied tile within 2 steps of the given origin.
        /// 
        /// Calls FindNearbyUnoccupiedTile with DISPLACEMENTS_WITHIN_2_LARGEST_FIRST.
        /// 
        /// r0: [output] position
        /// r1: origin position
        /// r2: random room mode flag
        /// return: whether a tile was successfully found
        /// </summary>
        public int FindFarthestUnoccupiedTileWithin2
        {
            get
            {
                if (f_findFarthestUnoccupiedTileWithin2)
                    return _findFarthestUnoccupiedTileWithin2;
                _findFarthestUnoccupiedTileWithin2 = (int) (55188);
                f_findFarthestUnoccupiedTileWithin2 = true;
                return _findFarthestUnoccupiedTileWithin2;
            }
        }
        private bool f_tryInflictYawningStatus;
        private int _tryInflictYawningStatus;

        /// <summary>
        /// Inflicts the Yawning status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of turns
        /// </summary>
        public int TryInflictYawningStatus
        {
            get
            {
                if (f_tryInflictYawningStatus)
                    return _tryInflictYawningStatus;
                _tryInflictYawningStatus = (int) (219796);
                f_tryInflictYawningStatus = true;
                return _tryInflictYawningStatus;
            }
        }
        private bool f_updateEntityPixelPos;
        private int _updateEntityPixelPos;

        /// <summary>
        /// Updates an entity's pixel_pos field using the specified pixel_position struct, or its own pos field if it's null.
        /// 
        /// r0: Entity pointer
        /// r1: Pixel position to use, or null to use the entity's own position
        /// </summary>
        public int UpdateEntityPixelPos
        {
            get
            {
                if (f_updateEntityPixelPos)
                    return _updateEntityPixelPos;
                _updateEntityPixelPos = (int) (22512);
                f_updateEntityPixelPos = true;
                return _updateEntityPixelPos;
            }
        }
        private bool f_markNonEnemySpawns;
        private int _markNonEnemySpawns;

        /// <summary>
        /// Mark tiles for all non-enemy entities, which includes stairs, items, traps, and the player. Note that this only marks tiles; actual spawning is handled later.
        /// 
        /// Most entities are spawned randomly on a subset of permissible tiles.
        /// 
        /// Stairs are spawned if they don't already exist on the floor, and hidden stairs of the specified type are also spawned if configured as long as there are at least 2 floors left in the dungeon. Stairs can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop, doesn't already have an enemy spawn, isn't a hallway junction, and isn't a special tile like a Key door.
        /// 
        /// Items are spawned both normally in rooms, as well as in walls and Monster Houses. Normal items can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop or Monster House, isn't a hallway junction, and isn't a special tile like a Key door. Buried items can spawn on any wall tile. Monster House items can spawn on any Monster House tile that isn't in a Kecleon shop and isn't a hallway junction.
        /// 
        /// Traps are similarly spawned both normally in rooms, as well as in Monster Houses. Normal traps can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop, doesn't already have an item or enemy spawn, and isn't a special tile like a Key door. Monster House traps follow the same conditions as Monster House items.
        /// 
        /// The player can spawn on any tile that has open terrain, is in a room, isn't in a Kecleon shop, isn't a hallway junction, doesn't already have an item, enemy, or trap spawn, and isn't a special tile like a Key door.
        /// 
        /// r0: floor properties
        /// r1: empty Monster House flag. An empty Monster House is one with no items or traps, and only a small number of enemies.
        /// </summary>
        public int MarkNonEnemySpawns
        {
            get
            {
                if (f_markNonEnemySpawns)
                    return _markNonEnemySpawns;
                _markNonEnemySpawns = (int) (411692);
                f_markNonEnemySpawns = true;
                return _markNonEnemySpawns;
            }
        }
        private bool f_updateShopkeeperModeAfterAttack;
        private int _updateShopkeeperModeAfterAttack;

        /// <summary>
        /// Updates the shopkeeper mode of a monster in response to being struck by an attack.
        /// 
        /// If the defender is in normal shopkeeper mode (not aggressive), nothing happens. Otherwise, the mode is set to SHOPKEEPER_MODE_ATTACK_TEAM if the attacker is a team member, or SHOPKEEPER_MODE_ATTACK_ENEMIES otherwise.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// </summary>
        public int UpdateShopkeeperModeAfterAttack
        {
            get
            {
                if (f_updateShopkeeperModeAfterAttack)
                    return _updateShopkeeperModeAfterAttack;
                _updateShopkeeperModeAfterAttack = (int) (200860);
                f_updateShopkeeperModeAfterAttack = true;
                return _updateShopkeeperModeAfterAttack;
            }
        }
        private bool f_playQuestionMarkEffect;
        private int _playQuestionMarkEffect;

        /// <summary>
        /// Plays the question mark effect (id = 0x144) on an entity.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int PlayQuestionMarkEffect
        {
            get
            {
                if (f_playQuestionMarkEffect)
                    return _playQuestionMarkEffect;
                _playQuestionMarkEffect = (int) (31592);
                f_playQuestionMarkEffect = true;
                return _playQuestionMarkEffect;
            }
        }
        private bool f_markShopkeeperSpawn;
        private int _markShopkeeperSpawn;

        /// <summary>
        /// Add a shopkeeper spawn to the list on the dungeon struct. Actual spawning is done later by SpawnShopkeepers.
        /// 
        /// If an existing entry in dungeon::shopkeeper_spawns exists with the same position, that entry is reused for the new spawn data. Otherwise, a new entry is appended to the array.
        /// 
        /// r0: x position
        /// r1: y position
        /// r2: monster ID
        /// r3: monster behavior
        /// </summary>
        public int MarkShopkeeperSpawn
        {
            get
            {
                if (f_markShopkeeperSpawn)
                    return _markShopkeeperSpawn;
                _markShopkeeperSpawn = (int) (138400);
                f_markShopkeeperSpawn = true;
                return _markShopkeeperSpawn;
            }
        }
        private bool f_tryInflictMuzzledStatus;
        private int _tryInflictMuzzledStatus;

        /// <summary>
        /// Inflicts the Muzzled status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictMuzzledStatus
        {
            get
            {
                if (f_tryInflictMuzzledStatus)
                    return _tryInflictMuzzledStatus;
                _tryInflictMuzzledStatus = (int) (240916);
                f_tryInflictMuzzledStatus = true;
                return _tryInflictMuzzledStatus;
            }
        }
        private bool f_tryInflictInfatuatedStatus;
        private int _tryInflictInfatuatedStatus;

        /// <summary>
        /// Inflicts the Infatuated status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictInfatuatedStatus
        {
            get
            {
                if (f_tryInflictInfatuatedStatus)
                    return _tryInflictInfatuatedStatus;
                _tryInflictInfatuatedStatus = (int) (220624);
                f_tryInflictInfatuatedStatus = true;
                return _tryInflictInfatuatedStatus;
            }
        }
        private bool f_initializeTeamStats;
        private int _initializeTeamStats;

        /// <summary>
        /// Initializes the team stats top screen.
        /// 
        /// return: always 1, seems unused
        /// </summary>
        public int InitializeTeamStats
        {
            get
            {
                if (f_initializeTeamStats)
                    return _initializeTeamStats;
                _initializeTeamStats = (int) (48824);
                f_initializeTeamStats = true;
                return _initializeTeamStats;
            }
        }
        private bool f_tryInflictReflectStatus;
        private int _tryInflictReflectStatus;

        /// <summary>
        /// Inflicts the Reflect status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictReflectStatus
        {
            get
            {
                if (f_tryInflictReflectStatus)
                    return _tryInflictReflectStatus;
                _tryInflictReflectStatus = (int) (249212);
                f_tryInflictReflectStatus = true;
                return _tryInflictReflectStatus;
            }
        }
        private bool f_updateShopkeeperModeAfterTrap;
        private int _updateShopkeeperModeAfterTrap;

        /// <summary>
        /// Updates the shopkeeper mode of a monster in response to stepping on a trap.
        /// 
        /// If in the normal shopkeeper mode (not aggressive), nothing happens. Otherwise, the mode is set to SHOPKEEPER_MODE_ATTACK_TEAM if the trap is from a team member or SHOPKEEPER_MODE_ATTACK_ENEMIES otherwise.
        /// 
        /// r0: shopkeeper pointer
        /// r1: bool non team member trap
        /// </summary>
        public int UpdateShopkeeperModeAfterTrap
        {
            get
            {
                if (f_updateShopkeeperModeAfterTrap)
                    return _updateShopkeeperModeAfterTrap;
                _updateShopkeeperModeAfterTrap = (int) (200920);
                f_updateShopkeeperModeAfterTrap = true;
                return _updateShopkeeperModeAfterTrap;
            }
        }
        private bool f_calcRecoilDamageFixed;
        private int _calcRecoilDamageFixed;

        /// <summary>
        /// Appears to calculate recoil damage to a monster.
        /// 
        /// This function wraps CalcDamageFixed using the monster as both the attacker and the defender, after doing some basic checks (like if the monster is already at 0 HP) and applying a boost from the Reckless ability if applicable.
        /// 
        /// r0: entity pointer
        /// r1: fixed damage
        /// r2: ?
        /// r3: [output] struct containing info about the damage calculation
        /// stack[0]: move ID (interestingly, this doesn't seem to be used by the function)
        /// stack[1]: attack type
        /// stack[2]: damage source
        /// stack[3]: damage message
        /// others: ?
        /// </summary>
        public int CalcRecoilDamageFixed
        {
            get
            {
                if (f_calcRecoilDamageFixed)
                    return _calcRecoilDamageFixed;
                _calcRecoilDamageFixed = (int) (200172);
                f_calcRecoilDamageFixed = true;
                return _calcRecoilDamageFixed;
            }
        }
        private bool f_isBossFight;
        private int _isBossFight;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: fixed_room_id
        /// return: bool
        /// </summary>
        public int IsBossFight
        {
            get
            {
                if (f_isBossFight)
                    return _isBossFight;
                _isBossFight = (int) (17940);
                f_isBossFight = true;
                return _isBossFight;
            }
        }
        private bool f_endSureShotClassStatus;
        private int _endSureShotClassStatus;

        /// <summary>
        /// Removes the target's sure shot, whiffer, set damage or focus energy status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndSureShotClassStatus
        {
            get
            {
                if (f_endSureShotClassStatus)
                    return _endSureShotClassStatus;
                _endSureShotClassStatus = (int) (173472);
                f_endSureShotClassStatus = true;
                return _endSureShotClassStatus;
            }
        }
        private bool f_removeUsedItem;
        private int _removeUsedItem;

        /// <summary>
        /// Removes an item from the bag or from the floor after using it
        /// 
        /// r0: Pointer to the entity that used the item
        /// r1: Parameter index in monster::action_data::action_parameters. Will be used to use to determine the index of the used item.
        /// </summary>
        public int RemoveUsedItem
        {
            get
            {
                if (f_removeUsedItem)
                    return _removeUsedItem;
                _removeUsedItem = (int) (62356);
                f_removeUsedItem = true;
                return _removeUsedItem;
            }
        }
        private bool f_trySpawnTrapperTrap;
        private int _trySpawnTrapperTrap;

        /// <summary>
        /// If the flag for a trapper trap is set, handles spawning a trap based upon the
        /// information inside the dungeon struct. Uses the entity for logging a message
        /// depending on success or failure.
        /// 
        /// r0: entity pointer
        /// return: true if a trap was spawned succesfully
        /// </summary>
        public int TrySpawnTrapperTrap
        {
            get
            {
                if (f_trySpawnTrapperTrap)
                    return _trySpawnTrapperTrap;
                _trySpawnTrapperTrap = (int) (72536);
                f_trySpawnTrapperTrap = true;
                return _trySpawnTrapperTrap;
            }
        }
        private bool f_runFractionalTurn;
        private int _runFractionalTurn;

        /// <summary>
        /// The main function which executes the actions that take place in a fractional turn. Called in a loop by RunDungeon while IsFloorOver returns false.
        /// 
        /// r0: first loop flag (true when the function is first called during a floor)
        /// </summary>
        public int RunFractionalTurn
        {
            get
            {
                if (f_runFractionalTurn)
                    return _runFractionalTurn;
                _runFractionalTurn = (int) (64144);
                f_runFractionalTurn = true;
                return _runFractionalTurn;
            }
        }
        private bool f_abilityIsActive;
        private int _abilityIsActive;

        /// <summary>
        /// Checks if a monster has a certain ability that isn't disabled by Gastro Acid.
        /// 
        /// r0: entity pointer
        /// r1: ability ID
        /// return: bool
        /// </summary>
        public int AbilityIsActive
        {
            get
            {
                if (f_abilityIsActive)
                    return _abilityIsActive;
                _abilityIsActive = (int) (153992);
                f_abilityIsActive = true;
                return _abilityIsActive;
            }
        }
        private bool f_getEntityWeatherBallType;
        private int _getEntityWeatherBallType;

        /// <summary>
        /// Gets the current Weather Ball type for the given entity, based on the apparent weather.
        /// 
        /// r0: entity pointer
        /// return: type ID
        /// </summary>
        public int GetEntityWeatherBallType
        {
            get
            {
                if (f_getEntityWeatherBallType)
                    return _getEntityWeatherBallType;
                _getEntityWeatherBallType = (int) (256764);
                f_getEntityWeatherBallType = true;
                return _getEntityWeatherBallType;
            }
        }
        private bool f_applyGrimyTrapEffect;
        private int _applyGrimyTrapEffect;

        /// <summary>
        /// If the defender is the leader, randomly try to turn food items in the toolbox into
        /// grimy food. Otherwise, try to make the food item the monster is holding grimy food.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int ApplyGrimyTrapEffect
        {
            get
            {
                if (f_applyGrimyTrapEffect)
                    return _applyGrimyTrapEffect;
                _applyGrimyTrapEffect = (int) (74668);
                f_applyGrimyTrapEffect = true;
                return _applyGrimyTrapEffect;
            }
        }
        private bool f_shouldMonsterRunAway;
        private int _shouldMonsterRunAway;

        /// <summary>
        /// Checks if a monster should run away from other monsters
        /// 
        /// r0: Entity pointer
        /// return: True if the monster should run away, false otherwise
        /// </summary>
        public int ShouldMonsterRunAway
        {
            get
            {
                if (f_shouldMonsterRunAway)
                    return _shouldMonsterRunAway;
                _shouldMonsterRunAway = (int) (152136);
                f_shouldMonsterRunAway = true;
                return _shouldMonsterRunAway;
            }
        }
        private bool f_tryInflictPetrifiedStatus;
        private int _tryInflictPetrifiedStatus;

        /// <summary>
        /// Inflicts the Petrified status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictPetrifiedStatus
        {
            get
            {
                if (f_tryInflictPetrifiedStatus)
                    return _tryInflictPetrifiedStatus;
                _tryInflictPetrifiedStatus = (int) (225400);
                f_tryInflictPetrifiedStatus = true;
                return _tryInflictPetrifiedStatus;
            }
        }
        private bool f_getHiddenFloorField;
        private int _getHiddenFloorField;

        /// <summary>
        /// Gets the hidden_floor_type variable from dungeon::dungeon_generation_info.
        /// 
        /// return: enum hidden_stairs_type
        /// </summary>
        public int GetHiddenFloorField
        {
            get
            {
                if (f_getHiddenFloorField)
                    return _getHiddenFloorField;
                _getHiddenFloorField = (int) (377700);
                f_getHiddenFloorField = true;
                return _getHiddenFloorField;
            }
        }
        private bool f_lowerSpeed;
        private int _lowerSpeed;

        /// <summary>
        /// Lowers the speed of the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of stages
        /// r3: flag to log a message on failure
        /// </summary>
        public int LowerSpeed
        {
            get
            {
                if (f_lowerSpeed)
                    return _lowerSpeed;
                _lowerSpeed = (int) (230728);
                f_lowerSpeed = true;
                return _lowerSpeed;
            }
        }
        private bool f_generateAndSpawnItem;
        private int _generateAndSpawnItem;

        /// <summary>
        /// A convenience function that generates an item with GenerateItemExplicit, then spawns it with SpawnItem.
        /// 
        /// If the check-in-bag flag is set and the player's bag already contains an item with the given ID, a Reviver Seed will be spawned instead.
        /// 
        /// It seems like this function is only ever called in one place, with an item ID of 0x49 (Reviver Seed).
        /// 
        /// r0: item ID
        /// r1: x position
        /// r2: y position
        /// r3: quantity
        /// stack[0]: sticky flag
        /// stack[1]: check-in-bag flag
        /// </summary>
        public int GenerateAndSpawnItem
        {
            get
            {
                if (f_generateAndSpawnItem)
                    return _generateAndSpawnItem;
                _generateAndSpawnItem = (int) (425748);
                f_generateAndSpawnItem = true;
                return _generateAndSpawnItem;
            }
        }
        private bool f_tryInflictSleepStatus;
        private int _tryInflictSleepStatus;

        /// <summary>
        /// Inflicts the Sleep status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of turns
        /// r3: flag to log a message on failure
        /// </summary>
        public int TryInflictSleepStatus
        {
            get
            {
                if (f_tryInflictSleepStatus)
                    return _tryInflictSleepStatus;
                _tryInflictSleepStatus = (int) (218384);
                f_tryInflictSleepStatus = true;
                return _tryInflictSleepStatus;
            }
        }
        private bool f_isMonsterVisuallyImpaired;
        private int _isMonsterVisuallyImpaired;

        /// <summary>
        /// Checks if a monster's vision is impaired somehow. This includes the checks in IsBlinded, as well as STATUS_CROSS_EYED and STATUS_DROPEYE.
        /// 
        /// r0: entity pointer
        /// r1: flag for whether to check for the held item
        /// return: bool
        /// </summary>
        public int IsMonsterVisuallyImpaired
        {
            get
            {
                if (f_isMonsterVisuallyImpaired)
                    return _isMonsterVisuallyImpaired;
                _isMonsterVisuallyImpaired = (int) (147652);
                f_isMonsterVisuallyImpaired = true;
                return _isMonsterVisuallyImpaired;
            }
        }
        private bool f_getSpecialTargetItem;
        private int _getSpecialTargetItem;

        /// <summary>
        /// Get the ID of the special target item for a Sealed Chamber or Treasure Memo mission on the current floor.
        /// 
        /// return: item ID
        /// </summary>
        public int GetSpecialTargetItem
        {
            get
            {
                if (f_getSpecialTargetItem)
                    return _getSpecialTargetItem;
                _getSpecialTargetItem = (int) (446308);
                f_getSpecialTargetItem = true;
                return _getSpecialTargetItem;
            }
        }
        private bool f_getForcedLossReason;
        private int _getForcedLossReason;

        /// <summary>
        /// Returns dungeon::forced_loss_reason
        /// 
        /// return: forced_loss_reason
        /// </summary>
        public int GetForcedLossReason
        {
            get
            {
                if (f_getForcedLossReason)
                    return _getForcedLossReason;
                _getForcedLossReason = (int) (69024);
                f_getForcedLossReason = true;
                return _getForcedLossReason;
            }
        }
        private bool f_freeOtherWrappedMonsters;
        private int _freeOtherWrappedMonsters;

        /// <summary>
        /// Frees from the wrap status all monsters which are wrapped by/around the monster passed as parameter.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int FreeOtherWrappedMonsters
        {
            get
            {
                if (f_freeOtherWrappedMonsters)
                    return _freeOtherWrappedMonsters;
                _freeOtherWrappedMonsters = (int) (225276);
                f_freeOtherWrappedMonsters = true;
                return _freeOtherWrappedMonsters;
            }
        }
        private bool f_setTargetMonsterNotFoundFlag;
        private int _setTargetMonsterNotFoundFlag;

        /// <summary>
        /// Sets dungeon::target_monster_not_found_flag to the specified value.
        /// 
        /// r0: Value to set the flag to
        /// </summary>
        public int SetTargetMonsterNotFoundFlag
        {
            get
            {
                if (f_setTargetMonsterNotFoundFlag)
                    return _setTargetMonsterNotFoundFlag;
                _setTargetMonsterNotFoundFlag = (int) (446732);
                f_setTargetMonsterNotFoundFlag = true;
                return _setTargetMonsterNotFoundFlag;
            }
        }
        private bool f_freeTopScreen;
        private int _freeTopScreen;

        /// <summary>
        /// Gets called twice when fading out the top screen. First it calls the free_func of the top screen type and sets the handlers to null and on the second pass it just returns.
        /// 
        /// return: always 1, seems unused
        /// </summary>
        public int FreeTopScreen
        {
            get
            {
                if (f_freeTopScreen)
                    return _freeTopScreen;
                _freeTopScreen = (int) (51668);
                f_freeTopScreen = true;
                return _freeTopScreen;
            }
        }
        private bool f_getPossibleAiArcItemTargets;
        private int _getPossibleAiArcItemTargets;

        /// <summary>
        /// Gets the positions of all targets that an AI can hit with an item thrown in an arc, such as a Gravelerock.
        /// The number of positions in the array will be stored in AI_THROWN_ITEM_ACTION_CHOICE_COUNT.
        /// 
        /// r0: Entity pointer
        /// r1: Item struct pointer
        /// r2: [output] Array of size 20 for storing position structs
        /// r3: If false, will roll GetAiUseItemProbability every time a position is checked and not add it if it rolls false.
        /// </summary>
        public int GetPossibleAiArcItemTargets
        {
            get
            {
                if (f_getPossibleAiArcItemTargets)
                    return _getPossibleAiArcItemTargets;
                _getPossibleAiArcItemTargets = (int) (208008);
                f_getPossibleAiArcItemTargets = true;
                return _getPossibleAiArcItemTargets;
            }
        }
        private bool f_loadFixedRoomDataVeneer;
        private int _loadFixedRoomDataVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for LoadFixedRoomData.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// No params.
        /// </summary>
        public int LoadFixedRoomDataVeneer
        {
            get
            {
                if (f_loadFixedRoomDataVeneer)
                    return _loadFixedRoomDataVeneer;
                _loadFixedRoomDataVeneer = (int) (385288);
                f_loadFixedRoomDataVeneer = true;
                return _loadFixedRoomDataVeneer;
            }
        }
        private bool f_calcTypeBasedDamageEffects;
        private int _calcTypeBasedDamageEffects;

        /// <summary>
        /// Calculates type-based effects on damage.
        /// 
        /// Loosely, this includes type matchup effects (including modifications due to abilities, IQ skills, and exclusive items), STAB, pinch abilities like Overgrow, weather/floor condition effects on certain types, and miscellaneous effects like Charge.
        /// 
        /// r0: [output] damage multiplier due to type effects.
        /// r1: attacker pointer
        /// r2: defender pointer
        /// r3: attack power
        /// stack[0]: attack type
        /// stack[1]: [output] struct containing info about the damage calculation (only the critical_hit, type_matchup, and field_0xF fields are modified)
        /// stack[2]: flag for whether Erratic Player and Technician effects should be excluded. CalcDamage only passes in true if the move is the regular attack or a projectile.
        /// return: whether or not the Type-Advantage Master IQ skill should activate if the attacker has it. In practice, this corresponds to when the attack is super-effective, but technically true is also returned when the defender is an invalid entity.
        /// </summary>
        public int CalcTypeBasedDamageEffects
        {
            get
            {
                if (f_calcTypeBasedDamageEffects)
                    return _calcTypeBasedDamageEffects;
                _calcTypeBasedDamageEffects = (int) (190876);
                f_calcTypeBasedDamageEffects = true;
                return _calcTypeBasedDamageEffects;
            }
        }
        private bool f_monsterCanThrowItems;
        private int _monsterCanThrowItems;

        /// <summary>
        /// Returns a boolean indicating whether or not the given monster can throw items based on its monster id.
        /// 
        /// r0: Monster pointer
        /// return: bool
        /// </summary>
        public int MonsterCanThrowItems
        {
            get
            {
                if (f_monsterCanThrowItems)
                    return _monsterCanThrowItems;
                _monsterCanThrowItems = (int) (155608);
                f_monsterCanThrowItems = true;
                return _monsterCanThrowItems;
            }
        }
        private bool f_isMarowakTrainingMaze;
        private int _isMarowakTrainingMaze;

        /// <summary>
        /// Check if the current dungeon is one of the training mazes in Marowak Dojo (this excludes Final Maze).
        /// 
        /// return: bool
        /// </summary>
        public int IsMarowakTrainingMaze
        {
            get
            {
                if (f_isMarowakTrainingMaze)
                    return _isMarowakTrainingMaze;
                _isMarowakTrainingMaze = (int) (18000);
                f_isMarowakTrainingMaze = true;
                return _isMarowakTrainingMaze;
            }
        }
        private bool f_getFinalKecleonShopSpawnChance;
        private int _getFinalKecleonShopSpawnChance;

        /// <summary>
        /// Gets the kecleon shop spawn chance for the floor.
        /// 
        /// When dungeon::boost_kecleon_shop_spawn_chance is false, returns the same value as the input. When it's true, returns the input (chance * 1.2).
        /// 
        /// r0: base kecleon shop spawn chance, floor_properties::kecleon_shop_spawn_chance
        /// return: int
        /// </summary>
        public int GetFinalKecleonShopSpawnChance
        {
            get
            {
                if (f_getFinalKecleonShopSpawnChance)
                    return _getFinalKecleonShopSpawnChance;
                _getFinalKecleonShopSpawnChance = (int) (420256);
                f_getFinalKecleonShopSpawnChance = true;
                return _getFinalKecleonShopSpawnChance;
            }
        }
        private bool f_checkTeamMemberIdxVeneer;
        private int _checkTeamMemberIdxVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for CheckTeamMemberIdx.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: member index
        /// return: True if the value is equal to 0x55AA or 0x5AA5
        /// </summary>
        public int CheckTeamMemberIdxVeneer
        {
            get
            {
                if (f_checkTeamMemberIdxVeneer)
                    return _checkTeamMemberIdxVeneer;
                _checkTeamMemberIdxVeneer = (int) (121112);
                f_checkTeamMemberIdxVeneer = true;
                return _checkTeamMemberIdxVeneer;
            }
        }
        private bool f_generateMaze;
        private int _generateMaze;

        /// <summary>
        /// Generate a maze room within a given grid cell.
        /// 
        /// A &quot;maze&quot; is generated within the room using a series of random walks to place obstacle terrain (walls or secondary terrain) in a maze-like arrangement. &quot;Maze lines&quot; (see GenerateMazeLine) are generated using every other tile around the room's border, as well as every other interior tile, as a starting point. This ensures that there are stripes of walkable open terrain surrounded by stripes of obstacles (the maze walls).
        /// 
        /// r0: grid cell pointer
        /// r1: use secondary terrain flag (true for water/lava, false for walls)
        /// </summary>
        public int GenerateMaze
        {
            get
            {
                if (f_generateMaze)
                    return _generateMaze;
                _generateMaze = (int) (409400);
                f_generateMaze = true;
                return _generateMaze;
            }
        }
        private bool f_isSecretFloor;
        private int _isSecretFloor;

        /// <summary>
        /// Checks if the current floor is a secret bazaar or a secret room.
        /// 
        /// return: bool
        /// </summary>
        public int IsSecretFloor
        {
            get
            {
                if (f_isSecretFloor)
                    return _isSecretFloor;
                _isSecretFloor = (int) (377192);
                f_isSecretFloor = true;
                return _isSecretFloor;
            }
        }
        private bool f_applyMudTrapEffect;
        private int _applyMudTrapEffect;

        /// <summary>
        /// Randomly lowers attack, special attack, defense, or special defense of the defender by 3 stages.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int ApplyMudTrapEffect
        {
            get
            {
                if (f_applyMudTrapEffect)
                    return _applyMudTrapEffect;
                _applyMudTrapEffect = (int) (73960);
                f_applyMudTrapEffect = true;
                return _applyMudTrapEffect;
            }
        }
        private bool f_getNextFixedRoomAction;
        private int _getNextFixedRoomAction;

        /// <summary>
        /// Returns the next action that needs to be performed when spawning a fixed room tile.
        /// 
        /// return: Next action ID
        /// </summary>
        public int GetNextFixedRoomAction
        {
            get
            {
                if (f_getNextFixedRoomAction)
                    return _getNextFixedRoomAction;
                _getNextFixedRoomAction = (int) (417712);
                f_getNextFixedRoomAction = true;
                return _getNextFixedRoomAction;
            }
        }
        private bool f_generateMazeLine;
        private int _generateMazeLine;

        /// <summary>
        /// Generate a &quot;maze line&quot; from a given starting point, within the given bounds.
        /// 
        /// A &quot;maze line&quot; is a random walk starting from (x0, y0). The random walk proceeds with a stride of 2 in a random direction, laying down obstacles as it goes. The random walk terminates when it gets trapped and there are no more neighboring tiles that are open and in-bounds.
        /// 
        /// r0: x0
        /// r1: y0
        /// r2: xmin
        /// r3: ymin
        /// stack[0]: xmax
        /// stack[1]: ymax
        /// stack[2]: use secondary terrain flag (true for water/lava, false for walls)
        /// stack[3]: room index
        /// </summary>
        public int GenerateMazeLine
        {
            get
            {
                if (f_generateMazeLine)
                    return _generateMazeLine;
                _generateMazeLine = (int) (410036);
                f_generateMazeLine = true;
                return _generateMazeLine;
            }
        }
        private bool f_tryInflictPierceStatus;
        private int _tryInflictPierceStatus;

        /// <summary>
        /// Inflicts the Pierce status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictPierceStatus
        {
            get
            {
                if (f_tryInflictPierceStatus)
                    return _tryInflictPierceStatus;
                _tryInflictPierceStatus = (int) (245248);
                f_tryInflictPierceStatus = true;
                return _tryInflictPierceStatus;
            }
        }
        private bool f_generateMissionEggMonster;
        private int _generateMissionEggMonster;

        /// <summary>
        /// Generates the monster ID in the egg from the given mission. Uses the base form of the monster.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: mission struct
        /// </summary>
        public int GenerateMissionEggMonster
        {
            get
            {
                if (f_generateMissionEggMonster)
                    return _generateMissionEggMonster;
                _generateMissionEggMonster = (int) (447152);
                f_generateMissionEggMonster = true;
                return _generateMissionEggMonster;
            }
        }
        private bool f_ensureImpassableTilesAreWalls;
        private int _ensureImpassableTilesAreWalls;

        /// <summary>
        /// Ensures all tiles with the impassable flag are walls.
        /// 
        /// No params.
        /// </summary>
        public int EnsureImpassableTilesAreWalls
        {
            get
            {
                if (f_ensureImpassableTilesAreWalls)
                    return _ensureImpassableTilesAreWalls;
                _ensureImpassableTilesAreWalls = (int) (410968);
                f_ensureImpassableTilesAreWalls = true;
                return _ensureImpassableTilesAreWalls;
            }
        }
        private bool f_flashFireShouldActivate;
        private int _flashFireShouldActivate;

        /// <summary>
        /// Checks whether Flash Fire should activate, assuming the defender is being hit by a Fire-type move.
        /// 
        /// This checks that the defender is valid and Flash Fire is active, and that Normalize isn't active on the attacker.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// return: 2 if Flash Fire should activate and raise the defender's boost level, 1 if Flash Fire should activate but the defender's boost level is maxed out, 0 otherwise.
        /// </summary>
        public int FlashFireShouldActivate
        {
            get
            {
                if (f_flashFireShouldActivate)
                    return _flashFireShouldActivate;
                _flashFireShouldActivate = (int) (227452);
                f_flashFireShouldActivate = true;
                return _flashFireShouldActivate;
            }
        }
        private bool f_spawnItemEntity;
        private int _spawnItemEntity;

        /// <summary>
        /// Spawns a blank item entity on the floor. Fails if there are more than 64 items already on the floor.
        /// 
        /// This initializes a new entry in the entity table and points it to the corresponding slot in the item info list.
        /// 
        /// r0: position
        /// return: entity pointer for the newly added item, or null on failure
        /// </summary>
        public int SpawnItemEntity
        {
            get
            {
                if (f_spawnItemEntity)
                    return _spawnItemEntity;
                _spawnItemEntity = (int) (24772);
                f_spawnItemEntity = true;
                return _spawnItemEntity;
            }
        }
        private bool f_musicTableIdxToMusicId;
        private int _musicTableIdxToMusicId;

        /// <summary>
        /// Used to convert an index that refers to a MUSIC_ID_TABLE entry to a regular music ID.
        /// 
        /// r0: Music table index
        /// return: Music ID
        /// </summary>
        public int MusicTableIdxToMusicId
        {
            get
            {
                if (f_musicTableIdxToMusicId)
                    return _musicTableIdxToMusicId;
                _musicTableIdxToMusicId = (int) (60040);
                f_musicTableIdxToMusicId = true;
                return _musicTableIdxToMusicId;
            }
        }
        private bool f_tryInflictBlinkerStatus;
        private int _tryInflictBlinkerStatus;

        /// <summary>
        /// Inflicts the Blinker status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// r3: flag to log a message on failure
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictBlinkerStatus
        {
            get
            {
                if (f_tryInflictBlinkerStatus)
                    return _tryInflictBlinkerStatus;
                _tryInflictBlinkerStatus = (int) (242364);
                f_tryInflictBlinkerStatus = true;
                return _tryInflictBlinkerStatus;
            }
        }
        private bool f_displayUi;
        private int _displayUi;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int DisplayUi
        {
            get
            {
                if (f_displayUi)
                    return _displayUi;
                _displayUi = (int) (365824);
                f_displayUi = true;
                return _displayUi;
            }
        }
        private bool f_setActionUseMoveAi;
        private int _setActionUseMoveAi;

        /// <summary>
        /// Sets a monster's action to action::ACTION_USE_MOVE_AI, with a specified direction and move index.
        /// 
        /// r0: Pointer to the monster's action field
        /// r1: Index of the move to use (0-3). Gets stored in monster::action::action_use_idx.
        /// r2: Direction in which to use the move. Gets stored in monster::action::direction.
        /// </summary>
        public int SetActionUseMoveAi
        {
            get
            {
                if (f_setActionUseMoveAi)
                    return _setActionUseMoveAi;
                _setActionUseMoveAi = (int) (64068);
                f_setActionUseMoveAi = true;
                return _setActionUseMoveAi;
            }
        }
        private bool f_endCurseClassStatus;
        private int _endCurseClassStatus;

        /// <summary>
        /// Removes the target's curse (1), decoy (2), snatch (3), gastro acid (4), heal block (5), or embargo (6) status
        /// due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// r2: curse class status being afflicted after (0 is the status is only being removed)
        /// r3: flag to log a message
        /// </summary>
        public int EndCurseClassStatus
        {
            get
            {
                if (f_endCurseClassStatus)
                    return _endCurseClassStatus;
                _endCurseClassStatus = (int) (172920);
                f_endCurseClassStatus = true;
                return _endCurseClassStatus;
            }
        }
        private bool f_tryDecreaseBelly;
        private int _tryDecreaseBelly;

        /// <summary>
        /// Tries to reduce the belly size of the target. Only when max belly shrink is 0, the
        /// current belly is reduced by belly to lose. If both are non-zero, only the max belly
        /// shrink is applied.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: belly to lose
        /// r3: max belly shrink
        /// </summary>
        public int TryDecreaseBelly
        {
            get
            {
                if (f_tryDecreaseBelly)
                    return _tryDecreaseBelly;
                _tryDecreaseBelly = (int) (238792);
                f_tryDecreaseBelly = true;
                return _tryDecreaseBelly;
            }
        }
        private bool f_spawnInitialMonsters;
        private int _spawnInitialMonsters;

        /// <summary>
        /// Tries to spawn monsters on all the tiles marked for monster spawns. This includes normal enemies and mission targets (rescue targets, outlaws, etc.).
        /// 
        /// A random initial position is selected as a starting point. Tiles are then swept over left-to-right, top-to-bottom, wrapping around when the map boundary is reached, until all tiles have been checked. The first marked tile encountered in the sweep is reserved for the mission target, but the actual spawning of the target is done last.
        /// 
        /// No params.
        /// </summary>
        public int SpawnInitialMonsters
        {
            get
            {
                if (f_spawnInitialMonsters)
                    return _spawnInitialMonsters;
                _spawnInitialMonsters = (int) (133260);
                f_spawnInitialMonsters = true;
                return _spawnInitialMonsters;
            }
        }
        private bool f_tickStatusAndHealthRegen;
        private int _tickStatusAndHealthRegen;

        /// <summary>
        /// Applies the natural HP regen effect by taking modifiers into account (Poison Heal, Heal Ribbon, weather-related regen). Then it ticks down counters for volatile status effects, and heals them if the counter reached zero.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int TickStatusAndHealthRegen
        {
            get
            {
                if (f_tickStatusAndHealthRegen)
                    return _tickStatusAndHealthRegen;
                _tickStatusAndHealthRegen = (int) (216272);
                f_tickStatusAndHealthRegen = true;
                return _tickStatusAndHealthRegen;
            }
        }
        private bool f_boostIq;
        private int _boostIq;

        /// <summary>
        /// Tries to boost the target's IQ.
        /// 
        /// r0: monster entity pointer
        /// r1: iq boost
        /// r2: bool suppress logs
        /// </summary>
        public int BoostIq
        {
            get
            {
                if (f_boostIq)
                    return _boostIq;
                _boostIq = (int) (122380);
                f_boostIq = true;
                return _boostIq;
            }
        }
        private bool f_tryInflictFocusEnergyStatus;
        private int _tryInflictFocusEnergyStatus;

        /// <summary>
        /// Inflicts the Focus Energy status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictFocusEnergyStatus
        {
            get
            {
                if (f_tryInflictFocusEnergyStatus)
                    return _tryInflictFocusEnergyStatus;
                _tryInflictFocusEnergyStatus = (int) (235900);
                f_tryInflictFocusEnergyStatus = true;
                return _tryInflictFocusEnergyStatus;
            }
        }
        private bool f_joinedAtRangeCheck2Veneer;
        private int _joinedAtRangeCheck2Veneer;

        /// <summary>
        /// Likely a linker-generated veneer for arm9::JoinedAtRangeCheck2.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// No params.
        /// </summary>
        public int JoinedAtRangeCheck2Veneer
        {
            get
            {
                if (f_joinedAtRangeCheck2Veneer)
                    return _joinedAtRangeCheck2Veneer;
                _joinedAtRangeCheck2Veneer = (int) (110736);
                f_joinedAtRangeCheck2Veneer = true;
                return _joinedAtRangeCheck2Veneer;
            }
        }
        private bool f_dungeonRand100;
        private int _dungeonRand100;

        /// <summary>
        /// Compute a pseudorandom integer on the interval [0, 100) using the dungeon PRNG.
        /// 
        /// return: pseudorandom integer
        /// </summary>
        public int DungeonRand100
        {
            get
            {
                if (f_dungeonRand100)
                    return _dungeonRand100;
                _dungeonRand100 = (int) (387432);
                f_dungeonRand100 = true;
                return _dungeonRand100;
            }
        }
        private bool f_getMoveTypeForMonster;
        private int _getMoveTypeForMonster;

        /// <summary>
        /// Check the type of a move when used by a certain monster. Accounts for special cases such as Hidden Power, Weather Ball, the regular attack...
        /// 
        /// r0: Entity pointer
        /// r1: Pointer to move data
        /// return: Type of the move
        /// </summary>
        public int GetMoveTypeForMonster
        {
            get
            {
                if (f_getMoveTypeForMonster)
                    return _getMoveTypeForMonster;
                _getMoveTypeForMonster = (int) (155372);
                f_getMoveTypeForMonster = true;
                return _getMoveTypeForMonster;
            }
        }
        private bool f_dungeonModeSetupAndShowNameKeyboard;
        private int _dungeonModeSetupAndShowNameKeyboard;

        /// <summary>
        /// Sets up and opens the naming keyboard in dungeon mode.
        /// 
        /// r0: [output] keyboard result, also the inital string
        /// r1: buffer?
        /// r2: ?
        /// return: ?
        /// </summary>
        public int DungeonModeSetupAndShowNameKeyboard
        {
            get
            {
                if (f_dungeonModeSetupAndShowNameKeyboard)
                    return _dungeonModeSetupAndShowNameKeyboard;
                _dungeonModeSetupAndShowNameKeyboard = (int) (469420);
                f_dungeonModeSetupAndShowNameKeyboard = true;
                return _dungeonModeSetupAndShowNameKeyboard;
            }
        }
        private bool f_tryInflictMirrorCoatStatus;
        private int _tryInflictMirrorCoatStatus;

        /// <summary>
        /// Inflicts the Mirror Coat status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictMirrorCoatStatus
        {
            get
            {
                if (f_tryInflictMirrorCoatStatus)
                    return _tryInflictMirrorCoatStatus;
                _tryInflictMirrorCoatStatus = (int) (249548);
                f_tryInflictMirrorCoatStatus = true;
                return _tryInflictMirrorCoatStatus;
            }
        }
        private bool f_getMaxHpAtLevel;
        private int _getMaxHpAtLevel;

        /// <summary>
        /// Returns the max HP of a monster given its level.
        /// 
        /// r0: Monster ID
        /// r1: Monster level
        /// return: Max HP at the given level
        /// </summary>
        public int GetMaxHpAtLevel
        {
            get
            {
                if (f_getMaxHpAtLevel)
                    return _getMaxHpAtLevel;
                _getMaxHpAtLevel = (int) (138756);
                f_getMaxHpAtLevel = true;
                return _getMaxHpAtLevel;
            }
        }
        private bool f_endSleepClassStatus;
        private int _endSleepClassStatus;

        /// <summary>
        /// Cures the target's sleep, sleepless, nightmare, yawn or napping status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndSleepClassStatus
        {
            get
            {
                if (f_endSleepClassStatus)
                    return _endSleepClassStatus;
                _endSleepClassStatus = (int) (171084);
                f_endSleepClassStatus = true;
                return _endSleepClassStatus;
            }
        }
        private bool f_boostOffensiveStat;
        private int _boostOffensiveStat;

        /// <summary>
        /// Boosts the specified offensive stat on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: number of stages
        /// </summary>
        public int BoostOffensiveStat
        {
            get
            {
                if (f_boostOffensiveStat)
                    return _boostOffensiveStat;
                _boostOffensiveStat = (int) (226724);
                f_boostOffensiveStat = true;
                return _boostOffensiveStat;
            }
        }
        private bool f_isMonsterCornered;
        private int _isMonsterCornered;

        /// <summary>
        /// True if the given monster is cornered (it can't move in any direction)
        /// 
        /// r0: Entity pointer
        /// return: True if the monster can't move in any direction, false otherwise.
        /// </summary>
        public int IsMonsterCornered
        {
            get
            {
                if (f_isMonsterCornered)
                    return _isMonsterCornered;
                _isMonsterCornered = (int) (150588);
                f_isMonsterCornered = true;
                return _isMonsterCornered;
            }
        }
        private bool f_removeGroundItem;
        private int _removeGroundItem;

        /// <summary>
        /// Removes an item lying on the ground.
        /// 
        /// Also updates dungeon::n_items.
        /// 
        /// r0: Position where the item is located
        /// r1: If true, update dungeon::poke_buy_kecleon_shop and dungeon::poke_sold_kecleon_shop
        /// </summary>
        public int RemoveGroundItem
        {
            get
            {
                if (f_removeGroundItem)
                    return _removeGroundItem;
                _removeGroundItem = (int) (430496);
                f_removeGroundItem = true;
                return _removeGroundItem;
            }
        }
        private bool f_tryInflictGrudgeStatus;
        private int _tryInflictGrudgeStatus;

        /// <summary>
        /// Inflicts the Grudge status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictGrudgeStatus
        {
            get
            {
                if (f_tryInflictGrudgeStatus)
                    return _tryInflictGrudgeStatus;
                _tryInflictGrudgeStatus = (int) (232108);
                f_tryInflictGrudgeStatus = true;
                return _tryInflictGrudgeStatus;
            }
        }
        private bool f_isSpecialStoryAlly;
        private int _isSpecialStoryAlly;

        /// <summary>
        /// Checks if a monster is a special story ally.
        /// 
        /// This is a hard-coded check that looks at the monster's &quot;Joined At&quot; field. If the value is in the range [DUNGEON_JOINED_AT_BIDOOF, DUNGEON_DUMMY_0xE3], this check will return true.
        /// 
        /// r0: monster pointer
        /// return: bool
        /// </summary>
        public int IsSpecialStoryAlly
        {
            get
            {
                if (f_isSpecialStoryAlly)
                    return _isSpecialStoryAlly;
                _isSpecialStoryAlly = (int) (128708);
                f_isSpecialStoryAlly = true;
                return _isSpecialStoryAlly;
            }
        }
        private bool f_displayRunAwayIfTriggered;
        private int _displayRunAwayIfTriggered;

        /// <summary>
        /// If the Run Away ability has triggered on the entity and r1 is true, displays the visual &quot;poof&quot; effect indicating Run Away.
        /// 
        /// r0: Entity pointer
        /// r1: Boolean value. If true, display a visual &quot;poof&quot; effect if the Run Away ability caused the monster to run away.
        /// </summary>
        public int DisplayRunAwayIfTriggered
        {
            get
            {
                if (f_displayRunAwayIfTriggered)
                    return _displayRunAwayIfTriggered;
                _displayRunAwayIfTriggered = (int) (152424);
                f_displayRunAwayIfTriggered = true;
                return _displayRunAwayIfTriggered;
            }
        }
        private bool f_tryInflictTerrifiedStatus;
        private int _tryInflictTerrifiedStatus;

        /// <summary>
        /// Inflicts the Terrified status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictTerrifiedStatus
        {
            get
            {
                if (f_tryInflictTerrifiedStatus)
                    return _tryInflictTerrifiedStatus;
                _tryInflictTerrifiedStatus = (int) (232020);
                f_tryInflictTerrifiedStatus = true;
                return _tryInflictTerrifiedStatus;
            }
        }
        private bool f_logMessageByIdWithPopupCheckUser;
        private int _logMessageByIdWithPopupCheckUser;

        /// <summary>
        /// Logs a message in the message log alongside a message popup, if the user hasn't fainted.
        /// 
        /// r0: user entity pointer
        /// r1: message ID
        /// </summary>
        public int LogMessageByIdWithPopupCheckUser
        {
            get
            {
                if (f_logMessageByIdWithPopupCheckUser)
                    return _logMessageByIdWithPopupCheckUser;
                _logMessageByIdWithPopupCheckUser = (int) (453684);
                f_logMessageByIdWithPopupCheckUser = true;
                return _logMessageByIdWithPopupCheckUser;
            }
        }
        private bool f_tryActivateGravity;
        private int _tryActivateGravity;

        /// <summary>
        /// Attempts to activate Gravity for this dungeon floor.
        /// 
        /// return: whether or not gravity was activated
        /// </summary>
        public int TryActivateGravity
        {
            get
            {
                if (f_tryActivateGravity)
                    return _tryActivateGravity;
                _tryActivateGravity = (int) (376480);
                f_tryActivateGravity = true;
                return _tryActivateGravity;
            }
        }
        private bool f_isExperienceLocked;
        private int _isExperienceLocked;

        /// <summary>
        /// Checks if a monster does not gain experience.
        /// 
        /// This basically just inverts IsSpecialStoryAlly, with the exception of also checking for the &quot;Joined At&quot; field being DUNGEON_CLIENT (set for mission clients).
        /// 
        /// r0: monster pointer
        /// return: bool
        /// </summary>
        public int IsExperienceLocked
        {
            get
            {
                if (f_isExperienceLocked)
                    return _isExperienceLocked;
                _isExperienceLocked = (int) (128740);
                f_isExperienceLocked = true;
                return _isExperienceLocked;
            }
        }
        private bool f_applyDamageAndEffectsWrapper;
        private int _applyDamageAndEffectsWrapper;

        /// <summary>
        /// A wrapper for ApplyDamageAndEffects used for applying damage from sources such as statuses, traps, liquid ooze,
        /// hunger, and possibly more.
        /// 
        /// r0: monster entity pointer
        /// r1: damage amount
        /// r2: damage message
        /// r3: damage source
        /// </summary>
        public int ApplyDamageAndEffectsWrapper
        {
            get
            {
                if (f_applyDamageAndEffectsWrapper)
                    return _applyDamageAndEffectsWrapper;
                _applyDamageAndEffectsWrapper = (int) (200060);
                f_applyDamageAndEffectsWrapper = true;
                return _applyDamageAndEffectsWrapper;
            }
        }
        private bool f_resolveInvalidSpawns;
        private int _resolveInvalidSpawns;

        /// <summary>
        /// Resolve invalid spawn flags on tiles.
        /// 
        /// Spawn flags can be invalid due to terrain. For example, traps can't spawn on obstacles. Spawn flags can also be invalid due to multiple being set on a single tile, in which case one will take precedence. For example, stair spawns trump trap spawns.
        /// 
        /// No params.
        /// </summary>
        public int ResolveInvalidSpawns
        {
            get
            {
                if (f_resolveInvalidSpawns)
                    return _resolveInvalidSpawns;
                _resolveInvalidSpawns = (int) (410708);
                f_resolveInvalidSpawns = true;
                return _resolveInvalidSpawns;
            }
        }
        private bool f_tryWarp;
        private int _tryWarp;

        /// <summary>
        /// Makes the target monster warp if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: warp type
        /// r3: position (if warp type is position-based)
        /// </summary>
        public int TryWarp
        {
            get
            {
                if (f_tryWarp)
                    return _tryWarp;
                _tryWarp = (int) (280788);
                f_tryWarp = true;
                return _tryWarp;
            }
        }
        private bool f_isTypeIneffectiveAgainstGhost;
        private int _isTypeIneffectiveAgainstGhost;

        /// <summary>
        /// Checks whether a type is normally ineffective against Ghost, i.e., it's Normal or Fighting.
        /// 
        /// r0: type ID
        /// return: bool
        /// </summary>
        public int IsTypeIneffectiveAgainstGhost
        {
            get
            {
                if (f_isTypeIneffectiveAgainstGhost)
                    return _isTypeIneffectiveAgainstGhost;
                _isTypeIneffectiveAgainstGhost = (int) (190600);
                f_isTypeIneffectiveAgainstGhost = true;
                return _isTypeIneffectiveAgainstGhost;
            }
        }
        private bool f_setDoughSeedFlag;
        private int _setDoughSeedFlag;

        /// <summary>
        /// Sets the dough_seed_extra_money_flag field on the dungeon struct to the given value.
        /// 
        /// r0: bool to set the flag to
        /// </summary>
        public int SetDoughSeedFlag
        {
            get
            {
                if (f_setDoughSeedFlag)
                    return _setDoughSeedFlag;
                _setDoughSeedFlag = (int) (376876);
                f_setDoughSeedFlag = true;
                return _setDoughSeedFlag;
            }
        }
        private bool f_shouldLeaderKeepRunning;
        private int _shouldLeaderKeepRunning;

        /// <summary>
        /// Determines if the leader should keep running. Returns false if the leader bumps into something, or if an action that should stop the leader takes place.
        /// 
        /// return: True if the leader should keep running, false if it should stop.
        /// </summary>
        public int ShouldLeaderKeepRunning
        {
            get
            {
                if (f_shouldLeaderKeepRunning)
                    return _shouldLeaderKeepRunning;
                _shouldLeaderKeepRunning = (int) (93604);
                f_shouldLeaderKeepRunning = true;
                return _shouldLeaderKeepRunning;
            }
        }
        private bool f_getMovePower;
        private int _getMovePower;

        /// <summary>
        /// Gets the power of a move, factoring in Ginseng/Space Globe boosts.
        /// 
        /// r0: user pointer
        /// r1: move pointer
        /// return: move power
        /// </summary>
        public int GetMovePower
        {
            get
            {
                if (f_getMovePower)
                    return _getMovePower;
                _getMovePower = (int) (155532);
                f_getMovePower = true;
                return _getMovePower;
            }
        }
        private bool f_mirrorMoveIsActive;
        private int _mirrorMoveIsActive;

        /// <summary>
        /// Checks if the monster is under the effect of Mirror Move.
        /// 
        /// Returns 1 if the effects is a status, 2 if it comes from an exclusive item, 0 otherwise.
        /// 
        /// r0: pointer to entity
        /// return: int
        /// </summary>
        public int MirrorMoveIsActive
        {
            get
            {
                if (f_mirrorMoveIsActive)
                    return _mirrorMoveIsActive;
                _mirrorMoveIsActive = (int) (250680);
                f_mirrorMoveIsActive = true;
                return _mirrorMoveIsActive;
            }
        }
        private bool f_spawnDroppedItemWrapper;
        private int _spawnDroppedItemWrapper;

        /// <summary>
        /// Wraps SpawnDroppedItem in a more convenient interface.
        /// 
        /// r0: entity
        /// r1: position
        /// r2: item
        /// r3: ?
        /// </summary>
        public int SpawnDroppedItemWrapper
        {
            get
            {
                if (f_spawnDroppedItemWrapper)
                    return _spawnDroppedItemWrapper;
                _spawnDroppedItemWrapper = (int) (431392);
                f_spawnDroppedItemWrapper = true;
                return _spawnDroppedItemWrapper;
            }
        }
        private bool f_getStairsSpawnPosition;
        private int _getStairsSpawnPosition;

        /// <summary>
        /// Gets the spawn position for the stairs and stores it at the passed pointers.
        /// 
        /// r0: [output] pointer to x coordinate
        /// r1: [output] pointer to y coordinate
        /// </summary>
        public int GetStairsSpawnPosition
        {
            get
            {
                if (f_getStairsSpawnPosition)
                    return _getStairsSpawnPosition;
                _getStairsSpawnPosition = (int) (368304);
                f_getStairsSpawnPosition = true;
                return _getStairsSpawnPosition;
            }
        }
        private bool f_openMessageLog;
        private int _openMessageLog;

        /// <summary>
        /// Opens the message log window.
        /// 
        /// r0: ?
        /// r1: ?
        /// </summary>
        public int OpenMessageLog
        {
            get
            {
                if (f_openMessageLog)
                    return _openMessageLog;
                _openMessageLog = (int) (455904);
                f_openMessageLog = true;
                return _openMessageLog;
            }
        }
        private bool f_areOrbsAllowed;
        private int _areOrbsAllowed;

        /// <summary>
        /// Checks if orbs are usable in the given fixed room.
        /// 
        /// Always true if not a full-floor fixed room.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int AreOrbsAllowed
        {
            get
            {
                if (f_areOrbsAllowed)
                    return _areOrbsAllowed;
                _areOrbsAllowed = (int) (424848);
                f_areOrbsAllowed = true;
                return _areOrbsAllowed;
            }
        }
        private bool f_deleteMonsterSpriteFile;
        private int _deleteMonsterSpriteFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// </summary>
        public int DeleteMonsterSpriteFile
        {
            get
            {
                if (f_deleteMonsterSpriteFile)
                    return _deleteMonsterSpriteFile;
                _deleteMonsterSpriteFile = (int) (111692);
                f_deleteMonsterSpriteFile = true;
                return _deleteMonsterSpriteFile;
            }
        }
        private bool f_enemyEvolution;
        private int _enemyEvolution;

        /// <summary>
        /// Checks if any enemies on the floor should evolve and attempts to evolve it. The
        /// entity pointer passed seems to get replaced by a generic placeholder entity if the
        /// entity pointer passed is invalid.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int EnemyEvolution
        {
            get
            {
                if (f_enemyEvolution)
                    return _enemyEvolution;
                _enemyEvolution = (int) (156524);
                f_enemyEvolution = true;
                return _enemyEvolution;
            }
        }
        private bool f_monsterIsType;
        private int _monsterIsType;

        /// <summary>
        /// Checks if a monster is a given type.
        /// 
        /// r0: entity pointer
        /// r1: type ID
        /// return: bool
        /// </summary>
        public int MonsterIsType
        {
            get
            {
                if (f_monsterIsType)
                    return _monsterIsType;
                _monsterIsType = (int) (154304);
                f_monsterIsType = true;
                return _monsterIsType;
            }
        }
        private bool f_countMovesOutOfPp;
        private int _countMovesOutOfPp;

        /// <summary>
        /// Returns how many of a monster's move are out of PP.
        /// 
        /// r0: entity pointer
        /// return: number of moves out of PP
        /// </summary>
        public int CountMovesOutOfPp
        {
            get
            {
                if (f_countMovesOutOfPp)
                    return _countMovesOutOfPp;
                _countMovesOutOfPp = (int) (126288);
                f_countMovesOutOfPp = true;
                return _countMovesOutOfPp;
            }
        }
        private bool f_tryInflictMobileStatus;
        private int _tryInflictMobileStatus;

        /// <summary>
        /// Inflicts the Mobile status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictMobileStatus
        {
            get
            {
                if (f_tryInflictMobileStatus)
                    return _tryInflictMobileStatus;
                _tryInflictMobileStatus = (int) (241660);
                f_tryInflictMobileStatus = true;
                return _tryInflictMobileStatus;
            }
        }
        private bool f_spawnTrap;
        private int _spawnTrap;

        /// <summary>
        /// Spawns a trap on the floor. Fails if there are more than 64 traps already on the floor.
        /// 
        /// This modifies the appropriate fields on the dungeon struct, initializing new entries in the entity table and the trap info list.
        /// 
        /// r0: trap ID
        /// r1: position
        /// r2: team (see struct trap::team)
        /// r3: flags (see struct trap::team)
        /// return: entity pointer for the newly added trap, or null on failure
        /// </summary>
        public int SpawnTrap
        {
            get
            {
                if (f_spawnTrap)
                    return _spawnTrap;
                _spawnTrap = (int) (24592);
                f_spawnTrap = true;
                return _spawnTrap;
            }
        }
        private bool f_generateMoneyQuantity;
        private int _generateMoneyQuantity;

        /// <summary>
        /// Set the quantity code on an item (assuming it's Poké), given some maximum acceptable money amount.
        /// 
        /// r0: item pointer
        /// r1: max money amount (inclusive)
        /// </summary>
        public int GenerateMoneyQuantity
        {
            get
            {
                if (f_generateMoneyQuantity)
                    return _generateMoneyQuantity;
                _generateMoneyQuantity = (int) (434948);
                f_generateMoneyQuantity = true;
                return _generateMoneyQuantity;
            }
        }
        private bool f_handleFaint;
        private int _handleFaint;

        /// <summary>
        /// Handles a fainted pokémon (reviving does not count as fainting).
        /// 
        /// r0: Fainted entity
        /// r1: Damage source (move ID or greater than the max move id for other causes)
        /// r2: Entity responsible of the fainting
        /// </summary>
        public int HandleFaint
        {
            get
            {
                if (f_handleFaint)
                    return _handleFaint;
                _handleFaint = (int) (113680);
                f_handleFaint = true;
                return _handleFaint;
            }
        }
        private bool f_initDungeonRng;
        private int _initDungeonRng;

        /// <summary>
        /// Initialize (or reinitialize) the dungeon PRNG with a given seed. The primary LCG and the five secondary LCGs are initialized jointly, and with the same seed.
        /// 
        /// r0: seed
        /// </summary>
        public int InitDungeonRng
        {
            get
            {
                if (f_initDungeonRng)
                    return _initDungeonRng;
                _initDungeonRng = (int) (59252);
                f_initDungeonRng = true;
                return _initDungeonRng;
            }
        }
        private bool f_applyPechaBerryEffect;
        private int _applyPechaBerryEffect;

        /// <summary>
        /// Tries to heal the poisoned and badly poisoned status condition. Prints a message on
        /// failure.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyPechaBerryEffect
        {
            get
            {
                if (f_applyPechaBerryEffect)
                    return _applyPechaBerryEffect;
                _applyPechaBerryEffect = (int) (264196);
                f_applyPechaBerryEffect = true;
                return _applyPechaBerryEffect;
            }
        }
        private bool f_prepareTrapperTrap;
        private int _prepareTrapperTrap;

        /// <summary>
        /// Saves the relevant information in the dungeon struct to later place a trap at the
        /// location of the entity. (Only called with trap ID 0x19 (TRAP_NONE), but could be used 
        /// with others).
        /// 
        /// r0: entity pointer
        /// r1: trap ID
        /// r2: team (see struct trap::team)
        /// </summary>
        public int PrepareTrapperTrap
        {
            get
            {
                if (f_prepareTrapperTrap)
                    return _prepareTrapperTrap;
                _prepareTrapperTrap = (int) (72024);
                f_prepareTrapperTrap = true;
                return _prepareTrapperTrap;
            }
        }
        private bool f_setSpawnFlag5;
        private int _setSpawnFlag5;

        /// <summary>
        /// Set spawn flag 5 (0b100000 or 0x20) on all tiles in a room.
        /// 
        /// r0: grid cell
        /// </summary>
        public int SetSpawnFlag5
        {
            get
            {
                if (f_setSpawnFlag5)
                    return _setSpawnFlag5;
                _setSpawnFlag5 = (int) (410460);
                f_setSpawnFlag5 = true;
                return _setSpawnFlag5;
            }
        }
        private bool f_tryExplosion;
        private int _tryExplosion;

        /// <summary>
        /// Creates an explosion if possible.
        /// 
        /// The target monster is considered the source of the explosion.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: coordinates where the explosion should take place (center)
        /// r3: explosion radius (only works correctly with 1 and 2)
        /// stack[0]: damage type
        /// stack[1]: damage source
        /// </summary>
        public int TryExplosion
        {
            get
            {
                if (f_tryExplosion)
                    return _tryExplosion;
                _tryExplosion = (int) (278548);
                f_tryExplosion = true;
                return _tryExplosion;
            }
        }
        private bool f_conversion2IsActive;
        private int _conversion2IsActive;

        /// <summary>
        /// Checks if the monster is under the effect of Conversion 2 (its type was changed).
        /// 
        /// Returns 1 if the effects is a status, 2 if it comes from an exclusive item, 0 otherwise.
        /// 
        /// r0: pointer to entity
        /// return: int
        /// </summary>
        public int Conversion2IsActive
        {
            get
            {
                if (f_conversion2IsActive)
                    return _conversion2IsActive;
                _conversion2IsActive = (int) (250884);
                f_conversion2IsActive = true;
                return _conversion2IsActive;
            }
        }
        private bool f_fadeToBlack;
        private int _fadeToBlack;

        /// <summary>
        /// Fades the screen to black across several frames.
        /// 
        /// No params.
        /// </summary>
        public int FadeToBlack
        {
            get
            {
                if (f_fadeToBlack)
                    return _fadeToBlack;
                _fadeToBlack = (int) (18200);
                f_fadeToBlack = true;
                return _fadeToBlack;
            }
        }
        private bool f_applyStickyTrapEffect;
        private int _applyStickyTrapEffect;

        /// <summary>
        /// If the defender is the leader, randomly try to make something in the bag sticky. Otherwise, try to make the item the monster is holding sticky.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int ApplyStickyTrapEffect
        {
            get
            {
                if (f_applyStickyTrapEffect)
                    return _applyStickyTrapEffect;
                _applyStickyTrapEffect = (int) (74160);
                f_applyStickyTrapEffect = true;
                return _applyStickyTrapEffect;
            }
        }
        private bool f_applyDoughSeedEffect;
        private int _applyDoughSeedEffect;

        /// <summary>
        /// If the target monster is a team member, set dough_seed_extra_poke_flag to true to 
        /// make extra poke spawn on the next floor. Otherwise, do nothing.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyDoughSeedEffect
        {
            get
            {
                if (f_applyDoughSeedEffect)
                    return _applyDoughSeedEffect;
                _applyDoughSeedEffect = (int) (266952);
                f_applyDoughSeedEffect = true;
                return _applyDoughSeedEffect;
            }
        }
        private bool f_levitateIsActive;
        private int _levitateIsActive;

        /// <summary>
        /// Checks if a monster is levitating (has the effect of Levitate and Gravity is not active).
        /// 
        /// r0: pointer to entity
        /// return: bool
        /// </summary>
        public int LevitateIsActive
        {
            get
            {
                if (f_levitateIsActive)
                    return _levitateIsActive;
                _levitateIsActive = (int) (154248);
                f_levitateIsActive = true;
                return _levitateIsActive;
            }
        }
        private bool f_determineTileWalkableNeighbors;
        private int _determineTileWalkableNeighbors;

        /// <summary>
        /// Evaluates the walkable_neighbor_flags for the this tile by checking the 8 adjacent tiles.
        /// 
        /// r0: x coordinate
        /// r1: y coordinate
        /// </summary>
        public int DetermineTileWalkableNeighbors
        {
            get
            {
                if (f_determineTileWalkableNeighbors)
                    return _determineTileWalkableNeighbors;
                _determineTileWalkableNeighbors = (int) (370028);
                f_determineTileWalkableNeighbors = true;
                return _determineTileWalkableNeighbors;
            }
        }
        private bool f_isMonsterDrowsy;
        private int _isMonsterDrowsy;

        /// <summary>
        /// Checks if a monster has the sleep, nightmare, or yawning status. Note that this excludes the napping status.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int IsMonsterDrowsy
        {
            get
            {
                if (f_isMonsterDrowsy)
                    return _isMonsterDrowsy;
                _isMonsterDrowsy = (int) (147380);
                f_isMonsterDrowsy = true;
                return _isMonsterDrowsy;
            }
        }
        private bool f_dungeonRandOutcomeUserAction;
        private int _dungeonRandOutcomeUserAction;

        /// <summary>
        /// Like DungeonRandOutcome, but specifically for user actions.
        /// 
        /// This modifies the underlying random process to factor in Serene Grace (and checks whether the user is a valid entity).
        /// 
        /// r0: entity pointer
        /// r1: base success percentage (100*p). 0 is treated specially and guarantees success.
        /// return: True if the random check passed, false otherwise.
        /// </summary>
        public int DungeonRandOutcomeUserAction
        {
            get
            {
                if (f_dungeonRandOutcomeUserAction)
                    return _dungeonRandOutcomeUserAction;
                _dungeonRandOutcomeUserAction = (int) (296396);
                f_dungeonRandOutcomeUserAction = true;
                return _dungeonRandOutcomeUserAction;
            }
        }
        private bool f_getExclusiveItemWithEffectFromBag;
        private int _getExclusiveItemWithEffectFromBag;

        /// <summary>
        /// If an exclusive item with a certain effect is present in the bag and works for the entity, returns true and copies the item struct to the address at item. Otherwise, returns false.
        /// 
        /// r0: Entity pointer
        /// r1: exclusive_item_effect_id enum
        /// r2: [output] Item pointer
        /// return: bool
        /// </summary>
        public int GetExclusiveItemWithEffectFromBag
        {
            get
            {
                if (f_getExclusiveItemWithEffectFromBag)
                    return _getExclusiveItemWithEffectFromBag;
                _getExclusiveItemWithEffectFromBag = (int) (209584);
                f_getExclusiveItemWithEffectFromBag = true;
                return _getExclusiveItemWithEffectFromBag;
            }
        }
        private bool f_executeMoveEffect;
        private int _executeMoveEffect;

        /// <summary>
        /// Handles the effects that happen after a move is used. Includes a loop that is run for each target, mutiple ability checks and the giant switch statement that executes the effect of the move used given its ID.
        /// 
        /// r0: pointer to list of targets
        /// r1: attacker pointer
        /// r2: pointer to move data
        /// r3: ?
        /// stack[0]: ?
        /// </summary>
        public int ExecuteMoveEffect
        {
            get
            {
                if (f_executeMoveEffect)
                    return _executeMoveEffect;
                _executeMoveEffect = (int) (336768);
                f_executeMoveEffect = true;
                return _executeMoveEffect;
            }
        }
        private bool f_playEffectAnimation0x171Full;
        private int _playEffectAnimation0x171Full;

        /// <summary>
        /// Just a guess. Calls PlayEffectAnimation with data from animation ID 0x171, with the third parameter of PlayEffectAnimation set to true.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int PlayEffectAnimation0x171Full
        {
            get
            {
                if (f_playEffectAnimation0x171Full)
                    return _playEffectAnimation0x171Full;
                _playEffectAnimation0x171Full = (int) (32168);
                f_playEffectAnimation0x171Full = true;
                return _playEffectAnimation0x171Full;
            }
        }
        private bool f_getLeaderAction;
        private int _getLeaderAction;

        /// <summary>
        /// Returns a pointer to the action data of the current leader (field 0x4A on its monster struct).
        /// 
        /// No params.
        /// </summary>
        public int GetLeaderAction
        {
            get
            {
                if (f_getLeaderAction)
                    return _getLeaderAction;
                _getLeaderAction = (int) (84140);
                f_getLeaderAction = true;
                return _getLeaderAction;
            }
        }
        private bool f_tryInflictShadowHoldStatus;
        private int _tryInflictShadowHoldStatus;

        /// <summary>
        /// Inflicts the Shadow Hold (AKA Immobilized) status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to only perform the check for inflicting without actually inflicting
        /// </summary>
        public int TryInflictShadowHoldStatus
        {
            get
            {
                if (f_tryInflictShadowHoldStatus)
                    return _tryInflictShadowHoldStatus;
                _tryInflictShadowHoldStatus = (int) (224136);
                f_tryInflictShadowHoldStatus = true;
                return _tryInflictShadowHoldStatus;
            }
        }
        private bool f_getEntityMoveTargetAndRange;
        private int _getEntityMoveTargetAndRange;

        /// <summary>
        /// Gets the move target-and-range field when used by a given entity. See struct move_target_and_range in the C headers.
        /// 
        /// r0: entity pointer
        /// r1: move pointer
        /// r2: AI flag (same as GetMoveTargetAndRange)
        /// return: move target and range
        /// </summary>
        public int GetEntityMoveTargetAndRange
        {
            get
            {
                if (f_getEntityMoveTargetAndRange)
                    return _getEntityMoveTargetAndRange;
                _getEntityMoveTargetAndRange = (int) (256156);
                f_getEntityMoveTargetAndRange = true;
                return _getEntityMoveTargetAndRange;
            }
        }
        private bool f_generateMazeRoom;
        private int _generateMazeRoom;

        /// <summary>
        /// Possibly generate a maze room on the floor.
        /// 
        /// A maze room will be generated with a probability determined by the maze room chance parameter. A maze will be generated in a random room that is valid, connected, has odd dimensions, and has no other features.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: maze room chance (percentage from 0-100)
        /// </summary>
        public int GenerateMazeRoom
        {
            get
            {
                if (f_generateMazeRoom)
                    return _generateMazeRoom;
                _generateMazeRoom = (int) (408836);
                f_generateMazeRoom = true;
                return _generateMazeRoom;
            }
        }
        private bool f_performDamageSequence;
        private int _performDamageSequence;

        /// <summary>
        /// Performs the &quot;damage sequence&quot; given the results of the damage calculation. This includes running the accuracy roll with MoveHitCheck, calling ApplyDamageAndEffects, and some other miscellaneous bits of state bookkeeping (including handling the effects of Illuminate).
        /// 
        /// This is the last function called by DealDamage. The result of this call is the return value of DealDamage and its relatives.
        /// 
        /// r0: Attacker pointer
        /// r1: Defender pointer
        /// r2: Move pointer
        /// r3: [output] struct containing info about the damage calculation
        /// stack[0]: Damage source
        /// return: Calculated damage
        /// </summary>
        public int PerformDamageSequence
        {
            get
            {
                if (f_performDamageSequence)
                    return _performDamageSequence;
                _performDamageSequence = (int) (354428);
                f_performDamageSequence = true;
                return _performDamageSequence;
            }
        }
        private bool f_levelUpItemEffect;
        private int _levelUpItemEffect;

        /// <summary>
        /// Attempts to level up the target. Calls LevelUp with a few extra checks and messages
        /// for using as an item. Used for the Joy Seed and Golden Seed.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of levels
        /// r3: bool message flag?
        /// stack[0]: bool show level up dialogue (for example &quot;Hey, I leveled up!&quot; with a portrait)?
        /// </summary>
        public int LevelUpItemEffect
        {
            get
            {
                if (f_levelUpItemEffect)
                    return _levelUpItemEffect;
                _levelUpItemEffect = (int) (157388);
                f_levelUpItemEffect = true;
                return _levelUpItemEffect;
            }
        }
        private bool f_tryInflictBadlyPoisonedStatus;
        private int _tryInflictBadlyPoisonedStatus;

        /// <summary>
        /// Inflicts the Badly Poisoned status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictBadlyPoisonedStatus
        {
            get
            {
                if (f_tryInflictBadlyPoisonedStatus)
                    return _tryInflictBadlyPoisonedStatus;
                _tryInflictBadlyPoisonedStatus = (int) (222548);
                f_tryInflictBadlyPoisonedStatus = true;
                return _tryInflictBadlyPoisonedStatus;
            }
        }
        private bool f_isDestinationFloorWithFleeingOutlaw;
        private int _isDestinationFloorWithFleeingOutlaw;

        /// <summary>
        /// Checks if the current floor is a mission destination floor with a &quot;fleeing outlaw&quot; that runs away.
        /// 
        /// return: bool
        /// </summary>
        public int IsDestinationFloorWithFleeingOutlaw
        {
            get
            {
                if (f_isDestinationFloorWithFleeingOutlaw)
                    return _isDestinationFloorWithFleeingOutlaw;
                _isDestinationFloorWithFleeingOutlaw = (int) (446512);
                f_isDestinationFloorWithFleeingOutlaw = true;
                return _isDestinationFloorWithFleeingOutlaw;
            }
        }
        private bool f_applyVileSeedEffect;
        private int _applyVileSeedEffect;

        /// <summary>
        /// Reduces the targets defense and special defense stages to the lowest level.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// </summary>
        public int ApplyVileSeedEffect
        {
            get
            {
                if (f_applyVileSeedEffect)
                    return _applyVileSeedEffect;
                _applyVileSeedEffect = (int) (264556);
                f_applyVileSeedEffect = true;
                return _applyVileSeedEffect;
            }
        }
        private bool f_loadTextureUi;
        private int _loadTextureUi;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int LoadTextureUi
        {
            get
            {
                if (f_loadTextureUi)
                    return _loadTextureUi;
                _loadTextureUi = (int) (365004);
                f_loadTextureUi = true;
                return _loadTextureUi;
            }
        }
        private bool f_checkNonLeaderTile;
        private int _checkNonLeaderTile;

        /// <summary>
        /// Similar to CheckLeaderTile, but for other monsters.
        /// 
        /// Used both for enemies and team members.
        /// 
        /// r0: Entity pointer
        /// </summary>
        public int CheckNonLeaderTile
        {
            get
            {
                if (f_checkNonLeaderTile)
                    return _checkNonLeaderTile;
                _checkNonLeaderTile = (int) (168708);
                f_checkNonLeaderTile = true;
                return _checkNonLeaderTile;
            }
        }
        private bool f_positionHasMonster;
        private int _positionHasMonster;

        /// <summary>
        /// Checks if the tile at the position has a monster on it.
        /// 
        /// r0: Position to check
        /// return: bool
        /// </summary>
        public int PositionHasMonster
        {
            get
            {
                if (f_positionHasMonster)
                    return _positionHasMonster;
                _positionHasMonster = (int) (374348);
                f_positionHasMonster = true;
                return _positionHasMonster;
            }
        }
        private bool f_inflictSleepStatusSingle;
        private int _inflictSleepStatusSingle;

        /// <summary>
        /// This is called by TryInflictSleepStatus.
        /// 
        /// r0: entity pointer
        /// r1: number of turns
        /// </summary>
        public int InflictSleepStatusSingle
        {
            get
            {
                if (f_inflictSleepStatusSingle)
                    return _inflictSleepStatusSingle;
                _inflictSleepStatusSingle = (int) (218204);
                f_inflictSleepStatusSingle = true;
                return _inflictSleepStatusSingle;
            }
        }
        private bool f_restoreOneMovePp;
        private int _restoreOneMovePp;

        /// <summary>
        /// Restores the PP the target's move in the specified move slot by the specified amount.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: move index
        /// r3: PP to restore
        /// stack[0]: flag to log message
        /// </summary>
        public int RestoreOneMovePp
        {
            get
            {
                if (f_restoreOneMovePp)
                    return _restoreOneMovePp;
                _restoreOneMovePp = (int) (244040);
                f_restoreOneMovePp = true;
                return _restoreOneMovePp;
            }
        }
        private bool f_shouldRunMonsterAi;
        private int _shouldRunMonsterAi;

        /// <summary>
        /// Checks a monster's monster_behavior to see whether or not the monster should use AI. Only called on monsters with
        /// a monster_behavior greater than or equal to BEHAVIOR_FIXED_ENEMY. Returns false for BEHAVIOR_FIXED_ENEMY, 
        /// BEHAVIOR_WANDERING_ENEMY_0x8, BEHAVIOR_SECRET_BAZAAR_KIRLIA, BEHAVIOR_SECRET_BAZAAR_MIME_JR,
        /// BEHAVIOR_SECRET_BAZAAR_SWALOT, BEHAVIOR_SECRET_BAZAAR_LICKILICKY, and BEHAVIOR_SECRET_BAZAAR_SHEDINJA.
        /// 
        /// r0: monster entity pointer
        /// return: bool
        /// </summary>
        public int ShouldRunMonsterAi
        {
            get
            {
                if (f_shouldRunMonsterAi)
                    return _shouldRunMonsterAi;
                _shouldRunMonsterAi = (int) (79632);
                f_shouldRunMonsterAi = true;
                return _shouldRunMonsterAi;
            }
        }
        private bool f_mewSpawnCheck;
        private int _mewSpawnCheck;

        /// <summary>
        /// If the monster id parameter is 0x97 (Mew), returns false if either dungeon::mew_cannot_spawn or the second parameter are true.
        /// 
        /// Called before spawning an enemy, appears to be checking if Mew can spawn on the current floor.
        /// 
        /// r0: monster id
        /// r1: return false if the monster id is Mew
        /// return: bool
        /// </summary>
        public int MewSpawnCheck
        {
            get
            {
                if (f_mewSpawnCheck)
                    return _mewSpawnCheck;
                _mewSpawnCheck = (int) (123576);
                f_mewSpawnCheck = true;
                return _mewSpawnCheck;
            }
        }
        private bool f_trySpawnMonsterAndTickSpawnCounter;
        private int _trySpawnMonsterAndTickSpawnCounter;

        /// <summary>
        /// First ticks up the spawn counter, and if it's equal or greater than the spawn cooldown, it will try to spawn an enemy if the number of enemies is below the spawn cap.
        /// 
        /// If the spawn counter is greater than 900, it will instead perform the special spawn caused by the ability Illuminate.
        /// 
        /// No params.
        /// </summary>
        public int TrySpawnMonsterAndTickSpawnCounter
        {
            get
            {
                if (f_trySpawnMonsterAndTickSpawnCounter)
                    return _trySpawnMonsterAndTickSpawnCounter;
                _trySpawnMonsterAndTickSpawnCounter = (int) (205592);
                f_trySpawnMonsterAndTickSpawnCounter = true;
                return _trySpawnMonsterAndTickSpawnCounter;
            }
        }
        private bool f_getTeamMemberIndex;
        private int _getTeamMemberIndex;

        /// <summary>
        /// Given a pointer to an entity, returns its index on the entity list, or null if the entity can't be found on the first 4 slots of the list.
        /// 
        /// r0: Pointer to the entity to find
        /// return: Index of the specified entity on the entity list, or null if it's not on the first 4 slots.
        /// </summary>
        public int GetTeamMemberIndex
        {
            get
            {
                if (f_getTeamMemberIndex)
                    return _getTeamMemberIndex;
                _getTeamMemberIndex = (int) (26604);
                f_getTeamMemberIndex = true;
                return _getTeamMemberIndex;
            }
        }
        private bool f_generateOneRoomMonsterHouseFloor;
        private int _generateOneRoomMonsterHouseFloor;

        /// <summary>
        /// Generates a floor layout with just a large, one-room Monster House.
        /// 
        /// This is the default layout if dungeon generation fails.
        /// 
        /// No params.
        /// </summary>
        public int GenerateOneRoomMonsterHouseFloor
        {
            get
            {
                if (f_generateOneRoomMonsterHouseFloor)
                    return _generateOneRoomMonsterHouseFloor;
                _generateOneRoomMonsterHouseFloor = (int) (393812);
                f_generateOneRoomMonsterHouseFloor = true;
                return _generateOneRoomMonsterHouseFloor;
            }
        }
        private bool f_isAdjacentToEnemy;
        private int _isAdjacentToEnemy;

        /// <summary>
        /// Called to check if a hostile entity is present in any of the tiles adjacent to an entity.
        /// 
        /// r0: Pointer to entity
        /// return: True if yes, false if no
        /// </summary>
        public int IsAdjacentToEnemy
        {
            get
            {
                if (f_isAdjacentToEnemy)
                    return _isAdjacentToEnemy;
                _isAdjacentToEnemy = (int) (271548);
                f_isAdjacentToEnemy = true;
                return _isAdjacentToEnemy;
            }
        }
        private bool f_lowerOffensiveStat;
        private int _lowerOffensiveStat;

        /// <summary>
        /// Lowers the specified offensive stat on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: number of stages
        /// stack[0]: flag to check for being protected from stat drops
        /// stack[1]: flag to log a message on failure for IsProtectedFromStatDrops
        /// </summary>
        public int LowerOffensiveStat
        {
            get
            {
                if (f_lowerOffensiveStat)
                    return _lowerOffensiveStat;
                _lowerOffensiveStat = (int) (225800);
                f_lowerOffensiveStat = true;
                return _lowerOffensiveStat;
            }
        }
        private bool f_shouldUsePp;
        private int _shouldUsePp;

        /// <summary>
        /// Checks if a monster should use PP when using a move. It also displays the corresponding animation if PP Saver triggers and prints the required messages to the message log.
        /// 
        /// r0: entity pointer
        /// return: True if the monster should not use PP, false if it should.
        /// </summary>
        public int ShouldUsePp
        {
            get
            {
                if (f_shouldUsePp)
                    return _shouldUsePp;
                _shouldUsePp = (int) (254864);
                f_shouldUsePp = true;
                return _shouldUsePp;
            }
        }
        private bool f_tryActivateFlashFireOnAllMonsters;
        private int _tryActivateFlashFireOnAllMonsters;

        /// <summary>
        /// Checks every monster for apply_flash_fire_boost. If it's true, activates Flash Fire for the monster and sets
        /// apply_flash_fire_boost back to false.
        /// 
        /// No params.
        /// </summary>
        public int TryActivateFlashFireOnAllMonsters
        {
            get
            {
                if (f_tryActivateFlashFireOnAllMonsters)
                    return _tryActivateFlashFireOnAllMonsters;
                _tryActivateFlashFireOnAllMonsters = (int) (142456);
                f_tryActivateFlashFireOnAllMonsters = true;
                return _tryActivateFlashFireOnAllMonsters;
            }
        }
        private bool f_getItemInfo;
        private int _getItemInfo;

        /// <summary>
        /// Given an item entity, returns the pointer to the item info struct it contains.
        /// 
        /// r0: Entity pointer
        /// return: Item data pointer
        /// </summary>
        public int GetItemInfo
        {
            get
            {
                if (f_getItemInfo)
                    return _getItemInfo;
                _getItemInfo = (int) (21440);
                f_getItemInfo = true;
                return _getItemInfo;
            }
        }
        private bool f_initOtherMonsterData;
        private int _initOtherMonsterData;

        /// <summary>
        /// Initializes stats, IQ skills and moves for a given monster
        /// 
        /// Might only be used when spawning fixed room monsters.
        /// 
        /// r0: Entity pointer
        /// r1: Fixed room monster stats index
        /// r2: Spawn direction? (when calling this function while spawning a fixed room monster, this is the parameter value associated to the spawn action, after converting it to a direction.)
        /// </summary>
        public int InitOtherMonsterData
        {
            get
            {
                if (f_initOtherMonsterData)
                    return _initOtherMonsterData;
                _initOtherMonsterData = (int) (129384);
                f_initOtherMonsterData = true;
                return _initOtherMonsterData;
            }
        }
        private bool f_dungeonRngSetPrimary;
        private int _dungeonRngSetPrimary;

        /// <summary>
        /// Sets the dungeon PRNG to use the primary LCG for subsequent random number generation.
        /// 
        /// No params.
        /// </summary>
        public int DungeonRngSetPrimary
        {
            get
            {
                if (f_dungeonRngSetPrimary)
                    return _dungeonRngSetPrimary;
                _dungeonRngSetPrimary = (int) (59884);
                f_dungeonRngSetPrimary = true;
                return _dungeonRngSetPrimary;
            }
        }
        private bool f_applyRandomTrapEffect;
        private int _applyRandomTrapEffect;

        /// <summary>
        /// Selects a random trap that isn't a wonder tile and isn't a random trap and calls
        /// ApplyTrapEffect on all monsters that is different from the trap's team.
        /// 
        /// r0: Triggered trap
        /// r1: User
        /// r2: Target, normally same as user
        /// r3: Tile that contains the trap
        /// stack[0]: position
        /// </summary>
        public int ApplyRandomTrapEffect
        {
            get
            {
                if (f_applyRandomTrapEffect)
                    return _applyRandomTrapEffect;
                _applyRandomTrapEffect = (int) (76896);
                f_applyRandomTrapEffect = true;
                return _applyRandomTrapEffect;
            }
        }
        private bool f_tryAddTargetToAiTargetList;
        private int _tryAddTargetToAiTargetList;

        /// <summary>
        /// Checks if the specified target is eligible to be targeted by the AI and if so adds it to the list of targets. This function also fills an array that seems to contain the directions in which the user should turn to look at each of the targets in the list, as well as a third unknown array.
        /// 
        /// r0: Number of existing targets in the list
        /// r1: Move's AI range field
        /// r2: User entity pointer
        /// r3: Target entity pointer
        /// stack[0]: Move pointer
        /// stack[1]: check_all_conditions parameter to pass to IsAiTargetEligible
        /// return: New number of targets in the target list
        /// </summary>
        public int TryAddTargetToAiTargetList
        {
            get
            {
                if (f_tryAddTargetToAiTargetList)
                    return _tryAddTargetToAiTargetList;
                _tryAddTargetToAiTargetList = (int) (252832);
                f_tryAddTargetToAiTargetList = true;
                return _tryAddTargetToAiTargetList;
            }
        }
        private bool f_tryRemoveTrap;
        private int _tryRemoveTrap;

        /// <summary>
        /// Tries to remove a trap from the tile at the passed position. It does nothing
        /// if there is no trap on the tile at that position.
        /// 
        /// r0: position
        /// r1: bool update trap visibility
        /// return: whether a trap was succesfully removed or not
        /// </summary>
        public int TryRemoveTrap
        {
            get
            {
                if (f_tryRemoveTrap)
                    return _tryRemoveTrap;
                _tryRemoveTrap = (int) (72704);
                f_tryRemoveTrap = true;
                return _tryRemoveTrap;
            }
        }
        private bool f_tryInflictSureShotStatus;
        private int _tryInflictSureShotStatus;

        /// <summary>
        /// Inflicts the Sure Shot status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictSureShotStatus
        {
            get
            {
                if (f_tryInflictSureShotStatus)
                    return _tryInflictSureShotStatus;
                _tryInflictSureShotStatus = (int) (235368);
                f_tryInflictSureShotStatus = true;
                return _tryInflictSureShotStatus;
            }
        }
        private bool f_tryInflictProtectStatus;
        private int _tryInflictProtectStatus;

        /// <summary>
        /// Inflicts the Protect status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictProtectStatus
        {
            get
            {
                if (f_tryInflictProtectStatus)
                    return _tryInflictProtectStatus;
                _tryInflictProtectStatus = (int) (249372);
                f_tryInflictProtectStatus = true;
                return _tryInflictProtectStatus;
            }
        }
        private bool f_getTypeMatchupBothTypes;
        private int _getTypeMatchupBothTypes;

        /// <summary>
        /// Gets the type matchup for a given combat interaction, accounting for both of the user's types.
        /// 
        /// Calls GetTypeMatchup twice and combines the result.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: attack type
        /// return: enum type_matchup
        /// </summary>
        public int GetTypeMatchupBothTypes
        {
            get
            {
                if (f_getTypeMatchupBothTypes)
                    return _getTypeMatchupBothTypes;
                _getTypeMatchupBothTypes = (int) (190244);
                f_getTypeMatchupBothTypes = true;
                return _getTypeMatchupBothTypes;
            }
        }
        private bool f_getOutlawSpawnData;
        private int _getOutlawSpawnData;

        /// <summary>
        /// Gets outlaw spawn data for the current floor.
        /// 
        /// r0: [output] Outlaw spawn data
        /// </summary>
        public int GetOutlawSpawnData
        {
            get
            {
                if (f_getOutlawSpawnData)
                    return _getOutlawSpawnData;
                _getOutlawSpawnData = (int) (139048);
                f_getOutlawSpawnData = true;
                return _getOutlawSpawnData;
            }
        }
        private bool f_isNotFullFloorFixedRoom;
        private int _isNotFullFloorFixedRoom;

        /// <summary>
        /// Checks if a fixed room ID does not correspond to a fixed, full-floor layout.
        /// 
        /// The first non-full-floor fixed room is 0xA5, which is for Sealed Chambers.
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int IsNotFullFloorFixedRoom
        {
            get
            {
                if (f_isNotFullFloorFixedRoom)
                    return _isNotFullFloorFixedRoom;
                _isNotFullFloorFixedRoom = (int) (392692);
                f_isNotFullFloorFixedRoom = true;
                return _isNotFullFloorFixedRoom;
            }
        }
        private bool f_categoryIsNotPhysical;
        private int _categoryIsNotPhysical;

        /// <summary>
        /// Checks that a move category is not CATEGORY_PHYSICAL.
        /// 
        /// r0: move category ID
        /// return: bool
        /// </summary>
        public int CategoryIsNotPhysical
        {
            get
            {
                if (f_categoryIsNotPhysical)
                    return _categoryIsNotPhysical;
                _categoryIsNotPhysical = (int) (271868);
                f_categoryIsNotPhysical = true;
                return _categoryIsNotPhysical;
            }
        }
        private bool f_getTile;
        private int _getTile;

        /// <summary>
        /// Get the tile at some position. If the coordinates are out of bounds, returns a default tile.
        /// 
        /// r0: x position
        /// r1: y position
        /// return: tile pointer
        /// </summary>
        public int GetTile
        {
            get
            {
                if (f_getTile)
                    return _getTile;
                _getTile = (int) (367596);
                f_getTile = true;
                return _getTile;
            }
        }
        private bool f_getTrapInfo;
        private int _getTrapInfo;

        /// <summary>
        /// Given a trap entity, returns the pointer to the trap info struct it contains.
        /// 
        /// r0: Entity pointer
        /// return: Trap data pointer
        /// </summary>
        public int GetTrapInfo
        {
            get
            {
                if (f_getTrapInfo)
                    return _getTrapInfo;
                _getTrapInfo = (int) (21432);
                f_getTrapInfo = true;
                return _getTrapInfo;
            }
        }
        private bool f_applyZincEffect;
        private int _applyZincEffect;

        /// <summary>
        /// Tries to boost the target's special defense stat.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: special defense boost
        /// </summary>
        public int ApplyZincEffect
        {
            get
            {
                if (f_applyZincEffect)
                    return _applyZincEffect;
                _applyZincEffect = (int) (244988);
                f_applyZincEffect = true;
                return _applyZincEffect;
            }
        }
        private bool f_logMessageQuiet;
        private int _logMessageQuiet;

        /// <summary>
        /// Logs a message in the message log (but without a message popup).
        /// 
        /// r0: user entity pointer
        /// r1: message string
        /// </summary>
        public int LogMessageQuiet
        {
            get
            {
                if (f_logMessageQuiet)
                    return _logMessageQuiet;
                _logMessageQuiet = (int) (453840);
                f_logMessageQuiet = true;
                return _logMessageQuiet;
            }
        }
        private bool f_tryEatItem;
        private int _tryEatItem;

        /// <summary>
        /// The user attempts to eat an item from the target.
        /// 
        /// The function tries to eat the target's held item first. If that's not possible and the target is part of the team, it attempts to eat a random edible item from the bag instead.
        /// Fun fact: The code used to select the random bag item that will be eaten is poorly coded. As a result, there's a small chance of the first edible item in the bag being picked instead of a random one. The exact chance of this happening is (N/B)^B, where N is the amount of non-edible items in the bag and B is the total amount of items in the bag.
        /// 
        /// r0: User
        /// r1: Target
        /// return: True if the attempt was successful
        /// </summary>
        public int TryEatItem
        {
            get
            {
                if (f_tryEatItem)
                    return _tryEatItem;
                _tryEatItem = (int) (126652);
                f_tryEatItem = true;
                return _tryEatItem;
            }
        }
        private bool f_getItemAction;
        private int _getItemAction;

        /// <summary>
        /// Returns the action ID that corresponds to an item given its ID.
        /// 
        /// The action is based on the category of the item (see ITEM_CATEGORY_ACTIONS), unless the specified ID is 0x16B, in which case ACTION_UNK_35 is returned.
        /// Some items can have unexpected actions, such as thrown items, which have ACTION_NOTHING. This is done to prevent duplicate actions from being listed in the menu (since items always have a &quot;throw&quot; option), since a return value of ACTION_NOTHING prevents the option from showing up in the menu.
        /// 
        /// r0: Item ID
        /// return: Action ID associated with the specified item
        /// </summary>
        public int GetItemAction
        {
            get
            {
                if (f_getItemAction)
                    return _getItemAction;
                _getItemAction = (int) (62304);
                f_getItemAction = true;
                return _getItemAction;
            }
        }
        private bool f_tryInflictMagicCoatStatus;
        private int _tryInflictMagicCoatStatus;

        /// <summary>
        /// Inflicts the Magic Coat status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictMagicCoatStatus
        {
            get
            {
                if (f_tryInflictMagicCoatStatus)
                    return _tryInflictMagicCoatStatus;
                _tryInflictMagicCoatStatus = (int) (248892);
                f_tryInflictMagicCoatStatus = true;
                return _tryInflictMagicCoatStatus;
            }
        }
        private bool f_dungeonRandRange;
        private int _dungeonRandRange;

        /// <summary>
        /// Compute a pseudorandom value between two integers using the dungeon PRNG.
        /// 
        /// If both input integers are the same, the first is returned.
        /// 
        /// r0: x
        /// r1: y
        /// return: pseudorandom integer on the interval [min(x, y), max(x, y) - 1], or x if x == y.
        /// </summary>
        public int DungeonRandRange
        {
            get
            {
                if (f_dungeonRandRange)
                    return _dungeonRandRange;
                _dungeonRandRange = (int) (59464);
                f_dungeonRandRange = true;
                return _dungeonRandRange;
            }
        }
        private bool f_generateBeetleFloor;
        private int _generateBeetleFloor;

        /// <summary>
        /// Generates a floor layout in a &quot;beetle&quot; formation, which is created by taking a 3x3 grid of rooms, connecting the rooms within each row, and merging the central column into one big room.
        /// 
        /// r0: floor properties
        /// </summary>
        public int GenerateBeetleFloor
        {
            get
            {
                if (f_generateBeetleFloor)
                    return _generateBeetleFloor;
                _generateBeetleFloor = (int) (391256);
                f_generateBeetleFloor = true;
                return _generateBeetleFloor;
            }
        }
        private bool f_boostDefensiveStat;
        private int _boostDefensiveStat;

        /// <summary>
        /// Boosts the specified defensive stat on the target monster.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: stat index
        /// r3: number of stages
        /// </summary>
        public int BoostDefensiveStat
        {
            get
            {
                if (f_boostDefensiveStat)
                    return _boostDefensiveStat;
                _boostDefensiveStat = (int) (227088);
                f_boostDefensiveStat = true;
                return _boostDefensiveStat;
            }
        }
        private bool f_updateMovePp;
        private int _updateMovePp;

        /// <summary>
        /// Updates the PP of any moves that were used by a monster, if PP should be consumed.
        /// 
        /// r0: entity pointer
        /// r1: flag for whether or not PP should be consumed
        /// </summary>
        public int UpdateMovePp
        {
            get
            {
                if (f_updateMovePp)
                    return _updateMovePp;
                _updateMovePp = (int) (297272);
                f_updateMovePp = true;
                return _updateMovePp;
            }
        }
        private bool f_endReflectClassStatus;
        private int _endReflectClassStatus;

        /// <summary>
        /// Removes the target's reflect, safeguard, light screen, counter, magic coat, wish, protect, mirror coat, endure, mini counter?, mirror move, conversion 2, vital throw, mist, metal burst, aqua ring or lucky chant status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndReflectClassStatus
        {
            get
            {
                if (f_endReflectClassStatus)
                    return _endReflectClassStatus;
                _endReflectClassStatus = (int) (172356);
                f_endReflectClassStatus = true;
                return _endReflectClassStatus;
            }
        }
        private bool f_dungeonRngUnsetSecondary;
        private int _dungeonRngUnsetSecondary;

        /// <summary>
        /// Sets the dungeon PRNG to use the primary LCG for subsequent random number generation, and also resets the secondary LCG index back to 0.
        /// 
        /// Similar to DungeonRngSetPrimary, but DungeonRngSetPrimary doesn't modify the secondary LCG index if it was already set to something other than 0.
        /// 
        /// No params.
        /// </summary>
        public int DungeonRngUnsetSecondary
        {
            get
            {
                if (f_dungeonRngUnsetSecondary)
                    return _dungeonRngUnsetSecondary;
                _dungeonRngUnsetSecondary = (int) (59836);
                f_dungeonRngUnsetSecondary = true;
                return _dungeonRngUnsetSecondary;
            }
        }
        private bool f_tryInflictLuckyChantStatus;
        private int _tryInflictLuckyChantStatus;

        /// <summary>
        /// Inflicts the Lucky Chant status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictLuckyChantStatus
        {
            get
            {
                if (f_tryInflictLuckyChantStatus)
                    return _tryInflictLuckyChantStatus;
                _tryInflictLuckyChantStatus = (int) (246008);
                f_tryInflictLuckyChantStatus = true;
                return _tryInflictLuckyChantStatus;
            }
        }
        private bool f_calcSpeedStage;
        private int _calcSpeedStage;

        /// <summary>
        /// Calculates the speed stage of a monster from its speed up/down counters. The second parameter is the weight of each counter (how many stages it will add/remove), but appears to be always 1. 
        /// Takes modifiers into account (paralysis, snowy weather, Time Tripper). Deoxys-speed, Shaymin-sky and enemy Kecleon during a thief alert get a flat +1 always.
        /// 
        /// The calculated speed stage is both returned and saved in the monster's statuses struct.
        /// 
        /// r0: pointer to entity
        /// r1: speed counter weight
        /// return: speed stage
        /// </summary>
        public int CalcSpeedStage
        {
            get
            {
                if (f_calcSpeedStage)
                    return _calcSpeedStage;
                _calcSpeedStage = (int) (145732);
                f_calcSpeedStage = true;
                return _calcSpeedStage;
            }
        }
        private bool f_initEnemyStatsAndMoves;
        private int _initEnemyStatsAndMoves;

        /// <summary>
        /// Initializes the HP, Atk, Sp. Atk, Def, Sp. Def and moveset of a newly spawned enemy. Might do something else too.
        /// 
        /// r0: Pointer to the monster's move list
        /// r1: Pointer to the monster's current HP
        /// r2: Pointer to the monster's offensive stats
        /// r3: Pointer to the monster's defensive stats
        /// </summary>
        public int InitEnemyStatsAndMoves
        {
            get
            {
                if (f_initEnemyStatsAndMoves)
                    return _initEnemyStatsAndMoves;
                _initEnemyStatsAndMoves = (int) (130372);
                f_initEnemyStatsAndMoves = true;
                return _initEnemyStatsAndMoves;
            }
        }
        private bool f_discoverMinimap;
        private int _discoverMinimap;

        /// <summary>
        /// Discovers the tiles around the specified position on the minimap.
        /// 
        /// The discovery radius depends on the visibility range of the floor. If display_data::blinded is true, the function returns early without doing anything.
        /// 
        /// r0: Position around which the map should be discovered
        /// </summary>
        public int DiscoverMinimap
        {
            get
            {
                if (f_discoverMinimap)
                    return _discoverMinimap;
                _discoverMinimap = (int) (374048);
                f_discoverMinimap = true;
                return _discoverMinimap;
            }
        }
        private bool f_isWaterTileset;
        private int _isWaterTileset;

        /// <summary>
        /// Returns flag tileset_property::is_water_tileset for the current tileset
        /// 
        /// return: True if the current tileset is a water tileset
        /// </summary>
        public int IsWaterTileset
        {
            get
            {
                if (f_isWaterTileset)
                    return _isWaterTileset;
                _isWaterTileset = (int) (375160);
                f_isWaterTileset = true;
                return _isWaterTileset;
            }
        }
        private bool f_getDefensiveStatAtLevel;
        private int _getDefensiveStatAtLevel;

        /// <summary>
        /// Returns the Def / Sp. Def of a monster given its level, capped to 255.
        /// 
        /// r0: Monster ID
        /// r1: Monster level
        /// r2: Stat index (0: Def, 1: Sp. Def)
        /// return: Def / Sp. Def at the given level
        /// </summary>
        public int GetDefensiveStatAtLevel
        {
            get
            {
                if (f_getDefensiveStatAtLevel)
                    return _getDefensiveStatAtLevel;
                _getDefensiveStatAtLevel = (int) (138944);
                f_getDefensiveStatAtLevel = true;
                return _getDefensiveStatAtLevel;
            }
        }
        private bool f_tryForcedLoss;
        private int _tryForcedLoss;

        /// <summary>
        /// Attempts to trigger a forced loss of the type specified in dungeon::forced_loss_reason.
        /// 
        /// r0: if true, the function will not check for the end of the floor condition and will skip other (unknown) actions in case of forced loss.
        /// return: true if the forced loss happens, false otherwise
        /// </summary>
        public int TryForcedLoss
        {
            get
            {
                if (f_tryForcedLoss)
                    return _tryForcedLoss;
                _tryForcedLoss = (int) (17356);
                f_tryForcedLoss = true;
                return _tryForcedLoss;
            }
        }
        private bool f_setMonsterActionFields;
        private int _setMonsterActionFields;

        /// <summary>
        /// Sets some the fields related to AI in the monster's data struct.
        /// Specifically, monster::action::action_id, monster::action::action_use_idx and monster::action::field_0xA. The last 2 are always set to 0.
        /// 
        /// r0: Pointer to the monster's action field
        /// r1: Value to set monster::action::action_id to.
        /// </summary>
        public int SetMonsterActionFields
        {
            get
            {
                if (f_setMonsterActionFields)
                    return _setMonsterActionFields;
                _setMonsterActionFields = (int) (61840);
                f_setMonsterActionFields = true;
                return _setMonsterActionFields;
            }
        }
        private bool f_tryInflictConstrictionStatus;
        private int _tryInflictConstrictionStatus;

        /// <summary>
        /// Inflicts the Constriction status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: animation ID
        /// r3: flag to log a message on failure
        /// </summary>
        public int TryInflictConstrictionStatus
        {
            get
            {
                if (f_tryInflictConstrictionStatus)
                    return _tryInflictConstrictionStatus;
                _tryInflictConstrictionStatus = (int) (223792);
                f_tryInflictConstrictionStatus = true;
                return _tryInflictConstrictionStatus;
            }
        }
        private bool f_changeLeader;
        private int _changeLeader;

        /// <summary>
        /// Tries to change the current leader to the monster specified by dungeon::new_leader.
        /// 
        /// Accounts for situations that can prevent changing leaders, such as having stolen from a Kecleon shop. If one of those situations prevents changing leaders, prints the corresponding message to the message log.
        /// 
        /// No params.
        /// </summary>
        public int ChangeLeader
        {
            get
            {
                if (f_changeLeader)
                    return _changeLeader;
                _changeLeader = (int) (95820);
                f_changeLeader = true;
                return _changeLeader;
            }
        }
        private bool f_targetRegularAttack;
        private int _targetRegularAttack;

        /// <summary>
        /// Decides which direction the AI will use its regular attack in.
        /// 
        /// r0: User entity pointer
        /// r1: [output] direction that the regular attack should be targeted at.
        /// r2: If true, the AI will ignore enemies that are petrified. If false, the AI will include petrified enemies when targeting.
        /// return: True if there is a target for the regular attack, false if there is no target.
        /// </summary>
        public int TargetRegularAttack
        {
            get
            {
                if (f_targetRegularAttack)
                    return _targetRegularAttack;
                _targetRegularAttack = (int) (254032);
                f_targetRegularAttack = true;
                return _targetRegularAttack;
            }
        }
        private bool f_logMessageByIdWithPopupCheckParticipants;
        private int _logMessageByIdWithPopupCheckParticipants;

        /// <summary>
        /// Logs the appropriate message based on the participating entites; this function calls LogMessageByIdWithPopupCheckUserTarget is both the user and target pointers are non-null, otherwise it calls LogMessageByIdWithPopupCheckUser if the user pointer is non-null, otherwise doesn't log anything.
        /// 
        /// This function also seems to set some global table entry to some value?
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: message ID
        /// r3: index into some table?
        /// stack[0]: value to set at the table index specified by r3?
        /// </summary>
        public int LogMessageByIdWithPopupCheckParticipants
        {
            get
            {
                if (f_logMessageByIdWithPopupCheckParticipants)
                    return _logMessageByIdWithPopupCheckParticipants;
                _logMessageByIdWithPopupCheckParticipants = (int) (453600);
                f_logMessageByIdWithPopupCheckParticipants = true;
                return _logMessageByIdWithPopupCheckParticipants;
            }
        }
        private bool f_getMonsterIdToSpawn;
        private int _getMonsterIdToSpawn;

        /// <summary>
        /// Randomly picks a monster to spawn using the floor's monster spawn list and returns its ID.
        /// 
        /// r0: the spawn weight to use (0 for normal, 1 for monster house)
        /// return: monster ID
        /// </summary>
        public int GetMonsterIdToSpawn
        {
            get
            {
                if (f_getMonsterIdToSpawn)
                    return _getMonsterIdToSpawn;
                _getMonsterIdToSpawn = (int) (47912);
                f_getMonsterIdToSpawn = true;
                return _getMonsterIdToSpawn;
            }
        }
        private bool f_setAquaRingHealingCountdownTo4;
        private int _setAquaRingHealingCountdownTo4;

        /// <summary>
        /// Sets the countdown for Aqua Ring healing countdown to a global value (0x4).
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int SetAquaRingHealingCountdownTo4
        {
            get
            {
                if (f_setAquaRingHealingCountdownTo4)
                    return _setAquaRingHealingCountdownTo4;
                _setAquaRingHealingCountdownTo4 = (int) (245680);
                f_setAquaRingHealingCountdownTo4 = true;
                return _setAquaRingHealingCountdownTo4;
            }
        }
        private bool f_spawnMonster;
        private int _spawnMonster;

        /// <summary>
        /// Spawns the given monster on a tile.
        /// 
        /// r0: pointer to struct spawned_monster_data
        /// r1: if true, the monster cannot spawn asleep, otherwise it will randomly be asleep
        /// return: pointer to entity
        /// </summary>
        public int SpawnMonster
        {
            get
            {
                if (f_spawnMonster)
                    return _spawnMonster;
                _spawnMonster = (int) (134040);
                f_spawnMonster = true;
                return _spawnMonster;
            }
        }
        private bool f_tryInflictIngrainStatus;
        private int _tryInflictIngrainStatus;

        /// <summary>
        /// Inflicts the Ingrain status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictIngrainStatus
        {
            get
            {
                if (f_tryInflictIngrainStatus)
                    return _tryInflictIngrainStatus;
                _tryInflictIngrainStatus = (int) (224572);
                f_tryInflictIngrainStatus = true;
                return _tryInflictIngrainStatus;
            }
        }
        private bool f_allocTopScreenStatus;
        private int _allocTopScreenStatus;

        /// <summary>
        /// Allocates and initializes the top_screen_status struct when entering dungeon mode.
        /// 
        /// No params.
        /// </summary>
        public int AllocTopScreenStatus
        {
            get
            {
                if (f_allocTopScreenStatus)
                    return _allocTopScreenStatus;
                _allocTopScreenStatus = (int) (48204);
                f_allocTopScreenStatus = true;
                return _allocTopScreenStatus;
            }
        }
        private bool f_createHallway;
        private int _createHallway;

        /// <summary>
        /// Create a hallway between two points.
        /// 
        /// If the two points share no coordinates in common (meaning the line connecting them is diagonal), a &quot;kinked&quot; hallway is created, with the kink at a specified &quot;middle&quot; coordinate (in practice the grid cell boundary). For example, with a kinked horizontal hallway, there are two horizontal lines extending out from the endpoints, connected by a vertical line on the middle x coordinate.
        /// 
        /// If a hallway would intersect with an existing open tile (like an existing hallway), the hallway will only be created up to the point where it intersects with the open tile.
        /// 
        /// r0: x0
        /// r1: y0
        /// r2: x1
        /// r3: y1
        /// stack[0]: vertical flag (true for vertical hallway, false for horizontal)
        /// stack[1]: middle x coordinate for kinked horizontal hallways
        /// stack[2]: middle y coordinate for kinked vertical hallways
        /// </summary>
        public int CreateHallway
        {
            get
            {
                if (f_createHallway)
                    return _createHallway;
                _createHallway = (int) (404480);
                f_createHallway = true;
                return _createHallway;
            }
        }
        private bool f_tryEndStatusWithAbility;
        private int _tryEndStatusWithAbility;

        /// <summary>
        /// Checks if any of the defender's active abilities would end one of their current status
        /// conditions. For example, if the ability Own Tempo will stop confusion.
        /// 
        /// Called after changing a monster's ability with skill swap, role play, or trace to
        /// remove statuses the monster should no longer be affected by.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int TryEndStatusWithAbility
        {
            get
            {
                if (f_tryEndStatusWithAbility)
                    return _tryEndStatusWithAbility;
                _tryEndStatusWithAbility = (int) (124068);
                f_tryEndStatusWithAbility = true;
                return _tryEndStatusWithAbility;
            }
        }
        private bool f_generateStandardItem;
        private int _generateStandardItem;

        /// <summary>
        /// Wrapper around GenerateItem with quantity set to 0
        /// 
        /// r0: pointer to item to initialize
        /// r1: item ID
        /// r2: stickiness type
        /// </summary>
        public int GenerateStandardItem
        {
            get
            {
                if (f_generateStandardItem)
                    return _generateStandardItem;
                _generateStandardItem = (int) (427700);
                f_generateStandardItem = true;
                return _generateStandardItem;
            }
        }
        private bool f_tryInflictEndureStatus;
        private int _tryInflictEndureStatus;

        /// <summary>
        /// Inflicts the Endure status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictEndureStatus
        {
            get
            {
                if (f_tryInflictEndureStatus)
                    return _tryInflictEndureStatus;
                _tryInflictEndureStatus = (int) (249704);
                f_tryInflictEndureStatus = true;
                return _tryInflictEndureStatus;
            }
        }
        private bool f_calcDamage;
        private int _calcDamage;

        /// <summary>
        /// The damage calculation function.
        /// 
        /// At a high level, the damage formula is:
        ///   M * [(153/256)*(A + P) - 0.5*D + 50*ln(10*[L + (A - D)/8 + 50]) - 311]
        /// where:
        ///   - A is the offensive stat (attack or special attack) with relevant modifiers applied (stat stages, certain items, certain abilities, etc.)
        ///   - D is the defensive stat (defense or special defense) with relevant modifiers applied (stat stages, certain items, certain abilities, etc.)
        ///   - L is the attacker's level
        ///   - P is the move power with relevant modifiers applied
        ///   - M is an aggregate damage multiplier from a variety of things, such as type-effectiveness, STAB, critical hits (which are also rolled in this function), certain items, certain abilities, certain statuses, etc.
        /// 
        /// The calculations are done primarily with 64-bit fixed point arithmetic, and a bit of 32-bit fixed point arithmetic. There's also rounding/truncation/clamping at various steps in the process.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: attack type
        /// r3: attack power
        /// stack[0]: crit chance
        /// stack[1]: [output] struct containing info about the damage calculation
        /// stack[2]: damage multiplier (as a binary fixed-point number with 8 fraction bits)
        /// stack[3]: move ID
        /// stack[4]: flag to account for certain effects (Flash Fire, Reflect, Light Screen, aura bows, Def. Scarf, Zinc Band). Only ever set to false when computing recoil damage for Jump Kick/Hi Jump Kick missing, which is based on the damage that would have been done if the move didn't miss.
        /// </summary>
        public int CalcDamage
        {
            get
            {
                if (f_calcDamage)
                    return _calcDamage;
                _calcDamage = (int) (194592);
                f_calcDamage = true;
                return _calcDamage;
            }
        }
        private bool f_generateStandardFloor;
        private int _generateStandardFloor;

        /// <summary>
        /// Generate a standard floor with the given parameters.
        /// 
        /// Broadly speaking, a standard floor is generated as follows:
        /// 1. Generating the grid
        /// 2. Creating a room or hallway anchor in each grid cell
        /// 3. Creating hallways between grid cells
        /// 4. Generating special features (maze room, Kecleon shop, Monster House, extra hallways, room imperfections, secondary structures)
        /// 
        /// r0: grid size x
        /// r1: grid size y
        /// r2: floor properties
        /// </summary>
        public int GenerateStandardFloor
        {
            get
            {
                if (f_generateStandardFloor)
                    return _generateStandardFloor;
                _generateStandardFloor = (int) (387852);
                f_generateStandardFloor = true;
                return _generateStandardFloor;
            }
        }
        private bool f_setLeaderAction;
        private int _setLeaderAction;

        /// <summary>
        /// Sets the leader's action field depending on the inputs given by the player.
        /// 
        /// This function also accounts for other special situations that can force a certain action, such as when the leader is running. The function also takes care of opening the main menu when X is pressed.
        /// The function generally doesn't return until the player has an action set.
        /// 
        /// No params.
        /// </summary>
        public int SetLeaderAction
        {
            get
            {
                if (f_setLeaderAction)
                    return _setLeaderAction;
                _setLeaderAction = (int) (84988);
                f_setLeaderAction = true;
                return _setLeaderAction;
            }
        }
        private bool f_startFadeDungeonWrapper;
        private int _startFadeDungeonWrapper;

        /// <summary>
        /// Calls StartFadeDungeon to initiate a screen fade in dungeon mode.
        /// 
        /// Sets the status field in the dungeon_fades struct to the fade type, then uses a switch-case to create a mapping of the status enums to different ones for some reason. This mapped value is then used in the StartFadeDungeon call.
        /// 
        /// r0: Fade type
        /// r1: Change of brightness per frame
        /// r2: Screen to fade
        /// </summary>
        public int StartFadeDungeonWrapper
        {
            get
            {
                if (f_startFadeDungeonWrapper)
                    return _startFadeDungeonWrapper;
                _startFadeDungeonWrapper = (int) (458732);
                f_startFadeDungeonWrapper = true;
                return _startFadeDungeonWrapper;
            }
        }
        private bool f_calcSpeedStageWrapper;
        private int _calcSpeedStageWrapper;

        /// <summary>
        /// Calls CalcSpeedStage with a speed counter weight of 1.
        /// 
        /// r0: pointer to entity
        /// return: speed stage
        /// </summary>
        public int CalcSpeedStageWrapper
        {
            get
            {
                if (f_calcSpeedStageWrapper)
                    return _calcSpeedStageWrapper;
                _calcSpeedStageWrapper = (int) (146076);
                f_calcSpeedStageWrapper = true;
                return _calcSpeedStageWrapper;
            }
        }
        private bool f_reevaluateSnatchMonster;
        private int _reevaluateSnatchMonster;

        /// <summary>
        /// Checks if any monster on the floor has the snatch status and stores the corresponding info
        /// onto the dungeon struct. This is only called when reinitalizing a dungeon from a quicksave.
        /// Normally, the game will try to prevent multiple monsters from having snatch, but will pick
        /// the first one in the list if multiple have the status.
        /// 
        /// No params.
        /// </summary>
        public int ReevaluateSnatchMonster
        {
            get
            {
                if (f_reevaluateSnatchMonster)
                    return _reevaluateSnatchMonster;
                _reevaluateSnatchMonster = (int) (120392);
                f_reevaluateSnatchMonster = true;
                return _reevaluateSnatchMonster;
            }
        }
        private bool f_getMoveRangeDistance;
        private int _getMoveRangeDistance;

        /// <summary>
        /// Returns the maximum reach distance of a move, based on its AI range value.
        /// 
        /// If the move doesn't have an AI range value of RANGE_FRONT_10, RANGE_FRONT_WITH_CORNER_CUTTING or RANGE_FRONT_2_WITH_CORNER_CUTTING, returns 0.
        /// If r2 is true, the move is a two-turn move and the user isn't charging said move, returns 0.
        /// 
        /// r0: User entity pointer
        /// r1: Move pointer
        /// r2: True to perform the two-turn move check
        /// return: Maximum reach distance of the move, in tiles.
        /// </summary>
        public int GetMoveRangeDistance
        {
            get
            {
                if (f_getMoveRangeDistance)
                    return _getMoveRangeDistance;
                _getMoveRangeDistance = (int) (286320);
                f_getMoveRangeDistance = true;
                return _getMoveRangeDistance;
            }
        }
        private bool f_trySpawnGoldenChamber;
        private int _trySpawnGoldenChamber;

        /// <summary>
        /// Changes the tileset and fixed room id of the floor for the Golden Chamber if the floor should be a
        /// Golden Chamber.
        /// 
        /// No params.
        /// </summary>
        public int TrySpawnGoldenChamber
        {
            get
            {
                if (f_trySpawnGoldenChamber)
                    return _trySpawnGoldenChamber;
                _trySpawnGoldenChamber = (int) (367892);
                f_trySpawnGoldenChamber = true;
                return _trySpawnGoldenChamber;
            }
        }
        private bool f_setTerrainObstacleChecked;
        private int _setTerrainObstacleChecked;

        /// <summary>
        /// Set the terrain of a specific tile to be an obstacle (wall or secondary terrain).
        /// 
        /// Secondary terrain (water/lava) can only be placed in the specified room. If the tile room index does not match, a wall will be placed instead.
        /// 
        /// r0: tile pointer
        /// r1: use secondary terrain flag (true for water/lava, false for wall)
        /// r2: room index
        /// </summary>
        public int SetTerrainObstacleChecked
        {
            get
            {
                if (f_setTerrainObstacleChecked)
                    return _setTerrainObstacleChecked;
                _setTerrainObstacleChecked = (int) (406496);
                f_setTerrainObstacleChecked = true;
                return _setTerrainObstacleChecked;
            }
        }
        private bool f_getMissionDestination;
        private int _getMissionDestination;

        /// <summary>
        /// Returns the current mission destination on the dungeon struct.
        /// 
        /// return: &amp;dungeon::mission_destination
        /// </summary>
        public int GetMissionDestination
        {
            get
            {
                if (f_getMissionDestination)
                    return _getMissionDestination;
                _getMissionDestination = (int) (445420);
                f_getMissionDestination = true;
                return _getMissionDestination;
            }
        }
        private bool f_useThrowableItem;
        private int _useThrowableItem;

        /// <summary>
        /// Makes a monster use a throwable item.
        /// 
        /// The item to use is determined by monster::action_data::action_parameter[0].
        /// If the item's category is CATEGORY_THROWN_LINE or CATEGORY_THROWN_ARC, the game will attempt to decrement the count of the used item by 1. If it's not or there's only 1 item left, it is destroyed instead.
        /// 
        /// r0: User (monster who used the item)
        /// </summary>
        public int UseThrowableItem
        {
            get
            {
                if (f_useThrowableItem)
                    return _useThrowableItem;
                _useThrowableItem = (int) (102868);
                f_useThrowableItem = true;
                return _useThrowableItem;
            }
        }
        private bool f_setForcedLossReason;
        private int _setForcedLossReason;

        /// <summary>
        /// Sets dungeon::forced_loss_reason to the specified value
        /// 
        /// r0: Forced loss reason
        /// </summary>
        public int SetForcedLossReason
        {
            get
            {
                if (f_setForcedLossReason)
                    return _setForcedLossReason;
                _setForcedLossReason = (int) (69004);
                f_setForcedLossReason = true;
                return _setForcedLossReason;
            }
        }
        private bool f_endMiracleEyeStatus;
        private int _endMiracleEyeStatus;

        /// <summary>
        /// Removes the target's miracle eye status due to the action of the user, and prints the event to the log.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int EndMiracleEyeStatus
        {
            get
            {
                if (f_endMiracleEyeStatus)
                    return _endMiracleEyeStatus;
                _endMiracleEyeStatus = (int) (174260);
                f_endMiracleEyeStatus = true;
                return _endMiracleEyeStatus;
            }
        }
        private bool f_convertSecondaryTerrainToChasms;
        private int _convertSecondaryTerrainToChasms;

        /// <summary>
        /// Converts all secondary terrain tiles (water/lava) to chasms.
        /// 
        /// No params.
        /// </summary>
        public int ConvertSecondaryTerrainToChasms
        {
            get
            {
                if (f_convertSecondaryTerrainToChasms)
                    return _convertSecondaryTerrainToChasms;
                _convertSecondaryTerrainToChasms = (int) (410860);
                f_convertSecondaryTerrainToChasms = true;
                return _convertSecondaryTerrainToChasms;
            }
        }
        private bool f_isCurrentMissionType;
        private int _isCurrentMissionType;

        /// <summary>
        /// Checks if the current floor is an active mission destination of a given type (and any subtype).
        /// 
        /// r0: mission type
        /// return: bool
        /// </summary>
        public int IsCurrentMissionType
        {
            get
            {
                if (f_isCurrentMissionType)
                    return _isCurrentMissionType;
                _isCurrentMissionType = (int) (445540);
                f_isCurrentMissionType = true;
                return _isCurrentMissionType;
            }
        }
        private bool f_generateKecleonShop;
        private int _generateKecleonShop;

        /// <summary>
        /// Possibly generate a Kecleon shop on the floor.
        /// 
        /// A Kecleon shop will be generated with a probability determined by the Kecleon shop spawn chance parameter. A Kecleon shop will be generated in a random room that is valid, connected, has no other special features, and has dimensions of at least 5x4. Kecleon shops will occupy the entire room interior, leaving a one tile margin from the room walls.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: Kecleon shop spawn chance (percentage from 0-100)
        /// </summary>
        public int GenerateKecleonShop
        {
            get
            {
                if (f_generateKecleonShop)
                    return _generateKecleonShop;
                _generateKecleonShop = (int) (407240);
                f_generateKecleonShop = true;
                return _generateKecleonShop;
            }
        }
        private bool f_assignTopScreenHandlers;
        private int _assignTopScreenHandlers;

        /// <summary>
        /// Sets the handler functions of the top screen type.
        /// 
        /// r0: Array where the handler function pointers get written to.
        /// r1: init_func
        /// r2: update_func
        /// r3: ?
        /// stack[0]: free_func
        /// </summary>
        public int AssignTopScreenHandlers
        {
            get
            {
                if (f_assignTopScreenHandlers)
                    return _assignTopScreenHandlers;
                _assignTopScreenHandlers = (int) (50256);
                f_assignTopScreenHandlers = true;
                return _assignTopScreenHandlers;
            }
        }
        private bool f_endProtectStatus;
        private int _endProtectStatus;

        /// <summary>
        /// Ends the target's protect status due to the action of the user.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int EndProtectStatus
        {
            get
            {
                if (f_endProtectStatus)
                    return _endProtectStatus;
                _endProtectStatus = (int) (178536);
                f_endProtectStatus = true;
                return _endProtectStatus;
            }
        }
        private bool f_updateCamera;
        private int _updateCamera;

        /// <summary>
        /// Called every frame. Sets the camera to the right coordinates depending on the monster it points to.
        /// 
        /// It also takes care of updating the minimap, checking which elements should be shown on it, as well as whether the screen should be black due to the blinker status.
        /// 
        /// r0: ?
        /// </summary>
        public int UpdateCamera
        {
            get
            {
                if (f_updateCamera)
                    return _updateCamera;
                _updateCamera = (int) (27732);
                f_updateCamera = true;
                return _updateCamera;
            }
        }
        private bool f_tryActivateFrisk;
        private int _tryActivateFrisk;

        /// <summary>
        /// Tries to activate the Frisk ability on the defender. The attacker has to be on the team and the defender has to be
        /// holding an item or be able to drop a treasure box.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// </summary>
        public int TryActivateFrisk
        {
            get
            {
                if (f_tryActivateFrisk)
                    return _tryActivateFrisk;
                _tryActivateFrisk = (int) (257168);
                f_tryActivateFrisk = true;
                return _tryActivateFrisk;
            }
        }
        private bool f_gravityIsActive;
        private int _gravityIsActive;

        /// <summary>
        /// Checks if gravity is active on the floor.
        /// 
        /// return: bool
        /// </summary>
        public int GravityIsActive
        {
            get
            {
                if (f_gravityIsActive)
                    return _gravityIsActive;
                _gravityIsActive = (int) (376436);
                f_gravityIsActive = true;
                return _gravityIsActive;
            }
        }
        private bool f_tryInflictPoisonedStatus;
        private int _tryInflictPoisonedStatus;

        /// <summary>
        /// Inflicts the Poisoned status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictPoisonedStatus
        {
            get
            {
                if (f_tryInflictPoisonedStatus)
                    return _tryInflictPoisonedStatus;
                _tryInflictPoisonedStatus = (int) (221824);
                f_tryInflictPoisonedStatus = true;
                return _tryInflictPoisonedStatus;
            }
        }
        private bool f_findNearbyUnoccupiedTile;
        private int _findNearbyUnoccupiedTile;

        /// <summary>
        /// Searches for an unoccupied tile near some origin.
        /// 
        /// A tile is considered &quot;unoccupied&quot; if it's not a key door, and has no object or monster on it. In &quot;random room&quot; mode, the tile must also not be in a hallway, and must not have the stairs.
        /// 
        /// The first unoccupied tile found is returned. The search order is randomized in &quot;random room&quot; mode, otherwise the search order is fixed based on the input displacement array.
        /// 
        /// r0: [output] position
        /// r1: origin position
        /// r2: array of displacements from the origin position to consider
        /// r3: number of elements in displacements array
        /// stack[0]: random room mode flag
        /// return: whether a tile was successfully found
        /// </summary>
        public int FindNearbyUnoccupiedTile
        {
            get
            {
                if (f_findNearbyUnoccupiedTile)
                    return _findNearbyUnoccupiedTile;
                _findNearbyUnoccupiedTile = (int) (54732);
                f_findNearbyUnoccupiedTile = true;
                return _findNearbyUnoccupiedTile;
            }
        }
        private bool f_ensureCanStandCurrentTile;
        private int _ensureCanStandCurrentTile;

        /// <summary>
        /// Checks that the given monster is standing on a tile it can stand on given its
        /// movement type and warps it if not. If the monster is a non-leader ally, they
        /// will be warped to the leader. Otherwise, the monster is warped randomly.
        /// 
        /// r0: Entity pointer
        /// </summary>
        public int EnsureCanStandCurrentTile
        {
            get
            {
                if (f_ensureCanStandCurrentTile)
                    return _ensureCanStandCurrentTile;
                _ensureCanStandCurrentTile = (int) (281808);
                f_ensureCanStandCurrentTile = true;
                return _ensureCanStandCurrentTile;
            }
        }
        private bool f_restoreRandomMovePp;
        private int _restoreRandomMovePp;

        /// <summary>
        /// Restores the PP of a random one of the target's moves by the specified amount.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: PP to restore
        /// r3: flag to log message
        /// </summary>
        public int RestoreRandomMovePp
        {
            get
            {
                if (f_restoreRandomMovePp)
                    return _restoreRandomMovePp;
                _restoreRandomMovePp = (int) (244344);
                f_restoreRandomMovePp = true;
                return _restoreRandomMovePp;
            }
        }
        private bool f_tryActivateBadDreams;
        private int _tryActivateBadDreams;

        /// <summary>
        /// Tries to apply the damage from Bad Dreams to all sleeping monsters in the room.
        /// 
        /// r0: monster pointer
        /// </summary>
        public int TryActivateBadDreams
        {
            get
            {
                if (f_tryActivateBadDreams)
                    return _tryActivateBadDreams;
                _tryActivateBadDreams = (int) (257444);
                f_tryActivateBadDreams = true;
                return _tryActivateBadDreams;
            }
        }
        private bool f_restorePpAllMovesSetFlags;
        private int _restorePpAllMovesSetFlags;

        /// <summary>
        /// Restores PP for all moves, clears flags move::f_consume_2_pp, move::flags2_unk5 and move::flags2_unk7, and sets flag move::f_consume_pp.
        /// Called when a monster is revived.
        /// 
        /// r0: pointer to entity whose moves will be restored
        /// </summary>
        public int RestorePpAllMovesSetFlags
        {
            get
            {
                if (f_restorePpAllMovesSetFlags)
                    return _restorePpAllMovesSetFlags;
                _restorePpAllMovesSetFlags = (int) (120652);
                f_restorePpAllMovesSetFlags = true;
                return _restorePpAllMovesSetFlags;
            }
        }
        private bool f_playEffectAnimationEntityStandard;
        private int _playEffectAnimationEntityStandard;

        /// <summary>
        /// Calls PlayEffectAnimationEntity with standard parameters used in various functions throughout the game.
        /// 
        /// r0: entity pointer
        /// r1: effect id
        /// </summary>
        public int PlayEffectAnimationEntityStandard
        {
            get
            {
                if (f_playEffectAnimationEntityStandard)
                    return _playEffectAnimationEntityStandard;
                _playEffectAnimationEntityStandard = (int) (32888);
                f_playEffectAnimationEntityStandard = true;
                return _playEffectAnimationEntityStandard;
            }
        }
        private bool f_canTargetPosition;
        private int _canTargetPosition;

        /// <summary>
        /// Checks if a monster can target a position. This function just calls IsPositionInSight using the position of the user as the origin.
        /// 
        /// r0: Entity pointer
        /// r1: Target position
        /// return: True if the specified monster can target the target position, false otherwise.
        /// </summary>
        public int CanTargetPosition
        {
            get
            {
                if (f_canTargetPosition)
                    return _canTargetPosition;
                _canTargetPosition = (int) (26376);
                f_canTargetPosition = true;
                return _canTargetPosition;
            }
        }
        private bool f_loadMappaFileAttributes;
        private int _loadMappaFileAttributes;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// This function processes the monster spawn list of the current floor, checking which species can spawn, capping the amount of spawnable species on the floor to 14, randomly choosing which 14 species will spawn and ensuring that the sprite size of all the species combined does not exceed the maximum of 0x58000 bytes (352 KB). Kecleon and the Decoy are always included in the random selection.
        /// The function also processes the floor's item spawn lists. When loading fixed rooms from the hidden staircase, the game forces the number of spawnable species to 0.
        /// 
        /// r0: quick_saved
        /// r1: disable_monsters
        /// r2: special_process
        /// </summary>
        public int LoadMappaFileAttributes
        {
            get
            {
                if (f_loadMappaFileAttributes)
                    return _loadMappaFileAttributes;
                _loadMappaFileAttributes = (int) (44364);
                f_loadMappaFileAttributes = true;
                return _loadMappaFileAttributes;
            }
        }
        private bool f_resetAiCanAttackInDirection;
        private int _resetAiCanAttackInDirection;

        /// <summary>
        /// Resets all entries in AI_CAN_ATTACK_IN_DIRECTION to false.
        /// 
        /// No params.
        /// </summary>
        public int ResetAiCanAttackInDirection
        {
            get
            {
                if (f_resetAiCanAttackInDirection)
                    return _resetAiCanAttackInDirection;
                _resetAiCanAttackInDirection = (int) (250956);
                f_resetAiCanAttackInDirection = true;
                return _resetAiCanAttackInDirection;
            }
        }
        private bool f_isTypeAffectedByGravity;
        private int _isTypeAffectedByGravity;

        /// <summary>
        /// Checks if Gravity is active and that the given type is affected (i.e., Flying type).
        /// 
        /// r0: target entity pointer (unused)
        /// r1: type ID
        /// return: bool
        /// </summary>
        public int IsTypeAffectedByGravity
        {
            get
            {
                if (f_isTypeAffectedByGravity)
                    return _isTypeAffectedByGravity;
                _isTypeAffectedByGravity = (int) (154360);
                f_isTypeAffectedByGravity = true;
                return _isTypeAffectedByGravity;
            }
        }
        private bool f_aftermathCheck;
        private int _aftermathCheck;

        /// <summary>
        /// Checks if the defender has the Aftermath ability and tries to activate it if so (50% chance).
        /// 
        /// The ability won't trigger if the damage source is DAMAGE_SOURCE_EXPLOSION.
        /// 
        /// r0: Attacker pointer
        /// r1: Defender pointer
        /// r2: Damage source
        /// return: True if Aftermath was activated, false if it wasn't
        /// </summary>
        public int AftermathCheck
        {
            get
            {
                if (f_aftermathCheck)
                    return _aftermathCheck;
                _aftermathCheck = (int) (190120);
                f_aftermathCheck = true;
                return _aftermathCheck;
            }
        }
        private bool f_finalizeJunctions;
        private int _finalizeJunctions;

        /// <summary>
        /// Finalizes junction tiles by setting the junction flag (bit 3 of the terrain flags) and ensuring open terrain.
        /// 
        /// Note that this implementation is slightly buggy. This function scans tiles left-to-right, top-to-bottom, and identifies junctions as any open, non-hallway tile (room_index != 0xFF) adjacent to an open, hallway tile (room_index == 0xFF). This interacts poorly with hallway anchors (room_index == 0xFE). This function sets the room index of any hallway anchors to 0xFF within the same loop, so a hallway anchor may or may not be identified as a junction depending on the orientation of connected hallways.
        /// 
        /// For example, in the following configuration, the &quot;o&quot; tile would be marked as a junction because the neighboring hallway tile to its left comes earlier in iteration, while the &quot;o&quot; tile still has the room index 0xFE, causing the algorithm to mistake it for a room tile:
        ///   xxxxx
        ///   ---ox
        ///   xxx|x
        ///   xxx|x
        /// However, in the following configuration, the &quot;o&quot; tile would NOT be marked as a junction because it comes earlier in iteration than any of its neighboring hallway tiles, so its room index is set to 0xFF before it can be marked as a junction. This is actually the ONLY possible configuration where a hallway anchor will not be marked as a junction.
        ///   xxxxx
        ///   xo---
        ///   x|xxx
        ///   x|xxx
        /// 
        /// No params.
        /// </summary>
        public int FinalizeJunctions
        {
            get
            {
                if (f_finalizeJunctions)
                    return _finalizeJunctions;
                _finalizeJunctions = (int) (406556);
                f_finalizeJunctions = true;
                return _finalizeJunctions;
            }
        }
        private bool f_getMonsterMoves;
        private int _getMonsterMoves;

        /// <summary>
        /// Determines the moveset of a newly spawned monster given its species and level.
        /// 
        /// The function loops the monster's learnset, adding moves to the list in level-up order. Once all four slots are filled up, a random existing move gets replaced to make room for the new one. This means that the monster will always have the latest move it can learn given its level.
        /// 
        /// r0: [output] Pointer to move ID list (4 entries, 2 bytes each)
        /// r1: Monster ID
        /// r2: Monster level
        /// </summary>
        public int GetMonsterMoves
        {
            get
            {
                if (f_getMonsterMoves)
                    return _getMonsterMoves;
                _getMonsterMoves = (int) (161672);
                f_getMonsterMoves = true;
                return _getMonsterMoves;
            }
        }
        private bool f_transferNegativeStatusCondition;
        private int _transferNegativeStatusCondition;

        /// <summary>
        /// Transfers all negative status conditions the user has and gives then to the target.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TransferNegativeStatusCondition
        {
            get
            {
                if (f_transferNegativeStatusCondition)
                    return _transferNegativeStatusCondition;
                _transferNegativeStatusCondition = (int) (170156);
                f_transferNegativeStatusCondition = true;
                return _transferNegativeStatusCondition;
            }
        }
        private bool f_logMessage;
        private int _logMessage;

        /// <summary>
        /// Logs a message in the message log.
        /// 
        /// r0: user entity pointer
        /// r1: message string
        /// r2: bool, whether or not to present a message popup
        /// </summary>
        public int LogMessage
        {
            get
            {
                if (f_logMessage)
                    return _logMessage;
                _logMessage = (int) (454296);
                f_logMessage = true;
                return _logMessage;
            }
        }
        private bool f_assignGridCellConnections;
        private int _assignGridCellConnections;

        /// <summary>
        /// Randomly assigns connections between adjacent grid cells.
        /// 
        /// Connections are created via a random walk with momentum, starting from the grid cell at (cursor x, cursor y). A connection is drawn in a random direction from the current cursor, and this process is repeated a certain number of times (the &quot;floor connectivity&quot; specified in the floor properties). The direction of the random walk has &quot;momentum&quot;; there's a 50% chance it will be the same as the previous step (or rotated counterclockwise if on the boundary). This helps to reduce the number of dead ends and forks in the road caused by the random walk &quot;doubling back&quot; on itself.
        /// 
        /// If dead ends are disabled in the floor properties, there is an additional phase to remove dead end hallway anchors (only hallway anchors, not rooms) by drawing additional connections. Note that the actual implementation contains a bug: the grid cell validity checks use the wrong index, so connections may be drawn to invalid cells.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// r3: cursor x
        /// stack[0]: cursor y
        /// stack[1]: floor properties
        /// </summary>
        public int AssignGridCellConnections
        {
            get
            {
                if (f_assignGridCellConnections)
                    return _assignGridCellConnections;
                _assignGridCellConnections = (int) (400188);
                f_assignGridCellConnections = true;
                return _assignGridCellConnections;
            }
        }
        private bool f_dungeonRngSetSecondary;
        private int _dungeonRngSetSecondary;

        /// <summary>
        /// Sets the dungeon PRNG to use one of the 5 secondary LCGs for subsequent random number generation.
        /// 
        /// r0: secondary LCG index
        /// </summary>
        public int DungeonRngSetSecondary
        {
            get
            {
                if (f_dungeonRngSetSecondary)
                    return _dungeonRngSetSecondary;
                _dungeonRngSetSecondary = (int) (59860);
                f_dungeonRngSetSecondary = true;
                return _dungeonRngSetSecondary;
            }
        }
        private bool f_setLeaderActionFields;
        private int _setLeaderActionFields;

        /// <summary>
        /// Sets the leader's monster::action::action_id to the specified value.
        /// 
        /// Also sets monster::action::action_use_idx and monster::action::field_0xA to 0, as well as monster::action::field_0x10 and monster::action::field_0x12 to -1.
        /// 
        /// r0: ID of the action to set
        /// </summary>
        public int SetLeaderActionFields
        {
            get
            {
                if (f_setLeaderActionFields)
                    return _setLeaderActionFields;
                _setLeaderActionFields = (int) (61776);
                f_setLeaderActionFields = true;
                return _setLeaderActionFields;
            }
        }
        private bool f_generateFixedRoom;
        private int _generateFixedRoom;

        /// <summary>
        /// Handles fixed room generation if the floor contains a fixed room.
        /// 
        /// r0: fixed room ID
        /// r1: floor properties
        /// return: bool
        /// </summary>
        public int GenerateFixedRoom
        {
            get
            {
                if (f_generateFixedRoom)
                    return _generateFixedRoom;
                _generateFixedRoom = (int) (392720);
                f_generateFixedRoom = true;
                return _generateFixedRoom;
            }
        }
        private bool f_setSecondaryTerrainOnWall;
        private int _setSecondaryTerrainOnWall;

        /// <summary>
        /// Set a specific tile to have secondary terrain (water/lava), but only if it's a passable wall.
        /// 
        /// r0: tile pointer
        /// </summary>
        public int SetSecondaryTerrainOnWall
        {
            get
            {
                if (f_setSecondaryTerrainOnWall)
                    return _setSecondaryTerrainOnWall;
                _setSecondaryTerrainOnWall = (int) (414284);
                f_setSecondaryTerrainOnWall = true;
                return _setSecondaryTerrainOnWall;
            }
        }
        private bool f_moveIsNotPhysical;
        private int _moveIsNotPhysical;

        /// <summary>
        /// Checks if a move isn't a physical move.
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int MoveIsNotPhysical
        {
            get
            {
                if (f_moveIsNotPhysical)
                    return _moveIsNotPhysical;
                _moveIsNotPhysical = (int) (271844);
                f_moveIsNotPhysical = true;
                return _moveIsNotPhysical;
            }
        }
        private bool f_isSecretBazaar;
        private int _isSecretBazaar;

        /// <summary>
        /// Checks if the current floor is the Secret Bazaar.
        /// 
        /// return: bool
        /// </summary>
        public int IsSecretBazaar
        {
            get
            {
                if (f_isSecretBazaar)
                    return _isSecretBazaar;
                _isSecretBazaar = (int) (377000);
                f_isSecretBazaar = true;
                return _isSecretBazaar;
            }
        }
        private bool f_updateMinimap;
        private int _updateMinimap;

        /// <summary>
        /// Graphically updates the minimap
        /// 
        /// No params.
        /// </summary>
        public int UpdateMinimap
        {
            get
            {
                if (f_updateMinimap)
                    return _updateMinimap;
                _updateMinimap = (int) (382924);
                f_updateMinimap = true;
                return _updateMinimap;
            }
        }
        private bool f_restoreAllMovePp;
        private int _restoreAllMovePp;

        /// <summary>
        /// Restores the PP of all the target's moves by the specified amount.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: PP to restore
        /// r3: flag to suppress message logging
        /// </summary>
        public int RestoreAllMovePp
        {
            get
            {
                if (f_restoreAllMovePp)
                    return _restoreAllMovePp;
                _restoreAllMovePp = (int) (243728);
                f_restoreAllMovePp = true;
                return _restoreAllMovePp;
            }
        }
        private bool f_areOrbsAllowedVeneer;
        private int _areOrbsAllowedVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for InitMemAllocTable.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: fixed room ID
        /// return: bool
        /// </summary>
        public int AreOrbsAllowedVeneer
        {
            get
            {
                if (f_areOrbsAllowedVeneer)
                    return _areOrbsAllowedVeneer;
                _areOrbsAllowedVeneer = (int) (424992);
                f_areOrbsAllowedVeneer = true;
                return _areOrbsAllowedVeneer;
            }
        }
        private bool f_checkTouchscreenArea;
        private int _checkTouchscreenArea;

        /// <summary>
        /// Checks if the currently pressed touchscreen position is within the specified area.
        /// 
        /// r0: Area lower X coordinate
        /// r1: Area lower Y coordinate
        /// r2: Area upper X coordinate
        /// r3: Area upper Y coordinate
        /// return: True if the specified area contains the currently pressed touchscreen position, false otherwise.
        /// </summary>
        public int CheckTouchscreenArea
        {
            get
            {
                if (f_checkTouchscreenArea)
                    return _checkTouchscreenArea;
                _checkTouchscreenArea = (int) (19048);
                f_checkTouchscreenArea = true;
                return _checkTouchscreenArea;
            }
        }
        private bool f_monsterHasMiracleEyeStatus;
        private int _monsterHasMiracleEyeStatus;

        /// <summary>
        /// Checks if a monster has the Miracle Eye status.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasMiracleEyeStatus
        {
            get
            {
                if (f_monsterHasMiracleEyeStatus)
                    return _monsterHasMiracleEyeStatus;
                _monsterHasMiracleEyeStatus = (int) (147740);
                f_monsterHasMiracleEyeStatus = true;
                return _monsterHasMiracleEyeStatus;
            }
        }
        private bool f_checkVariousConditions;
        private int _checkVariousConditions;

        /// <summary>
        /// Returns 0 if none of these conditions holds for the given entity: is a rescue client,
        /// doesn’t gain experience (a mission client/story teammate?), is a terrified non-team-leader,
        /// meets any of the conditions in CheckVariousStatuses2 (with blind_check = 0), is charging a two-turn move.
        /// 
        /// r0: Entity pointer
        /// return: bool
        /// </summary>
        public int CheckVariousConditions
        {
            get
            {
                if (f_checkVariousConditions)
                    return _checkVariousConditions;
                _checkVariousConditions = (int) (149060);
                f_checkVariousConditions = true;
                return _checkVariousConditions;
            }
        }
        private bool f_tryAftermathExplosion;
        private int _tryAftermathExplosion;

        /// <summary>
        /// Creates the explosion for the ability aftermath if possible.
        /// 
        /// The target monster is considered the source of the explosion.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: coordinates where the explosion should take place (center)
        /// r3: explosion radius (only works correctly with 1 and 2)
        /// stack[0]: damage type
        /// stack[1]: damage source (normally DAMAGE_SOURCE_EXPLOSION)
        /// </summary>
        public int TryAftermathExplosion
        {
            get
            {
                if (f_tryAftermathExplosion)
                    return _tryAftermathExplosion;
                _tryAftermathExplosion = (int) (279380);
                f_tryAftermathExplosion = true;
                return _tryAftermathExplosion;
            }
        }
        private bool f_abilityIsActiveVeneer;
        private int _abilityIsActiveVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for AbilityIsActive.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: entity pointer
        /// r1: ability ID
        /// return: bool
        /// </summary>
        public int AbilityIsActiveVeneer
        {
            get
            {
                if (f_abilityIsActiveVeneer)
                    return _abilityIsActiveVeneer;
                _abilityIsActiveVeneer = (int) (154096);
                f_abilityIsActiveVeneer = true;
                return _abilityIsActiveVeneer;
            }
        }
        private bool f_getMissionEnemyMinionGroup;
        private int _getMissionEnemyMinionGroup;

        /// <summary>
        /// Get the monster ID of the specified minion group on the current floor for a mission, if it exists.
        /// 
        /// Note that a single minion group can correspond to multiple actual minions of the same species. There can be up to 2 minion groups.
        /// 
        /// r0: minion group index (0-indexed)
        /// return: monster ID
        /// </summary>
        public int GetMissionEnemyMinionGroup
        {
            get
            {
                if (f_getMissionEnemyMinionGroup)
                    return _getMissionEnemyMinionGroup;
                _getMissionEnemyMinionGroup = (int) (446592);
                f_getMissionEnemyMinionGroup = true;
                return _getMissionEnemyMinionGroup;
            }
        }
        private bool f_tryInflictConversion2Status;
        private int _tryInflictConversion2Status;

        /// <summary>
        /// Inflicts the Conversion2 status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryInflictConversion2Status
        {
            get
            {
                if (f_tryInflictConversion2Status)
                    return _tryInflictConversion2Status;
                _tryInflictConversion2Status = (int) (250024);
                f_tryInflictConversion2Status = true;
                return _tryInflictConversion2Status;
            }
        }
        private bool f_updateTeamStatsWrapper;
        private int _updateTeamStatsWrapper;

        /// <summary>
        /// Contains a check and calls UpdateTeamStats in overlay10.
        /// 
        /// return: always 1, seems unused
        /// </summary>
        public int UpdateTeamStatsWrapper
        {
            get
            {
                if (f_updateTeamStatsWrapper)
                    return _updateTeamStatsWrapper;
                _updateTeamStatsWrapper = (int) (48920);
                f_updateTeamStatsWrapper = true;
                return _updateTeamStatsWrapper;
            }
        }
        private bool f_revealTrapsNearby;
        private int _revealTrapsNearby;

        /// <summary>
        /// Reveals traps within the monster's viewing range.
        /// 
        /// r0: entity pointer
        /// </summary>
        public int RevealTrapsNearby
        {
            get
            {
                if (f_revealTrapsNearby)
                    return _revealTrapsNearby;
                _revealTrapsNearby = (int) (78588);
                f_revealTrapsNearby = true;
                return _revealTrapsNearby;
            }
        }
        private bool f_logMessageByIdWithPopup;
        private int _logMessageByIdWithPopup;

        /// <summary>
        /// Logs a message in the message log alongside a message popup.
        /// 
        /// r0: user entity pointer
        /// r1: message ID
        /// </summary>
        public int LogMessageByIdWithPopup
        {
            get
            {
                if (f_logMessageByIdWithPopup)
                    return _logMessageByIdWithPopup;
                _logMessageByIdWithPopup = (int) (454184);
                f_logMessageByIdWithPopup = true;
                return _logMessageByIdWithPopup;
            }
        }
        private bool f_isSecretRoom;
        private int _isSecretRoom;

        /// <summary>
        /// Checks if the current floor is the Secret Room fixed floor (from hidden stairs).
        /// 
        /// return: bool
        /// </summary>
        public int IsSecretRoom
        {
            get
            {
                if (f_isSecretRoom)
                    return _isSecretRoom;
                _isSecretRoom = (int) (377152);
                f_isSecretRoom = true;
                return _isSecretRoom;
            }
        }
        private bool f_tryWeatherFormChange;
        private int _tryWeatherFormChange;

        /// <summary>
        /// Tries to change a monster into one of its weather-related alternative forms. Applies to Castform and Cherrim, and checks for their unique abilities.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int TryWeatherFormChange
        {
            get
            {
                if (f_tryWeatherFormChange)
                    return _tryWeatherFormChange;
                _tryWeatherFormChange = (int) (363644);
                f_tryWeatherFormChange = true;
                return _tryWeatherFormChange;
            }
        }
        private bool f_startFadeDungeon;
        private int _startFadeDungeon;

        /// <summary>
        /// Initiates a screen fade in dungeon mode.
        /// 
        /// Sets the fields of the dungeon_fade struct to appropriate values given in the args.
        /// 
        /// r0: Dungeon fade struct
        /// r1: Change of brightness per frame
        /// r2: Fade type
        /// </summary>
        public int StartFadeDungeon
        {
            get
            {
                if (f_startFadeDungeon)
                    return _startFadeDungeon;
                _startFadeDungeon = (int) (458124);
                f_startFadeDungeon = true;
                return _startFadeDungeon;
            }
        }
        private bool f_copySpawnEntriesMaster;
        private int _copySpawnEntriesMaster;

        /// <summary>
        /// Copies the array at spawn_entries_master, starting from offset, to spawn_entries and returns the number of elements copied.
        /// 
        /// r0: [output] Size 16 monster_spawn_entry array
        /// r1: Offset (always 0 in practice)
        /// return: int
        /// </summary>
        public int CopySpawnEntriesMaster
        {
            get
            {
                if (f_copySpawnEntriesMaster)
                    return _copySpawnEntriesMaster;
                _copySpawnEntriesMaster = (int) (47476);
                f_copySpawnEntriesMaster = true;
                return _copySpawnEntriesMaster;
            }
        }
        private bool f_logMessageByIdWithPopupCheckUserUnknown;
        private int _logMessageByIdWithPopupCheckUserUnknown;

        /// <summary>
        /// Logs a message in the message log alongside a message popup, if the user hasn't fainted and some other unknown check.
        /// 
        /// r0: user entity pointer
        /// r1: ?
        /// r2: message ID
        /// </summary>
        public int LogMessageByIdWithPopupCheckUserUnknown
        {
            get
            {
                if (f_logMessageByIdWithPopupCheckUserUnknown)
                    return _logMessageByIdWithPopupCheckUserUnknown;
                _logMessageByIdWithPopupCheckUserUnknown = (int) (454100);
                f_logMessageByIdWithPopupCheckUserUnknown = true;
                return _logMessageByIdWithPopupCheckUserUnknown;
            }
        }
        private bool f_handleTopScreenFades;
        private int _handleTopScreenFades;

        /// <summary>
        /// Used to initialize and uninitialize the top screen in dungeon mode in conjunction with handling the fade status of the screen.
        /// 
        /// For example, when a fade out is done, it calls the necessary functions to close the top screen windows. When it starts fading in again, it re-creates all the necessary windows corresponding to the top screen type setting.
        /// 
        /// No params.
        /// </summary>
        public int HandleTopScreenFades
        {
            get
            {
                if (f_handleTopScreenFades)
                    return _handleTopScreenFades;
                _handleTopScreenFades = (int) (50676);
                f_handleTopScreenFades = true;
                return _handleTopScreenFades;
            }
        }
        private bool f_displayNumberTextureUi;
        private int _displayNumberTextureUi;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: x position
        /// r1: y position
        /// r2: number
        /// r3: ally_mode
        /// return: xsize
        /// </summary>
        public int DisplayNumberTextureUi
        {
            get
            {
                if (f_displayNumberTextureUi)
                    return _displayNumberTextureUi;
                _displayNumberTextureUi = (int) (365424);
                f_displayNumberTextureUi = true;
                return _displayNumberTextureUi;
            }
        }
        private bool f_checkLeaderTile;
        private int _checkLeaderTile;

        /// <summary>
        /// Checks the tile the leader just stepped on and performs any required actions, such as picking up items, triggering traps, etc.
        /// 
        /// Contains a switch that checks the type of the tile the leader just stepped on.
        /// 
        /// No params.
        /// </summary>
        public int CheckLeaderTile
        {
            get
            {
                if (f_checkLeaderTile)
                    return _checkLeaderTile;
                _checkLeaderTile = (int) (95052);
                f_checkLeaderTile = true;
                return _checkLeaderTile;
            }
        }
        private bool f_monsterHasNegativeStatus;
        private int _monsterHasNegativeStatus;

        /// <summary>
        /// Checks if a monster has any &quot;negative&quot; status conditions. This includes a wide variety of non-self-inflicted statuses that could traditionally be viewed as actual &quot;status conditions&quot;, as well as speed being lowered and moves being sealed.
        /// 
        /// r0: entity pointer
        /// r1: flag for whether to check for the held item (see IsMonsterVisuallyImpaired)
        /// return: bool
        /// </summary>
        public int MonsterHasNegativeStatus
        {
            get
            {
                if (f_monsterHasNegativeStatus)
                    return _monsterHasNegativeStatus;
                _monsterHasNegativeStatus = (int) (147768);
                f_monsterHasNegativeStatus = true;
                return _monsterHasNegativeStatus;
            }
        }
        private bool f_tryRestoreRoostTyping;
        private int _tryRestoreRoostTyping;

        /// <summary>
        /// Tries to restore the target's original typings before the Roost effect took place. Does nothing if the target
        /// is not affected by Roost.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int TryRestoreRoostTyping
        {
            get
            {
                if (f_tryRestoreRoostTyping)
                    return _tryRestoreRoostTyping;
                _tryRestoreRoostTyping = (int) (178596);
                f_tryRestoreRoostTyping = true;
                return _tryRestoreRoostTyping;
            }
        }
        private bool f_changeShayminForme;
        private int _changeShayminForme;

        /// <summary>
        /// forme:
        ///   1: change from Land to Sky
        ///   2: change from Sky to Land
        /// result:
        ///   0: not Shaymin
        ///   1: not correct Forme
        ///   2: frozen
        ///   3: ok
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: Target
        /// r1: forme
        /// return: result
        /// </summary>
        public int ChangeShayminForme
        {
            get
            {
                if (f_changeShayminForme)
                    return _changeShayminForme;
                _changeShayminForme = (int) (258264);
                f_changeShayminForme = true;
                return _changeShayminForme;
            }
        }
        private bool f_isNextToHallway;
        private int _isNextToHallway;

        /// <summary>
        /// Checks if a tile position is either in a hallway or next to one.
        /// 
        /// r0: x
        /// r1: y
        /// return: bool
        /// </summary>
        public int IsNextToHallway
        {
            get
            {
                if (f_isNextToHallway)
                    return _isNextToHallway;
                _isNextToHallway = (int) (410544);
                f_isNextToHallway = true;
                return _isNextToHallway;
            }
        }
        private bool f_resetGravity;
        private int _resetGravity;

        /// <summary>
        /// Resets gravity (and the byte after it?) in the dungeon struct back to 0.
        /// 
        /// No params.
        /// </summary>
        public int ResetGravity
        {
            get
            {
                if (f_resetGravity)
                    return _resetGravity;
                _resetGravity = (int) (376400);
                f_resetGravity = true;
                return _resetGravity;
            }
        }
        private bool f_monsterHasSkillInterferingStatus;
        private int _monsterHasSkillInterferingStatus;

        /// <summary>
        /// Checks if a monster has one of the non-self-inflicted statuses in the &quot;curse&quot; group, which loosely includes status conditions that interfere with the monster's skills or ability to do things: STATUS_CURSED, STATUS_DECOY, STATUS_GASTRO_ACID, STATUS_HEAL_BLOCK, STATUS_EMBARGO.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int MonsterHasSkillInterferingStatus
        {
            get
            {
                if (f_monsterHasSkillInterferingStatus)
                    return _monsterHasSkillInterferingStatus;
                _monsterHasSkillInterferingStatus = (int) (147520);
                f_monsterHasSkillInterferingStatus = true;
                return _monsterHasSkillInterferingStatus;
            }
        }
        private bool f_getMinimapData;
        private int _getMinimapData;

        /// <summary>
        /// Returns a pointer to the minimap_display_data struct in the dungeon struct.
        /// 
        /// return: minimap_display_data*
        /// </summary>
        public int GetMinimapData
        {
            get
            {
                if (f_getMinimapData)
                    return _getMinimapData;
                _getMinimapData = (int) (379900);
                f_getMinimapData = true;
                return _getMinimapData;
            }
        }
        private bool f_dungeonRand16Bit;
        private int _dungeonRand16Bit;

        /// <summary>
        /// Computes a pseudorandom 16-bit integer using the dungeon PRNG.
        /// 
        /// Note that the dungeon PRNG is only used in dungeon mode (as evidenced by these functions being in overlay 29). The game uses another lower-quality PRNG (see arm9.yml) for other needs.
        /// 
        /// Random numbers are generated with a linear congruential generator (LCG). The game actually maintains 6 separate sequences that can be used for generation: a primary LCG and 5 secondary LCGs. The generator used depends on parameters set on the global PRNG state.
        /// 
        /// All dungeon LCGs have a modulus of 2^32 and a multiplier of 1566083941 (see DUNGEON_PRNG_LCG_MULTIPLIER). The primary LCG uses an increment of 1, while the secondary LCGs use an increment of 2531011 (see DUNGEON_PRNG_LCG_INCREMENT_SECONDARY). So, for example, the primary LCG uses the recurrence relation:
        ///   x = (1566083941*x_prev + 1) % 2^32
        /// 
        /// Since the dungeon LCGs generate 32-bit integers rather than 16-bit, the primary LCG yields 16-bit values by taking the upper 16 bits of the computed 32-bit value. The secondary LCGs yield 16-bit values by taking the lower 16 bits of the computed 32-bit value.
        /// 
        /// All of the dungeon LCGs have a hard-coded default seed of 1, but in practice the seed is set with a call to InitDungeonRng during dungeon initialization.
        /// 
        /// return: pseudorandom int on the interval [0, 65535]
        /// </summary>
        public int DungeonRand16Bit
        {
            get
            {
                if (f_dungeonRand16Bit)
                    return _dungeonRand16Bit;
                _dungeonRand16Bit = (int) (59304);
                f_dungeonRand16Bit = true;
                return _dungeonRand16Bit;
            }
        }
        private bool f_applyStealthRockTrapEffect;
        private int _applyStealthRockTrapEffect;

        /// <summary>
        /// Tries to apply the damage from the stealth rock trap but does nothing if the defender is a rock type.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int ApplyStealthRockTrapEffect
        {
            get
            {
                if (f_applyStealthRockTrapEffect)
                    return _applyStealthRockTrapEffect;
                _applyStealthRockTrapEffect = (int) (76740);
                f_applyStealthRockTrapEffect = true;
                return _applyStealthRockTrapEffect;
            }
        }
        private bool f_tryActivateNondamagingDefenderExclusiveItem;
        private int _tryActivateNondamagingDefenderExclusiveItem;

        /// <summary>
        /// Applies the effects of a defender's item on an attacker. After a move is used,
        /// this function is called to see if any of the bitflags for an item were set and
        /// applies the corresponding effect.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// </summary>
        public int TryActivateNondamagingDefenderExclusiveItem
        {
            get
            {
                if (f_tryActivateNondamagingDefenderExclusiveItem)
                    return _tryActivateNondamagingDefenderExclusiveItem;
                _tryActivateNondamagingDefenderExclusiveItem = (int) (284860);
                f_tryActivateNondamagingDefenderExclusiveItem = true;
                return _tryActivateNondamagingDefenderExclusiveItem;
            }
        }
        private bool f_hasStatusThatPreventsActing;
        private int _hasStatusThatPreventsActing;

        /// <summary>
        /// Returns true if the monster has any status problem that prevents it from acting
        /// 
        /// r0: Entity pointer
        /// return: True if the specified monster can't act because of a status problem, false otherwise.
        /// </summary>
        public int HasStatusThatPreventsActing
        {
            get
            {
                if (f_hasStatusThatPreventsActing)
                    return _hasStatusThatPreventsActing;
                _hasStatusThatPreventsActing = (int) (142552);
                f_hasStatusThatPreventsActing = true;
                return _hasStatusThatPreventsActing;
            }
        }
        private bool f_tryRemoveSnatchedMonsterFromDungeonStruct;
        private int _tryRemoveSnatchedMonsterFromDungeonStruct;

        /// <summary>
        /// If the target is afflicted with snatch, change dungeon::snatch_monster and dungeon::snatch_status_unique_id back
        /// to NULL and 0 respectively. This function does not actually remove the status and visual flags for snatch from
        /// the monster, it simply removes it from the dungeon struct. After calling, the user should ensure the monster
        /// does not still have the snatch status.
        /// 
        /// r0: pointer to user
        /// r1: pointer to target
        /// </summary>
        public int TryRemoveSnatchedMonsterFromDungeonStruct
        {
            get
            {
                if (f_tryRemoveSnatchedMonsterFromDungeonStruct)
                    return _tryRemoveSnatchedMonsterFromDungeonStruct;
                _tryRemoveSnatchedMonsterFromDungeonStruct = (int) (172840);
                f_tryRemoveSnatchedMonsterFromDungeonStruct = true;
                return _tryRemoveSnatchedMonsterFromDungeonStruct;
            }
        }
        private bool f_tryInflictNappingStatus;
        private int _tryInflictNappingStatus;

        /// <summary>
        /// Inflicts the Napping status condition (from Rest) on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: number of turns
        /// </summary>
        public int TryInflictNappingStatus
        {
            get
            {
                if (f_tryInflictNappingStatus)
                    return _tryInflictNappingStatus;
                _tryInflictNappingStatus = (int) (219528);
                f_tryInflictNappingStatus = true;
                return _tryInflictNappingStatus;
            }
        }
        private bool f_floorHasMissionMonster;
        private int _floorHasMissionMonster;

        /// <summary>
        /// Checks if a given floor is a mission destination with a special monster, either a target to rescue or an enemy to defeat.
        /// 
        /// Mission types with a monster on the destination floor:
        /// - Rescue client
        /// - Rescue target
        /// - Escort to target
        /// - Deliver item
        /// - Search for target
        /// - Take item from outlaw
        /// - Arrest outlaw
        /// - Challenge Request
        /// 
        /// r0: mission destination info pointer
        /// return: bool
        /// </summary>
        public int FloorHasMissionMonster
        {
            get
            {
                if (f_floorHasMissionMonster)
                    return _floorHasMissionMonster;
                _floorHasMissionMonster = (int) (446864);
                f_floorHasMissionMonster = true;
                return _floorHasMissionMonster;
            }
        }
        private bool f_tryInflictGastroAcidStatus;
        private int _tryInflictGastroAcidStatus;

        /// <summary>
        /// Inflicts the Gastro Acid status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log message
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictGastroAcidStatus
        {
            get
            {
                if (f_tryInflictGastroAcidStatus)
                    return _tryInflictGastroAcidStatus;
                _tryInflictGastroAcidStatus = (int) (245356);
                f_tryInflictGastroAcidStatus = true;
                return _tryInflictGastroAcidStatus;
            }
        }
        private bool f_getTypeMatchup;
        private int _getTypeMatchup;

        /// <summary>
        /// Gets the type matchup for a given combat interaction.
        /// 
        /// Note that the actual monster's types on the attacker and defender pointers are not used; the pointers are only used to check conditions. The actual type matchup table lookup is done solely using the attack and target type parameters.
        /// 
        /// This factors in some conditional effects like exclusive items, statuses, etc. There's some weirdness with the Ghost type; see the comment for struct type_matchup_table.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: target type index (0 the target's first type, 1 for the target's second type)
        /// r3: attack type
        /// return: enum type_matchup
        /// </summary>
        public int GetTypeMatchup
        {
            get
            {
                if (f_getTypeMatchup)
                    return _getTypeMatchup;
                _getTypeMatchup = (int) (190704);
                f_getTypeMatchup = true;
                return _getTypeMatchup;
            }
        }
        private bool f_auraBowIsActive;
        private int _auraBowIsActive;

        /// <summary>
        /// Checks if a monster is holding an aura bow that isn't disabled by Klutz.
        /// 
        /// r0: entity pointer
        /// return: bool
        /// </summary>
        public int AuraBowIsActive
        {
            get
            {
                if (f_auraBowIsActive)
                    return _auraBowIsActive;
                _auraBowIsActive = (int) (209700);
                f_auraBowIsActive = true;
                return _auraBowIsActive;
            }
        }
        private bool f_storeSpriteFileIndexBothGenders;
        private int _storeSpriteFileIndexBothGenders;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// r1: file ID
        /// </summary>
        public int StoreSpriteFileIndexBothGenders
        {
            get
            {
                if (f_storeSpriteFileIndexBothGenders)
                    return _storeSpriteFileIndexBothGenders;
                _storeSpriteFileIndexBothGenders = (int) (110836);
                f_storeSpriteFileIndexBothGenders = true;
                return _storeSpriteFileIndexBothGenders;
            }
        }
        private bool f_generateSecondaryTerrainFormations;
        private int _generateSecondaryTerrainFormations;

        /// <summary>
        /// Generate secondary terrain (water/lava) formations.
        /// 
        /// This includes &quot;rivers&quot; that flow from top-to-bottom (or bottom-to-top), as well as &quot;lakes&quot; both standalone and after rivers. Water/lava formations will never cut through rooms, but they can pass through rooms to the opposite side.
        /// 
        /// Rivers are generated by a top-down or bottom-up random walk that ends when existing secondary terrain is reached or the walk goes out of bounds. Some rivers also end prematurely in a lake. Lakes are a large collection of secondary terrain generated around a central point.
        /// 
        /// r0: bit index to test in the floor properties room flag bitvector (formations are only generated if the bit is set)
        /// r1: floor properties
        /// </summary>
        public int GenerateSecondaryTerrainFormations
        {
            get
            {
                if (f_generateSecondaryTerrainFormations)
                    return _generateSecondaryTerrainFormations;
                _generateSecondaryTerrainFormations = (int) (414348);
                f_generateSecondaryTerrainFormations = true;
                return _generateSecondaryTerrainFormations;
            }
        }
        private bool f_tryResetStatChanges;
        private int _tryResetStatChanges;

        /// <summary>
        /// Tries to reset the stat changes of the defender.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// r3: bool to force animation
        /// </summary>
        public int TryResetStatChanges
        {
            get
            {
                if (f_tryResetStatChanges)
                    return _tryResetStatChanges;
                _tryResetStatChanges = (int) (250388);
                f_tryResetStatChanges = true;
                return _tryResetStatChanges;
            }
        }
        private bool f_positionIsOnStairs;
        private int _positionIsOnStairs;

        /// <summary>
        /// Checks if this location is on top of the staircase. In the game it is only used to check if an outlaw has reached
        /// the staircase.
        /// 
        /// r0: x coordinate
        /// r1: y coordinate
        /// return: bool
        /// </summary>
        public int PositionIsOnStairs
        {
            get
            {
                if (f_positionIsOnStairs)
                    return _positionIsOnStairs;
                _positionIsOnStairs = (int) (368348);
                f_positionIsOnStairs = true;
                return _positionIsOnStairs;
            }
        }
        private bool f_getTileTerrain;
        private int _getTileTerrain;

        /// <summary>
        /// Gets the terrain type of a tile.
        /// 
        /// r0: tile pointer
        /// return: terrain ID
        /// </summary>
        public int GetTileTerrain
        {
            get
            {
                if (f_getTileTerrain)
                    return _getTileTerrain;
                _getTileTerrain = (int) (387420);
                f_getTileTerrain = true;
                return _getTileTerrain;
            }
        }
        private bool f_isDestinationFloorWithItem;
        private int _isDestinationFloorWithItem;

        /// <summary>
        /// Checks if the current floor is a mission destination floor with a special item.
        /// 
        /// This excludes missions involving taking an item from an outlaw.
        /// 
        /// return: bool
        /// </summary>
        public int IsDestinationFloorWithItem
        {
            get
            {
                if (f_isDestinationFloorWithItem)
                    return _isDestinationFloorWithItem;
                _isDestinationFloorWithItem = (int) (446380);
                f_isDestinationFloorWithItem = true;
                return _isDestinationFloorWithItem;
            }
        }
        private bool f_tryInflictParalysisStatus;
        private int _tryInflictParalysisStatus;

        /// <summary>
        /// Inflicts the Paralysis status condition on a target monster if possible.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: flag to log a message on failure
        /// r3: flag to only perform the check for inflicting without actually inflicting
        /// return: Whether or not the status could be inflicted
        /// </summary>
        public int TryInflictParalysisStatus
        {
            get
            {
                if (f_tryInflictParalysisStatus)
                    return _tryInflictParalysisStatus;
                _tryInflictParalysisStatus = (int) (229692);
                f_tryInflictParalysisStatus = true;
                return _tryInflictParalysisStatus;
            }
        }
        private bool f_isCurrentTilesetBackground;
        private int _isCurrentTilesetBackground;

        /// <summary>
        /// Calls IsBackgroundTileset with the current tileset ID
        /// 
        /// return: True if the current dungeon tileset is a background, false if it's a regular tileset.
        /// </summary>
        public int IsCurrentTilesetBackground
        {
            get
            {
                if (f_isCurrentTilesetBackground)
                    return _isCurrentTilesetBackground;
                _isCurrentTilesetBackground = (int) (367860);
                f_isCurrentTilesetBackground = true;
                return _isCurrentTilesetBackground;
            }
        }
        private bool f_isPositionActuallyInSight;
        private int _isPositionActuallyInSight;

        /// <summary>
        /// Checks if a given target position is in sight from a given origin position.
        /// If the origin position is on a hallway or r2 is true, checks if both positions are within &lt;dungeon::display_data::visibility_range&gt; tiles of each other.
        /// If the origin position is on a room, checks that the target position is within the boundaries of said room.
        /// 
        /// r0: Origin position
        /// r1: Target position
        /// r2: True to assume the entity standing on the origin position has the dropeye status
        /// return: True if the target position is in sight from the origin position
        /// </summary>
        public int IsPositionActuallyInSight
        {
            get
            {
                if (f_isPositionActuallyInSight)
                    return _isPositionActuallyInSight;
                _isPositionActuallyInSight = (int) (52820);
                f_isPositionActuallyInSight = true;
                return _isPositionActuallyInSight;
            }
        }
        private bool f_displayCharTextureUi;
        private int _displayCharTextureUi;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: render_3d_element_64
        /// r1: x position
        /// r2: y position
        /// r3: char_id
        /// stack[0]: ?
        /// return: ?
        /// </summary>
        public int DisplayCharTextureUi
        {
            get
            {
                if (f_displayCharTextureUi)
                    return _displayCharTextureUi;
                _displayCharTextureUi = (int) (365688);
                f_displayCharTextureUi = true;
                return _displayCharTextureUi;
            }
        }
        private bool f_tryActivateTruant;
        private int _tryActivateTruant;

        /// <summary>
        /// Checks if an entity has the ability Truant, and if so tries to apply the pause status to it.
        /// 
        /// r0: pointer to entity
        /// </summary>
        public int TryActivateTruant
        {
            get
            {
                if (f_tryActivateTruant)
                    return _tryActivateTruant;
                _tryActivateTruant = (int) (120008);
                f_tryActivateTruant = true;
                return _tryActivateTruant;
            }
        }
        private bool f_getTeamMemberWithIqSkill;
        private int _getTeamMemberWithIqSkill;

        /// <summary>
        /// Returns an entity pointer to the first team member which has the specified iq skill.
        /// 
        /// r0: iq skill id
        /// return: pointer to entity
        /// </summary>
        public int GetTeamMemberWithIqSkill
        {
            get
            {
                if (f_getTeamMemberWithIqSkill)
                    return _getTeamMemberWithIqSkill;
                _getTeamMemberWithIqSkill = (int) (126112);
                f_getTeamMemberWithIqSkill = true;
                return _getTeamMemberWithIqSkill;
            }
        }
        private bool f_applyCheriBerryEffect;
        private int _applyCheriBerryEffect;

        /// <summary>
        /// Tries to heal the paralysis status condition. Prints a message on failure.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// </summary>
        public int ApplyCheriBerryEffect
        {
            get
            {
                if (f_applyCheriBerryEffect)
                    return _applyCheriBerryEffect;
                _applyCheriBerryEffect = (int) (264152);
                f_applyCheriBerryEffect = true;
                return _applyCheriBerryEffect;
            }
        }
        private bool f_generateSecondaryStructures;
        private int _generateSecondaryStructures;

        /// <summary>
        /// Try to generate secondary structures in flagged rooms.
        /// 
        /// If a valid room with no special features is flagged to have a secondary structure, try to generate a random one in the room, based on the result of a dice roll:
        ///   0: no secondary structure
        ///   1: maze, or a central water/lava &quot;plus sign&quot; as fallback, or a single water/lava tile in the center as a second fallback
        ///   2: checkerboard pattern of water/lava
        ///   3: central pool of water/lava
        ///   4: central &quot;island&quot; with items and a Warp Tile, surrounded by a &quot;moat&quot; of water/lava
        ///   5: horizontal or vertical divider of water/lava splitting the room in two
        /// 
        /// If the room isn't the right shape, dimension, or otherwise doesn't support the selected secondary structure, it is left untouched.
        /// 
        /// r0: grid to update
        /// r1: grid size x
        /// r2: grid size y
        /// </summary>
        public int GenerateSecondaryStructures
        {
            get
            {
                if (f_generateSecondaryStructures)
                    return _generateSecondaryStructures;
                _generateSecondaryStructures = (int) (397652);
                f_generateSecondaryStructures = true;
                return _generateSecondaryStructures;
            }
        }
        private bool f_hasMaxGinsengBoost99;
        private int _hasMaxGinsengBoost99;

        /// <summary>
        /// Checks if a move has a max Ginseng boost value of 99
        /// 
        /// r0: Move
        /// return: True if the move's max Ginseng boost is 99, false otherwise.
        /// </summary>
        public int HasMaxGinsengBoost99
        {
            get
            {
                if (f_hasMaxGinsengBoost99)
                    return _hasMaxGinsengBoost99;
                _hasMaxGinsengBoost99 = (int) (295752);
                f_hasMaxGinsengBoost99 = true;
                return _hasMaxGinsengBoost99;
            }
        }
        private bool f_applyPitfallTrapEffect;
        private int _applyPitfallTrapEffect;

        /// <summary>
        /// If the defender is the leader, end the current floor unless it has a rescue point.
        /// Otherwise, make the entity faint and ignore reviver seeds. If not called by a random
        /// trap, break the grate on the pitfall trap.
        /// 
        /// r0: attacker entity pointer
        /// r1: defender entity pointer
        /// r2: tile pointer
        /// r3: bool caused by random trap
        /// </summary>
        public int ApplyPitfallTrapEffect
        {
            get
            {
                if (f_applyPitfallTrapEffect)
                    return _applyPitfallTrapEffect;
                _applyPitfallTrapEffect = (int) (75168);
                f_applyPitfallTrapEffect = true;
                return _applyPitfallTrapEffect;
            }
        }
        private bool f_getHiddenStairsType;
        private int _getHiddenStairsType;

        /// <summary>
        /// Gets the hidden stairs type for a given floor.
        /// 
        /// This function reads the floor properties and resolves any randomness (such as HIDDEN_STAIRS_RANDOM_SECRET_BAZAAR_OR_SECRET_ROOM and the floor_properties::hidden_stairs_spawn_chance) into a concrete hidden stairs type.
        /// 
        /// r0: dungeon generation info pointer
        /// r1: floor properties pointer
        /// return: enum hidden_stairs_type
        /// </summary>
        public int GetHiddenStairsType
        {
            get
            {
                if (f_getHiddenStairsType)
                    return _getHiddenStairsType;
                _getHiddenStairsType = (int) (419964);
                f_getHiddenStairsType = true;
                return _getHiddenStairsType;
            }
        }
        private bool f_noGastroAcidStatus;
        private int _noGastroAcidStatus;

        /// <summary>
        /// Checks if a monster does not have the Gastro Acid status.
        /// 
        /// r0: entity pointer
        /// r1: ability ID (unused)
        /// return: bool
        /// </summary>
        public int NoGastroAcidStatus
        {
            get
            {
                if (f_noGastroAcidStatus)
                    return _noGastroAcidStatus;
                _noGastroAcidStatus = (int) (153940);
                f_noGastroAcidStatus = true;
                return _noGastroAcidStatus;
            }
        }
        private bool f_monsterSpawnListPartialCopy;
        private int _monsterSpawnListPartialCopy;

        /// <summary>
        /// Copies all entries in the floor's monster spawn list that have a sprite size &gt;= 6 to the specified buffer.
        /// 
        /// The parameter in r1 can be used to specify how many entries are already present in the buffer. Entries added by this function will be placed after those, and the total returned in r1 will account for existing entries as well.
        /// 
        /// r0: [output] Buffer where the result will be stored
        /// r1: Current amount of entries in the buffer
        /// return: New amount of entries in the buffer
        /// </summary>
        public int MonsterSpawnListPartialCopy
        {
            get
            {
                if (f_monsterSpawnListPartialCopy)
                    return _monsterSpawnListPartialCopy;
                _monsterSpawnListPartialCopy = (int) (47596);
                f_monsterSpawnListPartialCopy = true;
                return _monsterSpawnListPartialCopy;
            }
        }
        private bool f_transferNegativeBlinkerClassStatus;
        private int _transferNegativeBlinkerClassStatus;

        /// <summary>
        /// Tries to transfer the negative blinker class status conditions from the user to
        /// the target.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// return: Whether or not the status could be transferred
        /// </summary>
        public int TransferNegativeBlinkerClassStatus
        {
            get
            {
                if (f_transferNegativeBlinkerClassStatus)
                    return _transferNegativeBlinkerClassStatus;
                _transferNegativeBlinkerClassStatus = (int) (177468);
                f_transferNegativeBlinkerClassStatus = true;
                return _transferNegativeBlinkerClassStatus;
            }
        }
        private bool f_tryInflictBurnStatusWholeTeam;
        private int _tryInflictBurnStatusWholeTeam;

        /// <summary>
        /// Inflicts the Burn status condition on all team members if possible.
        /// 
        /// No params.
        /// </summary>
        public int TryInflictBurnStatusWholeTeam
        {
            get
            {
                if (f_tryInflictBurnStatusWholeTeam)
                    return _tryInflictBurnStatusWholeTeam;
                _tryInflictBurnStatusWholeTeam = (int) (221748);
                f_tryInflictBurnStatusWholeTeam = true;
                return _tryInflictBurnStatusWholeTeam;
            }
        }
        private bool f_getCurrentHiddenStairsType;
        private int _getCurrentHiddenStairsType;

        /// <summary>
        /// Checks if the current floor is a secret bazaar or a secret room and returns which one it is.
        /// 
        /// return: enum hidden_stairs_type
        /// </summary>
        public int GetCurrentHiddenStairsType
        {
            get
            {
                if (f_getCurrentHiddenStairsType)
                    return _getCurrentHiddenStairsType;
                _getCurrentHiddenStairsType = (int) (377236);
                f_getCurrentHiddenStairsType = true;
                return _getCurrentHiddenStairsType;
            }
        }
        private bool f_calcDamageFixed;
        private int _calcDamageFixed;

        /// <summary>
        /// Appears to calculate damage from a fixed-damage effect.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: fixed damage
        /// r3: experience flag (see ApplyDamage)
        /// stack[0]: [output] struct containing info about the damage calculation
        /// stack[1]: attack type
        /// stack[2]: move category
        /// stack[3]: damage source
        /// stack[4]: damage message
        /// others: ?
        /// </summary>
        public int CalcDamageFixed
        {
            get
            {
                if (f_calcDamageFixed)
                    return _calcDamageFixed;
                _calcDamageFixed = (int) (200352);
                f_calcDamageFixed = true;
                return _calcDamageFixed;
            }
        }
        private bool f_canMonsterUseMove;
        private int _canMonsterUseMove;

        /// <summary>
        /// Checks if a monster can use the given move.
        /// Will always return true for the regular attack. Will return false if the move if the flag move::f_disabled is true, if the flag move::f_sealed is true. More things will be checked if the extra_checks parameter is true.
        /// 
        /// r0: Entity pointer
        /// r1: Move pointer
        /// r2: True to check whether the move is out of PP, whether it can be used under the taunted status and whether the encore status prevents using the move
        /// return: True if the monster can use the move, false otherwise.
        /// </summary>
        public int CanMonsterUseMove
        {
            get
            {
                if (f_canMonsterUseMove)
                    return _canMonsterUseMove;
                _canMonsterUseMove = (int) (296656);
                f_canMonsterUseMove = true;
                return _canMonsterUseMove;
            }
        }
        private bool f_monsterCannotAttack;
        private int _monsterCannotAttack;

        /// <summary>
        /// Returns 0 if the entity has any of these conditions: sleep, nightmare, napping, frozen, wrapped/wrapping, petrified, cringe, paused, infatuated, paralysis. Also returns 0 if ShouldMonsterRunAway returns 1.
        /// 
        /// r0: Entity pointer
        /// r1: If true, ignore sleep conditions (sleep, nightmare, napping) when checking if the entity cannot attack.
        /// return: bool
        /// </summary>
        public int MonsterCannotAttack
        {
            get
            {
                if (f_monsterCannotAttack)
                    return _monsterCannotAttack;
                _monsterCannotAttack = (int) (149712);
                f_monsterCannotAttack = true;
                return _monsterCannotAttack;
            }
        }
        private bool f_applyItemEffect;
        private int _applyItemEffect;

        /// <summary>
        /// Seems to apply an item's effect via a giant switch statement?
        /// 
        /// r3: attacker pointer
        /// stack[0]: defender pointer
        /// stack[1]: thrown item pointer
        /// others: ?
        /// </summary>
        public int ApplyItemEffect
        {
            get
            {
                if (f_applyItemEffect)
                    return _applyItemEffect;
                _applyItemEffect = (int) (258680);
                f_applyItemEffect = true;
                return _applyItemEffect;
            }
        }
        private bool f_logMessageByIdWithPopupCheckUserTarget;
        private int _logMessageByIdWithPopupCheckUserTarget;

        /// <summary>
        /// Logs a message in the message log alongside a message popup, if some user check passes and the target hasn't fainted.
        /// 
        /// r0: user entity pointer
        /// r1: target entity pointer
        /// r2: message ID
        /// </summary>
        public int LogMessageByIdWithPopupCheckUserTarget
        {
            get
            {
                if (f_logMessageByIdWithPopupCheckUserTarget)
                    return _logMessageByIdWithPopupCheckUserTarget;
                _logMessageByIdWithPopupCheckUserTarget = (int) (453856);
                f_logMessageByIdWithPopupCheckUserTarget = true;
                return _logMessageByIdWithPopupCheckUserTarget;
            }
        }
        private bool f_generateOuterRingFloor;
        private int _generateOuterRingFloor;

        /// <summary>
        /// Generates a floor layout with a 4x2 grid of rooms, surrounded by an outer ring of hallways.
        /// 
        /// r0: floor properties
        /// </summary>
        public int GenerateOuterRingFloor
        {
            get
            {
                if (f_generateOuterRingFloor)
                    return _generateOuterRingFloor;
                _generateOuterRingFloor = (int) (388212);
                f_generateOuterRingFloor = true;
                return _generateOuterRingFloor;
            }
        }
        private bool f_initMinimapDisplayTile;
        private int _initMinimapDisplayTile;

        /// <summary>
        /// Used to initialize an instance of struct minimap_display_tile
        /// 
        /// r0: Pointer to struct to init
        /// r1: Seems to be a pointer to the file that stores minimap icons or something like that
        /// </summary>
        public int InitMinimapDisplayTile
        {
            get
            {
                if (f_initMinimapDisplayTile)
                    return _initMinimapDisplayTile;
                _initMinimapDisplayTile = (int) (384468);
                f_initMinimapDisplayTile = true;
                return _initMinimapDisplayTile;
            }
        }
        private bool f_dungeonZInit;
        private int _dungeonZInit;

        /// <summary>
        /// Zero-initializes the dungeon struct pointed to by the master dungeon pointer.
        /// 
        /// No params.
        /// </summary>
        public int DungeonZInit
        {
            get
            {
                if (f_dungeonZInit)
                    return _dungeonZInit;
                _dungeonZInit = (int) (10320);
                f_dungeonZInit = true;
                return _dungeonZInit;
            }
        }
        private bool f_generateItem;
        private int _generateItem;

        /// <summary>
        /// Initializes an item struct with the given information.
        /// 
        /// This wraps InitItem, but with extra logic to resolve the item's stickiness. It also calls GenerateMoneyQuantity for Poké.
        /// 
        /// r0: pointer to item to initialize
        /// r1: item ID
        /// r2: quantity
        /// r3: stickiness type (enum gen_item_stickiness)
        /// </summary>
        public int GenerateItem
        {
            get
            {
                if (f_generateItem)
                    return _generateItem;
                _generateItem = (int) (437668);
                f_generateItem = true;
                return _generateItem;
            }
        }
        private bool f_shouldMovePlayAlternativeAnimation;
        private int _shouldMovePlayAlternativeAnimation;

        /// <summary>
        /// Checks whether a moved used by a monster should play its alternative animation. Includes checks for Curse, Snore, Sleep Talk, Solar Beam and 2-turn moves.
        /// 
        /// r0: Pointer to the entity that used the move
        /// r1: Move pointer
        /// return: True if the move should play its alternative animation
        /// </summary>
        public int ShouldMovePlayAlternativeAnimation
        {
            get
            {
                if (f_shouldMovePlayAlternativeAnimation)
                    return _shouldMovePlayAlternativeAnimation;
                _shouldMovePlayAlternativeAnimation = (int) (301092);
                f_shouldMovePlayAlternativeAnimation = true;
                return _shouldMovePlayAlternativeAnimation;
            }
        }
        private Overlay29Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay29Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
