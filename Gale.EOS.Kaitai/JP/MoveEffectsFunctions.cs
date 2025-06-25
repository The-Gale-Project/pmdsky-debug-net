// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// List of functions within MOVE_EFFECTS with relative address locations as their values.
    /// </summary>
    public partial class MoveEffectsFunctions : KaitaiStruct
    {
        public static MoveEffectsFunctions FromFile(string fileName)
        {
            return new MoveEffectsFunctions(new KaitaiStream(fileName));
        }

        public MoveEffectsFunctions(KaitaiStream p__io, KaitaiStruct p__parent = null, MoveEffectsFunctions p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_doMoveMist = false;
            f_doMoveEscape = false;
            f_doMovePowerTrick = false;
            f_doMoveTripleKick = false;
            f_doMoveHeadSmash = false;
            f_doMoveLunarDance = false;
            f_doMoveOneRoom = false;
            f_doMoveFakeTears = false;
            f_doMoveLastResort = false;
            f_doMoveDefendOrder = false;
            f_doMoveSleepTalk = false;
            f_doMoveGrowl = false;
            f_doMoveDamageWithRecoil = false;
            f_doMoveSonicBoom = false;
            f_doMoveMobile = false;
            f_doMoveDefenseCurl = false;
            f_doMoveRazorWind = false;
            f_doMoveConfuse = false;
            f_doMoveTrapBuster = false;
            f_doMoveDamageConstrict10 = false;
            f_doMoveSureShot = false;
            f_doMoveMorningSun = false;
            f_doMoveWish = false;
            f_doMoveCurse = false;
            f_doMoveAssist = false;
            f_doMoveDracoMeteor = false;
            f_doMoveThunderWave = false;
            f_doMoveSearchlight = false;
            f_doMoveMagnetRise = false;
            f_doMovePayDay = false;
            f_doMoveWaterfall = false;
            f_doMoveOneShot = false;
            f_doMoveBoostDefense2 = false;
            f_doMoveWakeUpSlap = false;
            f_doMoveBlazeKick = false;
            f_doMovePoisonFang = false;
            f_doMoveSkyAttack = false;
            f_doMoveShadowBall = false;
            f_doMoveMemento = false;
            f_doMoveNastyPlot = false;
            f_doMoveEndeavor = false;
            f_doMoveSecretPower = false;
            f_doMovePainSplit = false;
            f_doMoveZapCannon = false;
            f_doMoveDamageParalyze10 = false;
            f_doMoveHeartSwap = false;
            f_doMoveHammerArm = false;
            f_doMoveThunderFang = false;
            f_doMoveLightScreen = false;
            f_doMoveDamageLowerSpecialDefense50 = false;
            f_doMoveDoubleEdge = false;
            f_doMoveFireFang = false;
            f_doMoveTag0x1Ab = false;
            f_doMoveAuroraBeam = false;
            f_doMoveInvisify = false;
            f_doMoveBulkUp = false;
            f_doMoveMeteorMash = false;
            f_doMoveTag0x1A6 = false;
            f_doMoveTag0x1A7 = false;
            f_doMoveDamagePoison18 = false;
            f_doMoveGastroAcid = false;
            f_doMoveSplash = false;
            f_doMoveLowerSpeed1 = false;
            f_doMoveEncore = false;
            f_doMoveSetDamage = false;
            f_doMoveHiddenPower = false;
            f_doMoveMiracleEye = false;
            f_doMoveMirrorMove = false;
            f_doMoveHaze = false;
            f_doMovePsywave = false;
            f_doMoveConversion2 = false;
            f_doMoveBoostAttack1 = false;
            f_doMoveDoubleTeam = false;
            f_doMoveSpite = false;
            f_doMoveIceFang = false;
            f_doMoveVitalThrow = false;
            f_doMoveLongToss = false;
            f_doMoveSunnyDay = false;
            f_doMoveFillIn = false;
            f_doMoveSpikes = false;
            f_doMoveExplosion = false;
            f_doMoveReturn = false;
            f_doMoveShadowForce = false;
            f_doMoveDefog = false;
            f_doMoveMetalBurst = false;
            f_doMoveHealStatus = false;
            f_doMoveWorrySeed = false;
            f_doMoveHeadbutt = false;
            f_doMoveDamageLowerSpeed20 = false;
            f_doMoveRainDance = false;
            f_doMoveDamageLowerAccuracy40 = false;
            f_doMoveRecoverHp = false;
            f_doMoveFeint = false;
            f_doMoveBellyDrum = false;
            f_doMoveSnatch = false;
            f_doMoveStockpile = false;
            f_getNaturePowerVariant = false;
            f_doMoveThunderbolt = false;
            f_doMoveFissure = false;
            f_doMoveHiJumpKick = false;
            f_doMoveYawn = false;
            f_doMoveGyroBall = false;
            f_doMoveSmellingSalt = false;
            f_doMoveDamageLowerSpeed100 = false;
            f_doMoveTaunt = false;
            f_doMovePsychoShift = false;
            f_doMovePoison = false;
            f_doMoveEruption = false;
            f_doMoveDamageBoostAllStats = false;
            f_doMoveSelfdestruct = false;
            f_doMoveCounter = false;
            f_doMoveHail = false;
            f_doMoveIngrain = false;
            f_doMoveDamageFreeze15 = false;
            f_doMoveDive = false;
            f_doMoveDamageWeightDependent = false;
            f_doMoveEmbargo = false;
            f_doMoveRolePlay = false;
            f_doMoveDamageCringe20 = false;
            f_doMoveThundershock = false;
            f_doMoveMetalSound = false;
            f_doMoveDreamEater = false;
            f_doMoveNightmare = false;
            f_doMoveBounce = false;
            f_doMovePowerSwap = false;
            f_doMoveLeechSeed = false;
            f_doMoveSwapItems = false;
            f_doMoveAquaRing = false;
            f_doMoveReflect = false;
            f_doMoveBideUnleash = false;
            f_doMoveDamageConfuse30 = false;
            f_doMoveSuperFang = false;
            f_doMoveCharm = false;
            f_doMoveScan = false;
            f_doMoveEcho = false;
            f_doMoveGrowth = false;
            f_doMovePounce = false;
            f_doMoveDamageStealItem = false;
            f_doMoveTakeaway = false;
            f_doMoveWildCall = false;
            f_doMoveDamageBurn10 = false;
            f_doMoveSeeTrap = false;
            f_doMoveGravity = false;
            f_doMoveDynamicPunch = false;
            f_doMoveSteelWing = false;
            f_doMoveWhirlpool = false;
            f_doMoveShadowHold = false;
            f_doMovePsychoBoost = false;
            f_doMoveMetronome = false;
            f_doMoveCalmMind = false;
            f_doMoveMirrorCoat = false;
            f_doMoveSport = false;
            f_doMoveBrine = false;
            f_doMoveOhko = false;
            f_doMoveEarthquake = false;
            f_doMoveRebound = false;
            f_doMoveTrawl = false;
            f_doMoveDamageLowerDefensiveStatVariable = false;
            f_doMoveBrickBreak = false;
            f_doMoveTwineedle = false;
            f_doMoveSeeStairs = false;
            f_doMoveHelpingHand = false;
            f_doMoveAbsorb = false;
            f_doMoveGuardSwap = false;
            f_doMoveTransfer = false;
            f_doMoveCamouflage = false;
            f_doMoveSkullBash = false;
            f_doMoveDamageCringe10 = false;
            f_doMoveFocusPunch = false;
            f_doMoveTrapper = false;
            f_doMoveDamagePoison40 = false;
            f_doMoveStringShot = false;
            f_doMovePause = false;
            f_doMoveDamageDrain = false;
            f_doMoveLuckyChant = false;
            f_doMoveNightShade = false;
            f_doMoveCrushClaw = false;
            f_doMoveDamageHpDependent = false;
            f_doMoveSandstorm = false;
            f_doMoveSleep = false;
            f_doMoveFeatherDance = false;
            f_doMoveRest = false;
            f_doMoveVacuumCut = false;
            f_doMoveSynthesis = false;
            f_doMoveUproar = false;
            f_doMoveSwordsDance = false;
            f_doMoveLeafStorm = false;
            f_doMoveReviver = false;
            f_doMoveDamageConfuse10 = false;
            f_doMoveRapidSpin = false;
            f_doMoveAttract = false;
            f_doMoveCloseCombat = false;
            f_doMoveAcupressure = false;
            f_doMoveTailGlow = false;
            f_doMoveLowerAccuracy1 = false;
            f_doMoveRecoverHpTeam = false;
            f_doMoveHealingWish = false;
            f_doMoveDamageMultihitFatigue = false;
            f_doMoveMoonlight = false;
            f_doMoveWarp = false;
            f_doMoveToxic = false;
            f_doMoveKnockOff = false;
            f_doMoveRockSmash = false;
            f_doMoveShocker = false;
            f_doMoveCleanse = false;
            f_doMoveDamageCringe30 = false;
            f_doMoveSwallow = false;
            f_doMoveToxicSpikes = false;
            f_doMoveSafeguard = false;
            f_doMoveTorment = false;
            f_doMoveDamageMultihitUntilMiss = false;
            f_doMoveSkillSwap = false;
            f_doMoveRoost = false;
            f_doMoveFrustration = false;
            f_doMoveSwagger = false;
            f_doMoveChargeBeam = false;
            f_doMoveNaturalGift = false;
            f_doMoveAmnesia = false;
            f_doMovePoisonTail = false;
            f_doMoveDamageBurn10FlameWheel = false;
            f_doMoveTwoEdge = false;
            f_doMoveBubble = false;
            f_doMoveFakeOut = false;
            f_doMoveGrudge = false;
            f_doMoveOctazooka = false;
            f_doMoveDragonDance = false;
            f_doMoveBide = false;
            f_doMoveSweetScent = false;
            f_doMoveProtect = false;
            f_doMoveCaptivate = false;
            f_doMoveFlareBlitz = false;
            f_doMoveMetalClaw = false;
            f_doMoveDamageEatItem = false;
            f_doMoveHealOrder = false;
            f_doMoveTrickRoom = false;
            f_doMoveSuperpower = false;
            f_doMoveSlowDown = false;
            f_doMoveMinimize = false;
            f_doMoveHornDrill = false;
            f_doMoveSketch = false;
            f_doMovePsychUp = false;
            f_doMoveBlastBurn = false;
            f_doMoveFocusEnergy = false;
            f_doMoveBlock = false;
            f_doMoveDig = false;
            f_doMoveSeismicToss = false;
            f_doMoveConversion = false;
            f_doMoveStruggle = false;
            f_doMoveSpitUp = false;
            f_doMoveFacade = false;
            f_doMoveRage = false;
            f_doMovePerishSong = false;
            f_doMoveScreech = false;
            f_doMoveItemize = false;
            f_doMoveLowerDefense1 = false;
            f_doMoveCharge = false;
            f_doMoveStealthRock = false;
            f_doMoveBlowback = false;
            f_doMoveBoostSpeed1 = false;
            f_doMoveHealBlock = false;
            f_doMoveNoMove = false;
            f_doMoveBoostDefense1 = false;
            f_doMoveGust = false;
            f_doMoveCrunch = false;
            f_doMoveDrought = false;
            f_doMoveRockPolish = false;
            f_doMoveSurf = false;
            f_doMoveOverheat = false;
            f_doMoveExpose = false;
            f_doMoveTrumpCard = false;
            f_doMovePetrify = false;
            f_doMoveFlatter = false;
            f_doMoveStayAway = false;
            f_doMoveMagnitude = false;
            f_doMoveTwister = false;
            f_doMoveHurl = false;
            f_doMoveDragonRage = false;
            f_doMoveNaturePower = false;
            f_doMoveHpGauge = false;
            f_doMoveIronTail = false;
            f_doMoveReversal = false;
            f_doMoveSolarBeam = false;
            f_doMoveSacredFire = false;
            f_doMoveFly = false;
            f_doMoveMistBall = false;
            f_doMoveCosmicPower = false;
            f_doMoveBeatUp = false;
            f_doMoveWaterSpout = false;
            f_doMoveWillOWisp = false;
            f_doMoveDestinyBond = false;
            f_doMoveSiesta = false;
            f_doMoveFamish = false;
            f_doMovePierce = false;
            f_doMoveJumpKick = false;
            f_doMoveTransform = false;
            f_doMoveDamageParalyze20 = false;
            f_doMovePowerEars = false;
            f_doMoveWrap = false;
            f_doMoveCopycat = false;
            f_doMoveSnore = false;
            f_doMoveSmokescreen = false;
            f_doMoveTickle = false;
            f_doMoveDecoy = false;
            f_doMoveMudSlap = false;
            f_doMoveWeatherBall = false;
            f_doMoveSwitchPositions = false;
            f_doMoveRecycle = false;
            f_doMoveEndure = false;
            f_doMoveMagicCoat = false;
            f_doMoveTriAttack = false;
            f_doMovePresent = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_doMoveMist;
        private int _doMoveMist;

        /// <summary>
        /// Move effect: Mist
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMist
        {
            get
            {
                if (f_doMoveMist)
                    return _doMoveMist;
                _doMoveMist = (int) (9680);
                f_doMoveMist = true;
                return _doMoveMist;
            }
        }
        private bool f_doMoveEscape;
        private int _doMoveEscape;

        /// <summary>
        /// Move effect: Escape (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEscape
        {
            get
            {
                if (f_doMoveEscape)
                    return _doMoveEscape;
                _doMoveEscape = (int) (27756);
                f_doMoveEscape = true;
                return _doMoveEscape;
            }
        }
        private bool f_doMovePowerTrick;
        private int _doMovePowerTrick;

        /// <summary>
        /// Move effect: Power Trick
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePowerTrick
        {
            get
            {
                if (f_doMovePowerTrick)
                    return _doMovePowerTrick;
                _doMovePowerTrick = (int) (33432);
                f_doMovePowerTrick = true;
                return _doMovePowerTrick;
            }
        }
        private bool f_doMoveTripleKick;
        private int _doMoveTripleKick;

        /// <summary>
        /// Move effect: Triple Kick
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTripleKick
        {
            get
            {
                if (f_doMoveTripleKick)
                    return _doMoveTripleKick;
                _doMoveTripleKick = (int) (16796);
                f_doMoveTripleKick = true;
                return _doMoveTripleKick;
            }
        }
        private bool f_doMoveHeadSmash;
        private int _doMoveHeadSmash;

        /// <summary>
        /// Move effect: Head Smash
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHeadSmash
        {
            get
            {
                if (f_doMoveHeadSmash)
                    return _doMoveHeadSmash;
                _doMoveHeadSmash = (int) (34388);
                f_doMoveHeadSmash = true;
                return _doMoveHeadSmash;
            }
        }
        private bool f_doMoveLunarDance;
        private int _doMoveLunarDance;

        /// <summary>
        /// Move effect: Lunar Dance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLunarDance
        {
            get
            {
                if (f_doMoveLunarDance)
                    return _doMoveLunarDance;
                _doMoveLunarDance = (int) (34076);
                f_doMoveLunarDance = true;
                return _doMoveLunarDance;
            }
        }
        private bool f_doMoveOneRoom;
        private int _doMoveOneRoom;

        /// <summary>
        /// Move effect: One-Room (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveOneRoom
        {
            get
            {
                if (f_doMoveOneRoom)
                    return _doMoveOneRoom;
                _doMoveOneRoom = (int) (29040);
                f_doMoveOneRoom = true;
                return _doMoveOneRoom;
            }
        }
        private bool f_doMoveFakeTears;
        private int _doMoveFakeTears;

        /// <summary>
        /// Move effect: Fake Tears
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFakeTears
        {
            get
            {
                if (f_doMoveFakeTears)
                    return _doMoveFakeTears;
                _doMoveFakeTears = (int) (2584);
                f_doMoveFakeTears = true;
                return _doMoveFakeTears;
            }
        }
        private bool f_doMoveLastResort;
        private int _doMoveLastResort;

        /// <summary>
        /// Move effect: Last Resort
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLastResort
        {
            get
            {
                if (f_doMoveLastResort)
                    return _doMoveLastResort;
                _doMoveLastResort = (int) (32400);
                f_doMoveLastResort = true;
                return _doMoveLastResort;
            }
        }
        private bool f_doMoveDefendOrder;
        private int _doMoveDefendOrder;

        /// <summary>
        /// Move effect: Defend Order
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDefendOrder
        {
            get
            {
                if (f_doMoveDefendOrder)
                    return _doMoveDefendOrder;
                _doMoveDefendOrder = (int) (33832);
                f_doMoveDefendOrder = true;
                return _doMoveDefendOrder;
            }
        }
        private bool f_doMoveSleepTalk;
        private int _doMoveSleepTalk;

        /// <summary>
        /// Move effect: Sleep Talk
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSleepTalk
        {
            get
            {
                if (f_doMoveSleepTalk)
                    return _doMoveSleepTalk;
                _doMoveSleepTalk = (int) (17740);
                f_doMoveSleepTalk = true;
                return _doMoveSleepTalk;
            }
        }
        private bool f_doMoveGrowl;
        private int _doMoveGrowl;

        /// <summary>
        /// Move effect: Growl
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGrowl
        {
            get
            {
                if (f_doMoveGrowl)
                    return _doMoveGrowl;
                _doMoveGrowl = (int) (17212);
                f_doMoveGrowl = true;
                return _doMoveGrowl;
            }
        }
        private bool f_doMoveDamageWithRecoil;
        private int _doMoveDamageWithRecoil;

        /// <summary>
        /// Move effect: Deals damage, inflicting recoil damage on the attacker.
        /// Relevant moves: Submission, Take Down, Volt Tackle, Wood Hammer, Brave Bird
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: bool, whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageWithRecoil
        {
            get
            {
                if (f_doMoveDamageWithRecoil)
                    return _doMoveDamageWithRecoil;
                _doMoveDamageWithRecoil = (int) (8560);
                f_doMoveDamageWithRecoil = true;
                return _doMoveDamageWithRecoil;
            }
        }
        private bool f_doMoveSonicBoom;
        private int _doMoveSonicBoom;

        /// <summary>
        /// Move effect: SonicBoom
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSonicBoom
        {
            get
            {
                if (f_doMoveSonicBoom)
                    return _doMoveSonicBoom;
                _doMoveSonicBoom = (int) (12152);
                f_doMoveSonicBoom = true;
                return _doMoveSonicBoom;
            }
        }
        private bool f_doMoveMobile;
        private int _doMoveMobile;

        /// <summary>
        /// Move effect: Mobile (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMobile
        {
            get
            {
                if (f_doMoveMobile)
                    return _doMoveMobile;
                _doMoveMobile = (int) (29668);
                f_doMoveMobile = true;
                return _doMoveMobile;
            }
        }
        private bool f_doMoveDefenseCurl;
        private int _doMoveDefenseCurl;

        /// <summary>
        /// Move effect: Defense Curl
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDefenseCurl
        {
            get
            {
                if (f_doMoveDefenseCurl)
                    return _doMoveDefenseCurl;
                _doMoveDefenseCurl = (int) (23008);
                f_doMoveDefenseCurl = true;
                return _doMoveDefenseCurl;
            }
        }
        private bool f_doMoveRazorWind;
        private int _doMoveRazorWind;

        /// <summary>
        /// Move effect: Razor Wind
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRazorWind
        {
            get
            {
                if (f_doMoveRazorWind)
                    return _doMoveRazorWind;
                _doMoveRazorWind = (int) (4340);
                f_doMoveRazorWind = true;
                return _doMoveRazorWind;
            }
        }
        private bool f_doMoveConfuse;
        private int _doMoveConfuse;

        /// <summary>
        /// Move effect: Confuse target enemies if possible.
        /// Relevant moves: Confuse Ray, Supersonic, Sweet Kiss, Teeter Dance, Totter (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveConfuse
        {
            get
            {
                if (f_doMoveConfuse)
                    return _doMoveConfuse;
                _doMoveConfuse = (int) (13824);
                f_doMoveConfuse = true;
                return _doMoveConfuse;
            }
        }
        private bool f_doMoveTrapBuster;
        private int _doMoveTrapBuster;

        /// <summary>
        /// Move effect: Trap Buster (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTrapBuster
        {
            get
            {
                if (f_doMoveTrapBuster)
                    return _doMoveTrapBuster;
                _doMoveTrapBuster = (int) (27924);
                f_doMoveTrapBuster = true;
                return _doMoveTrapBuster;
            }
        }
        private bool f_doMoveDamageConstrict10;
        private int _doMoveDamageConstrict10;

        /// <summary>
        /// Move effect: Deal damage with a 10% (WHIRLPOOL_CONSTRICT_CHANCE) chance to constrict, and with a damage multiplier dependent on the move used.
        /// Relevant moves: Clamp, Bind, Sand Tomb, Fire Spin, Magma Storm
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageConstrict10
        {
            get
            {
                if (f_doMoveDamageConstrict10)
                    return _doMoveDamageConstrict10;
                _doMoveDamageConstrict10 = (int) (22520);
                f_doMoveDamageConstrict10 = true;
                return _doMoveDamageConstrict10;
            }
        }
        private bool f_doMoveSureShot;
        private int _doMoveSureShot;

        /// <summary>
        /// Move effect: Give the user the Sure-Shot status
        /// Relevant moves: Mind Reader, Lock-On
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSureShot
        {
            get
            {
                if (f_doMoveSureShot)
                    return _doMoveSureShot;
                _doMoveSureShot = (int) (7144);
                f_doMoveSureShot = true;
                return _doMoveSureShot;
            }
        }
        private bool f_doMoveMorningSun;
        private int _doMoveMorningSun;

        /// <summary>
        /// Move effect: Morning Sun
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMorningSun
        {
            get
            {
                if (f_doMoveMorningSun)
                    return _doMoveMorningSun;
                _doMoveMorningSun = (int) (436);
                f_doMoveMorningSun = true;
                return _doMoveMorningSun;
            }
        }
        private bool f_doMoveWish;
        private int _doMoveWish;

        /// <summary>
        /// Move effect: Wish
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWish
        {
            get
            {
                if (f_doMoveWish)
                    return _doMoveWish;
                _doMoveWish = (int) (17616);
                f_doMoveWish = true;
                return _doMoveWish;
            }
        }
        private bool f_doMoveCurse;
        private int _doMoveCurse;

        /// <summary>
        /// Move effect: Curse
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCurse
        {
            get
            {
                if (f_doMoveCurse)
                    return _doMoveCurse;
                _doMoveCurse = (int) (18188);
                f_doMoveCurse = true;
                return _doMoveCurse;
            }
        }
        private bool f_doMoveAssist;
        private int _doMoveAssist;

        /// <summary>
        /// Move effect: Assist
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveAssist
        {
            get
            {
                if (f_doMoveAssist)
                    return _doMoveAssist;
                _doMoveAssist = (int) (17952);
                f_doMoveAssist = true;
                return _doMoveAssist;
            }
        }
        private bool f_doMoveDracoMeteor;
        private int _doMoveDracoMeteor;

        /// <summary>
        /// Move effect: Draco Meteor
        /// 
        /// Note that this move effect handler has an extra parameter that can be used to disable the special attack drop.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// r4: disable special attack drop
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDracoMeteor
        {
            get
            {
                if (f_doMoveDracoMeteor)
                    return _doMoveDracoMeteor;
                _doMoveDracoMeteor = (int) (34860);
                f_doMoveDracoMeteor = true;
                return _doMoveDracoMeteor;
            }
        }
        private bool f_doMoveThunderWave;
        private int _doMoveThunderWave;

        /// <summary>
        /// Move effect: Thunder Wave
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveThunderWave
        {
            get
            {
                if (f_doMoveThunderWave)
                    return _doMoveThunderWave;
                _doMoveThunderWave = (int) (14768);
                f_doMoveThunderWave = true;
                return _doMoveThunderWave;
            }
        }
        private bool f_doMoveSearchlight;
        private int _doMoveSearchlight;

        /// <summary>
        /// Move effect: Searchlight (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSearchlight
        {
            get
            {
                if (f_doMoveSearchlight)
                    return _doMoveSearchlight;
                _doMoveSearchlight = (int) (27688);
                f_doMoveSearchlight = true;
                return _doMoveSearchlight;
            }
        }
        private bool f_doMoveMagnetRise;
        private int _doMoveMagnetRise;

        /// <summary>
        /// Move effect: Magnet Rise
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMagnetRise
        {
            get
            {
                if (f_doMoveMagnetRise)
                    return _doMoveMagnetRise;
                _doMoveMagnetRise = (int) (32288);
                f_doMoveMagnetRise = true;
                return _doMoveMagnetRise;
            }
        }
        private bool f_doMovePayDay;
        private int _doMovePayDay;

        /// <summary>
        /// Move effect: Pay Day
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePayDay
        {
            get
            {
                if (f_doMovePayDay)
                    return _doMovePayDay;
                _doMovePayDay = (int) (17764);
                f_doMovePayDay = true;
                return _doMovePayDay;
            }
        }
        private bool f_doMoveWaterfall;
        private int _doMoveWaterfall;

        /// <summary>
        /// Move effect: Waterfall
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWaterfall
        {
            get
            {
                if (f_doMoveWaterfall)
                    return _doMoveWaterfall;
                _doMoveWaterfall = (int) (12744);
                f_doMoveWaterfall = true;
                return _doMoveWaterfall;
            }
        }
        private bool f_doMoveOneShot;
        private int _doMoveOneShot;

        /// <summary>
        /// Move effect: One-Shot (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveOneShot
        {
            get
            {
                if (f_doMoveOneShot)
                    return _doMoveOneShot;
                _doMoveOneShot = (int) (28576);
                f_doMoveOneShot = true;
                return _doMoveOneShot;
            }
        }
        private bool f_doMoveBoostDefense2;
        private int _doMoveBoostDefense2;

        /// <summary>
        /// Move effect: Boost the defender's defense stat by two stages
        /// Relevant moves: Iron Defense, Acid Armor, Barrier
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBoostDefense2
        {
            get
            {
                if (f_doMoveBoostDefense2)
                    return _doMoveBoostDefense2;
                _doMoveBoostDefense2 = (int) (14604);
                f_doMoveBoostDefense2 = true;
                return _doMoveBoostDefense2;
            }
        }
        private bool f_doMoveWakeUpSlap;
        private int _doMoveWakeUpSlap;

        /// <summary>
        /// Move effect: Wake-Up Slap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWakeUpSlap
        {
            get
            {
                if (f_doMoveWakeUpSlap)
                    return _doMoveWakeUpSlap;
                _doMoveWakeUpSlap = (int) (34228);
                f_doMoveWakeUpSlap = true;
                return _doMoveWakeUpSlap;
            }
        }
        private bool f_doMoveBlazeKick;
        private int _doMoveBlazeKick;

        /// <summary>
        /// Move effect: Blaze Kick
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBlazeKick
        {
            get
            {
                if (f_doMoveBlazeKick)
                    return _doMoveBlazeKick;
                _doMoveBlazeKick = (int) (21496);
                f_doMoveBlazeKick = true;
                return _doMoveBlazeKick;
            }
        }
        private bool f_doMovePoisonFang;
        private int _doMovePoisonFang;

        /// <summary>
        /// Move effect: Poison Fang
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePoisonFang
        {
            get
            {
                if (f_doMovePoisonFang)
                    return _doMovePoisonFang;
                _doMovePoisonFang = (int) (15048);
                f_doMovePoisonFang = true;
                return _doMovePoisonFang;
            }
        }
        private bool f_doMoveSkyAttack;
        private int _doMoveSkyAttack;

        /// <summary>
        /// Move effect: Sky Attack
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSkyAttack
        {
            get
            {
                if (f_doMoveSkyAttack)
                    return _doMoveSkyAttack;
                _doMoveSkyAttack = (int) (7268);
                f_doMoveSkyAttack = true;
                return _doMoveSkyAttack;
            }
        }
        private bool f_doMoveShadowBall;
        private int _doMoveShadowBall;

        /// <summary>
        /// Move effect: Shadow Ball
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveShadowBall
        {
            get
            {
                if (f_doMoveShadowBall)
                    return _doMoveShadowBall;
                _doMoveShadowBall = (int) (9348);
                f_doMoveShadowBall = true;
                return _doMoveShadowBall;
            }
        }
        private bool f_doMoveMemento;
        private int _doMoveMemento;

        /// <summary>
        /// Move effect: Memento
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMemento
        {
            get
            {
                if (f_doMoveMemento)
                    return _doMoveMemento;
                _doMoveMemento = (int) (3144);
                f_doMoveMemento = true;
                return _doMoveMemento;
            }
        }
        private bool f_doMoveNastyPlot;
        private int _doMoveNastyPlot;

        /// <summary>
        /// Move effect: Nasty Plot
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveNastyPlot
        {
            get
            {
                if (f_doMoveNastyPlot)
                    return _doMoveNastyPlot;
                _doMoveNastyPlot = (int) (35012);
                f_doMoveNastyPlot = true;
                return _doMoveNastyPlot;
            }
        }
        private bool f_doMoveEndeavor;
        private int _doMoveEndeavor;

        /// <summary>
        /// Move effect: Endeavor
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEndeavor
        {
            get
            {
                if (f_doMoveEndeavor)
                    return _doMoveEndeavor;
                _doMoveEndeavor = (int) (5064);
                f_doMoveEndeavor = true;
                return _doMoveEndeavor;
            }
        }
        private bool f_doMoveSecretPower;
        private int _doMoveSecretPower;

        /// <summary>
        /// Move effect: Secret Power
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSecretPower
        {
            get
            {
                if (f_doMoveSecretPower)
                    return _doMoveSecretPower;
                _doMoveSecretPower = (int) (20268);
                f_doMoveSecretPower = true;
                return _doMoveSecretPower;
            }
        }
        private bool f_doMovePainSplit;
        private int _doMovePainSplit;

        /// <summary>
        /// Move effect: Pain Split
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePainSplit
        {
            get
            {
                if (f_doMovePainSplit)
                    return _doMovePainSplit;
                _doMovePainSplit = (int) (1372);
                f_doMovePainSplit = true;
                return _doMovePainSplit;
            }
        }
        private bool f_doMoveZapCannon;
        private int _doMoveZapCannon;

        /// <summary>
        /// Move effect: Zap Cannon
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveZapCannon
        {
            get
            {
                if (f_doMoveZapCannon)
                    return _doMoveZapCannon;
                _doMoveZapCannon = (int) (14880);
                f_doMoveZapCannon = true;
                return _doMoveZapCannon;
            }
        }
        private bool f_doMoveDamageParalyze10;
        private int _doMoveDamageParalyze10;

        /// <summary>
        /// Move effect: Deal damage with a 10% chance (LICK_PARALZYE_CHANCE) of paralyzing the defender.
        /// Relevant moves: Lick, Spark, Body Slam, DragonBreath
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageParalyze10
        {
            get
            {
                if (f_doMoveDamageParalyze10)
                    return _doMoveDamageParalyze10;
                _doMoveDamageParalyze10 = (int) (9128);
                f_doMoveDamageParalyze10 = true;
                return _doMoveDamageParalyze10;
            }
        }
        private bool f_doMoveHeartSwap;
        private int _doMoveHeartSwap;

        /// <summary>
        /// Move effect: Heart Swap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHeartSwap
        {
            get
            {
                if (f_doMoveHeartSwap)
                    return _doMoveHeartSwap;
                _doMoveHeartSwap = (int) (33004);
                f_doMoveHeartSwap = true;
                return _doMoveHeartSwap;
            }
        }
        private bool f_doMoveHammerArm;
        private int _doMoveHammerArm;

        /// <summary>
        /// Move effect: Hammer Arm
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHammerArm
        {
            get
            {
                if (f_doMoveHammerArm)
                    return _doMoveHammerArm;
                _doMoveHammerArm = (int) (29732);
                f_doMoveHammerArm = true;
                return _doMoveHammerArm;
            }
        }
        private bool f_doMoveThunderFang;
        private int _doMoveThunderFang;

        /// <summary>
        /// Move effect: Thunder Fang
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveThunderFang
        {
            get
            {
                if (f_doMoveThunderFang)
                    return _doMoveThunderFang;
                _doMoveThunderFang = (int) (30224);
                f_doMoveThunderFang = true;
                return _doMoveThunderFang;
            }
        }
        private bool f_doMoveLightScreen;
        private int _doMoveLightScreen;

        /// <summary>
        /// Move effect: Light Screen
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLightScreen
        {
            get
            {
                if (f_doMoveLightScreen)
                    return _doMoveLightScreen;
                _doMoveLightScreen = (int) (20252);
                f_doMoveLightScreen = true;
                return _doMoveLightScreen;
            }
        }
        private bool f_doMoveDamageLowerSpecialDefense50;
        private int _doMoveDamageLowerSpecialDefense50;

        /// <summary>
        /// Move effect: Deal damage with a 50% (LUSTER_PURGE_LOWER_SPECIAL_DEFENSE_CHANCE) chance to lower special defense.
        /// Relevant moves: Luster Purge, Energy Ball, Focus Blast
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageLowerSpecialDefense50
        {
            get
            {
                if (f_doMoveDamageLowerSpecialDefense50)
                    return _doMoveDamageLowerSpecialDefense50;
                _doMoveDamageLowerSpecialDefense50 = (int) (25332);
                f_doMoveDamageLowerSpecialDefense50 = true;
                return _doMoveDamageLowerSpecialDefense50;
            }
        }
        private bool f_doMoveDoubleEdge;
        private int _doMoveDoubleEdge;

        /// <summary>
        /// Move effect: Double-Edge
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDoubleEdge
        {
            get
            {
                if (f_doMoveDoubleEdge)
                    return _doMoveDoubleEdge;
                _doMoveDoubleEdge = (int) (11108);
                f_doMoveDoubleEdge = true;
                return _doMoveDoubleEdge;
            }
        }
        private bool f_doMoveFireFang;
        private int _doMoveFireFang;

        /// <summary>
        /// Move effect: Fire Fang
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFireFang
        {
            get
            {
                if (f_doMoveFireFang)
                    return _doMoveFireFang;
                _doMoveFireFang = (int) (33900);
                f_doMoveFireFang = true;
                return _doMoveFireFang;
            }
        }
        private bool f_doMoveTag0x1Ab;
        private int _doMoveTag0x1Ab;

        /// <summary>
        /// Move effect: MOVE_TAG_0x1AB
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTag0x1Ab
        {
            get
            {
                if (f_doMoveTag0x1Ab)
                    return _doMoveTag0x1Ab;
                _doMoveTag0x1Ab = (int) (35044);
                f_doMoveTag0x1Ab = true;
                return _doMoveTag0x1Ab;
            }
        }
        private bool f_doMoveAuroraBeam;
        private int _doMoveAuroraBeam;

        /// <summary>
        /// Move effect: Aurora Beam
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveAuroraBeam
        {
            get
            {
                if (f_doMoveAuroraBeam)
                    return _doMoveAuroraBeam;
                _doMoveAuroraBeam = (int) (3020);
                f_doMoveAuroraBeam = true;
                return _doMoveAuroraBeam;
            }
        }
        private bool f_doMoveInvisify;
        private int _doMoveInvisify;

        /// <summary>
        /// Move effect: Invisify (item effect)
        /// 
        /// This function sets r1 = r0 before calling TryInvisify, so the effect will always be applied to the user regardless of the move settings.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveInvisify
        {
            get
            {
                if (f_doMoveInvisify)
                    return _doMoveInvisify;
                _doMoveInvisify = (int) (28556);
                f_doMoveInvisify = true;
                return _doMoveInvisify;
            }
        }
        private bool f_doMoveBulkUp;
        private int _doMoveBulkUp;

        /// <summary>
        /// Move effect: Bulk Up
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBulkUp
        {
            get
            {
                if (f_doMoveBulkUp)
                    return _doMoveBulkUp;
                _doMoveBulkUp = (int) (20848);
                f_doMoveBulkUp = true;
                return _doMoveBulkUp;
            }
        }
        private bool f_doMoveMeteorMash;
        private int _doMoveMeteorMash;

        /// <summary>
        /// Move effect: Meteor Mash
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMeteorMash
        {
            get
            {
                if (f_doMoveMeteorMash)
                    return _doMoveMeteorMash;
                _doMoveMeteorMash = (int) (7576);
                f_doMoveMeteorMash = true;
                return _doMoveMeteorMash;
            }
        }
        private bool f_doMoveTag0x1A6;
        private int _doMoveTag0x1A6;

        /// <summary>
        /// Move effect: MOVE_TAG_0x1A6
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTag0x1A6
        {
            get
            {
                if (f_doMoveTag0x1A6)
                    return _doMoveTag0x1A6;
                _doMoveTag0x1A6 = (int) (35072);
                f_doMoveTag0x1A6 = true;
                return _doMoveTag0x1A6;
            }
        }
        private bool f_doMoveTag0x1A7;
        private int _doMoveTag0x1A7;

        /// <summary>
        /// Move effect: MOVE_TAG_0x1A7
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTag0x1A7
        {
            get
            {
                if (f_doMoveTag0x1A7)
                    return _doMoveTag0x1A7;
                _doMoveTag0x1A7 = (int) (35140);
                f_doMoveTag0x1A7 = true;
                return _doMoveTag0x1A7;
            }
        }
        private bool f_doMoveDamagePoison18;
        private int _doMoveDamagePoison18;

        /// <summary>
        /// Move effect: Deal damage with an 18% chance (POISON_STING_POISON_CHANCE) to poison the defender.
        /// Relevant moves: Poison Sting, Sludge, Sludge Bomb
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamagePoison18
        {
            get
            {
                if (f_doMoveDamagePoison18)
                    return _doMoveDamagePoison18;
                _doMoveDamagePoison18 = (int) (15156);
                f_doMoveDamagePoison18 = true;
                return _doMoveDamagePoison18;
            }
        }
        private bool f_doMoveGastroAcid;
        private int _doMoveGastroAcid;

        /// <summary>
        /// Move effect: Gastro Acid
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGastroAcid
        {
            get
            {
                if (f_doMoveGastroAcid)
                    return _doMoveGastroAcid;
                _doMoveGastroAcid = (int) (29816);
                f_doMoveGastroAcid = true;
                return _doMoveGastroAcid;
            }
        }
        private bool f_doMoveSplash;
        private int _doMoveSplash;

        /// <summary>
        /// Move effect: Splash
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSplash
        {
            get
            {
                if (f_doMoveSplash)
                    return _doMoveSplash;
                _doMoveSplash = (int) (19208);
                f_doMoveSplash = true;
                return _doMoveSplash;
            }
        }
        private bool f_doMoveLowerSpeed1;
        private int _doMoveLowerSpeed1;

        /// <summary>
        /// Move effect: Lower the defender's defense by one stage
        /// Relevant moves: Scary Face, Cotton Spore
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLowerSpeed1
        {
            get
            {
                if (f_doMoveLowerSpeed1)
                    return _doMoveLowerSpeed1;
                _doMoveLowerSpeed1 = (int) (7724);
                f_doMoveLowerSpeed1 = true;
                return _doMoveLowerSpeed1;
            }
        }
        private bool f_doMoveEncore;
        private int _doMoveEncore;

        /// <summary>
        /// Move effect: Encore
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEncore
        {
            get
            {
                if (f_doMoveEncore)
                    return _doMoveEncore;
                _doMoveEncore = (int) (1100);
                f_doMoveEncore = true;
                return _doMoveEncore;
            }
        }
        private bool f_doMoveSetDamage;
        private int _doMoveSetDamage;

        /// <summary>
        /// Move effect: Give the user the Set Damage status
        /// Relevant moves: Doom Desire, Future Sight
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSetDamage
        {
            get
            {
                if (f_doMoveSetDamage)
                    return _doMoveSetDamage;
                _doMoveSetDamage = (int) (20056);
                f_doMoveSetDamage = true;
                return _doMoveSetDamage;
            }
        }
        private bool f_doMoveHiddenPower;
        private int _doMoveHiddenPower;

        /// <summary>
        /// Move effect: Hidden Power
        /// 
        /// This is exactly the same as DoMoveDamage (both are wrappers around DealDamage), except this function always returns true.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHiddenPower
        {
            get
            {
                if (f_doMoveHiddenPower)
                    return _doMoveHiddenPower;
                _doMoveHiddenPower = (int) (23336);
                f_doMoveHiddenPower = true;
                return _doMoveHiddenPower;
            }
        }
        private bool f_doMoveMiracleEye;
        private int _doMoveMiracleEye;

        /// <summary>
        /// Move effect: Miracle Eye
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMiracleEye
        {
            get
            {
                if (f_doMoveMiracleEye)
                    return _doMoveMiracleEye;
                _doMoveMiracleEye = (int) (34180);
                f_doMoveMiracleEye = true;
                return _doMoveMiracleEye;
            }
        }
        private bool f_doMoveMirrorMove;
        private int _doMoveMirrorMove;

        /// <summary>
        /// Move effect: Mirror Move
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMirrorMove
        {
            get
            {
                if (f_doMoveMirrorMove)
                    return _doMoveMirrorMove;
                _doMoveMirrorMove = (int) (2884);
                f_doMoveMirrorMove = true;
                return _doMoveMirrorMove;
            }
        }
        private bool f_doMoveHaze;
        private int _doMoveHaze;

        /// <summary>
        /// Move effect: Haze
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHaze
        {
            get
            {
                if (f_doMoveHaze)
                    return _doMoveHaze;
                _doMoveHaze = (int) (6548);
                f_doMoveHaze = true;
                return _doMoveHaze;
            }
        }
        private bool f_doMovePsywave;
        private int _doMovePsywave;

        /// <summary>
        /// Move effect: Psywave
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePsywave
        {
            get
            {
                if (f_doMovePsywave)
                    return _doMovePsywave;
                _doMovePsywave = (int) (7856);
                f_doMovePsywave = true;
                return _doMovePsywave;
            }
        }
        private bool f_doMoveConversion2;
        private int _doMoveConversion2;

        /// <summary>
        /// Move effect: Conversion 2
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveConversion2
        {
            get
            {
                if (f_doMoveConversion2)
                    return _doMoveConversion2;
                _doMoveConversion2 = (int) (14488);
                f_doMoveConversion2 = true;
                return _doMoveConversion2;
            }
        }
        private bool f_doMoveBoostAttack1;
        private int _doMoveBoostAttack1;

        /// <summary>
        /// Move effect: Boost the user's attack by one stage
        /// Relevant moves: Sharpen, Howl, Meditate
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBoostAttack1
        {
            get
            {
                if (f_doMoveBoostAttack1)
                    return _doMoveBoostAttack1;
                _doMoveBoostAttack1 = (int) (4308);
                f_doMoveBoostAttack1 = true;
                return _doMoveBoostAttack1;
            }
        }
        private bool f_doMoveDoubleTeam;
        private int _doMoveDoubleTeam;

        /// <summary>
        /// Move effect: Double Team
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDoubleTeam
        {
            get
            {
                if (f_doMoveDoubleTeam)
                    return _doMoveDoubleTeam;
                _doMoveDoubleTeam = (int) (4160);
                f_doMoveDoubleTeam = true;
                return _doMoveDoubleTeam;
            }
        }
        private bool f_doMoveSpite;
        private int _doMoveSpite;

        /// <summary>
        /// Move effect: Spite
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSpite
        {
            get
            {
                if (f_doMoveSpite)
                    return _doMoveSpite;
                _doMoveSpite = (int) (2636);
                f_doMoveSpite = true;
                return _doMoveSpite;
            }
        }
        private bool f_doMoveIceFang;
        private int _doMoveIceFang;

        /// <summary>
        /// Move effect: Ice Fang
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveIceFang
        {
            get
            {
                if (f_doMoveIceFang)
                    return _doMoveIceFang;
                _doMoveIceFang = (int) (30744);
                f_doMoveIceFang = true;
                return _doMoveIceFang;
            }
        }
        private bool f_doMoveVitalThrow;
        private int _doMoveVitalThrow;

        /// <summary>
        /// Move effect: Vital Throw
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveVitalThrow
        {
            get
            {
                if (f_doMoveVitalThrow)
                    return _doMoveVitalThrow;
                _doMoveVitalThrow = (int) (500);
                f_doMoveVitalThrow = true;
                return _doMoveVitalThrow;
            }
        }
        private bool f_doMoveLongToss;
        private int _doMoveLongToss;

        /// <summary>
        /// Move effect: Long Toss (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLongToss
        {
            get
            {
                if (f_doMoveLongToss)
                    return _doMoveLongToss;
                _doMoveLongToss = (int) (29700);
                f_doMoveLongToss = true;
                return _doMoveLongToss;
            }
        }
        private bool f_doMoveSunnyDay;
        private int _doMoveSunnyDay;

        /// <summary>
        /// Move effect: Sunny Day
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSunnyDay
        {
            get
            {
                if (f_doMoveSunnyDay)
                    return _doMoveSunnyDay;
                _doMoveSunnyDay = (int) (17476);
                f_doMoveSunnyDay = true;
                return _doMoveSunnyDay;
            }
        }
        private bool f_doMoveFillIn;
        private int _doMoveFillIn;

        /// <summary>
        /// Move effect: Fill-In (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFillIn
        {
            get
            {
                if (f_doMoveFillIn)
                    return _doMoveFillIn;
                _doMoveFillIn = (int) (29056);
                f_doMoveFillIn = true;
                return _doMoveFillIn;
            }
        }
        private bool f_doMoveSpikes;
        private int _doMoveSpikes;

        /// <summary>
        /// Move effect: Spikes
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSpikes
        {
            get
            {
                if (f_doMoveSpikes)
                    return _doMoveSpikes;
                _doMoveSpikes = (int) (22744);
                f_doMoveSpikes = true;
                return _doMoveSpikes;
            }
        }
        private bool f_doMoveExplosion;
        private int _doMoveExplosion;

        /// <summary>
        /// Move effect: Explosion
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveExplosion
        {
            get
            {
                if (f_doMoveExplosion)
                    return _doMoveExplosion;
                _doMoveExplosion = (int) (12456);
                f_doMoveExplosion = true;
                return _doMoveExplosion;
            }
        }
        private bool f_doMoveReturn;
        private int _doMoveReturn;

        /// <summary>
        /// Move effect: Return
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveReturn
        {
            get
            {
                if (f_doMoveReturn)
                    return _doMoveReturn;
                _doMoveReturn = (int) (3580);
                f_doMoveReturn = true;
                return _doMoveReturn;
            }
        }
        private bool f_doMoveShadowForce;
        private int _doMoveShadowForce;

        /// <summary>
        /// Move effect: Shadow Force
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveShadowForce
        {
            get
            {
                if (f_doMoveShadowForce)
                    return _doMoveShadowForce;
                _doMoveShadowForce = (int) (31320);
                f_doMoveShadowForce = true;
                return _doMoveShadowForce;
            }
        }
        private bool f_doMoveDefog;
        private int _doMoveDefog;

        /// <summary>
        /// Move effect: Defog
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDefog
        {
            get
            {
                if (f_doMoveDefog)
                    return _doMoveDefog;
                _doMoveDefog = (int) (30372);
                f_doMoveDefog = true;
                return _doMoveDefog;
            }
        }
        private bool f_doMoveMetalBurst;
        private int _doMoveMetalBurst;

        /// <summary>
        /// Move effect: Metal Burst
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMetalBurst
        {
            get
            {
                if (f_doMoveMetalBurst)
                    return _doMoveMetalBurst;
                _doMoveMetalBurst = (int) (34368);
                f_doMoveMetalBurst = true;
                return _doMoveMetalBurst;
            }
        }
        private bool f_doMoveHealStatus;
        private int _doMoveHealStatus;

        /// <summary>
        /// Move effect: Heal the team's status conditions
        /// Relevant moves: Aromatherapy, Heal Bell, Refresh
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHealStatus
        {
            get
            {
                if (f_doMoveHealStatus)
                    return _doMoveHealStatus;
                _doMoveHealStatus = (int) (968);
                f_doMoveHealStatus = true;
                return _doMoveHealStatus;
            }
        }
        private bool f_doMoveWorrySeed;
        private int _doMoveWorrySeed;

        /// <summary>
        /// Move effect: Worry Seed
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWorrySeed
        {
            get
            {
                if (f_doMoveWorrySeed)
                    return _doMoveWorrySeed;
                _doMoveWorrySeed = (int) (32616);
                f_doMoveWorrySeed = true;
                return _doMoveWorrySeed;
            }
        }
        private bool f_doMoveHeadbutt;
        private int _doMoveHeadbutt;

        /// <summary>
        /// Move effect: Headbutt
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHeadbutt
        {
            get
            {
                if (f_doMoveHeadbutt)
                    return _doMoveHeadbutt;
                _doMoveHeadbutt = (int) (11000);
                f_doMoveHeadbutt = true;
                return _doMoveHeadbutt;
            }
        }
        private bool f_doMoveDamageLowerSpeed20;
        private int _doMoveDamageLowerSpeed20;

        /// <summary>
        /// Move effect: Deal damage with a 20% chance (CONSTRICT_LOWER_SPEED_CHANCE) of lowering the defender's speed.
        /// Relevant moves: Constrict, Bubblebeam
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageLowerSpeed20
        {
            get
            {
                if (f_doMoveDamageLowerSpeed20)
                    return _doMoveDamageLowerSpeed20;
                _doMoveDamageLowerSpeed20 = (int) (5320);
                f_doMoveDamageLowerSpeed20 = true;
                return _doMoveDamageLowerSpeed20;
            }
        }
        private bool f_doMoveRainDance;
        private int _doMoveRainDance;

        /// <summary>
        /// Move effect: Rain Dance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRainDance
        {
            get
            {
                if (f_doMoveRainDance)
                    return _doMoveRainDance;
                _doMoveRainDance = (int) (784);
                f_doMoveRainDance = true;
                return _doMoveRainDance;
            }
        }
        private bool f_doMoveDamageLowerAccuracy40;
        private int _doMoveDamageLowerAccuracy40;

        /// <summary>
        /// Move effect: Deal damage with a 40% chance (MUDDY_WATER_LOWER_ACCURACY_CHANCE) of lowering the defender's accuracy.
        /// Relevant moves: Muddy Water, Mud Bomb, Mirror Shot
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageLowerAccuracy40
        {
            get
            {
                if (f_doMoveDamageLowerAccuracy40)
                    return _doMoveDamageLowerAccuracy40;
                _doMoveDamageLowerAccuracy40 = (int) (12852);
                f_doMoveDamageLowerAccuracy40 = true;
                return _doMoveDamageLowerAccuracy40;
            }
        }
        private bool f_doMoveRecoverHp;
        private int _doMoveRecoverHp;

        /// <summary>
        /// Move effect: Recover 50% of the user's max HP
        /// Relevant moves: Recover, Slack Off
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRecoverHp
        {
            get
            {
                if (f_doMoveRecoverHp)
                    return _doMoveRecoverHp;
                _doMoveRecoverHp = (int) (8812);
                f_doMoveRecoverHp = true;
                return _doMoveRecoverHp;
            }
        }
        private bool f_doMoveFeint;
        private int _doMoveFeint;

        /// <summary>
        /// Move effect: Feint
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFeint
        {
            get
            {
                if (f_doMoveFeint)
                    return _doMoveFeint;
                _doMoveFeint = (int) (33452);
                f_doMoveFeint = true;
                return _doMoveFeint;
            }
        }
        private bool f_doMoveBellyDrum;
        private int _doMoveBellyDrum;

        /// <summary>
        /// Move effect: Belly Drum
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBellyDrum
        {
            get
            {
                if (f_doMoveBellyDrum)
                    return _doMoveBellyDrum;
                _doMoveBellyDrum = (int) (20072);
                f_doMoveBellyDrum = true;
                return _doMoveBellyDrum;
            }
        }
        private bool f_doMoveSnatch;
        private int _doMoveSnatch;

        /// <summary>
        /// Move effect: Snatch
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSnatch
        {
            get
            {
                if (f_doMoveSnatch)
                    return _doMoveSnatch;
                _doMoveSnatch = (int) (24628);
                f_doMoveSnatch = true;
                return _doMoveSnatch;
            }
        }
        private bool f_doMoveStockpile;
        private int _doMoveStockpile;

        /// <summary>
        /// Move effect: Stockpile
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveStockpile
        {
            get
            {
                if (f_doMoveStockpile)
                    return _doMoveStockpile;
                _doMoveStockpile = (int) (12968);
                f_doMoveStockpile = true;
                return _doMoveStockpile;
            }
        }
        private bool f_getNaturePowerVariant;
        private int _getNaturePowerVariant;

        /// <summary>
        /// Gets the nature power variant for the current dungeon, based on the tileset ID.
        /// 
        /// return: nature power variant
        /// </summary>
        public int GetNaturePowerVariant
        {
            get
            {
                if (f_getNaturePowerVariant)
                    return _getNaturePowerVariant;
                _getNaturePowerVariant = (int) (8976);
                f_getNaturePowerVariant = true;
                return _getNaturePowerVariant;
            }
        }
        private bool f_doMoveThunderbolt;
        private int _doMoveThunderbolt;

        /// <summary>
        /// Move effect: Thunderbolt
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveThunderbolt
        {
            get
            {
                if (f_doMoveThunderbolt)
                    return _doMoveThunderbolt;
                _doMoveThunderbolt = (int) (9572);
                f_doMoveThunderbolt = true;
                return _doMoveThunderbolt;
            }
        }
        private bool f_doMoveFissure;
        private int _doMoveFissure;

        /// <summary>
        /// Move effect: Fissure
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFissure
        {
            get
            {
                if (f_doMoveFissure)
                    return _doMoveFissure;
                _doMoveFissure = (int) (9696);
                f_doMoveFissure = true;
                return _doMoveFissure;
            }
        }
        private bool f_doMoveHiJumpKick;
        private int _doMoveHiJumpKick;

        /// <summary>
        /// Move effect: Hi Jump Kick
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHiJumpKick
        {
            get
            {
                if (f_doMoveHiJumpKick)
                    return _doMoveHiJumpKick;
                _doMoveHiJumpKick = (int) (15768);
                f_doMoveHiJumpKick = true;
                return _doMoveHiJumpKick;
            }
        }
        private bool f_doMoveYawn;
        private int _doMoveYawn;

        /// <summary>
        /// Move effect: Yawn
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveYawn
        {
            get
            {
                if (f_doMoveYawn)
                    return _doMoveYawn;
                _doMoveYawn = (int) (260);
                f_doMoveYawn = true;
                return _doMoveYawn;
            }
        }
        private bool f_doMoveGyroBall;
        private int _doMoveGyroBall;

        /// <summary>
        /// Move effect: Gyro Ball
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGyroBall
        {
            get
            {
                if (f_doMoveGyroBall)
                    return _doMoveGyroBall;
                _doMoveGyroBall = (int) (31216);
                f_doMoveGyroBall = true;
                return _doMoveGyroBall;
            }
        }
        private bool f_doMoveSmellingSalt;
        private int _doMoveSmellingSalt;

        /// <summary>
        /// Move effect: SmellingSalt
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSmellingSalt
        {
            get
            {
                if (f_doMoveSmellingSalt)
                    return _doMoveSmellingSalt;
                _doMoveSmellingSalt = (int) (6280);
                f_doMoveSmellingSalt = true;
                return _doMoveSmellingSalt;
            }
        }
        private bool f_doMoveDamageLowerSpeed100;
        private int _doMoveDamageLowerSpeed100;

        /// <summary>
        /// Move effect: Deal damage and lower the defender's speed.
        /// Relevant moves: Rock Tomb, Icy Wind, Mud Shot
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageLowerSpeed100
        {
            get
            {
                if (f_doMoveDamageLowerSpeed100)
                    return _doMoveDamageLowerSpeed100;
                _doMoveDamageLowerSpeed100 = (int) (5540);
                f_doMoveDamageLowerSpeed100 = true;
                return _doMoveDamageLowerSpeed100;
            }
        }
        private bool f_doMoveTaunt;
        private int _doMoveTaunt;

        /// <summary>
        /// Move effect: Taunt
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTaunt
        {
            get
            {
                if (f_doMoveTaunt)
                    return _doMoveTaunt;
                _doMoveTaunt = (int) (13848);
                f_doMoveTaunt = true;
                return _doMoveTaunt;
            }
        }
        private bool f_doMovePsychoShift;
        private int _doMovePsychoShift;

        /// <summary>
        /// Move effect: Psycho Shift
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePsychoShift
        {
            get
            {
                if (f_doMovePsychoShift)
                    return _doMovePsychoShift;
                _doMovePsychoShift = (int) (30888);
                f_doMovePsychoShift = true;
                return _doMovePsychoShift;
            }
        }
        private bool f_doMovePoison;
        private int _doMovePoison;

        /// <summary>
        /// Move effect: Poison the defender if possible
        /// Relevant moves: Poison Gas, PoisonPowder
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePoison
        {
            get
            {
                if (f_doMovePoison)
                    return _doMovePoison;
                _doMovePoison = (int) (15000);
                f_doMovePoison = true;
                return _doMovePoison;
            }
        }
        private bool f_doMoveEruption;
        private int _doMoveEruption;

        /// <summary>
        /// Move effect: Eruption
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEruption
        {
            get
            {
                if (f_doMoveEruption)
                    return _doMoveEruption;
                _doMoveEruption = (int) (21884);
                f_doMoveEruption = true;
                return _doMoveEruption;
            }
        }
        private bool f_doMoveDamageBoostAllStats;
        private int _doMoveDamageBoostAllStats;

        /// <summary>
        /// Move effect: Deal damage, with a 20% (SILVER_WIND_BOOST_CHANCE) to boost the user's attack, special attack, defense, special defense, and speed.
        /// Relevant moves: Silver Wind, AncientPower, Ominous Wind
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageBoostAllStats
        {
            get
            {
                if (f_doMoveDamageBoostAllStats)
                    return _doMoveDamageBoostAllStats;
                _doMoveDamageBoostAllStats = (int) (6720);
                f_doMoveDamageBoostAllStats = true;
                return _doMoveDamageBoostAllStats;
            }
        }
        private bool f_doMoveSelfdestruct;
        private int _doMoveSelfdestruct;

        /// <summary>
        /// Move effect: Selfdestruct
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSelfdestruct
        {
            get
            {
                if (f_doMoveSelfdestruct)
                    return _doMoveSelfdestruct;
                _doMoveSelfdestruct = (int) (9236);
                f_doMoveSelfdestruct = true;
                return _doMoveSelfdestruct;
            }
        }
        private bool f_doMoveCounter;
        private int _doMoveCounter;

        /// <summary>
        /// Move effect: Give the user the Counter status
        /// Relevant moves: Pursuit, Counter, Payback
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCounter
        {
            get
            {
                if (f_doMoveCounter)
                    return _doMoveCounter;
                _doMoveCounter = (int) (3824);
                f_doMoveCounter = true;
                return _doMoveCounter;
            }
        }
        private bool f_doMoveHail;
        private int _doMoveHail;

        /// <summary>
        /// Move effect: Hail
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHail
        {
            get
            {
                if (f_doMoveHail)
                    return _doMoveHail;
                _doMoveHail = (int) (876);
                f_doMoveHail = true;
                return _doMoveHail;
            }
        }
        private bool f_doMoveIngrain;
        private int _doMoveIngrain;

        /// <summary>
        /// Move effect: Ingrain
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveIngrain
        {
            get
            {
                if (f_doMoveIngrain)
                    return _doMoveIngrain;
                _doMoveIngrain = (int) (18084);
                f_doMoveIngrain = true;
                return _doMoveIngrain;
            }
        }
        private bool f_doMoveDamageFreeze15;
        private int _doMoveDamageFreeze15;

        /// <summary>
        /// Move effect: Deal damage with a 15% chance (POWDER_SNOW_FREEZE_CHANCE) of freezing the defender.
        /// Relevant moves: Powder Snow, Blizzard, Ice Punch, Ice Beam
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageFreeze15
        {
            get
            {
                if (f_doMoveDamageFreeze15)
                    return _doMoveDamageFreeze15;
                _doMoveDamageFreeze15 = (int) (7472);
                f_doMoveDamageFreeze15 = true;
                return _doMoveDamageFreeze15;
            }
        }
        private bool f_doMoveDive;
        private int _doMoveDive;

        /// <summary>
        /// Move effect: Dive
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDive
        {
            get
            {
                if (f_doMoveDive)
                    return _doMoveDive;
                _doMoveDive = (int) (12544);
                f_doMoveDive = true;
                return _doMoveDive;
            }
        }
        private bool f_doMoveDamageWeightDependent;
        private int _doMoveDamageWeightDependent;

        /// <summary>
        /// Move effect: Deal damage, multiplied by a weight-dependent factor.
        /// Relevant moves: Low Kick, Grass Knot
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageWeightDependent
        {
            get
            {
                if (f_doMoveDamageWeightDependent)
                    return _doMoveDamageWeightDependent;
                _doMoveDamageWeightDependent = (int) (6644);
                f_doMoveDamageWeightDependent = true;
                return _doMoveDamageWeightDependent;
            }
        }
        private bool f_doMoveEmbargo;
        private int _doMoveEmbargo;

        /// <summary>
        /// Move effect: Embargo
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEmbargo
        {
            get
            {
                if (f_doMoveEmbargo)
                    return _doMoveEmbargo;
                _doMoveEmbargo = (int) (30920);
                f_doMoveEmbargo = true;
                return _doMoveEmbargo;
            }
        }
        private bool f_doMoveRolePlay;
        private int _doMoveRolePlay;

        /// <summary>
        /// Move effect: Role Play
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRolePlay
        {
            get
            {
                if (f_doMoveRolePlay)
                    return _doMoveRolePlay;
                _doMoveRolePlay = (int) (17324);
                f_doMoveRolePlay = true;
                return _doMoveRolePlay;
            }
        }
        private bool f_doMoveDamageCringe20;
        private int _doMoveDamageCringe20;

        /// <summary>
        /// Move effect: Deal damage with a 20% chance (BITE_CRINGE_CHANCE) of inflicting the cringe status on the defender.
        /// Relevant moves: Bite, Needle Arm, Stomp, Rolling Kick
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageCringe20
        {
            get
            {
                if (f_doMoveDamageCringe20)
                    return _doMoveDamageCringe20;
                _doMoveDamageCringe20 = (int) (4848);
                f_doMoveDamageCringe20 = true;
                return _doMoveDamageCringe20;
            }
        }
        private bool f_doMoveThundershock;
        private int _doMoveThundershock;

        /// <summary>
        /// Move effect: Thundershock
        /// 
        /// This is identical to DoMoveDamageParalyze10, except it uses a different data symbol for the paralysis chance (but it's still 10%).
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveThundershock
        {
            get
            {
                if (f_doMoveThundershock)
                    return _doMoveThundershock;
                _doMoveThundershock = (int) (14660);
                f_doMoveThundershock = true;
                return _doMoveThundershock;
            }
        }
        private bool f_doMoveMetalSound;
        private int _doMoveMetalSound;

        /// <summary>
        /// Move effect: Metal Sound
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMetalSound
        {
            get
            {
                if (f_doMoveMetalSound)
                    return _doMoveMetalSound;
                _doMoveMetalSound = (int) (6384);
                f_doMoveMetalSound = true;
                return _doMoveMetalSound;
            }
        }
        private bool f_doMoveDreamEater;
        private int _doMoveDreamEater;

        /// <summary>
        /// Move effect: Dream Eater
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDreamEater
        {
            get
            {
                if (f_doMoveDreamEater)
                    return _doMoveDreamEater;
                _doMoveDreamEater = (int) (24268);
                f_doMoveDreamEater = true;
                return _doMoveDreamEater;
            }
        }
        private bool f_doMoveNightmare;
        private int _doMoveNightmare;

        /// <summary>
        /// Move effect: Nightmare
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveNightmare
        {
            get
            {
                if (f_doMoveNightmare)
                    return _doMoveNightmare;
                _doMoveNightmare = (int) (380);
                f_doMoveNightmare = true;
                return _doMoveNightmare;
            }
        }
        private bool f_doMoveBounce;
        private int _doMoveBounce;

        /// <summary>
        /// Move effect: Bounce
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBounce
        {
            get
            {
                if (f_doMoveBounce)
                    return _doMoveBounce;
                _doMoveBounce = (int) (15564);
                f_doMoveBounce = true;
                return _doMoveBounce;
            }
        }
        private bool f_doMovePowerSwap;
        private int _doMovePowerSwap;

        /// <summary>
        /// Move effect: Power Swap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePowerSwap
        {
            get
            {
                if (f_doMovePowerSwap)
                    return _doMovePowerSwap;
                _doMovePowerSwap = (int) (33336);
                f_doMovePowerSwap = true;
                return _doMovePowerSwap;
            }
        }
        private bool f_doMoveLeechSeed;
        private int _doMoveLeechSeed;

        /// <summary>
        /// Move effect: Leech Seed
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLeechSeed
        {
            get
            {
                if (f_doMoveLeechSeed)
                    return _doMoveLeechSeed;
                _doMoveLeechSeed = (int) (24124);
                f_doMoveLeechSeed = true;
                return _doMoveLeechSeed;
            }
        }
        private bool f_doMoveSwapItems;
        private int _doMoveSwapItems;

        /// <summary>
        /// Move effect: Swaps the held items of the attacker and defender.
        /// Relevant moves: Trick, Switcheroo
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSwapItems
        {
            get
            {
                if (f_doMoveSwapItems)
                    return _doMoveSwapItems;
                _doMoveSwapItems = (int) (16256);
                f_doMoveSwapItems = true;
                return _doMoveSwapItems;
            }
        }
        private bool f_doMoveAquaRing;
        private int _doMoveAquaRing;

        /// <summary>
        /// Move effect: Aqua Ring
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveAquaRing
        {
            get
            {
                if (f_doMoveAquaRing)
                    return _doMoveAquaRing;
                _doMoveAquaRing = (int) (29800);
                f_doMoveAquaRing = true;
                return _doMoveAquaRing;
            }
        }
        private bool f_doMoveReflect;
        private int _doMoveReflect;

        /// <summary>
        /// Move effect: Reflect
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveReflect
        {
            get
            {
                if (f_doMoveReflect)
                    return _doMoveReflect;
                _doMoveReflect = (int) (24952);
                f_doMoveReflect = true;
                return _doMoveReflect;
            }
        }
        private bool f_doMoveBideUnleash;
        private int _doMoveBideUnleash;

        /// <summary>
        /// Move effect: Unleashes the Bide status
        /// Relevant moves: Bide (unleashing), Revenge (unleashing), Avalanche (unleashing)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBideUnleash
        {
            get
            {
                if (f_doMoveBideUnleash)
                    return _doMoveBideUnleash;
                _doMoveBideUnleash = (int) (4552);
                f_doMoveBideUnleash = true;
                return _doMoveBideUnleash;
            }
        }
        private bool f_doMoveDamageConfuse30;
        private int _doMoveDamageConfuse30;

        /// <summary>
        /// Move effect: Deal damage with a 30% chance (DIZZY_PUNCH_CONFUSE_CHANCE) to confuse the defender.
        /// Relevant moves: Dizzy Punch, Water Pulse
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageConfuse30
        {
            get
            {
                if (f_doMoveDamageConfuse30)
                    return _doMoveDamageConfuse30;
                _doMoveDamageConfuse30 = (int) (20740);
                f_doMoveDamageConfuse30 = true;
                return _doMoveDamageConfuse30;
            }
        }
        private bool f_doMoveSuperFang;
        private int _doMoveSuperFang;

        /// <summary>
        /// Move effect: Super Fang
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSuperFang
        {
            get
            {
                if (f_doMoveSuperFang)
                    return _doMoveSuperFang;
                _doMoveSuperFang = (int) (1188);
                f_doMoveSuperFang = true;
                return _doMoveSuperFang;
            }
        }
        private bool f_doMoveCharm;
        private int _doMoveCharm;

        /// <summary>
        /// Move effect: Charm
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCharm
        {
            get
            {
                if (f_doMoveCharm)
                    return _doMoveCharm;
                _doMoveCharm = (int) (744);
                f_doMoveCharm = true;
                return _doMoveCharm;
            }
        }
        private bool f_doMoveScan;
        private int _doMoveScan;

        /// <summary>
        /// Move effect: Scan (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveScan
        {
            get
            {
                if (f_doMoveScan)
                    return _doMoveScan;
                _doMoveScan = (int) (27176);
                f_doMoveScan = true;
                return _doMoveScan;
            }
        }
        private bool f_doMoveEcho;
        private int _doMoveEcho;

        /// <summary>
        /// Move effect: Echo (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEcho
        {
            get
            {
                if (f_doMoveEcho)
                    return _doMoveEcho;
                _doMoveEcho = (int) (28840);
                f_doMoveEcho = true;
                return _doMoveEcho;
            }
        }
        private bool f_doMoveGrowth;
        private int _doMoveGrowth;

        /// <summary>
        /// Move effect: Growth
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGrowth
        {
            get
            {
                if (f_doMoveGrowth)
                    return _doMoveGrowth;
                _doMoveGrowth = (int) (11540);
                f_doMoveGrowth = true;
                return _doMoveGrowth;
            }
        }
        private bool f_doMovePounce;
        private int _doMovePounce;

        /// <summary>
        /// Move effect: Pounce (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePounce
        {
            get
            {
                if (f_doMovePounce)
                    return _doMovePounce;
                _doMovePounce = (int) (27720);
                f_doMovePounce = true;
                return _doMovePounce;
            }
        }
        private bool f_doMoveDamageStealItem;
        private int _doMoveDamageStealItem;

        /// <summary>
        /// Move effect: Deal damage and steal the defender's item if possible.
        /// Relevant moves: Thief, Covet
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageStealItem
        {
            get
            {
                if (f_doMoveDamageStealItem)
                    return _doMoveDamageStealItem;
                _doMoveDamageStealItem = (int) (17008);
                f_doMoveDamageStealItem = true;
                return _doMoveDamageStealItem;
            }
        }
        private bool f_doMoveTakeaway;
        private int _doMoveTakeaway;

        /// <summary>
        /// Move effect: Takeaway (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTakeaway
        {
            get
            {
                if (f_doMoveTakeaway)
                    return _doMoveTakeaway;
                _doMoveTakeaway = (int) (25872);
                f_doMoveTakeaway = true;
                return _doMoveTakeaway;
            }
        }
        private bool f_doMoveWildCall;
        private int _doMoveWildCall;

        /// <summary>
        /// Move effect: Wild Call (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWildCall
        {
            get
            {
                if (f_doMoveWildCall)
                    return _doMoveWildCall;
                _doMoveWildCall = (int) (28352);
                f_doMoveWildCall = true;
                return _doMoveWildCall;
            }
        }
        private bool f_doMoveDamageBurn10;
        private int _doMoveDamageBurn10;

        /// <summary>
        /// Move effect: Deal damage with a 10% chance (FLAMETHROWER_BURN_CHANCE) of burning the defender.
        /// Relevant moves: Flamethrower, Fire Blast, Heat Wave, Ember, Fire Punch
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageBurn10
        {
            get
            {
                if (f_doMoveDamageBurn10)
                    return _doMoveDamageBurn10;
                _doMoveDamageBurn10 = (int) (3980);
                f_doMoveDamageBurn10 = true;
                return _doMoveDamageBurn10;
            }
        }
        private bool f_doMoveSeeTrap;
        private int _doMoveSeeTrap;

        /// <summary>
        /// Move effect: See-Trap (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSeeTrap
        {
            get
            {
                if (f_doMoveSeeTrap)
                    return _doMoveSeeTrap;
                _doMoveSeeTrap = (int) (25856);
                f_doMoveSeeTrap = true;
                return _doMoveSeeTrap;
            }
        }
        private bool f_doMoveGravity;
        private int _doMoveGravity;

        /// <summary>
        /// Move effect: Gravity
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGravity
        {
            get
            {
                if (f_doMoveGravity)
                    return _doMoveGravity;
                _doMoveGravity = (int) (31476);
                f_doMoveGravity = true;
                return _doMoveGravity;
            }
        }
        private bool f_doMoveDynamicPunch;
        private int _doMoveDynamicPunch;

        /// <summary>
        /// Move effect: DynamicPunch
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDynamicPunch
        {
            get
            {
                if (f_doMoveDynamicPunch)
                    return _doMoveDynamicPunch;
                _doMoveDynamicPunch = (int) (18600);
                f_doMoveDynamicPunch = true;
                return _doMoveDynamicPunch;
            }
        }
        private bool f_doMoveSteelWing;
        private int _doMoveSteelWing;

        /// <summary>
        /// Move effect: Steel Wing
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSteelWing
        {
            get
            {
                if (f_doMoveSteelWing)
                    return _doMoveSteelWing;
                _doMoveSteelWing = (int) (18384);
                f_doMoveSteelWing = true;
                return _doMoveSteelWing;
            }
        }
        private bool f_doMoveWhirlpool;
        private int _doMoveWhirlpool;

        /// <summary>
        /// Move effect: Whirlpool
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWhirlpool
        {
            get
            {
                if (f_doMoveWhirlpool)
                    return _doMoveWhirlpool;
                _doMoveWhirlpool = (int) (2448);
                f_doMoveWhirlpool = true;
                return _doMoveWhirlpool;
            }
        }
        private bool f_doMoveShadowHold;
        private int _doMoveShadowHold;

        /// <summary>
        /// Move effect: Inflict the Shadow Hold status on the defender
        /// Relevant moves: Spider Web, Mean Look
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveShadowHold
        {
            get
            {
                if (f_doMoveShadowHold)
                    return _doMoveShadowHold;
                _doMoveShadowHold = (int) (6528);
                f_doMoveShadowHold = true;
                return _doMoveShadowHold;
            }
        }
        private bool f_doMovePsychoBoost;
        private int _doMovePsychoBoost;

        /// <summary>
        /// Move effect: Psycho Boost
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePsychoBoost
        {
            get
            {
                if (f_doMovePsychoBoost)
                    return _doMovePsychoBoost;
                _doMovePsychoBoost = (int) (8092);
                f_doMovePsychoBoost = true;
                return _doMovePsychoBoost;
            }
        }
        private bool f_doMoveMetronome;
        private int _doMoveMetronome;

        /// <summary>
        /// Move effect: Metronome
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMetronome
        {
            get
            {
                if (f_doMoveMetronome)
                    return _doMoveMetronome;
                _doMoveMetronome = (int) (24172);
                f_doMoveMetronome = true;
                return _doMoveMetronome;
            }
        }
        private bool f_doMoveCalmMind;
        private int _doMoveCalmMind;

        /// <summary>
        /// Move effect: Calm Mind
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCalmMind
        {
            get
            {
                if (f_doMoveCalmMind)
                    return _doMoveCalmMind;
                _doMoveCalmMind = (int) (23268);
                f_doMoveCalmMind = true;
                return _doMoveCalmMind;
            }
        }
        private bool f_doMoveMirrorCoat;
        private int _doMoveMirrorCoat;

        /// <summary>
        /// Move effect: Mirror Coat
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMirrorCoat
        {
            get
            {
                if (f_doMoveMirrorCoat)
                    return _doMoveMirrorCoat;
                _doMoveMirrorCoat = (int) (23252);
                f_doMoveMirrorCoat = true;
                return _doMoveMirrorCoat;
            }
        }
        private bool f_doMoveSport;
        private int _doMoveSport;

        /// <summary>
        /// Move effect: Activate the relevant sport condition (Mud Sport, Water Sport) on the floor
        /// Relevant moves: Mud Sport, Water Sport
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSport
        {
            get
            {
                if (f_doMoveSport)
                    return _doMoveSport;
                _doMoveSport = (int) (16856);
                f_doMoveSport = true;
                return _doMoveSport;
            }
        }
        private bool f_doMoveBrine;
        private int _doMoveBrine;

        /// <summary>
        /// Move effect: Deal damage, with a 2x multiplier if the defender is at or below half HP.
        /// Relevant moves: Brine, Assurance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBrine
        {
            get
            {
                if (f_doMoveBrine)
                    return _doMoveBrine;
                _doMoveBrine = (int) (30944);
                f_doMoveBrine = true;
                return _doMoveBrine;
            }
        }
        private bool f_doMoveOhko;
        private int _doMoveOhko;

        /// <summary>
        /// Move effect: Possibly one-hit KO the defender
        /// Relevant moves: Sheer Cold, Guillotine
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveOhko
        {
            get
            {
                if (f_doMoveOhko)
                    return _doMoveOhko;
                _doMoveOhko = (int) (11708);
                f_doMoveOhko = true;
                return _doMoveOhko;
            }
        }
        private bool f_doMoveEarthquake;
        private int _doMoveEarthquake;

        /// <summary>
        /// Move effect: Earthquake
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEarthquake
        {
            get
            {
                if (f_doMoveEarthquake)
                    return _doMoveEarthquake;
                _doMoveEarthquake = (int) (8880);
                f_doMoveEarthquake = true;
                return _doMoveEarthquake;
            }
        }
        private bool f_doMoveRebound;
        private int _doMoveRebound;

        /// <summary>
        /// Move effect: Rebound (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRebound
        {
            get
            {
                if (f_doMoveRebound)
                    return _doMoveRebound;
                _doMoveRebound = (int) (26396);
                f_doMoveRebound = true;
                return _doMoveRebound;
            }
        }
        private bool f_doMoveTrawl;
        private int _doMoveTrawl;

        /// <summary>
        /// Move effect: Trawl (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTrawl
        {
            get
            {
                if (f_doMoveTrawl)
                    return _doMoveTrawl;
                _doMoveTrawl = (int) (27740);
                f_doMoveTrawl = true;
                return _doMoveTrawl;
            }
        }
        private bool f_doMoveDamageLowerDefensiveStatVariable;
        private int _doMoveDamageLowerDefensiveStatVariable;

        /// <summary>
        /// Move effect: Deal damage with some chance of lowering one of the defender's defensive stats.
        /// Relevant moves: Psychic, Acid, Seed Flare, Earth Power, Bug Buzz, Flash Cannon
        /// 
        /// Note that this move effect handler has a slightly different parameter list than all the others. Which defensive stat is lowered, the chance of lowering, and the number of stages to lower are all specified as arguments by the caller.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: stat index for the defensive stat to lower
        /// stack[0]: number of defensive stat stages to lower
        /// stack[1]: percentage chance of lowering the defensive stat
        /// stack[2]: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageLowerDefensiveStatVariable
        {
            get
            {
                if (f_doMoveDamageLowerDefensiveStatVariable)
                    return _doMoveDamageLowerDefensiveStatVariable;
                _doMoveDamageLowerDefensiveStatVariable = (int) (7956);
                f_doMoveDamageLowerDefensiveStatVariable = true;
                return _doMoveDamageLowerDefensiveStatVariable;
            }
        }
        private bool f_doMoveBrickBreak;
        private int _doMoveBrickBreak;

        /// <summary>
        /// Move effect: Brick Break
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBrickBreak
        {
            get
            {
                if (f_doMoveBrickBreak)
                    return _doMoveBrickBreak;
                _doMoveBrickBreak = (int) (5428);
                f_doMoveBrickBreak = true;
                return _doMoveBrickBreak;
            }
        }
        private bool f_doMoveTwineedle;
        private int _doMoveTwineedle;

        /// <summary>
        /// Move effect: Twineedle
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTwineedle
        {
            get
            {
                if (f_doMoveTwineedle)
                    return _doMoveTwineedle;
                _doMoveTwineedle = (int) (13200);
                f_doMoveTwineedle = true;
                return _doMoveTwineedle;
            }
        }
        private bool f_doMoveSeeStairs;
        private int _doMoveSeeStairs;

        /// <summary>
        /// Move effect: See Stairs (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSeeStairs
        {
            get
            {
                if (f_doMoveSeeStairs)
                    return _doMoveSeeStairs;
                _doMoveSeeStairs = (int) (29684);
                f_doMoveSeeStairs = true;
                return _doMoveSeeStairs;
            }
        }
        private bool f_doMoveHelpingHand;
        private int _doMoveHelpingHand;

        /// <summary>
        /// Move effect: Helping Hand
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHelpingHand
        {
            get
            {
                if (f_doMoveHelpingHand)
                    return _doMoveHelpingHand;
                _doMoveHelpingHand = (int) (14504);
                f_doMoveHelpingHand = true;
                return _doMoveHelpingHand;
            }
        }
        private bool f_doMoveAbsorb;
        private int _doMoveAbsorb;

        /// <summary>
        /// Move effect: Absorb
        /// 
        /// This is essentially identical to DoMoveDamageDrain, except the ordering of the instructions is slightly different enough to introduce subtle variations in functionality.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveAbsorb
        {
            get
            {
                if (f_doMoveAbsorb)
                    return _doMoveAbsorb;
                _doMoveAbsorb = (int) (10100);
                f_doMoveAbsorb = true;
                return _doMoveAbsorb;
            }
        }
        private bool f_doMoveGuardSwap;
        private int _doMoveGuardSwap;

        /// <summary>
        /// Move effect: Guard Swap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGuardSwap
        {
            get
            {
                if (f_doMoveGuardSwap)
                    return _doMoveGuardSwap;
                _doMoveGuardSwap = (int) (30064);
                f_doMoveGuardSwap = true;
                return _doMoveGuardSwap;
            }
        }
        private bool f_doMoveTransfer;
        private int _doMoveTransfer;

        /// <summary>
        /// Move effect: Transfer (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTransfer
        {
            get
            {
                if (f_doMoveTransfer)
                    return _doMoveTransfer;
                _doMoveTransfer = (int) (27208);
                f_doMoveTransfer = true;
                return _doMoveTransfer;
            }
        }
        private bool f_doMoveCamouflage;
        private int _doMoveCamouflage;

        /// <summary>
        /// Move effect: Camouflage
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCamouflage
        {
            get
            {
                if (f_doMoveCamouflage)
                    return _doMoveCamouflage;
                _doMoveCamouflage = (int) (22316);
                f_doMoveCamouflage = true;
                return _doMoveCamouflage;
            }
        }
        private bool f_doMoveSkullBash;
        private int _doMoveSkullBash;

        /// <summary>
        /// Move effect: Skull Bash
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSkullBash
        {
            get
            {
                if (f_doMoveSkullBash)
                    return _doMoveSkullBash;
                _doMoveSkullBash = (int) (25188);
                f_doMoveSkullBash = true;
                return _doMoveSkullBash;
            }
        }
        private bool f_doMoveDamageCringe10;
        private int _doMoveDamageCringe10;

        /// <summary>
        /// Move effect: Deal damage with a 10% chance (EXTRASENSORY_CRINGE_CHANCE) to inflict the cringe status on the defender.
        /// Relevant moves: Extrasensory, Hyper Fang, Bone Club
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageCringe10
        {
            get
            {
                if (f_doMoveDamageCringe10)
                    return _doMoveDamageCringe10;
                _doMoveDamageCringe10 = (int) (9976);
                f_doMoveDamageCringe10 = true;
                return _doMoveDamageCringe10;
            }
        }
        private bool f_doMoveFocusPunch;
        private int _doMoveFocusPunch;

        /// <summary>
        /// Move effect: Focus Punch
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFocusPunch
        {
            get
            {
                if (f_doMoveFocusPunch)
                    return _doMoveFocusPunch;
                _doMoveFocusPunch = (int) (5640);
                f_doMoveFocusPunch = true;
                return _doMoveFocusPunch;
            }
        }
        private bool f_doMoveTrapper;
        private int _doMoveTrapper;

        /// <summary>
        /// Move effect: Trapper (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTrapper
        {
            get
            {
                if (f_doMoveTrapper)
                    return _doMoveTrapper;
                _doMoveTrapper = (int) (29420);
                f_doMoveTrapper = true;
                return _doMoveTrapper;
            }
        }
        private bool f_doMoveDamagePoison40;
        private int _doMoveDamagePoison40;

        /// <summary>
        /// Move effect: Deal damage with a 40% chance (SMOG_POISON_CHANCE) of poisoning the defender.
        /// Relevant moves: Smog, Cross Poison, Gunk Shot, Poison Jab
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamagePoison40
        {
            get
            {
                if (f_doMoveDamagePoison40)
                    return _doMoveDamagePoison40;
                _doMoveDamagePoison40 = (int) (11432);
                f_doMoveDamagePoison40 = true;
                return _doMoveDamagePoison40;
            }
        }
        private bool f_doMoveStringShot;
        private int _doMoveStringShot;

        /// <summary>
        /// Move effect: String Shot
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveStringShot
        {
            get
            {
                if (f_doMoveStringShot)
                    return _doMoveStringShot;
                _doMoveStringShot = (int) (1936);
                f_doMoveStringShot = true;
                return _doMoveStringShot;
            }
        }
        private bool f_doMovePause;
        private int _doMovePause;

        /// <summary>
        /// Move effect: Inflicts the Paused status on the defender
        /// Relevant moves: Imprison, Observer (item effect), MOVE_TAG_0x1AD
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePause
        {
            get
            {
                if (f_doMovePause)
                    return _doMovePause;
                _doMovePause = (int) (20916);
                f_doMovePause = true;
                return _doMovePause;
            }
        }
        private bool f_doMoveDamageDrain;
        private int _doMoveDamageDrain;

        /// <summary>
        /// Move effect: Deal draining damage, healing the attacker by a proportion of the damage dealt.
        /// Relevant moves: Giga Drain, Leech Life, Mega Drain, Drain Punch
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageDrain
        {
            get
            {
                if (f_doMoveDamageDrain)
                    return _doMoveDamageDrain;
                _doMoveDamageDrain = (int) (5780);
                f_doMoveDamageDrain = true;
                return _doMoveDamageDrain;
            }
        }
        private bool f_doMoveLuckyChant;
        private int _doMoveLuckyChant;

        /// <summary>
        /// Move effect: Lucky Chant
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLuckyChant
        {
            get
            {
                if (f_doMoveLuckyChant)
                    return _doMoveLuckyChant;
                _doMoveLuckyChant = (int) (30048);
                f_doMoveLuckyChant = true;
                return _doMoveLuckyChant;
            }
        }
        private bool f_doMoveNightShade;
        private int _doMoveNightShade;

        /// <summary>
        /// Move effect: Night Shade
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveNightShade
        {
            get
            {
                if (f_doMoveNightShade)
                    return _doMoveNightShade;
                _doMoveNightShade = (int) (17052);
                f_doMoveNightShade = true;
                return _doMoveNightShade;
            }
        }
        private bool f_doMoveCrushClaw;
        private int _doMoveCrushClaw;

        /// <summary>
        /// Move effect: Crush Claw
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCrushClaw
        {
            get
            {
                if (f_doMoveCrushClaw)
                    return _doMoveCrushClaw;
                _doMoveCrushClaw = (int) (21368);
                f_doMoveCrushClaw = true;
                return _doMoveCrushClaw;
            }
        }
        private bool f_doMoveDamageHpDependent;
        private int _doMoveDamageHpDependent;

        /// <summary>
        /// Move effect: Deal damage, with a multiplier dependent on the defender's current HP.
        /// Relevant moves: Wring Out, Crush Grip
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageHpDependent
        {
            get
            {
                if (f_doMoveDamageHpDependent)
                    return _doMoveDamageHpDependent;
                _doMoveDamageHpDependent = (int) (32824);
                f_doMoveDamageHpDependent = true;
                return _doMoveDamageHpDependent;
            }
        }
        private bool f_doMoveSandstorm;
        private int _doMoveSandstorm;

        /// <summary>
        /// Move effect: Sandstorm
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSandstorm
        {
            get
            {
                if (f_doMoveSandstorm)
                    return _doMoveSandstorm;
                _doMoveSandstorm = (int) (11308);
                f_doMoveSandstorm = true;
                return _doMoveSandstorm;
            }
        }
        private bool f_doMoveSleep;
        private int _doMoveSleep;

        /// <summary>
        /// Move effect: Put target enemies to sleep
        /// Relevant moves: Lovely Kiss, Sing, Spore, Grasswhistle, Hypnosis, Sleep Powder, Dark Void
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSleep
        {
            get
            {
                if (f_doMoveSleep)
                    return _doMoveSleep;
                _doMoveSleep = (int) (320);
                f_doMoveSleep = true;
                return _doMoveSleep;
            }
        }
        private bool f_doMoveFeatherDance;
        private int _doMoveFeatherDance;

        /// <summary>
        /// Move effect: FeatherDance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFeatherDance
        {
            get
            {
                if (f_doMoveFeatherDance)
                    return _doMoveFeatherDance;
                _doMoveFeatherDance = (int) (20996);
                f_doMoveFeatherDance = true;
                return _doMoveFeatherDance;
            }
        }
        private bool f_doMoveRest;
        private int _doMoveRest;

        /// <summary>
        /// Move effect: Rest
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRest
        {
            get
            {
                if (f_doMoveRest)
                    return _doMoveRest;
                _doMoveRest = (int) (17976);
                f_doMoveRest = true;
                return _doMoveRest;
            }
        }
        private bool f_doMoveVacuumCut;
        private int _doMoveVacuumCut;

        /// <summary>
        /// Move effect: Vacuum Cut
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveVacuumCut
        {
            get
            {
                if (f_doMoveVacuumCut)
                    return _doMoveVacuumCut;
                _doMoveVacuumCut = (int) (28748);
                f_doMoveVacuumCut = true;
                return _doMoveVacuumCut;
            }
        }
        private bool f_doMoveSynthesis;
        private int _doMoveSynthesis;

        /// <summary>
        /// Move effect: Synthesis
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSynthesis
        {
            get
            {
                if (f_doMoveSynthesis)
                    return _doMoveSynthesis;
                _doMoveSynthesis = (int) (6948);
                f_doMoveSynthesis = true;
                return _doMoveSynthesis;
            }
        }
        private bool f_doMoveUproar;
        private int _doMoveUproar;

        /// <summary>
        /// Move effect: Uproar
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveUproar
        {
            get
            {
                if (f_doMoveUproar)
                    return _doMoveUproar;
                _doMoveUproar = (int) (8204);
                f_doMoveUproar = true;
                return _doMoveUproar;
            }
        }
        private bool f_doMoveSwordsDance;
        private int _doMoveSwordsDance;

        /// <summary>
        /// Move effect: Swords Dance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSwordsDance
        {
            get
            {
                if (f_doMoveSwordsDance)
                    return _doMoveSwordsDance;
                _doMoveSwordsDance = (int) (14184);
                f_doMoveSwordsDance = true;
                return _doMoveSwordsDance;
            }
        }
        private bool f_doMoveLeafStorm;
        private int _doMoveLeafStorm;

        /// <summary>
        /// Move effect: Leaf Storm
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLeafStorm
        {
            get
            {
                if (f_doMoveLeafStorm)
                    return _doMoveLeafStorm;
                _doMoveLeafStorm = (int) (34772);
                f_doMoveLeafStorm = true;
                return _doMoveLeafStorm;
            }
        }
        private bool f_doMoveReviver;
        private int _doMoveReviver;

        /// <summary>
        /// Move effect: Reviver (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveReviver
        {
            get
            {
                if (f_doMoveReviver)
                    return _doMoveReviver;
                _doMoveReviver = (int) (28792);
                f_doMoveReviver = true;
                return _doMoveReviver;
            }
        }
        private bool f_doMoveDamageConfuse10;
        private int _doMoveDamageConfuse10;

        /// <summary>
        /// Move effect: Deal damage with a 10% chance (PSYBEAM_CONFUSE_CHANCE) of confusing the defender.
        /// Relevant moves: Psybeam, Signal Beam, Confusion, Chatter, Rock Climb
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageConfuse10
        {
            get
            {
                if (f_doMoveDamageConfuse10)
                    return _doMoveDamageConfuse10;
                _doMoveDamageConfuse10 = (int) (7748);
                f_doMoveDamageConfuse10 = true;
                return _doMoveDamageConfuse10;
            }
        }
        private bool f_doMoveRapidSpin;
        private int _doMoveRapidSpin;

        /// <summary>
        /// Move effect: Rapid Spin
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRapidSpin
        {
            get
            {
                if (f_doMoveRapidSpin)
                    return _doMoveRapidSpin;
                _doMoveRapidSpin = (int) (7036);
                f_doMoveRapidSpin = true;
                return _doMoveRapidSpin;
            }
        }
        private bool f_doMoveAttract;
        private int _doMoveAttract;

        /// <summary>
        /// Move effect: Attract
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveAttract
        {
            get
            {
                if (f_doMoveAttract)
                    return _doMoveAttract;
                _doMoveAttract = (int) (23504);
                f_doMoveAttract = true;
                return _doMoveAttract;
            }
        }
        private bool f_doMoveCloseCombat;
        private int _doMoveCloseCombat;

        /// <summary>
        /// Move effect: Close Combat
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCloseCombat
        {
            get
            {
                if (f_doMoveCloseCombat)
                    return _doMoveCloseCombat;
                _doMoveCloseCombat = (int) (29920);
                f_doMoveCloseCombat = true;
                return _doMoveCloseCombat;
            }
        }
        private bool f_doMoveAcupressure;
        private int _doMoveAcupressure;

        /// <summary>
        /// Move effect: Acupressure
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveAcupressure
        {
            get
            {
                if (f_doMoveAcupressure)
                    return _doMoveAcupressure;
                _doMoveAcupressure = (int) (31904);
                f_doMoveAcupressure = true;
                return _doMoveAcupressure;
            }
        }
        private bool f_doMoveTailGlow;
        private int _doMoveTailGlow;

        /// <summary>
        /// Move effect: Tail Glow
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTailGlow
        {
            get
            {
                if (f_doMoveTailGlow)
                    return _doMoveTailGlow;
                _doMoveTailGlow = (int) (22488);
                f_doMoveTailGlow = true;
                return _doMoveTailGlow;
            }
        }
        private bool f_doMoveLowerAccuracy1;
        private int _doMoveLowerAccuracy1;

        /// <summary>
        /// Move effect: Lower the defender's accuracy by one stage
        /// Relevant moves: Sand-Attack, Kinesis, Flash
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLowerAccuracy1
        {
            get
            {
                if (f_doMoveLowerAccuracy1)
                    return _doMoveLowerAccuracy1;
                _doMoveLowerAccuracy1 = (int) (11400);
                f_doMoveLowerAccuracy1 = true;
                return _doMoveLowerAccuracy1;
            }
        }
        private bool f_doMoveRecoverHpTeam;
        private int _doMoveRecoverHpTeam;

        /// <summary>
        /// Move effect: Recover 25% HP for all team members
        /// Relevant moves: Softboiled, Milk Drink
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRecoverHpTeam
        {
            get
            {
                if (f_doMoveRecoverHpTeam)
                    return _doMoveRecoverHpTeam;
                _doMoveRecoverHpTeam = (int) (13352);
                f_doMoveRecoverHpTeam = true;
                return _doMoveRecoverHpTeam;
            }
        }
        private bool f_doMoveHealingWish;
        private int _doMoveHealingWish;

        /// <summary>
        /// Move effect: Healing Wish
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHealingWish
        {
            get
            {
                if (f_doMoveHealingWish)
                    return _doMoveHealingWish;
                _doMoveHealingWish = (int) (29840);
                f_doMoveHealingWish = true;
                return _doMoveHealingWish;
            }
        }
        private bool f_doMoveDamageMultihitFatigue;
        private int _doMoveDamageMultihitFatigue;

        /// <summary>
        /// Move effect: Deal multihit damage, then confuse the attacker
        /// Relevant moves: Outrage, Petal Dance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageMultihitFatigue
        {
            get
            {
                if (f_doMoveDamageMultihitFatigue)
                    return _doMoveDamageMultihitFatigue;
                _doMoveDamageMultihitFatigue = (int) (6568);
                f_doMoveDamageMultihitFatigue = true;
                return _doMoveDamageMultihitFatigue;
            }
        }
        private bool f_doMoveMoonlight;
        private int _doMoveMoonlight;

        /// <summary>
        /// Move effect: Moonlight
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMoonlight
        {
            get
            {
                if (f_doMoveMoonlight)
                    return _doMoveMoonlight;
                _doMoveMoonlight = (int) (13868);
                f_doMoveMoonlight = true;
                return _doMoveMoonlight;
            }
        }
        private bool f_doMoveWarp;
        private int _doMoveWarp;

        /// <summary>
        /// Move effect: Warp the target to another tile on the floor
        /// Relevant moves: Teleport, Warp (item effect), MOVE_TAG_0x1A8
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWarp
        {
            get
            {
                if (f_doMoveWarp)
                    return _doMoveWarp;
                _doMoveWarp = (int) (14636);
                f_doMoveWarp = true;
                return _doMoveWarp;
            }
        }
        private bool f_doMoveToxic;
        private int _doMoveToxic;

        /// <summary>
        /// Move effect: Toxic
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveToxic
        {
            get
            {
                if (f_doMoveToxic)
                    return _doMoveToxic;
                _doMoveToxic = (int) (15024);
                f_doMoveToxic = true;
                return _doMoveToxic;
            }
        }
        private bool f_doMoveKnockOff;
        private int _doMoveKnockOff;

        /// <summary>
        /// Move effect: Knock Off
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveKnockOff
        {
            get
            {
                if (f_doMoveKnockOff)
                    return _doMoveKnockOff;
                _doMoveKnockOff = (int) (18700);
                f_doMoveKnockOff = true;
                return _doMoveKnockOff;
            }
        }
        private bool f_doMoveRockSmash;
        private int _doMoveRockSmash;

        /// <summary>
        /// Move effect: Rock Smash
        /// Relevant moves: Rock Smash, MOVE_UNNAMED_0x169
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRockSmash
        {
            get
            {
                if (f_doMoveRockSmash)
                    return _doMoveRockSmash;
                _doMoveRockSmash = (int) (25724);
                f_doMoveRockSmash = true;
                return _doMoveRockSmash;
            }
        }
        private bool f_doMoveShocker;
        private int _doMoveShocker;

        /// <summary>
        /// Move effect: Shocker (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveShocker
        {
            get
            {
                if (f_doMoveShocker)
                    return _doMoveShocker;
                _doMoveShocker = (int) (28816);
                f_doMoveShocker = true;
                return _doMoveShocker;
            }
        }
        private bool f_doMoveCleanse;
        private int _doMoveCleanse;

        /// <summary>
        /// Move effect: Cleanse (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCleanse
        {
            get
            {
                if (f_doMoveCleanse)
                    return _doMoveCleanse;
                _doMoveCleanse = (int) (26480);
                f_doMoveCleanse = true;
                return _doMoveCleanse;
            }
        }
        private bool f_doMoveDamageCringe30;
        private int _doMoveDamageCringe30;

        /// <summary>
        /// Move effect: Deal damage with a 30% chance (ROCK_SLIDE_CRINGE_CHANCE) of inflicting the cringe status on the defender.
        /// Relevant moves: Rock Slide, Astonish, Iron Head, Dark Pulse, Air Slash, Zen Headbutt, Dragon Rush
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageCringe30
        {
            get
            {
                if (f_doMoveDamageCringe30)
                    return _doMoveDamageCringe30;
                _doMoveDamageCringe30 = (int) (2224);
                f_doMoveDamageCringe30 = true;
                return _doMoveDamageCringe30;
            }
        }
        private bool f_doMoveSwallow;
        private int _doMoveSwallow;

        /// <summary>
        /// Move effect: Swallow
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSwallow
        {
            get
            {
                if (f_doMoveSwallow)
                    return _doMoveSwallow;
                _doMoveSwallow = (int) (18100);
                f_doMoveSwallow = true;
                return _doMoveSwallow;
            }
        }
        private bool f_doMoveToxicSpikes;
        private int _doMoveToxicSpikes;

        /// <summary>
        /// Move effect: Toxic Spikes
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveToxicSpikes
        {
            get
            {
                if (f_doMoveToxicSpikes)
                    return _doMoveToxicSpikes;
                _doMoveToxicSpikes = (int) (32304);
                f_doMoveToxicSpikes = true;
                return _doMoveToxicSpikes;
            }
        }
        private bool f_doMoveSafeguard;
        private int _doMoveSafeguard;

        /// <summary>
        /// Move effect: Safeguard
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSafeguard
        {
            get
            {
                if (f_doMoveSafeguard)
                    return _doMoveSafeguard;
                _doMoveSafeguard = (int) (10084);
                f_doMoveSafeguard = true;
                return _doMoveSafeguard;
            }
        }
        private bool f_doMoveTorment;
        private int _doMoveTorment;

        /// <summary>
        /// Move effect: Torment
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTorment
        {
            get
            {
                if (f_doMoveTorment)
                    return _doMoveTorment;
                _doMoveTorment = (int) (1608);
                f_doMoveTorment = true;
                return _doMoveTorment;
            }
        }
        private bool f_doMoveDamageMultihitUntilMiss;
        private byte _doMoveDamageMultihitUntilMiss;

        /// <summary>
        /// Move effect: Deal multihit damage until a strike misses
        /// Relevant moves: Ice Ball, Rollout
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public byte DoMoveDamageMultihitUntilMiss
        {
            get
            {
                if (f_doMoveDamageMultihitUntilMiss)
                    return _doMoveDamageMultihitUntilMiss;
                _doMoveDamageMultihitUntilMiss = (byte) (164);
                f_doMoveDamageMultihitUntilMiss = true;
                return _doMoveDamageMultihitUntilMiss;
            }
        }
        private bool f_doMoveSkillSwap;
        private int _doMoveSkillSwap;

        /// <summary>
        /// Move effect: Skill Swap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSkillSwap
        {
            get
            {
                if (f_doMoveSkillSwap)
                    return _doMoveSkillSwap;
                _doMoveSkillSwap = (int) (10444);
                f_doMoveSkillSwap = true;
                return _doMoveSkillSwap;
            }
        }
        private bool f_doMoveRoost;
        private int _doMoveRoost;

        /// <summary>
        /// Move effect: Roost
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRoost
        {
            get
            {
                if (f_doMoveRoost)
                    return _doMoveRoost;
                _doMoveRoost = (int) (33148);
                f_doMoveRoost = true;
                return _doMoveRoost;
            }
        }
        private bool f_doMoveFrustration;
        private int _doMoveFrustration;

        /// <summary>
        /// Move effect: Frustration
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFrustration
        {
            get
            {
                if (f_doMoveFrustration)
                    return _doMoveFrustration;
                _doMoveFrustration = (int) (23892);
                f_doMoveFrustration = true;
                return _doMoveFrustration;
            }
        }
        private bool f_doMoveSwagger;
        private int _doMoveSwagger;

        /// <summary>
        /// Move effect: Swagger
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSwagger
        {
            get
            {
                if (f_doMoveSwagger)
                    return _doMoveSwagger;
                _doMoveSwagger = (int) (1960);
                f_doMoveSwagger = true;
                return _doMoveSwagger;
            }
        }
        private bool f_doMoveChargeBeam;
        private int _doMoveChargeBeam;

        /// <summary>
        /// Move effect: Charge Beam
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveChargeBeam
        {
            get
            {
                if (f_doMoveChargeBeam)
                    return _doMoveChargeBeam;
                _doMoveChargeBeam = (int) (31588);
                f_doMoveChargeBeam = true;
                return _doMoveChargeBeam;
            }
        }
        private bool f_doMoveNaturalGift;
        private int _doMoveNaturalGift;

        /// <summary>
        /// Move effect: Natural Gift
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveNaturalGift
        {
            get
            {
                if (f_doMoveNaturalGift)
                    return _doMoveNaturalGift;
                _doMoveNaturalGift = (int) (31024);
                f_doMoveNaturalGift = true;
                return _doMoveNaturalGift;
            }
        }
        private bool f_doMoveAmnesia;
        private int _doMoveAmnesia;

        /// <summary>
        /// Move effect: Amnesia
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveAmnesia
        {
            get
            {
                if (f_doMoveAmnesia)
                    return _doMoveAmnesia;
                _doMoveAmnesia = (int) (17020);
                f_doMoveAmnesia = true;
                return _doMoveAmnesia;
            }
        }
        private bool f_doMovePoisonTail;
        private int _doMovePoisonTail;

        /// <summary>
        /// Move effect: Poison Tail
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePoisonTail
        {
            get
            {
                if (f_doMovePoisonTail)
                    return _doMovePoisonTail;
                _doMovePoisonTail = (int) (22184);
                f_doMovePoisonTail = true;
                return _doMovePoisonTail;
            }
        }
        private bool f_doMoveDamageBurn10FlameWheel;
        private int _doMoveDamageBurn10FlameWheel;

        /// <summary>
        /// Move effect: Deal damage with a 10% chance (FLAME_WHEEL_BURN_CHANCE) of burning the defender.
        /// Relevant moves: Flame Wheel, Lava Plume
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageBurn10FlameWheel
        {
            get
            {
                if (f_doMoveDamageBurn10FlameWheel)
                    return _doMoveDamageBurn10FlameWheel;
                _doMoveDamageBurn10FlameWheel = (int) (3844);
                f_doMoveDamageBurn10FlameWheel = true;
                return _doMoveDamageBurn10FlameWheel;
            }
        }
        private bool f_doMoveTwoEdge;
        private int _doMoveTwoEdge;

        /// <summary>
        /// Move effect: Two-Edge (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTwoEdge
        {
            get
            {
                if (f_doMoveTwoEdge)
                    return _doMoveTwoEdge;
                _doMoveTwoEdge = (int) (26860);
                f_doMoveTwoEdge = true;
                return _doMoveTwoEdge;
            }
        }
        private bool f_doMoveBubble;
        private int _doMoveBubble;

        /// <summary>
        /// Move effect: Bubble
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBubble
        {
            get
            {
                if (f_doMoveBubble)
                    return _doMoveBubble;
                _doMoveBubble = (int) (992);
                f_doMoveBubble = true;
                return _doMoveBubble;
            }
        }
        private bool f_doMoveFakeOut;
        private int _doMoveFakeOut;

        /// <summary>
        /// Move effect: Fake Out
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFakeOut
        {
            get
            {
                if (f_doMoveFakeOut)
                    return _doMoveFakeOut;
                _doMoveFakeOut = (int) (17632);
                f_doMoveFakeOut = true;
                return _doMoveFakeOut;
            }
        }
        private bool f_doMoveGrudge;
        private int _doMoveGrudge;

        /// <summary>
        /// Move effect: Grudge
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGrudge
        {
            get
            {
                if (f_doMoveGrudge)
                    return _doMoveGrudge;
                _doMoveGrudge = (int) (3808);
                f_doMoveGrudge = true;
                return _doMoveGrudge;
            }
        }
        private bool f_doMoveOctazooka;
        private int _doMoveOctazooka;

        /// <summary>
        /// Move effect: Octazooka
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveOctazooka
        {
            get
            {
                if (f_doMoveOctazooka)
                    return _doMoveOctazooka;
                _doMoveOctazooka = (int) (3248);
                f_doMoveOctazooka = true;
                return _doMoveOctazooka;
            }
        }
        private bool f_doMoveDragonDance;
        private int _doMoveDragonDance;

        /// <summary>
        /// Move effect: Dragon Dance
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDragonDance
        {
            get
            {
                if (f_doMoveDragonDance)
                    return _doMoveDragonDance;
                _doMoveDragonDance = (int) (25128);
                f_doMoveDragonDance = true;
                return _doMoveDragonDance;
            }
        }
        private bool f_doMoveBide;
        private int _doMoveBide;

        /// <summary>
        /// Move effect: Give the user the Bide status
        /// Relevant moves: Bide, Revenge, Avalanche
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBide
        {
            get
            {
                if (f_doMoveBide)
                    return _doMoveBide;
                _doMoveBide = (int) (4484);
                f_doMoveBide = true;
                return _doMoveBide;
            }
        }
        private bool f_doMoveSweetScent;
        private int _doMoveSweetScent;

        /// <summary>
        /// Move effect: Sweet Scent
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSweetScent
        {
            get
            {
                if (f_doMoveSweetScent)
                    return _doMoveSweetScent;
                _doMoveSweetScent = (int) (712);
                f_doMoveSweetScent = true;
                return _doMoveSweetScent;
            }
        }
        private bool f_doMoveProtect;
        private int _doMoveProtect;

        /// <summary>
        /// Move effect: Try to give the user the Protect status
        /// Relevant moves: Protect, Detect
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveProtect
        {
            get
            {
                if (f_doMoveProtect)
                    return _doMoveProtect;
                _doMoveProtect = (int) (22992);
                f_doMoveProtect = true;
                return _doMoveProtect;
            }
        }
        private bool f_doMoveCaptivate;
        private int _doMoveCaptivate;

        /// <summary>
        /// Move effect: Captivate
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCaptivate
        {
            get
            {
                if (f_doMoveCaptivate)
                    return _doMoveCaptivate;
                _doMoveCaptivate = (int) (34580);
                f_doMoveCaptivate = true;
                return _doMoveCaptivate;
            }
        }
        private bool f_doMoveFlareBlitz;
        private int _doMoveFlareBlitz;

        /// <summary>
        /// Move effect: Flare Blitz
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFlareBlitz
        {
            get
            {
                if (f_doMoveFlareBlitz)
                    return _doMoveFlareBlitz;
                _doMoveFlareBlitz = (int) (33508);
                f_doMoveFlareBlitz = true;
                return _doMoveFlareBlitz;
            }
        }
        private bool f_doMoveMetalClaw;
        private int _doMoveMetalClaw;

        /// <summary>
        /// Move effect: Metal Claw
        /// 
        ///  Note that this move effect handler has a slightly different parameter list than all the others. Which offensive stat is boosted is specified by the caller.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: stat index for the offensive stat to boost
        /// stack[0]: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMetalClaw
        {
            get
            {
                if (f_doMoveMetalClaw)
                    return _doMoveMetalClaw;
                _doMoveMetalClaw = (int) (23360);
                f_doMoveMetalClaw = true;
                return _doMoveMetalClaw;
            }
        }
        private bool f_doMoveDamageEatItem;
        private int _doMoveDamageEatItem;

        /// <summary>
        /// Move effect: Deals damage, and eats any beneficial items the defender is holding.
        /// Relevant moves: Pluck, Bug Bite
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDamageEatItem
        {
            get
            {
                if (f_doMoveDamageEatItem)
                    return _doMoveDamageEatItem;
                _doMoveDamageEatItem = (int) (31692);
                f_doMoveDamageEatItem = true;
                return _doMoveDamageEatItem;
            }
        }
        private bool f_doMoveHealOrder;
        private int _doMoveHealOrder;

        /// <summary>
        /// Move effect: Heal Order
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHealOrder
        {
            get
            {
                if (f_doMoveHealOrder)
                    return _doMoveHealOrder;
                _doMoveHealOrder = (int) (30160);
                f_doMoveHealOrder = true;
                return _doMoveHealOrder;
            }
        }
        private bool f_doMoveTrickRoom;
        private int _doMoveTrickRoom;

        /// <summary>
        /// Move effect: Trick Room
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTrickRoom
        {
            get
            {
                if (f_doMoveTrickRoom)
                    return _doMoveTrickRoom;
                _doMoveTrickRoom = (int) (32564);
                f_doMoveTrickRoom = true;
                return _doMoveTrickRoom;
            }
        }
        private bool f_doMoveSuperpower;
        private int _doMoveSuperpower;

        /// <summary>
        /// Move effect: Superpower
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSuperpower
        {
            get
            {
                if (f_doMoveSuperpower)
                    return _doMoveSuperpower;
                _doMoveSuperpower = (int) (18248);
                f_doMoveSuperpower = true;
                return _doMoveSuperpower;
            }
        }
        private bool f_doMoveSlowDown;
        private int _doMoveSlowDown;

        /// <summary>
        /// Move effect: Slow Down (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSlowDown
        {
            get
            {
                if (f_doMoveSlowDown)
                    return _doMoveSlowDown;
                _doMoveSlowDown = (int) (27664);
                f_doMoveSlowDown = true;
                return _doMoveSlowDown;
            }
        }
        private bool f_doMoveMinimize;
        private int _doMoveMinimize;

        /// <summary>
        /// Move effect: Minimize
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMinimize
        {
            get
            {
                if (f_doMoveMinimize)
                    return _doMoveMinimize;
                _doMoveMinimize = (int) (13424);
                f_doMoveMinimize = true;
                return _doMoveMinimize;
            }
        }
        private bool f_doMoveHornDrill;
        private int _doMoveHornDrill;

        /// <summary>
        /// Move effect: Horn Drill
        /// 
        /// This is exactly the same as DoMoveOhko, except there's a call to SubstitutePlaceholderStringTags at the end.
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHornDrill
        {
            get
            {
                if (f_doMoveHornDrill)
                    return _doMoveHornDrill;
                _doMoveHornDrill = (int) (13932);
                f_doMoveHornDrill = true;
                return _doMoveHornDrill;
            }
        }
        private bool f_doMoveSketch;
        private int _doMoveSketch;

        /// <summary>
        /// Move effect: Sketch
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSketch
        {
            get
            {
                if (f_doMoveSketch)
                    return _doMoveSketch;
                _doMoveSketch = (int) (10696);
                f_doMoveSketch = true;
                return _doMoveSketch;
            }
        }
        private bool f_doMovePsychUp;
        private int _doMovePsychUp;

        /// <summary>
        /// Move effect: Psych Up
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePsychUp
        {
            get
            {
                if (f_doMovePsychUp)
                    return _doMovePsychUp;
                _doMovePsychUp = (int) (8400);
                f_doMovePsychUp = true;
                return _doMovePsychUp;
            }
        }
        private bool f_doMoveBlastBurn;
        private int _doMoveBlastBurn;

        /// <summary>
        /// Move effect: Blast Burn
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBlastBurn
        {
            get
            {
                if (f_doMoveBlastBurn)
                    return _doMoveBlastBurn;
                _doMoveBlastBurn = (int) (21292);
                f_doMoveBlastBurn = true;
                return _doMoveBlastBurn;
            }
        }
        private bool f_doMoveFocusEnergy;
        private int _doMoveFocusEnergy;

        /// <summary>
        /// Move effect: Focus Energy
        /// Relevant moves: Focus Energy, MOVE_TAG_0x1AC
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFocusEnergy
        {
            get
            {
                if (f_doMoveFocusEnergy)
                    return _doMoveFocusEnergy;
                _doMoveFocusEnergy = (int) (2808);
                f_doMoveFocusEnergy = true;
                return _doMoveFocusEnergy;
            }
        }
        private bool f_doMoveBlock;
        private int _doMoveBlock;

        /// <summary>
        /// Move effect: Block
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBlock
        {
            get
            {
                if (f_doMoveBlock)
                    return _doMoveBlock;
                _doMoveBlock = (int) (14980);
                f_doMoveBlock = true;
                return _doMoveBlock;
            }
        }
        private bool f_doMoveDig;
        private int _doMoveDig;

        /// <summary>
        /// Move effect: Dig
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDig
        {
            get
            {
                if (f_doMoveDig)
                    return _doMoveDig;
                _doMoveDig = (int) (516);
                f_doMoveDig = true;
                return _doMoveDig;
            }
        }
        private bool f_doMoveSeismicToss;
        private int _doMoveSeismicToss;

        /// <summary>
        /// Move effect: Seismic Toss
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSeismicToss
        {
            get
            {
                if (f_doMoveSeismicToss)
                    return _doMoveSeismicToss;
                _doMoveSeismicToss = (int) (13452);
                f_doMoveSeismicToss = true;
                return _doMoveSeismicToss;
            }
        }
        private bool f_doMoveConversion;
        private int _doMoveConversion;

        /// <summary>
        /// Move effect: Conversion
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveConversion
        {
            get
            {
                if (f_doMoveConversion)
                    return _doMoveConversion;
                _doMoveConversion = (int) (14216);
                f_doMoveConversion = true;
                return _doMoveConversion;
            }
        }
        private bool f_doMoveStruggle;
        private int _doMoveStruggle;

        /// <summary>
        /// Move effect: Struggle
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveStruggle
        {
            get
            {
                if (f_doMoveStruggle)
                    return _doMoveStruggle;
                _doMoveStruggle = (int) (25508);
                f_doMoveStruggle = true;
                return _doMoveStruggle;
            }
        }
        private bool f_doMoveSpitUp;
        private int _doMoveSpitUp;

        /// <summary>
        /// Move effect: Spit Up
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSpitUp
        {
            get
            {
                if (f_doMoveSpitUp)
                    return _doMoveSpitUp;
                _doMoveSpitUp = (int) (18528);
                f_doMoveSpitUp = true;
                return _doMoveSpitUp;
            }
        }
        private bool f_doMoveFacade;
        private int _doMoveFacade;

        /// <summary>
        /// Move effect: Facade
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFacade
        {
            get
            {
                if (f_doMoveFacade)
                    return _doMoveFacade;
                _doMoveFacade = (int) (5256);
                f_doMoveFacade = true;
                return _doMoveFacade;
            }
        }
        private bool f_doMoveRage;
        private int _doMoveRage;

        /// <summary>
        /// Move effect: Rage
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRage
        {
            get
            {
                if (f_doMoveRage)
                    return _doMoveRage;
                _doMoveRage = (int) (1120);
                f_doMoveRage = true;
                return _doMoveRage;
            }
        }
        private bool f_doMovePerishSong;
        private int _doMovePerishSong;

        /// <summary>
        /// Move effect: Perish Song
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePerishSong
        {
            get
            {
                if (f_doMovePerishSong)
                    return _doMovePerishSong;
                _doMovePerishSong = (int) (22708);
                f_doMovePerishSong = true;
                return _doMovePerishSong;
            }
        }
        private bool f_doMoveScreech;
        private int _doMoveScreech;

        /// <summary>
        /// Move effect: Screech
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveScreech
        {
            get
            {
                if (f_doMoveScreech)
                    return _doMoveScreech;
                _doMoveScreech = (int) (2184);
                f_doMoveScreech = true;
                return _doMoveScreech;
            }
        }
        private bool f_doMoveItemize;
        private int _doMoveItemize;

        /// <summary>
        /// Move effect: Itemize (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveItemize
        {
            get
            {
                if (f_doMoveItemize)
                    return _doMoveItemize;
                _doMoveItemize = (int) (29504);
                f_doMoveItemize = true;
                return _doMoveItemize;
            }
        }
        private bool f_doMoveLowerDefense1;
        private int _doMoveLowerDefense1;

        /// <summary>
        /// Move effect: Lower the defender's defense by one stage
        /// Relevant moves: Tail Whip, Leer
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveLowerDefense1
        {
            get
            {
                if (f_doMoveLowerDefense1)
                    return _doMoveLowerDefense1;
                _doMoveLowerDefense1 = (int) (17568);
                f_doMoveLowerDefense1 = true;
                return _doMoveLowerDefense1;
            }
        }
        private bool f_doMoveCharge;
        private int _doMoveCharge;

        /// <summary>
        /// Move effect: Charge
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCharge
        {
            get
            {
                if (f_doMoveCharge)
                    return _doMoveCharge;
                _doMoveCharge = (int) (9476);
                f_doMoveCharge = true;
                return _doMoveCharge;
            }
        }
        private bool f_doMoveStealthRock;
        private int _doMoveStealthRock;

        /// <summary>
        /// Move effect: Stealth Rock
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveStealthRock
        {
            get
            {
                if (f_doMoveStealthRock)
                    return _doMoveStealthRock;
                _doMoveStealthRock = (int) (31492);
                f_doMoveStealthRock = true;
                return _doMoveStealthRock;
            }
        }
        private bool f_doMoveBlowback;
        private int _doMoveBlowback;

        /// <summary>
        /// Move effect: Blows the defender back
        /// Relevant moves: Whirlwind, Roar, Blowback (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBlowback
        {
            get
            {
                if (f_doMoveBlowback)
                    return _doMoveBlowback;
                _doMoveBlowback = (int) (22292);
                f_doMoveBlowback = true;
                return _doMoveBlowback;
            }
        }
        private bool f_doMoveBoostSpeed1;
        private int _doMoveBoostSpeed1;

        /// <summary>
        /// Move effect: Boost the team's movement speed by one stage
        /// Relevant moves: Agility, Speed Boost (item effect), MOVE_TAG_0x1AA, Tailwind
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBoostSpeed1
        {
            get
            {
                if (f_doMoveBoostSpeed1)
                    return _doMoveBoostSpeed1;
                _doMoveBoostSpeed1 = (int) (7012);
                f_doMoveBoostSpeed1 = true;
                return _doMoveBoostSpeed1;
            }
        }
        private bool f_doMoveHealBlock;
        private int _doMoveHealBlock;

        /// <summary>
        /// Move effect: Heal Block
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHealBlock
        {
            get
            {
                if (f_doMoveHealBlock)
                    return _doMoveHealBlock;
                _doMoveHealBlock = (int) (30200);
                f_doMoveHealBlock = true;
                return _doMoveHealBlock;
            }
        }
        private bool f_doMoveNoMove;
        private int _doMoveNoMove;

        /// <summary>
        /// Move effect: No-Move (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveNoMove
        {
            get
            {
                if (f_doMoveNoMove)
                    return _doMoveNoMove;
                _doMoveNoMove = (int) (27156);
                f_doMoveNoMove = true;
                return _doMoveNoMove;
            }
        }
        private bool f_doMoveBoostDefense1;
        private int _doMoveBoostDefense1;

        /// <summary>
        /// Move effect: Boost the user's defense by one stage
        /// Relevant moves: Harden, Withdraw
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBoostDefense1
        {
            get
            {
                if (f_doMoveBoostDefense1)
                    return _doMoveBoostDefense1;
                _doMoveBoostDefense1 = (int) (4252);
                f_doMoveBoostDefense1 = true;
                return _doMoveBoostDefense1;
            }
        }
        private bool f_doMoveGust;
        private int _doMoveGust;

        /// <summary>
        /// Move effect: Gust
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveGust
        {
            get
            {
                if (f_doMoveGust)
                    return _doMoveGust;
                _doMoveGust = (int) (4188);
                f_doMoveGust = true;
                return _doMoveGust;
            }
        }
        private bool f_doMoveCrunch;
        private int _doMoveCrunch;

        /// <summary>
        /// Move effect: Deal damage with a 20% chance (CRUNCH_LOWER_DEFENSE_CHANCE) of lowering the defender's defense.
        /// Relevant moves: Crunch, Shadow Ball via Nature Power
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveCrunch
        {
            get
            {
                if (f_doMoveCrunch)
                    return _doMoveCrunch;
                _doMoveCrunch = (int) (4720);
                f_doMoveCrunch = true;
                return _doMoveCrunch;
            }
        }
        private bool f_doMoveDrought;
        private int _doMoveDrought;

        /// <summary>
        /// Move effect: Drought (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDrought
        {
            get
            {
                if (f_doMoveDrought)
                    return _doMoveDrought;
                _doMoveDrought = (int) (27908);
                f_doMoveDrought = true;
                return _doMoveDrought;
            }
        }
        private bool f_doMoveRockPolish;
        private int _doMoveRockPolish;

        /// <summary>
        /// Move effect: Rock Polish
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRockPolish
        {
            get
            {
                if (f_doMoveRockPolish)
                    return _doMoveRockPolish;
                _doMoveRockPolish = (int) (34960);
                f_doMoveRockPolish = true;
                return _doMoveRockPolish;
            }
        }
        private bool f_doMoveSurf;
        private int _doMoveSurf;

        /// <summary>
        /// Move effect: Surf
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSurf
        {
            get
            {
                if (f_doMoveSurf)
                    return _doMoveSurf;
                _doMoveSurf = (int) (17260);
                f_doMoveSurf = true;
                return _doMoveSurf;
            }
        }
        private bool f_doMoveOverheat;
        private int _doMoveOverheat;

        /// <summary>
        /// Move effect: Overheat
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveOverheat
        {
            get
            {
                if (f_doMoveOverheat)
                    return _doMoveOverheat;
                _doMoveOverheat = (int) (2920);
                f_doMoveOverheat = true;
                return _doMoveOverheat;
            }
        }
        private bool f_doMoveExpose;
        private int _doMoveExpose;

        /// <summary>
        /// Move effect: Expose all Ghost-type enemies, and reset evasion boosts
        /// Relevant moves: Odor Sleuth, Foresight
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveExpose
        {
            get
            {
                if (f_doMoveExpose)
                    return _doMoveExpose;
                _doMoveExpose = (int) (4116);
                f_doMoveExpose = true;
                return _doMoveExpose;
            }
        }
        private bool f_doMoveTrumpCard;
        private int _doMoveTrumpCard;

        /// <summary>
        /// Move effect: Trump Card
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTrumpCard
        {
            get
            {
                if (f_doMoveTrumpCard)
                    return _doMoveTrumpCard;
                _doMoveTrumpCard = (int) (30552);
                f_doMoveTrumpCard = true;
                return _doMoveTrumpCard;
            }
        }
        private bool f_doMovePetrify;
        private int _doMovePetrify;

        /// <summary>
        /// Move effect: Petrifies the target
        /// Relevant moves: Petrify (item effect), MOVE_TAG_0x1A9
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePetrify
        {
            get
            {
                if (f_doMovePetrify)
                    return _doMovePetrify;
                _doMovePetrify = (int) (27704);
                f_doMovePetrify = true;
                return _doMovePetrify;
            }
        }
        private bool f_doMoveFlatter;
        private int _doMoveFlatter;

        /// <summary>
        /// Move effect: Flatter
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFlatter
        {
            get
            {
                if (f_doMoveFlatter)
                    return _doMoveFlatter;
                _doMoveFlatter = (int) (3364);
                f_doMoveFlatter = true;
                return _doMoveFlatter;
            }
        }
        private bool f_doMoveStayAway;
        private int _doMoveStayAway;

        /// <summary>
        /// Move effect: Stay Away (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveStayAway
        {
            get
            {
                if (f_doMoveStayAway)
                    return _doMoveStayAway;
                _doMoveStayAway = (int) (26456);
                f_doMoveStayAway = true;
                return _doMoveStayAway;
            }
        }
        private bool f_doMoveMagnitude;
        private int _doMoveMagnitude;

        /// <summary>
        /// Move effect: Magnitude
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMagnitude
        {
            get
            {
                if (f_doMoveMagnitude)
                    return _doMoveMagnitude;
                _doMoveMagnitude = (int) (22840);
                f_doMoveMagnitude = true;
                return _doMoveMagnitude;
            }
        }
        private bool f_doMoveTwister;
        private int _doMoveTwister;

        /// <summary>
        /// Move effect: Twister
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTwister
        {
            get
            {
                if (f_doMoveTwister)
                    return _doMoveTwister;
                _doMoveTwister = (int) (13056);
                f_doMoveTwister = true;
                return _doMoveTwister;
            }
        }
        private bool f_doMoveHurl;
        private int _doMoveHurl;

        /// <summary>
        /// Move effect: Hurls the target
        /// Relevant moves: Strength, Hurl (item effect), Fling
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHurl
        {
            get
            {
                if (f_doMoveHurl)
                    return _doMoveHurl;
                _doMoveHurl = (int) (29652);
                f_doMoveHurl = true;
                return _doMoveHurl;
            }
        }
        private bool f_doMoveDragonRage;
        private int _doMoveDragonRage;

        /// <summary>
        /// Move effect: Dragon Rage
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDragonRage
        {
            get
            {
                if (f_doMoveDragonRage)
                    return _doMoveDragonRage;
                _doMoveDragonRage = (int) (24968);
                f_doMoveDragonRage = true;
                return _doMoveDragonRage;
            }
        }
        private bool f_doMoveNaturePower;
        private int _doMoveNaturePower;

        /// <summary>
        /// Move effect: Nature Power
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move (unused)
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveNaturePower
        {
            get
            {
                if (f_doMoveNaturePower)
                    return _doMoveNaturePower;
                _doMoveNaturePower = (int) (9036);
                f_doMoveNaturePower = true;
                return _doMoveNaturePower;
            }
        }
        private bool f_doMoveHpGauge;
        private int _doMoveHpGauge;

        /// <summary>
        /// Move effect: HP Gauge (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveHpGauge
        {
            get
            {
                if (f_doMoveHpGauge)
                    return _doMoveHpGauge;
                _doMoveHpGauge = (int) (28732);
                f_doMoveHpGauge = true;
                return _doMoveHpGauge;
            }
        }
        private bool f_doMoveIronTail;
        private sbyte _doMoveIronTail;

        /// <summary>
        /// Move effect: Iron Tail
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public sbyte DoMoveIronTail
        {
            get
            {
                if (f_doMoveIronTail)
                    return _doMoveIronTail;
                _doMoveIronTail = (sbyte) (36);
                f_doMoveIronTail = true;
                return _doMoveIronTail;
            }
        }
        private bool f_doMoveReversal;
        private int _doMoveReversal;

        /// <summary>
        /// Move effect: Deal damage with a higher multiplier the lower the attacker's HP is.
        /// Relevant moves: Reversal, Flail
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveReversal
        {
            get
            {
                if (f_doMoveReversal)
                    return _doMoveReversal;
                _doMoveReversal = (int) (6100);
                f_doMoveReversal = true;
                return _doMoveReversal;
            }
        }
        private bool f_doMoveSolarBeam;
        private int _doMoveSolarBeam;

        /// <summary>
        /// Move effect: SolarBeam
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSolarBeam
        {
            get
            {
                if (f_doMoveSolarBeam)
                    return _doMoveSolarBeam;
                _doMoveSolarBeam = (int) (11944);
                f_doMoveSolarBeam = true;
                return _doMoveSolarBeam;
            }
        }
        private bool f_doMoveSacredFire;
        private int _doMoveSacredFire;

        /// <summary>
        /// Move effect: Sacred Fire
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSacredFire
        {
            get
            {
                if (f_doMoveSacredFire)
                    return _doMoveSacredFire;
                _doMoveSacredFire = (int) (11572);
                f_doMoveSacredFire = true;
                return _doMoveSacredFire;
            }
        }
        private bool f_doMoveFly;
        private int _doMoveFly;

        /// <summary>
        /// Move effect: Fly
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFly
        {
            get
            {
                if (f_doMoveFly)
                    return _doMoveFly;
                _doMoveFly = (int) (12312);
                f_doMoveFly = true;
                return _doMoveFly;
            }
        }
        private bool f_doMoveMistBall;
        private int _doMoveMistBall;

        /// <summary>
        /// Move effect: Mist Ball
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMistBall
        {
            get
            {
                if (f_doMoveMistBall)
                    return _doMoveMistBall;
                _doMoveMistBall = (int) (23072);
                f_doMoveMistBall = true;
                return _doMoveMistBall;
            }
        }
        private bool f_doMoveCosmicPower;
        private int _doMoveCosmicPower;

        /// <summary>
        /// Move effect: Cosmic Power
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCosmicPower
        {
            get
            {
                if (f_doMoveCosmicPower)
                    return _doMoveCosmicPower;
                _doMoveCosmicPower = (int) (7200);
                f_doMoveCosmicPower = true;
                return _doMoveCosmicPower;
            }
        }
        private bool f_doMoveBeatUp;
        private int _doMoveBeatUp;

        /// <summary>
        /// Move effect: Beat Up
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveBeatUp
        {
            get
            {
                if (f_doMoveBeatUp)
                    return _doMoveBeatUp;
                _doMoveBeatUp = (int) (21048);
                f_doMoveBeatUp = true;
                return _doMoveBeatUp;
            }
        }
        private bool f_doMoveWaterSpout;
        private int _doMoveWaterSpout;

        /// <summary>
        /// Move effect: Water Spout
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWaterSpout
        {
            get
            {
                if (f_doMoveWaterSpout)
                    return _doMoveWaterSpout;
                _doMoveWaterSpout = (int) (8220);
                f_doMoveWaterSpout = true;
                return _doMoveWaterSpout;
            }
        }
        private bool f_doMoveWillOWisp;
        private int _doMoveWillOWisp;

        /// <summary>
        /// Move effect: Will-O-Wisp
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWillOWisp
        {
            get
            {
                if (f_doMoveWillOWisp)
                    return _doMoveWillOWisp;
                _doMoveWillOWisp = (int) (3424);
                f_doMoveWillOWisp = true;
                return _doMoveWillOWisp;
            }
        }
        private bool f_doMoveDestinyBond;
        private int _doMoveDestinyBond;

        /// <summary>
        /// Move effect: Destiny Bond
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDestinyBond
        {
            get
            {
                if (f_doMoveDestinyBond)
                    return _doMoveDestinyBond;
                _doMoveDestinyBond = (int) (23200);
                f_doMoveDestinyBond = true;
                return _doMoveDestinyBond;
            }
        }
        private bool f_doMoveSiesta;
        private int _doMoveSiesta;

        /// <summary>
        /// Move effect: Siesta (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSiesta
        {
            get
            {
                if (f_doMoveSiesta)
                    return _doMoveSiesta;
                _doMoveSiesta = (int) (26800);
                f_doMoveSiesta = true;
                return _doMoveSiesta;
            }
        }
        private bool f_doMoveFamish;
        private int _doMoveFamish;

        /// <summary>
        /// Move effect: Famish (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveFamish
        {
            get
            {
                if (f_doMoveFamish)
                    return _doMoveFamish;
                _doMoveFamish = (int) (29008);
                f_doMoveFamish = true;
                return _doMoveFamish;
            }
        }
        private bool f_doMovePierce;
        private int _doMovePierce;

        /// <summary>
        /// Move effect: Pierce (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePierce
        {
            get
            {
                if (f_doMovePierce)
                    return _doMovePierce;
                _doMovePierce = (int) (29716);
                f_doMovePierce = true;
                return _doMovePierce;
            }
        }
        private bool f_doMoveJumpKick;
        private int _doMoveJumpKick;

        /// <summary>
        /// Move effect: Jump Kick
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveJumpKick
        {
            get
            {
                if (f_doMoveJumpKick)
                    return _doMoveJumpKick;
                _doMoveJumpKick = (int) (15264);
                f_doMoveJumpKick = true;
                return _doMoveJumpKick;
            }
        }
        private bool f_doMoveTransform;
        private int _doMoveTransform;

        /// <summary>
        /// Move effect: Transform
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTransform
        {
            get
            {
                if (f_doMoveTransform)
                    return _doMoveTransform;
                _doMoveTransform = (int) (22112);
                f_doMoveTransform = true;
                return _doMoveTransform;
            }
        }
        private bool f_doMoveDamageParalyze20;
        private int _doMoveDamageParalyze20;

        /// <summary>
        /// Move effect: Deal damage with a 20% chance (THUNDER_PARALYZE_CHANCE) of paralyzing the defender.
        /// Relevant moves: Thunder, ThunderPunch, Force Palm, Discharge
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether or not damage was dealt
        /// </summary>
        public int DoMoveDamageParalyze20
        {
            get
            {
                if (f_doMoveDamageParalyze20)
                    return _doMoveDamageParalyze20;
                _doMoveDamageParalyze20 = (int) (4956);
                f_doMoveDamageParalyze20 = true;
                return _doMoveDamageParalyze20;
            }
        }
        private bool f_doMovePowerEars;
        private int _doMovePowerEars;

        /// <summary>
        /// Move effect: Power-Ears (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePowerEars
        {
            get
            {
                if (f_doMovePowerEars)
                    return _doMovePowerEars;
                _doMovePowerEars = (int) (27192);
                f_doMovePowerEars = true;
                return _doMovePowerEars;
            }
        }
        private bool f_doMoveWrap;
        private int _doMoveWrap;

        /// <summary>
        /// Move effect: Wrap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWrap
        {
            get
            {
                if (f_doMoveWrap)
                    return _doMoveWrap;
                _doMoveWrap = (int) (22728);
                f_doMoveWrap = true;
                return _doMoveWrap;
            }
        }
        private bool f_doMoveCopycat;
        private int _doMoveCopycat;

        /// <summary>
        /// Move effect: The attacker uses the move last used by enemy it's facing.
        /// Relevant moves: Mimic, Copycat
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveCopycat
        {
            get
            {
                if (f_doMoveCopycat)
                    return _doMoveCopycat;
                _doMoveCopycat = (int) (23624);
                f_doMoveCopycat = true;
                return _doMoveCopycat;
            }
        }
        private bool f_doMoveSnore;
        private int _doMoveSnore;

        /// <summary>
        /// Move effect: Snore
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSnore
        {
            get
            {
                if (f_doMoveSnore)
                    return _doMoveSnore;
                _doMoveSnore = (int) (2020);
                f_doMoveSnore = true;
                return _doMoveSnore;
            }
        }
        private bool f_doMoveSmokescreen;
        private int _doMoveSmokescreen;

        /// <summary>
        /// Move effect: Smokescreen
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSmokescreen
        {
            get
            {
                if (f_doMoveSmokescreen)
                    return _doMoveSmokescreen;
                _doMoveSmokescreen = (int) (2824);
                f_doMoveSmokescreen = true;
                return _doMoveSmokescreen;
            }
        }
        private bool f_doMoveTickle;
        private int _doMoveTickle;

        /// <summary>
        /// Move effect: Tickle
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTickle
        {
            get
            {
                if (f_doMoveTickle)
                    return _doMoveTickle;
                _doMoveTickle = (int) (6436);
                f_doMoveTickle = true;
                return _doMoveTickle;
            }
        }
        private bool f_doMoveDecoy;
        private int _doMoveDecoy;

        /// <summary>
        /// Move effect: Inflict the Decoy status on the target
        /// Relevant moves: Follow Me, Substitute, Decoy Maker (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveDecoy
        {
            get
            {
                if (f_doMoveDecoy)
                    return _doMoveDecoy;
                _doMoveDecoy = (int) (23040);
                f_doMoveDecoy = true;
                return _doMoveDecoy;
            }
        }
        private bool f_doMoveMudSlap;
        private int _doMoveMudSlap;

        /// <summary>
        /// Move effect: Mud-Slap
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMudSlap
        {
            get
            {
                if (f_doMoveMudSlap)
                    return _doMoveMudSlap;
                _doMoveMudSlap = (int) (16900);
                f_doMoveMudSlap = true;
                return _doMoveMudSlap;
            }
        }
        private bool f_doMoveWeatherBall;
        private int _doMoveWeatherBall;

        /// <summary>
        /// Move effect: Weather Ball
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveWeatherBall
        {
            get
            {
                if (f_doMoveWeatherBall)
                    return _doMoveWeatherBall;
                _doMoveWeatherBall = (int) (2332);
                f_doMoveWeatherBall = true;
                return _doMoveWeatherBall;
            }
        }
        private bool f_doMoveSwitchPositions;
        private int _doMoveSwitchPositions;

        /// <summary>
        /// Move effect: Switches the user's position with positions of other monsters in the room.
        /// Relevant moves: Baton Pass, Switcher (item effect)
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveSwitchPositions
        {
            get
            {
                if (f_doMoveSwitchPositions)
                    return _doMoveSwitchPositions;
                _doMoveSwitchPositions = (int) (26416);
                f_doMoveSwitchPositions = true;
                return _doMoveSwitchPositions;
            }
        }
        private bool f_doMoveRecycle;
        private int _doMoveRecycle;

        /// <summary>
        /// Move effect: Recycle
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveRecycle
        {
            get
            {
                if (f_doMoveRecycle)
                    return _doMoveRecycle;
                _doMoveRecycle = (int) (24644);
                f_doMoveRecycle = true;
                return _doMoveRecycle;
            }
        }
        private bool f_doMoveEndure;
        private int _doMoveEndure;

        /// <summary>
        /// Move effect: Endure
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveEndure
        {
            get
            {
                if (f_doMoveEndure)
                    return _doMoveEndure;
                _doMoveEndure = (int) (7708);
                f_doMoveEndure = true;
                return _doMoveEndure;
            }
        }
        private bool f_doMoveMagicCoat;
        private int _doMoveMagicCoat;

        /// <summary>
        /// Move effect: Magic Coat
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveMagicCoat
        {
            get
            {
                if (f_doMoveMagicCoat)
                    return _doMoveMagicCoat;
                _doMoveMagicCoat = (int) (22976);
                f_doMoveMagicCoat = true;
                return _doMoveMagicCoat;
            }
        }
        private bool f_doMoveTriAttack;
        private int _doMoveTriAttack;

        /// <summary>
        /// Move effect: Tri Attack
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMoveTriAttack
        {
            get
            {
                if (f_doMoveTriAttack)
                    return _doMoveTriAttack;
                _doMoveTriAttack = (int) (16068);
                f_doMoveTriAttack = true;
                return _doMoveTriAttack;
            }
        }
        private bool f_doMovePresent;
        private int _doMovePresent;

        /// <summary>
        /// Move effect: Present
        /// 
        /// r0: attacker pointer
        /// r1: defender pointer
        /// r2: move
        /// r3: item ID
        /// return: whether the move was successfully used
        /// </summary>
        public int DoMovePresent
        {
            get
            {
                if (f_doMovePresent)
                    return _doMovePresent;
                _doMovePresent = (int) (21632);
                f_doMovePresent = true;
                return _doMovePresent;
            }
        }
        private MoveEffectsFunctions m_root;
        private KaitaiStruct m_parent;
        public MoveEffectsFunctions M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
