// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// List of functions within OVERLAY11 with relative address locations as their values.
    /// </summary>
    public partial class Overlay11Functions : KaitaiStruct
    {
        public static Overlay11Functions FromFile(string fileName)
        {
            return new Overlay11Functions(new KaitaiStream(fileName));
        }

        public Overlay11Functions(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay11Functions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_setAnimDataFieldsWrapper = false;
            f_jumpToTitleScreen = false;
            f_getIdLiveActor = false;
            f_getCollidingObjectId = false;
            f_getCollidingEventId = false;
            f_funcThatCallsRunNextOpcode = false;
            f_initPartnerFollowDataAndLiveActorList = false;
            f_getSpecialLayoutBackground = false;
            f_getCollisionBoxLiveActor = false;
            f_setMovementRangeLivePerformer = false;
            f_ssbLoad1 = false;
            f_setBlinkLiveObject = false;
            f_getAttributeBitfieldLiveObject = false;
            f_handleTeamStatsGround = false;
            f_scriptCaseProcess = false;
            f_getDungeonMapPos = false;
            f_updateTeamInfoBox = false;
            f_setAttributeBitfieldLivePerformer = false;
            f_setPositionLiveActor = false;
            f_getCollisionBoxCenterLiveActor = false;
            f_setPositionLiveActorVeneer = false;
            f_setPositionInitialLivePerformer = false;
            f_getAnimationStatusLiveActor = false;
            f_stationLoadHanger = false;
            f_getAnimationStatusLivePerformer = false;
            f_prepareMenuAcceptTeamMember = false;
            f_getCollisionBoxLiveObject = false;
            f_resetAttributeBitfieldLivePerformer = false;
            f_isTeamInfoBoxActive = false;
            f_setAttributeBitfieldLiveObjectWrapper = false;
            f_setEffectLiveObject = false;
            f_getIdLiveObject = false;
            f_getRandomNpcJobSubtype = false;
            f_scriptStationLoadTalk = false;
            f_unlockScriptingLock = false;
            f_setDirectionLiveObject = false;
            f_setEffectLiveActor = false;
            f_getRandomNpcJobStillAvailable = false;
            f_setDirectionLiveActor = false;
            f_deleteLiveEvent = false;
            f_setDirectionLivePerformer = false;
            f_setHeightLivePerformer = false;
            f_initRandomNpcJobs = false;
            f_runNextOpcode = false;
            f_getIdLivePerformer = false;
            f_setPositionOffsetLivePerformer = false;
            f_createTopGroundMenu = false;
            f_worldMapSetMode = false;
            f_statusUpdate = false;
            f_setMovementRangeLiveActor = false;
            f_getIdleAnimationType = false;
            f_sprintfStatic = false;
            f_getAllocArenaGround = false;
            f_deleteLiveObject = false;
            f_resetAttributeBitfieldLivePerformerWrapper = false;
            f_isBagNotEmpty = false;
            f_getSsbString = false;
            f_initPartnerFollowData = false;
            f_resetAttributeBitfieldLiveActorWrapper = false;
            f_getAttributeBitfieldLiveActor = false;
            f_setAttributeBitfieldLiveActor = false;
            f_changeActorAnimation = false;
            f_setPositionLiveObject = false;
            f_unlockMainRoutine = false;
            f_worldMapSetCamera = false;
            f_getEffectStatusLiveObject = false;
            f_setHeightLiveActor = false;
            f_setPositionOffsetLiveObject = false;
            f_getDirectionLiveActor = false;
            f_scriptParamToInt = false;
            f_getRandomNpcJobType = false;
            f_scriptParamToFixedPoint16 = false;
            f_setPositionLivePerformerVeneer = false;
            f_deleteLiveActor = false;
            f_setAttributeBitfieldLiveObject = false;
            f_scriptSpecialProcessCall = false;
            f_loadFileFromRomVeneer = false;
            f_getCollisionBoxCenterLiveObject = false;
            f_handleControlsTopScreenGround = false;
            f_setPositionOffsetLiveActor = false;
            f_isScreenFadeInProgress = false;
            f_setEffectLivePerformer = false;
            f_scriptSpecialProcess0x16 = false;
            f_groundMainLoop = false;
            f_loadMapType10 = false;
            f_unlockActorRoutines = false;
            f_getAnimationStatusLiveObject = false;
            f_createTeamInfoBox = false;
            f_getCollisionBoxCenterLivePerformer = false;
            f_returnToTitleScreen = false;
            f_getEffectStatusLivePerformer = false;
            f_setPositionInitialLiveObject = false;
            f_groundMainReturnDungeon = false;
            f_getDirectionLivePerformer = false;
            f_setPositionLivePerformer = false;
            f_updateTopGroundMenu = false;
            f_setAnimationLiveObject = false;
            f_acceptRandomNpcJob = false;
            f_setHeightLiveObject = false;
            f_getAttributeBitfieldLivePerformer = false;
            f_initAnimDataFromOtherAnimData = false;
            f_getHeightLiveActor = false;
            f_loadMapType11 = false;
            f_initScriptRoutineState = false;
            f_setBlinkLivePerformer = false;
            f_setAnimationLivePerformer = false;
            f_getExclusiveItemRequirements = false;
            f_setMovementRangeLiveObject = false;
            f_handleUnlocks = false;
            f_setAttributeBitfieldLiveActorWrapper = false;
            f_setAnimDataFields2 = false;
            f_loadObjectAnimData = false;
            f_closeTeamInfoBox = false;
            f_setPositionLiveObjectVeneer = false;
            f_resetAttributeBitfieldLiveActor = false;
            f_initScriptRoutine = false;
            f_getSpecialRecruitmentSpecies = false;
            f_groundMainNextDay = false;
            f_unlockObjectRoutines = false;
            f_getLiveActorIdxFromScriptEntityId = false;
            f_getDirectionLiveObject = false;
            f_setAnimationLiveActor = false;
            f_resetAttributeBitfieldLiveObject = false;
            f_resetAttributeBitfieldLiveObjectWrapper = false;
            f_getHeightLivePerformer = false;
            f_setAttributeBitfieldLivePerformerWrapper = false;
            f_loadBackgroundAttributes = false;
            f_unlockPerformerRoutines = false;
            f_ssbLoad2 = false;
            f_getCoroutineInfo = false;
            f_getHeightLiveObject = false;
            f_unlockRoutine = false;
            f_initAnimDataFromOtherAnimDataVeneer = false;
            f_getFreeArenaGround = false;
            f_getCollisionBoxLivePerformer = false;
            f_getEffectStatusLiveActor = false;
            f_allocAndInitPartnerFollowDataAndLiveActorList = false;
            f_closeTopGroundMenu = false;
            f_setAnimDataFields = false;
            f_deleteLivePerformer = false;
            f_getCollidingActorId = false;
            f_lockRoutine = false;
            f_setBlinkLiveActor = false;
            f_setPositionInitialLiveActor = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_setAnimDataFieldsWrapper;
        private int _setAnimDataFieldsWrapper;

        /// <summary>
        /// Calls SetAnimDataFields with the second argument right-shifted by 16.
        /// </summary>
        public int SetAnimDataFieldsWrapper
        {
            get
            {
                if (f_setAnimDataFieldsWrapper)
                    return _setAnimDataFieldsWrapper;
                _setAnimDataFieldsWrapper = (int) (100220);
                f_setAnimDataFieldsWrapper = true;
                return _setAnimDataFieldsWrapper;
            }
        }
        private bool f_jumpToTitleScreen;
        private int _jumpToTitleScreen;

        /// <summary>
        /// Implements SPECIAL_PROC_JUMP_TO_TITLE_SCREEN and SPECIAL_PROC_0x1A (see ScriptSpecialProcessCall).
        /// 
        /// r0: int, argument value for SPECIAL_PROC_JUMP_TO_TITLE_SCREEN and -1 for SPECIAL_PROC_0x1A
        /// return: bool (but note that the special process ignores this and always returns 0)
        /// </summary>
        public int JumpToTitleScreen
        {
            get
            {
                if (f_jumpToTitleScreen)
                    return _jumpToTitleScreen;
                _jumpToTitleScreen = (int) (54172);
                f_jumpToTitleScreen = true;
                return _jumpToTitleScreen;
            }
        }
        private bool f_getIdLiveActor;
        private int _getIdLiveActor;

        /// <summary>
        /// Returns the ID of a currently loaded actor. This ID can then be used to index GROUND_STATE_PTRS::actors.
        /// 
        /// r0: live actor
        /// return: id
        /// </summary>
        public int GetIdLiveActor
        {
            get
            {
                if (f_getIdLiveActor)
                    return _getIdLiveActor;
                _getIdLiveActor = (int) (124964);
                f_getIdLiveActor = true;
                return _getIdLiveActor;
            }
        }
        private bool f_getCollidingObjectId;
        private int _getCollidingObjectId;

        /// <summary>
        /// Returns the first colliding object given a series of vector coordinates.
        /// 
        /// r0: attribute bitfield to test objects against
        /// r1: pointer to coord_min
        /// r2: pointer to coord_max
        /// return: The first colliding object's id, or -1 if no is collision detected
        /// </summary>
        public int GetCollidingObjectId
        {
            get
            {
                if (f_getCollidingObjectId)
                    return _getCollidingObjectId;
                _getCollidingObjectId = (int) (133944);
                f_getCollidingObjectId = true;
                return _getCollidingObjectId;
            }
        }
        private bool f_getCollidingEventId;
        private int _getCollidingEventId;

        /// <summary>
        /// Returns the first colliding event given a series of vector coordinates.
        /// 
        /// r0: attribute bitfield to test events against
        /// r1: pointer to coord_min
        /// r2: pointer to coord_max
        /// return: The first colliding event's id, or -1 if no is collision detected
        /// </summary>
        public int GetCollidingEventId
        {
            get
            {
                if (f_getCollidingEventId)
                    return _getCollidingEventId;
                _getCollidingEventId = (int) (142360);
                f_getCollidingEventId = true;
                return _getCollidingEventId;
            }
        }
        private bool f_funcThatCallsRunNextOpcode;
        private int _funcThatCallsRunNextOpcode;

        /// <summary>
        /// Called up to 16 times per frame. Exact purpose unknown.
        /// 
        /// r0: script routine pointer
        /// </summary>
        public int FuncThatCallsRunNextOpcode
        {
            get
            {
                if (f_funcThatCallsRunNextOpcode)
                    return _funcThatCallsRunNextOpcode;
                _funcThatCallsRunNextOpcode = (int) (3876);
                f_funcThatCallsRunNextOpcode = true;
                return _funcThatCallsRunNextOpcode;
            }
        }
        private bool f_initPartnerFollowDataAndLiveActorList;
        private int _initPartnerFollowDataAndLiveActorList;

        /// <summary>
        /// Initialize the partner follow data and the live actor list (in GROUND_STATE_PTRS, doesn't perform the allocation of the structures)
        /// 
        /// No params.
        /// </summary>
        public int InitPartnerFollowDataAndLiveActorList
        {
            get
            {
                if (f_initPartnerFollowDataAndLiveActorList)
                    return _initPartnerFollowDataAndLiveActorList;
                _initPartnerFollowDataAndLiveActorList = (int) (113464);
                f_initPartnerFollowDataAndLiveActorList = true;
                return _initPartnerFollowDataAndLiveActorList;
            }
        }
        private bool f_getSpecialLayoutBackground;
        private int _getSpecialLayoutBackground;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: bg_id
        /// r1: dungeon_info_str
        /// r2: additional_info
        /// r3: copy_fixed_room_layout
        /// </summary>
        public int GetSpecialLayoutBackground
        {
            get
            {
                if (f_getSpecialLayoutBackground)
                    return _getSpecialLayoutBackground;
                _getSpecialLayoutBackground = (int) (86912);
                f_getSpecialLayoutBackground = true;
                return _getSpecialLayoutBackground;
            }
        }
        private bool f_getCollisionBoxLiveActor;
        private int _getCollisionBoxLiveActor;

        /// <summary>
        /// Gets the collision box of a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: [output] collision box buffer
        /// </summary>
        public int GetCollisionBoxLiveActor
        {
            get
            {
                if (f_getCollisionBoxLiveActor)
                    return _getCollisionBoxLiveActor;
                _getCollisionBoxLiveActor = (int) (124972);
                f_getCollisionBoxLiveActor = true;
                return _getCollisionBoxLiveActor;
            }
        }
        private bool f_setMovementRangeLivePerformer;
        private int _setMovementRangeLivePerformer;

        /// <summary>
        /// Sets a currently loaded performer's random movement range.
        /// 
        /// r0: live performer
        /// r1: pointer to limit_min_pos
        /// r2: pointer to limit_max_pos
        /// </summary>
        public int SetMovementRangeLivePerformer
        {
            get
            {
                if (f_setMovementRangeLivePerformer)
                    return _setMovementRangeLivePerformer;
                _setMovementRangeLivePerformer = (int) (140168);
                f_setMovementRangeLivePerformer = true;
                return _setMovementRangeLivePerformer;
            }
        }
        private bool f_ssbLoad1;
        private int _ssbLoad1;
        public int SsbLoad1
        {
            get
            {
                if (f_ssbLoad1)
                    return _ssbLoad1;
                _ssbLoad1 = (int) (39696);
                f_ssbLoad1 = true;
                return _ssbLoad1;
            }
        }
        private bool f_setBlinkLiveObject;
        private int _setBlinkLiveObject;

        /// <summary>
        /// Sets the object to blink in and out of sight at certain intervals.
        /// 
        /// r0: live object
        /// r1: frame interval for blinking in
        /// r2: frame interval for blinking out
        /// </summary>
        public int SetBlinkLiveObject
        {
            get
            {
                if (f_setBlinkLiveObject)
                    return _setBlinkLiveObject;
                _setBlinkLiveObject = (int) (135464);
                f_setBlinkLiveObject = true;
                return _setBlinkLiveObject;
            }
        }
        private bool f_getAttributeBitfieldLiveObject;
        private int _getAttributeBitfieldLiveObject;

        /// <summary>
        /// Gets the attribute bitfield of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: [output] pointer to attribute bitfield
        /// </summary>
        public int GetAttributeBitfieldLiveObject
        {
            get
            {
                if (f_getAttributeBitfieldLiveObject)
                    return _getAttributeBitfieldLiveObject;
                _getAttributeBitfieldLiveObject = (int) (135420);
                f_getAttributeBitfieldLiveObject = true;
                return _getAttributeBitfieldLiveObject;
            }
        }
        private bool f_handleTeamStatsGround;
        private int _handleTeamStatsGround;

        /// <summary>
        /// Handles the team stats top screen display in the overworld.
        /// 
        /// For some reason the implementation seems considerably jankier in ground mode. In dungeon mode there's this structure for the top screen that has handlers for creating, updating and closing the various top screen layouts in a sort of polymorphic way. Here there's just a separate function for every layout that gets called every frame and seems to have a switch-case to handle everything about it.
        /// 
        /// No params.
        /// </summary>
        public int HandleTeamStatsGround
        {
            get
            {
                if (f_handleTeamStatsGround)
                    return _handleTeamStatsGround;
                _handleTeamStatsGround = (int) (227644);
                f_handleTeamStatsGround = true;
                return _handleTeamStatsGround;
            }
        }
        private bool f_scriptCaseProcess;
        private int _scriptCaseProcess;

        /// <summary>
        /// Calculates the next opcode address for a script routine as the result of a switch-statement.
        /// 
        /// r0: script routine pointer
        /// r1: case id
        /// return: Next opcode address for the routine to execute
        /// </summary>
        public int ScriptCaseProcess
        {
            get
            {
                if (f_scriptCaseProcess)
                    return _scriptCaseProcess;
                _scriptCaseProcess = (int) (33192);
                f_scriptCaseProcess = true;
                return _scriptCaseProcess;
            }
        }
        private bool f_getDungeonMapPos;
        private int _getDungeonMapPos;

        /// <summary>
        /// Checks if a dungeon should be displayed on the map and the position where it should be displayed if so.
        /// 
        /// r0: [Output] Buffer where the coordinates of the map marker will be stored. The coordinates are shifted 8 bits to the left, so they are probably fixed-point numbers instead of integers.
        /// r1: Dungeon ID
        /// return: True if the dungeon should be displayed on the map, false otherwise.
        /// </summary>
        public int GetDungeonMapPos
        {
            get
            {
                if (f_getDungeonMapPos)
                    return _getDungeonMapPos;
                _getDungeonMapPos = (int) (207716);
                f_getDungeonMapPos = true;
                return _getDungeonMapPos;
            }
        }
        private bool f_updateTeamInfoBox;
        private int _updateTeamInfoBox;

        /// <summary>
        /// Window update function for team info boxes.
        /// 
        /// r0: window pointer
        /// </summary>
        public int UpdateTeamInfoBox
        {
            get
            {
                if (f_updateTeamInfoBox)
                    return _updateTeamInfoBox;
                _updateTeamInfoBox = (int) (142788);
                f_updateTeamInfoBox = true;
                return _updateTeamInfoBox;
            }
        }
        private bool f_setAttributeBitfieldLivePerformer;
        private int _setAttributeBitfieldLivePerformer;

        /// <summary>
        /// Sets bits of the attribute bitfield of a currently loaded performer.
        /// 
        /// r0: live performer id
        /// r1: attribute bitfield
        /// </summary>
        public int SetAttributeBitfieldLivePerformer
        {
            get
            {
                if (f_setAttributeBitfieldLivePerformer)
                    return _setAttributeBitfieldLivePerformer;
                _setAttributeBitfieldLivePerformer = (int) (138168);
                f_setAttributeBitfieldLivePerformer = true;
                return _setAttributeBitfieldLivePerformer;
            }
        }
        private bool f_setPositionLiveActor;
        private int _setPositionLiveActor;

        /// <summary>
        /// Sets the position for a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: pointer to a position vector
        /// </summary>
        public int SetPositionLiveActor
        {
            get
            {
                if (f_setPositionLiveActor)
                    return _setPositionLiveActor;
                _setPositionLiveActor = (int) (119624);
                f_setPositionLiveActor = true;
                return _setPositionLiveActor;
            }
        }
        private bool f_getCollisionBoxCenterLiveActor;
        private int _getCollisionBoxCenterLiveActor;

        /// <summary>
        /// Gets the center of a collision box of a currently loaded actor.
        /// 
        /// This simply adds the actor's minimum coordinates by half the size of the actor's collision box.
        /// 
        /// r0: live actor
        /// r1: [output] collision box center buffer
        /// </summary>
        public int GetCollisionBoxCenterLiveActor
        {
            get
            {
                if (f_getCollisionBoxCenterLiveActor)
                    return _getCollisionBoxCenterLiveActor;
                _getCollisionBoxCenterLiveActor = (int) (125216);
                f_getCollisionBoxCenterLiveActor = true;
                return _getCollisionBoxCenterLiveActor;
            }
        }
        private bool f_setPositionLiveActorVeneer;
        private int _setPositionLiveActorVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for SetPositionLiveActor.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: live actor
        /// r1: pointer to a position vector
        /// </summary>
        public int SetPositionLiveActorVeneer
        {
            get
            {
                if (f_setPositionLiveActorVeneer)
                    return _setPositionLiveActorVeneer;
                _setPositionLiveActorVeneer = (int) (125252);
                f_setPositionLiveActorVeneer = true;
                return _setPositionLiveActorVeneer;
            }
        }
        private bool f_setPositionInitialLivePerformer;
        private int _setPositionInitialLivePerformer;

        /// <summary>
        /// Sets a currently loaded performer to return to its initial position.
        /// 
        /// r0: live performer
        /// r1: pointer to an position vector; if null, performer will return to its initial position
        /// </summary>
        public int SetPositionInitialLivePerformer
        {
            get
            {
                if (f_setPositionInitialLivePerformer)
                    return _setPositionInitialLivePerformer;
                _setPositionInitialLivePerformer = (int) (139980);
                f_setPositionInitialLivePerformer = true;
                return _setPositionInitialLivePerformer;
            }
        }
        private bool f_getAnimationStatusLiveActor;
        private int _getAnimationStatusLiveActor;

        /// <summary>
        /// Gets the animation status of a currently loaded actor.
        /// 
        /// Used to determine if the animation has finished via script opcodes like WaitAnimation and WaitEndAnimation.
        /// 
        /// r0: live actor
        /// return: status
        /// </summary>
        public int GetAnimationStatusLiveActor
        {
            get
            {
                if (f_getAnimationStatusLiveActor)
                    return _getAnimationStatusLiveActor;
                _getAnimationStatusLiveActor = (int) (125444);
                f_getAnimationStatusLiveActor = true;
                return _getAnimationStatusLiveActor;
            }
        }
        private bool f_stationLoadHanger;
        private int _stationLoadHanger;
        public int StationLoadHanger
        {
            get
            {
                if (f_stationLoadHanger)
                    return _stationLoadHanger;
                _stationLoadHanger = (int) (35220);
                f_stationLoadHanger = true;
                return _stationLoadHanger;
            }
        }
        private bool f_getAnimationStatusLivePerformer;
        private int _getAnimationStatusLivePerformer;

        /// <summary>
        /// Gets the animation status of a currently loaded performer.
        /// 
        /// Used to determine if the animation has finished via script opcodes like WaitAnimation and WaitEndAnimation.
        /// 
        /// r0: live performer
        /// return: status
        /// </summary>
        public int GetAnimationStatusLivePerformer
        {
            get
            {
                if (f_getAnimationStatusLivePerformer)
                    return _getAnimationStatusLivePerformer;
                _getAnimationStatusLivePerformer = (int) (140520);
                f_getAnimationStatusLivePerformer = true;
                return _getAnimationStatusLivePerformer;
            }
        }
        private bool f_prepareMenuAcceptTeamMember;
        private int _prepareMenuAcceptTeamMember;

        /// <summary>
        /// Implements SPECIAL_PROC_PREPARE_MENU_ACCEPT_TEAM_MEMBER (see ScriptSpecialProcessCall).
        /// 
        /// r0: index into RECRUITMENT_TABLE_SPECIES
        /// </summary>
        public int PrepareMenuAcceptTeamMember
        {
            get
            {
                if (f_prepareMenuAcceptTeamMember)
                    return _prepareMenuAcceptTeamMember;
                _prepareMenuAcceptTeamMember = (int) (48704);
                f_prepareMenuAcceptTeamMember = true;
                return _prepareMenuAcceptTeamMember;
            }
        }
        private bool f_getCollisionBoxLiveObject;
        private int _getCollisionBoxLiveObject;

        /// <summary>
        /// Gets the collision box of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: [output] collision box buffer
        /// </summary>
        public int GetCollisionBoxLiveObject
        {
            get
            {
                if (f_getCollisionBoxLiveObject)
                    return _getCollisionBoxLiveObject;
                _getCollisionBoxLiveObject = (int) (134792);
                f_getCollisionBoxLiveObject = true;
                return _getCollisionBoxLiveObject;
            }
        }
        private bool f_resetAttributeBitfieldLivePerformer;
        private int _resetAttributeBitfieldLivePerformer;

        /// <summary>
        /// Clears bits of the attribute bitfield of a currently loaded performer.
        /// 
        /// r0: live performer id
        /// r1: attribute bitfield
        /// </summary>
        public int ResetAttributeBitfieldLivePerformer
        {
            get
            {
                if (f_resetAttributeBitfieldLivePerformer)
                    return _resetAttributeBitfieldLivePerformer;
                _resetAttributeBitfieldLivePerformer = (int) (138232);
                f_resetAttributeBitfieldLivePerformer = true;
                return _resetAttributeBitfieldLivePerformer;
            }
        }
        private bool f_isTeamInfoBoxActive;
        private int _isTeamInfoBoxActive;

        /// <summary>
        /// This is a guess.
        /// 
        /// Checks if the state of a team info box is not 5.
        /// 
        /// r0: window_id
        /// return: bool
        /// </summary>
        public int IsTeamInfoBoxActive
        {
            get
            {
                if (f_isTeamInfoBoxActive)
                    return _isTeamInfoBoxActive;
                _isTeamInfoBoxActive = (int) (142756);
                f_isTeamInfoBoxActive = true;
                return _isTeamInfoBoxActive;
            }
        }
        private bool f_setAttributeBitfieldLiveObjectWrapper;
        private int _setAttributeBitfieldLiveObjectWrapper;

        /// <summary>
        /// Sets bits of the attribute bitfield of a currently loaded object.
        /// 
        /// Is a wrapper around SetAttributeBitfieldLiveObject, meaning this calls SetAttributeBitfieldLiveObject with a first parameter of live_object::id.
        /// 
        /// r0: live object
        /// r1: attribute bitfield
        /// </summary>
        public int SetAttributeBitfieldLiveObjectWrapper
        {
            get
            {
                if (f_setAttributeBitfieldLiveObjectWrapper)
                    return _setAttributeBitfieldLiveObjectWrapper;
                _setAttributeBitfieldLiveObjectWrapper = (int) (135432);
                f_setAttributeBitfieldLiveObjectWrapper = true;
                return _setAttributeBitfieldLiveObjectWrapper;
            }
        }
        private bool f_setEffectLiveObject;
        private int _setEffectLiveObject;

        /// <summary>
        /// Sets the effect of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: flag (true if effect id is 0?)
        /// r2: effect id
        /// </summary>
        public int SetEffectLiveObject
        {
            get
            {
                if (f_setEffectLiveObject)
                    return _setEffectLiveObject;
                _setEffectLiveObject = (int) (135336);
                f_setEffectLiveObject = true;
                return _setEffectLiveObject;
            }
        }
        private bool f_getIdLiveObject;
        private int _getIdLiveObject;

        /// <summary>
        /// Returns the ID of a currently loaded object. This ID can then be used to index GROUND_STATE_PTRS::objects.
        /// 
        /// r0: live object
        /// return: id
        /// </summary>
        public int GetIdLiveObject
        {
            get
            {
                if (f_getIdLiveObject)
                    return _getIdLiveObject;
                _getIdLiveObject = (int) (134784);
                f_getIdLiveObject = true;
                return _getIdLiveObject;
            }
        }
        private bool f_getRandomNpcJobSubtype;
        private int _getRandomNpcJobSubtype;

        /// <summary>
        /// Implements SPECIAL_PROC_GET_RANDOM_NPC_JOB_SUBTYPE (see ScriptSpecialProcessCall).
        /// 
        /// return: job subtype?
        /// </summary>
        public int GetRandomNpcJobSubtype
        {
            get
            {
                if (f_getRandomNpcJobSubtype)
                    return _getRandomNpcJobSubtype;
                _getRandomNpcJobSubtype = (int) (49044);
                f_getRandomNpcJobSubtype = true;
                return _getRandomNpcJobSubtype;
            }
        }
        private bool f_scriptStationLoadTalk;
        private int _scriptStationLoadTalk;
        public int ScriptStationLoadTalk
        {
            get
            {
                if (f_scriptStationLoadTalk)
                    return _scriptStationLoadTalk;
                _scriptStationLoadTalk = (int) (37284);
                f_scriptStationLoadTalk = true;
                return _scriptStationLoadTalk;
            }
        }
        private bool f_unlockScriptingLock;
        private int _unlockScriptingLock;

        /// <summary>
        /// Unlocks a scripting lock.
        /// 
        /// Sets the corresponding byte to 1 on LOCK_NOTIFY_ARRAY to signal that the scripting engine should handle the unlock. Also sets a global unlock flag, used to tell the scripting engine that the state of locks have changed and they should be checked again.
        /// 
        /// r0: ID of the lock to unlock
        /// </summary>
        public int UnlockScriptingLock
        {
            get
            {
                if (f_unlockScriptingLock)
                    return _unlockScriptingLock;
                _unlockScriptingLock = (int) (3824);
                f_unlockScriptingLock = true;
                return _unlockScriptingLock;
            }
        }
        private bool f_setDirectionLiveObject;
        private int _setDirectionLiveObject;

        /// <summary>
        /// Sets the direction of a currently loaded object. Does nothing if the direction value passed is -1.
        /// 
        /// r0: live object
        /// r1: direction
        /// </summary>
        public int SetDirectionLiveObject
        {
            get
            {
                if (f_setDirectionLiveObject)
                    return _setDirectionLiveObject;
                _setDirectionLiveObject = (int) (135128);
                f_setDirectionLiveObject = true;
                return _setDirectionLiveObject;
            }
        }
        private bool f_setEffectLiveActor;
        private int _setEffectLiveActor;

        /// <summary>
        /// Sets the effect of a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: flag (true if effect id is 0?)
        /// r2: effect id
        /// r3: effect position marker
        /// </summary>
        public int SetEffectLiveActor
        {
            get
            {
                if (f_setEffectLiveActor)
                    return _setEffectLiveActor;
                _setEffectLiveActor = (int) (125424);
                f_setEffectLiveActor = true;
                return _setEffectLiveActor;
            }
        }
        private bool f_getRandomNpcJobStillAvailable;
        private int _getRandomNpcJobStillAvailable;

        /// <summary>
        /// Implements SPECIAL_PROC_GET_RANDOM_NPC_JOB_STILL_AVAILABLE (see ScriptSpecialProcessCall).
        /// 
        /// return: bool
        /// </summary>
        public int GetRandomNpcJobStillAvailable
        {
            get
            {
                if (f_getRandomNpcJobStillAvailable)
                    return _getRandomNpcJobStillAvailable;
                _getRandomNpcJobStillAvailable = (int) (49072);
                f_getRandomNpcJobStillAvailable = true;
                return _getRandomNpcJobStillAvailable;
            }
        }
        private bool f_setDirectionLiveActor;
        private int _setDirectionLiveActor;

        /// <summary>
        /// Sets the direction of a currently loaded actor. Does nothing if the direction value passed is -1.
        /// 
        /// r0: live actor
        /// r1: direction
        /// </summary>
        public int SetDirectionLiveActor
        {
            get
            {
                if (f_setDirectionLiveActor)
                    return _setDirectionLiveActor;
                _setDirectionLiveActor = (int) (125308);
                f_setDirectionLiveActor = true;
                return _setDirectionLiveActor;
            }
        }
        private bool f_deleteLiveEvent;
        private int _deleteLiveEvent;

        /// <summary>
        /// Remove the event from the event list (in GROUND_STATE_PTRS)
        /// 
        /// r0: the index of the event in the live event list
        /// </summary>
        public int DeleteLiveEvent
        {
            get
            {
                if (f_deleteLiveEvent)
                    return _deleteLiveEvent;
                _deleteLiveEvent = (int) (141960);
                f_deleteLiveEvent = true;
                return _deleteLiveEvent;
            }
        }
        private bool f_setDirectionLivePerformer;
        private int _setDirectionLivePerformer;

        /// <summary>
        /// Sets the direction of a currently loaded performer. Does nothing if the direction value passed is -1.
        /// 
        /// r0: live performer
        /// r1: direction
        /// </summary>
        public int SetDirectionLivePerformer
        {
            get
            {
                if (f_setDirectionLivePerformer)
                    return _setDirectionLivePerformer;
                _setDirectionLivePerformer = (int) (140296);
                f_setDirectionLivePerformer = true;
                return _setDirectionLivePerformer;
            }
        }
        private bool f_setHeightLivePerformer;
        private int _setHeightLivePerformer;

        /// <summary>
        /// Sets the height of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: height
        /// </summary>
        public int SetHeightLivePerformer
        {
            get
            {
                if (f_setHeightLivePerformer)
                    return _setHeightLivePerformer;
                _setHeightLivePerformer = (int) (140272);
                f_setHeightLivePerformer = true;
                return _setHeightLivePerformer;
            }
        }
        private bool f_initRandomNpcJobs;
        private int _initRandomNpcJobs;

        /// <summary>
        /// Implements SPECIAL_PROC_INIT_RANDOM_NPC_JOBS (see ScriptSpecialProcessCall).
        /// 
        /// r0: job type? 0 is a random NPC job, 1 is a bottle mission
        /// r1: ?
        /// </summary>
        public int InitRandomNpcJobs
        {
            get
            {
                if (f_initRandomNpcJobs)
                    return _initRandomNpcJobs;
                _initRandomNpcJobs = (int) (48868);
                f_initRandomNpcJobs = true;
                return _initRandomNpcJobs;
            }
        }
        private bool f_runNextOpcode;
        private int _runNextOpcode;

        /// <summary>
        /// Runs the next scripting opcode.
        /// 
        /// Contains a switch statement based on the routine's next opcode to run.
        /// 
        /// r0: script routine pointer
        /// return: status
        /// </summary>
        public int RunNextOpcode
        {
            get
            {
                if (f_runNextOpcode)
                    return _runNextOpcode;
                _runNextOpcode = (int) (6948);
                f_runNextOpcode = true;
                return _runNextOpcode;
            }
        }
        private bool f_getIdLivePerformer;
        private int _getIdLivePerformer;

        /// <summary>
        /// Returns the ID of a currently loaded performer. This ID can then be used to index GROUND_STATE_PTRS::performers.
        /// 
        /// r0: live performer
        /// return: id
        /// </summary>
        public int GetIdLivePerformer
        {
            get
            {
                if (f_getIdLivePerformer)
                    return _getIdLivePerformer;
                _getIdLivePerformer = (int) (139952);
                f_getIdLivePerformer = true;
                return _getIdLivePerformer;
            }
        }
        private bool f_setPositionOffsetLivePerformer;
        private int _setPositionOffsetLivePerformer;

        /// <summary>
        /// Offsets a currently loaded performer's position.
        /// 
        /// r0: live performer
        /// r1: pointer to an position offset vector
        /// </summary>
        public int SetPositionOffsetLivePerformer
        {
            get
            {
                if (f_setPositionOffsetLivePerformer)
                    return _setPositionOffsetLivePerformer;
                _setPositionOffsetLivePerformer = (int) (140668);
                f_setPositionOffsetLivePerformer = true;
                return _setPositionOffsetLivePerformer;
            }
        }
        private bool f_createTopGroundMenu;
        private int _createTopGroundMenu;

        /// <summary>
        /// Creates a parent menu (containing Items, Team, etc.) and two other windows upon pressing X in the overworld.
        /// 
        /// return: always 1
        /// </summary>
        public int CreateTopGroundMenu
        {
            get
            {
                if (f_createTopGroundMenu)
                    return _createTopGroundMenu;
                _createTopGroundMenu = (int) (150436);
                f_createTopGroundMenu = true;
                return _createTopGroundMenu;
            }
        }
        private bool f_worldMapSetMode;
        private int _worldMapSetMode;

        /// <summary>
        /// Function called by the script function &quot;worldmap_SetMode&quot;
        /// Define the mode of the world map, which can among other things be used to decide if the player character should appear on the world map
        /// The mode is set even if no world map is set
        /// 
        /// r0: world map mode
        /// </summary>
        public int WorldMapSetMode
        {
            get
            {
                if (f_worldMapSetMode)
                    return _worldMapSetMode;
                _worldMapSetMode = (int) (208416);
                f_worldMapSetMode = true;
                return _worldMapSetMode;
            }
        }
        private bool f_statusUpdate;
        private int _statusUpdate;

        /// <summary>
        /// Implements SPECIAL_PROC_STATUS_UPDATE (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int StatusUpdate
        {
            get
            {
                if (f_statusUpdate)
                    return _statusUpdate;
                _statusUpdate = (int) (227576);
                f_statusUpdate = true;
                return _statusUpdate;
            }
        }
        private bool f_setMovementRangeLiveActor;
        private int _setMovementRangeLiveActor;

        /// <summary>
        /// Sets a currently loaded actor's random movement range.
        /// 
        /// r0: live actor
        /// r1: pointer to limit_min_pos
        /// r2: pointer to limit_max_pos
        /// </summary>
        public int SetMovementRangeLiveActor
        {
            get
            {
                if (f_setMovementRangeLiveActor)
                    return _setMovementRangeLiveActor;
                _setMovementRangeLiveActor = (int) (125180);
                f_setMovementRangeLiveActor = true;
                return _setMovementRangeLiveActor;
            }
        }
        private bool f_getIdleAnimationType;
        private int _getIdleAnimationType;

        /// <summary>
        /// Given a monster species, returns the type of idle animation it should have.
        /// 
        /// Possible values are &quot;freeze animation #0&quot; (0x300), &quot;loop animation #7&quot; (0x807) and &quot;freeze animation #7&quot; (0x307).
        /// 
        /// r0: Monster ID
        /// r1: (?) Could contain data about the animation the monster is currently playing
        /// return: Animation data
        /// </summary>
        public int GetIdleAnimationType
        {
            get
            {
                if (f_getIdleAnimationType)
                    return _getIdleAnimationType;
                _getIdleAnimationType = (int) (105328);
                f_getIdleAnimationType = true;
                return _getIdleAnimationType;
            }
        }
        private bool f_sprintfStatic;
        private int _sprintfStatic;

        /// <summary>
        /// Statically defined copy of sprintf(3) in overlay 11. See arm9.yml for more information.
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
                _sprintfStatic = (int) (183528);
                f_sprintfStatic = true;
                return _sprintfStatic;
            }
        }
        private bool f_getAllocArenaGround;
        private int _getAllocArenaGround;

        /// <summary>
        /// The GetAllocArena function used for ground mode. See SetMemAllocatorParams for more information.
        /// 
        /// For (flags &amp; 0xFF):
        ///   8, 15, 16: GROUND_MEMORY_ARENA_1
        ///   14: GROUND_MEMORY_ARENA_2
        ///   other: null (default arena)
        /// 
        /// r0: initial memory arena pointer, or null
        /// r1: flags (see MemAlloc)
        /// return: memory arena pointer, or null
        /// </summary>
        public int GetAllocArenaGround
        {
            get
            {
                if (f_getAllocArenaGround)
                    return _getAllocArenaGround;
                _getAllocArenaGround = (int) (53532);
                f_getAllocArenaGround = true;
                return _getAllocArenaGround;
            }
        }
        private bool f_deleteLiveObject;
        private int _deleteLiveObject;

        /// <summary>
        /// Remove the object from the object list (in GROUND_STATE_PTRS)
        /// 
        /// r0: the index of the object in the live object list
        /// </summary>
        public int DeleteLiveObject
        {
            get
            {
                if (f_deleteLiveObject)
                    return _deleteLiveObject;
                _deleteLiveObject = (int) (131692);
                f_deleteLiveObject = true;
                return _deleteLiveObject;
            }
        }
        private bool f_resetAttributeBitfieldLivePerformerWrapper;
        private int _resetAttributeBitfieldLivePerformerWrapper;

        /// <summary>
        /// Clears bits of the attribute bitfield of a currently loaded performer.
        /// 
        /// Is a wrapper around ResetAttributeBitfieldLivePerformer, meaning this calls ResetAttributeBitfieldLivePerformer with a first parameter of live_performer::id.
        /// 
        /// r0: live performer
        /// r1: attribute bitfield
        /// </summary>
        public int ResetAttributeBitfieldLivePerformerWrapper
        {
            get
            {
                if (f_resetAttributeBitfieldLivePerformerWrapper)
                    return _resetAttributeBitfieldLivePerformerWrapper;
                _resetAttributeBitfieldLivePerformerWrapper = (int) (140636);
                f_resetAttributeBitfieldLivePerformerWrapper = true;
                return _resetAttributeBitfieldLivePerformerWrapper;
            }
        }
        private bool f_isBagNotEmpty;
        private int _isBagNotEmpty;

        /// <summary>
        /// Checks if the bag has at least one valid item. Notably used in CreateTopGroundMenu to decide if the &quot;Items&quot; option should be enabled.
        /// 
        /// return: bool
        /// </summary>
        public int IsBagNotEmpty
        {
            get
            {
                if (f_isBagNotEmpty)
                    return _isBagNotEmpty;
                _isBagNotEmpty = (int) (166112);
                f_isBagNotEmpty = true;
                return _isBagNotEmpty;
            }
        }
        private bool f_getSsbString;
        private int _getSsbString;

        /// <summary>
        /// Returns a string from a given SSB runtime struct.
        /// 
        /// r0: ssb runtime info pointer
        /// r1: idx
        /// </summary>
        public int GetSsbString
        {
            get
            {
                if (f_getSsbString)
                    return _getSsbString;
                _getSsbString = (int) (32776);
                f_getSsbString = true;
                return _getSsbString;
            }
        }
        private bool f_initPartnerFollowData;
        private int _initPartnerFollowData;

        /// <summary>
        /// Initialize the partner follow data structure, without allocating it (in GROUND_STATE_PTRS)
        /// 
        /// No params.
        /// </summary>
        public int InitPartnerFollowData
        {
            get
            {
                if (f_initPartnerFollowData)
                    return _initPartnerFollowData;
                _initPartnerFollowData = (int) (129096);
                f_initPartnerFollowData = true;
                return _initPartnerFollowData;
            }
        }
        private bool f_resetAttributeBitfieldLiveActorWrapper;
        private int _resetAttributeBitfieldLiveActorWrapper;

        /// <summary>
        /// Clears bits of the attribute bitfield of a currently loaded actor.
        /// 
        /// Is a wrapper around ResetAttributeBitfieldLiveActor, meaning this calls ResetAttributeBitfieldLiveActor with a first parameter of live_actor::id.
        /// 
        /// r0: live actor
        /// r1: attribute bitfield
        /// </summary>
        public int ResetAttributeBitfieldLiveActorWrapper
        {
            get
            {
                if (f_resetAttributeBitfieldLiveActorWrapper)
                    return _resetAttributeBitfieldLiveActorWrapper;
                _resetAttributeBitfieldLiveActorWrapper = (int) (125540);
                f_resetAttributeBitfieldLiveActorWrapper = true;
                return _resetAttributeBitfieldLiveActorWrapper;
            }
        }
        private bool f_getAttributeBitfieldLiveActor;
        private int _getAttributeBitfieldLiveActor;

        /// <summary>
        /// Gets the attribute bitfield of a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: [output] pointer to attribute bitfield
        /// </summary>
        public int GetAttributeBitfieldLiveActor
        {
            get
            {
                if (f_getAttributeBitfieldLiveActor)
                    return _getAttributeBitfieldLiveActor;
                _getAttributeBitfieldLiveActor = (int) (125512);
                f_getAttributeBitfieldLiveActor = true;
                return _getAttributeBitfieldLiveActor;
            }
        }
        private bool f_setAttributeBitfieldLiveActor;
        private int _setAttributeBitfieldLiveActor;

        /// <summary>
        /// Sets bits of the attribute bitfield of a currently loaded actor.
        /// 
        /// r0: live actor id
        /// r1: attribute bitfield
        /// </summary>
        public int SetAttributeBitfieldLiveActor
        {
            get
            {
                if (f_setAttributeBitfieldLiveActor)
                    return _setAttributeBitfieldLiveActor;
                _setAttributeBitfieldLiveActor = (int) (116044);
                f_setAttributeBitfieldLiveActor = true;
                return _setAttributeBitfieldLiveActor;
            }
        }
        private bool f_changeActorAnimation;
        private int _changeActorAnimation;

        /// <summary>
        /// Used by the SetAnimation opcode to change the animation of an actor.
        /// 
        /// It's responsible for breaking down the SetAnimation parameter and determining which animation to play and which flags to set.
        /// 
        /// r0: live actor
        /// r1: SetAnimation parameter
        /// </summary>
        public int ChangeActorAnimation
        {
            get
            {
                if (f_changeActorAnimation)
                    return _changeActorAnimation;
                _changeActorAnimation = (int) (119272);
                f_changeActorAnimation = true;
                return _changeActorAnimation;
            }
        }
        private bool f_setPositionLiveObject;
        private int _setPositionLiveObject;

        /// <summary>
        /// Sets the position for a currently loaded object.
        /// 
        /// r0: live object
        /// r1: pointer to a position vector
        /// </summary>
        public int SetPositionLiveObject
        {
            get
            {
                if (f_setPositionLiveObject)
                    return _setPositionLiveObject;
                _setPositionLiveObject = (int) (134544);
                f_setPositionLiveObject = true;
                return _setPositionLiveObject;
            }
        }
        private bool f_unlockMainRoutine;
        private int _unlockMainRoutine;

        /// <summary>
        /// Unlocks the main routine of the current script, as specified in GROUND_STATE_PTRS::main_routine.
        /// 
        /// r0: lock id
        /// return: True if the script routine was successfully unlocked
        /// </summary>
        public int UnlockMainRoutine
        {
            get
            {
                if (f_unlockMainRoutine)
                    return _unlockMainRoutine;
                _unlockMainRoutine = (int) (111728);
                f_unlockMainRoutine = true;
                return _unlockMainRoutine;
            }
        }
        private bool f_worldMapSetCamera;
        private int _worldMapSetCamera;

        /// <summary>
        /// Function called with the script function &quot;worldmap_SetCamera&quot;.
        /// Set the map marker the world map should try to center on (while still ensuring it doesn't go over the background border)
        /// Has no effect if no map is currently set
        /// 
        /// r0: map marker id
        /// </summary>
        public int WorldMapSetCamera
        {
            get
            {
                if (f_worldMapSetCamera)
                    return _worldMapSetCamera;
                _worldMapSetCamera = (int) (208608);
                f_worldMapSetCamera = true;
                return _worldMapSetCamera;
            }
        }
        private bool f_getEffectStatusLiveObject;
        private int _getEffectStatusLiveObject;

        /// <summary>
        /// Gets the effect status of a currently loaded object.
        /// 
        /// Used to determine if an effect has finished via the script opcode WaitEffect.
        /// 
        /// r0: live object
        /// return: status
        /// </summary>
        public int GetEffectStatusLiveObject
        {
            get
            {
                if (f_getEffectStatusLiveObject)
                    return _getEffectStatusLiveObject;
                _getEffectStatusLiveObject = (int) (135384);
                f_getEffectStatusLiveObject = true;
                return _getEffectStatusLiveObject;
            }
        }
        private bool f_setHeightLiveActor;
        private int _setHeightLiveActor;

        /// <summary>
        /// Sets the height of a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: height
        /// </summary>
        public int SetHeightLiveActor
        {
            get
            {
                if (f_setHeightLiveActor)
                    return _setHeightLiveActor;
                _setHeightLiveActor = (int) (125284);
                f_setHeightLiveActor = true;
                return _setHeightLiveActor;
            }
        }
        private bool f_setPositionOffsetLiveObject;
        private int _setPositionOffsetLiveObject;

        /// <summary>
        /// Offsets a currently loaded object's position.
        /// 
        /// r0: live object
        /// r1: pointer to an position offset vector
        /// </summary>
        public int SetPositionOffsetLiveObject
        {
            get
            {
                if (f_setPositionOffsetLiveObject)
                    return _setPositionOffsetLiveObject;
                _setPositionOffsetLiveObject = (int) (135480);
                f_setPositionOffsetLiveObject = true;
                return _setPositionOffsetLiveObject;
            }
        }
        private bool f_getDirectionLiveActor;
        private int _getDirectionLiveActor;

        /// <summary>
        /// Gets the direction of a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: [output] pointer to direction
        /// </summary>
        public int GetDirectionLiveActor
        {
            get
            {
                if (f_getDirectionLiveActor)
                    return _getDirectionLiveActor;
                _getDirectionLiveActor = (int) (125292);
                f_getDirectionLiveActor = true;
                return _getDirectionLiveActor;
            }
        }
        private bool f_scriptParamToInt;
        private int _scriptParamToInt;

        /// <summary>
        /// Converts the given opcode parameter to a signed integer.
        /// 
        /// The parameter will be returned unchanged unless one of its two most significant bits (0x8000 and 0x4000) are set, in which case both bits will be cleared and the original value will be modified according to the following two rules:
        /// - If the 0x4000 bit is set (sign bit), the value will be set to -16384 + value.
        /// - If the 0x8000 bit is set (fixed-point flag), the value will be set to value / 256, rounded down.
        /// Both rules can be applied, in the same order as listed, if both conditions are met.
        /// 
        /// r0: Parameter to convert
        /// return: The input parameter, as a signed integer
        /// </summary>
        public int ScriptParamToInt
        {
            get
            {
                if (f_scriptParamToInt)
                    return _scriptParamToInt;
                _scriptParamToInt = (int) (34412);
                f_scriptParamToInt = true;
                return _scriptParamToInt;
            }
        }
        private bool f_getRandomNpcJobType;
        private int _getRandomNpcJobType;

        /// <summary>
        /// Implements SPECIAL_PROC_GET_RANDOM_NPC_JOB_TYPE (see ScriptSpecialProcessCall).
        /// 
        /// return: job type?
        /// </summary>
        public int GetRandomNpcJobType
        {
            get
            {
                if (f_getRandomNpcJobType)
                    return _getRandomNpcJobType;
                _getRandomNpcJobType = (int) (49020);
                f_getRandomNpcJobType = true;
                return _getRandomNpcJobType;
            }
        }
        private bool f_scriptParamToFixedPoint16;
        private int _scriptParamToFixedPoint16;

        /// <summary>
        /// Converts the given opcode parameter to a 16-bit signed fixed-point number with 8 fraction bits.
        /// 
        /// The resulting number is encoded as (value) * 256, with the last byte acting as a fraction byte capable of representing multiples of 1/256.
        /// 
        /// The parameter will either be returned unchanged or modified depending on which of its two most significant bits (0x8000 and 0x4000) are set. Both bits are unset before running the operations listed below:
        /// - If the 0x4000 bit is set (sign bit), the value will be set to -16384 + value.
        /// - If the 0x8000 bit is set (fixed-point flag), the raw value is interpreted as being fixed-point already, and nothing else happens. Otherwise, it's assumed to be a normal integer and is converted to fixed-point by left-shifting it by 8 (moving the integer part to its proper place).
        /// Both rules can be applied, in the same order as listed, if both conditions are met.
        /// 
        /// r0: Parameter to convert
        /// return: The input parameter, as a 16-bit signed fixed-point number with 8 fraction bits
        /// </summary>
        public int ScriptParamToFixedPoint16
        {
            get
            {
                if (f_scriptParamToFixedPoint16)
                    return _scriptParamToFixedPoint16;
                _scriptParamToFixedPoint16 = (int) (34464);
                f_scriptParamToFixedPoint16 = true;
                return _scriptParamToFixedPoint16;
            }
        }
        private bool f_setPositionLivePerformerVeneer;
        private int _setPositionLivePerformerVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for SetPositionLivePerformer.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: live performer
        /// r1: pointer to a position vector
        /// </summary>
        public int SetPositionLivePerformerVeneer
        {
            get
            {
                if (f_setPositionLivePerformerVeneer)
                    return _setPositionLivePerformerVeneer;
                _setPositionLivePerformerVeneer = (int) (140240);
                f_setPositionLivePerformerVeneer = true;
                return _setPositionLivePerformerVeneer;
            }
        }
        private bool f_deleteLiveActor;
        private int _deleteLiveActor;

        /// <summary>
        /// Remove the actor from the actor list (in GROUND_STATE_PTRS)
        /// 
        /// r0: the index of the actor in the live actor list
        /// </summary>
        public int DeleteLiveActor
        {
            get
            {
                if (f_deleteLiveActor)
                    return _deleteLiveActor;
                _deleteLiveActor = (int) (115608);
                f_deleteLiveActor = true;
                return _deleteLiveActor;
            }
        }
        private bool f_setAttributeBitfieldLiveObject;
        private int _setAttributeBitfieldLiveObject;

        /// <summary>
        /// Sets bits of the attribute bitfield of a currently loaded object.
        /// 
        /// r0: live object id
        /// r1: attribute bitfield
        /// </summary>
        public int SetAttributeBitfieldLiveObject
        {
            get
            {
                if (f_setAttributeBitfieldLiveObject)
                    return _setAttributeBitfieldLiveObject;
                _setAttributeBitfieldLiveObject = (int) (132120);
                f_setAttributeBitfieldLiveObject = true;
                return _setAttributeBitfieldLiveObject;
            }
        }
        private bool f_scriptSpecialProcessCall;
        private int _scriptSpecialProcessCall;

        /// <summary>
        /// Processes calls to the OPCODE_PROCESS_SPECIAL script opcode.
        /// 
        /// r0: some struct containing a callback of some sort, only used for special process ID 18
        /// r1: special process ID
        /// r2: first argument, if relevant? Probably corresponds to the second parameter of OPCODE_PROCESS_SPECIAL
        /// r3: second argument, if relevant? Probably corresponds to the third parameter of OPCODE_PROCESS_SPECIAL
        /// return: return value of the special process if it has one, otherwise 0
        /// </summary>
        public int ScriptSpecialProcessCall
        {
            get
            {
                if (f_scriptSpecialProcessCall)
                    return _scriptSpecialProcessCall;
                _scriptSpecialProcessCall = (int) (44760);
                f_scriptSpecialProcessCall = true;
                return _scriptSpecialProcessCall;
            }
        }
        private bool f_loadFileFromRomVeneer;
        private int _loadFileFromRomVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for LoadFileFromRom.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: [output] pointer to an IO struct {ptr, len}
        /// r1: file path string pointer
        /// r2: flags
        /// </summary>
        public int LoadFileFromRomVeneer
        {
            get
            {
                if (f_loadFileFromRomVeneer)
                    return _loadFileFromRomVeneer;
                _loadFileFromRomVeneer = (int) (33948);
                f_loadFileFromRomVeneer = true;
                return _loadFileFromRomVeneer;
            }
        }
        private bool f_getCollisionBoxCenterLiveObject;
        private int _getCollisionBoxCenterLiveObject;

        /// <summary>
        /// Gets the center of a collision box of a currently loaded object.
        /// 
        /// This simply adds the object's minimum coordinates by half the size of the object's collision box.
        /// 
        /// r0: live object
        /// r1: [output] collision box center buffer
        /// </summary>
        public int GetCollisionBoxCenterLiveObject
        {
            get
            {
                if (f_getCollisionBoxCenterLiveObject)
                    return _getCollisionBoxCenterLiveObject;
                _getCollisionBoxCenterLiveObject = (int) (135036);
                f_getCollisionBoxCenterLiveObject = true;
                return _getCollisionBoxCenterLiveObject;
            }
        }
        private bool f_handleControlsTopScreenGround;
        private int _handleControlsTopScreenGround;

        /// <summary>
        /// Handles the controls top screen display in the overworld.
        /// 
        /// For some reason the implementation seems considerably jankier in ground mode. In dungeon mode there's this structure for the top screen that has handlers for creating, updating and closing the various top screen layouts in a sort of polymorphic way. Here there's just a separate function for every layout that gets called every frame and seems to have a switch-case to handle everything about it.
        /// 
        /// No params.
        /// </summary>
        public int HandleControlsTopScreenGround
        {
            get
            {
                if (f_handleControlsTopScreenGround)
                    return _handleControlsTopScreenGround;
                _handleControlsTopScreenGround = (int) (205876);
                f_handleControlsTopScreenGround = true;
                return _handleControlsTopScreenGround;
            }
        }
        private bool f_setPositionOffsetLiveActor;
        private int _setPositionOffsetLiveActor;

        /// <summary>
        /// Offsets a currently loaded actor's position.
        /// 
        /// r0: live actor
        /// r1: pointer to an position offset vector
        /// </summary>
        public int SetPositionOffsetLiveActor
        {
            get
            {
                if (f_setPositionOffsetLiveActor)
                    return _setPositionOffsetLiveActor;
                _setPositionOffsetLiveActor = (int) (125572);
                f_setPositionOffsetLiveActor = true;
                return _setPositionOffsetLiveActor;
            }
        }
        private bool f_isScreenFadeInProgress;
        private int _isScreenFadeInProgress;

        /// <summary>
        /// Used for example in the handler functions of the top screen types in ground mode to check whether the top screen fade is complete or not.
        /// 
        /// return: True if the top screen is still fading, false if it's done fading.
        /// </summary>
        public int IsScreenFadeInProgress
        {
            get
            {
                if (f_isScreenFadeInProgress)
                    return _isScreenFadeInProgress;
                _isScreenFadeInProgress = (int) (56632);
                f_isScreenFadeInProgress = true;
                return _isScreenFadeInProgress;
            }
        }
        private bool f_setEffectLivePerformer;
        private int _setEffectLivePerformer;

        /// <summary>
        /// Sets the effect of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: flag (true if effect id is 0?)
        /// r2: effect id
        /// </summary>
        public int SetEffectLivePerformer
        {
            get
            {
                if (f_setEffectLivePerformer)
                    return _setEffectLivePerformer;
                _setEffectLivePerformer = (int) (140504);
                f_setEffectLivePerformer = true;
                return _setEffectLivePerformer;
            }
        }
        private bool f_scriptSpecialProcess0x16;
        private int _scriptSpecialProcess0x16;

        /// <summary>
        /// Implements SPECIAL_PROC_0x16 (see ScriptSpecialProcessCall).
        /// 
        /// r0: bool
        /// </summary>
        public int ScriptSpecialProcess0x16
        {
            get
            {
                if (f_scriptSpecialProcess0x16)
                    return _scriptSpecialProcess0x16;
                _scriptSpecialProcess0x16 = (int) (54452);
                f_scriptSpecialProcess0x16 = true;
                return _scriptSpecialProcess0x16;
            }
        }
        private bool f_groundMainLoop;
        private int _groundMainLoop;

        /// <summary>
        /// Appears to be the main loop for ground mode.
        /// 
        /// Based on debug print statements and general code structure, it seems contain a core loop, and dispatches to various functions in response to different events.
        /// 
        /// r0: mode, which is stored globally and used in switch statements for dispatch
        /// return: return code
        /// </summary>
        public int GroundMainLoop
        {
            get
            {
                if (f_groundMainLoop)
                    return _groundMainLoop;
                _groundMainLoop = (int) (50484);
                f_groundMainLoop = true;
                return _groundMainLoop;
            }
        }
        private bool f_loadMapType10;
        private int _loadMapType10;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] buffer_ptr
        /// r1: map_id
        /// r2: dungeon_info_str
        /// r3: additional_info
        /// </summary>
        public int LoadMapType10
        {
            get
            {
                if (f_loadMapType10)
                    return _loadMapType10;
                _loadMapType10 = (int) (68324);
                f_loadMapType10 = true;
                return _loadMapType10;
            }
        }
        private bool f_unlockActorRoutines;
        private int _unlockActorRoutines;

        /// <summary>
        /// Attempts to unlock all live actor routines of the current script.
        /// 
        /// r0: lock id
        /// return: True if any script routine was successfully unlocked
        /// </summary>
        public int UnlockActorRoutines
        {
            get
            {
                if (f_unlockActorRoutines)
                    return _unlockActorRoutines;
                _unlockActorRoutines = (int) (118328);
                f_unlockActorRoutines = true;
                return _unlockActorRoutines;
            }
        }
        private bool f_getAnimationStatusLiveObject;
        private int _getAnimationStatusLiveObject;

        /// <summary>
        /// Gets the animation status of a currently loaded object.
        /// 
        /// Used to determine if the animation has finished via script opcodes like WaitAnimation and WaitEndAnimation.
        /// 
        /// r0: live object
        /// return: status
        /// </summary>
        public int GetAnimationStatusLiveObject
        {
            get
            {
                if (f_getAnimationStatusLiveObject)
                    return _getAnimationStatusLiveObject;
                _getAnimationStatusLiveObject = (int) (135352);
                f_getAnimationStatusLiveObject = true;
                return _getAnimationStatusLiveObject;
            }
        }
        private bool f_createTeamInfoBox;
        private int _createTeamInfoBox;

        /// <summary>
        /// Creates a window containing team information (rank and money carried) for the top-level menu in ground mode. Also see struct team_info_box.
        /// 
        /// The new window will always default to TEAM_INFO_BOX_DEFAULT_WINDOW_PARAMS.
        /// 
        /// return: window_id
        /// </summary>
        public int CreateTeamInfoBox
        {
            get
            {
                if (f_createTeamInfoBox)
                    return _createTeamInfoBox;
                _createTeamInfoBox = (int) (142516);
                f_createTeamInfoBox = true;
                return _createTeamInfoBox;
            }
        }
        private bool f_getCollisionBoxCenterLivePerformer;
        private int _getCollisionBoxCenterLivePerformer;

        /// <summary>
        /// Gets the center of a collision box of a currently loaded performer.
        /// 
        /// This simply adds the performer's minimum coordinates by half the size of the performer's collision box.
        /// 
        /// r0: live performer
        /// r1: [output] collision box center buffer
        /// </summary>
        public int GetCollisionBoxCenterLivePerformer
        {
            get
            {
                if (f_getCollisionBoxCenterLivePerformer)
                    return _getCollisionBoxCenterLivePerformer;
                _getCollisionBoxCenterLivePerformer = (int) (140204);
                f_getCollisionBoxCenterLivePerformer = true;
                return _getCollisionBoxCenterLivePerformer;
            }
        }
        private bool f_returnToTitleScreen;
        private int _returnToTitleScreen;

        /// <summary>
        /// Implements SPECIAL_PROC_RETURN_TO_TITLE_SCREEN (see ScriptSpecialProcessCall).
        /// 
        /// r0: fade duration
        /// return: bool (but note that the special process ignores this and always returns 0)
        /// </summary>
        public int ReturnToTitleScreen
        {
            get
            {
                if (f_returnToTitleScreen)
                    return _returnToTitleScreen;
                _returnToTitleScreen = (int) (54356);
                f_returnToTitleScreen = true;
                return _returnToTitleScreen;
            }
        }
        private bool f_getEffectStatusLivePerformer;
        private int _getEffectStatusLivePerformer;

        /// <summary>
        /// Gets the effect status of a currently loaded performer.
        /// 
        /// Used to determine if an effect has finished via the script opcode WaitEffect.
        /// 
        /// r0: live performer
        /// return: status
        /// </summary>
        public int GetEffectStatusLivePerformer
        {
            get
            {
                if (f_getEffectStatusLivePerformer)
                    return _getEffectStatusLivePerformer;
                _getEffectStatusLivePerformer = (int) (140552);
                f_getEffectStatusLivePerformer = true;
                return _getEffectStatusLivePerformer;
            }
        }
        private bool f_setPositionInitialLiveObject;
        private int _setPositionInitialLiveObject;

        /// <summary>
        /// Sets a currently loaded object to return to its initial position.
        /// 
        /// r0: live object
        /// r1: pointer to an position vector; if null, object will return to its initial position
        /// </summary>
        public int SetPositionInitialLiveObject
        {
            get
            {
                if (f_setPositionInitialLiveObject)
                    return _setPositionInitialLiveObject;
                _setPositionInitialLiveObject = (int) (134812);
                f_setPositionInitialLiveObject = true;
                return _setPositionInitialLiveObject;
            }
        }
        private bool f_groundMainReturnDungeon;
        private int _groundMainReturnDungeon;

        /// <summary>
        /// Implements SPECIAL_PROC_RETURN_DUNGEON (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int GroundMainReturnDungeon
        {
            get
            {
                if (f_groundMainReturnDungeon)
                    return _groundMainReturnDungeon;
                _groundMainReturnDungeon = (int) (53716);
                f_groundMainReturnDungeon = true;
                return _groundMainReturnDungeon;
            }
        }
        private bool f_getDirectionLivePerformer;
        private int _getDirectionLivePerformer;

        /// <summary>
        /// Gets the direction of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: [output] pointer to direction
        /// </summary>
        public int GetDirectionLivePerformer
        {
            get
            {
                if (f_getDirectionLivePerformer)
                    return _getDirectionLivePerformer;
                _getDirectionLivePerformer = (int) (140280);
                f_getDirectionLivePerformer = true;
                return _getDirectionLivePerformer;
            }
        }
        private bool f_setPositionLivePerformer;
        private int _setPositionLivePerformer;

        /// <summary>
        /// Sets the position for a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: pointer to a position vector
        /// </summary>
        public int SetPositionLivePerformer
        {
            get
            {
                if (f_setPositionLivePerformer)
                    return _setPositionLivePerformer;
                _setPositionLivePerformer = (int) (139812);
                f_setPositionLivePerformer = true;
                return _setPositionLivePerformer;
            }
        }
        private bool f_updateTopGroundMenu;
        private int _updateTopGroundMenu;

        /// <summary>
        /// Window update function for the top-level ground mode menu.
        /// 
        /// return: status code
        /// </summary>
        public int UpdateTopGroundMenu
        {
            get
            {
                if (f_updateTopGroundMenu)
                    return _updateTopGroundMenu;
                _updateTopGroundMenu = (int) (150892);
                f_updateTopGroundMenu = true;
                return _updateTopGroundMenu;
            }
        }
        private bool f_setAnimationLiveObject;
        private int _setAnimationLiveObject;

        /// <summary>
        /// Sets the animation of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: SetAnimation parameter
        /// </summary>
        public int SetAnimationLiveObject
        {
            get
            {
                if (f_setAnimationLiveObject)
                    return _setAnimationLiveObject;
                _setAnimationLiveObject = (int) (135144);
                f_setAnimationLiveObject = true;
                return _setAnimationLiveObject;
            }
        }
        private bool f_acceptRandomNpcJob;
        private int _acceptRandomNpcJob;

        /// <summary>
        /// Implements SPECIAL_PROC_ACCEPT_RANDOM_NPC_JOB (see ScriptSpecialProcessCall).
        /// 
        /// return: bool
        /// </summary>
        public int AcceptRandomNpcJob
        {
            get
            {
                if (f_acceptRandomNpcJob)
                    return _acceptRandomNpcJob;
                _acceptRandomNpcJob = (int) (49176);
                f_acceptRandomNpcJob = true;
                return _acceptRandomNpcJob;
            }
        }
        private bool f_setHeightLiveObject;
        private int _setHeightLiveObject;

        /// <summary>
        /// Sets the height of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: height
        /// </summary>
        public int SetHeightLiveObject
        {
            get
            {
                if (f_setHeightLiveObject)
                    return _setHeightLiveObject;
                _setHeightLiveObject = (int) (135104);
                f_setHeightLiveObject = true;
                return _setHeightLiveObject;
            }
        }
        private bool f_getAttributeBitfieldLivePerformer;
        private int _getAttributeBitfieldLivePerformer;

        /// <summary>
        /// Gets the attribute bitfield of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: [output] pointer to attribute bitfield
        /// </summary>
        public int GetAttributeBitfieldLivePerformer
        {
            get
            {
                if (f_getAttributeBitfieldLivePerformer)
                    return _getAttributeBitfieldLivePerformer;
                _getAttributeBitfieldLivePerformer = (int) (140608);
                f_getAttributeBitfieldLivePerformer = true;
                return _getAttributeBitfieldLivePerformer;
            }
        }
        private bool f_initAnimDataFromOtherAnimData;
        private int _initAnimDataFromOtherAnimData;

        /// <summary>
        /// Appears to partially copy some animation data into another animation struct, plus doing extra initialization on the destination struct.
        /// 
        /// r0: dst
        /// r1: src
        /// </summary>
        public int InitAnimDataFromOtherAnimData
        {
            get
            {
                if (f_initAnimDataFromOtherAnimData)
                    return _initAnimDataFromOtherAnimData;
                _initAnimDataFromOtherAnimData = (int) (100996);
                f_initAnimDataFromOtherAnimData = true;
                return _initAnimDataFromOtherAnimData;
            }
        }
        private bool f_getHeightLiveActor;
        private int _getHeightLiveActor;

        /// <summary>
        /// Gets the two height values of a currently loaded actor.
        /// 
        /// r0: live actor
        /// r1: [output] pointer to first height value
        /// r2: [output] pointer to second height value, which is curiously not referenced by SetHeightLiveActor
        /// </summary>
        public int GetHeightLiveActor
        {
            get
            {
                if (f_getHeightLiveActor)
                    return _getHeightLiveActor;
                _getHeightLiveActor = (int) (125264);
                f_getHeightLiveActor = true;
                return _getHeightLiveActor;
            }
        }
        private bool f_loadMapType11;
        private int _loadMapType11;

        /// <summary>
        /// Note: unverified, ported from Irdkwia's notes
        /// 
        /// r0: [output] buffer_ptr
        /// r1: map_id
        /// r2: dungeon_info_str
        /// r3: additional_info
        /// </summary>
        public int LoadMapType11
        {
            get
            {
                if (f_loadMapType11)
                    return _loadMapType11;
                _loadMapType11 = (int) (69636);
                f_loadMapType11 = true;
                return _loadMapType11;
            }
        }
        private bool f_initScriptRoutineState;
        private int _initScriptRoutineState;

        /// <summary>
        /// Initializes the various fields of script_routine_state, a struct that seems relevant when handling script opcode operations.
        /// 
        /// r0: script_routine_state pointer
        /// </summary>
        public int InitScriptRoutineState
        {
            get
            {
                if (f_initScriptRoutineState)
                    return _initScriptRoutineState;
                _initScriptRoutineState = (int) (1520);
                f_initScriptRoutineState = true;
                return _initScriptRoutineState;
            }
        }
        private bool f_setBlinkLivePerformer;
        private int _setBlinkLivePerformer;

        /// <summary>
        /// Sets the performer to blink in and out of sight at certain intervals.
        /// 
        /// r0: live performer
        /// r1: frame interval for blinking in
        /// r2: frame interval for blinking out
        /// </summary>
        public int SetBlinkLivePerformer
        {
            get
            {
                if (f_setBlinkLivePerformer)
                    return _setBlinkLivePerformer;
                _setBlinkLivePerformer = (int) (140652);
                f_setBlinkLivePerformer = true;
                return _setBlinkLivePerformer;
            }
        }
        private bool f_setAnimationLivePerformer;
        private int _setAnimationLivePerformer;

        /// <summary>
        /// Sets the animation of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: SetAnimation parameter
        /// </summary>
        public int SetAnimationLivePerformer
        {
            get
            {
                if (f_setAnimationLivePerformer)
                    return _setAnimationLivePerformer;
                _setAnimationLivePerformer = (int) (140312);
                f_setAnimationLivePerformer = true;
                return _setAnimationLivePerformer;
            }
        }
        private bool f_getExclusiveItemRequirements;
        private int _getExclusiveItemRequirements;

        /// <summary>
        /// Used to calculate the items required to get a certain exclusive item in the swap shop.
        /// 
        /// r0: ?
        /// r1: ?
        /// </summary>
        public int GetExclusiveItemRequirements
        {
            get
            {
                if (f_getExclusiveItemRequirements)
                    return _getExclusiveItemRequirements;
                _getExclusiveItemRequirements = (int) (191828);
                f_getExclusiveItemRequirements = true;
                return _getExclusiveItemRequirements;
            }
        }
        private bool f_setMovementRangeLiveObject;
        private int _setMovementRangeLiveObject;

        /// <summary>
        /// Sets a currently loaded object's random movement range.
        /// 
        /// r0: live object
        /// r1: pointer to limit_min_pos
        /// r2: pointer to limit_max_pos
        /// </summary>
        public int SetMovementRangeLiveObject
        {
            get
            {
                if (f_setMovementRangeLiveObject)
                    return _setMovementRangeLiveObject;
                _setMovementRangeLiveObject = (int) (135000);
                f_setMovementRangeLiveObject = true;
                return _setMovementRangeLiveObject;
            }
        }
        private bool f_handleUnlocks;
        private int _handleUnlocks;

        /// <summary>
        /// Checks if a script unlock happened by reading entries from LOCK_NOTIFY_ARRAY and handles the ones that were set.
        /// 
        /// If the global unlock flag is not set, returns immediately. If it is, the function loops LOCK_NOTIFY_ARRAY, checking for true values. If it finds one, resets it back to 0 and handles the unlock.
        /// 
        /// No params.
        /// </summary>
        public int HandleUnlocks
        {
            get
            {
                if (f_handleUnlocks)
                    return _handleUnlocks;
                _handleUnlocks = (int) (33040);
                f_handleUnlocks = true;
                return _handleUnlocks;
            }
        }
        private bool f_setAttributeBitfieldLiveActorWrapper;
        private int _setAttributeBitfieldLiveActorWrapper;

        /// <summary>
        /// Sets bits of the attribute bitfield of a currently loaded actor.
        /// 
        /// Is a wrapper around SetAttributeBitfieldLiveActor, meaning this calls SetAttributeBitfieldLiveActor with a first parameter of live_actor::id.
        /// 
        /// r0: live actor
        /// r1: attribute bitfield
        /// </summary>
        public int SetAttributeBitfieldLiveActorWrapper
        {
            get
            {
                if (f_setAttributeBitfieldLiveActorWrapper)
                    return _setAttributeBitfieldLiveActorWrapper;
                _setAttributeBitfieldLiveActorWrapper = (int) (125524);
                f_setAttributeBitfieldLiveActorWrapper = true;
                return _setAttributeBitfieldLiveActorWrapper;
            }
        }
        private bool f_setAnimDataFields2;
        private int _setAnimDataFields2;

        /// <summary>
        /// Sets some fields on the animation struct, based on the params?
        /// 
        /// r0: animation pointer
        /// r1: flags
        /// r2: ?
        /// </summary>
        public int SetAnimDataFields2
        {
            get
            {
                if (f_setAnimDataFields2)
                    return _setAnimDataFields2;
                _setAnimDataFields2 = (int) (102664);
                f_setAnimDataFields2 = true;
                return _setAnimDataFields2;
            }
        }
        private bool f_loadObjectAnimData;
        private int _loadObjectAnimData;

        /// <summary>
        /// Loads the animation (WAN) data for a given object index?
        /// 
        /// r0: animation pointer
        /// r1: object index
        /// r2: flags
        /// </summary>
        public int LoadObjectAnimData
        {
            get
            {
                if (f_loadObjectAnimData)
                    return _loadObjectAnimData;
                _loadObjectAnimData = (int) (109696);
                f_loadObjectAnimData = true;
                return _loadObjectAnimData;
            }
        }
        private bool f_closeTeamInfoBox;
        private int _closeTeamInfoBox;

        /// <summary>
        /// Closes a window created with CreateTeamInfoBox.
        /// 
        /// r0: window_id
        /// </summary>
        public int CloseTeamInfoBox
        {
            get
            {
                if (f_closeTeamInfoBox)
                    return _closeTeamInfoBox;
                _closeTeamInfoBox = (int) (142700);
                f_closeTeamInfoBox = true;
                return _closeTeamInfoBox;
            }
        }
        private bool f_setPositionLiveObjectVeneer;
        private int _setPositionLiveObjectVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for SetPositionLiveObject.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: live object
        /// r1: pointer to a position vector
        /// </summary>
        public int SetPositionLiveObjectVeneer
        {
            get
            {
                if (f_setPositionLiveObjectVeneer)
                    return _setPositionLiveObjectVeneer;
                _setPositionLiveObjectVeneer = (int) (135072);
                f_setPositionLiveObjectVeneer = true;
                return _setPositionLiveObjectVeneer;
            }
        }
        private bool f_resetAttributeBitfieldLiveActor;
        private int _resetAttributeBitfieldLiveActor;

        /// <summary>
        /// Clears bits of the attribute bitfield of a currently loaded actor.
        /// 
        /// r0: live actor id
        /// r1: attribute bitfield
        /// </summary>
        public int ResetAttributeBitfieldLiveActor
        {
            get
            {
                if (f_resetAttributeBitfieldLiveActor)
                    return _resetAttributeBitfieldLiveActor;
                _resetAttributeBitfieldLiveActor = (int) (116184);
                f_resetAttributeBitfieldLiveActor = true;
                return _resetAttributeBitfieldLiveActor;
            }
        }
        private bool f_initScriptRoutine;
        private int _initScriptRoutine;

        /// <summary>
        /// Initializes the various fields of script_routine.
        /// 
        /// r0: routine pointer
        /// r1: ground entity function table pointer
        /// r2: live entity pointer
        /// </summary>
        public int InitScriptRoutine
        {
            get
            {
                if (f_initScriptRoutine)
                    return _initScriptRoutine;
                _initScriptRoutine = (int) (1704);
                f_initScriptRoutine = true;
                return _initScriptRoutine;
            }
        }
        private bool f_getSpecialRecruitmentSpecies;
        private int _getSpecialRecruitmentSpecies;

        /// <summary>
        /// Returns an entry from RECRUITMENT_TABLE_SPECIES.
        /// 
        /// Note: This indexes without doing bounds checking.
        /// 
        /// r0: index into RECRUITMENT_TABLE_SPECIES
        /// return: enum monster_id
        /// </summary>
        public int GetSpecialRecruitmentSpecies
        {
            get
            {
                if (f_getSpecialRecruitmentSpecies)
                    return _getSpecialRecruitmentSpecies;
                _getSpecialRecruitmentSpecies = (int) (48636);
                f_getSpecialRecruitmentSpecies = true;
                return _getSpecialRecruitmentSpecies;
            }
        }
        private bool f_groundMainNextDay;
        private int _groundMainNextDay;

        /// <summary>
        /// Implements SPECIAL_PROC_NEXT_DAY (see ScriptSpecialProcessCall).
        /// 
        /// No params.
        /// </summary>
        public int GroundMainNextDay
        {
            get
            {
                if (f_groundMainNextDay)
                    return _groundMainNextDay;
                _groundMainNextDay = (int) (53752);
                f_groundMainNextDay = true;
                return _groundMainNextDay;
            }
        }
        private bool f_unlockObjectRoutines;
        private int _unlockObjectRoutines;

        /// <summary>
        /// Attempts to unlock all live object routines of the current script.
        /// 
        /// r0: lock id
        /// return: True if any script routine was successfully unlocked
        /// </summary>
        public int UnlockObjectRoutines
        {
            get
            {
                if (f_unlockObjectRoutines)
                    return _unlockObjectRoutines;
                _unlockObjectRoutines = (int) (133732);
                f_unlockObjectRoutines = true;
                return _unlockObjectRoutines;
            }
        }
        private bool f_getLiveActorIdxFromScriptEntityId;
        private int _getLiveActorIdxFromScriptEntityId;

        /// <summary>
        /// Searches through the live actor list to find the first matching actor who has an ID matching that of a script_entity_id.
        /// 
        /// r0: script_entity_id
        /// return: index of the live actor, or -1 if the specified actor could not be found
        /// </summary>
        public int GetLiveActorIdxFromScriptEntityId
        {
            get
            {
                if (f_getLiveActorIdxFromScriptEntityId)
                    return _getLiveActorIdxFromScriptEntityId;
                _getLiveActorIdxFromScriptEntityId = (int) (113712);
                f_getLiveActorIdxFromScriptEntityId = true;
                return _getLiveActorIdxFromScriptEntityId;
            }
        }
        private bool f_getDirectionLiveObject;
        private int _getDirectionLiveObject;

        /// <summary>
        /// Gets the direction of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: [output] pointer to direction
        /// </summary>
        public int GetDirectionLiveObject
        {
            get
            {
                if (f_getDirectionLiveObject)
                    return _getDirectionLiveObject;
                _getDirectionLiveObject = (int) (135112);
                f_getDirectionLiveObject = true;
                return _getDirectionLiveObject;
            }
        }
        private bool f_setAnimationLiveActor;
        private int _setAnimationLiveActor;

        /// <summary>
        /// Sets the animation of a currently loaded actor. Leads up to a final ChangeActorAnimation call.
        /// 
        /// Includes a check for if live_actor::id is less than 3 and if live_actor::field_0xa is equal to 0x119, which ultimately may perform ((SetAnimation parameter) &amp; 0x1f00 | 0x53).
        /// 
        /// r0: live actor
        /// r1: SetAnimation parameter
        /// </summary>
        public int SetAnimationLiveActor
        {
            get
            {
                if (f_setAnimationLiveActor)
                    return _setAnimationLiveActor;
                _setAnimationLiveActor = (int) (125348);
                f_setAnimationLiveActor = true;
                return _setAnimationLiveActor;
            }
        }
        private bool f_resetAttributeBitfieldLiveObject;
        private int _resetAttributeBitfieldLiveObject;

        /// <summary>
        /// Clears bits of the attribute bitfield of a currently loaded object.
        /// 
        /// r0: live object id
        /// r1: attribute bitfield
        /// </summary>
        public int ResetAttributeBitfieldLiveObject
        {
            get
            {
                if (f_resetAttributeBitfieldLiveObject)
                    return _resetAttributeBitfieldLiveObject;
                _resetAttributeBitfieldLiveObject = (int) (132184);
                f_resetAttributeBitfieldLiveObject = true;
                return _resetAttributeBitfieldLiveObject;
            }
        }
        private bool f_resetAttributeBitfieldLiveObjectWrapper;
        private int _resetAttributeBitfieldLiveObjectWrapper;

        /// <summary>
        /// Clears bits of the attribute bitfield of a currently loaded object.
        /// 
        /// Is a wrapper around ResetAttributeBitfieldLiveObject, meaning this calls ResetAttributeBitfieldLiveObject with a first parameter of live_object::id.
        /// 
        /// r0: live object
        /// r1: attribute bitfield
        /// </summary>
        public int ResetAttributeBitfieldLiveObjectWrapper
        {
            get
            {
                if (f_resetAttributeBitfieldLiveObjectWrapper)
                    return _resetAttributeBitfieldLiveObjectWrapper;
                _resetAttributeBitfieldLiveObjectWrapper = (int) (135448);
                f_resetAttributeBitfieldLiveObjectWrapper = true;
                return _resetAttributeBitfieldLiveObjectWrapper;
            }
        }
        private bool f_getHeightLivePerformer;
        private int _getHeightLivePerformer;

        /// <summary>
        /// Gets the two height values of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: [output] pointer to first height value
        /// r2: [output] pointer to second height value, which is curiously not referenced by SetHeightLivePerformer
        /// </summary>
        public int GetHeightLivePerformer
        {
            get
            {
                if (f_getHeightLivePerformer)
                    return _getHeightLivePerformer;
                _getHeightLivePerformer = (int) (140252);
                f_getHeightLivePerformer = true;
                return _getHeightLivePerformer;
            }
        }
        private bool f_setAttributeBitfieldLivePerformerWrapper;
        private int _setAttributeBitfieldLivePerformerWrapper;

        /// <summary>
        /// Sets bits of the attribute bitfield of a currently loaded performer.
        /// 
        /// Is a wrapper around SetAttributeBitfieldLivePerformer, meaning this calls SetAttributeBitfieldLivePerformer with a first parameter of live_performer::id.
        /// 
        /// r0: live performer
        /// r1: attribute bitfield
        /// </summary>
        public int SetAttributeBitfieldLivePerformerWrapper
        {
            get
            {
                if (f_setAttributeBitfieldLivePerformerWrapper)
                    return _setAttributeBitfieldLivePerformerWrapper;
                _setAttributeBitfieldLivePerformerWrapper = (int) (140620);
                f_setAttributeBitfieldLivePerformerWrapper = true;
                return _setAttributeBitfieldLivePerformerWrapper;
            }
        }
        private bool f_loadBackgroundAttributes;
        private int _loadBackgroundAttributes;

        /// <summary>
        /// Open and read an entry from the MAP_BG/bg_list.dat
        /// 
        /// Documentation on this format can be found here:
        /// https://github.com/SkyTemple/skytemple-files/tree/55b3017631a8a1b0f106111ef91a901dc394c6df/skytemple_files/graphics/bg_list_dat
        /// 
        /// r0: [output] The entry
        /// r1: background ID
        /// </summary>
        public int LoadBackgroundAttributes
        {
            get
            {
                if (f_loadBackgroundAttributes)
                    return _loadBackgroundAttributes;
                _loadBackgroundAttributes = (int) (63744);
                f_loadBackgroundAttributes = true;
                return _loadBackgroundAttributes;
            }
        }
        private bool f_unlockPerformerRoutines;
        private int _unlockPerformerRoutines;

        /// <summary>
        /// Attempts to unlock all live performer routines of the current script.
        /// 
        /// r0: lock id
        /// return: True if any script routine was successfully unlocked
        /// </summary>
        public int UnlockPerformerRoutines
        {
            get
            {
                if (f_unlockPerformerRoutines)
                    return _unlockPerformerRoutines;
                _unlockPerformerRoutines = (int) (139636);
                f_unlockPerformerRoutines = true;
                return _unlockPerformerRoutines;
            }
        }
        private bool f_ssbLoad2;
        private int _ssbLoad2;
        public int SsbLoad2
        {
            get
            {
                if (f_ssbLoad2)
                    return _ssbLoad2;
                _ssbLoad2 = (int) (33980);
                f_ssbLoad2 = true;
                return _ssbLoad2;
            }
        }
        private bool f_getCoroutineInfo;
        private int _getCoroutineInfo;

        /// <summary>
        /// Returns information about a coroutine in unionall
        /// 
        /// It's used by the CallCommon code to pull the data required to call the coroutine, so maybe the function returns data required to call a coroutine instead of info about the coroutine itself.
        /// 
        /// r0: [output] Coroutine info
        /// r1: Coroutine ID
        /// return: True if the coroutine is valid? It's false only if the coroutine's offset is 0.
        /// </summary>
        public int GetCoroutineInfo
        {
            get
            {
                if (f_getCoroutineInfo)
                    return _getCoroutineInfo;
                _getCoroutineInfo = (int) (48504);
                f_getCoroutineInfo = true;
                return _getCoroutineInfo;
            }
        }
        private bool f_getHeightLiveObject;
        private int _getHeightLiveObject;

        /// <summary>
        /// Gets the two height values of a currently loaded object.
        /// 
        /// r0: live object
        /// r1: [output] pointer to first height value
        /// r2: [output] pointer to second height value, which is curiously not referenced by SetHeightLiveObject
        /// </summary>
        public int GetHeightLiveObject
        {
            get
            {
                if (f_getHeightLiveObject)
                    return _getHeightLiveObject;
                _getHeightLiveObject = (int) (135084);
                f_getHeightLiveObject = true;
                return _getHeightLiveObject;
            }
        }
        private bool f_unlockRoutine;
        private int _unlockRoutine;

        /// <summary>
        /// Attempts to unlock a script routine via the Unlock opcode.
        /// 
        /// r0: script routine pointer
        /// r1: lock id
        /// return: True if the script routine was successfully unlocked
        /// </summary>
        public int UnlockRoutine
        {
            get
            {
                if (f_unlockRoutine)
                    return _unlockRoutine;
                _unlockRoutine = (int) (3756);
                f_unlockRoutine = true;
                return _unlockRoutine;
            }
        }
        private bool f_initAnimDataFromOtherAnimDataVeneer;
        private int _initAnimDataFromOtherAnimDataVeneer;

        /// <summary>
        /// Likely a linker-generated veneer for InitAnimDataFromOtherAnimData.
        /// 
        /// See https://developer.arm.com/documentation/dui0474/k/image-structure-and-generation/linker-generated-veneers/what-is-a-veneer-
        /// 
        /// r0: dst
        /// r1: src
        /// </summary>
        public int InitAnimDataFromOtherAnimDataVeneer
        {
            get
            {
                if (f_initAnimDataFromOtherAnimDataVeneer)
                    return _initAnimDataFromOtherAnimDataVeneer;
                _initAnimDataFromOtherAnimDataVeneer = (int) (109864);
                f_initAnimDataFromOtherAnimDataVeneer = true;
                return _initAnimDataFromOtherAnimDataVeneer;
            }
        }
        private bool f_getFreeArenaGround;
        private int _getFreeArenaGround;

        /// <summary>
        /// The GetFreeArena function used for ground mode. See SetMemAllocatorParams for more information.
        /// 
        /// r0: initial memory arena pointer, or null
        /// r1: pointer to free
        /// return: memory arena pointer, or null
        /// </summary>
        public int GetFreeArenaGround
        {
            get
            {
                if (f_getFreeArenaGround)
                    return _getFreeArenaGround;
                _getFreeArenaGround = (int) (53632);
                f_getFreeArenaGround = true;
                return _getFreeArenaGround;
            }
        }
        private bool f_getCollisionBoxLivePerformer;
        private int _getCollisionBoxLivePerformer;

        /// <summary>
        /// Gets the collision box of a currently loaded performer.
        /// 
        /// r0: live performer
        /// r1: [output] collision box buffer
        /// </summary>
        public int GetCollisionBoxLivePerformer
        {
            get
            {
                if (f_getCollisionBoxLivePerformer)
                    return _getCollisionBoxLivePerformer;
                _getCollisionBoxLivePerformer = (int) (139960);
                f_getCollisionBoxLivePerformer = true;
                return _getCollisionBoxLivePerformer;
            }
        }
        private bool f_getEffectStatusLiveActor;
        private int _getEffectStatusLiveActor;

        /// <summary>
        /// Gets the effect status of a currently loaded actor.
        /// 
        /// Used to determine if an effect has finished via the script opcode WaitEffect.
        /// 
        /// r0: live actor
        /// return: status
        /// </summary>
        public int GetEffectStatusLiveActor
        {
            get
            {
                if (f_getEffectStatusLiveActor)
                    return _getEffectStatusLiveActor;
                _getEffectStatusLiveActor = (int) (125476);
                f_getEffectStatusLiveActor = true;
                return _getEffectStatusLiveActor;
            }
        }
        private bool f_allocAndInitPartnerFollowDataAndLiveActorList;
        private int _allocAndInitPartnerFollowDataAndLiveActorList;

        /// <summary>
        /// Allocate and initialize the partner follow data and the live actor list (in GROUND_STATE_PTRS)
        /// 
        /// No params.
        /// </summary>
        public int AllocAndInitPartnerFollowDataAndLiveActorList
        {
            get
            {
                if (f_allocAndInitPartnerFollowDataAndLiveActorList)
                    return _allocAndInitPartnerFollowDataAndLiveActorList;
                _allocAndInitPartnerFollowDataAndLiveActorList = (int) (113372);
                f_allocAndInitPartnerFollowDataAndLiveActorList = true;
                return _allocAndInitPartnerFollowDataAndLiveActorList;
            }
        }
        private bool f_closeTopGroundMenu;
        private int _closeTopGroundMenu;

        /// <summary>
        /// Closes the three windows created by CreateOverworldMenu.
        /// 
        /// No params.
        /// </summary>
        public int CloseTopGroundMenu
        {
            get
            {
                if (f_closeTopGroundMenu)
                    return _closeTopGroundMenu;
                _closeTopGroundMenu = (int) (150800);
                f_closeTopGroundMenu = true;
                return _closeTopGroundMenu;
            }
        }
        private bool f_setAnimDataFields;
        private int _setAnimDataFields;

        /// <summary>
        /// Sets some fields on the animation struct?
        /// 
        /// r0: animation pointer
        /// r1: ?
        /// </summary>
        public int SetAnimDataFields
        {
            get
            {
                if (f_setAnimDataFields)
                    return _setAnimDataFields;
                _setAnimDataFields = (int) (99900);
                f_setAnimDataFields = true;
                return _setAnimDataFields;
            }
        }
        private bool f_deleteLivePerformer;
        private int _deleteLivePerformer;

        /// <summary>
        /// Remove the performer from the performer list (in GROUND_STATE_PTRS)
        /// 
        /// r0: the index of the performer in the live performer list
        /// </summary>
        public int DeleteLivePerformer
        {
            get
            {
                if (f_deleteLivePerformer)
                    return _deleteLivePerformer;
                _deleteLivePerformer = (int) (137740);
                f_deleteLivePerformer = true;
                return _deleteLivePerformer;
            }
        }
        private bool f_getCollidingActorId;
        private int _getCollidingActorId;

        /// <summary>
        /// Returns the first colliding actor given a series of vector coordinates.
        /// 
        /// r0: live actor id (used only to ignore an actor colliding with itself)
        /// r1: attribute bitfield to test actors against
        /// r2: pointer to coord_min
        /// r3: pointer to coord_max
        /// return: The first colliding actor's id, or -1 if no is collision detected
        /// </summary>
        public int GetCollidingActorId
        {
            get
            {
                if (f_getCollidingActorId)
                    return _getCollidingActorId;
                _getCollidingActorId = (int) (118688);
                f_getCollidingActorId = true;
                return _getCollidingActorId;
            }
        }
        private bool f_lockRoutine;
        private int _lockRoutine;

        /// <summary>
        /// Sets a routine to be locked via the Lock opcode.
        /// 
        /// r0: script routine pointer
        /// r1: lock id
        /// return: Always 1, but this does seem to get checked in RunNextOpcode for some reason
        /// </summary>
        public int LockRoutine
        {
            get
            {
                if (f_lockRoutine)
                    return _lockRoutine;
                _lockRoutine = (int) (3244);
                f_lockRoutine = true;
                return _lockRoutine;
            }
        }
        private bool f_setBlinkLiveActor;
        private int _setBlinkLiveActor;

        /// <summary>
        /// Sets the actor to blink in and out of sight at certain intervals.
        /// 
        /// r0: live actor
        /// r1: frame interval for blinking in
        /// r2: frame interval for blinking out
        /// </summary>
        public int SetBlinkLiveActor
        {
            get
            {
                if (f_setBlinkLiveActor)
                    return _setBlinkLiveActor;
                _setBlinkLiveActor = (int) (125556);
                f_setBlinkLiveActor = true;
                return _setBlinkLiveActor;
            }
        }
        private bool f_setPositionInitialLiveActor;
        private int _setPositionInitialLiveActor;

        /// <summary>
        /// Sets a currently loaded actor to return to its initial position.
        /// 
        /// r0: live actor
        /// r1: pointer to an position vector; if null, actor will return to its initial position
        /// </summary>
        public int SetPositionInitialLiveActor
        {
            get
            {
                if (f_setPositionInitialLiveActor)
                    return _setPositionInitialLiveActor;
                _setPositionInitialLiveActor = (int) (124992);
                f_setPositionInitialLiveActor = true;
                return _setPositionInitialLiveActor;
            }
        }
        private Overlay11Functions m_root;
        private KaitaiStruct m_parent;
        public Overlay11Functions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
