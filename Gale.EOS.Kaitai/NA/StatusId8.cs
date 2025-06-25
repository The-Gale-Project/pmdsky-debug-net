// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Holds bitsized data for the parent enum status_id.
    /// </summary>
    public partial class StatusId8 : KaitaiStruct
    {
        public static StatusId8 FromFile(string fileName)
        {
            return new StatusId8(new KaitaiStream(fileName));
        }


        public enum StatusId8Enum
        {
            StatusNone = 0,
            StatusSleep = 1,
            StatusSleepless = 2,
            StatusNightmare = 3,
            StatusYawning = 4,
            StatusNapping = 5,
            StatusLowHp = 6,
            StatusBurn = 7,
            StatusPoisoned = 8,
            StatusBadlyPoisoned = 9,
            StatusParalysis = 10,
            StatusIdentifying = 11,
            StatusFrozen = 12,
            StatusShadowHold = 13,
            StatusWrap = 14,
            StatusWrapped = 15,
            StatusIngrain = 16,
            StatusPetrified = 17,
            StatusConstriction = 18,
            StatusFamished = 19,
            StatusCringe = 20,
            StatusConfused = 21,
            StatusPaused = 22,
            StatusCowering = 23,
            StatusTaunted = 24,
            StatusEncore = 25,
            StatusInfatuated = 26,
            StatusDoubleSpeed = 27,
            StatusBide = 28,
            StatusSolarbeam = 29,
            StatusSkyAttack = 30,
            StatusRazorWind = 31,
            StatusFocusPunch = 32,
            StatusSkullBash = 33,
            StatusFlying = 34,
            StatusBouncing = 35,
            StatusDiving = 36,
            StatusDigging = 37,
            StatusCharging = 38,
            StatusEnraged = 39,
            StatusShadowForce = 40,
            StatusHalfSpeed = 41,
            StatusReflect = 42,
            StatusSafeguard = 43,
            StatusLightScreen = 44,
            StatusCounter = 45,
            StatusMagicCoat = 46,
            StatusWish = 47,
            StatusProtect = 48,
            StatusMirrorCoat = 49,
            StatusEnduring = 50,
            StatusMiniCounter = 51,
            StatusMirrorMove = 52,
            StatusConversion2 = 53,
            StatusVitalThrow = 54,
            StatusMist = 55,
            StatusMetalBurst = 56,
            StatusAquaRing = 57,
            StatusLuckyChant = 58,
            StatusWeakened = 59,
            StatusCursed = 60,
            StatusDecoy = 61,
            StatusSnatch = 62,
            StatusGastroAcid = 63,
            StatusHealBlock = 64,
            StatusEmbargo = 65,
            StatusHungryPal = 66,
            StatusLeechSeed = 67,
            StatusDestinyBond = 68,
            StatusPoweredUp = 69,
            StatusSureShot = 70,
            StatusWhiffer = 71,
            StatusSetDamage = 72,
            StatusFocusEnergy = 73,
            StatusUnnamed0x4a = 74,
            StatusLongToss = 75,
            StatusPierce = 76,
            StatusUnnamed0x4d = 77,
            StatusInvisible = 78,
            StatusTransformed = 79,
            StatusMobile = 80,
            StatusSlip = 81,
            StatusUnnamed0x52 = 82,
            StatusBlinker = 83,
            StatusCrossEyed = 84,
            StatusEyedrops = 85,
            StatusDropeye = 86,
            StatusUnnamed0x57 = 87,
            StatusMuzzled = 88,
            StatusUnnamed0x59 = 89,
            StatusMiracleEye = 90,
            StatusUnnamed0x5b = 91,
            StatusMagnetRise = 92,
            StatusStockpiling = 93,
            StatusPowerEars = 94,
            StatusScanning = 95,
            StatusGrudge = 96,
            StatusExposed = 97,
            StatusTerrified = 98,
            StatusPerishSong = 99,
            StatusDoubledAttack = 100,
            StatusStairSpotter = 101,
        }
        public StatusId8(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusId8 p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _statusId8Value = ((StatusId8Enum) m_io.ReadBitsIntLe(8));
        }
        private StatusId8Enum _statusId8Value;
        private StatusId8 m_root;
        private KaitaiStruct m_parent;
        public StatusId8Enum StatusId8Value { get { return _statusId8Value; } }
        public StatusId8 M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
