// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds bitsized data for the parent enum exclusive_item_effect_id.
    /// </summary>
    public partial class ExclusiveItemEffectId8 : KaitaiStruct
    {
        public static ExclusiveItemEffectId8 FromFile(string fileName)
        {
            return new ExclusiveItemEffectId8(new KaitaiStream(fileName));
        }


        public enum ExclusiveItemEffectId8Enum
        {
            ExclusiveEffStatBoost = 0,
            ExclusiveEffNoParalysis = 1,
            ExclusiveEffNoConfusion = 2,
            ExclusiveEffNoInfatuation = 3,
            ExclusiveEffNoFreeze = 4,
            ExclusiveEffNoCriticalHits = 5,
            ExclusiveEffHalvedExplosionDamage = 6,
            ExclusiveEffNoExplosionDamage = 7,
            ExclusiveEffNoMoveDisabling = 8,
            ExclusiveEffNoWeatherDamage = 9,
            ExclusiveEffNoSleep = 10,
            ExclusiveEffMayPoisonParalyzeSleepAttackers = 11,
            ExclusiveEffUnused0xc = 12,
            ExclusiveEffMaySleepAttackers = 13,
            ExclusiveEffMayNightmareAttackers = 14,
            ExclusiveEffMayBurnAttackers = 15,
            ExclusiveEffMayParalyzeAttackers = 16,
            ExclusiveEffMayConfuseAttackers = 17,
            ExclusiveEffMayInfatuateAttackers = 18,
            ExclusiveEffMayFreezeAttackers = 19,
            ExclusiveEffMayShadowHoldAttackers = 20,
            ExclusiveEffMayConstrictAttackers = 21,
            ExclusiveEffMayCringeAttackers = 22,
            ExclusiveEffMayBlinkerAttackers = 23,
            ExclusiveEffMaySealAttackerMoves = 24,
            ExclusiveEffMayGoInvisibleWhenAttacked = 25,
            ExclusiveEffMayBoostMovementSpeedWhenAttacked = 26,
            ExclusiveEffMayWarpWhenAttacked = 27,
            ExclusiveEffMayPerishSongAttackers = 28,
            ExclusiveEffMaySlowAttackers = 29,
            ExclusiveEffHalvedPhysicalDamage = 30,
            ExclusiveEffHalvedSpecialDamage = 31,
            ExclusiveEffCounterPhysicalDamage = 32,
            ExclusiveEffMayBounceStatusMoves = 33,
            ExclusiveEffMayEndure = 34,
            ExclusiveEffCounter25PctPhysicalDamage = 35,
            ExclusiveEffLongToss = 36,
            ExclusiveEffMayBounceMoves = 37,
            ExclusiveEffNoStatDrops = 38,
            ExclusiveEffConversion2WhenHit = 39,
            ExclusiveEffNoStatusWhenClear = 40,
            ExclusiveEffNoStatusWhenSunny = 41,
            ExclusiveEffNoStatusWhenSandstorm = 42,
            ExclusiveEffNoStatusWhenCloudy = 43,
            ExclusiveEffNoStatusWhenRainy = 44,
            ExclusiveEffNoStatusWhenHail = 45,
            ExclusiveEffNoStatusWhenFoggy = 46,
            ExclusiveEffMovementSpeedBoostWhenClear = 47,
            ExclusiveEffMovementSpeedBoostWhenSunny = 48,
            ExclusiveEffMovementSpeedBoostWhenSandstorm = 49,
            ExclusiveEffMovementSpeedBoostWhenCloudy = 50,
            ExclusiveEffMovementSpeedBoostWhenRainy = 51,
            ExclusiveEffMovementSpeedBoostWhenHail = 52,
            ExclusiveEffMovementSpeedBoostWhenFoggy = 53,
            ExclusiveEffAttackSpeedBoostWhenClear = 54,
            ExclusiveEffAttackSpeedBoostWhenSunny = 55,
            ExclusiveEffAttackSpeedBoostWhenSandstorm = 56,
            ExclusiveEffAttackSpeedBoostWhenCloudy = 57,
            ExclusiveEffAttackSpeedBoostWhenRainy = 58,
            ExclusiveEffAttackSpeedBoostWhenHail = 59,
            ExclusiveEffAttackSpeedBoostWhenFoggy = 60,
            ExclusiveEffEvasionBoostWhenClear = 61,
            ExclusiveEffEvasionBoostWhenSunny = 62,
            ExclusiveEffEvasionBoostWhenSandstorm = 63,
            ExclusiveEffEvasionBoostWhenCloudy = 64,
            ExclusiveEffEvasionBoostWhenRainy = 65,
            ExclusiveEffEvasionBoostWhenHail = 66,
            ExclusiveEffEvasionBoostWhenFoggy = 67,
            ExclusiveEffBypassReflectLightScreen = 68,
            ExclusiveEffScrappy = 69,
            ExclusiveEffMiracleEye = 70,
            ExclusiveEffRestorePpOnNewFloors = 71,
            ExclusiveEffRestoreHpOnNewFloors = 72,
            ExclusiveEffIncreasedHpRecovery = 73,
            ExclusiveEffMaxPpBoost = 74,
            ExclusiveEffUnused0x4b = 75,
            ExclusiveEffMaxHpBoost10 = 76,
            ExclusiveEffMaxHpBoost20 = 77,
            ExclusiveEffMaxHpBoost30 = 78,
            ExclusiveEffExpBoost = 79,
            ExclusiveEffExpFromDamage = 80,
            ExclusiveEffMayRestorePpFromDamage = 81,
            ExclusiveEffMayNotConsumePp = 82,
            ExclusiveEffThrownItemProtection = 83,
            ExclusiveEffBounceThrownItems = 84,
            ExclusiveEffExtendSelfEffectsToTeam = 85,
            ExclusiveEffMoreTreasureDrops = 86,
            ExclusiveEffHpDrainRecoveryBoost = 87,
            ExclusiveEffPressureBoost = 88,
            ExclusiveEffNoStatus = 89,
            ExclusiveEffHalvedDamage = 90,
            ExclusiveEffDamageBoost50Pct = 91,
            ExclusiveEffAbsorbTeammatePoison = 92,
            ExclusiveEffRecoverHpFromApplesAndBerries = 93,
            ExclusiveEffMoreKecleonShops = 94,
            ExclusiveEffMoreHiddenStairs = 95,
            ExclusiveEffNoFriendlyFire = 96,
            ExclusiveEffPickupBoost = 97,
            ExclusiveEffMoreMoneyDrops = 98,
            ExclusiveEffUnused0x63 = 99,
            ExclusiveEffRecoverHpFromWateryTerrain = 100,
            ExclusiveEffHealStatusFromWateryTerrain = 101,
            ExclusiveEffNoFireDamage = 102,
            ExclusiveEffNoWaterDamage = 103,
            ExclusiveEffNoGrassDamage = 104,
            ExclusiveEffNoElectricDamage = 105,
            ExclusiveEffNoFightingDamage = 106,
            ExclusiveEffNoGroundDamage = 107,
            ExclusiveEffNoFlyingDamage = 108,
            ExclusiveEffNoPsychicDamage = 109,
            ExclusiveEffNoGhostDamage = 110,
            ExclusiveEffNoDragonDamage = 111,
            ExclusiveEffNoDarkDamage = 112,
            ExclusiveEffNoSteelDamage = 113,
            ExclusiveEffAbsorbFireDamage = 114,
            ExclusiveEffAbsorbWaterDamage = 115,
            ExclusiveEffAbsorbGrassDamage = 116,
            ExclusiveEffAbsorbElectricDamage = 117,
            ExclusiveEffAbsorbIceDamage = 118,
            ExclusiveEffAbsorbFightingDamage = 119,
            ExclusiveEffAbsorbGroundDamage = 120,
            ExclusiveEffAbsorbFlyingDamage = 121,
            ExclusiveEffAbsorbPsychicDamage = 122,
            ExclusiveEffAbsorbBugDamage = 123,
            ExclusiveEffAbsorbRockDamage = 124,
            ExclusiveEffAbsorbGhostDamage = 125,
            ExclusiveEffAbsorbDragonDamage = 126,
            ExclusiveEffAbsorbDarkDamage = 127,
            ExclusiveEffAbsorbSteelDamage = 128,
            ExclusiveEffLast = 129,
        }
        public ExclusiveItemEffectId8(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclusiveItemEffectId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _exclusiveItemEffectId8Value = ((ExclusiveItemEffectId8Enum) m_io.ReadBitsIntLe(8));
        }
        private ExclusiveItemEffectId8Enum _exclusiveItemEffectId8Value;
        private ExclusiveItemEffectId8 m_root;
        private KaitaiStruct m_parent;
        public ExclusiveItemEffectId8Enum ExclusiveItemEffectId8Value { get { return _exclusiveItemEffectId8Value; } }
        public ExclusiveItemEffectId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
