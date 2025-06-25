// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum ability_id.
    /// </summary>
    public partial class AbilityId8 : KaitaiStruct
    {
        public static AbilityId8 FromFile(string fileName)
        {
            return new AbilityId8(new KaitaiStream(fileName));
        }


        public enum AbilityId8Enum
        {
            AbilityUnknown = 0,
            AbilityStench = 1,
            AbilityThickFat = 2,
            AbilityRainDish = 3,
            AbilityDrizzle = 4,
            AbilityArenaTrap = 5,
            AbilityIntimidate = 6,
            AbilityRockHead = 7,
            AbilityAirLock = 8,
            AbilityHyperCutter = 9,
            AbilityShadowTag = 10,
            AbilitySpeedBoost = 11,
            AbilityBattleArmor = 12,
            AbilitySturdy = 13,
            AbilitySuctionCups = 14,
            AbilityClearBody = 15,
            AbilityTorrent = 16,
            AbilityGuts = 17,
            AbilityRoughSkin = 18,
            AbilityShellArmor = 19,
            AbilityNaturalCure = 20,
            AbilityDamp = 21,
            AbilityLimber = 22,
            AbilityMagnetPull = 23,
            AbilityWhiteSmoke = 24,
            AbilitySynchronize = 25,
            AbilityOvergrow = 26,
            AbilitySwiftSwim = 27,
            AbilitySandStream = 28,
            AbilitySandVeil = 29,
            AbilityKeenEye = 30,
            AbilityInnerFocus = 31,
            AbilityStatic = 32,
            AbilityShedSkin = 33,
            AbilityHugePower = 34,
            AbilityVoltAbsorb = 35,
            AbilityWaterAbsorb = 36,
            AbilityForecast = 37,
            AbilitySereneGrace = 38,
            AbilityPoisonPoint = 39,
            AbilityTrace = 40,
            AbilityOblivious = 41,
            AbilityTruant = 42,
            AbilityRunAway = 43,
            AbilityStickyHold = 44,
            AbilityCloudNine = 45,
            AbilityIlluminate = 46,
            AbilityEarlyBird = 47,
            AbilityHustle = 48,
            AbilityDrought = 49,
            AbilityLightningrod = 50,
            AbilityCompoundeyes = 51,
            AbilityMarvelScale = 52,
            AbilityWonderGuard = 53,
            AbilityInsomnia = 54,
            AbilityLevitate = 55,
            AbilityPlus = 56,
            AbilityPressure = 57,
            AbilityLiquidOoze = 58,
            AbilityColorChange = 59,
            AbilitySoundproof = 60,
            AbilityEffectSpore = 61,
            AbilityFlameBody = 62,
            AbilityMinus = 63,
            AbilityOwnTempo = 64,
            AbilityMagmaArmor = 65,
            AbilityWaterVeil = 66,
            AbilitySwarm = 67,
            AbilityCuteCharm = 68,
            AbilityImmunity = 69,
            AbilityBlaze = 70,
            AbilityPickup = 71,
            AbilityFlashFire = 72,
            AbilityVitalSpirit = 73,
            AbilityChlorophyll = 74,
            AbilityPurePower = 75,
            AbilityShieldDust = 76,
            AbilityIceBody = 77,
            AbilityStall = 78,
            AbilityAngerPoint = 79,
            AbilityTintedLens = 80,
            AbilityHydration = 81,
            AbilityFrisk = 82,
            AbilityMoldBreaker = 83,
            AbilityUnburden = 84,
            AbilityDrySkin = 85,
            AbilityAnticipation = 86,
            AbilityScrappy = 87,
            AbilitySuperLuck = 88,
            AbilityGluttony = 89,
            AbilitySolarPower = 90,
            AbilitySkillLink = 91,
            AbilityReckless = 92,
            AbilitySniper = 93,
            AbilitySlowStart = 94,
            AbilityHeatproof = 95,
            AbilityDownload = 96,
            AbilitySimple = 97,
            AbilityTangledFeet = 98,
            AbilityAdaptability = 99,
            AbilityTechnician = 100,
            AbilityIronFist = 101,
            AbilityMotorDrive = 102,
            AbilityUnaware = 103,
            AbilityRivalry = 104,
            AbilityBadDreams = 105,
            AbilityNoGuard = 106,
            AbilityNormalize = 107,
            AbilitySolidRock = 108,
            AbilityQuickFeet = 109,
            AbilityFilter = 110,
            AbilityKlutz = 111,
            AbilitySteadfast = 112,
            AbilityFlowerGift = 113,
            AbilityPoisonHeal = 114,
            AbilityMagicGuard = 115,
            AbilityMultitype = 116,
            AbilityHoneyGather = 117,
            AbilityAftermath = 118,
            AbilitySnowCloak = 119,
            AbilitySnowWarning = 120,
            AbilityForewarn = 121,
            AbilityStormDrain = 122,
            AbilityLeafGuard = 123,
        }
        public AbilityId8(KaitaiStream p__io, KaitaiStruct p__parent = null, AbilityId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _abilityId8Value = ((AbilityId8Enum) m_io.ReadBitsIntLe(8));
        }
        private AbilityId8Enum _abilityId8Value;
        private AbilityId8 m_root;
        private KaitaiStruct m_parent;
        public AbilityId8Enum AbilityId8Value { get { return _abilityId8Value; } }
        public AbilityId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
