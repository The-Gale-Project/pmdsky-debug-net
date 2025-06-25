// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// List of functions within ARM9 with relative address locations as their values.
    /// </summary>
    public partial class Arm9Functions : KaitaiStruct
    {
        public static Arm9Functions FromFile(string fileName)
        {
            return new Arm9Functions(new KaitaiStream(fileName));
        }

        public Arm9Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Arm9Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_getAdvancedMenuResult = false;
            f_getMainCharacter3MemberIdx = false;
            f_isMonsterOnTeam = false;
            f_copyLogFrom = false;
            f_isItemForSpecialSpawnInBag = false;
            f_getRankStorageSize = false;
            f_render3d64Texture = false;
            f_copyMovesetTo = false;
            f_canDungeonBeUsedForMission = false;
            f_isEmptyString = false;
            f_addItemToKecleonShop1 = false;
            f_incrementNbDungeonsCleared = false;
            f_closeAdvancedTextBox = false;
            f_setAreaNameBoxState3 = false;
            f_memLocateUnset = false;
            f_countNbOfValidItemsInStorage = false;
            f_setFlagsForHeldItemInBag = false;
            f_openPackFile = false;
            f_alreadyHaveMission = false;
            f_getMonsterLevelFromSpawnEntry = false;
            f_getNbFloorsDungeonGroup = false;
            f_clampedLn = false;
            f_animationControlGetAllocForMaxFrame = false;
            f_copyMoveTo = false;
            f_hasMonsterBeenAttackedInDungeons = false;
            f_isHeldItemInBag = false;
            f_getMoveAccuracyOrAiChance = false;
            f_is2TurnsMove = false;
            f_deleteWanTableEntryVeneer = false;
            f_getPpIncrease = false;
            f_getDungeonTipShown = false;
            f_getFreeArenaDefault = false;
            f_loadItemPspi2n = false;
            f_updateTextBox = false;
            f_getBaseFormBurmyWormadamShellosGastrodonCherrim = false;
            f_getDisplayedBuyPrice = false;
            f_setMonsterId = false;
            f_eventFlagBackup = false;
            f_memZero16 = false;
            f_allManip1 = false;
            f_getBaseFormCastformDeoxysCherrim = false;
            f_noteSaveBase = false;
            f_getMissionRank = false;
            f_initSpecialEpisodeHero = false;
            f_getFirstEmptyMemberIdx = false;
            f_debugDisplay = false;
            f_getAdvancedTextBoxFlags2 = false;
            f_isRegularAttackOrProjectile = false;
            f_isOneHitKoMove = false;
            f_getFirstUnequippedItemOfType = false;
            f_applySitrusBerryBoostToGroundMonster = false;
            f_setMonsterLevelAndId = false;
            f_updateScrollBox = false;
            f_loadWanTableEntryFromPackUseProvidedMemory = false;
            f_normalizeTreasureBox = false;
            f_createParentMenuWrapper = false;
            f_getRngSeed = false;
            f_isMissionTypeSpecialEpisode = false;
            f_getExclusiveItem = false;
            f_convertStorageItemAtIdxToBulkItem = false;
            f_removeItemFromKecleonShop1 = false;
            f_setPokemonBattled = false;
            f_addMoneyCarried = false;
            f_startAutoloadDoneCallback = false;
            f_incrementExclusiveMonsterCounts = false;
            f_updatePortraitBox = false;
            f_initDebugStripped3 = false;
            f_selectWaza = false;
            f_unloadFile = false;
            f_manipMoves2v1 = false;
            f_getColorCodePaletteOffset = false;
            f_setItemAcquired = false;
            f_mIiUncompressBackward = false;
            f_getMoneyStored = false;
            f_decompressAtNormal = false;
            f_isSimpleMenuActive = false;
            f_randRange = false;
            f_getInfoGroundMoveset = false;
            f_initInventoryMenuInput = false;
            f_getMovesetEggPtr = false;
            f_drawChar = false;
            f_setAdventureLogStructLocation = false;
            f_isIqEnabled = false;
            f_isCopyingMove = false;
            f_generateMission = false;
            f_dungeonRequestsDone = false;
            f_handleSir0TranslationVeneer = false;
            f_manipMoves1v1 = false;
            f_getName = false;
            f_changeBgm = false;
            f_sortKecleonItems2 = false;
            f_getSecondFormIfValid = false;
            f_getNbItemAcquired = false;
            f_canSendItem = false;
            f_getNbMoves = false;
            f_haltProcessDisp = false;
            f_setStringAccuracy = false;
            f_removeActiveMembersFromAllTeams = false;
            f_isTextBoxActive = false;
            f_debugPrint0 = false;
            f_getPlayTimeSeconds = false;
            f_arm9LoadUnkFieldNa0x2029Ec8 = false;
            f_generateAllPossibleDungeonsList = false;
            f_applyCalciumBoostToGroundMonster = false;
            f_strcmpTagVeneer = false;
            f_getItemPaletteId = false;
            f_copy16BitsFrom = false;
            f_overlayIsLoaded = false;
            f_countStickyItemsInBag = false;
            f_restoreScriptVariableValues = false;
            f_divideFixedPoint64 = false;
            f_getAcceptedMission = false;
            f_isAffectedByTaunt = false;
            f_getFirstMatchingMemberIdx = false;
            f_deleteAllPossibleMonstersList = false;
            f_getHeroMemberIdx = false;
            f_loadScriptVariableValueSum = false;
            f_getNbItemsInBag = false;
            f_removeItemNoHole = false;
            f_removeEmptyItemsInBag = false;
            f_decompressAtNormalVeneer = false;
            f_getDungeonModeSpecial = false;
            f_isCollectionMenuState3 = false;
            f_setActorTalkSub = false;
            f_initMainTeamAfterQuiz = false;
            f_setNbBigTreasureWins = false;
            f_getSize = false;
            f_isEdible = false;
            f_createMemArena = false;
            f_interruptMasterEnable = false;
            f_getMonsterIdFromSpawnEntry = false;
            f_cleanStickyItemsInBag = false;
            f_getEvolutions = false;
            f_checkMissionRestrictions = false;
            f_closeOptionsMenu = false;
            f_copyAndInterleaveWrapper = false;
            f_manipMoves1v2 = false;
            f_getEncodedHalfword = false;
            f_initEventFlagScriptVars = false;
            f_getActualBuyPrice = false;
            f_eventFlagBackupVeneer = false;
            f_initDebugStripped4 = false;
            f_areItemsEquivalent = false;
            f_getDungeonGroup = false;
            f_countJobListMissions = false;
            f_playSe = false;
            f_initWanTable = false;
            f_createAdvancedMenu = false;
            f_isMonsterMissionAllowed = false;
            f_updateAlertBox = false;
            f_isThrownItem = false;
            f_cardPullOut = false;
            f_isNotMoney = false;
            f_setCollectionMenuField0x1C8 = false;
            f_getItemSpriteId = false;
            f_initPortraitParamsWithMonsterId = false;
            f_removeEmptyItems = false;
            f_setRngSeed = false;
            f_enableAllLearnableIqSkills = false;
            f_playSeByIdVolume = false;
            f_negateFixedPoint64 = false;
            f_getUnlockedTacticFlags = false;
            f_fileRead = false;
            f_strncpySimple = false;
            f_isValidTargetItem = false;
            f_updateDebugMenu = false;
            f_newWindowScreenCheck = false;
            f_loadScriptVariableValue = false;
            f_createCollectionMenu = false;
            f_updateOptionsMenu = false;
            f_isAvailableItem = false;
            f_shuffleHiddenPower = false;
            f_getTypeFunc = false;
            f_isFutureDungeon = false;
            f_allocateTemp1024ByteBufferFromPool = false;
            f_fileSeek = false;
            f_loadAnimationFrameAndIncrementInAnimationControl = false;
            f_getMoveCritChance = false;
            f_validateLegendaryChallengeMission = false;
            f_dungeonFloorToGroupFloor = false;
            f_memsetSimple = false;
            f_setExclusiveItemEffect = false;
            f_setActorTalkMainAndActorTalkSub = false;
            f_getMonsterEvoStatus = false;
            f_isPunchMove = false;
            f_setQuestionMarks = false;
            f_showKeyboard = false;
            f_getActualSellPrice = false;
            f_playSeLoad = false;
            f_updateAreaNameBox = false;
            f_isMonsterIllegalForMissions = false;
            f_setPortraitOffset = false;
            f_getSynthItem = false;
            f_getLanguageType = false;
            f_start = false;
            f_createDebugMenu = false;
            f_createTeamSelectionMenu = false;
            f_clearMissionData = false;
            f_rescueInventoryZInit = false;
            f_isGameModeRescue = false;
            f_render3d64Texture0x7 = false;
            f_noteLoadBase = false;
            f_getNbEggsHatched = false;
            f_setChallengeLetterCleared = false;
            f_getRegenSpeed = false;
            f_getNbMovesLearned = false;
            f_getHero = false;
            f_isItemValid = false;
            f_findAvailableMemBlock = false;
            f_getSpeedStatus = false;
            f_playBgmByIdVolume = false;
            f_getActiveRosterIndex = false;
            f_resumeSimpleMenu = false;
            f_transformPaletteDataWithFlushDivideFade = false;
            f_isItemInTimeDarkness = false;
            f_getMainCharacter1MemberIdx = false;
            f_cardBackupError = false;
            f_itemAtTableIdx = false;
            f_countNbOfValidItemsInTimeDarknessInStorage = false;
            f_initItem = false;
            f_getItemCategory = false;
            f_gendersEqual = false;
            f_getConversion2ConvertToType = false;
            f_failsWhileMuzzled = false;
            f_setSpriteIdForAnimationControl = false;
            f_isRecoilMove = false;
            f_gendersEqualNotGenderless = false;
            f_closeScrollBox = false;
            f_getAbilityString = false;
            f_isMainCharacter = false;
            f_closeAdvancedTextBox2 = false;
            f_setStringPower = false;
            f_canBeSnatched = false;
            f_getMainCharacter2MemberIdx = false;
            f_checkChecksumInvalid = false;
            f_getEvoParameters = false;
            f_isScrollBoxActive = false;
            f_getShadowSize = false;
            f_initScriptVariableValues = false;
            f_convertPointersSir0 = false;
            f_copyProgressInfoFromScratchTo = false;
            f_setCollectionMenuField0x1A4 = false;
            f_updateSimpleMenu = false;
            f_appendMissionSummary = false;
            f_memcpy32 = false;
            f_readMonsterFromSave = false;
            f_strncpyName = false;
            f_uMultiplyFixedPoint64 = false;
            f_getSystemClock = false;
            f_copyTacticString = false;
            f_getMonsterGender = false;
            f_svcWaitByLoop = false;
            f_render3dElement64 = false;
            f_isInvalidMoveset = false;
            f_getRankupPoints = false;
            f_replaceWanFromBinFile = false;
            f_wonderMailPasswordToMission = false;
            f_applyLevelUpBoostsToGroundMonster = false;
            f_handleSir0Translation = false;
            f_applyGummiBoostsToGroundMonster = false;
            f_getExplorerMazeMonster = false;
            f_setMoneyStored = false;
            f_isMonsterIdInNormalRange = false;
            f_checkOptionsMenuField0x1A4 = false;
            f_isMenuOptionActive = false;
            f_allInventoriesZInit = false;
            f_setAndPlayAnimationForAnimationControl = false;
            f_getFamilyIndex = false;
            f_incrementNbEggsHatched = false;
            f_removeItemFromKecleonShop2 = false;
            f_updateParentMenu = false;
            f_writeByteFromMemoryPointer = false;
            f_canMonsterBeUsedForMission = false;
            f_testItemAiFlag = false;
            f_groundToDungeonMoveset = false;
            f_debugPrint = false;
            f_isTeamSelectionMenuActive = false;
            f_newWindow = false;
            f_initDebugStripped2 = false;
            f_getAllPossibleMonsters = false;
            f_initCp15 = false;
            f_createSimpleMenuFromStringIds = false;
            f_isSpecialEpisodeOpen = false;
            f_loadScriptVariableRaw = false;
            f_removeHolderForItemInBag = false;
            f_allocAudioCommand = false;
            f_getHeldButtons = false;
            f_getKeyboardStatus = false;
            f_getMaxPp = false;
            f_preprocessStringFromId = false;
            f_memset32 = false;
            f_isAOrBPressed = false;
            f_sendAudioCommand2 = false;
            f_getBodySize = false;
            f_playBgmByIdVeneer = false;
            f_isMissionSuspendedAndValid = false;
            f_getHpBoostFromExclusiveItems = false;
            f_isSameMove = false;
            f_countNbOfItemsInStorage = false;
            f_getFileLengthInPack = false;
            f_showStringInDialogueBox = false;
            f_printMoveOptionMenu = false;
            f_isMoneyAllowed = false;
            f_initWindowTrailer = false;
            f_getItemActionName = false;
            f_executeCopyToFlatVramCommand = false;
            f_removeBulkItemInStorage = false;
            f_closeControlsChart = false;
            f_uDivideFixedPoint64 = false;
            f_rand32Bit = false;
            f_getWeightMultiplier = false;
            f_createPortraitBox = false;
            f_learnMoves = false;
            f_copyLogTo = false;
            f_multiplyByFixedPoint = false;
            f_copyNStringFromId = false;
            f_randInt = false;
            f_enqueueRender3d64Tiling = false;
            f_incrementNbFainted = false;
            f_getIqGroup = false;
            f_getBaseOffensiveStat = false;
            f_setActiveInventory = false;
            f_guestMonsterToGroundMonster = false;
            f_enableAllInterrupts = false;
            f_getPressedButtons = false;
            f_canThrowItems = false;
            f_getMoneyCarried = false;
            f_isSkyExclusiveDungeon = false;
            f_playSeFullSpec = false;
            f_updateWindow = false;
            f_isControlsChartActive = false;
            f_soundResume = false;
            f_addMoneyStored = false;
            f_getAbility = false;
            f_initWindowInput = false;
            f_anyDungeonRequestsDone = false;
            f_applyExclusiveItemStatBoosts = false;
            f_generateKecleonItems1 = false;
            f_getMoveActualAccuracy = false;
            f_setNbRecycled = false;
            f_allManip2 = false;
            f_getMoveTargetAndRange = false;
            f_initDungeonListScriptVars = false;
            f_createAdvancedTextBox = false;
            f_countNbItemsOfTypeInStorage = false;
            f_getBagCapacity = false;
            f_getMainTeamNameWithCheck = false;
            f_countItemTypeInBag = false;
            f_initRender3dElement64 = false;
            f_createTextBox = false;
            f_getNbFainted = false;
            f_copyProgressInfoFromScratchFrom = false;
            f_incrementNbBigTreasureWins = false;
            f_svcSoftReset = false;
            f_generateMissionDetailsStruct = false;
            f_getMonsterPreEvolution = false;
            f_getBgRegionArea = false;
            f_removeActiveMembersFromSpecialEpisodeTeam = false;
            f_stringFromId = false;
            f_createOptionsMenu = false;
            f_setMemAllocatorParams = false;
            f_getBaseHp = false;
            f_fixedPoint64IsNegative = false;
            f_getWindowContents = false;
            f_isAlertBoxActive = false;
            f_loadPortrait = false;
            f_resetPlannedVramTransfer = false;
            f_getExecuteSpecialEpisodeType = false;
            f_getNbRecycled = false;
            f_decodeFragmentByteAssemblyTable = false;
            f_getSpawnThreshold = false;
            f_canEvolve = false;
            f_getDisplayedSellPrice = false;
            f_isLevelResetDungeon = false;
            f_loadFileInPackWithPackId = false;
            f_baseFormsEqual = false;
            f_isOptionsMenuActive = false;
            f_clampComponentAbs = false;
            f_ceilFixedPoint = false;
            f_removeItemNoHoleCheck = false;
            f_copyProgressInfoFrom = false;
            f_removeActiveMembersFromRescueTeam = false;
            f_applyGummiBoostsToTeamMember = false;
            f_loadFileFromRom = false;
            f_setActiveInventoryToMain = false;
            f_getMoveType = false;
            f_initMove = false;
            f_getOptionsMenuResult = false;
            f_getKeyboardStringResult = false;
            f_isTeamSelectionMenuState3 = false;
            f_stopBgmCommand = false;
            f_sprintfSystemClock = false;
            f_resetPlayTimer = false;
            f_closeAreaNameBox = false;
            f_setDungeonTipShown = false;
            f_getMaxReachedFloor = false;
            f_createSimpleMenu = false;
            f_initSoundSystem = false;
            f_recruitSpecialPokemonLog = false;
            f_getExclusiveItemOffset = false;
            f_isMonsterAffectedByGravelyrockGroundMode = false;
            f_setMonsterFlag1 = false;
            f_rand16Bit = false;
            f_loadWteFromRom = false;
            f_femaleToMaleForm = false;
            f_fatalError = false;
            f_convertStorageItemAtIdxToItem = false;
            f_fixedPoint64ToInt = false;
            f_soundDriverReset = false;
            f_getFileLengthInPackWithPackNb = false;
            f_setScrollBoxState7 = false;
            f_isAreaNameBoxActive = false;
            f_isItemUsableNow = false;
            f_getMoveRangeId = false;
            f_removeActiveMembersFromMainTeam = false;
            f_setUnkAdvancedTextBoxFn = false;
            f_getItemBuyPrice = false;
            f_getPartnerMemberIdx = false;
            f_closeCollectionMenu = false;
            f_removePokeItemsInBag = false;
            f_getBagNameString = false;
            f_memcpySimple = false;
            f_binToDecFixedPoint = false;
            f_pointsToZero = false;
            f_findFirstFreeMovesetIdx = false;
            f_isHm = false;
            f_getSimpleMenuField0x1A4 = false;
            f_dungeonMoveToGroundMove = false;
            f_removeAllItemsStartingAt = false;
            f_getAdventureLogCompleted = false;
            f_initSpecialEpisodeExtraPartner = false;
            f_setupAndShowKeyboard = false;
            f_globalProgressAlloc = false;
            f_revertGiratinaAndShaymin = false;
            f_getIqSkillStringId = false;
            f_isMonsterValid = false;
            f_getFirstNotRealMoveInTimeDarkness = false;
            f_atoiTagVeneer = false;
            f_roundUpDiv256 = false;
            f_isCastform = false;
            f_getMissionByTypeAndDungeon = false;
            f_isTicketItem = false;
            f_isItemInBag = false;
            f_getItemMoveId = false;
            f_setSpecialEpisodeType = false;
            f_isMonsterMissionAllowedStory = false;
            f_getDexNumber = false;
            f_getItemSellPrice = false;
            f_removeFirstUnequippedItemOfType = false;
            f_isTreasureBox = false;
            f_resetGlobalProgress = false;
            f_applyGummiBoostsGroundMode = false;
            f_isRealMoveInTimeDarkness = false;
            f_isMovesetValid = false;
            f_scenarioFlagBackup = false;
            f_fileOpen = false;
            f_unloadOverlay = false;
            f_getPartyMembers = false;
            f_createAdvancedTextBoxInternal = false;
            f_findWanTableEntry = false;
            f_applyZincBoostToGroundMonster = false;
            f_initBulkItem = false;
            f_delayWteFree = false;
            f_allowPortraitDefault = false;
            f_setPortraitLayout = false;
            f_getAdvancedMenuCurrentOption = false;
            f_loadTblTalk = false;
            f_showStringIdInDialogueBox = false;
            f_playWindowInputSound = false;
            f_getMoveMaxGinsengBoost = false;
            f_addItemToStorage = false;
            f_getLanguage = false;
            f_checkStringSave = false;
            f_transmuteHeldItemInBag = false;
            f_strncpySimpleNoPad = false;
            f_isAdvancedMenuActive = false;
            f_getCanMoveFlag = false;
            f_isValidTeamMember = false;
            f_dungeonSwapIdToIdx = false;
            f_printMark = false;
            f_planCopyTextureToTextureVram = false;
            f_setCollectionMenuField0x1B2 = false;
            f_writeItemsToSave = false;
            f_fixedPoint64CmpLt = false;
            f_getMaxRescueAttempts = false;
            f_setPortraitEmotion = false;
            f_isReflectedByMagicCoat = false;
            f_closeDialogueBox = false;
            f_setMaxReachedFloor = false;
            f_isItemValidVeneer = false;
            f_clearAdventureLogStruct = false;
            f_getAdventureLogDungeonFloor = false;
            f_copyMovesetFrom = false;
            f_deleteWindow = false;
            f_deleteWanTableEntry = false;
            f_decompressAtHalf = false;
            f_getWindowRectangle = false;
            f_getMoveMessageFromId = false;
            f_loadScriptVariableValueAtIndex = false;
            f_portraitBoxNeedsUpdate = false;
            f_taskProcBoot = false;
            f_getRankString = false;
            f_readItemsFromSave = false;
            f_applyLifeSeedBoostToGroundMonster = false;
            f_generateAllPossibleMonstersList = false;
            f_getDebugFlag = false;
            f_resumeAdvancedMenu = false;
            f_seChangeVolume = false;
            f_updateDialogueBox = false;
            f_writeSaveFile = false;
            f_strcpySimple = false;
            f_setNotifyNote = false;
            f_getAllBaseForms = false;
            f_checkParentMenuField0x1A0 = false;
            f_isGummi = false;
            f_getRankUpEntry = false;
            f_loadAlert = false;
            f_getExp = false;
            f_isExclusiveItemForMonster = false;
            f_createAreaNameBox = false;
            f_arm9StoreUnkFieldNa0x2029Ed8 = false;
            f_addFixedPoint64 = false;
            f_checkAcceptedMissionByTypeAndDungeon = false;
            f_isDialogueBoxActive = false;
            f_createTextBoxWithArg = false;
            f_setDebugLogFlag = false;
            f_getThrownItemQuantityLimit = false;
            f_oSiReferSymbol = false;
            f_uFixedPoint64CmpLt = false;
            f_isMissionValid = false;
            f_zInit8 = false;
            f_addItemToKecleonShop2 = false;
            f_wanHasAnimationGroup = false;
            f_setActorTalkMain = false;
            f_mainLoop = false;
            f_setHolderForItemInBag = false;
            f_retrieveFromItemList2 = false;
            f_debugPrintSystemClock = false;
            f_setAdvancedTextBoxState5 = false;
            f_loadScriptVariableValueBytes = false;
            f_render3d64Quadrilateral = false;
            f_getMobilityType = false;
            f_getWindow = false;
            f_saveScriptVariableValue = false;
            f_getOptionsMenuStates = false;
            f_getLvlUpEntry = false;
            f_getNbAdventures = false;
            f_bulkItemToItem = false;
            f_changeBgm2 = false;
            f_printClearMark = false;
            f_fileGetSize = false;
            f_getUnlockedTactics = false;
            f_dungeonGoesUp = false;
            f_incrementNbSkyGiftsSent = false;
            f_getSpriteSize = false;
            f_isItemWithFlagsInBag = false;
            f_setCollectionMenuField0x1Bc = false;
            f_incrementNbFriendRescues = false;
            f_getActorMatchingStorageId = false;
            f_decompressAtFromMemoryPointerVeneer = false;
            f_generateDailyMissions = false;
            f_closeTextBox = false;
            f_initMemArena = false;
            f_isAdvancedTextBoxActive = false;
            f_loadWazaP2 = false;
            f_getStringFromFileVeneer = false;
            f_removeItemAtIdxInStorage = false;
            f_render3d64Nothing = false;
            f_hidePortraitBox = false;
            f_render3d64WindowFrame = false;
            f_getBagCapacitySpecialEpisode = false;
            f_eventFlagResume = false;
            f_initDebugStripped6 = false;
            f_setSentryDutyGamePoints = false;
            f_removeItem = false;
            f_spriteTypeInWanTable = false;
            f_createJobSummary = false;
            f_findItemInInventory = false;
            f_tryAddMonsterToActiveTeam = false;
            f_getSpriteFileSize = false;
            f_setCollectionMenuWidth = false;
            f_getMonsterFlag1 = false;
            f_setPokemonJoined = false;
            f_applyNectarBoostToGroundMonster = false;
            f_getMoveBasePp = false;
            f_isHealingWishOrLunarDance = false;
            f_randomizeDemoActors = false;
            f_getScenarioBalance = false;
            f_setEnterDungeon = false;
            f_ensureValidItem = false;
            f_getMoveNbStrikes = false;
            f_performPlannedTextureVramTransfer = false;
            f_closeTeamSelectionMenu = false;
            f_getGroundNameId = false;
            f_loadWazaP = false;
            f_getVictoriesOnOneFloor = false;
            f_getAbilityDescStringId = false;
            f_readMonsterInfoFromSave = false;
            f_removeAllItems = false;
            f_isExpEnabledInDungeon = false;
            f_removeEquivItemNoHole = false;
            f_removeHeldItemNoHole = false;
            f_closeAlertBox = false;
            f_incrementNbEvolutions = false;
            f_readQuickSaveInfo = false;
            f_getTypeStringId = false;
            f_isSoundMove = false;
            f_analyzeText = false;
            f_getItemIndex = false;
            f_getMovesetHmTmPtr = false;
            f_getActiveTeamMember = false;
            f_isNoLossPenaltyDungeon = false;
            f_getLearnableIqSkills = false;
            f_createMonsterSummaryFromTeamMember = false;
            f_bagHasExclusiveItemTypeForMonster = false;
            f_applyGinsengToGroundMonster = false;
            f_nitroMain = false;
            f_copyBitsFrom = false;
            f_getNbSkyGiftsSent = false;
            f_setParentMenuState7 = false;
            f_removeItemByIdAndStackNoHole = false;
            f_loadWteFromFileDirectory = false;
            f_setAdvancedTextBoxField0x1C2 = false;
            f_getTurnLimit = false;
            f_canEnemyEvolve = false;
            f_checkDebugMenuField0x1A4 = false;
            f_getSpeciesString = false;
            f_createDialogueBox = false;
            f_getPartner = false;
            f_initAnimationControl = false;
            f_disableAllIqSkills = false;
            f_getMoveCategory = false;
            f_getDungeonResultMsg = false;
            f_isParentMenuActive = false;
            f_getMoveAiWeight = false;
            f_isItemInTreasureBoxes = false;
            f_switchAnimationControlToNextFrame = false;
            f_sortItemsInStorage = false;
            f_createAlertBox = false;
            f_isTrappingMove = false;
            f_getMoveBasePower = false;
            f_setVictoriesOnOneFloor = false;
            f_updateFadeStatus = false;
            f_strcmpMonsterName = false;
            f_manipMoves2v2 = false;
            f_iqSkillFlagTest = false;
            f_fixedPoint32To64 = false;
            f_countNbItemsOfTypeInBag = false;
            f_getStatBoostsForMonsterSummary = false;
            f_loadSynthBin = false;
            f_initDungeonInit = false;
            f_writeMonsterInfoToSave = false;
            f_teamSelectionMenuGetItem = false;
            f_setAdventureLogCompleted = false;
            f_isRealMove = false;
            f_dungeonRequestsDoneWrapper = false;
            f_itemZInit = false;
            f_gendersNotEqualNotGenderless = false;
            f_clearWindow = false;
            f_sortItemsInBag = false;
            f_applyIronBoostToGroundMonster = false;
            f_getAvailableItemDeliveryList = false;
            f_closeParentMenu = false;
            f_getMonsterGenderVeneer = false;
            f_getAllocArenaDefault = false;
            f_deleteAllPossibleDungeonsList = false;
            f_initWorldMapScriptVars = false;
            f_getStringFromFile = false;
            f_dataTransferInit = false;
            f_validateNormalChallengeMission = false;
            f_fileInitVeneer = false;
            f_setTeamSetupHeroAndPartnerOnly = false;
            f_isUnown = false;
            f_render3d64Rectangle = false;
            f_getLoadedWanTableEntry = false;
            f_getCurrentTeamNameString = false;
            f_openWaza = false;
            f_printBadgeMark = false;
            f_sortItemList = false;
            f_getNameString = false;
            f_memArenaAlloc = false;
            f_getGameMode = false;
            f_checkSimpleMenuField0x1A0 = false;
            f_getChanceAsleep = false;
            f_joinedAtRangeCheck = false;
            f_randRangeSafe = false;
            f_isSongOver = false;
            f_getExclusiveItemParameter = false;
            f_handleFades = false;
            f_getOutlawLevel = false;
            f_initMemAllocTableVeneer = false;
            f_showDialogueBox = false;
            f_disableAllInterrupts = false;
            f_setUnkAdvancedTextBoxWindowFn = false;
            f_setDebugFlag = false;
            f_isStorableItem = false;
            f_getItemNameFormatted = false;
            f_isCherrim = false;
            f_isMonsterNotNicknamed = false;
            f_isExclusiveItemIdForMonster = false;
            f_formatMoveString = false;
            f_getOutlawLeaderLevel = false;
            f_createSimpleMenuInternal = false;
            f_setMonsterFlag2 = false;
            f_getSosMailCount = false;
            f_createScrollBoxMulti = false;
            f_getMainTeamName = false;
            f_setAdvancedTextBoxPartialMenu = false;
            f_missionToWonderMailPassword = false;
            f_setTeamSetupHeroOnly = false;
            f_playBgmByIdVolumeVeneer = false;
            f_interruptMasterDisable = false;
            f_strncpySimpleNoPadSafe = false;
            f_cardPullOutWithStatus = false;
            f_playBgmById = false;
            f_computeSpecialCounters = false;
            f_initMoveCheckId = false;
            f_readSaveHeader = false;
            f_createParentMenu = false;
            f_isShaymin = false;
            f_getItemIdFromList = false;
            f_storageZInit = false;
            f_applyGravelyrockBoostToGroundMonster = false;
            f_createScrollBoxSingle = false;
            f_getEquivItemIndex = false;
            f_waitForever = false;
            f_isDojoDungeon = false;
            f_keyWaitInit = false;
            f_render3d64Tiling = false;
            f_memLocateSet = false;
            f_allocateWanTableEntry = false;
            f_fileClose = false;
            f_setBaseStatsMovesGroundMonster = false;
            f_readStringFromDialogueBox = false;
            f_isStorageFull = false;
            f_debugPrintTrace = false;
            f_getNameWithGender = false;
            f_processWte = false;
            f_randIntSafe = false;
            f_hasStorableItems = false;
            f_appendMissionTitle = false;
            f_uMultiplyByFixedPoint = false;
            f_manipBgmPlayback = false;
            f_getOutlawMinionLevel = false;
            f_playTimerTick = false;
            f_changeGiratinaFormIfSkyDungeon = false;
            f_setNbSkyGiftsSent = false;
            f_specialEpisodeInventoryZInit = false;
            f_isDeoxys = false;
            f_stopMe = false;
            f_geomSetVertexCoord16 = false;
            f_closeTextBox2 = false;
            f_getTeamMember = false;
            f_getRank = false;
            f_loadCursors = false;
            f_closePortraitBox = false;
            f_closeSimpleMenu = false;
            f_getDamageSource = false;
            f_copyProgressInfoTo = false;
            f_setScreenWindowsColor = false;
            f_getMoveBasePowerGround = false;
            f_getLeaderChangeFlag = false;
            f_initDebugStripped5 = false;
            f_areMissionsEquivalent = false;
            f_incrementNbSteals = false;
            f_getDsFirmwareUserSettingsVeneer = false;
            f_allocAndLoadFileInPack = false;
            f_getExclusiveItemOffsetEnsureValid = false;
            f_playBgm2 = false;
            f_isShoppableItem = false;
            f_printIqSkillsMenu = false;
            f_getItemAtIdx = false;
            f_initRender3dData = false;
            f_isBagFull = false;
            f_intToFixedPoint64 = false;
            f_getExplorerMazeTeamName = false;
            f_getMainCharacter1 = false;
            f_copyMoveFrom = false;
            f_setBothScreensWindowsColor = false;
            f_setDungeonConquest = false;
            f_getNbFloors = false;
            f_memZero = false;
            f_getMainCharacter2 = false;
            f_wanTableSpriteHasAnimationGroup = false;
            f_formatMoveStringMore = false;
            f_loadWanTableEntry = false;
            f_loadDseFile = false;
            f_seChangePan = false;
            f_playMe = false;
            f_svcCpuSet = false;
            f_getAtSize = false;
            f_drawTextInWindow = false;
            f_dataTransferStop = false;
            f_countItemTypeInStorage = false;
            f_playBgm = false;
            f_isSpecialEpisodeDungeon = false;
            f_doAutoload = false;
            f_isItemAvailableInDungeonGroup = false;
            f_copyStringFromId = false;
            f_initKaomadoStream = false;
            f_initDebugLogFlag = false;
            f_getEvolutionPossibilities = false;
            f_rgb8ToRgb5 = false;
            f_isNot2TurnsMoveOrSketch = false;
            f_isThawingMove = false;
            f_clearItem = false;
            f_getItemCategoryVeneer = false;
            f_createParentMenuFromStringIds = false;
            f_initSpecialEpisodePartners = false;
            f_readStringSave = false;
            f_getCharWidth = false;
            f_getMoveMaxGinsengBoostGround = false;
            f_initDebugStripped1 = false;
            f_getSentryDutyGamePoints = false;
            f_sendAudioCommand = false;
            f_closeSynthBin = false;
            f_disableIqSkill = false;
            f_createControlsChart = false;
            f_isForbiddenFloor = false;
            f_getExclusiveItemType = false;
            f_addItemToBag = false;
            f_strcmpTag = false;
            f_isInvalidForMission = false;
            f_initPreprocessorArgs = false;
            f_memcpy16 = false;
            f_generateAllPossibleDeliverList = false;
            f_getItemName = false;
            f_resumeParentMenu = false;
            f_dungeonToGroundMoveset = false;
            f_copyBitsTo = false;
            f_getRecruitRate1 = false;
            f_setActiveKecleonShop = false;
            f_unloadCurrentWazaP = false;
            f_getMoveName = false;
            f_loadFileInPack = false;
            f_unloadWte = false;
            f_loadMonsterMd = false;
            f_isAdvancedMenuActive2 = false;
            f_isTrapInvisibleWhenAttacking = false;
            f_getFadeStatus = false;
            f_setAnimationForAnimationControlInternal = false;
            f_isMoveRangeStringUser = false;
            f_getBaseForm = false;
            f_allKecleonShopsZInit = false;
            f_saveScriptVariableValueAtIndex = false;
            f_createTextBoxInternal = false;
            f_getTreasureBoxChances = false;
            f_getNbPrecedingFloors = false;
            f_doesTacticFollowLeader = false;
            f_dexNumbersEqual = false;
            f_joinedAtRangeCheck2 = false;
            f_playAdvancedTextBoxInputSound = false;
            f_stopBgm2 = false;
            f_loadWtuFromBin = false;
            f_getSpecialEpisodeType = false;
            f_loadWanTableEntryFromPack = false;
            f_loadStringFile = false;
            f_isAuraBow = false;
            f_getPerformanceFlagWithChecks = false;
            f_setMoneyCarried = false;
            f_getNbDungeonsCleared = false;
            f_memZero32 = false;
            f_getNbFriendRescues = false;
            f_getNbRecruited = false;
            f_copyItemAtIdx = false;
            f_getDungeonMode = false;
            f_stopSe = false;
            f_getNextIqSkill = false;
            f_getEquivBulkItemIdxInStorage = false;
            f_getSimpleMenuResult = false;
            f_removeItemInStorage = false;
            f_getMovesetLevelUpPtr = false;
            f_getNbPokemonBattled = false;
            f_initDebugFlag = false;
            f_canLearnIqSkill = false;
            f_initStandardItem = false;
            f_getBaseFormCastformCherrimDeoxys = false;
            f_getTalkLine = false;
            f_fixedPoint64IsZero = false;
            f_exclusiveItemEffectFlagTest = false;
            f_hasPlayedOldGame = false;
            f_addGuestMonster = false;
            f_appendProgPos = false;
            f_setMainTeamName = false;
            f_setAdvancedTextBoxField0x1C4 = false;
            f_canMonsterSpawn = false;
            f_dumpScriptVariableValues = false;
            f_isMovesetValidInTimeDarkness = false;
            f_deleteAllPossibleDeliverList = false;
            f_memFree = false;
            f_getReleasedStylus = false;
            f_isValidPortrait = false;
            f_specialProcAddItemToBag = false;
            f_retrieveFromItemList1 = false;
            f_getBaseDefensiveStat = false;
            f_setScenarioScriptVar = false;
            f_decrementStackItem = false;
            f_getCategoryString = false;
            f_isRecruitingAllowed = false;
            f_readSaveFile = false;
            f_dungeonSwapIdxToId = false;
            f_splitMemBlock = false;
            f_updateAdvancedMenu = false;
            f_getEvoFamily = false;
            f_storeDefaultTeamData = false;
            f_initICpuClear32 = false;
            f_setCollectionMenuField0x1A0 = false;
            f_render3d64RectangleMulticolor = false;
            f_updateCollectionMenu = false;
            f_getCurrentBagCapacity = false;
            f_createAdvancedTextBoxWithArg = false;
            f_addMissionToJobList = false;
            f_initPortraitParams = false;
            f_createParentMenuInternal = false;
            f_openAllPackFiles = false;
            f_getRecruitRate2 = false;
            f_getNbFloorsPlusOne = false;
            f_treasureBoxDropsEnabled = false;
            f_writeMonsterToSave = false;
            f_removeEquivItem = false;
            f_setAnimationForAnimationControl = false;
            f_saveScriptVariableValueBytes = false;
            f_setAdventureLogDungeonFloor = false;
            f_getRandomMovementChance = false;
            f_getNotifyNote = false;
            f_memAlloc = false;
            f_generateKecleonItems2 = false;
            f_playSeVolumeWrapper = false;
            f_itemToBulkItem = false;
            f_isAdventureLogNotEmpty = false;
            f_initScenarioScriptVars = false;
            f_doesNotSaveWhenEntering = false;
            f_scriptVariablesEqual = false;
            f_strcpyName = false;
            f_memAllocFlagsToBlockType = false;
            f_loadM2nAndN2m = false;
            f_preprocessString = false;
            f_atoiTag = false;
            f_closeDebugMenu = false;
            f_closeAdvancedMenu = false;
            f_getNameRaw = false;
            f_zinitScriptVariable = false;
            f_getDungeonResultString = false;
            f_stopBgm = false;
            f_setCollectionMenuVoidFn = false;
            f_getTime = false;
            f_needsItemToSpawn = false;
            f_addItemToBagNoHeld = false;
            f_getNbEvolutions = false;
            f_getMainCharacter3 = false;
            f_sortKecleonItems1 = false;
            f_specialEpisodeKecleonShopZInit = false;
            f_refillTeam = false;
            f_addBulkItemToStorage = false;
            f_getDexNumberVeneer = false;
            f_incrementNbAdventures = false;
            f_initMemAllocTable = false;
            f_isCollectionMenuActive = false;
            f_loadOverlay = false;
            f_getMaxItemsAllowed = false;
            f_applyProteinBoostToGroundMonster = false;
            f_getWanForAnimationControl = false;
            f_canMonsterBeUsedForMissionWrapper = false;
            f_checkTeamMemberIdx = false;
            f_decompressAtFromMemoryPointer = false;
            f_getDebugLogFlag = false;
            f_calcChecksum = false;
            f_getExclusiveItemForMonsterFromBag = false;
            f_updateControlsChart = false;
            f_writeQuickSaveInfo = false;
            f_setActiveTeam = false;
            f_getItemMoveId16 = false;
            f_geomSetTexImageParam = false;
            f_getEquippedThrowableItem = false;
            f_subFixedPoint = false;
            f_geomSwapBuffers = false;
            f_getSpeciesIqSkill = false;
            f_getNbBigTreasureWins = false;
            f_enableIqSkill = false;
            f_setSimpleMenuField0x1Ac = false;
            f_getMaxMembersAllowed = false;
            f_initDebug = false;
            f_isDebugMenuActive = false;
            f_isLosableItem = false;
            f_strncmpSimple = false;
            f_getInfoMoveGround = false;
            f_getNbPokemonJoined = false;
            f_multiplyFixedPoint64 = false;
            f_getMoveBasePowerFromId = false;
            f_showPortraitInPortraitBox = false;
            f_updateTeamSelectionMenu = false;
            f_updateAdvancedTextBox = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_getAdvancedMenuResult;
        private int _getAdvancedMenuResult;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: window_id
        /// return: ?
        /// </summary>
        public int GetAdvancedMenuResult
        {
            get
            {
                if (f_getAdvancedMenuResult)
                    return _getAdvancedMenuResult;
                _getAdvancedMenuResult = (int) (180228);
                f_getAdvancedMenuResult = true;
                return _getAdvancedMenuResult;
            }
        }
        private bool f_getMainCharacter3MemberIdx;
        private int _getMainCharacter3MemberIdx;

        /// <summary>
        /// Returns the team member index of the third main character for the given game mode, if valid, otherwise return -1.
        /// 
        /// In normal play, this will be invalid (-1). During special episodes, this will be 4 if there's a third main character.
        /// 
        /// return: team member index
        /// </summary>
        public int GetMainCharacter3MemberIdx
        {
            get
            {
                if (f_getMainCharacter3MemberIdx)
                    return _getMainCharacter3MemberIdx;
                _getMainCharacter3MemberIdx = (int) (350892);
                f_getMainCharacter3MemberIdx = true;
                return _getMainCharacter3MemberIdx;
            }
        }
        private bool f_isMonsterOnTeam;
        private int _isMonsterOnTeam;

        /// <summary>
        /// Checks if a given monster is on the exploration team (not necessarily the active party)?
        /// 
        /// Irdkwia's notes:
        ///   recruit_strategy=0: strict equality
        ///   recruit_strategy=1: relative equality
        /// 
        /// r0: monster ID
        /// r1: recruit_strategy
        /// return: bool
        /// </summary>
        public int IsMonsterOnTeam
        {
            get
            {
                if (f_isMonsterOnTeam)
                    return _isMonsterOnTeam;
                _isMonsterOnTeam = (int) (349380);
                f_isMonsterOnTeam = true;
                return _isMonsterOnTeam;
            }
        }
        private bool f_copyLogFrom;
        private int _copyLogFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// </summary>
        public int CopyLogFrom
        {
            get
            {
                if (f_copyLogFrom)
                    return _copyLogFrom;
                _copyLogFrom = (int) (330352);
                f_copyLogFrom = true;
                return _copyLogFrom;
            }
        }
        private bool f_isItemForSpecialSpawnInBag;
        private int _isItemForSpecialSpawnInBag;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: bool
        /// </summary>
        public int IsItemForSpecialSpawnInBag
        {
            get
            {
                if (f_isItemForSpecialSpawnInBag)
                    return _isItemForSpecialSpawnInBag;
                _isItemForSpecialSpawnInBag = (int) (61688);
                f_isItemForSpecialSpawnInBag = true;
                return _isItemForSpecialSpawnInBag;
            }
        }
        private bool f_getRankStorageSize;
        private int _getRankStorageSize;

        /// <summary>
        /// Gets the size of storage for the current rank.
        /// 
        /// return: storage size
        /// </summary>
        public int GetRankStorageSize
        {
            get
            {
                if (f_getRankStorageSize)
                    return _getRankStorageSize;
                _getRankStorageSize = (int) (331804);
                f_getRankStorageSize = true;
                return _getRankStorageSize;
            }
        }
        private bool f_render3d64Texture;
        private int _render3d64Texture;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[0]. Renders a render_3d_element_64 with type RENDER64_TEXTURE.
        /// 
        /// Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TEXTURE.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64Texture
        {
            get
            {
                if (f_render3d64Texture)
                    return _render3d64Texture;
                _render3d64Texture = (int) (127400);
                f_render3d64Texture = true;
                return _render3d64Texture;
            }
        }
        private bool f_copyMovesetTo;
        private int _copyMovesetTo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: write_info
        /// r1: buffer_write
        /// </summary>
        public int CopyMovesetTo
        {
            get
            {
                if (f_copyMovesetTo)
                    return _copyMovesetTo;
                _copyMovesetTo = (int) (84836);
                f_copyMovesetTo = true;
                return _copyMovesetTo;
            }
        }
        private bool f_canDungeonBeUsedForMission;
        private int _canDungeonBeUsedForMission;

        /// <summary>
        /// Returns whether a certain dungeon can be used when generating a mission.
        /// 
        /// Excluded dungeons include DUNGEON_ICE_AEGIS_CAVE, DUNGEON_DESTINY_TOWER, all Special Episode dungeons, dungeons with IDs greater than 174 (DUNGEON_STAR_CAVE), DUNGEON_CRYSTAL_CAVE and DUNGEON_CRYSTAL_CROSSING if PERFORMANCE_PROGRESS_LIST[9] is false, and any dungeon that does not have a dungeon mode of DMODE_OPEN_AND_REQUEST.
        /// 
        /// r0: Dungeon ID
        /// return: True if the specified dungeon can be part of a mission
        /// </summary>
        public int CanDungeonBeUsedForMission
        {
            get
            {
                if (f_canDungeonBeUsedForMission)
                    return _canDungeonBeUsedForMission;
                _canDungeonBeUsedForMission = (int) (405300);
                f_canDungeonBeUsedForMission = true;
                return _canDungeonBeUsedForMission;
            }
        }
        private bool f_isEmptyString;
        private int _isEmptyString;

        /// <summary>
        /// Checks if a null-terminated string is empty. A NULL pointer counts as empty.
        /// 
        /// r0: string
        /// return: whether the string is NULL or empty
        /// </summary>
        public int IsEmptyString
        {
            get
            {
                if (f_isEmptyString)
                    return _isEmptyString;
                _isEmptyString = (int) (174432);
                f_isEmptyString = true;
                return _isEmptyString;
            }
        }
        private bool f_addItemToKecleonShop1;
        private int _addItemToKecleonShop1;

        /// <summary>
        /// Tries to add the item to the first Kecleon shop. If there is no space, no item is added.
        /// 
        /// r0: item ID
        /// return: whether the item was added succesfully
        /// </summary>
        public int AddItemToKecleonShop1
        {
            get
            {
                if (f_addItemToKecleonShop1)
                    return _addItemToKecleonShop1;
                _addItemToKecleonShop1 = (int) (68464);
                f_addItemToKecleonShop1 = true;
                return _addItemToKecleonShop1;
            }
        }
        private bool f_incrementNbDungeonsCleared;
        private int _incrementNbDungeonsCleared;

        /// <summary>
        /// Increments by 1 the number of dungeons cleared.
        /// 
        /// Implements SPECIAL_PROC_INCREMENT_DUNGEONS_CLEARED (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbDungeonsCleared
        {
            get
            {
                if (f_incrementNbDungeonsCleared)
                    return _incrementNbDungeonsCleared;
                _incrementNbDungeonsCleared = (int) (327520);
                f_incrementNbDungeonsCleared = true;
                return _incrementNbDungeonsCleared;
            }
        }
        private bool f_closeAdvancedTextBox;
        private int _closeAdvancedTextBox;

        /// <summary>
        /// Closes a window created with CreateAdvancedTextBox or CreateAdvancedTextBoxWithArg.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseAdvancedTextBox
        {
            get
            {
                if (f_closeAdvancedTextBox)
                    return _closeAdvancedTextBox;
                _closeAdvancedTextBox = (int) (199572);
                f_closeAdvancedTextBox = true;
                return _closeAdvancedTextBox;
            }
        }
        private bool f_setAreaNameBoxState3;
        private int _setAreaNameBoxState3;

        /// <summary>
        /// Sets the state of an area name box to 3.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetAreaNameBoxState3
        {
            get
            {
                if (f_setAreaNameBoxState3)
                    return _setAreaNameBoxState3;
                _setAreaNameBoxState3 = (int) (196656);
                f_setAreaNameBoxState3 = true;
                return _setAreaNameBoxState3;
            }
        }
        private bool f_memLocateUnset;
        private int _memLocateUnset;

        /// <summary>
        /// The implementation for MemFree.
        /// 
        /// At a high level, memory is freed by locating the pointer in its memory arena (searching block-by-block) and emptying the block so it's available for future allocations, and merging it with neighboring blocks if they're available.
        /// 
        /// r0: desired memory arena for freeing, or null (MemFree passes null)
        /// r1: pointer to free
        /// </summary>
        public int MemLocateUnset
        {
            get
            {
                if (f_memLocateUnset)
                    return _memLocateUnset;
                _memLocateUnset = (int) (5688);
                f_memLocateUnset = true;
                return _memLocateUnset;
            }
        }
        private bool f_countNbOfValidItemsInStorage;
        private int _countNbOfValidItemsInStorage;

        /// <summary>
        /// Counts the number of items currently in storage that are valid.
        /// 
        /// return: number of valid items in storage
        /// </summary>
        public int CountNbOfValidItemsInStorage
        {
            get
            {
                if (f_countNbOfValidItemsInStorage)
                    return _countNbOfValidItemsInStorage;
                _countNbOfValidItemsInStorage = (int) (65112);
                f_countNbOfValidItemsInStorage = true;
                return _countNbOfValidItemsInStorage;
            }
        }
        private bool f_setFlagsForHeldItemInBag;
        private int _setFlagsForHeldItemInBag;

        /// <summary>
        /// Looks for an item in the bag that has the holder (held_by) as the item and make their equivalent
        /// item in the treasure bag sticky. The monster's held item on their struct should be updated
        /// accordingly directly before or after calling this function. Mostly used for making existing items
        /// sticky.
        /// 
        /// r0: held_by
        /// r1: item bitflags
        /// </summary>
        public int SetFlagsForHeldItemInBag
        {
            get
            {
                if (f_setFlagsForHeldItemInBag)
                    return _setFlagsForHeldItemInBag;
                _setFlagsForHeldItemInBag = (int) (64404);
                f_setFlagsForHeldItemInBag = true;
                return _setFlagsForHeldItemInBag;
            }
        }
        private bool f_openPackFile;
        private int _openPackFile;

        /// <summary>
        /// Open a Pack file, to be read later. Initialize the output structure.
        /// 
        /// r0: [output] pack file struct
        /// r1: file name
        /// </summary>
        public int OpenPackFile
        {
            get
            {
                if (f_openPackFile)
                    return _openPackFile;
                _openPackFile = (int) (50280);
                f_openPackFile = true;
                return _openPackFile;
            }
        }
        private bool f_alreadyHaveMission;
        private int _alreadyHaveMission;

        /// <summary>
        /// Checks if a specified mission already exists in the Job List.
        /// 
        /// r0: mission to check
        /// return: bool
        /// </summary>
        public int AlreadyHaveMission
        {
            get
            {
                if (f_alreadyHaveMission)
                    return _alreadyHaveMission;
                _alreadyHaveMission = (int) (389140);
                f_alreadyHaveMission = true;
                return _alreadyHaveMission;
            }
        }
        private bool f_getMonsterLevelFromSpawnEntry;
        private int _getMonsterLevelFromSpawnEntry;

        /// <summary>
        /// Returns the level of the specified monster spawn entry.
        /// 
        /// r0: pointer to the monster spawn entry
        /// return: uint8_t
        /// </summary>
        public int GetMonsterLevelFromSpawnEntry
        {
            get
            {
                if (f_getMonsterLevelFromSpawnEntry)
                    return _getMonsterLevelFromSpawnEntry;
                _getMonsterLevelFromSpawnEntry = (int) (346164);
                f_getMonsterLevelFromSpawnEntry = true;
                return _getMonsterLevelFromSpawnEntry;
            }
        }
        private bool f_getNbFloorsDungeonGroup;
        private int _getNbFloorsDungeonGroup;

        /// <summary>
        /// Returns the total amount of floors among all the dungeons in the dungeon group of the specified dungeon.
        /// 
        /// r0: Dungeon ID
        /// return: Total number of floors in the group of the specified dungeon
        /// </summary>
        public int GetNbFloorsDungeonGroup
        {
            get
            {
                if (f_getNbFloorsDungeonGroup)
                    return _getNbFloorsDungeonGroup;
                _getNbFloorsDungeonGroup = (int) (325936);
                f_getNbFloorsDungeonGroup = true;
                return _getNbFloorsDungeonGroup;
            }
        }
        private bool f_clampedLn;
        private int _clampedLn;

        /// <summary>
        /// The natural log function over the domain of [1, 2047]. The input is clamped to this domain.
        /// 
        /// r0: [output] ln(x)
        /// r1: x
        /// </summary>
        public int ClampedLn
        {
            get
            {
                if (f_clampedLn)
                    return _clampedLn;
                _clampedLn = (int) (8692);
                f_clampedLn = true;
                return _clampedLn;
            }
        }
        private bool f_animationControlGetAllocForMaxFrame;
        private int _animationControlGetAllocForMaxFrame;

        /// <summary>
        /// Return the maximum allocation for a frame of this sprite, as stored in the WAN file
        /// Return 0 if missing and takes sprite override into account
        /// 
        /// r0: animation_control
        /// return: allocation for max frame
        /// </summary>
        public int AnimationControlGetAllocForMaxFrame
        {
            get
            {
                if (f_animationControlGetAllocForMaxFrame)
                    return _animationControlGetAllocForMaxFrame;
                _animationControlGetAllocForMaxFrame = (int) (119308);
                f_animationControlGetAllocForMaxFrame = true;
                return _animationControlGetAllocForMaxFrame;
            }
        }
        private bool f_copyMoveTo;
        private int _copyMoveTo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: write_info
        /// r1: buffer_write
        /// </summary>
        public int CopyMoveTo
        {
            get
            {
                if (f_copyMoveTo)
                    return _copyMoveTo;
                _copyMoveTo = (int) (84724);
                f_copyMoveTo = true;
                return _copyMoveTo;
            }
        }
        private bool f_hasMonsterBeenAttackedInDungeons;
        private int _hasMonsterBeenAttackedInDungeons;

        /// <summary>
        /// Checks whether the specified monster has been attacked by the player at some point in their adventure during an exploration.
        /// 
        /// The check is performed using the result of passing the ID to FemaleToMaleForm.
        /// 
        /// r0: Monster ID
        /// return: True if the specified mosnter (after converting its ID through FemaleToMaleForm) has been attacked by the player before, false otherwise.
        /// </summary>
        public int HasMonsterBeenAttackedInDungeons
        {
            get
            {
                if (f_hasMonsterBeenAttackedInDungeons)
                    return _hasMonsterBeenAttackedInDungeons;
                _hasMonsterBeenAttackedInDungeons = (int) (316736);
                f_hasMonsterBeenAttackedInDungeons = true;
                return _hasMonsterBeenAttackedInDungeons;
            }
        }
        private bool f_isHeldItemInBag;
        private int _isHeldItemInBag;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item
        /// return: bool
        /// </summary>
        public int IsHeldItemInBag
        {
            get
            {
                if (f_isHeldItemInBag)
                    return _isHeldItemInBag;
                _isHeldItemInBag = (int) (61556);
                f_isHeldItemInBag = true;
                return _isHeldItemInBag;
            }
        }
        private bool f_getMoveAccuracyOrAiChance;
        private int _getMoveAccuracyOrAiChance;

        /// <summary>
        /// Gets one of the two accuracy values of a move or its ai_condition_random_chance field.
        /// 
        /// r0: Move pointer
        /// r1: 0 to get the move's first accuracy1 field, 1 to get its accuracy2, 2 to get its ai_condition_random_chance.
        /// return: Move's accuracy1, accuracy2 or ai_condition_random_chance
        /// </summary>
        public int GetMoveAccuracyOrAiChance
        {
            get
            {
                if (f_getMoveAccuracyOrAiChance)
                    return _getMoveAccuracyOrAiChance;
                _getMoveAccuracyOrAiChance = (int) (80564);
                f_getMoveAccuracyOrAiChance = true;
                return _getMoveAccuracyOrAiChance;
            }
        }
        private bool f_is2TurnsMove;
        private int _is2TurnsMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int Is2TurnsMove
        {
            get
            {
                if (f_is2TurnsMove)
                    return _is2TurnsMove;
                _is2TurnsMove = (int) (85260);
                f_is2TurnsMove = true;
                return _is2TurnsMove;
            }
        }
        private bool f_deleteWanTableEntryVeneer;
        private int _deleteWanTableEntryVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for DeleteWanTableEntry.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: wan_table_ptr
        /// r1: wan_id
        /// </summary>
        public int DeleteWanTableEntryVeneer
        {
            get
            {
                if (f_deleteWanTableEntryVeneer)
                    return _deleteWanTableEntryVeneer;
                _deleteWanTableEntryVeneer = (int) (120776);
                f_deleteWanTableEntryVeneer = true;
                return _deleteWanTableEntryVeneer;
            }
        }
        private bool f_getPpIncrease;
        private int _getPpIncrease;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// r1: IQ skills bitvector
        /// return: PP increase
        /// </summary>
        public int GetPpIncrease
        {
            get
            {
                if (f_getPpIncrease)
                    return _getPpIncrease;
                _getPpIncrease = (int) (86668);
                f_getPpIncrease = true;
                return _getPpIncrease;
            }
        }
        private bool f_getDungeonTipShown;
        private int _getDungeonTipShown;

        /// <summary>
        /// Checks if a dungeon tip has already been shown before or not.
        /// 
        /// r0: Dungeon tip ID
        /// return: True if the tip has been shown before, false otherwise.
        /// </summary>
        public int GetDungeonTipShown
        {
            get
            {
                if (f_getDungeonTipShown)
                    return _getDungeonTipShown;
                _getDungeonTipShown = (int) (316872);
                f_getDungeonTipShown = true;
                return _getDungeonTipShown;
            }
        }
        private bool f_getFreeArenaDefault;
        private int _getFreeArenaDefault;

        /// <summary>
        /// The default function for retrieving the arena for memory freeing. This function always just returns the initial arena pointer.
        /// 
        /// r0: initial memory arena pointer, or null
        /// r1: pointer to free
        /// return: memory arena pointer, or null
        /// </summary>
        public int GetFreeArenaDefault
        {
            get
            {
                if (f_getFreeArenaDefault)
                    return _getFreeArenaDefault;
                _getFreeArenaDefault = (int) (3780);
                f_getFreeArenaDefault = true;
                return _getFreeArenaDefault;
            }
        }
        private bool f_loadItemPspi2n;
        private int _loadItemPspi2n;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int LoadItemPspi2n
        {
            get
            {
                if (f_loadItemPspi2n)
                    return _loadItemPspi2n;
                _loadItemPspi2n = (int) (59232);
                f_loadItemPspi2n = true;
                return _loadItemPspi2n;
            }
        }
        private bool f_updateTextBox;
        private int _updateTextBox;

        /// <summary>
        /// Window update function for text boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateTextBox
        {
            get
            {
                if (f_updateTextBox)
                    return _updateTextBox;
                _updateTextBox = (int) (195920);
                f_updateTextBox = true;
                return _updateTextBox;
            }
        }
        private bool f_getBaseFormBurmyWormadamShellosGastrodonCherrim;
        private int _getBaseFormBurmyWormadamShellosGastrodonCherrim;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: base form
        /// </summary>
        public int GetBaseFormBurmyWormadamShellosGastrodonCherrim
        {
            get
            {
                if (f_getBaseFormBurmyWormadamShellosGastrodonCherrim)
                    return _getBaseFormBurmyWormadamShellosGastrodonCherrim;
                _getBaseFormBurmyWormadamShellosGastrodonCherrim = (int) (345548);
                f_getBaseFormBurmyWormadamShellosGastrodonCherrim = true;
                return _getBaseFormBurmyWormadamShellosGastrodonCherrim;
            }
        }
        private bool f_getDisplayedBuyPrice;
        private int _getDisplayedBuyPrice;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item
        /// return: buy price
        /// </summary>
        public int GetDisplayedBuyPrice
        {
            get
            {
                if (f_getDisplayedBuyPrice)
                    return _getDisplayedBuyPrice;
                _getDisplayedBuyPrice = (int) (53592);
                f_getDisplayedBuyPrice = true;
                return _getDisplayedBuyPrice;
            }
        }
        private bool f_setMonsterId;
        private int _setMonsterId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: mons_spawn_str
        /// r1: monster ID
        /// </summary>
        public int SetMonsterId
        {
            get
            {
                if (f_setMonsterId)
                    return _setMonsterId;
                _setMonsterId = (int) (346140);
                f_setMonsterId = true;
                return _setMonsterId;
            }
        }
        private bool f_eventFlagBackup;
        private int _eventFlagBackup;

        /// <summary>
        /// Saves event flag script variables (see the code for an exhaustive list) to their respective BACKUP script variables, but only in certain game modes.
        /// 
        /// This function prints the debug string &quot;EventFlag BackupGameMode %d&quot; with the game mode.
        /// 
        /// No params.
        /// </summary>
        public int EventFlagBackup
        {
            get
            {
                if (f_eventFlagBackup)
                    return _eventFlagBackup;
                _eventFlagBackup = (int) (312604);
                f_eventFlagBackup = true;
                return _eventFlagBackup;
            }
        }
        private bool f_memZero16;
        private int _memZero16;

        /// <summary>
        /// Zeros a buffer of 16-bit values.
        /// 
        /// r0: ptr
        /// r1: len (# bytes)
        /// </summary>
        public int MemZero16
        {
            get
            {
                if (f_memZero16)
                    return _memZero16;
                _memZero16 = (int) (12908);
                f_memZero16 = true;
                return _memZero16;
            }
        }
        private bool f_allManip1;
        private int _allManip1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int AllManip1
        {
            get
            {
                if (f_allManip1)
                    return _allManip1;
                _allManip1 = (int) (82568);
                f_allManip1 = true;
                return _allManip1;
            }
        }
        private bool f_getBaseFormCastformDeoxysCherrim;
        private int _getBaseFormCastformDeoxysCherrim;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: base form
        /// </summary>
        public int GetBaseFormCastformDeoxysCherrim
        {
            get
            {
                if (f_getBaseFormCastformDeoxysCherrim)
                    return _getBaseFormCastformDeoxysCherrim;
                _getBaseFormCastformDeoxysCherrim = (int) (348064);
                f_getBaseFormCastformDeoxysCherrim = true;
                return _getBaseFormCastformDeoxysCherrim;
            }
        }
        private bool f_noteSaveBase;
        private int _noteSaveBase;

        /// <summary>
        /// Probably related to saving or quicksaving?
        /// 
        /// This function prints the debug message &quot;NoteSave Base %d %d&quot; with some values. It's also the only place where GetRngSeed is called.
        /// 
        /// r0: Irdkwia's notes: state ID
        /// others: ?
        /// return: status code
        /// </summary>
        public int NoteSaveBase
        {
            get
            {
                if (f_noteSaveBase)
                    return _noteSaveBase;
                _noteSaveBase = (int) (299680);
                f_noteSaveBase = true;
                return _noteSaveBase;
            }
        }
        private bool f_getMissionRank;
        private int _getMissionRank;

        /// <summary>
        /// Gets the mission rank for the given dungeon and floor.
        /// 
        /// If the dungeon ID is &gt;= DUNGEON_NORMAL_FLY_MAZE or the group of the dungeon is &gt; DGROUP_DUMMY_0x63, returns MISSION_RANK_E.
        /// 
        /// r0: Dungeon and floor
        /// return: Mission rank
        /// </summary>
        public int GetMissionRank
        {
            get
            {
                if (f_getMissionRank)
                    return _getMissionRank;
                _getMissionRank = (int) (326476);
                f_getMissionRank = true;
                return _getMissionRank;
            }
        }
        private bool f_initSpecialEpisodeHero;
        private int _initSpecialEpisodeHero;

        /// <summary>
        /// Removes/invalidates the special episode member slots, zero inits the special episode treasure bag, zero inits the
        /// special episode Kecleon shops, zero inits VAR_WORLD_MAP_MARK_LIST_SPECIAL, sets VAR_SPECIAL_EPISODE_OPEN_OLD for
        /// the corresponding special episode, and initializes the hero for the special episode.
        /// 
        /// No params.
        /// </summary>
        public int InitSpecialEpisodeHero
        {
            get
            {
                if (f_initSpecialEpisodeHero)
                    return _initSpecialEpisodeHero;
                _initSpecialEpisodeHero = (int) (296964);
                f_initSpecialEpisodeHero = true;
                return _initSpecialEpisodeHero;
            }
        }
        private bool f_getFirstEmptyMemberIdx;
        private int _getFirstEmptyMemberIdx;

        /// <summary>
        /// Gets the first unoccupied team member index (in the Chimecho Assembly), or -1 if there is none.
        /// 
        /// If valid, this will always be 5 or greater, since indexes 0-4 are reserved for main characters.
        /// 
        /// r0: ?
        /// return: team member index of the first available slot
        /// </summary>
        public int GetFirstEmptyMemberIdx
        {
            get
            {
                if (f_getFirstEmptyMemberIdx)
                    return _getFirstEmptyMemberIdx;
                _getFirstEmptyMemberIdx = (int) (351456);
                f_getFirstEmptyMemberIdx = true;
                return _getFirstEmptyMemberIdx;
            }
        }
        private bool f_debugDisplay;
        private int _debugDisplay;

        /// <summary>
        /// Would display a printf format string on the top screen in the debug binary.
        /// 
        /// This still constructs the string with vsprintf, but doesn't actually do anything with it in the final binary.
        /// 
        /// Identical to DebugPrint0 in release builds.
        /// 
        /// r0: format
        /// ...: variadic
        /// </summary>
        public int DebugDisplay
        {
            get
            {
                if (f_debugDisplay)
                    return _debugDisplay;
                _debugDisplay = (int) (49744);
                f_debugDisplay = true;
                return _debugDisplay;
            }
        }
        private bool f_getAdvancedTextBoxFlags2;
        private int _getAdvancedTextBoxFlags2;

        /// <summary>
        /// Gets the value of advanced_text_box::flags2.
        /// 
        /// r0: window_id
        /// return: flags2
        /// </summary>
        public int GetAdvancedTextBoxFlags2
        {
            get
            {
                if (f_getAdvancedTextBoxFlags2)
                    return _getAdvancedTextBoxFlags2;
                _getAdvancedTextBoxFlags2 = (int) (199988);
                f_getAdvancedTextBoxFlags2 = true;
                return _getAdvancedTextBoxFlags2;
            }
        }
        private bool f_isRegularAttackOrProjectile;
        private int _isRegularAttackOrProjectile;

        /// <summary>
        /// Checks if a move ID is MOVE_REGULAR_ATTACK or MOVE_PROJECTILE.
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsRegularAttackOrProjectile
        {
            get
            {
                if (f_isRegularAttackOrProjectile)
                    return _isRegularAttackOrProjectile;
                _isRegularAttackOrProjectile = (int) (85396);
                f_isRegularAttackOrProjectile = true;
                return _isRegularAttackOrProjectile;
            }
        }
        private bool f_isOneHitKoMove;
        private int _isOneHitKoMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsOneHitKoMove
        {
            get
            {
                if (f_isOneHitKoMove)
                    return _isOneHitKoMove;
                _isOneHitKoMove = (int) (85672);
                f_isOneHitKoMove = true;
                return _isOneHitKoMove;
            }
        }
        private bool f_getFirstUnequippedItemOfType;
        private int _getFirstUnequippedItemOfType;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: index
        /// </summary>
        public int GetFirstUnequippedItemOfType
        {
            get
            {
                if (f_getFirstUnequippedItemOfType)
                    return _getFirstUnequippedItemOfType;
                _getFirstUnequippedItemOfType = (int) (62228);
                f_getFirstUnequippedItemOfType = true;
                return _getFirstUnequippedItemOfType;
            }
        }
        private bool f_applySitrusBerryBoostToGroundMonster;
        private int _applySitrusBerryBoostToGroundMonster;

        /// <summary>
        /// Applies the hp boost from the Sitrus Berry to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted hp boost, if not NULL
        /// return: actual hp boost
        /// </summary>
        public int ApplySitrusBerryBoostToGroundMonster
        {
            get
            {
                if (f_applySitrusBerryBoostToGroundMonster)
                    return _applySitrusBerryBoostToGroundMonster;
                _applySitrusBerryBoostToGroundMonster = (int) (71208);
                f_applySitrusBerryBoostToGroundMonster = true;
                return _applySitrusBerryBoostToGroundMonster;
            }
        }
        private bool f_setMonsterLevelAndId;
        private int _setMonsterLevelAndId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: mons_spawn_str
        /// r1: level
        /// r2: monster ID
        /// </summary>
        public int SetMonsterLevelAndId
        {
            get
            {
                if (f_setMonsterLevelAndId)
                    return _setMonsterLevelAndId;
                _setMonsterLevelAndId = (int) (346148);
                f_setMonsterLevelAndId = true;
                return _setMonsterLevelAndId;
            }
        }
        private bool f_updateScrollBox;
        private int _updateScrollBox;

        /// <summary>
        /// Window update function for scroll boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateScrollBox
        {
            get
            {
                if (f_updateScrollBox)
                    return _updateScrollBox;
                _updateScrollBox = (int) (190972);
                f_updateScrollBox = true;
                return _updateScrollBox;
            }
        }
        private bool f_loadWanTableEntryFromPackUseProvidedMemory;
        private int _loadWanTableEntryFromPackUseProvidedMemory;

        /// <summary>
        /// Return an already allocated entry for this sprite if it exists, otherwise allocate a new one and load the optionally compressed sprite into the provided memory area. Mark the sprite as externally allocated.
        /// 
        /// r0: wan_table_ptr
        /// r1: pack_id
        /// r2: file_index
        /// r3: sprite_storage_ptr
        /// stack[0]: compressed
        /// return: the entry id in wan_table
        /// </summary>
        public int LoadWanTableEntryFromPackUseProvidedMemory
        {
            get
            {
                if (f_loadWanTableEntryFromPackUseProvidedMemory)
                    return _loadWanTableEntryFromPackUseProvidedMemory;
                _loadWanTableEntryFromPackUseProvidedMemory = (int) (120364);
                f_loadWanTableEntryFromPackUseProvidedMemory = true;
                return _loadWanTableEntryFromPackUseProvidedMemory;
            }
        }
        private bool f_normalizeTreasureBox;
        private int _normalizeTreasureBox;

        /// <summary>
        /// If the item is a treasure box return the first version of the treasure box in the item list.
        /// Otherwise, return the same item ID.
        /// 
        /// r0: item ID
        /// return: normalized item ID
        /// </summary>
        public int NormalizeTreasureBox
        {
            get
            {
                if (f_normalizeTreasureBox)
                    return _normalizeTreasureBox;
                _normalizeTreasureBox = (int) (57984);
                f_normalizeTreasureBox = true;
                return _normalizeTreasureBox;
            }
        }
        private bool f_createParentMenuWrapper;
        private int _createParentMenuWrapper;

        /// <summary>
        /// A wrapper around CreateParentMenu that sets field_0x1b0 to 1 if the returned window_id is not -2.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: simple_menu_ptr_item struct array, terminated with an item with an NULL string pointer
        /// return: window_id
        /// </summary>
        public int CreateParentMenuWrapper
        {
            get
            {
                if (f_createParentMenuWrapper)
                    return _createParentMenuWrapper;
                _createParentMenuWrapper = (int) (174628);
                f_createParentMenuWrapper = true;
                return _createParentMenuWrapper;
            }
        }
        private bool f_getRngSeed;
        private int _getRngSeed;

        /// <summary>
        /// Get the current value of PRNG_SEQUENCE_NUM.
        /// </summary>
        public int GetRngSeed
        {
            get
            {
                if (f_getRngSeed)
                    return _getRngSeed;
                _getRngSeed = (int) (8748);
                f_getRngSeed = true;
                return _getRngSeed;
            }
        }
        private bool f_isMissionTypeSpecialEpisode;
        private int _isMissionTypeSpecialEpisode;

        /// <summary>
        /// Checks if a mission is for a Special Episode Transmission, which unlocks Special Episode 3. This specifically checks for a mission of type MISSION_SPECIAL_EPISODE and subtype 0x2.
        /// 
        /// r0: mission pointer
        /// return: bool
        /// </summary>
        public int IsMissionTypeSpecialEpisode
        {
            get
            {
                if (f_isMissionTypeSpecialEpisode)
                    return _isMissionTypeSpecialEpisode;
                _isMissionTypeSpecialEpisode = (int) (386484);
                f_isMissionTypeSpecialEpisode = true;
                return _isMissionTypeSpecialEpisode;
            }
        }
        private bool f_getExclusiveItem;
        private int _getExclusiveItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: determines which exclusive item
        /// return: exclusive item
        /// </summary>
        public int GetExclusiveItem
        {
            get
            {
                if (f_getExclusiveItem)
                    return _getExclusiveItem;
                _getExclusiveItem = (int) (339652);
                f_getExclusiveItem = true;
                return _getExclusiveItem;
            }
        }
        private bool f_convertStorageItemAtIdxToBulkItem;
        private int _convertStorageItemAtIdxToBulkItem;

        /// <summary>
        /// Get an item in storage and converts it into an equivalent bulk_item. This does not remove the
        /// item from storage.
        /// 
        /// r0: item index
        /// r1: [output] pointer to a bulk_item
        /// return: bool whether or not the item id is not 0
        /// </summary>
        public int ConvertStorageItemAtIdxToBulkItem
        {
            get
            {
                if (f_convertStorageItemAtIdxToBulkItem)
                    return _convertStorageItemAtIdxToBulkItem;
                _convertStorageItemAtIdxToBulkItem = (int) (65620);
                f_convertStorageItemAtIdxToBulkItem = true;
                return _convertStorageItemAtIdxToBulkItem;
            }
        }
        private bool f_removeItemFromKecleonShop1;
        private int _removeItemFromKecleonShop1;

        /// <summary>
        /// Removes an item from the first Kecleon Shop at a specific slot in the shop list.
        /// 
        /// r0: item slot (0-7)
        /// </summary>
        public int RemoveItemFromKecleonShop1
        {
            get
            {
                if (f_removeItemFromKecleonShop1)
                    return _removeItemFromKecleonShop1;
                _removeItemFromKecleonShop1 = (int) (67860);
                f_removeItemFromKecleonShop1 = true;
                return _removeItemFromKecleonShop1;
            }
        }
        private bool f_setPokemonBattled;
        private int _setPokemonBattled;

        /// <summary>
        /// Marks one pokémon as battled.
        /// 
        /// r0: monster ID
        /// </summary>
        public int SetPokemonBattled
        {
            get
            {
                if (f_setPokemonBattled)
                    return _setPokemonBattled;
                _setPokemonBattled = (int) (328080);
                f_setPokemonBattled = true;
                return _setPokemonBattled;
            }
        }
        private bool f_addMoneyCarried;
        private int _addMoneyCarried;

        /// <summary>
        /// Adds the amount of money to the player's current amount of money. Just calls
        /// SetMoneyCarried with the current money + money gained.
        /// 
        /// r0: money gained (can be negative)
        /// </summary>
        public int AddMoneyCarried
        {
            get
            {
                if (f_addMoneyCarried)
                    return _addMoneyCarried;
                _addMoneyCarried = (int) (60928);
                f_addMoneyCarried = true;
                return _addMoneyCarried;
            }
        }
        private bool f_startAutoloadDoneCallback;
        private int _startAutoloadDoneCallback;

        /// <summary>
        /// Startup routine in the program's crt0 (https://en.wikipedia.org/wiki/Crt0).
        /// </summary>
        public int StartAutoloadDoneCallback
        {
            get
            {
                if (f_startAutoloadDoneCallback)
                    return _startAutoloadDoneCallback;
                _startAutoloadDoneCallback = (int) (2732);
                f_startAutoloadDoneCallback = true;
                return _startAutoloadDoneCallback;
            }
        }
        private bool f_incrementExclusiveMonsterCounts;
        private int _incrementExclusiveMonsterCounts;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// </summary>
        public int IncrementExclusiveMonsterCounts
        {
            get
            {
                if (f_incrementExclusiveMonsterCounts)
                    return _incrementExclusiveMonsterCounts;
                _incrementExclusiveMonsterCounts = (int) (317088);
                f_incrementExclusiveMonsterCounts = true;
                return _incrementExclusiveMonsterCounts;
            }
        }
        private bool f_updatePortraitBox;
        private int _updatePortraitBox;

        /// <summary>
        /// Window update function for portrait boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdatePortraitBox
        {
            get
            {
                if (f_updatePortraitBox)
                    return _updatePortraitBox;
                _updatePortraitBox = (int) (195072);
                f_updatePortraitBox = true;
                return _updatePortraitBox;
            }
        }
        private bool f_initDebugStripped3;
        private int _initDebugStripped3;

        /// <summary>
        /// Does nothing, only called in the debug initialization function.
        /// </summary>
        public int InitDebugStripped3
        {
            get
            {
                if (f_initDebugStripped3)
                    return _initDebugStripped3;
                _initDebugStripped3 = (int) (49880);
                f_initDebugStripped3 = true;
                return _initDebugStripped3;
            }
        }
        private bool f_selectWaza;
        private int _selectWaza;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: waza_id
        /// </summary>
        public int SelectWaza
        {
            get
            {
                if (f_selectWaza)
                    return _selectWaza;
                _selectWaza = (int) (86948);
                f_selectWaza = true;
                return _selectWaza;
            }
        }
        private bool f_unloadFile;
        private int _unloadFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: addr_ptr
        /// </summary>
        public int UnloadFile
        {
            get
            {
                if (f_unloadFile)
                    return _unloadFile;
                _unloadFile = (int) (35796);
                f_unloadFile = true;
                return _unloadFile;
            }
        }
        private bool f_manipMoves2v1;
        private int _manipMoves2v1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ManipMoves2v1
        {
            get
            {
                if (f_manipMoves2v1)
                    return _manipMoves2v1;
                _manipMoves2v1 = (int) (83276);
                f_manipMoves2v1 = true;
                return _manipMoves2v1;
            }
        }
        private bool f_getColorCodePaletteOffset;
        private int _getColorCodePaletteOffset;

        /// <summary>
        /// Gets the offset of a text color symbol's 2-byte RGB5 color in the palette stored in VRAM at 0x6882000.
        /// 
        /// The offset minus 0x10 will also be the corresponding 4-byte RGBX color's position in FONT/text_pal.pal.
        /// 
        /// r0: char
        /// return: offset
        /// </summary>
        public int GetColorCodePaletteOffset
        {
            get
            {
                if (f_getColorCodePaletteOffset)
                    return _getColorCodePaletteOffset;
                _getColorCodePaletteOffset = (int) (157864);
                f_getColorCodePaletteOffset = true;
                return _getColorCodePaletteOffset;
            }
        }
        private bool f_setItemAcquired;
        private int _setItemAcquired;

        /// <summary>
        /// Marks one specific item as acquired.
        /// 
        /// r0: item
        /// </summary>
        public int SetItemAcquired
        {
            get
            {
                if (f_setItemAcquired)
                    return _setItemAcquired;
                _setItemAcquired = (int) (329272);
                f_setItemAcquired = true;
                return _setItemAcquired;
            }
        }
        private bool f_mIiUncompressBackward;
        private int _mIiUncompressBackward;

        /// <summary>
        /// Startup routine in the program's crt0 (https://en.wikipedia.org/wiki/Crt0).
        /// </summary>
        public int MIiUncompressBackward
        {
            get
            {
                if (f_mIiUncompressBackward)
                    return _mIiUncompressBackward;
                _mIiUncompressBackward = (int) (2416);
                f_mIiUncompressBackward = true;
                return _mIiUncompressBackward;
            }
        }
        private bool f_getMoneyStored;
        private int _getMoneyStored;

        /// <summary>
        /// Gets the amount of money the player has stored in the Duskull Bank.
        /// 
        /// return: amount of money stored
        /// </summary>
        public int GetMoneyStored
        {
            get
            {
                if (f_getMoneyStored)
                    return _getMoneyStored;
                _getMoneyStored = (int) (67508);
                f_getMoneyStored = true;
                return _getMoneyStored;
            }
        }
        private bool f_decompressAtNormal;
        private int _decompressAtNormal;

        /// <summary>
        /// Overwrites r3 probably passed to match DecompressAtHalf's definition.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: addr_decomp
        /// r1: expected_size
        /// r2: AT pointer
        /// return: ?
        /// </summary>
        public int DecompressAtNormal
        {
            get
            {
                if (f_decompressAtNormal)
                    return _decompressAtNormal;
                _decompressAtNormal = (int) (128616);
                f_decompressAtNormal = true;
                return _decompressAtNormal;
            }
        }
        private bool f_isSimpleMenuActive;
        private int _isSimpleMenuActive;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// Checks if the menu state is anything other than 7 or 8.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsSimpleMenuActive
        {
            get
            {
                if (f_isSimpleMenuActive)
                    return _isSimpleMenuActive;
                _isSimpleMenuActive = (int) (178148);
                f_isSimpleMenuActive = true;
                return _isSimpleMenuActive;
            }
        }
        private bool f_randRange;
        private int _randRange;

        /// <summary>
        /// Compute a pseudorandom value between two integers using the general-purpose PRNG.
        /// 
        /// This function relies on a single call to Rand16Bit. Even though it takes 32-bit integers as input, the number of unique outcomes is capped at 2^16.
        /// 
        /// r0: x
        /// r1: y
        /// return: pseudorandom integer on the interval [x, y - 1]
        /// </summary>
        public int RandRange
        {
            get
            {
                if (f_randRange)
                    return _randRange;
                _randRange = (int) (8844);
                f_randRange = true;
                return _randRange;
            }
        }
        private bool f_getInfoGroundMoveset;
        private int _getInfoGroundMoveset;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// r1: moves_id
        /// </summary>
        public int GetInfoGroundMoveset
        {
            get
            {
                if (f_getInfoGroundMoveset)
                    return _getInfoGroundMoveset;
                _getInfoGroundMoveset = (int) (84064);
                f_getInfoGroundMoveset = true;
                return _getInfoGroundMoveset;
            }
        }
        private bool f_initInventoryMenuInput;
        private int _initInventoryMenuInput;

        /// <summary>
        /// Almost exactly the same as InitWindowInput, except two differences in field assignments on the window input context, one of which uses an extra parameter.
        /// 
        /// r0: inventory_menu_input_ctx pointer
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: window rectangle
        /// stack[0]: total number of selectable items
        /// stack[1]: number of selectable items per page
        /// stack[2]: ?
        /// </summary>
        public int InitInventoryMenuInput
        {
            get
            {
                if (f_initInventoryMenuInput)
                    return _initInventoryMenuInput;
                _initInventoryMenuInput = (int) (208172);
                f_initInventoryMenuInput = true;
                return _initInventoryMenuInput;
            }
        }
        private bool f_getMovesetEggPtr;
        private int _getMovesetEggPtr;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: ?
        /// </summary>
        public int GetMovesetEggPtr
        {
            get
            {
                if (f_getMovesetEggPtr)
                    return _getMovesetEggPtr;
                _getMovesetEggPtr = (int) (80360);
                f_getMovesetEggPtr = true;
                return _getMovesetEggPtr;
            }
        }
        private bool f_drawChar;
        private int _drawChar;

        /// <summary>
        /// Draws a single char within a window. This function is also responsible for drawing the shadows of a char.
        /// 
        /// r0: window_id
        /// r1: x offset within window
        /// r2: y offset within window
        /// r3: char
        /// stack[0]: color offset
        /// return: char width
        /// </summary>
        public int DrawChar
        {
            get
            {
                if (f_drawChar)
                    return _drawChar;
                _drawChar = (int) (158288);
                f_drawChar = true;
                return _drawChar;
            }
        }
        private bool f_setAdventureLogStructLocation;
        private int _setAdventureLogStructLocation;

        /// <summary>
        /// Sets the location of the adventure log struct in memory.
        /// 
        /// Sets it in a static memory location (At 0x22AB69C [US], 0x22ABFDC [EU], 0x22ACE58 [JP])
        /// 
        /// No params.
        /// </summary>
        public int SetAdventureLogStructLocation
        {
            get
            {
                if (f_setAdventureLogStructLocation)
                    return _setAdventureLogStructLocation;
                _setAdventureLogStructLocation = (int) (327004);
                f_setAdventureLogStructLocation = true;
                return _setAdventureLogStructLocation;
            }
        }
        private bool f_isIqEnabled;
        private int _isIqEnabled;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsIqEnabled
        {
            get
            {
                if (f_isIqEnabled)
                    return _isIqEnabled;
                _isIqEnabled = (int) (333688);
                f_isIqEnabled = true;
                return _isIqEnabled;
            }
        }
        private bool f_isCopyingMove;
        private int _isCopyingMove;

        /// <summary>
        /// Checks if a move ID is MOVE_MIMIC, MOVE_SKETCH, or MOVE_COPYCAT.
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsCopyingMove
        {
            get
            {
                if (f_isCopyingMove)
                    return _isCopyingMove;
                _isCopyingMove = (int) (85548);
                f_isCopyingMove = true;
                return _isCopyingMove;
            }
        }
        private bool f_generateMission;
        private int _generateMission;

        /// <summary>
        /// Attempts to generate a random mission.
        /// 
        /// r0: Pointer to something
        /// r1: Pointer to the struct where the data of the generated mission will be written to
        /// return: MISSION_GENERATION_SUCCESS if the mission was successfully generated, MISSION_GENERATION_FAILURE if it failed and MISSION_GENERATION_GLOBAL_FAILURE if it failed and the game shouldn't try to generate more.
        /// </summary>
        public int GenerateMission
        {
            get
            {
                if (f_generateMission)
                    return _generateMission;
                _generateMission = (int) (382368);
                f_generateMission = true;
                return _generateMission;
            }
        }
        private bool f_dungeonRequestsDone;
        private int _dungeonRequestsDone;

        /// <summary>
        /// Seems to return the number of missions completed.
        /// 
        /// Part of the implementation for SPECIAL_PROC_DUNGEON_HAD_REQUEST_DONE (see ScriptSpecialProcessCall).
        /// 
        /// r0: ?
        /// r1: some flag?
        /// return: number of missions completed
        /// </summary>
        public int DungeonRequestsDone
        {
            get
            {
                if (f_dungeonRequestsDone)
                    return _dungeonRequestsDone;
                _dungeonRequestsDone = (int) (389408);
                f_dungeonRequestsDone = true;
                return _dungeonRequestsDone;
            }
        }
        private bool f_handleSir0TranslationVeneer;
        private int _handleSir0TranslationVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for HandleSir0Translation.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: [output] double pointer to beginning of data
        /// r1: pointer to source file buffer
        /// return: return code
        /// </summary>
        public int HandleSir0TranslationVeneer
        {
            get
            {
                if (f_handleSir0TranslationVeneer)
                    return _handleSir0TranslationVeneer;
                _handleSir0TranslationVeneer = (int) (128552);
                f_handleSir0TranslationVeneer = true;
                return _handleSir0TranslationVeneer;
            }
        }
        private bool f_manipMoves1v1;
        private int _manipMoves1v1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ManipMoves1v1
        {
            get
            {
                if (f_manipMoves1v1)
                    return _manipMoves1v1;
                _manipMoves1v1 = (int) (82756);
                f_manipMoves1v1 = true;
                return _manipMoves1v1;
            }
        }
        private bool f_getName;
        private int _getName;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dst_ptr
        /// r1: id
        /// r2: color_id
        /// </summary>
        public int GetName
        {
            get
            {
                if (f_getName)
                    return _getName;
                _getName = (int) (337672);
                f_getName = true;
                return _getName;
            }
        }
        private bool f_changeBgm;
        private int _changeBgm;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ChangeBgm
        {
            get
            {
                if (f_changeBgm)
                    return _changeBgm;
                _changeBgm = (int) (105708);
                f_changeBgm = true;
                return _changeBgm;
            }
        }
        private bool f_sortKecleonItems2;
        private int _sortKecleonItems2;

        /// <summary>
        /// Sorts the items for the Orb/TM Kecleon Shop items in Treasure Town.
        /// 
        /// No params.
        /// </summary>
        public int SortKecleonItems2
        {
            get
            {
                if (f_sortKecleonItems2)
                    return _sortKecleonItems2;
                _sortKecleonItems2 = (int) (68872);
                f_sortKecleonItems2 = true;
                return _sortKecleonItems2;
            }
        }
        private bool f_getSecondFormIfValid;
        private int _getSecondFormIfValid;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: second form
        /// </summary>
        public int GetSecondFormIfValid
        {
            get
            {
                if (f_getSecondFormIfValid)
                    return _getSecondFormIfValid;
                _getSecondFormIfValid = (int) (347936);
                f_getSecondFormIfValid = true;
                return _getSecondFormIfValid;
            }
        }
        private bool f_getNbItemAcquired;
        private int _getNbItemAcquired;

        /// <summary>
        /// Gets the number of items acquired.
        /// 
        /// return: the number of items acquired
        /// </summary>
        public int GetNbItemAcquired
        {
            get
            {
                if (f_getNbItemAcquired)
                    return _getNbItemAcquired;
                _getNbItemAcquired = (int) (329476);
                f_getNbItemAcquired = true;
                return _getNbItemAcquired;
            }
        }
        private bool f_canSendItem;
        private int _canSendItem;

        /// <summary>
        /// Returns whether a certain item can be sent to another player via Wonder Mail.
        /// 
        /// r0: item ID
        /// r1: to_sky
        /// return: bool
        /// </summary>
        public int CanSendItem
        {
            get
            {
                if (f_canSendItem)
                    return _canSendItem;
                _canSendItem = (int) (405848);
                f_canSendItem = true;
                return _canSendItem;
            }
        }
        private bool f_getNbMoves;
        private int _getNbMoves;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// return: # moves
        /// </summary>
        public int GetNbMoves
        {
            get
            {
                if (f_getNbMoves)
                    return _getNbMoves;
                _getNbMoves = (int) (81164);
                f_getNbMoves = true;
                return _getNbMoves;
            }
        }
        private bool f_haltProcessDisp;
        private int _haltProcessDisp;

        /// <summary>
        /// Maybe halts the process display?
        /// 
        /// This function prints the debug string &quot;halt process disp %d&quot; with the status code.
        /// 
        /// r0: status code
        /// </summary>
        public int HaltProcessDisp
        {
            get
            {
                if (f_haltProcessDisp)
                    return _haltProcessDisp;
                _haltProcessDisp = (int) (15800);
                f_haltProcessDisp = true;
                return _haltProcessDisp;
            }
        }
        private bool f_setStringAccuracy;
        private int _setStringAccuracy;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int SetStringAccuracy
        {
            get
            {
                if (f_setStringAccuracy)
                    return _setStringAccuracy;
                _setStringAccuracy = (int) (148928);
                f_setStringAccuracy = true;
                return _setStringAccuracy;
            }
        }
        private bool f_removeActiveMembersFromAllTeams;
        private int _removeActiveMembersFromAllTeams;

        /// <summary>
        /// Removes all of the active monsters on every type of team from the team member table.
        /// 
        /// No params.
        /// </summary>
        public int RemoveActiveMembersFromAllTeams
        {
            get
            {
                if (f_removeActiveMembersFromAllTeams)
                    return _removeActiveMembersFromAllTeams;
                _removeActiveMembersFromAllTeams = (int) (353348);
                f_removeActiveMembersFromAllTeams = true;
                return _removeActiveMembersFromAllTeams;
            }
        }
        private bool f_isTextBoxActive;
        private int _isTextBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a text box is not 7.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsTextBoxActive
        {
            get
            {
                if (f_isTextBoxActive)
                    return _isTextBoxActive;
                _isTextBoxActive = (int) (196240);
                f_isTextBoxActive = true;
                return _isTextBoxActive;
            }
        }
        private bool f_debugPrint0;
        private int _debugPrint0;

        /// <summary>
        /// Would log a printf format string in the debug binary.
        /// 
        /// This still constructs the string with vsprintf, but doesn't actually do anything with it in the final binary.
        /// 
        /// Identical to DebugDisplay in release builds.
        /// 
        /// r0: format
        /// ...: variadic
        /// </summary>
        public int DebugPrint0
        {
            get
            {
                if (f_debugPrint0)
                    return _debugPrint0;
                _debugPrint0 = (int) (49796);
                f_debugPrint0 = true;
                return _debugPrint0;
            }
        }
        private bool f_getPlayTimeSeconds;
        private int _getPlayTimeSeconds;

        /// <summary>
        /// Returns the current play time in seconds.
        /// 
        /// return: play time in seconds
        /// </summary>
        public int GetPlayTimeSeconds
        {
            get
            {
                if (f_getPlayTimeSeconds)
                    return _getPlayTimeSeconds;
                _getPlayTimeSeconds = (int) (332172);
                f_getPlayTimeSeconds = true;
                return _getPlayTimeSeconds;
            }
        }
        private bool f_arm9LoadUnkFieldNa0x2029Ec8;
        private int _arm9LoadUnkFieldNa0x2029Ec8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// </summary>
        public int Arm9LoadUnkFieldNa0x2029Ec8
        {
            get
            {
                if (f_arm9LoadUnkFieldNa0x2029Ec8)
                    return _arm9LoadUnkFieldNa0x2029Ec8;
                _arm9LoadUnkFieldNa0x2029Ec8 = (int) (172476);
                f_arm9LoadUnkFieldNa0x2029Ec8 = true;
                return _arm9LoadUnkFieldNa0x2029Ec8;
            }
        }
        private bool f_generateAllPossibleDungeonsList;
        private int _generateAllPossibleDungeonsList;

        /// <summary>
        /// Attempts to add dungeon IDs 1 (DUNGEON_TEST_DUNGEON) through 179 (DUNGEON_RESCUE) as entries to a heap-allocated list.
        /// 
        /// If no dungeons are valid mission targets, the heap-allocated list is freed. Otherwise, sets MISSION_DUNGEON_LIST_PTR and MISSION_DUNGEON_COUNT.
        /// 
        /// return: Number of dungeons usable for a mission
        /// </summary>
        public int GenerateAllPossibleDungeonsList
        {
            get
            {
                if (f_generateAllPossibleDungeonsList)
                    return _generateAllPossibleDungeonsList;
                _generateAllPossibleDungeonsList = (int) (392048);
                f_generateAllPossibleDungeonsList = true;
                return _generateAllPossibleDungeonsList;
            }
        }
        private bool f_applyCalciumBoostToGroundMonster;
        private int _applyCalciumBoostToGroundMonster;

        /// <summary>
        /// Applies the special attack boost from Calcium to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted special attack boost, if not NULL
        /// return: actual special attack boost
        /// </summary>
        public int ApplyCalciumBoostToGroundMonster
        {
            get
            {
                if (f_applyCalciumBoostToGroundMonster)
                    return _applyCalciumBoostToGroundMonster;
                _applyCalciumBoostToGroundMonster = (int) (71664);
                f_applyCalciumBoostToGroundMonster = true;
                return _applyCalciumBoostToGroundMonster;
            }
        }
        private bool f_strcmpTagVeneer;
        private int _strcmpTagVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for StrcmpTag.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: s1
        /// r1: s2
        /// return: bool
        /// </summary>
        public int StrcmpTagVeneer
        {
            get
            {
                if (f_strcmpTagVeneer)
                    return _strcmpTagVeneer;
                _strcmpTagVeneer = (int) (145396);
                f_strcmpTagVeneer = true;
                return _strcmpTagVeneer;
            }
        }
        private bool f_getItemPaletteId;
        private int _getItemPaletteId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: palette ID
        /// </summary>
        public int GetItemPaletteId
        {
            get
            {
                if (f_getItemPaletteId)
                    return _getItemPaletteId;
                _getItemPaletteId = (int) (60096);
                f_getItemPaletteId = true;
                return _getItemPaletteId;
            }
        }
        private bool f_copy16BitsFrom;
        private int _copy16BitsFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// r1: buffer_read
        /// </summary>
        public int Copy16BitsFrom
        {
            get
            {
                if (f_copy16BitsFrom)
                    return _copy16BitsFrom;
                _copy16BitsFrom = (int) (334116);
                f_copy16BitsFrom = true;
                return _copy16BitsFrom;
            }
        }
        private bool f_overlayIsLoaded;
        private int _overlayIsLoaded;

        /// <summary>
        /// Checks if an overlay with a certain group ID is currently loaded.
        /// 
        /// See the LOADED_OVERLAY_GROUP_* data symbols or enum overlay_group_id in the C headers for a mapping between group ID and overlay number.
        /// 
        /// r0: group ID of the overlay to check. A group ID of 0 denotes no overlay, and the return value will always be true in this case.
        /// return: bool
        /// </summary>
        public int OverlayIsLoaded
        {
            get
            {
                if (f_overlayIsLoaded)
                    return _overlayIsLoaded;
                _overlayIsLoaded = (int) (16080);
                f_overlayIsLoaded = true;
                return _overlayIsLoaded;
            }
        }
        private bool f_countStickyItemsInBag;
        private int _countStickyItemsInBag;

        /// <summary>
        /// Counts the number of sticky items currently in the bag.
        /// 
        /// return: number of sticky items
        /// </summary>
        public int CountStickyItemsInBag
        {
            get
            {
                if (f_countStickyItemsInBag)
                    return _countStickyItemsInBag;
                _countStickyItemsInBag = (int) (63976);
                f_countStickyItemsInBag = true;
                return _countStickyItemsInBag;
            }
        }
        private bool f_restoreScriptVariableValues;
        private int _restoreScriptVariableValues;

        /// <summary>
        /// Restores the script variable values table (SCRIPT_VARS_VALUES) with the given data. The source data is assumed to be exactly 1024 bytes in length.
        /// 
        /// Irdkwia's notes: CheckCorrectVersion
        /// 
        /// r0: raw data to copy to the values table
        /// return: whether the restored value for VAR_VERSION is equal to its default value
        /// </summary>
        public int RestoreScriptVariableValues
        {
            get
            {
                if (f_restoreScriptVariableValues)
                    return _restoreScriptVariableValues;
                _restoreScriptVariableValues = (int) (313192);
                f_restoreScriptVariableValues = true;
                return _restoreScriptVariableValues;
            }
        }
        private bool f_divideFixedPoint64;
        private int _divideFixedPoint64;

        /// <summary>
        /// Divides two signed 64-bit fixed-point numbers (16 fraction bits).
        /// 
        /// Returns the maximum positive value ((INT64_MAX &gt;&gt; 16) + (UINT16_MAX * 2^-16)) if the divisor is zero.
        /// 
        /// r0: [output] quotient (dividend / divisor)
        /// r1: dividend
        /// r2: divisor
        /// </summary>
        public int DivideFixedPoint64
        {
            get
            {
                if (f_divideFixedPoint64)
                    return _divideFixedPoint64;
                _divideFixedPoint64 = (int) (7880);
                f_divideFixedPoint64 = true;
                return _divideFixedPoint64;
            }
        }
        private bool f_getAcceptedMission;
        private int _getAcceptedMission;

        /// <summary>
        /// Gets the mission struct corresponding to a certain mission number in the player's job list.
        /// 
        /// r0: mission id in player's job list
        /// return: mission struct pointer
        /// </summary>
        public int GetAcceptedMission
        {
            get
            {
                if (f_getAcceptedMission)
                    return _getAcceptedMission;
                _getAcceptedMission = (int) (390228);
                f_getAcceptedMission = true;
                return _getAcceptedMission;
            }
        }
        private bool f_isAffectedByTaunt;
        private int _isAffectedByTaunt;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// Based on struct move_data, maybe this should be IsUsableWhileTaunted?
        /// 
        /// r0: move
        /// return: bool
        /// </summary>
        public int IsAffectedByTaunt
        {
            get
            {
                if (f_isAffectedByTaunt)
                    return _isAffectedByTaunt;
                _isAffectedByTaunt = (int) (80888);
                f_isAffectedByTaunt = true;
                return _isAffectedByTaunt;
            }
        }
        private bool f_getFirstMatchingMemberIdx;
        private int _getFirstMatchingMemberIdx;

        /// <summary>
        /// Gets the first team member index (in the Chimecho Assembly) that has a specific monster ID, or -1 if there is none.
        /// 
        /// If valid, this will always be 5 or greater, since indexes 0-4 are reserved for main characters.
        /// 
        /// r0: monster ID
        /// return: team member index of the first matching slot
        /// </summary>
        public int GetFirstMatchingMemberIdx
        {
            get
            {
                if (f_getFirstMatchingMemberIdx)
                    return _getFirstMatchingMemberIdx;
                _getFirstMatchingMemberIdx = (int) (351344);
                f_getFirstMatchingMemberIdx = true;
                return _getFirstMatchingMemberIdx;
            }
        }
        private bool f_deleteAllPossibleMonstersList;
        private int _deleteAllPossibleMonstersList;

        /// <summary>
        /// If MISSION_MONSTER_LIST_PTR is not null, frees its heap-allocated list and nulls MISSION_MONSTER_LIST_PTR and MISSION_MONSTER_COUNT.
        /// 
        /// No params.
        /// </summary>
        public int DeleteAllPossibleMonstersList
        {
            get
            {
                if (f_deleteAllPossibleMonstersList)
                    return _deleteAllPossibleMonstersList;
                _deleteAllPossibleMonstersList = (int) (392000);
                f_deleteAllPossibleMonstersList = true;
                return _deleteAllPossibleMonstersList;
            }
        }
        private bool f_getHeroMemberIdx;
        private int _getHeroMemberIdx;

        /// <summary>
        /// Returns the team member index of the hero (0) if the hero is valid, otherwise return -1.
        /// 
        /// return: team member index
        /// </summary>
        public int GetHeroMemberIdx
        {
            get
            {
                if (f_getHeroMemberIdx)
                    return _getHeroMemberIdx;
                _getHeroMemberIdx = (int) (350668);
                f_getHeroMemberIdx = true;
                return _getHeroMemberIdx;
            }
        }
        private bool f_loadScriptVariableValueSum;
        private int _loadScriptVariableValueSum;

        /// <summary>
        /// Loads the sum of all values of a given script variable (for script variables that are arrays).
        /// 
        /// r0: pointer to the local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID
        /// return: sum of values
        /// </summary>
        public int LoadScriptVariableValueSum
        {
            get
            {
                if (f_loadScriptVariableValueSum)
                    return _loadScriptVariableValueSum;
                _loadScriptVariableValueSum = (int) (310840);
                f_loadScriptVariableValueSum = true;
                return _loadScriptVariableValueSum;
            }
        }
        private bool f_getNbItemsInBag;
        private int _getNbItemsInBag;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: # items
        /// </summary>
        public int GetNbItemsInBag
        {
            get
            {
                if (f_getNbItemsInBag)
                    return _getNbItemsInBag;
                _getNbItemsInBag = (int) (61092);
                f_getNbItemsInBag = true;
                return _getNbItemsInBag;
            }
        }
        private bool f_removeItemNoHole;
        private int _removeItemNoHole;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: index
        /// return: ?
        /// </summary>
        public int RemoveItemNoHole
        {
            get
            {
                if (f_removeItemNoHole)
                    return _removeItemNoHole;
                _removeItemNoHole = (int) (62520);
                f_removeItemNoHole = true;
                return _removeItemNoHole;
            }
        }
        private bool f_removeEmptyItemsInBag;
        private int _removeEmptyItemsInBag;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int RemoveEmptyItemsInBag
        {
            get
            {
                if (f_removeEmptyItemsInBag)
                    return _removeEmptyItemsInBag;
                _removeEmptyItemsInBag = (int) (62488);
                f_removeEmptyItemsInBag = true;
                return _removeEmptyItemsInBag;
            }
        }
        private bool f_decompressAtNormalVeneer;
        private int _decompressAtNormalVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for DecompressAtNormal.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: addr_decomp
        /// r1: expected_size
        /// r2: AT pointer
        /// return: ?
        /// </summary>
        public int DecompressAtNormalVeneer
        {
            get
            {
                if (f_decompressAtNormalVeneer)
                    return _decompressAtNormalVeneer;
                _decompressAtNormalVeneer = (int) (128604);
                f_decompressAtNormalVeneer = true;
                return _decompressAtNormalVeneer;
            }
        }
        private bool f_getDungeonModeSpecial;
        private int _getDungeonModeSpecial;

        /// <summary>
        /// Returns the status of the given dungeon, with some modifications.
        /// 
        /// If the dungeon ID is DUNGEON_BEACH, returns DMODE_REQUEST.
        /// If it's DUNGEON_JOINED_AT_UNKNOWN, returns DMODE_OPEN_AND_REQUEST.
        /// If it's &gt;= DUNGEON_NORMAL_FLY_MAZE and &lt;= DUNGEON_DOJO_0xD3, returns DMODE_OPEN_AND_REQUEST.
        /// Else, calls GetDungeonMode and returns DMODE_REQUEST if the dungeon has been cleared, or DMODE_OPEN if it's not.
        /// 
        /// r0: Dungeon ID
        /// return: Dungeon mode
        /// </summary>
        public int GetDungeonModeSpecial
        {
            get
            {
                if (f_getDungeonModeSpecial)
                    return _getDungeonModeSpecial;
                _getDungeonModeSpecial = (int) (436996);
                f_getDungeonModeSpecial = true;
                return _getDungeonModeSpecial;
            }
        }
        private bool f_isCollectionMenuState3;
        private int _isCollectionMenuState3;

        /// <summary>
        /// Checks if a collection menu has a state value of 3.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsCollectionMenuState3
        {
            get
            {
                if (f_isCollectionMenuState3)
                    return _isCollectionMenuState3;
                _isCollectionMenuState3 = (int) (185352);
                f_isCollectionMenuState3 = true;
                return _isCollectionMenuState3;
            }
        }
        private bool f_setActorTalkSub;
        private int _setActorTalkSub;

        /// <summary>
        /// Sets ACTOR_TALK_SUB to be actor_id.
        /// Implements SPECIAL_PROC_SET_ACTOR_TALK_SUB (see ScriptSpecialProcessCall).
        /// 
        /// r0: actor_id
        /// </summary>
        public int SetActorTalkSub
        {
            get
            {
                if (f_setActorTalkSub)
                    return _setActorTalkSub;
                _setActorTalkSub = (int) (417500);
                f_setActorTalkSub = true;
                return _setActorTalkSub;
            }
        }
        private bool f_initMainTeamAfterQuiz;
        private int _initMainTeamAfterQuiz;

        /// <summary>
        /// Implements SPECIAL_PROC_INIT_MAIN_TEAM_AFTER_QUIZ (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int InitMainTeamAfterQuiz
        {
            get
            {
                if (f_initMainTeamAfterQuiz)
                    return _initMainTeamAfterQuiz;
                _initMainTeamAfterQuiz = (int) (297696);
                f_initMainTeamAfterQuiz = true;
                return _initMainTeamAfterQuiz;
            }
        }
        private bool f_setNbBigTreasureWins;
        private int _setNbBigTreasureWins;

        /// <summary>
        /// Sets the number of big treasure wins.
        /// 
        /// r0: the new number of big treasure wins
        /// </summary>
        public int SetNbBigTreasureWins
        {
            get
            {
                if (f_setNbBigTreasureWins)
                    return _setNbBigTreasureWins;
                _setNbBigTreasureWins = (int) (328224);
                f_setNbBigTreasureWins = true;
                return _setNbBigTreasureWins;
            }
        }
        private bool f_getSize;
        private int _getSize;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: size
        /// </summary>
        public int GetSize
        {
            get
            {
                if (f_getSize)
                    return _getSize;
                _getSize = (int) (339024);
                f_getSize = true;
                return _getSize;
            }
        }
        private bool f_isEdible;
        private int _isEdible;

        /// <summary>
        /// Checks if an item has an item category of CATEGORY_BERRIES_SEEDS_VITAMINS or CATEGORY_FOOD_GUMMIES.
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsEdible
        {
            get
            {
                if (f_isEdible)
                    return _isEdible;
                _isEdible = (int) (52180);
                f_isEdible = true;
                return _isEdible;
            }
        }
        private bool f_createMemArena;
        private int _createMemArena;

        /// <summary>
        /// Creates a new memory arena within a given block of memory.
        /// 
        /// This is essentially a wrapper around InitMemArena, accounting for the space needed by the arena metadata.
        /// 
        /// r0: memory region in which to create the arena, as {pointer, length}
        /// r1: maximum number of blocks that the arena can hold
        /// return: memory arena pointer
        /// </summary>
        public int CreateMemArena
        {
            get
            {
                if (f_createMemArena)
                    return _createMemArena;
                _createMemArena = (int) (4736);
                f_createMemArena = true;
                return _createMemArena;
            }
        }
        private bool f_interruptMasterEnable;
        private int _interruptMasterEnable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: previous state
        /// </summary>
        public int InterruptMasterEnable
        {
            get
            {
                if (f_interruptMasterEnable)
                    return _interruptMasterEnable;
                _interruptMasterEnable = (int) (12516);
                f_interruptMasterEnable = true;
                return _interruptMasterEnable;
            }
        }
        private bool f_getMonsterIdFromSpawnEntry;
        private int _getMonsterIdFromSpawnEntry;

        /// <summary>
        /// Returns the monster ID of the specified monster spawn entry
        /// 
        /// r0: Pointer to the monster spawn entry
        /// return: monster_spawn_entry::id
        /// </summary>
        public int GetMonsterIdFromSpawnEntry
        {
            get
            {
                if (f_getMonsterIdFromSpawnEntry)
                    return _getMonsterIdFromSpawnEntry;
                _getMonsterIdFromSpawnEntry = (int) (346108);
                f_getMonsterIdFromSpawnEntry = true;
                return _getMonsterIdFromSpawnEntry;
            }
        }
        private bool f_cleanStickyItemsInBag;
        private int _cleanStickyItemsInBag;

        /// <summary>
        /// Removes the sticky flag from all the items currently in the bag.
        /// 
        /// No params.
        /// </summary>
        public int CleanStickyItemsInBag
        {
            get
            {
                if (f_cleanStickyItemsInBag)
                    return _cleanStickyItemsInBag;
                _cleanStickyItemsInBag = (int) (63928);
                f_cleanStickyItemsInBag = true;
                return _cleanStickyItemsInBag;
            }
        }
        private bool f_getEvolutions;
        private int _getEvolutions;

        /// <summary>
        /// Returns a list of all the possible evolutions for a given monster id.
        /// 
        /// r0: Monster id
        /// r1: [Output] Array that will hold the list of monster ids the specified monster can evolve into
        /// r2: True to skip the check that prevents returning monsters with a different sprite size than the current one
        /// r3: True to skip the check that prevents Shedinja from being counted as a potential evolution
        /// return: Number of possible evolutions for the specified monster id
        /// </summary>
        public int GetEvolutions
        {
            get
            {
                if (f_getEvolutions)
                    return _getEvolutions;
                _getEvolutions = (int) (344580);
                f_getEvolutions = true;
                return _getEvolutions;
            }
        }
        private bool f_checkMissionRestrictions;
        private int _checkMissionRestrictions;

        /// <summary>
        /// Seems to be used to check if you have any missions that have unmet restrictions when trying to access a dungeon.
        /// 
        /// r0: ?
        /// return: (?) Seems to be composed of multiple bitflags.
        /// </summary>
        public int CheckMissionRestrictions
        {
            get
            {
                if (f_checkMissionRestrictions)
                    return _checkMissionRestrictions;
                _checkMissionRestrictions = (int) (325372);
                f_checkMissionRestrictions = true;
                return _checkMissionRestrictions;
            }
        }
        private bool f_closeOptionsMenu;
        private int _closeOptionsMenu;

        /// <summary>
        /// Closes a window created with CreateOptionsMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseOptionsMenu
        {
            get
            {
                if (f_closeOptionsMenu)
                    return _closeOptionsMenu;
                _closeOptionsMenu = (int) (186404);
                f_closeOptionsMenu = true;
                return _closeOptionsMenu;
            }
        }
        private bool f_copyAndInterleaveWrapper;
        private int _copyAndInterleaveWrapper;

        /// <summary>
        /// Calls CopyAndInterleave with the passed len divided by 2.
        /// 
        /// r0: dst
        /// r1: src
        /// r2: len (in bytes, will be divided by 2 in the call to CopyAndInterleave)
        /// r3: val
        /// </summary>
        public int CopyAndInterleaveWrapper
        {
            get
            {
                if (f_copyAndInterleaveWrapper)
                    return _copyAndInterleaveWrapper;
                _copyAndInterleaveWrapper = (int) (114828);
                f_copyAndInterleaveWrapper = true;
                return _copyAndInterleaveWrapper;
            }
        }
        private bool f_manipMoves1v2;
        private int _manipMoves1v2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ManipMoves1v2
        {
            get
            {
                if (f_manipMoves1v2)
                    return _manipMoves1v2;
                _manipMoves1v2 = (int) (82916);
                f_manipMoves1v2 = true;
                return _manipMoves1v2;
            }
        }
        private bool f_getEncodedHalfword;
        private int _getEncodedHalfword;

        /// <summary>
        /// Decodes a 2-byte value that may be encoded using 1 or 2 bytes and writes it to the specified buffer.
        /// 
        /// The encoding system uses the most significant bit of the first byte to signal if the value is encoded as a single byte or as a halfword. If the bit is unset, the value is read as (encoded byte) &amp; 0x7F. If it's set, the value is read as ((first encoded byte) &amp; 0x7F &lt;&lt; 7) | (second encoded byte) &amp; 0x7F.
        /// 
        /// r0: Pointer to encoded value
        /// r1: [output] Buffer where the resulting 2-byte value will be stored.
        /// return: Pointer to the next byte to decode
        /// </summary>
        public int GetEncodedHalfword
        {
            get
            {
                if (f_getEncodedHalfword)
                    return _getEncodedHalfword;
                _getEncodedHalfword = (int) (342984);
                f_getEncodedHalfword = true;
                return _getEncodedHalfword;
            }
        }
        private bool f_initEventFlagScriptVars;
        private int _initEventFlagScriptVars;

        /// <summary>
        /// Initializes an assortment of event flag script variables (see the code for an exhaustive list).
        /// 
        /// No params.
        /// </summary>
        public int InitEventFlagScriptVars
        {
            get
            {
                if (f_initEventFlagScriptVars)
                    return _initEventFlagScriptVars;
                _initEventFlagScriptVars = (int) (308796);
                f_initEventFlagScriptVars = true;
                return _initEventFlagScriptVars;
            }
        }
        private bool f_getActualBuyPrice;
        private int _getActualBuyPrice;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item
        /// return: buy price
        /// </summary>
        public int GetActualBuyPrice
        {
            get
            {
                if (f_getActualBuyPrice)
                    return _getActualBuyPrice;
                _getActualBuyPrice = (int) (53736);
                f_getActualBuyPrice = true;
                return _getActualBuyPrice;
            }
        }
        private bool f_eventFlagBackupVeneer;
        private int _eventFlagBackupVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for EventFlagBackup.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// No params.
        /// </summary>
        public int EventFlagBackupVeneer
        {
            get
            {
                if (f_eventFlagBackupVeneer)
                    return _eventFlagBackupVeneer;
                _eventFlagBackupVeneer = (int) (297588);
                f_eventFlagBackupVeneer = true;
                return _eventFlagBackupVeneer;
            }
        }
        private bool f_initDebugStripped4;
        private int _initDebugStripped4;

        /// <summary>
        /// Does nothing, only called in the debug initialization function.
        /// </summary>
        public int InitDebugStripped4
        {
            get
            {
                if (f_initDebugStripped4)
                    return _initDebugStripped4;
                _initDebugStripped4 = (int) (49876);
                f_initDebugStripped4 = true;
                return _initDebugStripped4;
            }
        }
        private bool f_areItemsEquivalent;
        private int _areItemsEquivalent;

        /// <summary>
        /// Checks whether two items are equivalent and only checks the bitflags specified by the bitmask.
        /// 
        /// r0: item
        /// r1: item
        /// r2: bitmask
        /// return: bool
        /// </summary>
        public int AreItemsEquivalent
        {
            get
            {
                if (f_areItemsEquivalent)
                    return _areItemsEquivalent;
                _areItemsEquivalent = (int) (55484);
                f_areItemsEquivalent = true;
                return _areItemsEquivalent;
            }
        }
        private bool f_getDungeonGroup;
        private int _getDungeonGroup;

        /// <summary>
        /// Returns the dungeon group associated to the given dungeon.
        /// 
        /// For IDs greater or equal to dungeon_id::DUNGEON_NORMAL_FLY_MAZE, returns dungeon_group_id::DGROUP_MAROWAK_DOJO.
        /// 
        /// r0: Dungeon ID
        /// return: Group ID
        /// </summary>
        public int GetDungeonGroup
        {
            get
            {
                if (f_getDungeonGroup)
                    return _getDungeonGroup;
                _getDungeonGroup = (int) (325888);
                f_getDungeonGroup = true;
                return _getDungeonGroup;
            }
        }
        private bool f_countJobListMissions;
        private int _countJobListMissions;

        /// <summary>
        /// Gets the number of missions currently in the Job List.
        /// 
        /// return: number of missions
        /// </summary>
        public int CountJobListMissions
        {
            get
            {
                if (f_countJobListMissions)
                    return _countJobListMissions;
                _countJobListMissions = (int) (389376);
                f_countJobListMissions = true;
                return _countJobListMissions;
            }
        }
        private bool f_playSe;
        private int _playSe;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int PlaySe
        {
            get
            {
                if (f_playSe)
                    return _playSe;
                _playSe = (int) (107928);
                f_playSe = true;
                return _playSe;
            }
        }
        private bool f_initWanTable;
        private int _initWanTable;

        /// <summary>
        /// Initialize the input WAN table with 0x60 free entries (it needs a length of 0x1510 bytes)
        /// 
        /// r0: wan_table_ptr
        /// </summary>
        public int InitWanTable
        {
            get
            {
                if (f_initWanTable)
                    return _initWanTable;
                _initWanTable = (int) (119896);
                f_initWanTable = true;
                return _initWanTable;
            }
        }
        private bool f_createAdvancedMenu;
        private int _createAdvancedMenu;

        /// <summary>
        /// Creates a window containing a textual menu with complex layout and functionality (e.g., paging through multiple pages). Also see struct advanced_menu.
        /// 
        /// This is used for menus like the IQ skills menu, and the dungeon selection menu from the overworld crossroads. Curiously, it's also used in some non-interactive contexts like the Adventure Log.
        /// 
        /// If window_params is NULL, ADVANCED_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// The entry function is used to get the strings for all currently available options, so when the page is flipped the entry function is used to get the strings for the entries on the other page?
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: entry_function
        /// stack[0]: total number of options
        /// stack[1]: number of options per page
        /// return: window_id
        /// </summary>
        public int CreateAdvancedMenu
        {
            get
            {
                if (f_createAdvancedMenu)
                    return _createAdvancedMenu;
                _createAdvancedMenu = (int) (179476);
                f_createAdvancedMenu = true;
                return _createAdvancedMenu;
            }
        }
        private bool f_isMonsterMissionAllowed;
        private int _isMonsterMissionAllowed;

        /// <summary>
        /// Checks if the specified monster is contained in the MISSION_BANNED_MONSTERS array.
        /// 
        /// The function converts the ID by calling GetBaseForm and FemaleToMaleForm first.
        /// 
        /// r0: Monster ID
        /// return: False if the monster ID (after converting it) is contained in MISSION_BANNED_MONSTERS, true if it isn't.
        /// </summary>
        public int IsMonsterMissionAllowed
        {
            get
            {
                if (f_isMonsterMissionAllowed)
                    return _isMonsterMissionAllowed;
                _isMonsterMissionAllowed = (int) (404880);
                f_isMonsterMissionAllowed = true;
                return _isMonsterMissionAllowed;
            }
        }
        private bool f_updateAlertBox;
        private int _updateAlertBox;

        /// <summary>
        /// Window update function for alert boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateAlertBox
        {
            get
            {
                if (f_updateAlertBox)
                    return _updateAlertBox;
                _updateAlertBox = (int) (197992);
                f_updateAlertBox = true;
                return _updateAlertBox;
            }
        }
        private bool f_isThrownItem;
        private int _isThrownItem;

        /// <summary>
        /// Checks if a given item ID is a thrown item (CATEGORY_THROWN_LINE or CATEGORY_THROWN_ARC).
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsThrownItem
        {
            get
            {
                if (f_isThrownItem)
                    return _isThrownItem;
                _isThrownItem = (int) (52120);
                f_isThrownItem = true;
                return _isThrownItem;
            }
        }
        private bool f_cardPullOut;
        private int _cardPullOut;

        /// <summary>
        /// Sets some global flag that probably triggers system exit?
        /// 
        /// This function prints the debug string &quot;card pull out&quot;.
        /// 
        /// No params.
        /// </summary>
        public int CardPullOut
        {
            get
            {
                if (f_cardPullOut)
                    return _cardPullOut;
                _cardPullOut = (int) (15728);
                f_cardPullOut = true;
                return _cardPullOut;
            }
        }
        private bool f_isNotMoney;
        private int _isNotMoney;

        /// <summary>
        /// Checks if an item ID is not ITEM_POKE.
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsNotMoney
        {
            get
            {
                if (f_isNotMoney)
                    return _isNotMoney;
                _isNotMoney = (int) (52148);
                f_isNotMoney = true;
                return _isNotMoney;
            }
        }
        private bool f_setCollectionMenuField0x1C8;
        private int _setCollectionMenuField0x1C8;

        /// <summary>
        /// Sets collection_menu::field_0x1c8 to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetCollectionMenuField0x1C8
        {
            get
            {
                if (f_setCollectionMenuField0x1C8)
                    return _setCollectionMenuField0x1C8;
                _setCollectionMenuField0x1C8 = (int) (182920);
                f_setCollectionMenuField0x1C8 = true;
                return _setCollectionMenuField0x1C8;
            }
        }
        private bool f_getItemSpriteId;
        private int _getItemSpriteId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: sprite ID
        /// </summary>
        public int GetItemSpriteId
        {
            get
            {
                if (f_getItemSpriteId)
                    return _getItemSpriteId;
                _getItemSpriteId = (int) (60064);
                f_getItemSpriteId = true;
                return _getItemSpriteId;
            }
        }
        private bool f_initPortraitParamsWithMonsterId;
        private int _initPortraitParamsWithMonsterId;

        /// <summary>
        /// Calls InitPortraitParams, and also initializes emote to PORTRAIT_NORMAL and monster ID to the passed argument.
        /// 
        /// r0: portrait params pointer
        /// r1: monster ID
        /// </summary>
        public int InitPortraitParamsWithMonsterId
        {
            get
            {
                if (f_initPortraitParamsWithMonsterId)
                    return _initPortraitParamsWithMonsterId;
                _initPortraitParamsWithMonsterId = (int) (318220);
                f_initPortraitParamsWithMonsterId = true;
                return _initPortraitParamsWithMonsterId;
            }
        }
        private bool f_removeEmptyItems;
        private int _removeEmptyItems;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: list_pointer
        /// r1: size
        /// </summary>
        public int RemoveEmptyItems
        {
            get
            {
                if (f_removeEmptyItems)
                    return _removeEmptyItems;
                _removeEmptyItems = (int) (59032);
                f_removeEmptyItems = true;
                return _removeEmptyItems;
            }
        }
        private bool f_setRngSeed;
        private int _setRngSeed;

        /// <summary>
        /// Seed PRNG_SEQUENCE_NUM to a given value.
        /// 
        /// r0: seed
        /// </summary>
        public int SetRngSeed
        {
            get
            {
                if (f_setRngSeed)
                    return _setRngSeed;
                _setRngSeed = (int) (8764);
                f_setRngSeed = true;
                return _setRngSeed;
            }
        }
        private bool f_enableAllLearnableIqSkills;
        private int _enableAllLearnableIqSkills;

        /// <summary>
        /// Attempts to enable all the IQ skills available to the monster. If there are incompatible IQ skils,
        /// the one with the highest ID will be activated while the others will be inactivated.
        /// 
        /// r0: [output] Array where the list of skills will be written
        /// r1: Monster species
        /// r2: Monster IQ
        /// </summary>
        public int EnableAllLearnableIqSkills
        {
            get
            {
                if (f_enableAllLearnableIqSkills)
                    return _enableAllLearnableIqSkills;
                _enableAllLearnableIqSkills = (int) (365100);
                f_enableAllLearnableIqSkills = true;
                return _enableAllLearnableIqSkills;
            }
        }
        private bool f_playSeByIdVolume;
        private int _playSeByIdVolume;

        /// <summary>
        /// Plays the specified sound effect with the specified volume.
        /// 
        /// Checks for DEBUG_FLAG_SE_OFF and sets the volume to 0 if the flag is set. Calls SendAudioCommand2.
        /// 
        /// r0: Sound effect ID
        /// r1: Volume (0-255)
        /// </summary>
        public int PlaySeByIdVolume
        {
            get
            {
                if (f_playSeByIdVolume)
                    return _playSeByIdVolume;
                _playSeByIdVolume = (int) (99156);
                f_playSeByIdVolume = true;
                return _playSeByIdVolume;
            }
        }
        private bool f_negateFixedPoint64;
        private int _negateFixedPoint64;

        /// <summary>
        /// Negates a 64-bit fixed-point number (16 fraction bits) in-place.
        /// 
        /// r0: 64-bit fixed-point number to negate
        /// </summary>
        public int NegateFixedPoint64
        {
            get
            {
                if (f_negateFixedPoint64)
                    return _negateFixedPoint64;
                _negateFixedPoint64 = (int) (7416);
                f_negateFixedPoint64 = true;
                return _negateFixedPoint64;
            }
        }
        private bool f_getUnlockedTacticFlags;
        private int _getUnlockedTacticFlags;

        /// <summary>
        /// Returns an array with an entry for each tactic and if they're unlocked at the passed level.
        /// 
        /// r0: [output] bool Array where the unlocked status of each tactic is stored
        /// r1: Monster level
        /// </summary>
        public int GetUnlockedTacticFlags
        {
            get
            {
                if (f_getUnlockedTacticFlags)
                    return _getUnlockedTacticFlags;
                _getUnlockedTacticFlags = (int) (364568);
                f_getUnlockedTacticFlags = true;
                return _getUnlockedTacticFlags;
            }
        }
        private bool f_fileRead;
        private int _fileRead;

        /// <summary>
        /// Reads the contents of a file into the given buffer, and moves the file cursor accordingly.
        /// 
        /// Data transfer mode must have been initialized (with DataTransferInit) prior to calling this function. This function looks like it's doing something akin to calling read(2) or fread(3) in a loop until all the bytes have been successfully read.
        /// 
        /// Note: If code is running from IRQ mode, it appears that FileRead hangs the game. When the processor mode is forced into SYSTEM mode FileRead once again works, so it appears that ROM access only works in certain processor modes. Note that forcing the processor into a different mode is generally a bad idea and should be avoided as it will easily corrupt that processor mode's states.
        /// 
        /// r0: file_stream pointer
        /// r1: [output] buffer
        /// r2: number of bytes to read
        /// return: number of bytes read
        /// </summary>
        public int FileRead
        {
            get
            {
                if (f_fileRead)
                    return _fileRead;
                _fileRead = (int) (33364);
                f_fileRead = true;
                return _fileRead;
            }
        }
        private bool f_strncpySimple;
        private int _strncpySimple;

        /// <summary>
        /// A simple implementation of the strncpy(3) C library function.
        /// 
        /// This function was probably manually implemented by the developers. See strncpy for what's probably the real libc function.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// </summary>
        public int StrncpySimple
        {
            get
            {
                if (f_strncpySimple)
                    return _strncpySimple;
                _strncpySimple = (int) (152552);
                f_strncpySimple = true;
                return _strncpySimple;
            }
        }
        private bool f_isValidTargetItem;
        private int _isValidTargetItem;

        /// <summary>
        /// Checks if an item is a valid target item for missions. Returns true for any item less than ITEM_UNNAMED_0x16B.
        /// Appears to check a list for valid items above ITEM_UNNAMED_0x16B, but the list is empty?
        /// 
        /// r0: item_id
        /// return: bool
        /// </summary>
        public int IsValidTargetItem
        {
            get
            {
                if (f_isValidTargetItem)
                    return _isValidTargetItem;
                _isValidTargetItem = (int) (52788);
                f_isValidTargetItem = true;
                return _isValidTargetItem;
            }
        }
        private bool f_updateDebugMenu;
        private int _updateDebugMenu;

        /// <summary>
        /// Window update function for debug menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateDebugMenu
        {
            get
            {
                if (f_updateDebugMenu)
                    return _updateDebugMenu;
                _updateDebugMenu = (int) (189068);
                f_updateDebugMenu = true;
                return _updateDebugMenu;
            }
        }
        private bool f_newWindowScreenCheck;
        private int _newWindowScreenCheck;

        /// <summary>
        /// Calls NewWindow, with a pre-check for any valid existing windows in WINDOW_LIST on each screen.
        /// 
        /// r0: window_params (see NewWindow)
        /// r1: ?
        /// return: window_id
        /// </summary>
        public int NewWindowScreenCheck
        {
            get
            {
                if (f_newWindowScreenCheck)
                    return _newWindowScreenCheck;
                _newWindowScreenCheck = (int) (162108);
                f_newWindowScreenCheck = true;
                return _newWindowScreenCheck;
            }
        }
        private bool f_loadScriptVariableValue;
        private int _loadScriptVariableValue;

        /// <summary>
        /// Loads the value of a script variable.
        /// 
        /// r0: pointer to the local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID
        /// return: value
        /// </summary>
        public int LoadScriptVariableValue
        {
            get
            {
                if (f_loadScriptVariableValue)
                    return _loadScriptVariableValue;
                _loadScriptVariableValue = (int) (309284);
                f_loadScriptVariableValue = true;
                return _loadScriptVariableValue;
            }
        }
        private bool f_createCollectionMenu;
        private int _createCollectionMenu;

        /// <summary>
        /// Creates a window containing a menu for manipulating a collection of objects, with complex layout and functionality (e.g., paging). Also see struct collection_menu.
        /// 
        /// Collection menus seem similar to advanced menus, but are used for certain menus involving item management (Kangaskhan Storage, Kecleon shop, Croagunk Swap Shop), missions (job selection, bulletin board), and possibly other things.
        /// 
        /// If window_params is NULL, COLLECTION_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: some function pointer?
        /// stack[0]: ?
        /// stack[1]: total number of options
        /// stack[2]: number of options per page
        /// return: window_id
        /// </summary>
        public int CreateCollectionMenu
        {
            get
            {
                if (f_createCollectionMenu)
                    return _createCollectionMenu;
                _createCollectionMenu = (int) (181916);
                f_createCollectionMenu = true;
                return _createCollectionMenu;
            }
        }
        private bool f_updateOptionsMenu;
        private int _updateOptionsMenu;

        /// <summary>
        /// Window update function for options menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateOptionsMenu
        {
            get
            {
                if (f_updateOptionsMenu)
                    return _updateOptionsMenu;
                _updateOptionsMenu = (int) (186636);
                f_updateOptionsMenu = true;
                return _updateOptionsMenu;
            }
        }
        private bool f_isAvailableItem;
        private int _isAvailableItem;

        /// <summary>
        /// Checks if a certain item is valid to be used in delivery missions. 
        /// 
        /// Validity entails a loop throughout all dungeons, checking if they have been visited before (via a call to GetMaxReachedFloor), and checking if the item is available within a dungeon's group (via a call to IsItemAvailableInDungeonGroup).
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsAvailableItem
        {
            get
            {
                if (f_isAvailableItem)
                    return _isAvailableItem;
                _isAvailableItem = (int) (407512);
                f_isAvailableItem = true;
                return _isAvailableItem;
            }
        }
        private bool f_shuffleHiddenPower;
        private int _shuffleHiddenPower;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dmons_addr
        /// </summary>
        public int ShuffleHiddenPower
        {
            get
            {
                if (f_shuffleHiddenPower)
                    return _shuffleHiddenPower;
                _shuffleHiddenPower = (int) (344900);
                f_shuffleHiddenPower = true;
                return _shuffleHiddenPower;
            }
        }
        private bool f_getTypeFunc;
        private int _getTypeFunc;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: type index (0 for primary type or 1 for secondary type)
        /// return: type
        /// </summary>
        public int GetTypeFunc
        {
            get
            {
                if (f_getTypeFunc)
                    return _getTypeFunc;
                _getTypeFunc = (int) (339260);
                f_getTypeFunc = true;
                return _getTypeFunc;
            }
        }
        private bool f_isFutureDungeon;
        private int _isFutureDungeon;

        /// <summary>
        /// Checks if the given dungeon is a dungeon in the future arc of the main story.
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsFutureDungeon
        {
            get
            {
                if (f_isFutureDungeon)
                    return _isFutureDungeon;
                _isFutureDungeon = (int) (333828);
                f_isFutureDungeon = true;
                return _isFutureDungeon;
            }
        }
        private bool f_allocateTemp1024ByteBufferFromPool;
        private int _allocateTemp1024ByteBufferFromPool;

        /// <summary>
        /// return: Pointer to byte buffer
        /// </summary>
        public int AllocateTemp1024ByteBufferFromPool
        {
            get
            {
                if (f_allocateTemp1024ByteBufferFromPool)
                    return _allocateTemp1024ByteBufferFromPool;
                _allocateTemp1024ByteBufferFromPool = (int) (154452);
                f_allocateTemp1024ByteBufferFromPool = true;
                return _allocateTemp1024ByteBufferFromPool;
            }
        }
        private bool f_fileSeek;
        private int _fileSeek;

        /// <summary>
        /// Sets a file stream's position indicator.
        /// 
        /// This function has the a similar API to the fseek(3) library function from C, including using the same codes for the `whence` parameter:
        /// - SEEK_SET=0
        /// - SEEK_CUR=1
        /// - SEEK_END=2
        /// 
        /// r0: file_stream pointer
        /// r1: offset
        /// r2: whence
        /// </summary>
        public int FileSeek
        {
            get
            {
                if (f_fileSeek)
                    return _fileSeek;
                _fileSeek = (int) (33448);
                f_fileSeek = true;
                return _fileSeek;
            }
        }
        private bool f_loadAnimationFrameAndIncrementInAnimationControl;
        private int _loadAnimationFrameAndIncrementInAnimationControl;

        /// <summary>
        /// Read some value of the input animation frame, and update animation control with it.
        /// Also switch next_animation_frame of animation_control to the next animation frame
        /// Seems to only be called on said next_animation_frame
        /// Also set bit of some_bitfield at 0x0800 to 1
        /// 
        /// r0: animation_control
        /// r1: animation_frame
        /// </summary>
        public int LoadAnimationFrameAndIncrementInAnimationControl
        {
            get
            {
                if (f_loadAnimationFrameAndIncrementInAnimationControl)
                    return _loadAnimationFrameAndIncrementInAnimationControl;
                _loadAnimationFrameAndIncrementInAnimationControl = (int) (116220);
                f_loadAnimationFrameAndIncrementInAnimationControl = true;
                return _loadAnimationFrameAndIncrementInAnimationControl;
            }
        }
        private bool f_getMoveCritChance;
        private int _getMoveCritChance;

        /// <summary>
        /// Gets the critical hit chance of a move.
        /// 
        /// r0: move pointer
        /// return: critical hit chance
        /// </summary>
        public int GetMoveCritChance
        {
            get
            {
                if (f_getMoveCritChance)
                    return _getMoveCritChance;
                _getMoveCritChance = (int) (80824);
                f_getMoveCritChance = true;
                return _getMoveCritChance;
            }
        }
        private bool f_validateLegendaryChallengeMission;
        private int _validateLegendaryChallengeMission;

        /// <summary>
        /// Validates a legendary challenge letter mission by checking whether its dungeon matches the restricted dungeon of some mission_rescue_bin struct (alongside some other conditions).
        /// 
        /// r0: mission_template struct pointer
        /// r1: mission struct pointer
        /// return: bool
        /// </summary>
        public int ValidateLegendaryChallengeMission
        {
            get
            {
                if (f_validateLegendaryChallengeMission)
                    return _validateLegendaryChallengeMission;
                _validateLegendaryChallengeMission = (int) (396416);
                f_validateLegendaryChallengeMission = true;
                return _validateLegendaryChallengeMission;
            }
        }
        private bool f_dungeonFloorToGroupFloor;
        private int _dungeonFloorToGroupFloor;

        /// <summary>
        /// Given a dungeon ID and a floor number, returns a struct with the corresponding dungeon group and floor number in that group.
        /// 
        /// The function normally uses the data in mappa_s.bin to calculate the result, but there's some dungeons (such as dojo mazes) that have hardcoded return values.
        /// 
        /// Irdkwia's notes:
        ///   [r1]: dungeon_id
        ///   [r1+1]: dungeon_floor_id
        ///   [r0]: group_id
        ///   [r0+1]: group_floor_id
        /// 
        /// r0: [output] Struct containing the dungeon group and floor group
        /// r1: Struct containing the dungeon ID and floor number
        /// </summary>
        public int DungeonFloorToGroupFloor
        {
            get
            {
                if (f_dungeonFloorToGroupFloor)
                    return _dungeonFloorToGroupFloor;
                _dungeonFloorToGroupFloor = (int) (326020);
                f_dungeonFloorToGroupFloor = true;
                return _dungeonFloorToGroupFloor;
            }
        }
        private bool f_memsetSimple;
        private int _memsetSimple;

        /// <summary>
        /// A simple implementation of the memset(3) C library function.
        /// 
        /// This function was probably manually implemented by the developers. See memset for what's probably the real libc function.
        /// 
        /// r0: ptr
        /// r1: value
        /// r2: len (# bytes)
        /// </summary>
        public int MemsetSimple
        {
            get
            {
                if (f_memsetSimple)
                    return _memsetSimple;
                _memsetSimple = (int) (12964);
                f_memsetSimple = true;
                return _memsetSimple;
            }
        }
        private bool f_setExclusiveItemEffect;
        private int _setExclusiveItemEffect;

        /// <summary>
        /// Sets the bit for an exclusive item effect.
        /// 
        /// r0: pointer to the effects bitvector to modify
        /// r1: exclusive item effect ID
        /// </summary>
        public int SetExclusiveItemEffect
        {
            get
            {
                if (f_setExclusiveItemEffect)
                    return _setExclusiveItemEffect;
                _setExclusiveItemEffect = (int) (69672);
                f_setExclusiveItemEffect = true;
                return _setExclusiveItemEffect;
            }
        }
        private bool f_setActorTalkMainAndActorTalkSub;
        private int _setActorTalkMainAndActorTalkSub;

        /// <summary>
        /// Sets ACTOR_TALK_MAIN and ACTOR_TALK_SUB to given actor IDs.
        /// 
        /// r0: actor_id for ACTOR_TALK_MAIN
        /// r1: actor_id for ACTOR_TALK_SUB
        /// </summary>
        public int SetActorTalkMainAndActorTalkSub
        {
            get
            {
                if (f_setActorTalkMainAndActorTalkSub)
                    return _setActorTalkMainAndActorTalkSub;
                _setActorTalkMainAndActorTalkSub = (int) (417464);
                f_setActorTalkMainAndActorTalkSub = true;
                return _setActorTalkMainAndActorTalkSub;
            }
        }
        private bool f_getMonsterEvoStatus;
        private int _getMonsterEvoStatus;

        /// <summary>
        /// evo_status = 0: Not possible now
        /// evo_status = 1: Possible now
        /// evo_status = 2: No further
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ground_monster
        /// return: evo_status
        /// </summary>
        public int GetMonsterEvoStatus
        {
            get
            {
                if (f_getMonsterEvoStatus)
                    return _getMonsterEvoStatus;
                _getMonsterEvoStatus = (int) (370060);
                f_getMonsterEvoStatus = true;
                return _getMonsterEvoStatus;
            }
        }
        private bool f_isPunchMove;
        private int _isPunchMove;

        /// <summary>
        /// Checks if the given move is a punch move (affected by Iron Fist).
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsPunchMove
        {
            get
            {
                if (f_isPunchMove)
                    return _isPunchMove;
                _isPunchMove = (int) (85440);
                f_isPunchMove = true;
                return _isPunchMove;
            }
        }
        private bool f_setQuestionMarks;
        private int _setQuestionMarks;

        /// <summary>
        /// Fills the buffer with the string '???'
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// </summary>
        public int SetQuestionMarks
        {
            get
            {
                if (f_setQuestionMarks)
                    return _setQuestionMarks;
                _setQuestionMarks = (int) (152496);
                f_setQuestionMarks = true;
                return _setQuestionMarks;
            }
        }
        private bool f_showKeyboard;
        private int _showKeyboard;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: menu type
        /// r1: buffer1
        /// r2: ???
        /// r3: buffer2
        /// return: ?
        /// </summary>
        public int ShowKeyboard
        {
            get
            {
                if (f_showKeyboard)
                    return _showKeyboard;
                _showKeyboard = (int) (223972);
                f_showKeyboard = true;
                return _showKeyboard;
            }
        }
        private bool f_getActualSellPrice;
        private int _getActualSellPrice;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item
        /// return: sell price
        /// </summary>
        public int GetActualSellPrice
        {
            get
            {
                if (f_getActualSellPrice)
                    return _getActualSellPrice;
                _getActualSellPrice = (int) (53808);
                f_getActualSellPrice = true;
                return _getActualSellPrice;
            }
        }
        private bool f_playSeLoad;
        private int _playSeLoad;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int PlaySeLoad
        {
            get
            {
                if (f_playSeLoad)
                    return _playSeLoad;
                _playSeLoad = (int) (103952);
                f_playSeLoad = true;
                return _playSeLoad;
            }
        }
        private bool f_updateAreaNameBox;
        private int _updateAreaNameBox;

        /// <summary>
        /// Window update function for area name boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateAreaNameBox
        {
            get
            {
                if (f_updateAreaNameBox)
                    return _updateAreaNameBox;
                _updateAreaNameBox = (int) (196736);
                f_updateAreaNameBox = true;
                return _updateAreaNameBox;
            }
        }
        private bool f_isMonsterIllegalForMissions;
        private int _isMonsterIllegalForMissions;

        /// <summary>
        /// Checks if the monster index is illegal to be used for any mission.
        /// 
        /// Illegal indexes include Shaymin-Sky, Giratina-Origin, Purple Kecleon, Shiny Celebi, Primal Dialga, and all the unused Arceus forms.
        /// 
        /// r0: Monster ID
        /// return: True if the specified monster is illegal for missions
        /// </summary>
        public int IsMonsterIllegalForMissions
        {
            get
            {
                if (f_isMonsterIllegalForMissions)
                    return _isMonsterIllegalForMissions;
                _isMonsterIllegalForMissions = (int) (405216);
                f_isMonsterIllegalForMissions = true;
                return _isMonsterIllegalForMissions;
            }
        }
        private bool f_setPortraitOffset;
        private int _setPortraitOffset;

        /// <summary>
        /// Offsets the portrait from the original offset determined by the layout, by the vector passed as argument.
        /// 
        /// If the monster ID is MONSTER_NONE, then it does nothing.
        /// 
        /// r0: portrait params pointer
        /// r1: (x, y) offset in tiles from the original offset, derived from the layout
        /// </summary>
        public int SetPortraitOffset
        {
            get
            {
                if (f_setPortraitOffset)
                    return _setPortraitOffset;
                _setPortraitOffset = (int) (318336);
                f_setPortraitOffset = true;
                return _setPortraitOffset;
            }
        }
        private bool f_getSynthItem;
        private int _getSynthItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int GetSynthItem
        {
            get
            {
                if (f_getSynthItem)
                    return _getSynthItem;
                _getSynthItem = (int) (78584);
                f_getSynthItem = true;
                return _getSynthItem;
            }
        }
        private bool f_getLanguageType;
        private int _getLanguageType;

        /// <summary>
        /// Gets the language type.
        /// 
        /// This is the value backing the special LANGUAGE_TYPE script variable.
        /// 
        /// return: language type
        /// </summary>
        public int GetLanguageType
        {
            get
            {
                if (f_getLanguageType)
                    return _getLanguageType;
                _getLanguageType = (int) (132744);
                f_getLanguageType = true;
                return _getLanguageType;
            }
        }
        private bool f_start;
        private int _start;

        /// <summary>
        /// The entrypoint for the ARM9 CPU. This is like the &quot;main&quot; function for the ARM9 subsystem.
        /// 
        /// Once the entry function reaches the end, a constant containing the address to NitroMain is loaded into a register (r1), and a `bx` branch will jump to NitroMain.
        /// 
        /// No params.
        /// </summary>
        public int Start
        {
            get
            {
                if (f_start)
                    return _start;
                _start = (int) (2048);
                f_start = true;
                return _start;
            }
        }
        private bool f_createDebugMenu;
        private int _createDebugMenu;

        /// <summary>
        /// Creates a window containing the debug menu (probably). Also see struct debug_menu.
        /// 
        /// This is an educated guess, since this function references string IDs of debug menu strings.
        /// 
        /// See enum debug_flag and enum debug_log_flag.
        /// 
        /// If window_params is NULL, DEBUG_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: array of menu item string IDs
        /// stack[0]: number of menu items
        /// stack[1]: ?
        /// return: window_id
        /// </summary>
        public int CreateDebugMenu
        {
            get
            {
                if (f_createDebugMenu)
                    return _createDebugMenu;
                _createDebugMenu = (int) (188228);
                f_createDebugMenu = true;
                return _createDebugMenu;
            }
        }
        private bool f_createTeamSelectionMenu;
        private int _createTeamSelectionMenu;

        /// <summary>
        /// Creates a window containing a menu for selecting a single team member. Also see struct team_selection_menu.
        /// 
        /// If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// This appears to be used for various shop (and shop-like) interfaces when a single team member needs to be selected. For example, the Electivire Link Shop, the Chimecho Assembly, the Croagunk Swap Shop, and Luminous Spring. It's unknown if this is used for other contexts besides team member selection.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: function to get the menu item text for a given team member
        /// stack[0]: total number of options
        /// stack[1]: number of options per page
        /// return: window_id
        /// </summary>
        public int CreateTeamSelectionMenu
        {
            get
            {
                if (f_createTeamSelectionMenu)
                    return _createTeamSelectionMenu;
                _createTeamSelectionMenu = (int) (201272);
                f_createTeamSelectionMenu = true;
                return _createTeamSelectionMenu;
            }
        }
        private bool f_clearMissionData;
        private int _clearMissionData;

        /// <summary>
        /// Given a mission struct, clears some of its fields.
        /// 
        /// In particular, mission::status is set to mission_status::MISSION_STATUS_INVALID, mission::dungeon_id is set to -1, mission::floor is set to 0 and mission::reward_type is set to mission_reward_type::MISSION_REWARD_MONEY.
        /// 
        /// r0: Pointer to the mission to clear
        /// </summary>
        public int ClearMissionData
        {
            get
            {
                if (f_clearMissionData)
                    return _clearMissionData;
                _clearMissionData = (int) (392500);
                f_clearMissionData = true;
                return _clearMissionData;
            }
        }
        private bool f_rescueInventoryZInit;
        private int _rescueInventoryZInit;

        /// <summary>
        /// Initializes the TEAM_RESCUE inventory to be empty.
        /// 
        /// No params.
        /// </summary>
        public int RescueInventoryZInit
        {
            get
            {
                if (f_rescueInventoryZInit)
                    return _rescueInventoryZInit;
                _rescueInventoryZInit = (int) (60728);
                f_rescueInventoryZInit = true;
                return _rescueInventoryZInit;
            }
        }
        private bool f_isGameModeRescue;
        private int _isGameModeRescue;

        /// <summary>
        /// Returns true if the value of GAME_MODE is GAME_MODE_RESCUE.
        /// 
        /// return: True if GAME_MODE is GAME_MODE_RESCUE.
        /// </summary>
        public int IsGameModeRescue
        {
            get
            {
                if (f_isGameModeRescue)
                    return _isGameModeRescue;
                _isGameModeRescue = (int) (308016);
                f_isGameModeRescue = true;
                return _isGameModeRescue;
            }
        }
        private bool f_render3d64Texture0x7;
        private int _render3d64Texture0x7;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[7]. Renders a render_3d_element_64 with type RENDER64_TEXTURE_0x7.
        /// 
        /// Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TEXTURE.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64Texture0x7
        {
            get
            {
                if (f_render3d64Texture0x7)
                    return _render3d64Texture0x7;
                _render3d64Texture0x7 = (int) (125152);
                f_render3d64Texture0x7 = true;
                return _render3d64Texture0x7;
            }
        }
        private bool f_noteLoadBase;
        private int _noteLoadBase;

        /// <summary>
        /// Probably related to loading a save file or quicksave?
        /// 
        /// This function prints the debug message &quot;NoteLoad Base %d&quot; with some value. It's also the only place where SetRngSeed is called.
        /// 
        /// return: status code
        /// </summary>
        public int NoteLoadBase
        {
            get
            {
                if (f_noteLoadBase)
                    return _noteLoadBase;
                _noteLoadBase = (int) (300712);
                f_noteLoadBase = true;
                return _noteLoadBase;
            }
        }
        private bool f_getNbEggsHatched;
        private int _getNbEggsHatched;

        /// <summary>
        /// Gets the number of eggs hatched.
        /// 
        /// return: the number of eggs hatched
        /// </summary>
        public int GetNbEggsHatched
        {
            get
            {
                if (f_getNbEggsHatched)
                    return _getNbEggsHatched;
                _getNbEggsHatched = (int) (327856);
                f_getNbEggsHatched = true;
                return _getNbEggsHatched;
            }
        }
        private bool f_setChallengeLetterCleared;
        private int _setChallengeLetterCleared;

        /// <summary>
        /// Sets a challenge letter as cleared.
        /// 
        /// r0: challenge ID
        /// </summary>
        public int SetChallengeLetterCleared
        {
            get
            {
                if (f_setChallengeLetterCleared)
                    return _setChallengeLetterCleared;
                _setChallengeLetterCleared = (int) (329560);
                f_setChallengeLetterCleared = true;
                return _setChallengeLetterCleared;
            }
        }
        private bool f_getRegenSpeed;
        private int _getRegenSpeed;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: regen speed
        /// </summary>
        public int GetRegenSpeed
        {
            get
            {
                if (f_getRegenSpeed)
                    return _getRegenSpeed;
                _getRegenSpeed = (int) (338888);
                f_getRegenSpeed = true;
                return _getRegenSpeed;
            }
        }
        private bool f_getNbMovesLearned;
        private int _getNbMovesLearned;

        /// <summary>
        /// Gets the number of different moves learned.
        /// 
        /// return: the number of different moves learned
        /// </summary>
        public int GetNbMovesLearned
        {
            get
            {
                if (f_getNbMovesLearned)
                    return _getNbMovesLearned;
                _getNbMovesLearned = (int) (327896);
                f_getNbMovesLearned = true;
                return _getNbMovesLearned;
            }
        }
        private bool f_getHero;
        private int _getHero;

        /// <summary>
        /// Returns the ground monster data of the hero.
        /// 
        /// return: ground monster pointer
        /// </summary>
        public int GetHero
        {
            get
            {
                if (f_getHero)
                    return _getHero;
                _getHero = (int) (350956);
                f_getHero = true;
                return _getHero;
            }
        }
        private bool f_isItemValid;
        private int _isItemValid;

        /// <summary>
        /// Checks if an item is valid given its ID.
        /// 
        /// In particular, checks if the &quot;is valid&quot; flag is set on its item_p.bin entry.
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsItemValid
        {
            get
            {
                if (f_isItemValid)
                    return _isItemValid;
                _isItemValid = (int) (59536);
                f_isItemValid = true;
                return _isItemValid;
            }
        }
        private bool f_findAvailableMemBlock;
        private int _findAvailableMemBlock;

        /// <summary>
        /// Searches through the given memory arena for a block with enough free space.
        /// 
        /// Blocks are searched in reverse order. For object allocations (i.e., not arenas), the block with the smallest amount of free space that still suffices is returned. For arena allocations, the first satisfactory block found is returned.
        /// 
        /// r0: memory arena to search
        /// r1: internal alloc flags
        /// r2: amount of space needed, in bytes
        /// return: index of the located block in the arena's block array, or -1 if nothing is available
        /// </summary>
        public int FindAvailableMemBlock
        {
            get
            {
                if (f_findAvailableMemBlock)
                    return _findAvailableMemBlock;
                _findAvailableMemBlock = (int) (3976);
                f_findAvailableMemBlock = true;
                return _findAvailableMemBlock;
            }
        }
        private bool f_getSpeedStatus;
        private int _getSpeedStatus;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: speed status
        /// </summary>
        public int GetSpeedStatus
        {
            get
            {
                if (f_getSpeedStatus)
                    return _getSpeedStatus;
                _getSpeedStatus = (int) (338832);
                f_getSpeedStatus = true;
                return _getSpeedStatus;
            }
        }
        private bool f_playBgmByIdVolume;
        private int _playBgmByIdVolume;

        /// <summary>
        /// Initializes some values and then calls SendAudioCommand to play a BGM track.
        /// 
        /// Checks for DEBUG_FLAG_BGM_OFF. If 1, sets the volume to 0 before calling SendAudioCommand.
        /// 
        /// r0: Music ID
        /// r1: (?) Stored on byte 8 on the struct passed to SendAudioCommand
        /// r2: Volume (0-255)
        /// </summary>
        public int PlayBgmByIdVolume
        {
            get
            {
                if (f_playBgmByIdVolume)
                    return _playBgmByIdVolume;
                _playBgmByIdVolume = (int) (98060);
                f_playBgmByIdVolume = true;
                return _playBgmByIdVolume;
            }
        }
        private bool f_getActiveRosterIndex;
        private int _getActiveRosterIndex;

        /// <summary>
        /// Searches for the roster index for the given team member within the current active roster.
        /// 
        /// r0: team member index
        /// return: roster index if the team member is active, -1 otherwise
        /// </summary>
        public int GetActiveRosterIndex
        {
            get
            {
                if (f_getActiveRosterIndex)
                    return _getActiveRosterIndex;
                _getActiveRosterIndex = (int) (354104);
                f_getActiveRosterIndex = true;
                return _getActiveRosterIndex;
            }
        }
        private bool f_resumeSimpleMenu;
        private int _resumeSimpleMenu;

        /// <summary>
        /// Resumes input for a window created with CreateSimpleMenuInternal. Used for menus that do not close even after selecting an option.
        /// 
        /// r0: window_id
        /// </summary>
        public int ResumeSimpleMenu
        {
            get
            {
                if (f_resumeSimpleMenu)
                    return _resumeSimpleMenu;
                _resumeSimpleMenu = (int) (178052);
                f_resumeSimpleMenu = true;
                return _resumeSimpleMenu;
            }
        }
        private bool f_transformPaletteDataWithFlushDivideFade;
        private int _transformPaletteDataWithFlushDivideFade;

        /// <summary>
        /// r0: palette_data
        /// </summary>
        public int TransformPaletteDataWithFlushDivideFade
        {
            get
            {
                if (f_transformPaletteDataWithFlushDivideFade)
                    return _transformPaletteDataWithFlushDivideFade;
                _transformPaletteDataWithFlushDivideFade = (int) (44600);
                f_transformPaletteDataWithFlushDivideFade = true;
                return _transformPaletteDataWithFlushDivideFade;
            }
        }
        private bool f_isItemInTimeDarkness;
        private int _isItemInTimeDarkness;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsItemInTimeDarkness
        {
            get
            {
                if (f_isItemInTimeDarkness)
                    return _isItemInTimeDarkness;
                _isItemInTimeDarkness = (int) (60376);
                f_isItemInTimeDarkness = true;
                return _isItemInTimeDarkness;
            }
        }
        private bool f_getMainCharacter1MemberIdx;
        private int _getMainCharacter1MemberIdx;

        /// <summary>
        /// Returns the team member index of the first main character for the given game mode, if valid, otherwise return -1.
        /// 
        /// In normal play, this will be the hero (0). During special episodes, this will be 2.
        /// 
        /// return: team member index
        /// </summary>
        public int GetMainCharacter1MemberIdx
        {
            get
            {
                if (f_getMainCharacter1MemberIdx)
                    return _getMainCharacter1MemberIdx;
                _getMainCharacter1MemberIdx = (int) (350756);
                f_getMainCharacter1MemberIdx = true;
                return _getMainCharacter1MemberIdx;
            }
        }
        private bool f_cardBackupError;
        private int _cardBackupError;

        /// <summary>
        /// Sets some global flag that maybe indicates a save error?
        /// 
        /// This function prints the debug string &quot;card backup error&quot;.
        /// 
        /// No params.
        /// </summary>
        public int CardBackupError
        {
            get
            {
                if (f_cardBackupError)
                    return _cardBackupError;
                _cardBackupError = (int) (15764);
                f_cardBackupError = true;
                return _cardBackupError;
            }
        }
        private bool f_itemAtTableIdx;
        private int _itemAtTableIdx;

        /// <summary>
        /// Gets info about the item at a given item table (not sure what this table is...) index.
        /// 
        /// Used by SPECIAL_PROC_COUNT_TABLE_ITEM_TYPE_IN_BAG and friends (see ScriptSpecialProcessCall).
        /// 
        /// r0: table index
        /// r1: [output] pointer to an owned_item
        /// </summary>
        public int ItemAtTableIdx
        {
            get
            {
                if (f_itemAtTableIdx)
                    return _itemAtTableIdx;
                _itemAtTableIdx = (int) (417908);
                f_itemAtTableIdx = true;
                return _itemAtTableIdx;
            }
        }
        private bool f_countNbOfValidItemsInTimeDarknessInStorage;
        private int _countNbOfValidItemsInTimeDarknessInStorage;

        /// <summary>
        /// Counts the number of items currently in storage that are valid and in time and darkness.
        /// 
        /// return: number of valid items in storage
        /// </summary>
        public int CountNbOfValidItemsInTimeDarknessInStorage
        {
            get
            {
                if (f_countNbOfValidItemsInTimeDarknessInStorage)
                    return _countNbOfValidItemsInTimeDarknessInStorage;
                _countNbOfValidItemsInTimeDarknessInStorage = (int) (65192);
                f_countNbOfValidItemsInTimeDarknessInStorage = true;
                return _countNbOfValidItemsInTimeDarknessInStorage;
            }
        }
        private bool f_initItem;
        private int _initItem;

        /// <summary>
        /// Initialize an item struct with the given information.
        /// 
        /// This will resolve the quantity based on the item type. For Poké, the quantity code will always be set to 1. For thrown items, the quantity code will be randomly generated on the range of valid quantities for that item type. For non-stackable items, the quantity code will always be set to 0. Otherwise, the quantity will be assigned from the quantity argument.
        /// 
        /// r0: pointer to item to initialize
        /// r1: item ID
        /// r2: quantity
        /// r3: sticky flag
        /// </summary>
        public int InitItem
        {
            get
            {
                if (f_initItem)
                    return _initItem;
                _initItem = (int) (53028);
                f_initItem = true;
                return _initItem;
            }
        }
        private bool f_getItemCategory;
        private int _getItemCategory;

        /// <summary>
        /// Returns the category of the specified item
        /// 
        /// r0: Item ID
        /// return: Item category
        /// </summary>
        public int GetItemCategory
        {
            get
            {
                if (f_getItemCategory)
                    return _getItemCategory;
                _getItemCategory = (int) (59608);
                f_getItemCategory = true;
                return _getItemCategory;
            }
        }
        private bool f_gendersEqual;
        private int _gendersEqual;

        /// <summary>
        /// Checks if the genders for two monster IDs are equal.
        /// 
        /// r0: id1
        /// r1: id2
        /// return: bool
        /// </summary>
        public int GendersEqual
        {
            get
            {
                if (f_gendersEqual)
                    return _gendersEqual;
                _gendersEqual = (int) (348616);
                f_gendersEqual = true;
                return _gendersEqual;
            }
        }
        private bool f_getConversion2ConvertToType;
        private int _getConversion2ConvertToType;

        /// <summary>
        /// Determines which type a monster with Conversion2 should turn into after being hit by a certain
        /// type of move.
        /// 
        /// r0: type ID
        /// return: type ID
        /// </summary>
        public int GetConversion2ConvertToType
        {
            get
            {
                if (f_getConversion2ConvertToType)
                    return _getConversion2ConvertToType;
                _getConversion2ConvertToType = (int) (330908);
                f_getConversion2ConvertToType = true;
                return _getConversion2ConvertToType;
            }
        }
        private bool f_failsWhileMuzzled;
        private int _failsWhileMuzzled;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// Called IsMouthMove in Irdkwia's notes, which presumably is relevant to the Muzzled status.
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int FailsWhileMuzzled
        {
            get
            {
                if (f_failsWhileMuzzled)
                    return _failsWhileMuzzled;
                _failsWhileMuzzled = (int) (81384);
                f_failsWhileMuzzled = true;
                return _failsWhileMuzzled;
            }
        }
        private bool f_setSpriteIdForAnimationControl;
        private int _setSpriteIdForAnimationControl;

        /// <summary>
        /// Set the sprite id (from WAN_TABLE) in the given animation control
        /// Also set field 0x72 to the sprite id if they differ
        /// If they differ, it’ll also set field 0x43 to 0xFF
        /// 
        /// r0: animation control
        /// r1: sprite id in WAN_TABLE
        /// </summary>
        public int SetSpriteIdForAnimationControl
        {
            get
            {
                if (f_setSpriteIdForAnimationControl)
                    return _setSpriteIdForAnimationControl;
                _setSpriteIdForAnimationControl = (int) (115076);
                f_setSpriteIdForAnimationControl = true;
                return _setSpriteIdForAnimationControl;
            }
        }
        private bool f_isRecoilMove;
        private int _isRecoilMove;

        /// <summary>
        /// Checks if the given move is a recoil move (affected by Reckless).
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsRecoilMove
        {
            get
            {
                if (f_isRecoilMove)
                    return _isRecoilMove;
                _isRecoilMove = (int) (81596);
                f_isRecoilMove = true;
                return _isRecoilMove;
            }
        }
        private bool f_gendersEqualNotGenderless;
        private int _gendersEqualNotGenderless;

        /// <summary>
        /// Checks if the genders for two monster IDs are equal. Always returns false if either gender is GENDER_GENDERLESS.
        /// 
        /// r0: id1
        /// r1: id2
        /// return: bool
        /// </summary>
        public int GendersEqualNotGenderless
        {
            get
            {
                if (f_gendersEqualNotGenderless)
                    return _gendersEqualNotGenderless;
                _gendersEqualNotGenderless = (int) (348660);
                f_gendersEqualNotGenderless = true;
                return _gendersEqualNotGenderless;
            }
        }
        private bool f_closeScrollBox;
        private int _closeScrollBox;

        /// <summary>
        /// Closes a window created with CreateScrollBoxSingle or CreateScrollBoxMulti.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseScrollBox
        {
            get
            {
                if (f_closeScrollBox)
                    return _closeScrollBox;
                _closeScrollBox = (int) (190908);
                f_closeScrollBox = true;
                return _closeScrollBox;
            }
        }
        private bool f_getAbilityString;
        private int _getAbilityString;

        /// <summary>
        /// Copies the string for the ability id into the buffer.
        /// 
        /// r0: [output] buffer
        /// r1: ability ID
        /// </summary>
        public int GetAbilityString
        {
            get
            {
                if (f_getAbilityString)
                    return _getAbilityString;
                _getAbilityString = (int) (330836);
                f_getAbilityString = true;
                return _getAbilityString;
            }
        }
        private bool f_isMainCharacter;
        private int _isMainCharacter;

        /// <summary>
        /// Returns whether or not the team member at the given index is a &quot;main character&quot;.
        /// 
        /// During normal play, this will only be true for the hero and partner (0, 1). During special episodes, this will be true for the special-episode-reserved indexes (2, 3, 4).
        /// 
        /// r0: team member index
        /// return: bool
        /// </summary>
        public int IsMainCharacter
        {
            get
            {
                if (f_isMainCharacter)
                    return _isMainCharacter;
                _isMainCharacter = (int) (350372);
                f_isMainCharacter = true;
                return _isMainCharacter;
            }
        }
        private bool f_closeAdvancedTextBox2;
        private int _closeAdvancedTextBox2;

        /// <summary>
        /// Seems to do some things with the text box, before doing the same things that CloseAdvancedTextBox does.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseAdvancedTextBox2
        {
            get
            {
                if (f_closeAdvancedTextBox2)
                    return _closeAdvancedTextBox2;
                _closeAdvancedTextBox2 = (int) (199492);
                f_closeAdvancedTextBox2 = true;
                return _closeAdvancedTextBox2;
            }
        }
        private bool f_setStringPower;
        private int _setStringPower;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int SetStringPower
        {
            get
            {
                if (f_setStringPower)
                    return _setStringPower;
                _setStringPower = (int) (149128);
                f_setStringPower = true;
                return _setStringPower;
            }
        }
        private bool f_canBeSnatched;
        private int _canBeSnatched;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int CanBeSnatched
        {
            get
            {
                if (f_canBeSnatched)
                    return _canBeSnatched;
                _canBeSnatched = (int) (81356);
                f_canBeSnatched = true;
                return _canBeSnatched;
            }
        }
        private bool f_getMainCharacter2MemberIdx;
        private int _getMainCharacter2MemberIdx;

        /// <summary>
        /// Returns the team member index of the second main character for the given game mode, if valid, otherwise return -1.
        /// 
        /// In normal play, this will be the partner (1). During special episodes, this will be 3 if there's a second main character.
        /// 
        /// return: team member index
        /// </summary>
        public int GetMainCharacter2MemberIdx
        {
            get
            {
                if (f_getMainCharacter2MemberIdx)
                    return _getMainCharacter2MemberIdx;
                _getMainCharacter2MemberIdx = (int) (350824);
                f_getMainCharacter2MemberIdx = true;
                return _getMainCharacter2MemberIdx;
            }
        }
        private bool f_checkChecksumInvalid;
        private int _checkChecksumInvalid;

        /// <summary>
        /// Calculates the checksum of the save file and compares it with the one stored in it.
        /// 
        /// r0: Pointer to a buffer containing the save data
        /// r1: Size in bytes
        /// return: True if the calculated and stored checksums don't match, false if they do.
        /// </summary>
        public int CheckChecksumInvalid
        {
            get
            {
                if (f_checkChecksumInvalid)
                    return _checkChecksumInvalid;
                _checkChecksumInvalid = (int) (299624);
                f_checkChecksumInvalid = true;
                return _checkChecksumInvalid;
            }
        }
        private bool f_getEvoParameters;
        private int _getEvoParameters;

        /// <summary>
        /// Bx
        /// Has something to do with evolution
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] struct_evo_param
        /// r1: id
        /// </summary>
        public int GetEvoParameters
        {
            get
            {
                if (f_getEvoParameters)
                    return _getEvoParameters;
                _getEvoParameters = (int) (339432);
                f_getEvoParameters = true;
                return _getEvoParameters;
            }
        }
        private bool f_isScrollBoxActive;
        private int _isScrollBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a scroll box is not 8.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsScrollBoxActive
        {
            get
            {
                if (f_isScrollBoxActive)
                    return _isScrollBoxActive;
                _isScrollBoxActive = (int) (190936);
                f_isScrollBoxActive = true;
                return _isScrollBoxActive;
            }
        }
        private bool f_getShadowSize;
        private int _getShadowSize;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: shadow size
        /// </summary>
        public int GetShadowSize
        {
            get
            {
                if (f_getShadowSize)
                    return _getShadowSize;
                _getShadowSize = (int) (338804);
                f_getShadowSize = true;
                return _getShadowSize;
            }
        }
        private bool f_initScriptVariableValues;
        private int _initScriptVariableValues;

        /// <summary>
        /// Initialize the script variable values table (SCRIPT_VARS_VALUES).
        /// 
        /// The whole table is first zero-initialized. Then, all script variable values are first initialized to their defaults, after which some of them are overwritten with other hard-coded values.
        /// 
        /// No params.
        /// </summary>
        public int InitScriptVariableValues
        {
            get
            {
                if (f_initScriptVariableValues)
                    return _initScriptVariableValues;
                _initScriptVariableValues = (int) (308100);
                f_initScriptVariableValues = true;
                return _initScriptVariableValues;
            }
        }
        private bool f_convertPointersSir0;
        private int _convertPointersSir0;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: sir0_ptr
        /// </summary>
        public int ConvertPointersSir0
        {
            get
            {
                if (f_convertPointersSir0)
                    return _convertPointersSir0;
                _convertPointersSir0 = (int) (128464);
                f_convertPointersSir0 = true;
                return _convertPointersSir0;
            }
        }
        private bool f_copyProgressInfoFromScratchTo;
        private int _copyProgressInfoFromScratchTo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: start_address
        /// r1: total_length
        /// return: ?
        /// </summary>
        public int CopyProgressInfoFromScratchTo
        {
            get
            {
                if (f_copyProgressInfoFromScratchTo)
                    return _copyProgressInfoFromScratchTo;
                _copyProgressInfoFromScratchTo = (int) (317568);
                f_copyProgressInfoFromScratchTo = true;
                return _copyProgressInfoFromScratchTo;
            }
        }
        private bool f_setCollectionMenuField0x1A4;
        private int _setCollectionMenuField0x1A4;

        /// <summary>
        /// Sets collection_menu::field_0x1a4 to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetCollectionMenuField0x1A4
        {
            get
            {
                if (f_setCollectionMenuField0x1A4)
                    return _setCollectionMenuField0x1A4;
                _setCollectionMenuField0x1A4 = (int) (182960);
                f_setCollectionMenuField0x1A4 = true;
                return _setCollectionMenuField0x1A4;
            }
        }
        private bool f_updateSimpleMenu;
        private int _updateSimpleMenu;

        /// <summary>
        /// Window update function for simple menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateSimpleMenu
        {
            get
            {
                if (f_updateSimpleMenu)
                    return _updateSimpleMenu;
                _updateSimpleMenu = (int) (178364);
                f_updateSimpleMenu = true;
                return _updateSimpleMenu;
            }
        }
        private bool f_appendMissionSummary;
        private int _appendMissionSummary;

        /// <summary>
        /// Generates the mission title of a mission, and appends it to the string location.
        /// 
        /// r0: [output] main string location
        /// r1: temporary string buffer, concatenated to main string
        /// r2: window_id for DrawTextInWindow
        /// r3: y offset for DrawTextInWindow
        /// stack[0]: pointer to preprocessor args
        /// stack[1]: pointer to mission_details struct
        /// </summary>
        public int AppendMissionSummary
        {
            get
            {
                if (f_appendMissionSummary)
                    return _appendMissionSummary;
                _appendMissionSummary = (int) (397872);
                f_appendMissionSummary = true;
                return _appendMissionSummary;
            }
        }
        private bool f_memcpy32;
        private int _memcpy32;

        /// <summary>
        /// Copies 32-bit values from one buffer to another.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n (# bytes)
        /// </summary>
        public int Memcpy32
        {
            get
            {
                if (f_memcpy32)
                    return _memcpy32;
                _memcpy32 = (int) (13068);
                f_memcpy32 = true;
                return _memcpy32;
            }
        }
        private bool f_readMonsterFromSave;
        private int _readMonsterFromSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// r1: ground_monster
        /// </summary>
        public int ReadMonsterFromSave
        {
            get
            {
                if (f_readMonsterFromSave)
                    return _readMonsterFromSave;
                _readMonsterFromSave = (int) (366528);
                f_readMonsterFromSave = true;
                return _readMonsterFromSave;
            }
        }
        private bool f_strncpyName;
        private int _strncpyName;

        /// <summary>
        /// A special version of strncpy for handling names. Appears to use character 0x7E as some kind of
        /// formatting character in NA? Copies at most n characters.
        /// 
        /// r0: dst
        /// r1: src
        /// r2: n
        /// </summary>
        public int StrncpyName
        {
            get
            {
                if (f_strncpyName)
                    return _strncpyName;
                _strncpyName = (int) (153056);
                f_strncpyName = true;
                return _strncpyName;
            }
        }
        private bool f_uMultiplyFixedPoint64;
        private int _uMultiplyFixedPoint64;

        /// <summary>
        /// Multiplies two unsigned 64-bit fixed-point numbers (16 fraction bits) x and y.
        /// 
        /// r0: [output] product (x * y)
        /// r1: x
        /// r2: y
        /// </summary>
        public int UMultiplyFixedPoint64
        {
            get
            {
                if (f_uMultiplyFixedPoint64)
                    return _uMultiplyFixedPoint64;
                _uMultiplyFixedPoint64 = (int) (8096);
                f_uMultiplyFixedPoint64 = true;
                return _uMultiplyFixedPoint64;
            }
        }
        private bool f_getSystemClock;
        private int _getSystemClock;

        /// <summary>
        /// Gets information surrounding the DS system clock, such as the current month, day, etc.
        /// 
        /// r0: system_clock pointer
        /// </summary>
        public int GetSystemClock
        {
            get
            {
                if (f_getSystemClock)
                    return _getSystemClock;
                _getSystemClock = (int) (28520);
                f_getSystemClock = true;
                return _getSystemClock;
            }
        }
        private bool f_copyTacticString;
        private int _copyTacticString;

        /// <summary>
        /// Gets the string corresponding to a given string ID and copies it to the buffer specified in r0.
        /// 
        /// This function won't write more than 64 bytes.
        /// 
        /// r0: [output] buffer
        /// r1: tactic_id
        /// </summary>
        public int CopyTacticString
        {
            get
            {
                if (f_copyTacticString)
                    return _copyTacticString;
                _copyTacticString = (int) (370604);
                f_copyTacticString = true;
                return _copyTacticString;
            }
        }
        private bool f_getMonsterGender;
        private int _getMonsterGender;

        /// <summary>
        /// Returns the gender field of a monster given its ID.
        /// 
        /// r0: monster id
        /// return: monster gender
        /// </summary>
        public int GetMonsterGender
        {
            get
            {
                if (f_getMonsterGender)
                    return _getMonsterGender;
                _getMonsterGender = (int) (338656);
                f_getMonsterGender = true;
                return _getMonsterGender;
            }
        }
        private bool f_svcWaitByLoop;
        private int _svcWaitByLoop;

        /// <summary>
        /// Software interrupt.
        /// </summary>
        public int SvcWaitByLoop
        {
            get
            {
                if (f_svcWaitByLoop)
                    return _svcWaitByLoop;
                _svcWaitByLoop = (int) (1712);
                f_svcWaitByLoop = true;
                return _svcWaitByLoop;
            }
        }
        private bool f_render3dElement64;
        private int _render3dElement64;

        /// <summary>
        /// Dispatches a render_3d_element_64 to the render function corresponding to its type.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3dElement64
        {
            get
            {
                if (f_render3dElement64)
                    return _render3dElement64;
                _render3dElement64 = (int) (127600);
                f_render3dElement64 = true;
                return _render3dElement64;
            }
        }
        private bool f_isInvalidMoveset;
        private int _isInvalidMoveset;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_id
        /// return: bool
        /// </summary>
        public int IsInvalidMoveset
        {
            get
            {
                if (f_isInvalidMoveset)
                    return _isInvalidMoveset;
                _isInvalidMoveset = (int) (80244);
                f_isInvalidMoveset = true;
                return _isInvalidMoveset;
            }
        }
        private bool f_getRankupPoints;
        private int _getRankupPoints;

        /// <summary>
        /// Returns the number of points required to reach the next rank.
        /// 
        /// If PERFORMANCE_PROGRESS_LIST[8] is 0 and the current rank is RANK_MASTER, or if the current rank is RANK_GUILDMASTER, returns 0.
        /// 
        /// return: Points required to reach the next rank
        /// </summary>
        public int GetRankupPoints
        {
            get
            {
                if (f_getRankupPoints)
                    return _getRankupPoints;
                _getRankupPoints = (int) (331504);
                f_getRankupPoints = true;
                return _getRankupPoints;
            }
        }
        private bool f_replaceWanFromBinFile;
        private int _replaceWanFromBinFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: wan_table_ptr
        /// r1: wan_id
        /// r2: bin_file_id
        /// r3: file_id
        /// stack[0]: compressed
        /// </summary>
        public int ReplaceWanFromBinFile
        {
            get
            {
                if (f_replaceWanFromBinFile)
                    return _replaceWanFromBinFile;
                _replaceWanFromBinFile = (int) (120608);
                f_replaceWanFromBinFile = true;
                return _replaceWanFromBinFile;
            }
        }
        private bool f_wonderMailPasswordToMission;
        private int _wonderMailPasswordToMission;

        /// <summary>
        /// Tries to convert a Wonder Mail S password to a mission struct.
        /// 
        /// Returns whether the conversion was successful. This function does not include any checks if the mission itself is valid, only if the code is valid.
        /// 
        /// r0: string
        /// r1: [output] Pointer to the struct where the data of the converted mission will be written to
        /// return: successful conversion
        /// </summary>
        public int WonderMailPasswordToMission
        {
            get
            {
                if (f_wonderMailPasswordToMission)
                    return _wonderMailPasswordToMission;
                _wonderMailPasswordToMission = (int) (319672);
                f_wonderMailPasswordToMission = true;
                return _wonderMailPasswordToMission;
            }
        }
        private bool f_applyLevelUpBoostsToGroundMonster;
        private int _applyLevelUpBoostsToGroundMonster;

        /// <summary>
        /// Applies the level up boosts to stats and moves (until moveset is full) to a target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: level
        /// r2: flag that enables further editing of the monster
        /// </summary>
        public int ApplyLevelUpBoostsToGroundMonster
        {
            get
            {
                if (f_applyLevelUpBoostsToGroundMonster)
                    return _applyLevelUpBoostsToGroundMonster;
                _applyLevelUpBoostsToGroundMonster = (int) (346180);
                f_applyLevelUpBoostsToGroundMonster = true;
                return _applyLevelUpBoostsToGroundMonster;
            }
        }
        private bool f_handleSir0Translation;
        private int _handleSir0Translation;

        /// <summary>
        /// Translates the offsets in a SIR0 file into NDS memory addresses, changes the magic number to SirO (opened), and returns a pointer to the first pointer specified in the SIR0 header (beginning of the data).
        /// 
        /// Irkdiwa's notes:
        ///   ret_code = 0 if it wasn't a SIR0 file
        ///   ret_code = 1 if it has been transformed in SIRO file
        ///   ret_code = 2 if it was already a SIRO file
        ///   [output] contains a pointer to the header of the SIRO file if ret_code = 1 or 2
        ///   [output] contains a pointer which is exactly the same as the sir0_ptr if ret_code = 0
        /// 
        /// r0: [output] double pointer to beginning of data
        /// r1: pointer to source file buffer
        /// return: return code
        /// </summary>
        public int HandleSir0Translation
        {
            get
            {
                if (f_handleSir0Translation)
                    return _handleSir0Translation;
                _handleSir0Translation = (int) (128336);
                f_handleSir0Translation = true;
                return _handleSir0Translation;
            }
        }
        private bool f_applyGummiBoostsToGroundMonster;
        private int _applyGummiBoostsToGroundMonster;

        /// <summary>
        /// Applies the IQ boosts from eating a Gummi to the target monster. Basically a wrapper around
        /// ApplyGummiBoostsGroundMode for struct ground_monster.
        /// 
        /// r0: ground monster pointer
        /// r1: Item ID
        /// r2: bool to NOT increase stats
        /// r3: [output] pointer to a struct gummi_result to fill out
        /// </summary>
        public int ApplyGummiBoostsToGroundMonster
        {
            get
            {
                if (f_applyGummiBoostsToGroundMonster)
                    return _applyGummiBoostsToGroundMonster;
                _applyGummiBoostsToGroundMonster = (int) (71120);
                f_applyGummiBoostsToGroundMonster = true;
                return _applyGummiBoostsToGroundMonster;
            }
        }
        private bool f_getExplorerMazeMonster;
        private int _getExplorerMazeMonster;

        /// <summary>
        /// Returns the data of a monster sent into the Explorer Dojo using the &quot;exchange teams&quot; option.
        /// 
        /// r0: Entry number (0-3)
        /// return: Ground monster data of the specified entry
        /// </summary>
        public int GetExplorerMazeMonster
        {
            get
            {
                if (f_getExplorerMazeMonster)
                    return _getExplorerMazeMonster;
                _getExplorerMazeMonster = (int) (365684);
                f_getExplorerMazeMonster = true;
                return _getExplorerMazeMonster;
            }
        }
        private bool f_setMoneyStored;
        private int _setMoneyStored;

        /// <summary>
        /// Sets the amount of money the player has stored in the Duskull Bank, clamping the value to the range [0, MAX_MONEY_STORED].
        /// 
        /// r0: new value
        /// </summary>
        public int SetMoneyStored
        {
            get
            {
                if (f_setMoneyStored)
                    return _setMoneyStored;
                _setMoneyStored = (int) (67532);
                f_setMoneyStored = true;
                return _setMoneyStored;
            }
        }
        private bool f_isMonsterIdInNormalRange;
        private int _isMonsterIdInNormalRange;

        /// <summary>
        /// Checks if a monster ID is in the range [0, 554], meaning it's before the special story monster IDs and secondary gender IDs.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsMonsterIdInNormalRange
        {
            get
            {
                if (f_isMonsterIdInNormalRange)
                    return _isMonsterIdInNormalRange;
                _isMonsterIdInNormalRange = (int) (353808);
                f_isMonsterIdInNormalRange = true;
                return _isMonsterIdInNormalRange;
            }
        }
        private bool f_checkOptionsMenuField0x1A4;
        private int _checkOptionsMenuField0x1A4;

        /// <summary>
        /// Checks if options_menu::field_0x1a4 is 0.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int CheckOptionsMenuField0x1A4
        {
            get
            {
                if (f_checkOptionsMenuField0x1A4)
                    return _checkOptionsMenuField0x1A4;
                _checkOptionsMenuField0x1A4 = (int) (186480);
                f_checkOptionsMenuField0x1A4 = true;
                return _checkOptionsMenuField0x1A4;
            }
        }
        private bool f_isMenuOptionActive;
        private int _isMenuOptionActive;

        /// <summary>
        /// Called whenever a menu option is selected. Returns whether the option is active or not.
        /// 
        /// r0: ?
        /// return: True if the menu option is enabled, false otherwise.
        /// </summary>
        public int IsMenuOptionActive
        {
            get
            {
                if (f_isMenuOptionActive)
                    return _isMenuOptionActive;
                _isMenuOptionActive = (int) (206696);
                f_isMenuOptionActive = true;
                return _isMenuOptionActive;
            }
        }
        private bool f_allInventoriesZInit;
        private int _allInventoriesZInit;

        /// <summary>
        /// Initializes all inventories (TEAM_MAIN, TEAM_SPECIAL_EPISODE, TEAM_RESCUE) to empty and sets the active inventory
        /// to TEAM_MAIN.
        /// 
        /// No params.
        /// </summary>
        public int AllInventoriesZInit
        {
            get
            {
                if (f_allInventoriesZInit)
                    return _allInventoriesZInit;
                _allInventoriesZInit = (int) (60548);
                f_allInventoriesZInit = true;
                return _allInventoriesZInit;
            }
        }
        private bool f_setAndPlayAnimationForAnimationControl;
        private int _setAndPlayAnimationForAnimationControl;

        /// <summary>
        /// Set the animation to play with the animation control, and start it.
        /// 
        /// r0: animation_control
        /// r1: animation key (either an animation or animation group depending on the type of sprite and if it does have animation group with this animation key as index)
        /// r2: direction_id (unsure) (the key to the wan_animation in itself, only used when animation key represent a wan_animation_group)
        /// r3: ?
        /// stack[0]: low_palette_pos
        /// stack[1] (0x4): ?
        /// stack[2] (0x8): ?
        /// stack[3] (0xC): ?
        /// </summary>
        public int SetAndPlayAnimationForAnimationControl
        {
            get
            {
                if (f_setAndPlayAnimationForAnimationControl)
                    return _setAndPlayAnimationForAnimationControl;
                _setAndPlayAnimationForAnimationControl = (int) (115892);
                f_setAndPlayAnimationForAnimationControl = true;
                return _setAndPlayAnimationForAnimationControl;
            }
        }
        private bool f_getFamilyIndex;
        private int _getFamilyIndex;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: family index
        /// </summary>
        public int GetFamilyIndex
        {
            get
            {
                if (f_getFamilyIndex)
                    return _getFamilyIndex;
                _getFamilyIndex = (int) (339696);
                f_getFamilyIndex = true;
                return _getFamilyIndex;
            }
        }
        private bool f_incrementNbEggsHatched;
        private int _incrementNbEggsHatched;

        /// <summary>
        /// Increments by 1 the number of eggs hatched.
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbEggsHatched
        {
            get
            {
                if (f_incrementNbEggsHatched)
                    return _incrementNbEggsHatched;
                _incrementNbEggsHatched = (int) (327796);
                f_incrementNbEggsHatched = true;
                return _incrementNbEggsHatched;
            }
        }
        private bool f_removeItemFromKecleonShop2;
        private int _removeItemFromKecleonShop2;

        /// <summary>
        /// Removes an item from the second Kecleon Shop at a specific slot in the shop list.
        /// 
        /// r0: item slot (0-4)
        /// </summary>
        public int RemoveItemFromKecleonShop2
        {
            get
            {
                if (f_removeItemFromKecleonShop2)
                    return _removeItemFromKecleonShop2;
                _removeItemFromKecleonShop2 = (int) (68640);
                f_removeItemFromKecleonShop2 = true;
                return _removeItemFromKecleonShop2;
            }
        }
        private bool f_updateParentMenu;
        private int _updateParentMenu;

        /// <summary>
        /// Window update function for parent menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateParentMenu
        {
            get
            {
                if (f_updateParentMenu)
                    return _updateParentMenu;
                _updateParentMenu = (int) (175856);
                f_updateParentMenu = true;
                return _updateParentMenu;
            }
        }
        private bool f_writeByteFromMemoryPointer;
        private int _writeByteFromMemoryPointer;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: byte
        /// </summary>
        public int WriteByteFromMemoryPointer
        {
            get
            {
                if (f_writeByteFromMemoryPointer)
                    return _writeByteFromMemoryPointer;
                _writeByteFromMemoryPointer = (int) (132364);
                f_writeByteFromMemoryPointer = true;
                return _writeByteFromMemoryPointer;
            }
        }
        private bool f_canMonsterBeUsedForMission;
        private int _canMonsterBeUsedForMission;

        /// <summary>
        /// Returns whether a certain monster can be used (probably as the client or as the target) when generating a mission.
        /// 
        /// Excluded monsters include those that haven't been fought in dungeons yet, the second form of certain monsters and, if PERFOMANCE_PROGRESS_FLAG[9] is 0, monsters in MISSION_BANNED_STORY_MONSTERS, the species of the player and the species of the partner.
        /// 
        /// r0: Monster ID
        /// r1: True to exclude monsters in the MISSION_BANNED_MONSTERS array, false to allow them
        /// return: True if the specified monster can be part of a mission
        /// </summary>
        public int CanMonsterBeUsedForMission
        {
            get
            {
                if (f_canMonsterBeUsedForMission)
                    return _canMonsterBeUsedForMission;
                _canMonsterBeUsedForMission = (int) (404964);
                f_canMonsterBeUsedForMission = true;
                return _canMonsterBeUsedForMission;
            }
        }
        private bool f_testItemAiFlag;
        private int _testItemAiFlag;

        /// <summary>
        /// Returns a boolean indicating whether the item is consumable, throwable at an ally, or throwable at an enemy, depending on item_flag.
        /// The table used for this is inaccessible in the code, as it is loaded from a file in the ROM at runtime.
        /// Bit 7 in the table corresponds to ITEM_FLAG_CONSUMABLE, bit 6 to ITEM_FLAG_THROWABLE_AT_ALLY, and bit 5 to ITEM_FLAG_THROWABLE_AT_ENEMY.
        /// 
        /// r0: item_id enum
        /// r1: item_flag enum. Function will test a different allowed AI action depending on the value.
        /// return: bool
        /// </summary>
        public int TestItemAiFlag
        {
            get
            {
                if (f_testItemAiFlag)
                    return _testItemAiFlag;
                _testItemAiFlag = (int) (60232);
                f_testItemAiFlag = true;
                return _testItemAiFlag;
            }
        }
        private bool f_groundToDungeonMoveset;
        private int _groundToDungeonMoveset;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] moveset_dun_str
        /// r1: moveset_str
        /// </summary>
        public int GroundToDungeonMoveset
        {
            get
            {
                if (f_groundToDungeonMoveset)
                    return _groundToDungeonMoveset;
                _groundToDungeonMoveset = (int) (83852);
                f_groundToDungeonMoveset = true;
                return _groundToDungeonMoveset;
            }
        }
        private bool f_debugPrint;
        private int _debugPrint;

        /// <summary>
        /// Would log a printf format string in the debug binary. A no-op in the final binary.
        /// 
        /// r0: log level
        /// r1: format
        /// ...: variadic
        /// </summary>
        public int DebugPrint
        {
            get
            {
                if (f_debugPrint)
                    return _debugPrint;
                _debugPrint = (int) (49864);
                f_debugPrint = true;
                return _debugPrint;
            }
        }
        private bool f_isTeamSelectionMenuActive;
        private int _isTeamSelectionMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a team selection menu is something other than 6 or 7.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsTeamSelectionMenuActive
        {
            get
            {
                if (f_isTeamSelectionMenuActive)
                    return _isTeamSelectionMenuActive;
                _isTeamSelectionMenuActive = (int) (201896);
                f_isTeamSelectionMenuActive = true;
                return _isTeamSelectionMenuActive;
            }
        }
        private bool f_newWindow;
        private int _newWindow;

        /// <summary>
        /// Seems to return the ID of a newly initialized window in the next available slot in WINDOW_LIST, given some starting information.
        /// 
        /// If WINDOW_LIST is full, it will be overflowed, with the slot with an ID of 20 being initialized and returned.
        /// 
        /// r0: window_params pointer to be copied by value into window::hdr in the new window
        /// r1: ?
        /// return: window_id
        /// </summary>
        public int NewWindow
        {
            get
            {
                if (f_newWindow)
                    return _newWindow;
                _newWindow = (int) (162228);
                f_newWindow = true;
                return _newWindow;
            }
        }
        private bool f_initDebugStripped2;
        private int _initDebugStripped2;

        /// <summary>
        /// Does nothing, only called in the debug initialization function.
        /// </summary>
        public int InitDebugStripped2
        {
            get
            {
                if (f_initDebugStripped2)
                    return _initDebugStripped2;
                _initDebugStripped2 = (int) (49884);
                f_initDebugStripped2 = true;
                return _initDebugStripped2;
            }
        }
        private bool f_getAllPossibleMonsters;
        private int _getAllPossibleMonsters;

        /// <summary>
        /// Stores MISSION_MONSTER_LIST_PTR into the passed buffer and retrieves the number of monsters that can be used in a mission.
        /// 
        /// r0: buffer
        /// return: Number of monsters usable for a mission
        /// </summary>
        public int GetAllPossibleMonsters
        {
            get
            {
                if (f_getAllPossibleMonsters)
                    return _getAllPossibleMonsters;
                _getAllPossibleMonsters = (int) (391860);
                f_getAllPossibleMonsters = true;
                return _getAllPossibleMonsters;
            }
        }
        private bool f_initCp15;
        private int _initCp15;
        public int InitCp15
        {
            get
            {
                if (f_initCp15)
                    return _initCp15;
                _initCp15 = (int) (2736);
                f_initCp15 = true;
                return _initCp15;
            }
        }
        private bool f_createSimpleMenuFromStringIds;
        private int _createSimpleMenuFromStringIds;

        /// <summary>
        /// A wrapper around CreateSimpleMenuInternal, where the menu items can be defined by string ID instead of as strings.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: simple_menu_id_item struct array, terminated with an item with string_id 0
        /// stack[0]: number of items
        /// return: window_id
        /// </summary>
        public int CreateSimpleMenuFromStringIds
        {
            get
            {
                if (f_createSimpleMenuFromStringIds)
                    return _createSimpleMenuFromStringIds;
                _createSimpleMenuFromStringIds = (int) (177120);
                f_createSimpleMenuFromStringIds = true;
                return _createSimpleMenuFromStringIds;
            }
        }
        private bool f_isSpecialEpisodeOpen;
        private int _isSpecialEpisodeOpen;

        /// <summary>
        /// Checks if a special episode is unlocked from the SPECIAL_EPISODE_OPEN script variable.
        /// 
        /// r0: special episode type
        /// return: bool
        /// </summary>
        public int IsSpecialEpisodeOpen
        {
            get
            {
                if (f_isSpecialEpisodeOpen)
                    return _isSpecialEpisodeOpen;
                _isSpecialEpisodeOpen = (int) (314500);
                f_isSpecialEpisodeOpen = true;
                return _isSpecialEpisodeOpen;
            }
        }
        private bool f_loadScriptVariableRaw;
        private int _loadScriptVariableRaw;

        /// <summary>
        /// Loads a script variable descriptor for a given ID.
        /// 
        /// r0: [output] script variable descriptor pointer
        /// r1: pointer to the local variable table (doesn't need to be valid; just controls the output value pointer)
        /// r2: script variable ID
        /// </summary>
        public int LoadScriptVariableRaw
        {
            get
            {
                if (f_loadScriptVariableRaw)
                    return _loadScriptVariableRaw;
                _loadScriptVariableRaw = (int) (309204);
                f_loadScriptVariableRaw = true;
                return _loadScriptVariableRaw;
            }
        }
        private bool f_removeHolderForItemInBag;
        private int _removeHolderForItemInBag;

        /// <summary>
        /// Looks for an item in the bag that is equivalent and make the holder none. The monster's held item
        /// on their struct should be updated accordingly directly before or after calling this function.
        /// 
        /// r0: pointer to an item
        /// </summary>
        public int RemoveHolderForItemInBag
        {
            get
            {
                if (f_removeHolderForItemInBag)
                    return _removeHolderForItemInBag;
                _removeHolderForItemInBag = (int) (64508);
                f_removeHolderForItemInBag = true;
                return _removeHolderForItemInBag;
            }
        }
        private bool f_allocAudioCommand;
        private int _allocAudioCommand;

        /// <summary>
        /// Searches for an entry in AUDIO_COMMANDS_BUFFER that's not currently in use (audio_command::status == 0). Returns the first entry not in use, or null if none was found.
        /// 
        /// Also sets the status of the found entry to the value specified in r0.
        /// 
        /// The game doesn't bother checking if the result of the function is null, so the buffer is not supposed to ever get filled.
        /// 
        /// r0: Status to set the found entry to
        /// return: The first unused entry, or null if none was found
        /// </summary>
        public int AllocAudioCommand
        {
            get
            {
                if (f_allocAudioCommand)
                    return _allocAudioCommand;
                _allocAudioCommand = (int) (101384);
                f_allocAudioCommand = true;
                return _allocAudioCommand;
            }
        }
        private bool f_getHeldButtons;
        private int _getHeldButtons;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: controller
        /// r1: btn_ptr
        /// return: any_activated
        /// </summary>
        public int GetHeldButtons
        {
            get
            {
                if (f_getHeldButtons)
                    return _getHeldButtons;
                _getHeldButtons = (int) (25068);
                f_getHeldButtons = true;
                return _getHeldButtons;
            }
        }
        private bool f_getKeyboardStatus;
        private int _getKeyboardStatus;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: ?
        /// </summary>
        public int GetKeyboardStatus
        {
            get
            {
                if (f_getKeyboardStatus)
                    return _getKeyboardStatus;
                _getKeyboardStatus = (int) (225232);
                f_getKeyboardStatus = true;
                return _getKeyboardStatus;
            }
        }
        private bool f_getMaxPp;
        private int _getMaxPp;

        /// <summary>
        /// Gets the maximum PP for a given move.
        /// 
        /// Irkdwia's notes: GetMovePPWithBonus
        /// 
        /// r0: move pointer
        /// return: max PP for the given move, capped at 99
        /// </summary>
        public int GetMaxPp
        {
            get
            {
                if (f_getMaxPp)
                    return _getMaxPp;
                _getMaxPp = (int) (80632);
                f_getMaxPp = true;
                return _getMaxPp;
            }
        }
        private bool f_preprocessStringFromId;
        private int _preprocessStringFromId;

        /// <summary>
        /// Calls PreprocessString after resolving the given string ID to a string.
        /// 
        /// r0: [output] formatted string
        /// r1: maximum capacity of the output buffer
        /// r2: string ID
        /// r3: preprocessor flags
        /// stack[0]: pointer to preprocessor args
        /// </summary>
        public int PreprocessStringFromId
        {
            get
            {
                if (f_preprocessStringFromId)
                    return _preprocessStringFromId;
                _preprocessStringFromId = (int) (145332);
                f_preprocessStringFromId = true;
                return _preprocessStringFromId;
            }
        }
        private bool f_memset32;
        private int _memset32;

        /// <summary>
        /// Fills a buffer of 32-bit values with a given value.
        /// 
        /// r0: ptr
        /// r1: value
        /// r2: len (# bytes)
        /// </summary>
        public int Memset32
        {
            get
            {
                if (f_memset32)
                    return _memset32;
                _memset32 = (int) (12988);
                f_memset32 = true;
                return _memset32;
            }
        }
        private bool f_isAOrBPressed;
        private int _isAOrBPressed;

        /// <summary>
        /// Checks if A or B is currently being held.
        /// 
        /// return: bool
        /// </summary>
        public int IsAOrBPressed
        {
            get
            {
                if (f_isAOrBPressed)
                    return _isAOrBPressed;
                _isAOrBPressed = (int) (156108);
                f_isAOrBPressed = true;
                return _isAOrBPressed;
            }
        }
        private bool f_sendAudioCommand2;
        private int _sendAudioCommand2;

        /// <summary>
        /// Very similar to SendAudioCommand. Contains an additional function call.
        /// 
        /// r0: Command to send
        /// </summary>
        public int SendAudioCommand2
        {
            get
            {
                if (f_sendAudioCommand2)
                    return _sendAudioCommand2;
                _sendAudioCommand2 = (int) (101248);
                f_sendAudioCommand2 = true;
                return _sendAudioCommand2;
            }
        }
        private bool f_getBodySize;
        private int _getBodySize;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: body size
        /// </summary>
        public int GetBodySize
        {
            get
            {
                if (f_getBodySize)
                    return _getBodySize;
                _getBodySize = (int) (338684);
                f_getBodySize = true;
                return _getBodySize;
            }
        }
        private bool f_playBgmByIdVeneer;
        private int _playBgmByIdVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for PlayBgmById.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: Music ID
        /// </summary>
        public int PlayBgmByIdVeneer
        {
            get
            {
                if (f_playBgmByIdVeneer)
                    return _playBgmByIdVeneer;
                _playBgmByIdVeneer = (int) (97268);
                f_playBgmByIdVeneer = true;
                return _playBgmByIdVeneer;
            }
        }
        private bool f_isMissionSuspendedAndValid;
        private int _isMissionSuspendedAndValid;

        /// <summary>
        /// Checks if a mission is currently suspended and contains valid fields. Calls IsMissionValid for the validity check.
        /// 
        /// r0: mission to check
        /// return: bool
        /// </summary>
        public int IsMissionSuspendedAndValid
        {
            get
            {
                if (f_isMissionSuspendedAndValid)
                    return _isMissionSuspendedAndValid;
                _isMissionSuspendedAndValid = (int) (379856);
                f_isMissionSuspendedAndValid = true;
                return _isMissionSuspendedAndValid;
            }
        }
        private bool f_getHpBoostFromExclusiveItems;
        private int _getHpBoostFromExclusiveItems;

        /// <summary>
        /// Calculates the current HP boost from exclusive items. If none are active, return 0.
        /// 
        /// r0: some struct that has species ID in it?
        /// return: max HP boost from exclusive items
        /// </summary>
        public int GetHpBoostFromExclusiveItems
        {
            get
            {
                if (f_getHpBoostFromExclusiveItems)
                    return _getHpBoostFromExclusiveItems;
                _getHpBoostFromExclusiveItems = (int) (70716);
                f_getHpBoostFromExclusiveItems = true;
                return _getHpBoostFromExclusiveItems;
            }
        }
        private bool f_isSameMove;
        private int _isSameMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_dun_str
        /// r1: move_data_dun_str
        /// return: bool
        /// </summary>
        public int IsSameMove
        {
            get
            {
                if (f_isSameMove)
                    return _isSameMove;
                _isSameMove = (int) (86516);
                f_isSameMove = true;
                return _isSameMove;
            }
        }
        private bool f_countNbOfItemsInStorage;
        private int _countNbOfItemsInStorage;

        /// <summary>
        /// Counts the number of items currently in storage (including invalid items).
        /// 
        /// return: number of items in storage
        /// </summary>
        public int CountNbOfItemsInStorage
        {
            get
            {
                if (f_countNbOfItemsInStorage)
                    return _countNbOfItemsInStorage;
                _countNbOfItemsInStorage = (int) (65056);
                f_countNbOfItemsInStorage = true;
                return _countNbOfItemsInStorage;
            }
        }
        private bool f_getFileLengthInPack;
        private int _getFileLengthInPack;

        /// <summary>
        /// Get the length of a file entry from a Pack archive
        /// 
        /// r0: pack file struct
        /// r1: file index
        /// return: size of the file in bytes from the Pack Table of Content
        /// </summary>
        public int GetFileLengthInPack
        {
            get
            {
                if (f_getFileLengthInPack)
                    return _getFileLengthInPack;
                _getFileLengthInPack = (int) (50428);
                f_getFileLengthInPack = true;
                return _getFileLengthInPack;
            }
        }
        private bool f_showStringInDialogueBox;
        private int _showStringInDialogueBox;

        /// <summary>
        /// Preprocesses the passed string and puts it into the dialogue box.
        /// 
        /// r0: window_id
        /// r1: preprocessor flags (see PreprocessString)
        /// r2: string
        /// r3: pointer to preprocessor args (see PreprocessString)
        /// </summary>
        public int ShowStringInDialogueBox
        {
            get
            {
                if (f_showStringInDialogueBox)
                    return _showStringInDialogueBox;
                _showStringInDialogueBox = (int) (193840);
                f_showStringInDialogueBox = true;
                return _showStringInDialogueBox;
            }
        }
        private bool f_printMoveOptionMenu;
        private int _printMoveOptionMenu;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int PrintMoveOptionMenu
        {
            get
            {
                if (f_printMoveOptionMenu)
                    return _printMoveOptionMenu;
                _printMoveOptionMenu = (int) (263612);
                f_printMoveOptionMenu = true;
                return _printMoveOptionMenu;
            }
        }
        private bool f_isMoneyAllowed;
        private int _isMoneyAllowed;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsMoneyAllowed
        {
            get
            {
                if (f_isMoneyAllowed)
                    return _isMoneyAllowed;
                _isMoneyAllowed = (int) (333456);
                f_isMoneyAllowed = true;
                return _isMoneyAllowed;
            }
        }
        private bool f_initWindowTrailer;
        private int _initWindowTrailer;

        /// <summary>
        /// Seems to initialize a window_trailer within a new window.
        /// 
        /// r0: window_trailer pointer
        /// </summary>
        public int InitWindowTrailer
        {
            get
            {
                if (f_initWindowTrailer)
                    return _initWindowTrailer;
                _initWindowTrailer = (int) (170340);
                f_initWindowTrailer = true;
                return _initWindowTrailer;
            }
        }
        private bool f_getItemActionName;
        private int _getItemActionName;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: action name ID
        /// </summary>
        public int GetItemActionName
        {
            get
            {
                if (f_getItemActionName)
                    return _getItemActionName;
                _getItemActionName = (int) (60128);
                f_getItemActionName = true;
                return _getItemActionName;
            }
        }
        private bool f_executeCopyToFlatVramCommand;
        private int _executeCopyToFlatVramCommand;

        /// <summary>
        /// Immediately execute the command contained in a copy_to_obj_vram_order struct, copying content as described.
        /// 
        /// r0: command
        /// </summary>
        public int ExecuteCopyToFlatVramCommand
        {
            get
            {
                if (f_executeCopyToFlatVramCommand)
                    return _executeCopyToFlatVramCommand;
                _executeCopyToFlatVramCommand = (int) (109480);
                f_executeCopyToFlatVramCommand = true;
                return _executeCopyToFlatVramCommand;
            }
        }
        private bool f_removeBulkItemInStorage;
        private int _removeBulkItemInStorage;

        /// <summary>
        /// Removes a storage item equivalent to the bulk_item passed from storage.
        /// Probably? Implements SPECIAL_PROC_REMOVE_ITEM_TYPE_IN_STORAGE (see ScriptSpecialProcessCall).
        /// 
        /// r0: pointer to a bulk_item
        /// return: bool whether an item was removed
        /// </summary>
        public int RemoveBulkItemInStorage
        {
            get
            {
                if (f_removeBulkItemInStorage)
                    return _removeBulkItemInStorage;
                _removeBulkItemInStorage = (int) (66188);
                f_removeBulkItemInStorage = true;
                return _removeBulkItemInStorage;
            }
        }
        private bool f_closeControlsChart;
        private int _closeControlsChart;

        /// <summary>
        /// Closes a window created with CreateControlsChart.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseControlsChart
        {
            get
            {
                if (f_closeControlsChart)
                    return _closeControlsChart;
                _closeControlsChart = (int) (197064);
                f_closeControlsChart = true;
                return _closeControlsChart;
            }
        }
        private bool f_uDivideFixedPoint64;
        private int _uDivideFixedPoint64;

        /// <summary>
        /// Divides two unsigned 64-bit fixed-point numbers (16 fraction bits).
        /// 
        /// Returns the maximum positive value for a signed fixed-point number ((INT64_MAX &gt;&gt; 16) + (UINT16_MAX * 2^-16)) if the divisor is zero.
        /// 
        /// r0: [output] quotient (dividend / divisor)
        /// r1: dividend
        /// r2: divisor
        /// </summary>
        public int UDivideFixedPoint64
        {
            get
            {
                if (f_uDivideFixedPoint64)
                    return _uDivideFixedPoint64;
                _uDivideFixedPoint64 = (int) (8324);
                f_uDivideFixedPoint64 = true;
                return _uDivideFixedPoint64;
            }
        }
        private bool f_rand32Bit;
        private int _rand32Bit;

        /// <summary>
        /// Computes a random 32-bit integer using the general-purpose PRNG. The upper and lower 16 bits are each generated with a separate call to Rand16Bit (so this function advances the PRNG twice).
        /// 
        /// return: pseudorandom int on the interval [0, 4294967295]
        /// </summary>
        public int Rand32Bit
        {
            get
            {
                if (f_rand32Bit)
                    return _rand32Bit;
                _rand32Bit = (int) (8876);
                f_rand32Bit = true;
                return _rand32Bit;
            }
        }
        private bool f_getWeightMultiplier;
        private int _getWeightMultiplier;

        /// <summary>
        /// Gets the weight multiplier value for the given species. This value is passed as the damage_mult_fp parameter to DealDamage when calculating the damage dealt by Low Kick and Grass Knot.
        /// 
        /// r0: monster ID
        /// return: Monster weight multiplier, as a binary fixed-point number with 8 fraction bits.
        /// </summary>
        public int GetWeightMultiplier
        {
            get
            {
                if (f_getWeightMultiplier)
                    return _getWeightMultiplier;
                _getWeightMultiplier = (int) (338996);
                f_getWeightMultiplier = true;
                return _getWeightMultiplier;
            }
        }
        private bool f_createPortraitBox;
        private int _createPortraitBox;

        /// <summary>
        /// Creates a window containing a character portrait. Also see struct portrait_box.
        /// 
        /// This is commonly paired with a dialogue box, but can also be used standalone.
        /// 
        /// If framed, the window box type will be 0xFC, otherwise it will be 0xF9.
        /// 
        /// The new window will always default to PORTRAIT_BOX_DEFAULT_WINDOW_PARAMS.
        /// 
        /// r0: screen index
        /// r1: palette_idx
        /// r2: framed
        /// return: window_id
        /// </summary>
        public int CreatePortraitBox
        {
            get
            {
                if (f_createPortraitBox)
                    return _createPortraitBox;
                _createPortraitBox = (int) (194720);
                f_createPortraitBox = true;
                return _createPortraitBox;
            }
        }
        private bool f_learnMoves;
        private int _learnMoves;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// r1: moves_id
        /// </summary>
        public int LearnMoves
        {
            get
            {
                if (f_learnMoves)
                    return _learnMoves;
                _learnMoves = (int) (84308);
                f_learnMoves = true;
                return _learnMoves;
            }
        }
        private bool f_copyLogTo;
        private int _copyLogTo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: write_info
        /// </summary>
        public int CopyLogTo
        {
            get
            {
                if (f_copyLogTo)
                    return _copyLogTo;
                _copyLogTo = (int) (329860);
                f_copyLogTo = true;
                return _copyLogTo;
            }
        }
        private bool f_multiplyByFixedPoint;
        private int _multiplyByFixedPoint;

        /// <summary>
        /// Multiply a signed integer x by a signed binary fixed-point multiplier (8 fraction bits).
        /// 
        /// r0: x
        /// r1: multiplier
        /// return: x * multiplier
        /// </summary>
        public int MultiplyByFixedPoint
        {
            get
            {
                if (f_multiplyByFixedPoint)
                    return _multiplyByFixedPoint;
                _multiplyByFixedPoint = (int) (6740);
                f_multiplyByFixedPoint = true;
                return _multiplyByFixedPoint;
            }
        }
        private bool f_copyNStringFromId;
        private int _copyNStringFromId;

        /// <summary>
        /// Gets the string corresponding to a given string ID and copies it to the buffer specified in r0.
        /// 
        /// This function won't write more than &lt;buffer length&gt; bytes.
        /// 
        /// r0: buffer
        /// r1: string ID
        /// r2: buffer length
        /// </summary>
        public int CopyNStringFromId
        {
            get
            {
                if (f_copyNStringFromId)
                    return _copyNStringFromId;
                _copyNStringFromId = (int) (154584);
                f_copyNStringFromId = true;
                return _copyNStringFromId;
            }
        }
        private bool f_randInt;
        private int _randInt;

        /// <summary>
        /// Compute a pseudorandom integer under a given maximum value using the general-purpose PRNG.
        /// 
        /// This function relies on a single call to Rand16Bit. Even though it takes a 32-bit integer as input, the number of unique outcomes is capped at 2^16.
        /// 
        /// r0: high
        /// return: pseudorandom integer on the interval [0, high - 1]
        /// </summary>
        public int RandInt
        {
            get
            {
                if (f_randInt)
                    return _randInt;
                _randInt = (int) (8820);
                f_randInt = true;
                return _randInt;
            }
        }
        private bool f_enqueueRender3d64Tiling;
        private int _enqueueRender3d64Tiling;

        /// <summary>
        /// Converts a render_3d_element_64 with type RENDER64_TILING to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TILING.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int EnqueueRender3d64Tiling
        {
            get
            {
                if (f_enqueueRender3d64Tiling)
                    return _enqueueRender3d64Tiling;
                _enqueueRender3d64Tiling = (int) (126264);
                f_enqueueRender3d64Tiling = true;
                return _enqueueRender3d64Tiling;
            }
        }
        private bool f_incrementNbFainted;
        private int _incrementNbFainted;

        /// <summary>
        /// Increments by 1 the number of times you fainted.
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbFainted
        {
            get
            {
                if (f_incrementNbFainted)
                    return _incrementNbFainted;
                _incrementNbFainted = (int) (329192);
                f_incrementNbFainted = true;
                return _incrementNbFainted;
            }
        }
        private bool f_getIqGroup;
        private int _getIqGroup;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: IQ group
        /// </summary>
        public int GetIqGroup
        {
            get
            {
                if (f_getIqGroup)
                    return _getIqGroup;
                _getIqGroup = (int) (339552);
                f_getIqGroup = true;
                return _getIqGroup;
            }
        }
        private bool f_getBaseOffensiveStat;
        private int _getBaseOffensiveStat;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: stat index
        /// return: base attack/special attack stat
        /// </summary>
        public int GetBaseOffensiveStat
        {
            get
            {
                if (f_getBaseOffensiveStat)
                    return _getBaseOffensiveStat;
                _getBaseOffensiveStat = (int) (339196);
                f_getBaseOffensiveStat = true;
                return _getBaseOffensiveStat;
            }
        }
        private bool f_setActiveInventory;
        private int _setActiveInventory;

        /// <summary>
        /// Changes the currently active inventory. Has one for the main team, rescue team, and the special
        /// episode team.
        /// 
        /// r0: team ID
        /// </summary>
        public int SetActiveInventory
        {
            get
            {
                if (f_setActiveInventory)
                    return _setActiveInventory;
                _setActiveInventory = (int) (60800);
                f_setActiveInventory = true;
                return _setActiveInventory;
            }
        }
        private bool f_guestMonsterToGroundMonster;
        private int _guestMonsterToGroundMonster;

        /// <summary>
        /// Inits a ground_monster entry with the given guest_monster struct.
        /// 
        /// r0: [output] ground_monster struct to init
        /// r1: guest_monster struct to use
        /// </summary>
        public int GuestMonsterToGroundMonster
        {
            get
            {
                if (f_guestMonsterToGroundMonster)
                    return _guestMonsterToGroundMonster;
                _guestMonsterToGroundMonster = (int) (340428);
                f_guestMonsterToGroundMonster = true;
                return _guestMonsterToGroundMonster;
            }
        }
        private bool f_enableAllInterrupts;
        private int _enableAllInterrupts;

        /// <summary>
        /// Sets the Interrupt Master Enable (IME) register to 1, which enables all CPU interrupts (if enabled in the Interrupt Enable (IE) register).
        /// 
        /// See https://problemkaputt.de/gbatek.htm#dsiomaps.
        /// 
        /// return: old value in the IME register
        /// </summary>
        public int EnableAllInterrupts
        {
            get
            {
                if (f_enableAllInterrupts)
                    return _enableAllInterrupts;
                _enableAllInterrupts = (int) (13832);
                f_enableAllInterrupts = true;
                return _enableAllInterrupts;
            }
        }
        private bool f_getPressedButtons;
        private int _getPressedButtons;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: controller
        /// r1: btn_ptr
        /// return: any_activated
        /// </summary>
        public int GetPressedButtons
        {
            get
            {
                if (f_getPressedButtons)
                    return _getPressedButtons;
                _getPressedButtons = (int) (25180);
                f_getPressedButtons = true;
                return _getPressedButtons;
            }
        }
        private bool f_canThrowItems;
        private int _canThrowItems;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: bool
        /// </summary>
        public int CanThrowItems
        {
            get
            {
                if (f_canThrowItems)
                    return _canThrowItems;
                _canThrowItems = (int) (339080);
                f_canThrowItems = true;
                return _canThrowItems;
            }
        }
        private bool f_getMoneyCarried;
        private int _getMoneyCarried;

        /// <summary>
        /// Gets the amount of money the player is carrying.
        /// 
        /// return: value
        /// </summary>
        public int GetMoneyCarried
        {
            get
            {
                if (f_getMoneyCarried)
                    return _getMoneyCarried;
                _getMoneyCarried = (int) (60836);
                f_getMoneyCarried = true;
                return _getMoneyCarried;
            }
        }
        private bool f_isSkyExclusiveDungeon;
        private int _isSkyExclusiveDungeon;

        /// <summary>
        /// Also the dungeons where Giratina has its Origin Form
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon_id
        /// return: bool
        /// </summary>
        public int IsSkyExclusiveDungeon
        {
            get
            {
                if (f_isSkyExclusiveDungeon)
                    return _isSkyExclusiveDungeon;
                _isSkyExclusiveDungeon = (int) (334460);
                f_isSkyExclusiveDungeon = true;
                return _isSkyExclusiveDungeon;
            }
        }
        private bool f_playSeFullSpec;
        private int _playSeFullSpec;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int PlaySeFullSpec
        {
            get
            {
                if (f_playSeFullSpec)
                    return _playSeFullSpec;
                _playSeFullSpec = (int) (108296);
                f_playSeFullSpec = true;
                return _playSeFullSpec;
            }
        }
        private bool f_updateWindow;
        private int _updateWindow;

        /// <summary>
        /// Seems to cause updated window contents to be displayed.
        ///    
        /// Gets called for example at the end of a text box window update and seems to &quot;commit&quot; the update, but in general also gets called with all kinds of window updates. 
        /// 
        /// r0: window_id
        /// </summary>
        public int UpdateWindow
        {
            get
            {
                if (f_updateWindow)
                    return _updateWindow;
                _updateWindow = (int) (163300);
                f_updateWindow = true;
                return _updateWindow;
            }
        }
        private bool f_isControlsChartActive;
        private int _isControlsChartActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a controls chart is something other than 2 or 4.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsControlsChartActive
        {
            get
            {
                if (f_isControlsChartActive)
                    return _isControlsChartActive;
                _isControlsChartActive = (int) (197092);
                f_isControlsChartActive = true;
                return _isControlsChartActive;
            }
        }
        private bool f_soundResume;
        private int _soundResume;

        /// <summary>
        /// Probably resumes the sound player if paused?
        /// 
        /// This function prints the debug string &quot;sound resume&quot;.
        /// </summary>
        public int SoundResume
        {
            get
            {
                if (f_soundResume)
                    return _soundResume;
                _soundResume = (int) (15556);
                f_soundResume = true;
                return _soundResume;
            }
        }
        private bool f_addMoneyStored;
        private int _addMoneyStored;

        /// <summary>
        /// Adds money to the amount of money the player has stored in the Duskull Bank. Just calls SetMoneyStored with the current money + money gained.
        /// 
        /// r0: money gained (can be negative)
        /// </summary>
        public int AddMoneyStored
        {
            get
            {
                if (f_addMoneyStored)
                    return _addMoneyStored;
                _addMoneyStored = (int) (67584);
                f_addMoneyStored = true;
                return _addMoneyStored;
            }
        }
        private bool f_getAbility;
        private int _getAbility;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: ability index (0 for primary ability or 1 for secondary ability)
        /// return: ability
        /// </summary>
        public int GetAbility
        {
            get
            {
                if (f_getAbility)
                    return _getAbility;
                _getAbility = (int) (339292);
                f_getAbility = true;
                return _getAbility;
            }
        }
        private bool f_initWindowInput;
        private int _initWindowInput;

        /// <summary>
        /// This seems to be called when creating most interactive windows that respond to user input, like menus (but also other interactive windows like scroll boxes and advanced text boxes). It presumably sets up the state necessary for detecting and responding to user input.
        /// 
        /// r0: window_input_ctx pointer
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: window rectangle
        /// stack[0]: total number of selectable items
        /// stack[1]: number of selectable items per page
        /// </summary>
        public int InitWindowInput
        {
            get
            {
                if (f_initWindowInput)
                    return _initWindowInput;
                _initWindowInput = (int) (204268);
                f_initWindowInput = true;
                return _initWindowInput;
            }
        }
        private bool f_anyDungeonRequestsDone;
        private int _anyDungeonRequestsDone;

        /// <summary>
        /// Calls DungeonRequestsDone with the second argument set to true, and converts the integer output to a boolean.
        /// 
        /// r0: ?
        /// return: bool: whether the number of missions completed is greater than 0
        /// </summary>
        public int AnyDungeonRequestsDone
        {
            get
            {
                if (f_anyDungeonRequestsDone)
                    return _anyDungeonRequestsDone;
                _anyDungeonRequestsDone = (int) (389532);
                f_anyDungeonRequestsDone = true;
                return _anyDungeonRequestsDone;
            }
        }
        private bool f_applyExclusiveItemStatBoosts;
        private int _applyExclusiveItemStatBoosts;

        /// <summary>
        /// Applies stat boosts from an exclusive item.
        /// 
        /// r0: item ID
        /// r1: pointer to attack stat to modify
        /// r2: pointer to special attack stat to modify
        /// r3: pointer to defense stat to modify
        /// stack[0]: pointer to special defense stat to modify
        /// </summary>
        public int ApplyExclusiveItemStatBoosts
        {
            get
            {
                if (f_applyExclusiveItemStatBoosts)
                    return _applyExclusiveItemStatBoosts;
                _applyExclusiveItemStatBoosts = (int) (69388);
                f_applyExclusiveItemStatBoosts = true;
                return _applyExclusiveItemStatBoosts;
            }
        }
        private bool f_generateKecleonItems1;
        private int _generateKecleonItems1;

        /// <summary>
        /// Generates the Kecleon Shop items for both shopkeepers in Treasure Town. This function also calls
        /// GenerateKecleonItems2 despite GenerateKecleonItems2 being called directly after. This means that
        /// any items generated for the Orb/TM shop will be overwritten by the subsequent call to
        /// GenerateKecleonItems2.
        /// 
        /// r0: kecleon_shop_version to use
        /// </summary>
        public int GenerateKecleonItems1
        {
            get
            {
                if (f_generateKecleonItems1)
                    return _generateKecleonItems1;
                _generateKecleonItems1 = (int) (68340);
                f_generateKecleonItems1 = true;
                return _generateKecleonItems1;
            }
        }
        private bool f_getMoveActualAccuracy;
        private int _getMoveActualAccuracy;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: accuracy
        /// </summary>
        public int GetMoveActualAccuracy
        {
            get
            {
                if (f_getMoveActualAccuracy)
                    return _getMoveActualAccuracy;
                _getMoveActualAccuracy = (int) (80952);
                f_getMoveActualAccuracy = true;
                return _getMoveActualAccuracy;
            }
        }
        private bool f_setNbRecycled;
        private int _setNbRecycled;

        /// <summary>
        /// Sets the number of items recycled.
        /// 
        /// r0: the new number of items recycled
        /// </summary>
        public int SetNbRecycled
        {
            get
            {
                if (f_setNbRecycled)
                    return _setNbRecycled;
                _setNbRecycled = (int) (328300);
                f_setNbRecycled = true;
                return _setNbRecycled;
            }
        }
        private bool f_allManip2;
        private int _allManip2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int AllManip2
        {
            get
            {
                if (f_allManip2)
                    return _allManip2;
                _allManip2 = (int) (82608);
                f_allManip2 = true;
                return _allManip2;
            }
        }
        private bool f_getMoveTargetAndRange;
        private int _getMoveTargetAndRange;

        /// <summary>
        /// Gets the move target-and-range field. See struct move_target_and_range in the C headers.
        /// 
        /// r0: move pointer
        /// r1: AI flag (every move has two target-and-range fields, one for players and one for AI)
        /// return: move target and range
        /// </summary>
        public int GetMoveTargetAndRange
        {
            get
            {
                if (f_getMoveTargetAndRange)
                    return _getMoveTargetAndRange;
                _getMoveTargetAndRange = (int) (80104);
                f_getMoveTargetAndRange = true;
                return _getMoveTargetAndRange;
            }
        }
        private bool f_initDungeonListScriptVars;
        private int _initDungeonListScriptVars;

        /// <summary>
        /// Initializes the DUNGEON_*_LIST script variable values (IDs 0x4f-0x54).
        /// 
        /// No params.
        /// </summary>
        public int InitDungeonListScriptVars
        {
            get
            {
                if (f_initDungeonListScriptVars)
                    return _initDungeonListScriptVars;
                _initDungeonListScriptVars = (int) (315848);
                f_initDungeonListScriptVars = true;
                return _initDungeonListScriptVars;
            }
        }
        private bool f_createAdvancedTextBox;
        private int _createAdvancedTextBox;

        /// <summary>
        /// Calls CreateAdvancedTextBoxInternal with all the selectable items on one page (n_items_per_page = n_items), sets the callback without an argument, and returns the window_id.
        /// 
        /// If window_params is NULL, ADVANCED_TEXT_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: text box callback function
        /// stack[0]: number of selectable items
        /// return: window_id
        /// </summary>
        public int CreateAdvancedTextBox
        {
            get
            {
                if (f_createAdvancedTextBox)
                    return _createAdvancedTextBox;
                _createAdvancedTextBox = (int) (198824);
                f_createAdvancedTextBox = true;
                return _createAdvancedTextBox;
            }
        }
        private bool f_countNbItemsOfTypeInStorage;
        private int _countNbItemsOfTypeInStorage;

        /// <summary>
        /// Counts the number of instances of an item in storage not accounting for the number of items
        /// in a stack.
        /// 
        /// r0: item ID
        /// return: count
        /// </summary>
        public int CountNbItemsOfTypeInStorage
        {
            get
            {
                if (f_countNbItemsOfTypeInStorage)
                    return _countNbItemsOfTypeInStorage;
                _countNbItemsOfTypeInStorage = (int) (65360);
                f_countNbItemsOfTypeInStorage = true;
                return _countNbItemsOfTypeInStorage;
            }
        }
        private bool f_getBagCapacity;
        private int _getBagCapacity;

        /// <summary>
        /// Returns the player's bag capacity for a given point in the game.
        /// 
        /// r0: scenario_balance
        /// return: bag capacity
        /// </summary>
        public int GetBagCapacity
        {
            get
            {
                if (f_getBagCapacity)
                    return _getBagCapacity;
                _getBagCapacity = (int) (334604);
                f_getBagCapacity = true;
                return _getBagCapacity;
            }
        }
        private bool f_getMainTeamNameWithCheck;
        private int _getMainTeamNameWithCheck;

        /// <summary>
        /// Gets the name of the team for the main story with an additional check if the team name should be
        /// &quot;???&quot; because the story has not progressed enough.
        /// 
        /// r0: [output] buffer
        /// </summary>
        public int GetMainTeamNameWithCheck
        {
            get
            {
                if (f_getMainTeamNameWithCheck)
                    return _getMainTeamNameWithCheck;
                _getMainTeamNameWithCheck = (int) (331336);
                f_getMainTeamNameWithCheck = true;
                return _getMainTeamNameWithCheck;
            }
        }
        private bool f_countItemTypeInBag;
        private int _countItemTypeInBag;

        /// <summary>
        /// Implements SPECIAL_PROC_COUNT_ITEM_TYPE_IN_BAG (see ScriptSpecialProcessCall).
        /// 
        /// Irdkwia's notes: Count also stackable
        /// 
        /// r0: item ID
        /// return: number of items of the specified ID in the bag
        /// </summary>
        public int CountItemTypeInBag
        {
            get
            {
                if (f_countItemTypeInBag)
                    return _countItemTypeInBag;
                _countItemTypeInBag = (int) (61232);
                f_countItemTypeInBag = true;
                return _countItemTypeInBag;
            }
        }
        private bool f_initRender3dElement64;
        private int _initRender3dElement64;

        /// <summary>
        /// Initialize the render_3d_element_64 structure (without performing any drawing or external data access)
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int InitRender3dElement64
        {
            get
            {
                if (f_initRender3dElement64)
                    return _initRender3dElement64;
                _initRender3dElement64 = (int) (124876);
                f_initRender3dElement64 = true;
                return _initRender3dElement64;
            }
        }
        private bool f_createTextBox;
        private int _createTextBox;

        /// <summary>
        /// Calls CreateTextBoxInternal, sets the callback without an argument, and returns the window_id.
        /// 
        /// r0: window_params
        /// r1: text box callback function
        /// return: window_id
        /// </summary>
        public int CreateTextBox
        {
            get
            {
                if (f_createTextBox)
                    return _createTextBox;
                _createTextBox = (int) (195512);
                f_createTextBox = true;
                return _createTextBox;
            }
        }
        private bool f_getNbFainted;
        private int _getNbFainted;

        /// <summary>
        /// Gets the number of times you fainted.
        /// 
        /// return: the number of times you fainted
        /// </summary>
        public int GetNbFainted
        {
            get
            {
                if (f_getNbFainted)
                    return _getNbFainted;
                _getNbFainted = (int) (329252);
                f_getNbFainted = true;
                return _getNbFainted;
            }
        }
        private bool f_copyProgressInfoFromScratchFrom;
        private int _copyProgressInfoFromScratchFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: start_address
        /// r1: total_length
        /// </summary>
        public int CopyProgressInfoFromScratchFrom
        {
            get
            {
                if (f_copyProgressInfoFromScratchFrom)
                    return _copyProgressInfoFromScratchFrom;
                _copyProgressInfoFromScratchFrom = (int) (318080);
                f_copyProgressInfoFromScratchFrom = true;
                return _copyProgressInfoFromScratchFrom;
            }
        }
        private bool f_incrementNbBigTreasureWins;
        private int _incrementNbBigTreasureWins;

        /// <summary>
        /// Increments by 1 the number of big treasure wins.
        /// 
        /// Implements SPECIAL_PROC_INCREMENT_BIG_TREASURE_WINS (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbBigTreasureWins
        {
            get
            {
                if (f_incrementNbBigTreasureWins)
                    return _incrementNbBigTreasureWins;
                _incrementNbBigTreasureWins = (int) (328192);
                f_incrementNbBigTreasureWins = true;
                return _incrementNbBigTreasureWins;
            }
        }
        private bool f_svcSoftReset;
        private int _svcSoftReset;

        /// <summary>
        /// Software interrupt.
        /// </summary>
        public int SvcSoftReset
        {
            get
            {
                if (f_svcSoftReset)
                    return _svcSoftReset;
                _svcSoftReset = (int) (420);
                f_svcSoftReset = true;
                return _svcSoftReset;
            }
        }
        private bool f_generateMissionDetailsStruct;
        private int _generateMissionDetailsStruct;

        /// <summary>
        /// Generates a mission_details struct, to be used for printing mission details such as the title, summary, and objective.
        /// 
        /// r0: mission struct pointer
        /// r1: [output] mission_details struct pointer
        /// r2: ?
        /// r3: ?
        /// </summary>
        public int GenerateMissionDetailsStruct
        {
            get
            {
                if (f_generateMissionDetailsStruct)
                    return _generateMissionDetailsStruct;
                _generateMissionDetailsStruct = (int) (394444);
                f_generateMissionDetailsStruct = true;
                return _generateMissionDetailsStruct;
            }
        }
        private bool f_getMonsterPreEvolution;
        private int _getMonsterPreEvolution;

        /// <summary>
        /// Returns the pre-evolution id of a monster given its ID.
        /// 
        /// r0: monster id
        /// return: ID of the monster that evolves into the one specified in r0
        /// </summary>
        public int GetMonsterPreEvolution
        {
            get
            {
                if (f_getMonsterPreEvolution)
                    return _getMonsterPreEvolution;
                _getMonsterPreEvolution = (int) (339168);
                f_getMonsterPreEvolution = true;
                return _getMonsterPreEvolution;
            }
        }
        private bool f_getBgRegionArea;
        private int _getBgRegionArea;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: offset
        /// r1: subregion_id
        /// r2: region_id
        /// return: ?
        /// </summary>
        public int GetBgRegionArea
        {
            get
            {
                if (f_getBgRegionArea)
                    return _getBgRegionArea;
                _getBgRegionArea = (int) (336324);
                f_getBgRegionArea = true;
                return _getBgRegionArea;
            }
        }
        private bool f_removeActiveMembersFromSpecialEpisodeTeam;
        private int _removeActiveMembersFromSpecialEpisodeTeam;

        /// <summary>
        /// Removes the active monsters on the Special Episode Team from the team member table.
        /// 
        /// No params.
        /// </summary>
        public int RemoveActiveMembersFromSpecialEpisodeTeam
        {
            get
            {
                if (f_removeActiveMembersFromSpecialEpisodeTeam)
                    return _removeActiveMembersFromSpecialEpisodeTeam;
                _removeActiveMembersFromSpecialEpisodeTeam = (int) (353492);
                f_removeActiveMembersFromSpecialEpisodeTeam = true;
                return _removeActiveMembersFromSpecialEpisodeTeam;
            }
        }
        private bool f_stringFromId;
        private int _stringFromId;

        /// <summary>
        /// Gets the string corresponding to a given string ID.
        /// 
        /// r0: string ID
        /// return: string from the string files with the given string ID
        /// </summary>
        public int StringFromId
        {
            get
            {
                if (f_stringFromId)
                    return _stringFromId;
                _stringFromId = (int) (154512);
                f_stringFromId = true;
                return _stringFromId;
            }
        }
        private bool f_createOptionsMenu;
        private int _createOptionsMenu;

        /// <summary>
        /// Creates a window containing a menu controlling game options. Also see struct options_menu.
        /// 
        /// This is used for the options and window options menus, among other things.
        /// 
        /// If window_params is NULL, OPTIONS_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: options_menu_id_item struct array, terminated with an item with msg_id 0
        /// stack[0]: number of items
        /// stack[1]: option_states pointer
        /// return: window_id
        /// </summary>
        public int CreateOptionsMenu
        {
            get
            {
                if (f_createOptionsMenu)
                    return _createOptionsMenu;
                _createOptionsMenu = (int) (185572);
                f_createOptionsMenu = true;
                return _createOptionsMenu;
            }
        }
        private bool f_setMemAllocatorParams;
        private int _setMemAllocatorParams;

        /// <summary>
        /// Sets global parameters for the memory allocator.
        /// 
        /// This includes MEMORY_ALLOCATION_ARENA_GETTERS and some other stuff.
        /// 
        /// Dungeon mode uses the default arena getters. Ground mode uses its own arena getters that return custom arenas for some flag values, which are defined in overlay 11 and set (by calling this function) at the start of GroundMainLoop. Note that the sound memory arena is provided explicitly to MemLocateSet in the sound code, so doesn't go through this path.
        /// 
        /// r0: GetAllocArena function pointer (GetAllocArenaDefault is used if null)
        /// r1: GetFreeArena function pointer (GetFreeArenaDefault is used if null)
        /// </summary>
        public int SetMemAllocatorParams
        {
            get
            {
                if (f_setMemAllocatorParams)
                    return _setMemAllocatorParams;
                _setMemAllocatorParams = (int) (3696);
                f_setMemAllocatorParams = true;
                return _setMemAllocatorParams;
            }
        }
        private bool f_getBaseHp;
        private int _getBaseHp;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: base HP
        /// </summary>
        public int GetBaseHp
        {
            get
            {
                if (f_getBaseHp)
                    return _getBaseHp;
                _getBaseHp = (int) (339052);
                f_getBaseHp = true;
                return _getBaseHp;
            }
        }
        private bool f_fixedPoint64IsNegative;
        private int _fixedPoint64IsNegative;

        /// <summary>
        /// Checks whether a 64-bit fixed-point number (16 fraction bits) is negative.
        /// 
        /// r0: 64-bit fixed-point number
        /// return: bool
        /// </summary>
        public int FixedPoint64IsNegative
        {
            get
            {
                if (f_fixedPoint64IsNegative)
                    return _fixedPoint64IsNegative;
                _fixedPoint64IsNegative = (int) (7504);
                f_fixedPoint64IsNegative = true;
                return _fixedPoint64IsNegative;
            }
        }
        private bool f_getWindowContents;
        private int _getWindowContents;

        /// <summary>
        /// Gets the contents structure from the window with the given ID.
        /// 
        /// r0: window_id
        /// return: contents
        /// </summary>
        public int GetWindowContents
        {
            get
            {
                if (f_getWindowContents)
                    return _getWindowContents;
                _getWindowContents = (int) (165424);
                f_getWindowContents = true;
                return _getWindowContents;
            }
        }
        private bool f_isAlertBoxActive;
        private int _isAlertBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of an alert box is 3.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsAlertBoxActive
        {
            get
            {
                if (f_isAlertBoxActive)
                    return _isAlertBoxActive;
                _isAlertBoxActive = (int) (197864);
                f_isAlertBoxActive = true;
                return _isAlertBoxActive;
            }
        }
        private bool f_loadPortrait;
        private int _loadPortrait;

        /// <summary>
        /// Tries to load the portrait data associated with the passed portrait params.
        /// 
        /// Returns whether the operation was successful (the portrait could be found). If the passed buffer is null, the check if performed without loading any data.
        /// 
        /// This function also modifies the flip fields in the passed portrait params.
        /// 
        /// r0: portrait params pointer
        /// r1: kaomado_buffer pointer
        /// return: portrait exists
        /// </summary>
        public int LoadPortrait
        {
            get
            {
                if (f_loadPortrait)
                    return _loadPortrait;
                _loadPortrait = (int) (318452);
                f_loadPortrait = true;
                return _loadPortrait;
            }
        }
        private bool f_resetPlannedVramTransfer;
        private int _resetPlannedVramTransfer;

        /// <summary>
        /// Reset the command array of input container
        /// Does not reset its other field
        /// 
        /// r0: the container to reset
        /// </summary>
        public int ResetPlannedVramTransfer
        {
            get
            {
                if (f_resetPlannedVramTransfer)
                    return _resetPlannedVramTransfer;
                _resetPlannedVramTransfer = (int) (123504);
                f_resetPlannedVramTransfer = true;
                return _resetPlannedVramTransfer;
            }
        }
        private bool f_getExecuteSpecialEpisodeType;
        private int _getExecuteSpecialEpisodeType;

        /// <summary>
        /// Gets the special episode type from the EXECUTE_SPECIAL_EPISODE_TYPE script variable.
        /// 
        /// return: special episode type
        /// </summary>
        public int GetExecuteSpecialEpisodeType
        {
            get
            {
                if (f_getExecuteSpecialEpisodeType)
                    return _getExecuteSpecialEpisodeType;
                _getExecuteSpecialEpisodeType = (int) (314480);
                f_getExecuteSpecialEpisodeType = true;
                return _getExecuteSpecialEpisodeType;
            }
        }
        private bool f_getNbRecycled;
        private int _getNbRecycled;

        /// <summary>
        /// Gets the number of items recycled.
        /// 
        /// return: the number of items recycled
        /// </summary>
        public int GetNbRecycled
        {
            get
            {
                if (f_getNbRecycled)
                    return _getNbRecycled;
                _getNbRecycled = (int) (328356);
                f_getNbRecycled = true;
                return _getNbRecycled;
            }
        }
        private bool f_decodeFragmentByteAssemblyTable;
        private int _decodeFragmentByteAssemblyTable;

        /// <summary>
        /// Decode the sprite texture stored in each fragment byte assembly entry into the dst output, until the final one is reached.
        /// 
        /// r0: pointer to array of fragment byte assembly entry, final (otherwise unused) one should have byte_amount = 0
        /// r1: dst
        /// return: number of decoded bytes
        /// </summary>
        public int DecodeFragmentByteAssemblyTable
        {
            get
            {
                if (f_decodeFragmentByteAssemblyTable)
                    return _decodeFragmentByteAssemblyTable;
                _decodeFragmentByteAssemblyTable = (int) (109640);
                f_decodeFragmentByteAssemblyTable = true;
                return _decodeFragmentByteAssemblyTable;
            }
        }
        private bool f_getSpawnThreshold;
        private int _getSpawnThreshold;

        /// <summary>
        /// Returns the spawn threshold of the given monster ID
        /// 
        /// The spawn threshold determines the minimum SCENARIO_BALANCE_FLAG value required by a monster to spawn in dungeons.
        /// 
        /// r0: monster id
        /// return: Spawn threshold
        /// </summary>
        public int GetSpawnThreshold
        {
            get
            {
                if (f_getSpawnThreshold)
                    return _getSpawnThreshold;
                _getSpawnThreshold = (int) (339580);
                f_getSpawnThreshold = true;
                return _getSpawnThreshold;
            }
        }
        private bool f_canEvolve;
        private int _canEvolve;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: bool
        /// </summary>
        public int CanEvolve
        {
            get
            {
                if (f_canEvolve)
                    return _canEvolve;
                _canEvolve = (int) (339124);
                f_canEvolve = true;
                return _canEvolve;
            }
        }
        private bool f_getDisplayedSellPrice;
        private int _getDisplayedSellPrice;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item
        /// return: sell price
        /// </summary>
        public int GetDisplayedSellPrice
        {
            get
            {
                if (f_getDisplayedSellPrice)
                    return _getDisplayedSellPrice;
                _getDisplayedSellPrice = (int) (53664);
                f_getDisplayedSellPrice = true;
                return _getDisplayedSellPrice;
            }
        }
        private bool f_isLevelResetDungeon;
        private int _isLevelResetDungeon;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsLevelResetDungeon
        {
            get
            {
                if (f_isLevelResetDungeon)
                    return _isLevelResetDungeon;
                _isLevelResetDungeon = (int) (333392);
                f_isLevelResetDungeon = true;
                return _isLevelResetDungeon;
            }
        }
        private bool f_loadFileInPackWithPackId;
        private int _loadFileInPackWithPackId;

        /// <summary>
        /// Call LoadFileInPack after looking up the global Pack archive by its identifier
        /// 
        /// r0: pack file identifier
        /// r1: file index
        /// r2: [output] target buffer
        /// return: number of read bytes (identical to the length of the pack from the Table of Content)
        /// </summary>
        public int LoadFileInPackWithPackId
        {
            get
            {
                if (f_loadFileInPackWithPackId)
                    return _loadFileInPackWithPackId;
                _loadFileInPackWithPackId = (int) (50148);
                f_loadFileInPackWithPackId = true;
                return _loadFileInPackWithPackId;
            }
        }
        private bool f_baseFormsEqual;
        private int _baseFormsEqual;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id1
        /// r1: id2
        /// return: if the base forms are the same
        /// </summary>
        public int BaseFormsEqual
        {
            get
            {
                if (f_baseFormsEqual)
                    return _baseFormsEqual;
                _baseFormsEqual = (int) (348244);
                f_baseFormsEqual = true;
                return _baseFormsEqual;
            }
        }
        private bool f_isOptionsMenuActive;
        private int _isOptionsMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of an options menu is something other than 6 or 7.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsOptionsMenuActive
        {
            get
            {
                if (f_isOptionsMenuActive)
                    return _isOptionsMenuActive;
                _isOptionsMenuActive = (int) (186448);
                f_isOptionsMenuActive = true;
                return _isOptionsMenuActive;
            }
        }
        private bool f_clampComponentAbs;
        private int _clampComponentAbs;

        /// <summary>
        /// Clamps the absolute values in a two-component integer array.
        /// 
        /// Given an integer array [x, y] and a maximum absolute value M, clamps each element of the array to M such that the output array is [min(max(x, -M), M), min(max(y, -M), M)].
        /// 
        /// r0: 2-element integer array, will be mutated
        /// r1: max absolute value
        /// </summary>
        public int ClampComponentAbs
        {
            get
            {
                if (f_clampComponentAbs)
                    return _clampComponentAbs;
                _clampComponentAbs = (int) (20752);
                f_clampComponentAbs = true;
                return _clampComponentAbs;
            }
        }
        private bool f_ceilFixedPoint;
        private int _ceilFixedPoint;

        /// <summary>
        /// Compute the ceiling of a decimal fixed-point number (16 fraction bits).
        /// 
        /// Numbers are in the format {16-bit integer part, 16-bit thousandths}, where the integer part is the lower word. Probably used primarily for belly.
        /// 
        /// r0: number
        /// return: ceil(number)
        /// </summary>
        public int CeilFixedPoint
        {
            get
            {
                if (f_ceilFixedPoint)
                    return _ceilFixedPoint;
                _ceilFixedPoint = (int) (332700);
                f_ceilFixedPoint = true;
                return _ceilFixedPoint;
            }
        }
        private bool f_removeItemNoHoleCheck;
        private int _removeItemNoHoleCheck;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: index
        /// return: ?
        /// </summary>
        public int RemoveItemNoHoleCheck
        {
            get
            {
                if (f_removeItemNoHoleCheck)
                    return _removeItemNoHoleCheck;
                _removeItemNoHoleCheck = (int) (63424);
                f_removeItemNoHoleCheck = true;
                return _removeItemNoHoleCheck;
            }
        }
        private bool f_copyProgressInfoFrom;
        private int _copyProgressInfoFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// </summary>
        public int CopyProgressInfoFrom
        {
            get
            {
                if (f_copyProgressInfoFrom)
                    return _copyProgressInfoFrom;
                _copyProgressInfoFrom = (int) (317624);
                f_copyProgressInfoFrom = true;
                return _copyProgressInfoFrom;
            }
        }
        private bool f_removeActiveMembersFromRescueTeam;
        private int _removeActiveMembersFromRescueTeam;

        /// <summary>
        /// Removes the active monsters on the Rescue Team from the team member table.
        /// 
        /// No params.
        /// </summary>
        public int RemoveActiveMembersFromRescueTeam
        {
            get
            {
                if (f_removeActiveMembersFromRescueTeam)
                    return _removeActiveMembersFromRescueTeam;
                _removeActiveMembersFromRescueTeam = (int) (353596);
                f_removeActiveMembersFromRescueTeam = true;
                return _removeActiveMembersFromRescueTeam;
            }
        }
        private bool f_applyGummiBoostsToTeamMember;
        private int _applyGummiBoostsToTeamMember;

        /// <summary>
        /// Applies the IQ boosts from eating a Gummi to the target monster. Basically a wrapper around
        /// ApplyGummiBoostsGroundMode for struct team_member.
        /// 
        /// r0: team member pointer
        /// r1: Item ID
        /// r2: bool to NOT increase stats
        /// r3: [output] pointer to a struct gummi_result to fill out
        /// </summary>
        public int ApplyGummiBoostsToTeamMember
        {
            get
            {
                if (f_applyGummiBoostsToTeamMember)
                    return _applyGummiBoostsToTeamMember;
                _applyGummiBoostsToTeamMember = (int) (71164);
                f_applyGummiBoostsToTeamMember = true;
                return _applyGummiBoostsToTeamMember;
            }
        }
        private bool f_loadFileFromRom;
        private int _loadFileFromRom;

        /// <summary>
        /// Loads a file from ROM by filepath into a heap-allocated buffer.
        /// 
        /// r0: [output] pointer to an IO struct {ptr, len}
        /// r1: file path string pointer
        /// r2: flags
        /// </summary>
        public int LoadFileFromRom
        {
            get
            {
                if (f_loadFileFromRom)
                    return _loadFileFromRom;
                _loadFileFromRom = (int) (35900);
                f_loadFileFromRom = true;
                return _loadFileFromRom;
            }
        }
        private bool f_setActiveInventoryToMain;
        private int _setActiveInventoryToMain;

        /// <summary>
        /// Changes the currently active inventory to TEAM_MAIN.
        /// 
        /// No params.
        /// </summary>
        public int SetActiveInventoryToMain
        {
            get
            {
                if (f_setActiveInventoryToMain)
                    return _setActiveInventoryToMain;
                _setActiveInventoryToMain = (int) (60532);
                f_setActiveInventoryToMain = true;
                return _setActiveInventoryToMain;
            }
        }
        private bool f_getMoveType;
        private int _getMoveType;

        /// <summary>
        /// Gets the type of a move
        /// 
        /// r0: Pointer to move data
        /// return: Type of the move
        /// </summary>
        public int GetMoveType
        {
            get
            {
                if (f_getMoveType)
                    return _getMoveType;
                _getMoveType = (int) (80140);
                f_getMoveType = true;
                return _getMoveType;
            }
        }
        private bool f_initMove;
        private int _initMove;

        /// <summary>
        /// Initializes a move info struct.
        /// 
        /// This sets f_exists and f_enabled_for_ai on the flags, the ID to the given ID, the PP to the max PP for the move ID, and the ginseng boost to 0.
        /// 
        /// r0: pointer to move to initialize
        /// r1: move ID
        /// </summary>
        public int InitMove
        {
            get
            {
                if (f_initMove)
                    return _initMove;
                _initMove = (int) (79968);
                f_initMove = true;
                return _initMove;
            }
        }
        private bool f_getOptionsMenuResult;
        private int _getOptionsMenuResult;

        /// <summary>
        /// Returns whether or not the options menu was confirmed or canceled (e.g., by pressing the B button).
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int GetOptionsMenuResult
        {
            get
            {
                if (f_getOptionsMenuResult)
                    return _getOptionsMenuResult;
                _getOptionsMenuResult = (int) (186584);
                f_getOptionsMenuResult = true;
                return _getOptionsMenuResult;
            }
        }
        private bool f_getKeyboardStringResult;
        private int _getKeyboardStringResult;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: ?
        /// </summary>
        public int GetKeyboardStringResult
        {
            get
            {
                if (f_getKeyboardStringResult)
                    return _getKeyboardStringResult;
                _getKeyboardStringResult = (int) (227416);
                f_getKeyboardStringResult = true;
                return _getKeyboardStringResult;
            }
        }
        private bool f_isTeamSelectionMenuState3;
        private int _isTeamSelectionMenuState3;

        /// <summary>
        /// Checks if the state of a team selection menu is 3.
        /// 
        /// r0: window_id
        /// </summary>
        public int IsTeamSelectionMenuState3
        {
            get
            {
                if (f_isTeamSelectionMenuState3)
                    return _isTeamSelectionMenuState3;
                _isTeamSelectionMenuState3 = (int) (203684);
                f_isTeamSelectionMenuState3 = true;
                return _isTeamSelectionMenuState3;
            }
        }
        private bool f_stopBgmCommand;
        private int _stopBgmCommand;

        /// <summary>
        /// Stops the BGM that is being currently played by calling SendAudioCommand.
        /// 
        /// No params.
        /// </summary>
        public int StopBgmCommand
        {
            get
            {
                if (f_stopBgmCommand)
                    return _stopBgmCommand;
                _stopBgmCommand = (int) (98180);
                f_stopBgmCommand = true;
                return _stopBgmCommand;
            }
        }
        private bool f_sprintfSystemClock;
        private int _sprintfSystemClock;

        /// <summary>
        /// Calls sprintf to format a string using the fields of the DS system clock as &quot;year/month/day hour:minute:second&quot;. Used in DebugPrintSystemClock.
        /// 
        /// r0: system_clock pointer
        /// r1: str
        /// </summary>
        public int SprintfSystemClock
        {
            get
            {
                if (f_sprintfSystemClock)
                    return _sprintfSystemClock;
                _sprintfSystemClock = (int) (28600);
                f_sprintfSystemClock = true;
                return _sprintfSystemClock;
            }
        }
        private bool f_resetPlayTimer;
        private int _resetPlayTimer;

        /// <summary>
        /// Reset the file timer.
        /// 
        /// r0: play_time
        /// </summary>
        public int ResetPlayTimer
        {
            get
            {
                if (f_resetPlayTimer)
                    return _resetPlayTimer;
                _resetPlayTimer = (int) (332096);
                f_resetPlayTimer = true;
                return _resetPlayTimer;
            }
        }
        private bool f_closeAreaNameBox;
        private int _closeAreaNameBox;

        /// <summary>
        /// Closes a window created with CreateAreaNameBox.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseAreaNameBox
        {
            get
            {
                if (f_closeAreaNameBox)
                    return _closeAreaNameBox;
                _closeAreaNameBox = (int) (196676);
                f_closeAreaNameBox = true;
                return _closeAreaNameBox;
            }
        }
        private bool f_setDungeonTipShown;
        private int _setDungeonTipShown;

        /// <summary>
        /// Marks a dungeon tip as already shown to the player
        /// 
        /// r0: Dungeon tip ID
        /// </summary>
        public int SetDungeonTipShown
        {
            get
            {
                if (f_setDungeonTipShown)
                    return _setDungeonTipShown;
                _setDungeonTipShown = (int) (316808);
                f_setDungeonTipShown = true;
                return _setDungeonTipShown;
            }
        }
        private bool f_getMaxReachedFloor;
        private int _getMaxReachedFloor;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: max floor
        /// </summary>
        public int GetMaxReachedFloor
        {
            get
            {
                if (f_getMaxReachedFloor)
                    return _getMaxReachedFloor;
                _getMaxReachedFloor = (int) (316976);
                f_getMaxReachedFloor = true;
                return _getMaxReachedFloor;
            }
        }
        private bool f_createSimpleMenu;
        private int _createSimpleMenu;

        /// <summary>
        /// A wrapper around CreateSimpleMenuInternal where ownership of the simple_menu_items array parameter won't be transferred to the menu.
        /// 
        /// The menu item array will be copied onto a new array on the heap. This means the argument doesn't need to remain valid after the function returns (e.g., it can be stack-allocated).
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: simple_menu_items array
        /// stack[0]: number of items
        /// return: window_id
        /// </summary>
        public int CreateSimpleMenu
        {
            get
            {
                if (f_createSimpleMenu)
                    return _createSimpleMenu;
                _createSimpleMenu = (int) (177312);
                f_createSimpleMenu = true;
                return _createSimpleMenu;
            }
        }
        private bool f_initSoundSystem;
        private int _initSoundSystem;

        /// <summary>
        /// Initialize the DSE sound engine?
        /// 
        /// This function is called somewhere in the hierarchy under TaskProcBoot and appears to allocate a bunch of memory (including a dedicated memory arena, see SOUND_MEMORY_ARENA) for sound data, and reads a bunch of core sound files.
        /// 
        /// File paths referenced:
        /// - SOUND/SYSTEM/se_sys.swd
        /// - SOUND/SYSTEM/se_sys.sed
        /// - SOUND/SE/motion.swd
        /// - SOUND/SE/motion.sed
        /// - SOUND/BGM/bgm.swd (this is the main sample bank, see https://projectpokemon.org/home/docs/mystery-dungeon-nds/pok%C3%A9mon-mystery-dungeon-explorers-r78/)
        /// 
        /// Debug strings:
        /// - entry system se swd %04x\n
        /// - entry system se sed %04x\n
        /// - entry motion se swd %04x\n
        /// - entry motion se sed %04x\n
        /// </summary>
        public int InitSoundSystem
        {
            get
            {
                if (f_initSoundSystem)
                    return _initSoundSystem;
                _initSoundSystem = (int) (101572);
                f_initSoundSystem = true;
                return _initSoundSystem;
            }
        }
        private bool f_recruitSpecialPokemonLog;
        private int _recruitSpecialPokemonLog;

        /// <summary>
        /// Marks a specified special pokémon as recruited in the adventure log.
        /// 
        /// Irdkwia's notes: Useless in Sky
        /// 
        /// r0: monster ID
        /// </summary>
        public int RecruitSpecialPokemonLog
        {
            get
            {
                if (f_recruitSpecialPokemonLog)
                    return _recruitSpecialPokemonLog;
                _recruitSpecialPokemonLog = (int) (329084);
                f_recruitSpecialPokemonLog = true;
                return _recruitSpecialPokemonLog;
            }
        }
        private bool f_getExclusiveItemOffset;
        private int _getExclusiveItemOffset;

        /// <summary>
        /// Gets the exclusive item offset, which is the item ID relative to that of the first exclusive item, the Prism Ruff.
        /// 
        /// r0: item ID
        /// return: offset
        /// </summary>
        public int GetExclusiveItemOffset
        {
            get
            {
                if (f_getExclusiveItemOffset)
                    return _getExclusiveItemOffset;
                _getExclusiveItemOffset = (int) (69352);
                f_getExclusiveItemOffset = true;
                return _getExclusiveItemOffset;
            }
        }
        private bool f_isMonsterAffectedByGravelyrockGroundMode;
        private int _isMonsterAffectedByGravelyrockGroundMode;

        /// <summary>
        /// Checks if the monster is Bonsly or Sudowoodo.
        /// 
        /// r0: ground monster pointer
        /// return: bool
        /// </summary>
        public int IsMonsterAffectedByGravelyrockGroundMode
        {
            get
            {
                if (f_isMonsterAffectedByGravelyrockGroundMode)
                    return _isMonsterAffectedByGravelyrockGroundMode;
                _isMonsterAffectedByGravelyrockGroundMode = (int) (71896);
                f_isMonsterAffectedByGravelyrockGroundMode = true;
                return _isMonsterAffectedByGravelyrockGroundMode;
            }
        }
        private bool f_setMonsterFlag1;
        private int _setMonsterFlag1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// </summary>
        public int SetMonsterFlag1
        {
            get
            {
                if (f_setMonsterFlag1)
                    return _setMonsterFlag1;
                _setMonsterFlag1 = (int) (316548);
                f_setMonsterFlag1 = true;
                return _setMonsterFlag1;
            }
        }
        private bool f_rand16Bit;
        private int _rand16Bit;

        /// <summary>
        /// Computes a pseudorandom 16-bit integer using the general-purpose PRNG.
        /// 
        /// Note that much of dungeon mode uses its own (slightly higher-quality) PRNG within overlay 29. See overlay29.yml for more information.
        /// 
        /// Random numbers are generated with a linear congruential generator (LCG), using a modulus of 2^16, a multiplier of 109, and an increment of 1021. I.e., the recurrence relation is `x = (109*x_prev + 1021) % 2^16`.
        /// 
        /// The LCG has a hard-coded seed of 13452 (0x348C), but can be seeded with a call to SetRngSeed.
        /// 
        /// return: pseudorandom int on the interval [0, 65535]
        /// </summary>
        public int Rand16Bit
        {
            get
            {
                if (f_rand16Bit)
                    return _rand16Bit;
                _rand16Bit = (int) (8780);
                f_rand16Bit = true;
                return _rand16Bit;
            }
        }
        private bool f_loadWteFromRom;
        private int _loadWteFromRom;

        /// <summary>
        /// Loads a SIR0-wrapped WTE file from ROM, and returns a handle to it
        /// 
        /// r0: [output] pointer to wte handle
        /// r1: file path string
        /// r2: load file flags
        /// </summary>
        public int LoadWteFromRom
        {
            get
            {
                if (f_loadWteFromRom)
                    return _loadWteFromRom;
                _loadWteFromRom = (int) (122600);
                f_loadWteFromRom = true;
                return _loadWteFromRom;
            }
        }
        private bool f_femaleToMaleForm;
        private int _femaleToMaleForm;

        /// <summary>
        /// Returns the ID of the first form of the specified monster if the specified ID corresponds to a secondary form with female gender and the first form has male gender. If those conditions don't meet, returns the same ID unchanged.
        /// 
        /// r0: Monster ID
        /// return: ID of the male form of the monster if the requirements meet, same ID otherwise.
        /// </summary>
        public int FemaleToMaleForm
        {
            get
            {
                if (f_femaleToMaleForm)
                    return _femaleToMaleForm;
                _femaleToMaleForm = (int) (347996);
                f_femaleToMaleForm = true;
                return _femaleToMaleForm;
            }
        }
        private bool f_fatalError;
        private int _fatalError;

        /// <summary>
        /// Logs some debug messages, then hangs the process.
        /// 
        /// This function is called in lots of places to bail on a fatal error. Looking at the static data callers use to fill in the program position info is informative, as it tells you the original file name (probably from the standard __FILE__ macro) and line number (probably from the standard __LINE__ macro) in the source code.
        /// 
        /// r0: program position info
        /// r1: format
        /// ...: variadic
        /// </summary>
        public int FatalError
        {
            get
            {
                if (f_fatalError)
                    return _fatalError;
                _fatalError = (int) (49892);
                f_fatalError = true;
                return _fatalError;
            }
        }
        private bool f_convertStorageItemAtIdxToItem;
        private int _convertStorageItemAtIdxToItem;

        /// <summary>
        /// Get an item in storage and converts it into an equivalent item. The item does NOT have the exists
        /// flag set to true. This does not remove the item from storage.
        /// 
        /// r0: item index
        /// r1: [output] pointer to an item
        /// return: bool whether or not the item id is not 0
        /// </summary>
        public int ConvertStorageItemAtIdxToItem
        {
            get
            {
                if (f_convertStorageItemAtIdxToItem)
                    return _convertStorageItemAtIdxToItem;
                _convertStorageItemAtIdxToItem = (int) (65692);
                f_convertStorageItemAtIdxToItem = true;
                return _convertStorageItemAtIdxToItem;
            }
        }
        private bool f_fixedPoint64ToInt;
        private int _fixedPoint64ToInt;

        /// <summary>
        /// Converts a 64-bit fixed-point number (16 fraction bits) to a signed integer.
        /// 
        /// r0: 64-bit fixed-point number
        /// return: 32-bit signed
        /// </summary>
        public int FixedPoint64ToInt
        {
            get
            {
                if (f_fixedPoint64ToInt)
                    return _fixedPoint64ToInt;
                _fixedPoint64ToInt = (int) (7344);
                f_fixedPoint64ToInt = true;
                return _fixedPoint64ToInt;
            }
        }
        private bool f_soundDriverReset;
        private int _soundDriverReset;

        /// <summary>
        /// Uncertain.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int SoundDriverReset
        {
            get
            {
                if (f_soundDriverReset)
                    return _soundDriverReset;
                _soundDriverReset = (int) (102756);
                f_soundDriverReset = true;
                return _soundDriverReset;
            }
        }
        private bool f_getFileLengthInPackWithPackNb;
        private int _getFileLengthInPackWithPackNb;

        /// <summary>
        /// Call GetFileLengthInPack after looking up the global Pack archive by its number
        /// 
        /// r0: pack file number
        /// r1: file number
        /// return: size of the file in bytes from the Pack Table of Content
        /// </summary>
        public int GetFileLengthInPackWithPackNb
        {
            get
            {
                if (f_getFileLengthInPackWithPackNb)
                    return _getFileLengthInPackWithPackNb;
                _getFileLengthInPackWithPackNb = (int) (50116);
                f_getFileLengthInPackWithPackNb = true;
                return _getFileLengthInPackWithPackNb;
            }
        }
        private bool f_setScrollBoxState7;
        private int _setScrollBoxState7;

        /// <summary>
        /// Sets the state of a scroll box to 7.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetScrollBoxState7
        {
            get
            {
                if (f_setScrollBoxState7)
                    return _setScrollBoxState7;
                _setScrollBoxState7 = (int) (190884);
                f_setScrollBoxState7 = true;
                return _setScrollBoxState7;
            }
        }
        private bool f_isAreaNameBoxActive;
        private int _isAreaNameBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of an area name box is something other than 2 or 4.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsAreaNameBoxActive
        {
            get
            {
                if (f_isAreaNameBoxActive)
                    return _isAreaNameBoxActive;
                _isAreaNameBoxActive = (int) (196704);
                f_isAreaNameBoxActive = true;
                return _isAreaNameBoxActive;
            }
        }
        private bool f_isItemUsableNow;
        private int _isItemUsableNow;

        /// <summary>
        /// Checks if an item can be used right now. Returns true for all items that are not in a shop. If the item is in a
        /// shop, specifically checks for TMs/HMs and items that provide permanent buffs (Gummis, Sitrus Berry, Ginseng, etc).
        /// 
        /// r0: item pointer
        /// return: bool
        /// </summary>
        public int IsItemUsableNow
        {
            get
            {
                if (f_isItemUsableNow)
                    return _isItemUsableNow;
                _isItemUsableNow = (int) (52864);
                f_isItemUsableNow = true;
                return _isItemUsableNow;
            }
        }
        private bool f_getMoveRangeId;
        private int _getMoveRangeId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move
        /// return: range ID
        /// </summary>
        public int GetMoveRangeId
        {
            get
            {
                if (f_getMoveRangeId)
                    return _getMoveRangeId;
                _getMoveRangeId = (int) (80920);
                f_getMoveRangeId = true;
                return _getMoveRangeId;
            }
        }
        private bool f_removeActiveMembersFromMainTeam;
        private int _removeActiveMembersFromMainTeam;

        /// <summary>
        /// Removes the active monsters on the Main Team from the team member table.
        /// 
        /// No params.
        /// </summary>
        public int RemoveActiveMembersFromMainTeam
        {
            get
            {
                if (f_removeActiveMembersFromMainTeam)
                    return _removeActiveMembersFromMainTeam;
                _removeActiveMembersFromMainTeam = (int) (355548);
                f_removeActiveMembersFromMainTeam = true;
                return _removeActiveMembersFromMainTeam;
            }
        }
        private bool f_setUnkAdvancedTextBoxFn;
        private int _setUnkAdvancedTextBoxFn;

        /// <summary>
        /// Sets the value of advanced_text_box::field_0x1b4 to the given function pointer.
        /// 
        /// r0: window_id
        /// r1: some function pointer?
        /// </summary>
        public int SetUnkAdvancedTextBoxFn
        {
            get
            {
                if (f_setUnkAdvancedTextBoxFn)
                    return _setUnkAdvancedTextBoxFn;
                _setUnkAdvancedTextBoxFn = (int) (200116);
                f_setUnkAdvancedTextBoxFn = true;
                return _setUnkAdvancedTextBoxFn;
            }
        }
        private bool f_getItemBuyPrice;
        private int _getItemBuyPrice;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: buy price
        /// </summary>
        public int GetItemBuyPrice
        {
            get
            {
                if (f_getItemBuyPrice)
                    return _getItemBuyPrice;
                _getItemBuyPrice = (int) (60000);
                f_getItemBuyPrice = true;
                return _getItemBuyPrice;
            }
        }
        private bool f_getPartnerMemberIdx;
        private int _getPartnerMemberIdx;

        /// <summary>
        /// Returns the team member index of the partner (1) if the partner is valid, otherwise return -1.
        /// 
        /// return: team member index
        /// </summary>
        public int GetPartnerMemberIdx
        {
            get
            {
                if (f_getPartnerMemberIdx)
                    return _getPartnerMemberIdx;
                _getPartnerMemberIdx = (int) (350712);
                f_getPartnerMemberIdx = true;
                return _getPartnerMemberIdx;
            }
        }
        private bool f_closeCollectionMenu;
        private int _closeCollectionMenu;

        /// <summary>
        /// Closes a window created with CreateCollectionMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseCollectionMenu
        {
            get
            {
                if (f_closeCollectionMenu)
                    return _closeCollectionMenu;
                _closeCollectionMenu = (int) (182784);
                f_closeCollectionMenu = true;
                return _closeCollectionMenu;
            }
        }
        private bool f_removePokeItemsInBag;
        private int _removePokeItemsInBag;

        /// <summary>
        /// Checks the bag for any Poke and removes it after adding it to money carried.
        /// 
        /// No params.
        /// </summary>
        public int RemovePokeItemsInBag
        {
            get
            {
                if (f_removePokeItemsInBag)
                    return _removePokeItemsInBag;
                _removePokeItemsInBag = (int) (64852);
                f_removePokeItemsInBag = true;
                return _removePokeItemsInBag;
            }
        }
        private bool f_getBagNameString;
        private int _getBagNameString;

        /// <summary>
        /// Returns &quot;One-Item Inventory&quot; or &quot;Treasure Bag&quot; depending on the size of the bag.
        /// 
        /// r0: [output] Pointer to the buffer where the string will be written
        /// return: Pointer to the buffer where the string was written (in other words, the same value passed in r0)
        /// </summary>
        public int GetBagNameString
        {
            get
            {
                if (f_getBagNameString)
                    return _getBagNameString;
                _getBagNameString = (int) (151752);
                f_getBagNameString = true;
                return _getBagNameString;
            }
        }
        private bool f_memcpySimple;
        private int _memcpySimple;

        /// <summary>
        /// A simple implementation of the memcpy(3) C library function.
        /// 
        /// This function was probably manually implemented by the developers. See memcpy for what's probably the real libc function.
        /// 
        /// This function copies from src to dst in backwards byte order, so this is safe to call for overlapping src and dst if src &lt;= dst.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// </summary>
        public int MemcpySimple
        {
            get
            {
                if (f_memcpySimple)
                    return _memcpySimple;
                _memcpySimple = (int) (13012);
                f_memcpySimple = true;
                return _memcpySimple;
            }
        }
        private bool f_binToDecFixedPoint;
        private int _binToDecFixedPoint;

        /// <summary>
        /// Convert a binary fixed-point number (16 fraction bits) to the decimal fixed-point number (16 fraction bits) used for belly calculations. Thousandths are floored.
        /// 
        /// If &lt;data&gt; holds the raw binary data, a binary fixed-point number (16 fraction bits) has the value ((unsigned)data) * 2^-16), and the decimal fixed-point number (16 fraction bits) used for belly has the value (data &amp; 0xffff) + (data &gt;&gt; 16)/1000.
        /// 
        /// r0: pointer p, where ((const unsigned *)p)[1] is the fractional number in binary fixed-point format to convert
        /// return: fractional number in decimal fixed-point format
        /// </summary>
        public int BinToDecFixedPoint
        {
            get
            {
                if (f_binToDecFixedPoint)
                    return _binToDecFixedPoint;
                _binToDecFixedPoint = (int) (332632);
                f_binToDecFixedPoint = true;
                return _binToDecFixedPoint;
            }
        }
        private bool f_pointsToZero;
        private int _pointsToZero;

        /// <summary>
        /// Checks whether a pointer points to zero.
        /// 
        /// r0: ptr
        /// return: bool
        /// </summary>
        public int PointsToZero
        {
            get
            {
                if (f_pointsToZero)
                    return _pointsToZero;
                _pointsToZero = (int) (12856);
                f_pointsToZero = true;
                return _pointsToZero;
            }
        }
        private bool f_findFirstFreeMovesetIdx;
        private int _findFirstFreeMovesetIdx;

        /// <summary>
        /// Returns the first position of an empty move in the moveset if it is found, -1 otherwise
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// return: index
        /// </summary>
        public int FindFirstFreeMovesetIdx
        {
            get
            {
                if (f_findFirstFreeMovesetIdx)
                    return _findFirstFreeMovesetIdx;
                _findFirstFreeMovesetIdx = (int) (84232);
                f_findFirstFreeMovesetIdx = true;
                return _findFirstFreeMovesetIdx;
            }
        }
        private bool f_isHm;
        private int _isHm;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsHm
        {
            get
            {
                if (f_isHm)
                    return _isHm;
                _isHm = (int) (52216);
                f_isHm = true;
                return _isHm;
            }
        }
        private bool f_getSimpleMenuField0x1A4;
        private int _getSimpleMenuField0x1A4;

        /// <summary>
        /// Gets the value of simple_menu::field_0x1a4.
        /// 
        /// r0: window_id
        /// return: field_0x1a4
        /// </summary>
        public int GetSimpleMenuField0x1A4
        {
            get
            {
                if (f_getSimpleMenuField0x1A4)
                    return _getSimpleMenuField0x1A4;
                _getSimpleMenuField0x1A4 = (int) (178252);
                f_getSimpleMenuField0x1A4 = true;
                return _getSimpleMenuField0x1A4;
            }
        }
        private bool f_dungeonMoveToGroundMove;
        private int _dungeonMoveToGroundMove;

        /// <summary>
        /// Converts a struct move to a struct ground_move.
        /// 
        /// r0: [output] ground_move
        /// r1: move
        /// </summary>
        public int DungeonMoveToGroundMove
        {
            get
            {
                if (f_dungeonMoveToGroundMove)
                    return _dungeonMoveToGroundMove;
                _dungeonMoveToGroundMove = (int) (83796);
                f_dungeonMoveToGroundMove = true;
                return _dungeonMoveToGroundMove;
            }
        }
        private bool f_removeAllItemsStartingAt;
        private int _removeAllItemsStartingAt;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: index
        /// </summary>
        public int RemoveAllItemsStartingAt
        {
            get
            {
                if (f_removeAllItemsStartingAt)
                    return _removeAllItemsStartingAt;
                _removeAllItemsStartingAt = (int) (63620);
                f_removeAllItemsStartingAt = true;
                return _removeAllItemsStartingAt;
            }
        }
        private bool f_getAdventureLogCompleted;
        private int _getAdventureLogCompleted;

        /// <summary>
        /// Checks if one adventure log entry is completed.
        /// 
        /// r0: entry ID
        /// return: bool
        /// </summary>
        public int GetAdventureLogCompleted
        {
            get
            {
                if (f_getAdventureLogCompleted)
                    return _getAdventureLogCompleted;
                _getAdventureLogCompleted = (int) (327476);
                f_getAdventureLogCompleted = true;
                return _getAdventureLogCompleted;
            }
        }
        private bool f_initSpecialEpisodeExtraPartner;
        private int _initSpecialEpisodeExtraPartner;

        /// <summary>
        /// Initializes any partners/special episode members that join the team later in a special episode. This is used to add
        /// Celebi in the In the Future of Darkness special episode.
        /// Implements SPECIAL_PROC_0x4 (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int InitSpecialEpisodeExtraPartner
        {
            get
            {
                if (f_initSpecialEpisodeExtraPartner)
                    return _initSpecialEpisodeExtraPartner;
                _initSpecialEpisodeExtraPartner = (int) (298400);
                f_initSpecialEpisodeExtraPartner = true;
                return _initSpecialEpisodeExtraPartner;
            }
        }
        private bool f_setupAndShowKeyboard;
        private int _setupAndShowKeyboard;

        /// <summary>
        /// Calls a function that seems to set up info for the keyboard menu before ending with a call to ShowKeyboard.
        /// 
        /// r0: menu type
        /// r1: buffer1
        /// r2: buffer2
        /// return: ?
        /// </summary>
        public int SetupAndShowKeyboard
        {
            get
            {
                if (f_setupAndShowKeyboard)
                    return _setupAndShowKeyboard;
                _setupAndShowKeyboard = (int) (223912);
                f_setupAndShowKeyboard = true;
                return _setupAndShowKeyboard;
            }
        }
        private bool f_globalProgressAlloc;
        private int _globalProgressAlloc;

        /// <summary>
        /// Allocates a new global progress struct.
        /// 
        /// This updates the global pointer and returns a copy of that pointer.
        /// 
        /// return: pointer to a newly allocated global progress struct
        /// </summary>
        public int GlobalProgressAlloc
        {
            get
            {
                if (f_globalProgressAlloc)
                    return _globalProgressAlloc;
                _globalProgressAlloc = (int) (316480);
                f_globalProgressAlloc = true;
                return _globalProgressAlloc;
            }
        }
        private bool f_revertGiratinaAndShaymin;
        private int _revertGiratinaAndShaymin;

        /// <summary>
        /// Reverts Giratina and Shaymin party members to their standard forms.
        /// 
        /// r0: team member index in party
        /// r1: ?
        /// </summary>
        public int RevertGiratinaAndShaymin
        {
            get
            {
                if (f_revertGiratinaAndShaymin)
                    return _revertGiratinaAndShaymin;
                _revertGiratinaAndShaymin = (int) (362992);
                f_revertGiratinaAndShaymin = true;
                return _revertGiratinaAndShaymin;
            }
        }
        private bool f_getIqSkillStringId;
        private int _getIqSkillStringId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: iq skill id
        /// return: iq skill string id
        /// </summary>
        public int GetIqSkillStringId
        {
            get
            {
                if (f_getIqSkillStringId)
                    return _getIqSkillStringId;
                _getIqSkillStringId = (int) (364440);
                f_getIqSkillStringId = true;
                return _getIqSkillStringId;
            }
        }
        private bool f_isMonsterValid;
        private int _isMonsterValid;

        /// <summary>
        /// Checks if an monster ID is valid.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsMonsterValid
        {
            get
            {
                if (f_isMonsterValid)
                    return _isMonsterValid;
                _isMonsterValid = (int) (346856);
                f_isMonsterValid = true;
                return _isMonsterValid;
            }
        }
        private bool f_getFirstNotRealMoveInTimeDarkness;
        private int _getFirstNotRealMoveInTimeDarkness;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// return: index
        /// </summary>
        public int GetFirstNotRealMoveInTimeDarkness
        {
            get
            {
                if (f_getFirstNotRealMoveInTimeDarkness)
                    return _getFirstNotRealMoveInTimeDarkness;
                _getFirstNotRealMoveInTimeDarkness = (int) (86220);
                f_getFirstNotRealMoveInTimeDarkness = true;
                return _getFirstNotRealMoveInTimeDarkness;
            }
        }
        private bool f_atoiTagVeneer;
        private int _atoiTagVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for AtoiTag.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: s
        /// return: int
        /// </summary>
        public int AtoiTagVeneer
        {
            get
            {
                if (f_atoiTagVeneer)
                    return _atoiTagVeneer;
                _atoiTagVeneer = (int) (145408);
                f_atoiTagVeneer = true;
                return _atoiTagVeneer;
            }
        }
        private bool f_roundUpDiv256;
        private int _roundUpDiv256;

        /// <summary>
        /// Divide a number by 256 and round up to the nearest integer.
        /// 
        /// r0: number
        /// return: number // 256
        /// </summary>
        public int RoundUpDiv256
        {
            get
            {
                if (f_roundUpDiv256)
                    return _roundUpDiv256;
                _roundUpDiv256 = (int) (6292);
                f_roundUpDiv256 = true;
                return _roundUpDiv256;
            }
        }
        private bool f_isCastform;
        private int _isCastform;

        /// <summary>
        /// Checks if a monster ID is a Castform form.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsCastform
        {
            get
            {
                if (f_isCastform)
                    return _isCastform;
                _isCastform = (int) (347728);
                f_isCastform = true;
                return _isCastform;
            }
        }
        private bool f_getMissionByTypeAndDungeon;
        private int _getMissionByTypeAndDungeon;

        /// <summary>
        /// Returns the position on the mission list of the first mission of the specified type that takes place in the specified dungeon.
        /// 
        /// If the type of the mission has a subtype, the subtype of the checked mission must match the one in [r2] too for it to be returned.
        /// 
        /// r0: Position on the mission list where the search should start. Missions before this position on the list will be ignored.
        /// r1: Mission type
        /// r2: Pointer to some struct that contains the subtype of the mission to check on its first byte
        /// r3: Dungeon ID
        /// return: Index of the first mission that meets the specified requirements, or -1 if there aren't any missions that do so.
        /// </summary>
        public int GetMissionByTypeAndDungeon
        {
            get
            {
                if (f_getMissionByTypeAndDungeon)
                    return _getMissionByTypeAndDungeon;
                _getMissionByTypeAndDungeon = (int) (390952);
                f_getMissionByTypeAndDungeon = true;
                return _getMissionByTypeAndDungeon;
            }
        }
        private bool f_isTicketItem;
        private int _isTicketItem;

        /// <summary>
        /// Checks if an item is a ticket that can be used in the recycle shop (ITEM_PRIZE_TICKET, ITEM_SILVER_TICKET,
        /// ITEM_GOLD_TICKET, and ITEM_PRISM_TICKET).
        /// 
        /// r0: item_id
        /// return: bool
        /// </summary>
        public int IsTicketItem
        {
            get
            {
                if (f_isTicketItem)
                    return _isTicketItem;
                _isTicketItem = (int) (52988);
                f_isTicketItem = true;
                return _isTicketItem;
            }
        }
        private bool f_isItemInBag;
        private int _isItemInBag;

        /// <summary>
        /// Checks if an item is in the player's bag.
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsItemInBag
        {
            get
            {
                if (f_isItemInBag)
                    return _isItemInBag;
                _isItemInBag = (int) (61320);
                f_isItemInBag = true;
                return _isItemInBag;
            }
        }
        private bool f_getItemMoveId;
        private int _getItemMoveId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: move ID
        /// </summary>
        public int GetItemMoveId
        {
            get
            {
                if (f_getItemMoveId)
                    return _getItemMoveId;
                _getItemMoveId = (int) (60200);
                f_getItemMoveId = true;
                return _getItemMoveId;
            }
        }
        private bool f_setSpecialEpisodeType;
        private int _setSpecialEpisodeType;

        /// <summary>
        /// Sets the special episode type by changing the SPECIAL_EPISODE_TYPE script variable.
        /// 
        /// r0: special episode type
        /// </summary>
        public int SetSpecialEpisodeType
        {
            get
            {
                if (f_setSpecialEpisodeType)
                    return _setSpecialEpisodeType;
                _setSpecialEpisodeType = (int) (314424);
                f_setSpecialEpisodeType = true;
                return _setSpecialEpisodeType;
            }
        }
        private bool f_isMonsterMissionAllowedStory;
        private int _isMonsterMissionAllowedStory;

        /// <summary>
        /// Checks if the specified monster should be allowed to be part of a mission (probably as the client or the target), accounting for the progress on the story.
        /// 
        /// If PERFOMANCE_PROGRESS_FLAG[9] is true, the function returns true.
        /// If it isn't, the function checks if the specified monster is contained in the MISSION_BANNED_STORY_MONSTERS array, or if it corresponds to the ID of the player or the partner.
        /// 
        /// The function converts the ID by calling GetBaseForm and FemaleToMaleForm first.
        /// 
        /// r0: Monster ID
        /// return: True if PERFOMANCE_PROGRESS_FLAG[9] is true, false if it isn't and the monster ID (after converting it) is contained in MISSION_BANNED_STORY_MONSTERS or if it's the ID of the player or the partner, true otherwise.
        /// </summary>
        public int IsMonsterMissionAllowedStory
        {
            get
            {
                if (f_isMonsterMissionAllowedStory)
                    return _isMonsterMissionAllowedStory;
                _isMonsterMissionAllowedStory = (int) (405088);
                f_isMonsterMissionAllowedStory = true;
                return _isMonsterMissionAllowedStory;
            }
        }
        private bool f_getDexNumber;
        private int _getDexNumber;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: dex number
        /// </summary>
        public int GetDexNumber
        {
            get
            {
                if (f_getDexNumber)
                    return _getDexNumber;
                _getDexNumber = (int) (338552);
                f_getDexNumber = true;
                return _getDexNumber;
            }
        }
        private bool f_getItemSellPrice;
        private int _getItemSellPrice;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: sell price
        /// </summary>
        public int GetItemSellPrice
        {
            get
            {
                if (f_getItemSellPrice)
                    return _getItemSellPrice;
                _getItemSellPrice = (int) (60032);
                f_getItemSellPrice = true;
                return _getItemSellPrice;
            }
        }
        private bool f_removeFirstUnequippedItemOfType;
        private int _removeFirstUnequippedItemOfType;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: ?
        /// </summary>
        public int RemoveFirstUnequippedItemOfType
        {
            get
            {
                if (f_removeFirstUnequippedItemOfType)
                    return _removeFirstUnequippedItemOfType;
                _removeFirstUnequippedItemOfType = (int) (63552);
                f_removeFirstUnequippedItemOfType = true;
                return _removeFirstUnequippedItemOfType;
            }
        }
        private bool f_isTreasureBox;
        private int _isTreasureBox;

        /// <summary>
        /// Checks if the given item ID is a treasure box
        /// 
        /// In particular, it checks if the category of the item is CATEGORY_TREASURE_BOXES_1, CATEGORY_TREASURE_BOXES_2 or CATEGORY_TREASURE_BOXES_3.
        /// 
        /// r0: item ID
        /// return: True if the item is a treasure box, false otherwise
        /// </summary>
        public int IsTreasureBox
        {
            get
            {
                if (f_isTreasureBox)
                    return _isTreasureBox;
                _isTreasureBox = (int) (52492);
                f_isTreasureBox = true;
                return _isTreasureBox;
            }
        }
        private bool f_resetGlobalProgress;
        private int _resetGlobalProgress;

        /// <summary>
        /// Zero-initializes the global progress struct.
        /// 
        /// No params.
        /// </summary>
        public int ResetGlobalProgress
        {
            get
            {
                if (f_resetGlobalProgress)
                    return _resetGlobalProgress;
                _resetGlobalProgress = (int) (316520);
                f_resetGlobalProgress = true;
                return _resetGlobalProgress;
            }
        }
        private bool f_applyGummiBoostsGroundMode;
        private int _applyGummiBoostsGroundMode;

        /// <summary>
        /// Applies the IQ boosts from eating a Gummi to the monster's data. Generally called with not increasing stats true outside of the cafe.
        /// 
        /// r0: Pointer to monster id
        /// r1: Pointer to monster iq
        /// r2: Pointer to monster offensive stats
        /// r3: Pointer to monster defensive stats
        /// stack[0]: Item ID
        /// stack[1]: bool to NOT increase stats
        /// stack[2]: [output] pointer to a struct gummi_result
        /// </summary>
        public int ApplyGummiBoostsGroundMode
        {
            get
            {
                if (f_applyGummiBoostsGroundMode)
                    return _applyGummiBoostsGroundMode;
                _applyGummiBoostsGroundMode = (int) (72004);
                f_applyGummiBoostsGroundMode = true;
                return _applyGummiBoostsGroundMode;
            }
        }
        private bool f_isRealMoveInTimeDarkness;
        private int _isRealMoveInTimeDarkness;

        /// <summary>
        /// Seed Flare isn't a real move in Time/Darkness
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsRealMoveInTimeDarkness
        {
            get
            {
                if (f_isRealMoveInTimeDarkness)
                    return _isRealMoveInTimeDarkness;
                _isRealMoveInTimeDarkness = (int) (86028);
                f_isRealMoveInTimeDarkness = true;
                return _isRealMoveInTimeDarkness;
            }
        }
        private bool f_isMovesetValid;
        private int _isMovesetValid;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// return: bool
        /// </summary>
        public int IsMovesetValid
        {
            get
            {
                if (f_isMovesetValid)
                    return _isMovesetValid;
                _isMovesetValid = (int) (85920);
                f_isMovesetValid = true;
                return _isMovesetValid;
            }
        }
        private bool f_scenarioFlagBackup;
        private int _scenarioFlagBackup;

        /// <summary>
        /// Saves scenario flag script variables (SCENARIO_SELECT, SCENARIO_MAIN_BIT_FLAG) to their respective BACKUP script variables, but only in certain game modes.
        /// 
        /// This function prints the debug string &quot;ScenarioFlag BackupGameMode %d&quot; with the game mode.
        /// 
        /// No params.
        /// </summary>
        public int ScenarioFlagBackup
        {
            get
            {
                if (f_scenarioFlagBackup)
                    return _scenarioFlagBackup;
                _scenarioFlagBackup = (int) (315376);
                f_scenarioFlagBackup = true;
                return _scenarioFlagBackup;
            }
        }
        private bool f_fileOpen;
        private int _fileOpen;

        /// <summary>
        /// Opens a file from the ROM file system at the given path, sort of like C's fopen(3) library function.
        /// 
        /// r0: file_stream pointer
        /// r1: file path string
        /// </summary>
        public int FileOpen
        {
            get
            {
                if (f_fileOpen)
                    return _fileOpen;
                _fileOpen = (int) (33296);
                f_fileOpen = true;
                return _fileOpen;
            }
        }
        private bool f_unloadOverlay;
        private int _unloadOverlay;

        /// <summary>
        /// Unloads an overlay from ROM by its group ID.
        /// 
        /// See the LOADED_OVERLAY_GROUP_* data symbols or enum overlay_group_id in the C headers for a mapping between group ID and overlay number.
        /// 
        /// r0: group ID of the overlay to unload
        /// others: ?
        /// </summary>
        public int UnloadOverlay
        {
            get
            {
                if (f_unloadOverlay)
                    return _unloadOverlay;
                _unloadOverlay = (int) (18536);
                f_unloadOverlay = true;
                return _unloadOverlay;
            }
        }
        private bool f_getPartyMembers;
        private int _getPartyMembers;

        /// <summary>
        /// Appears to get the team's active party members. Implements most of SPECIAL_PROC_IS_TEAM_SETUP_SOLO (see ScriptSpecialProcessCall).
        /// 
        /// r0: [output] Array of 4 2-byte values (they seem to be indexes of some sort) describing each party member, which will be filled in by the function. The input can be a null pointer if the party members aren't needed
        /// return: Number of party members
        /// </summary>
        public int GetPartyMembers
        {
            get
            {
                if (f_getPartyMembers)
                    return _getPartyMembers;
                _getPartyMembers = (int) (356252);
                f_getPartyMembers = true;
                return _getPartyMembers;
            }
        }
        private bool f_createAdvancedTextBoxInternal;
        private int _createAdvancedTextBoxInternal;

        /// <summary>
        /// Creates a window containing text formatted in complex, potentially sectioned layouts. Also see struct advanced_text_box.
        /// 
        /// This is usually used to display text with &quot;pretty&quot; formatting in certain contexts, such as the message log, the move selection menu, team member summaries, etc.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: total number of selectable items
        /// stack[0]: number of selectable items per page
        /// return: advanced_text_box pointer
        /// </summary>
        public int CreateAdvancedTextBoxInternal
        {
            get
            {
                if (f_createAdvancedTextBoxInternal)
                    return _createAdvancedTextBoxInternal;
                _createAdvancedTextBoxInternal = (int) (198928);
                f_createAdvancedTextBoxInternal = true;
                return _createAdvancedTextBoxInternal;
            }
        }
        private bool f_findWanTableEntry;
        private int _findWanTableEntry;

        /// <summary>
        /// Search in the given table (in practice always seems to be WAN_TABLE) for an entry with the given file name.
        /// 
        /// r0: table pointer
        /// r1: file name
        /// return: index of the found file, if found, or -1 if not found
        /// </summary>
        public int FindWanTableEntry
        {
            get
            {
                if (f_findWanTableEntry)
                    return _findWanTableEntry;
                _findWanTableEntry = (int) (119664);
                f_findWanTableEntry = true;
                return _findWanTableEntry;
            }
        }
        private bool f_applyZincBoostToGroundMonster;
        private int _applyZincBoostToGroundMonster;

        /// <summary>
        /// Applies the special defense boost from Zinc to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted special defense boost, if not NULL
        /// return: actual special defense boost
        /// </summary>
        public int ApplyZincBoostToGroundMonster
        {
            get
            {
                if (f_applyZincBoostToGroundMonster)
                    return _applyZincBoostToGroundMonster;
                _applyZincBoostToGroundMonster = (int) (71784);
                f_applyZincBoostToGroundMonster = true;
                return _applyZincBoostToGroundMonster;
            }
        }
        private bool f_initBulkItem;
        private int _initBulkItem;

        /// <summary>
        /// Initialize a struct bulk_item with the given information.
        /// 
        /// This will resolve the quantity based on the item type. For Poké, the quantity code will always be set to 1. For thrown items, the quantity code will be randomly generated on the range of valid quantities for that item type. For non-stackable items, the quantity code will always be set to 0.
        /// 
        /// r0: pointer to bulk item to initialize
        /// r1: item ID
        /// </summary>
        public int InitBulkItem
        {
            get
            {
                if (f_initBulkItem)
                    return _initBulkItem;
                _initBulkItem = (int) (53248);
                f_initBulkItem = true;
                return _initBulkItem;
            }
        }
        private bool f_delayWteFree;
        private int _delayWteFree;

        /// <summary>
        /// Add a command to free the input WTE handle once all previously registered commands that would edit the texture VRAM have been executed.
        /// Also nullify the structure’s two pointers.
        /// The error caused by the lack of place to store the command is ignored.
        /// 
        /// r0: wte handle to eventually free
        /// </summary>
        public int DelayWteFree
        {
            get
            {
                if (f_delayWteFree)
                    return _delayWteFree;
                _delayWteFree = (int) (123352);
                f_delayWteFree = true;
                return _delayWteFree;
            }
        }
        private bool f_allowPortraitDefault;
        private int _allowPortraitDefault;

        /// <summary>
        /// Allows the portrait to try and load the default emote (PORTRAIT_NORMAL) if it can't find the specified emote.
        /// 
        /// r0: portrait params pointer
        /// r1: allow default
        /// </summary>
        public int AllowPortraitDefault
        {
            get
            {
                if (f_allowPortraitDefault)
                    return _allowPortraitDefault;
                _allowPortraitDefault = (int) (318412);
                f_allowPortraitDefault = true;
                return _allowPortraitDefault;
            }
        }
        private bool f_setPortraitLayout;
        private int _setPortraitLayout;

        /// <summary>
        /// Sets the layout in the passed portrait from the array of possible layouts.
        /// 
        /// If the layout is 32 or if the monster ID is MONSTER_NONE, then it does nothing.
        /// 
        /// r0: portrait params pointer
        /// r1: layout index
        /// </summary>
        public int SetPortraitLayout
        {
            get
            {
                if (f_setPortraitLayout)
                    return _setPortraitLayout;
                _setPortraitLayout = (int) (318268);
                f_setPortraitLayout = true;
                return _setPortraitLayout;
            }
        }
        private bool f_getAdvancedMenuCurrentOption;
        private int _getAdvancedMenuCurrentOption;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: window_id
        /// return: ?
        /// </summary>
        public int GetAdvancedMenuCurrentOption
        {
            get
            {
                if (f_getAdvancedMenuCurrentOption)
                    return _getAdvancedMenuCurrentOption;
                _getAdvancedMenuCurrentOption = (int) (180208);
                f_getAdvancedMenuCurrentOption = true;
                return _getAdvancedMenuCurrentOption;
            }
        }
        private bool f_loadTblTalk;
        private int _loadTblTalk;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int LoadTblTalk
        {
            get
            {
                if (f_loadTblTalk)
                    return _loadTblTalk;
                _loadTblTalk = (int) (154632);
                f_loadTblTalk = true;
                return _loadTblTalk;
            }
        }
        private bool f_showStringIdInDialogueBox;
        private int _showStringIdInDialogueBox;

        /// <summary>
        /// Preprocesses the corresponding string_id message in the text file and puts it into the dialogue box.
        /// 
        /// r0: window_id
        /// r1: preprocessor flags (see PreprocessString)
        /// r2: string_id
        /// r3: pointer to preprocessor args (see PreprocessString)
        /// </summary>
        public int ShowStringIdInDialogueBox
        {
            get
            {
                if (f_showStringIdInDialogueBox)
                    return _showStringIdInDialogueBox;
                _showStringIdInDialogueBox = (int) (193704);
                f_showStringIdInDialogueBox = true;
                return _showStringIdInDialogueBox;
            }
        }
        private bool f_playWindowInputSound;
        private int _playWindowInputSound;

        /// <summary>
        /// Plays a &quot;beep&quot; sound when giving an input to an interactive window (typically, when choosing a menu option).
        /// 
        /// r0: window_input_ctx pointer
        /// r1: Some kind of index used to determine the ID of the sound to play
        /// </summary>
        public int PlayWindowInputSound
        {
            get
            {
                if (f_playWindowInputSound)
                    return _playWindowInputSound;
                _playWindowInputSound = (int) (207956);
                f_playWindowInputSound = true;
                return _playWindowInputSound;
            }
        }
        private bool f_getMoveMaxGinsengBoost;
        private int _getMoveMaxGinsengBoost;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move
        /// return: max ginseng boost
        /// </summary>
        public int GetMoveMaxGinsengBoost
        {
            get
            {
                if (f_getMoveMaxGinsengBoost)
                    return _getMoveMaxGinsengBoost;
                _getMoveMaxGinsengBoost = (int) (80760);
                f_getMoveMaxGinsengBoost = true;
                return _getMoveMaxGinsengBoost;
            }
        }
        private bool f_addItemToStorage;
        private int _addItemToStorage;

        /// <summary>
        /// Attempts to add the item to storage.
        /// 
        /// r0: pointer to an item
        /// return: bool whether an item was added
        /// </summary>
        public int AddItemToStorage
        {
            get
            {
                if (f_addItemToStorage)
                    return _addItemToStorage;
                _addItemToStorage = (int) (66644);
                f_addItemToStorage = true;
                return _addItemToStorage;
            }
        }
        private bool f_getLanguage;
        private int _getLanguage;

        /// <summary>
        /// Gets the single-byte language ID of the current program.
        /// 
        /// The language ID appears to be used to index some global tables.
        /// 
        /// return: language ID
        /// </summary>
        public int GetLanguage
        {
            get
            {
                if (f_getLanguage)
                    return _getLanguage;
                _getLanguage = (int) (132784);
                f_getLanguage = true;
                return _getLanguage;
            }
        }
        private bool f_checkStringSave;
        private int _checkStringSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// return: bool
        /// </summary>
        public int CheckStringSave
        {
            get
            {
                if (f_checkStringSave)
                    return _checkStringSave;
                _checkStringSave = (int) (298732);
                f_checkStringSave = true;
                return _checkStringSave;
            }
        }
        private bool f_transmuteHeldItemInBag;
        private int _transmuteHeldItemInBag;

        /// <summary>
        /// Looks for an item in the bag that has the same holder (held_by) as the transmute item and convert
        /// their equivalent item in the treasure bag into the transmute item. The monster's held item on
        /// their struct should be updated accordingly directly before or after calling this function.
        /// 
        /// r0: transmute_item
        /// return: bool whether or not the item could be transmuted
        /// </summary>
        public int TransmuteHeldItemInBag
        {
            get
            {
                if (f_transmuteHeldItemInBag)
                    return _transmuteHeldItemInBag;
                _transmuteHeldItemInBag = (int) (64272);
                f_transmuteHeldItemInBag = true;
                return _transmuteHeldItemInBag;
            }
        }
        private bool f_strncpySimpleNoPad;
        private int _strncpySimpleNoPad;

        /// <summary>
        /// Similar to StrncpySimple, but does not zero-pad the end of dest beyond the null-terminator.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// </summary>
        public int StrncpySimpleNoPad
        {
            get
            {
                if (f_strncpySimpleNoPad)
                    return _strncpySimpleNoPad;
                _strncpySimpleNoPad = (int) (152636);
                f_strncpySimpleNoPad = true;
                return _strncpySimpleNoPad;
            }
        }
        private bool f_isAdvancedMenuActive;
        private int _isAdvancedMenuActive;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// Checks if advanced_menu::field_0x1a0 is 0.
        /// 
        /// This seems to resemble the Check*Field* functions of some of the other menu types. It's unclear whether these are the real &quot;IsActive&quot; functions, or whether the ones that check the state value are. It may be noteworthy that all menu types seem to have a variant of the &quot;state checking&quot; function, but only some menu types seem to have a variant of the &quot;check field&quot; function.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsAdvancedMenuActive
        {
            get
            {
                if (f_isAdvancedMenuActive)
                    return _isAdvancedMenuActive;
                _isAdvancedMenuActive = (int) (180176);
                f_isAdvancedMenuActive = true;
                return _isAdvancedMenuActive;
            }
        }
        private bool f_getCanMoveFlag;
        private int _getCanMoveFlag;

        /// <summary>
        /// Returns the flag that determines if a monster can move in dungeons.
        /// 
        /// r0: Monster ID
        /// return: &quot;Can move&quot; flag
        /// </summary>
        public int GetCanMoveFlag
        {
            get
            {
                if (f_getCanMoveFlag)
                    return _getCanMoveFlag;
                _getCanMoveFlag = (int) (338924);
                f_getCanMoveFlag = true;
                return _getCanMoveFlag;
            }
        }
        private bool f_isValidTeamMember;
        private int _isValidTeamMember;

        /// <summary>
        /// Returns whether or not the team member at the given index is valid for the current game mode.
        /// 
        /// During normal play, this will only be false for the special-episode-reserved indexes (2, 3, 4). During special episodes, this will be false for the hero and partner (0, 1).
        /// 
        /// r0: team member index
        /// return: bool
        /// </summary>
        public int IsValidTeamMember
        {
            get
            {
                if (f_isValidTeamMember)
                    return _isValidTeamMember;
                _isValidTeamMember = (int) (349964);
                f_isValidTeamMember = true;
                return _isValidTeamMember;
            }
        }
        private bool f_dungeonSwapIdToIdx;
        private int _dungeonSwapIdToIdx;

        /// <summary>
        /// Converts a dungeon ID to its corresponding index in DUNGEON_SWAP_ID_TABLE, or -1 if not found.
        /// 
        /// r0: dungeon ID
        /// return: index
        /// </summary>
        public int DungeonSwapIdToIdx
        {
            get
            {
                if (f_dungeonSwapIdToIdx)
                    return _dungeonSwapIdToIdx;
                _dungeonSwapIdToIdx = (int) (436908);
                f_dungeonSwapIdToIdx = true;
                return _dungeonSwapIdToIdx;
            }
        }
        private bool f_printMark;
        private int _printMark;

        /// <summary>
        /// Prints a mark from one of the .w16 files in FONT.
        /// 
        /// r0: 0 if file is clrmark1.w16, 1 if file is clrmark2.w16, 2 if file is rankmark.w16.
        /// r1: Mark ID in file
        /// r2: X pos (unknown units)
        /// r3: Y pos (unknown units)
        /// stack[0]: ?
        /// </summary>
        public int PrintMark
        {
            get
            {
                if (f_printMark)
                    return _printMark;
                _printMark = (int) (173904);
                f_printMark = true;
                return _printMark;
            }
        }
        private bool f_planCopyTextureToTextureVram;
        private int _planCopyTextureToTextureVram;

        /// <summary>
        /// Add a command in the container (r1) that will be executed later by PerformPlannedTextureVramTransfer to copy part of the RAM into the texture VRAM (or free the source allocated memory depending of the specified type of command).
        /// Check for overflow. If an overflow would occur, do not add the command to the container, and return -1 instead.
        /// 
        /// r0: Container that contain the command list to add to
        /// r1: pointer to the bytes to be copied in CPU-accessible RAM
        /// r2: offset to copy too in texture VRAM
        /// r3: number of bytes to copy
        /// stack[0]: type of command to perform
        /// </summary>
        public int PlanCopyTextureToTextureVram
        {
            get
            {
                if (f_planCopyTextureToTextureVram)
                    return _planCopyTextureToTextureVram;
                _planCopyTextureToTextureVram = (int) (123516);
                f_planCopyTextureToTextureVram = true;
                return _planCopyTextureToTextureVram;
            }
        }
        private bool f_setCollectionMenuField0x1B2;
        private int _setCollectionMenuField0x1B2;

        /// <summary>
        /// Sets collection_menu::field_0x1b2 to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetCollectionMenuField0x1B2
        {
            get
            {
                if (f_setCollectionMenuField0x1B2)
                    return _setCollectionMenuField0x1B2;
                _setCollectionMenuField0x1B2 = (int) (185292);
                f_setCollectionMenuField0x1B2 = true;
                return _setCollectionMenuField0x1B2;
            }
        }
        private bool f_writeItemsToSave;
        private int _writeItemsToSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: start_address
        /// r1: total_length
        /// return: ?
        /// </summary>
        public int WriteItemsToSave
        {
            get
            {
                if (f_writeItemsToSave)
                    return _writeItemsToSave;
                _writeItemsToSave = (int) (55780);
                f_writeItemsToSave = true;
                return _writeItemsToSave;
            }
        }
        private bool f_fixedPoint64CmpLt;
        private int _fixedPoint64CmpLt;

        /// <summary>
        /// Compares two signed 64-bit fixed-point numbers (16 fraction bits) x and y.
        /// 
        /// r0: x
        /// r1: y
        /// return: x &lt; y
        /// </summary>
        public int FixedPoint64CmpLt
        {
            get
            {
                if (f_fixedPoint64CmpLt)
                    return _fixedPoint64CmpLt;
                _fixedPoint64CmpLt = (int) (7528);
                f_fixedPoint64CmpLt = true;
                return _fixedPoint64CmpLt;
            }
        }
        private bool f_getMaxRescueAttempts;
        private int _getMaxRescueAttempts;

        /// <summary>
        /// Returns the maximum rescue attempts allowed in the specified dungeon.
        /// 
        /// r0: dungeon id
        /// return: Max rescue attempts, or -1 if rescues are disabled.
        /// </summary>
        public int GetMaxRescueAttempts
        {
            get
            {
                if (f_getMaxRescueAttempts)
                    return _getMaxRescueAttempts;
                _getMaxRescueAttempts = (int) (333496);
                f_getMaxRescueAttempts = true;
                return _getMaxRescueAttempts;
            }
        }
        private bool f_setPortraitEmotion;
        private int _setPortraitEmotion;

        /// <summary>
        /// Sets the emote in the passed portrait params, only if the monster ID isn't MONSTER_NONE.
        /// 
        /// r0: portrait params pointer
        /// r1: emotion ID
        /// </summary>
        public int SetPortraitEmotion
        {
            get
            {
                if (f_setPortraitEmotion)
                    return _setPortraitEmotion;
                _setPortraitEmotion = (int) (318252);
                f_setPortraitEmotion = true;
                return _setPortraitEmotion;
            }
        }
        private bool f_isReflectedByMagicCoat;
        private int _isReflectedByMagicCoat;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsReflectedByMagicCoat
        {
            get
            {
                if (f_isReflectedByMagicCoat)
                    return _isReflectedByMagicCoat;
                _isReflectedByMagicCoat = (int) (81328);
                f_isReflectedByMagicCoat = true;
                return _isReflectedByMagicCoat;
            }
        }
        private bool f_closeDialogueBox;
        private int _closeDialogueBox;

        /// <summary>
        /// Closes a window created with CreateDialogueBox.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseDialogueBox
        {
            get
            {
                if (f_closeDialogueBox)
                    return _closeDialogueBox;
                _closeDialogueBox = (int) (193596);
                f_closeDialogueBox = true;
                return _closeDialogueBox;
            }
        }
        private bool f_setMaxReachedFloor;
        private int _setMaxReachedFloor;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// r1: max floor
        /// </summary>
        public int SetMaxReachedFloor
        {
            get
            {
                if (f_setMaxReachedFloor)
                    return _setMaxReachedFloor;
                _setMaxReachedFloor = (int) (316948);
                f_setMaxReachedFloor = true;
                return _setMaxReachedFloor;
            }
        }
        private bool f_isItemValidVeneer;
        private int _isItemValidVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for IsItemValid.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsItemValidVeneer
        {
            get
            {
                if (f_isItemValidVeneer)
                    return _isItemValidVeneer;
                _isItemValidVeneer = (int) (60416);
                f_isItemValidVeneer = true;
                return _isItemValidVeneer;
            }
        }
        private bool f_clearAdventureLogStruct;
        private int _clearAdventureLogStruct;

        /// <summary>
        /// Clears the adventure log structure.
        /// 
        /// No params.
        /// </summary>
        public int ClearAdventureLogStruct
        {
            get
            {
                if (f_clearAdventureLogStruct)
                    return _clearAdventureLogStruct;
                _clearAdventureLogStruct = (int) (327080);
                f_clearAdventureLogStruct = true;
                return _clearAdventureLogStruct;
            }
        }
        private bool f_getAdventureLogDungeonFloor;
        private int _getAdventureLogDungeonFloor;

        /// <summary>
        /// Gets the current dungeon floor pair.
        /// 
        /// return: struct dungeon_floor_pair
        /// </summary>
        public int GetAdventureLogDungeonFloor
        {
            get
            {
                if (f_getAdventureLogDungeonFloor)
                    return _getAdventureLogDungeonFloor;
                _getAdventureLogDungeonFloor = (int) (327060);
                f_getAdventureLogDungeonFloor = true;
                return _getAdventureLogDungeonFloor;
            }
        }
        private bool f_copyMovesetFrom;
        private int _copyMovesetFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// r1: buffer_read
        /// </summary>
        public int CopyMovesetFrom
        {
            get
            {
                if (f_copyMovesetFrom)
                    return _copyMovesetFrom;
                _copyMovesetFrom = (int) (84884);
                f_copyMovesetFrom = true;
                return _copyMovesetFrom;
            }
        }
        private bool f_deleteWindow;
        private int _deleteWindow;

        /// <summary>
        /// Seems to uninitialize an active window in WINDOW_LIST with a given ID, freeing the slot for reuse by another window.
        /// 
        /// r0: window_id
        /// </summary>
        public int DeleteWindow
        {
            get
            {
                if (f_deleteWindow)
                    return _deleteWindow;
                _deleteWindow = (int) (165000);
                f_deleteWindow = true;
                return _deleteWindow;
            }
        }
        private bool f_deleteWanTableEntry;
        private int _deleteWanTableEntry;

        /// <summary>
        /// Always delete an entry if the file is allocated externally (file_externally_allocated is set), otherwise, decrease the reference counter. If it reach 0, delete the sprite.
        /// 
        /// r0: wan_table_ptr
        /// r1: wan_id
        /// </summary>
        public int DeleteWanTableEntry
        {
            get
            {
                if (f_deleteWanTableEntry)
                    return _deleteWanTableEntry;
                _deleteWanTableEntry = (int) (119416);
                f_deleteWanTableEntry = true;
                return _deleteWanTableEntry;
            }
        }
        private bool f_decompressAtHalf;
        private int _decompressAtHalf;

        /// <summary>
        /// Same as DecompressAtNormal, except it stores each nibble as a byte
        /// and adds the high nibble (r3).
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: addr_decomp
        /// r1: expected_size
        /// r2: AT pointer
        /// r3: high_nibble
        /// return: ?
        /// </summary>
        public int DecompressAtHalf
        {
            get
            {
                if (f_decompressAtHalf)
                    return _decompressAtHalf;
                _decompressAtHalf = (int) (129708);
                f_decompressAtHalf = true;
                return _decompressAtHalf;
            }
        }
        private bool f_getWindowRectangle;
        private int _getWindowRectangle;

        /// <summary>
        /// Get the rectangle defined by a window.
        /// 
        /// r0: window_id
        /// r1: [output] rectangle
        /// </summary>
        public int GetWindowRectangle
        {
            get
            {
                if (f_getWindowRectangle)
                    return _getWindowRectangle;
                _getWindowRectangle = (int) (165240);
                f_getWindowRectangle = true;
                return _getWindowRectangle;
            }
        }
        private bool f_getMoveMessageFromId;
        private int _getMoveMessageFromId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID?
        /// return: string
        /// </summary>
        public int GetMoveMessageFromId
        {
            get
            {
                if (f_getMoveMessageFromId)
                    return _getMoveMessageFromId;
                _getMoveMessageFromId = (int) (81112);
                f_getMoveMessageFromId = true;
                return _getMoveMessageFromId;
            }
        }
        private bool f_loadScriptVariableValueAtIndex;
        private int _loadScriptVariableValueAtIndex;

        /// <summary>
        /// Loads the value of a script variable at some index (for script variables that are arrays).
        /// 
        /// r0: pointer to the local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID
        /// r2: value index for the given script var
        /// return: value
        /// </summary>
        public int LoadScriptVariableValueAtIndex
        {
            get
            {
                if (f_loadScriptVariableValueAtIndex)
                    return _loadScriptVariableValueAtIndex;
                _loadScriptVariableValueAtIndex = (int) (309680);
                f_loadScriptVariableValueAtIndex = true;
                return _loadScriptVariableValueAtIndex;
            }
        }
        private bool f_portraitBoxNeedsUpdate;
        private int _portraitBoxNeedsUpdate;

        /// <summary>
        /// Checks if a portrait box has a state of PORTRAIT_BOX_TRY_UPDATE or PORTRAIT_BOX_UPDATE.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int PortraitBoxNeedsUpdate
        {
            get
            {
                if (f_portraitBoxNeedsUpdate)
                    return _portraitBoxNeedsUpdate;
                _portraitBoxNeedsUpdate = (int) (194912);
                f_portraitBoxNeedsUpdate = true;
                return _portraitBoxNeedsUpdate;
            }
        }
        private bool f_taskProcBoot;
        private int _taskProcBoot;

        /// <summary>
        /// Boot the game and run the main loop. Use dynamic code dispatch to run code depending on the context (like dungeon mode, ground mode, menu mode, etc.).
        /// 
        /// This function prints the debug message &quot;task proc boot&quot;.
        /// 
        /// No params.
        /// </summary>
        public int TaskProcBoot
        {
            get
            {
                if (f_taskProcBoot)
                    return _taskProcBoot;
                _taskProcBoot = (int) (13096);
                f_taskProcBoot = true;
                return _taskProcBoot;
            }
        }
        private bool f_getRankString;
        private int _getRankString;

        /// <summary>
        /// Gets the string corresponding to the player's current explorer rank.
        /// 
        /// r0: [output] Pointer to the buffer where the string will be written (if flags are 0)
        /// r1: First 16 bits contain the rank, next 4 are some sort of bitflags
        /// return: r0 if flags are 0, pointer to some static address otherwise
        /// </summary>
        public int GetRankString
        {
            get
            {
                if (f_getRankString)
                    return _getRankString;
                _getRankString = (int) (150920);
                f_getRankString = true;
                return _getRankString;
            }
        }
        private bool f_readItemsFromSave;
        private int _readItemsFromSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: start_address
        /// r1: total_length
        /// return: ?
        /// </summary>
        public int ReadItemsFromSave
        {
            get
            {
                if (f_readItemsFromSave)
                    return _readItemsFromSave;
                _readItemsFromSave = (int) (56524);
                f_readItemsFromSave = true;
                return _readItemsFromSave;
            }
        }
        private bool f_applyLifeSeedBoostToGroundMonster;
        private int _applyLifeSeedBoostToGroundMonster;

        /// <summary>
        /// Applies the hp boost from the Life Seed to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted hp boost, if not NULL
        /// return: actual hp boost
        /// </summary>
        public int ApplyLifeSeedBoostToGroundMonster
        {
            get
            {
                if (f_applyLifeSeedBoostToGroundMonster)
                    return _applyLifeSeedBoostToGroundMonster;
                _applyLifeSeedBoostToGroundMonster = (int) (71268);
                f_applyLifeSeedBoostToGroundMonster = true;
                return _applyLifeSeedBoostToGroundMonster;
            }
        }
        private bool f_generateAllPossibleMonstersList;
        private int _generateAllPossibleMonstersList;

        /// <summary>
        /// Attempts to add monster IDs 1 (Bulbasaur) through 535 (Shaymin Sky) as entries to a heap-allocated list.
        /// 
        /// If no monsters are valid mission targets, the heap-allocated list is freed. Otherwise, sets MISSION_MONSTER_LIST_PTR and MISSION_MONSTER_COUNT.
        /// 
        /// return: Number of monsters usable for a mission
        /// </summary>
        public int GenerateAllPossibleMonstersList
        {
            get
            {
                if (f_generateAllPossibleMonstersList)
                    return _generateAllPossibleMonstersList;
                _generateAllPossibleMonstersList = (int) (391892);
                f_generateAllPossibleMonstersList = true;
                return _generateAllPossibleMonstersList;
            }
        }
        private bool f_getDebugFlag;
        private int _getDebugFlag;

        /// <summary>
        /// Should return the value of the specified debug flag. Just returns 0 in the final binary.
        /// 
        /// r0: flag ID
        /// return: flag value
        /// </summary>
        public int GetDebugFlag
        {
            get
            {
                if (f_getDebugFlag)
                    return _getDebugFlag;
                _getDebugFlag = (int) (49560);
                f_getDebugFlag = true;
                return _getDebugFlag;
            }
        }
        private bool f_resumeAdvancedMenu;
        private int _resumeAdvancedMenu;

        /// <summary>
        /// Resumes input for a window created with CreateAdvancedMenu. Used for menus that do not close even after selecting an option.
        /// 
        /// r0: window_id
        /// </summary>
        public int ResumeAdvancedMenu
        {
            get
            {
                if (f_resumeAdvancedMenu)
                    return _resumeAdvancedMenu;
                _resumeAdvancedMenu = (int) (179940);
                f_resumeAdvancedMenu = true;
                return _resumeAdvancedMenu;
            }
        }
        private bool f_seChangeVolume;
        private int _seChangeVolume;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int SeChangeVolume
        {
            get
            {
                if (f_seChangeVolume)
                    return _seChangeVolume;
                _seChangeVolume = (int) (108740);
                f_seChangeVolume = true;
                return _seChangeVolume;
            }
        }
        private bool f_updateDialogueBox;
        private int _updateDialogueBox;

        /// <summary>
        /// Window update function for dialogue boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateDialogueBox
        {
            get
            {
                if (f_updateDialogueBox)
                    return _updateDialogueBox;
                _updateDialogueBox = (int) (194428);
                f_updateDialogueBox = true;
                return _updateDialogueBox;
            }
        }
        private bool f_writeSaveFile;
        private int _writeSaveFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: save_info
        /// r1: buffer
        /// r2: size
        /// return: status code
        /// </summary>
        public int WriteSaveFile
        {
            get
            {
                if (f_writeSaveFile)
                    return _writeSaveFile;
                _writeSaveFile = (int) (299408);
                f_writeSaveFile = true;
                return _writeSaveFile;
            }
        }
        private bool f_strcpySimple;
        private int _strcpySimple;

        /// <summary>
        /// A simple implementation of the strcpy(3) C library function.
        /// 
        /// This function was probably manually implemented by the developers. See strcpy for what's probably the real libc function.
        /// 
        /// r0: dest
        /// r1: src
        /// </summary>
        public int StrcpySimple
        {
            get
            {
                if (f_strcpySimple)
                    return _strcpySimple;
                _strcpySimple = (int) (152524);
                f_strcpySimple = true;
                return _strcpySimple;
            }
        }
        private bool f_setNotifyNote;
        private int _setNotifyNote;

        /// <summary>
        /// Sets NOTIFY_NOTE to the given value.
        /// 
        /// r0: bool
        /// </summary>
        public int SetNotifyNote
        {
            get
            {
                if (f_setNotifyNote)
                    return _setNotifyNote;
                _setNotifyNote = (int) (296908);
                f_setNotifyNote = true;
                return _setNotifyNote;
            }
        }
        private bool f_getAllBaseForms;
        private int _getAllBaseForms;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: base form
        /// </summary>
        public int GetAllBaseForms
        {
            get
            {
                if (f_getAllBaseForms)
                    return _getAllBaseForms;
                _getAllBaseForms = (int) (346080);
                f_getAllBaseForms = true;
                return _getAllBaseForms;
            }
        }
        private bool f_checkParentMenuField0x1A0;
        private int _checkParentMenuField0x1A0;

        /// <summary>
        /// Checks if a parent menu's field_0x1a0 is 0.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int CheckParentMenuField0x1A0
        {
            get
            {
                if (f_checkParentMenuField0x1A0)
                    return _checkParentMenuField0x1A0;
                _checkParentMenuField0x1A0 = (int) (175700);
                f_checkParentMenuField0x1A0 = true;
                return _checkParentMenuField0x1A0;
            }
        }
        private bool f_isGummi;
        private int _isGummi;

        /// <summary>
        /// Checks if an item is a Gummi.
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsGummi
        {
            get
            {
                if (f_isGummi)
                    return _isGummi;
                _isGummi = (int) (52348);
                f_isGummi = true;
                return _isGummi;
            }
        }
        private bool f_getRankUpEntry;
        private int _getRankUpEntry;

        /// <summary>
        /// Gets the rank up data for the specified rank.
        /// 
        /// r0: rank index
        /// return: struct rankup_table_entry*
        /// </summary>
        public int GetRankUpEntry
        {
            get
            {
                if (f_getRankUpEntry)
                    return _getRankUpEntry;
                _getRankUpEntry = (int) (334636);
                f_getRankUpEntry = true;
                return _getRankUpEntry;
            }
        }
        private bool f_loadAlert;
        private int _loadAlert;

        /// <summary>
        /// Load and initialize the alert sprite, storing the result in ALERT_ANIMATION_CONTROL
        /// 
        /// No params.
        /// </summary>
        public int LoadAlert
        {
            get
            {
                if (f_loadAlert)
                    return _loadAlert;
                _loadAlert = (int) (172508);
                f_loadAlert = true;
                return _loadAlert;
            }
        }
        private bool f_getExp;
        private int _getExp;

        /// <summary>
        /// Base Formula = ((Level-1)*ExpYield)//10+ExpYield
        /// Note: Defeating an enemy without using a move will divide this amount by 2
        /// 
        /// r0: id
        /// r1: level
        /// return: exp
        /// </summary>
        public int GetExp
        {
            get
            {
                if (f_getExp)
                    return _getExp;
                _getExp = (int) (339380);
                f_getExp = true;
                return _getExp;
            }
        }
        private bool f_isExclusiveItemForMonster;
        private int _isExclusiveItemForMonster;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item
        /// r1: monster ID
        /// r2: type ID 1
        /// r3: type ID 2
        /// return: bool
        /// </summary>
        public int IsExclusiveItemForMonster
        {
            get
            {
                if (f_isExclusiveItemForMonster)
                    return _isExclusiveItemForMonster;
                _isExclusiveItemForMonster = (int) (69948);
                f_isExclusiveItemForMonster = true;
                return _isExclusiveItemForMonster;
            }
        }
        private bool f_createAreaNameBox;
        private int _createAreaNameBox;

        /// <summary>
        /// Creates a window containing the area name, as resolved from the &quot;[area:0]&quot; tag.
        /// 
        /// This only seems to be used for the &quot;area name&quot; text box in the top-level menu in ground mode (not dungeon mode), and the analogous text box on the world map transition screen before entering a dungeon.
        /// 
        /// If window_params is NULL, AREA_NAME_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width is 0, it will be computed based on the contained text. If window_params::height is 0, it will default to 2.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: ID (for preprocessor_args)
        /// return: window_id
        /// </summary>
        public int CreateAreaNameBox
        {
            get
            {
                if (f_createAreaNameBox)
                    return _createAreaNameBox;
                _createAreaNameBox = (int) (196272);
                f_createAreaNameBox = true;
                return _createAreaNameBox;
            }
        }
        private bool f_arm9StoreUnkFieldNa0x2029Ed8;
        private int _arm9StoreUnkFieldNa0x2029Ed8;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: value
        /// </summary>
        public int Arm9StoreUnkFieldNa0x2029Ed8
        {
            get
            {
                if (f_arm9StoreUnkFieldNa0x2029Ed8)
                    return _arm9StoreUnkFieldNa0x2029Ed8;
                _arm9StoreUnkFieldNa0x2029Ed8 = (int) (172492);
                f_arm9StoreUnkFieldNa0x2029Ed8 = true;
                return _arm9StoreUnkFieldNa0x2029Ed8;
            }
        }
        private bool f_addFixedPoint64;
        private int _addFixedPoint64;

        /// <summary>
        /// Adds two 64-bit fixed-point numbers (16 fraction bits) x and y.
        /// 
        /// r0: [output] sum (x + y)
        /// r1: x
        /// r2: y
        /// </summary>
        public int AddFixedPoint64
        {
            get
            {
                if (f_addFixedPoint64)
                    return _addFixedPoint64;
                _addFixedPoint64 = (int) (8648);
                f_addFixedPoint64 = true;
                return _addFixedPoint64;
            }
        }
        private bool f_checkAcceptedMissionByTypeAndDungeon;
        private int _checkAcceptedMissionByTypeAndDungeon;

        /// <summary>
        /// Returns true if there are any accepted missions on the mission list that are of the specified type and take place in the specified dungeon.
        /// 
        /// If the type of the mission has a subtype, the subtype of the checked mission must match the one in [r2] too for it to be returned.
        /// 
        /// r0: Mission type
        /// r1: Pointer to some struct that contains the subtype of the mission to check on its first byte
        /// r2: Dungeon ID
        /// return: True if at least one mission meets the specified requirements, false otherwise.
        /// </summary>
        public int CheckAcceptedMissionByTypeAndDungeon
        {
            get
            {
                if (f_checkAcceptedMissionByTypeAndDungeon)
                    return _checkAcceptedMissionByTypeAndDungeon;
                _checkAcceptedMissionByTypeAndDungeon = (int) (391200);
                f_checkAcceptedMissionByTypeAndDungeon = true;
                return _checkAcceptedMissionByTypeAndDungeon;
            }
        }
        private bool f_isDialogueBoxActive;
        private int _isDialogueBoxActive;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsDialogueBoxActive
        {
            get
            {
                if (f_isDialogueBoxActive)
                    return _isDialogueBoxActive;
                _isDialogueBoxActive = (int) (193652);
                f_isDialogueBoxActive = true;
                return _isDialogueBoxActive;
            }
        }
        private bool f_createTextBoxWithArg;
        private int _createTextBoxWithArg;

        /// <summary>
        /// Calls CreateTextBoxInternal, sets the callback with an argument, and returns the window_id.
        /// 
        /// r0: window_params
        /// r1: text box callback with arg function
        /// r2: callback argument
        /// return: window_id
        /// </summary>
        public int CreateTextBoxWithArg
        {
            get
            {
                if (f_createTextBoxWithArg)
                    return _createTextBoxWithArg;
                _createTextBoxWithArg = (int) (195536);
                f_createTextBoxWithArg = true;
                return _createTextBoxWithArg;
            }
        }
        private bool f_setDebugLogFlag;
        private int _setDebugLogFlag;

        /// <summary>
        /// Should set the value of a debug log flag. A no-op in the final binary.
        /// 
        /// r0: flag ID
        /// r1: flag value
        /// </summary>
        public int SetDebugLogFlag
        {
            get
            {
                if (f_setDebugLogFlag)
                    return _setDebugLogFlag;
                _setDebugLogFlag = (int) (49860);
                f_setDebugLogFlag = true;
                return _setDebugLogFlag;
            }
        }
        private bool f_getThrownItemQuantityLimit;
        private int _getThrownItemQuantityLimit;

        /// <summary>
        /// Get the minimum or maximum quantity for a given thrown item ID.
        /// 
        /// r0: item ID
        /// r1: 0 for minimum, 1 for maximum
        /// return: minimum/maximum quantity for the given item ID
        /// </summary>
        public int GetThrownItemQuantityLimit
        {
            get
            {
                if (f_getThrownItemQuantityLimit)
                    return _getThrownItemQuantityLimit;
                _getThrownItemQuantityLimit = (int) (60160);
                f_getThrownItemQuantityLimit = true;
                return _getThrownItemQuantityLimit;
            }
        }
        private bool f_oSiReferSymbol;
        private int _oSiReferSymbol;

        /// <summary>
        /// Startup routine in the program's crt0 (https://en.wikipedia.org/wiki/Crt0).
        /// </summary>
        public int OSiReferSymbol
        {
            get
            {
                if (f_oSiReferSymbol)
                    return _oSiReferSymbol;
                _oSiReferSymbol = (int) (2972);
                f_oSiReferSymbol = true;
                return _oSiReferSymbol;
            }
        }
        private bool f_uFixedPoint64CmpLt;
        private int _uFixedPoint64CmpLt;

        /// <summary>
        /// Compares two unsigned 64-bit fixed-point numbers (16 fraction bits) x and y.
        /// 
        /// r0: upper 32 bits of x
        /// r1: lower 32 bits of x
        /// r2: upper 32 bits of y
        /// r3: lower 32 bits of y
        /// return: x &lt; y
        /// </summary>
        public int UFixedPoint64CmpLt
        {
            get
            {
                if (f_uFixedPoint64CmpLt)
                    return _uFixedPoint64CmpLt;
                _uFixedPoint64CmpLt = (int) (6704);
                f_uFixedPoint64CmpLt = true;
                return _uFixedPoint64CmpLt;
            }
        }
        private bool f_isMissionValid;
        private int _isMissionValid;

        /// <summary>
        /// Checks if a mission contains valid fields.
        /// 
        /// For example, a mission will be considered invalid if the ID of the monsters or items involved are out of bounds, if their entries are marked as invalid, if the destination floor does not exist, etc.
        /// If the mission fails one of the checks, the game will print an error message explaining what is wrong using DebugPrint0.
        /// 
        /// r0: mission to check
        /// return: True if the mission is valid, false if it's not.
        /// </summary>
        public int IsMissionValid
        {
            get
            {
                if (f_isMissionValid)
                    return _isMissionValid;
                _isMissionValid = (int) (380348);
                f_isMissionValid = true;
                return _isMissionValid;
            }
        }
        private bool f_zInit8;
        private int _zInit8;

        /// <summary>
        /// Zeroes an 8-byte buffer.
        /// 
        /// r0: ptr
        /// </summary>
        public int ZInit8
        {
            get
            {
                if (f_zInit8)
                    return _zInit8;
                _zInit8 = (int) (12840);
                f_zInit8 = true;
                return _zInit8;
            }
        }
        private bool f_addItemToKecleonShop2;
        private int _addItemToKecleonShop2;

        /// <summary>
        /// Tries to add the item to the second Kecleon shop. If there is no space, no item is added.
        /// 
        /// r0: item ID
        /// return: whether the item was added succesfully
        /// </summary>
        public int AddItemToKecleonShop2
        {
            get
            {
                if (f_addItemToKecleonShop2)
                    return _addItemToKecleonShop2;
                _addItemToKecleonShop2 = (int) (69236);
                f_addItemToKecleonShop2 = true;
                return _addItemToKecleonShop2;
            }
        }
        private bool f_wanHasAnimationGroup;
        private int _wanHasAnimationGroup;

        /// <summary>
        /// Check if the input WAN file loaded in memory has an animation group with this ID
        /// Valid means that the animation group is in the range of existing animation, and that it has at least one animation.
        /// 
        /// r0: pointer to the header of the WAN
        /// r1: id of the animation group
        /// return: whether the WAN file has the given animation group
        /// </summary>
        public int WanHasAnimationGroup
        {
            get
            {
                if (f_wanHasAnimationGroup)
                    return _wanHasAnimationGroup;
                _wanHasAnimationGroup = (int) (121568);
                f_wanHasAnimationGroup = true;
                return _wanHasAnimationGroup;
            }
        }
        private bool f_setActorTalkMain;
        private int _setActorTalkMain;

        /// <summary>
        /// Sets ACTOR_TALK_MAIN to be actor_id.
        /// Implements SPECIAL_PROC_SET_ACTOR_TALK_MAIN (see ScriptSpecialProcessCall).
        /// 
        /// r0: actor_id
        /// </summary>
        public int SetActorTalkMain
        {
            get
            {
                if (f_setActorTalkMain)
                    return _setActorTalkMain;
                _setActorTalkMain = (int) (417484);
                f_setActorTalkMain = true;
                return _setActorTalkMain;
            }
        }
        private bool f_mainLoop;
        private int _mainLoop;

        /// <summary>
        /// This function gets called shortly after the game is started. Contains a single infinite loop and has no return statement.
        /// 
        /// No params.
        /// </summary>
        public int MainLoop
        {
            get
            {
                if (f_mainLoop)
                    return _mainLoop;
                _mainLoop = (int) (417944);
                f_mainLoop = true;
                return _mainLoop;
            }
        }
        private bool f_setHolderForItemInBag;
        private int _setHolderForItemInBag;

        /// <summary>
        /// Modifies the item at the index to be held by the monster specified and updates the item with the
        /// holder as well. This only modifies the flags and held_by of the item.
        /// 
        /// r0: item index
        /// r1: pointer to an item
        /// r2: held_by
        /// </summary>
        public int SetHolderForItemInBag
        {
            get
            {
                if (f_setHolderForItemInBag)
                    return _setHolderForItemInBag;
                _setHolderForItemInBag = (int) (64648);
                f_setHolderForItemInBag = true;
                return _setHolderForItemInBag;
            }
        }
        private bool f_retrieveFromItemList2;
        private int _retrieveFromItemList2;

        /// <summary>
        /// Same as RetrieveFromItemList1, except there is one more comparison
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon_info
        /// </summary>
        public int RetrieveFromItemList2
        {
            get
            {
                if (f_retrieveFromItemList2)
                    return _retrieveFromItemList2;
                _retrieveFromItemList2 = (int) (334260);
                f_retrieveFromItemList2 = true;
                return _retrieveFromItemList2;
            }
        }
        private bool f_debugPrintSystemClock;
        private int _debugPrintSystemClock;

        /// <summary>
        /// This function prints the debug message &quot;Now date &amp; time&quot; followed by the current date and time of the DS system clock. Called on boot.
        /// 
        /// No params.
        /// </summary>
        public int DebugPrintSystemClock
        {
            get
            {
                if (f_debugPrintSystemClock)
                    return _debugPrintSystemClock;
                _debugPrintSystemClock = (int) (28408);
                f_debugPrintSystemClock = true;
                return _debugPrintSystemClock;
            }
        }
        private bool f_setAdvancedTextBoxState5;
        private int _setAdvancedTextBoxState5;

        /// <summary>
        /// Sets the state of an advanced text box to 5.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetAdvancedTextBoxState5
        {
            get
            {
                if (f_setAdvancedTextBoxState5)
                    return _setAdvancedTextBoxState5;
                _setAdvancedTextBoxState5 = (int) (199552);
                f_setAdvancedTextBoxState5 = true;
                return _setAdvancedTextBoxState5;
            }
        }
        private bool f_loadScriptVariableValueBytes;
        private int _loadScriptVariableValueBytes;

        /// <summary>
        /// Loads some number of bytes from the value of a given script variable.
        /// 
        /// r0: script variable ID
        /// r1: [output] script variable value bytes
        /// r2: number of bytes to load
        /// </summary>
        public int LoadScriptVariableValueBytes
        {
            get
            {
                if (f_loadScriptVariableValueBytes)
                    return _loadScriptVariableValueBytes;
                _loadScriptVariableValueBytes = (int) (310940);
                f_loadScriptVariableValueBytes = true;
                return _loadScriptVariableValueBytes;
            }
        }
        private bool f_render3d64Quadrilateral;
        private int _render3d64Quadrilateral;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[4]. Renders a render_3d_element_64 with type RENDER64_QUADRILATERAL.
        /// 
        /// Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_QUADRILATERAL.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64Quadrilateral
        {
            get
            {
                if (f_render3d64Quadrilateral)
                    return _render3d64Quadrilateral;
                _render3d64Quadrilateral = (int) (126700);
                f_render3d64Quadrilateral = true;
                return _render3d64Quadrilateral;
            }
        }
        private bool f_getMobilityType;
        private int _getMobilityType;

        /// <summary>
        /// Gets the mobility type for a given monster species.
        /// 
        /// r0: species ID
        /// return: mobility type
        /// </summary>
        public int GetMobilityType
        {
            get
            {
                if (f_getMobilityType)
                    return _getMobilityType;
                _getMobilityType = (int) (338860);
                f_getMobilityType = true;
                return _getMobilityType;
            }
        }
        private bool f_getWindow;
        private int _getWindow;

        /// <summary>
        /// Get the window with a given ID from WINDOW_LIST.
        /// 
        /// r0: window_id
        /// return: window
        /// </summary>
        public int GetWindow
        {
            get
            {
                if (f_getWindow)
                    return _getWindow;
                _getWindow = (int) (162028);
                f_getWindow = true;
                return _getWindow;
            }
        }
        private bool f_saveScriptVariableValue;
        private int _saveScriptVariableValue;

        /// <summary>
        /// Saves the given value to a script variable.
        /// 
        /// r0: pointer to local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID
        /// r2: value to save
        /// </summary>
        public int SaveScriptVariableValue
        {
            get
            {
                if (f_saveScriptVariableValue)
                    return _saveScriptVariableValue;
                _saveScriptVariableValue = (int) (310104);
                f_saveScriptVariableValue = true;
                return _saveScriptVariableValue;
            }
        }
        private bool f_getOptionsMenuStates;
        private int _getOptionsMenuStates;

        /// <summary>
        /// Gets all the option menu states; used to determine what options the user has selected in a menu. Each option state corresponds a options_menu_id_item.
        /// 
        /// r0: window_id
        /// r1: option_states pointer
        /// </summary>
        public int GetOptionsMenuStates
        {
            get
            {
                if (f_getOptionsMenuStates)
                    return _getOptionsMenuStates;
                _getOptionsMenuStates = (int) (186532);
                f_getOptionsMenuStates = true;
                return _getOptionsMenuStates;
            }
        }
        private bool f_getLvlUpEntry;
        private int _getLvlUpEntry;

        /// <summary>
        /// Gets the level-up entry of the given monster ID at the specified level.
        /// 
        /// The monster's entire level up data is also decompressed to LEVEL_UP_DATA_DECOMPRESS_BUFFER, and its ID is stored in LEVEL_UP_DATA_MONSTER_ID.
        /// 
        /// r0: [output] Level-up entry
        /// r1: monster ID
        /// r2: level
        /// </summary>
        public int GetLvlUpEntry
        {
            get
            {
                if (f_getLvlUpEntry)
                    return _getLvlUpEntry;
                _getLvlUpEntry = (int) (342808);
                f_getLvlUpEntry = true;
                return _getLvlUpEntry;
            }
        }
        private bool f_getNbAdventures;
        private int _getNbAdventures;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: # adventures
        /// </summary>
        public int GetNbAdventures
        {
            get
            {
                if (f_getNbAdventures)
                    return _getNbAdventures;
                _getNbAdventures = (int) (317060);
                f_getNbAdventures = true;
                return _getNbAdventures;
            }
        }
        private bool f_bulkItemToItem;
        private int _bulkItemToItem;

        /// <summary>
        /// Convert a bulk_item into an equivalent item.
        /// 
        /// r0: pointer to item to initialize
        /// r1: pointer to bulk_item
        /// </summary>
        public int BulkItemToItem
        {
            get
            {
                if (f_bulkItemToItem)
                    return _bulkItemToItem;
                _bulkItemToItem = (int) (53368);
                f_bulkItemToItem = true;
                return _bulkItemToItem;
            }
        }
        private bool f_changeBgm2;
        private int _changeBgm2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ChangeBgm2
        {
            get
            {
                if (f_changeBgm2)
                    return _changeBgm2;
                _changeBgm2 = (int) (106884);
                f_changeBgm2 = true;
                return _changeBgm2;
            }
        }
        private bool f_printClearMark;
        private int _printClearMark;

        /// <summary>
        /// Prints the specified clear mark on the screen.
        /// 
        /// Clear marks are shown on the save file load screen. They are used to show which plot milestones have already been completed.
        /// 
        /// r0: Clear mark ID
        /// r1: X pos (unknown units, usually ranges between 3 and 27)
        /// r2: Y pos (unknown units, normally 14)
        /// r3: ?
        /// </summary>
        public int PrintClearMark
        {
            get
            {
                if (f_printClearMark)
                    return _printClearMark;
                _printClearMark = (int) (173784);
                f_printClearMark = true;
                return _printClearMark;
            }
        }
        private bool f_fileGetSize;
        private int _fileGetSize;

        /// <summary>
        /// Gets the size of an open file.
        /// 
        /// r0: file_stream pointer
        /// return: file size
        /// </summary>
        public int FileGetSize
        {
            get
            {
                if (f_fileGetSize)
                    return _fileGetSize;
                _fileGetSize = (int) (33348);
                f_fileGetSize = true;
                return _fileGetSize;
            }
        }
        private bool f_getUnlockedTactics;
        private int _getUnlockedTactics;

        /// <summary>
        /// Returns an array with all the enabled tactics. TACTIC_NONE is used to fill the empty/unused entries
        /// in the array.
        /// 
        /// r0: [output] Array of tactic_ids that are enabled
        /// r1: Monster level
        /// </summary>
        public int GetUnlockedTactics
        {
            get
            {
                if (f_getUnlockedTactics)
                    return _getUnlockedTactics;
                _getUnlockedTactics = (int) (364488);
                f_getUnlockedTactics = true;
                return _getUnlockedTactics;
            }
        }
        private bool f_dungeonGoesUp;
        private int _dungeonGoesUp;

        /// <summary>
        /// Returns whether the specified dungeon is considered as going upward or not
        /// 
        /// r0: dungeon id
        /// return: bool
        /// </summary>
        public int DungeonGoesUp
        {
            get
            {
                if (f_dungeonGoesUp)
                    return _dungeonGoesUp;
                _dungeonGoesUp = (int) (333248);
                f_dungeonGoesUp = true;
                return _dungeonGoesUp;
            }
        }
        private bool f_incrementNbSkyGiftsSent;
        private int _incrementNbSkyGiftsSent;

        /// <summary>
        /// Increments by 1 the number of sky gifts sent.
        /// 
        /// Implements SPECIAL_PROC_SEND_SKY_GIFT_TO_GUILDMASTER (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbSkyGiftsSent
        {
            get
            {
                if (f_incrementNbSkyGiftsSent)
                    return _incrementNbSkyGiftsSent;
                _incrementNbSkyGiftsSent = (int) (328376);
                f_incrementNbSkyGiftsSent = true;
                return _incrementNbSkyGiftsSent;
            }
        }
        private bool f_getSpriteSize;
        private int _getSpriteSize;

        /// <summary>
        /// Returns the sprite size of the specified monster. If the size is between 1 and 6, 6 will be returned.
        /// 
        /// r0: monster id
        /// return: sprite size
        /// </summary>
        public int GetSpriteSize
        {
            get
            {
                if (f_getSpriteSize)
                    return _getSpriteSize;
                _getSpriteSize = (int) (338712);
                f_getSpriteSize = true;
                return _getSpriteSize;
            }
        }
        private bool f_isItemWithFlagsInBag;
        private int _isItemWithFlagsInBag;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// r1: flags
        /// return: bool
        /// </summary>
        public int IsItemWithFlagsInBag
        {
            get
            {
                if (f_isItemWithFlagsInBag)
                    return _isItemWithFlagsInBag;
                _isItemWithFlagsInBag = (int) (61384);
                f_isItemWithFlagsInBag = true;
                return _isItemWithFlagsInBag;
            }
        }
        private bool f_setCollectionMenuField0x1Bc;
        private int _setCollectionMenuField0x1Bc;

        /// <summary>
        /// Sets collection_menu::field_0x1bc to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetCollectionMenuField0x1Bc
        {
            get
            {
                if (f_setCollectionMenuField0x1Bc)
                    return _setCollectionMenuField0x1Bc;
                _setCollectionMenuField0x1Bc = (int) (182484);
                f_setCollectionMenuField0x1Bc = true;
                return _setCollectionMenuField0x1Bc;
            }
        }
        private bool f_incrementNbFriendRescues;
        private int _incrementNbFriendRescues;

        /// <summary>
        /// Increments by 1 the number of successful friend rescues.
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbFriendRescues
        {
            get
            {
                if (f_incrementNbFriendRescues)
                    return _incrementNbFriendRescues;
                _incrementNbFriendRescues = (int) (327608);
                f_incrementNbFriendRescues = true;
                return _incrementNbFriendRescues;
            }
        }
        private bool f_getActorMatchingStorageId;
        private int _getActorMatchingStorageId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: actor_id
        /// return: storage ID
        /// </summary>
        public int GetActorMatchingStorageId
        {
            get
            {
                if (f_getActorMatchingStorageId)
                    return _getActorMatchingStorageId;
                _getActorMatchingStorageId = (int) (417044);
                f_getActorMatchingStorageId = true;
                return _getActorMatchingStorageId;
            }
        }
        private bool f_decompressAtFromMemoryPointerVeneer;
        private int _decompressAtFromMemoryPointerVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for DecompressAtFromMemoryPointer.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: addr_decomp
        /// r1: expected_size
        /// r2: AT pointer
        /// return: ?
        /// </summary>
        public int DecompressAtFromMemoryPointerVeneer
        {
            get
            {
                if (f_decompressAtFromMemoryPointerVeneer)
                    return _decompressAtFromMemoryPointerVeneer;
                _decompressAtFromMemoryPointerVeneer = (int) (131048);
                f_decompressAtFromMemoryPointerVeneer = true;
                return _decompressAtFromMemoryPointerVeneer;
            }
        }
        private bool f_generateDailyMissions;
        private int _generateDailyMissions;

        /// <summary>
        /// Generates the missions displayed on the Job Bulletin Board and the Outlaw Notice Board.
        /// 
        /// No params.
        /// </summary>
        public int GenerateDailyMissions
        {
            get
            {
                if (f_generateDailyMissions)
                    return _generateDailyMissions;
                _generateDailyMissions = (int) (387404);
                f_generateDailyMissions = true;
                return _generateDailyMissions;
            }
        }
        private bool f_closeTextBox;
        private int _closeTextBox;

        /// <summary>
        /// Closes a window created with CreateTextBox or CreateTextBoxWithArg.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseTextBox
        {
            get
            {
                if (f_closeTextBox)
                    return _closeTextBox;
                _closeTextBox = (int) (195568);
                f_closeTextBox = true;
                return _closeTextBox;
            }
        }
        private bool f_initMemArena;
        private int _initMemArena;

        /// <summary>
        /// Initializes a new memory arena with the given specifications, and records it in the global MEMORY_ALLOCATION_TABLE.
        /// 
        /// r0: arena struct to be initialized
        /// r1: memory region to be owned by the arena, as {pointer, length}
        /// r2: pointer to block metadata array for the arena to use
        /// r3: maximum number of blocks that the arena can hold
        /// </summary>
        public int InitMemArena
        {
            get
            {
                if (f_initMemArena)
                    return _initMemArena;
                _initMemArena = (int) (3784);
                f_initMemArena = true;
                return _initMemArena;
            }
        }
        private bool f_isAdvancedTextBoxActive;
        private int _isAdvancedTextBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of an advanced text box is something other than 6 or 7.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsAdvancedTextBoxActive
        {
            get
            {
                if (f_isAdvancedTextBoxActive)
                    return _isAdvancedTextBoxActive;
                _isAdvancedTextBoxActive = (int) (199608);
                f_isAdvancedTextBoxActive = true;
                return _isAdvancedTextBoxActive;
            }
        }
        private bool f_loadWazaP2;
        private int _loadWazaP2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int LoadWazaP2
        {
            get
            {
                if (f_loadWazaP2)
                    return _loadWazaP2;
                _loadWazaP2 = (int) (78996);
                f_loadWazaP2 = true;
                return _loadWazaP2;
            }
        }
        private bool f_getStringFromFileVeneer;
        private int _getStringFromFileVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for GetStringFromFile.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: Buffer
        /// r1: String ID
        /// </summary>
        public int GetStringFromFileVeneer
        {
            get
            {
                if (f_getStringFromFileVeneer)
                    return _getStringFromFileVeneer;
                _getStringFromFileVeneer = (int) (154500);
                f_getStringFromFileVeneer = true;
                return _getStringFromFileVeneer;
            }
        }
        private bool f_removeItemAtIdxInStorage;
        private int _removeItemAtIdxInStorage;

        /// <summary>
        /// Remove an item at the specified index from storage.
        /// 
        /// r0: storage item idx
        /// return: bool whether or not the item was removed (fails if there is no storage item at the index)
        /// </summary>
        public int RemoveItemAtIdxInStorage
        {
            get
            {
                if (f_removeItemAtIdxInStorage)
                    return _removeItemAtIdxInStorage;
                _removeItemAtIdxInStorage = (int) (66120);
                f_removeItemAtIdxInStorage = true;
                return _removeItemAtIdxInStorage;
            }
        }
        private bool f_render3d64Nothing;
        private int _render3d64Nothing;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[1]. Renders a render_3d_element_64 with type RENDER64_NOTHING. This function is entirely empty.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64Nothing
        {
            get
            {
                if (f_render3d64Nothing)
                    return _render3d64Nothing;
                _render3d64Nothing = (int) (127396);
                f_render3d64Nothing = true;
                return _render3d64Nothing;
            }
        }
        private bool f_hidePortraitBox;
        private int _hidePortraitBox;

        /// <summary>
        /// Flags a portrait box to be hidden at next update (sets portrait_box::hide) if it's not already in the PORTRAIT_BOX_HIDDEN state, and resets its buffer state.
        /// 
        /// r0: window_id
        /// </summary>
        public int HidePortraitBox
        {
            get
            {
                if (f_hidePortraitBox)
                    return _hidePortraitBox;
                _hidePortraitBox = (int) (195024);
                f_hidePortraitBox = true;
                return _hidePortraitBox;
            }
        }
        private bool f_render3d64WindowFrame;
        private int _render3d64WindowFrame;

        /// <summary>
        /// Draw the frame for a window, using the 3D engine.
        /// 
        /// The render_3d_element_64 contains certain value that needs to be set to a correct value for it to work.
        /// The element is not immediately sent to the geometry engine, but is converted to a render_3d_element and queued up in RENDER_3D.
        /// 
        /// RENDER_3D_FUNCTIONS_64[6], corresponding to a type of RENDER64_WINDOW_FRAME.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64WindowFrame
        {
            get
            {
                if (f_render3d64WindowFrame)
                    return _render3d64WindowFrame;
                _render3d64WindowFrame = (int) (125576);
                f_render3d64WindowFrame = true;
                return _render3d64WindowFrame;
            }
        }
        private bool f_getBagCapacitySpecialEpisode;
        private int _getBagCapacitySpecialEpisode;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: se_type
        /// return: bag capacity
        /// </summary>
        public int GetBagCapacitySpecialEpisode
        {
            get
            {
                if (f_getBagCapacitySpecialEpisode)
                    return _getBagCapacitySpecialEpisode;
                _getBagCapacitySpecialEpisode = (int) (334620);
                f_getBagCapacitySpecialEpisode = true;
                return _getBagCapacitySpecialEpisode;
            }
        }
        private bool f_eventFlagResume;
        private int _eventFlagResume;

        /// <summary>
        /// Restores BACKUP event flag script variables (see the code for an exhaustive list) to their
        /// respective script variables, but only in certain game modes.
        /// 
        /// This function prints the debug string &quot;EventFlag BackupGameMode %d&quot; with the game mode.
        /// 
        /// No params.
        /// </summary>
        public int EventFlagResume
        {
            get
            {
                if (f_eventFlagResume)
                    return _eventFlagResume;
                _eventFlagResume = (int) (312056);
                f_eventFlagResume = true;
                return _eventFlagResume;
            }
        }
        private bool f_initDebugStripped6;
        private int _initDebugStripped6;

        /// <summary>
        /// Does nothing, only called in the debug initialization function.
        /// </summary>
        public int InitDebugStripped6
        {
            get
            {
                if (f_initDebugStripped6)
                    return _initDebugStripped6;
                _initDebugStripped6 = (int) (49572);
                f_initDebugStripped6 = true;
                return _initDebugStripped6;
            }
        }
        private bool f_setSentryDutyGamePoints;
        private int _setSentryDutyGamePoints;

        /// <summary>
        /// Sets a new record in the footprints minigame.
        /// 
        /// r0: points
        /// return: the rank (range 0-4, 1st to 5th; -1 if out of ranking)
        /// </summary>
        public int SetSentryDutyGamePoints
        {
            get
            {
                if (f_setSentryDutyGamePoints)
                    return _setSentryDutyGamePoints;
                _setSentryDutyGamePoints = (int) (329716);
                f_setSentryDutyGamePoints = true;
                return _setSentryDutyGamePoints;
            }
        }
        private bool f_removeItem;
        private int _removeItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: index
        /// </summary>
        public int RemoveItem
        {
            get
            {
                if (f_removeItem)
                    return _removeItem;
                _removeItem = (int) (62636);
                f_removeItem = true;
                return _removeItem;
            }
        }
        private bool f_spriteTypeInWanTable;
        private int _spriteTypeInWanTable;

        /// <summary>
        /// Look up the sprite in the WAN table, and return its type
        /// 
        /// r0: sprite id in the WAN table
        /// return: sprite type
        /// </summary>
        public int SpriteTypeInWanTable
        {
            get
            {
                if (f_spriteTypeInWanTable)
                    return _spriteTypeInWanTable;
                _spriteTypeInWanTable = (int) (122124);
                f_spriteTypeInWanTable = true;
                return _spriteTypeInWanTable;
            }
        }
        private bool f_createJobSummary;
        private int _createJobSummary;

        /// <summary>
        /// Creates a window containing a summary of a specific mission on the Top Screen.
        /// 
        /// r0: mission pointer
        /// r1: ?
        /// </summary>
        public int CreateJobSummary
        {
            get
            {
                if (f_createJobSummary)
                    return _createJobSummary;
                _createJobSummary = (int) (433048);
                f_createJobSummary = true;
                return _createJobSummary;
            }
        }
        private bool f_findItemInInventory;
        private int _findItemInInventory;

        /// <summary>
        /// Returns x if item_id is at position x in the bag
        /// Returns 0x8000+x if item_id is at position x in storage
        /// Returns -1 if item is not found
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_id
        /// return: inventory index
        /// </summary>
        public int FindItemInInventory
        {
            get
            {
                if (f_findItemInInventory)
                    return _findItemInInventory;
                _findItemInInventory = (int) (54016);
                f_findItemInInventory = true;
                return _findItemInInventory;
            }
        }
        private bool f_tryAddMonsterToActiveTeam;
        private int _tryAddMonsterToActiveTeam;

        /// <summary>
        /// Attempts to add a monster from the team member table to the active team.
        /// 
        /// Returns the team index of the newly added monster. If the monster was already on the team, returns its current team index. If the monster is not on the team and there's no space left, returns -1.
        /// 
        /// r0: member index
        /// return: Team index
        /// </summary>
        public int TryAddMonsterToActiveTeam
        {
            get
            {
                if (f_tryAddMonsterToActiveTeam)
                    return _tryAddMonsterToActiveTeam;
                _tryAddMonsterToActiveTeam = (int) (355024);
                f_tryAddMonsterToActiveTeam = true;
                return _tryAddMonsterToActiveTeam;
            }
        }
        private bool f_getSpriteFileSize;
        private int _getSpriteFileSize;

        /// <summary>
        /// Returns the sprite file size of the specified monster.
        /// 
        /// r0: monster id
        /// return: sprite file size
        /// </summary>
        public int GetSpriteFileSize
        {
            get
            {
                if (f_getSpriteFileSize)
                    return _getSpriteFileSize;
                _getSpriteFileSize = (int) (338772);
                f_getSpriteFileSize = true;
                return _getSpriteFileSize;
            }
        }
        private bool f_setCollectionMenuWidth;
        private int _setCollectionMenuWidth;

        /// <summary>
        /// Sets collection_menu::width to a new value, clamped to be no greater than (window_params::width * 8 - 1) for the window.
        /// 
        /// r0: window_id
        /// r1: width
        /// </summary>
        public int SetCollectionMenuWidth
        {
            get
            {
                if (f_setCollectionMenuWidth)
                    return _setCollectionMenuWidth;
                _setCollectionMenuWidth = (int) (182504);
                f_setCollectionMenuWidth = true;
                return _setCollectionMenuWidth;
            }
        }
        private bool f_getMonsterFlag1;
        private int _getMonsterFlag1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: ?
        /// </summary>
        public int GetMonsterFlag1
        {
            get
            {
                if (f_getMonsterFlag1)
                    return _getMonsterFlag1;
                _getMonsterFlag1 = (int) (316608);
                f_getMonsterFlag1 = true;
                return _getMonsterFlag1;
            }
        }
        private bool f_setPokemonJoined;
        private int _setPokemonJoined;

        /// <summary>
        /// Marks one pokémon as joined.
        /// 
        /// r0: monster ID
        /// </summary>
        public int SetPokemonJoined
        {
            get
            {
                if (f_setPokemonJoined)
                    return _setPokemonJoined;
                _setPokemonJoined = (int) (327988);
                f_setPokemonJoined = true;
                return _setPokemonJoined;
            }
        }
        private bool f_applyNectarBoostToGroundMonster;
        private int _applyNectarBoostToGroundMonster;

        /// <summary>
        /// Applies the iq boost from Nectar to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted iq boost, if not NULL
        /// return: actual iq boost
        /// </summary>
        public int ApplyNectarBoostToGroundMonster
        {
            get
            {
                if (f_applyNectarBoostToGroundMonster)
                    return _applyNectarBoostToGroundMonster;
                _applyNectarBoostToGroundMonster = (int) (71844);
                f_applyNectarBoostToGroundMonster = true;
                return _applyNectarBoostToGroundMonster;
            }
        }
        private bool f_getMoveBasePp;
        private int _getMoveBasePp;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move
        /// return: base PP
        /// </summary>
        public int GetMoveBasePp
        {
            get
            {
                if (f_getMoveBasePp)
                    return _getMoveBasePp;
                _getMoveBasePp = (int) (80600);
                f_getMoveBasePp = true;
                return _getMoveBasePp;
            }
        }
        private bool f_isHealingWishOrLunarDance;
        private int _isHealingWishOrLunarDance;

        /// <summary>
        /// Checks if a move ID is MOVE_HEALING_WISH or MOVE_LUNAR_DANCE.
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsHealingWishOrLunarDance
        {
            get
            {
                if (f_isHealingWishOrLunarDance)
                    return _isHealingWishOrLunarDance;
                _isHealingWishOrLunarDance = (int) (85504);
                f_isHealingWishOrLunarDance = true;
                return _isHealingWishOrLunarDance;
            }
        }
        private bool f_randomizeDemoActors;
        private int _randomizeDemoActors;

        /// <summary>
        /// Randomly picks one of the 18 teams from DEMO_TEAMS and sets ENTITY_NPC_DEMO_HERO and ENTITY_NPC_DEMO_PARTNER
        /// to the randomly selected hero and partner.
        /// Implements SPECIAL_PROC_RANDOMIZE_DEMO_ACTORS (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int RandomizeDemoActors
        {
            get
            {
                if (f_randomizeDemoActors)
                    return _randomizeDemoActors;
                _randomizeDemoActors = (int) (417732);
                f_randomizeDemoActors = true;
                return _randomizeDemoActors;
            }
        }
        private bool f_getScenarioBalance;
        private int _getScenarioBalance;

        /// <summary>
        /// Returns the current SCENARIO_BALANCE value.
        /// 
        /// The exact value returned depends on multiple factors:
        /// - If the first special episode is active, returns 1
        /// - If a different special episode is active, returns 3
        /// - If the SCENARIO_BALANCE_DEBUG variable is &gt;= 0, returns its value
        /// - In all other cases, the value of the SCENARIO_BALANCE_FLAG variable is returned
        /// 
        /// return: Current SCENARIO_BALANCE value.
        /// </summary>
        public int GetScenarioBalance
        {
            get
            {
                if (f_getScenarioBalance)
                    return _getScenarioBalance;
                _getScenarioBalance = (int) (315084);
                f_getScenarioBalance = true;
                return _getScenarioBalance;
            }
        }
        private bool f_setEnterDungeon;
        private int _setEnterDungeon;

        /// <summary>
        /// Used to set the dungeon that will be accessed when switching from ground to dungeon mode.
        /// 
        /// r0: Dungeon ID
        /// </summary>
        public int SetEnterDungeon
        {
            get
            {
                if (f_setEnterDungeon)
                    return _setEnterDungeon;
                _setEnterDungeon = (int) (322692);
                f_setEnterDungeon = true;
                return _setEnterDungeon;
            }
        }
        private bool f_ensureValidItem;
        private int _ensureValidItem;

        /// <summary>
        /// Checks if the given item ID is valid (using IsItemValid). If so, return the given item ID. Otherwise, return ITEM_PLAIN_SEED.
        /// 
        /// r0: item ID
        /// return: valid item ID
        /// </summary>
        public int EnsureValidItem
        {
            get
            {
                if (f_ensureValidItem)
                    return _ensureValidItem;
                _ensureValidItem = (int) (59640);
                f_ensureValidItem = true;
                return _ensureValidItem;
            }
        }
        private bool f_getMoveNbStrikes;
        private int _getMoveNbStrikes;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move
        /// return: # strikes
        /// </summary>
        public int GetMoveNbStrikes
        {
            get
            {
                if (f_getMoveNbStrikes)
                    return _getMoveNbStrikes;
                _getMoveNbStrikes = (int) (80468);
                f_getMoveNbStrikes = true;
                return _getMoveNbStrikes;
            }
        }
        private bool f_performPlannedTextureVramTransfer;
        private int _performPlannedTextureVramTransfer;

        /// <summary>
        /// Execute the texture VRAM edition command of the input container. Does not reset it, or alter its state in any way.
        /// 
        /// r0: container that contains the command list to execute
        /// </summary>
        public int PerformPlannedTextureVramTransfer
        {
            get
            {
                if (f_performPlannedTextureVramTransfer)
                    return _performPlannedTextureVramTransfer;
                _performPlannedTextureVramTransfer = (int) (123596);
                f_performPlannedTextureVramTransfer = true;
                return _performPlannedTextureVramTransfer;
            }
        }
        private bool f_closeTeamSelectionMenu;
        private int _closeTeamSelectionMenu;

        /// <summary>
        /// Closes a window created with CreateTeamSelectionMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseTeamSelectionMenu
        {
            get
            {
                if (f_closeTeamSelectionMenu)
                    return _closeTeamSelectionMenu;
                _closeTeamSelectionMenu = (int) (201868);
                f_closeTeamSelectionMenu = true;
                return _closeTeamSelectionMenu;
            }
        }
        private bool f_getGroundNameId;
        private int _getGroundNameId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int GetGroundNameId
        {
            get
            {
                if (f_getGroundNameId)
                    return _getGroundNameId;
                _getGroundNameId = (int) (326800);
                f_getGroundNameId = true;
                return _getGroundNameId;
            }
        }
        private bool f_loadWazaP;
        private int _loadWazaP;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int LoadWazaP
        {
            get
            {
                if (f_loadWazaP)
                    return _loadWazaP;
                _loadWazaP = (int) (78956);
                f_loadWazaP = true;
                return _loadWazaP;
            }
        }
        private bool f_getVictoriesOnOneFloor;
        private int _getVictoriesOnOneFloor;

        /// <summary>
        /// Gets the record of victories on one floor.
        /// 
        /// return: the record of victories
        /// </summary>
        public int GetVictoriesOnOneFloor
        {
            get
            {
                if (f_getVictoriesOnOneFloor)
                    return _getVictoriesOnOneFloor;
                _getVictoriesOnOneFloor = (int) (327968);
                f_getVictoriesOnOneFloor = true;
                return _getVictoriesOnOneFloor;
            }
        }
        private bool f_getAbilityDescStringId;
        private int _getAbilityDescStringId;

        /// <summary>
        /// Gets the ability description string ID for the corresponding ability.
        /// 
        /// r0: ability ID
        /// return: string ID
        /// </summary>
        public int GetAbilityDescStringId
        {
            get
            {
                if (f_getAbilityDescStringId)
                    return _getAbilityDescStringId;
                _getAbilityDescStringId = (int) (330868);
                f_getAbilityDescStringId = true;
                return _getAbilityDescStringId;
            }
        }
        private bool f_readMonsterInfoFromSave;
        private int _readMonsterInfoFromSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: start_address
        /// r1: total_length
        /// </summary>
        public int ReadMonsterInfoFromSave
        {
            get
            {
                if (f_readMonsterInfoFromSave)
                    return _readMonsterInfoFromSave;
                _readMonsterInfoFromSave = (int) (365984);
                f_readMonsterInfoFromSave = true;
                return _readMonsterInfoFromSave;
            }
        }
        private bool f_removeAllItems;
        private int _removeAllItems;

        /// <summary>
        /// WARNING! Does not remove from party items
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int RemoveAllItems
        {
            get
            {
                if (f_removeAllItems)
                    return _removeAllItems;
                _removeAllItems = (int) (63568);
                f_removeAllItems = true;
                return _removeAllItems;
            }
        }
        private bool f_isExpEnabledInDungeon;
        private int _isExpEnabledInDungeon;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon_id
        /// return: bool
        /// </summary>
        public int IsExpEnabledInDungeon
        {
            get
            {
                if (f_isExpEnabledInDungeon)
                    return _isExpEnabledInDungeon;
                _isExpEnabledInDungeon = (int) (334420);
                f_isExpEnabledInDungeon = true;
                return _isExpEnabledInDungeon;
            }
        }
        private bool f_removeEquivItemNoHole;
        private int _removeEquivItemNoHole;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_ptr
        /// return: ?
        /// </summary>
        public int RemoveEquivItemNoHole
        {
            get
            {
                if (f_removeEquivItemNoHole)
                    return _removeEquivItemNoHole;
                _removeEquivItemNoHole = (int) (63144);
                f_removeEquivItemNoHole = true;
                return _removeEquivItemNoHole;
            }
        }
        private bool f_removeHeldItemNoHole;
        private int _removeHeldItemNoHole;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: held_index
        /// </summary>
        public int RemoveHeldItemNoHole
        {
            get
            {
                if (f_removeHeldItemNoHole)
                    return _removeHeldItemNoHole;
                _removeHeldItemNoHole = (int) (62716);
                f_removeHeldItemNoHole = true;
                return _removeHeldItemNoHole;
            }
        }
        private bool f_closeAlertBox;
        private int _closeAlertBox;

        /// <summary>
        /// Closes a window created with CreateAlertBox.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseAlertBox
        {
            get
            {
                if (f_closeAlertBox)
                    return _closeAlertBox;
                _closeAlertBox = (int) (197432);
                f_closeAlertBox = true;
                return _closeAlertBox;
            }
        }
        private bool f_incrementNbEvolutions;
        private int _incrementNbEvolutions;

        /// <summary>
        /// Increments by 1 the number of evolutions.
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbEvolutions
        {
            get
            {
                if (f_incrementNbEvolutions)
                    return _incrementNbEvolutions;
                _incrementNbEvolutions = (int) (327700);
                f_incrementNbEvolutions = true;
                return _incrementNbEvolutions;
            }
        }
        private bool f_readQuickSaveInfo;
        private int _readQuickSaveInfo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// r1: size
        /// return: status code
        /// </summary>
        public int ReadQuickSaveInfo
        {
            get
            {
                if (f_readQuickSaveInfo)
                    return _readQuickSaveInfo;
                _readQuickSaveInfo = (int) (301408);
                f_readQuickSaveInfo = true;
                return _readQuickSaveInfo;
            }
        }
        private bool f_getTypeStringId;
        private int _getTypeStringId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: type ID
        /// return: string ID
        /// </summary>
        public int GetTypeStringId
        {
            get
            {
                if (f_getTypeStringId)
                    return _getTypeStringId;
                _getTypeStringId = (int) (330888);
                f_getTypeStringId = true;
                return _getTypeStringId;
            }
        }
        private bool f_isSoundMove;
        private int _isSoundMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move
        /// return: bool
        /// </summary>
        public int IsSoundMove
        {
            get
            {
                if (f_isSoundMove)
                    return _isSoundMove;
                _isSoundMove = (int) (81412);
                f_isSoundMove = true;
                return _isSoundMove;
            }
        }
        private bool f_analyzeText;
        private int _analyzeText;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// return: ?
        /// </summary>
        public int AnalyzeText
        {
            get
            {
                if (f_analyzeText)
                    return _analyzeText;
                _analyzeText = (int) (134944);
                f_analyzeText = true;
                return _analyzeText;
            }
        }
        private bool f_getItemIndex;
        private int _getItemIndex;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_ptr
        /// return: index
        /// </summary>
        public int GetItemIndex
        {
            get
            {
                if (f_getItemIndex)
                    return _getItemIndex;
                _getItemIndex = (int) (61940);
                f_getItemIndex = true;
                return _getItemIndex;
            }
        }
        private bool f_getMovesetHmTmPtr;
        private int _getMovesetHmTmPtr;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// return: ?
        /// </summary>
        public int GetMovesetHmTmPtr
        {
            get
            {
                if (f_getMovesetHmTmPtr)
                    return _getMovesetHmTmPtr;
                _getMovesetHmTmPtr = (int) (80284);
                f_getMovesetHmTmPtr = true;
                return _getMovesetHmTmPtr;
            }
        }
        private bool f_getActiveTeamMember;
        private int _getActiveTeamMember;

        /// <summary>
        /// Returns a struct containing information about the active team member in the given slot index.
        /// 
        /// r0: roster index
        /// return: team member pointer, or null if index is -1
        /// </summary>
        public int GetActiveTeamMember
        {
            get
            {
                if (f_getActiveTeamMember)
                    return _getActiveTeamMember;
                _getActiveTeamMember = (int) (354056);
                f_getActiveTeamMember = true;
                return _getActiveTeamMember;
            }
        }
        private bool f_isNoLossPenaltyDungeon;
        private int _isNoLossPenaltyDungeon;

        /// <summary>
        /// Returns true if the specified dungeon shouldn't have a loss penalty.
        /// 
        /// If true you won't lose your money and items upon fainting. Also used to initialize dungeon_init::skip_faint_animation_flag.
        /// 
        /// Returns: True for DUNGEON_CRYSTAL_LAKE and DUNGEON_5TH_STATION_CLEARING, as well as for DUNGEON_DEEP_STAR_CAVE_TEAM_ROGUE if the ground variable SIDE01_BOSS2ND is 0; false otherwise.
        /// </summary>
        public int IsNoLossPenaltyDungeon
        {
            get
            {
                if (f_isNoLossPenaltyDungeon)
                    return _isNoLossPenaltyDungeon;
                _isNoLossPenaltyDungeon = (int) (324376);
                f_isNoLossPenaltyDungeon = true;
                return _isNoLossPenaltyDungeon;
            }
        }
        private bool f_getLearnableIqSkills;
        private int _getLearnableIqSkills;

        /// <summary>
        /// Determines the list of IQ skills that a given monster can learn given its IQ value.
        /// 
        /// The list of skills is written in the array specified in r0. The array has 69 slots in total. Unused slots are set to 0.
        /// 
        /// r0: [output] Array where the list of skills will be written
        /// r1: Monster species
        /// r2: Monster IQ
        /// return: Amount of skills written to the output array
        /// </summary>
        public int GetLearnableIqSkills
        {
            get
            {
                if (f_getLearnableIqSkills)
                    return _getLearnableIqSkills;
                _getLearnableIqSkills = (int) (364672);
                f_getLearnableIqSkills = true;
                return _getLearnableIqSkills;
            }
        }
        private bool f_createMonsterSummaryFromTeamMember;
        private int _createMonsterSummaryFromTeamMember;

        /// <summary>
        /// Creates a snapshot of the condition of a team_member struct in a monster_summary struct.
        /// 
        /// r0: [output] monster_summary
        /// r1: team_member
        /// r2: bool is leader
        /// </summary>
        public int CreateMonsterSummaryFromTeamMember
        {
            get
            {
                if (f_createMonsterSummaryFromTeamMember)
                    return _createMonsterSummaryFromTeamMember;
                _createMonsterSummaryFromTeamMember = (int) (373156);
                f_createMonsterSummaryFromTeamMember = true;
                return _createMonsterSummaryFromTeamMember;
            }
        }
        private bool f_bagHasExclusiveItemTypeForMonster;
        private int _bagHasExclusiveItemTypeForMonster;

        /// <summary>
        /// Checks the bag for any exclusive item that applies to the monster or type(s) and gets the item ID.
        /// 
        /// r0: excl_type
        /// r1: monster ID
        /// r2: type ID 1
        /// r3: type ID 2
        /// return: exclusive item ID
        /// </summary>
        public int BagHasExclusiveItemTypeForMonster
        {
            get
            {
                if (f_bagHasExclusiveItemTypeForMonster)
                    return _bagHasExclusiveItemTypeForMonster;
                _bagHasExclusiveItemTypeForMonster = (int) (70016);
                f_bagHasExclusiveItemTypeForMonster = true;
                return _bagHasExclusiveItemTypeForMonster;
            }
        }
        private bool f_applyGinsengToGroundMonster;
        private int _applyGinsengToGroundMonster;

        /// <summary>
        /// Attempts to apply a ginseng boost to the highest valid move that the ground monster knows.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] move ID
        /// r2: [output] move boost
        /// return: actual move boost
        /// </summary>
        public int ApplyGinsengToGroundMonster
        {
            get
            {
                if (f_applyGinsengToGroundMonster)
                    return _applyGinsengToGroundMonster;
                _applyGinsengToGroundMonster = (int) (71328);
                f_applyGinsengToGroundMonster = true;
                return _applyGinsengToGroundMonster;
            }
        }
        private bool f_nitroMain;
        private int _nitroMain;

        /// <summary>
        /// Entrypoint into NitroSDK, the DS devkit library.
        /// </summary>
        public int NitroMain
        {
            get
            {
                if (f_nitroMain)
                    return _nitroMain;
                _nitroMain = (int) (3180);
                f_nitroMain = true;
                return _nitroMain;
            }
        }
        private bool f_copyBitsFrom;
        private int _copyBitsFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// r1: buffer_read
        /// r2: nb_bits
        /// </summary>
        public int CopyBitsFrom
        {
            get
            {
                if (f_copyBitsFrom)
                    return _copyBitsFrom;
                _copyBitsFrom = (int) (331128);
                f_copyBitsFrom = true;
                return _copyBitsFrom;
            }
        }
        private bool f_getNbSkyGiftsSent;
        private int _getNbSkyGiftsSent;

        /// <summary>
        /// Gets the number of Sky Gifts sent.
        /// 
        /// return: the number of Sky Gifts sent
        /// </summary>
        public int GetNbSkyGiftsSent
        {
            get
            {
                if (f_getNbSkyGiftsSent)
                    return _getNbSkyGiftsSent;
                _getNbSkyGiftsSent = (int) (328464);
                f_getNbSkyGiftsSent = true;
                return _getNbSkyGiftsSent;
            }
        }
        private bool f_setParentMenuState7;
        private int _setParentMenuState7;

        /// <summary>
        /// Sets the state of a parent menu to 7.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetParentMenuState7
        {
            get
            {
                if (f_setParentMenuState7)
                    return _setParentMenuState7;
                _setParentMenuState7 = (int) (175516);
                f_setParentMenuState7 = true;
                return _setParentMenuState7;
            }
        }
        private bool f_removeItemByIdAndStackNoHole;
        private int _removeItemByIdAndStackNoHole;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_ptr
        /// return: ?
        /// </summary>
        public int RemoveItemByIdAndStackNoHole
        {
            get
            {
                if (f_removeItemByIdAndStackNoHole)
                    return _removeItemByIdAndStackNoHole;
                _removeItemByIdAndStackNoHole = (int) (62844);
                f_removeItemByIdAndStackNoHole = true;
                return _removeItemByIdAndStackNoHole;
            }
        }
        private bool f_loadWteFromFileDirectory;
        private int _loadWteFromFileDirectory;

        /// <summary>
        /// Loads a SIR0-wrapped WTE file from a file directory, and returns a handle to it
        /// 
        /// r0: [output] pointer to wte handle
        /// r1: file directory id
        /// r2: file index
        /// r3: malloc flags
        /// </summary>
        public int LoadWteFromFileDirectory
        {
            get
            {
                if (f_loadWteFromFileDirectory)
                    return _loadWteFromFileDirectory;
                _loadWteFromFileDirectory = (int) (122720);
                f_loadWteFromFileDirectory = true;
                return _loadWteFromFileDirectory;
            }
        }
        private bool f_setAdvancedTextBoxField0x1C2;
        private int _setAdvancedTextBoxField0x1C2;

        /// <summary>
        /// Sets advanced_text_box::field_0x1c2 to 1.
        /// 
        /// r0: window_id
        /// </summary>
        public int SetAdvancedTextBoxField0x1C2
        {
            get
            {
                if (f_setAdvancedTextBoxField0x1C2)
                    return _setAdvancedTextBoxField0x1C2;
                _setAdvancedTextBoxField0x1C2 = (int) (199472);
                f_setAdvancedTextBoxField0x1C2 = true;
                return _setAdvancedTextBoxField0x1C2;
            }
        }
        private bool f_getTurnLimit;
        private int _getTurnLimit;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: turn limit
        /// </summary>
        public int GetTurnLimit
        {
            get
            {
                if (f_getTurnLimit)
                    return _getTurnLimit;
                _getTurnLimit = (int) (333288);
                f_getTurnLimit = true;
                return _getTurnLimit;
            }
        }
        private bool f_canEnemyEvolve;
        private int _canEnemyEvolve;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int CanEnemyEvolve
        {
            get
            {
                if (f_canEnemyEvolve)
                    return _canEnemyEvolve;
                _canEnemyEvolve = (int) (333624);
                f_canEnemyEvolve = true;
                return _canEnemyEvolve;
            }
        }
        private bool f_checkDebugMenuField0x1A4;
        private int _checkDebugMenuField0x1A4;

        /// <summary>
        /// Checks if debug_menu::field_0x1a4 is 0.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int CheckDebugMenuField0x1A4
        {
            get
            {
                if (f_checkDebugMenuField0x1A4)
                    return _checkDebugMenuField0x1A4;
                _checkDebugMenuField0x1A4 = (int) (188984);
                f_checkDebugMenuField0x1A4 = true;
                return _checkDebugMenuField0x1A4;
            }
        }
        private bool f_getSpeciesString;
        private int _getSpeciesString;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dst_ptr
        /// r1: id
        /// </summary>
        public int GetSpeciesString
        {
            get
            {
                if (f_getSpeciesString)
                    return _getSpeciesString;
                _getSpeciesString = (int) (337976);
                f_getSpeciesString = true;
                return _getSpeciesString;
            }
        }
        private bool f_createDialogueBox;
        private int _createDialogueBox;

        /// <summary>
        /// Creates a window containing text that is gradually revealed via scrolling, and pages on overflow. Also see struct dialogue_box.
        /// 
        /// This is primarily used for character dialogue, hence the name. However, it can also be used for other types of messages. The defining feature of this window type is the scrolling/paging behavior.
        /// 
        /// If window_params is NULL, DIALOGUE_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// r0: window_params
        /// return: window_id
        /// </summary>
        public int CreateDialogueBox
        {
            get
            {
                if (f_createDialogueBox)
                    return _createDialogueBox;
                _createDialogueBox = (int) (193444);
                f_createDialogueBox = true;
                return _createDialogueBox;
            }
        }
        private bool f_getPartner;
        private int _getPartner;

        /// <summary>
        /// Returns the ground monster data of the partner.
        /// 
        /// return: ground monster pointer
        /// </summary>
        public int GetPartner
        {
            get
            {
                if (f_getPartner)
                    return _getPartner;
                _getPartner = (int) (350996);
                f_getPartner = true;
                return _getPartner;
            }
        }
        private bool f_initAnimationControl;
        private int _initAnimationControl;

        /// <summary>
        /// Initialize the animation_control structure
        /// 
        /// r0: animation_control
        /// </summary>
        public int InitAnimationControl
        {
            get
            {
                if (f_initAnimationControl)
                    return _initAnimationControl;
                _initAnimationControl = (int) (114924);
                f_initAnimationControl = true;
                return _initAnimationControl;
            }
        }
        private bool f_disableAllIqSkills;
        private int _disableAllIqSkills;

        /// <summary>
        /// Disables all IQ skills in the bitarray.
        /// 
        /// r0: Pointer to the bitarray containing the list of enabled IQ skills
        /// </summary>
        public int DisableAllIqSkills
        {
            get
            {
                if (f_disableAllIqSkills)
                    return _disableAllIqSkills;
                _disableAllIqSkills = (int) (365064);
                f_disableAllIqSkills = true;
                return _disableAllIqSkills;
            }
        }
        private bool f_getMoveCategory;
        private int _getMoveCategory;

        /// <summary>
        /// Gets a move's category (physical, special, status).
        /// 
        /// r0: move ID
        /// return: move category enum
        /// </summary>
        public int GetMoveCategory
        {
            get
            {
                if (f_getMoveCategory)
                    return _getMoveCategory;
                _getMoveCategory = (int) (86640);
                f_getMoveCategory = true;
                return _getMoveCategory;
            }
        }
        private bool f_getDungeonResultMsg;
        private int _getDungeonResultMsg;

        /// <summary>
        /// Gets the message that is shown on the dungeon results (&quot;The Last Outing&quot;) screen, right after the leader's name.
        /// 
        /// r0: Damage source value to use when displaying the cause of fainting or the result of the expedition
        /// r1: [output] Buffer where the resulting message will be stored
        /// r2: Buffer size
        /// r3: (?) Seems to point to a buffer
        /// </summary>
        public int GetDungeonResultMsg
        {
            get
            {
                if (f_getDungeonResultMsg)
                    return _getDungeonResultMsg;
                _getDungeonResultMsg = (int) (50564);
                f_getDungeonResultMsg = true;
                return _getDungeonResultMsg;
            }
        }
        private bool f_isParentMenuActive;
        private int _isParentMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a parent menu is something other than 8 or 9.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsParentMenuActive
        {
            get
            {
                if (f_isParentMenuActive)
                    return _isParentMenuActive;
                _isParentMenuActive = (int) (175668);
                f_isParentMenuActive = true;
                return _isParentMenuActive;
            }
        }
        private bool f_getMoveAiWeight;
        private int _getMoveAiWeight;

        /// <summary>
        /// Gets the AI weight of a move
        /// 
        /// r0: Pointer to move data
        /// return: AI weight of the move
        /// </summary>
        public int GetMoveAiWeight
        {
            get
            {
                if (f_getMoveAiWeight)
                    return _getMoveAiWeight;
                _getMoveAiWeight = (int) (80436);
                f_getMoveAiWeight = true;
                return _getMoveAiWeight;
            }
        }
        private bool f_isItemInTreasureBoxes;
        private int _isItemInTreasureBoxes;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsItemInTreasureBoxes
        {
            get
            {
                if (f_isItemInTreasureBoxes)
                    return _isItemInTreasureBoxes;
                _isItemInTreasureBoxes = (int) (61460);
                f_isItemInTreasureBoxes = true;
                return _isItemInTreasureBoxes;
            }
        }
        private bool f_switchAnimationControlToNextFrame;
        private int _switchAnimationControlToNextFrame;

        /// <summary>
        /// Handle switching to the next frame of an animation control, including looping.
        /// 
        /// r0: animation_control
        /// </summary>
        public int SwitchAnimationControlToNextFrame
        {
            get
            {
                if (f_switchAnimationControlToNextFrame)
                    return _switchAnimationControlToNextFrame;
                _switchAnimationControlToNextFrame = (int) (115956);
                f_switchAnimationControlToNextFrame = true;
                return _switchAnimationControlToNextFrame;
            }
        }
        private bool f_sortItemsInStorage;
        private int _sortItemsInStorage;

        /// <summary>
        /// Sorts the item in storage by making converting them into normal items in a temporary list and
        /// using SortItemList on them. After, it puts the list of items back into storage. This may also have
        /// another use or do something broader than just sorting because it outputs a bool array.
        /// 
        /// r0: [output] bool array?
        /// r1: number of items to sort (usually just the current size of storage)
        /// </summary>
        public int SortItemsInStorage
        {
            get
            {
                if (f_sortItemsInStorage)
                    return _sortItemsInStorage;
                _sortItemsInStorage = (int) (66764);
                f_sortItemsInStorage = true;
                return _sortItemsInStorage;
            }
        }
        private bool f_createAlertBox;
        private int _createAlertBox;

        /// <summary>
        /// Creates a window containing text that will disappear after a certain amount of time. Also see struct alert_box.
        /// 
        /// This is only used in dungeon mode, for the &quot;popup alert&quot; messages about things happening in the dungeon (which will also be accessible in the message logs).
        /// 
        /// If window_params is NULL, ALERT_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// r0: window_params
        /// return: window_id
        /// </summary>
        public int CreateAlertBox
        {
            get
            {
                if (f_createAlertBox)
                    return _createAlertBox;
                _createAlertBox = (int) (197284);
                f_createAlertBox = true;
                return _createAlertBox;
            }
        }
        private bool f_isTrappingMove;
        private int _isTrappingMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsTrappingMove
        {
            get
            {
                if (f_isTrappingMove)
                    return _isTrappingMove;
                _isTrappingMove = (int) (85604);
                f_isTrappingMove = true;
                return _isTrappingMove;
            }
        }
        private bool f_getMoveBasePower;
        private int _getMoveBasePower;

        /// <summary>
        /// Gets the base power of a move from the move data table.
        /// 
        /// r0: move pointer
        /// return: base power
        /// </summary>
        public int GetMoveBasePower
        {
            get
            {
                if (f_getMoveBasePower)
                    return _getMoveBasePower;
                _getMoveBasePower = (int) (80500);
                f_getMoveBasePower = true;
                return _getMoveBasePower;
            }
        }
        private bool f_setVictoriesOnOneFloor;
        private int _setVictoriesOnOneFloor;

        /// <summary>
        /// Sets the record of victories on one floor.
        /// 
        /// r0: the new record of victories
        /// </summary>
        public int SetVictoriesOnOneFloor
        {
            get
            {
                if (f_setVictoriesOnOneFloor)
                    return _setVictoriesOnOneFloor;
                _setVictoriesOnOneFloor = (int) (327916);
                f_setVictoriesOnOneFloor = true;
                return _setVictoriesOnOneFloor;
            }
        }
        private bool f_updateFadeStatus;
        private int _updateFadeStatus;

        /// <summary>
        /// Updates the given screen_fade struct to initiate a fade for example.
        /// 
        /// In addition to initiating a fade this is called when a fade out is complete to set a flag for that in the struct.
        /// 
        /// r0: screen_fade
        /// r1: probably the type of the fade
        /// r2: duration
        /// </summary>
        public int UpdateFadeStatus
        {
            get
            {
                if (f_updateFadeStatus)
                    return _updateFadeStatus;
                _updateFadeStatus = (int) (47640);
                f_updateFadeStatus = true;
                return _updateFadeStatus;
            }
        }
        private bool f_strcmpMonsterName;
        private int _strcmpMonsterName;

        /// <summary>
        /// Checks if the string_buffer matches the name of the species
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: string_buffer
        /// r1: monster ID
        /// return: bool
        /// </summary>
        public int StrcmpMonsterName
        {
            get
            {
                if (f_strcmpMonsterName)
                    return _strcmpMonsterName;
                _strcmpMonsterName = (int) (340780);
                f_strcmpMonsterName = true;
                return _strcmpMonsterName;
            }
        }
        private bool f_manipMoves2v2;
        private int _manipMoves2v2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ManipMoves2v2
        {
            get
            {
                if (f_manipMoves2v2)
                    return _manipMoves2v2;
                _manipMoves2v2 = (int) (83436);
                f_manipMoves2v2 = true;
                return _manipMoves2v2;
            }
        }
        private bool f_iqSkillFlagTest;
        private int _iqSkillFlagTest;

        /// <summary>
        /// Tests whether an IQ skill with a given ID is active.
        /// 
        /// r0: IQ skill bitvector to test
        /// r1: IQ skill ID
        /// return: bool
        /// </summary>
        public int IqSkillFlagTest
        {
            get
            {
                if (f_iqSkillFlagTest)
                    return _iqSkillFlagTest;
                _iqSkillFlagTest = (int) (365184);
                f_iqSkillFlagTest = true;
                return _iqSkillFlagTest;
            }
        }
        private bool f_fixedPoint32To64;
        private int _fixedPoint32To64;

        /// <summary>
        /// Converts a 32-bit fixed-point number (8 fraction bits) to a 64-bit fixed point number (16 fraction bits). Sign-extends as necessary.
        /// 
        /// r0: [output] 64-bit fixed-point number
        /// r1: 32-bit signed fixed-point number
        /// </summary>
        public int FixedPoint32To64
        {
            get
            {
                if (f_fixedPoint32To64)
                    return _fixedPoint32To64;
                _fixedPoint32To64 = (int) (7380);
                f_fixedPoint32To64 = true;
                return _fixedPoint32To64;
            }
        }
        private bool f_countNbItemsOfTypeInBag;
        private int _countNbItemsOfTypeInBag;

        /// <summary>
        /// Returns the number of items of the given kind in the bag
        /// 
        /// r0: item ID
        /// return: count
        /// </summary>
        public int CountNbItemsOfTypeInBag
        {
            get
            {
                if (f_countNbItemsOfTypeInBag)
                    return _countNbItemsOfTypeInBag;
                _countNbItemsOfTypeInBag = (int) (61172);
                f_countNbItemsOfTypeInBag = true;
                return _countNbItemsOfTypeInBag;
            }
        }
        private bool f_getStatBoostsForMonsterSummary;
        private int _getStatBoostsForMonsterSummary;

        /// <summary>
        /// Gets the stat boosts from held items, exclusive items, and iq skills and stores them into the
        /// monster_summary struct.
        /// 
        /// r0: monster_summary
        /// r1: enum monster_id monster_id
        /// r2: pointer to held item
        /// r3: iq
        /// stack[0]: bool if Klutz is active
        /// </summary>
        public int GetStatBoostsForMonsterSummary
        {
            get
            {
                if (f_getStatBoostsForMonsterSummary)
                    return _getStatBoostsForMonsterSummary;
                _getStatBoostsForMonsterSummary = (int) (370636);
                f_getStatBoostsForMonsterSummary = true;
                return _getStatBoostsForMonsterSummary;
            }
        }
        private bool f_loadSynthBin;
        private int _loadSynthBin;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int LoadSynthBin
        {
            get
            {
                if (f_loadSynthBin)
                    return _loadSynthBin;
                _loadSynthBin = (int) (76680);
                f_loadSynthBin = true;
                return _loadSynthBin;
            }
        }
        private bool f_initDungeonInit;
        private int _initDungeonInit;

        /// <summary>
        /// Initializes the dungeon_init struct before entering a dungeon.
        /// 
        /// r0: [output] Pointer to the struct to init
        /// r1: Dungeon ID
        /// </summary>
        public int InitDungeonInit
        {
            get
            {
                if (f_initDungeonInit)
                    return _initDungeonInit;
                _initDungeonInit = (int) (322964);
                f_initDungeonInit = true;
                return _initDungeonInit;
            }
        }
        private bool f_writeMonsterInfoToSave;
        private int _writeMonsterInfoToSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: start_address
        /// r1: total_length
        /// return: ?
        /// </summary>
        public int WriteMonsterInfoToSave
        {
            get
            {
                if (f_writeMonsterInfoToSave)
                    return _writeMonsterInfoToSave;
                _writeMonsterInfoToSave = (int) (365716);
                f_writeMonsterInfoToSave = true;
                return _writeMonsterInfoToSave;
            }
        }
        private bool f_teamSelectionMenuGetItem;
        private int _teamSelectionMenuGetItem;

        /// <summary>
        /// Gets the menu item text (member name) for a given team member for a team selection menu.
        /// 
        /// r0: buffer
        /// r1: team member index
        /// return: menu item text (points into buffer)
        /// </summary>
        public int TeamSelectionMenuGetItem
        {
            get
            {
                if (f_teamSelectionMenuGetItem)
                    return _teamSelectionMenuGetItem;
                _teamSelectionMenuGetItem = (int) (240216);
                f_teamSelectionMenuGetItem = true;
                return _teamSelectionMenuGetItem;
            }
        }
        private bool f_setAdventureLogCompleted;
        private int _setAdventureLogCompleted;

        /// <summary>
        /// Marks one of the adventure log entry as completed.
        /// 
        /// r0: entry ID
        /// </summary>
        public int SetAdventureLogCompleted
        {
            get
            {
                if (f_setAdventureLogCompleted)
                    return _setAdventureLogCompleted;
                _setAdventureLogCompleted = (int) (327380);
                f_setAdventureLogCompleted = true;
                return _setAdventureLogCompleted;
            }
        }
        private bool f_isRealMove;
        private int _isRealMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsRealMove
        {
            get
            {
                if (f_isRealMove)
                    return _isRealMove;
                _isRealMove = (int) (85772);
                f_isRealMove = true;
                return _isRealMove;
            }
        }
        private bool f_dungeonRequestsDoneWrapper;
        private int _dungeonRequestsDoneWrapper;

        /// <summary>
        /// Calls DungeonRequestsDone with the second argument set to false.
        /// 
        /// r0: ?
        /// return: number of mission completed
        /// </summary>
        public int DungeonRequestsDoneWrapper
        {
            get
            {
                if (f_dungeonRequestsDoneWrapper)
                    return _dungeonRequestsDoneWrapper;
                _dungeonRequestsDoneWrapper = (int) (389516);
                f_dungeonRequestsDoneWrapper = true;
                return _dungeonRequestsDoneWrapper;
            }
        }
        private bool f_itemZInit;
        private int _itemZInit;

        /// <summary>
        /// Zero-initializes an item struct.
        /// 
        /// r0: item
        /// </summary>
        public int ItemZInit
        {
            get
            {
                if (f_itemZInit)
                    return _itemZInit;
                _itemZInit = (int) (55460);
                f_itemZInit = true;
                return _itemZInit;
            }
        }
        private bool f_gendersNotEqualNotGenderless;
        private int _gendersNotEqualNotGenderless;

        /// <summary>
        /// Checks if the genders for two monster IDs are not equal. Always returns false
        /// if either gender is GENDER_GENDERLESS.
        /// 
        /// r0: id1
        /// r1: id2
        /// return: bool
        /// </summary>
        public int GendersNotEqualNotGenderless
        {
            get
            {
                if (f_gendersNotEqualNotGenderless)
                    return _gendersNotEqualNotGenderless;
                _gendersNotEqualNotGenderless = (int) (348740);
                f_gendersNotEqualNotGenderless = true;
                return _gendersNotEqualNotGenderless;
            }
        }
        private bool f_clearWindow;
        private int _clearWindow;

        /// <summary>
        /// Clears the window, at least in the case of a text box.
        /// 
        /// The low number of XREFs makes it seem like there might be more such functions.
        /// 
        /// r0: window_id
        /// </summary>
        public int ClearWindow
        {
            get
            {
                if (f_clearWindow)
                    return _clearWindow;
                _clearWindow = (int) (163404);
                f_clearWindow = true;
                return _clearWindow;
            }
        }
        private bool f_sortItemsInBag;
        private int _sortItemsInBag;

        /// <summary>
        /// Sorts the current items in the item bag but first checks if any Poke is in the bag to remove. If
        /// Poke is found, add it to money carried.
        /// 
        /// No params.
        /// </summary>
        public int SortItemsInBag
        {
            get
            {
                if (f_sortItemsInBag)
                    return _sortItemsInBag;
                _sortItemsInBag = (int) (64716);
                f_sortItemsInBag = true;
                return _sortItemsInBag;
            }
        }
        private bool f_applyIronBoostToGroundMonster;
        private int _applyIronBoostToGroundMonster;

        /// <summary>
        /// Applies the defense boost from Iron to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted defense boost, if not NULL
        /// return: actual defense boost
        /// </summary>
        public int ApplyIronBoostToGroundMonster
        {
            get
            {
                if (f_applyIronBoostToGroundMonster)
                    return _applyIronBoostToGroundMonster;
                _applyIronBoostToGroundMonster = (int) (71724);
                f_applyIronBoostToGroundMonster = true;
                return _applyIronBoostToGroundMonster;
            }
        }
        private bool f_getAvailableItemDeliveryList;
        private int _getAvailableItemDeliveryList;

        /// <summary>
        /// Iterates through ITEM_DELIVERY_TABLE and checks if each entry is valid to be used in delivery missions.
        /// 
        /// r0: item_buffer
        /// return: Number of deliverable items for a mission
        /// </summary>
        public int GetAvailableItemDeliveryList
        {
            get
            {
                if (f_getAvailableItemDeliveryList)
                    return _getAvailableItemDeliveryList;
                _getAvailableItemDeliveryList = (int) (407588);
                f_getAvailableItemDeliveryList = true;
                return _getAvailableItemDeliveryList;
            }
        }
        private bool f_closeParentMenu;
        private int _closeParentMenu;

        /// <summary>
        /// Closes a window created with CreateParentMenu or CreateParentMenuFromStringIds.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseParentMenu
        {
            get
            {
                if (f_closeParentMenu)
                    return _closeParentMenu;
                _closeParentMenu = (int) (175536);
                f_closeParentMenu = true;
                return _closeParentMenu;
            }
        }
        private bool f_getMonsterGenderVeneer;
        private int _getMonsterGenderVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for GetMonsterGender.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: monster id
        /// return: monster gender
        /// </summary>
        public int GetMonsterGenderVeneer
        {
            get
            {
                if (f_getMonsterGenderVeneer)
                    return _getMonsterGenderVeneer;
                _getMonsterGenderVeneer = (int) (346844);
                f_getMonsterGenderVeneer = true;
                return _getMonsterGenderVeneer;
            }
        }
        private bool f_getAllocArenaDefault;
        private int _getAllocArenaDefault;

        /// <summary>
        /// The default function for retrieving the arena for memory allocations. This function always just returns the initial arena pointer.
        /// 
        /// r0: initial memory arena pointer, or null
        /// r1: flags (see MemAlloc)
        /// return: memory arena pointer, or null
        /// </summary>
        public int GetAllocArenaDefault
        {
            get
            {
                if (f_getAllocArenaDefault)
                    return _getAllocArenaDefault;
                _getAllocArenaDefault = (int) (3776);
                f_getAllocArenaDefault = true;
                return _getAllocArenaDefault;
            }
        }
        private bool f_deleteAllPossibleDungeonsList;
        private int _deleteAllPossibleDungeonsList;

        /// <summary>
        /// If MISSION_DUNGEON_LIST_PTR is not null, frees its heap-allocated list and nulls MISSION_DUNGEON_LIST_PTR and MISSION_DUNGEON_COUNT.
        /// 
        /// No params.
        /// </summary>
        public int DeleteAllPossibleDungeonsList
        {
            get
            {
                if (f_deleteAllPossibleDungeonsList)
                    return _deleteAllPossibleDungeonsList;
                _deleteAllPossibleDungeonsList = (int) (392220);
                f_deleteAllPossibleDungeonsList = true;
                return _deleteAllPossibleDungeonsList;
            }
        }
        private bool f_initWorldMapScriptVars;
        private int _initWorldMapScriptVars;

        /// <summary>
        /// Initializes the WORLD_MAP_* script variable values (IDs 0x55-0x57).
        /// 
        /// No params.
        /// </summary>
        public int InitWorldMapScriptVars
        {
            get
            {
                if (f_initWorldMapScriptVars)
                    return _initWorldMapScriptVars;
                _initWorldMapScriptVars = (int) (315584);
                f_initWorldMapScriptVars = true;
                return _initWorldMapScriptVars;
            }
        }
        private bool f_getStringFromFile;
        private int _getStringFromFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: Buffer
        /// r1: String ID
        /// </summary>
        public int GetStringFromFile
        {
            get
            {
                if (f_getStringFromFile)
                    return _getStringFromFile;
                _getStringFromFile = (int) (154196);
                f_getStringFromFile = true;
                return _getStringFromFile;
            }
        }
        private bool f_dataTransferInit;
        private int _dataTransferInit;

        /// <summary>
        /// Initializes data transfer mode to get data from the ROM cartridge.
        /// 
        /// No params.
        /// </summary>
        public int DataTransferInit
        {
            get
            {
                if (f_dataTransferInit)
                    return _dataTransferInit;
                _dataTransferInit = (int) (33128);
                f_dataTransferInit = true;
                return _dataTransferInit;
            }
        }
        private bool f_validateNormalChallengeMission;
        private int _validateNormalChallengeMission;

        /// <summary>
        /// Validates a normal (non-legendary) challenge letter mission by checking whether its client (leader), target (second member), and outlaw_backup_species (third member) match those of some mission_rescue_bin struct (alongside some other conditions).
        /// 
        /// r0: mission_template struct pointer
        /// r1: mission struct pointer
        /// return: bool
        /// </summary>
        public int ValidateNormalChallengeMission
        {
            get
            {
                if (f_validateNormalChallengeMission)
                    return _validateNormalChallengeMission;
                _validateNormalChallengeMission = (int) (396160);
                f_validateNormalChallengeMission = true;
                return _validateNormalChallengeMission;
            }
        }
        private bool f_fileInitVeneer;
        private int _fileInitVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for FileInit.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: file_stream pointer
        /// </summary>
        public int FileInitVeneer
        {
            get
            {
                if (f_fileInitVeneer)
                    return _fileInitVeneer;
                _fileInitVeneer = (int) (33284);
                f_fileInitVeneer = true;
                return _fileInitVeneer;
            }
        }
        private bool f_setTeamSetupHeroAndPartnerOnly;
        private int _setTeamSetupHeroAndPartnerOnly;

        /// <summary>
        /// Implements SPECIAL_PROC_SET_TEAM_SETUP_HERO_AND_PARTNER_ONLY (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int SetTeamSetupHeroAndPartnerOnly
        {
            get
            {
                if (f_setTeamSetupHeroAndPartnerOnly)
                    return _setTeamSetupHeroAndPartnerOnly;
                _setTeamSetupHeroAndPartnerOnly = (int) (355656);
                f_setTeamSetupHeroAndPartnerOnly = true;
                return _setTeamSetupHeroAndPartnerOnly;
            }
        }
        private bool f_isUnown;
        private int _isUnown;

        /// <summary>
        /// Checks if a monster ID is an Unown.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsUnown
        {
            get
            {
                if (f_isUnown)
                    return _isUnown;
                _isUnown = (int) (347652);
                f_isUnown = true;
                return _isUnown;
            }
        }
        private bool f_render3d64Rectangle;
        private int _render3d64Rectangle;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[2]. Renders a render_3d_element_64 with type RENDER64_RECTANGLE.
        /// 
        /// Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_RECTANGLE.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64Rectangle
        {
            get
            {
                if (f_render3d64Rectangle)
                    return _render3d64Rectangle;
                _render3d64Rectangle = (int) (127224);
                f_render3d64Rectangle = true;
                return _render3d64Rectangle;
            }
        }
        private bool f_getLoadedWanTableEntry;
        private int _getLoadedWanTableEntry;

        /// <summary>
        /// Look up a sprite with the provided pack_id and file_index in the wan table.
        /// 
        /// r0: wan_table_ptr
        /// r1: pack_id
        /// r2: file_index
        /// return: sprite id in the wan table, -1 if not found
        /// </summary>
        public int GetLoadedWanTableEntry
        {
            get
            {
                if (f_getLoadedWanTableEntry)
                    return _getLoadedWanTableEntry;
                _getLoadedWanTableEntry = (int) (119760);
                f_getLoadedWanTableEntry = true;
                return _getLoadedWanTableEntry;
            }
        }
        private bool f_getCurrentTeamNameString;
        private int _getCurrentTeamNameString;

        /// <summary>
        /// Returns the current team name with a check for special episodes and story progression. If the story
        /// has not progressed enough or the special episode is not for Team Charm, &quot;???&quot; will be displayed.
        /// During the Team Charm special episode, it will return &quot;Team Charm&quot;.
        /// 
        /// r0: [output] Pointer to the buffer where the string will be written
        /// r1: 0, 1 or 2???
        /// return: Pointer to the buffer where the string was written (in other words, the same value passed in r0)
        /// </summary>
        public int GetCurrentTeamNameString
        {
            get
            {
                if (f_getCurrentTeamNameString)
                    return _getCurrentTeamNameString;
                _getCurrentTeamNameString = (int) (151296);
                f_getCurrentTeamNameString = true;
                return _getCurrentTeamNameString;
            }
        }
        private bool f_openWaza;
        private int _openWaza;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: waza_id
        /// </summary>
        public int OpenWaza
        {
            get
            {
                if (f_openWaza)
                    return _openWaza;
                _openWaza = (int) (86844);
                f_openWaza = true;
                return _openWaza;
            }
        }
        private bool f_printBadgeMark;
        private int _printBadgeMark;

        /// <summary>
        /// Prints the specified badge mark on the screen.
        /// 
        /// The badge mark is shown when opening the menu in the overworld.
        /// 
        /// r0: Badge ID
        /// r1: X pos (unknown units, always 3)
        /// r2: Y pos (unknown units, always 18)
        /// r3: ? (always 3)
        /// </summary>
        public int PrintBadgeMark
        {
            get
            {
                if (f_printBadgeMark)
                    return _printBadgeMark;
                _printBadgeMark = (int) (173864);
                f_printBadgeMark = true;
                return _printBadgeMark;
            }
        }
        private bool f_sortItemList;
        private int _sortItemList;

        /// <summary>
        /// Attempts to combine stacks of throwable items, sort the list, and then remove empty items.
        /// Appears to use selection sort to sort the list in place.
        /// 
        /// r0: item array
        /// r1: number of items in array
        /// </summary>
        public int SortItemList
        {
            get
            {
                if (f_sortItemList)
                    return _sortItemList;
                _sortItemList = (int) (58408);
                f_sortItemList = true;
                return _sortItemList;
            }
        }
        private bool f_getNameString;
        private int _getNameString;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: name
        /// </summary>
        public int GetNameString
        {
            get
            {
                if (f_getNameString)
                    return _getNameString;
                _getNameString = (int) (338432);
                f_getNameString = true;
                return _getNameString;
            }
        }
        private bool f_memArenaAlloc;
        private int _memArenaAlloc;

        /// <summary>
        /// Allocates some memory on the heap and creates a new global memory arena with it.
        /// 
        /// The actual allocation part works similarly to the normal MemAlloc.
        /// 
        /// r0: desired parent memory arena, or null
        /// r1: length of the arena in bytes
        /// r2: maximum number of blocks that the arena can hold
        /// r3: flags (see MemAlloc)
        /// return: memory arena pointer
        /// </summary>
        public int MemArenaAlloc
        {
            get
            {
                if (f_memArenaAlloc)
                    return _memArenaAlloc;
                _memArenaAlloc = (int) (4508);
                f_memArenaAlloc = true;
                return _memArenaAlloc;
            }
        }
        private bool f_getGameMode;
        private int _getGameMode;

        /// <summary>
        /// Gets the value of GAME_MODE.
        /// 
        /// return: game mode
        /// </summary>
        public int GetGameMode
        {
            get
            {
                if (f_getGameMode)
                    return _getGameMode;
                _getGameMode = (int) (307960);
                f_getGameMode = true;
                return _getGameMode;
            }
        }
        private bool f_checkSimpleMenuField0x1A0;
        private int _checkSimpleMenuField0x1A0;

        /// <summary>
        /// Checks if simple_menu::field_0x1a0 is 0.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int CheckSimpleMenuField0x1A0
        {
            get
            {
                if (f_checkSimpleMenuField0x1A0)
                    return _checkSimpleMenuField0x1A0;
                _checkSimpleMenuField0x1A0 = (int) (178180);
                f_checkSimpleMenuField0x1A0 = true;
                return _checkSimpleMenuField0x1A0;
            }
        }
        private bool f_getChanceAsleep;
        private int _getChanceAsleep;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: chance asleep
        /// </summary>
        public int GetChanceAsleep
        {
            get
            {
                if (f_getChanceAsleep)
                    return _getChanceAsleep;
                _getChanceAsleep = (int) (338968);
                f_getChanceAsleep = true;
                return _getChanceAsleep;
            }
        }
        private bool f_joinedAtRangeCheck;
        private int _joinedAtRangeCheck;

        /// <summary>
        /// Returns whether a certain joined_at field value is between dungeon_id::DUNGEON_JOINED_AT_BIDOOF and dungeon_id::DUNGEON_DUMMY_0xE3.
        /// 
        /// Irdkwia's notes: IsSupportPokemon
        /// 
        /// r0: joined_at id
        /// return: bool
        /// </summary>
        public int JoinedAtRangeCheck
        {
            get
            {
                if (f_joinedAtRangeCheck)
                    return _joinedAtRangeCheck;
                _joinedAtRangeCheck = (int) (333768);
                f_joinedAtRangeCheck = true;
                return _joinedAtRangeCheck;
            }
        }
        private bool f_randRangeSafe;
        private int _randRangeSafe;

        /// <summary>
        /// Like RandRange, except reordering the inputs as needed, and explicitly masking out the upper 16 bits of the output from Rand16Bit (which should be zero anyway).
        /// 
        /// r0: x
        /// r1: y
        /// return: pseudorandom integer on the interval [min(x, y), max(x, y) - 1]
        /// </summary>
        public int RandRangeSafe
        {
            get
            {
                if (f_randRangeSafe)
                    return _randRangeSafe;
                _randRangeSafe = (int) (8984);
                f_randRangeSafe = true;
                return _randRangeSafe;
            }
        }
        private bool f_isSongOver;
        private int _isSongOver;

        /// <summary>
        /// True if the song that is currently being played has finished playing.
        /// 
        /// return: True if the current song is over
        /// </summary>
        public int IsSongOver
        {
            get
            {
                if (f_isSongOver)
                    return _isSongOver;
                _isSongOver = (int) (104684);
                f_isSongOver = true;
                return _isSongOver;
            }
        }
        private bool f_getExclusiveItemParameter;
        private int _getExclusiveItemParameter;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: ?
        /// </summary>
        public int GetExclusiveItemParameter
        {
            get
            {
                if (f_getExclusiveItemParameter)
                    return _getExclusiveItemParameter;
                _getExclusiveItemParameter = (int) (59576);
                f_getExclusiveItemParameter = true;
                return _getExclusiveItemParameter;
            }
        }
        private bool f_handleFades;
        private int _handleFades;

        /// <summary>
        /// Handles updating the screen_fade struct in all modes except dungeon mode.
        /// 
        /// Gets called every frame for both screens, analyzes the fade_struct and does appropriate actions. If there's a fade in progress, it calculates the brightness on the next frame and updates the structure accordingly.
        /// 
        /// r0: screen_fade
        /// return: bool
        /// </summary>
        public int HandleFades
        {
            get
            {
                if (f_handleFades)
                    return _handleFades;
                _handleFades = (int) (47760);
                f_handleFades = true;
                return _handleFades;
            }
        }
        private bool f_getOutlawLevel;
        private int _getOutlawLevel;

        /// <summary>
        /// Gets the level that should be used for outlaws for the given dungeon and floor
        /// 
        /// r0: Dungeon and floor
        /// return: Outlaw level
        /// </summary>
        public int GetOutlawLevel
        {
            get
            {
                if (f_getOutlawLevel)
                    return _getOutlawLevel;
                _getOutlawLevel = (int) (326596);
                f_getOutlawLevel = true;
                return _getOutlawLevel;
            }
        }
        private bool f_initMemAllocTableVeneer;
        private int _initMemAllocTableVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for InitMemAllocTable.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// No params.
        /// </summary>
        public int InitMemAllocTableVeneer
        {
            get
            {
                if (f_initMemAllocTableVeneer)
                    return _initMemAllocTableVeneer;
                _initMemAllocTableVeneer = (int) (12828);
                f_initMemAllocTableVeneer = true;
                return _initMemAllocTableVeneer;
            }
        }
        private bool f_showDialogueBox;
        private int _showDialogueBox;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: window_id
        /// </summary>
        public int ShowDialogueBox
        {
            get
            {
                if (f_showDialogueBox)
                    return _showDialogueBox;
                _showDialogueBox = (int) (194200);
                f_showDialogueBox = true;
                return _showDialogueBox;
            }
        }
        private bool f_disableAllInterrupts;
        private int _disableAllInterrupts;

        /// <summary>
        /// Sets the Interrupt Master Enable (IME) register to 0, which disables all CPU interrupts (even if enabled in the Interrupt Enable (IE) register).
        /// 
        /// See https://problemkaputt.de/gbatek.htm#dsiomaps.
        /// 
        /// return: old value in the IME register
        /// </summary>
        public int DisableAllInterrupts
        {
            get
            {
                if (f_disableAllInterrupts)
                    return _disableAllInterrupts;
                _disableAllInterrupts = (int) (14372);
                f_disableAllInterrupts = true;
                return _disableAllInterrupts;
            }
        }
        private bool f_setUnkAdvancedTextBoxWindowFn;
        private int _setUnkAdvancedTextBoxWindowFn;

        /// <summary>
        /// Sets the value of advanced_text_box::field_0x1b8 to the given function pointer.
        /// 
        /// r0: window_id
        /// r1: some function pointer?
        /// </summary>
        public int SetUnkAdvancedTextBoxWindowFn
        {
            get
            {
                if (f_setUnkAdvancedTextBoxWindowFn)
                    return _setUnkAdvancedTextBoxWindowFn;
                _setUnkAdvancedTextBoxWindowFn = (int) (200136);
                f_setUnkAdvancedTextBoxWindowFn = true;
                return _setUnkAdvancedTextBoxWindowFn;
            }
        }
        private bool f_setDebugFlag;
        private int _setDebugFlag;

        /// <summary>
        /// Should set the value of a debug flag. A no-op in the final binary.
        /// 
        /// r0: flag ID
        /// r1: flag value
        /// </summary>
        public int SetDebugFlag
        {
            get
            {
                if (f_setDebugFlag)
                    return _setDebugFlag;
                _setDebugFlag = (int) (49568);
                f_setDebugFlag = true;
                return _setDebugFlag;
            }
        }
        private bool f_isStorableItem;
        private int _isStorableItem;

        /// <summary>
        /// Checks if an item can be put into storage. Specifically checks for the Wonder Egg, Poke, and Used TMs. Used TMs
        /// likely can't be stored because the move the TM teaches would be lost when sent to storage.
        /// 
        /// r0: item_id
        /// return: bool
        /// </summary>
        public int IsStorableItem
        {
            get
            {
                if (f_isStorableItem)
                    return _isStorableItem;
                _isStorableItem = (int) (52528);
                f_isStorableItem = true;
                return _isStorableItem;
            }
        }
        private bool f_getItemNameFormatted;
        private int _getItemNameFormatted;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] name
        /// r1: item_id
        /// r2: flag
        /// r3: flag2
        /// </summary>
        public int GetItemNameFormatted
        {
            get
            {
                if (f_getItemNameFormatted)
                    return _getItemNameFormatted;
                _getItemNameFormatted = (int) (59732);
                f_getItemNameFormatted = true;
                return _getItemNameFormatted;
            }
        }
        private bool f_isCherrim;
        private int _isCherrim;

        /// <summary>
        /// Checks if a monster ID is a Cherrim form.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsCherrim
        {
            get
            {
                if (f_isCherrim)
                    return _isCherrim;
                _isCherrim = (int) (347816);
                f_isCherrim = true;
                return _isCherrim;
            }
        }
        private bool f_isMonsterNotNicknamed;
        private int _isMonsterNotNicknamed;

        /// <summary>
        /// Checks if the string_buffer matches the name of the species
        /// 
        /// r0: ground monster pointer
        /// return: bool
        /// </summary>
        public int IsMonsterNotNicknamed
        {
            get
            {
                if (f_isMonsterNotNicknamed)
                    return _isMonsterNotNicknamed;
                _isMonsterNotNicknamed = (int) (353260);
                f_isMonsterNotNicknamed = true;
                return _isMonsterNotNicknamed;
            }
        }
        private bool f_isExclusiveItemIdForMonster;
        private int _isExclusiveItemIdForMonster;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// r1: monster ID
        /// r2: type ID 1
        /// r3: type ID 2
        /// return: bool
        /// </summary>
        public int IsExclusiveItemIdForMonster
        {
            get
            {
                if (f_isExclusiveItemIdForMonster)
                    return _isExclusiveItemIdForMonster;
                _isExclusiveItemIdForMonster = (int) (69740);
                f_isExclusiveItemIdForMonster = true;
                return _isExclusiveItemIdForMonster;
            }
        }
        private bool f_formatMoveString;
        private int _formatMoveString;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: string_buffer
        /// r1: move
        /// r2: type_print
        /// </summary>
        public int FormatMoveString
        {
            get
            {
                if (f_formatMoveString)
                    return _formatMoveString;
                _formatMoveString = (int) (79136);
                f_formatMoveString = true;
                return _formatMoveString;
            }
        }
        private bool f_getOutlawLeaderLevel;
        private int _getOutlawLeaderLevel;

        /// <summary>
        /// Gets the level that should be used for team leader outlaws for the given dungeon and floor. Identical to GetOutlawLevel.
        /// 
        /// r0: Dungeon and floor
        /// return: Outlaw leader level
        /// </summary>
        public int GetOutlawLeaderLevel
        {
            get
            {
                if (f_getOutlawLeaderLevel)
                    return _getOutlawLeaderLevel;
                _getOutlawLeaderLevel = (int) (326624);
                f_getOutlawLeaderLevel = true;
                return _getOutlawLeaderLevel;
            }
        }
        private bool f_createSimpleMenuInternal;
        private int _createSimpleMenuInternal;

        /// <summary>
        /// Creates a window containing a simple textual menu with a list of options. Also see struct simple_menu.
        /// 
        /// This is used in lots of places. For example, some simple Yes/No prompts.
        /// 
        /// If window_params is NULL, SIMPLE_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: heap-allocated simple_menu_items array, the menu takes ownership
        /// stack[0]: number of items
        /// return: window_id
        /// </summary>
        public int CreateSimpleMenuInternal
        {
            get
            {
                if (f_createSimpleMenuInternal)
                    return _createSimpleMenuInternal;
                _createSimpleMenuInternal = (int) (177528);
                f_createSimpleMenuInternal = true;
                return _createSimpleMenuInternal;
            }
        }
        private bool f_setMonsterFlag2;
        private int _setMonsterFlag2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster ID
        /// </summary>
        public int SetMonsterFlag2
        {
            get
            {
                if (f_setMonsterFlag2)
                    return _setMonsterFlag2;
                _setMonsterFlag2 = (int) (316668);
                f_setMonsterFlag2 = true;
                return _setMonsterFlag2;
            }
        }
        private bool f_getSosMailCount;
        private int _getSosMailCount;

        /// <summary>
        /// Implements SPECIAL_PROC_GET_SOS_MAIL_COUNT (see ScriptSpecialProcessCall).
        /// 
        /// r0: ?
        /// r1: some flag?
        /// return: SOS mail count
        /// </summary>
        public int GetSosMailCount
        {
            get
            {
                if (f_getSosMailCount)
                    return _getSosMailCount;
                _getSosMailCount = (int) (376056);
                f_getSosMailCount = true;
                return _getSosMailCount;
            }
        }
        private bool f_createScrollBoxMulti;
        private int _createScrollBoxMulti;

        /// <summary>
        /// Creates window containing text that pages vertically on overflow, with an array of string pairs. Also see struct scroll_box.
        /// 
        /// This includes things like descriptions for items and moves.
        /// 
        /// If window_params is NULL, SCROLL_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: number of string pairs
        /// stack[0]: string ID 1 array
        /// stack[1]: preprocessor args 1 array
        /// stack[2]: string ID 2 array
        /// stack[3]: preprocessor args 2 array
        /// return: window_id
        /// </summary>
        public int CreateScrollBoxMulti
        {
            get
            {
                if (f_createScrollBoxMulti)
                    return _createScrollBoxMulti;
                _createScrollBoxMulti = (int) (190476);
                f_createScrollBoxMulti = true;
                return _createScrollBoxMulti;
            }
        }
        private bool f_getMainTeamName;
        private int _getMainTeamName;

        /// <summary>
        /// Gets the name of the team for the main story.
        /// 
        /// r0: [output] buffer
        /// </summary>
        public int GetMainTeamName
        {
            get
            {
                if (f_getMainTeamName)
                    return _getMainTeamName;
                _getMainTeamName = (int) (331444);
                f_getMainTeamName = true;
                return _getMainTeamName;
            }
        }
        private bool f_setAdvancedTextBoxPartialMenu;
        private int _setAdvancedTextBoxPartialMenu;

        /// <summary>
        /// Seems to set advanced_text_box::flags::partial_menu to the given value?
        /// 
        /// r0: window_id
        /// r1: partial_menu flag value
        /// </summary>
        public int SetAdvancedTextBoxPartialMenu
        {
            get
            {
                if (f_setAdvancedTextBoxPartialMenu)
                    return _setAdvancedTextBoxPartialMenu;
                _setAdvancedTextBoxPartialMenu = (int) (199280);
                f_setAdvancedTextBoxPartialMenu = true;
                return _setAdvancedTextBoxPartialMenu;
            }
        }
        private bool f_missionToWonderMailPassword;
        private int _missionToWonderMailPassword;

        /// <summary>
        /// Converts a mission struct to a Wonder Mail S password.
        /// 
        /// r0: [output] Pointer to the buffer where the string will be written
        /// r1: mission struct pointer
        /// </summary>
        public int MissionToWonderMailPassword
        {
            get
            {
                if (f_missionToWonderMailPassword)
                    return _missionToWonderMailPassword;
                _missionToWonderMailPassword = (int) (319924);
                f_missionToWonderMailPassword = true;
                return _missionToWonderMailPassword;
            }
        }
        private bool f_setTeamSetupHeroOnly;
        private int _setTeamSetupHeroOnly;

        /// <summary>
        /// Implements SPECIAL_PROC_SET_TEAM_SETUP_HERO_ONLY (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int SetTeamSetupHeroOnly
        {
            get
            {
                if (f_setTeamSetupHeroOnly)
                    return _setTeamSetupHeroOnly;
                _setTeamSetupHeroOnly = (int) (355884);
                f_setTeamSetupHeroOnly = true;
                return _setTeamSetupHeroOnly;
            }
        }
        private bool f_playBgmByIdVolumeVeneer;
        private int _playBgmByIdVolumeVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for PlayBgmByIdVolume.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: Music ID
        /// r1: (?) Stored on byte 8 on the struct passed to SendAudioCommand
        /// r2: Volume (0-255)
        /// </summary>
        public int PlayBgmByIdVolumeVeneer
        {
            get
            {
                if (f_playBgmByIdVolumeVeneer)
                    return _playBgmByIdVolumeVeneer;
                _playBgmByIdVolumeVeneer = (int) (97280);
                f_playBgmByIdVolumeVeneer = true;
                return _playBgmByIdVolumeVeneer;
            }
        }
        private bool f_interruptMasterDisable;
        private int _interruptMasterDisable;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: previous state
        /// </summary>
        public int InterruptMasterDisable
        {
            get
            {
                if (f_interruptMasterDisable)
                    return _interruptMasterDisable;
                _interruptMasterDisable = (int) (12492);
                f_interruptMasterDisable = true;
                return _interruptMasterDisable;
            }
        }
        private bool f_strncpySimpleNoPadSafe;
        private int _strncpySimpleNoPadSafe;

        /// <summary>
        /// Like StrncpySimpleNoPad, except there's a useless check on that each character is less than 0x100 (which is impossible for the result of a ldrb instruction).
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n
        /// </summary>
        public int StrncpySimpleNoPadSafe
        {
            get
            {
                if (f_strncpySimpleNoPadSafe)
                    return _strncpySimpleNoPadSafe;
                _strncpySimpleNoPadSafe = (int) (152768);
                f_strncpySimpleNoPadSafe = true;
                return _strncpySimpleNoPadSafe;
            }
        }
        private bool f_cardPullOutWithStatus;
        private int _cardPullOutWithStatus;

        /// <summary>
        /// Probably aborts the program with some status code? It seems to serve a similar purpose to the exit(3) function.
        /// 
        /// This function prints the debug string &quot;card pull out %d&quot; with the status code.
        /// 
        /// r0: status code
        /// </summary>
        public int CardPullOutWithStatus
        {
            get
            {
                if (f_cardPullOutWithStatus)
                    return _cardPullOutWithStatus;
                _cardPullOutWithStatus = (int) (15660);
                f_cardPullOutWithStatus = true;
                return _cardPullOutWithStatus;
            }
        }
        private bool f_playBgmById;
        private int _playBgmById;

        /// <summary>
        /// Initializes some values and then calls SendAudioCommand to play a BGM track.
        /// 
        /// Checks for DEBUG_FLAG_BGM_OFF. The volume is set to either 0 or 255 depending on the flag before calling SendAudioCommand.
        /// 
        /// r0: Music ID
        /// </summary>
        public int PlayBgmById
        {
            get
            {
                if (f_playBgmById)
                    return _playBgmById;
                _playBgmById = (int) (97936);
                f_playBgmById = true;
                return _playBgmById;
            }
        }
        private bool f_computeSpecialCounters;
        private int _computeSpecialCounters;

        /// <summary>
        /// Computes the counters from the bit fields in the adventure log, as they are not updated automatically when bit fields are altered.
        /// 
        /// Affects GetNbPokemonJoined, GetNbMovesLearned, GetNbPokemonBattled and GetNbItemAcquired.
        /// 
        /// No params.
        /// </summary>
        public int ComputeSpecialCounters
        {
            get
            {
                if (f_computeSpecialCounters)
                    return _computeSpecialCounters;
                _computeSpecialCounters = (int) (328484);
                f_computeSpecialCounters = true;
                return _computeSpecialCounters;
            }
        }
        private bool f_initMoveCheckId;
        private int _initMoveCheckId;

        /// <summary>
        /// Same as InitMove, but the function ensures that the specified ID is not 0. If it is, the move is initialized as invalid and nothing else happens.
        /// 
        /// r0: move
        /// r1: move ID
        /// </summary>
        public int InitMoveCheckId
        {
            get
            {
                if (f_initMoveCheckId)
                    return _initMoveCheckId;
                _initMoveCheckId = (int) (80016);
                f_initMoveCheckId = true;
                return _initMoveCheckId;
            }
        }
        private bool f_readSaveHeader;
        private int _readSaveHeader;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ReadSaveHeader
        {
            get
            {
                if (f_readSaveHeader)
                    return _readSaveHeader;
                _readSaveHeader = (int) (300424);
                f_readSaveHeader = true;
                return _readSaveHeader;
            }
        }
        private bool f_createParentMenu;
        private int _createParentMenu;

        /// <summary>
        /// A wrapper around CreateParentMenuInternal where ownership of the items array parameter won't be transferred to the menu.
        /// 
        /// The menu item array will be copied onto a new array on the heap. This means the argument doesn't need to remain valid after the function returns (e.g., it can be stack-allocated).
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: simple_menu_ptr_item struct array, terminated with an item with an NULL string pointer
        /// return: window_id
        /// </summary>
        public int CreateParentMenu
        {
            get
            {
                if (f_createParentMenu)
                    return _createParentMenu;
                _createParentMenu = (int) (174468);
                f_createParentMenu = true;
                return _createParentMenu;
            }
        }
        private bool f_isShaymin;
        private int _isShaymin;

        /// <summary>
        /// Checks if a monster ID is a Shaymin form.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsShaymin
        {
            get
            {
                if (f_isShaymin)
                    return _isShaymin;
                _isShaymin = (int) (347680);
                f_isShaymin = true;
                return _isShaymin;
            }
        }
        private bool f_getItemIdFromList;
        private int _getItemIdFromList;

        /// <summary>
        /// category_num and item_num are numbers in range 0-10000
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: list_id
        /// r1: category_num
        /// r2: item_num
        /// return: item ID
        /// </summary>
        public int GetItemIdFromList
        {
            get
            {
                if (f_getItemIdFromList)
                    return _getItemIdFromList;
                _getItemIdFromList = (int) (57564);
                f_getItemIdFromList = true;
                return _getItemIdFromList;
            }
        }
        private bool f_storageZInit;
        private int _storageZInit;

        /// <summary>
        /// Initializes the storage to be empty.
        /// 
        /// No params.
        /// </summary>
        public int StorageZInit
        {
            get
            {
                if (f_storageZInit)
                    return _storageZInit;
                _storageZInit = (int) (66436);
                f_storageZInit = true;
                return _storageZInit;
            }
        }
        private bool f_applyGravelyrockBoostToGroundMonster;
        private int _applyGravelyrockBoostToGroundMonster;

        /// <summary>
        /// Applies the iq boost from Gravelyrock to the target monster. Only Bonsly and Sudowoodo gain IQ from the Gravelyrock.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted iq boost, if not NULL
        /// return: actual iq boost
        /// </summary>
        public int ApplyGravelyrockBoostToGroundMonster
        {
            get
            {
                if (f_applyGravelyrockBoostToGroundMonster)
                    return _applyGravelyrockBoostToGroundMonster;
                _applyGravelyrockBoostToGroundMonster = (int) (71928);
                f_applyGravelyrockBoostToGroundMonster = true;
                return _applyGravelyrockBoostToGroundMonster;
            }
        }
        private bool f_createScrollBoxSingle;
        private int _createScrollBoxSingle;

        /// <summary>
        /// Creates window containing text that pages vertically on overflow, with a single pair of strings. Also see struct scroll_box.
        /// 
        /// This includes things like descriptions for items and moves.
        /// 
        /// If window_params is NULL, SCROLL_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: string ID 1
        /// stack[0]: preprocessor args 1
        /// stack[1]: string ID 2
        /// stack[2]: preprocessor args 2
        /// return: window_id
        /// </summary>
        public int CreateScrollBoxSingle
        {
            get
            {
                if (f_createScrollBoxSingle)
                    return _createScrollBoxSingle;
                _createScrollBoxSingle = (int) (190144);
                f_createScrollBoxSingle = true;
                return _createScrollBoxSingle;
            }
        }
        private bool f_getEquivItemIndex;
        private int _getEquivItemIndex;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_ptr
        /// return: index
        /// </summary>
        public int GetEquivItemIndex
        {
            get
            {
                if (f_getEquivItemIndex)
                    return _getEquivItemIndex;
                _getEquivItemIndex = (int) (62004);
                f_getEquivItemIndex = true;
                return _getEquivItemIndex;
            }
        }
        private bool f_waitForever;
        private int _waitForever;

        /// <summary>
        /// Sets some program state and calls WaitForInterrupt in an infinite loop.
        /// 
        /// This is called on fatal errors to hang the program indefinitely.
        /// 
        /// No params.
        /// </summary>
        public int WaitForever
        {
            get
            {
                if (f_waitForever)
                    return _waitForever;
                _waitForever = (int) (9272);
                f_waitForever = true;
                return _waitForever;
            }
        }
        private bool f_isDojoDungeon;
        private int _isDojoDungeon;

        /// <summary>
        /// Checks if the given dungeon is a Marowak Dojo dungeon.
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsDojoDungeon
        {
            get
            {
                if (f_isDojoDungeon)
                    return _isDojoDungeon;
                _isDojoDungeon = (int) (333800);
                f_isDojoDungeon = true;
                return _isDojoDungeon;
            }
        }
        private bool f_keyWaitInit;
        private int _keyWaitInit;

        /// <summary>
        /// Implements (most of?) SPECIAL_PROC_KEY_WAIT_INIT (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int KeyWaitInit
        {
            get
            {
                if (f_keyWaitInit)
                    return _keyWaitInit;
                _keyWaitInit = (int) (28068);
                f_keyWaitInit = true;
                return _keyWaitInit;
            }
        }
        private bool f_render3d64Tiling;
        private int _render3d64Tiling;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[5]. Renders a render_3d_element_64 with type RENDER64_TILING.
        /// 
        /// Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_TILING.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64Tiling
        {
            get
            {
                if (f_render3d64Tiling)
                    return _render3d64Tiling;
                _render3d64Tiling = (int) (126500);
                f_render3d64Tiling = true;
                return _render3d64Tiling;
            }
        }
        private bool f_memLocateSet;
        private int _memLocateSet;

        /// <summary>
        /// The implementation for MemAlloc.
        /// 
        /// At a high level, memory is allocated by choosing a memory arena, looking through blocks in the memory arena until a free one that's large enough is found, then splitting off a new memory block of the needed size.
        /// 
        /// This function is not fallible, i.e., it hangs the whole program on failure, so callers can assume it never fails.
        /// 
        /// The name for this function comes from the error message logged on failure, and it reflects what the function does: locate an available block of memory and set it up for the caller.
        /// 
        /// r0: desired memory arena for allocation, or null (MemAlloc passes null)
        /// r1: length in bytes
        /// r2: flags (see MemAlloc)
        /// return: pointer to allocated memory
        /// </summary>
        public int MemLocateSet
        {
            get
            {
                if (f_memLocateSet)
                    return _memLocateSet;
                _memLocateSet = (int) (5008);
                f_memLocateSet = true;
                return _memLocateSet;
            }
        }
        private bool f_allocateWanTableEntry;
        private int _allocateWanTableEntry;

        /// <summary>
        /// Return the identifier to a free wan table entry (-1 if none are avalaible). The entry is zeroed.
        /// 
        /// r0: wan_table_ptr
        /// return: the entry id in wan_table
        /// </summary>
        public int AllocateWanTableEntry
        {
            get
            {
                if (f_allocateWanTableEntry)
                    return _allocateWanTableEntry;
                _allocateWanTableEntry = (int) (119520);
                f_allocateWanTableEntry = true;
                return _allocateWanTableEntry;
            }
        }
        private bool f_fileClose;
        private int _fileClose;

        /// <summary>
        /// Closes a file.
        /// 
        /// Data transfer mode must have been initialized (with DataTransferInit) prior to calling this function.
        /// 
        /// Note: It is possible to keep a file stream open even if data transfer mode has been stopped, in which case the file stream can be used again if data transfer mode is reinitialized.
        /// 
        /// r0: file_stream pointer
        /// </summary>
        public int FileClose
        {
            get
            {
                if (f_fileClose)
                    return _fileClose;
                _fileClose = (int) (33476);
                f_fileClose = true;
                return _fileClose;
            }
        }
        private bool f_setBaseStatsMovesGroundMonster;
        private int _setBaseStatsMovesGroundMonster;

        /// <summary>
        /// Sets a ground monster to have the base stats and Level 1 moves of its species, along with 1 IQ.
        /// 
        /// r0: ground monster pointer
        /// </summary>
        public int SetBaseStatsMovesGroundMonster
        {
            get
            {
                if (f_setBaseStatsMovesGroundMonster)
                    return _setBaseStatsMovesGroundMonster;
                _setBaseStatsMovesGroundMonster = (int) (340600);
                f_setBaseStatsMovesGroundMonster = true;
                return _setBaseStatsMovesGroundMonster;
            }
        }
        private bool f_readStringFromDialogueBox;
        private int _readStringFromDialogueBox;

        /// <summary>
        /// Copies data from the dialogue box's string buffer into an output buffer.
        /// 
        /// r0: window_id
        /// r1: [output] string buffer
        /// r2: number of bytes to read
        /// </summary>
        public int ReadStringFromDialogueBox
        {
            get
            {
                if (f_readStringFromDialogueBox)
                    return _readStringFromDialogueBox;
                _readStringFromDialogueBox = (int) (194368);
                f_readStringFromDialogueBox = true;
                return _readStringFromDialogueBox;
            }
        }
        private bool f_isStorageFull;
        private int _isStorageFull;

        /// <summary>
        /// Checks if the storage is full accounting for the current rank of the team.
        /// Implements SPECIAL_PROC_0x39 (see ScriptSpecialProcessCall).
        /// 
        /// return: bool
        /// </summary>
        public int IsStorageFull
        {
            get
            {
                if (f_isStorageFull)
                    return _isStorageFull;
                _isStorageFull = (int) (65020);
                f_isStorageFull = true;
                return _isStorageFull;
            }
        }
        private bool f_debugPrintTrace;
        private int _debugPrintTrace;

        /// <summary>
        /// Would log a printf format string tagged with the file name and line number in the debug binary.
        /// 
        /// This still constructs the string, but doesn't actually do anything with it in the final binary.
        /// 
        /// If message is a null pointer, the string &quot;  Print  &quot; is used instead.
        /// 
        /// r0: message
        /// r1: program position info (can be null)
        /// </summary>
        public int DebugPrintTrace
        {
            get
            {
                if (f_debugPrintTrace)
                    return _debugPrintTrace;
                _debugPrintTrace = (int) (49652);
                f_debugPrintTrace = true;
                return _debugPrintTrace;
            }
        }
        private bool f_getNameWithGender;
        private int _getNameWithGender;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dst_ptr
        /// r1: id
        /// r2: color_id
        /// </summary>
        public int GetNameWithGender
        {
            get
            {
                if (f_getNameWithGender)
                    return _getNameWithGender;
                _getNameWithGender = (int) (337784);
                f_getNameWithGender = true;
                return _getNameWithGender;
            }
        }
        private bool f_processWte;
        private int _processWte;

        /// <summary>
        /// Prepare and plan a WTE data to be loaded into VRAM.
        /// It skips the texture and/or the palette if missing from the file. The texture VRAM has 128KiB of space, and palette has 16KiB.
        /// The true palette VRAM offset will be upper_part*0x100+lower_part.
        /// Will ensure it gets copied next time PerformPlannedTextureVramTransfer is called by the game.
        /// Will not automatically free the data once done. That can be done with DelayWteFree, which seems systematically called in the game’s code.
        /// 
        /// r0: pointer to the WTE file header loaded in memory
        /// r1: where the WTE texture will be loaded in the VRAM (from 0 to 0x1FFFF)
        /// r2: upper part of the palette VRAM
        /// r3: lower part of the palette VRAM
        /// </summary>
        public int ProcessWte
        {
            get
            {
                if (f_processWte)
                    return _processWte;
                _processWte = (int) (123212);
                f_processWte = true;
                return _processWte;
            }
        }
        private bool f_randIntSafe;
        private int _randIntSafe;

        /// <summary>
        /// Same as RandInt, except explicitly masking out the upper 16 bits of the output from Rand16Bit (which should be zero anyway).
        /// 
        /// r0: high
        /// return: pseudorandom integer on the interval [0, high - 1]
        /// </summary>
        public int RandIntSafe
        {
            get
            {
                if (f_randIntSafe)
                    return _randIntSafe;
                _randIntSafe = (int) (8952);
                f_randIntSafe = true;
                return _randIntSafe;
            }
        }
        private bool f_hasStorableItems;
        private int _hasStorableItems;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: bool
        /// </summary>
        public int HasStorableItems
        {
            get
            {
                if (f_hasStorableItems)
                    return _hasStorableItems;
                _hasStorableItems = (int) (61836);
                f_hasStorableItems = true;
                return _hasStorableItems;
            }
        }
        private bool f_appendMissionTitle;
        private int _appendMissionTitle;

        /// <summary>
        /// Generates the mission title of a mission, and appends it to the string location.
        /// 
        /// r0: [output] output buffer
        /// r1: intermediate buffer, filled then concatenated to output buffer
        /// r2: pointer to preprocessor args
        /// r3: pointer to mission_details struct
        /// </summary>
        public int AppendMissionTitle
        {
            get
            {
                if (f_appendMissionTitle)
                    return _appendMissionTitle;
                _appendMissionTitle = (int) (396684);
                f_appendMissionTitle = true;
                return _appendMissionTitle;
            }
        }
        private bool f_uMultiplyByFixedPoint;
        private int _uMultiplyByFixedPoint;

        /// <summary>
        /// Multiplies an unsigned integer x by an unsigned binary fixed-point multiplier (8 fraction bits).
        /// 
        /// r0: x
        /// r1: multiplier
        /// return: x * multiplier
        /// </summary>
        public int UMultiplyByFixedPoint
        {
            get
            {
                if (f_uMultiplyByFixedPoint)
                    return _uMultiplyByFixedPoint;
                _uMultiplyByFixedPoint = (int) (6924);
                f_uMultiplyByFixedPoint = true;
                return _uMultiplyByFixedPoint;
            }
        }
        private bool f_manipBgmPlayback;
        private int _manipBgmPlayback;

        /// <summary>
        /// Uncertain. More like bgm1&amp;2 end
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int ManipBgmPlayback
        {
            get
            {
                if (f_manipBgmPlayback)
                    return _manipBgmPlayback;
                _manipBgmPlayback = (int) (102208);
                f_manipBgmPlayback = true;
                return _manipBgmPlayback;
            }
        }
        private bool f_getOutlawMinionLevel;
        private int _getOutlawMinionLevel;

        /// <summary>
        /// Gets the level that should be used for minion outlaws for the given dungeon and floor.
        /// 
        /// r0: Dungeon and floor
        /// return: Outlaw minion level
        /// </summary>
        public int GetOutlawMinionLevel
        {
            get
            {
                if (f_getOutlawMinionLevel)
                    return _getOutlawMinionLevel;
                _getOutlawMinionLevel = (int) (326652);
                f_getOutlawMinionLevel = true;
                return _getOutlawMinionLevel;
            }
        }
        private bool f_playTimerTick;
        private int _playTimerTick;

        /// <summary>
        /// Advance the file timer by 1 frame.
        /// 
        /// r0: play_time
        /// </summary>
        public int PlayTimerTick
        {
            get
            {
                if (f_playTimerTick)
                    return _playTimerTick;
                _playTimerTick = (int) (332112);
                f_playTimerTick = true;
                return _playTimerTick;
            }
        }
        private bool f_changeGiratinaFormIfSkyDungeon;
        private int _changeGiratinaFormIfSkyDungeon;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// </summary>
        public int ChangeGiratinaFormIfSkyDungeon
        {
            get
            {
                if (f_changeGiratinaFormIfSkyDungeon)
                    return _changeGiratinaFormIfSkyDungeon;
                _changeGiratinaFormIfSkyDungeon = (int) (362836);
                f_changeGiratinaFormIfSkyDungeon = true;
                return _changeGiratinaFormIfSkyDungeon;
            }
        }
        private bool f_setNbSkyGiftsSent;
        private int _setNbSkyGiftsSent;

        /// <summary>
        /// Sets the number of Sky Gifts sent.
        /// 
        /// return: the number of Sky Gifts sent
        /// </summary>
        public int SetNbSkyGiftsSent
        {
            get
            {
                if (f_setNbSkyGiftsSent)
                    return _setNbSkyGiftsSent;
                _setNbSkyGiftsSent = (int) (328408);
                f_setNbSkyGiftsSent = true;
                return _setNbSkyGiftsSent;
            }
        }
        private bool f_specialEpisodeInventoryZInit;
        private int _specialEpisodeInventoryZInit;

        /// <summary>
        /// Initializes the TEAM_SPECIAL_EPISODE inventory to be empty.
        /// 
        /// No params.
        /// </summary>
        public int SpecialEpisodeInventoryZInit
        {
            get
            {
                if (f_specialEpisodeInventoryZInit)
                    return _specialEpisodeInventoryZInit;
                _specialEpisodeInventoryZInit = (int) (60656);
                f_specialEpisodeInventoryZInit = true;
                return _specialEpisodeInventoryZInit;
            }
        }
        private bool f_isDeoxys;
        private int _isDeoxys;

        /// <summary>
        /// Checks if a monster ID is a Deoxys form.
        /// 
        /// r0: monster ID
        /// return: bool
        /// </summary>
        public int IsDeoxys
        {
            get
            {
                if (f_isDeoxys)
                    return _isDeoxys;
                _isDeoxys = (int) (347888);
                f_isDeoxys = true;
                return _isDeoxys;
            }
        }
        private bool f_stopMe;
        private int _stopMe;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: fade_out
        /// </summary>
        public int StopMe
        {
            get
            {
                if (f_stopMe)
                    return _stopMe;
                _stopMe = (int) (107688);
                f_stopMe = true;
                return _stopMe;
            }
        }
        private bool f_geomSetVertexCoord16;
        private int _geomSetVertexCoord16;

        /// <summary>
        /// Send the &quot;VTX_16&quot; geometry engine command, that defines the coordinate of a point of a polygon, using 16 bits.
        /// Inputs are clamped over their 16 lower bits
        /// 
        /// r0: x coordinate
        /// r1: y coordinate
        /// r2: z coordinate
        /// </summary>
        public int GeomSetVertexCoord16
        {
            get
            {
                if (f_geomSetVertexCoord16)
                    return _geomSetVertexCoord16;
                _geomSetVertexCoord16 = (int) (124272);
                f_geomSetVertexCoord16 = true;
                return _geomSetVertexCoord16;
            }
        }
        private bool f_closeTextBox2;
        private int _closeTextBox2;

        /// <summary>
        /// Seems to do some things with the text box, before doing the same things that CloseTextBox does.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseTextBox2
        {
            get
            {
                if (f_closeTextBox2)
                    return _closeTextBox2;
                _closeTextBox2 = (int) (195596);
                f_closeTextBox2 = true;
                return _closeTextBox2;
            }
        }
        private bool f_getTeamMember;
        private int _getTeamMember;

        /// <summary>
        /// Gets the team member at the given index.
        /// 
        /// r0: team member index
        /// return: ground monster pointer
        /// </summary>
        public int GetTeamMember
        {
            get
            {
                if (f_getTeamMember)
                    return _getTeamMember;
                _getTeamMember = (int) (350500);
                f_getTeamMember = true;
                return _getTeamMember;
            }
        }
        private bool f_getRank;
        private int _getRank;

        /// <summary>
        /// Returns the team's rank
        /// 
        /// If PERFORMANCE_PROGRESS_LIST[8] is 0, the maximum rank that can be returned is RANK_MASTER.
        /// 
        /// return: Rank
        /// </summary>
        public int GetRank
        {
            get
            {
                if (f_getRank)
                    return _getRank;
                _getRank = (int) (331692);
                f_getRank = true;
                return _getRank;
            }
        }
        private bool f_loadCursors;
        private int _loadCursors;

        /// <summary>
        /// Load and initialize the cursor and cursor16 sprites, storing the result in CURSOR_ANIMATION_CONTROL and CURSOR_16_ANIMATION_CONTROL
        /// 
        /// No params.
        /// </summary>
        public int LoadCursors
        {
            get
            {
                if (f_loadCursors)
                    return _loadCursors;
                _loadCursors = (int) (169984);
                f_loadCursors = true;
                return _loadCursors;
            }
        }
        private bool f_closePortraitBox;
        private int _closePortraitBox;

        /// <summary>
        /// Closes a window created with CreatePortraitBox.
        /// 
        /// r0: window_id
        /// </summary>
        public int ClosePortraitBox
        {
            get
            {
                if (f_closePortraitBox)
                    return _closePortraitBox;
                _closePortraitBox = (int) (194884);
                f_closePortraitBox = true;
                return _closePortraitBox;
            }
        }
        private bool f_closeSimpleMenu;
        private int _closeSimpleMenu;

        /// <summary>
        /// Closes a window created with CreateSimpleMenu or CreateSimpleMenuFromStringIds.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseSimpleMenu
        {
            get
            {
                if (f_closeSimpleMenu)
                    return _closeSimpleMenu;
                _closeSimpleMenu = (int) (178104);
                f_closeSimpleMenu = true;
                return _closeSimpleMenu;
            }
        }
        private bool f_getDamageSource;
        private int _getDamageSource;

        /// <summary>
        /// Gets the damage source for a given move-item combination.
        /// 
        /// If there's no item, the source is the move ID. If the item is an orb, return DAMAGE_SOURCE_ORB_ITEM. Otherwise, return DAMAGE_SOURCE_NON_ORB_ITEM.
        /// 
        /// r0: move ID
        /// r1: item ID
        /// return: damage source
        /// </summary>
        public int GetDamageSource
        {
            get
            {
                if (f_getDamageSource)
                    return _getDamageSource;
                _getDamageSource = (int) (51932);
                f_getDamageSource = true;
                return _getDamageSource;
            }
        }
        private bool f_copyProgressInfoTo;
        private int _copyProgressInfoTo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: write_info
        /// others: ?
        /// </summary>
        public int CopyProgressInfoTo
        {
            get
            {
                if (f_copyProgressInfoTo)
                    return _copyProgressInfoTo;
                _copyProgressInfoTo = (int) (317176);
                f_copyProgressInfoTo = true;
                return _copyProgressInfoTo;
            }
        }
        private bool f_setScreenWindowsColor;
        private int _setScreenWindowsColor;

        /// <summary>
        /// Sets the palette of the frames of windows in the specified screen
        /// 
        /// r0: palette index
        /// r1: is upper screen
        /// </summary>
        public int SetScreenWindowsColor
        {
            get
            {
                if (f_setScreenWindowsColor)
                    return _setScreenWindowsColor;
                _setScreenWindowsColor = (int) (163164);
                f_setScreenWindowsColor = true;
                return _setScreenWindowsColor;
            }
        }
        private bool f_getMoveBasePowerGround;
        private int _getMoveBasePowerGround;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ground_move
        /// return: base power
        /// </summary>
        public int GetMoveBasePowerGround
        {
            get
            {
                if (f_getMoveBasePowerGround)
                    return _getMoveBasePowerGround;
                _getMoveBasePowerGround = (int) (80532);
                f_getMoveBasePowerGround = true;
                return _getMoveBasePowerGround;
            }
        }
        private bool f_getLeaderChangeFlag;
        private int _getLeaderChangeFlag;

        /// <summary>
        /// Returns true if the flag that allows changing leaders is set in the restrictions of the specified dungeon
        /// 
        /// r0: dungeon id
        /// return: True if the restrictions of the current dungeon allow changing leaders, false otherwise.
        /// </summary>
        public int GetLeaderChangeFlag
        {
            get
            {
                if (f_getLeaderChangeFlag)
                    return _getLeaderChangeFlag;
                _getLeaderChangeFlag = (int) (333560);
                f_getLeaderChangeFlag = true;
                return _getLeaderChangeFlag;
            }
        }
        private bool f_initDebugStripped5;
        private int _initDebugStripped5;

        /// <summary>
        /// Does nothing, only called in the debug initialization function.
        /// </summary>
        public int InitDebugStripped5
        {
            get
            {
                if (f_initDebugStripped5)
                    return _initDebugStripped5;
                _initDebugStripped5 = (int) (49648);
                f_initDebugStripped5 = true;
                return _initDebugStripped5;
            }
        }
        private bool f_areMissionsEquivalent;
        private int _areMissionsEquivalent;

        /// <summary>
        /// Checks if two missions are equivalent.
        /// 
        /// r0: mission1
        /// r1: mission2
        /// return: bool
        /// </summary>
        public int AreMissionsEquivalent
        {
            get
            {
                if (f_areMissionsEquivalent)
                    return _areMissionsEquivalent;
                _areMissionsEquivalent = (int) (380080);
                f_areMissionsEquivalent = true;
                return _areMissionsEquivalent;
            }
        }
        private bool f_incrementNbSteals;
        private int _incrementNbSteals;

        /// <summary>
        /// Leftover from Time &amp; Darkness. Does not do anything.
        /// 
        /// Calls to this matches the ones for incrementing the number of successful steals in Time &amp; Darkness.
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbSteals
        {
            get
            {
                if (f_incrementNbSteals)
                    return _incrementNbSteals;
                _incrementNbSteals = (int) (327792);
                f_incrementNbSteals = true;
                return _incrementNbSteals;
            }
        }
        private bool f_getDsFirmwareUserSettingsVeneer;
        private int _getDsFirmwareUserSettingsVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for GetDsFirmwareUserSettings.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: user_settings pointer
        /// </summary>
        public int GetDsFirmwareUserSettingsVeneer
        {
            get
            {
                if (f_getDsFirmwareUserSettingsVeneer)
                    return _getDsFirmwareUserSettingsVeneer;
                _getDsFirmwareUserSettingsVeneer = (int) (20340);
                f_getDsFirmwareUserSettingsVeneer = true;
                return _getDsFirmwareUserSettingsVeneer;
            }
        }
        private bool f_allocAndLoadFileInPack;
        private int _allocAndLoadFileInPack;

        /// <summary>
        /// Allocate a file and load a file from the pack archive inside.
        /// The data pointed by the pointer in the output need to be freed once is not needed anymore.
        /// 
        /// r0: pack file identifier
        /// r1: file index
        /// r2: [output] result struct (will contain length and pointer)
        /// r3: allocation flags
        /// </summary>
        public int AllocAndLoadFileInPack
        {
            get
            {
                if (f_allocAndLoadFileInPack)
                    return _allocAndLoadFileInPack;
                _allocAndLoadFileInPack = (int) (50192);
                f_allocAndLoadFileInPack = true;
                return _allocAndLoadFileInPack;
            }
        }
        private bool f_getExclusiveItemOffsetEnsureValid;
        private int _getExclusiveItemOffsetEnsureValid;

        /// <summary>
        /// Gets the exclusive item offset, which is the item ID relative to that of the first exclusive item, the Prism Ruff.
        /// 
        /// If the given item ID is not a valid item ID, ITEM_PLAIN_SEED (0x55) is returned. This is a bug, since 0x55 is the valid exclusive item offset for the Icy Globe.
        /// 
        /// r0: item ID
        /// return: offset
        /// </summary>
        public int GetExclusiveItemOffsetEnsureValid
        {
            get
            {
                if (f_getExclusiveItemOffsetEnsureValid)
                    return _getExclusiveItemOffsetEnsureValid;
                _getExclusiveItemOffsetEnsureValid = (int) (59468);
                f_getExclusiveItemOffsetEnsureValid = true;
                return _getExclusiveItemOffsetEnsureValid;
            }
        }
        private bool f_playBgm2;
        private int _playBgm2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int PlayBgm2
        {
            get
            {
                if (f_playBgm2)
                    return _playBgm2;
                _playBgm2 = (int) (106016);
                f_playBgm2 = true;
                return _playBgm2;
            }
        }
        private bool f_isShoppableItem;
        private int _isShoppableItem;

        /// <summary>
        /// Checks if an item can be bought and sold from a Kecleon shop. Includes items like the Gold Thorn, Poke, Golden
        /// Mask, Amber Tear, etc. Also has a special check to make sure an item's buy and sell price is more than 0.
        /// 
        /// r0: item_id
        /// return: bool
        /// </summary>
        public int IsShoppableItem
        {
            get
            {
                if (f_isShoppableItem)
                    return _isShoppableItem;
                _isShoppableItem = (int) (52584);
                f_isShoppableItem = true;
                return _isShoppableItem;
            }
        }
        private bool f_printIqSkillsMenu;
        private int _printIqSkillsMenu;

        /// <summary>
        /// Draws the IQ skills menu for a certain monster.
        /// 
        /// r0: Monster species
        /// r1: Pointer to bitarray where the enabled skills will be written when enabling or disabling them in the menu
        /// r2: Monster IQ
        /// r3: True if the monster is blinded
        /// </summary>
        public int PrintIqSkillsMenu
        {
            get
            {
                if (f_printIqSkillsMenu)
                    return _printIqSkillsMenu;
                _printIqSkillsMenu = (int) (269628);
                f_printIqSkillsMenu = true;
                return _printIqSkillsMenu;
            }
        }
        private bool f_getItemAtIdx;
        private int _getItemAtIdx;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: index
        /// return: item pointer
        /// </summary>
        public int GetItemAtIdx
        {
            get
            {
                if (f_getItemAtIdx)
                    return _getItemAtIdx;
                _getItemAtIdx = (int) (62448);
                f_getItemAtIdx = true;
                return _getItemAtIdx;
            }
        }
        private bool f_initRender3dData;
        private int _initRender3dData;

        /// <summary>
        /// Initialize the global &quot;RENDER_3D&quot; structure.
        /// 
        /// No params.
        /// </summary>
        public int InitRender3dData
        {
            get
            {
                if (f_initRender3dData)
                    return _initRender3dData;
                _initRender3dData = (int) (124320);
                f_initRender3dData = true;
                return _initRender3dData;
            }
        }
        private bool f_isBagFull;
        private int _isBagFull;

        /// <summary>
        /// Implements SPECIAL_PROC_IS_BAG_FULL (see ScriptSpecialProcessCall).
        /// 
        /// return: bool
        /// </summary>
        public int IsBagFull
        {
            get
            {
                if (f_isBagFull)
                    return _isBagFull;
                _isBagFull = (int) (61032);
                f_isBagFull = true;
                return _isBagFull;
            }
        }
        private bool f_intToFixedPoint64;
        private int _intToFixedPoint64;

        /// <summary>
        /// Converts a signed integer to a 64-bit fixed-point number (16 fraction bits).
        /// 
        /// Note that this function appears to be bugged: it appears to try to sign-extend if the input is negative, but in a nonsensical way, checking the sign bit for a 16-bit signed integer, but then doing the sign extension as if the input were a 32-bit signed integer.
        /// 
        /// r0: [output] 64-bit fixed-point number
        /// r1: 32-bit signed int
        /// </summary>
        public int IntToFixedPoint64
        {
            get
            {
                if (f_intToFixedPoint64)
                    return _intToFixedPoint64;
                _intToFixedPoint64 = (int) (7296);
                f_intToFixedPoint64 = true;
                return _intToFixedPoint64;
            }
        }
        private bool f_getExplorerMazeTeamName;
        private int _getExplorerMazeTeamName;

        /// <summary>
        /// Returns the name of the explorer maze team. If the language of the team name is different from the
        /// language of selected in this game a default team name is written to the buffer instead.
        /// 
        /// r0: [output] Buffer
        /// </summary>
        public int GetExplorerMazeTeamName
        {
            get
            {
                if (f_getExplorerMazeTeamName)
                    return _getExplorerMazeTeamName;
                _getExplorerMazeTeamName = (int) (365532);
                f_getExplorerMazeTeamName = true;
                return _getExplorerMazeTeamName;
            }
        }
        private bool f_getMainCharacter1;
        private int _getMainCharacter1;

        /// <summary>
        /// Returns the ground monster data of the first main character for the given game mode.
        /// 
        /// In normal play, this will be the hero. During special episodes, this will be the first special episode main character (index 2).
        /// 
        /// return: ground monster pointer
        /// </summary>
        public int GetMainCharacter1
        {
            get
            {
                if (f_getMainCharacter1)
                    return _getMainCharacter1;
                _getMainCharacter1 = (int) (351040);
                f_getMainCharacter1 = true;
                return _getMainCharacter1;
            }
        }
        private bool f_copyMoveFrom;
        private int _copyMoveFrom;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: read_info
        /// r1: buffer_read
        /// </summary>
        public int CopyMoveFrom
        {
            get
            {
                if (f_copyMoveFrom)
                    return _copyMoveFrom;
                _copyMoveFrom = (int) (84780);
                f_copyMoveFrom = true;
                return _copyMoveFrom;
            }
        }
        private bool f_setBothScreensWindowsColor;
        private int _setBothScreensWindowsColor;

        /// <summary>
        /// Sets the palette of the frames of windows in both screens
        /// 
        /// r0: palette index
        /// </summary>
        public int SetBothScreensWindowsColor
        {
            get
            {
                if (f_setBothScreensWindowsColor)
                    return _setBothScreensWindowsColor;
                _setBothScreensWindowsColor = (int) (163188);
                f_setBothScreensWindowsColor = true;
                return _setBothScreensWindowsColor;
            }
        }
        private bool f_setDungeonConquest;
        private int _setDungeonConquest;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// r1: bit_value
        /// </summary>
        public int SetDungeonConquest
        {
            get
            {
                if (f_setDungeonConquest)
                    return _setDungeonConquest;
                _setDungeonConquest = (int) (316016);
                f_setDungeonConquest = true;
                return _setDungeonConquest;
            }
        }
        private bool f_getNbFloors;
        private int _getNbFloors;

        /// <summary>
        /// Returns the number of floors of the given dungeon.
        /// 
        /// The result is hardcoded for certain dungeons, such as dojo mazes.
        /// 
        /// r0: Dungeon ID
        /// return: Number of floors
        /// </summary>
        public int GetNbFloors
        {
            get
            {
                if (f_getNbFloors)
                    return _getNbFloors;
                _getNbFloors = (int) (325812);
                f_getNbFloors = true;
                return _getNbFloors;
            }
        }
        private bool f_memZero;
        private int _memZero;

        /// <summary>
        /// Zeroes a buffer.
        /// 
        /// r0: ptr
        /// r1: len
        /// </summary>
        public int MemZero
        {
            get
            {
                if (f_memZero)
                    return _memZero;
                _memZero = (int) (12880);
                f_memZero = true;
                return _memZero;
            }
        }
        private bool f_getMainCharacter2;
        private int _getMainCharacter2;

        /// <summary>
        /// Returns the ground monster data of the second main character for the given game mode, or null if invalid.
        /// 
        /// In normal play, this will be the partner. During special episodes, this will be the second special episode main character (index 3) if one is present.
        /// 
        /// return: ground monster pointer
        /// </summary>
        public int GetMainCharacter2
        {
            get
            {
                if (f_getMainCharacter2)
                    return _getMainCharacter2;
                _getMainCharacter2 = (int) (351112);
                f_getMainCharacter2 = true;
                return _getMainCharacter2;
            }
        }
        private bool f_wanTableSpriteHasAnimationGroup;
        private int _wanTableSpriteHasAnimationGroup;

        /// <summary>
        /// Check if the sprite in the global WAN table has the given animation group
        /// see WanHasAnimationGroup for more detail
        /// 
        /// r0: sprite id in the WAN table
        /// r1: animation group id
        /// return: whether the associated sprite has the given animation group
        /// </summary>
        public int WanTableSpriteHasAnimationGroup
        {
            get
            {
                if (f_wanTableSpriteHasAnimationGroup)
                    return _wanTableSpriteHasAnimationGroup;
                _wanTableSpriteHasAnimationGroup = (int) (121628);
                f_wanTableSpriteHasAnimationGroup = true;
                return _wanTableSpriteHasAnimationGroup;
            }
        }
        private bool f_formatMoveStringMore;
        private int _formatMoveStringMore;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ???
        /// r1: ???
        /// r2: move
        /// r3: type_print
        /// </summary>
        public int FormatMoveStringMore
        {
            get
            {
                if (f_formatMoveStringMore)
                    return _formatMoveStringMore;
                _formatMoveStringMore = (int) (79912);
                f_formatMoveStringMore = true;
                return _formatMoveStringMore;
            }
        }
        private bool f_loadWanTableEntry;
        private int _loadWanTableEntry;

        /// <summary>
        /// Appears to load data from the given file (in practice always seems to be animation data), using previously loaded data in the given table (see FindWanTableEntry) if possible.
        /// 
        /// r0: table pointer
        /// r1: file name
        /// r2: flags
        /// return: table index of the loaded data
        /// </summary>
        public int LoadWanTableEntry
        {
            get
            {
                if (f_loadWanTableEntry)
                    return _loadWanTableEntry;
                _loadWanTableEntry = (int) (119928);
                f_loadWanTableEntry = true;
                return _loadWanTableEntry;
            }
        }
        private bool f_loadDseFile;
        private int _loadDseFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] iovec
        /// r1: filename
        /// return: bytes read
        /// </summary>
        public int LoadDseFile
        {
            get
            {
                if (f_loadDseFile)
                    return _loadDseFile;
                _loadDseFile = (int) (103464);
                f_loadDseFile = true;
                return _loadDseFile;
            }
        }
        private bool f_seChangePan;
        private int _seChangePan;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int SeChangePan
        {
            get
            {
                if (f_seChangePan)
                    return _seChangePan;
                _seChangePan = (int) (108956);
                f_seChangePan = true;
                return _seChangePan;
            }
        }
        private bool f_playMe;
        private int _playMe;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int PlayMe
        {
            get
            {
                if (f_playMe)
                    return _playMe;
                _playMe = (int) (107108);
                f_playMe = true;
                return _playMe;
            }
        }
        private bool f_svcCpuSet;
        private int _svcCpuSet;

        /// <summary>
        /// Software interrupt.
        /// </summary>
        public int SvcCpuSet
        {
            get
            {
                if (f_svcCpuSet)
                    return _svcCpuSet;
                _svcCpuSet = (int) (1950);
                f_svcCpuSet = true;
                return _svcCpuSet;
            }
        }
        private bool f_getAtSize;
        private int _getAtSize;

        /// <summary>
        /// Doesn't work for AT3PX and AT4PN
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: AT pointer
        /// r1: ?
        /// return: ?
        /// </summary>
        public int GetAtSize
        {
            get
            {
                if (f_getAtSize)
                    return _getAtSize;
                _getAtSize = (int) (132488);
                f_getAtSize = true;
                return _getAtSize;
            }
        }
        private bool f_drawTextInWindow;
        private int _drawTextInWindow;

        /// <summary>
        /// Seems to be responsible for drawing the text in a window.
        /// 
        /// Needs a call to UpdateWindow after to actually display the contents.
        /// Unclear if this is generic for windows or just text boxes.
        /// 
        /// r0: window_id
        /// r1: x offset within window
        /// r2: y offset within window
        /// r3: text to draw
        /// </summary>
        public int DrawTextInWindow
        {
            get
            {
                if (f_drawTextInWindow)
                    return _drawTextInWindow;
                _drawTextInWindow = (int) (156920);
                f_drawTextInWindow = true;
                return _drawTextInWindow;
            }
        }
        private bool f_dataTransferStop;
        private int _dataTransferStop;

        /// <summary>
        /// Finalizes data transfer from the ROM cartridge.
        /// 
        /// This function must always be called if DataTransferInit was called, or the game will crash.
        /// 
        /// No params.
        /// </summary>
        public int DataTransferStop
        {
            get
            {
                if (f_dataTransferStop)
                    return _dataTransferStop;
                _dataTransferStop = (int) (33172);
                f_dataTransferStop = true;
                return _dataTransferStop;
            }
        }
        private bool f_countItemTypeInStorage;
        private int _countItemTypeInStorage;

        /// <summary>
        /// Counts the number of a certain item in storage accounting for stackable items.
        /// Implements SPECIAL_PROC_COUNT_ITEM_TYPE_IN_STORAGE (see ScriptSpecialProcessCall).
        /// 
        /// r0: pointer to an bulk_item
        /// return: number of items of the specified ID in storage
        /// </summary>
        public int CountItemTypeInStorage
        {
            get
            {
                if (f_countItemTypeInStorage)
                    return _countItemTypeInStorage;
                _countItemTypeInStorage = (int) (65420);
                f_countItemTypeInStorage = true;
                return _countItemTypeInStorage;
            }
        }
        private bool f_playBgm;
        private int _playBgm;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int PlayBgm
        {
            get
            {
                if (f_playBgm)
                    return _playBgm;
                _playBgm = (int) (104788);
                f_playBgm = true;
                return _playBgm;
            }
        }
        private bool f_isSpecialEpisodeDungeon;
        private int _isSpecialEpisodeDungeon;

        /// <summary>
        /// Checks if the given dungeon is a special episode dungeon.
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsSpecialEpisodeDungeon
        {
            get
            {
                if (f_isSpecialEpisodeDungeon)
                    return _isSpecialEpisodeDungeon;
                _isSpecialEpisodeDungeon = (int) (333856);
                f_isSpecialEpisodeDungeon = true;
                return _isSpecialEpisodeDungeon;
            }
        }
        private bool f_doAutoload;
        private int _doAutoload;

        /// <summary>
        /// Startup routine in the program's crt0 (https://en.wikipedia.org/wiki/Crt0).
        /// </summary>
        public int DoAutoload
        {
            get
            {
                if (f_doAutoload)
                    return _doAutoload;
                _doAutoload = (int) (2588);
                f_doAutoload = true;
                return _doAutoload;
            }
        }
        private bool f_isItemAvailableInDungeonGroup;
        private int _isItemAvailableInDungeonGroup;

        /// <summary>
        /// Checks one specific bit from AVAILABLE_ITEMS_IN_GROUP_TABLE?
        /// 
        /// r0: dungeon ID
        /// r1: item ID
        /// return: bool
        /// </summary>
        public int IsItemAvailableInDungeonGroup
        {
            get
            {
                if (f_isItemAvailableInDungeonGroup)
                    return _isItemAvailableInDungeonGroup;
                _isItemAvailableInDungeonGroup = (int) (57492);
                f_isItemAvailableInDungeonGroup = true;
                return _isItemAvailableInDungeonGroup;
            }
        }
        private bool f_copyStringFromId;
        private int _copyStringFromId;

        /// <summary>
        /// Gets the string corresponding to a given string ID and copies it to the buffer specified in r0.
        /// 
        /// r0: buffer
        /// r1: string ID
        /// </summary>
        public int CopyStringFromId
        {
            get
            {
                if (f_copyStringFromId)
                    return _copyStringFromId;
                _copyStringFromId = (int) (154544);
                f_copyStringFromId = true;
                return _copyStringFromId;
            }
        }
        private bool f_initKaomadoStream;
        private int _initKaomadoStream;

        /// <summary>
        /// Initializes the stream used to load all Kaomado portraits, called once on game start!
        /// 
        /// No params.
        /// </summary>
        public int InitKaomadoStream
        {
            get
            {
                if (f_initKaomadoStream)
                    return _initKaomadoStream;
                _initKaomadoStream = (int) (318136);
                f_initKaomadoStream = true;
                return _initKaomadoStream;
            }
        }
        private bool f_initDebugLogFlag;
        private int _initDebugLogFlag;

        /// <summary>
        /// Would have initialized the debug log flags.
        /// Does nothing in release binary.
        /// </summary>
        public int InitDebugLogFlag
        {
            get
            {
                if (f_initDebugLogFlag)
                    return _initDebugLogFlag;
                _initDebugLogFlag = (int) (49848);
                f_initDebugLogFlag = true;
                return _initDebugLogFlag;
            }
        }
        private bool f_getEvolutionPossibilities;
        private int _getEvolutionPossibilities;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ground_monster
        /// r1: evo_struct_addr
        /// </summary>
        public int GetEvolutionPossibilities
        {
            get
            {
                if (f_getEvolutionPossibilities)
                    return _getEvolutionPossibilities;
                _getEvolutionPossibilities = (int) (368276);
                f_getEvolutionPossibilities = true;
                return _getEvolutionPossibilities;
            }
        }
        private bool f_rgb8ToRgb5;
        private int _rgb8ToRgb5;

        /// <summary>
        /// Transform the input rgb8 color to a rgb5 color
        /// 
        /// r0: pointer to target rgb5 (2 bytes, aligned to LSB)
        /// r1: pointer to source rgb8
        /// </summary>
        public int Rgb8ToRgb5
        {
            get
            {
                if (f_rgb8ToRgb5)
                    return _rgb8ToRgb5;
                _rgb8ToRgb5 = (int) (20428);
                f_rgb8ToRgb5 = true;
                return _rgb8ToRgb5;
            }
        }
        private bool f_isNot2TurnsMoveOrSketch;
        private int _isNot2TurnsMoveOrSketch;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: bool
        /// </summary>
        public int IsNot2TurnsMoveOrSketch
        {
            get
            {
                if (f_isNot2TurnsMoveOrSketch)
                    return _isNot2TurnsMoveOrSketch;
                _isNot2TurnsMoveOrSketch = (int) (85728);
                f_isNot2TurnsMoveOrSketch = true;
                return _isNot2TurnsMoveOrSketch;
            }
        }
        private bool f_isThawingMove;
        private int _isThawingMove;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move
        /// return: bool
        /// </summary>
        public int IsThawingMove
        {
            get
            {
                if (f_isThawingMove)
                    return _isThawingMove;
                _isThawingMove = (int) (80856);
                f_isThawingMove = true;
                return _isThawingMove;
            }
        }
        private bool f_clearItem;
        private int _clearItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: team_id
        /// r1: check
        /// </summary>
        public int ClearItem
        {
            get
            {
                if (f_clearItem)
                    return _clearItem;
                _clearItem = (int) (361836);
                f_clearItem = true;
                return _clearItem;
            }
        }
        private bool f_getItemCategoryVeneer;
        private int _getItemCategoryVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for GetItemCategory.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: Item ID
        /// return: Category ID
        /// </summary>
        public int GetItemCategoryVeneer
        {
            get
            {
                if (f_getItemCategoryVeneer)
                    return _getItemCategoryVeneer;
                _getItemCategoryVeneer = (int) (52088);
                f_getItemCategoryVeneer = true;
                return _getItemCategoryVeneer;
            }
        }
        private bool f_createParentMenuFromStringIds;
        private int _createParentMenuFromStringIds;

        /// <summary>
        /// A wrapper around CreateParentMenuInternal, where the menu items can be defined by string ID instead of as strings.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: simple_menu_id_item struct array, terminated with an item with string_id 0
        /// return: window_id
        /// </summary>
        public int CreateParentMenuFromStringIds
        {
            get
            {
                if (f_createParentMenuFromStringIds)
                    return _createParentMenuFromStringIds;
                _createParentMenuFromStringIds = (int) (174272);
                f_createParentMenuFromStringIds = true;
                return _createParentMenuFromStringIds;
            }
        }
        private bool f_initSpecialEpisodePartners;
        private int _initSpecialEpisodePartners;

        /// <summary>
        /// Initializes the partners for the current special episode and sets the team to be the hero and partner only.
        /// Implements SPECIAL_PROC_0x3 (see ScriptSpecialProcessCall). 
        /// 
        /// No params.
        /// </summary>
        public int InitSpecialEpisodePartners
        {
            get
            {
                if (f_initSpecialEpisodePartners)
                    return _initSpecialEpisodePartners;
                _initSpecialEpisodePartners = (int) (298280);
                f_initSpecialEpisodePartners = true;
                return _initSpecialEpisodePartners;
            }
        }
        private bool f_readStringSave;
        private int _readStringSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// </summary>
        public int ReadStringSave
        {
            get
            {
                if (f_readStringSave)
                    return _readStringSave;
                _readStringSave = (int) (298704);
                f_readStringSave = true;
                return _readStringSave;
            }
        }
        private bool f_getCharWidth;
        private int _getCharWidth;

        /// <summary>
        /// Gets the width of a text char.
        /// 
        /// r0: char
        /// return: char width
        /// </summary>
        public int GetCharWidth
        {
            get
            {
                if (f_getCharWidth)
                    return _getCharWidth;
                _getCharWidth = (int) (157744);
                f_getCharWidth = true;
                return _getCharWidth;
            }
        }
        private bool f_getMoveMaxGinsengBoostGround;
        private int _getMoveMaxGinsengBoostGround;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ground_move
        /// return: max ginseng boost
        /// </summary>
        public int GetMoveMaxGinsengBoostGround
        {
            get
            {
                if (f_getMoveMaxGinsengBoostGround)
                    return _getMoveMaxGinsengBoostGround;
                _getMoveMaxGinsengBoostGround = (int) (80792);
                f_getMoveMaxGinsengBoostGround = true;
                return _getMoveMaxGinsengBoostGround;
            }
        }
        private bool f_initDebugStripped1;
        private int _initDebugStripped1;

        /// <summary>
        /// Does nothing, only called in the debug initialization function.
        /// </summary>
        public int InitDebugStripped1
        {
            get
            {
                if (f_initDebugStripped1)
                    return _initDebugStripped1;
                _initDebugStripped1 = (int) (49888);
                f_initDebugStripped1 = true;
                return _initDebugStripped1;
            }
        }
        private bool f_getSentryDutyGamePoints;
        private int _getSentryDutyGamePoints;

        /// <summary>
        /// Gets the points for the associated rank in the footprints minigame.
        /// 
        /// r0: the rank (range 0-4, 1st to 5th)
        /// return: points
        /// </summary>
        public int GetSentryDutyGamePoints
        {
            get
            {
                if (f_getSentryDutyGamePoints)
                    return _getSentryDutyGamePoints;
                _getSentryDutyGamePoints = (int) (329692);
                f_getSentryDutyGamePoints = true;
                return _getSentryDutyGamePoints;
            }
        }
        private bool f_sendAudioCommand;
        private int _sendAudioCommand;

        /// <summary>
        /// Used to send commands to the audio engine (seems to be used mainly to play and stop music)
        /// 
        /// This function calls a stubbed-out one with the string &quot;audio command list&quot;
        /// 
        /// r0: Command to send
        /// </summary>
        public int SendAudioCommand
        {
            get
            {
                if (f_sendAudioCommand)
                    return _sendAudioCommand;
                _sendAudioCommand = (int) (101444);
                f_sendAudioCommand = true;
                return _sendAudioCommand;
            }
        }
        private bool f_closeSynthBin;
        private int _closeSynthBin;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int CloseSynthBin
        {
            get
            {
                if (f_closeSynthBin)
                    return _closeSynthBin;
                _closeSynthBin = (int) (76764);
                f_closeSynthBin = true;
                return _closeSynthBin;
            }
        }
        private bool f_disableIqSkill;
        private int _disableIqSkill;

        /// <summary>
        /// Disables an IQ skill.
        /// 
        /// r0: Pointer to the bitarray containing the list of enabled IQ skills
        /// r1: ID of the skill to disable
        /// </summary>
        public int DisableIqSkill
        {
            get
            {
                if (f_disableIqSkill)
                    return _disableIqSkill;
                _disableIqSkill = (int) (364832);
                f_disableIqSkill = true;
                return _disableIqSkill;
            }
        }
        private bool f_createControlsChart;
        private int _createControlsChart;

        /// <summary>
        /// Creates a window containing a chart of player controls for some context. Also see struct controls_chart.
        /// 
        /// This is usually used for static top-screen control reference charts.
        /// 
        /// If window_params is NULL, CONTROLS_CHART_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: string ID
        /// return: window_id
        /// </summary>
        public int CreateControlsChart
        {
            get
            {
                if (f_createControlsChart)
                    return _createControlsChart;
                _createControlsChart = (int) (196896);
                f_createControlsChart = true;
                return _createControlsChart;
            }
        }
        private bool f_isForbiddenFloor;
        private int _isForbiddenFloor;

        /// <summary>
        /// Related to missions floors forbidden
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon_info
        /// others: ?
        /// return: bool
        /// </summary>
        public int IsForbiddenFloor
        {
            get
            {
                if (f_isForbiddenFloor)
                    return _isForbiddenFloor;
                _isForbiddenFloor = (int) (333984);
                f_isForbiddenFloor = true;
                return _isForbiddenFloor;
            }
        }
        private bool f_getExclusiveItemType;
        private int _getExclusiveItemType;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: ?
        /// </summary>
        public int GetExclusiveItemType
        {
            get
            {
                if (f_getExclusiveItemType)
                    return _getExclusiveItemType;
                _getExclusiveItemType = (int) (59440);
                f_getExclusiveItemType = true;
                return _getExclusiveItemType;
            }
        }
        private bool f_addItemToBag;
        private int _addItemToBag;

        /// <summary>
        /// Attempts to add an item to the bag.
        /// 
        /// r0: item_str
        /// r1: held_by
        /// return: bool item was successfully added to the bag
        /// </summary>
        public int AddItemToBag
        {
            get
            {
                if (f_addItemToBag)
                    return _addItemToBag;
                _addItemToBag = (int) (63788);
                f_addItemToBag = true;
                return _addItemToBag;
            }
        }
        private bool f_strcmpTag;
        private int _strcmpTag;

        /// <summary>
        /// Checks if a null-terminated string s1 either exactly equals a null-terminated string s2, or starts with s2 followed by a ':' or a ']'.
        /// 
        /// r0: s1
        /// r1: s2
        /// return: bool
        /// </summary>
        public int StrcmpTag
        {
            get
            {
                if (f_strcmpTag)
                    return _strcmpTag;
                _strcmpTag = (int) (133664);
                f_strcmpTag = true;
                return _strcmpTag;
            }
        }
        private bool f_isInvalidForMission;
        private int _isInvalidForMission;

        /// <summary>
        /// It's a guess
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon_id
        /// return: bool
        /// </summary>
        public int IsInvalidForMission
        {
            get
            {
                if (f_isInvalidForMission)
                    return _isInvalidForMission;
                _isInvalidForMission = (int) (334356);
                f_isInvalidForMission = true;
                return _isInvalidForMission;
            }
        }
        private bool f_initPreprocessorArgs;
        private int _initPreprocessorArgs;

        /// <summary>
        /// Initializes a struct preprocess_args.
        /// 
        /// r0: preprocessor args pointer
        /// </summary>
        public int InitPreprocessorArgs
        {
            get
            {
                if (f_initPreprocessorArgs)
                    return _initPreprocessorArgs;
                _initPreprocessorArgs = (int) (145588);
                f_initPreprocessorArgs = true;
                return _initPreprocessorArgs;
            }
        }
        private bool f_memcpy16;
        private int _memcpy16;

        /// <summary>
        /// Copies 16-bit values from one buffer to another.
        /// 
        /// r0: dest
        /// r1: src
        /// r2: n (# bytes)
        /// </summary>
        public int Memcpy16
        {
            get
            {
                if (f_memcpy16)
                    return _memcpy16;
                _memcpy16 = (int) (13040);
                f_memcpy16 = true;
                return _memcpy16;
            }
        }
        private bool f_generateAllPossibleDeliverList;
        private int _generateAllPossibleDeliverList;

        /// <summary>
        /// Attempts to add all items in ITEM_DELIVERY_TABLE as entries to a heap-allocated list.
        /// 
        /// If no items are valid for a delivery mission, the heap-allocated list is freed. Otherwise, sets MISSION_DELIVER_LIST_PTR and MISSION_DELIVER_COUNT.
        /// 
        /// return: Number of deliverable items for a mission
        /// </summary>
        public int GenerateAllPossibleDeliverList
        {
            get
            {
                if (f_generateAllPossibleDeliverList)
                    return _generateAllPossibleDeliverList;
                _generateAllPossibleDeliverList = (int) (392268);
                f_generateAllPossibleDeliverList = true;
                return _generateAllPossibleDeliverList;
            }
        }
        private bool f_getItemName;
        private int _getItemName;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item ID
        /// return: item name
        /// </summary>
        public int GetItemName
        {
            get
            {
                if (f_getItemName)
                    return _getItemName;
                _getItemName = (int) (59700);
                f_getItemName = true;
                return _getItemName;
            }
        }
        private bool f_resumeParentMenu;
        private int _resumeParentMenu;

        /// <summary>
        /// Resumes input for a window created with CreateParentMenuInternal. Used for menus that do not close even after selecting an option.
        /// 
        /// r0: window_id
        /// </summary>
        public int ResumeParentMenu
        {
            get
            {
                if (f_resumeParentMenu)
                    return _resumeParentMenu;
                _resumeParentMenu = (int) (175176);
                f_resumeParentMenu = true;
                return _resumeParentMenu;
            }
        }
        private bool f_dungeonToGroundMoveset;
        private int _dungeonToGroundMoveset;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] moveset_str
        /// r1: moveset_dun_str
        /// </summary>
        public int DungeonToGroundMoveset
        {
            get
            {
                if (f_dungeonToGroundMoveset)
                    return _dungeonToGroundMoveset;
                _dungeonToGroundMoveset = (int) (84000);
                f_dungeonToGroundMoveset = true;
                return _dungeonToGroundMoveset;
            }
        }
        private bool f_copyBitsTo;
        private int _copyBitsTo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: write_info
        /// r1: buffer_write
        /// r2: nb_bits
        /// </summary>
        public int CopyBitsTo
        {
            get
            {
                if (f_copyBitsTo)
                    return _copyBitsTo;
                _copyBitsTo = (int) (331000);
                f_copyBitsTo = true;
                return _copyBitsTo;
            }
        }
        private bool f_getRecruitRate1;
        private int _getRecruitRate1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: recruit rate 1
        /// </summary>
        public int GetRecruitRate1
        {
            get
            {
                if (f_getRecruitRate1)
                    return _getRecruitRate1;
                _getRecruitRate1 = (int) (339352);
                f_getRecruitRate1 = true;
                return _getRecruitRate1;
            }
        }
        private bool f_setActiveKecleonShop;
        private int _setActiveKecleonShop;

        /// <summary>
        /// Changes the currently active Kecleon shop. Has one for TEAM_MAIN and TEAM_SPECIAL_EPISODE. TEAM_RESCUE does not
        /// appear to have its own copy of the Kecleon shop it seems to use TEAM_MAIN intead of TEAM_RESCUE.
        /// 
        /// r0: team ID
        /// </summary>
        public int SetActiveKecleonShop
        {
            get
            {
                if (f_setActiveKecleonShop)
                    return _setActiveKecleonShop;
                _setActiveKecleonShop = (int) (67436);
                f_setActiveKecleonShop = true;
                return _setActiveKecleonShop;
            }
        }
        private bool f_unloadCurrentWazaP;
        private int _unloadCurrentWazaP;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int UnloadCurrentWazaP
        {
            get
            {
                if (f_unloadCurrentWazaP)
                    return _unloadCurrentWazaP;
                _unloadCurrentWazaP = (int) (79036);
                f_unloadCurrentWazaP = true;
                return _unloadCurrentWazaP;
            }
        }
        private bool f_getMoveName;
        private int _getMoveName;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: move name
        /// </summary>
        public int GetMoveName
        {
            get
            {
                if (f_getMoveName)
                    return _getMoveName;
                _getMoveName = (int) (79100);
                f_getMoveName = true;
                return _getMoveName;
            }
        }
        private bool f_loadFileInPack;
        private int _loadFileInPack;

        /// <summary>
        /// Load the indexed file from the Pack archive, itself loaded from the ROM.
        /// 
        /// r0: pack file struct
        /// r1: [output] target buffer
        /// r2: file index
        /// return: number of read bytes (identical to the length of the pack from the Table of Content)
        /// </summary>
        public int LoadFileInPack
        {
            get
            {
                if (f_loadFileInPack)
                    return _loadFileInPack;
                _loadFileInPack = (int) (50444);
                f_loadFileInPack = true;
                return _loadFileInPack;
            }
        }
        private bool f_unloadWte;
        private int _unloadWte;

        /// <summary>
        /// Frees the buffer used to store the WTE data in the handle, and sets both pointers to null
        /// 
        /// r0: pointer to wte handle
        /// </summary>
        public int UnloadWte
        {
            get
            {
                if (f_unloadWte)
                    return _unloadWte;
                _unloadWte = (int) (122804);
                f_unloadWte = true;
                return _unloadWte;
            }
        }
        private bool f_loadMonsterMd;
        private int _loadMonsterMd;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int LoadMonsterMd
        {
            get
            {
                if (f_loadMonsterMd)
                    return _loadMonsterMd;
                _loadMonsterMd = (int) (337552);
                f_loadMonsterMd = true;
                return _loadMonsterMd;
            }
        }
        private bool f_isAdvancedMenuActive2;
        private int _isAdvancedMenuActive2;

        /// <summary>
        /// This is a guess, by analogy to IsSimpleMenuActive, which does the same thing. Most of window types also have an analogous function that checks the state value. It's unclear how this relates to the other IsAdvancedMenuActive, or if this guess is completely wrong.
        /// 
        /// Checks if the state of an advanced menu is something other than 7 or 8.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsAdvancedMenuActive2
        {
            get
            {
                if (f_isAdvancedMenuActive2)
                    return _isAdvancedMenuActive2;
                _isAdvancedMenuActive2 = (int) (180144);
                f_isAdvancedMenuActive2 = true;
                return _isAdvancedMenuActive2;
            }
        }
        private bool f_isTrapInvisibleWhenAttacking;
        private int _isTrapInvisibleWhenAttacking;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsTrapInvisibleWhenAttacking
        {
            get
            {
                if (f_isTrapInvisibleWhenAttacking)
                    return _isTrapInvisibleWhenAttacking;
                _isTrapInvisibleWhenAttacking = (int) (333728);
                f_isTrapInvisibleWhenAttacking = true;
                return _isTrapInvisibleWhenAttacking;
            }
        }
        private bool f_getFadeStatus;
        private int _getFadeStatus;

        /// <summary>
        /// Returns 1 if fading to black, 2 if fading to white, 0 otherwise.
        /// 
        /// r0: screen_fade
        /// return: int
        /// </summary>
        public int GetFadeStatus
        {
            get
            {
                if (f_getFadeStatus)
                    return _getFadeStatus;
                _getFadeStatus = (int) (48564);
                f_getFadeStatus = true;
                return _getFadeStatus;
            }
        }
        private bool f_setAnimationForAnimationControlInternal;
        private int _setAnimationForAnimationControlInternal;

        /// <summary>
        /// Set the wan animation (and other related settings) of an animation_control
        /// Used by SetAnimationForAnimationControl
        /// 
        /// r0: animation_control
        /// r1: wan_header
        /// r2: animation group id
        /// r3: animation id
        /// stack[0]: ?
        /// stack[1] (0x4): palette pos low (see the field on animation_control)
        /// stack[2] (0x8): ?
        /// stack[3] (0xC): ?
        /// stack[4] (0x10): palette_bank (directly set to the animation_control field with said name)
        /// </summary>
        public int SetAnimationForAnimationControlInternal
        {
            get
            {
                if (f_setAnimationForAnimationControlInternal)
                    return _setAnimationForAnimationControlInternal;
                _setAnimationForAnimationControlInternal = (int) (115224);
                f_setAnimationForAnimationControlInternal = true;
                return _setAnimationForAnimationControlInternal;
            }
        }
        private bool f_isMoveRangeStringUser;
        private int _isMoveRangeStringUser;

        /// <summary>
        /// Returns whether a move's range string is 19 (&quot;User&quot;).
        /// 
        /// r0: Move pointer
        /// return: True if the move's range string field has a value of 19.
        /// </summary>
        public int IsMoveRangeStringUser
        {
            get
            {
                if (f_isMoveRangeStringUser)
                    return _isMoveRangeStringUser;
                _isMoveRangeStringUser = (int) (81068);
                f_isMoveRangeStringUser = true;
                return _isMoveRangeStringUser;
            }
        }
        private bool f_getBaseForm;
        private int _getBaseForm;

        /// <summary>
        /// Checks if the specified monster ID corresponds to any of the pokémon that have multiple forms and returns the ID of the base form if so. If it doesn't, the same ID is returned.
        /// 
        /// Some of the pokémon included in the check are Castform, Unown, Deoxys, Cherrim, Shaymin, and Giratina
        /// 
        /// r0: Monster ID
        /// return: ID of the base form of the specified monster, or the same if the specified monster doesn't have a base form.
        /// </summary>
        public int GetBaseForm
        {
            get
            {
                if (f_getBaseForm)
                    return _getBaseForm;
                _getBaseForm = (int) (344992);
                f_getBaseForm = true;
                return _getBaseForm;
            }
        }
        private bool f_allKecleonShopsZInit;
        private int _allKecleonShopsZInit;

        /// <summary>
        /// Empties the Kecleon shop for both TEAM_MAIN and TEAM_SPECIAL_EPISODE. TEAM_RESCUE does not appear to have its own
        /// Kecleon shop.
        /// 
        /// No params.
        /// </summary>
        public int AllKecleonShopsZInit
        {
            get
            {
                if (f_allKecleonShopsZInit)
                    return _allKecleonShopsZInit;
                _allKecleonShopsZInit = (int) (67132);
                f_allKecleonShopsZInit = true;
                return _allKecleonShopsZInit;
            }
        }
        private bool f_saveScriptVariableValueAtIndex;
        private int _saveScriptVariableValueAtIndex;

        /// <summary>
        /// Saves the given value to a script variable at some index (for script variables that are arrays).
        /// 
        /// r0: pointer to local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID
        /// r2: value index for the given script var
        /// r3: value to save
        /// </summary>
        public int SaveScriptVariableValueAtIndex
        {
            get
            {
                if (f_saveScriptVariableValueAtIndex)
                    return _saveScriptVariableValueAtIndex;
                _saveScriptVariableValueAtIndex = (int) (310464);
                f_saveScriptVariableValueAtIndex = true;
                return _saveScriptVariableValueAtIndex;
            }
        }
        private bool f_createTextBoxInternal;
        private int _createTextBoxInternal;

        /// <summary>
        /// Creates a window containing simple text, without much advanced functionality. Also see struct text_box.
        /// 
        /// If window_params is NULL, TEXT_BOX_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields.
        /// 
        /// r0: window_params
        /// return: text_box pointer
        /// </summary>
        public int CreateTextBoxInternal
        {
            get
            {
                if (f_createTextBoxInternal)
                    return _createTextBoxInternal;
                _createTextBoxInternal = (int) (195792);
                f_createTextBoxInternal = true;
                return _createTextBoxInternal;
            }
        }
        private bool f_getTreasureBoxChances;
        private int _getTreasureBoxChances;

        /// <summary>
        /// Has something to do with bytes 3C-3E
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: [output] struct_chances
        /// </summary>
        public int GetTreasureBoxChances
        {
            get
            {
                if (f_getTreasureBoxChances)
                    return _getTreasureBoxChances;
                _getTreasureBoxChances = (int) (339480);
                f_getTreasureBoxChances = true;
                return _getTreasureBoxChances;
            }
        }
        private bool f_getNbPrecedingFloors;
        private int _getNbPrecedingFloors;

        /// <summary>
        /// Given a dungeon ID, returns the total amount of floors summed by all the previous dungeons in its group.
        /// 
        /// The value is normally pulled from dungeon_data_list_entry::n_preceding_floors_group, except for dungeons with an ID &gt;= dungeon_id::DUNGEON_NORMAL_FLY_MAZE, for which this function always returns 0.
        /// 
        /// r0: Dungeon ID
        /// return: Number of preceding floors of the dungeon
        /// </summary>
        public int GetNbPrecedingFloors
        {
            get
            {
                if (f_getNbPrecedingFloors)
                    return _getNbPrecedingFloors;
                _getNbPrecedingFloors = (int) (325912);
                f_getNbPrecedingFloors = true;
                return _getNbPrecedingFloors;
            }
        }
        private bool f_doesTacticFollowLeader;
        private int _doesTacticFollowLeader;

        /// <summary>
        /// Returns whether or not the tactic involves following the team leader.
        /// 
        /// r0: tactic_id
        /// return: bool
        /// </summary>
        public int DoesTacticFollowLeader
        {
            get
            {
                if (f_doesTacticFollowLeader)
                    return _doesTacticFollowLeader;
                _doesTacticFollowLeader = (int) (364472);
                f_doesTacticFollowLeader = true;
                return _doesTacticFollowLeader;
            }
        }
        private bool f_dexNumbersEqual;
        private int _dexNumbersEqual;

        /// <summary>
        /// Each Unown is considered as different
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id1
        /// r1: id2
        /// return: bool
        /// </summary>
        public int DexNumbersEqual
        {
            get
            {
                if (f_dexNumbersEqual)
                    return _dexNumbersEqual;
                _dexNumbersEqual = (int) (348480);
                f_dexNumbersEqual = true;
                return _dexNumbersEqual;
            }
        }
        private bool f_joinedAtRangeCheck2;
        private int _joinedAtRangeCheck2;

        /// <summary>
        /// Returns whether a certain joined_at field value is equal to dungeon_id::DUNGEON_BEACH or is between dungeon_id::DUNGEON_DUMMY_0xEC and dungeon_id::DUNGEON_DUMMY_0xF0.
        /// 
        /// Irdkwia's notes: IsSEPokemon
        /// 
        /// r0: joined_at id
        /// return: bool
        /// </summary>
        public int JoinedAtRangeCheck2
        {
            get
            {
                if (f_joinedAtRangeCheck2)
                    return _joinedAtRangeCheck2;
                _joinedAtRangeCheck2 = (int) (334488);
                f_joinedAtRangeCheck2 = true;
                return _joinedAtRangeCheck2;
            }
        }
        private bool f_playAdvancedTextBoxInputSound;
        private int _playAdvancedTextBoxInputSound;

        /// <summary>
        /// Calls PlayWindowInputSound for an advanced text box.
        /// 
        /// r0: window_id
        /// r1: index for PlayWindowInputSound
        /// </summary>
        public int PlayAdvancedTextBoxInputSound
        {
            get
            {
                if (f_playAdvancedTextBoxInputSound)
                    return _playAdvancedTextBoxInputSound;
                _playAdvancedTextBoxInputSound = (int) (201244);
                f_playAdvancedTextBoxInputSound = true;
                return _playAdvancedTextBoxInputSound;
            }
        }
        private bool f_stopBgm2;
        private int _stopBgm2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int StopBgm2
        {
            get
            {
                if (f_stopBgm2)
                    return _stopBgm2;
                _stopBgm2 = (int) (106628);
                f_stopBgm2 = true;
                return _stopBgm2;
            }
        }
        private bool f_loadWtuFromBin;
        private int _loadWtuFromBin;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: bin_file_id
        /// r1: file_id
        /// r2: load_type
        /// return: ?
        /// </summary>
        public int LoadWtuFromBin
        {
            get
            {
                if (f_loadWtuFromBin)
                    return _loadWtuFromBin;
                _loadWtuFromBin = (int) (122960);
                f_loadWtuFromBin = true;
                return _loadWtuFromBin;
            }
        }
        private bool f_getSpecialEpisodeType;
        private int _getSpecialEpisodeType;

        /// <summary>
        /// Gets the special episode type from the SPECIAL_EPISODE_TYPE script variable.
        /// 
        /// return: special episode type
        /// </summary>
        public int GetSpecialEpisodeType
        {
            get
            {
                if (f_getSpecialEpisodeType)
                    return _getSpecialEpisodeType;
                _getSpecialEpisodeType = (int) (314404);
                f_getSpecialEpisodeType = true;
                return _getSpecialEpisodeType;
            }
        }
        private bool f_loadWanTableEntryFromPack;
        private int _loadWanTableEntryFromPack;

        /// <summary>
        /// Return an already allocated entry for this sprite if it exists, otherwise allocate a new one and load the optionally compressed sprite.
        /// 
        /// r0: wan_table_ptr
        /// r1: pack_id
        /// r2: file_index
        /// r3: allocation flags
        /// stack[0]: compressed
        /// return: the entry id in wan_table
        /// </summary>
        public int LoadWanTableEntryFromPack
        {
            get
            {
                if (f_loadWanTableEntryFromPack)
                    return _loadWanTableEntryFromPack;
                _loadWanTableEntryFromPack = (int) (120096);
                f_loadWanTableEntryFromPack = true;
                return _loadWanTableEntryFromPack;
            }
        }
        private bool f_loadStringFile;
        private int _loadStringFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int LoadStringFile
        {
            get
            {
                if (f_loadStringFile)
                    return _loadStringFile;
                _loadStringFile = (int) (154340);
                f_loadStringFile = true;
                return _loadStringFile;
            }
        }
        private bool f_isAuraBow;
        private int _isAuraBow;

        /// <summary>
        /// Checks if an item is one of the aura bows received at the start of the game.
        /// 
        /// r0: item ID
        /// return: bool
        /// </summary>
        public int IsAuraBow
        {
            get
            {
                if (f_isAuraBow)
                    return _isAuraBow;
                _isAuraBow = (int) (52380);
                f_isAuraBow = true;
                return _isAuraBow;
            }
        }
        private bool f_getPerformanceFlagWithChecks;
        private int _getPerformanceFlagWithChecks;

        /// <summary>
        /// Returns the value of one of the flags in VAR_PERFORMANCE_PROGRESS_LIST, with some edge cases.
        /// 
        /// List of cases where the function behaves differently:
        /// - If the requested flag is 0, returns true if and only if SCENARIO_MAIN == 0x35
        /// - If the requested flag is 1 or 2 and GAME_MODE == GAME_MODE_SPECIAL_EPISODE, returns true
        /// - If the requested flag is between 3 and 7 (both included) and GAME_MODE == GAME_MODE_SPECIAL_EPISODE, returns false
        /// 
        /// r0: ID of the flag to get
        /// return: Value of the flag
        /// </summary>
        public int GetPerformanceFlagWithChecks
        {
            get
            {
                if (f_getPerformanceFlagWithChecks)
                    return _getPerformanceFlagWithChecks;
                _getPerformanceFlagWithChecks = (int) (314828);
                f_getPerformanceFlagWithChecks = true;
                return _getPerformanceFlagWithChecks;
            }
        }
        private bool f_setMoneyCarried;
        private int _setMoneyCarried;

        /// <summary>
        /// Sets the amount of money the player is carrying, clamping the value to the range [0, MAX_MONEY_CARRIED].
        /// 
        /// r0: new value
        /// </summary>
        public int SetMoneyCarried
        {
            get
            {
                if (f_setMoneyCarried)
                    return _setMoneyCarried;
                _setMoneyCarried = (int) (60868);
                f_setMoneyCarried = true;
                return _setMoneyCarried;
            }
        }
        private bool f_getNbDungeonsCleared;
        private int _getNbDungeonsCleared;

        /// <summary>
        /// Gets the number of dungeons cleared.
        /// 
        /// return: the number of dungeons cleared
        /// </summary>
        public int GetNbDungeonsCleared
        {
            get
            {
                if (f_getNbDungeonsCleared)
                    return _getNbDungeonsCleared;
                _getNbDungeonsCleared = (int) (327588);
                f_getNbDungeonsCleared = true;
                return _getNbDungeonsCleared;
            }
        }
        private bool f_memZero32;
        private int _memZero32;

        /// <summary>
        /// Zeros a buffer of 32-bit values.
        /// 
        /// r0: ptr
        /// r1: len (# bytes)
        /// </summary>
        public int MemZero32
        {
            get
            {
                if (f_memZero32)
                    return _memZero32;
                _memZero32 = (int) (12936);
                f_memZero32 = true;
                return _memZero32;
            }
        }
        private bool f_getNbFriendRescues;
        private int _getNbFriendRescues;

        /// <summary>
        /// Gets the number of successful friend rescues.
        /// 
        /// return: the number of successful friend rescues
        /// </summary>
        public int GetNbFriendRescues
        {
            get
            {
                if (f_getNbFriendRescues)
                    return _getNbFriendRescues;
                _getNbFriendRescues = (int) (327680);
                f_getNbFriendRescues = true;
                return _getNbFriendRescues;
            }
        }
        private bool f_getNbRecruited;
        private int _getNbRecruited;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: recruit_str
        /// </summary>
        public int GetNbRecruited
        {
            get
            {
                if (f_getNbRecruited)
                    return _getNbRecruited;
                _getNbRecruited = (int) (349680);
                f_getNbRecruited = true;
                return _getNbRecruited;
            }
        }
        private bool f_copyItemAtIdx;
        private int _copyItemAtIdx;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: index
        /// r1: [output] item_ptr
        /// return: exists
        /// </summary>
        public int CopyItemAtIdx
        {
            get
            {
                if (f_copyItemAtIdx)
                    return _copyItemAtIdx;
                _copyItemAtIdx = (int) (62344);
                f_copyItemAtIdx = true;
                return _copyItemAtIdx;
            }
        }
        private bool f_getDungeonMode;
        private int _getDungeonMode;

        /// <summary>
        /// Returns the mode of the specified dungeon
        /// 
        /// r0: Dungeon ID
        /// return: Dungeon mode
        /// </summary>
        public int GetDungeonMode
        {
            get
            {
                if (f_getDungeonMode)
                    return _getDungeonMode;
                _getDungeonMode = (int) (316116);
                f_getDungeonMode = true;
                return _getDungeonMode;
            }
        }
        private bool f_stopSe;
        private int _stopSe;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int StopSe
        {
            get
            {
                if (f_stopSe)
                    return _stopSe;
                _stopSe = (int) (109184);
                f_stopSe = true;
                return _stopSe;
            }
        }
        private bool f_getNextIqSkill;
        private int _getNextIqSkill;

        /// <summary>
        /// Returns the next IQ skill that a given monster will learn given its current IQ value, or IQ_NONE if the monster won't learn any more skills.
        /// 
        /// r0: Monster ID
        /// r1: Monster IQ
        /// return: ID of the next skill learned by the monster, or IQ_NONE if the monster won't learn any more skills.
        /// </summary>
        public int GetNextIqSkill
        {
            get
            {
                if (f_getNextIqSkill)
                    return _getNextIqSkill;
                _getNextIqSkill = (int) (365216);
                f_getNextIqSkill = true;
                return _getNextIqSkill;
            }
        }
        private bool f_getEquivBulkItemIdxInStorage;
        private int _getEquivBulkItemIdxInStorage;

        /// <summary>
        /// Checks for a storage item equivalent to the bulk_item and returns the index of the item in storage.
        /// Returns -1 if unable to find an equivalent item.
        /// 
        /// r0: pointer to a bulk_item
        /// return: index in storage
        /// </summary>
        public int GetEquivBulkItemIdxInStorage
        {
            get
            {
                if (f_getEquivBulkItemIdxInStorage)
                    return _getEquivBulkItemIdxInStorage;
                _getEquivBulkItemIdxInStorage = (int) (65528);
                f_getEquivBulkItemIdxInStorage = true;
                return _getEquivBulkItemIdxInStorage;
            }
        }
        private bool f_getSimpleMenuResult;
        private int _getSimpleMenuResult;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: window_id
        /// return: ?
        /// </summary>
        public int GetSimpleMenuResult
        {
            get
            {
                if (f_getSimpleMenuResult)
                    return _getSimpleMenuResult;
                _getSimpleMenuResult = (int) (178288);
                f_getSimpleMenuResult = true;
                return _getSimpleMenuResult;
            }
        }
        private bool f_removeItemInStorage;
        private int _removeItemInStorage;

        /// <summary>
        /// Removes a storage item equivalent to the item passed from storage.
        /// 
        /// r0: pointer to an item
        /// return: bool whether an item was removed
        /// </summary>
        public int RemoveItemInStorage
        {
            get
            {
                if (f_removeItemInStorage)
                    return _removeItemInStorage;
                _removeItemInStorage = (int) (66312);
                f_removeItemInStorage = true;
                return _removeItemInStorage;
            }
        }
        private bool f_getMovesetLevelUpPtr;
        private int _getMovesetLevelUpPtr;

        /// <summary>
        /// Given the ID of a monster in the current dungeon, returns a pointer to the list of moves it learns by leveling up and the level in which each move is learnt.
        /// 
        /// The list contains pairs of &lt;encoded move ID, level&gt;. The move ID is encoded and can be 1 or 2 bytes long. GetEncodedHalfword must be used to decode it. The end of the list is marked by a null byte.
        /// 
        /// r0: monster ID
        /// return: Pointer to encoded level-up move list
        /// </summary>
        public int GetMovesetLevelUpPtr
        {
            get
            {
                if (f_getMovesetLevelUpPtr)
                    return _getMovesetLevelUpPtr;
                _getMovesetLevelUpPtr = (int) (80172);
                f_getMovesetLevelUpPtr = true;
                return _getMovesetLevelUpPtr;
            }
        }
        private bool f_getNbPokemonBattled;
        private int _getNbPokemonBattled;

        /// <summary>
        /// Gets the number of different pokémon that battled against you.
        /// 
        /// return: the number of different pokémon that battled against you
        /// </summary>
        public int GetNbPokemonBattled
        {
            get
            {
                if (f_getNbPokemonBattled)
                    return _getNbPokemonBattled;
                _getNbPokemonBattled = (int) (328172);
                f_getNbPokemonBattled = true;
                return _getNbPokemonBattled;
            }
        }
        private bool f_initDebugFlag;
        private int _initDebugFlag;

        /// <summary>
        /// Would have initialized the debug flags.
        /// Does nothing in release binary.
        /// </summary>
        public int InitDebugFlag
        {
            get
            {
                if (f_initDebugFlag)
                    return _initDebugFlag;
                _initDebugFlag = (int) (49556);
                f_initDebugFlag = true;
                return _initDebugFlag;
            }
        }
        private bool f_canLearnIqSkill;
        private int _canLearnIqSkill;

        /// <summary>
        /// Returns whether an IQ skill can be learned with a given IQ amount or not.
        /// 
        /// If the specified amount is 0, it always returns false.
        /// 
        /// r0: IQ amount
        /// r1: IQ skill
        /// return: True if the specified skill can be learned with the specified IQ amount.
        /// </summary>
        public int CanLearnIqSkill
        {
            get
            {
                if (f_canLearnIqSkill)
                    return _canLearnIqSkill;
                _canLearnIqSkill = (int) (364628);
                f_canLearnIqSkill = true;
                return _canLearnIqSkill;
            }
        }
        private bool f_initStandardItem;
        private int _initStandardItem;

        /// <summary>
        /// Wrapper around InitItem with quantity set to 0.
        /// 
        /// r0: pointer to item to initialize
        /// r1: item ID
        /// r2: sticky flag
        /// </summary>
        public int InitStandardItem
        {
            get
            {
                if (f_initStandardItem)
                    return _initStandardItem;
                _initStandardItem = (int) (53216);
                f_initStandardItem = true;
                return _initStandardItem;
            }
        }
        private bool f_getBaseFormCastformCherrimDeoxys;
        private int _getBaseFormCastformCherrimDeoxys;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: base form
        /// </summary>
        public int GetBaseFormCastformCherrimDeoxys
        {
            get
            {
                if (f_getBaseFormCastformCherrimDeoxys)
                    return _getBaseFormCastformCherrimDeoxys;
                _getBaseFormCastformCherrimDeoxys = (int) (345876);
                f_getBaseFormCastformCherrimDeoxys = true;
                return _getBaseFormCastformCherrimDeoxys;
            }
        }
        private bool f_getTalkLine;
        private int _getTalkLine;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: personality_index
        /// r1: group_id
        /// r2: restrictions
        /// return: ?
        /// </summary>
        public int GetTalkLine
        {
            get
            {
                if (f_getTalkLine)
                    return _getTalkLine;
                _getTalkLine = (int) (154712);
                f_getTalkLine = true;
                return _getTalkLine;
            }
        }
        private bool f_fixedPoint64IsZero;
        private int _fixedPoint64IsZero;

        /// <summary>
        /// Checks whether a 64-bit fixed-point number (16 fraction bits) is zero.
        /// 
        /// r0: 64-bit fixed-point number
        /// return: bool
        /// </summary>
        public int FixedPoint64IsZero
        {
            get
            {
                if (f_fixedPoint64IsZero)
                    return _fixedPoint64IsZero;
                _fixedPoint64IsZero = (int) (7464);
                f_fixedPoint64IsZero = true;
                return _fixedPoint64IsZero;
            }
        }
        private bool f_exclusiveItemEffectFlagTest;
        private int _exclusiveItemEffectFlagTest;

        /// <summary>
        /// Tests the exclusive item bitvector for a specific exclusive item effect.
        /// 
        /// r0: the effects bitvector to test
        /// r1: exclusive item effect ID
        /// return: bool
        /// </summary>
        public int ExclusiveItemEffectFlagTest
        {
            get
            {
                if (f_exclusiveItemEffectFlagTest)
                    return _exclusiveItemEffectFlagTest;
                _exclusiveItemEffectFlagTest = (int) (69708);
                f_exclusiveItemEffectFlagTest = true;
                return _exclusiveItemEffectFlagTest;
            }
        }
        private bool f_hasPlayedOldGame;
        private int _hasPlayedOldGame;

        /// <summary>
        /// Returns the value of the VAR_PLAY_OLD_GAME script variable.
        /// 
        /// return: bool
        /// </summary>
        public int HasPlayedOldGame
        {
            get
            {
                if (f_hasPlayedOldGame)
                    return _hasPlayedOldGame;
                _hasPlayedOldGame = (int) (314792);
                f_hasPlayedOldGame = true;
                return _hasPlayedOldGame;
            }
        }
        private bool f_addGuestMonster;
        private int _addGuestMonster;

        /// <summary>
        /// Adds a guest monster to the active team
        /// 
        /// r0: dungeon_init struct for the dungeon that is about to be entered
        /// r1: Number of the guest monster to add. Used when more than one monster is added.
        /// r2: Pointer to the guest monster entry to add to the team (usually located within GUEST_MONSTER_DATA)
        /// </summary>
        public int AddGuestMonster
        {
            get
            {
                if (f_addGuestMonster)
                    return _addGuestMonster;
                _addGuestMonster = (int) (326680);
                f_addGuestMonster = true;
                return _addGuestMonster;
            }
        }
        private bool f_appendProgPos;
        private int _appendProgPos;

        /// <summary>
        /// Write a base message into a string and append the file name and line number to the end in the format &quot;file = '%s'  line = %5d\n&quot;.
        /// 
        /// If no program position info is given, &quot;ProgPos info NULL\n&quot; is appended instead.
        /// 
        /// r0: [output] str
        /// r1: program position info
        /// r2: base message
        /// return: number of characters printed, excluding the null-terminator
        /// </summary>
        public int AppendProgPos
        {
            get
            {
                if (f_appendProgPos)
                    return _appendProgPos;
                _appendProgPos = (int) (49576);
                f_appendProgPos = true;
                return _appendProgPos;
            }
        }
        private bool f_setMainTeamName;
        private int _setMainTeamName;

        /// <summary>
        /// Sets the main team name to the name in the passed buffer.
        /// 
        /// r0: buffer
        /// </summary>
        public int SetMainTeamName
        {
            get
            {
                if (f_setMainTeamName)
                    return _setMainTeamName;
                _setMainTeamName = (int) (331468);
                f_setMainTeamName = true;
                return _setMainTeamName;
            }
        }
        private bool f_setAdvancedTextBoxField0x1C4;
        private int _setAdvancedTextBoxField0x1C4;

        /// <summary>
        /// Sets the value of advanced_text_box::field_0x1c4 to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetAdvancedTextBoxField0x1C4
        {
            get
            {
                if (f_setAdvancedTextBoxField0x1C4)
                    return _setAdvancedTextBoxField0x1C4;
                _setAdvancedTextBoxField0x1C4 = (int) (199320);
                f_setAdvancedTextBoxField0x1C4 = true;
                return _setAdvancedTextBoxField0x1C4;
            }
        }
        private bool f_canMonsterSpawn;
        private int _canMonsterSpawn;

        /// <summary>
        /// Always returns true.
        /// 
        /// This function seems to be a debug switch that the developers may have used to disable the random enemy spawn. 
        /// If it returned false, the call to SpawnMonster inside TrySpawnMonsterAndTickSpawnCounter would not be executed.
        /// 
        /// r0: monster ID
        /// return: bool (always true)
        /// </summary>
        public int CanMonsterSpawn
        {
            get
            {
                if (f_canMonsterSpawn)
                    return _canMonsterSpawn;
                _canMonsterSpawn = (int) (317080);
                f_canMonsterSpawn = true;
                return _canMonsterSpawn;
            }
        }
        private bool f_dumpScriptVariableValues;
        private int _dumpScriptVariableValues;

        /// <summary>
        /// Runs EventFlagBackup, then copies the script variable values table (SCRIPT_VARS_VALUES) to the given pointer.
        /// 
        /// r0: destination pointer for the data dump
        /// return: always 1
        /// </summary>
        public int DumpScriptVariableValues
        {
            get
            {
                if (f_dumpScriptVariableValues)
                    return _dumpScriptVariableValues;
                _dumpScriptVariableValues = (int) (313152);
                f_dumpScriptVariableValues = true;
                return _dumpScriptVariableValues;
            }
        }
        private bool f_isMovesetValidInTimeDarkness;
        private int _isMovesetValidInTimeDarkness;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: moveset_str
        /// return: bool
        /// </summary>
        public int IsMovesetValidInTimeDarkness
        {
            get
            {
                if (f_isMovesetValidInTimeDarkness)
                    return _isMovesetValidInTimeDarkness;
                _isMovesetValidInTimeDarkness = (int) (86188);
                f_isMovesetValidInTimeDarkness = true;
                return _isMovesetValidInTimeDarkness;
            }
        }
        private bool f_deleteAllPossibleDeliverList;
        private int _deleteAllPossibleDeliverList;

        /// <summary>
        /// If MISSION_DELIVER_LIST_PTR is not null, frees its heap-allocated list and nulls MISSION_DELIVER_LIST_PTR and MISSION_DELIVER_COUNT.
        /// 
        /// No params.
        /// </summary>
        public int DeleteAllPossibleDeliverList
        {
            get
            {
                if (f_deleteAllPossibleDeliverList)
                    return _deleteAllPossibleDeliverList;
                _deleteAllPossibleDeliverList = (int) (392328);
                f_deleteAllPossibleDeliverList = true;
                return _deleteAllPossibleDeliverList;
            }
        }
        private bool f_memFree;
        private int _memFree;

        /// <summary>
        /// Frees heap-allocated memory.
        /// 
        /// This function is just a wrapper around MemLocateUnset.
        /// 
        /// r0: pointer
        /// </summary>
        public int MemFree
        {
            get
            {
                if (f_memFree)
                    return _memFree;
                _memFree = (int) (4488);
                f_memFree = true;
                return _memFree;
            }
        }
        private bool f_getReleasedStylus;
        private int _getReleasedStylus;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: stylus_ptr
        /// return: any_activated
        /// </summary>
        public int GetReleasedStylus
        {
            get
            {
                if (f_getReleasedStylus)
                    return _getReleasedStylus;
                _getReleasedStylus = (int) (27676);
                f_getReleasedStylus = true;
                return _getReleasedStylus;
            }
        }
        private bool f_isValidPortrait;
        private int _isValidPortrait;

        /// <summary>
        /// Returns whether this portrait params represents a valid portrait.
        /// 
        /// r0: portrait params pointer
        /// return: bool
        /// </summary>
        public int IsValidPortrait
        {
            get
            {
                if (f_isValidPortrait)
                    return _isValidPortrait;
                _isValidPortrait = (int) (318420);
                f_isValidPortrait = true;
                return _isValidPortrait;
            }
        }
        private bool f_specialProcAddItemToBag;
        private int _specialProcAddItemToBag;

        /// <summary>
        /// Implements SPECIAL_PROC_ADD_ITEM_TO_BAG (see ScriptSpecialProcessCall).
        /// 
        /// r0: pointer to an owned_item
        /// return: bool
        /// </summary>
        public int SpecialProcAddItemToBag
        {
            get
            {
                if (f_specialProcAddItemToBag)
                    return _specialProcAddItemToBag;
                _specialProcAddItemToBag = (int) (63732);
                f_specialProcAddItemToBag = true;
                return _specialProcAddItemToBag;
            }
        }
        private bool f_retrieveFromItemList1;
        private int _retrieveFromItemList1;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon_info
        /// r1: ?
        /// return: ?
        /// </summary>
        public int RetrieveFromItemList1
        {
            get
            {
                if (f_retrieveFromItemList1)
                    return _retrieveFromItemList1;
                _retrieveFromItemList1 = (int) (333884);
                f_retrieveFromItemList1 = true;
                return _retrieveFromItemList1;
            }
        }
        private bool f_getBaseDefensiveStat;
        private int _getBaseDefensiveStat;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// r1: stat index
        /// return: base defense/special defense stat
        /// </summary>
        public int GetBaseDefensiveStat
        {
            get
            {
                if (f_getBaseDefensiveStat)
                    return _getBaseDefensiveStat;
                _getBaseDefensiveStat = (int) (339228);
                f_getBaseDefensiveStat = true;
                return _getBaseDefensiveStat;
            }
        }
        private bool f_setScenarioScriptVar;
        private int _setScenarioScriptVar;

        /// <summary>
        /// Sets the given SCENARIO_* script variable with a given pair of values [val0, val1].
        /// 
        /// In the special case when the ID is VAR_SCENARIO_MAIN, and the set value is different from the old one, the REQUEST_CLEAR_COUNT script variable will be set to 0.
        /// 
        /// r0: script variable ID
        /// r1: val0
        /// r2: val1
        /// </summary>
        public int SetScenarioScriptVar
        {
            get
            {
                if (f_setScenarioScriptVar)
                    return _setScenarioScriptVar;
                _setScenarioScriptVar = (int) (313680);
                f_setScenarioScriptVar = true;
                return _setScenarioScriptVar;
            }
        }
        private bool f_decrementStackItem;
        private int _decrementStackItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_ptr
        /// return: ?
        /// </summary>
        public int DecrementStackItem
        {
            get
            {
                if (f_decrementStackItem)
                    return _decrementStackItem;
                _decrementStackItem = (int) (63292);
                f_decrementStackItem = true;
                return _decrementStackItem;
            }
        }
        private bool f_getCategoryString;
        private int _getCategoryString;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: category
        /// </summary>
        public int GetCategoryString
        {
            get
            {
                if (f_getCategoryString)
                    return _getCategoryString;
                _getCategoryString = (int) (338580);
                f_getCategoryString = true;
                return _getCategoryString;
            }
        }
        private bool f_isRecruitingAllowed;
        private int _isRecruitingAllowed;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int IsRecruitingAllowed
        {
            get
            {
                if (f_isRecruitingAllowed)
                    return _isRecruitingAllowed;
                _isRecruitingAllowed = (int) (333520);
                f_isRecruitingAllowed = true;
                return _isRecruitingAllowed;
            }
        }
        private bool f_readSaveFile;
        private int _readSaveFile;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: save_info
        /// r1: buffer
        /// r2: size
        /// return: status code
        /// </summary>
        public int ReadSaveFile
        {
            get
            {
                if (f_readSaveFile)
                    return _readSaveFile;
                _readSaveFile = (int) (299500);
                f_readSaveFile = true;
                return _readSaveFile;
            }
        }
        private bool f_dungeonSwapIdxToId;
        private int _dungeonSwapIdxToId;

        /// <summary>
        /// Converts an index in DUNGEON_SWAP_ID_TABLE to the corresponding dungeon ID, or DUNGEON_DUMMY_0xFF if the index is -1.
        /// 
        /// r0: index
        /// return: dungeon ID
        /// </summary>
        public int DungeonSwapIdxToId
        {
            get
            {
                if (f_dungeonSwapIdxToId)
                    return _dungeonSwapIdxToId;
                _dungeonSwapIdxToId = (int) (436968);
                f_dungeonSwapIdxToId = true;
                return _dungeonSwapIdxToId;
            }
        }
        private bool f_splitMemBlock;
        private int _splitMemBlock;

        /// <summary>
        /// Given a memory block at a given index, splits off another memory block of the specified size from the end.
        /// 
        /// Since blocks are stored in an array on the memory arena struct, this is essentially an insertion operation, plus some processing on the block being split and its child.
        /// 
        /// r0: memory arena
        /// r1: block index
        /// r2: internal alloc flags
        /// r3: number of bytes to split off
        /// stack[0]: user alloc flags (to assign to the new block)
        /// return: the newly split-off memory block
        /// </summary>
        public int SplitMemBlock
        {
            get
            {
                if (f_splitMemBlock)
                    return _splitMemBlock;
                _splitMemBlock = (int) (4208);
                f_splitMemBlock = true;
                return _splitMemBlock;
            }
        }
        private bool f_updateAdvancedMenu;
        private int _updateAdvancedMenu;

        /// <summary>
        /// Window update function for advanced menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateAdvancedMenu
        {
            get
            {
                if (f_updateAdvancedMenu)
                    return _updateAdvancedMenu;
                _updateAdvancedMenu = (int) (180312);
                f_updateAdvancedMenu = true;
                return _updateAdvancedMenu;
            }
        }
        private bool f_getEvoFamily;
        private int _getEvoFamily;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: monster_str
        /// r1: evo_family_str
        /// return: nb_family
        /// </summary>
        public int GetEvoFamily
        {
            get
            {
                if (f_getEvoFamily)
                    return _getEvoFamily;
                _getEvoFamily = (int) (344396);
                f_getEvoFamily = true;
                return _getEvoFamily;
            }
        }
        private bool f_storeDefaultTeamData;
        private int _storeDefaultTeamData;

        /// <summary>
        /// Sets the name of the team for the main story to the default team name Poképals. Also initializes
        /// the team to Normal Rank and possibly set Secret Rank unlocked to false?
        /// 
        /// No params.
        /// </summary>
        public int StoreDefaultTeamData
        {
            get
            {
                if (f_storeDefaultTeamData)
                    return _storeDefaultTeamData;
                _storeDefaultTeamData = (int) (331268);
                f_storeDefaultTeamData = true;
                return _storeDefaultTeamData;
            }
        }
        private bool f_initICpuClear32;
        private int _initICpuClear32;
        public int InitICpuClear32
        {
            get
            {
                if (f_initICpuClear32)
                    return _initICpuClear32;
                _initICpuClear32 = (int) (2388);
                f_initICpuClear32 = true;
                return _initICpuClear32;
            }
        }
        private bool f_setCollectionMenuField0x1A0;
        private int _setCollectionMenuField0x1A0;

        /// <summary>
        /// Sets collection_menu::field_0x1a0 to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetCollectionMenuField0x1A0
        {
            get
            {
                if (f_setCollectionMenuField0x1A0)
                    return _setCollectionMenuField0x1A0;
                _setCollectionMenuField0x1A0 = (int) (182940);
                f_setCollectionMenuField0x1A0 = true;
                return _setCollectionMenuField0x1A0;
            }
        }
        private bool f_render3d64RectangleMulticolor;
        private int _render3d64RectangleMulticolor;

        /// <summary>
        /// RENDER_3D_FUNCTIONS_64[3]. Renders a render_3d_element_64 with type RENDER64_RECTANGLE_MULTICOLOR.
        /// 
        /// Converts the render_3d_element_64 to a render_3d_element on the render queue of RENDER_3D, with type RENDER_RECTANGLE.
        /// 
        /// r0: render_3d_element_64
        /// </summary>
        public int Render3d64RectangleMulticolor
        {
            get
            {
                if (f_render3d64RectangleMulticolor)
                    return _render3d64RectangleMulticolor;
                _render3d64RectangleMulticolor = (int) (126860);
                f_render3d64RectangleMulticolor = true;
                return _render3d64RectangleMulticolor;
            }
        }
        private bool f_updateCollectionMenu;
        private int _updateCollectionMenu;

        /// <summary>
        /// Window update function for collection menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateCollectionMenu
        {
            get
            {
                if (f_updateCollectionMenu)
                    return _updateCollectionMenu;
                _updateCollectionMenu = (int) (183036);
                f_updateCollectionMenu = true;
                return _updateCollectionMenu;
            }
        }
        private bool f_getCurrentBagCapacity;
        private int _getCurrentBagCapacity;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: bag capacity
        /// </summary>
        public int GetCurrentBagCapacity
        {
            get
            {
                if (f_getCurrentBagCapacity)
                    return _getCurrentBagCapacity;
                _getCurrentBagCapacity = (int) (60972);
                f_getCurrentBagCapacity = true;
                return _getCurrentBagCapacity;
            }
        }
        private bool f_createAdvancedTextBoxWithArg;
        private int _createAdvancedTextBoxWithArg;

        /// <summary>
        /// Calls CreateAdvancedTextBoxInternal with all the selectable items on one page (n_items_per_page = n_items), sets the callback with an argument, and returns the window_id.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: text box callback with arg function
        /// stack[0]: callback argument
        /// stack[1]: number of selectable items
        /// return: window_id
        /// </summary>
        public int CreateAdvancedTextBoxWithArg
        {
            get
            {
                if (f_createAdvancedTextBoxWithArg)
                    return _createAdvancedTextBoxWithArg;
                _createAdvancedTextBoxWithArg = (int) (198872);
                f_createAdvancedTextBoxWithArg = true;
                return _createAdvancedTextBoxWithArg;
            }
        }
        private bool f_addMissionToJobList;
        private int _addMissionToJobList;

        /// <summary>
        /// Adds a mission to the Job List.
        /// 
        /// r0: mission to add
        /// </summary>
        public int AddMissionToJobList
        {
            get
            {
                if (f_addMissionToJobList)
                    return _addMissionToJobList;
                _addMissionToJobList = (int) (390196);
                f_addMissionToJobList = true;
                return _addMissionToJobList;
            }
        }
        private bool f_initPortraitParams;
        private int _initPortraitParams;

        /// <summary>
        /// Initializes a struct portrait_params.
        /// 
        /// The emote is set to PORTRAIT_NONE and the layout to the default. Everything else is initialized to 0.
        /// 
        /// r0: portrait params pointer
        /// </summary>
        public int InitPortraitParams
        {
            get
            {
                if (f_initPortraitParams)
                    return _initPortraitParams;
                _initPortraitParams = (int) (318164);
                f_initPortraitParams = true;
                return _initPortraitParams;
            }
        }
        private bool f_createParentMenuInternal;
        private int _createParentMenuInternal;

        /// <summary>
        /// Creates a window containing a simple textual menu with a list of options that might open submenus when selected. Also see struct simple_menu.
        /// 
        /// Multiple levels of nesting is possible, i.e., a submenu could itself be a parent menu.
        /// 
        /// This is used in various menus that lead to submenus. For example, the top-level ground and dungeon mode menus.
        /// 
        /// If window_params is NULL, PARENT_MENU_DEFAULT_WINDOW_PARAMS will be used. Otherwise, it will be copied onto the window, ignoring the update and contents fields. If window_params::width and/or window_params::height are 0, they will be computed based on the contained text.
        /// 
        /// If window_extra_info is non-NULL, it will be copied onto the window. Note that window_extra_info can only be NULL if there are no window_flags set that require extra info.
        /// 
        /// r0: window_params
        /// r1: window_flags
        /// r2: window_extra_info pointer
        /// r3: heap-allocated simple_menu_items array, the menu takes ownership
        /// return: window_id
        /// </summary>
        public int CreateParentMenuInternal
        {
            get
            {
                if (f_createParentMenuInternal)
                    return _createParentMenuInternal;
                _createParentMenuInternal = (int) (174672);
                f_createParentMenuInternal = true;
                return _createParentMenuInternal;
            }
        }
        private bool f_openAllPackFiles;
        private int _openAllPackFiles;

        /// <summary>
        /// Open the 6 files at PACK_FILE_PATHS_TABLE into PACK_FILES_OPENED. Called during game initialization.
        /// 
        /// No params.
        /// </summary>
        public int OpenAllPackFiles
        {
            get
            {
                if (f_openAllPackFiles)
                    return _openAllPackFiles;
                _openAllPackFiles = (int) (50020);
                f_openAllPackFiles = true;
                return _openAllPackFiles;
            }
        }
        private bool f_getRecruitRate2;
        private int _getRecruitRate2;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: recruit rate 2
        /// </summary>
        public int GetRecruitRate2
        {
            get
            {
                if (f_getRecruitRate2)
                    return _getRecruitRate2;
                _getRecruitRate2 = (int) (339324);
                f_getRecruitRate2 = true;
                return _getRecruitRate2;
            }
        }
        private bool f_getNbFloorsPlusOne;
        private int _getNbFloorsPlusOne;

        /// <summary>
        /// Returns the number of floors of the given dungeon + 1.
        /// 
        /// r0: Dungeon ID
        /// return: Number of floors + 1
        /// </summary>
        public int GetNbFloorsPlusOne
        {
            get
            {
                if (f_getNbFloorsPlusOne)
                    return _getNbFloorsPlusOne;
                _getNbFloorsPlusOne = (int) (325868);
                f_getNbFloorsPlusOne = true;
                return _getNbFloorsPlusOne;
            }
        }
        private bool f_treasureBoxDropsEnabled;
        private int _treasureBoxDropsEnabled;

        /// <summary>
        /// Checks if enemy Treasure Box drops are enabled in the dungeon.
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int TreasureBoxDropsEnabled
        {
            get
            {
                if (f_treasureBoxDropsEnabled)
                    return _treasureBoxDropsEnabled;
                _treasureBoxDropsEnabled = (int) (333352);
                f_treasureBoxDropsEnabled = true;
                return _treasureBoxDropsEnabled;
            }
        }
        private bool f_writeMonsterToSave;
        private int _writeMonsterToSave;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: write_info
        /// r1: ground_monster
        /// </summary>
        public int WriteMonsterToSave
        {
            get
            {
                if (f_writeMonsterToSave)
                    return _writeMonsterToSave;
                _writeMonsterToSave = (int) (366256);
                f_writeMonsterToSave = true;
                return _writeMonsterToSave;
            }
        }
        private bool f_removeEquivItem;
        private int _removeEquivItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: item_ptr
        /// return: ?
        /// </summary>
        public int RemoveEquivItem
        {
            get
            {
                if (f_removeEquivItem)
                    return _removeEquivItem;
                _removeEquivItem = (int) (62976);
                f_removeEquivItem = true;
                return _removeEquivItem;
            }
        }
        private bool f_setAnimationForAnimationControl;
        private int _setAnimationForAnimationControl;

        /// <summary>
        /// Set the animation to play with this animation control, but do not start it.
        /// 
        /// (args same as SetAndPlayAnimationForAnimationControl)
        /// r0: animation_control
        /// r1: animation key (either an animation or animation group depending on the type of sprite and if it does have animation group with this animation key as index)
        /// r2: direction_id (unsure) (the key to the wan_animation in itself, only used when animation key represent a wan_animation_group)
        /// r3: ?
        /// stack[0]: low_palette_pos
        /// stack[1] (0x4): ?
        /// stack[2] (0x8): ?
        /// stack[3] (0xC): ?
        /// </summary>
        public int SetAnimationForAnimationControl
        {
            get
            {
                if (f_setAnimationForAnimationControl)
                    return _setAnimationForAnimationControl;
                _setAnimationForAnimationControl = (int) (115560);
                f_setAnimationForAnimationControl = true;
                return _setAnimationForAnimationControl;
            }
        }
        private bool f_saveScriptVariableValueBytes;
        private int _saveScriptVariableValueBytes;

        /// <summary>
        /// Saves some number of bytes to the given script variable.
        /// 
        /// r0: script variable ID
        /// r1: bytes to save
        /// r2: number of bytes
        /// </summary>
        public int SaveScriptVariableValueBytes
        {
            get
            {
                if (f_saveScriptVariableValueBytes)
                    return _saveScriptVariableValueBytes;
                _saveScriptVariableValueBytes = (int) (311044);
                f_saveScriptVariableValueBytes = true;
                return _saveScriptVariableValueBytes;
            }
        }
        private bool f_setAdventureLogDungeonFloor;
        private int _setAdventureLogDungeonFloor;

        /// <summary>
        /// Sets the current dungeon floor pair.
        /// 
        /// r0: struct dungeon_floor_pair
        /// </summary>
        public int SetAdventureLogDungeonFloor
        {
            get
            {
                if (f_setAdventureLogDungeonFloor)
                    return _setAdventureLogDungeonFloor;
                _setAdventureLogDungeonFloor = (int) (327028);
                f_setAdventureLogDungeonFloor = true;
                return _setAdventureLogDungeonFloor;
            }
        }
        private bool f_getRandomMovementChance;
        private int _getRandomMovementChance;

        /// <summary>
        /// Returns dungeon_restriction::random_movement_chance for the specified dungeon ID.
        /// 
        /// r0: dungeon ID
        /// return: Random movement chance
        /// </summary>
        public int GetRandomMovementChance
        {
            get
            {
                if (f_getRandomMovementChance)
                    return _getRandomMovementChance;
                _getRandomMovementChance = (int) (333600);
                f_getRandomMovementChance = true;
                return _getRandomMovementChance;
            }
        }
        private bool f_getNotifyNote;
        private int _getNotifyNote;

        /// <summary>
        /// Returns the current value of NOTIFY_NOTE.
        /// 
        /// return: bool
        /// </summary>
        public int GetNotifyNote
        {
            get
            {
                if (f_getNotifyNote)
                    return _getNotifyNote;
                _getNotifyNote = (int) (296892);
                f_getNotifyNote = true;
                return _getNotifyNote;
            }
        }
        private bool f_memAlloc;
        private int _memAlloc;

        /// <summary>
        /// Allocates some memory on the heap, returning a pointer to the starting address.
        /// 
        /// Memory allocation is done with region-based memory management. See MEMORY_ALLOCATION_TABLE for more information.
        /// 
        /// This function is just a wrapper around MemLocateSet.
        /// 
        /// r0: length in bytes
        /// r1: flags (see the comment on struct mem_block::user_flags)
        /// return: pointer
        /// </summary>
        public int MemAlloc
        {
            get
            {
                if (f_memAlloc)
                    return _memAlloc;
                _memAlloc = (int) (4464);
                f_memAlloc = true;
                return _memAlloc;
            }
        }
        private bool f_generateKecleonItems2;
        private int _generateKecleonItems2;

        /// <summary>
        /// Generates the Kecleon Shop items for the TMs/Orbs shop in Treasure Town.
        /// 
        /// r0: kecleon_shop_version to use
        /// </summary>
        public int GenerateKecleonItems2
        {
            get
            {
                if (f_generateKecleonItems2)
                    return _generateKecleonItems2;
                _generateKecleonItems2 = (int) (69120);
                f_generateKecleonItems2 = true;
                return _generateKecleonItems2;
            }
        }
        private bool f_playSeVolumeWrapper;
        private int _playSeVolumeWrapper;

        /// <summary>
        /// Wrapper for PlaySeVolume. Takes an index and uses it to determine the ID of the sound to play.
        /// 
        /// r0: Index
        /// </summary>
        public int PlaySeVolumeWrapper
        {
            get
            {
                if (f_playSeVolumeWrapper)
                    return _playSeVolumeWrapper;
                _playSeVolumeWrapper = (int) (97640);
                f_playSeVolumeWrapper = true;
                return _playSeVolumeWrapper;
            }
        }
        private bool f_itemToBulkItem;
        private int _itemToBulkItem;

        /// <summary>
        /// Convert an item into an equivalent bulk_item.
        /// 
        /// r0: pointer to bulk_item to initialize
        /// r1: pointer to item
        /// </summary>
        public int ItemToBulkItem
        {
            get
            {
                if (f_itemToBulkItem)
                    return _itemToBulkItem;
                _itemToBulkItem = (int) (53544);
                f_itemToBulkItem = true;
                return _itemToBulkItem;
            }
        }
        private bool f_isAdventureLogNotEmpty;
        private int _isAdventureLogNotEmpty;

        /// <summary>
        /// Checks if at least one of the adventure log entries is completed.
        /// 
        /// return: bool
        /// </summary>
        public int IsAdventureLogNotEmpty
        {
            get
            {
                if (f_isAdventureLogNotEmpty)
                    return _isAdventureLogNotEmpty;
                _isAdventureLogNotEmpty = (int) (327420);
                f_isAdventureLogNotEmpty = true;
                return _isAdventureLogNotEmpty;
            }
        }
        private bool f_initScenarioScriptVars;
        private int _initScenarioScriptVars;

        /// <summary>
        /// Initializes most of the SCENARIO_* script variables (except SCENARIO_TALK_BIT_FLAG for some reason). Also initializes the PLAY_OLD_GAME variable.
        /// 
        /// No params.
        /// </summary>
        public int InitScenarioScriptVars
        {
            get
            {
                if (f_initScenarioScriptVars)
                    return _initScenarioScriptVars;
                _initScenarioScriptVars = (int) (313280);
                f_initScenarioScriptVars = true;
                return _initScenarioScriptVars;
            }
        }
        private bool f_doesNotSaveWhenEntering;
        private int _doesNotSaveWhenEntering;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: bool
        /// </summary>
        public int DoesNotSaveWhenEntering
        {
            get
            {
                if (f_doesNotSaveWhenEntering)
                    return _doesNotSaveWhenEntering;
                _doesNotSaveWhenEntering = (int) (333312);
                f_doesNotSaveWhenEntering = true;
                return _doesNotSaveWhenEntering;
            }
        }
        private bool f_scriptVariablesEqual;
        private int _scriptVariablesEqual;

        /// <summary>
        /// Checks if two script variables have equal values. For arrays, compares elementwise for the length of the first variable.
        /// 
        /// r0: pointer to the local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID 1
        /// r2: script variable ID 2
        /// return: true if values are equal, false otherwise
        /// </summary>
        public int ScriptVariablesEqual
        {
            get
            {
                if (f_scriptVariablesEqual)
                    return _scriptVariablesEqual;
                _scriptVariablesEqual = (int) (311120);
                f_scriptVariablesEqual = true;
                return _scriptVariablesEqual;
            }
        }
        private bool f_strcpyName;
        private int _strcpyName;

        /// <summary>
        /// A special version of strcpy for handling names. Appears to use character 0x7E as some kind of
        /// formatting character in NA?
        /// 
        /// r0: dst
        /// r1: src
        /// </summary>
        public int StrcpyName
        {
            get
            {
                if (f_strcpyName)
                    return _strcpyName;
                _strcpyName = (int) (152828);
                f_strcpyName = true;
                return _strcpyName;
            }
        }
        private bool f_memAllocFlagsToBlockType;
        private int _memAllocFlagsToBlockType;

        /// <summary>
        /// Converts the internal alloc flags bitfield (struct mem_block field 0x4) to the block type bitfield (struct mem_block field 0x0).
        /// 
        /// r0: internal alloc flags
        /// return: block type flags
        /// </summary>
        public int MemAllocFlagsToBlockType
        {
            get
            {
                if (f_memAllocFlagsToBlockType)
                    return _memAllocFlagsToBlockType;
                _memAllocFlagsToBlockType = (int) (3908);
                f_memAllocFlagsToBlockType = true;
                return _memAllocFlagsToBlockType;
            }
        }
        private bool f_loadM2nAndN2m;
        private int _loadM2nAndN2m;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int LoadM2nAndN2m
        {
            get
            {
                if (f_loadM2nAndN2m)
                    return _loadM2nAndN2m;
                _loadM2nAndN2m = (int) (339724);
                f_loadM2nAndN2m = true;
                return _loadM2nAndN2m;
            }
        }
        private bool f_preprocessString;
        private int _preprocessString;

        /// <summary>
        /// An enhanced sprintf, which recognizes certain tags and replaces them with appropiate game values.
        /// This function can also be used to simply insert values passed within the preprocessor args
        /// 
        /// The tags utilized for this function are lowercase, it might produce uppercase tags
        /// that only are used when the text is being typewrited into a message box
        /// 
        /// Irdkwia's notes: MenuCreateOptionString
        /// 
        /// r0: [output] formatted string
        /// r1: maximum capacity of the output buffer
        /// r2: input format string
        /// r3: preprocessor flags
        /// stack[0]: pointer to preprocessor args
        /// </summary>
        public int PreprocessString
        {
            get
            {
                if (f_preprocessString)
                    return _preprocessString;
                _preprocessString = (int) (140780);
                f_preprocessString = true;
                return _preprocessString;
            }
        }
        private bool f_atoiTag;
        private int _atoiTag;

        /// <summary>
        /// Parses a null-terminated string to a base-10 integer, reading digit characters between '0' and '9' until ':', ']', or the end of the string is encountered.
        /// 
        /// Any characters that are not digits, ':', or ']' are ignored, and the string is converted as if those characters were removed from the string.
        /// 
        /// r0: string to convert
        /// return: int
        /// </summary>
        public int AtoiTag
        {
            get
            {
                if (f_atoiTag)
                    return _atoiTag;
                _atoiTag = (int) (133732);
                f_atoiTag = true;
                return _atoiTag;
            }
        }
        private bool f_closeDebugMenu;
        private int _closeDebugMenu;

        /// <summary>
        /// Closes a window created with CreateDebugMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseDebugMenu
        {
            get
            {
                if (f_closeDebugMenu)
                    return _closeDebugMenu;
                _closeDebugMenu = (int) (188908);
                f_closeDebugMenu = true;
                return _closeDebugMenu;
            }
        }
        private bool f_closeAdvancedMenu;
        private int _closeAdvancedMenu;

        /// <summary>
        /// Closes a window created with CreateAdvancedMenu.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseAdvancedMenu
        {
            get
            {
                if (f_closeAdvancedMenu)
                    return _closeAdvancedMenu;
                _closeAdvancedMenu = (int) (180024);
                f_closeAdvancedMenu = true;
                return _closeAdvancedMenu;
            }
        }
        private bool f_getNameRaw;
        private int _getNameRaw;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dst_ptr
        /// r1: id
        /// </summary>
        public int GetNameRaw
        {
            get
            {
                if (f_getNameRaw)
                    return _getNameRaw;
                _getNameRaw = (int) (337612);
                f_getNameRaw = true;
                return _getNameRaw;
            }
        }
        private bool f_zinitScriptVariable;
        private int _zinitScriptVariable;

        /// <summary>
        /// Zero-initialize the values of the given script variable.
        /// 
        /// r0: pointer to the local variable table (only needed if id &gt;= VAR_LOCAL0)
        /// r1: script variable ID
        /// </summary>
        public int ZinitScriptVariable
        {
            get
            {
                if (f_zinitScriptVariable)
                    return _zinitScriptVariable;
                _zinitScriptVariable = (int) (309100);
                f_zinitScriptVariable = true;
                return _zinitScriptVariable;
            }
        }
        private bool f_getDungeonResultString;
        private int _getDungeonResultString;

        /// <summary>
        /// Returns a string containing some information to be used when displaying the dungeon results screen.
        /// 
        /// The exact string returned depends on the value of r0:
        /// 0: Name of the move that fainted the leader. Empty string if the leader didn't faint.
        /// 1-3: Seems to always result in an empty string.
        /// 4: Name of the pokémon that fainted the leader, or name of the leader if the leader didn't faint.
        /// 5: Name of the fainted leader. Empty string if the leader didn't faint.
        /// 
        /// r0: String to return
        /// return: Pointer to resulting string
        /// </summary>
        public int GetDungeonResultString
        {
            get
            {
                if (f_getDungeonResultString)
                    return _getDungeonResultString;
                _getDungeonResultString = (int) (152228);
                f_getDungeonResultString = true;
                return _getDungeonResultString;
            }
        }
        private bool f_stopBgm;
        private int _stopBgm;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// </summary>
        public int StopBgm
        {
            get
            {
                if (f_stopBgm)
                    return _stopBgm;
                _stopBgm = (int) (105412);
                f_stopBgm = true;
                return _stopBgm;
            }
        }
        private bool f_setCollectionMenuVoidFn;
        private int _setCollectionMenuVoidFn;

        /// <summary>
        /// Sets collection_menu::field_0x1a8 to the given function pointer.
        /// 
        /// r0: window_id
        /// r1: some function pointer?
        /// </summary>
        public int SetCollectionMenuVoidFn
        {
            get
            {
                if (f_setCollectionMenuVoidFn)
                    return _setCollectionMenuVoidFn;
                _setCollectionMenuVoidFn = (int) (182980);
                f_setCollectionMenuVoidFn = true;
                return _setCollectionMenuVoidFn;
            }
        }
        private bool f_getTime;
        private int _getTime;

        /// <summary>
        /// Seems to get the current (system?) time as an IEEE 754 floating-point number.
        /// 
        /// return: current time (maybe in seconds?)
        /// </summary>
        public int GetTime
        {
            get
            {
                if (f_getTime)
                    return _getTime;
                _getTime = (int) (14260);
                f_getTime = true;
                return _getTime;
            }
        }
        private bool f_needsItemToSpawn;
        private int _needsItemToSpawn;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: id
        /// return: bool
        /// </summary>
        public int NeedsItemToSpawn
        {
            get
            {
                if (f_needsItemToSpawn)
                    return _needsItemToSpawn;
                _needsItemToSpawn = (int) (339608);
                f_needsItemToSpawn = true;
                return _needsItemToSpawn;
            }
        }
        private bool f_addItemToBagNoHeld;
        private int _addItemToBagNoHeld;

        /// <summary>
        /// A wrapper around AddItemToBag with held_by being 0 (no holder).
        /// 
        /// r0: item_str
        /// return: bool item was successfully added to the bag
        /// </summary>
        public int AddItemToBagNoHeld
        {
            get
            {
                if (f_addItemToBagNoHeld)
                    return _addItemToBagNoHeld;
                _addItemToBagNoHeld = (int) (63772);
                f_addItemToBagNoHeld = true;
                return _addItemToBagNoHeld;
            }
        }
        private bool f_getNbEvolutions;
        private int _getNbEvolutions;

        /// <summary>
        /// Gets the number of evolutions.
        /// 
        /// return: the number of evolutions
        /// </summary>
        public int GetNbEvolutions
        {
            get
            {
                if (f_getNbEvolutions)
                    return _getNbEvolutions;
                _getNbEvolutions = (int) (327772);
                f_getNbEvolutions = true;
                return _getNbEvolutions;
            }
        }
        private bool f_getMainCharacter3;
        private int _getMainCharacter3;

        /// <summary>
        /// Returns the ground monster data of the third main character for the given game mode, or null if invalid.
        /// 
        /// In normal play, this will be null. During special episodes, this will be the third special episode main character (index 4) if one is present.
        /// 
        /// return: ground monster pointer
        /// </summary>
        public int GetMainCharacter3
        {
            get
            {
                if (f_getMainCharacter3)
                    return _getMainCharacter3;
                _getMainCharacter3 = (int) (351184);
                f_getMainCharacter3 = true;
                return _getMainCharacter3;
            }
        }
        private bool f_sortKecleonItems1;
        private int _sortKecleonItems1;

        /// <summary>
        /// Sorts the items for the normal Kecleon Shop items in Treasure Town.
        /// 
        /// No params.
        /// </summary>
        public int SortKecleonItems1
        {
            get
            {
                if (f_sortKecleonItems1)
                    return _sortKecleonItems1;
                _sortKecleonItems1 = (int) (68092);
                f_sortKecleonItems1 = true;
                return _sortKecleonItems1;
            }
        }
        private bool f_specialEpisodeKecleonShopZInit;
        private int _specialEpisodeKecleonShopZInit;

        /// <summary>
        /// Empties the special episode Kecleon shop.
        /// 
        /// No params.
        /// </summary>
        public int SpecialEpisodeKecleonShopZInit
        {
            get
            {
                if (f_specialEpisodeKecleonShopZInit)
                    return _specialEpisodeKecleonShopZInit;
                _specialEpisodeKecleonShopZInit = (int) (67324);
                f_specialEpisodeKecleonShopZInit = true;
                return _specialEpisodeKecleonShopZInit;
            }
        }
        private bool f_refillTeam;
        private int _refillTeam;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int RefillTeam
        {
            get
            {
                if (f_refillTeam)
                    return _refillTeam;
                _refillTeam = (int) (360660);
                f_refillTeam = true;
                return _refillTeam;
            }
        }
        private bool f_addBulkItemToStorage;
        private int _addBulkItemToStorage;

        /// <summary>
        /// Attempts to add the bulk_item to storage.
        /// Implements SPECIAL_PROC_ADD_ITEM_TO_STORAGE (see ScriptSpecialProcessCall).
        /// 
        /// r0: pointer to a bulk_item
        /// return: bool whether an item was added
        /// </summary>
        public int AddBulkItemToStorage
        {
            get
            {
                if (f_addBulkItemToStorage)
                    return _addBulkItemToStorage;
                _addBulkItemToStorage = (int) (66500);
                f_addBulkItemToStorage = true;
                return _addBulkItemToStorage;
            }
        }
        private bool f_getDexNumberVeneer;
        private int _getDexNumberVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for GetDexNumber.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: id
        /// return: dex number
        /// </summary>
        public int GetDexNumberVeneer
        {
            get
            {
                if (f_getDexNumberVeneer)
                    return _getDexNumberVeneer;
                _getDexNumberVeneer = (int) (346096);
                f_getDexNumberVeneer = true;
                return _getDexNumberVeneer;
            }
        }
        private bool f_incrementNbAdventures;
        private int _incrementNbAdventures;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// No params.
        /// </summary>
        public int IncrementNbAdventures
        {
            get
            {
                if (f_incrementNbAdventures)
                    return _incrementNbAdventures;
                _incrementNbAdventures = (int) (317008);
                f_incrementNbAdventures = true;
                return _incrementNbAdventures;
            }
        }
        private bool f_initMemAllocTable;
        private int _initMemAllocTable;

        /// <summary>
        /// Initializes MEMORY_ALLOCATION_TABLE.
        /// 
        /// Sets up the default memory arena, sets the default memory allocator parameters (calls SetMemAllocatorParams(0, 0)), and does some other stuff.
        /// 
        /// No params.
        /// </summary>
        public int InitMemAllocTable
        {
            get
            {
                if (f_initMemAllocTable)
                    return _initMemAllocTable;
                _initMemAllocTable = (int) (3552);
                f_initMemAllocTable = true;
                return _initMemAllocTable;
            }
        }
        private bool f_isCollectionMenuActive;
        private int _isCollectionMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a collection menu is something other than 6 or 7.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsCollectionMenuActive
        {
            get
            {
                if (f_isCollectionMenuActive)
                    return _isCollectionMenuActive;
                _isCollectionMenuActive = (int) (182812);
                f_isCollectionMenuActive = true;
                return _isCollectionMenuActive;
            }
        }
        private bool f_loadOverlay;
        private int _loadOverlay;

        /// <summary>
        /// Loads an overlay from ROM by its group ID.
        /// 
        /// See the LOADED_OVERLAY_GROUP_* data symbols or enum overlay_group_id in the C headers for a mapping between group ID and overlay number.
        /// 
        /// r0: group ID of the overlay to load
        /// </summary>
        public int LoadOverlay
        {
            get
            {
                if (f_loadOverlay)
                    return _loadOverlay;
                _loadOverlay = (int) (16556);
                f_loadOverlay = true;
                return _loadOverlay;
            }
        }
        private bool f_getMaxItemsAllowed;
        private int _getMaxItemsAllowed;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: max items allowed
        /// </summary>
        public int GetMaxItemsAllowed
        {
            get
            {
                if (f_getMaxItemsAllowed)
                    return _getMaxItemsAllowed;
                _getMaxItemsAllowed = (int) (333432);
                f_getMaxItemsAllowed = true;
                return _getMaxItemsAllowed;
            }
        }
        private bool f_applyProteinBoostToGroundMonster;
        private int _applyProteinBoostToGroundMonster;

        /// <summary>
        /// Applies the attack boost from Protein to the target monster.
        /// 
        /// r0: ground monster pointer
        /// r1: [output] pointer to attempted attack boost, if not NULL
        /// return: actual attack boost
        /// </summary>
        public int ApplyProteinBoostToGroundMonster
        {
            get
            {
                if (f_applyProteinBoostToGroundMonster)
                    return _applyProteinBoostToGroundMonster;
                _applyProteinBoostToGroundMonster = (int) (71604);
                f_applyProteinBoostToGroundMonster = true;
                return _applyProteinBoostToGroundMonster;
            }
        }
        private bool f_getWanForAnimationControl;
        private int _getWanForAnimationControl;

        /// <summary>
        /// Return the WAN to use for the given animation control
        /// Return the override if it exists, otherwise look up the sprite id in WAN_TABLE
        /// 
        /// r0: animation_control
        /// return: wan_header
        /// </summary>
        public int GetWanForAnimationControl
        {
            get
            {
                if (f_getWanForAnimationControl)
                    return _getWanForAnimationControl;
                _getWanForAnimationControl = (int) (115844);
                f_getWanForAnimationControl = true;
                return _getWanForAnimationControl;
            }
        }
        private bool f_canMonsterBeUsedForMissionWrapper;
        private int _canMonsterBeUsedForMissionWrapper;

        /// <summary>
        /// Calls CanMonsterBeUsedForMission with r1 = 1.
        /// 
        /// r0: Monster ID
        /// return: Result of CanMonsterBeUsedForMission
        /// </summary>
        public int CanMonsterBeUsedForMissionWrapper
        {
            get
            {
                if (f_canMonsterBeUsedForMissionWrapper)
                    return _canMonsterBeUsedForMissionWrapper;
                _canMonsterBeUsedForMissionWrapper = (int) (404948);
                f_canMonsterBeUsedForMissionWrapper = true;
                return _canMonsterBeUsedForMissionWrapper;
            }
        }
        private bool f_checkTeamMemberIdx;
        private int _checkTeamMemberIdx;

        /// <summary>
        /// Checks if a team member's member index (team_member::member_idx) is equal to certain values.
        /// 
        /// This is known to return true for some or all of the guest monsters.
        /// 
        /// r0: member index
        /// return: True if the value is equal to 0x55AA or 0x5AA5
        /// </summary>
        public int CheckTeamMemberIdx
        {
            get
            {
                if (f_checkTeamMemberIdx)
                    return _checkTeamMemberIdx;
                _checkTeamMemberIdx = (int) (353760);
                f_checkTeamMemberIdx = true;
                return _checkTeamMemberIdx;
            }
        }
        private bool f_decompressAtFromMemoryPointer;
        private int _decompressAtFromMemoryPointer;

        /// <summary>
        /// Overwrites r3 probably passed to match DecompressAtHalf's definition.
        /// 
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: addr_decomp
        /// r1: expected_size
        /// r2: AT pointer
        /// return: ?
        /// </summary>
        public int DecompressAtFromMemoryPointer
        {
            get
            {
                if (f_decompressAtFromMemoryPointer)
                    return _decompressAtFromMemoryPointer;
                _decompressAtFromMemoryPointer = (int) (131060);
                f_decompressAtFromMemoryPointer = true;
                return _decompressAtFromMemoryPointer;
            }
        }
        private bool f_getDebugLogFlag;
        private int _getDebugLogFlag;

        /// <summary>
        /// Should return the value of the specified debug log flag. Just returns 0 in the final binary.
        /// 
        /// r0: flag ID
        /// return: flag value
        /// </summary>
        public int GetDebugLogFlag
        {
            get
            {
                if (f_getDebugLogFlag)
                    return _getDebugLogFlag;
                _getDebugLogFlag = (int) (49852);
                f_getDebugLogFlag = true;
                return _getDebugLogFlag;
            }
        }
        private bool f_calcChecksum;
        private int _calcChecksum;

        /// <summary>
        /// Calculates the checksum of the save file and stores it at the start of the data.
        /// 
        /// r0: Pointer to a buffer containing the save data
        /// r1: Size in bytes
        /// </summary>
        public int CalcChecksum
        {
            get
            {
                if (f_calcChecksum)
                    return _calcChecksum;
                _calcChecksum = (int) (299584);
                f_calcChecksum = true;
                return _calcChecksum;
            }
        }
        private bool f_getExclusiveItemForMonsterFromBag;
        private int _getExclusiveItemForMonsterFromBag;

        /// <summary>
        /// Checks the bag for any exclusive item that applies to the monster or type(s) and copies that item
        /// into the passed item struct.
        /// 
        /// r0: [output] item_struct
        /// r1: excl_type
        /// r2: monster ID
        /// r3: type ID 1
        /// stack[0]: type ID 2
        /// return: bool whether an exclusive item was found
        /// </summary>
        public int GetExclusiveItemForMonsterFromBag
        {
            get
            {
                if (f_getExclusiveItemForMonsterFromBag)
                    return _getExclusiveItemForMonsterFromBag;
                _getExclusiveItemForMonsterFromBag = (int) (70164);
                f_getExclusiveItemForMonsterFromBag = true;
                return _getExclusiveItemForMonsterFromBag;
            }
        }
        private bool f_updateControlsChart;
        private int _updateControlsChart;

        /// <summary>
        /// Window update function for controls charts.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateControlsChart
        {
            get
            {
                if (f_updateControlsChart)
                    return _updateControlsChart;
                _updateControlsChart = (int) (197124);
                f_updateControlsChart = true;
                return _updateControlsChart;
            }
        }
        private bool f_writeQuickSaveInfo;
        private int _writeQuickSaveInfo;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: buffer
        /// r1: size
        /// </summary>
        public int WriteQuickSaveInfo
        {
            get
            {
                if (f_writeQuickSaveInfo)
                    return _writeQuickSaveInfo;
                _writeQuickSaveInfo = (int) (300388);
                f_writeQuickSaveInfo = true;
                return _writeQuickSaveInfo;
            }
        }
        private bool f_setActiveTeam;
        private int _setActiveTeam;

        /// <summary>
        /// Sets the specified team to active in TEAM_MEMBER_TABLE.
        /// 
        /// r0: team ID
        /// </summary>
        public int SetActiveTeam
        {
            get
            {
                if (f_setActiveTeam)
                    return _setActiveTeam;
                _setActiveTeam = (int) (353864);
                f_setActiveTeam = true;
                return _setActiveTeam;
            }
        }
        private bool f_getItemMoveId16;
        private int _getItemMoveId16;

        /// <summary>
        /// Wraps GetItemMoveId, ensuring that the return value is 16-bit.
        /// 
        /// r0: item ID
        /// return: move ID
        /// </summary>
        public int GetItemMoveId16
        {
            get
            {
                if (f_getItemMoveId16)
                    return _getItemMoveId16;
                _getItemMoveId16 = (int) (52100);
                f_getItemMoveId16 = true;
                return _getItemMoveId16;
            }
        }
        private bool f_geomSetTexImageParam;
        private int _geomSetTexImageParam;

        /// <summary>
        /// Send the TEXIMAGE_PARAM geometry engine command, that defines some parameters for the texture
        /// See http://problemkaputt.de/gbatek.htm#ds3dtextureattributes for more information on the parameters
        /// 
        /// r0: texture format
        /// r1: texture coordinates transformation modes
        /// r2: texture S-Size
        /// r3: texture T-Size
        /// stack[0] (0x0): repeat in S (bit 0) and/or T (bit 1) direction
        /// stack[1] (0x4): flip in S (bit 0) and/or T (bit 1) direction
        /// stack[2] (0x8): What to make of color 0 (bit 29)
        /// stack[3] (0xC): Texture VRAM offset divided by 8
        /// </summary>
        public int GeomSetTexImageParam
        {
            get
            {
                if (f_geomSetTexImageParam)
                    return _geomSetTexImageParam;
                _geomSetTexImageParam = (int) (124208);
                f_geomSetTexImageParam = true;
                return _geomSetTexImageParam;
            }
        }
        private bool f_getEquippedThrowableItem;
        private int _getEquippedThrowableItem;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// return: index
        /// </summary>
        public int GetEquippedThrowableItem
        {
            get
            {
                if (f_getEquippedThrowableItem)
                    return _getEquippedThrowableItem;
                _getEquippedThrowableItem = (int) (62128);
                f_getEquippedThrowableItem = true;
                return _getEquippedThrowableItem;
            }
        }
        private bool f_subFixedPoint;
        private int _subFixedPoint;

        /// <summary>
        /// Compute the subtraction of two decimal fixed-point numbers (16 fraction bits).
        /// 
        /// Numbers are in the format {16-bit integer part, 16-bit thousandths}, where the integer part is the lower word. Probably used primarily for belly.
        /// 
        /// r0: number
        /// r1: decrement
        /// return: max(number - decrement, 0)
        /// </summary>
        public int SubFixedPoint
        {
            get
            {
                if (f_subFixedPoint)
                    return _subFixedPoint;
                _subFixedPoint = (int) (332360);
                f_subFixedPoint = true;
                return _subFixedPoint;
            }
        }
        private bool f_geomSwapBuffers;
        private int _geomSwapBuffers;

        /// <summary>
        /// Call the &quot;SWAP_BUFFERS&quot; command. This will swap the geometry buffer. The parameter of 1 is provided, which enables manual Y-sorting of translucent polygons.
        /// 
        /// No params.
        /// </summary>
        public int GeomSwapBuffers
        {
            get
            {
                if (f_geomSwapBuffers)
                    return _geomSwapBuffers;
                _geomSwapBuffers = (int) (124856);
                f_geomSwapBuffers = true;
                return _geomSwapBuffers;
            }
        }
        private bool f_getSpeciesIqSkill;
        private int _getSpeciesIqSkill;

        /// <summary>
        /// Gets the &lt;index&gt;th skill on the list of IQ skills that a given monster species can learn.
        /// 
        /// r0: Species ID
        /// r1: Index (starting at 0)
        /// return: IQ skill ID
        /// </summary>
        public int GetSpeciesIqSkill
        {
            get
            {
                if (f_getSpeciesIqSkill)
                    return _getSpeciesIqSkill;
                _getSpeciesIqSkill = (int) (365028);
                f_getSpeciesIqSkill = true;
                return _getSpeciesIqSkill;
            }
        }
        private bool f_getNbBigTreasureWins;
        private int _getNbBigTreasureWins;

        /// <summary>
        /// Gets the number of big treasure wins.
        /// 
        /// return: the number of big treasure wins
        /// </summary>
        public int GetNbBigTreasureWins
        {
            get
            {
                if (f_getNbBigTreasureWins)
                    return _getNbBigTreasureWins;
                _getNbBigTreasureWins = (int) (328280);
                f_getNbBigTreasureWins = true;
                return _getNbBigTreasureWins;
            }
        }
        private bool f_enableIqSkill;
        private int _enableIqSkill;

        /// <summary>
        /// Enables an IQ skill and disables any other skills that are incompatible with it.
        /// 
        /// r0: Pointer to the bitarray containing the list of enabled IQ skills
        /// r1: ID of the skill to enable
        /// </summary>
        public int EnableIqSkill
        {
            get
            {
                if (f_enableIqSkill)
                    return _enableIqSkill;
                _enableIqSkill = (int) (364912);
                f_enableIqSkill = true;
                return _enableIqSkill;
            }
        }
        private bool f_setSimpleMenuField0x1Ac;
        private int _setSimpleMenuField0x1Ac;

        /// <summary>
        /// Sets simple_menu::field_0x1ac to the given value.
        /// 
        /// r0: window_id
        /// r1: value
        /// </summary>
        public int SetSimpleMenuField0x1Ac
        {
            get
            {
                if (f_setSimpleMenuField0x1Ac)
                    return _setSimpleMenuField0x1Ac;
                _setSimpleMenuField0x1Ac = (int) (179456);
                f_setSimpleMenuField0x1Ac = true;
                return _setSimpleMenuField0x1Ac;
            }
        }
        private bool f_getMaxMembersAllowed;
        private int _getMaxMembersAllowed;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: dungeon ID
        /// return: max members allowed
        /// </summary>
        public int GetMaxMembersAllowed
        {
            get
            {
                if (f_getMaxMembersAllowed)
                    return _getMaxMembersAllowed;
                _getMaxMembersAllowed = (int) (333664);
                f_getMaxMembersAllowed = true;
                return _getMaxMembersAllowed;
            }
        }
        private bool f_initDebug;
        private int _initDebug;

        /// <summary>
        /// Would have initialized debugging-related things, if they were not removed.
        /// As for the release version, does nothing but set DEBUG_IS_INITIALIZED to true.
        /// </summary>
        public int InitDebug
        {
            get
            {
                if (f_initDebug)
                    return _initDebug;
                _initDebug = (int) (49500);
                f_initDebug = true;
                return _initDebug;
            }
        }
        private bool f_isDebugMenuActive;
        private int _isDebugMenuActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a debug menu is something other than 6 or 7.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsDebugMenuActive
        {
            get
            {
                if (f_isDebugMenuActive)
                    return _isDebugMenuActive;
                _isDebugMenuActive = (int) (188952);
                f_isDebugMenuActive = true;
                return _isDebugMenuActive;
            }
        }
        private bool f_isLosableItem;
        private int _isLosableItem;

        /// <summary>
        /// Checks if an item can be lost after fainting in a dungeon. Specifically calls IsAuraBow and checks item::f_in_shop
        /// so that the player can't keep an aura bow they haven't paid for yet.
        /// 
        /// r0: item pointer
        /// return: bool
        /// </summary>
        public int IsLosableItem
        {
            get
            {
                if (f_isLosableItem)
                    return _isLosableItem;
                _isLosableItem = (int) (52416);
                f_isLosableItem = true;
                return _isLosableItem;
            }
        }
        private bool f_strncmpSimple;
        private int _strncmpSimple;

        /// <summary>
        /// A simple implementation of the strncmp(3) C library function.
        /// 
        /// This function was probably manually implemented by the developers. See strncmp for what's probably the real libc function.
        /// 
        /// r0: s1
        /// r1: s2
        /// r2: n
        /// return: comparison value
        /// </summary>
        public int StrncmpSimple
        {
            get
            {
                if (f_strncmpSimple)
                    return _strncmpSimple;
                _strncmpSimple = (int) (152696);
                f_strncmpSimple = true;
                return _strncmpSimple;
            }
        }
        private bool f_getInfoMoveGround;
        private int _getInfoMoveGround;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: ground move
        /// r1: move ID
        /// </summary>
        public int GetInfoMoveGround
        {
            get
            {
                if (f_getInfoMoveGround)
                    return _getInfoMoveGround;
                _getInfoMoveGround = (int) (80080);
                f_getInfoMoveGround = true;
                return _getInfoMoveGround;
            }
        }
        private bool f_getNbPokemonJoined;
        private int _getNbPokemonJoined;

        /// <summary>
        /// Gets the number of different pokémon that joined.
        /// 
        /// return: the number of different pokémon that joined
        /// </summary>
        public int GetNbPokemonJoined
        {
            get
            {
                if (f_getNbPokemonJoined)
                    return _getNbPokemonJoined;
                _getNbPokemonJoined = (int) (327876);
                f_getNbPokemonJoined = true;
                return _getNbPokemonJoined;
            }
        }
        private bool f_multiplyFixedPoint64;
        private int _multiplyFixedPoint64;

        /// <summary>
        /// Multiplies two signed 64-bit fixed-point numbers (16 fraction bits) x and y.
        /// 
        /// r0: [output] product (x * y)
        /// r1: x
        /// r2: y
        /// </summary>
        public int MultiplyFixedPoint64
        {
            get
            {
                if (f_multiplyFixedPoint64)
                    return _multiplyFixedPoint64;
                _multiplyFixedPoint64 = (int) (7668);
                f_multiplyFixedPoint64 = true;
                return _multiplyFixedPoint64;
            }
        }
        private bool f_getMoveBasePowerFromId;
        private int _getMoveBasePowerFromId;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: move ID
        /// return: base power
        /// </summary>
        public int GetMoveBasePowerFromId
        {
            get
            {
                if (f_getMoveBasePowerFromId)
                    return _getMoveBasePowerFromId;
                _getMoveBasePowerFromId = (int) (81040);
                f_getMoveBasePowerFromId = true;
                return _getMoveBasePowerFromId;
            }
        }
        private bool f_showPortraitInPortraitBox;
        private int _showPortraitInPortraitBox;

        /// <summary>
        /// Stages a portrait to be rendered in a portrait box at next update (sets portrait_box::buffer_state).
        /// 
        /// If portrait is NULL, the default portrait will be shown (see InitPortraitParams).
        /// 
        /// r0: window_id
        /// r1: portrait params pointer
        /// </summary>
        public int ShowPortraitInPortraitBox
        {
            get
            {
                if (f_showPortraitInPortraitBox)
                    return _showPortraitInPortraitBox;
                _showPortraitInPortraitBox = (int) (194948);
                f_showPortraitInPortraitBox = true;
                return _showPortraitInPortraitBox;
            }
        }
        private bool f_updateTeamSelectionMenu;
        private int _updateTeamSelectionMenu;

        /// <summary>
        /// Window update function for team selection menus.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateTeamSelectionMenu
        {
            get
            {
                if (f_updateTeamSelectionMenu)
                    return _updateTeamSelectionMenu;
                _updateTeamSelectionMenu = (int) (202032);
                f_updateTeamSelectionMenu = true;
                return _updateTeamSelectionMenu;
            }
        }
        private bool f_updateAdvancedTextBox;
        private int _updateAdvancedTextBox;

        /// <summary>
        /// Window update function for advanced text boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateAdvancedTextBox
        {
            get
            {
                if (f_updateAdvancedTextBox)
                    return _updateAdvancedTextBox;
                _updateAdvancedTextBox = (int) (200156);
                f_updateAdvancedTextBox = true;
                return _updateAdvancedTextBox;
            }
        }
        private Arm9Functions m_root;
        private KaitaiStruct m_parent;
        public Arm9Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
